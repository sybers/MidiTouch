using System;
using System.Windows.Forms;
using WacomMTDN;
using NAudio.Midi;
using System.Configuration;
using System.Diagnostics;

namespace MidiTouch
{
    public partial class MainForm : Form
    {

        /*these settings are hardcoded for the moment*/
        private bool skipEarlyFrames = true;
        private uint framesToSkip = 5;
        public WacomMTProcessingMode _processingMode = WacomMTProcessingMode.WMTProcessingModeObserver;

        public Configuration _conf = new Configuration();

        private FormPairing mFormPairing;
        public MidiTouchMessage[] mtouchMessages = new MidiTouchMessage[5];
        
        /*Fonctions Tablette*/
        public delegate void UpdateDelegate(ref WacomMTFingerCollection fingercollection);
        public UpdateDelegate mUpdateRealTimeLabel = null;
        private CWacomMTConfig mWacomMTConfig = new CWacomMTConfig();
        private WacomMTAttachCallback mAttachCallback;
        private WacomMTDetachCallback mDetachCallback;
        private WacomMTCallback mTouchDataCallback;

        private MidiOut mMidiOut;

        private string mUserDataStringReturned;


        #region Constructors

        public MainForm()
        {
            InitializeComponent();

            System.Reflection.AssemblyName AsName = System.Reflection.Assembly.GetExecutingAssembly().GetName();
            this.Text = AsName.Name + " - " + AsName.Version;

            //Ouverture du Midi par defaut
            mMidiOut = new MidiOut(0);
            //trouve les peripheriques Midi Out et remplit la liste
            PopulateMidiDevicesBox();

            try
            {
                _conf = new Configuration("Settings.xml");
                mtouchMessages = _conf.getConfig();
            }
            catch
            {
                MessageBox.Show("Configuration File not found, using default values...");
            }

        }
        #endregion

        #region Methods

        private void PopulateMidiDevicesBox()
        {
            string[] MidiDevices = new string[MidiOut.NumberOfDevices];

            for (int device = 0; device < MidiOut.NumberOfDevices; device++)
            {
                MidiDevices[device] = MidiOut.DeviceInfo(device).ProductName;
                comboBoxMidiOut.Items.Add(MidiDevices[device]);
            }

            comboBoxMidiOut.SelectedIndex = 0;
        }

        private void DoAttachWindowClientCallback(WacomMTCapability deviceCapability_I, IntPtr userData_I)
        {
            try
            {
                // This will add the device to our configuration only if not already added.
                mWacomMTConfig.AddDevice(deviceCapability_I);

                //MessageBox.Show("DeviceID: " + deviceCapability_I.DeviceID + " has attached");

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }

        private void DoDetachWindowClientCallback(Int32 deviceID_I, IntPtr userData_I)
        {
            try
            {
                mWacomMTConfig.RemoveDevice(deviceID_I);

                //MessageBox.Show("DeviceID: " + deviceID_I + " has detached");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }

        public UInt32 DoFingerDataUpdateCallback(IntPtr packet_I, IntPtr userData_I)
        {
            try
            {
                // Recover the finger collection sent back.
                WacomMTFingerCollection fingerCollection =
                    CMemUtils.PtrToStructure<WacomMTFingerCollection>(packet_I);

                // Recover the user data sent back.
                mUserDataStringReturned = CMemUtils.PtrToManagedString(userData_I);

                Invoke(mUpdateRealTimeLabel, fingerCollection);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }

            return 0;
        }

        private void DoUpdateGraphicsControl(ref WacomMTFingerCollection fingercollection)
        {
           tabletPointer1.PaintFingerTraces(fingercollection);
        }

        private void DoSendMidiMessage(ref WacomMTFingerCollection fingercollection)
        {
            //if we decided to skip early frames
            if (skipEarlyFrames && fingercollection.FrameNumber >= framesToSkip)
            {

                if (!TouchHelper.AllFingersUp(ref fingercollection) && fingercollection.FingerCount <= 5)
                {
                    //X value for messages
                    MidiFingerMessage fmX = mtouchMessages[fingercollection.FingerCount - 1].MessageX;
                    int val = (int)(((fingercollection.GetFingerByIndex(0).X * 10000) * fmX.MaxValue) / 10000) + fmX.MinValue;
                    SendMidiMessage(fmX.MidiCtrlr, val, fmX.MidiChannel);

                    //Y value for messages
                    MidiFingerMessage fmY = mtouchMessages[fingercollection.FingerCount - 1].MessageY;
                    val = (int)(fmY.MaxValue - (((fingercollection.GetFingerByIndex(0).Y * 10000) * fmY.MaxValue) / 10000) + fmY.MinValue);
                    SendMidiMessage(fmY.MidiCtrlr, val, fmY.MidiChannel);
                }
            }
            
        }

        public void SendMidiMessage(int Control, int Value, int Channel)
        {
            MidiMessage msg = MidiMessage.ChangeControl(Control, Value, Channel);
            mMidiOut.Send(msg.RawData);
        }

        private void UpdateLabelText()
        {
            string caps = mWacomMTConfig.GetDeviceCapsString(
                        mWacomMTConfig.GetAttachedDeviceID(0));
            labelDeviceInfo.Text = caps;
        }
        #endregion

        #region EventHandlers

        private void Form1_Load(object sender, EventArgs e)
        {
            WacomMTError status = WacomMTError.WMTErrorSuccess;

            IntPtr userDataBuf = IntPtr.Zero;
            try
            {
                mWacomMTConfig.Init();

                //Delegate called when events come to tablet
                mUpdateRealTimeLabel = new UpdateDelegate(this.DoUpdateGraphicsControl);
                mUpdateRealTimeLabel += this.DoSendMidiMessage;

                // crée un nouveau callback attach et abonne a ce callback
                mAttachCallback = new WacomMTAttachCallback(this.DoAttachWindowClientCallback);
                status = CWacomMTInterface.WacomMTRegisterAttachCallback(this.mAttachCallback, IntPtr.Zero);

                if (status != WacomMTError.WMTErrorSuccess)
                {
                    throw new Exception("Failed to register for device attaches - err: " + status.ToString());
                }

                // crée un nouveau callback detack et abonne a ce callback
                mDetachCallback = new WacomMTDetachCallback(this.DoDetachWindowClientCallback);
                status = CWacomMTInterface.WacomMTRegisterDetachCallback(this.mDetachCallback, IntPtr.Zero);

                if (status != WacomMTError.WMTErrorSuccess)
                {
                    throw new Exception("Failed to register for device detaches - err: " + status.ToString());
                }

                //crée un nouveau callback de type Finger Read et abonne a celui-ci
                WacomMTHitRect HR = new WacomMTHitRect(0, 0, 0, 0);
                mTouchDataCallback = new WacomMTCallback(this.DoFingerDataUpdateCallback);
                status = CWacomMTInterface.WacomMTRegisterFingerReadCallback(0, ref HR, _processingMode,
                    mTouchDataCallback, IntPtr.Zero);

                UpdateLabelText();

            }
            catch (Exception ex)
            {
                MessageBox.Show("Error : " + ex.ToString());
            }

        }

        private void Form1_Shown(object sender, EventArgs e)
        {

        }

        private void Form1_Resize(object sender, EventArgs e)
        {
            if (FormWindowState.Minimized == this.WindowState)
            {
                mNotifyicon.Visible = true;
                mNotifyicon.ShowBalloonTip(250);
                this.ShowInTaskbar = false;
            }

            else if (FormWindowState.Normal == this.WindowState)
            {
                mNotifyicon.Visible = false;
            }
        }

        private void Form1_FormClosed(object sender, FormClosedEventArgs e)
        {
            mWacomMTConfig.Quit();
        }

        private void comboBoxMidiOut_SelectedIndexChanged(object sender, EventArgs e)
        {
            mMidiOut.Close();

            mMidiOut = new MidiOut(comboBoxMidiOut.SelectedIndex);
        }

        private void buttonSendTestMidiMsg_Click(object sender, EventArgs e)
        {
            MidiMessage msg = MidiMessage.ChangeControl((int)UpDownCtrlr.Value, (int)UpDownValue.Value, (int)UpDownChannel.Value);
            mMidiOut.Send(msg.RawData);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            mFormPairing = new FormPairing(this, ref mtouchMessages);
            mFormPairing.Show();
        }

        private void mNotifyicon_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            this.WindowState = FormWindowState.Normal;
            this.ShowInTaskbar = true;

            mNotifyicon.Visible = false;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            UpdateLabelText();
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {
            
        }

        private void panel1_MouseClick(object sender, MouseEventArgs e)
        {
            Process.Start("http://www.github.com/Gramatiik");
        }
        #endregion
    }
}

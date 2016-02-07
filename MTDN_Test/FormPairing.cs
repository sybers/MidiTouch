using System;
using System.Windows.Forms;

namespace MidiTouch
{
    public partial class FormPairing : Form
    {
        //represents the parent of this form (must be MainForm class)
        private MainForm mParent;

        private MidiTouchMessage[] mTouchMessages;

        /*you need to pass parent as parameter, you cannot instantiate this form alone*/
        public FormPairing(MainForm Parent, ref MidiTouchMessage[] touchMessages)
        {
            InitializeComponent();
            mParent = Parent;
            mTouchMessages = touchMessages;

        }

        private void FormPairing_Shown(object sender, EventArgs e)
        {
            //opening this form disables its parent
            mParent.Enabled = false;
            numFingers.Value = 1;
        }

        /*closing this form re-enables its parent*/
        private void FormPairing_FormClosed(object sender, FormClosedEventArgs e)
        {
            mParent.Enabled = true;
        }

        /*Callback trigered when number of fingers numeric_up_down changed*/
        private void numFingers_ValueChanged(object sender, EventArgs e)
        {
            groupBoxFingers1.Text = "Setup " + numFingers.Value + " Finger(s) Controls on X Axis";
            groupBoxFingers2.Text = "Setup " + numFingers.Value + " Finger(s) Controls on Y Axis";
            LoadValuesForFinger();
        }

        /*callback trigered when Save button clicked*/
        private void BtnSave_Click(object sender, EventArgs e)
        {
            if(numMinValueX.Value >= numMaxValueX.Value || numMaxValueX.Value <= numMinValueX.Value
                || numMinValueY.Value >= numMaxValueY.Value || numMaxValueY.Value <= numMinValueY.Value)
            {
                MessageBox.Show("Minimum and maximum Values are not correct...", "Error", MessageBoxButtons.OK);
                numMinValueX.Value = numMinValueX.Minimum;
                numMaxValueX.Value = numMaxValueX.Maximum;
            }
            else
            {
                MidiFingerMessage fmX = mTouchMessages[(int)numFingers.Value - 1].MessageX;
                MidiFingerMessage fmY = mTouchMessages[(int)numFingers.Value - 1].MessageY;

                fmX.MidiCtrlr = (int)numCtrlMsgX.Value;
                fmX.MidiChannel = (int)numChannelX.Value;
                fmX.MinValue = (int)numMinValueX.Value;
                fmX.MaxValue = (int)numMaxValueX.Value;

                fmY.MidiCtrlr = (int)numCtrlMsgY.Value;
                fmY.MidiChannel = (int)numChannelY.Value;
                fmY.MinValue = (int)numMinValueY.Value;
                fmY.MaxValue = (int)numMaxValueY.Value;

                mTouchMessages[(int)numFingers.Value - 1].MessageX = fmX;
                mTouchMessages[(int)numFingers.Value - 1].MessageY = fmY;

                try
                {
                    mParent._conf.SaveConfiguration("Settings.xml", mTouchMessages);
                    MessageBox.Show("Configuration Saved !", "Success", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                }
                catch
                {
                    MessageBox.Show("Error while saving parameters...");
                }

                

            }
        }

        private void LoadValuesForFinger()
        {
            MidiFingerMessage fmX = mTouchMessages[(int)numFingers.Value - 1].MessageX;
            MidiFingerMessage fmY = mTouchMessages[(int)numFingers.Value - 1].MessageY;

            //updating current values in numeric boxes
            numCtrlMsgX.Value = fmX.MidiCtrlr;
            numChannelX.Value = fmX.MidiChannel;
            numMinValueX.Value = fmX.MinValue;
            numMaxValueX.Value = fmX.MaxValue;

            numCtrlMsgY.Value = fmY.MidiCtrlr;
            numChannelY.Value = fmY.MidiChannel;
            numMinValueY.Value = fmY.MinValue;
            numMaxValueY.Value = fmY.MaxValue;

        }

        private void FormPairing_Load(object sender, EventArgs e)
        {
            LoadValuesForFinger();
        }

        private void btnTestX_Click(object sender, EventArgs e)
        {
            mParent.SendMidiMessage((int)numCtrlMsgX.Value, 64, (int)numChannelX.Value);
        }

        private void btnTestY_Click(object sender, EventArgs e)
        {
            mParent.SendMidiMessage((int)numCtrlMsgY.Value, 64, (int)numChannelY.Value);
        }
    }
}

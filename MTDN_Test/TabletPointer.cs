using System.Drawing;
using System.Windows.Forms;
using WacomMTDN;
using System.ComponentModel;

namespace MidiTouch
{
    /*user control used to print the finger positions on forms*/
    public partial class TabletPointer : UserControl
    {
        private Graphics _gp;
        private Pen _pen;
        private WacomMTFingerCollection _fingerCollection;

        [Category("Apparence") Browsable(true) Description("Define the finger trace color")]
        public Color BrushColor
        {
            get
            {
                return _pen.Color;
            }
            set
            {
                _pen.Color = value;
            }
        }

        [Category("Apparence") Browsable(true) Description("Size of each Finger trace")]
        public int TraceSize { get; set; }

        [Category("Apparence") Browsable(true) Description("Drawing surface background color")]
        public Color DrawingSurfaceColor
        {
            get
            {
                return panel1.BackColor;
            }

            set
            {
                panel1.BackColor = value;
            }
        }

        public TabletPointer()
        {
            InitializeComponent();
            DoubleBuffered = true;
            _gp = panel1.CreateGraphics();
            _pen = new Pen(Color.Red);
        }

            
        public void PaintFingerTraces(WacomMTFingerCollection fingerCollection)
        {
            _fingerCollection = fingerCollection;
            if(this.Visible)
            {
                panel1.Invalidate();
            }
        }

        /*what to do when repainting the control*/
        private void panel1_Paint(object sender, PaintEventArgs e)
        {
            //if there is at least 1 and less than 5 fingers on tablet
            if( !TouchHelper.AllFingersUp(ref _fingerCollection) && _fingerCollection.FingerCount <= 5 )
            {
                for(uint i=0; i< _fingerCollection.FingerCount; i++)
                {
                    WacomMTFinger finger = _fingerCollection.GetFingerByIndex(i);
                    int xpos = (int)( ( (finger.X * 10000 + 1) * panel1.Width) / 10000);
                    int ypos = (int)( ( (finger.Y * 10000 + 1) * panel1.Height) / 10000);

                    _gp.DrawRectangle(_pen, xpos, ypos, TraceSize, TraceSize);
                    _gp.SmoothingMode = System.Drawing.Drawing2D.SmoothingMode.AntiAlias;
                }

                //display the actual frame number on control
                lblFrames.Text = _fingerCollection.FrameNumber.ToString();
            }
            else
            {
                lblFrames.Text = "";
            }
            
        }

        /*How to resize the control*/
        private void TabletPointer_Resize(object sender, System.EventArgs e)
        {
            Size temp = this.Size;
            temp.Height -= 37;
            temp.Width -= 5;
            panel1.Size = temp;
        }
    }
}

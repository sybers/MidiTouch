using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace MidiTouch
{
    public class Configuration
    {
        #region Properties

        MidiTouchMessage[] _fingerMessages = new MidiTouchMessage[5];
        #endregion

        #region Constructors
        public Configuration()
        {
        }

        public Configuration(string filepath)
        {
            for (int i = 0; i < _fingerMessages.Length; i++)
            {
                _fingerMessages[i].MessageX = new MidiFingerMessage() { MidiCtrlr = 0, MidiChannel = 0, MinValue = 0, MaxValue = 127 };
                _fingerMessages[i].MessageY = new MidiFingerMessage() { MidiCtrlr = 0, MidiChannel = 0, MinValue = 0, MaxValue = 127 };
            }

            LoadSettings(filepath);
        }
        #endregion

        #region Methods
        public void LoadSettings(string filepath)
        {
            try
            {
                XElement configuration = XElement.Load(filepath);

                for(int i=0; i<5; i++)
                {
                    XElement FingerElement = configuration.Element("Finger" + (i + 1));
                    _fingerMessages[i].MessageX.MidiCtrlr = ((int?)FingerElement.Element("XCntrl") ?? 0).ToInteger32();
                    _fingerMessages[i].MessageX.MidiChannel = ((int?)FingerElement.Element("XChannel") ?? 0).ToInteger32();
                    _fingerMessages[i].MessageX.MinValue = ((int?)FingerElement.Element("XMinVal") ?? 0).ToInteger32();
                    _fingerMessages[i].MessageX.MaxValue = ((int?)FingerElement.Element("XMaxVal") ?? 0).ToInteger32();

                    _fingerMessages[i].MessageY.MidiCtrlr = ((int?)FingerElement.Element("YCntrl") ?? 0).ToInteger32();
                    _fingerMessages[i].MessageY.MidiChannel = ((int?)FingerElement.Element("YChannel") ?? 0).ToInteger32();
                    _fingerMessages[i].MessageY.MinValue = ((int?)FingerElement.Element("YMinVal") ?? 0).ToInteger32();
                    _fingerMessages[i].MessageY.MaxValue = ((int?)FingerElement.Element("YMaxVal") ?? 0).ToInteger32();

                }
            }
            catch(Exception ex)
            {
                throw (ex);
            }
        }

        public void SaveConfiguration(string filepath, MidiTouchMessage[] fm)
        {
            try
            {
                _fingerMessages = fm;

                XElement configuration = new XElement("MidiTouchSettings");

                for (int i = 0; i < 5; i++)
                {
                    XElement finger = new XElement("Finger" + (i + 1));

                    finger.Add(new XElement("XCntrl", _fingerMessages[i].MessageX.MidiCtrlr.ToString() ),
                        new XElement("XChannel", _fingerMessages[i].MessageX.MidiChannel.ToString() ),
                        new XElement("XMinVal", _fingerMessages[i].MessageX.MinValue.ToString() ),
                        new XElement("XMaxVal", _fingerMessages[i].MessageX.MaxValue.ToString() ),
                        new XElement("YCntrl", _fingerMessages[i].MessageY.MidiCtrlr.ToString() ),
                        new XElement("YChannel", _fingerMessages[i].MessageY.MidiChannel.ToString() ),
                        new XElement("YMinVal", _fingerMessages[i].MessageY.MinValue.ToString() ),
                        new XElement("YMaxVal", _fingerMessages[i].MessageY.MaxValue.ToString()) );

                    configuration.Add(finger);
                }

                configuration.Save(filepath);
            }
            catch(Exception ex)
            {
                throw (ex);
            }
                
        }

        public MidiTouchMessage[] getConfig()
        {
            return _fingerMessages;
        }

        #endregion
    }
}

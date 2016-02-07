using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WacomMTDN;

namespace MidiTouch
{
    /* this file group all methods/structures/enums useful for touch features*/

    public struct MidiFingerMessage
    {
        public int MidiCtrlr;      //COntrol message sent to interface
        public int MidiChannel;    //channel to send message to
        public int MinValue;       //minimum value sent to midi interface
        public int MaxValue;       //maximum value sent to midi interface
    }

    public struct MidiTouchMessage
    {
        public MidiFingerMessage MessageX;
        public MidiFingerMessage MessageY;
    }
    
    static class TouchHelper
    {
        public static bool AllFingersUp(ref WacomMTFingerCollection fingercollection)
        {
            for(uint i=0; i< fingercollection.FingerCount; i++)
            {
                if(fingercollection.GetFingerByIndex(i).TouchState != WacomMTFingerState.WMTFingerStateUp)
                {
                    return false;
                }
            }
            return true;
        }
    }
}

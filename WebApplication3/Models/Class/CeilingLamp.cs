using System;
using System.Web;
using System.Web.Services;
using System.Web.Services.Protocols;
using System.ComponentModel;

namespace WebApplication3
{
    public class CeilingLamp : Technics , ICeilingLamp
    {
        private int brightnessLight;
        public CeilingLamp(string name, int brightnessLight, bool status):base(name, status)
        {
            this.brightnessLight = brightnessLight;
        }

        public int BrightUpLight
        {
            get
            {
                brightnessLight += 5;
                if (brightnessLight > 101) { brightnessLight = 100; }
                return brightnessLight;
            }
        }

        public int BrightDownLight
        {
            get
            {
                brightnessLight -= 5;
                if (brightnessLight < -1) { brightnessLight = 0; }
                return brightnessLight;
            }
        }

        public int GetBrightLight
        {
            get
            {
                return brightnessLight;
            }
            set
            {
                brightnessLight = value;
            }
        }

    }
}
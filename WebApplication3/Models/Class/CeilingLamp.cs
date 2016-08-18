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

        public int BrightLight
        {
            get
            {
                return brightnessLight;
            }
            set
            {
                if (value <= 0 && value <= 100)
                {
                    brightnessLight = value;
                }
            }
        }

        public void IncreaseBrightLight()
        {
            BrightLight+=5;
        }
        public void DecreasBrightLight()
        {
            BrightLight-=5;
        }

    }
}
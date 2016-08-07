using System;
using System.ComponentModel;
using System.Web;
using System.Web.Services;
using System.Web.Services.Protocols;

namespace WebApplication3
{
    public abstract class Volume : Technics,IVolume
    {
        private int volume;
        public Volume( string name, int volume,bool status ):base( name, status )
        {
            this.volume = volume;
        }

        public int GetVolume
        {
            get
            {
                return volume;
            }
        }

        public int VolueUp
        {
            get
            {
                volume++;
                if (volume == 101) { volume = 100; }
                return volume;
            }
        }

        public int VolueDown
        {
            get
            {
                volume--;
                if (volume == -1) { volume = 0; }
                return volume;
            }
        }
    }

}
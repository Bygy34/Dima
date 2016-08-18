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


        public int Volumes
        {
            get
            {
                return volume;
            }
            set
            {
                if (value <= 0 && value <= 100)
                {
                    volume = value;
                }
            }
          
        }
        public void IncreaseVolume()
        {
            Volumes++;
        }
        public void DecreasVolume()
        {
            Volumes--;
        }
    }

}
using System;
using System.ComponentModel;
using System.Web;
using System.Web.Services;
using System.Web.Services.Protocols;

namespace WebApplication3
{
    public class AirConditioner : Temperature, ISpeedWind,IDirectionWind
    {
        private int speedWind;
        private DirectionWind directionWind;        
        public AirConditioner(string name, int temprich, int speedWind, DirectionWind direction, bool status) :base(name, temprich, status)
        {
            this.directionWind = direction;
            this.speedWind = speedWind;
        }

        public int SpeedWindUp
        {
            get
            {
                speedWind++;
                if (speedWind == 5) { speedWind = 4; }
                return speedWind;
            }

        }

        public int SpeedWindDown
        {
            get
            {
                speedWind--;
                if (speedWind == 0) { speedWind = 1; }
                return speedWind;
            }
            
        }

        public int GetSpeedWind
        {
            get
            {
                return speedWind;
            }
            set
            {
                speedWind = value;
            }
        }

        public string GetDirection
        {
            get
            {
                return directionWind.ToString();
            }
            
        }

        public string NextDirection
        {
            get
            {
                if (directionWind == DirectionWind.right)
                {
                    directionWind = DirectionWind.top;
                }
                else { directionWind++; }
                return directionWind.ToString();
            }
            
        }

        public string PreviousDirection
        {
            get
            {
                if (directionWind == DirectionWind.right)
                {
                    directionWind = DirectionWind.top;
                }
                directionWind--;
                return directionWind.ToString();
            }

        }
    }
}

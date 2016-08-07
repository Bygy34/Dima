using System;
using System.ComponentModel;
using System.Web;
using System.Web.Services;
using System.Web.Services.Protocols;

namespace WebApplication3
{
    public class TV : Volume, IChanel
    {
        public Chanel directionChanel;

        public TV(string name, int volume, Chanel chanel, bool status) : base(name, volume, status)
        {
            directionChanel = chanel;
        }

        public string GetChanel
        {
            get
            {
                return directionChanel.ToString();
            }
        }

        public string NextChanel
        {
            get
            {
                if (directionChanel == Chanel.inter)
                { directionChanel = Chanel.estv; }
                else { directionChanel++; }
                return directionChanel.ToString();
            }
        }


        public string PreviousChanel
        {
            get
            {
                if (directionChanel == Chanel.estv)
                { directionChanel = Chanel.inter; }
                else { directionChanel--; }
                return directionChanel.ToString();
            }
        }
    }
}
using System;
using System.ComponentModel;
using System.Web;
using System.Web.Services;
using System.Web.Services.Protocols;
using WebApplication3;

namespace WebApplication3
{
    public class TV : Volume, IChanel
    {
        public Chanels directionChanel;

        public TV(string name, int volume, Chanels chanel, bool status) : base(name, volume, status)
        {
            directionChanel = chanel;
        }

        public string Chanel
        {
            get
            {
                return directionChanel.ToString();
            }

        }

        public void NextChanel()
        {
                if (directionChanel == Chanels.inter)
                { directionChanel = Chanels.estv; }
                else { directionChanel++; }
        }


        public void PreviousChanel()
        {
                if (directionChanel == Chanels.estv)
                { directionChanel = Chanels.inter; }
                else { directionChanel--; }
        }
    }
}
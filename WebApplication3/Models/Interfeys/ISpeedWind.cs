using System;
using System.Web;
using System.Web.Services;
using System.Web.Services.Protocols;
using System.ComponentModel;

namespace WebApplication3
{
    public interface ISpeedWind
    {
        int SpeedWind { get; set; }
        void IncreaseSpeedWind();
        void DecreasSpeedWind();
    }
}
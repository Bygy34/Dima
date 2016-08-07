using System;
using System.Web;
using System.Web.Services;
using System.Web.Services.Protocols;
using System.ComponentModel;

namespace WebApplication3
{
    public interface ISpeedWind
    {
        int GetSpeedWind { get; set; }
        int SpeedWindUp { get; }
        int SpeedWindDown { get; }
    }
}
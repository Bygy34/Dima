using System;
using System.Web;
using System.Web.Services;
using System.Web.Services.Protocols;
using System.ComponentModel;

namespace WebApplication3
{
    public interface ICeilingLamp
    {
        int BrightLight { get; set; }
        void IncreaseBrightLight();
        void DecreasBrightLight();
    }
}
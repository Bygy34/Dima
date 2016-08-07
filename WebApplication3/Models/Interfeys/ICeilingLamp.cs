using System;
using System.Web;
using System.Web.Services;
using System.Web.Services.Protocols;
using System.ComponentModel;

namespace WebApplication3
{
    public interface ICeilingLamp
    {
        int GetBrightLight { get; set; }
        int BrightUpLight { get; }
        int BrightDownLight { get; }
    }
}
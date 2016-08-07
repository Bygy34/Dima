using System;
using System.Web;
using System.Web.Services;
using System.Web.Services.Protocols;
using System.ComponentModel;

namespace WebApplication3
{
    public interface IVolume
    {
        int GetVolume { get; }
        int VolueUp { get; }
        int VolueDown { get; }
    }
}
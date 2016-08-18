using System;
using System.Web;
using System.Web.Services;
using System.Web.Services.Protocols;
using System.ComponentModel;

namespace WebApplication3
{
    public interface IVolume
    {
        void IncreaseVolume();
        void DecreasVolume();
        int Volumes { get; set; }
    }
}
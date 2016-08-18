using System;
using System.Web;
using System.Web.Services;
using System.Web.Services.Protocols;
using System.ComponentModel;

namespace WebApplication3
{
    public interface IChanel
    {
        string Chanel { get; }
        void NextChanel();
        void PreviousChanel();
    }
}
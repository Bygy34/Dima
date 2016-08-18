using System;
using System.Web;
using System.Web.Services;
using System.Web.Services.Protocols;
using System.ComponentModel;

namespace WebApplication3
{
    public interface IDirectionWind
    {
        string DirectionWind { get; }
        void NextDirectionWind();
        void PreviousDirectionWind();
    }
}
using System;
using System.Web;
using System.Web.Services;
using System.Web.Services.Protocols;
using System.ComponentModel;

namespace WebApplication3
{
    public interface IDirectionWind
    {
        string GetDirection { get; }
        string NextDirection { get; }
        string PreviousDirection { get; }
    }
}
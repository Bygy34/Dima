using System;
using System.Web;
using System.Web.Services;
using System.Web.Services.Protocols;
using System.ComponentModel;

namespace WebApplication3
{
    public interface IChanel
    {
        string GetChanel { get; }
        string NextChanel { get; }
        string PreviousChanel { get; }
    }
}
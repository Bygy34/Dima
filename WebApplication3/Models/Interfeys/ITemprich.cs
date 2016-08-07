using System;
using System.Web;
using System.Web.Services;
using System.Web.Services.Protocols;
using System.ComponentModel;

namespace WebApplication3
{
    public interface ITemprich
    {
        int GetTempriche { get; set; }
        int TempricheUp { get; }
        int TempricheDown { get; }
    }
}
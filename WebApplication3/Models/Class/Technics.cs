using System;
using System.Web;
using System.Web.Services;
using System.Web.Services.Protocols;
using System.ComponentModel;

namespace WebApplication3
{
    public abstract class Technics
    {
        private bool technicalStatus;
        public bool status
        {
            get
            {
                return technicalStatus;
            }
            set
            {
                technicalStatus = value;
            }
        }

        public Technics(string name, bool status)
        {
            Name = name;
            technicalStatus = status;
        }
        public string Name { get; set; }

    }
}
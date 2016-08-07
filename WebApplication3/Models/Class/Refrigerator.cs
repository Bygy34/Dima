using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace WebApplication3.Models
{
    public class Refrigerator : Temperature, IBright
    {

        int bright;
        public Refrigerator(string name, int temprich, bool status, int bright) : base(name, temprich, status)
        {
            this.bright = bright;
        }

        public int BrightUp
        {
            get
            {
                bright += 5;
                return bright;
            }
        }

        public int BrightDown
        {
            get
            {
                bright -= 5;
                return bright;
            }
        }

        public int GetBright
        {
            get
            {
                return bright;
            }
            set
            {
                bright = value;
            }
        }
    }
}

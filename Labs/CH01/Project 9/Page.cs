using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project_9
{
    public class Page : ITurnable 
    {
        public string Turn()
        {
            return "Page - grab any page and take it left or right";
        }
    }
}

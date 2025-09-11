using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project_9
{
    public class Corner : ITurnable
    {
        public string Turn()
        {
            return "Corner - walk to edge of corner and turn 90 degrees";
        }
    }
}

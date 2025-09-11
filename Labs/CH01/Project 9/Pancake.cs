using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project_9
{
    public class Pancake : ITurnable
    {
        public string Turn()
        {
            return "Pancake - flip and turn the spatula";
        }
    }
}

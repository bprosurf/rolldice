using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace rolldice
{
    class Class1
    {
        // Method to simulate rolling a single die
        static int RollDie()
        {
            Random random = new Random();
            return random.Next(1, 7);
        }

    }
}

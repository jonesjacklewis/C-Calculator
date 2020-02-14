using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApplication1
{
    class Factorial
    {
        public static int Fact(int n)  // Recursive factorial
        {
            if (n <= 1)
            {
                return 1;
            }
            else
            {
                return n * Fact(n - 1);
            }
        }
    }

   
}

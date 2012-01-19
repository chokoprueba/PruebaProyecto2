using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ConsoleApplication1
{
    class Class1
    {
        
        public Class1() {
         
        }

        

        public Boolean esPar(int n) {

            int s = 0;
            s = n % 2;
            if (s == 0)
            {
                return true;
            }
            else { return false; }
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ConsoleApplication1
{
    class Program
    {
        static void Main(string[] args)
        {
            int a = 2;
            String s = "";
            Console.WriteLine("ESCRIBA Y PARA CONTINUAR");
            Class1 c = new Class1();
            if (c.esPar(a) == true) { Console.WriteLine("ES PAR"); }
            else{Console.WriteLine("NO ES PAR");}

            do
            {
                s = Console.ReadLine();
                if (s.Equals("y") == false) { Console.WriteLine("ERROR"); }
            }
            while (s.Equals("y") == false);
            
            
        }
    }
}

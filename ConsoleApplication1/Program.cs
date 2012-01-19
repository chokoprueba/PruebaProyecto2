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
            String s = "";
            Console.WriteLine("ESCRIBA Y PARA CONTINUAR");
            do
            {
                s = Console.ReadLine();
                if (s.Equals("y") == false) { Console.WriteLine("ERROR"); }
            }
            while (s.Equals("y") == false);
            
            
        }
    }
}

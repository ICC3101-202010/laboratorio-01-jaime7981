using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Laboratorio1
{
    class Program
    {
        static void Main(string[] args)
        {
            Player p1 = new Player("Bob", "Kunga");
            for (int i=0; i < 1; ++i) { 
            p1.Trhow();
            }

            Console.ReadLine();
        }
    }
}

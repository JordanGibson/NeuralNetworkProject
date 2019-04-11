using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BlackjackConsole
{
    class Program
    {
        static void Main(string[] args)
        {
            Player player = new Player();
            while (true)
            {
                Console.WriteLine(player.Hand.ToString());
                Console.WriteLine(player.Hand.GetHandTotal());
                Console.ReadLine();
                player.Hit();
            }
        }
    }
}

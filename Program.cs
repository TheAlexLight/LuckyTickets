using _6.LuckyTickets.Controller;
using _6.LuckyTickets.Logic;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _6.LuckyTickets
{
    class Program
    {
        static void Main(string[] args)
        {
            if (args.Length == 3)
            {
                LuckyTicketController ticketController = new LuckyTicketController();
                ticketController.ChooseTicketMode(args[0], args[1], args[2]);
            }

            Console.ReadKey();
        }
    }
}

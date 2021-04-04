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
            MoscowLuckyTicket moscowTicket = new MoscowLuckyTicket();

            Stopwatch stopwatch = new Stopwatch();

            stopwatch.Start();
            int count = moscowTicket.GetTicketsCount(0, 50000000);
            stopwatch.Stop();

            Console.WriteLine("Время выполнения: " + stopwatch.Elapsed.TotalMilliseconds);
            Console.WriteLine(count);

            Console.ReadKey();
        }
    }
}

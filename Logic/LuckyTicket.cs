using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _6.LuckyTickets
{
    public abstract class LuckyTicket
    {
        protected int amount = 0;
        protected int numbersInTicket;

        public abstract int GetTicketsCount(int startRange, int finishRange);
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _6.LuckyTickets.Logic
{
    class PiterLuckyTicket : LuckyTicket
    {
        public override int GetTicketsCount(int startRange, int finishRange)
        {
            for (int i = startRange; i <= finishRange; i++)
            {
                int evenNumberSumCount = 0;
                int oddNumberSumCount = 0;

                int currentNumber = i;

                for (int j = 0; j < numbersInTicket; j++)
                {
                    if (currentNumber % 10 % 2 == 0)
                    {
                        evenNumberSumCount += currentNumber % 10;
                    }
                    else
                    {
                        oddNumberSumCount += currentNumber % 10;
                    }

                    currentNumber /= 10;
                }

                if (evenNumberSumCount == oddNumberSumCount)
                {
                    amount++;
                }
            }

            return amount;
        }
    }
}

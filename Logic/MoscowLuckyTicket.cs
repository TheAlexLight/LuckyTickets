using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _6.LuckyTickets.Logic
{
    class MoscowLuckyTicket : LuckyTicket
    {
        public override int GetTicketsCount(int startRange, int finishRange)
        {
            numbersInTicket = 6;
            amount = 0;

            for (int i = startRange; i <= finishRange; i++)
            {

                int leftNumberSide = i / ((int)Math.Pow(10, numbersInTicket / 2));
                int rightSumCount = 0;
                int leftSumCount = 0;

                int rightNumberSide = i;

                for (int j = 0; j < numbersInTicket / 2; j++)
                {
                    rightSumCount += rightNumberSide % 10;
                    leftSumCount += leftNumberSide % 10;

                    rightNumberSide /= 10;
                    leftNumberSide /= 10;
                }

                if (rightSumCount == leftSumCount)
                {
                    amount++;
                }
            }

            return amount;
        }
    }
}

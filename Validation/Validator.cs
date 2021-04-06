using _6.LuckyTickets.View;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _6.LuckyTickets.Validation
{
    class Validator
    {
        public bool CheckIntOnPositive(int intToCheck)
        {
            return (intToCheck >= 0 && intToCheck < Constant.MAX_TICKET_BORDER);
        }

        public bool HighestBorderGreater(int lowestBorder, int highestBorder)
        {
            return highestBorder > lowestBorder;
        }
    }
}

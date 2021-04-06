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
        public bool CheckStringLength(string checkedString)
        {
            bool result = false;

            if (!(checkedString == null || checkedString.Length <= 0 || checkedString.Length > Constant.MAX_STRING_LENGTH))
            {
                result = true;
            }

            return result;
        }

        public bool CheckIntOnPositive(int intToCheck)
        {
            return (intToCheck >= 0 && intToCheck < Constant.MAX_TICKET_BORDER);
        }
    }
}

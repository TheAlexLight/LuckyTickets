using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _6.LuckyTickets.View
{
    class Constant
    {
        public const int MAX_STRING_LENGTH = 50;
        public const int MAX_TICKET_BORDER = 1000000;

        public const string EXCEPTION_OCCURED = "ERROR occured";
        public const string MODE = "Mode";
        public const string WRONG_STRING = "Wrong {0}";
        public const string INSTRUCTION = "Instruction of using: You should use 3 arguments::";
        public const string FIRST_ARGUMENT =@"1 argument - choose your mode(""Moscow"" or ""PITER""): Type - string";
        public const string SECOND_ARGUMENT = "2 argument - Lower range of count: Type - integer";
        public const string THIRD_ARGUMENT = "3 argument - Higher range of count: Type - integer";
        public const string MOSCOW = "MOSCOW";
        public const string PITER = "PITER";
        public const string WRONG_BOUNDARIES = "Wrong number boundaries, try again";
        public const string INT_WRONG_TYPE = "Type of data should be integer, try again";
        public const string LOWER_BOUND = "Lower bound";
        public const string HIGHER_BOUND = "Higher bound";
        public const string TICKET_AMOUNT = "Ticket amount = {0}";
        public const string WRONG_MODE = "Wrong mode. Mode should be Moscow or Piter";

    }
}

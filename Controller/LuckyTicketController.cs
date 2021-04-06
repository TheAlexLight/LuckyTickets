using _6.LuckyTickets.Logic;
using _6.LuckyTickets.Validation;
using _6.LuckyTickets.View;
using ConsoleTaskLibrary;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _6.LuckyTickets.Controller
{
    class LuckyTicketController
    {
        readonly ConsolePrinter _printer = new ConsolePrinter();
        readonly Validator _validData = new Validator();

        public void ChooseTicketMode(string modeName, string lowestBorder, string highestBorder)
        {
            try
            {
                int lowestBound = CheckStartNumbers(lowestBorder);
                int highestBound = CheckStartNumbers(highestBorder);

                int ticketCount = 0;

                if (!_validData.HighestBorderGreater(lowestBound,highestBound))
                {
                    _printer.WriteLine(Constant.HIGHEST_BORDER_SHOULD_BE_GREATER);
                    _printer.ShowInstruction(Constant.INSTRUCTION, Constant.FIRST_ARGUMENT, Constant.SECOND_ARGUMENT, Constant.THIRD_ARGUMENT);
                    Environment.Exit(-1);
                }

                LuckyTicket ticket = null;

                if (modeName.ToUpper().Equals(Constant.MOSCOW))
                {
                    ticket = new MoscowLuckyTicket();
                    
                }
                else if (modeName.ToUpper().Equals(Constant.PITER))
                {
                    ticket = new PiterLuckyTicket();
                }
                else
                {
                    _printer.WriteLine(Constant.WRONG_MODE);
                    _printer.ShowInstruction(Constant.INSTRUCTION, Constant.FIRST_ARGUMENT, Constant.SECOND_ARGUMENT, Constant.THIRD_ARGUMENT);
                    Environment.Exit(-1);
                }

                ticketCount = ticket.GetTicketsCount(lowestBound, highestBound);

                _printer.WriteLine(string.Format(Constant.TICKET_AMOUNT, ticketCount));

            }
            catch (ArgumentException ex)
            {
                _printer.WriteLine(string.Format(Constant.EXCEPTION_OCCURED, ex.Message));
                throw;
            }
        }

        public int CheckStartNumbers(string checkedNumber)
        {
            Converter converterArgs = new Converter();

            int result = converterArgs.TryParseToInt(checkedNumber);

            if (result != -1)
            {
                if (!_validData.CheckIntOnPositive(result))
                {
                    _printer.WriteLine(Constant.WRONG_BOUNDARIES); 
                    _printer.ShowInstruction(Constant.INSTRUCTION, Constant.FIRST_ARGUMENT, Constant.SECOND_ARGUMENT, Constant.THIRD_ARGUMENT);
                    Environment.Exit(-1);
                }
            }
            else
            {
                _printer.WriteLine(Constant.INT_WRONG_TYPE); 
                _printer.ShowInstruction(Constant.INSTRUCTION, Constant.FIRST_ARGUMENT, Constant.SECOND_ARGUMENT, Constant.THIRD_ARGUMENT);
                Environment.Exit(-1);
            }

            return result;
        }

    }
}

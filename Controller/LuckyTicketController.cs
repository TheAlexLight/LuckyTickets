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
        ConsolePrinter _printer = new ConsolePrinter();
        Validator _validData = new Validator();

        public void ChooseTicketMode(string modeName, string startRange, string finishRange)
        {
            try
            {
                modeName = CheckStartString(modeName, Constant.MODE);

                int lowerBound = CheckStartNumbers(startRange, Constant.LOWER_BOUND);
                int higherBound = CheckStartNumbers(finishRange, Constant.HIGHER_BOUND);

                int ticketCount = 0;

                if (true)//TODO add border comparison)
                {

                }

                if (modeName.ToUpper().Equals(Constant.MOSCOW))
                {
                    MoscowLuckyTicket moscowTicket = new MoscowLuckyTicket();
                    ticketCount= moscowTicket.GetTicketsCount(lowerBound, higherBound);
                }
                else if (modeName.ToUpper().Equals(Constant.PITER))
                {
                    PiterLuckyTicket piterTicket = new PiterLuckyTicket();
                    ticketCount = piterTicket.GetTicketsCount(lowerBound,higherBound);
                }
                else
                {
                    _printer.WriteLine(Constant.WRONG_MODE);
                    _printer.ShowInstruction(Constant.INSTRUCTION, Constant.FIRST_ARGUMENT, Constant.SECOND_ARGUMENT, Constant.THIRD_ARGUMENT);
                    Environment.Exit(-1);
                }

                _printer.WriteLine(string.Format(Constant.TICKET_AMOUNT, ticketCount));

            }
            catch (ArgumentException ex)
            {
                _printer.WriteLine(string.Format(Constant.EXCEPTION_OCCURED, ex.Message));
                throw;
            }
        }

        public string CheckStartString(string checkedString, string checkedStringName)
        {
            if (!_validData.CheckStringLength(checkedString))
            {
                _printer.WriteLine(string.Format(Constant.WRONG_STRING, checkedStringName));
                _printer.ShowInstruction(Constant.INSTRUCTION, Constant.FIRST_ARGUMENT, Constant.SECOND_ARGUMENT, Constant.THIRD_ARGUMENT);
                Environment.Exit(-1);
            }

            return checkedString;
        }

        public int CheckStartNumbers(string checkedNumber, string checkedStringName)
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

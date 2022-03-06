using StudentSystem.Infrastructure;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StudentSystem.Managers
{
    public static class ScannerManager
    {
        public static int ReadInteger(string caption)
        {
        l1:
            Console.WriteLine(caption);
            Console.ForegroundColor = ConsoleColor.DarkGreen;

            if (!int.TryParse(Console.ReadLine(),out int value))
            {
                PrintError("duzgun melumat deyil, yeniden cehd edin");
                goto l1;
            }
            Console.ResetColor();
            return value;
        }
        public static double ReadDouble(string caption)
        {
        l1:
            Console.WriteLine(caption);
            Console.ForegroundColor = ConsoleColor.DarkGreen;

            
            if (!double.TryParse(Console.ReadLine(), out double value))
            {
                PrintError("duzgun melumat deyil, yeniden cehd edin");
                goto l1;
            }
            Console.ResetColor();
            return value;
        }
        public static string ReadString(string caption)
        {
        l1:
           

            Console.Write(caption);
            Console.ForegroundColor = ConsoleColor.DarkGreen;

            string value = Console.ReadLine();
            if (string.IsNullOrWhiteSpace(value))
            {
                PrintError("duzgun melumat deyil, yeniden cehd edin");
                goto l1;
            }
            Console.ResetColor();
            return value;
        }
        public static void PrintError(string message)
        {
            Console.ForegroundColor = ConsoleColor.DarkRed;
            Console.WriteLine(message);
            Console.ResetColor();
        }
        public static DateTime ReadDate(string caption)
        {
        l1:
            
            Console.Write($"{caption} [dd.MM.yyyy]:  ");
            Console.ForegroundColor = ConsoleColor.DarkGreen;

            if (!DateTime.TryParseExact(Console.ReadLine(),"dd.MM.yyyy",null,System.Globalization.DateTimeStyles.None, out DateTime value))
             { 
                PrintError("duzgun melumat deyil, yeniden cehd edin");
                goto l1;
            }
            Console.ResetColor();
            return value;
        }
        public static Menu ReadMenu(string caption)
        {
        l1:
      
            Console.Write(caption);
            Console.ForegroundColor = ConsoleColor.DarkGreen;

            if (!Enum.TryParse(Console.ReadLine(), out Menu m))
            {
                PrintError("menudan secmediz , yeniden secin.");
                goto l1;
            }
            Console.ResetColor();
            return m;
        }

    }
}

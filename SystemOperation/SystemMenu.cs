using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IDF_Operation__First_Strike.SystemOperation
{
    internal class SystemMenu
    {
        public static int OptionsPanelMenu() // תתפריט הפעלת המערכת
        {
            int choise;
            do
            {
                Console.WriteLine(
    @"  ===  main menu ===
    1. Intel Analysis
    2. Strike Availability
    3. Target Prioritization
    4. Strike Execution
    5.  Logout
    choose an option  (1-5): ");
                choise = int.Parse(Console.ReadLine());
                if(choise < 1 || choise > 5)
                {
                    Console.ForegroundColor = ConsoleColor.Red;  // צובע את האזהרה באדום
                    Console.WriteLine("Error: Choose an appropriate number from the options given to you.");
                    Console.ResetColor(); // מחזיר לצבע ברירת המחדל

                }
            }
            while (choise < 1 || choise > 5);


            return choise;
        }
    }
}

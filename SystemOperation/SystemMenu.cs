using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IDF_Operation__First_Strike.SystemOperation
{
    internal class SystemMenu
    {
        public int OptionsPanelMenu()
        {
            int choise;
            do
            {
                Console.WriteLine(
    @"  === תפריט ראשי ===
    1. Intel Analysis
    2. Strike Availability
    3. Target Prioritization
    4. Strike Execution
    5.  Logout
    בחר אופציה (1-5): ");
                choise = int.Parse(Console.ReadLine());
            }
            while (choise < 1 || choise > 5);


            return choise;
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using IDF_Operation__First_Strike.Idf.arsenal;

namespace IDF_Operation__First_Strike
{
    internal class ReturningDataFromWeaponsDB
    {
        // מחזירה בהדפסה את  כל  כלי הנשק  הזמינים
        public static void GetWeaponInformationFromTheDB(WeaponsDatabase WeaponsStorageObject = null) 
        {
            var arsenal = WeaponsStorageObject.GetTheWeponDB();
            Console.WriteLine($"You have {arsenal.Count} types of weapons.");

            foreach (var itam in arsenal) // ריצה בלולאה על המילון
            {
                Console.ForegroundColor = ConsoleColor.Blue;
                Console.Write($"and cuurent available tool {itam.Key} - ");
                Console.ResetColor();
                Console.WriteLine($"And you have {itam.Value.Count} such tools");


                foreach (var wepon in itam.Value) // ריצה בתוך הרשימה שהיא הערך  במילון
                {
                    Console.WriteLine($"The tool {wepon.NameOfTheWeapon} has {wepon.NumberOfAttacke} attacks left.");
                }

            }
        }
    }
}

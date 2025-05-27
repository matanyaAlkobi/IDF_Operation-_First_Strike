using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Policy;
using System.Text;
using System.Threading.Tasks;
using IDF_Operation__First_Strike.Idf.arsenal;

namespace IDF_Operation__First_Strike.SystemOperation
{
    internal class OperatingTheSystemAsSelected
    {
        public static void OperatingTheSystem(int num, WeaponsDatabase WeaponsStorageObject)
        {
            switch (num)
                {
                case 1:
                    Console.WriteLine("");
                    break;

                case 2:  // צריך להפעיל סדר  פעולות  שיחזיר איזה יחידות  פנויות וכמה תקיפות נשאר
                    ReturningDataFromWeaponsDB.GetWeaponInformationFromTheDB(WeaponsStorageObject);
                    break;

                case 3:
                    Console.WriteLine("");
                    break;

                case 4:
                    AttackSystem Attack = new AttackSystem();

                    break;
                }
            } 
        }
}

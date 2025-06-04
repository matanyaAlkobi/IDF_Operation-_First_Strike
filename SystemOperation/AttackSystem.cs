using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using IDF_Operation__First_Strike.Idf.AMAN;
using IDF_Operation__First_Strike.Idf.arsenal;

namespace IDF_Operation__First_Strike.SystemOperation
{
    internal class AttackSystem
    {


        private List<InformationCollection> DBFromAman = new List<InformationCollection>();
        public void AttackMenu()
        {

        }

        public void AttackOperation(WeaponsDatabase WeaponsStorageObject,AmanDB info)
        {
            ReturningDataFromWeaponsDB.GetWeaponInformationFromTheDB();
            
            Console.WriteLine("Choose the nickname of the weapon to use it. ");

            Console.WriteLine("The target has been destroyed.");
        }

        private void SearchForWeaponsByLocation(AmanDB info)
        {
            DBFromAman = info.ReceivingADatabaseOfTerrorists();
            List<StrikeWeapon> ListOfWeapon = new List<StrikeWeapon>(); // יצירת רשימה שתחזיק את  כל הנשקים הזמינים  לפי  תקיפה
            foreach (var item in DBFromAman)

            {

            }

        }
    }
}

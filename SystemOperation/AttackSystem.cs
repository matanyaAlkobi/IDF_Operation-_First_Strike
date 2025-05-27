using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IDF_Operation__First_Strike.SystemOperation
{
    internal class AttackSystem
    {

        public void AttackMenu()
        {

        }

        public void AttackOperation()
        {
            ReturningDataFromWeaponsDB.GetWeaponInformationFromTheDB();
            Console.WriteLine("Enter the weapon category.  ");
            string choise = Console.ReadLine();



            Console.WriteLine("Choose the nickname of the weapon to use it. ");

            Console.WriteLine("The target has been destroyed.");
        }

        private void SearchForWeaponsByLocation()
        {

        }
    }
}

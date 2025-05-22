using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IDF_Operation__First_Strike.Idf.arsenal
{
    internal class WeaponsDatabase
    {

        public Dictionary<string, List<StrikeWeapon>> weponToolDatabase = new Dictionary<string, List<StrikeWeapon>>();
        
         public void AddingWeaponsToTheDatabase(StrikeWeapon WeponObject)
        {
            if(!weponToolDatabase.ContainsKey(WeponObject.TypeOfWeapon))
            {
                weponToolDatabase[WeponObject.TypeOfWeapon] = new List<StrikeWeapon>();
            }
            weponToolDatabase[WeponObject.TypeOfWeapon].Add(WeponObject);
            Console.WriteLine("The weapon has been added to the database.");
        }
    }
}

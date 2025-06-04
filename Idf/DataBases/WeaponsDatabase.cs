using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using IDF_Operation__First_Strike.Idf.AMAN;

namespace IDF_Operation__First_Strike.Idf.arsenal
{
    internal class WeaponsDatabase
    {

        private static WeaponsDatabase _instance = null;

        private Dictionary<string, List<StrikeWeapon>> weponToolDatabase = new Dictionary<string, List<StrikeWeapon>>();

        private WeaponsDatabase() { }

        public static WeaponsDatabase GetInstance()
        {
            if (_instance == null)
            {
                _instance = new WeaponsDatabase();
            }
            return _instance;
        }

        public void AddingWeaponsToTheDatabase(StrikeWeapon WeponObject)
        {
            if(!weponToolDatabase.ContainsKey(WeponObject.TypeOfWeapon))
            {
                weponToolDatabase[WeponObject.TypeOfWeapon] = new List<StrikeWeapon>();
            }
            weponToolDatabase[WeponObject.TypeOfWeapon].Add(WeponObject);
            Console.WriteLine("The weapon has been added to the database.");
        }

        public Dictionary<string, List<StrikeWeapon>>  GetTheWeponDB()
        {
            return weponToolDatabase;
        }
        
    }
}

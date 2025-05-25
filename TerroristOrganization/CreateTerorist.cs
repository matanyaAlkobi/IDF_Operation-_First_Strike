using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IDF_Operation__First_Strike
{
    internal class CreateTerorist : Terrorist
    {
        public override string TerroristName { get; set; }
        public override int TerroristRank { get; set; }
        public override string Weapons { get; set; }
        public override string Status { get; set; }

        public int Rank()                                                               // דרגה רנדומלית
        {
            Random random = new Random();
            int num = random.Next(1, 6);
            //Console.WriteLine(num);
            return num;
        }
        public string[] Weapon()                                                   // חבילת נשקים רנדומלית למחבל  
        {
            List<string> weapons = new List<string> { "AK-47", "M-16", "Pistol", "knife" };

            Random random = new Random();
            int times = random.Next(1, 5);

            string[] WeaponsForTerrorist = new string[times];
            Random randWeapon = new Random();
            for (int i = 0; i < times; i++)
            {
                int index = randWeapon.Next(weapons.Count);
                //Console.WriteLine(weapons[i]);
                WeaponsForTerrorist[i] = weapons[index];
            }
            return WeaponsForTerrorist;
        }
        public string SetStatus(string set = "Life")                              // "סטטוס חיים למחבל "ברירת מחדל" = "ח
        {
            return set;
        }
        public CreateTerorist(string name)                                           // (שם המחבל (קומסטרקטור
        {
            TerroristName = name;
        }

        public void ManagingCreationTerrorist(string name)
        {
            Dictionary<string, string> TerroristInformation = new Dictionary<string ,string>();
            TerroristInformation["getInfro"] = "setInfro";

            CreateTerorist terorist = new CreateTerorist(name);

        }
    }
}

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

        private static Random random = new Random();
        public int Rank()                                                               // דרגה רנדומלית
        {
            //Random random = new Random();
            int num = random.Next(1, 6);
            //Console.WriteLine(num);
            TerroristRank = num;
            return num;
        }
        public string[] Weapon()                                                   // חבילת נשקים רנדומלית למחבל  
        {
            List<string> weapons = new List<string> { "AK-47", "M-16", "Pistol", "knife" };

            int times = random.Next(1, 5);

            string[] WeaponsForTerrorist = new string[times];
            for (int i = 0; i < times; i++)
            {
                int index = random.Next(weapons.Count);
                WeaponsForTerrorist[i] = weapons[index];
            }
            return WeaponsForTerrorist;
        }
        public string SetStatus(string set = "Life")                              // "סטטוס חיים למחבל "ברירת מחדל" = "חי
        {
            return set;
        }
        
        public CreateTerorist(string name)                                           // (שם המחבל (קומסטרקטור
        {
            
            TerroristName = name;
            TerroristRank = Rank();
            Weapons = string.Join(", ", Weapon());
            Status = SetStatus();
            
        }

        public override string ToString()
        {
            return $"Name: {TerroristName}, Rank: {TerroristRank}, Weapons: {Weapons}, Status: {Status}";
        }
        //Dictionary<string, string> TerroristInformation = new Dictionary<string, string>();
        //TerroristInformation["getInfro"] = "setInfro";
        //CreateTerorist terorist = new CreateTerorist("name");
    }
}


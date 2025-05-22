using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IDF_Operation__First_Strike
{
    internal class CreateTeror :Terrorist
    {
        public override string TerroristName { get; set; }        
        public override int TerroristRank { get; set; }              
        public override string Weapons {get; set;}               
        public override string Status { get; set; }

        public int Rank()
        {
            Random random = new Random();
            int num = random.Next(1, 6);
            return num;
        }

        public string[] Weapon()
        {
            List<string> weapons = new List<string> { "AK-47", "M-16", "Pistol", "knife" };

            Random random = new Random();
            int times = random.Next(1, 5);

            string[] WeaponsForTerrorist = new string[times];
            Random randWeapon = new Random();
            for (int i = 0; i < times; i++)
            {
                int index = randWeapon.Next(weapons.Count);
                Console.WriteLine(weapons[i]);
                 WeaponsForTerrorist[i]= weapons[index];
            }
            return WeaponsForTerrorist;  
        }

        public CreateTeror(string name)
        {
            TerroristName = name;
        }
    }
    
}

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
        public override int Weapons {get; set;}               
        public override string Status { get; set; }

        public int Rank()
        {
            Random random = new Random();
            int num = random.Next(1, 6);
            return num;
        }

        public int Weapon()
        {
            string[] weapons = { "AK-47", "M-16", "Pistol", "knife" };
             
            Random random = new Random();
            int num = random.Next(1, 5);
            return num;        }

        public CreateTeror(string name)
        {
            TerroristName = name;
        }
    }
    
}

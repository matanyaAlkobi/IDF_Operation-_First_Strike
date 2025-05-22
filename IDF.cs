using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IDF_Operation__First_Strike
{
    internal class IDF
    {
        StrikeWeapon wepen;
        public string DateOfEstablishment = "26.05.1948";
        public string CurrentCommander { get; set; }
        public  List<StrikeWeapon> ListOfStrikeOption { get; set; }

        public IDF(string CurrentCommander)
        {
            this.CurrentCommander = CurrentCommander;
            this.ListOfStrikeOption = new List<StrikeWeapon>();
        }




    }
}

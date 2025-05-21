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
        public DateTime DateOfEstablishment { get; set; }
        public string CurrentCommander { get; set; }
        public  List<StrikeWeapon> ListOfStrikeOption { get; set; }

        public IDF(DateTime DateOfEstablishment, string CurrentCommander)
        {
            this.DateOfEstablishment = DateOfEstablishment;
            this.CurrentCommander = CurrentCommander;
            this.ListOfStrikeOption = new List<StrikeWeapon>();
        }




    }
}

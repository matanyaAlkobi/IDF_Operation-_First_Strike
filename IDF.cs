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
        StrikeOption wepen;
        public DateTime DateOfEstablishment { get; set; }
        public string CurrentCommander { get; set; }
        public  List<StrikeOption> ListOfStrikeOption { get; set; }

        public IDF(DateTime DateOfEstablishment, string CurrentCommander)
        {
            this.DateOfEstablishment = DateOfEstablishment;
            this.CurrentCommander = CurrentCommander;
            this.ListOfStrikeOption = new List<StrikeOption>();
        }




    }
}

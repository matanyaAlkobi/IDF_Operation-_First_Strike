using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IDF_Operation__First_Strike
{
    internal abstract class Terrorist
    {
        public abstract string TerroristName { get; set; }         // שם המחבל
        public abstract int TerroristRank { get; set; }              //דרגת המחבל
        public abstract int Weapons { get; set; }                    // נשק 
        public abstract string Status { get; set; }               // סטטוס חי/מת 
    }
}
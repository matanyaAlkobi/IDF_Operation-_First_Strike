using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IDF_Operation__First_Strike
{

    internal abstract class StrikeWeapon

    {
        public abstract string TypeOfWeapon { get; }
        public abstract string NameOfTheWeapon { get; set; }
        public abstract  int NumberOfAttacke { get;}
        public abstract string[] WhatCanDestroy { get;}

        public abstract string TypesOfArtillery { get; set; }
           
    }
}

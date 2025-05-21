using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IDF_Operation__First_Strike
{

    internal abstract class StrikeOption

    {
        public abstract string NameOfTheWeapon { get;}
        public abstract  int NumberOfAttacke { get;}
        public abstract int FuelQuantity{ get;}
        public abstract string WhatCanDestroy { get;}
        
    }
}

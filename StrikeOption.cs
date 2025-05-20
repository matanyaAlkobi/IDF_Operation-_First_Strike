using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IDF_Operation__First_Strike
{
    internal interface StrikeOption
    {
        void NameOfTheWeapon(string nema);
        void NumberOfAttacke(int remainigAttacks);
        void FuelQuantity(int fuelRemainig);
        void WhatCanDestroy(string target);
        
    }
}

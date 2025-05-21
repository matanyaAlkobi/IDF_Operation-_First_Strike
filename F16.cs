using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IDF_Operation__First_Strike
{
    internal class F16 : StrikeOption
    {
        public override string NameOfTheWeapon { get; set; }
        public override int NumberOfAttacke => 20;
        public override int FuelQuantity => 20;
        public override string WhatCanDestroy => "dcvhjbk";

        public F16(string NameOfTheWeapon)
        {
            this.NameOfTheWeapon = NameOfTheWeapon;
        }


    }
}

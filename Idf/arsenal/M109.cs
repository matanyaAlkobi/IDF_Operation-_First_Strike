﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IDF_Operation__First_Strike
{
    internal class M109 : StrikeWeapon, IFuel
    {
        public override string TypeOfWeapon => "M109";

        public override string NameOfTheWeapon { get; set; }
    public override int NumberOfAttacke => 40;
        public double FuelQuantity => 70;
        public override string[] WhatCanDestroy => new string[]  {"open areas"};

    public override string TypesOfArtillery { get; set; }


    public M109(string NameOfTheWeapon)
    {
            this.NameOfTheWeapon = NameOfTheWeapon;
            this.TypesOfArtillery = "explosive shells";
    }


    }
}
    


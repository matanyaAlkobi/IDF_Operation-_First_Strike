using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IDF_Operation__First_Strike
{
    internal class F16 : StrikeWeapon, IArtillery, IFuel
    {
        public override string TypeOfWeapon => "F16";
        public override string NameOfTheWeapon { get; set; }
        public override int NumberOfAttacke => 8;
        public double FuelQuantity => 20;
        public override string WhatCanDestroy => "buildings";

        public override string TypesOfArtillery { get; set; }


        public F16(string NameOfTheWeapon)
        {
            this.NameOfTheWeapon = NameOfTheWeapon;
        }

        public void SetArtillery(int num)
        {
            if (num == 1)
            {
                TypesOfArtillery = "0.5  ton";
            }
            else if (num == 2)
            {
                TypesOfArtillery = "1 ton";
            }
            
        }


    }
}

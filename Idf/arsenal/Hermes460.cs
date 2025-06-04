using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IDF_Operation__First_Strike
{
    internal class Hermes460 : StrikeWeapon, IArtillery, IFuel
    {
        public override string TypeOfWeapon => "Hermes460";
        public override string NameOfTheWeapon { get; set; }
        public override int NumberOfAttacke => 8;
        public double FuelQuantity => 30;
        public override string[] WhatCanDestroy => new string[] { "people", "vehicles" };

        public override string TypesOfArtillery { get; set; }


        public Hermes460(string NameOfTheWeapon)
        {
            this.NameOfTheWeapon = NameOfTheWeapon;
        }

        public void SetArtillery(int num)
        {
            if (num == 1)
            {
                TypesOfArtillery = "A bomb destroys people.";
            }
            else if (num == 2)
            {
                TypesOfArtillery = "A bomb destroys vehicles";
            }

        }
    }
}

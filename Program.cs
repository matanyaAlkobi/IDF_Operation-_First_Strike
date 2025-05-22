using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IDF_Operation__First_Strike
{
    internal class Program
    {
        static void Main(string[] args)
        {
            F16 F16_01 = new F16("hhfh");
  
            IDF Army = new IDF("ggg");

            Army.ListOfStrikeOption.Add(F16_01);
            foreach(var ii in Army.ListOfStrikeOption)
            {
                Console.WriteLine(ii.NumberOfAttacke);
            }
            Console.WriteLine(Army.DateOfEstablishment);
        }
    }
}

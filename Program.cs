using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using IDF_Operation__First_Strike.Idf.arsenal;
using IDF_Operation__First_Strike.TerroristOrganization;

namespace IDF_Operation__First_Strike
{
    internal class Program
    {
        static void Main(string[] args)
        {
            CreateTerorist t1 = new CreateTerorist("Ahmad");
            CreateTerorist t2 = new CreateTerorist("Muhamad");

            DatabaseTrrorists TBTerror = new DatabaseTrrorists();
            TBTerror.AddingTerroristToTheDatabase(t2);
            TBTerror.AddingTerroristToTheDatabase(t1);

            foreach (var itam in TBTerror.TerroristInformation.Values)
            {
                foreach (var item1 in itam)
                {
                    Console.WriteLine(item1);
                }




                /*
                F16 dd = new F16("saefw");
                M109 aa = new M109("sgfgm");

                WeaponsDatabase ascs = new WeaponsDatabase();

                ascs.AddingWeaponsToTheDatabase(dd);
                ascs.AddingWeaponsToTheDatabase(aa);

                foreach(var itam in ascs.weponToolDatabase.Values)
                {
                    foreach (var item1 in itam)
                    {
                        Console.WriteLine(item1.NumberOfAttacke);
                    }

                }
                */




            }
        }
    }

}

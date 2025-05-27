using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using IDF_Operation__First_Strike.Idf.arsenal;
using IDF_Operation__First_Strike.SystemOperation;
using IDF_Operation__First_Strike.TerroristOrganization;

namespace IDF_Operation__First_Strike
{
    internal class Program
    {
        static void Main(string[] args)
   
            
            //CreateTeror ahmad = new CreateTeror("ahmad");
            //ahmad.Weapon();

            F16 dd = new F16("f16-1");
            M109 aa = new M109("m109-1");
            M109 bb = new M109("m109-2");
            WeaponsDatabase WeaponsStorageObject = new WeaponsDatabase();
            WeaponsStorageObject.AddingWeaponsToTheDatabase(dd);
            WeaponsStorageObject.AddingWeaponsToTheDatabase(aa);
            WeaponsStorageObject.AddingWeaponsToTheDatabase(bb);

            int choise = SystemMenu.OptionsPanelMenu();
            OperatingTheSystemAsSelected.OperatingTheSystem(choise, WeaponsStorageObject);

            //var arsenal = WeaponsStorageObject.weponToolDatabase;



            //Console.WriteLine($"You have {arsenal.Count} types of weapons.");

            //foreach (var itam in arsenal)
            //{
            //    Console.ForegroundColor = ConsoleColor.Blue;
            //    Console.WriteLine($"and cuurent available tool {itam.Key}");
            //    Console.ResetColor();
            //    Console.WriteLine($"And you have {itam.Value.Count} such tools");


            //    foreach (var wepon in itam.Value)
            //    {
            //        Console.WriteLine($"The tool {wepon.NameOfTheWeapon} has {wepon.NumberOfAttacke} attacks left.");
            //    }

            //}


            //foreach(var itam in ascs.weponToolDatabase.Values)
            //{
            //    foreach (var item1 in itam)
            //    {
            //        Console.WriteLine(item1.NameOfTheWeapon);
            //    }

            //}



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

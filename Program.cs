using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using IDF_Operation__First_Strike.Idf.arsenal;

namespace IDF_Operation__First_Strike
{
    internal class Program
    {
        static void Main(string[] args)
        {

            //CreateTeror ahmad = new CreateTeror("ahmad");
            //ahmad.Weapon();

            F16 dd = new F16("saefw");
            M109 aa = new M109("sgfgm");

            WeaponsDatabase ascs = new WeaponsDatabase();

            ascs.AddingWeaponsToTheDatabase(dd);
            ascs.AddingWeaponsToTheDatabase(aa);

            foreach(var itam in ascs.weponToolDatabase.Values)
            {
                foreach (var item1 in itam)
                {
                    Console.WriteLine(item1.);
                }

            }

            



        }
    }
}

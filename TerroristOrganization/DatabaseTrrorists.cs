using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IDF_Operation__First_Strike.TerroristOrganization
{
    internal class DatabaseTrrorists
    {
        public Dictionary<string, List<Terrorist>> TerroristInformation = new Dictionary<string, List<Terrorist>>();

        public void AddingTerroristToTheDatabase(Terrorist TerroistObject)
        {
            if (!TerroristInformation.ContainsKey(TerroistObject.TerroristName))
            {
                TerroristInformation[TerroistObject.TerroristName] = new List<Terrorist>();
            }
            TerroristInformation[TerroistObject.TerroristName].Add(TerroistObject);
            Console.WriteLine("The terrorist has been added to the database.");
        }
    }
}

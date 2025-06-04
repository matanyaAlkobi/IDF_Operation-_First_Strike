using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IDF_Operation__First_Strike.Idf.AMAN
{
    internal class AmanDB
    {
        private static AmanDB _instance = null;

        private List<InformationCollection> TerroristDatabase = new List<InformationCollection>();


        private  AmanDB() { }

        public static AmanDB GetInstance()
        {
            if (_instance == null)
            {
                _instance = new AmanDB();
            }
            return _instance;
        }

        public void AddingATerroristToDB(InformationCollection terrorist)
        {
            if (terrorist != null)
            {
                TerroristDatabase.Add(terrorist);
            }
        }

        public  List<InformationCollection> ReceivingADBOfTerrorists()
        {
            return TerroristDatabase;
        }

        //public IReadOnlyList<InformationCollection> GetAllTerrorists()
        //{
        //    return TerroristDatabase.AsReadOnly();
        //}

    }
}

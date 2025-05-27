using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IDF_Operation__First_Strike.Idf.AMAN
{
    internal class InformationCollection
    {  
        private int ID;
        private string TerroristBelong;
        private string LastKnownLocation;
        private DateTime InformationCollectionTime;
 
        private List<InformationCollection> TerroristDatabase = new List<InformationCollection>();


        public InformationCollection(string terroristBelong, string lastKnownLocation, DateTime informationCollectionTime, int ID)
        {
            this.TerroristBelong = terroristBelong;
            this.LastKnownLocation = lastKnownLocation;
            this.InformationCollectionTime = informationCollectionTime;
            this.ID = ID;
        }

        public void AddingATerroristToTheDatabase(InformationCollection Terrorist)
        {  // 
            TerroristDatabase.Add(Terrorist);

        }
        public List<InformationCollection> ReceivingADatabaseOfTerrorists()
        {
            return TerroristDatabase;
        }
    }
}

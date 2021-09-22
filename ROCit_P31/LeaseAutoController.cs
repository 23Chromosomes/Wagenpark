using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ROCit_P31
{
    class LeaseAutoController
    {
        private DataLinQDataContext db;

        public LeaseAutoController(DataLinQDataContext db)
        {
            this.db = db;
        }
        public auto autoZoeken(string kenteken)
        {
            return null;
        }
        public bool autoOpslaan(string merk, string kleur, string kenteken, int personeelId, int dealerId)
        {
            return false;
        }
        public bool beurtOpslaan(string beurtnaam, decimal prijs, string omschijving
            , DateTime datum, int autoId, int werkplaatsId)
        {
            return false;
        }
        public List<auto> autoSelect()
        {
            return autoSelect(DateTime.Today);
        }
        public List<auto> autoSelect(DateTime date)
        {
            /*
            var onderhoudAuto = (from onderhoud in db.onderhouds where onderhoud.uitvoerdatum != DateTime.Today select onderhoud).FirstOrDefault();
            List<string> autos = (from auto in db.autos where auto.autoId.Equals(onderhoudAuto) select auto).FirstOrDefault();
            return autos;
            */
            //auto's laten zien die geen onderhoudsbeurt hebben 
            //auto's niet laten zien die vandaag een onderhoudsbeurt hebben.
            //
            //Lijst van onderhoud op datum vandaag ophalen
            //Lijst met alle auto's ophalen
            //Loopen door lijst met onderhoud en de auto die onderhoud heeft, uit lijst verwijderen van autos
            return null;
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ROCit_P31
{
    class WerkplaatsController
    {
        private DataLinQDataContext db;
        public WerkplaatsController(DataLinQDataContext db)
        {
            this.db = db;
        }
        public bool werkplaatsToevoegen(string bedrijfsnaam, string werkplaatsnaam)
        {
            try
            {
                werkplaat Werkplaats = new werkplaat();
                Werkplaats.bedrijfsnaam = bedrijfsnaam;
                Werkplaats.werkplaatsnaam = werkplaatsnaam;
                db.werkplaats.InsertOnSubmit(Werkplaats);
                return true;
            }
            catch
            {
                return false;
            }
            
        }
    }
}

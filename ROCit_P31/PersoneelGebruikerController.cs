using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ROCit_P31
{
    class PersoneelGebruikerController
    {
        private DataLinQDataContext db;

        public PersoneelGebruikerController(DataLinQDataContext db)
        {
            this.db = db;
        }
        public bool Personeeltoevoegen(string naam, string personeelnummer)
        {
            try
            {
                personeel pers = new personeel();
                pers.naam = naam;
                pers.personeelsnumer = personeelnummer;
                db.personeels.InsertOnSubmit(pers);
                db.SubmitChanges();
                return true;
            }
            catch
            {
                return false;
            }
            
        }
        //Evt. Functie verwijderen
        //Evt. Functie Wijzigen
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ROCit_P31
{
    class loginController
    {
        private DataLinQDataContext db;

        public loginController(DataLinQDataContext db)
        {
            this.db = db;
        }
        public gebruiker inloggen(string gebruikersnaam, string wachtwoord)
        {
            gebruiker user = (from gebruiker in db.gebruikers
                              where gebruiker.naam.Equals(gebruikersnaam) && gebruiker.wachtwoord.Equals(wachtwoord)
                              select gebruiker).FirstOrDefault();
            //0 = dealer
            //1 = beheerder
            //2 = rocit
            //-1 = wrong credentials
            if(user == null)
            {
                gebruiker nulluser = new gebruiker();
                nulluser.key = -1;
                return nulluser;
            }
            else
            {
                return user; 
            }
            
        }
    }
}

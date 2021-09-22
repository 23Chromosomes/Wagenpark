using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;

namespace ROCit_P31
{
    class DealerController
    {
        private DataLinQDataContext db;
        public int dealerId { get; set; }

        public DealerController(DataLinQDataContext db)
        {
            this.db = db;
        }
        public bool addDealer(string dealerNaam)
        {
            try
            {
                dealer Dealer = new dealer();
                Dealer.dealerNaam = dealerNaam;
                db.dealers.InsertOnSubmit(Dealer);
                db.SubmitChanges();
                return true;
            }
            catch
            {
                return false;
            }           
        }
        public dealer DealerOpvragen(string dealernaam, int dealernummer)
        {
            dealer Dealer = (from dealer in db.dealers
                                where dealer.dealerNaam.Equals(dealernaam) && dealer.dealerId.Equals(dealernummer)
                                select dealer).FirstOrDefault();
            return Dealer;
        }
    }
}

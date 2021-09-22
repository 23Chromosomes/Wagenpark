using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace ROCit_P31
{
    /// <summary>
    /// Interaction logic for DealerOpvagenUC.xaml
    /// </summary>
    public partial class DealerOpvagenUC : UserControl
    {
        private DataLinQDataContext db;
        DealerController dealerC;
        public DealerOpvagenUC(DataLinQDataContext db)
        {
            InitializeComponent();
            this.db = db;
            dealerC = new DealerController(db);
        
            dealerDG.ItemsSource = db.dealers.ToList();
        }

        private void BtnZoek_Click(object sender, RoutedEventArgs e)
        {
            if(txtDealerNaam.Text.Length == 0)
            {
                MessageBox.Show("Er is geen Dealernaam ingevoerd!");
            }
            else
            {
                if(txtDealerNummer.Text.Length == 0)
                {
                    MessageBox.Show("Er is geen dealernummer ingevoerd!");
                }
                else
                {
                    try
                    {
                        int dealernummer = Convert.ToInt32(txtDealerNummer.Text);
                        dealer Dealer = dealerC.DealerOpvragen(txtDealerNaam.Text, dealernummer);

                        List<string> MyList = new List<string>();
                        MyList.Add(Convert.ToString(Dealer.dealerId));
                        MyList.Add(Dealer.dealerNaam);
                        dealerLijst.ItemsSource = MyList;

                        txtDealerNaam.Text = string.Empty;
                        txtDealerNummer.Text = string.Empty;
                    }
                    catch
                    {
                        MessageBox.Show("De gegevens komen niet overeen.");
                    }
                }
            }
            
        }
    }
}

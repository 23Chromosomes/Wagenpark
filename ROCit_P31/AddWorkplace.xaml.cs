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
    /// Interaction logic for AddWorkplace.xaml
    /// </summary>
    public partial class AddWorkplace : UserControl
    {
        private DataLinQDataContext db;
        DealerController dealerC;
        public AddWorkplace(DataLinQDataContext db)
        {
            InitializeComponent();
            this.db = db;
            dealerC = new DealerController(db);
            dgDealers.ItemsSource = db.dealers.ToList();
        }

        private void BtnLijstOpslaan_Click(object sender, RoutedEventArgs e)
        {
            if(tbxDealerNaam.Text.Length == 0)
            {
                MessageBox.Show("Je hebt geen dealernaam ingevuld!");
            }
            else
            {
                if(dealerC.addDealer(tbxDealerNaam.Text) == true)
                {
                    MessageBox.Show("Je Dealer is opgeslagen");
                    tbxDealerNaam.Text = string.Empty;
                }
                else
                {
                    MessageBox.Show("Er is iets mis gegaan.");
                }
            }
            dgDealers.ItemsSource = db.dealers.ToList();
         
        }
    }
}

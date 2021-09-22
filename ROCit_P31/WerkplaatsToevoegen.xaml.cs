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
    /// Interaction logic for WerkplaatsToevoegen.xaml
    /// </summary>
    public partial class WerkplaatsToevoegen : UserControl
    {
        private DataLinQDataContext db;
        WerkplaatsController werkpC;
        public WerkplaatsToevoegen(DataLinQDataContext db)
        {
            InitializeComponent();
            this.db = db;
            werkpC = new WerkplaatsController(db);
            dgWerkplaatsen.ItemsSource = db.werkplaats.ToList();
        }

        private void BtnWerkplaatsToevoegen_Click(object sender, RoutedEventArgs e)
        {
            if(tbxBedrijfsnaam.Text.Length == 0)
            {
                MessageBox.Show("Je hebt geen bedrijfsnaam ingevuld!");
            }
            else
            {
                if(tbxWerkplaatsnaam.Text.Length == 0)
                {
                    MessageBox.Show("Je hebt geen werkplaatsnaam toegevoegd!");
                }
                else
                {
                    if(werkpC.werkplaatsToevoegen(tbxBedrijfsnaam.Text, tbxWerkplaatsnaam.Text) == true)
                    {
                        MessageBox.Show("Je werkplaats is opgeslagen!");
                    }
                    else
                    {
                        MessageBox.Show("Er is iets mis gegaan!");
                    }
                }
            }
            dgWerkplaatsen.ItemsSource = db.werkplaats.ToList();
        }
    }
}

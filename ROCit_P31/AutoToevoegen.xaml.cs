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
    /// Interaction logic for AutoToevoegen.xaml
    /// </summary>
    public partial class AutoToevoegen : UserControl
    {
        private DataLinQDataContext db;
        LeaseAutoController leaseC;
        public AutoToevoegen(DataLinQDataContext db)
        {
            InitializeComponent();
            this.db = db;
            cbxPersoneel.ItemsSource = db.personeels.ToList();
            cbxDealer.ItemsSource = db.dealers.ToList();
            leaseC = new LeaseAutoController(db);
            dgAutos.ItemsSource = db.autos.ToList();

        }

        private void BtnOpslaan_Click(object sender, RoutedEventArgs e)
        {
            int persId = Convert.ToInt32(cbxPersoneel.SelectedValue);
            int dealerId = Convert.ToInt32(cbxDealer.SelectedValue);
            if(tbxMerk.Text.Length == 0)
            {
                MessageBox.Show("Er is geen merk ingevuld!");
            }
            else
            {
                if (tbxKleur.Text.Length == 0)
                {
                    MessageBox.Show("Er is geen Kleur ingevuld!");
                }
                else
                {
                    if (tbxKenteken.Text.Length == 0)
                    {
                        MessageBox.Show("Er is geen Kenteken ingevuld!");
                    }
                    else
                    {
                        if(string.IsNullOrEmpty(cbxDealer.Text))
                        {
                            MessageBox.Show("Er is geen Dealer Geselecteerd!");
                        }
                        else
                        {
                            if(string.IsNullOrEmpty(cbxPersoneel.Text))
                            {
                                MessageBox.Show("Er is geen Personeelslid Geselecteerd!");
                            }
                            else
                            {
                                if (leaseC.autoOpslaan(tbxMerk.Text, tbxKleur.Text, tbxKenteken.Text, persId, dealerId) == true)
                                {
                                    MessageBox.Show("Opslaan Gelukt!");
                                    tbxKenteken.Text = string.Empty;
                                    tbxKleur.Text = string.Empty;
                                    tbxMerk.Text = string.Empty;
                                }
                            }
                        }
                        
                    }
                }
            }
           
            

            
            
        }
    }
}

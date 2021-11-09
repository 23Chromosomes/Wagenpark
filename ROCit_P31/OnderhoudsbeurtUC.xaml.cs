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
    /// Interaction logic for OnderhoudsbeurtUC.xaml
    /// </summary>
    public partial class OnderhoudsbeurtUC : UserControl
    {
        private DataLinQDataContext db;
        LeaseAutoController leaseC;


        public OnderhoudsbeurtUC(DataLinQDataContext db)
        {
            InitializeComponent();
         
            this.db = db;
            dgBeurten.ItemsSource = db.onderhouds.ToList();
            leaseC = new LeaseAutoController(db);
            cbxauto.ItemsSource = db.autos.ToList();
            cbxWerkplaats.ItemsSource= db.werkplaats.ToList();
        }

        public void refreshgrid()
        {
            dgBeurten.ItemsSource = db.onderhouds.ToList();
        }

        private void BtnOpslaanBeurt_Click(object sender, RoutedEventArgs e)
        {
            if (tbxbeurtnaam.Text.Length == 0)
            {
                MessageBox.Show("Er is geen Naam ingevoerd!");
            }
            else
            {
                if (tbxprijs.Text.Length == 0)
                {
                    MessageBox.Show("Er is geen prijs ingevoerd!");
                }
                else
                {
                    if (tbxomschrijving.Text.Length == 0)
                    {
                        MessageBox.Show("Er is geen omschrijving!");
                    }
                    else
                    {
                        if (dpUitvoerdatum.Text.Length == 0)
                        {
                            MessageBox.Show("Er is geen uitvoerdatum geselecteerd!");
                        }
                        else
                        {
                            if (string.IsNullOrEmpty(cbxauto.Text))
                            {
                                MessageBox.Show("Er is geen Auto geselecteerd!");
                            }
                            else
                            {
                                if (string.IsNullOrEmpty(cbxWerkplaats.Text))
                                {
                                    MessageBox.Show("Er is geen Werkplaats geselecteerd!");
                                }
                                else
                                {
                                    onderhoud HetOnderhoud = new onderhoud();
                                    var date = dpUitvoerdatum.SelectedDate.Value.Date;


                                    string sBeurtnaam = tbxbeurtnaam.Text;
                                    int dprijs = Int32.Parse(tbxprijs.Text);
                                    string sOmschrijving = tbxomschrijving.Text;
                                    int TextboxAuto = Convert.ToInt32(cbxauto.SelectedValue);
                                    int TextboxWerk = Convert.ToInt32(cbxWerkplaats.SelectedValue);

                                    //Object persoon aanmaken
                                    HetOnderhoud.beurtnaam = sBeurtnaam;
                                    HetOnderhoud.kosten = dprijs;
                                    HetOnderhoud.omschrijving = sOmschrijving;
                                    HetOnderhoud.uitvoerdatum = date;
                                    HetOnderhoud.autoId = TextboxAuto;
                                    HetOnderhoud.werkplaatsId = TextboxWerk;

                                    //Insert in de wachtrij plaatsen
                                    db.onderhouds.InsertOnSubmit(HetOnderhoud);
                                    //Daadwerkelijk doorvoeren naar de database
                                    db.SubmitChanges();
                                    refreshgrid();
                                    


                                }
                            }
                        }
                       
                    }
                }

            }
        }
        private void btnWijzigBeurt_Click(object sender, RoutedEventArgs e)
        {
            onderhoud HetOnderhoud = (onderhoud)dgBeurten.SelectedItem;
            wBeurt WijzigBeurt = new wBeurt(HetOnderhoud, db);
            WijzigBeurt.Show();
            refreshgrid();
        }

        private void btnVerwijderen_Click(object sender, RoutedEventArgs e)
        {
            onderhoud HetOnderhoud = (onderhoud)dgBeurten.SelectedItem;

            MessageBoxResult messageBoxResult = System.Windows.MessageBox.Show("Weet je het zeker?", "Bevestig Verwijder", System.Windows.MessageBoxButton.YesNo);
            if (messageBoxResult == MessageBoxResult.Yes)
            {
                db.onderhouds.DeleteOnSubmit(HetOnderhoud);
                db.SubmitChanges();
                refreshgrid();
            }
        }

        private void DpUitvoerdatum_SelectedDateChanged(object sender, SelectionChangedEventArgs e)
        {
            DateTime datum = Convert.ToDateTime(dpUitvoerdatum.SelectedDate);

        }

        private void Tbxprijs_TextChanged(object sender, TextChangedEventArgs e)
        {
            if (System.Text.RegularExpressions.Regex.IsMatch(tbxprijs.Text, "[^0-9]"))
            {
                MessageBox.Show("Geef alleen hele nummers op!");
                tbxprijs.Text = tbxprijs.Text.Remove(tbxprijs.Text.Length - 1);
            }
        }

    }
}

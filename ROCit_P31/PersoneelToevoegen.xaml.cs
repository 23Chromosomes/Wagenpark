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
    /// Interaction logic for PersoneelToevoegen.xaml
    /// </summary>
    public partial class PersoneelToevoegen : UserControl
    {
        private DataLinQDataContext db;
        PersoneelGebruikerController personeel;
        public PersoneelToevoegen(DataLinQDataContext db)
        {
            InitializeComponent();
            this.db = db;
            personeel = new PersoneelGebruikerController(db);
            dgPersoneel.ItemsSource = db.personeels.ToList();
        }

        public void refreshDatagrid()
        {
            dgPersoneel.ItemsSource = db.personeels.ToList();
        }

        private void BtnPersoneelOpslaan_Click(object sender, RoutedEventArgs e)
        {
            if(tbxPersoneelNaam.Text.Length == 0)
            {
                MessageBox.Show("Je hebt geen Personeelsnaam ingevoerd!");
            }
            else
            {
                if(tbxPersoneelNummer.Text.Length == 0)
                {
                    MessageBox.Show("Je hebt geen Personeelsnummer ingevoerd!");
                }
                else
                {
                    if (personeel.Personeeltoevoegen(tbxPersoneelNaam.Text, tbxPersoneelNummer.Text) == true)
                    {
                        MessageBox.Show("Personeel is Opgeslagen!");
                        tbxPersoneelNaam.Text = string.Empty;
                        tbxPersoneelNummer.Text = string.Empty;
                    }
                    else
                    {
                        MessageBox.Show("Er is iets mis gegaan.");
                    }
                }
            }
            dgPersoneel.ItemsSource = db.personeels.ToList();
        }

        private void btnDelete_Click(object sender, RoutedEventArgs e)
        {
            MessageBoxResult confirmResult = MessageBox.Show("Are you sure to delete this item ??", "Confirm Delete!!", MessageBoxButton.YesNo);

            if (confirmResult == MessageBoxResult.Yes)
            {
                personeel personeelSelected = (personeel)dgPersoneel.SelectedItem;
                db.personeels.DeleteOnSubmit(personeelSelected);
                db.SubmitChanges();
                refreshDatagrid();
            }
        }

        private void btnupdate_Click(object sender, RoutedEventArgs e)
        {
            personeel personeelSelected = (personeel)dgPersoneel.SelectedItem;
            personeelUpdate personeelupdate = new personeelUpdate(personeelSelected, db);

            personeelupdate.Show();
        }
    }
}

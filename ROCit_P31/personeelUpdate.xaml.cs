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
using System.Windows.Shapes;

namespace ROCit_P31
{
    /// <summary>
    /// Interaction logic for personeelUpdate.xaml
    /// </summary>
    public partial class personeelUpdate : Window
    {
        private personeel hetPersoneel;
        private DataLinQDataContext db;

        public personeelUpdate(personeel hetPersoneel, DataLinQDataContext db)
        {
            InitializeComponent();

            this.hetPersoneel = hetPersoneel;
            this.db = db;

            PersoneelNaam.Text = hetPersoneel.naam;
            PersoneelNummer.Text = hetPersoneel.personeelsnummer.ToString();
        }

        private void updateBtn_Click(object sender, RoutedEventArgs e)
        {
            hetPersoneel.naam = PersoneelNaam.Text.ToString();
            hetPersoneel.personeelsnummer = PersoneelNummer.Text.ToString();
            db.SubmitChanges();
            this.Close();
        }
    }
}

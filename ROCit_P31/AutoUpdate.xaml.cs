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
    /// Interaction logic for AutoUpdate.xaml
    /// </summary>
    public partial class AutoUpdate : Window
    {

        private auto deAuto;
        private DataLinQDataContext db;

        public AutoUpdate(auto deAuto, DataLinQDataContext db)
        {
            InitializeComponent();

            cbxPersoneel.ItemsSource = db.personeels.ToList();
            cbxDealer.ItemsSource = db.dealers.ToList();

            this.deAuto = deAuto;
            this.db = db;

            tbxKenteken.Text = deAuto.kenteken;
            tbxKleur.Text = deAuto.kleur;
            tbxMerk.Text = deAuto.merk;


            cbxPersoneel.SelectedValue = deAuto.personeelId;
            cbxDealer.SelectedValue = deAuto.dealerId;
        }

        private void updateBtn_Click(object sender, RoutedEventArgs e)
        {
            deAuto.kenteken = tbxKenteken.Text;
            deAuto.kleur = tbxKleur.Text;
            deAuto.merk = tbxMerk.Text;


            deAuto.personeelId = (int)cbxPersoneel.SelectedValue;
            deAuto.dealerId = (int)cbxDealer.SelectedValue;
            db.SubmitChanges();
            this.Close();
        }
    }
}

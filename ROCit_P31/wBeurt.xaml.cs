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
    /// Interaction logic for wBeurt.xaml
    /// </summary>
    
    public partial class wBeurt : Window
    {
        private onderhoud HetOnderhouds;
        private DataLinQDataContext db;
        LeaseAutoController leaseC;

        public wBeurt(onderhoud HetOnderhoud, DataLinQDataContext db)
        {
            InitializeComponent();
            leaseC = new LeaseAutoController(db);
            cbxauto.ItemsSource = db.autos.ToList();
            cbxWerkplaats.ItemsSource = db.werkplaats.ToList();
            this.HetOnderhouds = HetOnderhoud;
            this.db = db;
            //Huidige data in de controls plaatsen
            tbxbeurtnaam.Text = HetOnderhoud.beurtnaam;
            tbxprijs.Text = Convert.ToString(HetOnderhoud.kosten);
            tbxomschrijving.Text = HetOnderhoud.omschrijving;
            dpUitvoerdatum.Text = Convert.ToString(HetOnderhoud.uitvoerdatum);
            cbxauto.SelectedItem = HetOnderhoud.auto;
            cbxWerkplaats.SelectedItem = HetOnderhoud.werkplaat;

           
   

        }

        private void btnWijzigBeurt_Click(object sender, RoutedEventArgs e)
        {
            var date = dpUitvoerdatum.SelectedDate.Value.Date;

            HetOnderhouds.beurtnaam = tbxbeurtnaam.Text;
            HetOnderhouds.kosten = Convert.ToDecimal(tbxprijs.Text);
            HetOnderhouds.omschrijving = tbxomschrijving.Text;
            HetOnderhouds.uitvoerdatum = date;
            HetOnderhouds.auto = (auto)cbxauto.SelectedItem;
            HetOnderhouds.werkplaat = (werkplaat)cbxWerkplaats.SelectedItem; ;

            db.SubmitChanges();
            this.Close();
        }
    }
}

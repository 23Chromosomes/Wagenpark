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
    /// Interaction logic for Overizicht_Lease_Auto.xaml
    /// </summary>
    public partial class Overizicht_Lease_Auto : UserControl
    {
        private DataLinQDataContext db;
        LeaseAutoController leaseC;
        public Overizicht_Lease_Auto(DataLinQDataContext db)
        {
            InitializeComponent();
            dgAuto.ItemsSource = db.autos.ToList();
            leaseC = new LeaseAutoController(db);
            this.db = db;
        }

        private void BtnZoek_Click(object sender, RoutedEventArgs e)
        {
            if(tbxKenteken.Text.Length == 0)
            {
                MessageBox.Show("Je hebt geen kenteken ingevoerd!");
            }
            else
            {
                if(leaseC.autoZoeken(tbxKenteken.Text) == null)
                {
                    MessageBox.Show("Er is geen auto gevonden!");
                }
                else
                {
                    auto car = leaseC.autoZoeken(tbxKenteken.Text);
                    List<string> MyList = new List<string>();
                    MyList.Add(car.merk);
                    MyList.Add(car.kenteken);
                    MyList.Add(car.kleur);
                    listAuto.ItemsSource = MyList;
                    tbxKenteken.Text = string.Empty;
                }
                
                
            }
            
        }
    }
}

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
    /// Interaction logic for Base.xaml
    /// </summary>
    public partial class Base : Window
    {
        private DataLinQDataContext db;
   
        public Base(DataLinQDataContext db, gebruiker user)
        {
            InitializeComponent();
            this.db = db;
          
            welkomUC welkom = new welkomUC();
            mainframe.Content = welkom;
            //0 = dealer
            //1 = beheerder
            //2 = rocit
            //-1 = wrong credentials
            if (user.key == 0)
            {
                btnPersoneel.Visibility = Visibility.Collapsed;
                btnleasetoevoegen.Visibility = Visibility.Collapsed;
                btnkosten.Visibility = Visibility.Collapsed;
                btnOnderhoudToevoegen.Visibility = Visibility.Collapsed;
            }
            if(user.key == 2)
            {
                btnOnderhoudToevoegen.Visibility = Visibility.Collapsed;
                btnDealerToevoegen.Visibility = Visibility.Collapsed;
                btnWerkplaatsToevoegen.Visibility = Visibility.Collapsed;
            }
            
            //Slide label + Gebruikersnaam

            txtKron.Text = "Welkom, " + user.naam;
        }

        private void BtnOverzicht_Click(object sender, RoutedEventArgs e)
        {
            Overizicht_Lease_Auto overzichtlease = new Overizicht_Lease_Auto(db);
            mainframe.Content = overzichtlease;
        }

        private void Btnleasetoevoegen_Click(object sender, RoutedEventArgs e)
        {
            AutoToevoegen addcar = new AutoToevoegen(db);
            mainframe.Content = addcar;
        }

        private void BtnPersoneel_Click(object sender, RoutedEventArgs e)
        {
            PersoneelToevoegen addstaff = new PersoneelToevoegen(db);
            mainframe.Content = addstaff;
        }

        private void BtnOnderhoudToevoegen_Click(object sender, RoutedEventArgs e)
        {
            OnderhoudsbeurtUC onderhoud = new OnderhoudsbeurtUC(db);
            mainframe.Content = onderhoud;
        }

        private void Btnkosten_Click(object sender, RoutedEventArgs e)
        {
            kostenUC kosten = new kostenUC(db);
            mainframe.Content = kosten;
        }

        private void BtnUitloggen_Click(object sender, RoutedEventArgs e)
        {
            MainWindow main = new MainWindow();
            main.Show();
            this.Close();
        }


        private void BtnDealerToevoegen_Click_1(object sender, RoutedEventArgs e)
        {
            AddWorkplace werkplaatsT = new AddWorkplace(db);
            mainframe.Content = werkplaatsT;
        }

        private void BtnDealerZoeken_Click(object sender, RoutedEventArgs e)
        {
            DealerOpvagenUC dealerZoekUC = new DealerOpvagenUC(db);
            mainframe.Content = dealerZoekUC;
        }

        private void BtnWerkplaatsToevoegen_Click(object sender, RoutedEventArgs e)
        {
            WerkplaatsToevoegen werkplaatsUC = new WerkplaatsToevoegen(db);
            mainframe.Content = werkplaatsUC;
        }
    }

    public class NegatingConverter : IValueConverter
    {

        public object Convert(object value, Type targetType, object parameter, System.Globalization.CultureInfo culture)
        {
            if (value is double)
            {
                return -((double)value);
            }
            return value;
        }

        public object ConvertBack(object value, Type targetType, object parameter, System.Globalization.CultureInfo culture)
        {
            if (value is double)
            {
                return +(double)value;
            }
            return value;
        }
    }
}

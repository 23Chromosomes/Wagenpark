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
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        DataLinQDataContext db = new DataLinQDataContext();
        loginController loginC;
        LeaseAutoController leaseC;
        int key;
        public MainWindow()
        {
            InitializeComponent();
            loginC = new loginController(db);
            leaseC = new LeaseAutoController(db);
        }

        private void BtnloginUser_Click(object sender, RoutedEventArgs e)
        {
            gebruiker user = loginC.inloggen(txtuserName.Text, txtuserPassword.Password);

            if (user.key == 1)
            {
                key = 1;
                Base main = new Base(db, user);
                main.Show();
                this.Close();
            }
            if (user.key == 0)
            {
                key = 0;
                Base main = new Base(db, user);
                main.Show();
                this.Close();
            }
            if (user.key == 2)
            {
                key = 2;
                Base main = new Base(db, user);
                main.Show();
                this.Close();
            }
            if (user.key == -1)
            {
                MessageBox.Show("Je wachtwoord en of Gebruikersnaam komen niet overeen!");
            }
        }

        private void BtnUitloggen_Click(object sender, RoutedEventArgs e)
        {
            this.Close();
        }
    }
}

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
    /// Interaction logic for kostenUC.xaml
    /// </summary>
    public partial class kostenUC : UserControl
    {
        private DataLinQDataContext db;
        decimal totaalkosten;
        public kostenUC(DataLinQDataContext db)
        {
            InitializeComponent();
            this.db = db;
            var datum = DateTime.Today.AddMonths(-6);
            // var maand = datum.Month;
            // var jaar = datum.Year;

            var halfjaarGeleden = (from onderhoud in db.onderhouds
                                   where onderhoud.uitvoerdatum > datum
                                   select onderhoud).ToList();

            dgkostenhalfjaar.ItemsSource = halfjaarGeleden.ToList();
            foreach(onderhoud onderhoud in halfjaarGeleden)
            {
                decimal onderhoudkosten = onderhoud.kosten;
                totaalkosten += onderhoudkosten;
            }
            lblKosten.Content = totaalkosten;
        }

    }
}

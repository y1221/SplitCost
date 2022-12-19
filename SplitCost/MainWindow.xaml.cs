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

namespace SplitCost
{
    /// <summary>
    /// MainWindow.xaml の相互作用ロジック
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void btnCalc_Click(object sender, RoutedEventArgs e)
        {
            const double zei = 1.1;
            double zeikomiEn = 0;
            int ninzu = 0;
            int hitoriEn = 0;
            int amari = 0;

            zeikomiEn = int.Parse(txtZeinuki.Text);
            zeikomiEn *= zei;
            ninzu = int.Parse(txtNin.Text);
            hitoriEn = (int)(zeikomiEn / ninzu);
            amari = (int)(zeikomiEn % ninzu);

            lblHitoriEn.Content = hitoriEn + "円";
            lblAmariEn.Content = amari + "円";

        }
    }
}

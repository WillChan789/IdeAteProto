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

namespace IdeAteProto
{
    /// <summary>
    /// Interaction logic for PayTogether.xaml
    /// </summary>
    public partial class PayTogether : Window
    {
        public PayTogether()
        {
            InitializeComponent();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            Menu winA = new Menu();
            winA.boxRed.Visibility = Visibility.Hidden;
            winA.boxBlue.Visibility = Visibility.Hidden;
            winA.boxPurple.Visibility = Visibility.Hidden;

            winA.sendRed.Visibility = Visibility.Hidden;
            winA.sendBlue.Visibility = Visibility.Hidden;
            winA.sendPurple.Visibility = Visibility.Hidden;

            winA.totalRed.Visibility = Visibility.Hidden;
            winA.totalBlue.Visibility = Visibility.Hidden;
            winA.totalPurple.Visibility = Visibility.Hidden;

            winA.payRed.Visibility = Visibility.Hidden;
            winA.payBlue.Visibility = Visibility.Hidden;
            winA.payPurple.Visibility = Visibility.Hidden;

            winA.callWaiterR.Visibility = Visibility.Hidden;
            winA.Show();
            this.Close();
        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            Menu winA = new Menu();
            winA.Show();
            this.Close();
        }
    }
}

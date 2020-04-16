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

namespace IdeAteProto
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void Next_Click(object sender, RoutedEventArgs e)
        {
            string str = PeopleDropdown.Text;
            ComboBoxItem cbi = (ComboBoxItem)PeopleDropdown.SelectedItem;
            string num = cbi.Content.ToString();
            int n = Int16.Parse(num);
            App.Current.Properties["numPayers"] = n;
            if (n > 1)
            {
                PayTogether winA = new PayTogether();
                winA.Show();
            } else
            {
                Menu winB = new Menu();
                winB.boxRed.Visibility = Visibility.Hidden;
                winB.boxBlue.Visibility = Visibility.Hidden;
                winB.boxPurple.Visibility = Visibility.Hidden;

                winB.sendRed.Visibility = Visibility.Hidden;
                winB.sendBlue.Visibility = Visibility.Hidden;
                winB.sendPurple.Visibility = Visibility.Hidden;

                winB.totalRed.Visibility = Visibility.Hidden;
                winB.totalBlue.Visibility = Visibility.Hidden;
                winB.totalPurple.Visibility = Visibility.Hidden;

                winB.payRed.Visibility = Visibility.Hidden;
                winB.payBlue.Visibility = Visibility.Hidden;
                winB.payPurple.Visibility = Visibility.Hidden;

                winB.callWaiterR.Visibility = Visibility.Hidden;

                winB.Show();
            }
            this.Close();
        }
    }
}

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
            if (n > 1)
            {
                PayTogether winA = new PayTogether();
                winA.Show();
            } else
            {
                Menu winB = new Menu();
                winB.Show();
            }
            this.Close();
        }
    }
}

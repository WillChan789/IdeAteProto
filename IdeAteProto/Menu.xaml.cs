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
    /// Interaction logic for Menu.xaml
    /// </summary>
    public partial class Menu : Window
    {
        public Menu()
        {
            InitializeComponent();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {

        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {

        }

        private void Button_Click_2(object sender, RoutedEventArgs e)
        {

        }

        private bool dragging;
        private void MouseLeftDownRect (object sender, MouseButtonEventArgs e)
        {
            dragging = true;
            this.CaptureMouse();
            this.ReleaseMouseCapture();
        }
        private void MouseLeftUpRect (object sender, MouseButtonEventArgs e)
        {
            dragging = false;
            var mouseWasDownOn = e.Source as FrameworkElement;
            string elementName = mouseWasDownOn.Name;

            var myRectangle = (Rectangle)this.FindName(elementName);

            myRectangle.Fill = new SolidColorBrush(System.Windows.Media.Colors.White);
            testtext.Visibility = Visibility.Visible;
            this.ReleaseMouseCapture();
        }
        private void MouseMoveRect (object sender, MouseEventArgs e)
        {
            if (!dragging) {
                return;
            }
            var mousepos = e.GetPosition(canvas);
            double left = mousepos.X - (this.ActualWidth / 2);
            double top = mousepos.Y - (this.ActualHeight / 2);
        }
    }
}

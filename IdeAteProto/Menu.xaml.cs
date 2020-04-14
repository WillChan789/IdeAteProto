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
            var last = (mouseWasDownOn.Name).Substring((mouseWasDownOn.Name).Length - 1);
            if (last != "t")
            {
                string elementName = mouseWasDownOn.Name;
                string elementName2 = elementName + "t";
                string pic = elementName + ".png";

                var myRectangle = (Rectangle)this.FindName(elementName);
                var myTextBlock = (TextBlock)this.FindName(elementName2);
                var ing1 = (CheckBox)this.FindName(elementName + "i1");
                var ing2 = (CheckBox)this.FindName(elementName + "i2");
                var ing3 = (CheckBox)this.FindName(elementName + "i3");




                myRectangle.Fill = new SolidColorBrush(System.Windows.Media.Colors.White);
                //myTextBlock.Visibility = Visibility.Visible;
                ing1.Visibility = Visibility.Visible;
                ing2.Visibility = Visibility.Visible;
                ing3.Visibility = Visibility.Visible;

            }
            else
            {
                string elementName2 = mouseWasDownOn.Name;
                string elementName = elementName2.Remove(elementName2.Length - 1);
                string pic = elementName + ".png";

                var myRectangle = (Rectangle)this.FindName(elementName);
                var myTextBlock = (TextBlock)this.FindName(elementName2);


                myRectangle.Fill = new SolidColorBrush(System.Windows.Media.Colors.White);
                myTextBlock.Visibility = Visibility.Visible;

                ImageBrush imgBrush = new ImageBrush();
                imgBrush.ImageSource = new BitmapImage(new Uri("pack://application:,,,/"+pic, UriKind.Absolute));
                // Fill rectangle with an ImageBrush 
                myRectangle.Fill = imgBrush;

                myTextBlock.Visibility = Visibility.Hidden;
            }
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

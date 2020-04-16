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
        bool drag = false;
        Point startPoint;

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
            CWaiterTextL.Visibility = Visibility.Visible;
            CWaiterTextR.Visibility = Visibility.Visible;
            callWaiterL.IsEnabled = false;
            callWaiterR.IsEnabled = false;
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
                myTextBlock.Visibility = Visibility.Visible;
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
                var ing1 = (CheckBox)this.FindName(elementName + "i1");
                var ing2 = (CheckBox)this.FindName(elementName + "i2");
                var ing3 = (CheckBox)this.FindName(elementName + "i3");


                myRectangle.Fill = new SolidColorBrush(System.Windows.Media.Colors.White);
                myTextBlock.Visibility = Visibility.Visible;

                ImageBrush imgBrush = new ImageBrush();
                imgBrush.ImageSource = new BitmapImage(new Uri("pack://application:,,,/"+pic, UriKind.Absolute));
                // Fill rectangle with an ImageBrush 
                myRectangle.Fill = imgBrush;

                myTextBlock.Visibility = Visibility.Hidden;
                ing1.Visibility = Visibility.Hidden;
                ing2.Visibility = Visibility.Hidden;
                ing3.Visibility = Visibility.Hidden;
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

        private void rectangle_MouseDown(object sender, MouseButtonEventArgs e)
        {
            // start dragging
            drag = true;
            // save start point of dragging
            startPoint = Mouse.GetPosition(canvas);
        }

        private void rectangle_MouseMove(object sender, MouseEventArgs e)
        {
            // if dragging, then adjust rectangle position based on mouse movement
            if (drag)
            {
                Rectangle draggedRectangle = sender as Rectangle;
                Point newPoint = Mouse.GetPosition(canvas);
                double left = Canvas.GetLeft(draggedRectangle);
                double top = Canvas.GetTop(draggedRectangle);
                Canvas.SetLeft(draggedRectangle, left + (newPoint.X - startPoint.X));
                Canvas.SetTop(draggedRectangle, top + (newPoint.Y - startPoint.Y));

                startPoint = newPoint;
            }
        }

        private void rectangle_MouseUp(object sender, MouseButtonEventArgs e)
        {
            // stop dragging
            drag = false;
        }
    }
}

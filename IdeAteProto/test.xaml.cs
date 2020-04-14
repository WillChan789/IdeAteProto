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
    /// Interaction logic for test.xaml
    /// </summary>
    public partial class test : Window
    {
        bool drag = false;
        Point startPoint;
        public test()
        {
            InitializeComponent();
        }
        // this creates and adds rectangles dynamically
        private void addRectangleButton_Click(object sender, RoutedEventArgs e)
        {
            // create new Rectangle
            Rectangle rectangle = new Rectangle();
            // assign properties
            rectangle.Width = 100;
            rectangle.Height = 50;
            rectangle.Fill = new SolidColorBrush(Colors.RoyalBlue);
            // assign handlers
            rectangle.MouseDown += rectangle_MouseDown;
            rectangle.MouseMove += rectangle_MouseMove;
            rectangle.MouseUp += rectangle_MouseUp;
            // set default position
            Canvas.SetLeft(rectangle, 0);
            Canvas.SetTop(rectangle, 0);
            // add it to canvas
            canvas.Children.Add(rectangle);
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

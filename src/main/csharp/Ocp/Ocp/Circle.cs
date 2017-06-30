using System;
using System.Windows.Controls;
using System.Windows.Shapes;

namespace Ocp
{
    public class Circle : Shape
    {
        public double Radius { get; set; }

        public Circle(double radius) : base()
        {
            Radius = radius;
        }

        public override void DrawOnConsole()
        {
            Console.WriteLine("Drawing circle with radius " + Radius);
        }

        public override void DrawOnCanvas(Canvas canvas)
        {
            var circle = new Ellipse {
                Width = Radius,
                Height = Radius,
                Stroke = System.Windows.Media.Brushes.IndianRed,
                StrokeThickness = 2};

            canvas.Children.Add(circle);
            Canvas.SetLeft(circle, positionLeft);
            Canvas.SetTop(circle, positionTop);
        }
    }
}
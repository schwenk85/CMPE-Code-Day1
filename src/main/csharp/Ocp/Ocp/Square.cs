using System;
using System.Windows.Controls;
using System.Windows.Shapes;

namespace Ocp
{
    public class Square : Shape
    {
        public double Length { get; set; }

        public Square(double len) : base()
        {
            Length = len;
        }

        public override void DrawOnConsole()
        {
            Console.WriteLine("Drawing square with side length " + Length);
        }

        public override void DrawOnCanvas(Canvas canvas)
        {
            var square = new Rectangle {
                Width = Length,
                Height = Length,
                Stroke = System.Windows.Media.Brushes.CornflowerBlue,
                StrokeThickness = 2};

            canvas.Children.Add(square);
            Canvas.SetLeft(square, positionLeft);
            Canvas.SetTop(square, positionTop);
        }
    }
}
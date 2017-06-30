using System;
using System.Windows.Controls;

namespace Ocp
{
    public abstract class Shape
    {
        private static Random random = new Random();
        protected int positionLeft;
        protected int positionTop;
        
        public Shape()
        {
            const int border = 50;
            positionLeft = random.Next(100) + border / 2;
            positionTop = random.Next(100) + border / 2;
        }

        public abstract void DrawOnConsole();
        public abstract void DrawOnCanvas(Canvas canvas);
    }
}
using System.Collections.Generic;
using System.Windows.Controls;

namespace Ocp
{
    public class ShapeDrawer
    {
        public void DrawShapesOnConsole(List<Shape> shapes)
        {
            foreach (var shape in shapes)
            {
                shape.DrawOnConsole();
            }
        }

        public void DrawShapesOnCanvas(List<Shape> shapes, Canvas canvas)
        {
            foreach (var shape in shapes)
            {
                shape.DrawOnCanvas(canvas);
            }
        }
    }
}
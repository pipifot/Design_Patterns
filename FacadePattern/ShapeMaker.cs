using System;
using System.Collections.Generic;
using System.Text;

namespace FacadePattern
{
    class ShapeMaker
    {
        private readonly Circle _circle;
        private readonly Rectangle _rectangle;
        private readonly Square _square;

        public ShapeMaker()
        {
            _circle = new Circle();
            _rectangle = new Rectangle();
            _square = new Square();
        }

        public void DrawCircle()
        {
            _circle.Draw();
        }

        public void DrawRectangle()
        {
            _rectangle.Draw();
        }

        public void Square()
        {
            _square.Draw();
        }
    }
}

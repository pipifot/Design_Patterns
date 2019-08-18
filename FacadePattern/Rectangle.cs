using System;
using System.Collections.Generic;
using System.Text;

namespace FacadePattern
{
    class Rectangle : IShape
    {
        public void Draw()
        {
            Console.WriteLine(nameof(Rectangle));
        }
    }
}

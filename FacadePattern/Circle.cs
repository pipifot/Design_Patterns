using System;
using System.Collections.Generic;
using System.Text;

namespace FacadePattern
{
    class Circle : IShape
    {
        public void Draw()
        {
            Console.WriteLine(nameof(Circle));
        }
    }
}

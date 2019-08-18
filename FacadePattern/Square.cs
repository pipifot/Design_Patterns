using System;
using System.Collections.Generic;
using System.Text;

namespace FacadePattern
{
    class Square : IShape
    {
        public void Draw()
        {
            Console.WriteLine(nameof(Square));
        }
    }
}

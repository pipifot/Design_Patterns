using System;
using System.Collections.Generic;
using System.Text;

namespace AbstractFacotryPattern
{
    abstract class AbstractFactory
    {
        public abstract AbstractProductA CreateProductA();
        public abstract AbstractProductB CreateProductB();
    }

}

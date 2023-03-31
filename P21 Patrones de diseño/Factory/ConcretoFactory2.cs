using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace P21_Patrones_de_diseño.Factory
{
    class ConcretoFactory2 : IAbstractFactory
    {
        public IAbstractProductA CreateProductA()
        {
            return new ConcretoProductA2();
        }

        public IAbstractProductB CreateProductB()
        {
            return new ConcretoProductB2();
        }
    }
}
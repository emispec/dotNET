using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace P21_Patrones_de_diseño.Factory
{
    public class ConcretoProductB2 : IAbstractProductB
    {
        public string MetodoB()
        {
            return "Desde MetodoB en productB2";
        }

        public string OtroMetodoB(IAbstractProductA colaborador)
        {
            var resultado = colaborador.MetodoA();
            return $"El resultado de la claboracion con A es: {resultado} desde product B2";
        }

        string IAbstractProductB.MetodoB()
        {
            throw new NotImplementedException();
        }

        string IAbstractProductB.OtroMEtodoB(IAbstractProductA colaborador)
        {
            throw new NotImplementedException();
        }
    }
}

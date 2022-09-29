using System;
using System.Collections.Generic;
using System.Text;

namespace Supermercado
{
    class Preferencial:BaseCliente
    {
        public Preferencial (string _nombre, int _dni): base(_nombre, _dni)
        {
            beneficio = 0.10;
        }
    }
}

using System;
using System.Collections.Generic;
using System.Text;

namespace Supermercado
{
    class Comun:BaseCliente
    {
        public Comun(string _nombre, int _dni) : base(_nombre, _dni)
        {

            beneficio = 0;
        }
    }
}

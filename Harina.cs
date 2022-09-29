using System;
using System.Collections.Generic;
using System.Text;

namespace Supermercado
{
    class Harina:BaseProducto
    {
        public Harina(string _nombre, int _codigo, double _precio, int _stock, double _descuento) : base(_nombre, _codigo, _precio, _stock, _descuento)
        {

        }
    }
}

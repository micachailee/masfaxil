using System;
using System.Collections.Generic;
using System.Text;

namespace Supermercado
{
   public abstract class BaseProducto
    {
        public string nombre;
        public int codigo;
        public double precio;
        public int stock;
        public double descuento;
        public double preciof;
        public BaseProducto(string _nombre, int _codigo, double _precio, int _stock, double _descuento )
        {
            nombre = _nombre;
            codigo = _codigo;
            precio = _precio;
            stock = _stock;
            descuento = _descuento;
            preciof = precio - precio * descuento;
        }
        public bool TengoStock()
        {
            return (stock > 0);
        }
    }
}

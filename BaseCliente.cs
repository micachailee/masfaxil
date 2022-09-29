using System;
using System.Collections.Generic;
using System.Text;

namespace Supermercado
{
    public abstract class BaseCliente
    {
        public string nombre;
        public int dni;
        public double beneficio;
        public BaseCliente(string _nombre, int _dni)
        {
            nombre = _nombre;
            dni = _dni;
        }
 
    }
}

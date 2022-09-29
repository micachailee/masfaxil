using System;
using System.Collections.Generic;
using System.Text;

namespace Supermercado
{
    class Supermercado: IClienteSuper
    {
        private Compra compra;
        public List<BaseProducto> Productosdisponibles;
        public Supermercado()
        {
            compra= new Compra();
            Productosdisponibles = new List<BaseProducto>();

            
        }
        public void Agregarproducto(BaseProducto producto)
        {  
            Productosdisponibles.Add(producto);

        }
        public void CargarProductos(List<BaseProducto> _listadeproductosdisponibles)
        {
            Productosdisponibles = _listadeproductosdisponibles;
        }
       public void VerProductosDisponibles()
        {
            Console.WriteLine("\n------Productos disponibles-------\n");
            foreach (BaseProducto producto in Productosdisponibles)
            {
                if (producto.TengoStock()) { 
                Console.WriteLine("\n"+producto.nombre + "\t\t" + producto.precio + "\n");
                }
            }
            Console.WriteLine("-----------------------------------------");
        }
        public void AgregarCompra(BaseProducto producto, int cantidaddeproducto)
        { 
            
           compra.Agregarproducto(producto, cantidaddeproducto);
        }
        public void Venta(BaseCliente cliente)
        {
            compra.Mostrarfactura(cliente);
            FindeCompra();

        }
        public void FindeCompra()
        {
            compra.FindeCompra();
        }

    }
}

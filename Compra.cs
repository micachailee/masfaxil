using System;
using System.Collections.Generic;
using System.Text;

namespace Supermercado
{
    class Compra
    {
        List<BaseProducto> Productoselegidos;
        public double saldodecompra;
        public Compra()
        {
            Productoselegidos = new List<BaseProducto>();
            saldodecompra = 0;
        }
        public List<BaseProducto> Agregarproducto(BaseProducto producto ,int cantidaddeproducto)
        {
            for(int i=0; i < cantidaddeproducto; i++)
            {
                if (producto.TengoStock() == false)
                {
                    Console.WriteLine("No se puede realizar la compra, no hay stock de "+producto.nombre+"\nCantidad disponible: "+producto.stock);
                    FindeCompra();
                    break;
                }
                else
                {
                   Productoselegidos.Add(producto);
                   producto.stock -= 1;
                }
            }
            return Productoselegidos; 
        }
        public double Saldodecompra(BaseCliente cliente)
        {
            foreach(BaseProducto producto in Productoselegidos)
            {
                saldodecompra += producto.preciof;
            }
            saldodecompra -=( saldodecompra*cliente.beneficio);
            return saldodecompra;
        }
        public void Mostrarfactura( BaseCliente cliente)
        {
                Console.WriteLine("--------FACTURA DEL CIENTE-------\n Cliente: " + cliente.nombre + "\n D.N.I: " + cliente.dni + "\n Producto: \t\t Precio:\n");
                foreach (BaseProducto producto in Productoselegidos)
                {
                    Console.WriteLine("\n"+producto.nombre + "\t\t" + producto.preciof);
                    if (producto.descuento > 0)
                    {
                    Console.WriteLine("Descuento:\t\t-" + producto.precio * producto.descuento+"\n");
                    }
                }
                Console.WriteLine("\nDescuento cliente: " + cliente.beneficio*100 + "%\n SALDO FINAL: " + Saldodecompra(cliente)+"\n----------fin de compra-----------\n");
        }
  
        public void FindeCompra()
        {
            Productoselegidos.Clear();
            saldodecompra = 0;
        }
    }
}

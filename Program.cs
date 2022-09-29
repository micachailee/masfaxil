using System;

namespace Supermercado
{
    class Program
    {
        static void Main(string[] args)
        {
            
            Supermercado supermercado = new Supermercado();
            Leche leche = new Leche("leche entera",01,99.50,2,0);
            Harina harina = new Harina("Harina 000", 02, 80.99, 4, 0.10);
            supermercado.Agregarproducto(leche);
            supermercado.Agregarproducto(harina);

            BaseCliente cliente1 = new Comun("Marcos", 26875465);
            supermercado.VerProductosDisponibles();
            supermercado.AgregarCompra(leche, 1);
            supermercado.AgregarCompra(harina, 2);
            supermercado.Venta(cliente1);

            BaseCliente cliente2 = new Preferencial("Lucas", 45634232);
            supermercado.VerProductosDisponibles();
            supermercado.AgregarCompra(leche,1);
            supermercado.AgregarCompra(harina, 1);
            supermercado.Venta(cliente2);

            BaseCliente cliente3 = new Comun("Pablo", 2465365);
            supermercado.VerProductosDisponibles();
            supermercado.AgregarCompra(harina, 3);
            
        }
    }
}

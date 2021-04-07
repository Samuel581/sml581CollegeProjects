using System;

namespace barajearCartas
{
    class Program
    {
        static void Main(string[] args)
        {
            Monedero miBolsillo = new Monedero();
            Moneda dolar = new Moneda();
	    
            miBolsillo.añadirMoneda(dolar);
            miBolsillo.añadirMoneda(dolar);
            miBolsillo.añadirMoneda(0.25, "cora");
            miBolsillo.añadirMoneda(0.25, "cora");
            
            Console.WriteLine("Dinero: $" + miBolsillo.consultarTotal());
        }
    }
}

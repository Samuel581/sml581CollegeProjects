using System;

namespace barajearCartas
{
    class Program
    {
        static void Main(string[] args)
        {
            Monedero miBolsillo = new Monedero();
	    
            miBolsillo.añadirMoneda(1, "dólar");
            miBolsillo.añadirMoneda(1, "dólar");
            miBolsillo.añadirMoneda(0.25, "cora");
            miBolsillo.añadirMoneda(0.25, "cora");
            
            Console.WriteLine("Dinero: $" + miBolsillo.consultarTotal());
        }
    }
}

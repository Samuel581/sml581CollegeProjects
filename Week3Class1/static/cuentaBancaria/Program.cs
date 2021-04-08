using System;

namespace cuentaBancaria
{
    class Program
    {
        static void Main() {
        CuentaBancaria cuenta1 = new CuentaBancaria();
        Console.WriteLine("No. de cuenta: " + cuenta1.numeroCuenta);
        
        CuentaBancaria cuenta2 = new CuentaBancaria();
        Console.WriteLine("No. de cuenta: " + cuenta2.numeroCuenta);
        
        CuentaBancaria cuenta3 = new CuentaBancaria();
        Console.WriteLine("No. de cuenta: " + cuenta3.numeroCuenta);
        }
    }
}

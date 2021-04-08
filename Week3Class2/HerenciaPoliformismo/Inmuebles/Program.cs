using System;

namespace Inmuebles
{
    class Program
    {
        static void Main() {
            Inmueble unInmueble = new Inmueble();
            unInmueble.direccion = "San Miguel";
            unInmueble.area = 150.0;
            
            LocalComercial unLocal = new LocalComercial();
            unLocal.direccion = "Santa Ana";
            unLocal.area = 100.0;
            unLocal.nombreNegocio = "Venta de comida";
            
            RanchoPlaya unRancho = new RanchoPlaya();
            unRancho.direccion = "San Blas";
            unRancho.area = 250.0;
            unRancho.cantidadPiscinas = 2;
            
            Hospital unHospital = new Hospital();
            unHospital.direccion = "San Salvador";
            unHospital.area = 1000.0;
            unHospital.cantidadCamas = 2000;
            
            mostrarDatos(unInmueble); // Error!!! no tiene nombreNegocio
            mostrarDatos(unLocal);    // No hay error, funciona bien
            mostrarDatos(unRancho);   // Error!!! no tiene nombreNegocio
            mostrarDatos(unHospital); // Error!!! no tiene nombreNegocio
        }
        
        /* Este método solo podrá funcionar para Locales comerciales
            ya que ni Inmueble ni Ranchos ni Hospitales tienen 
            un atributo llamado "nombreNegocio".
            
        Si hubiera una clase hija de LocalComercial entonces
            este método sí funcionara, ya que sí tuviera nombreNegocio*/
        static void mostrarDatos(LocalComercial unLocal) {
            Console.WriteLine("------Datos------");
            Console.WriteLine("Dirección: " + unLocal.direccion);
            Console.WriteLine("Area: " + unLocal.area + " metros cuadrados");
            Console.WriteLine("Nombre negocio: " + unLocal.nombreNegocio);
        }
    }
}

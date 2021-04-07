using System.Collections.Generic;
using System.Linq;
namespace barajearCartas
{
    public class Monedero {
        private List<Moneda> listaMonedas;

        public Monedero(){
            listaMonedas = new List<Moneda>();
        }
         // Método sobrecargado
        public void añadirMoneda(Moneda unaMoneda){
            listaMonedas.Add(unaMoneda);
        }
        // Método sobrecargado
        public void añadirMoneda(double pValor, string pNombre){
            Moneda unaMoneda = new Moneda(pValor, pNombre);
            
            listaMonedas.Add(unaMoneda);
        }

        public double consultarTotal(){
            double total = 0;
            
            foreach (Moneda unaMoneda in listaMonedas){
                total += unaMoneda.getValor();
            }
            
            return total;
        }
    }
}
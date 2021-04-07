namespace barajearCartas
{
    public class Moneda
    {
        private double valor;
        private string nombre;

        public Moneda(double pValor, string pNombre){
            valor = pValor;
            nombre = pNombre;
        }

        public double getValor(){
            return valor;
        }
        
        public string getNombre(){
            return nombre;
        }
    // No hay setter porque el valor de la moneda
    // no debería de cambiar con el tiempo
    }
}
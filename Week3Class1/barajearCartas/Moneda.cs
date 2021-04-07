namespace barajearCartas
{
    public class Moneda
    {
        private double valor;
        private string nombre;

        // Constructor sobrecargado
        public Moneda(double pValor, string pNombre){
            valor = pValor;
            nombre = pNombre;
        }
        // Constructor sobrecargado
        public Moneda() : this(1, "Un dólar") {// Llamada al otro constructor
            //Otras sentencias, opcional
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
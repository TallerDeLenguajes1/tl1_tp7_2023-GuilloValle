namespace EspacioCalculadora
{

    public class calculadora
    {
        private double dato;

        public double Resultado { get => dato; }

        public void Sumar(double termino)
        {
            dato += termino;
        }
        public void Resta(double termino)
        {
            dato -= termino;
        }
        public void Division(double termino)
        {
            dato /= termino;
        }
        public void Multiplicacion(double termino)
        {
            dato *= termino;
        }
        public void Limpiar()
        {
            dato = 0;
        }
    }

}
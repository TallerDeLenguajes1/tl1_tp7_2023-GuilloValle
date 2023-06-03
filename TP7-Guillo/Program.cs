using EspacioCalculadora;

internal class Program
{
    private static void Main(string[] args)
    {   
        
        calculadora instance = new calculadora();
        System.Console.WriteLine("Bienvendio a la calculadora!!");
        int cont = 1;
        double dato = ValidaIngreso();
        static double ValidaIngreso()
        {
            double dato = 0;
            do
            {
                System.Console.WriteLine("Ingrese un valor numerico use , para la fraccion ");
            } while (!double.TryParse(System.Console.ReadLine(), out dato));
            return dato;
        }
        System.Console.WriteLine("Ingrese que operacion quiere realizar:");
        System.Console.WriteLine("0-Suma");
        System.Console.WriteLine("1-Resta");
        System.Console.WriteLine("2-Division");
        System.Console.WriteLine("3-Multiplicacion");
        System.Console.WriteLine("4-Limpiar");
        int operacion;
        int.TryParse(System.Console.ReadLine(), out operacion);
        while (cont != 0)
        {
            switch (operacion)
            {
                case 0:
                    instance.Sumar(dato);
                    break;
                case 1:
                    instance.Resta(dato);
                    break;
                case 2:
                    instance.Division(dato);
                    break;
                case 3:
                    instance.Multiplicacion(dato);
                    break;
                case 4:
                    instance.Limpiar();
                    break;
                default:
                    System.Console.WriteLine("Usted ah ingresado mal la operacion, por favor vuelva a ingresar.");
                    break;
            }
            System.Console.WriteLine("El resultado acumulado en esta iteracion es:" + instance.Resultado);
            System.Console.WriteLine("Ingrese que operacion quiere realizar:");
            System.Console.WriteLine("0-Suma");
            System.Console.WriteLine("1-Resta");
            System.Console.WriteLine("2-Division");
            System.Console.WriteLine("3-Multiplicacion");
            System.Console.WriteLine("4-Limpiar");
            System.Console.WriteLine("5-Terminar con la calculadora");
            int.TryParse(System.Console.ReadLine(), out operacion);
            if (operacion == 5)
            {
                cont = 0;
            }
            else if (operacion != 4)
            {
                dato = ValidaIngreso();
            }
        }
    }

}
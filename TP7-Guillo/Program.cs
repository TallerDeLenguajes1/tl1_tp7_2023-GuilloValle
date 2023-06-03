using espacioEmpleado;

internal class Program
{
    private static void Main(string[] args)
    {   
        
        
        empleado empleado1 = new empleado();

        empleado1.Nombre = "Guillo";
        empleado1.Apellido = "Valle";
        empleado1.FechaDeNacimiento = new DateTime(1980, 5, 10);
        empleado1.EstadoCivil = 'S';
        empleado1.Genero = 'M';
        empleado1.FechaIngresoAEmpresa = new DateTime(2005, 3, 15);
        empleado1.SueldoBasico = 65000;
        empleado1.Cargo = cargos.Especialista;

        int anti1 = empleado1.Antiguedad();
        System.Console.WriteLine(anti1);

        int edad1 = empleado1.Edad();
        System.Console.WriteLine(edad1);

        int jubi1 = empleado1.aniosParaJubilarse();
        System.Console.WriteLine(jubi1);

        double salario1 = empleado1.cacularSalario();
        System.Console.WriteLine(salario1);
    }

}
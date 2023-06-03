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

        empleado empleado2 = new empleado
        {
            Nombre = "María",
            Apellido = "López",
            FechaDeNacimiento = new DateTime(1985, 9, 20),
            EstadoCivil = 'C',
            Genero = 'F',
            FechaIngresoAEmpresa = new DateTime(2010, 7, 1),
            SueldoBasico = 55000,
            Cargo = cargos.Administrativo
        };

        empleado empleado3 = new empleado
        {
            Nombre = "Pedro",
            Apellido = "Gómez",
            FechaDeNacimiento = new DateTime(1975, 12, 8),
            EstadoCivil = 'C',
            Genero = 'M',
            FechaIngresoAEmpresa = new DateTime(1999, 2, 10),
            SueldoBasico = 70000,
            Cargo = cargos.Ingeniero
        };

        int anti1 = empleado1.Antiguedad();
        System.Console.WriteLine(anti1);

        int edad1 = empleado1.Edad();
        System.Console.WriteLine(edad1);

        int jubi1 = empleado1.aniosParaJubilarse();
        System.Console.WriteLine(jubi1);

        double salario1 = empleado1.cacularSalario();
        System.Console.WriteLine(salario1);

        empleado empleadoMasProximoJubilarse = empleado1;
        int añosProximosJubilarse = empleado1.aniosParaJubilarse();

        if (empleado2.aniosParaJubilarse() < añosProximosJubilarse)
        {
            empleadoMasProximoJubilarse = empleado2;
            añosProximosJubilarse = empleado2.aniosParaJubilarse();
        }

        if (empleado3.aniosParaJubilarse() < añosProximosJubilarse)
        {
            empleadoMasProximoJubilarse = empleado3;
            añosProximosJubilarse = empleado3.aniosParaJubilarse();
        }

        Console.WriteLine("Empleado más próximo a jubilarse:");
        Console.WriteLine($"Nombre: {empleadoMasProximoJubilarse.Nombre}");
        Console.WriteLine($"Apellido: {empleadoMasProximoJubilarse.Apellido}");
        Console.WriteLine($"Edad: {empleadoMasProximoJubilarse.Edad()}");
        Console.WriteLine($"Salario: {empleadoMasProximoJubilarse.cacularSalario()}");

    }

}
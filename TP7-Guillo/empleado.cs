namespace espacioEmpleado
{   

    public enum cargos
        {
        Auxiliar = 1,
        Administrativo = 2,
        Ingeniero = 3,
        Especialista = 4,
        Investigador = 5
        }

    public class empleado
    {
        private string? nombre;

        private string? apellido;

        private DateTime fechaDeNacimiento;
        private char estadoCivil;

        private char genero;

        private DateTime fechaIngresoAEmpresa;
        private double sueldoBasico;
        private cargos cargo;

        public string? Nombre { get => nombre; set => nombre = value; }
        public string? Apellido { get => apellido; set => apellido = value; }
        public DateTime FechaDeNacimiento { get => fechaDeNacimiento; set => fechaDeNacimiento = value; }
        public char EstadoCivil { get => estadoCivil; set => estadoCivil = value; }
        public char Genero { get => genero; set => genero = value; }
        public DateTime FechaIngresoAEmpresa { get => fechaIngresoAEmpresa; set => fechaIngresoAEmpresa = value; }
        public double SueldoBasico { get => sueldoBasico; set => sueldoBasico = value; }
        public cargos Cargo {get => cargo; set => cargo = value; }

    /*--------------------------------------------------------------------------------------------------------------------------------*/
        

    /*--------------------------------------------------------------------------------------------------------------------------------*/


        public int Antiguedad()
        {
        DateTime fechaActual = DateTime.Now;
        TimeSpan tiempoTranscurrido = fechaActual - fechaIngresoAEmpresa;
        return tiempoTranscurrido.Days / 365; // Aproximación a años enteros
        }

         public int Edad()
        {
        DateTime fechaActual = DateTime.Now;
        TimeSpan tiempoTranscurrido = fechaActual - fechaDeNacimiento;
        return tiempoTranscurrido.Days / 365; // Aproximación a años enteros
        }

        public int aniosParaJubilarse()
        {

            int edadActual = Edad();
            int edadJubilatoria;
            if (genero == 'M')
            {
                edadJubilatoria = 65;
            }else
            {
                edadJubilatoria = 60;
            }

            int añosFaltantes = edadJubilatoria - edadActual;
            
            if (añosFaltantes <= 0)
            {
                return 0;
            }else
            {
                return añosFaltantes;
            }

        }

        public double cacularSalario()
        {   
            double adicional;
            if (Antiguedad() < 20)
            {
                adicional = sueldoBasico * Antiguedad()/100;
            }else
            {
                adicional = sueldoBasico * 0.25;
            }

            if (cargo == cargos.Ingeniero || cargo == cargos.Especialista )
            {
                adicional = adicional * 1.5;
            }

            if (estadoCivil == 'C')
            {
                adicional = adicional + 15000;
            }

            return sueldoBasico + adicional;
        }

    }

    

}
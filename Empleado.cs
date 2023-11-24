using System;

namespace MiEmpresa
{
    public class Empleado : IMostrarInformacion
    {
        public string Nombre { get; set; }
        public double Salario { get; set; }

        public Empleado(string nombre, double salario)
        {
            Nombre = nombre;
            Salario = salario;
        }
        //Calculo del salario 
        public double CalcularSalarioAnual()
        {
            return Salario * 12;
        }

        public void MostrarInformacion()
        {
            Console.WriteLine($"Empleado: {Nombre}");
            Console.WriteLine($"Salario Mensual: {Salario:C}");
            Console.WriteLine($"Salario Anual: {CalcularSalarioAnual():C}");
        }
    }
}
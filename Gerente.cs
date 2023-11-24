using System;

namespace MiEmpresa
{
    public class Gerente : Empleado, IMostrarInformacion
    {
        public string Departamento { get; set; }

        public Gerente(string nombre, double salario, string departamento) : base(nombre, salario)
        {
            Departamento = departamento;
        }

        public new void MostrarInformacion()
        {
            Console.WriteLine($"Gerente: {Nombre}");
            Console.WriteLine($"Departamento: {Departamento}");
            Console.WriteLine($"Salario Mensual: {Salario:C}");
            Console.WriteLine($"Salario Anual: {CalcularSalarioAnual():C}");
        }
    }
}
using System;

namespace MiEmpresa
{
    
    class Program
    {
        static void Main()
        {
            Empleado empleado = new Empleado("Juan Esteban Reyes Ortiz", 5000);
            Gerente gerente = new Gerente("Luis Santiago Lopez Reyes :", 8000, "Recursos Humanos");

            Console.WriteLine("Información del Empleado:");
            MostrarInformacion(empleado);

            Console.WriteLine("\nInformación del Gerente:");
            MostrarInformacion(gerente);
        }

        static void MostrarInformacion(IMostrarInformacion entidad)
        {
            entidad.MostrarInformacion();
        }
    }
}

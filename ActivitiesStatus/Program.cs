using System;
using System.Data.SqlClient;

class Program
{
    static string connectionString = "Server=localhost; Database=activities_status; Trusted_Connection=True;";

    static void Main()
    {
        while (true)
        {
            Console.WriteLine("\n1. Crear tarea \n2. Mostrar tareas \n3. Modificar tarea \n4. Eliminar tarea \n5. Salir");
            Console.Wirte("Seleccione una opcion: ");

            string option = Console.ReadLine();

        }
    }

}
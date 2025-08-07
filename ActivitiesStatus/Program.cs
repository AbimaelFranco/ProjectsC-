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
            Console.Write("Seleccione una opcion: ");

            string option = Console.ReadLine();

            switch (option)
            {
                case "1":
                    CreateTask();
                    break;
                case "2":
                    // ShowTask();
                    break;
                case "3":
                    // UpdateTask();
                    break;
                case "4":
                    // DeleteTask();
                    break;
                case "5":
                    return;
            }

        }
    }

    static void ConexionSQL(string action, string name, string description, string status)
    {
        using SqlConnection conn = new(connectionString);
        conn.Open();

        switch (action)
        {
            case "create":
                {
                    string query = "INSERT INTO tasks (Task, Descripcion, Estatus) VALUES (@name, @description, @status)";
                    using SqlCommand cmd = new(query, conn);
                    cmd.Parameters.AddWithValue("@name", name);
                    cmd.Parameters.AddWithValue("@description", description);
                    cmd.Parameters.AddWithValue("@status", status);
                    int filas = cmd.ExecuteNonQuery();
                    Console.WriteLine("Accion realizada correctamente");
                    break;
                }
            default:
                Console.WriteLine("Accion no valida");
                return;
        }

    }

    static void CreateTask()
    {
        Console.WriteLine("Nombre de la tarea: ");
        string name = Console.ReadLine();

        Console.WriteLine("Descripcion de la tarea: ");
        string description = Console.ReadLine();

        Console.WriteLine("Estatus de la tarea: ");
        string status = Console.ReadLine();

        ConexionSQL("create", name, description, status);

    }

}


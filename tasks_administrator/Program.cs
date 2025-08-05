using System;
using System.Data.SqlClient;

class Program
{
    static string connectionString = "Server=localhost;Database=tasks_administrator;Trusted_Connection=True;";

    static void Main()
    {
        while (true)
        {
            Console.WriteLine("\n1. Crear persona \n2. Leer personas \n3. Actualizar persona \n4. Eliminar persona \n5. Salir");
            Console.Write("Seleccione una opcion: ");
            string option = Console.ReadLine();

            switch (option)
            {
                case "1":
                    CreatePerson();
                    break;
                case "2":
                    // ReadPerson();
                    break;
                case "3":
                    // UpdatePerson();
                    break;
                case "4":
                    // DeletePereson();
                    break;
                case "5":
                    break;
                default:
                    Console.WriteLine("Opcion no valida");
                    break;
            }
        }
    }

    static void CreatePerson()
    {
        Console.Write("Ingrese el nombre: ");
        string name = Console.ReadLine();

        Console.Write("Ingrese el edad: ");
        string age = Console.ReadLine();

        using SqlConnection conn = new(connectionString);
        conn.Open();

        String query = "INSERT INTO Peresonas (Nombre, Edad) VALUES (@name, @age)";
        using SqlCommand cmd = new(query, conn);
        cmd.Parameters.AddWithValue("@name", name);
        cmd.Parameters.AddWithValue("@age", age);

        int filas = cmd.ExecuteNonQuery();
        Console.WriteLine($"{filas} persona(s) creada(s)");



    }
}
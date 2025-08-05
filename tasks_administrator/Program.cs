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
                    ReadPerson();
                    break;
                case "3":
                    UpdatePerson();
                    break;
                case "4":
                    DeletePerson();
                    break;
                case "5":
                    return;
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

        String query = "INSERT INTO Personas (Nombre, Edad) VALUES (@name, @age)";
        using SqlCommand cmd = new(query, conn);
        cmd.Parameters.AddWithValue("@name", name);
        cmd.Parameters.AddWithValue("@age", age);

        int filas = cmd.ExecuteNonQuery();
        Console.WriteLine($"{filas} persona(s) creada(s)");



    }

    static void ReadPerson()
    {
        using SqlConnection conn = new(connectionString);
        conn.Open();

        string query = "SELECT * FROM Personas";
        using SqlCommand cmd = new(query, conn);
        using SqlDataReader reader = cmd.ExecuteReader();

        while (reader.Read())
        {
            Console.WriteLine($"ID: {reader["Id"]}, Nombre: {reader["Nombre"]}, Edad: {reader["Edad"]}");
        }
    }

    static void UpdatePerson()
    {
        Console.Write("ID de la persona a actualizar: ");
        int id = int.Parse(Console.ReadLine());

        Console.Write("Nuevo nombre: ");
        string name = Console.ReadLine();

        Console.Write("Nueva edad: ");
        int age = int.Parse(Console.ReadLine());

        using SqlConnection conn = new(connectionString);
        conn.Open();

        string query = "UPDATE Personas SET Nombre = @name, Edad = @age WHERE Id = @id";
        using SqlCommand cmd = new(query, conn);
        cmd.Parameters.AddWithValue("@name", name);
        cmd.Parameters.AddWithValue("@age", age);
        cmd.Parameters.AddWithValue("@id", id);

        int filas = cmd.ExecuteNonQuery();
        Console.WriteLine($"{filas} persona(s) actualizada(s)");
    }

    static void DeletePerson()
    {
        Console.Write("ID de la persona a eliminar:");
        int id = int.Parse(Console.ReadLine());

        using SqlConnection conn = new(connectionString);
        conn.Open();

        string query = "DELETE FROM Personas WHERE ID = @id";
        using SqlCommand cmd = new(query, conn);
        cmd.Parameters.AddWithValue("@id", id);

        int filas = cmd.ExecuteNonQuery();
        Console.WriteLine($"{filas} persona(s) eliminada(s)");
    }
}
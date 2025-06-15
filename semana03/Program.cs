using System;

public class Estudiante
{
    // Propiedades del estudiante
    public int Id { get; set; }
    public string Nombres { get; set; }
    public string Apellidos { get; set; }
    public string Direccion { get; set; }
    public string[] Telefonos { get; set; }

    // Constructor de la clase Estudiante
    public Estudiante(int id, string nombres, string apellidos, string direccion, string[] telefonos)
    {
        Id = id;
        Nombres = nombres;
        Apellidos = apellidos;
        Direccion = direccion;

        // Validar que el array de teléfonos tenga exactamente 3 valores
        if (telefonos.Length == 3)
        {
            Telefonos = telefonos;
        }
        else
        {
            throw new ArgumentException("El array de teléfonos debe contener exactamente 3 números.");
        }
    }

    // Método para mostrar la información del estudiante
    public void MostrarInformacion()
    {
        Console.WriteLine($"ID: {Id}");
        Console.WriteLine($"Nombres: {Nombres}");
        Console.WriteLine($"Apellidos: {Apellidos}");
        Console.WriteLine($"Dirección: {Direccion}");
        Console.WriteLine("Teléfonos:");
        for (int i = 0; i < Telefonos.Length; i++)
        {
            Console.WriteLine($"  Teléfono {i + 1}: {Telefonos[i]}");
        }
    }
}

class Program
{
    static void Main()
    {
        try
        {
            // Array con tres números de teléfono ecuatorianos
            string[] telefonos = new string[]
            {
                "0988595149",    // Tu número de teléfono
                "0991234567",    // Ejemplo de número de teléfono
                "0977654321"     // Ejemplo de número de teléfono
            };

            // Crear el objeto estudiante con tus datos
            Estudiante estudiante = new Estudiante(
                id: 1,
                nombres: "Gabriela",
                apellidos: "Plaza",
                direccion: "El Coca, Calles Amazonas y Río Coca",
                telefonos: telefonos
            );

            // Mostrar información del estudiante
            estudiante.MostrarInformacion();
        }
        catch (Exception ex)
        {
            Console.WriteLine("Error: " + ex.Message);
        }
    }
}


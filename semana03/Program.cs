using System;

public class Estudiante
{
    // Propiedad para almacenar el ID único del estudiante
    public int Id { get; set; }

    // Nombres completos del estudiante
    public string Nombres { get; set; }

    // Apellidos completos del estudiante
    public string Apellidos { get; set; }

    // Dirección residencial del estudiante
    public string Direccion { get; set; }

    // Array con tres números de teléfono que el estudiante utiliza
    public string[] Telefonos { get; set; }

    // Constructor personalizado que inicializa todos los datos del estudiante
    public Estudiante(int id, string nombres, string apellidos, string direccion, string[] telefonos)
    {
        if (telefonos == null || telefonos.Length != 3)
            throw new ArgumentException("Por favor, ingrese exactamente tres números de teléfono.");

        Id = id;
        Nombres = nombres;
        Apellidos = apellidos;
        Direccion = direccion;
        Telefonos = telefonos;
    }

    // Método para mostrar todos los datos del estudiante en consola
    public void MostrarInformacion()
    {
        Console.WriteLine("Información completa del estudiante:");
        Console.WriteLine($"ID: {Id}");
        Console.WriteLine($"Nombres: {Nombres}");
        Console.WriteLine($"Apellidos: {Apellidos}");
        Console.WriteLine($"Dirección: {Direccion}");
        Console.WriteLine("Teléfonos asignados:");
        for (int i = 0; i < Telefonos.Length; i++)
        {
            Console.WriteLine($"  Teléfono {i + 1}: {Telefonos[i]}");
        }
    }
}

class ProgramaGabrielaPlaza
{
    static void Main(string[] args)
    {
        // Detalle personalizado de dirección con calles Amazonas y Río Coca
        string direccionPersonalizada = "Intersección de Calles Amazonas y Río Coca, Ciudad del Coca";

        // Array con los tres teléfonos ecuatorianos válidos
        string[] misTelefonos = new string[] { "0988595149", "0991234567", "0987654321" };

        // Crear instancia de Estudiante con datos personalizados
        Estudiante estudiante = new Estudiante(
            1,
            "Gabriela",
            "Plaza",
            direccionPersonalizada,
            misTelefonos
        );

        // Mostrar en consola la información completa del estudiante
        estudiante.MostrarInformacion();

        Console.WriteLine("\n¡Programa ejecutado correctamente! Presione cualquier tecla para cerrar.");
        Console.ReadKey();
    }
}


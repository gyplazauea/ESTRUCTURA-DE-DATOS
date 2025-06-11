// Clase que representa un círculo
public class Circulo
{
    // Propiedad que almacena el radio del círculo
    public double Radio { get; set; }

    // Constructor que inicializa el radio
    public Circulo(double radio)
    {
        Radio = radio;
    }

    // CalcularArea es una función que devuelve un valor double, se utiliza para calcular el área de un círculo, requiere como argumento el radio del círculo
    public double CalcularArea()
    {
        return Math.PI * Radio * Radio;
    }

    // CalcularPerimetro es una función que devuelve un valor double, se utiliza para calcular el perímetro de un círculo
    public double CalcularPerimetro()
    {
        return 2 * Math.PI * Radio;
    }
}
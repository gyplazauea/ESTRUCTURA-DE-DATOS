    // Clase que representa un rectángulo
    public class Rectangulo
    {
        // Propiedades que almacenan la base y la altura del rectángulo
        public double Base { get; set; }
        public double Altura { get; set; }

        // Constructor que inicializa la base y la altura
        public Rectangulo(double baseRectangulo, double altura)
        {
            Base = baseRectangulo;
            Altura = altura;
        }

        // CalcularArea es una función que devuelve un valor double, se utiliza para calcular el área de un rectángulo
        public double CalcularArea()
        {
            return Base * Altura;
        }

        // CalcularPerimetro es una función que devuelve un valor double, se utiliza para calcular el perímetro de un rectángulo
        public double CalcularPerimetro()
        {
            return 2 * (Base + Altura);
        }
    }

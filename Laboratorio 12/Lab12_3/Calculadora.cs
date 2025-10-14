using System;

namespace Lab12_3
{
    // Clase Calculadora con funciones reutilizables para los ejercicios del laboratorio.
    // Comentarios estilo estudiante: explico brevemente cada método.
    public static class Calculadora
    {
        // Calcula distancia = velocidad * tiempo
        public static double CalcularDistancia(double velocidad, double tiempo) => velocidad * tiempo;

        // Calcula el promedio de 3 notas
        public static double Promedio(double n1, double n2, double n3) => (n1 + n2 + n3) / 3.0;

        // Calcula semiperímetro para Herón
        public static double Semiperimetro(double a, double b, double c) => (a + b + c) / 2.0;

        // Calcula área usando fórmula de Herón; lanza excepción si no es triángulo válido
        public static double AreaTriangulo(double a, double b, double c)
        {
            if (!EsTrianguloValido(a,b,c)) throw new ArgumentException("Lados no válidos para un triángulo.");
            double s = Semiperimetro(a,b,c);
            return Math.Sqrt(s * (s - a) * (s - b) * (s - c));
        }

        public static bool EsTrianguloValido(double a, double b, double c) =>
            a > 0 && b > 0 && c > 0 && a + b > c && a + c > b && b + c > a;
    }
}

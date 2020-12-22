using System;
using System.Globalization;

namespace Course
{

    /*
     * CRIE UM PROGRAMA PARA LER AS MEDIDAS DOS LADOS DE
    DOIS TRIÂNGULOS X E Y (MEDIDAS VÁLIDAS). EM SEGUIDA,
    MOSTRE O VALOR DAS ÁREAS DOS DOIS TRIÂNGULOS E
    MOSTRAR QUAL DOS DOIS POSSUI A MAIOR ÁREA.
    */

    public class Program
    {
        public static void Main(string[] args)
        {
            Triangulo x, y;

            x = new Triangulo();
            y = new Triangulo();

            Console.WriteLine("Informe as medidas dos lados do triângulo X: ");
            x.A = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            x.B = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            x.C = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            double areaX = x.Area();

            Console.WriteLine("Informe as medidas dos lados do triângulo Y: ");
            y.A = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            y.B = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            y.C = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            double areaY = y.Area();

            Console.WriteLine("A área do triângulo X é: " + areaX.ToString("F4", CultureInfo.InvariantCulture));
            Console.WriteLine("A área do triângulo Y é: " + areaY.ToString("F4", CultureInfo.InvariantCulture));

            if (areaX > areaY)
            {
                Console.WriteLine("O triângulo X tem a maior área");
            }
            else
            {
                Console.WriteLine("O triângulo Y tem a maior área");
            }
        }
    }
}

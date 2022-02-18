using System;

namespace ConsoleApp1.ExercicioUmListaUm
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Imobiliária Imóbilis");
            Console.WriteLine("Area de um retangulo b x h (base x altura)");
            while (true)
            {
                Console.WriteLine("=========================");
                double B, H, Area;
                Console.Write("Digite a base: ");
                B = Convert.ToDouble(Console.ReadLine());
                Console.Write("Digite a altura: ");
                H = Convert.ToDouble(Console.ReadLine());

                Area = B * H;
                Console.WriteLine("A área do terreno é : " + Area);

            } while (true);
        }
    }
}

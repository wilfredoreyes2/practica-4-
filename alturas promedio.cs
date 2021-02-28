using System;

namespace promedio_de_alturas
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("intodudca 1 altura ");
            double[] numero;
            numero = new double[5];

            numero[0] = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("sigiente altura ");

            numero[1] = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("sigiente altura ");

            numero[2] = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("sigiente altura ");

            numero[3] = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("sigiente altura ");

            numero[4] = Convert.ToInt32(Console.ReadLine());


            double promedio2;
            double promedio;

            promedio = numero[0] + numero[1] + numero[2] + numero[3] + numero[4];

            promedio2 = promedio / 4;

            Console.WriteLine("su promedio es ");

            Console.WriteLine(promedio2);

            Console.WriteLine("mas alto es ");
            Console.WriteLine(numero [3]);

            Console.WriteLine("mas bajo es ");
            Console.WriteLine(numero[3]);


        }
    }
}

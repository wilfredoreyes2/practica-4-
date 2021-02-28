using System;

namespace _5_numeros_del_reves
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("intodudca 1 de 5 numeros ");

            Console.WriteLine("intodudca 1 numeros ");
            int[] numero;
            numero = new int[5];

            numero[0] = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("sigiente numero ");

            numero[1] = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("sigiente numero ");

            numero[2] = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("sigiente numero ");

            numero[3] = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("sigiente numero ");

            numero[4] = Convert.ToInt32(Console.ReadLine());



            Console.WriteLine("los numeros al reves son ");

            Console.WriteLine(numero[4]);

            Console.WriteLine(numero[3]);

            Console.WriteLine(numero[2]);

            Console.WriteLine(numero[1]);

            Console.WriteLine(numero[0]);




        }
    }
}

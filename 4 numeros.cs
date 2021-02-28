using System;

namespace _4_numeros
{
    class Program
    {
        static void Main(string[] args)
        { Console.WriteLine("intodudca 1 numeros ");
            int[] numero;
            numero = new int[4];

            numero[0] = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("sigiente numero ");
             
            numero[1] = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("sigiente numero ");

            numero[2] = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("sigiente numero ");

            numero[3] = Convert.ToInt32(Console.ReadLine());


            int promedio2;
            int promedio;

            promedio = numero[0] + numero[1] + numero[2] + numero[3];

            promedio2= promedio/4;

            Console.WriteLine("su promedio es ");

            Console.WriteLine(promedio2);

            Console.WriteLine("los numeros dijitados fueron " + numero[0]);

            Console.WriteLine(numero[1]);
          
            Console.WriteLine(numero[2]);
          
            Console.WriteLine(numero[3]);
        }
    }
} 

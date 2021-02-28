using System;

namespace nombre_y_esdad
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("untroduzca su nombre ");

            string n = Console.ReadLine());

            Console.WriteLine("itroduzca su edad  ");

            double a = double.Parse(Console.ReadLine()); 

            if (a < 18)
            {
                Console.WriteLine(" lo sentimos pero no eres mayor de edad joven " + n);
            }
            else Console.WriteLine("aprobado " + n);
            Console.WriteLine(" mayor bienbenido al desmadre ");

        }


    }
}

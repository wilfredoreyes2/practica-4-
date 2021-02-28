using System;

namespace nombres
{
    class Program
    {
        static void Main(string[] args)
        {
          
            
            Console.WriteLine("cunatos nombres va ingrear maximo 100");
            int numeros = int.Parse(Console.ReadLine());
            Console.WriteLine("porfavor introduzca los nombres");
            string nom = Console.ReadLine();
           
            string[] nombres = new string[100];

            for (int i = 0; i <numeros; i++)
            {
                nombres[i] = nom;


                Console.WriteLine("los nombres son " + nombres[i]);
            }


        } 


    }
}

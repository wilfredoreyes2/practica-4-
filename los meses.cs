using System;

namespace dias_de_los_meces
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("introduzca el numero del mes que desea consultar ");
           
            
            int n;

            n = Convert.ToInt32(Console.ReadLine());
            int[] numero;
            numero = new int[12];

            numero[0] = 31;

            numero[1] = 28;

            numero[2] = 31;

            numero[3] = 30;

            numero[4] = 31;

            numero[5] = 30;

            numero[6] = 31;

            numero[7] = 30;

            numero[8] = 31;

            numero[9] = 30;

            numero[10] = 30;

            numero[11] = 31;



            int[] mes;
            mes = new int[12];

            mes[0] = 1;

            mes[1] = 2;

            mes[2] = 3;

            mes[3] = 4;

            mes[4] = 5;

            mes[5] = 6;

            mes[6] = 7;

            mes[7] = 8;

            mes[8] = 9;

            mes[9] = 10;

            mes[10] = 11;


           mes[11] = 12;

            if (n = 1)
            {
                Console.WriteLine("el numero del mes es :" + numero[0]);

            }
            else if (n = 2) ;
            {

                Console.WriteLine("el numero del mes es :" + numero[1]);

            }
            else if (n = 3) ;
            {

                Console.WriteLine("el numero del mes es :" + numero[2]);

            }
            else if (n = 4) ;
            {

                Console.WriteLine("el numero del mes es :" + numero[3]);

            }
            else if (n = 5) ;
            {

                Console.WriteLine("el numero del mes es :" + numero[4]);

            }
            else if (n = 6) ;
            {

                Console.WriteLine("el numero del mes es :" + numero[5]);

            }
            else if (n = 7) ;
            {

                Console.WriteLine("el numero del mes es :" + numero[6]);

            }
            else if (n = 8) ;
            {

                Console.WriteLine("el numero del mes es :" + numero[7]);

            }
            else if (n = 9) ;
            {
                Console.WriteLine("el numero del mes es :" + numero[8]);

            }
            else if (n = 10) ;
            {

                Console.WriteLine("el numero del mes es :" + numero[9]);

            }
            else if (n = 11) ;
            {

                Console.WriteLine("el numero del mes es :" + numero[10]);

            }
            else if (n = 12) ;
            {

                Console.WriteLine("el numero del mes es :" + numero[11]);

            }
            else Console.WriteLine("el mes no es valido , volver a intentarlo ");


           
        }
        }
        }







using System;
using System.Numerics;

namespace MyApp // Note: actual namespace depends on the project name.
{
    internal class Program
    {
        static void Main(string[] args)
        {
           int[,] matrizBidimencional = new int[3, 4];

           for (int fila = 0; fila < 3; fila++)
           {
                for (int columna = 0; columna < 4; columna++)
                {
                    matrizBidimencional[fila, columna] = fila * 4 + columna + 1;
                }
           }

            Console.WriteLine("\nArreglo Bidimensional: ");
            for (int fila = 0; fila < 3; fila++)
            {
                 for (int columna = 0; columna < 4; columna++)
                {
                   Console.WriteLine(matrizBidimencional[fila, columna]  + "\t");
                }
            }


            int[,,] matrizTridimencional = new int[3, 3, 4];

            for (int caja = 0; caja < 3; caja++)
            {
                 for (int fila = 0; fila < 3; fila++)
                {
                   for (int columna = 0; columna < 4; columna++)
                   {
                        matrizTridimencional[caja, fila, columna] = caja * 12 + fila  * 4 + columna + 1;
                   }
                }
            }


            Console.WriteLine("\nArreglo Tridimencional");
            for (int caja = 0; caja < 3; caja++)
            {
                for (int fila = 0; fila < 3; fila++)
                {
                    for (int columna = 0; columna < 4; columna++ )
                    {
                        Console.WriteLine(matrizTridimencional[caja, fila, columna] + "\t");
                    }
                    Console.WriteLine();
                }
            }

            Console.WriteLine();
        } //Fin del main
           
    }
}

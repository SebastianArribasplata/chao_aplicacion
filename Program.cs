﻿using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace chao_aplicacion
{
    internal class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine("Ingrese # Fila:"); 
            int f = int .Parse(Console.ReadLine());
            Console.WriteLine("Ingrese # Columnas:");
            int c  = int.Parse(Console.ReadLine());

            int[,] matriz = new int[f, c];
            Random rnd = new Random();
            for (int i = 0;i<  matriz.GetLength(0); i++)
            {
                for (int j = 0;j < matriz.GetLength(1); j++)
                {
                    matriz[i, j] = rnd.Next(30, 51);
                    Console.Write(matriz[i,j]+"\t");
                }
                Console.WriteLine();
            }
            Console.ReadKey();
        }
    }
}

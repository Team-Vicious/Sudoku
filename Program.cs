using System;
using System.Collections.Generic;
using System.Text;

namespace SudokuMatriz
{
    class Program
    {
        public static void Main(string[] args)
        {

            int numeroJuego;
            int[,] matriz = new int[9,9];

            Console.WriteLine("Ingrese el numero de juego");
            numeroJuego = int.Parse(Console.ReadLine());

            switch (numeroJuego)
            {

                case 1:

                    matriz[0,0]= 5; matriz[0,4]= 7; matriz[0,6]=9; matriz[1,0]= 6;
                    matriz[1,3]= 1; matriz[1,4]= 9; matriz[1,6]= 6; matriz[1,7]= 2;
                    matriz[1,8] = 7; matriz[2, 2] = 6; matriz[2, 8] = 9; matriz[3, 0] = 9;
                    matriz[3, 2] = 3; matriz[3, 6] = 8; matriz[4, 3] = 4; matriz[4, 5] = 3;
                    matriz[5, 2] = 8; matriz[5, 6] = 5; matriz[5, 8] = 2; matriz[6, 0] = 5;
                    matriz[6, 6] = 2; matriz[7, 0] = 2; matriz[7, 1] = 9; matriz[7, 2] = 1;
                    matriz[7, 4] = 4; matriz[7, 5] = 7; matriz[7, 8] = 8; matriz[8, 2] = 7;
                    matriz[8, 4] = 1; matriz[8, 8] = 3;

                   

                    Console.WriteLine("La matriz 1 es:");
                    Console.WriteLine(" ");

                    for (int filas =0; filas< 9; filas++)
                    {
                        if (filas % 3 == 0)
                        {
                            Console.WriteLine(" ");

                        }
                        for (int col =0; col<9; col++)
                        {
                            

                            if (col % 3 == 0 || col == 9)
                            {
                                Console.Write(" ");

                            }
                            Console.Write("[" + matriz[filas, col] + "]");


                        }
                        Console.WriteLine(" ");

                    }

                    Console.WriteLine("A continución empiece a jugar");

                    
                  while(matriz[0, 1]!=3)
                    {
                        Console.WriteLine("ingrese el numero para la celda 1" );
                    matriz[0, 1] = int.Parse(Console.ReadLine());

                    }
                    while (matriz[0, 3] != 5)
                    {
                        Console.WriteLine("ingrese el numero para la celda 2");
                        matriz[0, 3] = int.Parse(Console.ReadLine());

                    }




                        break;


                case 2:


                    matriz[0, 0] = 7; matriz[0, 4] = 5; matriz[0, 6] = 4; matriz[1, 0] = 4;
                    matriz[1, 3] = 1; matriz[1, 4] = 9; matriz[1, 6] = 6; matriz[1, 7] = 2;
                    matriz[1, 8] = 7; matriz[2, 2] = 6; matriz[2, 8] = 9; matriz[3, 0] = 9;
                    matriz[3, 2] = 3; matriz[3, 6] = 8; matriz[4, 3] = 4; matriz[4, 5] = 3;
                    matriz[5, 2] = 8; matriz[5, 6] = 5; matriz[5, 8] = 2; matriz[6, 0] = 5;
                    matriz[6, 6] = 2; matriz[7, 0] = 2; matriz[7, 1] = 9; matriz[7, 2] = 1;
                    matriz[7, 4] = 4; matriz[7, 5] = 7; matriz[7, 8] = 8; matriz[8, 2] = 7;
                    matriz[8, 4] = 1; matriz[8, 8] = 5;

                    break;

                Default:
                    Console.WriteLine("Ingerso un numero incorrecto");
                    break;

            }


        }
       




    }
    }




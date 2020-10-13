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

                    matriz[0,0]= 5; matriz[0,1]= 3; matriz[0,4]=7; matriz[1,0]= 6;
                    matriz[1,3]= 1; matriz[1,4]= 9; matriz[1,5]= 5; matriz[2,1]= 9;
                    matriz[2,2] = 8; matriz[2,7] = 6; matriz[3,0] = 8; matriz[3,4] = 6;
                    matriz[3,8] = 3; matriz[4, 0] = 4; matriz[4,3] = 8; matriz[4,5] = 3;
                    matriz[4,8] = 1; matriz[5, 0] = 7; matriz[5,4] = 2; matriz[5,8] = 6;
                    matriz[6, 1] = 6; matriz[6,6] = 2; matriz[6,7] = 8; matriz[7,3] = 4;
                    matriz[7, 4] = 1; matriz[7, 5] = 9; matriz[7, 8] = 5; matriz[8,4] = 8;
                    matriz[8, 7] = 7; matriz[8, 8] = 9;

                   

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

                    
                  while(matriz[0, 1]!=4)
                    {
                        Console.WriteLine("ingrese el numero para la celda 3" );
                    matriz[0, 1] = int.Parse(Console.ReadLine());

                    }
                    while (matriz[0, 3] != 6)
                    {
                        Console.WriteLine("ingrese el numero para la celda 4");
                        matriz[0, 3] = int.Parse(Console.ReadLine());

                    }
                    while (matriz[0, 5] != 8)
                    {
                        Console.WriteLine("ingrese el numero para la celda 6");
                        matriz[0, 5] = int.Parse(Console.ReadLine());

                    }
                    while (matriz[0, 6] != 9)
                    {
                        Console.WriteLine("ingrese el numero para la celda 7");
                        matriz[0, 6] = int.Parse(Console.ReadLine());

                    }
                    while (matriz[0, 7] != 1)
                    {
                        Console.WriteLine("ingrese el numero para la celda 8");
                        matriz[0, 3] = int.Parse(Console.ReadLine());

                    }
                    while (matriz[0, 8] != 2)
                    {
                        Console.WriteLine("ingrese el numero para la celda 9");
                        matriz[0, 8] = int.Parse(Console.ReadLine());

                    }
                    while (matriz[1,1] != 7)
                    {
                        Console.WriteLine("ingrese el numero para la celda 11");
                        matriz[1,1] = int.Parse(Console.ReadLine());

                    }
                    while (matriz[1,2] != 2)
                    {
                        Console.WriteLine("ingrese el numero para la celda 12");
                        matriz[1, 2] = int.Parse(Console.ReadLine());

                    }
                    while (matriz[1, 6] != 3)
                    {
                        Console.WriteLine("ingrese el numero para la celda 16");
                        matriz[1, 6] = int.Parse(Console.ReadLine());

                    } while (matriz[1, 7] != 4)
                    {
                        Console.WriteLine("ingrese el numero para la celda 17");
                        matriz[1, 4] = int.Parse(Console.ReadLine());

                    }
                    while (matriz[1, 8] != 8)
                    {
                        Console.WriteLine("ingrese el numero para la celda 18");
                        matriz[1, 8] = int.Parse(Console.ReadLine());

                    }
                    ////continuar desde la celda [2,1]inclusive


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




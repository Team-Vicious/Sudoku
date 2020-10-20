using System;
using System.Collections.Generic;
using System.Numerics;
using System.Text;

namespace SudokuInterfaz
{
    class Matriz
    {
        //int[] vectorsolucion = { 5, 3, 4, 6, 7, 8, 9, 1, 2, 6, 7, 2, 1, 9, 5, 3, 4, 8, 1, 9, 8, 3, 4, 2, 5, 6, 7, 8, 5, 9, 7, 6, 1, 4, 2, 3, 4, 2, 6, 8, 5, 3, 7, 9, 1, 7, 1, 3, 9, 2, 4, 8, 5, 6, 9, 6, 1, 5, 3, 7, 2, 8, 4, 2, 8, 7, 4, 1, 9, 6, 3, 5, 3, 4, 5, 2, 8, 6, 1, 7, 9 };
        //int[] vector = { 5, 3, 4, 6, 7, 8, 9, 0, 0, 6, 7, 2, 1, 9, 5, 0, 0, 8, 1, 9, 8, 3, 4, 2, 0, 0, 0, 0, 5, 0, 7, 6, 0, 4, 0, 0, 0, 2, 6, 8, 0, 3, 7, 9, 1, 7, 1, 3, 9, 2, 4, 8, 5, 0, 9, 6, 1, 5, 3, 0, 2, 8, 4, 2, 0, 7, 4, 1, 0, 6, 3, 5, 3, 4, 5, 2, 8, 6, 0, 7, 9 };
        FileWork filework = new FileWork();
        public int[] vectorsolucion = new int[81];
        public int[] vector = new int[81];
        public void llenar()
        {
            vectorsolucion = filework.elegir(1);
            vector = filework.elegir(2);
        }



        int[,] matriz = new int[9, 9];
        


        public void Llenarimprimir()
        {


            int recorre = 0;
            for (int i = 0; i < 9; i++)
            {
                if (i % 3 == 0)
                {
                    Console.WriteLine(" ");

                }
                Console.WriteLine(" ");
                for (int j = 0; j < 9; j++)
                {
                    if (j % 3 == 0 || j == 9)
                    {
                        Console.Write(" ");

                    }
                    matriz[i, j] = vector[recorre];

                    if (vector[recorre] == 0)
                    {
                        Console.Write("[ ]");
                    }
                    else
                    {
                        Console.Write("[" + matriz[i, j] + "]");
                    }
                    recorre++;


                }
                Console.WriteLine(" ");
            }

            

        }


        public void Completar()
        {

            int recorre = 0;
            int auxiliar = 0;

            for (int i = 0; i < 9; i++)
            {
                for (int j = 0; j < 9; j++)
                {
                    if (vector[recorre] == 0)
                    {
                        while (auxiliar != vectorsolucion[recorre])
                        {

                            Console.Write("agregue el numero de la fila: " + (i + 1) + " columna: " + (j + 1) + " = ");
                            auxiliar = int.Parse(Console.ReadLine());
                            Console.WriteLine();

                            if(auxiliar != vectorsolucion[recorre])
                            {
                                Console.WriteLine("Numero incorrecto!");
                                Console.WriteLine();
                            }
                            


                        }

                        //matriz[i, j] = auxiliar;
                        vector[recorre] = vectorsolucion[recorre];
                        matriz[i, j] = vectorsolucion[recorre];
                        Console.WriteLine();
                        imprimir();


                    }
                    recorre++;
                }


            }

            


        }

        public void imprimir()
        {


            int recorre = 0;
            for (int i = 0; i < 9; i++)
            {
                if (i % 3 == 0)
                {
                    Console.WriteLine(" ");

                }

                Console.WriteLine(" ");


                for (int j = 0; j < 9; j++)
                {

                    if (j % 3 == 0 || j == 9)
                    {
                        Console.Write(" ");

                    }

                    //matriz[i, j] = vector[recorre];

                    if (vector[recorre] == 0)
                    {
                        Console.Write("[ ]");
                    }
                    else
                    {
                        Console.Write("[" + matriz[i, j] + "]");
                    }
                    recorre++;


                }
                Console.WriteLine(" ");
            }



        }
    }
}

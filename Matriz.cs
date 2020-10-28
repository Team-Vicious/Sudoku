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
        //FileWork filework = new FileWork();
        public int[] vectorsolucion = new int[81];
        public int[] vector = new int[81];


        //int[,] matriz = new int[9, 9];
        public int[,] matSolucion = new int[9, 9];
        public int[,] mat = new int[9, 9];

        public void igualar_vaciar()
        {
            //variables contador i,j
            int n1 = 0;
            int n2 = 0;
            

            //mat = matSolucion;
            //copiar matriz
            foreach(int n in matSolucion)
            {
                if (n2 == 9)
                {
                    n1++;
                    n2 = 0;
                }
                
                mat[n1,n2] = n;
                n2++;
            }


            for(int i = 0; i< 20; i++)
            {
                
                Random rand1 = new Random(Guid.NewGuid().GetHashCode());
                Random rand2 = new Random(Guid.NewGuid().GetHashCode());
                int num1 =rand1.Next(1, 9);
                int num2 =rand2.Next(1, 9);
                mat[num1, num2] = 0;

            }
        }

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
                    matSolucion[i, j] = vector[recorre];

                    if (vector[recorre] == 0)
                    {
                        Console.Write("[ ]");
                    }
                    else
                    {
                        Console.Write("[" + matSolucion[i, j] + "]");
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
                        matSolucion[i, j] = vectorsolucion[recorre];
                        Console.WriteLine();
                        ;


                    }
                    recorre++;
                }


            }

            


        }


        //permuta valores
        public void insertarVal( int valor1, int valor2)
        {
            int x1, y1, x2, y2;
            x1 = y1 = x2 = y2 = 0;
            for (int i = 0; i < 9; i += 3)
            {
                for (int k = 0; k < 9; k += 3)
                {
                    for (int j = 0; j < 3; j++)
                    {

                        for (int z = 0; z < 3; z++)
                        {
                            if (matSolucion[i + j, k + z] == valor1)
                            {
                                x1 = i + j;
                                y1 = k + z;
                            }
                            if (matSolucion[i + j, k + z] == valor2)
                            {
                                x2 = i + j;
                                y2 = k + z;
                            }
                        }
                    }
                    matSolucion[x1, y1] = valor2;
                    matSolucion[x2, y2] = valor1;
                }

            }

        }

        //genera numeros random del 1 al 9
        public void generarNumeros()
        {
            for (int repeat = 0; repeat < 10; repeat++)
            {
                Random rand1 = new Random(Guid.NewGuid().GetHashCode());
                Random rand2 = new Random(Guid.NewGuid().GetHashCode());
                insertarVal( rand1.Next(1, 9), rand2.Next(1, 9));
            }
        }

        //genera valores iniciales en la tabla
        public void generarValInicial()
        {
            for (int i = 0; i < 9; i++)
            {
                for (int j = 0; j < 9; j++)
                {
                    matSolucion[i, j] = (i * 3 + i / 3 + j) % 9 + 1;
                }
            }
        }
    }
}

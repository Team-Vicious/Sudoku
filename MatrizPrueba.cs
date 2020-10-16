using System;
using System.Collections.Generic;
using System.Text;

namespace SudokuMatriz
{
    class MatrizPrueba
    {
        int count = 0;
        int[] vector = new int[81];
        FileWork filework = new FileWork();
        
        //public void llenar()
        //{
        //    vector = filework.readVector();
        //}

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
                        Console.Write("[" + vector[count] + "]");
                    }
                    recorre++;
                    count++;

                }
                Console.WriteLine(" ");
            }



        }
    }
}

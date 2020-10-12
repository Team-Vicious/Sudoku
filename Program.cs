using System;
using System.Collections.Generic;
using System.Text;

namespace SudokuMatriz
{
    class Program
    {
        public static void Main(string[] args)
        {

            Matriz obj = new Matriz();

            //obj.insertar();
            obj.insertar();
            obj.mostrar();
            

        }

    }

    class Matriz
    {
        int[,] matriz = new int[9, 9];

        public void mostrar()
        {
            for (int i = 0; i < 9; i++)
            {
                if (i % 3 == 0)
                {
                    Console.WriteLine(" ");
                }

                for (int j = 0; j < 9; j++)
                {
                    if (j % 3 == 0 || j == 9)
                    {
                        Console.Write(" ");
                    }

                    Console.Write("[" + matriz[i, j] + "]");
                    
                }
                Console.WriteLine(" ");

            }

        }

        public void llenar()
        {
            int num = 0;
            for(int i = 0; i< 9; i++)
            {
                for (int j = 0; j < 9; j++)
                {
                    matriz[i, j] = num;
                    num++;
                }
            }
   
        }

        //verificar que el valor ingresado no este en la misma fila o columna
        public Boolean verificar(int num,int f,int c)
        {
            // en caso de encontrar uno igual que retorne directamnte el true,sino al final
            //retorna false(significa que no hay nungun numero en la fila o columna)

            //x+
            for (int i = c; i < 9; i++)
            {
                if (matriz[f,i] == num)
                {
                    return true;
                }
            }

            //x-
            for (int i =c; i >= 0; i--)
            {
                if (matriz[f, i] == num)
                {
                    return true;
                }
            }

            //y+
            for (int j = f; j >= 0; j--)
            {
                if (matriz[j, c] == num)
                {
                    return true;
                }
            }

            //y-
            for (int j = f; j < 9; j++)
            {
                if (matriz[j, c] == num)
                {
                    return true;
                }
            }

            return false;
        }


        //tratar de insertar un valor, en caso de que no pasar
        public void insertar() { 
            
            for (int i = 0; i < 9; i++)
            {
                for (int j = 0; j < 9; j++)
                {
                    int random;
                    Random rnd = new Random();
                    random = rnd.Next(9);

                    if (verificar(random,i,j) == false)
                    {
                        matriz[i, j] = random;
                    }
                    //sino que pase y no genere numero en esa celda, tarea para el futuro :)
                }
            }


        }

    }
}

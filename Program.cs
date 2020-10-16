using System;
using System.Collections.Generic;
using System.Text;

namespace SudokuMatriz
{
    class Program
    {
        public static void Main(string[] args)
        {
            
            Matriz matriz = new Matriz();
            matriz.llenar();
            matriz.Llenarimprimir();
            Console.WriteLine("");
            matriz.Completar();
            

            //FileWork filework = new FileWork();
            //filework.writeFile();
            //filework.readFile();

            //MatrizPrueba mat = new MatrizPrueba();
            //mat.llenar();
            //mat.imprimir();

        }

    
    }
}




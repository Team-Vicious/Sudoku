using System;
using System.Collections.Generic;
using System.Text;
using System.IO;
using System.Numerics;

namespace SudokuMatriz
{
    class FileWork
    {
        String juego1Completo = "Juego1Completo.txt";
        String juego1Incompleto = "Juego1Incompleto.txt";
        int[] vec = new int[81];

        public int[] elegir(int opc)
        {
            switch (opc)
            {
                case 1:
                    vec = readVector(juego1Completo);
                    break;

                case 2:
                    vec = readVector(juego1Incompleto);
                    break;

            }
            return vec;
        }
        public void writeFile()
        {
            try
            {
                //Pass the filepath and filename to the StreamWriter Constructor
                StreamWriter sw = new StreamWriter("Test.txt");
                //Write a line of text
                sw.WriteLine("Hello World!!");
                //Write a second line of text
                sw.WriteLine("From the StreamWriter class");
                //Close the file
                sw.Close();
            }
            catch (Exception e)
            {
                Console.WriteLine("Exception: " + e.Message);
            }
            finally
            {
                Console.WriteLine("Executing finally block.");
            }
        }
     
        public void readFile()
        {
            String line;
            try
            {
                //Pass the file path and file name to the StreamReader constructor
                StreamReader sr = new StreamReader("Test.txt");
                //Read the first line of text
                line = sr.ReadLine();
                //Continue to read until you reach end of file
                while (line != null)
                {
                    //write the lie to console window
                    Console.WriteLine(line);
                    //Read the next line
                    line = sr.ReadLine();
                }
                //close the file
                sr.Close();
                Console.ReadLine();
            }
            catch (Exception e)
            {
                Console.WriteLine("Exception: " + e.Message);
            }
            finally
            {
                Console.WriteLine("Executing finally block.");
            }
        }

        public int[] readVector(String opc)
        {
            int[] vec = new int[81];
            try
            {
                //Pass the file path and file name to the StreamReader constructor
                StreamReader sr = new StreamReader(opc);
                //Read the first line of text
                int aux = 0;
                int count = 0;
                //Continue to read until you reach end of file
                while (aux != null)
                {
                    //write the lie to console window
                    //Console.WriteLine(aux);
                    //Read the next line
                    aux = Int32.Parse(sr.ReadLine());
                    vec[count] = aux;
                    count++;
                }
                //close the file
                sr.Close();
                Console.ReadLine();

                
            }
            catch (Exception e)
            {
                Console.WriteLine("Exception: " + e.Message);
            }
            

            return vec;
        }
    }
}

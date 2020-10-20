using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;


namespace SudokuInterfaz
{
    /// <summary>
    /// Lógica de interacción para MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        
        ArrayList vec = new ArrayList();
        Matriz matriz = new Matriz(); 

        public void llenar() {
            vec.Add(t1); vec.Add(t2); vec.Add(t3); vec.Add(t4); vec.Add(t5); vec.Add(t6);
            vec.Add(t7) ;vec.Add(t8); vec.Add(t9); vec.Add(t10); vec.Add(t11); vec.Add(t12);
            vec.Add(t13); vec.Add(t14); vec.Add(t15); vec.Add(t16); vec.Add(t17); vec.Add(t18);
            vec.Add(t19); vec.Add(t20); vec.Add(t21); vec.Add(t22); vec.Add(t23);vec.Add(t24);
            vec.Add(t25); vec.Add(t26); vec.Add(t27);

            vec.Add(t28); vec.Add(t29); vec.Add(t30); vec.Add(t31); vec.Add(t32); vec.Add(t33);
            vec.Add(t34); vec.Add(t35); vec.Add(t36); vec.Add(t37); vec.Add(t38); vec.Add(t39);
            vec.Add(t40); vec.Add(t41); vec.Add(t42); vec.Add(t43); vec.Add(t44); vec.Add(t45);
            vec.Add(t46); vec.Add(t47); vec.Add(t48); vec.Add(t49); vec.Add(t50); vec.Add(t51);
            vec.Add(t52); vec.Add(t53); vec.Add(t54);

            vec.Add(t55); vec.Add(t56); vec.Add(t57); vec.Add(t58); vec.Add(t59); vec.Add(t60);
            vec.Add(t61); vec.Add(t62); vec.Add(t63); vec.Add(t64); vec.Add(t65); vec.Add(t66);
            vec.Add(t67); vec.Add(t68); vec.Add(t69); vec.Add(t70); vec.Add(t71); vec.Add(t72);
            vec.Add(t73); vec.Add(t74); vec.Add(t75); vec.Add(t76); vec.Add(t77); vec.Add(t78);
            vec.Add(t79); vec.Add(t80); vec.Add(t81);


            almacenar();
        }

        int n = 0;
        public void almacenar()
        {
            //cargar los txt en los vectores
            matriz.llenar();

            //setea los valores de la matriz en lo textBox
            foreach (TextBox t in vec)
            {
                if (matriz.vector[n].ToString().Equals("0"))
                {
                    t.Text = "-";
                }
                else
                {
                    t.Text = matriz.vector[n].ToString();
                }

                

                n++;
            }
                
        }
        
        private void TextBox_TextChanged(object sender, TextChangedEventArgs e)
        {
            
            

        }


        private void Button_Click(object sender, RoutedEventArgs e)
        {
            //INICIAR
            //inicio del juego
            llenar();
            
            iniciar.IsEnabled = false;
        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            //MOSTRAR RESULTADO
            //mostrar resultado

            int n = 0;
            //setea los valores de la matriz en lo textBox
            foreach (TextBox t in vec)
            {
                t.Text = matriz.vectorsolucion[n].ToString();
                n++;
                
            }



            viewResultado.IsEnabled = false;
            volver.IsEnabled = true;
        }

        
        private void Button_Click_2(object sender, RoutedEventArgs e)
        {
            //VERIFICAR
            int n = 0;
            foreach (TextBox t in vec)
            {
                

                if(t.Text.Equals(matriz.vectorsolucion[n].ToString()))
                {
                    t.Background = Brushes.White;
                    matriz.vector[n] = matriz.vectorsolucion[n];
                    
                }
                else
                {
                    if (t.Text.Equals("0") || t.Text.Equals("-"))
                    {
                        t.Background = Brushes.White;
                    }
                    else
                    {
                        t.Background = Brushes.Red;
                        break;
                    }
                        
                    
                        
                    
                    
                }

               
                n++;
            }
            
        }

        private void Button_Click_3(object sender, RoutedEventArgs e)
        {
            int n = 0;
            //VOLVER
            //volver al estado del juego
            //setea los valores de la matriz en lo textBox
            foreach (TextBox t in vec)
            {
                if (matriz.vector[n].ToString().Equals("0"))
                {
                    t.Text = "-";
                }
                else
                {
                    t.Text = matriz.vector[n].ToString();
                }

                

                n++;
            }
            viewResultado.IsEnabled = true;
            volver.IsEnabled = false;
        }
    }
}

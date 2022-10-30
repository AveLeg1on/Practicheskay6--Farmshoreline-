
using System;
using System.IO;
using System.Media;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Input;

namespace Farmshoreline
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        


        public MainWindow()
        {
            InitializeComponent();
            one.Focus();

            Jumbo.IsReadOnly = true;
            one.Focus();
            two.IsReadOnly = true;
            three.IsReadOnly = true;
            four.IsReadOnly = true;




        }
        Pair pair1 = new Pair();
        Pair pair2 = new Pair();
        Pair answer = new Pair();


        private void one_KeyUp(object sender, KeyEventArgs e)
         {
            int One = 0;

            if (e.Key == Key.Space || e.Key==Key.Enter) 
            {
                try
                {
                    if (!(int.TryParse(one.Text, out One)))
                    {
                        throw new ArgumentException();

                    }


                }
                catch (Exception)
                {
                    MessageBox.Show("Корректное занчение,пожалуйста");
                    return;
                }
                if (One == 0)
                {
                    MessageBox.Show("Значение не должно быть 0");
                    one.Text = null;
                    return;
                }

                if (!(One % 2 == 0))
                {
                    MessageBox.Show("Корректное занчение,пожалуйста");

                    one.Text = null;
                    return;

                }
                pair1.One = One;

                two.IsReadOnly = false;
                two.IsEnabled = true;
                two.Focus();
                one.IsReadOnly = true;

            }




        }

        private void two_KeyUp(object sender, KeyEventArgs e)
        {
            int Two = 0;

            if (e.Key == Key.Space || e.Key == Key.Enter)
            {
                try
                {
                    if (!(int.TryParse(two.Text, out Two)))
                    {
                        throw new ArgumentException();

                    }


                }
                catch (Exception)
                {
                    MessageBox.Show("Корректное занчение,пожалуйста");
                    return;
                }
                if (Two == 0)
                {
                    MessageBox.Show("Значение не должно быть 0");
                    two.Text = null;
                    return;
                }
                if (!(Two % 2 == 0))
                {
                    MessageBox.Show("Корректное занчение,пожалуйста");

                    two.Text = null;

                    return;

                }



                pair1.Two = Two;
                three.IsReadOnly = false;
                three.IsEnabled = true;
                three.Focus();
                two.IsReadOnly = true;
            }

        }
        private void three_KeyUp(object sender, KeyEventArgs e)
        {
            int Three = 0;

            if (e.Key == Key.Space || e.Key == Key.Enter)
            {
                try
                {
                    if (!(int.TryParse(three.Text, out Three)))
                    {
                        throw new ArgumentException();

                    }


                }
                catch (Exception)
                {
                    MessageBox.Show("Корректное занчение,пожалуйста");
                    return;
                }
                if (Three == 0)
                {
                    MessageBox.Show("Значение не должно быть 0");
                    two.Text = null;
                    return;
                }


                if (!(Three % 2 == 0))
                {
                    MessageBox.Show("Корректное занчение,пожалуйста");

                    three.Text = null;
                    return;
                }
                pair2.One = Three;
                four.IsReadOnly = false;
                four.IsEnabled = true;
                four.Focus();
                three.IsReadOnly = true;
            }
        }
        bool flag;
 int Four = 0;
        private void four_KeyUp(object sender, KeyEventArgs e)
        {
          
            if (e.Key == Key.Space || e.Key == Key.Enter)
            {flag=true;
                try
                {

                    if (!(int.TryParse(four.Text, out Four)))
                    {
                        throw new ArgumentException();

                    }





                }
                catch (Exception)
                {
                    MessageBox.Show("Корректное занчение,пожалуйста");
                    return;

                }
                if (Four == 0)
                {
                    MessageBox.Show("Значение не должно быть 0");
                    two.Text = null;
                    return;
                }

                if (!(Four % 2 == 0))
                {
                    MessageBox.Show("Корректное занчение,пожалуйста");

                    four.Text = null;
                    return;

                }
                pair2.Two = Four;
                four.IsReadOnly = true;

            }

        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            if (!flag)
            {

          
            try
            {

                if (!(int.TryParse(four.Text, out Four)))
                {
                    throw new ArgumentException();


                }





            }
            catch (Exception)
            {
                MessageBox.Show("Корректное занчение,пожалуйста");
                four.Text = null;
                four.Focus();
                return;
            }
            if (Four == 0)
            {
                MessageBox.Show("Значение не должно быть 0");
                four.Text = null;
                four.Focus();
                return;
            }

            if (!(Four % 2 == 0))
            {
                MessageBox.Show("Корректное занчение,пожалуйста");

                four.Text = null;
                four.Focus();
                return;
            }
           
            pair2.Two = Four;

            four.IsReadOnly = true;
            }
            Jumbo.Text = null;
            answer = pair1 * pair2;
            Jumbo.Text += $"{pair1.One}*{pair2.One}=" + Convert.ToString(answer.One) + ";\n ";
            Jumbo.Text += $"{pair2.Two}*{pair1.Two}=" + Convert.ToString(answer.Two);
        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            if (!flag)
            {
                try
                {

                    if (!(int.TryParse(four.Text, out Four)))
                    {
                        throw new ArgumentException();


                    }





                }
                catch (Exception)
                {
                    MessageBox.Show("Корректное занчение,пожалуйста");
                    four.Text = null;
                    four.Focus();
                    return;
                }
                if (Four == 0)
                {
                    MessageBox.Show("Значение не должно быть 0");
                    four.Text = null;
                    four.Focus();
                    return;
                }

                if (!(Four % 2 == 0))
                {
                    MessageBox.Show("Корректное занчение,пожалуйста");

                    four.Text = null;
                    four.Focus();
                    return;
                }
                pair2.Two = Four;

                
            }
            flag = true;

            four.IsReadOnly = true;
            Jumbo.Text = null;
           answer=++pair1;
            Jumbo.Text += $"Первая пара значений {answer.One};{answer.Two}";
           answer=++pair2;
            Jumbo.Text += $"Вторая пара значений {answer.One};{answer.Two}";


        }



        private void Button_Click_2(object sender, RoutedEventArgs e)
        {
            Close();
        }

        private void Button_Click_3(object sender, RoutedEventArgs e)
        {
            MessageBox.Show("Разраб:Денисов Олег Андреевич\n Задание: Создать класс Pair (пара четных чисел). Создать необходимые методы и свойства. \r\nОпределить метод перемножения пар (а, b) * (с, d) = (а * c, b * d). Создать перегруженный метод для удвоения пары чисел");
        }

     

        private void Button_Click_4(object sender, RoutedEventArgs e)
        {
            one.Text = null;
            one.IsReadOnly = false;
            one.Focus();
            two.Text = null;
            three.Text = null;
            four.Text = null;
            flag=false;
            //two.IsReadOnly = false; 
            //three.IsReadOnly = false;
            //four.
        }
    }
}



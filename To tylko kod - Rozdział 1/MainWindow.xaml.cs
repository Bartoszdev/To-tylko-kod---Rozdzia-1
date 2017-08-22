using System;
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

namespace To_tylko_kod___Rozdział_1
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            int number = 15;
            number = number + 10;
            number = 36 * 15;
            number = 12 - (42 / 7);
            number += 10;
            number *= 3;
            number = 71 / 3;

            int count = 0;
            count++;
            count--;


            string result = "witam ";
            result += "ponownie " + result;
            output.Text = result;
            result = "wartościa jest : " + count;
            result = "";


            bool yesNo = false;
            bool anotherBool = true;
            yesNo = !anotherBool;
  
            
          
        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            int someValue = 24;
            if(someValue == 24)
            {
                output.Text = " Wartość jest równa 24";
            }
            else
            {
                output.Text = "Wartość nie jest równa 24";
            }
            
        }

        private void button1_Click(object sender, RoutedEventArgs e)
        {
            string name = "Quentin";
            int x = 3;
            x = x * 17;
            double d = Math.PI / 2;
             myLabel.Text = "nazwa to " + name
                + "\nx jest równe " + x
                + "\nx jest równe " + d;
        

        }

        private void button2_Click(object sender, RoutedEventArgs e)
        {
            int x = 5;
            if(x == 10)
            {
                myLabel.Text = "x musi być równe 10";
            }
            else
            {
                myLabel.Text = "x nie jest równe 10";
            }
        }

        private void button3_Click(object sender, RoutedEventArgs e)
        {
            int someValue2 = 4;
            string name = "Krzysiek";
            if((someValue2 == 4) && (name.Equals("Krzysiek")))
            {
                myLabel.Text = "SomeValue jest równe 3 i name jest równe Janek";
            }
            else
            {
                myLabel.Text = "ten wiersz jest wykonywany bez względu na warunki";
            }
        }

        private void button4_Click(object sender, RoutedEventArgs e)
        {
            int count = 0;
            
            while (count < 10)
            {
                count = count + 1;
                
            }

            for (int i = 0; i < 5; i++)
            {
                count = count - 1;
            }

            myLabel.Text = "Odpowiedź brzmi " + count;
         }

        private void Button_Click_2(object sender, RoutedEventArgs e)
        {
            int result = 0;
            int x = 6;
            while(x>3)
            {
                result = result + x;

                x = x - 1;
            }
            for (int z = 1; z < 3; z = z + 1)
            {
                result = result + z;
            }
            myLabel.Text = "Zmienna result jest równa " + result;
        }

        private void Button_Click_3(object sender, RoutedEventArgs e)
        {
            int count = 5;
            while (count > 0)
            {
                count = count * 3;
                count = count * -1; 

                //Pętla wykona się tylko raz , wartość count = -15
            }
        }

        private void Button_Click_4(object sender, RoutedEventArgs e)
        {
            int j = 2;
            for (int i = 1; i < 100; i = i * 2)
            {
                j = j - i; //Pętla wykona się dokładnie siedem razy 
                while (j < 25)
                {
                    j = j + 5;
                }
                
            }
        }

        private void Button_Click_5(object sender, RoutedEventArgs e)
        {
            int i = 0;
            int count = 2;
            while ( i == 0)
            {
                count = count * 3;
                count = count * -1;

                //Pętla wykonuje się w nieskończoność ,int i == 0 więc while będzię zawsze wykonywane
            }
        }

        private void Button_Click_6(object sender, RoutedEventArgs e)
        {
            while (true)
            {
                int i = 1; //Kolejna pętla nieskończona 
            }
            
        }

        private void Button_Click_7(object sender, RoutedEventArgs e)
        {
            int p = 2;
            for (int q = 2; q < 32; q = q * 2)
            {
                while (p < q)
                {
                    p = p * 2;
                }
                q = p - q;

                //pętla wykona się osiem razy ( q = p - q) 
            }
        }

        private void Button_Click_8(object sender, RoutedEventArgs e)
        {
            int x = 3;
            string result = "";

            while (x > 0)
            {


                if (x > 2)
                {
                    result = result + "a";
                }
                x = x - 1;

                result = result + "-";


                if (x == 2)
                {
                    result = result + "b c";
                }
                

                if (x == 1)
                {
                    result = result + "d";

                    x = x - 1;
                }

                output.Text = result;

                //wynik programu to a-b c-d
            }
        }

        private void Button_Click_9(object sender, RoutedEventArgs e)
        {
            int x = 0;
            string poem = "";

            while(x < 4)
            {
                poem = poem + "a";

                if(x < 1)
                {
                    poem = poem + " ";
                }

                poem = poem + "n";

                if (x > 1)
                {
                    poem = poem + " oyster";

                    x = x + 2;
                }
                if(x == 1)
                {
                    poem = poem + "noys ";
                }
                if(x < 1)
                {
                    poem = poem + "oise ";
                }

                x = x + 1;
            }

            output.Text = poem;
        }

        // wynik programu to a noise annoys an oyster

    }
}

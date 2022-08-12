using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace JogoAveia
{
    public partial class MainPage : ContentPage
    {
        // váriavel que define a vez(x ou o)
        string Vez = "X";
        public MainPage()
        {
            //\\*-*//\\
            InitializeComponent();
        }

        private void b1_Clicked(object sender, EventArgs e)
        {
            //identificando de quem é a vez
            if (Vez == "X")
            {
                //texto do botão
                b1.Text = "X";
                //troca a vez
                Vez = "O";
            }else
            {
                //texto do botão
                b1.Text = "O";
                //troca a vez
                Vez = "X";
            }
            //desativa o botão
            b1.IsEnabled = false;
        }

        private void b2_Clicked(object sender, EventArgs e)
        {
            

            if (Vez == "X")
            {
                b2.Text = "X";
                Vez = "O";
            }
            else
            {
                b2.Text = "O";
                Vez = "X";
            }
            b2.IsEnabled = false;
        }

        private void b3_Clicked(object sender, EventArgs e)
        {
            

            if (Vez == "X")
            {
                b3.Text = "X";
                Vez = "O";
            }
            else
            {
                b3.Text = "O";
                Vez = "X";
            }
            b3.IsEnabled = false;
        }

        private void b4_Clicked(object sender, EventArgs e)
        {
            

            if (Vez == "X")
            {
                b4.Text = "X";
                Vez = "O";
            }
            else
            {
                b4.Text = "O";
                Vez = "X";
            }
            b4.IsEnabled = false;
        }

        private void b5_Clicked(object sender, EventArgs e)
        {
            

            if (Vez == "X")
            {
                b5.Text = "X";
                Vez = "O";
            }
            else
            {
                b5.Text = "O";
                Vez = "X";
            }
            b5.IsEnabled = false;
        }

        private void b6_Clicked(object sender, EventArgs e)
        {
            

            if (Vez == "X")
            {
                b6.Text = "X";
                Vez = "O";
            }
            else
            {
                b6.Text = "O";
                Vez = "X";
            }
            b6.IsEnabled = false;
        }

        private void b7_Clicked(object sender, EventArgs e)
        {
            

            if (Vez == "X")
            {
                b7.Text = "X";
                Vez = "O";
            }
            else
            {
                b7.Text = "O";
                Vez = "X";
            }
            b7.IsEnabled = false;
        }

        private void b8_Clicked(object sender, EventArgs e)
        {
            
            if (Vez == "X")
            {
                b8.Text = "X";
                Vez = "O";
            }
            else
            {
                b8.Text = "O";
                Vez = "X";
            }
            b8.IsEnabled = false;
        }

        private void b9_Clicked(object sender, EventArgs e)
        {
           

            if (Vez == "X")
            {
                b9.Text = "X";
                Vez = "O";
            }
            else
            {
                b9.Text = "O";
                Vez = "X";
            }
            b9.IsEnabled = false;
     
        }




    }
}

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CalculatorApp
{
    public partial class Form1 : Form
    {
        Double value = 0;
        string operation = "";
        bool operation_pressed = false;




        public Form1()
        {
            InitializeComponent();
        }
        // Kur deshirojm mi shfaq numrat ne text box njeri pas tjetrit
        private void button_click(object sender, EventArgs e)
        {
            if ((result.Text == "0") || (operation_pressed))
                result.Clear();
            operation_pressed = false;

            Button b = (Button)sender;
            result.Text = result.Text + b.Text;
        }

        // Butoni CE kur deshirojm mi shly numrat 

        private void button5_Click(object sender, EventArgs e)
        {
            result.Text = "0";
        }

        /* Funksionalizimi i veprimeve matematikore 
        Duhet te krijohet nje vlere te dyfisht (Double value = 0;) per shkak te perdorimit te vlerave decimale
        dhe nje string i zbrazet (string operation = "";) per te pasqyruar llojin e 
        veprimit matematikor.defe

        */
        private void operator_click(object sender, EventArgs e)
        {

            Button b = (Button)sender;
            operation = b.Text;
            value = Double.Parse(result.Text);
            operation_pressed = true;
            equation.Text = value + " " + operation;



        }
        /* Konfigurimi i butonit = equal 
         
             */
        private void button16_Click(object sender, EventArgs e)
        {

            equation.Text = "";
            switch (operation)

            {
                case "+":
                    result.Text = (value + Double.Parse(result.Text)).ToString();
                    break;
                case "-":
                    result.Text = (value - Double.Parse(result.Text)).ToString();
                    break;
                case "*":
                    result.Text = (value * Double.Parse(result.Text)).ToString();
                    break;
                case "/":
                    result.Text = (value / Double.Parse(result.Text)).ToString();
                    break;
                default:
                    break;

            }



        }
        //Butoni C per fshiren e rezultatit ne ekran
        private void button6_Click(object sender, EventArgs e)
        {
            result.Clear();
            value = 0;
            result.Text = "0";
        }

    
    }
}

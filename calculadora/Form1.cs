using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace calculadora
{
    public partial class Calculadora : Form
    {
        double primero;
        double segundo;
        string operador;

        public Calculadora()
        {
            InitializeComponent();
        }

        clases.clsuma osuma = new clases.clsuma();
        clases.clresta oresta = new clases.clresta();
        clases.clmultiplicacion omult = new clases.clmultiplicacion();
        clases.cldivision odiv = new clases.cldivision();

        private void button1_Click(object sender, EventArgs e)
        {
            if (txtresultado.Text.Length != 0)
            {
                operador = "+";
                primero = double.Parse(txtresultado.Text);
                txtresultado.Clear();
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button20_Click(object sender, EventArgs e)
        {
            if (txtresultado.Text.Length != 0)
            {
                operador = "/";
                primero = double.Parse(txtresultado.Text);
                txtresultado.Clear();
            }
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged_1(object sender, EventArgs e)
        {

        }

        private void btn0_Click(object sender, EventArgs e)
        {
            txtresultado.Text = txtresultado.Text + "0";
        }

        private void button11_Click(object sender, EventArgs e)
        {
            if (txtresultado.Text.Length != 0)
            {
                txtresultado.Text = txtresultado.Text + ".";
            }
        }

        private void button17_Click(object sender, EventArgs e)
        {
            if (txtresultado.Text.Length != 0)
            {
                segundo = double.Parse(txtresultado.Text);

                double suma;
                double resta;
                double multiplicacion;
                double division;



                switch (operador)
                {
                    case "+":
                        suma = osuma.sumar((primero), (segundo));
                        txtresultado.Text = suma.ToString();
                        break;
                    case "-":
                        resta = oresta.restar((primero), (segundo));
                        txtresultado.Text = resta.ToString();
                        break;
                    case "*":
                        multiplicacion = omult.multiplicar((primero), (segundo));
                        txtresultado.Text = multiplicacion.ToString();
                        break;
                    case "/":
                        division = odiv.division((primero), (segundo));
                        txtresultado.Text = division.ToString();
                        break;
                }
            }
        }

        private void btn1_Click(object sender, EventArgs e)
        {
            txtresultado.Text = txtresultado.Text + "1";
        }

        private void btn2_Click(object sender, EventArgs e)
        {
            txtresultado.Text = txtresultado.Text + "2";
        }

        private void btn3_Click(object sender, EventArgs e)
        {
            txtresultado.Text = txtresultado.Text + "3";
        }

        private void btn4_Click(object sender, EventArgs e)
        {
            txtresultado.Text = txtresultado.Text + "4";
        }

        private void btn5_Click(object sender, EventArgs e)
        {
            txtresultado.Text = txtresultado.Text + "5";
        }

        private void btn6_Click(object sender, EventArgs e)
        {
            txtresultado.Text = txtresultado.Text + "6";
        }

        private void btn7_Click(object sender, EventArgs e)
        {
            txtresultado.Text = txtresultado.Text + "7";
        }

        private void btn8_Click(object sender, EventArgs e)
        {
            txtresultado.Text = txtresultado.Text + "8";
        }

        private void btn9_Click(object sender, EventArgs e)
        {
            txtresultado.Text = txtresultado.Text + "9";
        }

        private void button10_Click(object sender, EventArgs e)
        {
            if (txtresultado.Text.Length != 0)
            {
                operador = "-";
                primero = double.Parse(txtresultado.Text);
                txtresultado.Clear();
            }
        }

        private void button15_Click(object sender, EventArgs e)
        {
            if (txtresultado.Text.Length != 0)
            {
                operador = "*";

                primero = double.Parse(txtresultado.Text);
                txtresultado.Clear();
            }
        }

        private void button18_Click(object sender, EventArgs e)
        {
            txtresultado.Clear();
        }

        private void button19_Click(object sender, EventArgs e)
        {
            if (txtresultado.Text.Length != 0)
            {
                if (txtresultado.Text.Length == 1)
                {
                    txtresultado.Text = "";
                }
                else
                {
                    txtresultado.Text = txtresultado.Text.Substring(0, txtresultado.Text.Length - 1);
                }
            }
        }
    }
}

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Racional.Model;

namespace Racional
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void multi_Click(object sender, EventArgs e)
        {
            int n1 = Convert.ToInt16(numerador1.Text);
            int d1 = Convert.ToInt16(denominador1.Text);
            int n2 = Convert.ToInt16(numerador2.Text);
            int d2 = Convert.ToInt16(denominador2.Text);

            Racionales r1 = new Racionales(n1,d1);
            Racionales r2 = new Racionales(n2, d2);

            Racionales producto = r1.multiplicar(r2);

            textBox5.Text = producto.getA().ToString();
            textBox6.Text = producto.getB().ToString();

        }

        private void divid_Click_1(object sender, EventArgs e)
        {

            int n1 = Convert.ToInt16(numerador1.Text);
            int d1 = Convert.ToInt16(denominador1.Text);
            int n2 = Convert.ToInt16(numerador2.Text);
            int d2 = Convert.ToInt16(denominador2.Text);

            Racionales r1 = new Racionales(n1, d1);
            Racionales r2 = new Racionales(n2, d2);

            Racionales division = r1.dividir(r2);

            textBox5.Text = division.getA().ToString();
            textBox6.Text = division.getB().ToString();

        }

        private void equivalente_Click(object sender, EventArgs e)
        {
            int n1 = Convert.ToInt16(numerador1.Text);
            int d1 = Convert.ToInt16(denominador1.Text);
            int n2 = Convert.ToInt16(numerador2.Text);
            int d2 = Convert.ToInt16(denominador2.Text);

            Racionales r1 = new Racionales(n1, d1);
            Racionales r2 = new Racionales(n2, d2);




        }





    }
}

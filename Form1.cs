using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Funciones
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            double resultado;

            resultado = suma(5, 15);

            label1.Text = "El resultado de la función en la misma clase es: " + resultado.ToString();

            double resultado2;
            resultado2 = funciones.multiplicacion(5, 15);

            label2.Text = "El resultado de llamar funciones fuera de esta clase es: " + resultado2.ToString();

        }

        public static double suma(double valor1, double valor2)
        {
            double sum = 0;
            sum = valor1 + valor2;

            return sum;
        }
    }
}

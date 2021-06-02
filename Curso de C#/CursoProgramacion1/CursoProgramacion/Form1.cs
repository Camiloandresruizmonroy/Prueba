using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CursoProgramacion
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int numero = 123;
            double numeroConComas = 5000.28;
            string prueba = "Prueba de variable: " + numeroConComas;
            string prueba2 = "Prueba" + "de" + "concatenacion. " + prueba;
            label1.Text = prueba;
        }
    }
}

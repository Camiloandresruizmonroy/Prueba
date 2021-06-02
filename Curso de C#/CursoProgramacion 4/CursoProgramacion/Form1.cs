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
            //En esta parte creamos una vaiable para obtener la edad
            string textoEdad = txtEdad.Text;

            //convertimos el texto a un numero 
            int Edad = Int32.Parse(textoEdad);
            bool esMayorDeEdad = Edad >= 18;

                        
            if (esMayorDeEdad)
            {
                lblResultado.Text = "El usuario es mayor de edad";
            }
            else {
                lblResultado.Text = "El usuario es menor de edad";
            }
            
            
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}

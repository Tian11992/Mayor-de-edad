using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Edades
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btningresar_Click(object sender, EventArgs e)
        {
            double edad = double.Parse(txtedad.Text);

            if (edad >= 18)
            {
                MessageBox.Show("Es mayor de edad");
            }
            else
            {
                MessageBox.Show("No es mayor de edad");
            }
        }
    }
}

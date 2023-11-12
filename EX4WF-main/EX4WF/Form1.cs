using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EX4WF
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnCalcular_Click(object sender, EventArgs e)
        {
            Triangulo a;
            a = new Triangulo();

            a.setBase(double.Parse(txtBase.Text));
            a.setAltura(double.Parse(txtAltura.Text));
            txtResultado.Text = a.CalcularArea().ToString();
        }
    }
}

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace prueba_ejecicio_con_GitHub
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnSumar_Click(object sender, EventArgs e)
        {
            int suma=0;
            suma = Convert.ToInt32(txtnum1.Text) + Convert.ToInt32(txtnum2.Text);

            txtResultado.Text = suma.ToString();

        }

        private void btnRestar_Click(object sender, EventArgs e)
        {
            int resta = 0;
            resta = Convert.ToInt32(txtnum1.Text) + Convert.ToInt32(txtnum2.Text);

            txtResultado.Text = resta.ToString();
        }
    }
}

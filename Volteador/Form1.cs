using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Volteador
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnVoltear_Click(object sender, EventArgs e)
        {
            string palabraOri = txtOriginal.Text;
            string palabraNue = "";

            for (int i = palabraOri.Length-1; i >= 0; i--)
            {
                //System.Console.WriteLine(palabraOri[i]);
                //palabraOri[i] = 'A';
                string letra = palabraOri[i].ToString();

                palabraNue = palabraNue + letra;

                //hola
                //aloh
            }

            lblResultado.Text = palabraNue;
            
        }
    }
}

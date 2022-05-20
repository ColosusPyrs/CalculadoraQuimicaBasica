using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Calculadora_Quimica_Basica
{
    public partial class CalculadoraQuimicaBasica : Form
    {
        public CalculadoraQuimicaBasica()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
            MoralidadDisolucion MoDi = new MoralidadDisolucion();
            MoDi.Show();
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            Environment.Exit(0);
        }
    }
}

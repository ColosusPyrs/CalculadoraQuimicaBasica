﻿using System;
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
    public partial class MoralidadDisolucion : Form
    {
        float x, y;

        public MoralidadDisolucion()
        {
            InitializeComponent();
        }

        private void bt1_Click(object sender, EventArgs e)
        {
            this.Hide();
            CalculadoraQuimicaBasica CQB = new CalculadoraQuimicaBasica();
            CQB.Show();
        }

        //Botones de texto.
        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            if(textBox1.Text != "") //Evita que el programa falle al escribir y luego borrar todo el texto de la textBox.
            {
                x = Convert.ToSingle(textBox1.Text);
            }
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {
            if (textBox2.Text != "") //Evita que el programa falle al escribir y luego borrar todo el texto de la textBox.
            {
                y = Convert.ToSingle(textBox2.Text);
            }
        }

        //Cambiar texto de los label.
        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButton1.Checked == true)
            {
                label1.Text = "ml:";
                label2.Text = "g:";
            }
        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButton2.Checked == true)
            {
                label1.Text = "ml:";
                label2.Text = "M:";
            }
        }

        private void radioButton3_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButton3.Checked == true)
            {
                label1.Text = "L:";
                label2.Text = "M:";
            }
        }

        //Ecuaciones.
        private float Procedimiento(float x, float y) //Formulas.
        {
            float X, Y, Z = 0;
            
            if(radioButton1.Checked == true) //Molaridad.
            {
                //Formula: NaCI.
                X = x * (1 / 1000f);
                Y = y * (1 / 58.5f);
                Z = Y / X;
            }
            else if(radioButton2.Checked == true) //Gramos.
            {
                //Formula: NaOH.
                X = x * (1 / 1000f);
                Z = y * 40f * X;
            }
            else if(radioButton3.Checked == true) //Moles.
            {
                Z = x * y;
            }

            return Z;
        }

        private string Respxd() //La cosita que acompaña el resultado pero de momento no me acuerdo como se llama xd.
        {
            string r="";

            if(radioButton1.Checked == true)
            {
                r = "Mol/L";
            }
            else if (radioButton2.Checked == true)
            {
                r = "g";
            }
            else if( radioButton3.Checked == true)
            {
                r = "mol";
            }

            return r;
        }

        private void button1_Click(object sender, EventArgs e) //Imprimimos el resultado en pantalla.
        {
            MessageBox.Show($"Resuldado:\n{Procedimiento(x, y)}{Respxd()}.");
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void ModalidadDisolucion_Load(object sender, EventArgs e)
        {

        }
    }
}

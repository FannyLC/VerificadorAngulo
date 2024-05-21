using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace VerificadorAngulo
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnCheck_Click(object sender, EventArgs e)
        {
            // Verificar si el valor ingresado es un número
            if (double.TryParse(txtAngle.Text, out double angle))
            {
                // Determinar el tipo de ángulo
                string angleType;
                if (angle < 90)
                {
                    angleType = "agudo";
                }
                else if (angle == 90)
                {
                    angleType = "recto";
                }
                else
                {
                    angleType = "obtuso";
                }

                // Mostrar el resultado
                lblResult.Text = $"El ángulo es {angleType}.";
            }
            else
            {
                // Mostrar un mensaje de error si el valor ingresado no es un número válido
                lblResult.Text = "Por favor, ingrese un número válido.";
            }
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
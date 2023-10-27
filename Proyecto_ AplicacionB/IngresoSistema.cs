using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace Proyecto__AplicacionB
{
    public partial class sistema : Form
    {
        public sistema()
        {
            InitializeComponent();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click_1(object sender, EventArgs e)
        {
            
        }

        private void botoniniciar_Click(object sender, EventArgs e)
        {
            try
            {
                if (ValidarNombre() == false)
                {
                    return;
                }

                if (ValidarMatricula() == false)
                {
                    return;
                }
              /*  TextReader Inicio = new StreamReader(txtboxnombre.Text + ".txt");
                if (Inicio.ReadLine() == txtControl.Text)
                {
                    MessageBox.Show("El alumno ingresado ha sido correcto ", " Inicio de Sesion ",
                       MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    MessageBox.Show("El nombre o numero de control son incorrectos", " Error de inicio de sesion  ",
                      MessageBoxButtons.OK, MessageBoxIcon.Error);
                }*/


                registar login = new registar();
                login.Show();
                Hide();


            }
            catch(Exception z)
            {
                MessageBox.Show("El usuario no ha sido encontrado "+ z , "Hubo un error ",
                     MessageBoxButtons.OK, MessageBoxIcon.Error);

            }
        }
        private bool ValidarMatricula()
        {
            int Matricula;
            if (!int.TryParse(txtControl.Text, out Matricula) || txtControl.Text == "")
            {
                errorProvider1.SetError(txtControl, "Solo se aceptan numeros  " );
                txtControl.Clear();
                txtControl.Focus();
                return false;



            }
            else
            {
                errorProvider1.SetError(txtControl, "");
                return true;
            }
        }
        private bool ValidarNombre()
        {
            if (string.IsNullOrEmpty(txtboxnombre.Text))
            {

                errorProvider1.SetError(txtboxnombre, "Debe de ingresar el nombre con el cual se registro");
                return false;


            }
            else
            {
                errorProvider1.SetError(txtboxnombre, "");
                return true;
            }
        }
    }
}


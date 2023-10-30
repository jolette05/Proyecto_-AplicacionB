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




                string nombre = txtboxnombre.Text;
                string matricula = txtControl.Text;

                if (!nombre.Equals("Jolette Manzano ", StringComparison.OrdinalIgnoreCase))

                {
                    MessageBox.Show("Usuario incorrecto ", "Error  ",
                   MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;

                }
          
                if (!matricula.Equals("2391", StringComparison.OrdinalIgnoreCase))
                {

                    MessageBox.Show("Contraseña  incorrecta", "Error  ",
                   MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;

                }
                

              

                    MessageBox.Show("Inicio de sesion exitoso", " Datos correctos  ",
                   MessageBoxButtons.OK, MessageBoxIcon.Information);


                    registar login = new registar();
                    login.Show();
                    Hide();
                


            }
            catch(Exception x)
            {

                MessageBox.Show("Hubo un Error" + x, "Error ");
                   
            


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


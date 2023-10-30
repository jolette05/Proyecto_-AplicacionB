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
    public partial class registar : Form
    {
        public registar()
        {
            InitializeComponent();
        }

        private void imagenagregar_Click(object sender, EventArgs e)
        {
            
            try
            {


                if (ValidarCampos() == false)
                {
                    return;
                }


                if (ValidarApellidos() == false)
                {
                    return;

                }
                if (ValidarMatricula() == false)
                {
                    return;
                }
                if (ValidarCarrera() == false)
                {
                    return;

                }
                if (ValidarGrupo() == false)
                {
                    return;
                }
                MessageBox.Show("Se ha agruegado correctamente los datos ", "Agregando  Estudiante ",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);


                DataGridViewRow renglon = (DataGridViewRow)dgvDatosEstudiante.Rows[0].Clone();
                renglon.Cells[0].Value = txtcontrol.Text;
                renglon.Cells[1].Value = txtnombre.Text;
                renglon.Cells[2].Value = txtapellidos.Text;
                renglon.Cells[3].Value = comboxcarrera.Text;
                renglon.Cells[4].Value = comboBoxgrupo.Text;

                dgvDatosEstudiante.Rows.Add(renglon);

                txtnombre.Clear();
                txtapellidos.Clear();
                txtcontrol.Clear();

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Agregando  Estudiante ",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }



        private bool ValidarMatricula()
        {
            
            int Matricula;
            if (!int.TryParse(txtcontrol.Text, out Matricula) || txtcontrol.Text == "")
            {
                errorProvider1.SetError(txtcontrol, "Solo se aceptan numeros  ");
                txtcontrol.Clear();
                txtcontrol.Focus();
                return false;



            }
            else
            {
                errorProvider1.SetError(txtcontrol, "");
                return true;
            }
        }

        private bool ValidarCampos()
        {
            if (string.IsNullOrEmpty(txtnombre.Text))
            {

                errorProvider1.SetError(txtnombre, "Debe de ingresar un nombre ");
                return false;


            }
            else
            {
                errorProvider1.SetError(txtnombre, "");
                return true;
            }

        }
        private bool ValidarApellidos()
        {
             if (string.IsNullOrEmpty(txtapellidos.Text))
            {

                errorProvider1.SetError(txtapellidos, "Debe de ingresar un nombre ");
                return false;


            }
            else
            {
                errorProvider1.SetError(txtapellidos, "");
                return true;
            }

            

        }



        private bool ValidarGrupo()
        { if (string.IsNullOrEmpty(comboBoxgrupo.Text))
            {

                errorProvider1.SetError(comboBoxgrupo, "Debe de elegir un grupo ");
                return false;


            }
            else
            {
                errorProvider1.SetError(comboBoxgrupo, "");
                return true;
            }



        }



        private bool ValidarCarrera()
        {
            if (string.IsNullOrEmpty(comboxcarrera.Text))
            {

                errorProvider1.SetError(comboxcarrera, "Debe de Elegir una carrera  ");
                return false;


            }
            else
            {
                errorProvider1.SetError(comboxcarrera, "");
                return true;
            }

            
        }




        private void imageneliminar_Click(object sender, EventArgs e)
        {
            string mensaje = "¿Desea eliminar los datos del registro  ?";
            string titulo = "Eliminando el registro ";

            if (!(dgvDatosEstudiante.CurrentRow is null))
            {
                if (MessageBox.Show(mensaje, titulo, MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    try
                    {
                        dgvDatosEstudiante.Rows.Remove(dgvDatosEstudiante.CurrentRow);

                    }
                    catch (Exception ex)
                    {


                        MessageBox.Show(ex.Message, "Eliminando   Estudiante ",
                            MessageBoxButtons.OK, MessageBoxIcon.Error);




                    }
                }
                else
                {
                    MessageBox.Show("Debes seleccionar un renglon", "Eliminando estudiante ",
                        MessageBoxButtons.OK, MessageBoxIcon.Information);

                }







            }
        }

        private void imagenactualizar_Click(object sender, EventArgs e)
        {
            if (dgvDatosEstudiante.SelectedRows.Count <= 0)
            {
                MessageBox.Show("Debes selecionar un renglon", "Modificando estudiante",
                            MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
               txtnombre.Text = dgvDatosEstudiante.CurrentRow.Cells["Nombre"].Value.ToString();
                txtapellidos.Text = dgvDatosEstudiante.CurrentRow.Cells["Apellidosusuario"].Value.ToString();
                txtcontrol.Text = dgvDatosEstudiante.CurrentRow.Cells["Matricula"].Value.ToString();
                comboxcarrera.Text = dgvDatosEstudiante.CurrentRow.Cells["Carrera"].Value.ToString();
                comboBoxgrupo.Text = dgvDatosEstudiante.CurrentRow.Cells["Grupo"].Value.ToString();


                DataGridViewRow renglon = (DataGridViewRow)dgvDatosEstudiante.Rows[0].Clone();
                renglon.Cells[0].Value = txtcontrol.Text;
                renglon.Cells[1].Value = txtnombre.Text;
                renglon.Cells[2].Value = txtapellidos.Text;
                renglon.Cells[3].Value = comboxcarrera.Text;
                renglon.Cells[4].Value = comboBoxgrupo.Text;

                dgvDatosEstudiante.Rows.Add(renglon);

            }

        }

        private void consultarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            sistema login = new sistema();
            login.Show();
            Hide();
        }

        private void Imagenbuscar_Click(object sender, EventArgs e)
        {
            if (ValidarCampos() == false)
            {
                return;
            }
            else
            {


                string username = txtnombre.Text;







                // Busca el usuario en el DataGridView
                DataGridViewRow usuario = null;


                if (usuario != null)
                {
                    // Si se encuentra el usuario
                    if (usuario.Cells["Nombre"].Value != null)
                    {
                        txtnombre.Text = usuario.Cells["Nombre"].Value.ToString();
                    }
                    else
                    {
                        // Valor de la celda Nombre es null
                        txtnombre.Text = string.Empty;
                    }


                    foreach (DataGridViewRow row in dgvDatosEstudiante.Rows)
                    {
                        if (row.Cells["Nombre"].Value.ToString() == username)
                        {
                            usuario = row;
                            break;
                        }
                    }

                    if (usuario != null)
                    {
                        // Si se encuentra el usuario, muestra los datos en los campos correspondientes
                        txtcontrol.Text = usuario.Cells["Matricula "].Value.ToString();
                        txtnombre.Text = usuario.Cells["Nombre"].Value.ToString();
                        txtapellidos.Text = usuario.Cells["Apellidosusuario"].Value.ToString();
                        comboxcarrera.Text = usuario.Cells["Carrera"].Value.ToString();
                        comboBoxgrupo.Text = usuario.Cells["Grupo"].Value.ToString();
                    }
                    else if
                        { 

                        txtnombre.Text = dgvDatosEstudiante.CurrentRow.Cells["Nombre"].Value.ToString();
                        txtapellidos.Text = dgvDatosEstudiante.CurrentRow.Cells["Apellidosusuario"].Value.ToString();
                        txtcontrol.Text = dgvDatosEstudiante.CurrentRow.Cells["Matricula"].Value.ToString();
                        comboxcarrera.Text = dgvDatosEstudiante.CurrentRow.Cells["Carrera"].Value.ToString();
                        comboBoxgrupo.Text = dgvDatosEstudiante.CurrentRow.Cells["Grupo"].Value.ToString();

                        // ... Otros campos
                    }
                    }
                    else
                    {
                        // Si no se encuentra el usuario, muestra un mensaje de error
                        MessageBox.Show("Usuario no encontrado", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }



            }
        }

        private void archivoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}


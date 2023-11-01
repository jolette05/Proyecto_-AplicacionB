using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Proyecto__AplicacionB
{
    public partial class AgregarMaestros : Form
    {
        public AgregarMaestros()
        {
            InitializeComponent();
        }

        private void AgregarMaestros_Load(object sender, EventArgs e)
        {

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
                MessageBox.Show("Se ha agruegado correctamente los datos ", "Agregando  Docente",
                  MessageBoxButtons.OK, MessageBoxIcon.Information);


                DataGridViewRow renglon = (DataGridViewRow)dgvDatosEstudiante.Rows[0].Clone();
                renglon.Cells[0].Value = txtcelular.Text;
                renglon.Cells[1].Value = txtnombre.Text;
                renglon.Cells[2].Value = txtapellidos.Text;
                renglon.Cells[3].Value = textcorreo.Text;
                renglon.Cells[4].Value = comboBoxturno.Text;

                dgvDatosEstudiante.Rows.Add(renglon);

                txtnombre.Clear();
                txtapellidos.Clear();
                txtcelular.Clear();
                textcorreo.Clear();

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Agregando  Docente ",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private bool ValidarMatricula()
        {
            
            int Celular;
            if (!int.TryParse(txtcelular.Text, out Celular) || txtcelular.Text == "")
            {
                errorProvider1.SetError(txtcelular, "Solo se aceptan numeros  ");
                txtcelular.Clear();
                txtcelular.Focus();
                return false;



            }
            else
            {
                errorProvider1.SetError(txtcelular, "");
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

                errorProvider1.SetError(txtapellidos, "Debe de ingresar sus apellidos ");
                return false;


            }
            else
            {
                errorProvider1.SetError(txtapellidos, "");
                return true;
            }



        }

        private bool ValidarGrupo()
        {
            if (string.IsNullOrEmpty(comboBoxturno.Text))
            {

                errorProvider1.SetError(comboBoxturno, "Debe de elegir un Turno ");
                return false;


            }
            else
            {
                errorProvider1.SetError(comboBoxturno, "");
                return true;
            }



        }
        private bool ValidarCarrera()
        {
            int ID;
            if (!int.TryParse(txtcelular.Text, out ID) || textcorreo.Text == "")
            {
                errorProvider1.SetError(textcorreo, "Solo se aceptan numeros  ");
                txtcelular.Clear();
                txtcelular.Focus();
                return false;



            }
            else
            {
                errorProvider1.SetError(textcorreo, "");
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


                        MessageBox.Show(ex.Message, "Eliminando   Docente ",
                            MessageBoxButtons.OK, MessageBoxIcon.Error);




                    }
                }
                else
                {
                    MessageBox.Show("Debes seleccionar un renglon", "Eliminando Docente ",
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
                txtcelular.Text = dgvDatosEstudiante.CurrentRow.Cells["Telefono"].Value.ToString();
                textcorreo.Text = dgvDatosEstudiante.CurrentRow.Cells["ID"].Value.ToString();
                comboBoxturno.Text = dgvDatosEstudiante.CurrentRow.Cells["Turno"].Value.ToString();




            }



            }
        }
    }




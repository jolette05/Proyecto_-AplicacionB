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
    public partial class AccionaRealizar : Form
    {
        public AccionaRealizar()
        {
            InitializeComponent();
        }

     

     

        private void pictureBox1_Click_1(object sender, EventArgs e)
        {
            historial_ventas login = new historial_ventas();
            login.Show();
            Hide();
        }

        private void pictureBox2_Click_1(object sender, EventArgs e)
        {
            registar login = new registar();
            login.Show();
            Hide();
        }

        private void QuienInicia_Load(object sender, EventArgs e)
        {

        }

        private void picBoxClientes_Click(object sender, EventArgs e)
        {

        }
    }
    }

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
    public partial class QuienInicia : Form
    {
        public QuienInicia()
        {
            InitializeComponent();
        }

     

     

        private void pictureBox1_Click_1(object sender, EventArgs e)
        {
            AgregarMaestros login = new AgregarMaestros();
            login.Show();
            Hide();
        }

        private void pictureBox2_Click_1(object sender, EventArgs e)
        {
            registar login = new registar();
            login.Show();
            Hide();
        }
    }
    }

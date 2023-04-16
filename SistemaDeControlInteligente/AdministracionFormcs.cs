using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WinFormsApp;

namespace SistemaDeControlInteligente
{
    public partial class AdministracionFormcs : Form
    {
        public AdministracionFormcs()
        {
            InitializeComponent();
        }

        private void AdministracionFormcs_FormClosing(object sender, FormClosingEventArgs e)
        {

                DialogResult result = MessageBox.Show("¿Está seguro que desea salir?", "Confirmación de salida", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);
                if (result == DialogResult.Cancel)
                {
                    e.Cancel = true;
                }
            

        }

        private void button1_Click(object sender, EventArgs e)
        {
            var module1Form = new RegistroRFID();
            module1Form.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            var module1Form = new Estado();
            module1Form.Show();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            var moduleForm = new RegistrarUsuarios();
            moduleForm.Show();
        }
    }
}

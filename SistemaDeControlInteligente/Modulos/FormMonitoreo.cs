using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SistemaDeControlInteligente.Modulos
{
    public partial class FormMonitoreo : Form
    {
        public FormMonitoreo()
        {
            InitializeComponent();
            llenarDatagridview();
        }
        public class Usuario
        {
            public string Nombre { get; set; }
            public string Codigo { get; set; }
            public bool Estado { get; set; }
            public DateTime Fecha { get; set; }
        }
        List<Usuario> listaUsuarios = new List<Usuario>();
        Usuario usuario1 = new Usuario
        {
            Nombre = "Juan Perez",
            Codigo = "1234567890",
            Estado = true,
            Fecha = DateTime.Now
        };

        Usuario usuario2 = new Usuario
        {
            Nombre = "Maria Hernandez",
            Codigo = "0987654321",
            Estado = false,
            Fecha = DateTime.Now.AddDays(-1)
        };


        private void llenarDatagridview()
        {
            listaUsuarios.Add(usuario1);
            listaUsuarios.Add(usuario2);
            dataGridView1.DataSource = listaUsuarios;
            dataGridView1.Columns["Nombre"].HeaderText = "Nombre de Usuario";
            dataGridView1.Columns["Codigo"].HeaderText = "Código";
            dataGridView1.Columns["Estado"].HeaderText = "Estado";
            dataGridView1.Columns["Fecha"].HeaderText = "Fecha";
        }

        private void BtnRefresh_Click(object sender, EventArgs e)
        {
            llenarDatagridview();
        }
    }
}

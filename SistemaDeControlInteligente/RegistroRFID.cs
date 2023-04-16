using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SistemaDeControlInteligente
{
    public partial class RegistroRFID : Form
    {
        public RegistroRFID()
        {
            InitializeComponent();
            BuscarOCrearDirectorioYArchivo();
            Limpiar();
            CargarCodigos();
        }

        private void BtnRegistrar_Click(object sender, EventArgs e)
        {
            try
            {
                Guardar(txtCodigo.Text, CmbEStado.Text);
                CargarCodigos();
            }
           catch(Exception ex)
            {
               MessageBox.Show(ex.Message);
            }
        }
        public static void BuscarOCrearDirectorioYArchivo()
        {
            string path = @"Datos\RegistroRFID.txt";

            if (!Directory.Exists("Datos"))
            {
                Directory.CreateDirectory("Datos");
            }

            if (!File.Exists(path))
            {
                File.Create(path).Dispose();
            }
        }
        private void Guardar(string codigo, string estado)
        {
            // Verificar si la carpeta "Datos" existe y crearla si no
            if (!Directory.Exists("Datos"))
            {
                Directory.CreateDirectory("Datos");
            }

            // Crear o abrir el archivo "RegistroRFID.txt" en modo de escritura
            string path = @"Datos\RegistroRFID.txt";
            using (StreamWriter sw = File.AppendText(path))
            {
                // Escribir el código RFID y su estado en una nueva línea del archivo
                sw.WriteLine($"{codigo},{estado}");

                MessageBox.Show("Guardado Exitoso");
                Limpiar();
            }
        }

        private void EditarCodigo()
        {
            // Obtener el código seleccionado en el ComboBox
            string codigoSeleccionado = cmbEditarCodigos.Text;

            // Obtener el nuevo código ingresado en el TextBox
            string nuevoCodigo = txtNuevoCodigo.Text.Trim();

            // Obtener el nuevo estado seleccionado en el ComboBox
            string nuevoEstado = cmbNuevoEstado.SelectedItem?.ToString()?.Trim();

            // Verificar si los campos tienen valores válidos
            if (string.IsNullOrEmpty(codigoSeleccionado) || string.IsNullOrEmpty(nuevoCodigo) || string.IsNullOrEmpty(nuevoEstado))
            {
                MessageBox.Show("Todos los campos son requeridos.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            // Verificar si el nuevo código ya existe en el archivo
            if (ExisteCodigo(nuevoCodigo) && nuevoCodigo != codigoSeleccionado)
            {
                MessageBox.Show("El código ya existe en el archivo.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            // Abrir el archivo para leer su contenido
            string path = @"Datos\RegistroRFID.txt";
            List<string> lines = new List<string>();
            if (File.Exists(path))
            {
                lines = File.ReadAllLines(path).ToList();

                // Buscar el código seleccionado en el archivo y reemplazarlo con el nuevo código y estado
                for (int i = 0; i < lines.Count; i++)
                {
                    string[] parts = lines[i].Split(',');
                    if (parts[0] == codigoSeleccionado)
                    {
                        lines[i] = nuevoCodigo + "," + nuevoEstado;
                        break;
                    }
                }

                // Guardar los cambios en el archivo
                File.WriteAllLines(path, lines);

                // Actualizar el ComboBox con los códigos actualizados
                cmbEditarCodigos.Items.Clear();
                CargarCodigos();

                MessageBox.Show("El código se ha actualizado correctamente.", "Información", MessageBoxButtons.OK, MessageBoxIcon.Information);

                // Limpiar los controles de entrada
                cmbEditarCodigos.SelectedIndex = -1;
                txtNuevoCodigo.Clear();
                cmbNuevoEstado.SelectedIndex = 0;
            }
            else
            {
                MessageBox.Show("No se pudo encontrar el archivo.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private bool ExisteCodigo(string codigo)
        {
            string path = @"Datos\RegistroRFID.txt";

            if (File.Exists(path))
            {
                string[] lines = File.ReadAllLines(path);

                foreach (string line in lines)
                {
                    string[] parts = line.Split(',');
                    if (parts[0] == codigo)
                    {
                        return true;
                    }
                }
            }

            return false;
        }
        private void Limpiar()
        {
            CmbEStado.SelectedIndex = 0;
            txtCodigo.Text = "";

        }
        private void CargarCodigos()
        {
            // Verificar si el archivo existe
            string path = @"Datos\RegistroRFID.txt";
            if (File.Exists(path))
            {
                // Leer todas las líneas del archivo
                string[] lines = File.ReadAllLines(path);

                // Recorrer cada línea y agregar el código al ComboBox
                foreach (string line in lines)
                {
                    // Dividir la línea en dos partes: el código y el estado (separados por una coma)
                    string[] parts = line.Split(',');
                    string codigo = parts[0];

                    // Agregar el código al ComboBox si no existe ya en él
                    if (!cmbEditarCodigos.Items.Contains(codigo))
                    {
                        cmbEditarCodigos.Items.Add(codigo);
                    }
                }
            }
        }

        private void RegistroRFID_Load(object sender, EventArgs e)
        {

        }

        private void BtnEditar_Click(object sender, EventArgs e)
        {
            try
            {
                EditarCodigo();
                CargarCodigos();
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void CmbEStado_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void txtCodigo_TextChanged(object sender, EventArgs e)
        {

        }
    }
}

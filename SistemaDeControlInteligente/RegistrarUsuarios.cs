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
    public partial class RegistrarUsuarios : Form
    {
        public RegistrarUsuarios()
        {
            InitializeComponent();
        }

        private void BtnRegistrar_Click(object sender, EventArgs e)
        {
            try
            {
                Guardar(txtUsuario.Text,txtPassword.Text);
            }
            catch(Exception ex) 
            {
                MessageBox.Show(ex.Message);
            }
        }
        public void Guardar(string usuario, string contraseña)
        {
            string path = @"Datos\RegistroUsuarios";
            bool usuarioExiste = false;

            // Si el archivo existe, verificamos si el usuario ya está registrado.
            if (File.Exists(path))
            {
                using (StreamReader sr = File.OpenText(path))
                {
                    string s = "";
                    while ((s = sr.ReadLine()) != null)
                    {
                        if (s.StartsWith(usuario + ","))
                        {
                            usuarioExiste = true;
                            break;
                        }
                    }
                }
            }

            // Si el usuario no existe, lo agregamos al archivo.
            if (!usuarioExiste)
            {
                using (StreamWriter sw = File.AppendText(path))
                {
                    sw.WriteLine(usuario + "," + contraseña);
                }
                MessageBox.Show("Usuario registrado exitosamente.");
            }
            // Si el usuario ya existe, mostramos un mensaje de error en un MessageBox.
            else
            {
                MessageBox.Show("El usuario ya existe.");
            }
        }

    }
}

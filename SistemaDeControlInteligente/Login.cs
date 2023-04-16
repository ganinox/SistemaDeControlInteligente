using SistemaDeControlInteligente;
using System;
using System.IO;
using System.Windows.Forms;

namespace WinFormsApp
{
    public partial class LoginForm : Form
    {
        public LoginForm()
        {
            InitializeComponent();
            BuscarOCrearDirectorioYArchivo();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            bool userAuthenticated = false;
            string username = txtUsername.Text;
            string password = txtPassword.Text;
            string path = @"Datos\RegistroUsuarios";

            if (username == "admin" && password == "admin")
            {
                // Si el usuario es el administrador, se autentica directamente
                userAuthenticated = true;
            }
            else
            {
                // Si el usuario no es el administrador, se busca en el archivo
                if (File.Exists(path))
                {
                    using (StreamReader sr = new StreamReader(path))
                    {
                        string line;
                        while ((line = sr.ReadLine()) != null)
                        {
                            string[] parts = line.Split(',');
                            if (parts[0] == username && parts[1] == password)
                            {
                                // Si se encuentra el usuario y contraseña, se autentica
                                userAuthenticated = true;
                                break;
                            }
                        }
                    }
                }
            }

            if (userAuthenticated)
            {
                DialogResult = DialogResult.OK;
                Llenarcache();
                MainForm main = new MainForm();
                main.Show();
                this.Hide();
            }
            else
            {
                MessageBox.Show("El usuario o la contraseña son incorrectos.", "Error de autenticación", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }


        private void btnCancel_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.Cancel;
        }

        private void Llenarcache()
        {
            CacheUsercs.Admin = true;
            CacheUsercs.User = txtUsername.Text;
            CacheUsercs.Password = txtPassword.Text;
            CacheUsercs.Code = "HD1080P365";
            CacheUsercs.Admin = false;
        }
        public static void BuscarOCrearDirectorioYArchivo()
        {
            string path = @"Datos\RegistroUsuarios";

            if (!Directory.Exists("Datos"))
            {
                Directory.CreateDirectory("Datos");
            }

            if (!File.Exists(path))
            {
                File.Create(path).Dispose();
            }
        }
    }
}

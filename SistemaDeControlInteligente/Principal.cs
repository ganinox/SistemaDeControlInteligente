using SistemaDeControlInteligente;
using SistemaDeControlInteligente.Modulos;
using System;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;


using SistemaDeControlInteligente.Properties;
namespace WinFormsApp
{
    public partial class Principal : Form
    {
        public Principal()
        {
            InitializeComponent();
            LoadCache();
        }

        private void btnAuthenticationModule_Click(object sender, EventArgs e)
        {
            var loginForm = new LoginForm();
            if (loginForm.ShowDialog() == DialogResult.OK)
            {
                MessageBox.Show("Autenticación exitosa.", "Autenticación", MessageBoxButtons.OK, MessageBoxIcon.Information);
                btnModule1.Enabled = true;
                btnModule2.Enabled = true;
                btnModule3.Enabled = true;
            }
        }

        private void btnModule1_Click(object sender, EventArgs e)
        {
            var module1Form = new FormMonitoreo();
            module1Form.ShowDialog();
        }

        private void btnModule2_Click(object sender, EventArgs e)
        {
           // var module2Form = new Module2Form();
           // module2Form.ShowDialog();
        }

        private void btnModule3_Click(object sender, EventArgs e)
        {
            //var module3Form = new Module3Form();
            //module3Form.ShowDialog();
        }

        private void LoadCache()
        {
            LblUsuarioIngresado.Text = "Usuario: " + CacheUsercs.User + " ID: " + CacheUsercs.Code;

            if(CacheUsercs.Admin== false)
            {
                btnModule3.Enabled = true;
            }
        }

        private void btnModule2_Click_1(object sender, EventArgs e)
        {
           

            Random random = new Random();
            int result = random.Next(1, 3);
            if (result == 1)
            {
                Notificacion notificacion = new Notificacion();
                notificacion.burbuja("Mario", "X345FDRH67", true);
            }
            else
            {
                Notificacion notificacion = new Notificacion();
                notificacion.burbuja("Mario", "X345FDRH67", false);
            }
        }

        private void btnModule3_Click_1(object sender, EventArgs e)
        {
            this.Hide();
            var module1Form = new AdministracionFormcs();
            module1Form.Show();
            module1Form.FormClosed += Logout;

           
        }
        private void Logout(object sender, FormClosedEventArgs e)
        {

            this.Show();

        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.Hide();
            var module1Form = new Opciones();
            module1Form.Show();
            module1Form.FormClosed += Logout;
        }
        private void Form1_Resize(object sender, EventArgs e)
        {
            // Oculta el formulario en la bandeja de sistema si la propiedad EsconderFormularios está activada
            if (SistemaDeControlInteligente.Properties.Settings.Default.EsconderFormularios && this.WindowState == FormWindowState.Minimized)
            {
                // Oculta el formulario de la barra de tareas
                this.ShowInTaskbar = false;

                // Muestra el icono del NotifyIcon en la bandeja de sistema
                IconoNotificacion.Visible = true;
            }
        }

        private void IconoNotificacion_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            this.WindowState = FormWindowState.Normal;
            this.ShowInTaskbar = true;

            // Oculta el icono del NotifyIcon en la bandeja de sistema
            IconoNotificacion.Visible = false;
        }
    }
            
    }


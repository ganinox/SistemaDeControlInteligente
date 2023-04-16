using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Microsoft.Win32;
namespace SistemaDeControlInteligente
{
    public partial class Opciones : Form
    {
        public Opciones()
        {
            InitializeComponent();
            Opciones_Load();
            //VolverIcono();
            if (Properties.Settings.Default.EsconderFormularios == true)
            {
                checkBox2.Checked= true;
            }
            }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            RegistryKey reg = Registry.CurrentUser.OpenSubKey("SOFTWARE\\Microsoft\\Windows\\CurrentVersion\\Run", true);

            // Agregar o eliminar la entrada según el estado del checkbox
            if (checkBox1.Checked)
            {
                // Agregar la ruta de la aplicación a la clave de ejecución automática
                reg.SetValue("MiAplicacion", Application.ExecutablePath);
            }
            else
            {
                // Eliminar la entrada correspondiente a la aplicación
                reg.DeleteValue("MiAplicacion", false);
            }
        }
        private void Opciones_Load()
        {
            // Obtener la clave de ejecución automática de usuario actual de Windows
            RegistryKey reg = Registry.CurrentUser.OpenSubKey("SOFTWARE\\Microsoft\\Windows\\CurrentVersion\\Run", true);

            // Verificar si la aplicación está en la lista de ejecución automática
            string value = (string)reg.GetValue("MiAplicacion");
            if (value == Application.ExecutablePath)
            {
                // La aplicación está configurada para iniciarse con Windows
                checkBox1.Checked = true;
            }
            else
            {
                // La aplicación no está configurada para iniciarse con Windows
                checkBox1.Checked = false;
            }
        }
     
        private void VolverIcono()
        {
            if (Properties.Settings.Default.EsconderFormularios)
            {
                // Establece el estado del formulario como "minimizado"
                this.WindowState = FormWindowState.Minimized;

                // Oculta el formulario de la barra de tareas
                this.ShowInTaskbar = false;

                // Muestra el icono del NotifyIcon en la bandeja de sistema
                IconoNotificacion.Visible = true;
            }
        }
        private void Form1_Resize(object sender, EventArgs e)
        {
            // Oculta el formulario en la bandeja de sistema si la propiedad EsconderFormularios está activada
            if (Properties.Settings.Default.EsconderFormularios && this.WindowState == FormWindowState.Minimized)
            {
                // Oculta el formulario de la barra de tareas
                this.ShowInTaskbar = false;

                // Muestra el icono del NotifyIcon en la bandeja de sistema
                IconoNotificacion.Visible = true;
            }
        }

        private void checkBox2_CheckedChanged(object sender, EventArgs e)
        {

                // Actualizar la propiedad EsconderFormularios
                Properties.Settings.Default.EsconderFormularios = checkBox2.Checked;

                // Guardar la configuración en el archivo app.config
                Properties.Settings.Default.Save();
            

        }

        private void notifyIcon1_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            this.WindowState = FormWindowState.Normal;
            this.ShowInTaskbar = true;

            // Oculta el icono del NotifyIcon en la bandeja de sistema
            IconoNotificacion.Visible = false;
        }
    }

}

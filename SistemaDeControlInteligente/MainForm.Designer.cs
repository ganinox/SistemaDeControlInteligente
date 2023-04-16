namespace WinFormsApp
{
    partial class MainForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.btnModule1 = new System.Windows.Forms.Button();
            this.btnModule3 = new System.Windows.Forms.Button();
            this.btnModule2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.LblUsuarioIngresado = new System.Windows.Forms.Label();
            this.IconoNotificacion = new System.Windows.Forms.NotifyIcon(this.components);
            this.SuspendLayout();
            // 
            // btnModule1
            // 
            this.btnModule1.Location = new System.Drawing.Point(30, 84);
            this.btnModule1.Name = "btnModule1";
            this.btnModule1.Size = new System.Drawing.Size(321, 47);
            this.btnModule1.TabIndex = 5;
            this.btnModule1.Text = "Monitoreo";
            this.btnModule1.UseVisualStyleBackColor = true;
            this.btnModule1.Click += new System.EventHandler(this.btnModule1_Click);
            // 
            // btnModule3
            // 
            this.btnModule3.Location = new System.Drawing.Point(32, 244);
            this.btnModule3.Name = "btnModule3";
            this.btnModule3.Size = new System.Drawing.Size(321, 47);
            this.btnModule3.TabIndex = 6;
            this.btnModule3.Text = "Administracion";
            this.btnModule3.UseVisualStyleBackColor = true;
            this.btnModule3.Click += new System.EventHandler(this.btnModule3_Click_1);
            // 
            // btnModule2
            // 
            this.btnModule2.Location = new System.Drawing.Point(30, 159);
            this.btnModule2.Name = "btnModule2";
            this.btnModule2.Size = new System.Drawing.Size(321, 47);
            this.btnModule2.TabIndex = 7;
            this.btnModule2.Text = "Notificaciones";
            this.btnModule2.UseVisualStyleBackColor = true;
            this.btnModule2.Click += new System.EventHandler(this.btnModule2_Click_1);
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(30, 358);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(321, 47);
            this.button3.TabIndex = 8;
            this.button3.Text = "Opciones";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // LblUsuarioIngresado
            // 
            this.LblUsuarioIngresado.AutoSize = true;
            this.LblUsuarioIngresado.Location = new System.Drawing.Point(29, 35);
            this.LblUsuarioIngresado.Name = "LblUsuarioIngresado";
            this.LblUsuarioIngresado.Size = new System.Drawing.Size(118, 16);
            this.LblUsuarioIngresado.TabIndex = 9;
            this.LblUsuarioIngresado.Text = "User Place Holder";
            // 
            // IconoNotificacion
            // 
            this.IconoNotificacion.Icon = ((System.Drawing.Icon)(resources.GetObject("IconoNotificacion.Icon")));
            this.IconoNotificacion.Text = "RFID";
            this.IconoNotificacion.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.IconoNotificacion_MouseDoubleClick);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(379, 450);
            this.Controls.Add(this.LblUsuarioIngresado);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.btnModule2);
            this.Controls.Add(this.btnModule3);
            this.Controls.Add(this.btnModule1);
            this.Name = "MainForm";
            this.Text = "MainForm";
            this.Resize += new System.EventHandler(this.Form1_Resize);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnModule1;
        private System.Windows.Forms.Button btnModule3;
        private System.Windows.Forms.Button btnModule2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Label LblUsuarioIngresado;
        private System.Windows.Forms.NotifyIcon IconoNotificacion;
    }
}
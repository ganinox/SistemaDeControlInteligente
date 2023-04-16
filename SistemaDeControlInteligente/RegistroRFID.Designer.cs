namespace SistemaDeControlInteligente
{
    partial class RegistroRFID
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
            this.txtCodigo = new System.Windows.Forms.TextBox();
            this.CmbEStado = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.BtnRegistrar = new System.Windows.Forms.Button();
            this.cmbEditarCodigos = new System.Windows.Forms.ComboBox();
            this.txtNuevoCodigo = new System.Windows.Forms.TextBox();
            this.cmbNuevoEstado = new System.Windows.Forms.ComboBox();
            this.BtnEditar = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // txtCodigo
            // 
            this.txtCodigo.Location = new System.Drawing.Point(194, 62);
            this.txtCodigo.Name = "txtCodigo";
            this.txtCodigo.Size = new System.Drawing.Size(236, 22);
            this.txtCodigo.TabIndex = 0;
            this.txtCodigo.TextChanged += new System.EventHandler(this.txtCodigo_TextChanged);
            // 
            // CmbEStado
            // 
            this.CmbEStado.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.CmbEStado.FormattingEnabled = true;
            this.CmbEStado.Items.AddRange(new object[] {
            "Activo",
            "Inactivo"});
            this.CmbEStado.Location = new System.Drawing.Point(194, 117);
            this.CmbEStado.Name = "CmbEStado";
            this.CmbEStado.Size = new System.Drawing.Size(236, 24);
            this.CmbEStado.TabIndex = 1;
            this.CmbEStado.SelectedIndexChanged += new System.EventHandler(this.CmbEStado_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(91, 68);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(59, 16);
            this.label1.TabIndex = 2;
            this.label1.Text = "CODIGO";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(91, 125);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(63, 16);
            this.label2.TabIndex = 3;
            this.label2.Text = "ESTADO";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // BtnRegistrar
            // 
            this.BtnRegistrar.Location = new System.Drawing.Point(176, 157);
            this.BtnRegistrar.Name = "BtnRegistrar";
            this.BtnRegistrar.Size = new System.Drawing.Size(172, 71);
            this.BtnRegistrar.TabIndex = 4;
            this.BtnRegistrar.Text = "Registrar";
            this.BtnRegistrar.UseVisualStyleBackColor = true;
            this.BtnRegistrar.Click += new System.EventHandler(this.BtnRegistrar_Click);
            // 
            // cmbEditarCodigos
            // 
            this.cmbEditarCodigos.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbEditarCodigos.FormattingEnabled = true;
            this.cmbEditarCodigos.Location = new System.Drawing.Point(194, 266);
            this.cmbEditarCodigos.Name = "cmbEditarCodigos";
            this.cmbEditarCodigos.Size = new System.Drawing.Size(236, 24);
            this.cmbEditarCodigos.TabIndex = 5;
            // 
            // txtNuevoCodigo
            // 
            this.txtNuevoCodigo.Location = new System.Drawing.Point(194, 307);
            this.txtNuevoCodigo.Name = "txtNuevoCodigo";
            this.txtNuevoCodigo.Size = new System.Drawing.Size(236, 22);
            this.txtNuevoCodigo.TabIndex = 6;
            // 
            // cmbNuevoEstado
            // 
            this.cmbNuevoEstado.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbNuevoEstado.FormattingEnabled = true;
            this.cmbNuevoEstado.Items.AddRange(new object[] {
            "Activo",
            "Inactivo"});
            this.cmbNuevoEstado.Location = new System.Drawing.Point(194, 345);
            this.cmbNuevoEstado.Name = "cmbNuevoEstado";
            this.cmbNuevoEstado.Size = new System.Drawing.Size(236, 24);
            this.cmbNuevoEstado.TabIndex = 7;
            // 
            // BtnEditar
            // 
            this.BtnEditar.Location = new System.Drawing.Point(176, 391);
            this.BtnEditar.Name = "BtnEditar";
            this.BtnEditar.Size = new System.Drawing.Size(172, 71);
            this.BtnEditar.TabIndex = 8;
            this.BtnEditar.Text = "Editar";
            this.BtnEditar.UseVisualStyleBackColor = true;
            this.BtnEditar.Click += new System.EventHandler(this.BtnEditar_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(34, 274);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(137, 16);
            this.label3.TabIndex = 9;
            this.label3.Text = "CODIGO EXISTENTE";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(61, 310);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(110, 16);
            this.label4.TabIndex = 10;
            this.label4.Text = "CODIGO NUEVO";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(57, 348);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(114, 16);
            this.label5.TabIndex = 11;
            this.label5.Text = "ESTADO NUEVO";
            // 
            // RegistroRFID
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(481, 525);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.BtnEditar);
            this.Controls.Add(this.cmbNuevoEstado);
            this.Controls.Add(this.txtNuevoCodigo);
            this.Controls.Add(this.cmbEditarCodigos);
            this.Controls.Add(this.BtnRegistrar);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.CmbEStado);
            this.Controls.Add(this.txtCodigo);
            this.Name = "RegistroRFID";
            this.Text = "RegistroRFID";
            this.Load += new System.EventHandler(this.RegistroRFID_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtCodigo;
        private System.Windows.Forms.ComboBox CmbEStado;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button BtnRegistrar;
        private System.Windows.Forms.ComboBox cmbEditarCodigos;
        private System.Windows.Forms.TextBox txtNuevoCodigo;
        private System.Windows.Forms.ComboBox cmbNuevoEstado;
        private System.Windows.Forms.Button BtnEditar;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
    }
}
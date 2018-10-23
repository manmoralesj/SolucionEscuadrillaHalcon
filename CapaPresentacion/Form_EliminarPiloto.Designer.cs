namespace CapaPresentacion
{
    partial class Form_EliminarPiloto
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
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.btnBuscar = new MetroFramework.Controls.MetroButton();
            this.metroLabel4 = new MetroFramework.Controls.MetroLabel();
            this.txtRut = new MetroFramework.Controls.MetroTextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.txtApPaterno = new MetroFramework.Controls.MetroTextBox();
            this.metroLabel1 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel2 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel3 = new MetroFramework.Controls.MetroLabel();
            this.txtNombre = new MetroFramework.Controls.MetroTextBox();
            this.txtApMaterno = new MetroFramework.Controls.MetroTextBox();
            this.btnEliminar = new MetroFramework.Controls.MetroButton();
            this.groupBox4.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(265, 119);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(220, 38);
            this.label1.TabIndex = 63;
            this.label1.Text = "Eliminar piloto";
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.btnBuscar);
            this.groupBox4.Controls.Add(this.metroLabel4);
            this.groupBox4.Controls.Add(this.txtRut);
            this.groupBox4.Location = new System.Drawing.Point(66, 204);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(604, 65);
            this.groupBox4.TabIndex = 64;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Búsqueda de piloto";
            // 
            // btnBuscar
            // 
            this.btnBuscar.Location = new System.Drawing.Point(399, 21);
            this.btnBuscar.Name = "btnBuscar";
            this.btnBuscar.Size = new System.Drawing.Size(140, 29);
            this.btnBuscar.TabIndex = 51;
            this.btnBuscar.Text = "Buscar";
            this.btnBuscar.UseSelectable = true;
            this.btnBuscar.Click += new System.EventHandler(this.metroButton2_Click);
            // 
            // metroLabel4
            // 
            this.metroLabel4.AutoSize = true;
            this.metroLabel4.Location = new System.Drawing.Point(15, 24);
            this.metroLabel4.Name = "metroLabel4";
            this.metroLabel4.Size = new System.Drawing.Size(76, 20);
            this.metroLabel4.TabIndex = 38;
            this.metroLabel4.Text = "RUT Piloto:";
            // 
            // txtRut
            // 
            this.txtRut.BackColor = System.Drawing.Color.White;
            // 
            // 
            // 
            this.txtRut.CustomButton.Image = null;
            this.txtRut.CustomButton.Location = new System.Drawing.Point(129, 1);
            this.txtRut.CustomButton.Name = "";
            this.txtRut.CustomButton.Size = new System.Drawing.Size(27, 27);
            this.txtRut.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txtRut.CustomButton.TabIndex = 1;
            this.txtRut.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txtRut.CustomButton.UseSelectable = true;
            this.txtRut.CustomButton.Visible = false;
            this.txtRut.Lines = new string[0];
            this.txtRut.Location = new System.Drawing.Point(199, 21);
            this.txtRut.MaxLength = 32767;
            this.txtRut.Name = "txtRut";
            this.txtRut.PasswordChar = '\0';
            this.txtRut.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtRut.SelectedText = "";
            this.txtRut.SelectionLength = 0;
            this.txtRut.SelectionStart = 0;
            this.txtRut.ShortcutsEnabled = true;
            this.txtRut.Size = new System.Drawing.Size(157, 29);
            this.txtRut.Style = MetroFramework.MetroColorStyle.Orange;
            this.txtRut.TabIndex = 50;
            this.txtRut.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txtRut.UseSelectable = true;
            this.txtRut.UseStyleColors = true;
            this.txtRut.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txtRut.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.txtApPaterno);
            this.groupBox1.Controls.Add(this.metroLabel1);
            this.groupBox1.Controls.Add(this.metroLabel2);
            this.groupBox1.Controls.Add(this.metroLabel3);
            this.groupBox1.Controls.Add(this.txtNombre);
            this.groupBox1.Controls.Add(this.txtApMaterno);
            this.groupBox1.Location = new System.Drawing.Point(66, 294);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(604, 133);
            this.groupBox1.TabIndex = 65;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Datos Personales";
            // 
            // txtApPaterno
            // 
            this.txtApPaterno.BackColor = System.Drawing.Color.White;
            // 
            // 
            // 
            this.txtApPaterno.CustomButton.Image = null;
            this.txtApPaterno.CustomButton.Location = new System.Drawing.Point(82, 1);
            this.txtApPaterno.CustomButton.Name = "";
            this.txtApPaterno.CustomButton.Size = new System.Drawing.Size(27, 27);
            this.txtApPaterno.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txtApPaterno.CustomButton.TabIndex = 1;
            this.txtApPaterno.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txtApPaterno.CustomButton.UseSelectable = true;
            this.txtApPaterno.CustomButton.Visible = false;
            this.txtApPaterno.Lines = new string[0];
            this.txtApPaterno.Location = new System.Drawing.Point(199, 85);
            this.txtApPaterno.MaxLength = 32767;
            this.txtApPaterno.Name = "txtApPaterno";
            this.txtApPaterno.PasswordChar = '\0';
            this.txtApPaterno.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtApPaterno.SelectedText = "";
            this.txtApPaterno.SelectionLength = 0;
            this.txtApPaterno.SelectionStart = 0;
            this.txtApPaterno.ShortcutsEnabled = true;
            this.txtApPaterno.Size = new System.Drawing.Size(110, 29);
            this.txtApPaterno.Style = MetroFramework.MetroColorStyle.Orange;
            this.txtApPaterno.TabIndex = 36;
            this.txtApPaterno.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txtApPaterno.UseSelectable = true;
            this.txtApPaterno.UseStyleColors = true;
            this.txtApPaterno.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txtApPaterno.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // metroLabel1
            // 
            this.metroLabel1.AutoSize = true;
            this.metroLabel1.Location = new System.Drawing.Point(19, 36);
            this.metroLabel1.Name = "metroLabel1";
            this.metroLabel1.Size = new System.Drawing.Size(70, 20);
            this.metroLabel1.TabIndex = 34;
            this.metroLabel1.Text = "Nombres:";
            // 
            // metroLabel2
            // 
            this.metroLabel2.AutoSize = true;
            this.metroLabel2.Location = new System.Drawing.Point(19, 82);
            this.metroLabel2.Name = "metroLabel2";
            this.metroLabel2.Size = new System.Drawing.Size(113, 20);
            this.metroLabel2.TabIndex = 35;
            this.metroLabel2.Text = "Apellido Paterno:";
            // 
            // metroLabel3
            // 
            this.metroLabel3.AutoSize = true;
            this.metroLabel3.Location = new System.Drawing.Point(325, 82);
            this.metroLabel3.Name = "metroLabel3";
            this.metroLabel3.Size = new System.Drawing.Size(118, 20);
            this.metroLabel3.TabIndex = 37;
            this.metroLabel3.Text = "Apellido Materno:";
            // 
            // txtNombre
            // 
            this.txtNombre.BackColor = System.Drawing.Color.White;
            // 
            // 
            // 
            this.txtNombre.CustomButton.Image = null;
            this.txtNombre.CustomButton.Location = new System.Drawing.Point(129, 1);
            this.txtNombre.CustomButton.Name = "";
            this.txtNombre.CustomButton.Size = new System.Drawing.Size(27, 27);
            this.txtNombre.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txtNombre.CustomButton.TabIndex = 1;
            this.txtNombre.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txtNombre.CustomButton.UseSelectable = true;
            this.txtNombre.CustomButton.Visible = false;
            this.txtNombre.Lines = new string[0];
            this.txtNombre.Location = new System.Drawing.Point(199, 39);
            this.txtNombre.MaxLength = 32767;
            this.txtNombre.Name = "txtNombre";
            this.txtNombre.PasswordChar = '\0';
            this.txtNombre.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtNombre.SelectedText = "";
            this.txtNombre.SelectionLength = 0;
            this.txtNombre.SelectionStart = 0;
            this.txtNombre.ShortcutsEnabled = true;
            this.txtNombre.Size = new System.Drawing.Size(157, 29);
            this.txtNombre.Style = MetroFramework.MetroColorStyle.Orange;
            this.txtNombre.TabIndex = 51;
            this.txtNombre.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txtNombre.UseSelectable = true;
            this.txtNombre.UseStyleColors = true;
            this.txtNombre.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txtNombre.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // txtApMaterno
            // 
            this.txtApMaterno.BackColor = System.Drawing.Color.White;
            // 
            // 
            // 
            this.txtApMaterno.CustomButton.Image = null;
            this.txtApMaterno.CustomButton.Location = new System.Drawing.Point(84, 1);
            this.txtApMaterno.CustomButton.Name = "";
            this.txtApMaterno.CustomButton.Size = new System.Drawing.Size(25, 25);
            this.txtApMaterno.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txtApMaterno.CustomButton.TabIndex = 1;
            this.txtApMaterno.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txtApMaterno.CustomButton.UseSelectable = true;
            this.txtApMaterno.CustomButton.Visible = false;
            this.txtApMaterno.Lines = new string[0];
            this.txtApMaterno.Location = new System.Drawing.Point(479, 82);
            this.txtApMaterno.MaxLength = 32767;
            this.txtApMaterno.Name = "txtApMaterno";
            this.txtApMaterno.PasswordChar = '\0';
            this.txtApMaterno.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtApMaterno.SelectedText = "";
            this.txtApMaterno.SelectionLength = 0;
            this.txtApMaterno.SelectionStart = 0;
            this.txtApMaterno.ShortcutsEnabled = true;
            this.txtApMaterno.Size = new System.Drawing.Size(110, 27);
            this.txtApMaterno.Style = MetroFramework.MetroColorStyle.Orange;
            this.txtApMaterno.TabIndex = 52;
            this.txtApMaterno.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txtApMaterno.UseSelectable = true;
            this.txtApMaterno.UseStyleColors = true;
            this.txtApMaterno.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txtApMaterno.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // btnEliminar
            // 
            this.btnEliminar.FontSize = MetroFramework.MetroButtonSize.Tall;
            this.btnEliminar.FontWeight = MetroFramework.MetroButtonWeight.Regular;
            this.btnEliminar.Location = new System.Drawing.Point(67, 456);
            this.btnEliminar.Name = "btnEliminar";
            this.btnEliminar.Size = new System.Drawing.Size(131, 45);
            this.btnEliminar.Style = MetroFramework.MetroColorStyle.Orange;
            this.btnEliminar.TabIndex = 66;
            this.btnEliminar.Text = "Eliminar";
            this.btnEliminar.Theme = MetroFramework.MetroThemeStyle.Light;
            this.btnEliminar.UseSelectable = true;
            this.btnEliminar.Click += new System.EventHandler(this.btnEliminar_Click);
            // 
            // Form_EliminarPiloto
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(754, 650);
            this.Controls.Add(this.btnEliminar);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.groupBox4);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Form_EliminarPiloto";
            this.Text = "Form_EliminarPiloto";
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox4;
        private MetroFramework.Controls.MetroButton btnBuscar;
        private MetroFramework.Controls.MetroLabel metroLabel4;
        private MetroFramework.Controls.MetroTextBox txtRut;
        private System.Windows.Forms.GroupBox groupBox1;
        private MetroFramework.Controls.MetroTextBox txtApPaterno;
        private MetroFramework.Controls.MetroLabel metroLabel1;
        private MetroFramework.Controls.MetroLabel metroLabel2;
        private MetroFramework.Controls.MetroLabel metroLabel3;
        private MetroFramework.Controls.MetroTextBox txtNombre;
        private MetroFramework.Controls.MetroTextBox txtApMaterno;
        private MetroFramework.Controls.MetroButton btnEliminar;
    }
}
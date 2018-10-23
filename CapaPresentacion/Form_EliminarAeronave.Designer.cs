namespace CapaPresentacion
{
    partial class Form_EliminarAeronave
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
            this.btnDesactivar = new MetroFramework.Controls.MetroButton();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.btnBuscar = new MetroFramework.Controls.MetroButton();
            this.metroLabel4 = new MetroFramework.Controls.MetroLabel();
            this.txtMatricula = new MetroFramework.Controls.MetroTextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.txtAnioFab = new MetroFramework.Controls.MetroTextBox();
            this.metroLabel5 = new MetroFramework.Controls.MetroLabel();
            this.txtFechaInspeccion = new MetroFramework.Controls.MetroDateTime();
            this.metroLabel1 = new MetroFramework.Controls.MetroLabel();
            this.txtHorasVoladas = new MetroFramework.Controls.MetroTextBox();
            this.metroLabel3 = new MetroFramework.Controls.MetroLabel();
            this.groupBox4.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnDesactivar
            // 
            this.btnDesactivar.FontSize = MetroFramework.MetroButtonSize.Tall;
            this.btnDesactivar.FontWeight = MetroFramework.MetroButtonWeight.Regular;
            this.btnDesactivar.Location = new System.Drawing.Point(88, 489);
            this.btnDesactivar.Name = "btnDesactivar";
            this.btnDesactivar.Size = new System.Drawing.Size(131, 45);
            this.btnDesactivar.Style = MetroFramework.MetroColorStyle.Orange;
            this.btnDesactivar.TabIndex = 68;
            this.btnDesactivar.Text = "Desactivar";
            this.btnDesactivar.Theme = MetroFramework.MetroThemeStyle.Light;
            this.btnDesactivar.UseSelectable = true;
            this.btnDesactivar.Click += new System.EventHandler(this.btnDesactivar_Click);
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.btnBuscar);
            this.groupBox4.Controls.Add(this.metroLabel4);
            this.groupBox4.Controls.Add(this.txtMatricula);
            this.groupBox4.Location = new System.Drawing.Point(88, 216);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(573, 65);
            this.groupBox4.TabIndex = 67;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Búsqueda de Aeronave";
            // 
            // btnBuscar
            // 
            this.btnBuscar.Location = new System.Drawing.Point(399, 21);
            this.btnBuscar.Name = "btnBuscar";
            this.btnBuscar.Size = new System.Drawing.Size(140, 29);
            this.btnBuscar.TabIndex = 51;
            this.btnBuscar.Text = "Buscar";
            this.btnBuscar.UseSelectable = true;
            this.btnBuscar.Click += new System.EventHandler(this.btnBuscar_Click);
            // 
            // metroLabel4
            // 
            this.metroLabel4.AutoSize = true;
            this.metroLabel4.Location = new System.Drawing.Point(15, 24);
            this.metroLabel4.Name = "metroLabel4";
            this.metroLabel4.Size = new System.Drawing.Size(68, 20);
            this.metroLabel4.TabIndex = 38;
            this.metroLabel4.Text = "Matricula:";
            // 
            // txtMatricula
            // 
            this.txtMatricula.BackColor = System.Drawing.Color.White;
            // 
            // 
            // 
            this.txtMatricula.CustomButton.Image = null;
            this.txtMatricula.CustomButton.Location = new System.Drawing.Point(129, 1);
            this.txtMatricula.CustomButton.Name = "";
            this.txtMatricula.CustomButton.Size = new System.Drawing.Size(27, 27);
            this.txtMatricula.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txtMatricula.CustomButton.TabIndex = 1;
            this.txtMatricula.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txtMatricula.CustomButton.UseSelectable = true;
            this.txtMatricula.CustomButton.Visible = false;
            this.txtMatricula.Lines = new string[0];
            this.txtMatricula.Location = new System.Drawing.Point(199, 21);
            this.txtMatricula.MaxLength = 32767;
            this.txtMatricula.Name = "txtMatricula";
            this.txtMatricula.PasswordChar = '\0';
            this.txtMatricula.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtMatricula.SelectedText = "";
            this.txtMatricula.SelectionLength = 0;
            this.txtMatricula.SelectionStart = 0;
            this.txtMatricula.ShortcutsEnabled = true;
            this.txtMatricula.Size = new System.Drawing.Size(157, 29);
            this.txtMatricula.Style = MetroFramework.MetroColorStyle.Orange;
            this.txtMatricula.TabIndex = 50;
            this.txtMatricula.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txtMatricula.UseSelectable = true;
            this.txtMatricula.UseStyleColors = true;
            this.txtMatricula.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txtMatricula.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(234, 130);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(322, 38);
            this.label1.TabIndex = 69;
            this.label1.Text = "Desactivar Aeronave";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.txtAnioFab);
            this.groupBox2.Controls.Add(this.metroLabel5);
            this.groupBox2.Controls.Add(this.txtFechaInspeccion);
            this.groupBox2.Controls.Add(this.metroLabel1);
            this.groupBox2.Controls.Add(this.txtHorasVoladas);
            this.groupBox2.Controls.Add(this.metroLabel3);
            this.groupBox2.Location = new System.Drawing.Point(88, 297);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(573, 175);
            this.groupBox2.TabIndex = 70;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Datos Aeronave:";
            // 
            // txtAnioFab
            // 
            // 
            // 
            // 
            this.txtAnioFab.CustomButton.Image = null;
            this.txtAnioFab.CustomButton.Location = new System.Drawing.Point(64, 1);
            this.txtAnioFab.CustomButton.Name = "";
            this.txtAnioFab.CustomButton.Size = new System.Drawing.Size(25, 25);
            this.txtAnioFab.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txtAnioFab.CustomButton.TabIndex = 1;
            this.txtAnioFab.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txtAnioFab.CustomButton.UseSelectable = true;
            this.txtAnioFab.CustomButton.Visible = false;
            this.txtAnioFab.Lines = new string[0];
            this.txtAnioFab.Location = new System.Drawing.Point(199, 132);
            this.txtAnioFab.MaxLength = 32767;
            this.txtAnioFab.Name = "txtAnioFab";
            this.txtAnioFab.PasswordChar = '\0';
            this.txtAnioFab.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtAnioFab.SelectedText = "";
            this.txtAnioFab.SelectionLength = 0;
            this.txtAnioFab.SelectionStart = 0;
            this.txtAnioFab.ShortcutsEnabled = true;
            this.txtAnioFab.Size = new System.Drawing.Size(90, 27);
            this.txtAnioFab.Style = MetroFramework.MetroColorStyle.Orange;
            this.txtAnioFab.TabIndex = 7;
            this.txtAnioFab.UseSelectable = true;
            this.txtAnioFab.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txtAnioFab.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // metroLabel5
            // 
            this.metroLabel5.AutoSize = true;
            this.metroLabel5.Location = new System.Drawing.Point(15, 139);
            this.metroLabel5.Name = "metroLabel5";
            this.metroLabel5.Size = new System.Drawing.Size(110, 20);
            this.metroLabel5.TabIndex = 6;
            this.metroLabel5.Text = "Año Fabricación:";
            // 
            // txtFechaInspeccion
            // 
            this.txtFechaInspeccion.Location = new System.Drawing.Point(199, 79);
            this.txtFechaInspeccion.MinimumSize = new System.Drawing.Size(0, 30);
            this.txtFechaInspeccion.Name = "txtFechaInspeccion";
            this.txtFechaInspeccion.Size = new System.Drawing.Size(292, 30);
            this.txtFechaInspeccion.Style = MetroFramework.MetroColorStyle.Orange;
            this.txtFechaInspeccion.TabIndex = 5;
            // 
            // metroLabel1
            // 
            this.metroLabel1.AutoSize = true;
            this.metroLabel1.Location = new System.Drawing.Point(15, 89);
            this.metroLabel1.Name = "metroLabel1";
            this.metroLabel1.Size = new System.Drawing.Size(117, 20);
            this.metroLabel1.TabIndex = 4;
            this.metroLabel1.Text = "Inspección Anual:";
            // 
            // txtHorasVoladas
            // 
            // 
            // 
            // 
            this.txtHorasVoladas.CustomButton.Image = null;
            this.txtHorasVoladas.CustomButton.Location = new System.Drawing.Point(108, 2);
            this.txtHorasVoladas.CustomButton.Name = "";
            this.txtHorasVoladas.CustomButton.Size = new System.Drawing.Size(23, 23);
            this.txtHorasVoladas.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txtHorasVoladas.CustomButton.TabIndex = 1;
            this.txtHorasVoladas.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txtHorasVoladas.CustomButton.UseSelectable = true;
            this.txtHorasVoladas.CustomButton.Visible = false;
            this.txtHorasVoladas.Lines = new string[0];
            this.txtHorasVoladas.Location = new System.Drawing.Point(199, 32);
            this.txtHorasVoladas.MaxLength = 32767;
            this.txtHorasVoladas.Name = "txtHorasVoladas";
            this.txtHorasVoladas.PasswordChar = '\0';
            this.txtHorasVoladas.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtHorasVoladas.SelectedText = "";
            this.txtHorasVoladas.SelectionLength = 0;
            this.txtHorasVoladas.SelectionStart = 0;
            this.txtHorasVoladas.ShortcutsEnabled = true;
            this.txtHorasVoladas.Size = new System.Drawing.Size(134, 28);
            this.txtHorasVoladas.Style = MetroFramework.MetroColorStyle.Orange;
            this.txtHorasVoladas.TabIndex = 3;
            this.txtHorasVoladas.UseSelectable = true;
            this.txtHorasVoladas.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txtHorasVoladas.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // metroLabel3
            // 
            this.metroLabel3.AutoSize = true;
            this.metroLabel3.Location = new System.Drawing.Point(15, 40);
            this.metroLabel3.Name = "metroLabel3";
            this.metroLabel3.Size = new System.Drawing.Size(99, 20);
            this.metroLabel3.TabIndex = 2;
            this.metroLabel3.Text = "Horas Voladas:";
            // 
            // Form_EliminarAeronave
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(779, 647);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnDesactivar);
            this.Controls.Add(this.groupBox4);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Form_EliminarAeronave";
            this.Text = "Form_EliminarAeronave";
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private MetroFramework.Controls.MetroButton btnDesactivar;
        private System.Windows.Forms.GroupBox groupBox4;
        private MetroFramework.Controls.MetroButton btnBuscar;
        private MetroFramework.Controls.MetroLabel metroLabel4;
        private MetroFramework.Controls.MetroTextBox txtMatricula;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox2;
        private MetroFramework.Controls.MetroTextBox txtAnioFab;
        private MetroFramework.Controls.MetroLabel metroLabel5;
        private MetroFramework.Controls.MetroDateTime txtFechaInspeccion;
        private MetroFramework.Controls.MetroLabel metroLabel1;
        private MetroFramework.Controls.MetroTextBox txtHorasVoladas;
        private MetroFramework.Controls.MetroLabel metroLabel3;
    }
}
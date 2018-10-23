namespace CapaPresentacion
{
    partial class Form_CompletarVuelo
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.btnCompletar = new MetroFramework.Controls.MetroButton();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.lblAtras = new System.Windows.Forms.LinkLabel();
            this.btnBuscar = new MetroFramework.Controls.MetroButton();
            this.txtNumero = new MetroFramework.Controls.MetroTextBox();
            this.metroLabel5 = new MetroFramework.Controls.MetroLabel();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.txtHoras = new MetroFramework.Controls.MetroTextBox();
            this.metroLabel1 = new MetroFramework.Controls.MetroLabel();
            this.panel1.SuspendLayout();
            this.groupBox4.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.White;
            this.panel1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Location = new System.Drawing.Point(116, 358);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(511, 156);
            this.panel1.TabIndex = 81;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Franklin Gothic Medium Cond", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.Black;
            this.label3.Location = new System.Drawing.Point(28, 53);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(418, 63);
            this.label3.TabIndex = 4;
            this.label3.Text = "- Completar el vuelo implica que este ha logrado llegar a destino\r\n   de forma ex" +
    "itosa, por lo tanto una vez que realice esta opción, \r\n   el vuelo no se puede v" +
    "olver a poner en curso.";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Impact", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.DarkOrange;
            this.label2.Location = new System.Drawing.Point(9, 13);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(105, 29);
            this.label2.TabIndex = 3;
            this.label2.Text = "Atención:";
            // 
            // btnCompletar
            // 
            this.btnCompletar.DisplayFocus = true;
            this.btnCompletar.FontSize = MetroFramework.MetroButtonSize.Medium;
            this.btnCompletar.Location = new System.Drawing.Point(114, 542);
            this.btnCompletar.Name = "btnCompletar";
            this.btnCompletar.Size = new System.Drawing.Size(119, 41);
            this.btnCompletar.Style = MetroFramework.MetroColorStyle.Orange;
            this.btnCompletar.TabIndex = 80;
            this.btnCompletar.Text = "Completar";
            this.btnCompletar.Theme = MetroFramework.MetroThemeStyle.Light;
            this.btnCompletar.UseCustomBackColor = true;
            this.btnCompletar.UseCustomForeColor = true;
            this.btnCompletar.UseSelectable = true;
            this.btnCompletar.UseStyleColors = true;
            this.btnCompletar.Click += new System.EventHandler(this.btnCompletar_Click);
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.lblAtras);
            this.groupBox4.Controls.Add(this.btnBuscar);
            this.groupBox4.Controls.Add(this.txtNumero);
            this.groupBox4.Controls.Add(this.metroLabel5);
            this.groupBox4.Location = new System.Drawing.Point(118, 121);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(509, 106);
            this.groupBox4.TabIndex = 79;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Búsqueda de Vuelo";
            // 
            // lblAtras
            // 
            this.lblAtras.AutoSize = true;
            this.lblAtras.Location = new System.Drawing.Point(26, 76);
            this.lblAtras.Name = "lblAtras";
            this.lblAtras.Size = new System.Drawing.Size(89, 17);
            this.lblAtras.TabIndex = 78;
            this.lblAtras.TabStop = true;
            this.lblAtras.Text = "Volver Atrás.";
            this.lblAtras.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.lblAtras_LinkClicked);
            // 
            // btnBuscar
            // 
            this.btnBuscar.DisplayFocus = true;
            this.btnBuscar.FontSize = MetroFramework.MetroButtonSize.Medium;
            this.btnBuscar.Location = new System.Drawing.Point(384, 33);
            this.btnBuscar.Name = "btnBuscar";
            this.btnBuscar.Size = new System.Drawing.Size(103, 32);
            this.btnBuscar.Style = MetroFramework.MetroColorStyle.Orange;
            this.btnBuscar.TabIndex = 77;
            this.btnBuscar.Text = "Buscar";
            this.btnBuscar.Theme = MetroFramework.MetroThemeStyle.Light;
            this.btnBuscar.UseCustomBackColor = true;
            this.btnBuscar.UseCustomForeColor = true;
            this.btnBuscar.UseSelectable = true;
            this.btnBuscar.UseStyleColors = true;
            this.btnBuscar.Click += new System.EventHandler(this.btnBuscar_Click);
            // 
            // txtNumero
            // 
            this.txtNumero.BackColor = System.Drawing.Color.White;
            // 
            // 
            // 
            this.txtNumero.CustomButton.Image = null;
            this.txtNumero.CustomButton.Location = new System.Drawing.Point(69, 2);
            this.txtNumero.CustomButton.Name = "";
            this.txtNumero.CustomButton.Size = new System.Drawing.Size(27, 27);
            this.txtNumero.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txtNumero.CustomButton.TabIndex = 1;
            this.txtNumero.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txtNumero.CustomButton.UseSelectable = true;
            this.txtNumero.CustomButton.Visible = false;
            this.txtNumero.Lines = new string[0];
            this.txtNumero.Location = new System.Drawing.Point(250, 33);
            this.txtNumero.MaxLength = 32767;
            this.txtNumero.Name = "txtNumero";
            this.txtNumero.PasswordChar = '\0';
            this.txtNumero.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtNumero.SelectedText = "";
            this.txtNumero.SelectionLength = 0;
            this.txtNumero.SelectionStart = 0;
            this.txtNumero.ShortcutsEnabled = true;
            this.txtNumero.Size = new System.Drawing.Size(99, 32);
            this.txtNumero.Style = MetroFramework.MetroColorStyle.Orange;
            this.txtNumero.TabIndex = 52;
            this.txtNumero.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txtNumero.UseSelectable = true;
            this.txtNumero.UseStyleColors = true;
            this.txtNumero.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txtNumero.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            this.txtNumero.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtNumero_KeyPress);
            // 
            // metroLabel5
            // 
            this.metroLabel5.AutoSize = true;
            this.metroLabel5.Location = new System.Drawing.Point(13, 33);
            this.metroLabel5.Name = "metroLabel5";
            this.metroLabel5.Size = new System.Drawing.Size(123, 20);
            this.metroLabel5.TabIndex = 0;
            this.metroLabel5.Text = "Número de Vuelo:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(252, 64);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(259, 38);
            this.label1.TabIndex = 78;
            this.label1.Text = "Completar Vuelo";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.txtHoras);
            this.groupBox1.Controls.Add(this.metroLabel1);
            this.groupBox1.Location = new System.Drawing.Point(116, 248);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(395, 89);
            this.groupBox1.TabIndex = 80;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Horas de vuelo";
            // 
            // txtHoras
            // 
            this.txtHoras.BackColor = System.Drawing.Color.White;
            // 
            // 
            // 
            this.txtHoras.CustomButton.Image = null;
            this.txtHoras.CustomButton.Location = new System.Drawing.Point(69, 2);
            this.txtHoras.CustomButton.Name = "";
            this.txtHoras.CustomButton.Size = new System.Drawing.Size(27, 27);
            this.txtHoras.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txtHoras.CustomButton.TabIndex = 1;
            this.txtHoras.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txtHoras.CustomButton.UseSelectable = true;
            this.txtHoras.CustomButton.Visible = false;
            this.txtHoras.Lines = new string[0];
            this.txtHoras.Location = new System.Drawing.Point(252, 33);
            this.txtHoras.MaxLength = 32767;
            this.txtHoras.Name = "txtHoras";
            this.txtHoras.PasswordChar = '\0';
            this.txtHoras.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtHoras.SelectedText = "";
            this.txtHoras.SelectionLength = 0;
            this.txtHoras.SelectionStart = 0;
            this.txtHoras.ShortcutsEnabled = true;
            this.txtHoras.Size = new System.Drawing.Size(99, 32);
            this.txtHoras.Style = MetroFramework.MetroColorStyle.Orange;
            this.txtHoras.TabIndex = 52;
            this.txtHoras.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txtHoras.UseSelectable = true;
            this.txtHoras.UseStyleColors = true;
            this.txtHoras.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txtHoras.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            this.txtHoras.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtHoras_KeyPress);
            // 
            // metroLabel1
            // 
            this.metroLabel1.AutoSize = true;
            this.metroLabel1.Location = new System.Drawing.Point(15, 33);
            this.metroLabel1.Name = "metroLabel1";
            this.metroLabel1.Size = new System.Drawing.Size(171, 20);
            this.metroLabel1.TabIndex = 0;
            this.metroLabel1.Text = "Horas realizadas de vuelo:";
            // 
            // Form_CompletarVuelo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(754, 650);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.btnCompletar);
            this.Controls.Add(this.groupBox4);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Form_CompletarVuelo";
            this.Text = "Form_CompletarVuelo";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private MetroFramework.Controls.MetroButton btnCompletar;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.LinkLabel lblAtras;
        private MetroFramework.Controls.MetroButton btnBuscar;
        private MetroFramework.Controls.MetroTextBox txtNumero;
        private MetroFramework.Controls.MetroLabel metroLabel5;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox1;
        private MetroFramework.Controls.MetroTextBox txtHoras;
        private MetroFramework.Controls.MetroLabel metroLabel1;
    }
}
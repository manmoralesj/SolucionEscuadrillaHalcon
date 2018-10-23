namespace CapaPresentacion
{
    partial class Form_AgregarComponente
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
            this.label1 = new System.Windows.Forms.Label();
            this.metroLabel1 = new MetroFramework.Controls.MetroLabel();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.txtNombre = new MetroFramework.Controls.MetroTextBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.metroLabel2 = new MetroFramework.Controls.MetroLabel();
            this.chkHorasUso = new MetroFramework.Controls.MetroRadioButton();
            this.chkCantUso = new MetroFramework.Controls.MetroRadioButton();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.txtHorasUso = new MetroFramework.Controls.MetroTextBox();
            this.txtNumUsos = new MetroFramework.Controls.MetroTextBox();
            this.metroLabel4 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel3 = new MetroFramework.Controls.MetroLabel();
            this.btnAgregarComponente = new MetroFramework.Controls.MetroButton();
            this.groupBox5 = new System.Windows.Forms.GroupBox();
            this.cboComponentes = new MetroFramework.Controls.MetroComboBox();
            this.cOMPONENTESBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dataSetComponentes = new CapaPresentacion.DataSetComponentes();
            this.chkCompInternos = new MetroFramework.Controls.MetroCheckBox();
            this.metroLabel6 = new MetroFramework.Controls.MetroLabel();
            this.cOMPONENTESTableAdapter = new CapaPresentacion.DataSetComponentesTableAdapters.COMPONENTESTableAdapter();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.groupBox5.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.cOMPONENTESBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSetComponentes)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(166, 41);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(345, 38);
            this.label1.TabIndex = 65;
            this.label1.Text = "Registrar Componente";
            // 
            // metroLabel1
            // 
            this.metroLabel1.AutoSize = true;
            this.metroLabel1.Location = new System.Drawing.Point(32, 43);
            this.metroLabel1.Name = "metroLabel1";
            this.metroLabel1.Size = new System.Drawing.Size(64, 20);
            this.metroLabel1.TabIndex = 66;
            this.metroLabel1.Text = "Nombre:";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.txtNombre);
            this.groupBox1.Controls.Add(this.metroLabel1);
            this.groupBox1.Location = new System.Drawing.Point(100, 104);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(482, 88);
            this.groupBox1.TabIndex = 68;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Datos Componente";
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
            this.txtNombre.Location = new System.Drawing.Point(159, 34);
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
            this.txtNombre.TabIndex = 72;
            this.txtNombre.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txtNombre.UseSelectable = true;
            this.txtNombre.UseStyleColors = true;
            this.txtNombre.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txtNombre.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.metroLabel2);
            this.groupBox2.Controls.Add(this.chkHorasUso);
            this.groupBox2.Controls.Add(this.chkCantUso);
            this.groupBox2.Location = new System.Drawing.Point(100, 198);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(482, 81);
            this.groupBox2.TabIndex = 69;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Tipo de desgaste";
            // 
            // metroLabel2
            // 
            this.metroLabel2.AutoSize = true;
            this.metroLabel2.Location = new System.Drawing.Point(32, 40);
            this.metroLabel2.Name = "metroLabel2";
            this.metroLabel2.Size = new System.Drawing.Size(79, 20);
            this.metroLabel2.TabIndex = 2;
            this.metroLabel2.Text = "Seleccione:";
            // 
            // chkHorasUso
            // 
            this.chkHorasUso.AutoSize = true;
            this.chkHorasUso.Location = new System.Drawing.Point(321, 40);
            this.chkHorasUso.Name = "chkHorasUso";
            this.chkHorasUso.Size = new System.Drawing.Size(103, 17);
            this.chkHorasUso.Style = MetroFramework.MetroColorStyle.Orange;
            this.chkHorasUso.TabIndex = 1;
            this.chkHorasUso.Text = "Horas de uso";
            this.chkHorasUso.UseSelectable = true;
            this.chkHorasUso.CheckedChanged += new System.EventHandler(this.chkHorasUso_CheckedChanged);
            // 
            // chkCantUso
            // 
            this.chkCantUso.AutoSize = true;
            this.chkCantUso.Location = new System.Drawing.Point(159, 40);
            this.chkCantUso.Name = "chkCantUso";
            this.chkCantUso.Size = new System.Drawing.Size(120, 17);
            this.chkCantUso.Style = MetroFramework.MetroColorStyle.Orange;
            this.chkCantUso.TabIndex = 0;
            this.chkCantUso.Text = "Cantidad de uso";
            this.chkCantUso.UseSelectable = true;
            this.chkCantUso.CheckedChanged += new System.EventHandler(this.chkCantUso_CheckedChanged);
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.txtHorasUso);
            this.groupBox3.Controls.Add(this.txtNumUsos);
            this.groupBox3.Controls.Add(this.metroLabel4);
            this.groupBox3.Controls.Add(this.metroLabel3);
            this.groupBox3.Location = new System.Drawing.Point(100, 285);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(482, 126);
            this.groupBox3.TabIndex = 70;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Datos Desgaste";
            // 
            // txtHorasUso
            // 
            this.txtHorasUso.BackColor = System.Drawing.Color.White;
            // 
            // 
            // 
            this.txtHorasUso.CustomButton.Image = null;
            this.txtHorasUso.CustomButton.Location = new System.Drawing.Point(44, 1);
            this.txtHorasUso.CustomButton.Name = "";
            this.txtHorasUso.CustomButton.Size = new System.Drawing.Size(27, 27);
            this.txtHorasUso.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txtHorasUso.CustomButton.TabIndex = 1;
            this.txtHorasUso.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txtHorasUso.CustomButton.UseSelectable = true;
            this.txtHorasUso.CustomButton.Visible = false;
            this.txtHorasUso.Lines = new string[0];
            this.txtHorasUso.Location = new System.Drawing.Point(254, 78);
            this.txtHorasUso.MaxLength = 32767;
            this.txtHorasUso.Name = "txtHorasUso";
            this.txtHorasUso.PasswordChar = '\0';
            this.txtHorasUso.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtHorasUso.SelectedText = "";
            this.txtHorasUso.SelectionLength = 0;
            this.txtHorasUso.SelectionStart = 0;
            this.txtHorasUso.ShortcutsEnabled = true;
            this.txtHorasUso.Size = new System.Drawing.Size(72, 29);
            this.txtHorasUso.Style = MetroFramework.MetroColorStyle.Orange;
            this.txtHorasUso.TabIndex = 74;
            this.txtHorasUso.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txtHorasUso.UseSelectable = true;
            this.txtHorasUso.UseStyleColors = true;
            this.txtHorasUso.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txtHorasUso.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            this.txtHorasUso.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtHorasUso_KeyPress);
            // 
            // txtNumUsos
            // 
            this.txtNumUsos.BackColor = System.Drawing.Color.White;
            // 
            // 
            // 
            this.txtNumUsos.CustomButton.Image = null;
            this.txtNumUsos.CustomButton.Location = new System.Drawing.Point(44, 1);
            this.txtNumUsos.CustomButton.Name = "";
            this.txtNumUsos.CustomButton.Size = new System.Drawing.Size(27, 27);
            this.txtNumUsos.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txtNumUsos.CustomButton.TabIndex = 1;
            this.txtNumUsos.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txtNumUsos.CustomButton.UseSelectable = true;
            this.txtNumUsos.CustomButton.Visible = false;
            this.txtNumUsos.Lines = new string[0];
            this.txtNumUsos.Location = new System.Drawing.Point(254, 29);
            this.txtNumUsos.MaxLength = 32767;
            this.txtNumUsos.Name = "txtNumUsos";
            this.txtNumUsos.PasswordChar = '\0';
            this.txtNumUsos.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtNumUsos.SelectedText = "";
            this.txtNumUsos.SelectionLength = 0;
            this.txtNumUsos.SelectionStart = 0;
            this.txtNumUsos.ShortcutsEnabled = true;
            this.txtNumUsos.Size = new System.Drawing.Size(72, 29);
            this.txtNumUsos.Style = MetroFramework.MetroColorStyle.Orange;
            this.txtNumUsos.TabIndex = 73;
            this.txtNumUsos.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txtNumUsos.UseSelectable = true;
            this.txtNumUsos.UseStyleColors = true;
            this.txtNumUsos.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txtNumUsos.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            this.txtNumUsos.Click += new System.EventHandler(this.txtNumUsos_Click);
            this.txtNumUsos.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtNumUsos_KeyPress);
            // 
            // metroLabel4
            // 
            this.metroLabel4.AutoSize = true;
            this.metroLabel4.Location = new System.Drawing.Point(32, 78);
            this.metroLabel4.Name = "metroLabel4";
            this.metroLabel4.Size = new System.Drawing.Size(151, 20);
            this.metroLabel4.TabIndex = 2;
            this.metroLabel4.Text = "Horas Máximas de uso:";
            // 
            // metroLabel3
            // 
            this.metroLabel3.AutoSize = true;
            this.metroLabel3.Location = new System.Drawing.Point(32, 38);
            this.metroLabel3.Name = "metroLabel3";
            this.metroLabel3.Size = new System.Drawing.Size(168, 20);
            this.metroLabel3.TabIndex = 0;
            this.metroLabel3.Text = "Número de usos Maximo:";
            // 
            // btnAgregarComponente
            // 
            this.btnAgregarComponente.Location = new System.Drawing.Point(100, 585);
            this.btnAgregarComponente.Name = "btnAgregarComponente";
            this.btnAgregarComponente.Size = new System.Drawing.Size(119, 34);
            this.btnAgregarComponente.TabIndex = 71;
            this.btnAgregarComponente.Text = "Registrar";
            this.btnAgregarComponente.UseSelectable = true;
            this.btnAgregarComponente.Click += new System.EventHandler(this.metroButton1_Click);
            // 
            // groupBox5
            // 
            this.groupBox5.Controls.Add(this.cboComponentes);
            this.groupBox5.Controls.Add(this.chkCompInternos);
            this.groupBox5.Controls.Add(this.metroLabel6);
            this.groupBox5.Location = new System.Drawing.Point(100, 417);
            this.groupBox5.Name = "groupBox5";
            this.groupBox5.Size = new System.Drawing.Size(482, 143);
            this.groupBox5.TabIndex = 72;
            this.groupBox5.TabStop = false;
            this.groupBox5.Text = "Componentes internos";
            // 
            // cboComponentes
            // 
            this.cboComponentes.DataSource = this.cOMPONENTESBindingSource;
            this.cboComponentes.DisplayMember = "NOMBRE";
            this.cboComponentes.FormattingEnabled = true;
            this.cboComponentes.ItemHeight = 24;
            this.cboComponentes.Location = new System.Drawing.Point(159, 93);
            this.cboComponentes.Name = "cboComponentes";
            this.cboComponentes.Size = new System.Drawing.Size(157, 30);
            this.cboComponentes.Style = MetroFramework.MetroColorStyle.Orange;
            this.cboComponentes.TabIndex = 74;
            this.cboComponentes.UseSelectable = true;
            this.cboComponentes.ValueMember = "IDCOMPONENTE";
            // 
            // cOMPONENTESBindingSource
            // 
            this.cOMPONENTESBindingSource.DataMember = "COMPONENTES";
            this.cOMPONENTESBindingSource.DataSource = this.dataSetComponentes;
            // 
            // dataSetComponentes
            // 
            this.dataSetComponentes.DataSetName = "DataSetComponentes";
            this.dataSetComponentes.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // chkCompInternos
            // 
            this.chkCompInternos.AutoSize = true;
            this.chkCompInternos.Location = new System.Drawing.Point(32, 42);
            this.chkCompInternos.Name = "chkCompInternos";
            this.chkCompInternos.Size = new System.Drawing.Size(209, 17);
            this.chkCompInternos.Style = MetroFramework.MetroColorStyle.Orange;
            this.chkCompInternos.TabIndex = 73;
            this.chkCompInternos.Text = "Contiene componentes internos";
            this.chkCompInternos.UseSelectable = true;
            this.chkCompInternos.CheckedChanged += new System.EventHandler(this.chkCompInternos_CheckedChanged);
            // 
            // metroLabel6
            // 
            this.metroLabel6.AutoSize = true;
            this.metroLabel6.Location = new System.Drawing.Point(32, 99);
            this.metroLabel6.Name = "metroLabel6";
            this.metroLabel6.Size = new System.Drawing.Size(64, 20);
            this.metroLabel6.TabIndex = 66;
            this.metroLabel6.Text = "Nombre:";
            // 
            // cOMPONENTESTableAdapter
            // 
            this.cOMPONENTESTableAdapter.ClearBeforeFill = true;
            // 
            // Form_AgregarComponente
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(676, 661);
            this.Controls.Add(this.groupBox5);
            this.Controls.Add(this.btnAgregarComponente);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Form_AgregarComponente";
            this.Text = "Form_AgregarComponente";
            this.Load += new System.EventHandler(this.Form_AgregarComponente_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.groupBox5.ResumeLayout(false);
            this.groupBox5.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.cOMPONENTESBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSetComponentes)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private MetroFramework.Controls.MetroLabel metroLabel1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private MetroFramework.Controls.MetroLabel metroLabel2;
        private MetroFramework.Controls.MetroRadioButton chkHorasUso;
        private MetroFramework.Controls.MetroRadioButton chkCantUso;
        private System.Windows.Forms.GroupBox groupBox3;
        private MetroFramework.Controls.MetroLabel metroLabel4;
        private MetroFramework.Controls.MetroLabel metroLabel3;
        private MetroFramework.Controls.MetroButton btnAgregarComponente;
        private MetroFramework.Controls.MetroTextBox txtNombre;
        private MetroFramework.Controls.MetroTextBox txtHorasUso;
        private MetroFramework.Controls.MetroTextBox txtNumUsos;
        private System.Windows.Forms.GroupBox groupBox5;
        private MetroFramework.Controls.MetroComboBox cboComponentes;
        private MetroFramework.Controls.MetroCheckBox chkCompInternos;
        private MetroFramework.Controls.MetroLabel metroLabel6;
        private DataSetComponentes dataSetComponentes;
        private System.Windows.Forms.BindingSource cOMPONENTESBindingSource;
        private DataSetComponentesTableAdapters.COMPONENTESTableAdapter cOMPONENTESTableAdapter;
    }
}
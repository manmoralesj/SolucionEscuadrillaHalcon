namespace CapaPresentacion
{
    partial class Form_ModificarComponente
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
            this.txtNumMaxUsos = new MetroFramework.Controls.MetroTextBox();
            this.metroButton1 = new MetroFramework.Controls.MetroButton();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.txtHorasMaxUsos = new MetroFramework.Controls.MetroTextBox();
            this.metroLabel4 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel3 = new MetroFramework.Controls.MetroLabel();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.metroLabel2 = new MetroFramework.Controls.MetroLabel();
            this.chkHorasUso = new MetroFramework.Controls.MetroRadioButton();
            this.chkCantUso = new MetroFramework.Controls.MetroRadioButton();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.cboComponentes = new MetroFramework.Controls.MetroComboBox();
            this.cOMPONENTESBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.dataSetComponentes = new CapaPresentacion.DataSetComponentes();
            this.btnBuscar = new MetroFramework.Controls.MetroButton();
            this.metroLabel1 = new MetroFramework.Controls.MetroLabel();
            this.cOMPONENTESBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.txtHorasUso = new MetroFramework.Controls.MetroTextBox();
            this.txtNumUsos = new MetroFramework.Controls.MetroTextBox();
            this.metroLabel5 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel6 = new MetroFramework.Controls.MetroLabel();
            this.cOMPONENTESTableAdapter = new CapaPresentacion.DataSetComponentesTableAdapters.COMPONENTESTableAdapter();
            this.groupBox5 = new System.Windows.Forms.GroupBox();
            this.cboCompInternos = new MetroFramework.Controls.MetroComboBox();
            this.chkCompInternos = new MetroFramework.Controls.MetroCheckBox();
            this.metroLabel7 = new MetroFramework.Controls.MetroLabel();
            this.groupBox3.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.cOMPONENTESBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSetComponentes)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cOMPONENTESBindingSource)).BeginInit();
            this.groupBox4.SuspendLayout();
            this.groupBox5.SuspendLayout();
            this.SuspendLayout();
            // 
            // txtNumMaxUsos
            // 
            this.txtNumMaxUsos.BackColor = System.Drawing.Color.White;
            // 
            // 
            // 
            this.txtNumMaxUsos.CustomButton.Image = null;
            this.txtNumMaxUsos.CustomButton.Location = new System.Drawing.Point(15, 1);
            this.txtNumMaxUsos.CustomButton.Name = "";
            this.txtNumMaxUsos.CustomButton.Size = new System.Drawing.Size(27, 27);
            this.txtNumMaxUsos.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txtNumMaxUsos.CustomButton.TabIndex = 1;
            this.txtNumMaxUsos.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txtNumMaxUsos.CustomButton.UseSelectable = true;
            this.txtNumMaxUsos.CustomButton.Visible = false;
            this.txtNumMaxUsos.Lines = new string[0];
            this.txtNumMaxUsos.Location = new System.Drawing.Point(201, 29);
            this.txtNumMaxUsos.MaxLength = 32767;
            this.txtNumMaxUsos.Name = "txtNumMaxUsos";
            this.txtNumMaxUsos.PasswordChar = '\0';
            this.txtNumMaxUsos.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtNumMaxUsos.SelectedText = "";
            this.txtNumMaxUsos.SelectionLength = 0;
            this.txtNumMaxUsos.SelectionStart = 0;
            this.txtNumMaxUsos.ShortcutsEnabled = true;
            this.txtNumMaxUsos.Size = new System.Drawing.Size(43, 29);
            this.txtNumMaxUsos.Style = MetroFramework.MetroColorStyle.Orange;
            this.txtNumMaxUsos.TabIndex = 73;
            this.txtNumMaxUsos.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txtNumMaxUsos.UseSelectable = true;
            this.txtNumMaxUsos.UseStyleColors = true;
            this.txtNumMaxUsos.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txtNumMaxUsos.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            this.txtNumMaxUsos.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtNumMaxUsos_KeyPress);
            // 
            // metroButton1
            // 
            this.metroButton1.Location = new System.Drawing.Point(84, 597);
            this.metroButton1.Name = "metroButton1";
            this.metroButton1.Size = new System.Drawing.Size(119, 34);
            this.metroButton1.TabIndex = 76;
            this.metroButton1.Text = "Modificar";
            this.metroButton1.UseSelectable = true;
            this.metroButton1.Click += new System.EventHandler(this.metroButton1_Click);
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.txtHorasMaxUsos);
            this.groupBox3.Controls.Add(this.txtNumMaxUsos);
            this.groupBox3.Controls.Add(this.metroLabel4);
            this.groupBox3.Controls.Add(this.metroLabel3);
            this.groupBox3.Location = new System.Drawing.Point(84, 285);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(262, 126);
            this.groupBox3.TabIndex = 75;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Datos Desgaste";
            // 
            // txtHorasMaxUsos
            // 
            this.txtHorasMaxUsos.BackColor = System.Drawing.Color.White;
            // 
            // 
            // 
            this.txtHorasMaxUsos.CustomButton.Image = null;
            this.txtHorasMaxUsos.CustomButton.Location = new System.Drawing.Point(15, 1);
            this.txtHorasMaxUsos.CustomButton.Name = "";
            this.txtHorasMaxUsos.CustomButton.Size = new System.Drawing.Size(27, 27);
            this.txtHorasMaxUsos.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txtHorasMaxUsos.CustomButton.TabIndex = 1;
            this.txtHorasMaxUsos.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txtHorasMaxUsos.CustomButton.UseSelectable = true;
            this.txtHorasMaxUsos.CustomButton.Visible = false;
            this.txtHorasMaxUsos.Lines = new string[0];
            this.txtHorasMaxUsos.Location = new System.Drawing.Point(201, 78);
            this.txtHorasMaxUsos.MaxLength = 32767;
            this.txtHorasMaxUsos.Name = "txtHorasMaxUsos";
            this.txtHorasMaxUsos.PasswordChar = '\0';
            this.txtHorasMaxUsos.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtHorasMaxUsos.SelectedText = "";
            this.txtHorasMaxUsos.SelectionLength = 0;
            this.txtHorasMaxUsos.SelectionStart = 0;
            this.txtHorasMaxUsos.ShortcutsEnabled = true;
            this.txtHorasMaxUsos.Size = new System.Drawing.Size(43, 29);
            this.txtHorasMaxUsos.Style = MetroFramework.MetroColorStyle.Orange;
            this.txtHorasMaxUsos.TabIndex = 74;
            this.txtHorasMaxUsos.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txtHorasMaxUsos.UseSelectable = true;
            this.txtHorasMaxUsos.UseStyleColors = true;
            this.txtHorasMaxUsos.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txtHorasMaxUsos.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            this.txtHorasMaxUsos.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtHorasMaxUsos_KeyPress);
            // 
            // metroLabel4
            // 
            this.metroLabel4.AutoSize = true;
            this.metroLabel4.Location = new System.Drawing.Point(15, 78);
            this.metroLabel4.Name = "metroLabel4";
            this.metroLabel4.Size = new System.Drawing.Size(151, 20);
            this.metroLabel4.TabIndex = 2;
            this.metroLabel4.Text = "Horas Máximas de uso:";
            // 
            // metroLabel3
            // 
            this.metroLabel3.AutoSize = true;
            this.metroLabel3.Location = new System.Drawing.Point(15, 38);
            this.metroLabel3.Name = "metroLabel3";
            this.metroLabel3.Size = new System.Drawing.Size(168, 20);
            this.metroLabel3.TabIndex = 0;
            this.metroLabel3.Text = "Número de usos Maximo:";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.metroLabel2);
            this.groupBox2.Controls.Add(this.chkHorasUso);
            this.groupBox2.Controls.Add(this.chkCantUso);
            this.groupBox2.Location = new System.Drawing.Point(84, 189);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(497, 81);
            this.groupBox2.TabIndex = 74;
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
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.cboComponentes);
            this.groupBox1.Controls.Add(this.btnBuscar);
            this.groupBox1.Controls.Add(this.metroLabel1);
            this.groupBox1.Location = new System.Drawing.Point(84, 85);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(497, 88);
            this.groupBox1.TabIndex = 73;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Datos Componente";
            // 
            // cboComponentes
            // 
            this.cboComponentes.DataSource = this.cOMPONENTESBindingSource1;
            this.cboComponentes.DisplayMember = "NOMBRE";
            this.cboComponentes.FormattingEnabled = true;
            this.cboComponentes.ItemHeight = 24;
            this.cboComponentes.Location = new System.Drawing.Point(159, 34);
            this.cboComponentes.Name = "cboComponentes";
            this.cboComponentes.Size = new System.Drawing.Size(157, 30);
            this.cboComponentes.Style = MetroFramework.MetroColorStyle.Orange;
            this.cboComponentes.TabIndex = 76;
            this.cboComponentes.UseSelectable = true;
            this.cboComponentes.ValueMember = "IDCOMPONENTE";
            // 
            // cOMPONENTESBindingSource1
            // 
            this.cOMPONENTESBindingSource1.DataMember = "COMPONENTES";
            this.cOMPONENTESBindingSource1.DataSource = this.dataSetComponentes;
            // 
            // dataSetComponentes
            // 
            this.dataSetComponentes.DataSetName = "DataSetComponentes";
            this.dataSetComponentes.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // btnBuscar
            // 
            this.btnBuscar.Location = new System.Drawing.Point(342, 34);
            this.btnBuscar.Name = "btnBuscar";
            this.btnBuscar.Size = new System.Drawing.Size(111, 29);
            this.btnBuscar.TabIndex = 73;
            this.btnBuscar.Text = "Buscar";
            this.btnBuscar.UseSelectable = true;
            this.btnBuscar.Click += new System.EventHandler(this.metroButton2_Click);
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
            // cOMPONENTESBindingSource
            // 
            this.cOMPONENTESBindingSource.DataMember = "COMPONENTES";
            this.cOMPONENTESBindingSource.DataSource = this.dataSetComponentes;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(151, 26);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(344, 38);
            this.label1.TabIndex = 72;
            this.label1.Text = "Modificar Componente";
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.txtHorasUso);
            this.groupBox4.Controls.Add(this.txtNumUsos);
            this.groupBox4.Controls.Add(this.metroLabel5);
            this.groupBox4.Controls.Add(this.metroLabel6);
            this.groupBox4.Location = new System.Drawing.Point(361, 285);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(220, 126);
            this.groupBox4.TabIndex = 76;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Desgaste Actual";
            // 
            // txtHorasUso
            // 
            this.txtHorasUso.BackColor = System.Drawing.Color.White;
            // 
            // 
            // 
            this.txtHorasUso.CustomButton.Image = null;
            this.txtHorasUso.CustomButton.Location = new System.Drawing.Point(15, 1);
            this.txtHorasUso.CustomButton.Name = "";
            this.txtHorasUso.CustomButton.Size = new System.Drawing.Size(27, 27);
            this.txtHorasUso.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txtHorasUso.CustomButton.TabIndex = 1;
            this.txtHorasUso.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txtHorasUso.CustomButton.UseSelectable = true;
            this.txtHorasUso.CustomButton.Visible = false;
            this.txtHorasUso.Lines = new string[0];
            this.txtHorasUso.Location = new System.Drawing.Point(150, 78);
            this.txtHorasUso.MaxLength = 32767;
            this.txtHorasUso.Name = "txtHorasUso";
            this.txtHorasUso.PasswordChar = '\0';
            this.txtHorasUso.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtHorasUso.SelectedText = "";
            this.txtHorasUso.SelectionLength = 0;
            this.txtHorasUso.SelectionStart = 0;
            this.txtHorasUso.ShortcutsEnabled = true;
            this.txtHorasUso.Size = new System.Drawing.Size(43, 29);
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
            this.txtNumUsos.CustomButton.Location = new System.Drawing.Point(15, 1);
            this.txtNumUsos.CustomButton.Name = "";
            this.txtNumUsos.CustomButton.Size = new System.Drawing.Size(27, 27);
            this.txtNumUsos.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txtNumUsos.CustomButton.TabIndex = 1;
            this.txtNumUsos.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txtNumUsos.CustomButton.UseSelectable = true;
            this.txtNumUsos.CustomButton.Visible = false;
            this.txtNumUsos.Lines = new string[0];
            this.txtNumUsos.Location = new System.Drawing.Point(150, 29);
            this.txtNumUsos.MaxLength = 32767;
            this.txtNumUsos.Name = "txtNumUsos";
            this.txtNumUsos.PasswordChar = '\0';
            this.txtNumUsos.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtNumUsos.SelectedText = "";
            this.txtNumUsos.SelectionLength = 0;
            this.txtNumUsos.SelectionStart = 0;
            this.txtNumUsos.ShortcutsEnabled = true;
            this.txtNumUsos.Size = new System.Drawing.Size(43, 29);
            this.txtNumUsos.Style = MetroFramework.MetroColorStyle.Orange;
            this.txtNumUsos.TabIndex = 73;
            this.txtNumUsos.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txtNumUsos.UseSelectable = true;
            this.txtNumUsos.UseStyleColors = true;
            this.txtNumUsos.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txtNumUsos.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            this.txtNumUsos.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtNumUsos_KeyPress);
            // 
            // metroLabel5
            // 
            this.metroLabel5.AutoSize = true;
            this.metroLabel5.Location = new System.Drawing.Point(22, 78);
            this.metroLabel5.Name = "metroLabel5";
            this.metroLabel5.Size = new System.Drawing.Size(94, 20);
            this.metroLabel5.TabIndex = 2;
            this.metroLabel5.Text = "Horas de uso:";
            // 
            // metroLabel6
            // 
            this.metroLabel6.AutoSize = true;
            this.metroLabel6.Location = new System.Drawing.Point(22, 38);
            this.metroLabel6.Name = "metroLabel6";
            this.metroLabel6.Size = new System.Drawing.Size(110, 20);
            this.metroLabel6.TabIndex = 0;
            this.metroLabel6.Text = "Número de uso:";
            // 
            // cOMPONENTESTableAdapter
            // 
            this.cOMPONENTESTableAdapter.ClearBeforeFill = true;
            // 
            // groupBox5
            // 
            this.groupBox5.Controls.Add(this.cboCompInternos);
            this.groupBox5.Controls.Add(this.chkCompInternos);
            this.groupBox5.Controls.Add(this.metroLabel7);
            this.groupBox5.Location = new System.Drawing.Point(84, 431);
            this.groupBox5.Name = "groupBox5";
            this.groupBox5.Size = new System.Drawing.Size(482, 143);
            this.groupBox5.TabIndex = 77;
            this.groupBox5.TabStop = false;
            this.groupBox5.Text = "Componentes internos";
            // 
            // cboCompInternos
            // 
            this.cboCompInternos.DataSource = this.cOMPONENTESBindingSource;
            this.cboCompInternos.DisplayMember = "NOMBRE";
            this.cboCompInternos.FormattingEnabled = true;
            this.cboCompInternos.ItemHeight = 24;
            this.cboCompInternos.Location = new System.Drawing.Point(159, 93);
            this.cboCompInternos.Name = "cboCompInternos";
            this.cboCompInternos.Size = new System.Drawing.Size(157, 30);
            this.cboCompInternos.Style = MetroFramework.MetroColorStyle.Orange;
            this.cboCompInternos.TabIndex = 74;
            this.cboCompInternos.UseSelectable = true;
            this.cboCompInternos.ValueMember = "IDCOMPONENTE";
            this.cboCompInternos.SelectedIndexChanged += new System.EventHandler(this.cboCompInternos_SelectedIndexChanged);
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
            // metroLabel7
            // 
            this.metroLabel7.AutoSize = true;
            this.metroLabel7.Location = new System.Drawing.Point(32, 99);
            this.metroLabel7.Name = "metroLabel7";
            this.metroLabel7.Size = new System.Drawing.Size(64, 20);
            this.metroLabel7.TabIndex = 66;
            this.metroLabel7.Text = "Nombre:";
            // 
            // Form_ModificarComponente
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(676, 661);
            this.Controls.Add(this.groupBox5);
            this.Controls.Add(this.groupBox4);
            this.Controls.Add(this.metroButton1);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Form_ModificarComponente";
            this.Text = "Form_ModificarComponente";
            this.Load += new System.EventHandler(this.Form_ModificarComponente_Load);
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.cOMPONENTESBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSetComponentes)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cOMPONENTESBindingSource)).EndInit();
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            this.groupBox5.ResumeLayout(false);
            this.groupBox5.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private MetroFramework.Controls.MetroTextBox txtNumMaxUsos;
        private MetroFramework.Controls.MetroButton metroButton1;
        private System.Windows.Forms.GroupBox groupBox3;
        private MetroFramework.Controls.MetroTextBox txtHorasMaxUsos;
        private MetroFramework.Controls.MetroLabel metroLabel4;
        private MetroFramework.Controls.MetroLabel metroLabel3;
        private System.Windows.Forms.GroupBox groupBox2;
        private MetroFramework.Controls.MetroLabel metroLabel2;
        private MetroFramework.Controls.MetroRadioButton chkHorasUso;
        private MetroFramework.Controls.MetroRadioButton chkCantUso;
        private System.Windows.Forms.GroupBox groupBox1;
        private MetroFramework.Controls.MetroLabel metroLabel1;
        private System.Windows.Forms.Label label1;
        private MetroFramework.Controls.MetroButton btnBuscar;
        private System.Windows.Forms.GroupBox groupBox4;
        private MetroFramework.Controls.MetroTextBox txtHorasUso;
        private MetroFramework.Controls.MetroTextBox txtNumUsos;
        private MetroFramework.Controls.MetroLabel metroLabel5;
        private MetroFramework.Controls.MetroLabel metroLabel6;
        private MetroFramework.Controls.MetroComboBox cboComponentes;
        private DataSetComponentes dataSetComponentes;
        private System.Windows.Forms.BindingSource cOMPONENTESBindingSource;
        private DataSetComponentesTableAdapters.COMPONENTESTableAdapter cOMPONENTESTableAdapter;
        private System.Windows.Forms.GroupBox groupBox5;
        private MetroFramework.Controls.MetroComboBox cboCompInternos;
        private MetroFramework.Controls.MetroCheckBox chkCompInternos;
        private MetroFramework.Controls.MetroLabel metroLabel7;
        private System.Windows.Forms.BindingSource cOMPONENTESBindingSource1;
    }
}
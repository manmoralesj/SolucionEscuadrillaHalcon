namespace CapaPresentacion
{
    partial class Form_ModificarMantenimiento
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
            this.btnModificar = new MetroFramework.Controls.MetroButton();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.txtObs = new MetroFramework.Controls.MetroTextBox();
            this.metroLabel4 = new MetroFramework.Controls.MetroLabel();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.cboComponente = new MetroFramework.Controls.MetroComboBox();
            this.cOMPONENTESBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dataSetComponentes = new CapaPresentacion.DataSetComponentes();
            this.metroLabel3 = new MetroFramework.Controls.MetroLabel();
            this.cboMatAeronave = new MetroFramework.Controls.MetroComboBox();
            this.aERONAVESBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dataSetAeronaves = new CapaPresentacion.DataSetAeronaves();
            this.metroLabel2 = new MetroFramework.Controls.MetroLabel();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.chkComponente = new MetroFramework.Controls.MetroRadioButton();
            this.chkAeronave = new MetroFramework.Controls.MetroRadioButton();
            this.metroLabel1 = new MetroFramework.Controls.MetroLabel();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.btnBuscar = new MetroFramework.Controls.MetroButton();
            this.txtNum = new MetroFramework.Controls.MetroTextBox();
            this.metroLabel5 = new MetroFramework.Controls.MetroLabel();
            this.aERONAVESTableAdapter = new CapaPresentacion.DataSetAeronavesTableAdapters.AERONAVESTableAdapter();
            this.cOMPONENTESTableAdapter = new CapaPresentacion.DataSetComponentesTableAdapters.COMPONENTESTableAdapter();
            this.groupBox3.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.cOMPONENTESBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSetComponentes)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.aERONAVESBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSetAeronaves)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.groupBox4.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnModificar
            // 
            this.btnModificar.Location = new System.Drawing.Point(118, 555);
            this.btnModificar.Name = "btnModificar";
            this.btnModificar.Size = new System.Drawing.Size(108, 41);
            this.btnModificar.TabIndex = 73;
            this.btnModificar.Text = "Modificar";
            this.btnModificar.UseSelectable = true;
            this.btnModificar.Click += new System.EventHandler(this.metroButton1_Click);
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.txtObs);
            this.groupBox3.Controls.Add(this.metroLabel4);
            this.groupBox3.Location = new System.Drawing.Point(118, 421);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(509, 116);
            this.groupBox3.TabIndex = 72;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Selección Mantenimiento";
            // 
            // txtObs
            // 
            this.txtObs.BackColor = System.Drawing.Color.White;
            // 
            // 
            // 
            this.txtObs.CustomButton.Image = null;
            this.txtObs.CustomButton.Location = new System.Drawing.Point(113, 2);
            this.txtObs.CustomButton.Name = "";
            this.txtObs.CustomButton.Size = new System.Drawing.Size(71, 71);
            this.txtObs.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txtObs.CustomButton.TabIndex = 1;
            this.txtObs.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txtObs.CustomButton.UseSelectable = true;
            this.txtObs.CustomButton.Visible = false;
            this.txtObs.Lines = new string[0];
            this.txtObs.Location = new System.Drawing.Point(293, 21);
            this.txtObs.MaxLength = 32767;
            this.txtObs.Multiline = true;
            this.txtObs.Name = "txtObs";
            this.txtObs.PasswordChar = '\0';
            this.txtObs.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtObs.SelectedText = "";
            this.txtObs.SelectionLength = 0;
            this.txtObs.SelectionStart = 0;
            this.txtObs.ShortcutsEnabled = true;
            this.txtObs.Size = new System.Drawing.Size(187, 76);
            this.txtObs.Style = MetroFramework.MetroColorStyle.Orange;
            this.txtObs.TabIndex = 51;
            this.txtObs.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txtObs.UseSelectable = true;
            this.txtObs.UseStyleColors = true;
            this.txtObs.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txtObs.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // metroLabel4
            // 
            this.metroLabel4.AutoSize = true;
            this.metroLabel4.Location = new System.Drawing.Point(17, 43);
            this.metroLabel4.Name = "metroLabel4";
            this.metroLabel4.Size = new System.Drawing.Size(91, 20);
            this.metroLabel4.TabIndex = 0;
            this.metroLabel4.Text = "Observación:";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.cboComponente);
            this.groupBox2.Controls.Add(this.metroLabel3);
            this.groupBox2.Controls.Add(this.cboMatAeronave);
            this.groupBox2.Controls.Add(this.metroLabel2);
            this.groupBox2.Location = new System.Drawing.Point(118, 282);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(509, 137);
            this.groupBox2.TabIndex = 71;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Selección Datos";
            // 
            // cboComponente
            // 
            this.cboComponente.DataSource = this.cOMPONENTESBindingSource;
            this.cboComponente.DisplayMember = "NOMBRE";
            this.cboComponente.FormattingEnabled = true;
            this.cboComponente.ItemHeight = 24;
            this.cboComponente.Location = new System.Drawing.Point(293, 87);
            this.cboComponente.Name = "cboComponente";
            this.cboComponente.Size = new System.Drawing.Size(143, 30);
            this.cboComponente.Style = MetroFramework.MetroColorStyle.Orange;
            this.cboComponente.TabIndex = 3;
            this.cboComponente.UseSelectable = true;
            this.cboComponente.ValueMember = "IDCOMPONENTE";
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
            // metroLabel3
            // 
            this.metroLabel3.AutoSize = true;
            this.metroLabel3.Location = new System.Drawing.Point(17, 87);
            this.metroLabel3.Name = "metroLabel3";
            this.metroLabel3.Size = new System.Drawing.Size(164, 20);
            this.metroLabel3.TabIndex = 2;
            this.metroLabel3.Text = "Seleccione Componente:";
            // 
            // cboMatAeronave
            // 
            this.cboMatAeronave.DataSource = this.aERONAVESBindingSource;
            this.cboMatAeronave.DisplayMember = "PATENTE";
            this.cboMatAeronave.FormattingEnabled = true;
            this.cboMatAeronave.ItemHeight = 24;
            this.cboMatAeronave.Location = new System.Drawing.Point(293, 29);
            this.cboMatAeronave.Name = "cboMatAeronave";
            this.cboMatAeronave.Size = new System.Drawing.Size(143, 30);
            this.cboMatAeronave.Style = MetroFramework.MetroColorStyle.Orange;
            this.cboMatAeronave.TabIndex = 1;
            this.cboMatAeronave.UseSelectable = true;
            this.cboMatAeronave.ValueMember = "IDAERONAVE";
            // 
            // aERONAVESBindingSource
            // 
            this.aERONAVESBindingSource.DataMember = "AERONAVES";
            this.aERONAVESBindingSource.DataSource = this.dataSetAeronaves;
            // 
            // dataSetAeronaves
            // 
            this.dataSetAeronaves.DataSetName = "DataSetAeronaves";
            this.dataSetAeronaves.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // metroLabel2
            // 
            this.metroLabel2.AutoSize = true;
            this.metroLabel2.Location = new System.Drawing.Point(17, 39);
            this.metroLabel2.Name = "metroLabel2";
            this.metroLabel2.Size = new System.Drawing.Size(203, 20);
            this.metroLabel2.TabIndex = 0;
            this.metroLabel2.Text = "Seleccione matricula Aeronave:";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.chkComponente);
            this.groupBox1.Controls.Add(this.chkAeronave);
            this.groupBox1.Controls.Add(this.metroLabel1);
            this.groupBox1.Location = new System.Drawing.Point(118, 204);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(509, 72);
            this.groupBox1.TabIndex = 70;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Selección Mantenimiento";
            // 
            // chkComponente
            // 
            this.chkComponente.AutoSize = true;
            this.chkComponente.Location = new System.Drawing.Point(337, 36);
            this.chkComponente.Name = "chkComponente";
            this.chkComponente.Size = new System.Drawing.Size(99, 17);
            this.chkComponente.Style = MetroFramework.MetroColorStyle.Orange;
            this.chkComponente.TabIndex = 2;
            this.chkComponente.Text = "Componente";
            this.chkComponente.UseSelectable = true;
            this.chkComponente.CheckedChanged += new System.EventHandler(this.chkComponente_CheckedChanged);
            // 
            // chkAeronave
            // 
            this.chkAeronave.AutoSize = true;
            this.chkAeronave.Location = new System.Drawing.Point(196, 36);
            this.chkAeronave.Name = "chkAeronave";
            this.chkAeronave.Size = new System.Drawing.Size(79, 17);
            this.chkAeronave.Style = MetroFramework.MetroColorStyle.Orange;
            this.chkAeronave.TabIndex = 1;
            this.chkAeronave.Text = "Aeronave";
            this.chkAeronave.UseSelectable = true;
            this.chkAeronave.CheckedChanged += new System.EventHandler(this.chkAeronave_CheckedChanged);
            // 
            // metroLabel1
            // 
            this.metroLabel1.AutoSize = true;
            this.metroLabel1.Location = new System.Drawing.Point(17, 33);
            this.metroLabel1.Name = "metroLabel1";
            this.metroLabel1.Size = new System.Drawing.Size(136, 20);
            this.metroLabel1.TabIndex = 0;
            this.metroLabel1.Text = "Tipo Mantenimiento:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(184, 51);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(370, 38);
            this.label1.TabIndex = 69;
            this.label1.Text = "Modificar Mantenimiento";
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.btnBuscar);
            this.groupBox4.Controls.Add(this.txtNum);
            this.groupBox4.Controls.Add(this.metroLabel5);
            this.groupBox4.Location = new System.Drawing.Point(118, 122);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(509, 76);
            this.groupBox4.TabIndex = 71;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Búsqueda de Mantenimiento";
            // 
            // btnBuscar
            // 
            this.btnBuscar.Location = new System.Drawing.Point(381, 33);
            this.btnBuscar.Name = "btnBuscar";
            this.btnBuscar.Size = new System.Drawing.Size(108, 32);
            this.btnBuscar.TabIndex = 74;
            this.btnBuscar.Text = "Buscar";
            this.btnBuscar.UseSelectable = true;
            this.btnBuscar.Click += new System.EventHandler(this.btnBuscar_Click);
            // 
            // txtNum
            // 
            this.txtNum.BackColor = System.Drawing.Color.White;
            // 
            // 
            // 
            this.txtNum.CustomButton.Image = null;
            this.txtNum.CustomButton.Location = new System.Drawing.Point(69, 2);
            this.txtNum.CustomButton.Name = "";
            this.txtNum.CustomButton.Size = new System.Drawing.Size(27, 27);
            this.txtNum.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txtNum.CustomButton.TabIndex = 1;
            this.txtNum.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txtNum.CustomButton.UseSelectable = true;
            this.txtNum.CustomButton.Visible = false;
            this.txtNum.Lines = new string[0];
            this.txtNum.Location = new System.Drawing.Point(251, 33);
            this.txtNum.MaxLength = 32767;
            this.txtNum.Name = "txtNum";
            this.txtNum.PasswordChar = '\0';
            this.txtNum.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtNum.SelectedText = "";
            this.txtNum.SelectionLength = 0;
            this.txtNum.SelectionStart = 0;
            this.txtNum.ShortcutsEnabled = true;
            this.txtNum.Size = new System.Drawing.Size(99, 32);
            this.txtNum.Style = MetroFramework.MetroColorStyle.Orange;
            this.txtNum.TabIndex = 52;
            this.txtNum.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txtNum.UseSelectable = true;
            this.txtNum.UseStyleColors = true;
            this.txtNum.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txtNum.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            this.txtNum.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtNum_KeyPress);
            // 
            // metroLabel5
            // 
            this.metroLabel5.AutoSize = true;
            this.metroLabel5.Location = new System.Drawing.Point(17, 33);
            this.metroLabel5.Name = "metroLabel5";
            this.metroLabel5.Size = new System.Drawing.Size(181, 20);
            this.metroLabel5.TabIndex = 0;
            this.metroLabel5.Text = "Número de Mantenimiento:";
            // 
            // aERONAVESTableAdapter
            // 
            this.aERONAVESTableAdapter.ClearBeforeFill = true;
            // 
            // cOMPONENTESTableAdapter
            // 
            this.cOMPONENTESTableAdapter.ClearBeforeFill = true;
            // 
            // Form_ModificarMantenimiento
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(754, 650);
            this.Controls.Add(this.groupBox4);
            this.Controls.Add(this.btnModificar);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Form_ModificarMantenimiento";
            this.Text = "Form_ModificarMantenimiento";
            this.Load += new System.EventHandler(this.Form_ModificarMantenimiento_Load);
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.cOMPONENTESBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSetComponentes)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.aERONAVESBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSetAeronaves)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private MetroFramework.Controls.MetroButton btnModificar;
        private System.Windows.Forms.GroupBox groupBox3;
        private MetroFramework.Controls.MetroTextBox txtObs;
        private MetroFramework.Controls.MetroLabel metroLabel4;
        private System.Windows.Forms.GroupBox groupBox2;
        private MetroFramework.Controls.MetroComboBox cboComponente;
        private MetroFramework.Controls.MetroLabel metroLabel3;
        private MetroFramework.Controls.MetroComboBox cboMatAeronave;
        private MetroFramework.Controls.MetroLabel metroLabel2;
        private System.Windows.Forms.GroupBox groupBox1;
        private MetroFramework.Controls.MetroRadioButton chkComponente;
        private MetroFramework.Controls.MetroRadioButton chkAeronave;
        private MetroFramework.Controls.MetroLabel metroLabel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox4;
        private MetroFramework.Controls.MetroLabel metroLabel5;
        private MetroFramework.Controls.MetroButton btnBuscar;
        private MetroFramework.Controls.MetroTextBox txtNum;
        private DataSetAeronaves dataSetAeronaves;
        private System.Windows.Forms.BindingSource aERONAVESBindingSource;
        private DataSetAeronavesTableAdapters.AERONAVESTableAdapter aERONAVESTableAdapter;
        private DataSetComponentes dataSetComponentes;
        private System.Windows.Forms.BindingSource cOMPONENTESBindingSource;
        private DataSetComponentesTableAdapters.COMPONENTESTableAdapter cOMPONENTESTableAdapter;
    }
}
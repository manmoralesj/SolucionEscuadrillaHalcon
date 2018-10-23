namespace CapaPresentacion
{
    partial class Form_AgregarMantenimiento
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.chkComponente = new MetroFramework.Controls.MetroRadioButton();
            this.chkAeronave = new MetroFramework.Controls.MetroRadioButton();
            this.metroLabel1 = new MetroFramework.Controls.MetroLabel();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.cboComponente = new MetroFramework.Controls.MetroComboBox();
            this.cOMPONENTESBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dataSetComponentesBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dataSetComponentes = new CapaPresentacion.DataSetComponentes();
            this.metroLabel3 = new MetroFramework.Controls.MetroLabel();
            this.cboMatAeronave = new MetroFramework.Controls.MetroComboBox();
            this.aERONAVESBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dataSetAeronaves = new CapaPresentacion.DataSetAeronaves();
            this.metroLabel2 = new MetroFramework.Controls.MetroLabel();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.txtObs = new MetroFramework.Controls.MetroTextBox();
            this.metroLabel4 = new MetroFramework.Controls.MetroLabel();
            this.btnIngresar = new MetroFramework.Controls.MetroButton();
            this.cOMPONENTESTableAdapter = new CapaPresentacion.DataSetComponentesTableAdapters.COMPONENTESTableAdapter();
            this.aERONAVESTableAdapter = new CapaPresentacion.DataSetAeronavesTableAdapters.AERONAVESTableAdapter();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.cOMPONENTESBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSetComponentesBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSetComponentes)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.aERONAVESBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSetAeronaves)).BeginInit();
            this.groupBox3.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(151, 85);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(371, 38);
            this.label1.TabIndex = 64;
            this.label1.Text = "Registrar Mantenimiento";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.chkComponente);
            this.groupBox1.Controls.Add(this.chkAeronave);
            this.groupBox1.Controls.Add(this.metroLabel1);
            this.groupBox1.Location = new System.Drawing.Point(86, 159);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(509, 91);
            this.groupBox1.TabIndex = 65;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Selección Mantenimiento";
            // 
            // chkComponente
            // 
            this.chkComponente.AutoSize = true;
            this.chkComponente.Location = new System.Drawing.Point(337, 47);
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
            this.chkAeronave.Location = new System.Drawing.Point(196, 47);
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
            this.metroLabel1.Location = new System.Drawing.Point(17, 44);
            this.metroLabel1.Name = "metroLabel1";
            this.metroLabel1.Size = new System.Drawing.Size(136, 20);
            this.metroLabel1.TabIndex = 0;
            this.metroLabel1.Text = "Tipo Mantenimiento:";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.cboComponente);
            this.groupBox2.Controls.Add(this.metroLabel3);
            this.groupBox2.Controls.Add(this.cboMatAeronave);
            this.groupBox2.Controls.Add(this.metroLabel2);
            this.groupBox2.Location = new System.Drawing.Point(86, 272);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(509, 137);
            this.groupBox2.TabIndex = 66;
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
            this.cOMPONENTESBindingSource.DataSource = this.dataSetComponentesBindingSource;
            // 
            // dataSetComponentesBindingSource
            // 
            this.dataSetComponentesBindingSource.DataSource = this.dataSetComponentes;
            this.dataSetComponentesBindingSource.Position = 0;
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
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.txtObs);
            this.groupBox3.Controls.Add(this.metroLabel4);
            this.groupBox3.Location = new System.Drawing.Point(86, 422);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(509, 116);
            this.groupBox3.TabIndex = 67;
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
            // btnIngresar
            // 
            this.btnIngresar.Location = new System.Drawing.Point(86, 555);
            this.btnIngresar.Name = "btnIngresar";
            this.btnIngresar.Size = new System.Drawing.Size(108, 41);
            this.btnIngresar.TabIndex = 68;
            this.btnIngresar.Text = "Ingresar";
            this.btnIngresar.UseSelectable = true;
            this.btnIngresar.Click += new System.EventHandler(this.btnIngresar_Click);
            // 
            // cOMPONENTESTableAdapter
            // 
            this.cOMPONENTESTableAdapter.ClearBeforeFill = true;
            // 
            // aERONAVESTableAdapter
            // 
            this.aERONAVESTableAdapter.ClearBeforeFill = true;
            // 
            // Form_AgregarMantenimiento
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(672, 641);
            this.Controls.Add(this.btnIngresar);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Form_AgregarMantenimiento";
            this.Text = "Form_AgregarMantenimiento";
            this.Load += new System.EventHandler(this.Form_AgregarMantenimiento_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.cOMPONENTESBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSetComponentesBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSetComponentes)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.aERONAVESBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSetAeronaves)).EndInit();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox1;
        private MetroFramework.Controls.MetroRadioButton chkComponente;
        private MetroFramework.Controls.MetroRadioButton chkAeronave;
        private MetroFramework.Controls.MetroLabel metroLabel1;
        private System.Windows.Forms.GroupBox groupBox2;
        private MetroFramework.Controls.MetroComboBox cboComponente;
        private MetroFramework.Controls.MetroLabel metroLabel3;
        private MetroFramework.Controls.MetroComboBox cboMatAeronave;
        private MetroFramework.Controls.MetroLabel metroLabel2;
        private System.Windows.Forms.GroupBox groupBox3;
        private MetroFramework.Controls.MetroLabel metroLabel4;
        private MetroFramework.Controls.MetroButton btnIngresar;
        private MetroFramework.Controls.MetroTextBox txtObs;
        private System.Windows.Forms.BindingSource cOMPONENTESBindingSource;
        private System.Windows.Forms.BindingSource dataSetComponentesBindingSource;
        private DataSetComponentes dataSetComponentes;
        private System.Windows.Forms.BindingSource aERONAVESBindingSource;
        private DataSetAeronaves dataSetAeronaves;
        private DataSetComponentesTableAdapters.COMPONENTESTableAdapter cOMPONENTESTableAdapter;
        private DataSetAeronavesTableAdapters.AERONAVESTableAdapter aERONAVESTableAdapter;
    }
}
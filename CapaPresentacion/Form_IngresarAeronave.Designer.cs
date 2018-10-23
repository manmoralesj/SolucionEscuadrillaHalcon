namespace CapaPresentacion
{
    partial class Form_IngresarAeronave
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
            this.chkHelicoptero = new MetroFramework.Controls.MetroRadioButton();
            this.chkAvion = new MetroFramework.Controls.MetroRadioButton();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.metroLabel13 = new MetroFramework.Controls.MetroLabel();
            this.cboFabricante = new MetroFramework.Controls.MetroComboBox();
            this.fABRICANTESAEROBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dataSetFabricantes = new CapaPresentacion.DataSetFabricantes();
            this.metroLabel12 = new MetroFramework.Controls.MetroLabel();
            this.cboModelo = new MetroFramework.Controls.MetroComboBox();
            this.mODELOSAEROBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dataSetModelos = new CapaPresentacion.DataSetModelos();
            this.txtCantRuedas = new MetroFramework.Controls.MetroTextBox();
            this.metroLabel11 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel5 = new MetroFramework.Controls.MetroLabel();
            this.txtAnnioFab = new MetroFramework.Controls.MetroTextBox();
            this.txtMotor = new MetroFramework.Controls.MetroTextBox();
            this.metroLabel10 = new MetroFramework.Controls.MetroLabel();
            this.txtLitros = new MetroFramework.Controls.MetroTextBox();
            this.metroLabel8 = new MetroFramework.Controls.MetroLabel();
            this.txtCantMaxPilotos = new MetroFramework.Controls.MetroTextBox();
            this.metroLabel7 = new MetroFramework.Controls.MetroLabel();
            this.txtFechaInspeccion = new MetroFramework.Controls.MetroDateTime();
            this.metroLabel4 = new MetroFramework.Controls.MetroLabel();
            this.txtCantMaxHoras = new MetroFramework.Controls.MetroTextBox();
            this.metroLabel3 = new MetroFramework.Controls.MetroLabel();
            this.txtMatricula = new MetroFramework.Controls.MetroTextBox();
            this.metroLabel2 = new MetroFramework.Controls.MetroLabel();
            this.btnIngresar = new MetroFramework.Controls.MetroButton();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.txtCantHelices = new MetroFramework.Controls.MetroTextBox();
            this.metroLabel9 = new MetroFramework.Controls.MetroLabel();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.txtCantTurbinas = new MetroFramework.Controls.MetroTextBox();
            this.metroLabel6 = new MetroFramework.Controls.MetroLabel();
            this.mODELOS_AEROTableAdapter = new CapaPresentacion.DataSetModelosTableAdapters.MODELOS_AEROTableAdapter();
            this.fABRICANTES_AEROTableAdapter = new CapaPresentacion.DataSetFabricantesTableAdapters.FABRICANTES_AEROTableAdapter();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.fABRICANTESAEROBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSetFabricantes)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.mODELOSAEROBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSetModelos)).BeginInit();
            this.groupBox3.SuspendLayout();
            this.groupBox4.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(218, 23);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(319, 38);
            this.label1.TabIndex = 64;
            this.label1.Text = "Ingreso de Aeronave";
            // 
            // metroLabel1
            // 
            this.metroLabel1.AutoSize = true;
            this.metroLabel1.Location = new System.Drawing.Point(19, 18);
            this.metroLabel1.Name = "metroLabel1";
            this.metroLabel1.Size = new System.Drawing.Size(79, 20);
            this.metroLabel1.TabIndex = 65;
            this.metroLabel1.Text = "Seleccione:";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.chkHelicoptero);
            this.groupBox1.Controls.Add(this.chkAvion);
            this.groupBox1.Controls.Add(this.metroLabel1);
            this.groupBox1.Location = new System.Drawing.Point(140, 83);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(445, 54);
            this.groupBox1.TabIndex = 66;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Tipo de Aeronave";
            // 
            // chkHelicoptero
            // 
            this.chkHelicoptero.AutoSize = true;
            this.chkHelicoptero.Location = new System.Drawing.Point(297, 21);
            this.chkHelicoptero.Name = "chkHelicoptero";
            this.chkHelicoptero.Size = new System.Drawing.Size(84, 17);
            this.chkHelicoptero.Style = MetroFramework.MetroColorStyle.Orange;
            this.chkHelicoptero.TabIndex = 67;
            this.chkHelicoptero.Text = "Helicótero";
            this.chkHelicoptero.UseSelectable = true;
            this.chkHelicoptero.CheckedChanged += new System.EventHandler(this.chkHelicoptero_CheckedChanged);
            // 
            // chkAvion
            // 
            this.chkAvion.AutoSize = true;
            this.chkAvion.Location = new System.Drawing.Point(169, 21);
            this.chkAvion.Name = "chkAvion";
            this.chkAvion.Size = new System.Drawing.Size(56, 17);
            this.chkAvion.Style = MetroFramework.MetroColorStyle.Orange;
            this.chkAvion.TabIndex = 66;
            this.chkAvion.Text = "Avión";
            this.chkAvion.UseSelectable = true;
            this.chkAvion.CheckedChanged += new System.EventHandler(this.chkAvion_CheckedChanged);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.metroLabel13);
            this.groupBox2.Controls.Add(this.cboFabricante);
            this.groupBox2.Controls.Add(this.metroLabel12);
            this.groupBox2.Controls.Add(this.cboModelo);
            this.groupBox2.Controls.Add(this.txtCantRuedas);
            this.groupBox2.Controls.Add(this.metroLabel11);
            this.groupBox2.Controls.Add(this.metroLabel5);
            this.groupBox2.Controls.Add(this.txtAnnioFab);
            this.groupBox2.Controls.Add(this.txtMotor);
            this.groupBox2.Controls.Add(this.metroLabel10);
            this.groupBox2.Controls.Add(this.txtLitros);
            this.groupBox2.Controls.Add(this.metroLabel8);
            this.groupBox2.Controls.Add(this.txtCantMaxPilotos);
            this.groupBox2.Controls.Add(this.metroLabel7);
            this.groupBox2.Controls.Add(this.txtFechaInspeccion);
            this.groupBox2.Controls.Add(this.metroLabel4);
            this.groupBox2.Controls.Add(this.txtCantMaxHoras);
            this.groupBox2.Controls.Add(this.metroLabel3);
            this.groupBox2.Controls.Add(this.txtMatricula);
            this.groupBox2.Controls.Add(this.metroLabel2);
            this.groupBox2.Location = new System.Drawing.Point(26, 260);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(719, 316);
            this.groupBox2.TabIndex = 67;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Datos Aeronave:";
            // 
            // metroLabel13
            // 
            this.metroLabel13.AutoSize = true;
            this.metroLabel13.Location = new System.Drawing.Point(402, 180);
            this.metroLabel13.Name = "metroLabel13";
            this.metroLabel13.Size = new System.Drawing.Size(75, 20);
            this.metroLabel13.TabIndex = 80;
            this.metroLabel13.Text = "Fabricante:";
            // 
            // cboFabricante
            // 
            this.cboFabricante.DataSource = this.fABRICANTESAEROBindingSource;
            this.cboFabricante.DisplayMember = "NOMBRE_FAB";
            this.cboFabricante.FormattingEnabled = true;
            this.cboFabricante.ItemHeight = 24;
            this.cboFabricante.Location = new System.Drawing.Point(554, 180);
            this.cboFabricante.Name = "cboFabricante";
            this.cboFabricante.Size = new System.Drawing.Size(137, 30);
            this.cboFabricante.Style = MetroFramework.MetroColorStyle.Orange;
            this.cboFabricante.TabIndex = 79;
            this.cboFabricante.UseSelectable = true;
            this.cboFabricante.ValueMember = "IDFABRICANTE";
            // 
            // fABRICANTESAEROBindingSource
            // 
            this.fABRICANTESAEROBindingSource.DataMember = "FABRICANTES_AERO";
            this.fABRICANTESAEROBindingSource.DataSource = this.dataSetFabricantes;
            // 
            // dataSetFabricantes
            // 
            this.dataSetFabricantes.DataSetName = "DataSetFabricantes";
            this.dataSetFabricantes.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // metroLabel12
            // 
            this.metroLabel12.AutoSize = true;
            this.metroLabel12.Location = new System.Drawing.Point(402, 134);
            this.metroLabel12.Name = "metroLabel12";
            this.metroLabel12.Size = new System.Drawing.Size(59, 20);
            this.metroLabel12.TabIndex = 78;
            this.metroLabel12.Text = "Modelo:";
            // 
            // cboModelo
            // 
            this.cboModelo.DataSource = this.mODELOSAEROBindingSource;
            this.cboModelo.DisplayMember = "MODELO_AERONAVE";
            this.cboModelo.FormattingEnabled = true;
            this.cboModelo.ItemHeight = 24;
            this.cboModelo.Location = new System.Drawing.Point(554, 131);
            this.cboModelo.Name = "cboModelo";
            this.cboModelo.Size = new System.Drawing.Size(137, 30);
            this.cboModelo.Style = MetroFramework.MetroColorStyle.Orange;
            this.cboModelo.TabIndex = 77;
            this.cboModelo.UseSelectable = true;
            this.cboModelo.ValueMember = "IDMODELO";
            // 
            // mODELOSAEROBindingSource
            // 
            this.mODELOSAEROBindingSource.DataMember = "MODELOS_AERO";
            this.mODELOSAEROBindingSource.DataSource = this.dataSetModelos;
            // 
            // dataSetModelos
            // 
            this.dataSetModelos.DataSetName = "DataSetModelos";
            this.dataSetModelos.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // txtCantRuedas
            // 
            // 
            // 
            // 
            this.txtCantRuedas.CustomButton.Image = null;
            this.txtCantRuedas.CustomButton.Location = new System.Drawing.Point(33, 1);
            this.txtCantRuedas.CustomButton.Name = "";
            this.txtCantRuedas.CustomButton.Size = new System.Drawing.Size(25, 25);
            this.txtCantRuedas.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txtCantRuedas.CustomButton.TabIndex = 1;
            this.txtCantRuedas.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txtCantRuedas.CustomButton.UseSelectable = true;
            this.txtCantRuedas.CustomButton.Visible = false;
            this.txtCantRuedas.Lines = new string[0];
            this.txtCantRuedas.Location = new System.Drawing.Point(554, 91);
            this.txtCantRuedas.MaxLength = 32767;
            this.txtCantRuedas.Name = "txtCantRuedas";
            this.txtCantRuedas.PasswordChar = '\0';
            this.txtCantRuedas.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtCantRuedas.SelectedText = "";
            this.txtCantRuedas.SelectionLength = 0;
            this.txtCantRuedas.SelectionStart = 0;
            this.txtCantRuedas.ShortcutsEnabled = true;
            this.txtCantRuedas.Size = new System.Drawing.Size(59, 27);
            this.txtCantRuedas.Style = MetroFramework.MetroColorStyle.Orange;
            this.txtCantRuedas.TabIndex = 15;
            this.txtCantRuedas.UseSelectable = true;
            this.txtCantRuedas.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txtCantRuedas.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // metroLabel11
            // 
            this.metroLabel11.AutoSize = true;
            this.metroLabel11.Location = new System.Drawing.Point(402, 92);
            this.metroLabel11.Name = "metroLabel11";
            this.metroLabel11.Size = new System.Drawing.Size(115, 20);
            this.metroLabel11.TabIndex = 14;
            this.metroLabel11.Text = "Cantidad Ruedas:";
            // 
            // metroLabel5
            // 
            this.metroLabel5.AutoSize = true;
            this.metroLabel5.Location = new System.Drawing.Point(19, 91);
            this.metroLabel5.Name = "metroLabel5";
            this.metroLabel5.Size = new System.Drawing.Size(110, 20);
            this.metroLabel5.TabIndex = 6;
            this.metroLabel5.Text = "Año Fabricación:";
            // 
            // txtAnnioFab
            // 
            // 
            // 
            // 
            this.txtAnnioFab.CustomButton.Image = null;
            this.txtAnnioFab.CustomButton.Location = new System.Drawing.Point(51, 1);
            this.txtAnnioFab.CustomButton.Name = "";
            this.txtAnnioFab.CustomButton.Size = new System.Drawing.Size(25, 25);
            this.txtAnnioFab.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txtAnnioFab.CustomButton.TabIndex = 1;
            this.txtAnnioFab.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txtAnnioFab.CustomButton.UseSelectable = true;
            this.txtAnnioFab.CustomButton.Visible = false;
            this.txtAnnioFab.Lines = new string[0];
            this.txtAnnioFab.Location = new System.Drawing.Point(263, 91);
            this.txtAnnioFab.MaxLength = 32767;
            this.txtAnnioFab.Name = "txtAnnioFab";
            this.txtAnnioFab.PasswordChar = '\0';
            this.txtAnnioFab.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtAnnioFab.SelectedText = "";
            this.txtAnnioFab.SelectionLength = 0;
            this.txtAnnioFab.SelectionStart = 0;
            this.txtAnnioFab.ShortcutsEnabled = true;
            this.txtAnnioFab.Size = new System.Drawing.Size(77, 27);
            this.txtAnnioFab.Style = MetroFramework.MetroColorStyle.Orange;
            this.txtAnnioFab.TabIndex = 7;
            this.txtAnnioFab.UseSelectable = true;
            this.txtAnnioFab.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txtAnnioFab.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            this.txtAnnioFab.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtAnnioFab_KeyPress);
            // 
            // txtMotor
            // 
            // 
            // 
            // 
            this.txtMotor.CustomButton.Image = null;
            this.txtMotor.CustomButton.Location = new System.Drawing.Point(91, 1);
            this.txtMotor.CustomButton.Name = "";
            this.txtMotor.CustomButton.Size = new System.Drawing.Size(25, 25);
            this.txtMotor.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txtMotor.CustomButton.TabIndex = 1;
            this.txtMotor.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txtMotor.CustomButton.UseSelectable = true;
            this.txtMotor.CustomButton.Visible = false;
            this.txtMotor.Lines = new string[0];
            this.txtMotor.Location = new System.Drawing.Point(263, 222);
            this.txtMotor.MaxLength = 32767;
            this.txtMotor.Name = "txtMotor";
            this.txtMotor.PasswordChar = '\0';
            this.txtMotor.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtMotor.SelectedText = "";
            this.txtMotor.SelectionLength = 0;
            this.txtMotor.SelectionStart = 0;
            this.txtMotor.ShortcutsEnabled = true;
            this.txtMotor.Size = new System.Drawing.Size(117, 27);
            this.txtMotor.Style = MetroFramework.MetroColorStyle.Orange;
            this.txtMotor.TabIndex = 13;
            this.txtMotor.UseSelectable = true;
            this.txtMotor.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txtMotor.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // metroLabel10
            // 
            this.metroLabel10.AutoSize = true;
            this.metroLabel10.Location = new System.Drawing.Point(21, 222);
            this.metroLabel10.Name = "metroLabel10";
            this.metroLabel10.Size = new System.Drawing.Size(50, 20);
            this.metroLabel10.TabIndex = 12;
            this.metroLabel10.Text = "Motor:";
            // 
            // txtLitros
            // 
            // 
            // 
            // 
            this.txtLitros.CustomButton.Image = null;
            this.txtLitros.CustomButton.Location = new System.Drawing.Point(33, 1);
            this.txtLitros.CustomButton.Name = "";
            this.txtLitros.CustomButton.Size = new System.Drawing.Size(25, 25);
            this.txtLitros.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txtLitros.CustomButton.TabIndex = 1;
            this.txtLitros.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txtLitros.CustomButton.UseSelectable = true;
            this.txtLitros.CustomButton.Visible = false;
            this.txtLitros.Lines = new string[0];
            this.txtLitros.Location = new System.Drawing.Point(554, 46);
            this.txtLitros.MaxLength = 32767;
            this.txtLitros.Name = "txtLitros";
            this.txtLitros.PasswordChar = '\0';
            this.txtLitros.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtLitros.SelectedText = "";
            this.txtLitros.SelectionLength = 0;
            this.txtLitros.SelectionStart = 0;
            this.txtLitros.ShortcutsEnabled = true;
            this.txtLitros.Size = new System.Drawing.Size(59, 27);
            this.txtLitros.Style = MetroFramework.MetroColorStyle.Orange;
            this.txtLitros.TabIndex = 11;
            this.txtLitros.UseSelectable = true;
            this.txtLitros.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txtLitros.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            this.txtLitros.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtLitros_KeyPress);
            // 
            // metroLabel8
            // 
            this.metroLabel8.AutoSize = true;
            this.metroLabel8.Location = new System.Drawing.Point(402, 46);
            this.metroLabel8.Name = "metroLabel8";
            this.metroLabel8.Size = new System.Drawing.Size(113, 20);
            this.metroLabel8.TabIndex = 10;
            this.metroLabel8.Text = "Capacidad Litros:";
            // 
            // txtCantMaxPilotos
            // 
            // 
            // 
            // 
            this.txtCantMaxPilotos.CustomButton.Image = null;
            this.txtCantMaxPilotos.CustomButton.Location = new System.Drawing.Point(33, 1);
            this.txtCantMaxPilotos.CustomButton.Name = "";
            this.txtCantMaxPilotos.CustomButton.Size = new System.Drawing.Size(25, 25);
            this.txtCantMaxPilotos.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txtCantMaxPilotos.CustomButton.TabIndex = 1;
            this.txtCantMaxPilotos.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txtCantMaxPilotos.CustomButton.UseSelectable = true;
            this.txtCantMaxPilotos.CustomButton.Visible = false;
            this.txtCantMaxPilotos.Lines = new string[0];
            this.txtCantMaxPilotos.Location = new System.Drawing.Point(263, 180);
            this.txtCantMaxPilotos.MaxLength = 32767;
            this.txtCantMaxPilotos.Name = "txtCantMaxPilotos";
            this.txtCantMaxPilotos.PasswordChar = '\0';
            this.txtCantMaxPilotos.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtCantMaxPilotos.SelectedText = "";
            this.txtCantMaxPilotos.SelectionLength = 0;
            this.txtCantMaxPilotos.SelectionStart = 0;
            this.txtCantMaxPilotos.ShortcutsEnabled = true;
            this.txtCantMaxPilotos.Size = new System.Drawing.Size(59, 27);
            this.txtCantMaxPilotos.Style = MetroFramework.MetroColorStyle.Orange;
            this.txtCantMaxPilotos.TabIndex = 9;
            this.txtCantMaxPilotos.UseSelectable = true;
            this.txtCantMaxPilotos.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txtCantMaxPilotos.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            this.txtCantMaxPilotos.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtCantMaxPilotos_KeyPress);
            // 
            // metroLabel7
            // 
            this.metroLabel7.AutoSize = true;
            this.metroLabel7.Location = new System.Drawing.Point(19, 180);
            this.metroLabel7.Name = "metroLabel7";
            this.metroLabel7.Size = new System.Drawing.Size(142, 20);
            this.metroLabel7.TabIndex = 8;
            this.metroLabel7.Text = "Cantidad Máx. Pilotos:";
            // 
            // txtFechaInspeccion
            // 
            this.txtFechaInspeccion.Location = new System.Drawing.Point(263, 267);
            this.txtFechaInspeccion.MinimumSize = new System.Drawing.Size(0, 30);
            this.txtFechaInspeccion.Name = "txtFechaInspeccion";
            this.txtFechaInspeccion.Size = new System.Drawing.Size(280, 30);
            this.txtFechaInspeccion.Style = MetroFramework.MetroColorStyle.Orange;
            this.txtFechaInspeccion.TabIndex = 5;
            // 
            // metroLabel4
            // 
            this.metroLabel4.AutoSize = true;
            this.metroLabel4.Location = new System.Drawing.Point(21, 267);
            this.metroLabel4.Name = "metroLabel4";
            this.metroLabel4.Size = new System.Drawing.Size(117, 20);
            this.metroLabel4.TabIndex = 4;
            this.metroLabel4.Text = "Inspección Anual:";
            // 
            // txtCantMaxHoras
            // 
            // 
            // 
            // 
            this.txtCantMaxHoras.CustomButton.Image = null;
            this.txtCantMaxHoras.CustomButton.Location = new System.Drawing.Point(33, 2);
            this.txtCantMaxHoras.CustomButton.Name = "";
            this.txtCantMaxHoras.CustomButton.Size = new System.Drawing.Size(23, 23);
            this.txtCantMaxHoras.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txtCantMaxHoras.CustomButton.TabIndex = 1;
            this.txtCantMaxHoras.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txtCantMaxHoras.CustomButton.UseSelectable = true;
            this.txtCantMaxHoras.CustomButton.Visible = false;
            this.txtCantMaxHoras.Lines = new string[0];
            this.txtCantMaxHoras.Location = new System.Drawing.Point(263, 132);
            this.txtCantMaxHoras.MaxLength = 32767;
            this.txtCantMaxHoras.Name = "txtCantMaxHoras";
            this.txtCantMaxHoras.PasswordChar = '\0';
            this.txtCantMaxHoras.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtCantMaxHoras.SelectedText = "";
            this.txtCantMaxHoras.SelectionLength = 0;
            this.txtCantMaxHoras.SelectionStart = 0;
            this.txtCantMaxHoras.ShortcutsEnabled = true;
            this.txtCantMaxHoras.Size = new System.Drawing.Size(59, 28);
            this.txtCantMaxHoras.Style = MetroFramework.MetroColorStyle.Orange;
            this.txtCantMaxHoras.TabIndex = 3;
            this.txtCantMaxHoras.UseSelectable = true;
            this.txtCantMaxHoras.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txtCantMaxHoras.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            this.txtCantMaxHoras.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtCantMaxHoras_KeyPress);
            // 
            // metroLabel3
            // 
            this.metroLabel3.AutoSize = true;
            this.metroLabel3.Location = new System.Drawing.Point(19, 134);
            this.metroLabel3.Name = "metroLabel3";
            this.metroLabel3.Size = new System.Drawing.Size(184, 20);
            this.metroLabel3.TabIndex = 2;
            this.metroLabel3.Text = "Cantidad Máx. Horas a volar:";
            // 
            // txtMatricula
            // 
            // 
            // 
            // 
            this.txtMatricula.CustomButton.Image = null;
            this.txtMatricula.CustomButton.Location = new System.Drawing.Point(89, 2);
            this.txtMatricula.CustomButton.Name = "";
            this.txtMatricula.CustomButton.Size = new System.Drawing.Size(25, 25);
            this.txtMatricula.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txtMatricula.CustomButton.TabIndex = 1;
            this.txtMatricula.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txtMatricula.CustomButton.UseSelectable = true;
            this.txtMatricula.CustomButton.Visible = false;
            this.txtMatricula.Lines = new string[0];
            this.txtMatricula.Location = new System.Drawing.Point(263, 43);
            this.txtMatricula.MaxLength = 32767;
            this.txtMatricula.Name = "txtMatricula";
            this.txtMatricula.PasswordChar = '\0';
            this.txtMatricula.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtMatricula.SelectedText = "";
            this.txtMatricula.SelectionLength = 0;
            this.txtMatricula.SelectionStart = 0;
            this.txtMatricula.ShortcutsEnabled = true;
            this.txtMatricula.Size = new System.Drawing.Size(117, 30);
            this.txtMatricula.Style = MetroFramework.MetroColorStyle.Orange;
            this.txtMatricula.TabIndex = 1;
            this.txtMatricula.UseSelectable = true;
            this.txtMatricula.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txtMatricula.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // metroLabel2
            // 
            this.metroLabel2.AutoSize = true;
            this.metroLabel2.Location = new System.Drawing.Point(19, 46);
            this.metroLabel2.Name = "metroLabel2";
            this.metroLabel2.Size = new System.Drawing.Size(68, 20);
            this.metroLabel2.TabIndex = 0;
            this.metroLabel2.Text = "Matrícula:";
            // 
            // btnIngresar
            // 
            this.btnIngresar.Location = new System.Drawing.Point(26, 592);
            this.btnIngresar.Name = "btnIngresar";
            this.btnIngresar.Size = new System.Drawing.Size(118, 43);
            this.btnIngresar.TabIndex = 68;
            this.btnIngresar.Text = "Ingresar";
            this.btnIngresar.UseSelectable = true;
            this.btnIngresar.Click += new System.EventHandler(this.btnIngresar_Click);
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.txtCantHelices);
            this.groupBox3.Controls.Add(this.metroLabel9);
            this.groupBox3.Location = new System.Drawing.Point(28, 161);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(338, 82);
            this.groupBox3.TabIndex = 68;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Datos Helicóptero:";
            // 
            // txtCantHelices
            // 
            // 
            // 
            // 
            this.txtCantHelices.CustomButton.Image = null;
            this.txtCantHelices.CustomButton.Location = new System.Drawing.Point(21, 2);
            this.txtCantHelices.CustomButton.Name = "";
            this.txtCantHelices.CustomButton.Size = new System.Drawing.Size(25, 25);
            this.txtCantHelices.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txtCantHelices.CustomButton.TabIndex = 1;
            this.txtCantHelices.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txtCantHelices.CustomButton.UseSelectable = true;
            this.txtCantHelices.CustomButton.Visible = false;
            this.txtCantHelices.Lines = new string[0];
            this.txtCantHelices.Location = new System.Drawing.Point(209, 36);
            this.txtCantHelices.MaxLength = 32767;
            this.txtCantHelices.Name = "txtCantHelices";
            this.txtCantHelices.PasswordChar = '\0';
            this.txtCantHelices.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtCantHelices.SelectedText = "";
            this.txtCantHelices.SelectionLength = 0;
            this.txtCantHelices.SelectionStart = 0;
            this.txtCantHelices.ShortcutsEnabled = true;
            this.txtCantHelices.Size = new System.Drawing.Size(49, 30);
            this.txtCantHelices.Style = MetroFramework.MetroColorStyle.Orange;
            this.txtCantHelices.TabIndex = 1;
            this.txtCantHelices.UseSelectable = true;
            this.txtCantHelices.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txtCantHelices.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            this.txtCantHelices.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtCantHelices_KeyPress);
            // 
            // metroLabel9
            // 
            this.metroLabel9.AutoSize = true;
            this.metroLabel9.Location = new System.Drawing.Point(19, 36);
            this.metroLabel9.Name = "metroLabel9";
            this.metroLabel9.Size = new System.Drawing.Size(135, 20);
            this.metroLabel9.TabIndex = 0;
            this.metroLabel9.Text = "Cantidad de Hélices:";
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.txtCantTurbinas);
            this.groupBox4.Controls.Add(this.metroLabel6);
            this.groupBox4.Location = new System.Drawing.Point(396, 161);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(349, 82);
            this.groupBox4.TabIndex = 69;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Datos Avión:";
            // 
            // txtCantTurbinas
            // 
            // 
            // 
            // 
            this.txtCantTurbinas.CustomButton.Image = null;
            this.txtCantTurbinas.CustomButton.Location = new System.Drawing.Point(21, 2);
            this.txtCantTurbinas.CustomButton.Name = "";
            this.txtCantTurbinas.CustomButton.Size = new System.Drawing.Size(25, 25);
            this.txtCantTurbinas.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txtCantTurbinas.CustomButton.TabIndex = 1;
            this.txtCantTurbinas.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txtCantTurbinas.CustomButton.UseSelectable = true;
            this.txtCantTurbinas.CustomButton.Visible = false;
            this.txtCantTurbinas.Lines = new string[0];
            this.txtCantTurbinas.Location = new System.Drawing.Point(205, 36);
            this.txtCantTurbinas.MaxLength = 32767;
            this.txtCantTurbinas.Name = "txtCantTurbinas";
            this.txtCantTurbinas.PasswordChar = '\0';
            this.txtCantTurbinas.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtCantTurbinas.SelectedText = "";
            this.txtCantTurbinas.SelectionLength = 0;
            this.txtCantTurbinas.SelectionStart = 0;
            this.txtCantTurbinas.ShortcutsEnabled = true;
            this.txtCantTurbinas.Size = new System.Drawing.Size(49, 30);
            this.txtCantTurbinas.Style = MetroFramework.MetroColorStyle.Orange;
            this.txtCantTurbinas.TabIndex = 1;
            this.txtCantTurbinas.UseSelectable = true;
            this.txtCantTurbinas.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txtCantTurbinas.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            this.txtCantTurbinas.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtCantTurbinas_KeyPress);
            // 
            // metroLabel6
            // 
            this.metroLabel6.AutoSize = true;
            this.metroLabel6.Location = new System.Drawing.Point(17, 36);
            this.metroLabel6.Name = "metroLabel6";
            this.metroLabel6.Size = new System.Drawing.Size(141, 20);
            this.metroLabel6.TabIndex = 0;
            this.metroLabel6.Text = "Cantidad de Turbinas:";
            this.metroLabel6.Click += new System.EventHandler(this.metroLabel6_Click_1);
            // 
            // mODELOS_AEROTableAdapter
            // 
            this.mODELOS_AEROTableAdapter.ClearBeforeFill = true;
            // 
            // fABRICANTES_AEROTableAdapter
            // 
            this.fABRICANTES_AEROTableAdapter.ClearBeforeFill = true;
            // 
            // Form_IngresarAeronave
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(779, 647);
            this.Controls.Add(this.groupBox4);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.btnIngresar);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Form_IngresarAeronave";
            this.Text = "Form_IngresarAeronave";
            this.Load += new System.EventHandler(this.Form_IngresarAeronave_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.fABRICANTESAEROBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSetFabricantes)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.mODELOSAEROBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSetModelos)).EndInit();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private MetroFramework.Controls.MetroLabel metroLabel1;
        private System.Windows.Forms.GroupBox groupBox1;
        private MetroFramework.Controls.MetroRadioButton chkHelicoptero;
        private MetroFramework.Controls.MetroRadioButton chkAvion;
        private System.Windows.Forms.GroupBox groupBox2;
        private MetroFramework.Controls.MetroTextBox txtMatricula;
        private MetroFramework.Controls.MetroLabel metroLabel2;
        private MetroFramework.Controls.MetroTextBox txtAnnioFab;
        private MetroFramework.Controls.MetroLabel metroLabel5;
        private MetroFramework.Controls.MetroDateTime txtFechaInspeccion;
        private MetroFramework.Controls.MetroLabel metroLabel4;
        private MetroFramework.Controls.MetroTextBox txtCantMaxHoras;
        private MetroFramework.Controls.MetroLabel metroLabel3;
        private MetroFramework.Controls.MetroButton btnIngresar;
        private System.Windows.Forms.GroupBox groupBox3;
        private MetroFramework.Controls.MetroTextBox txtCantHelices;
        private MetroFramework.Controls.MetroLabel metroLabel9;
        private System.Windows.Forms.GroupBox groupBox4;
        private MetroFramework.Controls.MetroTextBox txtCantTurbinas;
        private MetroFramework.Controls.MetroLabel metroLabel6;
        private MetroFramework.Controls.MetroTextBox txtCantRuedas;
        private MetroFramework.Controls.MetroLabel metroLabel11;
        private MetroFramework.Controls.MetroTextBox txtMotor;
        private MetroFramework.Controls.MetroLabel metroLabel10;
        private MetroFramework.Controls.MetroTextBox txtLitros;
        private MetroFramework.Controls.MetroLabel metroLabel8;
        private MetroFramework.Controls.MetroTextBox txtCantMaxPilotos;
        private MetroFramework.Controls.MetroLabel metroLabel7;
        private MetroFramework.Controls.MetroLabel metroLabel13;
        private MetroFramework.Controls.MetroComboBox cboFabricante;
        private MetroFramework.Controls.MetroLabel metroLabel12;
        private MetroFramework.Controls.MetroComboBox cboModelo;
        private DataSetModelos dataSetModelos;
        private System.Windows.Forms.BindingSource mODELOSAEROBindingSource;
        private DataSetModelosTableAdapters.MODELOS_AEROTableAdapter mODELOS_AEROTableAdapter;
        private DataSetFabricantes dataSetFabricantes;
        private System.Windows.Forms.BindingSource fABRICANTESAEROBindingSource;
        private DataSetFabricantesTableAdapters.FABRICANTES_AEROTableAdapter fABRICANTES_AEROTableAdapter;
    }
}
namespace CapaPresentacion
{
    partial class Form_ModificarVuelo
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form_ModificarVuelo));
            this.btnModificar = new MetroFramework.Controls.MetroButton();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.txtMision = new MetroFramework.Controls.MetroTextBox();
            this.txtHorasVuelo = new MetroFramework.Controls.MetroTextBox();
            this.txtFechaHora = new MetroFramework.Controls.MetroDateTime();
            this.metroLabel5 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel4 = new MetroFramework.Controls.MetroLabel();
            this.label3 = new System.Windows.Forms.Label();
            this.cboCondicion = new MetroFramework.Controls.MetroComboBox();
            this.cONDICIONBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dataSetCondicion = new CapaPresentacion.DataSetCondicion();
            this.label2 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.metroLabel8 = new MetroFramework.Controls.MetroLabel();
            this.imgCopilotoNV = new System.Windows.Forms.PictureBox();
            this.imgPilotoNV = new System.Windows.Forms.PictureBox();
            this.imgCopilotoV = new System.Windows.Forms.PictureBox();
            this.imgPilotoV = new System.Windows.Forms.PictureBox();
            this.txtLicCopiloto = new MetroFramework.Controls.MetroTextBox();
            this.txtLicPiloto = new MetroFramework.Controls.MetroTextBox();
            this.metroLink2 = new MetroFramework.Controls.MetroLink();
            this.metroLink1 = new MetroFramework.Controls.MetroLink();
            this.cboCopiloto = new MetroFramework.Controls.MetroComboBox();
            this.pILOTOSBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.dataSetPilotos = new CapaPresentacion.DataSetPilotos();
            this.cboPiloto = new MetroFramework.Controls.MetroComboBox();
            this.pILOTOSBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.metroLabel3 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel2 = new MetroFramework.Controls.MetroLabel();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.btnBuscar = new MetroFramework.Controls.MetroButton();
            this.txtNumVuelo = new MetroFramework.Controls.MetroTextBox();
            this.metroLabel6 = new MetroFramework.Controls.MetroLabel();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.metroLabel1 = new MetroFramework.Controls.MetroLabel();
            this.chkCopiloto = new MetroFramework.Controls.MetroCheckBox();
            this.groupBox5 = new System.Windows.Forms.GroupBox();
            this.cboAeronave = new MetroFramework.Controls.MetroComboBox();
            this.aERONAVESBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dataSetAeronaves = new CapaPresentacion.DataSetAeronaves();
            this.metroLabel7 = new MetroFramework.Controls.MetroLabel();
            this.aERONAVESTableAdapter = new CapaPresentacion.DataSetAeronavesTableAdapters.AERONAVESTableAdapter();
            this.pILOTOSTableAdapter = new CapaPresentacion.DataSetPilotosTableAdapters.PILOTOSTableAdapter();
            this.cONDICIONTableAdapter = new CapaPresentacion.DataSetCondicionTableAdapters.CONDICIONTableAdapter();
            this.groupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.cONDICIONBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSetCondicion)).BeginInit();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.imgCopilotoNV)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.imgPilotoNV)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.imgCopilotoV)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.imgPilotoV)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pILOTOSBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSetPilotos)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pILOTOSBindingSource)).BeginInit();
            this.groupBox4.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.groupBox5.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.aERONAVESBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSetAeronaves)).BeginInit();
            this.SuspendLayout();
            // 
            // btnModificar
            // 
            this.btnModificar.Location = new System.Drawing.Point(43, 620);
            this.btnModificar.Name = "btnModificar";
            this.btnModificar.Size = new System.Drawing.Size(149, 38);
            this.btnModificar.TabIndex = 83;
            this.btnModificar.Text = "Modificar Vuelo";
            this.btnModificar.UseSelectable = true;
            this.btnModificar.Click += new System.EventHandler(this.metroButton1_Click);
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.txtMision);
            this.groupBox3.Controls.Add(this.txtHorasVuelo);
            this.groupBox3.Controls.Add(this.txtFechaHora);
            this.groupBox3.Controls.Add(this.metroLabel5);
            this.groupBox3.Controls.Add(this.metroLabel4);
            this.groupBox3.Controls.Add(this.label3);
            this.groupBox3.Controls.Add(this.cboCondicion);
            this.groupBox3.Controls.Add(this.label2);
            this.groupBox3.Location = new System.Drawing.Point(43, 342);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(537, 272);
            this.groupBox3.TabIndex = 82;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Datos Vuelo";
            this.groupBox3.Enter += new System.EventHandler(this.groupBox3_Enter);
            // 
            // txtMision
            // 
            this.txtMision.BackColor = System.Drawing.Color.White;
            // 
            // 
            // 
            this.txtMision.CustomButton.Image = null;
            this.txtMision.CustomButton.Location = new System.Drawing.Point(154, 2);
            this.txtMision.CustomButton.Name = "";
            this.txtMision.CustomButton.Size = new System.Drawing.Size(87, 87);
            this.txtMision.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txtMision.CustomButton.TabIndex = 1;
            this.txtMision.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txtMision.CustomButton.UseSelectable = true;
            this.txtMision.CustomButton.Visible = false;
            this.txtMision.Lines = new string[0];
            this.txtMision.Location = new System.Drawing.Point(205, 170);
            this.txtMision.MaxLength = 32767;
            this.txtMision.Multiline = true;
            this.txtMision.Name = "txtMision";
            this.txtMision.PasswordChar = '\0';
            this.txtMision.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtMision.SelectedText = "";
            this.txtMision.SelectionLength = 0;
            this.txtMision.SelectionStart = 0;
            this.txtMision.ShortcutsEnabled = true;
            this.txtMision.Size = new System.Drawing.Size(244, 92);
            this.txtMision.Style = MetroFramework.MetroColorStyle.Orange;
            this.txtMision.TabIndex = 54;
            this.txtMision.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txtMision.UseSelectable = true;
            this.txtMision.UseStyleColors = true;
            this.txtMision.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txtMision.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // txtHorasVuelo
            // 
            this.txtHorasVuelo.BackColor = System.Drawing.Color.White;
            // 
            // 
            // 
            this.txtHorasVuelo.CustomButton.Image = null;
            this.txtHorasVuelo.CustomButton.Location = new System.Drawing.Point(66, 2);
            this.txtHorasVuelo.CustomButton.Name = "";
            this.txtHorasVuelo.CustomButton.Size = new System.Drawing.Size(27, 27);
            this.txtHorasVuelo.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txtHorasVuelo.CustomButton.TabIndex = 1;
            this.txtHorasVuelo.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txtHorasVuelo.CustomButton.UseSelectable = true;
            this.txtHorasVuelo.CustomButton.Visible = false;
            this.txtHorasVuelo.Lines = new string[0];
            this.txtHorasVuelo.Location = new System.Drawing.Point(205, 67);
            this.txtHorasVuelo.MaxLength = 32767;
            this.txtHorasVuelo.Name = "txtHorasVuelo";
            this.txtHorasVuelo.PasswordChar = '\0';
            this.txtHorasVuelo.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtHorasVuelo.SelectedText = "";
            this.txtHorasVuelo.SelectionLength = 0;
            this.txtHorasVuelo.SelectionStart = 0;
            this.txtHorasVuelo.ShortcutsEnabled = true;
            this.txtHorasVuelo.Size = new System.Drawing.Size(96, 32);
            this.txtHorasVuelo.Style = MetroFramework.MetroColorStyle.Orange;
            this.txtHorasVuelo.TabIndex = 53;
            this.txtHorasVuelo.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txtHorasVuelo.UseSelectable = true;
            this.txtHorasVuelo.UseStyleColors = true;
            this.txtHorasVuelo.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txtHorasVuelo.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            this.txtHorasVuelo.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtHorasVuelo_KeyPress);
            // 
            // txtFechaHora
            // 
            this.txtFechaHora.DisplayFocus = true;
            this.txtFechaHora.Location = new System.Drawing.Point(205, 118);
            this.txtFechaHora.MinimumSize = new System.Drawing.Size(0, 30);
            this.txtFechaHora.Name = "txtFechaHora";
            this.txtFechaHora.Size = new System.Drawing.Size(315, 30);
            this.txtFechaHora.Style = MetroFramework.MetroColorStyle.Orange;
            this.txtFechaHora.TabIndex = 14;
            this.txtFechaHora.UseCustomBackColor = true;
            this.txtFechaHora.UseCustomForeColor = true;
            this.txtFechaHora.UseStyleColors = true;
            // 
            // metroLabel5
            // 
            this.metroLabel5.AutoSize = true;
            this.metroLabel5.Location = new System.Drawing.Point(20, 128);
            this.metroLabel5.Name = "metroLabel5";
            this.metroLabel5.Size = new System.Drawing.Size(93, 20);
            this.metroLabel5.TabIndex = 13;
            this.metroLabel5.Text = "Fecha - Hora:";
            // 
            // metroLabel4
            // 
            this.metroLabel4.AutoSize = true;
            this.metroLabel4.Location = new System.Drawing.Point(20, 182);
            this.metroLabel4.Name = "metroLabel4";
            this.metroLabel4.Size = new System.Drawing.Size(52, 20);
            this.metroLabel4.TabIndex = 11;
            this.metroLabel4.Text = "Misión:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(17, 82);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(108, 17);
            this.label3.TabIndex = 9;
            this.label3.Text = "Horas de vuelo:";
            // 
            // cboCondicion
            // 
            this.cboCondicion.DataSource = this.cONDICIONBindingSource;
            this.cboCondicion.DisplayFocus = true;
            this.cboCondicion.DisplayMember = "desc";
            this.cboCondicion.FormattingEnabled = true;
            this.cboCondicion.ItemHeight = 24;
            this.cboCondicion.Location = new System.Drawing.Point(205, 21);
            this.cboCondicion.Name = "cboCondicion";
            this.cboCondicion.Size = new System.Drawing.Size(121, 30);
            this.cboCondicion.Style = MetroFramework.MetroColorStyle.Orange;
            this.cboCondicion.TabIndex = 8;
            this.cboCondicion.UseCustomBackColor = true;
            this.cboCondicion.UseCustomForeColor = true;
            this.cboCondicion.UseSelectable = true;
            this.cboCondicion.UseStyleColors = true;
            this.cboCondicion.ValueMember = "IDCONDICION_VUELO";
            // 
            // cONDICIONBindingSource
            // 
            this.cONDICIONBindingSource.DataMember = "CONDICION";
            this.cONDICIONBindingSource.DataSource = this.dataSetCondicion;
            // 
            // dataSetCondicion
            // 
            this.dataSetCondicion.DataSetName = "DataSetCondicion";
            this.dataSetCondicion.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(17, 34);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(132, 17);
            this.label2.TabIndex = 0;
            this.label2.Text = "Condición de vuelo:";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.metroLabel8);
            this.groupBox2.Controls.Add(this.imgCopilotoNV);
            this.groupBox2.Controls.Add(this.imgPilotoNV);
            this.groupBox2.Controls.Add(this.imgCopilotoV);
            this.groupBox2.Controls.Add(this.imgPilotoV);
            this.groupBox2.Controls.Add(this.txtLicCopiloto);
            this.groupBox2.Controls.Add(this.txtLicPiloto);
            this.groupBox2.Controls.Add(this.metroLink2);
            this.groupBox2.Controls.Add(this.metroLink1);
            this.groupBox2.Controls.Add(this.cboCopiloto);
            this.groupBox2.Controls.Add(this.cboPiloto);
            this.groupBox2.Controls.Add(this.metroLabel3);
            this.groupBox2.Controls.Add(this.metroLabel2);
            this.groupBox2.Location = new System.Drawing.Point(43, 194);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(677, 142);
            this.groupBox2.TabIndex = 81;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Tripulación";
            // 
            // metroLabel8
            // 
            this.metroLabel8.AutoSize = true;
            this.metroLabel8.Location = new System.Drawing.Point(334, 18);
            this.metroLabel8.Name = "metroLabel8";
            this.metroLabel8.Size = new System.Drawing.Size(68, 20);
            this.metroLabel8.TabIndex = 64;
            this.metroLabel8.Text = "Licencias:";
            // 
            // imgCopilotoNV
            // 
            this.imgCopilotoNV.Image = ((System.Drawing.Image)(resources.GetObject("imgCopilotoNV.Image")));
            this.imgCopilotoNV.Location = new System.Drawing.Point(607, 96);
            this.imgCopilotoNV.Name = "imgCopilotoNV";
            this.imgCopilotoNV.Size = new System.Drawing.Size(33, 33);
            this.imgCopilotoNV.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.imgCopilotoNV.TabIndex = 63;
            this.imgCopilotoNV.TabStop = false;
            this.imgCopilotoNV.Visible = false;
            // 
            // imgPilotoNV
            // 
            this.imgPilotoNV.Image = ((System.Drawing.Image)(resources.GetObject("imgPilotoNV.Image")));
            this.imgPilotoNV.Location = new System.Drawing.Point(607, 52);
            this.imgPilotoNV.Name = "imgPilotoNV";
            this.imgPilotoNV.Size = new System.Drawing.Size(33, 33);
            this.imgPilotoNV.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.imgPilotoNV.TabIndex = 62;
            this.imgPilotoNV.TabStop = false;
            this.imgPilotoNV.Visible = false;
            // 
            // imgCopilotoV
            // 
            this.imgCopilotoV.Image = ((System.Drawing.Image)(resources.GetObject("imgCopilotoV.Image")));
            this.imgCopilotoV.Location = new System.Drawing.Point(607, 96);
            this.imgCopilotoV.Name = "imgCopilotoV";
            this.imgCopilotoV.Size = new System.Drawing.Size(34, 33);
            this.imgCopilotoV.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.imgCopilotoV.TabIndex = 61;
            this.imgCopilotoV.TabStop = false;
            this.imgCopilotoV.Visible = false;
            // 
            // imgPilotoV
            // 
            this.imgPilotoV.Image = ((System.Drawing.Image)(resources.GetObject("imgPilotoV.Image")));
            this.imgPilotoV.Location = new System.Drawing.Point(607, 50);
            this.imgPilotoV.Name = "imgPilotoV";
            this.imgPilotoV.Size = new System.Drawing.Size(34, 33);
            this.imgPilotoV.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.imgPilotoV.TabIndex = 60;
            this.imgPilotoV.TabStop = false;
            this.imgPilotoV.Visible = false;
            // 
            // txtLicCopiloto
            // 
            this.txtLicCopiloto.BackColor = System.Drawing.Color.White;
            // 
            // 
            // 
            this.txtLicCopiloto.CustomButton.Image = null;
            this.txtLicCopiloto.CustomButton.Location = new System.Drawing.Point(88, 2);
            this.txtLicCopiloto.CustomButton.Name = "";
            this.txtLicCopiloto.CustomButton.Size = new System.Drawing.Size(27, 27);
            this.txtLicCopiloto.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txtLicCopiloto.CustomButton.TabIndex = 1;
            this.txtLicCopiloto.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txtLicCopiloto.CustomButton.UseSelectable = true;
            this.txtLicCopiloto.CustomButton.Visible = false;
            this.txtLicCopiloto.Lines = new string[0];
            this.txtLicCopiloto.Location = new System.Drawing.Point(314, 96);
            this.txtLicCopiloto.MaxLength = 32767;
            this.txtLicCopiloto.Name = "txtLicCopiloto";
            this.txtLicCopiloto.PasswordChar = '\0';
            this.txtLicCopiloto.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtLicCopiloto.SelectedText = "";
            this.txtLicCopiloto.SelectionLength = 0;
            this.txtLicCopiloto.SelectionStart = 0;
            this.txtLicCopiloto.ShortcutsEnabled = true;
            this.txtLicCopiloto.Size = new System.Drawing.Size(118, 32);
            this.txtLicCopiloto.Style = MetroFramework.MetroColorStyle.Orange;
            this.txtLicCopiloto.TabIndex = 57;
            this.txtLicCopiloto.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txtLicCopiloto.UseSelectable = true;
            this.txtLicCopiloto.UseStyleColors = true;
            this.txtLicCopiloto.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txtLicCopiloto.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // txtLicPiloto
            // 
            this.txtLicPiloto.BackColor = System.Drawing.Color.White;
            // 
            // 
            // 
            this.txtLicPiloto.CustomButton.Image = null;
            this.txtLicPiloto.CustomButton.Location = new System.Drawing.Point(88, 2);
            this.txtLicPiloto.CustomButton.Name = "";
            this.txtLicPiloto.CustomButton.Size = new System.Drawing.Size(27, 27);
            this.txtLicPiloto.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txtLicPiloto.CustomButton.TabIndex = 1;
            this.txtLicPiloto.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txtLicPiloto.CustomButton.UseSelectable = true;
            this.txtLicPiloto.CustomButton.Visible = false;
            this.txtLicPiloto.Lines = new string[0];
            this.txtLicPiloto.Location = new System.Drawing.Point(314, 52);
            this.txtLicPiloto.MaxLength = 32767;
            this.txtLicPiloto.Name = "txtLicPiloto";
            this.txtLicPiloto.PasswordChar = '\0';
            this.txtLicPiloto.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtLicPiloto.SelectedText = "";
            this.txtLicPiloto.SelectionLength = 0;
            this.txtLicPiloto.SelectionStart = 0;
            this.txtLicPiloto.ShortcutsEnabled = true;
            this.txtLicPiloto.Size = new System.Drawing.Size(118, 32);
            this.txtLicPiloto.Style = MetroFramework.MetroColorStyle.Orange;
            this.txtLicPiloto.TabIndex = 56;
            this.txtLicPiloto.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txtLicPiloto.UseSelectable = true;
            this.txtLicPiloto.UseStyleColors = true;
            this.txtLicPiloto.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txtLicPiloto.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // metroLink2
            // 
            this.metroLink2.DisplayFocus = true;
            this.metroLink2.Location = new System.Drawing.Point(438, 96);
            this.metroLink2.Name = "metroLink2";
            this.metroLink2.Size = new System.Drawing.Size(163, 28);
            this.metroLink2.Style = MetroFramework.MetroColorStyle.Orange;
            this.metroLink2.TabIndex = 7;
            this.metroLink2.Text = "Consultar Licencia";
            this.metroLink2.UseCustomBackColor = true;
            this.metroLink2.UseCustomForeColor = true;
            this.metroLink2.UseSelectable = true;
            this.metroLink2.UseStyleColors = true;
            this.metroLink2.Click += new System.EventHandler(this.metroLink2_Click);
            // 
            // metroLink1
            // 
            this.metroLink1.DisplayFocus = true;
            this.metroLink1.Location = new System.Drawing.Point(438, 52);
            this.metroLink1.Name = "metroLink1";
            this.metroLink1.Size = new System.Drawing.Size(163, 28);
            this.metroLink1.Style = MetroFramework.MetroColorStyle.Orange;
            this.metroLink1.TabIndex = 6;
            this.metroLink1.Text = "Consultar Licencia";
            this.metroLink1.UseCustomBackColor = true;
            this.metroLink1.UseCustomForeColor = true;
            this.metroLink1.UseSelectable = true;
            this.metroLink1.UseStyleColors = true;
            this.metroLink1.Click += new System.EventHandler(this.metroLink1_Click);
            // 
            // cboCopiloto
            // 
            this.cboCopiloto.DataSource = this.pILOTOSBindingSource1;
            this.cboCopiloto.DisplayFocus = true;
            this.cboCopiloto.DisplayMember = "RUT";
            this.cboCopiloto.FormattingEnabled = true;
            this.cboCopiloto.ItemHeight = 24;
            this.cboCopiloto.Location = new System.Drawing.Point(146, 96);
            this.cboCopiloto.Name = "cboCopiloto";
            this.cboCopiloto.Size = new System.Drawing.Size(121, 30);
            this.cboCopiloto.Style = MetroFramework.MetroColorStyle.Orange;
            this.cboCopiloto.TabIndex = 5;
            this.cboCopiloto.UseCustomBackColor = true;
            this.cboCopiloto.UseCustomForeColor = true;
            this.cboCopiloto.UseSelectable = true;
            this.cboCopiloto.UseStyleColors = true;
            this.cboCopiloto.ValueMember = "IDUSUARIO";
            // 
            // pILOTOSBindingSource1
            // 
            this.pILOTOSBindingSource1.DataMember = "PILOTOS";
            this.pILOTOSBindingSource1.DataSource = this.dataSetPilotos;
            // 
            // dataSetPilotos
            // 
            this.dataSetPilotos.DataSetName = "DataSetPilotos";
            this.dataSetPilotos.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // cboPiloto
            // 
            this.cboPiloto.DataSource = this.pILOTOSBindingSource;
            this.cboPiloto.DisplayFocus = true;
            this.cboPiloto.DisplayMember = "RUT";
            this.cboPiloto.FormattingEnabled = true;
            this.cboPiloto.ItemHeight = 24;
            this.cboPiloto.Location = new System.Drawing.Point(146, 50);
            this.cboPiloto.Name = "cboPiloto";
            this.cboPiloto.Size = new System.Drawing.Size(121, 30);
            this.cboPiloto.Style = MetroFramework.MetroColorStyle.Orange;
            this.cboPiloto.TabIndex = 4;
            this.cboPiloto.UseCustomBackColor = true;
            this.cboPiloto.UseCustomForeColor = true;
            this.cboPiloto.UseSelectable = true;
            this.cboPiloto.UseStyleColors = true;
            this.cboPiloto.ValueMember = "IDUSUARIO";
            // 
            // pILOTOSBindingSource
            // 
            this.pILOTOSBindingSource.DataMember = "PILOTOS";
            this.pILOTOSBindingSource.DataSource = this.dataSetPilotos;
            // 
            // metroLabel3
            // 
            this.metroLabel3.AutoSize = true;
            this.metroLabel3.Location = new System.Drawing.Point(20, 96);
            this.metroLabel3.Name = "metroLabel3";
            this.metroLabel3.Size = new System.Drawing.Size(63, 20);
            this.metroLabel3.TabIndex = 3;
            this.metroLabel3.Text = "Copiloto:";
            // 
            // metroLabel2
            // 
            this.metroLabel2.AutoSize = true;
            this.metroLabel2.Location = new System.Drawing.Point(20, 56);
            this.metroLabel2.Name = "metroLabel2";
            this.metroLabel2.Size = new System.Drawing.Size(46, 20);
            this.metroLabel2.TabIndex = 2;
            this.metroLabel2.Text = "Piloto:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(221, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(241, 38);
            this.label1.TabIndex = 79;
            this.label1.Text = "Modificar Vuelo";
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.btnBuscar);
            this.groupBox4.Controls.Add(this.txtNumVuelo);
            this.groupBox4.Controls.Add(this.metroLabel6);
            this.groupBox4.Location = new System.Drawing.Point(43, 50);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(677, 66);
            this.groupBox4.TabIndex = 81;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Búsqueda";
            // 
            // btnBuscar
            // 
            this.btnBuscar.Location = new System.Drawing.Point(334, 21);
            this.btnBuscar.Name = "btnBuscar";
            this.btnBuscar.Size = new System.Drawing.Size(111, 32);
            this.btnBuscar.TabIndex = 84;
            this.btnBuscar.Text = "Buscar";
            this.btnBuscar.UseSelectable = true;
            this.btnBuscar.Click += new System.EventHandler(this.metroButton2_Click);
            // 
            // txtNumVuelo
            // 
            this.txtNumVuelo.BackColor = System.Drawing.Color.White;
            // 
            // 
            // 
            this.txtNumVuelo.CustomButton.Image = null;
            this.txtNumVuelo.CustomButton.Location = new System.Drawing.Point(66, 2);
            this.txtNumVuelo.CustomButton.Name = "";
            this.txtNumVuelo.CustomButton.Size = new System.Drawing.Size(27, 27);
            this.txtNumVuelo.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txtNumVuelo.CustomButton.TabIndex = 1;
            this.txtNumVuelo.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txtNumVuelo.CustomButton.UseSelectable = true;
            this.txtNumVuelo.CustomButton.Visible = false;
            this.txtNumVuelo.Lines = new string[0];
            this.txtNumVuelo.Location = new System.Drawing.Point(205, 21);
            this.txtNumVuelo.MaxLength = 32767;
            this.txtNumVuelo.Name = "txtNumVuelo";
            this.txtNumVuelo.PasswordChar = '\0';
            this.txtNumVuelo.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtNumVuelo.SelectedText = "";
            this.txtNumVuelo.SelectionLength = 0;
            this.txtNumVuelo.SelectionStart = 0;
            this.txtNumVuelo.ShortcutsEnabled = true;
            this.txtNumVuelo.Size = new System.Drawing.Size(96, 32);
            this.txtNumVuelo.Style = MetroFramework.MetroColorStyle.Orange;
            this.txtNumVuelo.TabIndex = 54;
            this.txtNumVuelo.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txtNumVuelo.UseSelectable = true;
            this.txtNumVuelo.UseStyleColors = true;
            this.txtNumVuelo.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txtNumVuelo.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            this.txtNumVuelo.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtNumVuelo_KeyPress);
            // 
            // metroLabel6
            // 
            this.metroLabel6.AutoSize = true;
            this.metroLabel6.Location = new System.Drawing.Point(20, 29);
            this.metroLabel6.Name = "metroLabel6";
            this.metroLabel6.Size = new System.Drawing.Size(122, 20);
            this.metroLabel6.TabIndex = 2;
            this.metroLabel6.Text = "Número de vuelo:";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.metroLabel1);
            this.groupBox1.Controls.Add(this.chkCopiloto);
            this.groupBox1.Location = new System.Drawing.Point(43, 122);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(267, 66);
            this.groupBox1.TabIndex = 84;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Encargados";
            // 
            // metroLabel1
            // 
            this.metroLabel1.AutoSize = true;
            this.metroLabel1.Location = new System.Drawing.Point(20, 21);
            this.metroLabel1.Name = "metroLabel1";
            this.metroLabel1.Size = new System.Drawing.Size(79, 20);
            this.metroLabel1.TabIndex = 2;
            this.metroLabel1.Text = "Seleccione:";
            // 
            // chkCopiloto
            // 
            this.chkCopiloto.AutoSize = true;
            this.chkCopiloto.DisplayFocus = true;
            this.chkCopiloto.Location = new System.Drawing.Point(128, 24);
            this.chkCopiloto.Name = "chkCopiloto";
            this.chkCopiloto.Size = new System.Drawing.Size(113, 17);
            this.chkCopiloto.Style = MetroFramework.MetroColorStyle.Orange;
            this.chkCopiloto.TabIndex = 1;
            this.chkCopiloto.Text = "Posee Copiloto";
            this.chkCopiloto.UseCustomBackColor = true;
            this.chkCopiloto.UseCustomForeColor = true;
            this.chkCopiloto.UseSelectable = true;
            this.chkCopiloto.UseStyleColors = true;
            this.chkCopiloto.CheckedChanged += new System.EventHandler(this.chkCopiloto_CheckedChanged);
            // 
            // groupBox5
            // 
            this.groupBox5.Controls.Add(this.cboAeronave);
            this.groupBox5.Controls.Add(this.metroLabel7);
            this.groupBox5.Location = new System.Drawing.Point(325, 124);
            this.groupBox5.Name = "groupBox5";
            this.groupBox5.Size = new System.Drawing.Size(395, 64);
            this.groupBox5.TabIndex = 85;
            this.groupBox5.TabStop = false;
            this.groupBox5.Text = "Aeronave";
            // 
            // cboAeronave
            // 
            this.cboAeronave.DataSource = this.aERONAVESBindingSource;
            this.cboAeronave.DisplayFocus = true;
            this.cboAeronave.DisplayMember = "PATENTE";
            this.cboAeronave.FormattingEnabled = true;
            this.cboAeronave.ItemHeight = 24;
            this.cboAeronave.Location = new System.Drawing.Point(207, 19);
            this.cboAeronave.Name = "cboAeronave";
            this.cboAeronave.Size = new System.Drawing.Size(121, 30);
            this.cboAeronave.Style = MetroFramework.MetroColorStyle.Orange;
            this.cboAeronave.TabIndex = 4;
            this.cboAeronave.UseCustomBackColor = true;
            this.cboAeronave.UseCustomForeColor = true;
            this.cboAeronave.UseSelectable = true;
            this.cboAeronave.UseStyleColors = true;
            this.cboAeronave.ValueMember = "IDAERONAVE";
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
            // metroLabel7
            // 
            this.metroLabel7.AutoSize = true;
            this.metroLabel7.Location = new System.Drawing.Point(20, 24);
            this.metroLabel7.Name = "metroLabel7";
            this.metroLabel7.Size = new System.Drawing.Size(143, 20);
            this.metroLabel7.TabIndex = 2;
            this.metroLabel7.Text = "Seleccione Aeronave:";
            // 
            // aERONAVESTableAdapter
            // 
            this.aERONAVESTableAdapter.ClearBeforeFill = true;
            // 
            // pILOTOSTableAdapter
            // 
            this.pILOTOSTableAdapter.ClearBeforeFill = true;
            // 
            // cONDICIONTableAdapter
            // 
            this.cONDICIONTableAdapter.ClearBeforeFill = true;
            // 
            // Form_ModificarVuelo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(754, 668);
            this.Controls.Add(this.groupBox5);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.groupBox4);
            this.Controls.Add(this.btnModificar);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Form_ModificarVuelo";
            this.Text = "Form_ModificarVuelo";
            this.Load += new System.EventHandler(this.Form_ModificarVuelo_Load);
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.cONDICIONBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSetCondicion)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.imgCopilotoNV)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.imgPilotoNV)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.imgCopilotoV)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.imgPilotoV)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pILOTOSBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSetPilotos)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pILOTOSBindingSource)).EndInit();
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox5.ResumeLayout(false);
            this.groupBox5.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.aERONAVESBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSetAeronaves)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private MetroFramework.Controls.MetroButton btnModificar;
        private System.Windows.Forms.GroupBox groupBox3;
        private MetroFramework.Controls.MetroTextBox txtMision;
        private MetroFramework.Controls.MetroTextBox txtHorasVuelo;
        private MetroFramework.Controls.MetroDateTime txtFechaHora;
        private MetroFramework.Controls.MetroLabel metroLabel5;
        private MetroFramework.Controls.MetroLabel metroLabel4;
        private System.Windows.Forms.Label label3;
        private MetroFramework.Controls.MetroComboBox cboCondicion;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.GroupBox groupBox2;
        private MetroFramework.Controls.MetroLink metroLink2;
        private MetroFramework.Controls.MetroLink metroLink1;
        private MetroFramework.Controls.MetroComboBox cboCopiloto;
        private MetroFramework.Controls.MetroComboBox cboPiloto;
        private MetroFramework.Controls.MetroLabel metroLabel3;
        private MetroFramework.Controls.MetroLabel metroLabel2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox4;
        private MetroFramework.Controls.MetroButton btnBuscar;
        private MetroFramework.Controls.MetroTextBox txtNumVuelo;
        private MetroFramework.Controls.MetroLabel metroLabel6;
        private System.Windows.Forms.GroupBox groupBox1;
        private MetroFramework.Controls.MetroLabel metroLabel1;
        private MetroFramework.Controls.MetroCheckBox chkCopiloto;
        private System.Windows.Forms.GroupBox groupBox5;
        private MetroFramework.Controls.MetroComboBox cboAeronave;
        private MetroFramework.Controls.MetroLabel metroLabel7;
        private DataSetAeronaves dataSetAeronaves;
        private System.Windows.Forms.BindingSource aERONAVESBindingSource;
        private DataSetAeronavesTableAdapters.AERONAVESTableAdapter aERONAVESTableAdapter;
        private DataSetPilotos dataSetPilotos;
        private System.Windows.Forms.BindingSource pILOTOSBindingSource;
        private DataSetPilotosTableAdapters.PILOTOSTableAdapter pILOTOSTableAdapter;
        private System.Windows.Forms.BindingSource pILOTOSBindingSource1;
        private DataSetCondicion dataSetCondicion;
        private System.Windows.Forms.BindingSource cONDICIONBindingSource;
        private DataSetCondicionTableAdapters.CONDICIONTableAdapter cONDICIONTableAdapter;
        private MetroFramework.Controls.MetroTextBox txtLicCopiloto;
        private MetroFramework.Controls.MetroTextBox txtLicPiloto;
        private System.Windows.Forms.PictureBox imgCopilotoV;
        private System.Windows.Forms.PictureBox imgPilotoV;
        private System.Windows.Forms.PictureBox imgCopilotoNV;
        private System.Windows.Forms.PictureBox imgPilotoNV;
        private MetroFramework.Controls.MetroLabel metroLabel8;
    }
}
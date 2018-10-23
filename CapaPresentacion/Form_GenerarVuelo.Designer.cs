namespace CapaPresentacion
{
    partial class Form_GenerarVuelo
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form_GenerarVuelo));
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.metroLabel1 = new MetroFramework.Controls.MetroLabel();
            this.chkCopiloto = new MetroFramework.Controls.MetroCheckBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.imgCopilotoV = new System.Windows.Forms.PictureBox();
            this.imgPilotoV = new System.Windows.Forms.PictureBox();
            this.imgCopilotoNV = new System.Windows.Forms.PictureBox();
            this.imgPilotoNV = new System.Windows.Forms.PictureBox();
            this.txtRutCopiloto = new MetroFramework.Controls.MetroTextBox();
            this.txtRutPiloto = new MetroFramework.Controls.MetroTextBox();
            this.linkLicenciaCopiloto = new MetroFramework.Controls.MetroLink();
            this.linkLicenciaPiloto = new MetroFramework.Controls.MetroLink();
            this.metroLabel3 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel2 = new MetroFramework.Controls.MetroLabel();
            this.pILOTOSBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.dataSetPilotos = new CapaPresentacion.DataSetPilotos();
            this.pILOTOSBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.txtMision = new MetroFramework.Controls.MetroTextBox();
            this.txtHorasEstimadas = new MetroFramework.Controls.MetroTextBox();
            this.txtFechaHora = new MetroFramework.Controls.MetroDateTime();
            this.metroLabel5 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel4 = new MetroFramework.Controls.MetroLabel();
            this.label3 = new System.Windows.Forms.Label();
            this.cboCondicion = new MetroFramework.Controls.MetroComboBox();
            this.cONDICIONBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dataSetCondicion = new CapaPresentacion.DataSetCondicion();
            this.label2 = new System.Windows.Forms.Label();
            this.btbGenerar = new MetroFramework.Controls.MetroButton();
            this.pILOTOSTableAdapter = new CapaPresentacion.DataSetPilotosTableAdapters.PILOTOSTableAdapter();
            this.cONDICIONTableAdapter = new CapaPresentacion.DataSetCondicionTableAdapters.CONDICIONTableAdapter();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.cboAeronave = new MetroFramework.Controls.MetroComboBox();
            this.aERONAVESBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dataSetAeronaves = new CapaPresentacion.DataSetAeronaves();
            this.metroLabel7 = new MetroFramework.Controls.MetroLabel();
            this.aERONAVESTableAdapter = new CapaPresentacion.DataSetAeronavesTableAdapters.AERONAVESTableAdapter();
            this.groupBox5 = new System.Windows.Forms.GroupBox();
            this.lblMensaje = new MetroFramework.Controls.MetroLabel();
            this.imagenError = new System.Windows.Forms.PictureBox();
            this.imagenAlerta = new System.Windows.Forms.PictureBox();
            this.imagenExito = new System.Windows.Forms.PictureBox();
            this.metroLabel8 = new MetroFramework.Controls.MetroLabel();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.imgCopilotoV)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.imgPilotoV)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.imgCopilotoNV)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.imgPilotoNV)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pILOTOSBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSetPilotos)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pILOTOSBindingSource)).BeginInit();
            this.groupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.cONDICIONBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSetCondicion)).BeginInit();
            this.groupBox4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.aERONAVESBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSetAeronaves)).BeginInit();
            this.groupBox5.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.imagenError)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.imagenAlerta)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.imagenExito)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(276, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(229, 38);
            this.label1.TabIndex = 74;
            this.label1.Text = "Generar Vuelo";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.metroLabel1);
            this.groupBox1.Controls.Add(this.chkCopiloto);
            this.groupBox1.Location = new System.Drawing.Point(51, 60);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(300, 60);
            this.groupBox1.TabIndex = 75;
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
            this.chkCopiloto.Location = new System.Drawing.Point(142, 24);
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
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.imgCopilotoV);
            this.groupBox2.Controls.Add(this.imgPilotoV);
            this.groupBox2.Controls.Add(this.imgCopilotoNV);
            this.groupBox2.Controls.Add(this.imgPilotoNV);
            this.groupBox2.Controls.Add(this.txtRutCopiloto);
            this.groupBox2.Controls.Add(this.txtRutPiloto);
            this.groupBox2.Controls.Add(this.linkLicenciaCopiloto);
            this.groupBox2.Controls.Add(this.linkLicenciaPiloto);
            this.groupBox2.Controls.Add(this.metroLabel3);
            this.groupBox2.Controls.Add(this.metroLabel2);
            this.groupBox2.Location = new System.Drawing.Point(51, 214);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(675, 140);
            this.groupBox2.TabIndex = 76;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Tripulación";
            // 
            // imgCopilotoV
            // 
            this.imgCopilotoV.Image = ((System.Drawing.Image)(resources.GetObject("imgCopilotoV.Image")));
            this.imgCopilotoV.Location = new System.Drawing.Point(606, 91);
            this.imgCopilotoV.Name = "imgCopilotoV";
            this.imgCopilotoV.Size = new System.Drawing.Size(34, 33);
            this.imgCopilotoV.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.imgCopilotoV.TabIndex = 59;
            this.imgCopilotoV.TabStop = false;
            this.imgCopilotoV.Visible = false;
            // 
            // imgPilotoV
            // 
            this.imgPilotoV.Image = ((System.Drawing.Image)(resources.GetObject("imgPilotoV.Image")));
            this.imgPilotoV.Location = new System.Drawing.Point(605, 48);
            this.imgPilotoV.Name = "imgPilotoV";
            this.imgPilotoV.Size = new System.Drawing.Size(34, 33);
            this.imgPilotoV.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.imgPilotoV.TabIndex = 7;
            this.imgPilotoV.TabStop = false;
            this.imgPilotoV.Visible = false;
            // 
            // imgCopilotoNV
            // 
            this.imgCopilotoNV.Image = ((System.Drawing.Image)(resources.GetObject("imgCopilotoNV.Image")));
            this.imgCopilotoNV.Location = new System.Drawing.Point(606, 93);
            this.imgCopilotoNV.Name = "imgCopilotoNV";
            this.imgCopilotoNV.Size = new System.Drawing.Size(33, 33);
            this.imgCopilotoNV.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.imgCopilotoNV.TabIndex = 58;
            this.imgCopilotoNV.TabStop = false;
            this.imgCopilotoNV.Visible = false;
            // 
            // imgPilotoNV
            // 
            this.imgPilotoNV.Image = ((System.Drawing.Image)(resources.GetObject("imgPilotoNV.Image")));
            this.imgPilotoNV.Location = new System.Drawing.Point(606, 49);
            this.imgPilotoNV.Name = "imgPilotoNV";
            this.imgPilotoNV.Size = new System.Drawing.Size(33, 33);
            this.imgPilotoNV.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.imgPilotoNV.TabIndex = 57;
            this.imgPilotoNV.TabStop = false;
            this.imgPilotoNV.Visible = false;
            // 
            // txtRutCopiloto
            // 
            this.txtRutCopiloto.BackColor = System.Drawing.Color.White;
            // 
            // 
            // 
            this.txtRutCopiloto.CustomButton.Image = null;
            this.txtRutCopiloto.CustomButton.Location = new System.Drawing.Point(88, 2);
            this.txtRutCopiloto.CustomButton.Name = "";
            this.txtRutCopiloto.CustomButton.Size = new System.Drawing.Size(27, 27);
            this.txtRutCopiloto.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txtRutCopiloto.CustomButton.TabIndex = 1;
            this.txtRutCopiloto.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txtRutCopiloto.CustomButton.UseSelectable = true;
            this.txtRutCopiloto.CustomButton.Visible = false;
            this.txtRutCopiloto.Lines = new string[0];
            this.txtRutCopiloto.Location = new System.Drawing.Point(232, 85);
            this.txtRutCopiloto.MaxLength = 32767;
            this.txtRutCopiloto.Name = "txtRutCopiloto";
            this.txtRutCopiloto.PasswordChar = '\0';
            this.txtRutCopiloto.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtRutCopiloto.SelectedText = "";
            this.txtRutCopiloto.SelectionLength = 0;
            this.txtRutCopiloto.SelectionStart = 0;
            this.txtRutCopiloto.ShortcutsEnabled = true;
            this.txtRutCopiloto.Size = new System.Drawing.Size(118, 32);
            this.txtRutCopiloto.Style = MetroFramework.MetroColorStyle.Orange;
            this.txtRutCopiloto.TabIndex = 55;
            this.txtRutCopiloto.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txtRutCopiloto.UseSelectable = true;
            this.txtRutCopiloto.UseStyleColors = true;
            this.txtRutCopiloto.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txtRutCopiloto.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // txtRutPiloto
            // 
            this.txtRutPiloto.BackColor = System.Drawing.Color.White;
            // 
            // 
            // 
            this.txtRutPiloto.CustomButton.Image = null;
            this.txtRutPiloto.CustomButton.Location = new System.Drawing.Point(88, 2);
            this.txtRutPiloto.CustomButton.Name = "";
            this.txtRutPiloto.CustomButton.Size = new System.Drawing.Size(27, 27);
            this.txtRutPiloto.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txtRutPiloto.CustomButton.TabIndex = 1;
            this.txtRutPiloto.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txtRutPiloto.CustomButton.UseSelectable = true;
            this.txtRutPiloto.CustomButton.Visible = false;
            this.txtRutPiloto.Lines = new string[0];
            this.txtRutPiloto.Location = new System.Drawing.Point(232, 45);
            this.txtRutPiloto.MaxLength = 32767;
            this.txtRutPiloto.Name = "txtRutPiloto";
            this.txtRutPiloto.PasswordChar = '\0';
            this.txtRutPiloto.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtRutPiloto.SelectedText = "";
            this.txtRutPiloto.SelectionLength = 0;
            this.txtRutPiloto.SelectionStart = 0;
            this.txtRutPiloto.ShortcutsEnabled = true;
            this.txtRutPiloto.Size = new System.Drawing.Size(118, 32);
            this.txtRutPiloto.Style = MetroFramework.MetroColorStyle.Orange;
            this.txtRutPiloto.TabIndex = 54;
            this.txtRutPiloto.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txtRutPiloto.UseSelectable = true;
            this.txtRutPiloto.UseStyleColors = true;
            this.txtRutPiloto.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txtRutPiloto.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // linkLicenciaCopiloto
            // 
            this.linkLicenciaCopiloto.DisplayFocus = true;
            this.linkLicenciaCopiloto.Location = new System.Drawing.Point(437, 91);
            this.linkLicenciaCopiloto.Name = "linkLicenciaCopiloto";
            this.linkLicenciaCopiloto.Size = new System.Drawing.Size(163, 28);
            this.linkLicenciaCopiloto.Style = MetroFramework.MetroColorStyle.Orange;
            this.linkLicenciaCopiloto.TabIndex = 7;
            this.linkLicenciaCopiloto.Text = "Consultar Licencia";
            this.linkLicenciaCopiloto.UseCustomBackColor = true;
            this.linkLicenciaCopiloto.UseCustomForeColor = true;
            this.linkLicenciaCopiloto.UseSelectable = true;
            this.linkLicenciaCopiloto.UseStyleColors = true;
            this.linkLicenciaCopiloto.Click += new System.EventHandler(this.linkLicenciaCopiloto_Click);
            // 
            // linkLicenciaPiloto
            // 
            this.linkLicenciaPiloto.DisplayFocus = true;
            this.linkLicenciaPiloto.Location = new System.Drawing.Point(437, 49);
            this.linkLicenciaPiloto.Name = "linkLicenciaPiloto";
            this.linkLicenciaPiloto.Size = new System.Drawing.Size(163, 28);
            this.linkLicenciaPiloto.Style = MetroFramework.MetroColorStyle.Orange;
            this.linkLicenciaPiloto.TabIndex = 6;
            this.linkLicenciaPiloto.Text = "Consultar Licencia";
            this.linkLicenciaPiloto.UseCustomBackColor = true;
            this.linkLicenciaPiloto.UseCustomForeColor = true;
            this.linkLicenciaPiloto.UseSelectable = true;
            this.linkLicenciaPiloto.UseStyleColors = true;
            this.linkLicenciaPiloto.Click += new System.EventHandler(this.metroLink1_Click);
            // 
            // metroLabel3
            // 
            this.metroLabel3.AutoSize = true;
            this.metroLabel3.Location = new System.Drawing.Point(20, 97);
            this.metroLabel3.Name = "metroLabel3";
            this.metroLabel3.Size = new System.Drawing.Size(63, 20);
            this.metroLabel3.TabIndex = 3;
            this.metroLabel3.Text = "Copiloto:";
            // 
            // metroLabel2
            // 
            this.metroLabel2.AutoSize = true;
            this.metroLabel2.Location = new System.Drawing.Point(20, 57);
            this.metroLabel2.Name = "metroLabel2";
            this.metroLabel2.Size = new System.Drawing.Size(46, 20);
            this.metroLabel2.TabIndex = 2;
            this.metroLabel2.Text = "Piloto:";
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
            // pILOTOSBindingSource
            // 
            this.pILOTOSBindingSource.DataMember = "PILOTOS";
            this.pILOTOSBindingSource.DataSource = this.dataSetPilotos;
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.txtMision);
            this.groupBox3.Controls.Add(this.txtHorasEstimadas);
            this.groupBox3.Controls.Add(this.txtFechaHora);
            this.groupBox3.Controls.Add(this.metroLabel5);
            this.groupBox3.Controls.Add(this.metroLabel4);
            this.groupBox3.Controls.Add(this.label3);
            this.groupBox3.Controls.Add(this.cboCondicion);
            this.groupBox3.Controls.Add(this.label2);
            this.groupBox3.Location = new System.Drawing.Point(51, 360);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(675, 234);
            this.groupBox3.TabIndex = 77;
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
            this.txtMision.CustomButton.Location = new System.Drawing.Point(303, 2);
            this.txtMision.CustomButton.Name = "";
            this.txtMision.CustomButton.Size = new System.Drawing.Size(53, 53);
            this.txtMision.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txtMision.CustomButton.TabIndex = 1;
            this.txtMision.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txtMision.CustomButton.UseSelectable = true;
            this.txtMision.CustomButton.Visible = false;
            this.txtMision.Lines = new string[0];
            this.txtMision.Location = new System.Drawing.Point(232, 162);
            this.txtMision.MaxLength = 32767;
            this.txtMision.Multiline = true;
            this.txtMision.Name = "txtMision";
            this.txtMision.PasswordChar = '\0';
            this.txtMision.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtMision.SelectedText = "";
            this.txtMision.SelectionLength = 0;
            this.txtMision.SelectionStart = 0;
            this.txtMision.ShortcutsEnabled = true;
            this.txtMision.Size = new System.Drawing.Size(359, 58);
            this.txtMision.Style = MetroFramework.MetroColorStyle.Orange;
            this.txtMision.TabIndex = 54;
            this.txtMision.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txtMision.UseSelectable = true;
            this.txtMision.UseStyleColors = true;
            this.txtMision.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txtMision.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            this.txtMision.Click += new System.EventHandler(this.txtMision_Click);
            // 
            // txtHorasEstimadas
            // 
            this.txtHorasEstimadas.BackColor = System.Drawing.Color.White;
            // 
            // 
            // 
            this.txtHorasEstimadas.CustomButton.Image = null;
            this.txtHorasEstimadas.CustomButton.Location = new System.Drawing.Point(38, 2);
            this.txtHorasEstimadas.CustomButton.Name = "";
            this.txtHorasEstimadas.CustomButton.Size = new System.Drawing.Size(27, 27);
            this.txtHorasEstimadas.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txtHorasEstimadas.CustomButton.TabIndex = 1;
            this.txtHorasEstimadas.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txtHorasEstimadas.CustomButton.UseSelectable = true;
            this.txtHorasEstimadas.CustomButton.Visible = false;
            this.txtHorasEstimadas.Lines = new string[0];
            this.txtHorasEstimadas.Location = new System.Drawing.Point(232, 70);
            this.txtHorasEstimadas.MaxLength = 32767;
            this.txtHorasEstimadas.Name = "txtHorasEstimadas";
            this.txtHorasEstimadas.PasswordChar = '\0';
            this.txtHorasEstimadas.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtHorasEstimadas.SelectedText = "";
            this.txtHorasEstimadas.SelectionLength = 0;
            this.txtHorasEstimadas.SelectionStart = 0;
            this.txtHorasEstimadas.ShortcutsEnabled = true;
            this.txtHorasEstimadas.Size = new System.Drawing.Size(68, 32);
            this.txtHorasEstimadas.Style = MetroFramework.MetroColorStyle.Orange;
            this.txtHorasEstimadas.TabIndex = 53;
            this.txtHorasEstimadas.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txtHorasEstimadas.UseSelectable = true;
            this.txtHorasEstimadas.UseStyleColors = true;
            this.txtHorasEstimadas.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txtHorasEstimadas.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            this.txtHorasEstimadas.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtHorasEstimadas_KeyPress);
            // 
            // txtFechaHora
            // 
            this.txtFechaHora.DisplayFocus = true;
            this.txtFechaHora.Location = new System.Drawing.Point(232, 117);
            this.txtFechaHora.MinimumSize = new System.Drawing.Size(0, 30);
            this.txtFechaHora.Name = "txtFechaHora";
            this.txtFechaHora.Size = new System.Drawing.Size(265, 30);
            this.txtFechaHora.Style = MetroFramework.MetroColorStyle.Orange;
            this.txtFechaHora.TabIndex = 14;
            this.txtFechaHora.UseCustomBackColor = true;
            this.txtFechaHora.UseCustomForeColor = true;
            this.txtFechaHora.UseStyleColors = true;
            // 
            // metroLabel5
            // 
            this.metroLabel5.AutoSize = true;
            this.metroLabel5.Location = new System.Drawing.Point(20, 127);
            this.metroLabel5.Name = "metroLabel5";
            this.metroLabel5.Size = new System.Drawing.Size(93, 20);
            this.metroLabel5.TabIndex = 13;
            this.metroLabel5.Text = "Fecha - Hora:";
            // 
            // metroLabel4
            // 
            this.metroLabel4.AutoSize = true;
            this.metroLabel4.Location = new System.Drawing.Point(20, 174);
            this.metroLabel4.Name = "metroLabel4";
            this.metroLabel4.Size = new System.Drawing.Size(52, 20);
            this.metroLabel4.TabIndex = 11;
            this.metroLabel4.Text = "Misión:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(17, 85);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(176, 17);
            this.label3.TabIndex = 9;
            this.label3.Text = "Horas de vuelo estimadas:";
            // 
            // cboCondicion
            // 
            this.cboCondicion.DataSource = this.cONDICIONBindingSource;
            this.cboCondicion.DisplayFocus = true;
            this.cboCondicion.DisplayMember = "desc";
            this.cboCondicion.FormattingEnabled = true;
            this.cboCondicion.ItemHeight = 24;
            this.cboCondicion.Location = new System.Drawing.Point(232, 24);
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
            this.label2.Location = new System.Drawing.Point(17, 37);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(132, 17);
            this.label2.TabIndex = 0;
            this.label2.Text = "Condición de vuelo:";
            // 
            // btbGenerar
            // 
            this.btbGenerar.Location = new System.Drawing.Point(51, 600);
            this.btbGenerar.Name = "btbGenerar";
            this.btbGenerar.Size = new System.Drawing.Size(131, 38);
            this.btbGenerar.TabIndex = 78;
            this.btbGenerar.Text = "Generar Vuelo";
            this.btbGenerar.UseSelectable = true;
            this.btbGenerar.Click += new System.EventHandler(this.btbGenerar_Click);
            // 
            // pILOTOSTableAdapter
            // 
            this.pILOTOSTableAdapter.ClearBeforeFill = true;
            // 
            // cONDICIONTableAdapter
            // 
            this.cONDICIONTableAdapter.ClearBeforeFill = true;
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.cboAeronave);
            this.groupBox4.Controls.Add(this.metroLabel7);
            this.groupBox4.Location = new System.Drawing.Point(51, 126);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(675, 82);
            this.groupBox4.TabIndex = 77;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Aeronave";
            // 
            // cboAeronave
            // 
            this.cboAeronave.DataSource = this.aERONAVESBindingSource;
            this.cboAeronave.DisplayFocus = true;
            this.cboAeronave.DisplayMember = "PATENTE";
            this.cboAeronave.FormattingEnabled = true;
            this.cboAeronave.ItemHeight = 24;
            this.cboAeronave.Location = new System.Drawing.Point(232, 32);
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
            this.metroLabel7.Location = new System.Drawing.Point(20, 38);
            this.metroLabel7.Name = "metroLabel7";
            this.metroLabel7.Size = new System.Drawing.Size(143, 20);
            this.metroLabel7.TabIndex = 2;
            this.metroLabel7.Text = "Seleccione Aeronave:";
            // 
            // aERONAVESTableAdapter
            // 
            this.aERONAVESTableAdapter.ClearBeforeFill = true;
            // 
            // groupBox5
            // 
            this.groupBox5.Controls.Add(this.lblMensaje);
            this.groupBox5.Controls.Add(this.imagenError);
            this.groupBox5.Controls.Add(this.imagenAlerta);
            this.groupBox5.Controls.Add(this.imagenExito);
            this.groupBox5.Controls.Add(this.metroLabel8);
            this.groupBox5.Location = new System.Drawing.Point(373, 60);
            this.groupBox5.Name = "groupBox5";
            this.groupBox5.Size = new System.Drawing.Size(353, 60);
            this.groupBox5.TabIndex = 76;
            this.groupBox5.TabStop = false;
            this.groupBox5.Text = "Validacion de licencias";
            // 
            // lblMensaje
            // 
            this.lblMensaje.AutoSize = true;
            this.lblMensaje.Location = new System.Drawing.Point(162, 24);
            this.lblMensaje.Name = "lblMensaje";
            this.lblMensaje.Size = new System.Drawing.Size(61, 20);
            this.lblMensaje.TabIndex = 6;
            this.lblMensaje.Text = "Mensaje";
            // 
            // imagenError
            // 
            this.imagenError.Image = ((System.Drawing.Image)(resources.GetObject("imagenError.Image")));
            this.imagenError.Location = new System.Drawing.Point(99, 21);
            this.imagenError.Name = "imagenError";
            this.imagenError.Size = new System.Drawing.Size(33, 33);
            this.imagenError.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.imagenError.TabIndex = 5;
            this.imagenError.TabStop = false;
            this.imagenError.Visible = false;
            // 
            // imagenAlerta
            // 
            this.imagenAlerta.Image = ((System.Drawing.Image)(resources.GetObject("imagenAlerta.Image")));
            this.imagenAlerta.Location = new System.Drawing.Point(98, 21);
            this.imagenAlerta.Name = "imagenAlerta";
            this.imagenAlerta.Size = new System.Drawing.Size(34, 33);
            this.imagenAlerta.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.imagenAlerta.TabIndex = 4;
            this.imagenAlerta.TabStop = false;
            this.imagenAlerta.Visible = false;
            // 
            // imagenExito
            // 
            this.imagenExito.Image = ((System.Drawing.Image)(resources.GetObject("imagenExito.Image")));
            this.imagenExito.Location = new System.Drawing.Point(98, 21);
            this.imagenExito.Name = "imagenExito";
            this.imagenExito.Size = new System.Drawing.Size(34, 33);
            this.imagenExito.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.imagenExito.TabIndex = 3;
            this.imagenExito.TabStop = false;
            this.imagenExito.Visible = false;
            // 
            // metroLabel8
            // 
            this.metroLabel8.AutoSize = true;
            this.metroLabel8.Location = new System.Drawing.Point(21, 24);
            this.metroLabel8.Name = "metroLabel8";
            this.metroLabel8.Size = new System.Drawing.Size(53, 20);
            this.metroLabel8.TabIndex = 2;
            this.metroLabel8.Text = "Estado:";
            // 
            // Form_GenerarVuelo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(779, 647);
            this.Controls.Add(this.groupBox5);
            this.Controls.Add(this.groupBox4);
            this.Controls.Add(this.btbGenerar);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Form_GenerarVuelo";
            this.Text = "Form_GenerarVuelo";
            this.Load += new System.EventHandler(this.Form_GenerarVuelo_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.imgCopilotoV)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.imgPilotoV)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.imgCopilotoNV)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.imgPilotoNV)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pILOTOSBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSetPilotos)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pILOTOSBindingSource)).EndInit();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.cONDICIONBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSetCondicion)).EndInit();
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.aERONAVESBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSetAeronaves)).EndInit();
            this.groupBox5.ResumeLayout(false);
            this.groupBox5.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.imagenError)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.imagenAlerta)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.imagenExito)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox1;
        private MetroFramework.Controls.MetroLabel metroLabel1;
        private MetroFramework.Controls.MetroCheckBox chkCopiloto;
        private System.Windows.Forms.GroupBox groupBox2;
        private MetroFramework.Controls.MetroLink linkLicenciaCopiloto;
        private MetroFramework.Controls.MetroLink linkLicenciaPiloto;
        private MetroFramework.Controls.MetroLabel metroLabel3;
        private MetroFramework.Controls.MetroLabel metroLabel2;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Label label3;
        private MetroFramework.Controls.MetroComboBox cboCondicion;
        private System.Windows.Forms.Label label2;
        private MetroFramework.Controls.MetroDateTime txtFechaHora;
        private MetroFramework.Controls.MetroLabel metroLabel5;
        private MetroFramework.Controls.MetroLabel metroLabel4;
        private MetroFramework.Controls.MetroTextBox txtMision;
        private MetroFramework.Controls.MetroTextBox txtHorasEstimadas;
        private MetroFramework.Controls.MetroButton btbGenerar;
        private DataSetPilotos dataSetPilotos;
        private System.Windows.Forms.BindingSource pILOTOSBindingSource;
        private DataSetPilotosTableAdapters.PILOTOSTableAdapter pILOTOSTableAdapter;
        private DataSetCondicion dataSetCondicion;
        private System.Windows.Forms.BindingSource cONDICIONBindingSource;
        private DataSetCondicionTableAdapters.CONDICIONTableAdapter cONDICIONTableAdapter;
        private System.Windows.Forms.GroupBox groupBox4;
        private MetroFramework.Controls.MetroComboBox cboAeronave;
        private MetroFramework.Controls.MetroLabel metroLabel7;
        private DataSetAeronaves dataSetAeronaves;
        private System.Windows.Forms.BindingSource aERONAVESBindingSource;
        private DataSetAeronavesTableAdapters.AERONAVESTableAdapter aERONAVESTableAdapter;
        private System.Windows.Forms.BindingSource pILOTOSBindingSource1;
        private MetroFramework.Controls.MetroTextBox txtRutCopiloto;
        private MetroFramework.Controls.MetroTextBox txtRutPiloto;
        private System.Windows.Forms.GroupBox groupBox5;
        private MetroFramework.Controls.MetroLabel lblMensaje;
        private System.Windows.Forms.PictureBox imagenError;
        private System.Windows.Forms.PictureBox imagenAlerta;
        private System.Windows.Forms.PictureBox imagenExito;
        private MetroFramework.Controls.MetroLabel metroLabel8;
        private System.Windows.Forms.PictureBox imgCopilotoV;
        private System.Windows.Forms.PictureBox imgPilotoV;
        private System.Windows.Forms.PictureBox imgCopilotoNV;
        private System.Windows.Forms.PictureBox imgPilotoNV;
    }
}
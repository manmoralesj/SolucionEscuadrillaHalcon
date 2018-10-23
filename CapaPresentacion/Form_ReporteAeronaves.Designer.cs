namespace CapaPresentacion
{
    partial class Form_ReporteAeronaves
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
            Microsoft.Reporting.WinForms.ReportDataSource reportDataSource1 = new Microsoft.Reporting.WinForms.ReportDataSource();
            this.label1 = new System.Windows.Forms.Label();
            this.reportViewer1 = new Microsoft.Reporting.WinForms.ReportViewer();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.metroLabel2 = new MetroFramework.Controls.MetroLabel();
            this.chkHelicopteros = new MetroFramework.Controls.MetroRadioButton();
            this.chkAviones = new MetroFramework.Controls.MetroRadioButton();
            this.DataSetReporteAeronaves = new CapaPresentacion.DataSetReporteAeronaves();
            this.SP_REPORTE_AERNAVESBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.SP_REPORTE_AERNAVESTableAdapter = new CapaPresentacion.DataSetReporteAeronavesTableAdapters.SP_REPORTE_AERNAVESTableAdapter();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DataSetReporteAeronaves)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.SP_REPORTE_AERNAVESBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(211, 42);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(299, 38);
            this.label1.TabIndex = 65;
            this.label1.Text = "Reporte Aeronaves";
            // 
            // reportViewer1
            // 
            this.reportViewer1.BackColor = System.Drawing.Color.Snow;
            reportDataSource1.Name = "DataSetAeronaves";
            reportDataSource1.Value = this.SP_REPORTE_AERNAVESBindingSource;
            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource1);
            this.reportViewer1.LocalReport.ReportEmbeddedResource = "CapaPresentacion.Reporte_Aeronaves.rdlc";
            this.reportViewer1.Location = new System.Drawing.Point(12, 217);
            this.reportViewer1.Name = "reportViewer1";
            this.reportViewer1.Size = new System.Drawing.Size(730, 421);
            this.reportViewer1.TabIndex = 66;
            this.reportViewer1.Load += new System.EventHandler(this.reportViewer1_Load);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.metroLabel2);
            this.groupBox2.Controls.Add(this.chkHelicopteros);
            this.groupBox2.Controls.Add(this.chkAviones);
            this.groupBox2.Location = new System.Drawing.Point(127, 107);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(497, 81);
            this.groupBox2.TabIndex = 75;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Tipo de aeronave";
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
            // chkHelicopteros
            // 
            this.chkHelicopteros.AutoSize = true;
            this.chkHelicopteros.Location = new System.Drawing.Point(321, 40);
            this.chkHelicopteros.Name = "chkHelicopteros";
            this.chkHelicopteros.Size = new System.Drawing.Size(98, 17);
            this.chkHelicopteros.Style = MetroFramework.MetroColorStyle.Orange;
            this.chkHelicopteros.TabIndex = 1;
            this.chkHelicopteros.Text = "Helicópteros";
            this.chkHelicopteros.UseSelectable = true;
            this.chkHelicopteros.CheckedChanged += new System.EventHandler(this.chkHelicopteros_CheckedChanged);
            // 
            // chkAviones
            // 
            this.chkAviones.AutoSize = true;
            this.chkAviones.Location = new System.Drawing.Point(159, 40);
            this.chkAviones.Name = "chkAviones";
            this.chkAviones.Size = new System.Drawing.Size(69, 17);
            this.chkAviones.Style = MetroFramework.MetroColorStyle.Orange;
            this.chkAviones.TabIndex = 0;
            this.chkAviones.Text = "Aviones";
            this.chkAviones.UseSelectable = true;
            this.chkAviones.CheckedChanged += new System.EventHandler(this.chkAviones_CheckedChanged_1);
            // 
            // DataSetReporteAeronaves
            // 
            this.DataSetReporteAeronaves.DataSetName = "DataSetReporteAeronaves";
            this.DataSetReporteAeronaves.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // SP_REPORTE_AERNAVESBindingSource
            // 
            this.SP_REPORTE_AERNAVESBindingSource.DataMember = "SP_REPORTE_AERNAVES";
            this.SP_REPORTE_AERNAVESBindingSource.DataSource = this.DataSetReporteAeronaves;
            // 
            // SP_REPORTE_AERNAVESTableAdapter
            // 
            this.SP_REPORTE_AERNAVESTableAdapter.ClearBeforeFill = true;
            // 
            // Form_ReporteAeronaves
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(754, 650);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.reportViewer1);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Form_ReporteAeronaves";
            this.Text = "Form_ReporteAeronaves";
            this.Load += new System.EventHandler(this.Form_ReporteAeronaves_Load);
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DataSetReporteAeronaves)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.SP_REPORTE_AERNAVESBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private Microsoft.Reporting.WinForms.ReportViewer reportViewer1;
        private System.Windows.Forms.GroupBox groupBox2;
        private MetroFramework.Controls.MetroLabel metroLabel2;
        private MetroFramework.Controls.MetroRadioButton chkHelicopteros;
        private MetroFramework.Controls.MetroRadioButton chkAviones;
        private System.Windows.Forms.BindingSource SP_REPORTE_AERNAVESBindingSource;
        private DataSetReporteAeronaves DataSetReporteAeronaves;
        private DataSetReporteAeronavesTableAdapters.SP_REPORTE_AERNAVESTableAdapter SP_REPORTE_AERNAVESTableAdapter;
    }
}
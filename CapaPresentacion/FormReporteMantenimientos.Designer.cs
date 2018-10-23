namespace CapaPresentacion
{
    partial class FormReporteMantenimientos
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
            Microsoft.Reporting.WinForms.ReportDataSource reportDataSource2 = new Microsoft.Reporting.WinForms.ReportDataSource();
            Microsoft.Reporting.WinForms.ReportDataSource reportDataSource3 = new Microsoft.Reporting.WinForms.ReportDataSource();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.metroLabel2 = new MetroFramework.Controls.MetroLabel();
            this.chkComponentes = new MetroFramework.Controls.MetroRadioButton();
            this.chkAeronaves = new MetroFramework.Controls.MetroRadioButton();
            this.reportViewer1 = new Microsoft.Reporting.WinForms.ReportViewer();
            this.label1 = new System.Windows.Forms.Label();
            this.DataSetMantenimientoAeronaves = new CapaPresentacion.DataSetMantenimientoAeronaves();
            this.SP_REPORTE_MANT_AERONAVESBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.SP_REPORTE_MANT_AERONAVESTableAdapter = new CapaPresentacion.DataSetMantenimientoAeronavesTableAdapters.SP_REPORTE_MANT_AERONAVESTableAdapter();
            this.DataSetMantComponente = new CapaPresentacion.DataSetMantComponente();
            this.SP_REPORTE_MANT_COMPONENTESBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.SP_REPORTE_MANT_COMPONENTESTableAdapter = new CapaPresentacion.DataSetMantComponenteTableAdapters.SP_REPORTE_MANT_COMPONENTESTableAdapter();
            this.reportViewer2 = new Microsoft.Reporting.WinForms.ReportViewer();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DataSetMantenimientoAeronaves)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.SP_REPORTE_MANT_AERONAVESBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.DataSetMantComponente)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.SP_REPORTE_MANT_COMPONENTESBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.metroLabel2);
            this.groupBox2.Controls.Add(this.chkComponentes);
            this.groupBox2.Controls.Add(this.chkAeronaves);
            this.groupBox2.Location = new System.Drawing.Point(127, 92);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(497, 81);
            this.groupBox2.TabIndex = 81;
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
            // chkComponentes
            // 
            this.chkComponentes.AutoSize = true;
            this.chkComponentes.Location = new System.Drawing.Point(321, 40);
            this.chkComponentes.Name = "chkComponentes";
            this.chkComponentes.Size = new System.Drawing.Size(105, 17);
            this.chkComponentes.Style = MetroFramework.MetroColorStyle.Orange;
            this.chkComponentes.TabIndex = 1;
            this.chkComponentes.Text = "Componentes";
            this.chkComponentes.UseSelectable = true;
            this.chkComponentes.CheckedChanged += new System.EventHandler(this.chkComponentes_CheckedChanged);
            // 
            // chkAeronaves
            // 
            this.chkAeronaves.AutoSize = true;
            this.chkAeronaves.Location = new System.Drawing.Point(159, 40);
            this.chkAeronaves.Name = "chkAeronaves";
            this.chkAeronaves.Size = new System.Drawing.Size(85, 17);
            this.chkAeronaves.Style = MetroFramework.MetroColorStyle.Orange;
            this.chkAeronaves.TabIndex = 0;
            this.chkAeronaves.Text = "Aeronaves";
            this.chkAeronaves.UseSelectable = true;
            this.chkAeronaves.CheckedChanged += new System.EventHandler(this.chkAeronaves_CheckedChanged);
            // 
            // reportViewer1
            // 
            this.reportViewer1.BackColor = System.Drawing.Color.Snow;
            reportDataSource1.Name = "DataSet1";
            reportDataSource1.Value = this.SP_REPORTE_MANT_AERONAVESBindingSource;
            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource1);
            this.reportViewer1.LocalReport.ReportEmbeddedResource = "CapaPresentacion.Reporte_Mantenimiento_Aer.rdlc";
            this.reportViewer1.Location = new System.Drawing.Point(12, 192);
            this.reportViewer1.Name = "reportViewer1";
            this.reportViewer1.Size = new System.Drawing.Size(730, 213);
            this.reportViewer1.TabIndex = 80;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(152, 23);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(416, 38);
            this.label1.TabIndex = 79;
            this.label1.Text = "Reporte de Mantenimientos";
            // 
            // DataSetMantenimientoAeronaves
            // 
            this.DataSetMantenimientoAeronaves.DataSetName = "DataSetMantenimientoAeronaves";
            this.DataSetMantenimientoAeronaves.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // SP_REPORTE_MANT_AERONAVESBindingSource
            // 
            this.SP_REPORTE_MANT_AERONAVESBindingSource.DataMember = "SP_REPORTE_MANT_AERONAVES";
            this.SP_REPORTE_MANT_AERONAVESBindingSource.DataSource = this.DataSetMantenimientoAeronaves;
            // 
            // SP_REPORTE_MANT_AERONAVESTableAdapter
            // 
            this.SP_REPORTE_MANT_AERONAVESTableAdapter.ClearBeforeFill = true;
            // 
            // DataSetMantComponente
            // 
            this.DataSetMantComponente.DataSetName = "DataSetMantComponente";
            this.DataSetMantComponente.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // SP_REPORTE_MANT_COMPONENTESBindingSource
            // 
            this.SP_REPORTE_MANT_COMPONENTESBindingSource.DataMember = "SP_REPORTE_MANT_COMPONENTES";
            this.SP_REPORTE_MANT_COMPONENTESBindingSource.DataSource = this.DataSetMantComponente;
            // 
            // SP_REPORTE_MANT_COMPONENTESTableAdapter
            // 
            this.SP_REPORTE_MANT_COMPONENTESTableAdapter.ClearBeforeFill = true;
            // 
            // reportViewer2
            // 
            this.reportViewer2.BackColor = System.Drawing.Color.Snow;
            reportDataSource2.Name = "DataSet1";
            reportDataSource2.Value = this.SP_REPORTE_MANT_COMPONENTESBindingSource;
            reportDataSource3.Name = "DataSet2";
            reportDataSource3.Value = this.SP_REPORTE_MANT_AERONAVESBindingSource;
            this.reportViewer2.LocalReport.DataSources.Add(reportDataSource2);
            this.reportViewer2.LocalReport.DataSources.Add(reportDataSource3);
            this.reportViewer2.LocalReport.ReportEmbeddedResource = "CapaPresentacion.Reporte_Mantenimiento_Comp.rdlc";
            this.reportViewer2.Location = new System.Drawing.Point(12, 425);
            this.reportViewer2.Name = "reportViewer2";
            this.reportViewer2.Size = new System.Drawing.Size(730, 213);
            this.reportViewer2.TabIndex = 82;
            this.reportViewer2.Load += new System.EventHandler(this.reportViewer2_Load);
            // 
            // FormReporteMantenimientos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(754, 650);
            this.Controls.Add(this.reportViewer2);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.reportViewer1);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FormReporteMantenimientos";
            this.Text = "FormReporteMantenimientos";
            this.Load += new System.EventHandler(this.FormReporteMantenimientos_Load);
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DataSetMantenimientoAeronaves)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.SP_REPORTE_MANT_AERONAVESBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.DataSetMantComponente)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.SP_REPORTE_MANT_COMPONENTESBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox2;
        private MetroFramework.Controls.MetroLabel metroLabel2;
        private MetroFramework.Controls.MetroRadioButton chkComponentes;
        private MetroFramework.Controls.MetroRadioButton chkAeronaves;
        private Microsoft.Reporting.WinForms.ReportViewer reportViewer1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.BindingSource SP_REPORTE_MANT_COMPONENTESBindingSource;
        private DataSetMantComponente DataSetMantComponente;
        private DataSetMantComponenteTableAdapters.SP_REPORTE_MANT_COMPONENTESTableAdapter SP_REPORTE_MANT_COMPONENTESTableAdapter;
        private System.Windows.Forms.BindingSource SP_REPORTE_MANT_AERONAVESBindingSource;
        private DataSetMantenimientoAeronaves DataSetMantenimientoAeronaves;
        private DataSetMantenimientoAeronavesTableAdapters.SP_REPORTE_MANT_AERONAVESTableAdapter SP_REPORTE_MANT_AERONAVESTableAdapter;
        private Microsoft.Reporting.WinForms.ReportViewer reportViewer2;
    }
}
namespace CapaPresentacion
{
    partial class FormReportePilotos
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
            Microsoft.Reporting.WinForms.ReportDataSource reportDataSource3 = new Microsoft.Reporting.WinForms.ReportDataSource();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.metroLabel2 = new MetroFramework.Controls.MetroLabel();
            this.chkHelicopteros = new MetroFramework.Controls.MetroRadioButton();
            this.chkAviones = new MetroFramework.Controls.MetroRadioButton();
            this.reportViewer1 = new Microsoft.Reporting.WinForms.ReportViewer();
            this.label1 = new System.Windows.Forms.Label();
            this.DataSetReportePilotos = new CapaPresentacion.DataSetReportePilotos();
            this.SP_REPORTE_PILOTOSBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.SP_REPORTE_PILOTOSTableAdapter = new CapaPresentacion.DataSetReportePilotosTableAdapters.SP_REPORTE_PILOTOSTableAdapter();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DataSetReportePilotos)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.SP_REPORTE_PILOTOSBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.metroLabel2);
            this.groupBox2.Controls.Add(this.chkHelicopteros);
            this.groupBox2.Controls.Add(this.chkAviones);
            this.groupBox2.Location = new System.Drawing.Point(127, 92);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(497, 81);
            this.groupBox2.TabIndex = 78;
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
            this.chkAviones.CheckedChanged += new System.EventHandler(this.chkAviones_CheckedChanged);
            // 
            // reportViewer1
            // 
            this.reportViewer1.BackColor = System.Drawing.Color.Snow;
            reportDataSource3.Name = "DataSet1";
            reportDataSource3.Value = this.SP_REPORTE_PILOTOSBindingSource;
            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource3);
            this.reportViewer1.LocalReport.ReportEmbeddedResource = "CapaPresentacion.ReportePilotos.rdlc";
            this.reportViewer1.Location = new System.Drawing.Point(12, 202);
            this.reportViewer1.Name = "reportViewer1";
            this.reportViewer1.Size = new System.Drawing.Size(730, 421);
            this.reportViewer1.TabIndex = 77;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(245, 28);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(240, 38);
            this.label1.TabIndex = 76;
            this.label1.Text = "Reporte Pilotos";
            // 
            // DataSetReportePilotos
            // 
            this.DataSetReportePilotos.DataSetName = "DataSetReportePilotos";
            this.DataSetReportePilotos.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // SP_REPORTE_PILOTOSBindingSource
            // 
            this.SP_REPORTE_PILOTOSBindingSource.DataMember = "SP_REPORTE_PILOTOS";
            this.SP_REPORTE_PILOTOSBindingSource.DataSource = this.DataSetReportePilotos;
            // 
            // SP_REPORTE_PILOTOSTableAdapter
            // 
            this.SP_REPORTE_PILOTOSTableAdapter.ClearBeforeFill = true;
            // 
            // FormReportePilotos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(754, 650);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.reportViewer1);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FormReportePilotos";
            this.Text = "FormReportePilotos";
            this.Load += new System.EventHandler(this.FormReportePilotos_Load);
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DataSetReportePilotos)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.SP_REPORTE_PILOTOSBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox2;
        private MetroFramework.Controls.MetroLabel metroLabel2;
        private MetroFramework.Controls.MetroRadioButton chkHelicopteros;
        private MetroFramework.Controls.MetroRadioButton chkAviones;
        private Microsoft.Reporting.WinForms.ReportViewer reportViewer1;
        private System.Windows.Forms.BindingSource SP_REPORTE_PILOTOSBindingSource;
        private DataSetReportePilotos DataSetReportePilotos;
        private System.Windows.Forms.Label label1;
        private DataSetReportePilotosTableAdapters.SP_REPORTE_PILOTOSTableAdapter SP_REPORTE_PILOTOSTableAdapter;
    }
}
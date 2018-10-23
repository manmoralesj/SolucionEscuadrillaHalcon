namespace CapaPresentacion
{
    partial class Form_AlertaMantenimiento
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            this.metroGrid1 = new MetroFramework.Controls.MetroGrid();
            this.dataSetAlertaMantenimiento = new CapaPresentacion.DataSetAlertaMantenimiento();
            this.sPALERTAINSPECCIONANUALBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.sP_ALERTA_INSPECCION_ANUALTableAdapter = new CapaPresentacion.DataSetAlertaMantenimientoTableAdapters.SP_ALERTA_INSPECCION_ANUALTableAdapter();
            this.pATENTEDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.hORASVOLADASDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cANTMAXHORASDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.aNIOFABDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.fECHAINSPECCIONANUALDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cAPLITROSDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.sPALERTAINSPECCIONANUALBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.metroGrid1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSetAlertaMantenimiento)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.sPALERTAINSPECCIONANUALBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.sPALERTAINSPECCIONANUALBindingSource1)).BeginInit();
            this.SuspendLayout();
            // 
            // metroGrid1
            // 
            this.metroGrid1.AllowUserToAddRows = false;
            this.metroGrid1.AllowUserToDeleteRows = false;
            this.metroGrid1.AllowUserToResizeRows = false;
            this.metroGrid1.AutoGenerateColumns = false;
            this.metroGrid1.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.metroGrid1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.metroGrid1.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
            this.metroGrid1.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(209)))), ((int)(((byte)(17)))), ((int)(((byte)(65)))));
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(234)))), ((int)(((byte)(19)))), ((int)(((byte)(73)))));
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.metroGrid1.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.metroGrid1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.metroGrid1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.pATENTEDataGridViewTextBoxColumn,
            this.hORASVOLADASDataGridViewTextBoxColumn,
            this.cANTMAXHORASDataGridViewTextBoxColumn,
            this.aNIOFABDataGridViewTextBoxColumn,
            this.fECHAINSPECCIONANUALDataGridViewTextBoxColumn,
            this.cAPLITROSDataGridViewTextBoxColumn});
            this.metroGrid1.DataSource = this.sPALERTAINSPECCIONANUALBindingSource1;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(136)))), ((int)(((byte)(136)))), ((int)(((byte)(136)))));
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(234)))), ((int)(((byte)(19)))), ((int)(((byte)(73)))));
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.metroGrid1.DefaultCellStyle = dataGridViewCellStyle2;
            this.metroGrid1.EnableHeadersVisualStyles = false;
            this.metroGrid1.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.metroGrid1.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.metroGrid1.Location = new System.Drawing.Point(40, 93);
            this.metroGrid1.Name = "metroGrid1";
            this.metroGrid1.ReadOnly = true;
            this.metroGrid1.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(209)))), ((int)(((byte)(17)))), ((int)(((byte)(65)))));
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(234)))), ((int)(((byte)(19)))), ((int)(((byte)(73)))));
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.metroGrid1.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.metroGrid1.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.metroGrid1.RowTemplate.Height = 24;
            this.metroGrid1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.metroGrid1.Size = new System.Drawing.Size(640, 192);
            this.metroGrid1.Style = MetroFramework.MetroColorStyle.Red;
            this.metroGrid1.TabIndex = 0;
            this.metroGrid1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.metroGrid1_CellContentClick);
            // 
            // dataSetAlertaMantenimiento
            // 
            this.dataSetAlertaMantenimiento.DataSetName = "DataSetAlertaMantenimiento";
            this.dataSetAlertaMantenimiento.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // sPALERTAINSPECCIONANUALBindingSource
            // 
            this.sPALERTAINSPECCIONANUALBindingSource.DataMember = "SP_ALERTA_INSPECCION_ANUAL";
            this.sPALERTAINSPECCIONANUALBindingSource.DataSource = this.dataSetAlertaMantenimiento;
            // 
            // sP_ALERTA_INSPECCION_ANUALTableAdapter
            // 
            this.sP_ALERTA_INSPECCION_ANUALTableAdapter.ClearBeforeFill = true;
            // 
            // pATENTEDataGridViewTextBoxColumn
            // 
            this.pATENTEDataGridViewTextBoxColumn.DataPropertyName = "PATENTE";
            this.pATENTEDataGridViewTextBoxColumn.HeaderText = "PATENTE";
            this.pATENTEDataGridViewTextBoxColumn.Name = "pATENTEDataGridViewTextBoxColumn";
            this.pATENTEDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // hORASVOLADASDataGridViewTextBoxColumn
            // 
            this.hORASVOLADASDataGridViewTextBoxColumn.DataPropertyName = "HORAS_VOLADAS";
            this.hORASVOLADASDataGridViewTextBoxColumn.HeaderText = "HORAS VOLADAS";
            this.hORASVOLADASDataGridViewTextBoxColumn.Name = "hORASVOLADASDataGridViewTextBoxColumn";
            this.hORASVOLADASDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // cANTMAXHORASDataGridViewTextBoxColumn
            // 
            this.cANTMAXHORASDataGridViewTextBoxColumn.DataPropertyName = "CANT_MAX_HORAS";
            this.cANTMAXHORASDataGridViewTextBoxColumn.HeaderText = "HORAS MÁXIMAS";
            this.cANTMAXHORASDataGridViewTextBoxColumn.Name = "cANTMAXHORASDataGridViewTextBoxColumn";
            this.cANTMAXHORASDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // aNIOFABDataGridViewTextBoxColumn
            // 
            this.aNIOFABDataGridViewTextBoxColumn.DataPropertyName = "ANIO_FAB";
            this.aNIOFABDataGridViewTextBoxColumn.HeaderText = "AÑO FABRICACIÓN";
            this.aNIOFABDataGridViewTextBoxColumn.Name = "aNIOFABDataGridViewTextBoxColumn";
            this.aNIOFABDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // fECHAINSPECCIONANUALDataGridViewTextBoxColumn
            // 
            this.fECHAINSPECCIONANUALDataGridViewTextBoxColumn.DataPropertyName = "FECHA_INSPECCION_ANUAL";
            this.fECHAINSPECCIONANUALDataGridViewTextBoxColumn.HeaderText = "FECHA INSPECCION ANUAL";
            this.fECHAINSPECCIONANUALDataGridViewTextBoxColumn.Name = "fECHAINSPECCIONANUALDataGridViewTextBoxColumn";
            this.fECHAINSPECCIONANUALDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // cAPLITROSDataGridViewTextBoxColumn
            // 
            this.cAPLITROSDataGridViewTextBoxColumn.DataPropertyName = "CAP_LITROS";
            this.cAPLITROSDataGridViewTextBoxColumn.HeaderText = "CAPACIDAD LITROS";
            this.cAPLITROSDataGridViewTextBoxColumn.Name = "cAPLITROSDataGridViewTextBoxColumn";
            this.cAPLITROSDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // sPALERTAINSPECCIONANUALBindingSource1
            // 
            this.sPALERTAINSPECCIONANUALBindingSource1.DataMember = "SP_ALERTA_INSPECCION_ANUAL";
            this.sPALERTAINSPECCIONANUALBindingSource1.DataSource = this.dataSetAlertaMantenimiento;
            // 
            // Form_AlertaMantenimiento
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(735, 324);
            this.Controls.Add(this.metroGrid1);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Form_AlertaMantenimiento";
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide;
            this.Style = MetroFramework.MetroColorStyle.Red;
            this.Text = "Aeronaves Pendientes a mantenimiento";
            this.Load += new System.EventHandler(this.Form_AlertaMantenimiento_Load);
            ((System.ComponentModel.ISupportInitialize)(this.metroGrid1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSetAlertaMantenimiento)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.sPALERTAINSPECCIONANUALBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.sPALERTAINSPECCIONANUALBindingSource1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private MetroFramework.Controls.MetroGrid metroGrid1;
        private System.Windows.Forms.DataGridViewTextBoxColumn pATENTEDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn hORASVOLADASDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn cANTMAXHORASDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn aNIOFABDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn fECHAINSPECCIONANUALDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn cAPLITROSDataGridViewTextBoxColumn;
        private System.Windows.Forms.BindingSource sPALERTAINSPECCIONANUALBindingSource;
        private DataSetAlertaMantenimiento dataSetAlertaMantenimiento;
        private DataSetAlertaMantenimientoTableAdapters.SP_ALERTA_INSPECCION_ANUALTableAdapter sP_ALERTA_INSPECCION_ANUALTableAdapter;
        private System.Windows.Forms.BindingSource sPALERTAINSPECCIONANUALBindingSource1;
    }
}
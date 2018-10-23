namespace CapaPresentacion
{
    partial class Form_ListarPiloto
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
            this.label1 = new System.Windows.Forms.Label();
            this.btnCargar = new MetroFramework.Controls.MetroButton();
            this.listaPilotos = new MetroFramework.Controls.MetroGrid();
            this.dataSetUsuarios = new CapaPresentacion.DataSetUsuarios();
            this.dTPilotosBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dTPilotosTableAdapter = new CapaPresentacion.DataSetUsuariosTableAdapters.DTPilotosTableAdapter();
            this.rUTDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nOMBRESDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.aPPATERNODataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.aPMATERNODataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.hORASVOLADASDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.listaPilotos)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSetUsuarios)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dTPilotosBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(252, 71);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(270, 38);
            this.label1.TabIndex = 63;
            this.label1.Text = "Listado de pilotos";
            // 
            // btnCargar
            // 
            this.btnCargar.Location = new System.Drawing.Point(47, 193);
            this.btnCargar.Name = "btnCargar";
            this.btnCargar.Size = new System.Drawing.Size(117, 38);
            this.btnCargar.TabIndex = 65;
            this.btnCargar.Text = "Cargar Datos";
            this.btnCargar.UseSelectable = true;
            this.btnCargar.Click += new System.EventHandler(this.btnCargar_Click);
            // 
            // listaPilotos
            // 
            this.listaPilotos.AllowUserToAddRows = false;
            this.listaPilotos.AllowUserToDeleteRows = false;
            this.listaPilotos.AllowUserToResizeRows = false;
            this.listaPilotos.AutoGenerateColumns = false;
            this.listaPilotos.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.listaPilotos.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.listaPilotos.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
            this.listaPilotos.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(243)))), ((int)(((byte)(119)))), ((int)(((byte)(53)))));
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(244)))), ((int)(((byte)(133)))), ((int)(((byte)(72)))));
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.listaPilotos.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.listaPilotos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.listaPilotos.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.rUTDataGridViewTextBoxColumn,
            this.nOMBRESDataGridViewTextBoxColumn,
            this.aPPATERNODataGridViewTextBoxColumn,
            this.aPMATERNODataGridViewTextBoxColumn,
            this.hORASVOLADASDataGridViewTextBoxColumn});
            this.listaPilotos.DataSource = this.dTPilotosBindingSource;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(136)))), ((int)(((byte)(136)))), ((int)(((byte)(136)))));
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(244)))), ((int)(((byte)(133)))), ((int)(((byte)(72)))));
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.listaPilotos.DefaultCellStyle = dataGridViewCellStyle2;
            this.listaPilotos.EnableHeadersVisualStyles = false;
            this.listaPilotos.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.listaPilotos.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.listaPilotos.Location = new System.Drawing.Point(36, 254);
            this.listaPilotos.Name = "listaPilotos";
            this.listaPilotos.ReadOnly = true;
            this.listaPilotos.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(243)))), ((int)(((byte)(119)))), ((int)(((byte)(53)))));
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(244)))), ((int)(((byte)(133)))), ((int)(((byte)(72)))));
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.listaPilotos.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.listaPilotos.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.listaPilotos.RowTemplate.Height = 24;
            this.listaPilotos.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.listaPilotos.Size = new System.Drawing.Size(678, 333);
            this.listaPilotos.Style = MetroFramework.MetroColorStyle.Orange;
            this.listaPilotos.TabIndex = 66;
            this.listaPilotos.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.listaPilotos_CellContentClick);
            // 
            // dataSetUsuarios
            // 
            this.dataSetUsuarios.DataSetName = "DataSetUsuarios";
            this.dataSetUsuarios.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // dTPilotosBindingSource
            // 
            this.dTPilotosBindingSource.DataMember = "DTPilotos";
            this.dTPilotosBindingSource.DataSource = this.dataSetUsuarios;
            // 
            // dTPilotosTableAdapter
            // 
            this.dTPilotosTableAdapter.ClearBeforeFill = true;
            // 
            // rUTDataGridViewTextBoxColumn
            // 
            this.rUTDataGridViewTextBoxColumn.DataPropertyName = "RUT";
            this.rUTDataGridViewTextBoxColumn.HeaderText = "RUT";
            this.rUTDataGridViewTextBoxColumn.Name = "rUTDataGridViewTextBoxColumn";
            this.rUTDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // nOMBRESDataGridViewTextBoxColumn
            // 
            this.nOMBRESDataGridViewTextBoxColumn.DataPropertyName = "NOMBRES";
            this.nOMBRESDataGridViewTextBoxColumn.HeaderText = "NOMBRES";
            this.nOMBRESDataGridViewTextBoxColumn.Name = "nOMBRESDataGridViewTextBoxColumn";
            this.nOMBRESDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // aPPATERNODataGridViewTextBoxColumn
            // 
            this.aPPATERNODataGridViewTextBoxColumn.DataPropertyName = "AP_PATERNO";
            this.aPPATERNODataGridViewTextBoxColumn.HeaderText = "APELLIDO PATERNO";
            this.aPPATERNODataGridViewTextBoxColumn.Name = "aPPATERNODataGridViewTextBoxColumn";
            this.aPPATERNODataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // aPMATERNODataGridViewTextBoxColumn
            // 
            this.aPMATERNODataGridViewTextBoxColumn.DataPropertyName = "AP_MATERNO";
            this.aPMATERNODataGridViewTextBoxColumn.HeaderText = "APELLIDO MATERNO";
            this.aPMATERNODataGridViewTextBoxColumn.Name = "aPMATERNODataGridViewTextBoxColumn";
            this.aPMATERNODataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // hORASVOLADASDataGridViewTextBoxColumn
            // 
            this.hORASVOLADASDataGridViewTextBoxColumn.DataPropertyName = "HORAS_VOLADAS";
            this.hORASVOLADASDataGridViewTextBoxColumn.HeaderText = "HORAS VOLADAS";
            this.hORASVOLADASDataGridViewTextBoxColumn.Name = "hORASVOLADASDataGridViewTextBoxColumn";
            this.hORASVOLADASDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // Form_ListarPiloto
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(754, 650);
            this.Controls.Add(this.listaPilotos);
            this.Controls.Add(this.btnCargar);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Form_ListarPiloto";
            this.Text = "Form_ListarPiloto";
            this.Load += new System.EventHandler(this.Form_ListarPiloto_Load);
            ((System.ComponentModel.ISupportInitialize)(this.listaPilotos)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSetUsuarios)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dTPilotosBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private MetroFramework.Controls.MetroButton btnCargar;
        private MetroFramework.Controls.MetroGrid listaPilotos;
        private DataSetUsuarios dataSetUsuarios;
        private System.Windows.Forms.BindingSource dTPilotosBindingSource;
        private DataSetUsuariosTableAdapters.DTPilotosTableAdapter dTPilotosTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn rUTDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn nOMBRESDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn aPPATERNODataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn aPMATERNODataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn hORASVOLADASDataGridViewTextBoxColumn;
    }
}
namespace CapaPresentacion
{
    partial class FormValidarLicencias
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            this.btbGenerar = new MetroFramework.Controls.MetroButton();
            this.txtLicencia = new MetroFramework.Controls.MetroTextBox();
            this.metroLabel1 = new MetroFramework.Controls.MetroLabel();
            this.listaMultas = new MetroFramework.Controls.MetroGrid();
            this.metroLabel4 = new MetroFramework.Controls.MetroLabel();
            ((System.ComponentModel.ISupportInitialize)(this.listaMultas)).BeginInit();
            this.SuspendLayout();
            // 
            // btbGenerar
            // 
            this.btbGenerar.BackColor = System.Drawing.Color.Transparent;
            this.btbGenerar.Location = new System.Drawing.Point(339, 136);
            this.btbGenerar.Name = "btbGenerar";
            this.btbGenerar.Size = new System.Drawing.Size(131, 29);
            this.btbGenerar.Style = MetroFramework.MetroColorStyle.Blue;
            this.btbGenerar.TabIndex = 84;
            this.btbGenerar.Text = "Consultar";
            this.btbGenerar.Theme = MetroFramework.MetroThemeStyle.Light;
            this.btbGenerar.UseCustomForeColor = true;
            this.btbGenerar.UseSelectable = true;
            this.btbGenerar.UseStyleColors = true;
            // 
            // txtLicencia
            // 
            this.txtLicencia.BackColor = System.Drawing.Color.White;
            // 
            // 
            // 
            this.txtLicencia.CustomButton.Image = null;
            this.txtLicencia.CustomButton.Location = new System.Drawing.Point(117, 1);
            this.txtLicencia.CustomButton.Name = "";
            this.txtLicencia.CustomButton.Size = new System.Drawing.Size(27, 27);
            this.txtLicencia.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txtLicencia.CustomButton.TabIndex = 1;
            this.txtLicencia.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txtLicencia.CustomButton.UseSelectable = true;
            this.txtLicencia.CustomButton.Visible = false;
            this.txtLicencia.Lines = new string[0];
            this.txtLicencia.Location = new System.Drawing.Point(163, 136);
            this.txtLicencia.MaxLength = 32767;
            this.txtLicencia.Name = "txtLicencia";
            this.txtLicencia.PasswordChar = '\0';
            this.txtLicencia.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtLicencia.SelectedText = "";
            this.txtLicencia.SelectionLength = 0;
            this.txtLicencia.SelectionStart = 0;
            this.txtLicencia.ShortcutsEnabled = true;
            this.txtLicencia.Size = new System.Drawing.Size(145, 29);
            this.txtLicencia.Style = MetroFramework.MetroColorStyle.Blue;
            this.txtLicencia.TabIndex = 83;
            this.txtLicencia.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txtLicencia.UseSelectable = true;
            this.txtLicencia.UseStyleColors = true;
            this.txtLicencia.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txtLicencia.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // metroLabel1
            // 
            this.metroLabel1.AutoSize = true;
            this.metroLabel1.Location = new System.Drawing.Point(23, 136);
            this.metroLabel1.Name = "metroLabel1";
            this.metroLabel1.Size = new System.Drawing.Size(83, 20);
            this.metroLabel1.TabIndex = 82;
            this.metroLabel1.Text = "N° Licencia:";
            // 
            // listaMultas
            // 
            this.listaMultas.AllowUserToAddRows = false;
            this.listaMultas.AllowUserToDeleteRows = false;
            this.listaMultas.AllowUserToResizeRows = false;
            this.listaMultas.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.listaMultas.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.listaMultas.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
            this.listaMultas.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(174)))), ((int)(((byte)(219)))));
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(198)))), ((int)(((byte)(247)))));
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.listaMultas.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle4;
            this.listaMultas.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle5.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle5.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(136)))), ((int)(((byte)(136)))), ((int)(((byte)(136)))));
            dataGridViewCellStyle5.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(198)))), ((int)(((byte)(247)))));
            dataGridViewCellStyle5.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.listaMultas.DefaultCellStyle = dataGridViewCellStyle5;
            this.listaMultas.EnableHeadersVisualStyles = false;
            this.listaMultas.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.listaMultas.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.listaMultas.Location = new System.Drawing.Point(23, 214);
            this.listaMultas.Name = "listaMultas";
            this.listaMultas.ReadOnly = true;
            this.listaMultas.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle6.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(174)))), ((int)(((byte)(219)))));
            dataGridViewCellStyle6.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle6.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle6.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(198)))), ((int)(((byte)(247)))));
            dataGridViewCellStyle6.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle6.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.listaMultas.RowHeadersDefaultCellStyle = dataGridViewCellStyle6;
            this.listaMultas.RowHeadersWidth = 50;
            this.listaMultas.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.listaMultas.RowTemplate.Height = 24;
            this.listaMultas.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.listaMultas.Size = new System.Drawing.Size(501, 146);
            this.listaMultas.Style = MetroFramework.MetroColorStyle.Blue;
            this.listaMultas.TabIndex = 81;
            // 
            // metroLabel4
            // 
            this.metroLabel4.AutoSize = true;
            this.metroLabel4.Location = new System.Drawing.Point(23, 70);
            this.metroLabel4.Name = "metroLabel4";
            this.metroLabel4.Size = new System.Drawing.Size(197, 20);
            this.metroLabel4.TabIndex = 80;
            this.metroLabel4.Text = "Validación de Licencias Pilotos.";
            // 
            // FormValidarLicencias
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(689, 385);
            this.Controls.Add(this.btbGenerar);
            this.Controls.Add(this.txtLicencia);
            this.Controls.Add(this.metroLabel1);
            this.Controls.Add(this.listaMultas);
            this.Controls.Add(this.metroLabel4);
            this.Name = "FormValidarLicencias";
            this.Text = "Dirección General de Aeronáutica Civil";
            this.Load += new System.EventHandler(this.FormValidarLicencias_Load);
            ((System.ComponentModel.ISupportInitialize)(this.listaMultas)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private MetroFramework.Controls.MetroButton btbGenerar;
        public MetroFramework.Controls.MetroTextBox txtLicencia;
        private MetroFramework.Controls.MetroLabel metroLabel1;
        private MetroFramework.Controls.MetroGrid listaMultas;
        private MetroFramework.Controls.MetroLabel metroLabel4;
    }
}
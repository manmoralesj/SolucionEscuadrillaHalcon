namespace CapaPresentacion
{
    partial class Form_EliminarComponente
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
            this.metroButton1 = new MetroFramework.Controls.MetroButton();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.metroLabel1 = new MetroFramework.Controls.MetroLabel();
            this.label1 = new System.Windows.Forms.Label();
            this.cboComponentes = new MetroFramework.Controls.MetroComboBox();
            this.dataSetComponentes = new CapaPresentacion.DataSetComponentes();
            this.dataSetComponentesBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.cOMPONENTESBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.cOMPONENTESTableAdapter = new CapaPresentacion.DataSetComponentesTableAdapters.COMPONENTESTableAdapter();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataSetComponentes)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSetComponentesBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cOMPONENTESBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // metroButton1
            // 
            this.metroButton1.Location = new System.Drawing.Point(90, 318);
            this.metroButton1.Name = "metroButton1";
            this.metroButton1.Size = new System.Drawing.Size(119, 34);
            this.metroButton1.TabIndex = 73;
            this.metroButton1.Text = "Desactivar";
            this.metroButton1.UseSelectable = true;
            this.metroButton1.Click += new System.EventHandler(this.metroButton1_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.cboComponentes);
            this.groupBox1.Controls.Add(this.metroLabel1);
            this.groupBox1.Location = new System.Drawing.Point(90, 200);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(482, 88);
            this.groupBox1.TabIndex = 72;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Búsqueda Componente";
            this.groupBox1.Enter += new System.EventHandler(this.groupBox1_Enter);
            // 
            // metroLabel1
            // 
            this.metroLabel1.AutoSize = true;
            this.metroLabel1.Location = new System.Drawing.Point(32, 43);
            this.metroLabel1.Name = "metroLabel1";
            this.metroLabel1.Size = new System.Drawing.Size(64, 20);
            this.metroLabel1.TabIndex = 66;
            this.metroLabel1.Text = "Nombre:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(166, 120);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(368, 38);
            this.label1.TabIndex = 74;
            this.label1.Text = "Desactivar Componente";
            // 
            // cboComponentes
            // 
            this.cboComponentes.DataSource = this.cOMPONENTESBindingSource;
            this.cboComponentes.DisplayMember = "NOMBRE";
            this.cboComponentes.FormattingEnabled = true;
            this.cboComponentes.ItemHeight = 24;
            this.cboComponentes.Location = new System.Drawing.Point(191, 33);
            this.cboComponentes.Name = "cboComponentes";
            this.cboComponentes.Size = new System.Drawing.Size(157, 30);
            this.cboComponentes.Style = MetroFramework.MetroColorStyle.Orange;
            this.cboComponentes.TabIndex = 75;
            this.cboComponentes.UseSelectable = true;
            this.cboComponentes.ValueMember = "IDCOMPONENTE";
            // 
            // dataSetComponentes
            // 
            this.dataSetComponentes.DataSetName = "DataSetComponentes";
            this.dataSetComponentes.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // dataSetComponentesBindingSource
            // 
            this.dataSetComponentesBindingSource.DataSource = this.dataSetComponentes;
            this.dataSetComponentesBindingSource.Position = 0;
            // 
            // cOMPONENTESBindingSource
            // 
            this.cOMPONENTESBindingSource.DataMember = "COMPONENTES";
            this.cOMPONENTESBindingSource.DataSource = this.dataSetComponentes;
            // 
            // cOMPONENTESTableAdapter
            // 
            this.cOMPONENTESTableAdapter.ClearBeforeFill = true;
            // 
            // Form_EliminarComponente
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(640, 567);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.metroButton1);
            this.Controls.Add(this.groupBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Form_EliminarComponente";
            this.Text = "Form_EliminarComponente";
            this.Load += new System.EventHandler(this.Form_EliminarComponente_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataSetComponentes)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSetComponentesBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cOMPONENTESBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private MetroFramework.Controls.MetroButton metroButton1;
        private System.Windows.Forms.GroupBox groupBox1;
        private MetroFramework.Controls.MetroLabel metroLabel1;
        private System.Windows.Forms.Label label1;
        private MetroFramework.Controls.MetroComboBox cboComponentes;
        private System.Windows.Forms.BindingSource dataSetComponentesBindingSource;
        private DataSetComponentes dataSetComponentes;
        private System.Windows.Forms.BindingSource cOMPONENTESBindingSource;
        private DataSetComponentesTableAdapters.COMPONENTESTableAdapter cOMPONENTESTableAdapter;
    }
}
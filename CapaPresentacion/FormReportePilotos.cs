using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CapaPresentacion
{
    public partial class FormReportePilotos : Form
    {
        public FormReportePilotos()
        {
            InitializeComponent();
        }

        private void FormReportePilotos_Load(object sender, EventArgs e)
        {
           

        }

        private void chkAviones_CheckedChanged(object sender, EventArgs e)
        {
            if (chkAviones.Checked)
            {
                object obj;
                // TODO: esta línea de código carga datos en la tabla 'DataSetReportePilotos.SP_REPORTE_PILOTOS' Puede moverla o quitarla según sea necesario.
                this.SP_REPORTE_PILOTOSTableAdapter.Fill(this.DataSetReportePilotos.SP_REPORTE_PILOTOS, out obj, 1);
                this.reportViewer1.RefreshReport();
            }
        }

        private void chkHelicopteros_CheckedChanged(object sender, EventArgs e)
        {
            if (chkHelicopteros.Checked)
            {
                object obj;
                // TODO: esta línea de código carga datos en la tabla 'DataSetReportePilotos.SP_REPORTE_PILOTOS' Puede moverla o quitarla según sea necesario.
                this.SP_REPORTE_PILOTOSTableAdapter.Fill(this.DataSetReportePilotos.SP_REPORTE_PILOTOS, out obj, 2);
                this.reportViewer1.RefreshReport();
            }
        }
    }
}

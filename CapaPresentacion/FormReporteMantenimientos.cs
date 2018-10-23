using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace CapaPresentacion
{
    public partial class FormReporteMantenimientos : Form
    {
        public FormReporteMantenimientos()
        {
            InitializeComponent();
        }

        private void chkAeronaves_CheckedChanged(object sender, EventArgs e)
        {
            if (chkAeronaves.Checked)
            {
                reportViewer1.Clear();
                reportViewer1.LocalReport.ReportPath = Path.Combine(Application.StartupPath, "../../Reporte_Mantenimiento_Aer.rdlc");
                object man;
                // TODO: esta línea de código carga datos en la tabla 'DataSetMantenimientoAeronaves.SP_REPORTE_MANT_AERONAVES' Puede moverla o quitarla según sea necesario.
                this.SP_REPORTE_MANT_AERONAVESTableAdapter.Fill(this.DataSetMantenimientoAeronaves.SP_REPORTE_MANT_AERONAVES, out man);

                this.reportViewer1.RefreshReport();

            }
        }

        private void chkComponentes_CheckedChanged(object sender, EventArgs e)
        {
            if (chkComponentes.Checked)
            {
                reportViewer1.Clear();
                reportViewer2.LocalReport.ReportPath = Path.Combine(Application.StartupPath, "../../Reporte_Mantenimiento_Comp.rdlc");
                object man1;

                // TODO: esta línea de código carga datos en la tabla 'DataSetMantComponente.SP_REPORTE_MANT_COMPONENTES' Puede moverla o quitarla según sea necesario.
                this.SP_REPORTE_MANT_COMPONENTESTableAdapter.Fill(this.DataSetMantComponente.SP_REPORTE_MANT_COMPONENTES, out man1);



                this.reportViewer2.RefreshReport();

            }
        }

        private void FormReporteMantenimientos_Load(object sender, EventArgs e)
        {
            


        }

        private void reportViewer2_Load(object sender, EventArgs e)
        {

        }
    }
}
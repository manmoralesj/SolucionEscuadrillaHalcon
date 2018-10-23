using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using CapaDALC;
namespace CapaPresentacion
{
    public partial class Form_ReporteAeronaves : Form
    {
        int aeronave;

        public Form_ReporteAeronaves()
        {
            InitializeComponent();
        }



        private void Form_ReporteAeronaves_Load(object sender, EventArgs e)
        {
            


        }

        private void chkAviones_CheckedChanged(object sender, EventArgs e)
        {
            
        }

        private void chkAviones_CheckedChanged_1(object sender, EventArgs e)
        {
            if (chkAviones.Checked)
            {
                object aer;
                // TODO: esta línea de código carga datos en la tabla 'DataSetMantAeronave.SP_REPORTE_MANT_AERONAVES' Puede moverla o quitarla según sea necesario.
                this.SP_REPORTE_AERNAVESTableAdapter.Fill(this.DataSetReporteAeronaves.SP_REPORTE_AERNAVES, out aer, 1);
                this.reportViewer1.RefreshReport();
            }
        }

        private void chkHelicopteros_CheckedChanged(object sender, EventArgs e)
        {
            if (chkHelicopteros.Checked)
            {
                object aer;
                // TODO: esta línea de código carga datos en la tabla 'DataSetMantAeronave.SP_REPORTE_MANT_AERONAVES' Puede moverla o quitarla según sea necesario.
                this.SP_REPORTE_AERNAVESTableAdapter.Fill(this.DataSetReporteAeronaves.SP_REPORTE_AERNAVES, out aer,2);
                this.reportViewer1.RefreshReport();
            }
        }

        private void reportViewer1_Load(object sender, EventArgs e)
        {

        }
    }
}

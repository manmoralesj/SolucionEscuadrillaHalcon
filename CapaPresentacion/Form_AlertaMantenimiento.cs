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
    public partial class Form_AlertaMantenimiento : MetroFramework.Forms.MetroForm
    {
        public Form_AlertaMantenimiento()
        {
            InitializeComponent();
            
        }

        private void Form_AlertaMantenimiento_Load(object sender, EventArgs e)
        {
            object al;
            this.sP_ALERTA_INSPECCION_ANUALTableAdapter.Fill(this.dataSetAlertaMantenimiento.SP_ALERTA_INSPECCION_ANUAL,out al);
        }

        private void metroGrid1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}

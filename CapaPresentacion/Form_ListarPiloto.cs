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
using CapaNegocio;

namespace CapaPresentacion
{
    public partial class Form_ListarPiloto : Form
    {
        public Form_ListarPiloto()
        {
            InitializeComponent();
            //dtListado.DataSource = dao.listarMenu();
        }

        private void btnCargar_Click(object sender, EventArgs e)
        {

            // TODO: esta línea de código carga datos en la tabla 'dataSetUsuarios.DTPilotos' Puede moverla o quitarla según sea necesario.
            this.dTPilotosTableAdapter.FillPilotos(this.dataSetUsuarios.DTPilotos);
        }

        private void Form_ListarPiloto_Load(object sender, EventArgs e)
        {
           


        }

        private void listaPilotos_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}

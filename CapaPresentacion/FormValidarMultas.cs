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
    public partial class FormValidarMultas : MetroFramework.Forms.MetroForm
    {
        public FormValidarMultas()
        {
            InitializeComponent();
        }

        private void FormValidarLicencias_Load(object sender, EventArgs e)
        {

        }

        private void btbGenerar_Click(object sender, EventArgs e)
        {
            try
            {
               ServiceReferenceDGAC.webservice_dgacClient cliente = new ServiceReferenceDGAC.webservice_dgacClient();

               listaMultas.DataSource = cliente.MultasByRut(txtRut.Text).ToList();

                if (cliente.validarMultasbyRut(txtRut.Text))
                {
                    label1.Text = "Piloto Invalidado";
                    
                }
                else
                {
                    label1.Text = "Piloto Apto para el vuelo";
                }

            }
            catch (Exception)
            {

                throw;
            }
        }

        private void listaMultas_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}

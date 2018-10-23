using CapaNegocio;
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
    public partial class Form_EliminarAeronave : Form
    {
        public Form_EliminarAeronave()
        {
            InitializeComponent();
            desactivarControles();
        }

        private void desactivarControles()
        {
            txtHorasVoladas.Enabled = false;
            txtAnioFab.Enabled = false;
            txtFechaInspeccion.Enabled = false;
            btnDesactivar.Enabled = false;
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            try
            {
                DAO_Aeronave dao = new DAO_Aeronave();

                string matricula = txtMatricula.Text;
                List<AERONAVES> LC = dao.BuscarAeronave(matricula);
                foreach (var item in LC)
                {

                    txtHorasVoladas.Text = item.HORAS_VOLADAS.ToString();
                    txtAnioFab.Text = item.ANIO_FAB.ToString();
                    txtFechaInspeccion.Value = DateTime.Parse(item.FECHA_INSPECCION_ANUAL.ToString());

                }
                txtMatricula.Enabled = false;
                btnDesactivar.Enabled = true;
                MessageBox.Show("Aeronave Encontrada exitosamente", "Busqueda correcta");
            }
            catch (Exception)
            {

                MessageBox.Show("Aeronave NO Encontrada, por favor verifique la matrícula", "Busqueda incorrecta");
            }
        }

        private void btnDesactivar_Click(object sender, EventArgs e)
        {
            try
            {
                string patente = txtMatricula.Text;

                DAO_Aeronave dao = new DAO_Aeronave();

                bool resp = dao.DesactivarAeronave(patente);

                if (resp)
                {
                    MessageBox.Show(this, "Componente Desactivado Exitosamente!");
                }
                else
                {
                    MessageBox.Show(this, "Error al Generar Solicitud");
                }
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message, "Error Inesperado");
            }

        }
    }
}

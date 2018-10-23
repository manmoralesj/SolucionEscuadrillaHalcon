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
    public partial class Form_EliminarPiloto : Form
    {
        public Form_EliminarPiloto()
        {
            InitializeComponent();
            desactivarControles();
        }

        private void limpiarControles()
        {
            txtNombre.Clear();
            txtApPaterno.Clear();
            txtApMaterno.Clear();
            txtRut.Clear();
            txtRut.Enabled = true;
        }
        private void desactivarControles()
        {
            txtNombre.Enabled = false;
            txtApPaterno.Enabled = false;
            txtApMaterno.Enabled = false;
        }

        private void metroButton2_Click(object sender, EventArgs e)
        {
            try
            {
                DAO_Piloto dao = new DAO_Piloto();
                string rut = txtRut.Text;
                List<USUARIOS> LC = dao.BuscarPiloto(rut);
                foreach (var item in LC)
                {

                    txtNombre.Text = item.NOMBRES;
                    txtApPaterno.Text = item.AP_PATERNO;
                    txtApMaterno.Text = item.AP_MATERNO;
                    txtRut.Enabled = false;

                }


            }
            catch (Exception)
            {

                MessageBox.Show("Error al encontrar piloto");
            }
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            try
            {
                DAO_Piloto dao = new DAO_Piloto();
                PILOTOS pil = new PILOTOS();

                string rut = txtRut.Text;

                bool resp = dao.EliminarPiloto(rut);
                if (resp)
                {
                    MessageBox.Show("El Piloto " + rut + " ha sido eliminado del sistema.","Operación Exitosa");

                }
                else
                {
                    MessageBox.Show("Se ha producido un error, verifique los datos y vuelva a intentar.", "Error en la Operación");
                }
            }
            catch (Exception ex)
            {

                MessageBox.Show("Error inesperado: " +ex.Message, "Error en la Operación");
            }
        }
    }
}

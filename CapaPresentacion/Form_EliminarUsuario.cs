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
    public partial class Form_EliminarUsuario : Form
    {
        public Form_EliminarUsuario()
        {
            InitializeComponent();
            desactivarControles();
            txtLimpiar.Visible = false;
        }

        private void limpiarControles()
        {
            txtNombres.Clear();
            txtApPaterno.Clear();
            txtApMaterno.Clear();
            txtRut.Clear();
            txtRut.Enabled = true;
        }
        private void desactivarControles()
        {
            txtNombres.Enabled = false;
            txtApPaterno.Enabled = false;
            txtApMaterno.Enabled = false;
        }
        private void btnBuscar_Click(object sender, EventArgs e)
        {
            try
            {
                DAO_Usuario dao = new DAO_Usuario();
                string rut = txtRut.Text;
                List<USUARIOS> LC = dao.BuscarUsuario(rut);
                foreach (var item in LC)
                {

                    txtNombres.Text = item.NOMBRES;
                    txtApPaterno.Text = item.AP_PATERNO;
                    txtApMaterno.Text = item.AP_MATERNO;
                    txtRut.Enabled = false;
                    txtLimpiar.Visible = true;
                }
            }
            catch (Exception)
            {

                MessageBox.Show("Error al encontrar usuario");
            }
        }

        private void btnDesactivar_Click(object sender, EventArgs e)
        {
            try
            {
                DAO_Usuario dao = new DAO_Usuario();
                USUARIOS usu = new USUARIOS();

                string rut = txtRut.Text;

                bool resp = dao.DesactivarUsuario(rut);
                if (resp)
                {
                    MessageBox.Show("El usuario " + rut + " ha sido desactivado del sistema.", "Operación Exitosa");
                    limpiarControles();
                    txtLimpiar.Visible = false;

                }
                else
                {
                    MessageBox.Show("Se ha producido un error, verifique los datos y vuelva a intentar.", "Error en la Operación");
                }
            }
            catch (Exception ex)
            {

                MessageBox.Show("Error inesperado: " + ex.Message, "Error en la Operación");
            }
        }

        private void txtLimpiar_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            limpiarControles();
        }
    }
}

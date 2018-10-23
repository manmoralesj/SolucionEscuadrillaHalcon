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
    public partial class Form_ModificarPiloto : Form
    {
        private string pass;
        public Form_ModificarPiloto()
        {
            InitializeComponent();
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            try
            {
                DAO_Piloto dao = new DAO_Piloto();
                string rut = txtRut.Text;
                List<USUARIOS> LC = dao.BuscarPiloto(rut);
                foreach (var item in LC)
                {

                    txtNombres.Text = item.NOMBRES;
                    txtApPaterno.Text = item.AP_PATERNO;
                    txtApMaterno.Text = item.AP_MATERNO;

                    txtDireccion.Text = item.DOMICILIO;
                    txtCelular.Text = item.TEL_CEL.ToString();
                    txtTelFijo.Text = item.TEL_FIJO.ToString();
                    txtCorreo.Text = item.CORREO;


                }


                DAO_Credenciales daoc = new DAO_Credenciales();
                List<CREDENCIALES> LC1 = daoc.BuscarCredenciales(rut);
                foreach (var item in LC1)
                {

                    txtPass.Text = item.PW;
                    txtConfirmarPass.Text = item.PW;


                }
            }
            catch (Exception)
            {

                MessageBox.Show("Error al encontrar piloto");
            }
        }

        private void metroButton1_Click(object sender, EventArgs e)
        {
            try
            {
                DAO_Piloto dao = new DAO_Piloto();
                PILOTOS pi = new PILOTOS();
                USUARIOS usu = new USUARIOS();

                usu.ESTADO_IDESTADO = 1;
                pi.RUT = txtRut.Text;
                usu.NOMBRES = txtNombres.Text;
                usu.AP_PATERNO = txtApPaterno.Text;
                usu.AP_MATERNO = txtApMaterno.Text;
                usu.DOMICILIO = txtDireccion.Text;
                usu.TEL_CEL = int.Parse(txtCelular.Text);
                if (txtTelFijo.Text.Length.Equals(0))
                {
                    usu.TEL_FIJO = 0;
                }
                else
                {
                    usu.TEL_FIJO = int.Parse(txtTelFijo.Text);
                }

                usu.CORREO = txtCorreo.Text;
                pi.HORAS_VOLADAS = 0;

                if (txtPass.Text.Equals(txtConfirmarPass.Text))
                {
                    pass = txtPass.Text;
                }
                else
                {
                    MessageBox.Show("Error: Las contraseñas no coinciden", "Error de credenciales");
                }



                bool resp = dao.ModificarPiloto(usu, pi,pass);

                if (resp)
                {
                    MessageBox.Show("Piloto Modificado Exitosamente en el sistema", "Operación Exitosa");
                }
                else
                {
                    MessageBox.Show("Error: no se ha podido completar la solicitud. Verifique los datos e intente nuevamente.", "Error de datos");
                }

            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message, "Error inesperado.");
            }
        }

        private void txtCelular_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (Char.IsDigit(e.KeyChar))
            {
                e.Handled = false;
            }
            else if (Char.IsControl(e.KeyChar))
            {
                e.Handled = false;
            }
            else if (Char.IsSeparator(e.KeyChar))
            {
                e.Handled = false;
            }
            else
            {
                e.Handled = true;
            }
        }

        private void txtTelFijo_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (Char.IsDigit(e.KeyChar))
            {
                e.Handled = false;
            }
            else if (Char.IsControl(e.KeyChar))
            {
                e.Handled = false;
            }
            else if (Char.IsSeparator(e.KeyChar))
            {
                e.Handled = false;
            }
            else
            {
                e.Handled = true;
            }
        }
    }
}

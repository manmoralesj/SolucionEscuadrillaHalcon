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
    public partial class Form_AgregarOperador : Form
    {
        private string pass;
        public Form_AgregarOperador()
        {
            InitializeComponent();
        }

        private void btnInscribir_Click(object sender, EventArgs e)
        {
            try
            {
                DAO_Operador dao = new DAO_Operador();
                OPERARIOS op = new OPERARIOS();
                USUARIOS usu = new USUARIOS();

                usu.ESTADO_IDESTADO = 1;
                op.RUT = txtRut.Text;
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

                if (txtPass.Text.Equals(txtConfirmarPass.Text))
                {
                    pass = txtPass.Text;
                }
                else
                {
                    MessageBox.Show("Error: Las contraseñas no coinciden", "Error de credenciales");
                }

                bool resp = dao.AgregarOperador(usu, op, pass);

                if (resp)
                {
                    MessageBox.Show("Operador Registrado Exitosamente en el sistema", "Operación Exitosa");
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

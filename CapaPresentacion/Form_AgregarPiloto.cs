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
    public partial class Form_AgregarPiloto : Form
    {
        string pass;
        //1 = invalidado; 2 = validado
        int multasPiloto;
        //1 = invalidado; 2 = validado
        int estadoLicenciaPiloto=0, estadoLicenciaCopiloto=0;
        public Form_AgregarPiloto()
        {
            InitializeComponent();
        }
        public void limpiar()
        {
            txtApMaterno.Clear();
            txtApPaterno.Clear();
            txtCelular.Clear();
            txtConfirmarPass.Clear();
            txtCorreo.Clear();
            txtDireccion.Clear();
            txtLicAvion.Clear();
            txtLicHelicoptero.Clear();
            txtNombres.Clear();
            txtPass.Clear();
            txtRut.Clear();
            txtRut.Enabled = true;
            txtTelFijo.Clear();
            chkAvion.Checked = false;
            chkHelicoptero.Checked = false;
        
        }
        private void metroButton1_Click(object sender, EventArgs e)
        {
            try
            {
                if (estadoLicenciaPiloto.Equals(2)&& estadoLicenciaCopiloto.Equals(2))
                {
                    if (multasPiloto.Equals(2))
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

                        bool resp = dao.AgregarPiloto(usu, pi, pass);

                        if (resp)
                        {
                            MessageBox.Show("Piloto Registrado Exitosamente en el sistema", "Operación Exitosa");
                            
                        }
                        else
                        {
                            MessageBox.Show("Error: no se ha podido completar la solicitud. Verifique los datos  y la existencia del rut e intente nuevamente.", "Error de datos");
                        }
                    }
                    else
                    {
                        MessageBox.Show("El piloto debe estar correctamente validado y sin multas para poder ser registrado al sistema", "Problemas con el piloto");
                    }
                }
                else
                {
                    MessageBox.Show("Por favor, verifique correctamente las licencias y vuelva a intentar", "Problemas con las licencias");
                }

               
            }
            catch (Exception ex )
            {

                MessageBox.Show(ex.Message, "Error inesperado.");
            }
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void groupBox2_Enter(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void metroLink1_Click(object sender, EventArgs e)
        {
            try
            {
                ServiceReferenceDGAC.webservice_dgacClient cliente = new ServiceReferenceDGAC.webservice_dgacClient();

                if (chkAvion.Checked)
                {
                    if (cliente.existeLicencia(int.Parse(txtLicAvion.Text)))
                    {
                        estadoLicenciaPiloto = 2;
                        imgPilotoV.Visible = true;
                        imgPilotoNV.Visible = false;
                        lblLicAviones.Text = "Licencia Aviones correcta.";

                    }
                    else
                    {

                        estadoLicenciaPiloto = 1;
                        imgPilotoV.Visible = false;
                        imgPilotoNV.Visible = true;
                        lblLicAviones.Text = "Licencia Aviones incorrecta.";
                    }
                }
                else
                {
                    estadoLicenciaPiloto = 2;
                }
                if (chkHelicoptero.Checked)
                {
                    if (cliente.existeLicencia(int.Parse(txtLicHelicoptero.Text)))
                    {
                        estadoLicenciaCopiloto = 2;
                        imgPilotoV.Visible = true;
                        imgPilotoNV.Visible = false;
                        lblLicHelicopteros.Text = "Licencia Helicópteros correcta.";
                    }
                    else
                    {
                        estadoLicenciaCopiloto = 1;
                        imgPilotoV.Visible = false;
                        imgPilotoNV.Visible = true;
                        lblLicHelicopteros.Text = "Licencia Helicópteros incorrecta.";

                    }
                }
                else
                {
                    estadoLicenciaCopiloto = 2;
                }




            }
            catch (Exception)
            {

                throw;
            }


        }

        private void btnMultas_Click(object sender, EventArgs e)
        {

            try
            {
                ServiceReferenceDGAC.webservice_dgacClient cliente = new ServiceReferenceDGAC.webservice_dgacClient();


                if (cliente.validarMultasbyRut(txtRut.Text))
                {
                    multasPiloto = 1;
                    
                    btnInscribir.Enabled = false;


                    DialogResult result = MessageBox.Show(this, "Acorde con los datos de La Dirección General de Aeronáutica Civil, el Rut posee multas invalidantes para ser agregado al sistema. ¿Desea ver Detalles? ", "Piloto Invalidado", MessageBoxButtons.YesNo);

                    if (result == DialogResult.Yes)
                    {

                        FormValidarMultas form = new FormValidarMultas();
                        form.txtRut.Text = txtRut.Text;
                        form.Show();

                    }
                    
                }
                else
                {

                    multasPiloto = 2;
                    MessageBox.Show("El usuario no registra multas invalidantes en los registros de la Dirección General de Aeronáutica Civil " ,"Piloto Válido");
                    btnInscribir.Enabled = true;
                    txtRut.Enabled = false;
                }
                
            }
            catch (Exception)
            {

                throw;
            }
          
            
        }

        private void Form_AgregarPiloto_Load(object sender, EventArgs e)
        {
            txtLicAvion.Enabled = false;
            txtLicHelicoptero.Enabled = false;
        }

        private void chkAvion_CheckedChanged(object sender, EventArgs e)
        {
            if (chkAvion.Checked)
            {
                txtLicAvion.Enabled = true;
            }
            else
            {
                txtLicAvion.Enabled = false;
                lblLicAviones.Text = "";
            }
        }

        private void chkHelicoptero_CheckedChanged(object sender, EventArgs e)
        {
            if (chkHelicoptero.Checked)
            {
                txtLicHelicoptero.Enabled = true;
            }
            else
            {
                txtLicHelicoptero.Enabled = false;
                lblLicHelicopteros.Text = "";
            }
        }

        private void groupBox3_Enter(object sender, EventArgs e)
        {

        }

        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            limpiar();
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

        private void txtLicAvion_KeyPress(object sender, KeyPressEventArgs e)
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

        private void txtLicHelicoptero_KeyPress(object sender, KeyPressEventArgs e)
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

        private void lblDetalles_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            FormValidarMultas form = new FormValidarMultas();
            form.txtRut.Text = txtRut.Text;
            form.Show();
        }
    }
}

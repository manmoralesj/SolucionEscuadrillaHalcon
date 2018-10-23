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
    public partial class Form_IngresarAeronave : Form
    {
        int tipoAeronave;
        public Form_IngresarAeronave()
        {
            InitializeComponent();
            desactivarControles();
        }

        private void Form_IngresarAeronave_Load(object sender, EventArgs e)
        {
            // TODO: esta línea de código carga datos en la tabla 'dataSetFabricantes.FABRICANTES_AERO' Puede moverla o quitarla según sea necesario.
            this.fABRICANTES_AEROTableAdapter.Fill(this.dataSetFabricantes.FABRICANTES_AERO);
            // TODO: esta línea de código carga datos en la tabla 'dataSetModelos.MODELOS_AERO' Puede moverla o quitarla según sea necesario.
            this.mODELOS_AEROTableAdapter.Fill(this.dataSetModelos.MODELOS_AERO);

        }

        private void desactivarControles()
        {
            txtCantHelices.Enabled = false;
            txtCantTurbinas.Enabled = false;
        }

        private void metroDateTime2_ValueChanged(object sender, EventArgs e)
        {

        }

        private void metroLabel6_Click(object sender, EventArgs e)
        {

        }

        private void metroTextBox4_Click(object sender, EventArgs e)
        {

        }

        private void metroLabel7_Click(object sender, EventArgs e)
        {

        }

        private void metroTextBox5_Click(object sender, EventArgs e)
        {

        }

        private void metroLabel8_Click(object sender, EventArgs e)
        {

        }

        private void metroLabel6_Click_1(object sender, EventArgs e)
        {

        }

        private void btnIngresar_Click(object sender, EventArgs e)
        {
            try
            {
                DAO_Aeronave dao = new DAO_Aeronave();
                AERONAVES aeronave = new AERONAVES();

                if (chkAvion.Checked)
                {
                    tipoAeronave = 1;
                    aeronave.CANT_TURBINAS = int.Parse(txtCantTurbinas.Text);
                    
                }
                if (chkHelicoptero.Checked)
                {
                    tipoAeronave = 2;
                    aeronave.CANT_HELICES = int.Parse(txtCantHelices.Text);

                }
                aeronave.TIPO_AERONAVE_IDTIPO_AERONAVE = tipoAeronave;
                aeronave.ESTADO_IDESTADO = 1;

                int idFab =int.Parse(cboFabricante.SelectedValue.ToString());
                aeronave.FABRICANTES_AERO_IDFABRICANTE = idFab;

                int idModelo = int.Parse(cboModelo.SelectedValue.ToString());
                aeronave.MODELOS_AERO_IDMODELO = idModelo;
                aeronave.HORAS_VOLADAS = 0;
                aeronave.CANT_MAX_HORAS = int.Parse(txtCantMaxHoras.Text);
                aeronave.PATENTE = txtMatricula.Text;
                aeronave.ANIO_FAB = int.Parse(txtAnnioFab.Text);
                aeronave.CANT_MAX_PILOTOS = short.Parse(txtCantMaxPilotos.Text);
                aeronave.FECHA_INSPECCION_ANUAL = txtFechaInspeccion.Value;
                aeronave.CAP_LITROS = int.Parse(txtLitros.Text);
                aeronave.MOTOR = txtMotor.Text;
                aeronave.RUEDAS = txtCantRuedas.Text;
              
              

                bool resp = dao.AgregarAeronave(aeronave);

                if (resp)
                {
                    MessageBox.Show("Aeronave Registrada en el Sistema exitosamente!","Operación exitosa");
                }
                else
                {
                    MessageBox.Show("Se ha producido un error, verifique todos los campos y vuelva a intentar.", "Error al ingresar");
                }
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }
        }

        private void chkAvion_CheckedChanged(object sender, EventArgs e)
        {
            if (chkAvion.Checked)
            {
                txtCantTurbinas.Enabled = true;
            }
            else
            {
                txtCantTurbinas.Enabled = false;
            }
        }

        private void chkHelicoptero_CheckedChanged(object sender, EventArgs e)
        {
            if (chkHelicoptero.Checked)
            {
                txtCantHelices.Enabled = true;
            }
            else
            {
                txtCantHelices.Enabled = false;
            }
        }

        private void txtCantHelices_KeyPress(object sender, KeyPressEventArgs e)
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

        private void txtCantTurbinas_KeyPress(object sender, KeyPressEventArgs e)
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

        private void txtAnnioFab_KeyPress(object sender, KeyPressEventArgs e)
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

        private void txtLitros_KeyPress(object sender, KeyPressEventArgs e)
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

        private void txtCantMaxHoras_KeyPress(object sender, KeyPressEventArgs e)
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

        private void txtCantMaxPilotos_KeyPress(object sender, KeyPressEventArgs e)
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

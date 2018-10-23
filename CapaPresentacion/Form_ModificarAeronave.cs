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
    public partial class Form_ModificarAeronave : Form
    {
        int tipoAeronave;
        public Form_ModificarAeronave()
        {
            InitializeComponent();
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
                    if (item.ESTADO_IDESTADO == 2)
                    {
                        MessageBox.Show("Atención, Aeronave " + item.PATENTE + " se encuentra desactivada del sistema.", "Aeronave no seleccionable.");
                    }
                    else
                    {
                        txtAnnioFab.Text = item.ANIO_FAB.ToString();
                        txtCantMaxHoras.Text = item.CANT_MAX_HORAS.ToString();
                        txtCantMaxPilotos.Text = item.CANT_MAX_PILOTOS.ToString();
                        txtMotor.Text = item.MOTOR;
                        txtFechaInspeccion.Value = DateTime.Parse(item.FECHA_INSPECCION_ANUAL.ToString());
                        txtLitros.Text = item.CAP_LITROS.ToString();
                        txtCantRuedas.Text = item.RUEDAS;

                        int idModelo = item.MODELOS_AERO_IDMODELO;
                        cboModelo.SelectedValue = idModelo;

                        int idFabricante = item.FABRICANTES_AERO_IDFABRICANTE;
                        cboFabricante.SelectedValue = idFabricante;

                        if (item.TIPO_AERONAVE_IDTIPO_AERONAVE == 1)
                        {
                            txtCantTurbinas.Text = item.CANT_TURBINAS.ToString();
                            chkAvion.Checked = true;
                        }
                        else
                        {
                            txtCantTurbinas.Text = "0";
                        }

                        if (item.TIPO_AERONAVE_IDTIPO_AERONAVE == 2)
                        {
                            txtCantHelices.Text = item.CANT_HELICES.ToString();
                            chkHelicoptero.Checked = true;
                        }
                        else
                        {
                            txtCantHelices.Text = "0";
                        }
                        MessageBox.Show("Aeronave Encontrada exitosamente", "Busqueda correcta");
                    }
                    
                }

                
                }
            catch (Exception)
            {

                MessageBox.Show("Aeronave NO Encontrada, por favor verifique la matrícula", "Busqueda incorrecta");
            }

        }

        private void Form_ModificarAeronave_Load(object sender, EventArgs e)
        {
            // TODO: esta línea de código carga datos en la tabla 'dataSetFabricantes.FABRICANTES_AERO' Puede moverla o quitarla según sea necesario.
            this.fABRICANTES_AEROTableAdapter.Fill(this.dataSetFabricantes.FABRICANTES_AERO);
            // TODO: esta línea de código carga datos en la tabla 'dataSetModelos.MODELOS_AERO' Puede moverla o quitarla según sea necesario.
            this.mODELOS_AEROTableAdapter.Fill(this.dataSetModelos.MODELOS_AERO);

        }

        private void btnModificar_Click(object sender, EventArgs e)
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

                int idFab = int.Parse(cboFabricante.SelectedValue.ToString());
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



                bool resp = dao.ModificarAeronave(aeronave);

                if (resp)
                {
                    MessageBox.Show("Aeronave Modificada exitosamente!", "Operación exitosa");
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

        private void txtCantRuedas_KeyPress(object sender, KeyPressEventArgs e)
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

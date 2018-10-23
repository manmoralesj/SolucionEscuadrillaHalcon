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
    public partial class Form_ModificarVuelo : Form
    {
        private string rutPiloto, rutCopiloto = "N/A";
        private int idPiloto, idCopiloto = 0, estadoLicenciaPiloto=0, estadoLicenciaCopiloto=0;
        public Form_ModificarVuelo()
        {
            InitializeComponent();
            txtFechaHora.CustomFormat = "dd/MM/yyyy hh:mm:ss";
            txtFechaHora.Format = DateTimePickerFormat.Custom;
            cboCopiloto.Enabled = false;
            txtLicCopiloto.Enabled = false;
            metroLink2.Enabled = false;
        }

        private void groupBox3_Enter(object sender, EventArgs e)
        {

        }

        private void Form_ModificarVuelo_Load(object sender, EventArgs e)
        {
            // TODO: esta línea de código carga datos en la tabla 'dataSetCondicion.CONDICION' Puede moverla o quitarla según sea necesario.
            this.cONDICIONTableAdapter.Fill(this.dataSetCondicion.CONDICION);
            // TODO: esta línea de código carga datos en la tabla 'dataSetPilotos.PILOTOS' Puede moverla o quitarla según sea necesario.
            this.pILOTOSTableAdapter.Fill(this.dataSetPilotos.PILOTOS);
            // TODO: esta línea de código carga datos en la tabla 'dataSetAeronaves.AERONAVES' Puede moverla o quitarla según sea necesario.
            this.aERONAVESTableAdapter.FillBy1(this.dataSetAeronaves.AERONAVES);


        }

        private void txtNumVuelo_KeyPress(object sender, KeyPressEventArgs e)
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

        private void txtHorasVuelo_KeyPress(object sender, KeyPressEventArgs e)
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

        private void chkCopiloto_CheckedChanged(object sender, EventArgs e)
        {
            if (chkCopiloto.Checked)
            {
                cboCopiloto.Enabled = true;
                txtLicCopiloto.Enabled = true;
                metroLink2.Enabled = true;
            }
            else
            {
                cboCopiloto.Enabled = false;
                txtLicCopiloto.Enabled = false;
                metroLink2.Enabled = false;
            }
        }

        private void metroLink1_Click(object sender, EventArgs e)
        {
            try
            {
                ServiceReferenceDGAC.webservice_dgacClient cliente = new ServiceReferenceDGAC.webservice_dgacClient();

              
                    if (cliente.existeLicencia(int.Parse(txtLicPiloto.Text)))
                    {
                        estadoLicenciaPiloto = 2;
                        imgPilotoV.Visible = true;
                        imgPilotoNV.Visible = false;

                    }
                    else
                    {

                        estadoLicenciaPiloto = 1;
                        imgPilotoV.Visible = false;
                        imgPilotoNV.Visible = true;
                    }
                
            }
            catch (Exception)
            {

                throw;
            }
        }

        private void metroLink2_Click(object sender, EventArgs e)
        {
            try
            {
                ServiceReferenceDGAC.webservice_dgacClient cliente = new ServiceReferenceDGAC.webservice_dgacClient();


                if (cliente.existeLicencia(int.Parse(txtLicCopiloto.Text)))
                {
                    estadoLicenciaCopiloto = 1;
                    imgCopilotoV.Visible = false;
                    imgCopilotoNV.Visible = true;
                }
                else
                {
                    estadoLicenciaCopiloto = 2;
                    imgCopilotoV.Visible = true;
                    imgCopilotoNV.Visible = false;
                }
               
            }
            catch (Exception)
            {

                throw;
            }
        }

        private void metroButton2_Click(object sender, EventArgs e)
        {
            try
            {
                DAO_Vuelo dao = new DAO_Vuelo();

                int id = int.Parse(txtNumVuelo.Text);
                List<VUELOS> LC = dao.BuscarVuelos(id);
                foreach (var item in LC)
                {
                    int idCondicion = item.CONDICION_IDCONDICION_VUELO;
                    cboCondicion.SelectedValue = idCondicion;

                    int idAeronave = item.AERONAVES_IDAERONAVE;
                    cboAeronave.SelectedValue = idAeronave;

                    txtHorasVuelo.Text = item.HORAS_ESTIMADAS.ToString();

                    txtFechaHora.Value = item.FECHAHORA_INICIO.Date;

                    txtMision.Text = item.MISION;


                }

                List<CL_PILOTOS_VUELOS> LC1 = dao.BuscarPilotos(id);
                foreach (var item in LC1)
                {
                    int idPiloto = item.PILOTOS_IDUSUARIO;
                    cboPiloto.SelectedValue = idPiloto;
                    cboPiloto.Text = item.PILOTOS_RUT;
                }

                List<CL_COPILOTOS_VUELOS> LC2 = dao.BuscarCopilotos(id);
                if (LC2.LongCount()>0)
                {
                    foreach (var item in LC2)
                    {
                        if (cboPiloto.Text.Equals(item.PILOTOS_RUT))
                        {
                            chkCopiloto.Checked = false;
                        }
                        else
                        {
                            chkCopiloto.Checked = true;
                            int idPiloto = item.PILOTOS_IDUSUARIO;
                            cboCopiloto.SelectedValue = idPiloto;
                            cboCopiloto.Text = item.PILOTOS_RUT;
                        }
                        
                    }
                   

                }
                else
                {
                    chkCopiloto.Checked = false;
                }
               

            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }
        }

        private void metroButton1_Click(object sender, EventArgs e)
        {
            try
            {
                if (estadoLicenciaPiloto.Equals(2) && estadoLicenciaCopiloto.Equals(2) || estadoLicenciaPiloto.Equals(2) && estadoLicenciaCopiloto.Equals(0))
                {
                    DAO_Vuelo dao = new DAO_Vuelo();

                    VUELOS vuelo = new VUELOS();
                    int id = int.Parse(txtNumVuelo.Text);
                    vuelo.IDVUELO = id;

                    int idcondicion = int.Parse(cboCondicion.SelectedValue.ToString());
                    vuelo.CONDICION_IDCONDICION_VUELO = idcondicion;
                    vuelo.HORAS_ESTIMADAS = short.Parse(txtHorasVuelo.Text);
                    vuelo.MISION = txtMision.Text;
                    DateTime fecha = txtFechaHora.Value;
                    vuelo.FECHAHORA_INICIO = fecha;
                    vuelo.ESTADO_IDESTADO = 4;

                    int idAeronave = int.Parse(cboAeronave.SelectedValue.ToString());
                    vuelo.AERONAVES_IDAERONAVE = idAeronave;
                    idPiloto = int.Parse(cboPiloto.SelectedValue.ToString());
                    rutPiloto = cboPiloto.Text;

                    if (chkCopiloto.Checked)
                    {
                        idCopiloto = int.Parse(cboCopiloto.SelectedValue.ToString());
                        rutCopiloto = cboCopiloto.Text;
                    }
                    else
                    {

                        idCopiloto = 0;
                    }

                    bool resp = dao.ModificarVuelo(vuelo, rutPiloto, rutCopiloto, idPiloto, idCopiloto);

                    if (resp)
                    {
                        MessageBox.Show("Vuelo Modificado Exitosamente ", "Operación exitosa.");
                    }
                    else
                    {
                        MessageBox.Show("Error al realizar solicitud, verifique los campos y vuelva a intentar", "Error en Operación.");
                    }
                }
                else
                {
                    MessageBox.Show("Verifique correctamente las licencias antes de efectuar la operación ", "Error en la operación");
                }

                
            }
            catch (Exception)
            {

                throw;
            }
        }
    }

}

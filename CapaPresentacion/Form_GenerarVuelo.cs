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
    public partial class Form_GenerarVuelo : Form
    {
        private string rutPiloto, rutCopiloto="N/A";
        private int idPiloto, idCopiloto=0;

        // 0 = no validada; 1 = invalidada; 2 = validada
        private int estadoLicenciaPiloto=0, estadoLicenciaCopiloto=0;

        // 1 = validado; 2 = invalidado
        private int estadoDGAC;

        public Form_GenerarVuelo()
        {
            InitializeComponent();
            txtFechaHora.CustomFormat = "dd/MM/yyyy hh:mm:ss";
            txtFechaHora.Format = DateTimePickerFormat.Custom;
            txtRutCopiloto.Enabled = false;
            linkLicenciaCopiloto.Enabled = false;
            txtRutCopiloto.Enabled = false;
            ValidarLicenciasDGAC();
        }

        private void ValidarLicenciasDGAC()
        {
            if (chkCopiloto.Checked)
            {
                if (estadoLicenciaPiloto.Equals(2) && estadoLicenciaCopiloto.Equals(2))
                {
                    imagenExito.Visible = true;
                    imagenError.Visible = false;
                    imagenAlerta.Visible = false;
                    lblMensaje.Text = "Licencia(s) Validada(s)";
                    estadoDGAC = 1;
                }
                if (estadoLicenciaPiloto.Equals(1) && estadoLicenciaCopiloto.Equals(1))
                {
                    imagenExito.Visible = false;
                    imagenError.Visible = true;
                    imagenAlerta.Visible = false;
                    lblMensaje.Text = "Licencia(s) Invalida(s)";
                    estadoDGAC = 2;
                }
                if (estadoLicenciaPiloto.Equals(0) || estadoLicenciaCopiloto.Equals(0))
                {
                    imagenExito.Visible = false;
                    imagenError.Visible = false;
                    imagenAlerta.Visible = true;
                    lblMensaje.Text = "Licencia(s) sin Validar";
                }
            }
            else
            {
                if (estadoLicenciaPiloto.Equals(2))
                {
                    imagenExito.Visible = true;
                    imagenError.Visible = false;
                    imagenAlerta.Visible = false;
                    lblMensaje.Text = "Licencia(s) Validada(s)";
                    estadoDGAC = 1;
                }
                if (estadoLicenciaPiloto.Equals(1))
                {
                    imagenExito.Visible = false;
                    imagenError.Visible = true;
                    imagenAlerta.Visible = false;
                    lblMensaje.Text = "Licencia(s) Invalida(s)";
                }
                if (estadoLicenciaPiloto.Equals(0))
                {
                    imagenExito.Visible = false;
                    imagenError.Visible = false;
                    imagenAlerta.Visible = true;
                    lblMensaje.Text = "Licencia(s) sin Validar";
                    estadoDGAC = 2;
                }
            }
            
        }

        private void groupBox3_Enter(object sender, EventArgs e)
        {

        }

        private void txtMision_Click(object sender, EventArgs e)
        {

        }

        private void fillBy1ToolStripButton_Click(object sender, EventArgs e)
        {
            

        }

        private void fillBy1ToolStrip_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }

        private void fillToolStripButton_Click(object sender, EventArgs e)
        {
           

        }

        private void fillToolStrip_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }

        private void linkLicenciaCopiloto_Click(object sender, EventArgs e)
        {
            try
            {
                ServiceReferenceDGAC.webservice_dgacClient cliente = new ServiceReferenceDGAC.webservice_dgacClient();


                if (cliente.validarMultasbyRut(txtRutCopiloto.Text))
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
                ValidarLicenciasDGAC();
            }
            catch (Exception)
            {

                throw;
            }
        }

        private void chkCopiloto_CheckedChanged(object sender, EventArgs e)
        {
           
            if (chkCopiloto.Checked)
            {
                txtRutCopiloto.Enabled = true;
                linkLicenciaCopiloto.Enabled = true;
                txtRutCopiloto.Enabled = true;
            }
            else
            {
                txtRutCopiloto.Enabled = false;
                linkLicenciaCopiloto.Enabled = false;
                txtRutCopiloto.Enabled = false;
            }
        }

        private void txtHorasEstimadas_KeyPress(object sender, KeyPressEventArgs e)
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

        private void metroLink1_Click(object sender, EventArgs e)
        {
            try
            {
                ServiceReferenceDGAC.webservice_dgacClient cliente = new ServiceReferenceDGAC.webservice_dgacClient();

                if (cliente.validarMultasbyRut(txtRutPiloto.Text))
                {
                    estadoLicenciaPiloto = 1;
                    imgPilotoV.Visible = false;
                    imgPilotoNV.Visible = true;

                }
                else
                {
                    estadoLicenciaPiloto = 2;
                    imgPilotoV.Visible = true;
                    imgPilotoNV.Visible = false;
                }
                ValidarLicenciasDGAC();
            }
            catch (Exception)
            {

                throw;
            }
        }

        private void Form_GenerarVuelo_Load(object sender, EventArgs e)
        {
            // TODO: esta línea de código carga datos en la tabla 'dataSetAeronaves.AERONAVES' Puede moverla o quitarla según sea necesario.
            this.aERONAVESTableAdapter.FillBy1(this.dataSetAeronaves.AERONAVES);
            // TODO: esta línea de código carga datos en la tabla 'dataSetCondicion.CONDICION' Puede moverla o quitarla según sea necesario.
            this.cONDICIONTableAdapter.Fill(this.dataSetCondicion.CONDICION);
            // TODO: esta línea de código carga datos en la tabla 'dataSetPilotos.PILOTOS' Puede moverla o quitarla según sea necesario.
            this.pILOTOSTableAdapter.Fill(this.dataSetPilotos.PILOTOS);


        }

        private void btbGenerar_Click(object sender, EventArgs e)
        {

            //verificación horas aeronave
            bool horasDisponibles = true;
            DAO_Aeronave aer = new DAO_Aeronave();
            string matricula = cboAeronave.Text;
            List<AERONAVES> LC = aer.BuscarAeronave(matricula);
            foreach (var item in LC)
            {
                if (item.HORAS_VOLADAS+int.Parse(txtHorasEstimadas.Text)>item.CANT_MAX_HORAS)
                {
                    horasDisponibles = false;
                }
            }


            try
            {
                if (estadoDGAC.Equals(1))
                {
                    if (horasDisponibles)
                    {
                        DAO_Vuelo dao = new DAO_Vuelo();
                        VUELOS vuelo = new VUELOS();

                        int idcondicion = int.Parse(cboCondicion.SelectedValue.ToString());
                        vuelo.CONDICION_IDCONDICION_VUELO = idcondicion;
                        vuelo.HORAS_ESTIMADAS = short.Parse(txtHorasEstimadas.Text);
                        vuelo.MISION = txtMision.Text;
                        DateTime fecha = txtFechaHora.Value;
                        vuelo.FECHAHORA_INICIO = fecha;
                        vuelo.ESTADO_IDESTADO = 4;

                        int idAeronave = int.Parse(cboAeronave.SelectedValue.ToString());
                        vuelo.AERONAVES_IDAERONAVE = idAeronave;

                        

                        rutPiloto = txtRutPiloto.Text;

                        DAO_Piloto pil = new DAO_Piloto();
                        string rut = txtRutPiloto.Text;
                        List<USUARIOS> LC1 = pil.BuscarPiloto(rut);
                        foreach (var item in LC1)
                        {
                            idPiloto = item.IDUSUARIO;
                        }

                        if (chkCopiloto.Checked)
                        {
                            DAO_Piloto copil = new DAO_Piloto();
                            string rutCopioto = txtRutCopiloto.Text;
                            List<USUARIOS> LC2 = pil.BuscarPiloto(rutCopiloto);
                            foreach (var item in LC2)
                            {
                                idCopiloto = item.IDUSUARIO;
                            }
                            
                            rutCopiloto = txtRutCopiloto.Text;
                        }
                        else
                        {
                            idCopiloto = 0;
                        }

                        bool resp = dao.AgregarVuelo(vuelo, rutPiloto, rutCopiloto, idPiloto, idCopiloto);

                        if (resp)
                        {
                            MessageBox.Show("Vuelo Puesto en Marcha Exitosamente con fecha de " + fecha.ToLongTimeString(), "Operación exitosa.");
                        }
                        else
                        {
                            MessageBox.Show("Error al realizar solicitud, verifique los campos y vuelva a intentar", "Error en Operación.");
                        }
                    }
                    else
                    {
                        MessageBox.Show("La Aeronave Seleccionada excede sus horas de vuelo máximas, por favor seleccione otra aeronave", "Aeronave Invalidante.");
                    }
                }
                else
                {
                    MessageBox.Show("No se han registrado licencias válidas para efectuar la operación","Problemas con las licencias");
                }
               
                   
            }
            catch (Exception)
            {

                throw;
            }
        }
    }
}

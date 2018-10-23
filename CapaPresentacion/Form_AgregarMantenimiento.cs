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
    public partial class Form_AgregarMantenimiento : Form
    {
        int idAeronave =0, idComponente=0;

        string patente, destinatario;
        public Form_AgregarMantenimiento()
        {
            InitializeComponent();
            cboComponente.Enabled = false;
            cboMatAeronave.Enabled = false;
        }

        private void Form_AgregarMantenimiento_Load(object sender, EventArgs e)
        {
           

            this.cOMPONENTESTableAdapter.FillBy2(this.dataSetComponentes.COMPONENTES);
            this.aERONAVESTableAdapter.FillBy1(this.dataSetAeronaves.AERONAVES);
        }

        private void chkAeronave_CheckedChanged(object sender, EventArgs e)
        {
            if (chkAeronave.Checked)
            {
                cboMatAeronave.Enabled = true;
            }
            else
            {
                cboMatAeronave.Enabled = false;
            }
        }

        private void chkComponente_CheckedChanged(object sender, EventArgs e)
        {
            if (chkComponente.Checked)
            {
                cboComponente.Enabled = true;
            }
            else
            {
                cboComponente.Enabled = false;
            }
        }

        private void fillBy1ToolStripButton_Click(object sender, EventArgs e)
        {
            try
            {
                this.aERONAVESTableAdapter.FillBy1(this.dataSetAeronaves.AERONAVES);
            }
            catch (System.Exception ex)
            {
                System.Windows.Forms.MessageBox.Show(ex.Message);
            }

        }

        private void fillBy2ToolStripButton_Click(object sender, EventArgs e)
        {
            try
            {
                this.cOMPONENTESTableAdapter.FillBy2(this.dataSetComponentes.COMPONENTES);
            }
            catch (System.Exception ex)
            {
                System.Windows.Forms.MessageBox.Show(ex.Message);
            }

        }

        private void fillBy2ToolStrip_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }

        private void btnIngresar_Click(object sender, EventArgs e)
        {

            try
            {
                DAO_Mantenimiento dao = new DAO_Mantenimiento();
                MANTENIMIENTOS man = new MANTENIMIENTOS();

                man.ESTADO_IDESTADO = 4;

                if (chkAeronave.Checked)
                {
                    idAeronave = int.Parse(cboMatAeronave.SelectedValue.ToString());
                }
                man.AERONAVES_IDAERONAVE = idAeronave;

                if (chkComponente.Checked)
                {
                    idComponente = int.Parse(cboComponente.SelectedValue.ToString());
                }
                man.COMPONENTES_IDCOMPONENTE = idComponente;

                man.OBS = txtObs.Text;

                patente = cboMatAeronave.Text;
                bool resp = dao.AgregarMantenimiento(man);

                if (resp)
                {
                    MessageBox.Show("Mantenimiento registrado!");

                  

                    DAO_Usuario usu = new DAO_Usuario();

                    DAO_Piloto pil = new DAO_Piloto();
                 

                    List<USUARIOS> LC = pil.listarPiloto();
                    foreach (var item in LC)
                    {

                        destinatario = item.CORREO;
                        usu.correo(patente,destinatario);

                    }
                }
                else
                {
                    MessageBox.Show("Error al ingresar Mantenimiento.");
                }
            }


            catch (Exception)
            {

                throw;
            }
        }
    }
}

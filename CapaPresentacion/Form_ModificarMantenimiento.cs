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
    public partial class Form_ModificarMantenimiento : Form
    {
        int idComponente = 0, idAeronave = 0;
        public Form_ModificarMantenimiento()
        {
            InitializeComponent();
        }

        private void metroButton1_Click(object sender, EventArgs e)
        {
            try
            {
                DAO_Mantenimiento dao = new DAO_Mantenimiento();
                MANTENIMIENTOS mantenimiento = new MANTENIMIENTOS();

                int id = int.Parse(txtNum.Text);

                mantenimiento.IDMANTENIMIENTO = id;

                string obs = txtObs.Text;

                mantenimiento.OBS = obs;

                if (chkAeronave.Checked)
                {
                    idAeronave = int.Parse(cboMatAeronave.SelectedValue.ToString());

                }
                mantenimiento.AERONAVES_IDAERONAVE = idAeronave;

                if (chkComponente.Checked)
                {
                    idComponente = int.Parse(cboComponente.SelectedValue.ToString());

                }
                mantenimiento.COMPONENTES_IDCOMPONENTE = idComponente;

                mantenimiento.ESTADO_IDESTADO = 4;


                bool resp = dao.ModificarMantenimiento(mantenimiento);

                if (resp)
                {
                    MessageBox.Show(this, "Mantenimiento Modificado Exitosamente!");
                }
                else
                {
                    MessageBox.Show(this, "Error al Generar Solicitud");
                }
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message,"Error interno");
            }
        }

        private void Form_ModificarMantenimiento_Load(object sender, EventArgs e)
        {

            this.aERONAVESTableAdapter.FillBy1(this.dataSetAeronaves.AERONAVES);
            this.cOMPONENTESTableAdapter.FillBy2(this.dataSetComponentes.COMPONENTES);
        }

        private void fillBy1ToolStripButton_Click(object sender, EventArgs e)
        {
            

        }

        private void fillBy2ToolStripButton_Click(object sender, EventArgs e)
        {
           

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

        private void txtNum_KeyPress(object sender, KeyPressEventArgs e)
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

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            try
            {
                DAO_Mantenimiento dao = new DAO_Mantenimiento();
                int id = int.Parse(txtNum.Text);
                List<MANTENIMIENTOS> LC = dao.BuscarMantenimiento(id);
                foreach (var item in LC)
                {


                    txtObs.Text = item.OBS.ToString();
                   

                    if (item.AERONAVES_IDAERONAVE > 0)
                    {
                        chkAeronave.Checked = true;
                        idAeronave = item.AERONAVES_IDAERONAVE;
                        cboMatAeronave.SelectedValue = idAeronave;

                    }
                    else
                    {
                        chkAeronave.Checked = false;
                    }

                    if (item.COMPONENTES_IDCOMPONENTE > 0)
                    {
                        chkComponente.Checked = true;
                        idComponente = item.COMPONENTES_IDCOMPONENTE;
                        cboComponente.SelectedValue = idComponente;
                    }
                    else
                    {
                        chkComponente.Checked = false;
                    }

                    
                }
            }
            catch (Exception)
            {

                MessageBox.Show("Error al encontrar mantenimiento");
            }
        }
    }
}

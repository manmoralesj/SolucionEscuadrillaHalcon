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
    public partial class Form_AgregarComponente : Form
    {
        int numUsos, horasUso;
        
        public Form_AgregarComponente()
        {
            InitializeComponent();
            cboComponentes.Enabled = false;
            txtHorasUso.Enabled = false;
            txtNumUsos.Enabled = false;
        }

        private void metroButton1_Click(object sender, EventArgs e)
        {
            DAO_Componente dao = new DAO_Componente();
            COMPONENTES componente = new COMPONENTES();

            componente.ESTADO_IDESTADO = 1;
            componente.NOMBRE = txtNombre.Text;


            if (chkHorasUso.Checked)
            {
                horasUso = int.Parse(txtHorasUso.Text);

            }
            componente.HORAS_MAX_USO = horasUso;

            if (chkCantUso.Checked)
            {
                numUsos = int.Parse(txtNumUsos.Text);

            }
            componente.MAX_NUM_USOS = numUsos;


            if (chkCompInternos.Checked)
            {
                componente.COMPONENTES_IDCOMPONENTE = int.Parse(cboComponentes.SelectedValue.ToString());
            }





            bool resp = dao.AgregarComponente(componente);

            if (resp)
            {
                MessageBox.Show(this, "Componente Registrado Exitosamente!");
            }
            else
            {
                MessageBox.Show(this, "Error al Generar Solicitud");
            }
        }

        private void Form_AgregarComponente_Load(object sender, EventArgs e)
        {
            this.cOMPONENTESTableAdapter.FillBy1(this.dataSetComponentes.COMPONENTES);


        }

        private void chkCantUso_CheckedChanged(object sender, EventArgs e)
        {
            if (chkCantUso.Checked)
            {
                txtHorasUso.Enabled = false;
                txtNumUsos.Enabled = true;
                txtHorasUso.Clear();
            }

        }

        private void chkHorasUso_CheckedChanged(object sender, EventArgs e)
        {
            if (chkHorasUso.Checked)
            {
                txtHorasUso.Enabled = true;
                txtNumUsos.Enabled = false;
                txtNumUsos.Clear();
            }
        }

        private void fillByToolStripButton_Click(object sender, EventArgs e)
        {
       

        }

        private void fillBy1ToolStripButton_Click(object sender, EventArgs e)
        {
            try
            {
                this.cOMPONENTESTableAdapter.FillBy1(this.dataSetComponentes.COMPONENTES);
            }
            catch (System.Exception ex)
            {
                System.Windows.Forms.MessageBox.Show(ex.Message);
            }

        }

        private void fillBy1ToolStripButton_Click_1(object sender, EventArgs e)
        {
        

        }

        private void fillBy1ToolStrip_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }

        private void txtNumUsos_KeyPress(object sender, KeyPressEventArgs e)
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

        private void txtHorasUso_KeyPress(object sender, KeyPressEventArgs e)
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

        private void txtNumUsos_Click(object sender, EventArgs e)
        {

        }

        private void chkCompInternos_CheckedChanged(object sender, EventArgs e)
        {
            if (chkCompInternos.Checked)
            {
                cboComponentes.Enabled = true;
            }
        }
    }
}

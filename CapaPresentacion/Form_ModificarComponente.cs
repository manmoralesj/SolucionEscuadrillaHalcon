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
    public partial class Form_ModificarComponente : Form
    {
        int numUsos, numMaxUsos, horasUso, horasMaxUsos;

        public Form_ModificarComponente()
        {
            InitializeComponent();
            cboCompInternos.Enabled = false;
        }

        private void metroButton2_Click(object sender, EventArgs e)
        {
            try
            {
                DAO_Componente dao = new DAO_Componente();

                int id = int.Parse(cboComponentes.SelectedValue.ToString());
                List<COMPONENTES> LC = dao.BuscarComponente(id);
                foreach (var item in LC)
                {
                   

                    txtHorasMaxUsos.Text = item.HORAS_MAX_USO.ToString();
                    int horas = int.Parse(item.HORAS_MAX_USO.ToString());
                    txtNumMaxUsos.Text = item.MAX_NUM_USOS.ToString();

                    txtHorasUso.Text = item.HORAS_USADO.ToString();
                    txtNumUsos.Text = item.VECES_USADO.ToString();

                    if (horas > 0)
                    {
                        chkHorasUso.Checked = true;
                    }
                    else
                    {
                        chkCantUso.Checked = true;
                    }

                    if (item.COMPONENTES_IDCOMPONENTE>0)
                    {
                        chkCompInternos.Checked = true;
                        int idCompInterno = int.Parse(item.COMPONENTES_IDCOMPONENTE.ToString());
                        cboCompInternos.SelectedValue = idCompInterno;
                        cboCompInternos.Enabled = true;
                        int idcomp = int.Parse(item.IDCOMPONENTE.ToString());
                        cboComponentes.SelectedValue = idcomp;
                    }
                    else
                    {
                        chkCompInternos.Checked = false;
                    }

                    

                }
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }
        }

        private void Form_ModificarComponente_Load(object sender, EventArgs e)
        {
            this.cOMPONENTESTableAdapter.Fill(this.dataSetComponentes.COMPONENTES);

        }

        private void fillBy1ToolStripButton_Click(object sender, EventArgs e)
        {
            

        }

        private void fillBy1ToolStrip_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }

        private void chkCantUso_CheckedChanged(object sender, EventArgs e)
        {
            if (chkCantUso.Checked)
            {
                txtHorasUso.Enabled = false;
                txtNumUsos.Enabled = true;
                txtHorasUso.Clear();
                txtHorasMaxUsos.Clear();
            }
        }

        private void chkHorasUso_CheckedChanged(object sender, EventArgs e)
        {
            if (chkHorasUso.Checked)
            {
                txtHorasUso.Enabled = true;
                txtNumUsos.Enabled = false;
                txtNumUsos.Clear();
                txtNumMaxUsos.Clear();
            }
        }

        private void chkCompInternos_CheckedChanged(object sender, EventArgs e)
        {
            if (chkCompInternos.Checked)
            {
                cboCompInternos.Enabled = true;
            }
            else
            {
                cboCompInternos.Enabled = false;
            }
        }

        private void fillToolStripButton_Click(object sender, EventArgs e)
        {
            try
            {
                this.cOMPONENTESTableAdapter.Fill(this.dataSetComponentes.COMPONENTES);
            }
            catch (System.Exception ex)
            {
                System.Windows.Forms.MessageBox.Show(ex.Message);
            }

        }

        private void cboCompInternos_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void txtNumMaxUsos_KeyPress(object sender, KeyPressEventArgs e)
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

        private void txtHorasMaxUsos_KeyPress(object sender, KeyPressEventArgs e)
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

        private void fillToolStripButton_Click_1(object sender, EventArgs e)
        {
            try
            {
                this.cOMPONENTESTableAdapter.Fill(this.dataSetComponentes.COMPONENTES);
            }
            catch (System.Exception ex)
            {
                System.Windows.Forms.MessageBox.Show(ex.Message);
            }

        }

        private void fillToolStrip_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }

        private void metroButton1_Click(object sender, EventArgs e)
        {
            DAO_Componente dao = new DAO_Componente();
            COMPONENTES componente = new COMPONENTES();

            int id = int.Parse(cboComponentes.SelectedValue.ToString());

            componente.IDCOMPONENTE = id;

            string nombre = cboCompInternos.Text;

            componente.NOMBRE = nombre;

            if (chkHorasUso.Checked)
            {
                horasMaxUsos = int.Parse(txtHorasMaxUsos.Text);
                horasUso = int.Parse(txtHorasUso.Text);

            }
            componente.HORAS_USADO = horasUso;
            componente.HORAS_MAX_USO = horasMaxUsos;

            if (chkCantUso.Checked)
            {
                numMaxUsos = int.Parse(txtNumMaxUsos.Text);
                numUsos = int.Parse(txtNumUsos.Text);

            }
            componente.VECES_USADO = numUsos;
            componente.MAX_NUM_USOS = numMaxUsos;

            if (chkCompInternos.Checked)
            {
                componente.COMPONENTES_IDCOMPONENTE = int.Parse(cboComponentes.SelectedValue.ToString());
            }




            bool resp = dao.ModificarComponente(componente);

            if (resp)
            {
                MessageBox.Show(this, "Componente Modificado Exitosamente!");
            }
            else
            {
                MessageBox.Show(this, "Error al Generar Solicitud");
            }
        }
    }
}

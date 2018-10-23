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
    public partial class Form_CompletarMantenimiento : Form
    {
        public Form_CompletarMantenimiento()
        {
            InitializeComponent();
            btnCompletar.Enabled = false;
            lblAtras.Visible = false;
        }

        private void metroTextBox1_Click(object sender, EventArgs e)
        {

        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            try
            {
                DAO_Mantenimiento dao = new DAO_Mantenimiento();
                MANTENIMIENTOS man = new MANTENIMIENTOS();

                int id = int.Parse(txtNumero.Text);
                man.IDMANTENIMIENTO = id;
                if (dao.BuscarCompletarMantenimiento(id))
                {
                    MessageBox.Show("Mantenimiento Encontrado!", "Operación exitosa");
                    btnCompletar.Enabled = true;
                    txtNumero.Enabled = false;
                    lblAtras.Visible = true;
                }
                else
                {
                    MessageBox.Show("Mantenimiento NO Encontrado", "Error en la operación");
                    btnCompletar.Enabled = false;
                }
                
            }
            catch (Exception ex)
            {
                MessageBox.Show("Ha ocurrido un error: " +ex.Message, "Error en la operación");

            }
        }

        private void btnCompletar_Click(object sender, EventArgs e)
        {
            try
            {
                DAO_Mantenimiento dao = new DAO_Mantenimiento();

                int id = int.Parse(txtNumero.Text);
               bool resp = dao.CompletarMantenimiento(id);

                if (resp)
                {
                    MessageBox.Show("El mantenimiento " + id + " ha sido registrado como COMPLETADO", "Operación Exitosa");
                    txtNumero.Enabled = true;
                    txtNumero.Clear();
                }
                else
                {
                    MessageBox.Show("No se ha podido completar el mantenimiento" , "Error en la operación");
                }
            }
            catch (Exception ex)
            {

                MessageBox.Show("Ha ocurrido un error: " + ex.Message, "Error en la operación");
            }
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            txtNumero.Clear();
            txtNumero.Enabled = true;
            btnCompletar.Enabled = false;
        }

        private void txtNumero_KeyPress(object sender, KeyPressEventArgs e)
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

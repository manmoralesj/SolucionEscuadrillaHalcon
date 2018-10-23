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
    public partial class Form_CompletarVuelo : Form
    {
        public Form_CompletarVuelo()
        {
            InitializeComponent();
            desactivarControles();
        }

        private void desactivarControles()
        {
            lblAtras.Visible = false;
            btnCompletar.Enabled = false;
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            try
            {
                DAO_Vuelo dao = new DAO_Vuelo();
                VUELOS vuelo = new VUELOS();

                int id = int.Parse(txtNumero.Text);
                vuelo.IDVUELO = id;
                if (dao.BuscarCompletarVuelo(id))
                {
                    MessageBox.Show("Vuelo Encontrado!", "Operación exitosa");
                    btnCompletar.Enabled = true;
                    txtNumero.Enabled = false;
                    lblAtras.Visible = true;
                }
                else
                {
                    MessageBox.Show("Vuelo NO Encontrado", "Error en la operación");
                    btnCompletar.Enabled = false;
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show("Ha ocurrido un error: " + ex.Message, "Error en la operación");

            }
        
            
        }

        private void lblAtras_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            txtNumero.Clear();
            txtNumero.Enabled = true;
            btnCompletar.Enabled = false;
        }

        private void btnCompletar_Click(object sender, EventArgs e)
        {
            try
            {
                DAO_Vuelo dao = new DAO_Vuelo();

                int id = int.Parse(txtNumero.Text);
                int horas = int.Parse(txtHoras.Text);
                bool resp = dao.CompletarVuelo(id,horas);

                if (resp)
                {
                    MessageBox.Show("El vuelo " + id + " ha sido registrado como COMPLETADO", "Operación Exitosa");
                    txtNumero.Enabled = true;
                    txtNumero.Clear();
                }
                else
                {
                    MessageBox.Show("No se ha podido completar el vuelo", "Error en la operación");
                }
            }
            catch (Exception ex)
            {

                MessageBox.Show("Ha ocurrido un error: " + ex.Message, "Error en la operación");
            }
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

        private void txtHoras_KeyPress(object sender, KeyPressEventArgs e)
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

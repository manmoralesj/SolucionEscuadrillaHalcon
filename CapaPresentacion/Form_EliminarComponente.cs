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
    public partial class Form_EliminarComponente : Form
    {
        public Form_EliminarComponente()
        {
            InitializeComponent();
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void metroButton1_Click(object sender, EventArgs e)
        {
            try
            {
                int id = int.Parse(cboComponentes.SelectedValue.ToString());

                DAO_Componente dao = new DAO_Componente();

                bool resp = dao.DesactivarComponente(id);

                if (resp)
                {
                    MessageBox.Show(this, "Componente Desactivado Exitosamente!");
                }
                else
                {
                    MessageBox.Show(this, "Error al Generar Solicitud");
                }
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message,"Error Inesperado");
            }
        }

        private void Form_EliminarComponente_Load(object sender, EventArgs e)
        {
            // TODO: esta línea de código carga datos en la tabla 'dataSetComponentes.COMPONENTES' Puede moverla o quitarla según sea necesario.
            this.cOMPONENTESTableAdapter.FillBy1(this.dataSetComponentes.COMPONENTES);

        }
    }
}

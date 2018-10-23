using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CapaPresentacion
{
    public partial class Form_ListarUsuarios : Form
    {
        public Form_ListarUsuarios()
        {
            InitializeComponent();
        }

        private void Form_ListarUsuarios_Load(object sender, EventArgs e)
        {
            

        }

        private void metroButton1_Click(object sender, EventArgs e)
        {
            // TODO: esta línea de código carga datos en la tabla 'dataSetUsuarios.USUARIOS' Puede moverla o quitarla según sea necesario.
            this.uSUARIOSTableAdapter.Fill(this.dataSetUsuarios.USUARIOS);
        }

        private void metroGrid1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using CapaNegocio;

namespace CapaPresentacion
{
    public partial class Form2 : MetroFramework.Forms.MetroForm
    {
        DAO_Usuario dao = new DAO_Usuario();
        public Form2()
        {
            InitializeComponent();
        }

        private void Form2_Load(object sender, EventArgs e)
        {

        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            if (dao.AlertaMantenimiento().LongCount() > 0)
            {
                lblAlerta.Visible = true;
                lblVerMas.Visible = true;
            }
            else
            {
                lblAlerta.Visible = false;
                lblVerMas.Visible = false;
            }
            label9.Refresh();
            label9.Text = DateTime.Now.Hour.ToString("D2") + ":" + DateTime.Now.Minute.ToString("D2") + ":" + DateTime.Now.Second.ToString("D2");
            label14.Refresh();
            label14.Text = DateTime.Now.ToString("dddd dd MMMM, yyyy");
        }

        private void metroTile8_Click(object sender, EventArgs e)
        {
            metroPanel2.Controls.Clear();
            Form_AgregarPiloto form = new Form_AgregarPiloto();
            form.TopLevel = false;
            form.Parent = metroPanel2;
            form.Dock = DockStyle.Top;
            form.Show();
            form.BringToFront();
        }

        private void metroTile7_Click(object sender, EventArgs e)
        {
            metroPanel2.Controls.Clear();
            Form_ModificarUsuario form = new Form_ModificarUsuario();
            form.TopLevel = false;
            form.Parent = metroPanel2;
            form.Dock = DockStyle.Top;
            form.Show();
            form.BringToFront();
        }

        private void metroTile6_Click(object sender, EventArgs e)
        {
            metroPanel2.Controls.Clear();
            Form_ListarUsuarios form = new Form_ListarUsuarios();
            form.TopLevel = false;
            form.Parent = metroPanel2;
            form.Dock = DockStyle.Top;
            form.Show();
            form.BringToFront();
        }

        private void metroTile5_Click(object sender, EventArgs e)
        {
            metroPanel2.Controls.Clear();
            Form_EliminarUsuario form = new Form_EliminarUsuario();
            form.TopLevel = false;
            form.Parent = metroPanel2;
            form.Dock = DockStyle.Top;
            form.Show();
            form.BringToFront();
        }

        private void metroTile23_Click(object sender, EventArgs e)
        {
            menu.SelectedTab = adminUsuario;
            metroPanel2.Controls.Clear();
            Form_AgregarUsuario form = new Form_AgregarUsuario();
            form.TopLevel = false;
            form.Parent = metroPanel2;
            form.Dock = DockStyle.Top;
            form.Show();
            form.BringToFront();
        }

        private void metroLabel3_Click(object sender, EventArgs e)
        {
            Form_Login menu = new Form_Login();

            menu.Show();

            this.Hide();
        }

        private void metroTile3_Click(object sender, EventArgs e)
        {
            metroPanel2.Controls.Clear();
            Form_AgregarOperador form = new Form_AgregarOperador();
            form.TopLevel = false;
            form.Parent = metroPanel2;
            form.Dock = DockStyle.Top;
            form.Show();
            form.BringToFront();
        }

        private void metroTile1_Click(object sender, EventArgs e)
        {
            metroPanel2.Controls.Clear();
            Form_AgregarConsultor form = new Form_AgregarConsultor();
            form.TopLevel = false;
            form.Parent = metroPanel2;
            form.Dock = DockStyle.Top;
            form.Show();
            form.BringToFront();
        }
    }
}

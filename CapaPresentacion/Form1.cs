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
    public partial class Form1 : MetroFramework.Forms.MetroForm
    {
        DAO_Usuario dao = new DAO_Usuario();
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {


        }

        private void metroTile8_Click(object sender, EventArgs e)
        {
            metroPanel1.Controls.Clear();
            Form_AgregarPiloto form = new Form_AgregarPiloto();
            form.TopLevel = false;
            form.Parent = metroPanel1;
            form.Dock = DockStyle.Top;
            form.Show();
            form.BringToFront();
        }

        private void metroTile7_Click(object sender, EventArgs e)
        {
            metroPanel1.Controls.Clear();
            Form_ModificarPiloto form = new Form_ModificarPiloto();
            form.TopLevel = false;
            form.Parent = metroPanel1;
            form.Dock = DockStyle.Top;
            form.Show();
            form.BringToFront();
        }

        private void metroTile6_Click(object sender, EventArgs e)
        {
            metroPanel1.Controls.Clear();
            Form_ListarPiloto form = new Form_ListarPiloto();
            form.TopLevel = false;
            form.Parent = metroPanel1;
            form.Dock = DockStyle.Top;
            form.Show();
            form.BringToFront();
        }

        private void metroTile5_Click(object sender, EventArgs e)
        {
            metroPanel1.Controls.Clear();
            Form_EliminarPiloto form = new Form_EliminarPiloto();
            form.TopLevel = false;
            form.Parent = metroPanel1;
            form.Dock = DockStyle.Top;
            form.Show();
            form.BringToFront();
        }

        private void pictureBox9_Click(object sender, EventArgs e)
        {

        }

        private void metroTile12_Click(object sender, EventArgs e)
        {
            panel2.Controls.Clear();
            Form_IngresarAeronave form = new Form_IngresarAeronave();
            form.TopLevel = false;
            form.Parent = panel2;
            form.Dock = DockStyle.Top;
            form.Show();
            form.BringToFront();
        }

        private void metroTile11_Click(object sender, EventArgs e)
        {
            panel2.Controls.Clear();
            Form_ModificarAeronave form = new Form_ModificarAeronave();
            form.TopLevel = false;
            form.Parent = panel2;
            form.Dock = DockStyle.Top;
            form.Show();
            form.BringToFront();
        }

        private void metroTile9_Click(object sender, EventArgs e)
        {
            panel2.Controls.Clear();
            Form_EliminarAeronave form = new Form_EliminarAeronave();
            form.TopLevel = false;
            form.Parent = panel2;
            form.Dock = DockStyle.Top;
            form.Show();
            form.BringToFront();
        }

        private void metroTile4_Click(object sender, EventArgs e)
        {
            panel4.Controls.Clear();
            Form_AgregarMantenimiento form = new Form_AgregarMantenimiento();
            form.TopLevel = false;
            form.Parent = panel4;
            form.Dock = DockStyle.Top;
            form.Show();
            form.BringToFront();
        }

        private void metroTile16_Click(object sender, EventArgs e)
        {
            panel3.Controls.Clear();
            Form_AgregarComponente form = new Form_AgregarComponente();
            form.TopLevel = false;
            form.Parent = panel3;
            form.Dock = DockStyle.Top;
            form.Show();
            form.BringToFront();
        }

        private void pictureBox12_Click(object sender, EventArgs e)
        {

        }

        private void metroTile15_Click(object sender, EventArgs e)
        {
            panel3.Controls.Clear();
            Form_ModificarComponente form = new Form_ModificarComponente();
            form.TopLevel = false;
            form.Parent = panel3;
            form.Dock = DockStyle.Top;
            form.Show();
            form.BringToFront();
        }

        private void metroTile13_Click(object sender, EventArgs e)
        {
            panel3.Controls.Clear();
            Form_EliminarComponente form = new Form_EliminarComponente();
            form.TopLevel = false;
            form.Parent = panel3;
            form.Dock = DockStyle.Top;
            form.Show();
            form.BringToFront();
        }

        private void metroTile3_Click(object sender, EventArgs e)
        {
            panel4.Controls.Clear();
            Form_ModificarMantenimiento form = new Form_ModificarMantenimiento();
            form.TopLevel = false;
            form.Parent = panel4;
            form.Dock = DockStyle.Top;
            form.Show();
            form.BringToFront();
        }

        private void metroTile1_Click(object sender, EventArgs e)
        {
            panel4.Controls.Clear();
            Form_CompletarMantenimiento form = new Form_CompletarMantenimiento();
            form.TopLevel = false;
            form.Parent = panel4;
            form.Dock = DockStyle.Top;
            form.Show();
            form.BringToFront();
        }

        private void inicio_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void metroGrid1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            
        }

        private void metroGrid1_Click(object sender, EventArgs e)
        {
            
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            label9.Refresh();
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
            label9.Text = DateTime.Now.Hour.ToString("D2") + ":" + DateTime.Now.Minute.ToString("D2") + ":" + DateTime.Now.Second.ToString("D2");
            label14.Refresh();
            label14.Text = DateTime.Now.ToString("dddd dd MMMM, yyyy");
        }

        private void metroTabPage5_Click(object sender, EventArgs e)
        {

        }

        private void metroTile26_Click(object sender, EventArgs e)
        {
            panel5.Controls.Clear();
            Form_GenerarVuelo form = new Form_GenerarVuelo();
            form.TopLevel = false;
            form.Parent = panel5;
            form.Dock = DockStyle.Top;
            form.Show();
            form.BringToFront();
        }

        private void metroTile17_Click(object sender, EventArgs e)
        {
            
        }

        private void metroTile25_Click(object sender, EventArgs e)
        {
            panel5.Controls.Clear();
            Form_ModificarVuelo form = new Form_ModificarVuelo();
            form.TopLevel = false;
            form.Parent = panel5;
            form.Dock = DockStyle.Top;
            form.Show();
            form.BringToFront();
        }

        private void metroTile23_Click(object sender, EventArgs e)
        {
            menu.SelectedTab = adminPiloto;
            metroPanel1.Controls.Clear();
            Form_AgregarPiloto form = new Form_AgregarPiloto();
            form.TopLevel = false;
            form.Parent = metroPanel1;
            form.Dock = DockStyle.Top;
            form.Show();
            form.BringToFront();
        }

        private void metroTile17_Click_1(object sender, EventArgs e)
        {
            menu.SelectedTab = adminVuelo;
            panel2.Controls.Clear();
            Form_IngresarAeronave form = new Form_IngresarAeronave();
            form.TopLevel = false;
            form.Parent = panel2;
            form.Dock = DockStyle.Top;
            form.Show();
            form.BringToFront();
        }

        private void metroTile18_Click(object sender, EventArgs e)
        {
            menu.SelectedTab = adminComponente;
            panel3.Controls.Clear();
            Form_AgregarComponente form = new Form_AgregarComponente();
            form.TopLevel = false;
            form.Parent = panel3;
            form.Dock = DockStyle.Top;
            form.Show();
            form.BringToFront();
        }

        private void metroTile19_Click(object sender, EventArgs e)
        {
            menu.SelectedTab = adminMantenimiento;
            panel4.Controls.Clear();
            Form_AgregarMantenimiento form = new Form_AgregarMantenimiento();
            form.TopLevel = false;
            form.Parent = panel4;
            form.Dock = DockStyle.Top;
            form.Show();
            form.BringToFront();
        }

        private void metroTile20_Click(object sender, EventArgs e)
        {
            menu.SelectedTab = adminVuelo;
            panel5.Controls.Clear();
            Form_GenerarVuelo form = new Form_GenerarVuelo();
            form.TopLevel = false;
            form.Parent = panel5;
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

        private void metroTile2_Click(object sender, EventArgs e)
        {
            //panel4.Controls.Clear();
            //Form_ListarMantenimientos form = new Form_ListarMantenimientos();
            //form.TopLevel = false;
            //form.Parent = panel4;
            //form.Dock = DockStyle.Top;
            //form.Show();
            //form.BringToFront();
        }

        private void metroTile24_Click(object sender, EventArgs e)
        {
            menu.SelectedTab = adminVuelo;
            panel5.Controls.Clear();
            Form_CompletarVuelo form = new Form_CompletarVuelo();
            form.TopLevel = false;
            form.Parent = panel5;
            form.Dock = DockStyle.Top;
            form.Show();
            form.BringToFront();
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Form_AlertaMantenimiento form = new Form_AlertaMantenimiento();
            form.Show();
        }
    }
    }


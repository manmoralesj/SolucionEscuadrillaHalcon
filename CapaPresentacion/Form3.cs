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
    public partial class Form3 : MetroFramework.Forms.MetroForm
    {
        public Form3()
        {
            InitializeComponent();
        }

        private void Form3_Load(object sender, EventArgs e)
        {

        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            label9.Refresh();
            label9.Text = DateTime.Now.Hour.ToString("D2") + ":" + DateTime.Now.Minute.ToString("D2") + ":" + DateTime.Now.Second.ToString("D2");
            label14.Refresh();
            label14.Text = DateTime.Now.ToString("dddd dd MMMM, yyyy");
        }

        private void metroTile6_Click(object sender, EventArgs e)
        {
            metroPanel3.Controls.Clear();
            FormReportePilotos form = new FormReportePilotos();
            form.TopLevel = false;
            form.Parent = metroPanel3;
            form.Dock = DockStyle.Top;
            form.Show();
            form.BringToFront();
        }

        private void metroTile24_Click(object sender, EventArgs e)
        {
            metroPanel3.Controls.Clear();
            Form_ReporteAeronaves form = new Form_ReporteAeronaves();
            form.TopLevel = false;
            form.Parent = metroPanel3;
            form.Dock = DockStyle.Top;
            form.Show();
            form.BringToFront();
        }

        private void metroTile2_Click(object sender, EventArgs e)
        {
            metroPanel3.Controls.Clear();
            FormReporteMantenimientos form = new FormReporteMantenimientos();
            form.TopLevel = false;
            form.Parent = metroPanel3;
            form.Dock = DockStyle.Top;
            form.Show();
            form.BringToFront();
        }

        private void metroTile4_Click(object sender, EventArgs e)
        {
            menu.SelectedTab = adminConsultor;
            metroPanel3.Controls.Clear();
            Form_ListarPiloto form = new Form_ListarPiloto();
            form.TopLevel = false;
            form.Parent = metroPanel3;
            form.Dock = DockStyle.Top;
            form.Show();
            form.BringToFront();
        }

        private void metroTile1_Click(object sender, EventArgs e)
        {
            //menu.SelectedTab = adminConsultor;
            //metroPanel3.Controls.Clear();
            //Form_ListarMantenimientos form = new Form_ListarMantenimientos();
            //form.TopLevel = false;
            //form.Parent = metroPanel3;
            //form.Dock = DockStyle.Top;
            //form.Show();
            //form.BringToFront();
        }

        private void metroTile3_Click(object sender, EventArgs e)
        {
            menu.SelectedTab = adminConsultor;
            metroPanel3.Controls.Clear();
            Form_ReporteAeronaves form = new Form_ReporteAeronaves();
            form.TopLevel = false;
            form.Parent = metroPanel3;
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
    }
}

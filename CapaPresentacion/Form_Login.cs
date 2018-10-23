using Oracle.DataAccess.Client;
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
using CapaDALC;

namespace CapaPresentacion
{
    public partial class Form_Login : MetroFramework.Forms.MetroForm
    {
        string nombreUsuario;
        public Form_Login()
        {
            InitializeComponent();
        }
        
        private void Form_Login_Load(object sender, EventArgs e)
        {

        }

        private void metroButton1_Click(object sender, EventArgs e)
        {

            try
            {
                DAO_Usuario usu = new DAO_Usuario();
                
               int resp = usu.login(txtRut.Text, txtPass.Text);

                switch (resp)
                {
                    case 1:
                        MessageBox.Show("Estimado Piloto, sus credenciales no le permiten acceder al sistema interno.","Error de Credenciales");
                        break;
                    case 2:  
                        List<USUARIOS> LC = usu.BuscarUsuario(txtRut.Text);
                        foreach (var item in LC)
                        {
                            nombreUsuario = item.NOMBRES + " " + item.AP_PATERNO + " " + item.AP_MATERNO;
                        }
                        Form1 menuC = new Form1();
                        menuC.lblUsuario.Text = nombreUsuario;
                        menuC.Show();
                        this.Hide();
                        break;
                    case 3:
                        List<USUARIOS> LC2 = usu.BuscarUsuario(txtRut.Text);
                        foreach (var item in LC2)
                        {
                            nombreUsuario = item.NOMBRES + " " + item.AP_PATERNO + " " + item.AP_MATERNO;
                        }
                        Form2 menuA = new Form2();
                        menuA.lblUsuario.Text = nombreUsuario;
                        menuA.Show();
                        this.Hide();
                        break;
                    case 4:
                        List<USUARIOS> LC3 = usu.BuscarUsuario(txtRut.Text);
                        foreach (var item in LC3)
                        {
                            nombreUsuario = item.NOMBRES + " " + item.AP_PATERNO + " " + item.AP_MATERNO;
                        }
                        Form3 menuCT = new Form3();
                        menuCT.lblUsuario.Text = nombreUsuario;
                        menuCT.Show();
                        this.Hide();
                        break;
                    default:
                        break;
                }
            }
            catch (Exception)
            {

                throw;
            }

        }

        private void metroButton2_Click(object sender, EventArgs e)
        {
            
        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            
                
        }
    }
}

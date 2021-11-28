using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SistemaDeAlmacen2
{
    public partial class FrmLogin : Form
    {
        public FrmLogin()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        
        private void BtnIniciarSesion_Click(object sender, EventArgs e)
        {
            if (txtUsuario.Text == "Admin" && (txtContraseña.Text == "1234"))
            {
                
                FrmLogin frmLogin = new FrmLogin();
                frmLogin.Show();
            }

            else
            {
                MessageBox.Show("Datos erróneos, intente de nuevo");
                txtUsuario.Text = "";
                txtContraseña.Text = "";

            }
        }
    }
}

using System;
using System.Linq;
using System.Windows.Forms;

namespace Lab02_01
{
    public partial class frmLogin : Form
    {

        int Intentos = 0;
        PrincipalMDI Principal = new PrincipalMDI();

        public frmLogin()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void btnIniciar_Click(object sender, EventArgs e)
        {
            String[] Usuario = { "leonardo", "fabrizio", "nayo" };
            String[] Contraseña = { "1234", "1111", "0000" };

            if (Usuario.Contains(txtUsuario.Text) && Contraseña.Contains(txtPassword.Text) && Array.IndexOf(Usuario, txtUsuario.Text) == Array.IndexOf(Contraseña, txtPassword.Text))
            {
                Principal.Show();
                this.Hide();
                txtUsuario.Text = "";
                txtPassword.Text = "";
            }
            else
            {
                txtUsuario.Clear();
                txtPassword.Text = "";
                txtUsuario.Focus();
                Intentos += 1;

                if (Intentos == 3)
                {
                    Application.Exit();
                }
            }

        }

        private void frmLogin_Load(object sender, EventArgs e)
        {
            
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void txtUsuario_TextChanged(object sender, EventArgs e)
        {

        }
    }
}

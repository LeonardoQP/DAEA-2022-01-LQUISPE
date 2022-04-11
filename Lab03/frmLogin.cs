using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace Lab03
{
    public partial class frmLogin : Form
    {
        SqlConnection conn;
        public frmLogin(SqlConnection conn)
        {
            this.conn = conn;
            InitializeComponent();
        }

        private void frmLogin_Load(object sender, EventArgs e)
        {

        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnIniciar_Click(object sender, EventArgs e)
        {
            if (conn.State == ConnectionState.Open)
            {
                String usuario = txtUsuario.Text;
                String pass = txtPassword.Text;

                SqlCommand cmd = new SqlCommand();
                cmd.CommandText = "LoginUsuario";
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Connection = conn;

                SqlParameter paramUser = new SqlParameter();
                paramUser.ParameterName = "@usuario";
                paramUser.SqlDbType = SqlDbType.NVarChar;
                paramUser.Value = usuario;

                cmd.Parameters.Add(paramUser);

                SqlParameter paramPass = new SqlParameter();
                paramPass.ParameterName = "@password";
                paramPass.SqlDbType = SqlDbType.NVarChar;
                paramPass.Value = pass;

                cmd.Parameters.Add(paramPass);

                SqlDataReader reader = cmd.ExecuteReader();
                DataTable dt = new DataTable();
                dt.Load(reader);

                if (dt.Rows.Count > 0)
                {
                    Persona persona = new Persona(conn);
                    persona.Show();
                    this.Hide();
                }
                else
                {
                    MessageBox.Show("Usuario o Contraseña incorrectas");
                }
            }                 
        }
    }
}

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Factura
{
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
        }

        private void btnMinimizar_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void btnCerrar_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnLogearte_Click(object sender, EventArgs e)
        {
            CorrerLogin();
        }
        User Usuario1 = new User();
        NewUser NewUser1 = new NewUser();
        Menu menu = new Menu();

        public static string NombreEmpleado;
        public static string Correo;
        public static string Posicion;

        void CorrerLogin()
        {
            DataTable dt = new DataTable();
            Usuario1.usuario = txtNombre.Text;
            Usuario1.clave = txtContraseña.Text;
            dt = NewUser1.N_user(Usuario1);

            if (dt.Rows.Count > 0)
            {
                NombreEmpleado = dt.Rows[0][1].ToString();
                Correo = dt.Rows[0][4].ToString();
                Posicion = dt.Rows[0][6].ToString();

                EntrarMenu();
                Login login = new Login();
                login.ShowDialog();

                if (login.DialogResult == DialogResult.OK)
                    Application.Run(new Menu());

                txtNombre.Clear();
                txtContraseña.Clear();
            }
            else
                MessageBox.Show("Tu usuario y/o Contraseña esta incorrecta", "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
        void EntrarMenu()
        {
            Menu Menu1 = new Menu();
            this.Hide();
            Menu1.ShowDialog();
            this.Close();
        }
    }
}

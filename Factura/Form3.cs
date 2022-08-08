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
    public partial class Menu : Form
    {
        public Menu()
        {
            InitializeComponent();
        }

        private void Menu_Load(object sender, EventArgs e)
        {
            lblNombre.Text = Login.NombreEmpleado;
            lblCorreo.Text = Login.Correo;
            lblPosicion.Text = Login.Posicion;
            if(Login.Posicion != "Administrador")
                label2.Visible = false;
        }

        private void btncerrar_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnminimizar_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }
        void EntrarFactura()
        {
            Form1 factura1 = new Form1();
            this.Hide();
            factura1.ShowDialog();
            this.Close();
        }

        private void lblGoFactura_Click(object sender, EventArgs e)
        {
            EntrarFactura();
        }

        private void label2_Click(object sender, EventArgs e)
        {
            IngresarEmpleado Empleado1 = new IngresarEmpleado();
            Empleado1.ShowDialog();
        }

        private void VolverLogin_Click(object sender, EventArgs e)
        {
            try
            {
                DialogResult rppta = MessageBox.Show("¿Desea volver atras?",
                    "", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                if (rppta == DialogResult.Yes)
                {
                    Login Log1 = new Login();
                    this.Hide();
                    Log1.ShowDialog();
                    this.Close();
                }
            }
            catch { }
        }
        private void lblNombre_Click(object sender, EventArgs e)
        {

        }
    }
}
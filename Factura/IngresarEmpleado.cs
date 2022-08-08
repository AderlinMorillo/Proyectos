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

namespace Factura
{
    public partial class IngresarEmpleado : Form
    {
        string CodPosi;
        public IngresarEmpleado()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        private void cmbPosicion_SelectedIndexChanged(object sender, EventArgs e)
        {
            string Posicion = cmbPosicion.SelectedItem.ToString();

            switch (Posicion)
            {
                case "Administrador": CodPosi = "001"; break;
                case "Vendedor": CodPosi = "002"; break;
            }
        }
        private void button1_Click(object sender, EventArgs e)
        {
            SqlConnection conexion = new SqlConnection("Server=DESKTOP-JN8EDPB; Database=BD_Empleados; Trusted_Connection=True;");
            conexion.Open();
            string IdEmp = txtIdEmpleado.Text;
            string NomEmp = txtNomEmpleado.Text;
            string UserEmp = txtUserEmpleado.Text;
            string ContraEmp = txtContraEmpleado.Text;
            string Correo = txtCorreoEmpleado.Text;
            string cadena = "insert into USUARIOS(IdEmpleado,NombreDeEmpleado,NombreDeUsuario,Contraseña,Correo,IDposicion) values ('"+IdEmp+"','"+NomEmp+"','"+UserEmp+"','"+ContraEmp+"','"+Correo+"','"+CodPosi+"')";
            SqlCommand comando = new SqlCommand(cadena, conexion);
            comando.ExecuteNonQuery();
            MessageBox.Show("Los datos se guardaron correctamente");
            conexion.Close();
            this.Close();   
        }
    }
}

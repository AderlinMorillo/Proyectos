using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;

namespace Factura
{
    public class Usuario
    {
        public static string nombre { get; set; }
        public static int Id { get; set; }
        public static string correo { get; set; }
    }
    class User
    {
        public string usuario { get; set; }
        public string clave { get; set; }
    }
    class NewUser
    {
        BossUser Jefe = new BossUser();
        public DataTable N_user(User usre)
        { return Jefe.BossUsers(usre); }
    }

    class BossUser
    {
        public class cnn
        { public static string db = "Server=DESKTOP-JN8EDPB; Database=BD_Empleados; Trusted_Connection=True;"; }


        public DataTable BossUsers(User usre)
        {
            SqlConnection cn = new SqlConnection(cnn.db);
            cn.Open();
            SqlCommand cmd = new SqlCommand("Usurio", cn);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@usuario", usre.usuario);
            cmd.Parameters.AddWithValue("@contraseña", usre.clave);
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            da.Fill(dt);
            cn.Close();
            return dt;
        }
    }

}
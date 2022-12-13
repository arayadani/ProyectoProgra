using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace ProyectoProgra
{
    public partial class Usuarios : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            LlenarGrid();
        }
        protected void LlenarGrid()
        {
            string constr = ConfigurationManager.ConnectionStrings["ProyectoFinalUHConnectionString"].ConnectionString;
            using (SqlConnection con = new SqlConnection(constr))
            {
                using (SqlCommand cmd = new SqlCommand("SELECT *  FROM Usuarios"))
                {
                    using (SqlDataAdapter sda = new SqlDataAdapter())
                    {
                        cmd.Connection = con;
                        sda.SelectCommand = cmd;
                        using (DataTable dt = new DataTable())
                        {
                            sda.Fill(dt);
                            GridView1.DataSource = dt;
                            GridView1.DataBind();
                        }
                    }
                }
            }
        }

        public void IngresarUsuarios()
        {
            SqlConnection Conn = new SqlConnection();
            using (Conn = DboCon.obtenerConexion())
            {
                SqlCommand cmd = new SqlCommand();
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.CommandText = "IngresarUsuarios ";
                cmd.Parameters.Add("@correo", SqlDbType.VarChar).Value = tcorreoUSU.Text.Trim();
                cmd.Parameters.Add("@clave", SqlDbType.VarChar).Value = TclaveUSU.Text.Trim();
                cmd.Parameters.Add("@tipo", SqlDbType.VarChar).Value = TtipoUSU.Text.Trim();
                cmd.Connection = Conn;
                cmd.ExecuteNonQuery();
            }


        }
        public void BorrarUsuarios()
        {
            SqlConnection Conn = new SqlConnection();
            using (Conn = DboCon.obtenerConexion())
            {
                SqlCommand cmd = new SqlCommand();
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.CommandText = "BorrarUsuarios ";
                cmd.Parameters.Add("@correo", SqlDbType.VarChar).Value = tcorreoUSU.Text.Trim();
                
                cmd.Connection = Conn;
                cmd.ExecuteNonQuery();
            }


        }

        public void ActualizaUsuarios()
        {
            SqlConnection Conn = new SqlConnection();
            using (Conn = DboCon.obtenerConexion())
            {
                SqlCommand cmd = new SqlCommand();
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.CommandText = "ActualizaUsuarios ";
                cmd.Parameters.Add("@correo", SqlDbType.VarChar).Value = tcorreoUSU.Text.Trim();
                cmd.Parameters.Add("@clave", SqlDbType.VarChar).Value = TclaveUSU.Text.Trim();
                cmd.Parameters.Add("@tipo", SqlDbType.VarChar).Value = TtipoUSU.Text.Trim();
                cmd.Connection = Conn;
                cmd.ExecuteNonQuery();
            }


        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            IngresarUsuarios();
            LlenarGrid();
        }

        protected void Button2_Click(object sender, EventArgs e)
        {
            BorrarUsuarios();
            LlenarGrid();


        }

        protected void Button4_Click(object sender, EventArgs e)
        {
            ActualizaUsuarios();
            LlenarGrid();
        }
    }
}

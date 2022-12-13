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
    public partial class Rutinas : System.Web.UI.Page
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
                using (SqlCommand cmd = new SqlCommand("SELECT *  FROM rutinas"))
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

        public void Rutinas_Cliente()
        {
            SqlConnection Conn = new SqlConnection();
            using (Conn = DboCon.obtenerConexion())
            {
                SqlCommand cmd = new SqlCommand();
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.CommandText = "ConsultarRutina";
                cmd.Parameters.Add("@correo_cliente", SqlDbType.VarChar).Value = Trutina.Text.Trim();
                cmd.Connection = Conn;
                cmd.ExecuteNonQuery();
                using (SqlDataAdapter sda = new SqlDataAdapter())
                {
                    sda.SelectCommand = cmd;
                    using (DataTable dt = new DataTable())
                    {
                        sda.Fill(dt);
                        GridView2.DataSource = dt;
                        GridView2.DataBind();
                    }
                }
            }



        }

        public void Modificar_rutina()
        {
            SqlConnection Conn = new SqlConnection();
            using (Conn = DboCon.obtenerConexion())
            {
                SqlCommand cmd = new SqlCommand();
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.CommandText = "CambiarRutina";
                cmd.Parameters.Add("@email_cliente", SqlDbType.VarChar).Value = Trutina.Text.Trim();
                cmd.Parameters.Add("@id_rutina", SqlDbType.VarChar).Value = Rutinas_DD.SelectedValue.Trim();
                cmd.Connection = Conn;
                cmd.ExecuteNonQuery();
            }



        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            Rutinas_Cliente();

        }

        protected void Button2_Click(object sender, EventArgs e)
        {
            Modificar_rutina();
            Rutinas_Cliente();

        }

    }
}

       




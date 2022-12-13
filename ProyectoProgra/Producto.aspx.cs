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
    public partial class Producto : System.Web.UI.Page
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
                using (SqlCommand cmd = new SqlCommand("SELECT *  FROM Producto"))
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
        public void IngresarProducto()
        {
            SqlConnection Conn = new SqlConnection();
            using (Conn = DboCon.obtenerConexion())
            {
                SqlCommand cmd = new SqlCommand();
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.CommandText = "IngresarProductos";
                cmd.Parameters.Add("@nombre_producto", SqlDbType.VarChar).Value = Tnombrepro.Text.Trim();
                cmd.Parameters.Add("@precio_producto", SqlDbType.VarChar).Value = Tpreciopro. Text.Trim();
                cmd.Connection = Conn;
                cmd.ExecuteNonQuery();
            }

        }
        public void BorrarProducto()
        {
            SqlConnection Conn = new SqlConnection();
            using (Conn = DboCon.obtenerConexion())
            {
                SqlCommand cmd = new SqlCommand();
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.CommandText = "BorrarProducto ";
                cmd.Parameters.Add("@nombre_producto", SqlDbType.VarChar).Value = Tnombrepro. Text.Trim();

                cmd.Connection = Conn;
                cmd.ExecuteNonQuery();
            }


        }

        public void ActualizaProducto()
        {
            SqlConnection Conn = new SqlConnection();
            using (Conn = DboCon.obtenerConexion())
            {
                SqlCommand cmd = new SqlCommand();
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.CommandText = "ActualizaProducto ";
                cmd.Parameters.Add("@nombre_producto", SqlDbType.VarChar).Value = Tnombrepro.Text.Trim();
                cmd.Parameters.Add("@precio_producto", SqlDbType.VarChar).Value = Tpreciopro.Text.Trim();
                cmd.Connection = Conn;
                cmd.ExecuteNonQuery();
            }
        }



        protected void Button1_Click(object sender, EventArgs e)
        {
            IngresarProducto();
            LlenarGrid();
        }

        protected void Button2_Click(object sender, EventArgs e)
        {
            BorrarProducto();
        }

        protected void Button3_Click(object sender, EventArgs e)
        {

            ActualizaProducto();
            LlenarGrid();

        }
    }
}
    

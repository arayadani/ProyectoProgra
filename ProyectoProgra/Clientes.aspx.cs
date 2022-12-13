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
    public partial class Clientes : System.Web.UI.Page
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
                using (SqlCommand cmd = new SqlCommand("SELECT *  FROM Clientes"))
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



        public void IngresarClientes()
        {
            SqlConnection Conn = new SqlConnection();
            using (Conn = DboCon.obtenerConexion())
            {
                SqlCommand cmd = new SqlCommand();
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.CommandText = "IngresarCliente ";
                cmd.Parameters.Add("@nombre_cliente", SqlDbType.VarChar).Value = TnombreCli.Text.Trim();
                cmd.Parameters.Add("@apellido_cliente", SqlDbType.VarChar).Value = TapellidoCLi.Text.Trim();
                cmd.Parameters.Add("@telefono_cliente", SqlDbType.VarChar).Value = TtelefonoCli.Text.Trim();
                cmd.Parameters.Add("@email_cliente", SqlDbType.VarChar).Value = TemailCli.Text.Trim();
                cmd.Parameters.Add("@rutina_cliente", SqlDbType.VarChar).Value = TrutinaCli.Text.Trim();
                cmd.Connection = Conn;
                cmd.ExecuteNonQuery();
            }

        }
        public void BorrarClientes()
        {
            SqlConnection Conn = new SqlConnection();
            using (Conn = DboCon.obtenerConexion())
            {
                SqlCommand cmd = new SqlCommand();
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.CommandText = "BorrarCliente ";
                cmd.Parameters.Add("@nombre_cliente", SqlDbType.VarChar).Value = TnombreCli.Text.Trim();

                cmd.Connection = Conn;
                cmd.ExecuteNonQuery();
            }


        }


        public void Modificar_clientes()
        {
            SqlConnection Conn = new SqlConnection();
            using (Conn = DboCon.obtenerConexion())
            {
                SqlCommand cmd = new SqlCommand();
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.CommandText = "Modificar_clientes ";
                cmd.Parameters.Add("@codigo_cliente", SqlDbType.VarChar).Value = TcodigoCli.Text.Trim();
                cmd.Parameters.Add("@nombre_cliente", SqlDbType.VarChar).Value = TnombreCli.Text.Trim();
                cmd.Parameters.Add("@apellido_cliente", SqlDbType.VarChar).Value = TapellidoCLi.Text.Trim();
                cmd.Parameters.Add("@telefono_cliente", SqlDbType.VarChar).Value = TtelefonoCli.Text.Trim();
                cmd.Parameters.Add("@email_cliente", SqlDbType.VarChar).Value = TemailCli.Text.Trim();
                cmd.Parameters.Add("@rutina_cliente", SqlDbType.VarChar).Value = TrutinaCli.Text.Trim();
                cmd.Connection = Conn;
                cmd.ExecuteNonQuery();
            }

            

        }
        protected void Button1_Click(object sender, EventArgs e)
        {
            IngresarClientes();
            LlenarGrid();
        }

        protected void Button2_Click(object sender, EventArgs e)
        {
            BorrarClientes();
        }

        protected void Button3_Click(object sender, EventArgs e)
        {
            Modificar_clientes();
            LlenarGrid();
        }

        protected void TemailCli_TextChanged(object sender, EventArgs e)
        {

        }
    }
}

    


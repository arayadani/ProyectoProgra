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
    public partial class Direcciones : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            LlenarGrid();
            LlenarGrid2();
            LlenarGrid3();
            LlenarGrid4();
        }
        protected void LlenarGrid()
        {
            string constr = ConfigurationManager.ConnectionStrings["ProyectoFinalUHConnectionString"].ConnectionString;
            using (SqlConnection con = new SqlConnection(constr))
            {
                using (SqlCommand cmd = new SqlCommand("SELECT *  FROM Provincia"))
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



        protected void LlenarGrid2()
        {
            string constr = ConfigurationManager.ConnectionStrings["ProyectoFinalUHConnectionString"].ConnectionString;
            using (SqlConnection con = new SqlConnection(constr))
            {
                using (SqlCommand cmd = new SqlCommand("SELECT *  FROM Canton"))
                {
                    using (SqlDataAdapter sda = new SqlDataAdapter())
                    {
                        cmd.Connection = con;
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
        }

        protected void LlenarGrid3()
        {
            string constr = ConfigurationManager.ConnectionStrings["ProyectoFinalUHConnectionString"].ConnectionString;
            using (SqlConnection con = new SqlConnection(constr))
            {
                using (SqlCommand cmd = new SqlCommand("SELECT *  FROM Districto"))
                {
                    using (SqlDataAdapter sda = new SqlDataAdapter())
                    {
                        cmd.Connection = con;
                        sda.SelectCommand = cmd;
                        using (DataTable dt = new DataTable())
                        {
                            sda.Fill(dt);
                            GridView3.DataSource = dt;
                            GridView3.DataBind();
                        }
                    }
                }
            }
        }
        protected void LlenarGrid4()
        {
            string constr = ConfigurationManager.ConnectionStrings["ProyectoFinalUHConnectionString"].ConnectionString;
            using (SqlConnection con = new SqlConnection(constr))
            {
                using (SqlCommand cmd = new SqlCommand("SELECT *  FROM Direcciones"))
                {
                    using (SqlDataAdapter sda = new SqlDataAdapter())
                    {
                        cmd.Connection = con;
                        sda.SelectCommand = cmd;
                        using (DataTable dt = new DataTable())
                        {
                            sda.Fill(dt);
                            GridView4.DataSource = dt;
                            GridView4.DataBind();
                        }
                    }
                }
            }
        }


        public void IngresarDirecciones()
        {
            SqlConnection Conn = new SqlConnection();
            using (Conn = DboCon.obtenerConexion())
            {
                SqlCommand cmd = new SqlCommand();
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.CommandText = "AgregarDirecciones ";
                cmd.Parameters.Add("@comentarios", SqlDbType.VarChar).Value = Tcomentarios.Text.Trim();
                cmd.Parameters.Add("@codigo_cliente", SqlDbType.VarChar).Value = Tcliente.Text.Trim();
                cmd.Parameters.Add("@codigo_provincia", SqlDbType.VarChar).Value = Tprovincia.Text.Trim();
                cmd.Parameters.Add("@codigo_canton", SqlDbType.VarChar).Value = Tcanton.Text.Trim();
                cmd.Parameters.Add("@codigo_districto", SqlDbType.VarChar).Value = Tdistricto.Text.Trim();
                cmd.Connection = Conn;
                cmd.ExecuteNonQuery();
            }

        }
        public void BorrarDirecciones()
        {
            SqlConnection Conn = new SqlConnection();
            using (Conn = DboCon.obtenerConexion())
            {
                SqlCommand cmd = new SqlCommand();
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.CommandText = "BorrarDirecciones ";
                cmd.Parameters.Add("@codigo_direccion", SqlDbType.VarChar).Value = TcodigoDire.Text.Trim();

                cmd.Connection = Conn;
                cmd.ExecuteNonQuery();
            }


        }

        public void ModificarDirecciones()
        {
            SqlConnection Conn = new SqlConnection();
            using (Conn = DboCon.obtenerConexion())
            {
                SqlCommand cmd = new SqlCommand();
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.CommandText = "ModificarDirecciones ";
                cmd.Parameters.Add("@codigo_direccion", SqlDbType.VarChar).Value = TcodigoDire.Text.Trim();
                cmd.Parameters.Add("@codigo_cliente", SqlDbType.VarChar).Value = Tcliente.Text.Trim();
                cmd.Parameters.Add("@comentarios", SqlDbType.VarChar).Value = Tcomentarios.Text.Trim();
                cmd.Parameters.Add("@codigo_provincia", SqlDbType.VarChar).Value = Tprovincia.Text.Trim();
                cmd.Parameters.Add("@codigo_districto", SqlDbType.VarChar).Value = Tdistricto.Text.Trim();
                cmd.Parameters.Add("@codigo_canton", SqlDbType.VarChar).Value = Tcanton.Text.Trim();
                cmd.Connection = Conn;
                cmd.ExecuteNonQuery();
            }

        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            IngresarDirecciones();
            LlenarGrid4();
        }




        protected void Button2_Click(object sender, EventArgs e)
        {
            BorrarDirecciones();

        }

        protected void Modificar_Click(object sender, EventArgs e)
        {
            ModificarDirecciones();
            LlenarGrid4();
        }
    }
}


    
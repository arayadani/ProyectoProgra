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
    public partial class RutinaAdmin : System.Web.UI.Page
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
                using (SqlCommand cmd = new SqlCommand("SELECT *  FROM Rutinas"))
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
        public void IngresarRutina()
        {
            SqlConnection Conn = new SqlConnection();
            using (Conn = DboCon.obtenerConexion())
            {
                SqlCommand cmd = new SqlCommand();
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.CommandText = "IngresarRutina";
                cmd.Parameters.Add("@rutina", SqlDbType.VarChar).Value = NombreRuti.Text.Trim();
                cmd.Connection = Conn;
                cmd.ExecuteNonQuery();
            }

        }
        public void BorrarRutina()
        {
            SqlConnection Conn = new SqlConnection();
            using (Conn = DboCon.obtenerConexion())
            {
                SqlCommand cmd = new SqlCommand();
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.CommandText = "BorrarRutina ";
                cmd.Parameters.Add("@rutina", SqlDbType.VarChar).Value = NombreRuti.Text.Trim();

                cmd.Connection = Conn;
                cmd.ExecuteNonQuery();
            }


        }

        public void ActualizaRutina()
        {
            SqlConnection Conn = new SqlConnection();
            using (Conn = DboCon.obtenerConexion())
            {
                SqlCommand cmd = new SqlCommand();
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.CommandText = "ActualizaRutina ";
                cmd.Parameters.Add("@rutina1", SqlDbType.VarChar).Value = NombreRuti.Text.Trim();

                cmd.Connection = Conn;
                cmd.ExecuteNonQuery();
            }
        }

        protected void AgregarRuti_Click(object sender, EventArgs e)
        {
            IngresarRutina(); 
            LlenarGrid();
        }

        protected void Button3_Click(object sender, EventArgs e)
        {
            BorrarRutina();
           
        }

        protected void ModificarRuti_Click(object sender, EventArgs e)
        {
            ActualizaRutina();
            LlenarGrid();
        }
    }
    }
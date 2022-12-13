using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace ProyectoProgra
{
    public partial class Reportes : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {






        }
        public void LlenarGridUsu()
        {
            SqlConnection Conn = new SqlConnection();
            using (Conn = DboCon.obtenerConexion())
            {
                SqlCommand cmd = new SqlCommand();
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.CommandText = "SelectUsu";
                cmd.Parameters.Add("@correo", SqlDbType.VarChar).Value = DropDownList1.SelectedValue.Trim();
                cmd.Connection = Conn;
                cmd.ExecuteNonQuery();
                using (SqlDataAdapter sda = new SqlDataAdapter())
                {
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
        public void LlenarGridCli()
        {
            SqlConnection Conn = new SqlConnection();
            using (Conn = DboCon.obtenerConexion())
            {
                SqlCommand cmd = new SqlCommand();
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.CommandText = "SelectCli";
                cmd.Parameters.Add("@email_cliente", SqlDbType.VarChar).Value = DropDownList1.SelectedValue.Trim();
                cmd.Connection = Conn;
                cmd.ExecuteNonQuery();
                using (SqlDataAdapter sda = new SqlDataAdapter())
                {
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
        public void LlenarGridRuti()
        {
            SqlConnection Conn = new SqlConnection();
            using (Conn = DboCon.obtenerConexion())
            {
                SqlCommand cmd = new SqlCommand();
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.CommandText = "SelectRuti";
                cmd.Parameters.Add("@email_cliente", SqlDbType.VarChar).Value = DropDownList1.SelectedValue.Trim();
                cmd.Connection = Conn;
                cmd.ExecuteNonQuery();
                using (SqlDataAdapter sda = new SqlDataAdapter())
                {
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

        protected void Button1_Click(object sender, EventArgs e)
        {
            LlenarGridUsu();

        }

        protected void Button2_Click(object sender, EventArgs e)
        {
            LlenarGridCli();
        }

       

        protected void Button5_Click(object sender, EventArgs e)
        {
            LlenarGridRuti();
        }
    }
}
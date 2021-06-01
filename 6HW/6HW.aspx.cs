using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Data;
using System.Web.UI.WebControls;
using System.Data.SqlClient;

namespace _6HW
{
    public partial class _6HW : System.Web.UI.Page
    {
        string s_Conn = "Data Source=(localdb)\\ProjectsV13;" +
              "Initial Catalog=Test;" +
              "Integrated Security=True;" +
              "Connect Timeout=30;Encrypt=False;" +
              "TrustServerCertificate=False;" +
              "ApplicationIntent=ReadWrite;MultiSubnetFailover=False;" +
              "User ID = sa; Password = 12345";
        protected void Page_Load(object sender, EventArgs e)
        {
           
            SqlConnection o_Conn = new SqlConnection(s_Conn);
            try
            {

                o_Conn.Open();
                SqlCommand o_Com = new SqlCommand("SELECT * FROM Users", o_Conn);
                SqlDataReader o_reas = o_Com.ExecuteReader();
                for (; o_reas.Read();)
                {
                    for (int i = 0; i < o_reas.FieldCount; i++)
                    {
                        Response.Write(o_reas[i]);

                    }
                    Response.Write("<br />");
                }
                o_Conn.Close();
            }
            catch (Exception o_Exc)
            {
                Response.Write(o_Exc.ToString());
            }
        }

        protected void btn_Del_Click(object sender, EventArgs e)
        {
            SqlConnection o_Conn = new SqlConnection(s_Conn);
            try
            {
                o_Conn.Open();
                SqlCommand o_Com = new SqlCommand("DELETE FROM Users WHERE Name=N'" + tb_Name.Text + "';", o_Conn);
                SqlDataReader o_reas = o_Com.ExecuteReader();
                Response.Redirect("./6HW.aspx");
                o_Conn.Close();
            }
            catch (Exception o_Exc)
            {
                Response.Write(o_Exc.ToString());
            }
        }
    }
}
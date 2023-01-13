using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace ASPLogin
{
    public partial class WebForm1 : System.Web.UI.Page
    {
        SqlConnection SQLConn = new SqlConnection("Data Source=NDA2-SQL1\\NDASHAFTDB;Initial Catalog=NDA_TRACE_ADMIN_DB;User ID=sa;Password=NDA_Admin;");
        //SqlConnection SQLConn = new SqlConnection("Data Source=NDA2-SQL1\\NDASHAFTDB;Initial Catalog=NDA_TRACE_ADMIN_DB; Integrated Security=True");
        protected void Page_Load(object sender, EventArgs e)
        {

            try
            {
                // Open the connection
                SQLConn.Open();

                // Check the connection status
                if (SQLConn.State == ConnectionState.Open)
                {
                    Console.WriteLine("Connection Successful");
                    // Execute your SQL commands here
                }
                else
                {
                    Console.WriteLine("Connection Failed");
                }
            }
            catch (SqlException ex)
            {
                Console.WriteLine("Error: " + ex.Message);
            }
        }
        protected void Button1_Click(object sender, EventArgs e)
        {
            message.Text = "";
            SqlDataAdapter sqlDataAdapter = new SqlDataAdapter("SELECT * FROM MST_USER WHERE USER_NO='"+ txtUser.Text+"'", SQLConn);
            DataTable DT = new DataTable();
            sqlDataAdapter.Fill(DT);

            if(DT.Rows.Count > 0)
            {
                message.Visible = true;
                message.Text = "You have logged in";
                message.ForeColor = System.Drawing.Color.Green;
            }
            else
            {
                message.Visible = true;
                message.Text = "There was a promblem";
                message.ForeColor = System.Drawing.Color.Red;
            }

        }
    }
}
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace TicketCounter
{
    public partial class Login : System.Web.UI.Page
    {
        SqlConnection connect = null;
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void btnSignUp_Click(object sender, EventArgs e)
        {
            Response.Redirect("~/signUp.aspx", true);
        }
        public void connection()
        {
            try
            {
                String strcon = "Data Source =DESKTOP-TVUOF0N\\JANNATULSQL; Initial Catalog = TicketCounter; Integrated Security = True";
                connect = new SqlConnection(strcon);
                connect.Open();
            }
            catch (Exception e)
            {

            }
        }
        protected void Button1_Click(object sender, EventArgs e)
        {
            String name = tbxusername.Text;
            String password = tbxpassword.Text;
            connection();
            SqlCommand cmd = new SqlCommand("select * from regstrationTable where name=@a and password=@b",connect);
            cmd.Parameters.AddWithValue("@a",name);
            cmd.Parameters.AddWithValue("@b", password);
            var dataReader = cmd.ExecuteReader();
            DataTable dt = new DataTable();
            dt.Load(dataReader);
            if (dt.Rows.Count> 0)
            {
                Session["userName"] = tbxusername.Text;
                Response.Redirect("~/HomePage.aspx",true);
            }
            else
            {
                lblShow.Text = "Log In falied";
            }
            connect.Close();

        }
    }
}
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace TicketCounter
{
    public partial class signUp : System.Web.UI.Page
    {
        SqlConnection connect = null;
        protected void Page_Load(object sender, EventArgs e)
        {

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
        protected void btnSignUp_Click(object sender, EventArgs e)
        {
            connection();
            SqlCommand cmd = new SqlCommand("insert into regstrationTable values (@a,@b,@c,@d)", connect);
            cmd.Parameters.AddWithValue("@a", Convert.ToInt32(tbxId.Text.ToString().Trim()));
            cmd.Parameters.AddWithValue("@b", tbxUserName.Text);
            cmd.Parameters.AddWithValue("@c", tbxPasword.Text);
            cmd.Parameters.AddWithValue("@d", tbxNumber.Text);
            cmd.ExecuteNonQuery();
            lblShow.Text = "Sign Up Succesfully";
            connect.Close();
        }

        protected void btnSignIn_Click(object sender, EventArgs e)
        {
            Response.Redirect("~/Login.aspx",true);
        }
    }
}
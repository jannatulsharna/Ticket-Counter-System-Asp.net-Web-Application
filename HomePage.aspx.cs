using System;
using System.Data.SqlClient;

namespace TicketCounter
{
    public partial class HomePage : System.Web.UI.Page
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
        protected void Button2_Click(object sender, EventArgs e)
        {
            connection();
            SqlCommand cmd = new SqlCommand("insert into ticketInfo values (@a,@b,@c,@d,@e,@f)", connect);
            cmd.Parameters.AddWithValue("@a", tbxname.Text);
            cmd.Parameters.AddWithValue("@b", tbxphonenumber.Text);
            cmd.Parameters.AddWithValue("@c", route.Text);
            cmd.Parameters.AddWithValue("@d", day.Text);
            cmd.Parameters.AddWithValue("@e", Convert.ToInt32(tbxnumberofticket.Text.ToString().Trim()));
            cmd.Parameters.AddWithValue("@f", time.Text);
            cmd.ExecuteNonQuery();
            connect.Close();
            lblSow.Text = "Saved In Succesfully";
            lblSow.ForeColor = System.Drawing.Color.Green;
            Session["name"] = tbxname.Text;
            Response.Redirect("~/TicketDetails.aspx", true);

        }
    }
}
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
    public partial class TicketDetails : System.Web.UI.Page
    {
        SqlConnection connect = null;
        protected void Page_Load(object sender, EventArgs e)
        {
            load();
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
        
        protected void load()
        {
            connection();
            SqlCommand cmd = new SqlCommand("select * from ticketinfo where pname=@a", connect);
            cmd.Parameters.AddWithValue("@a", Session["name"].ToString());
            SqlDataReader dt = cmd.ExecuteReader();
            if (dt.Read())
            {
                tbxName.Text = Session["name"].ToString();
                tbxTime.Text = (dt["ptime"].ToString());
                tbxdes.Text = (dt["proute"].ToString());
                tbxDay.Text = (dt["pday"].ToString());
                tbxA.Text = (dt["numberOfTicket"].ToString());
                String a = (dt["proute"].ToString());
                int Cost = 0;
                if(a.Equals ("Dhaka - Tangail"))
                {
                    Cost = 160;
                    Cost *= Convert.ToInt32(tbxA.Text.ToString());
                }
                else if (a.Equals("Dhaka - Jamalpur"))
                {
                    Cost = 200;
                    Cost *= Convert.ToInt32(tbxA.Text.ToString());
                }
                else if (a.Equals("Dhaka - Chittagong"))
                {
                    Cost = 450;
                    Cost *= Convert.ToInt32(tbxA.Text.ToString());
                }
                tbxCost.Text = Cost.ToString();
            }
            
            connect.Close();
        }
        protected void btnConfirm_Click(object sender, EventArgs e)
        {
            lblShow.Text = "Your ticket confirmation Succesfully";
        }
    }
}
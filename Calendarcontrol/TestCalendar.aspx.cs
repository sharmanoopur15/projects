using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data.SqlClient;
using System.Drawing;

namespace Calendarcontrol
{
    public partial class TestCalendar : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void btnTestConnection_Click(object sender, EventArgs e)
        {
            if (Page.IsPostBack)
            {
                SqlConnection conn = null;
                try
                {
                    conn= new SqlConnection(txtConnString.Text);
                    conn.Open();

                    lblStatus.ForeColor = Color.Green;
                    lblStatus.Text = "Connection Succeeded";
                }
                catch (Exception ex)
                {
                    lblStatus.ForeColor = Color.Red;
                    lblStatus.Text = ex.Message + "\n" + ex.StackTrace;
                }
                finally
                {
                    if (conn != null)
                    {
                        conn.Close();
                    }
                }
            }
        }

    }
}
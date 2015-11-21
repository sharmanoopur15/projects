using System;
using System.Data;
using System.Configuration;
using System.Collections;
using System.Web;
using System.Web.Security;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Web.UI.WebControls.WebParts;
using System.Web.UI.HtmlControls;
using System.Data.Sql;
using System.Data.SqlClient;

using System.Xml;
namespace Calendarcontrol
{
    public partial class AddMember : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void btnSave_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection(@"Data Source=USER-PC\SQLEXPRESS;Initial Catalog=CalendarApp; Integrated Security=true");
            con.Open();
            SqlCommand cmd = new SqlCommand(" insert into Members(" + " General,Name 1,Name 2,Last Name,Address,Phone 1,Phone 2,Email 1,Email 2," + ") values (" + " @txtgeneral.Text,@txtname1.Text,@Txtname2,@TxtPlace.Text,@txtAddress.Text,@Txtphone1.Text,@Txtphone2.Text,@Txtemail1,Txtemail2.Text" + ")", con);
            //con.Open();
            cmd.ExecuteNonQuery();
            con.Close();


        }

        protected void btnCancel_Click(object sender, EventArgs e)
        {
            Response.Redirect("Home.aspx");
        }
    }
}
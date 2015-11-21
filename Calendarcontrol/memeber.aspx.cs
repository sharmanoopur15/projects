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
using System.Web.Script;

using System.Xml;

namespace Calendarcontrol
{
    public partial class memeber : System.Web.UI.Page
    {
        private const string CONNECTION_NAME = "ConnStringDb1";
        SqlConnection con;
        SqlDataAdapter da;
        private string s;

        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                binddata();
            }
        }
        //SqlConnection con = new SqlConnection(@"Data Source=.\SQLEXPRESS;AttachDbFilename=|DataDirectory|\Calendar.mdf;Integrated Security=True;User Instance=True");
        //con.Open();
        void binddata()
        {
            //s = WebConfigurationManager.ConnectionStrings["ChartDatabaseConnectionString"].ConnectionString;
            //con = new SqlConnection(s);
                //SqlConnection con = new SqlConnection(@"Data Source=USER-PC\SQLEXPRESS;Initial Catalog=CalendarApp; Integrated Security=true");
                SqlConnection con = new SqlConnection(ConfigurationManager.ConnectionStrings[CONNECTION_NAME].ConnectionString);
            //SqlConnection con = new SqlConnection(@"Data Source=.\SQLEXPRESS;AttachDbFilename=|DataDirectory|\Calendar.mdf;Integrated Security=True;User Instance=True");
            con.Open();
          da = new SqlDataAdapter("Select * from Members", con);
          //da = new SqlDataAdapter("Select General,Name1,Name2,LastName,Address,Phone1,Phone2,Email1,Email2 from Members", con);
            DataSet ds = new DataSet();
            da.Fill(ds);
            GridView1.DataSource = ds;
            GridView1.DataBind();
        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            Response.Redirect("Home.aspx");
        }
    }
}


        
    

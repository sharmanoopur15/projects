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
    
   
    //class Test
    //{
    //    public string setMeetingName { get; set; }
    //    public string setStartTime { get; set; }
    //    public string setEndTime { get; set; }
    //}
    public class Newevents

    {
        private const string CONNECTION_NAME = "ConnStringDb1";
        SqlConnection con;
    
        DataSet dsevents;
        DataSet dscal;
        SqlDataAdapter da;
       
       
        //public Newevents()
        //{
        //}



        public DataSet Add(string seveenttype, string sDate, string time, string place, string sComment)
        {
            try
            {
                dsevents = new DataSet();
               // SqlConnection con = new SqlConnection(@"Data Source=ELIZABETH-PC\SQLSERVER;Initial Catalog=CalendarApp;User ID=sa;Password=root@12345");
                //SqlConnection con = new SqlConnection(@"Data Source=USER-PC\SQLEXPRESS;Initial Catalog=CalendarApp; Integrated Security=true");
                 SqlConnection con = new SqlConnection(ConfigurationManager.ConnectionStrings[CONNECTION_NAME].ConnectionString);
                string querystring = "Insert into EVENTS(EVENT_TYPE,EVENT_DATE,EVENT_TIME,EVENT_PLACE,EVENT_COMMENTS) values('" + seveenttype + "','" + sDate + "','" + time + "','" + place + "','" + sComment + "' ) ;SELECT SCOPE_IDENTITY()";
                
                SqlCommand cmd = new SqlCommand(querystring, con);
                con.Open();
                da = new SqlDataAdapter(cmd);

                var SERNUMBER = cmd.ExecuteScalar();
                 
                da.Fill(dsevents);
                con.Close();
               
                   }
            catch (Exception ex)
            {
                //iErrNum = 20999;
                //sErrMsg = ex.Message;
            }

            return dsevents;
           

        }

        public DataSet Retrive(Int16 iSernumber)
        {
            try
            {
                dscal = new DataSet();
                SqlConnection con = new SqlConnection(@"Data Source=ELIZABETH-PC\SQLSERVER;Initial Catalog=CalendarApp;User ID=sa;Password=root@12345");
                string querystring = "SELECT * FROM EVENTS WHERE EVENT_SER_NUMBER ='" + iSernumber + "'";

                SqlCommand cmd = new SqlCommand(querystring, con);
                con.Open();
                da = new SqlDataAdapter(cmd);

               // var SERNUMBER = cmd.ExecuteScalar();

                da.Fill(dscal);
                con.Close();

            }
            catch (Exception ex)
            {
                //iErrNum = 20999;
                //sErrMsg = ex.Message;
            }

            return dscal;


        }
    }
    }
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
using System.Windows.Forms;
using System.Collections.Generic;
using System.Web.Script;
using System.Web.Script.Serialization;
using System.Web.Services;
//using System.Collections.Generic;


namespace Calendarcontrol
{
  
    public partial class Newevent : System.Web.UI.Page
    {

        Newevents events =new Newevents();
        DataSet dsevents;
        Int32 iErrNum;
        DataSet dscal;
       // string meeting name;
       // DataTable dscals=new DataTable();
      


       
        protected void Page_Load(object sender, EventArgs e)
        {

        }
    //    [WebMethod(EnableSession = true)]

        protected void btnSave_Click(object sender, EventArgs e)
        {
            //var date=Convert.To
            var time = txteventhour.Text + txteventminute.Text;
            Session["time"] = ddltime.SelectedItem.Value;
            dsevents = events.Add(Convert.ToString(ddleventtype.SelectedItem.ToString()), txteventdate.Text, time, Convert.ToString(ddlplace.SelectedItem.ToString()), txtComment.Text);
            ddleventtype.Items.Clear();
            ddleventtype.SelectedIndex = 0;
            txteventdate.Text = " ";
            txteventhour.Text = " ";
            txteventminute.Text = "";
            ddltime.Items.Clear();
            ddltime.SelectedIndex = 0;
            ddlplace.Items.Clear();
            ddlplace.SelectedIndex = 0;
            txtComment.Text = "";
            Session["SerialNumber"] = dsevents.Tables[0].Rows[0][0].ToString();

           /* dscal = events.Retrive(Convert.ToInt16(Session["SerialNumber"].ToString()));
            //List<string> eventslist = new List<string>();
            //{
            //    string a = dsevents.Tables[0].Rows[0][0].ToString();
                
            //}
            ///nikhil this is my dataset
            string title = dscal.Tables[0].Rows[0][1].ToString();
            // var eventslist = dscal.Tables[0].AsEnumerable().Select(dataRow => new Newevents{Name = dataRow.Field<string>("Name")}.ToList();

            //    List<Test> list = new List<Test>();   //Creating list with type MeetingClass(User defined class with MeetingName,StartTime,EndTime & corresponding get-set methods)
            //   // Newevents meetingObject = new Newevents();	//Creating an object of the class MeetingClass
            //    list =(from DataRow row in dscal.Tables.ToString()
            //           select new Test
            //           {
            //    //Read and assign each data to object of the class
            //    //events.setMeetingName(dscal.Tables[0].Rows[0][0].ToString());
            //    //events.setStartTime(dscal.Tables[0].Rows[0][1].ToString());
            //    //events.setEndTime(dscal.Tables[0].Rows[0][2].ToString());
            //    setMeetingName =(dscal.Tables[0].Rows[0][0].ToString())

            //}).ToList();

            //             return (from row in dscal.Tables[0].AsEnumerable()
            //            select new Newevents {
            //                Product_ID = row.Field<string>("Product_ID"),
            //                ProductDescr = row.Field<string>("ProductDescr"),
            //            }).ToList();
            //}



            JavaScriptSerializer jss = new JavaScriptSerializer();
            String json = jss.Serialize(title);

            Response.Write(json);
            Response.End();*/



        }


      
        
        protected void btnCancel_Click(object sender, EventArgs e)
        {
            Response.Redirect("Calendar.aspx");
        }

        //protected void btnback_Click(object sender, EventArgs e)
        //{
        //    Response.Redirect("cal.aspx");
        //}

       

        
    }
}
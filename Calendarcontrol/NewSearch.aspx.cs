﻿using System;
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
using System.Windows.Forms;
using System.Xml;
namespace Calendarcontrol
{
    public partial class NewSearch : System.Web.UI.Page

    {

        NewSearchss eventsearch = new NewSearchss();
        DataSet dsSearch;
        DataSet dsPlace;
        DataSet dsUpdate;
        DataSet dsUpdateBind;
        DataTable dtSummary;
        DataRow dr;
        
       // Int16 iErrrnum;
        protected void Page_Load(object sender, EventArgs e)
        {
            try {
                if (!this.IsPostBack)
                {

                    
                }
            }
            catch {
            }

        }

        protected void btnSearch_Click(object sender, EventArgs e)
        
        {

            dsSearch = eventsearch.Search(ddleventtype.SelectedItem.ToString(), Convert.ToString(txteventdate.Text), ddlplace.SelectedItem.ToString());
            gvResult.DataSource = dsSearch;
            gvResult.DataBind();
            pnlEditBody.Visible = false;
            pnlEditHeader.Visible = false;
           // pnlCreateBody.Visible = false;
           // pnlCreateHeader.Visible = false;
            pnlResultHeader.Visible = true;
            pnlResultBody.Visible = true;
            if (dsSearch.Tables[0].Rows.Count == 0)
            {
                gvDefault();
                gvResult.Rows[0].Cells[0].Text = "No Data Found";
                //gvResult.Rows[0].Cells[0].ForeColor=
            }
           
        }

        protected void btnSearch_Click1(object sender, EventArgs e)
        {

        }


        protected void gvResult_RowCommand(object sender, GridViewCommandEventArgs e)
        {
            ddlEventtypeEdit.Items.Clear();
            txtEventDateEdit.Text = "";
            txthourEdit.Text = "";
            ddlPlaceEdit.Items.Clear();
            txtComments.Text = "";

            pnlEditBody.Visible = true;
            pnlEditHeader.Visible = true;
            btnUpdate.Visible = false;
            btnedit.Visible = true;
            int currentRowIndex = Convert.ToInt32(e.CommandArgument);
            Session["SerialNumber"] = Convert.ToInt64(gvResult.DataKeys[currentRowIndex].Value);
            dsSearch = eventsearch.Edit(Convert.ToInt32(Session["SerialNumber"]));

            ddlEventtypeEdit.Items.Add(new ListItem(dsSearch.Tables[0].Rows[0][1].ToString()));
            txtEventDateEdit.Text = dsSearch.Tables[0].Rows[0][2].ToString();
            txthourEdit.Text = dsSearch.Tables[0].Rows[0][3].ToString();
            ddlPlaceEdit.Items.Add(new ListItem(dsSearch.Tables[0].Rows[0][4].ToString()));
            txtComments.Text = dsSearch.Tables[0].Rows[0][5].ToString();
            
            ddlEventtypeEdit.Enabled = false;
            txtEventDateEdit.Enabled = false;
            txthourEdit.Enabled = false;
            txtMinuteEdit.Enabled = false;
            ddlPlaceEdit.Enabled = false;
            txtComments.Enabled = false;
            if (dsSearch.Tables[0].Rows.Count == 0)
            {
                gvDefault();
                gvResult.Rows[0].Cells[0].Text = "No Data Found";
                //gvResult.Rows[0].Cells[0].ForeColor=
            }
            
        }

        protected void btnedit_Click(object sender, EventArgs e)
        {
            btnUpdate.Visible = true;
            btnedit.Visible = false;

            dsSearch = eventsearch.MeetingSearch();
            ddlEventtypeEdit.DataSource = dsSearch;

            ddlEventtypeEdit.DataValueField = dsSearch.Tables[0].Columns[0].ColumnName.ToString();
            ddlEventtypeEdit.DataTextField = dsSearch.Tables[0].Columns[1].ColumnName.ToString();

            ddlEventtypeEdit.DataBind();
            ddlEventtypeEdit.Items.Insert(0, new ListItem("-Select-", "0"));
            ddlEventtypeEdit.SelectedIndex = 0;
            ddlEventtypeEdit.Enabled = true;

            dsPlace = eventsearch.PlaceSearch();
            ddlPlaceEdit.DataSource = dsPlace;

            ddlPlaceEdit.DataValueField = dsPlace.Tables[0].Columns[0].ColumnName.ToString();
            ddlPlaceEdit.DataTextField = dsPlace.Tables[0].Columns[1].ColumnName.ToString();

            ddlPlaceEdit.DataBind();
            ddlPlaceEdit.Items.Insert(0, new ListItem("-Select-", "0"));
            ddlPlaceEdit.SelectedIndex = 0;
            ddlPlaceEdit.Enabled = true;
            txtEventDateEdit.Enabled = true;
            txthourEdit.Enabled = true;
            txtMinuteEdit.Enabled = true;
            txtComments.Enabled = true;

          

          
            

        }

        protected void btnUpdate_Click(object sender, EventArgs e)
        {
           
            dsUpdate = eventsearch.Update( (Convert.ToInt32(Session["SerialNumber"])),ddlEventtypeEdit.SelectedItem.ToString(), txtEventDateEdit.Text, txthourEdit.Text, ddlPlaceEdit.SelectedItem.ToString(), txtComments.Text);
            //gvResult.DataSource = dsUpdate;
            //gvResult.DataBind();
            dsUpdateBind = eventsearch.UpdateBind((Convert.ToInt32(Session["SerialNumber"])));
            gvResult.DataSource = dsUpdateBind;
            gvResult.DataBind();

            string message = "Updated succesfully";
            var result = MessageBox.Show(message);
            ddlEventtypeEdit.Items.Clear();
            txtEventDateEdit.Text = "";
            txthourEdit.Text = "";
            txtMinuteEdit.Text = "";
            ddlPlaceEdit.Items.Clear();
            txtComments.Text = "";
            pnlEditBody.Visible = false;
            pnlEditHeader.Visible = false;
                      
          
            
             
           
        }

        protected void btnCancel_Click(object sender, EventArgs e)
        {
            Response.Redirect("Calendar.aspx");
        }

        protected void btnDelete_Click(object sender, EventArgs e)
        {
            eventsearch.Delete(Convert.ToInt32(Session["SerialNumber"]));
            string message = "Deleted succesfully";
            var result = MessageBox.Show(message);
            pnlEditBody.Visible = false;
            pnlEditHeader.Visible = false;
            pnlResultBody.Visible = false;
            pnlResultHeader.Visible = false;

        }


        private void gvDefault()
        {
            dtSummary = new DataTable();
            dtSummary.Columns.Add(new DataColumn("EVENT TYPE", typeof(string)));
            dtSummary.Columns.Add(new DataColumn("EVENT DATE", typeof(string)));
            dtSummary.Columns.Add(new DataColumn("EVENT PLACE", typeof(string)));
           
            dtSummary.Columns[1].ColumnName = "EVENT_TYPE";
            dtSummary.Columns[0].ColumnName = "EVENT_DATE";
            dtSummary.Columns[2].ColumnName = "EVENT_PLACE";
           
            dr = dtSummary.NewRow();
            dtSummary.Rows.Add(dr);
            gvResult.DataSource = dtSummary;
            //gvResult.DataBind();
        }

        protected void btnCancelEdit_Click(object sender, EventArgs e)
        {
            //Response.Redirect("");
            pnlEditBody.Visible = false;
            pnlEditHeader.Visible = false;

        }
    }
}
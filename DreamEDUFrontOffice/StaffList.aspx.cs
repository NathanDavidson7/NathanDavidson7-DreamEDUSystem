using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using DreamEDUClasses;

public partial class StaffList : System.Web.UI.Page
{
    //this function handles the load event for the page
    protected void Page_Load(object sender, EventArgs e)
    {
        //if this is the first time the page is displayed
        if(IsPostBack == false)
        {
            //update the list box
            DisplayStaff();
        }
    }

    void DisplayStaff()
    {
        //create an instance of the staff collection
        DreamEDUClasses.clsStaffCollection Staff = new DreamEDUClasses.clsStaffCollection();
        //set the data source to the list of stafff in the collection
        lstStaffList.DataSource = Staff.StaffList;
        //set the name of the primary key
        lstStaffList.DataValueField = "sID";
        //set the data field to display
        lstStaffList.DataTextField = "sName";
        //bind the data to the list
        lstStaffList.DataBind();
    }

    //event handler for the add button
    protected void btnAdd_Click(object sender, EventArgs e)
    {
        //store -1 into the session object to indicate this is a new record
        Session["sID"] = -1;
        //redirect the data to the entry page
        Response.Redirect("sStaff.aspx");
    }

    protected void btnDelete_Click(object sender, EventArgs e)
    {
        //var to store the primary key value of the record to be deleted
        Int32 sId;
        //if a record has been selected from the list 
        if(lstStaffList.SelectedIndex != -1)
        {
            //get the primary key value of the record to delete
            sId = Convert.ToInt32(lstStaffList.SelectedValue);
            //store the data in the session object
            Session["sID"] = sId;
            //redirect to the delet page
            Response.Redirect("DeleteStaff.aspx");
        }
        else //if no record has been selected
        {
            //display an error 
            lblError.Text = "Please select a record to delete from the list";
        }
    }

    protected void btnEdit_Click(object sender, EventArgs e)
    {
        //var to store the primary key value of the record to be deleted
        Int32 sId;
        //if a record has been selected from the list 
        if (lstStaffList.SelectedIndex != -1)
        {
            //get the primary key value of the record to edit
            sId = Convert.ToInt32(lstStaffList.SelectedValue);
            //store the data in the session object
            Session["sID"] = sId;
            //redirect to the delet page
            Response.Redirect("sStaff.aspx");
        }
        else //if no record has been selected
        {
            //display an error
            lblError.Text = "Please select a record to edit from the list";
        }

    }

    protected void btnApply_Click(object sender, EventArgs e)
    {
        //create an instance of the address collection
        clsStaffCollection Staff = new clsStaffCollection();
        Staff.ReportBysPhone(txtFilter.Text);
        lstStaffList.DataSource = Staff.StaffList;
        //set the name of the primary key
        lstStaffList.DataValueField = "sID";
        //set the name of the field to display
        lstStaffList.DataTextField = "sPhone";
        //bind the data to the list
        lstStaffList.DataBind();
    }

    protected void btnClear_Click(object sender, EventArgs e)
    {
        //create an instance of the address collection
        clsStaffCollection Staff = new clsStaffCollection();
        Staff.ReportBysPhone(txtFilter.Text);
        //clear any existing filter to tidy up the interface
        txtFilter.Text = "";
        lstStaffList.DataSource = Staff.StaffList;
        //set the name of the primary key
        lstStaffList.DataValueField = "sID";
        //set the name of the field to display
        lstStaffList.DataTextField = "sPhone";
        //bind the data to the list
        lstStaffList.DataBind();
    }
}
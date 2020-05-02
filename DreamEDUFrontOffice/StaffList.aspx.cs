using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

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
}
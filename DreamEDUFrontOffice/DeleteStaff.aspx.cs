using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using DreamEDUClasses;

public partial class DeleteStaff : System.Web.UI.Page
{
    //var to store the primary key value of the record to be deleted
    Int32 sId;
    //event handler for the load event
    protected void Page_Load(object sender, EventArgs e)
    {
        //get the number of the staff to be deleted from the session object
        sId = Convert.ToInt32(Session["sID"]);
    }



    protected void Button1_Click(object sender, EventArgs e)
    {
        //create a new instance of the staff
        clsStaffCollection StaffBook = new clsStaffCollection();
        //find the record to delete
        StaffBook.ThisStaff.Find(sId);
        //delete the record
        StaffBook.Delete();
        //redirect back to main page
        Response.Redirect("StaffList.aspx");
    }
}
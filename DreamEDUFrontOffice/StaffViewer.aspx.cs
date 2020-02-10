using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using DreamEDUClasses;

public partial class StaffViewer : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        //create new instance of clsStaff
        clsStaff aStaff = new clsStaff();
        //get the data from the session object
        aStaff = (clsStaff)Session["aStaff"];
        //display the staff number for this entry
        Response.Write(aStaff.sID);

    }
}
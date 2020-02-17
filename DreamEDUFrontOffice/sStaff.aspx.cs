using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using DreamEDUClasses;

public partial class sStaff : System.Web.UI.Page
{
    private object txtsJoiningDate;

    protected void Page_Load(object sender, EventArgs e)
    {

    }

    protected void Button1_Click(object sender, EventArgs e)
    {


    }

    protected void CheckBox1_CheckedChanged(object sender, EventArgs e)
    {

    }

    protected void Button1_Click1(object sender, EventArgs e)
    {
        //create a new instance of class
        clsstaff aStaff = new clsstaff();
        //capture the staffId
        aStaff.sID = Convert.ToInt32(sID.Text);
        //capture the staff Name
        aStaff.sName = sName.Text;
        //capture the staff Address
        aStaff.sAddress = sAddress.Text;
        //capture whetherTutorOrNot
        aStaff.sTutorOrNot = Yes.Checked;
        //capture staffPhNo
        aStaff.sPhone = sPhone.Text;
        //capture staff joining date
        aStaff.sJoiningDate = Convert.ToDateTime(sJoiningDate.Text);
        //store the ID in the session object
        Session["aStaff"] = aStaff;
        //redirect to viewerPage
        Response.Redirect("StaffViewer.aspx");
    }
}
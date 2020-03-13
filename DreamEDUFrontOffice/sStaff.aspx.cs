using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using DreamEDUClasses;

public partial class sStaff : System.Web.UI.Page
{
    

    protected void Page_Load(object sender, EventArgs e)
    {

    }

    protected void CheckBox1_CheckedChanged(object sender, EventArgs e)
    {

    }

    protected void Button1_Click1(object sender, EventArgs e)
    {
        //create a new instance of class
        clsStaff aStaff = new clsStaff();
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
        aStaff.sJoinD = Convert.ToDateTime(sJoiningDate.Text);
        //store the ID in the session object
        Session["aStaff"] = aStaff;
        //redirect to viewerPage
        Response.Redirect("StaffViewer.aspx");
    }


    protected void btnFind_Click(object sender, EventArgs e)
    {
        //create a new instance of class
        clsStaff aStaff = new clsStaff();
        //variable to store the primary key
        Int32 vsID;
        //variable to store the result of the find operation
        Boolean Found = false;
        //get the primary key entered by the user
        vsID = Convert.ToInt32(sID.Text);
        //find the record
        Found = aStaff.Find(vsID);
        //if Found
        if (Found == true)
        {
            //dispay the values of the staff in the form
            sID.Text = aStaff.sID.ToString();
            sName.Text = aStaff.sName;
            sAddress.Text = aStaff.sAddress;
            sJoiningDate.Text = aStaff.sJoinD.ToString();
            Yes.Text = aStaff.sTutorOrNot.ToString();
            sPhone.Text = aStaff.sPhone;
        }
    }

}
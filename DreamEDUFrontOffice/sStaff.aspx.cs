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


    protected void Button1_Click1(object sender, EventArgs e)
    {
        //create a new instance of class
        clsStaff aStaff = new clsStaff();
        //capture the staffId
        string sID = txtsID.Text;
        //capture the staff Name
        string sName = txtsName.Text;
        //capture the staff Address
        string sAddress = txtsAddress.Text;
        //capture whetherTutorOrNot
        Boolean sTutorOrNot = (chkYes.Checked);
        //capture staffPhNo
        string sPhone = txtsPhone.Text;
        //capture staff joining date
        string sJoinD = txtsJoiningDate.Text;
        //validate the data
        string Error =  aStaff.Valid(sName, sAddress, sPhone, sJoinD);
        if (Error == "")
        {
            //capture the name
            aStaff.sName = sName;
            //capture the Address
            aStaff.sAddress = sAddress;
            //capture the Phone number
            aStaff.sPhone = sPhone;
            //capture the Joining date
            aStaff.sJoinD = Convert.ToDateTime(txtsJoiningDate);

            //store the ID in the session object
            Session["aStaff"] = aStaff;
            //redirect to viewerPage
            Response.Write("StaffViewer.aspx");
        }
        else
        {
            //display the error message
            lblError.Text = Error;
        }
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
            vsID = Convert.ToInt32(txtsID.Text);
            //find the record
            Found = aStaff.Find(vsID);
            //if Found
            if (Found == true)
            {
                //dispay the values of the staff in the form
                txtsID.Text = aStaff.sID.ToString();
                txtsName.Text = aStaff.sName;
                txtsAddress.Text = aStaff.sAddress;
                txtsJoiningDate.Text = aStaff.sJoinD.ToString();
                chkYes.Text = aStaff.sTutorOrNot.ToString();
                txtsPhone.Text = aStaff.sPhone;
            }
    }

}

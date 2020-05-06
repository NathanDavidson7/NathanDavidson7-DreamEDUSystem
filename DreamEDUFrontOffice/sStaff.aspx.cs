using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using DreamEDUClasses;


public partial class sStaff : System.Web.UI.Page
{
    //variable to store the primary key with page level scope
    Int32 sId;

    protected void Page_Load(object sender, EventArgs e)
    {
        //get the numbre of the staff to be processed
        sId = Convert.ToInt32(Session["sStaff.aspx"]);
        if(IsPostBack == false)
        {
            //if this is not a new record
            if(sId != -1)
            {
                //display the current data for the record
                DisplayStaff();
            }
        }
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
            //capture the sID
            aStaff.sID = sId;
            //capture the name
            aStaff.sName = sName;
            //capture the Address
            aStaff.sAddress = sAddress;
            //capture the Phone number
            aStaff.sPhone = sPhone;
            //capture the Joining date
            aStaff.sJoiningDate = Convert.ToDateTime(txtsJoiningDate);
            //create the new instance of the staff collection
            clsStaffCollection StaffList = new clsStaffCollection();
            
            //if this is a new record i.e. sId = -1 then add the data
            if(sId == -1)
            {
                //set the ThisStaff property
                StaffList.ThisStaff = aStaff;
                //add the new record 
                StaffList.Add();
            }
            //otherwise it must be an update
            else
            {
                //find the record to update 
                StaffList.ThisStaff = aStaff;
                //add the new record
                StaffList.Add();
            }
            //redirect back to the list page
            Response.Redirect("StaffList.aspx");
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
                txtsJoiningDate.Text = aStaff.sJoiningDate.ToString();
                chkYes.Text = aStaff.sTutorOrNot.ToString();
                txtsPhone.Text = aStaff.sPhone;
            }
    }

    void DisplayStaff()
    {
        //create an instance of the staff book 
        clsStaffCollection StaffBook = new clsStaffCollection();
        //find the record to update
        StaffBook.ThisStaff.Find(sId);
        //display the data for this record
        txtsID.Text = StaffBook.ThisStaff.sID.ToString();
        txtsName.Text = StaffBook.ThisStaff.sName;
        txtsPhone.Text = StaffBook.ThisStaff.sPhone;
        txtsAddress.Text = StaffBook.ThisStaff.sAddress;
        txtsJoiningDate.Text = StaffBook.ThisStaff.sJoiningDate.ToString();
        chkYes.Checked = StaffBook.ThisStaff.sTutorOrNot;
    }

}

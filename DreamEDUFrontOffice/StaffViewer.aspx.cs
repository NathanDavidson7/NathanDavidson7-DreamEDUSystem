﻿using System;
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
        //create a new instance of a classStaff
        clsStaff aStaff = new clsStaff();
        //get the data from the session object
        aStaff = (clsStaff)Session["aStaff"];
        //displsay the staffID for this entry
        Response.Write(aStaff.sID);
        Response.Write("<br>");
        //display the staffName
        Response.Write(aStaff.sName);
        Response.Write("<br>");
        //display the staffAddress
        Response.Write(aStaff.sAddress);
        Response.Write("<br>");
        //display the stafftutorOrNot
        Response.Write(aStaff.sTutorOrNot);
        Response.Write("<br>");
        //display the staffPhNo
        Response.Write(aStaff.sPhone);
        Response.Write("<br>");
        //display the staffJoiningDate
        Response.Write(aStaff.sJoinD);
        Response.Write("<br>");

    }
}
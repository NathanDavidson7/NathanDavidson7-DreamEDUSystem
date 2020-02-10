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

    protected void btnOK_Click(object sender, EventArgs e)
    {
        
    }

    protected void TextBox1_TextChanged(object sender, EventArgs e)
    {

    }

    protected void OK_Click(object sender, EventArgs e)
    {
        //create a new instance of a class
        clsStaff aStaff = new clsStaff();
        //capture the staffID
        aStaff.sID = Convert.ToInt32(txtsID.Text);
        //store the staffId in the session object
        Session["aStaff"] = aStaff;
        //redirect the viewer page
        Response.Redirect("StaffViewer.aspx");
    }

    protected void Button1_Click(object sender, EventArgs e)
    {

    }
}
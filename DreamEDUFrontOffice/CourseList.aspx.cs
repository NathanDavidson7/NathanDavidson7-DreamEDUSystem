using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class CourseList : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {

    }

    protected void btnAdd_Click(object sender, EventArgs e)
    {
        //store -1 into the session object to indicate this is a new record
        Session["IDno"] = -1;
        //redirect to the data entry page
        Response.Redirect("ACourse.aspx");
    }

    protected void btnDelete_Click(object sender, EventArgs e)
    {
        //var to store the primary key value of the record to be deleted
        Int32 IDno;
        //if a record has been selected from the list
        if (lstCourseList.SelectedIndex != -1)
        {
            //get the primary key value of the record to delete
            IDno = Convert.ToInt32(lstCourseList.SelectedValue);
            //store the data in the session object
            Session["IDno"] = IDno;
            //redirect to the delete page
            Response.Redirect("DeleteCourse.aspx");
        }
        else // if no record has been selected
        {
            //display an error
            lblError.Text = "Please select a record to delete from the list";
        }
    }
}
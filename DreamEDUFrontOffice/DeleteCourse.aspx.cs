using DreamEDUClasses;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class DeleteCourse : System.Web.UI.Page
{
    //var to store the primary key value of the record to be deleted
    Int32 IDno;
    //event handler for the load event
    protected void Page_Load(object sender, EventArgs e)
    {
        //gets the number of the course to be deleted from the session object
        IDno = Convert.ToInt32(Session["IDno"]);
    }

    protected void btnYes_Click(object sender, EventArgs e)
    {
        //create a new instance of the courses
        clsCourseCollection CourseBook = new clsCourseCollection();
        //find the record to delete
        CourseBook.ThisCourse.Find(IDno);
        //delete the record
        CourseBook.Delete();
        //redirect back to the main page
        Response.Redirect("CourseList.aspx");
    }
}
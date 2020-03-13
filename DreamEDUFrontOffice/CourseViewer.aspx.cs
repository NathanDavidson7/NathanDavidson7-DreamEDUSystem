//using DreamEDU_Testing;
using DreamEDUClasses;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class CourseViewer : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        //create a new instance of clsCourses
        clsCourses aCourse = new clsCourses();
        //get the data from the session object
        aCourse = (clsCourses)Session["aCourse"];
        //display the ID for this entry
        Response.Write(aCourse.IDno);
        //display the Title for this entry
        Response.Write(aCourse.Title);
        //display the Category for this entry
        Response.Write(aCourse.Category);
        //display the Tutor for this entry
        Response.Write(aCourse.Tutor);
        //display the LiveDate for this entry
        Response.Write(aCourse.LiveDate);
        //display the Available for this entry
        Response.Write(aCourse.Available);
        //display the Price for this entry
        Response.Write(aCourse.Price);

    }
}
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class _Default : System.Web.UI.Page
{
    //this function handles the load event for the page
    protected void Page_Load(object sender, EventArgs e)
    {
        //if this is the first time the page is displayed
        if (IsPostBack == false)
        {
            //update the list box
           DisplayCourses();
        }
    }

    void DisplayCourses()
    {
        //create an instance of the collection
        DreamEDUClasses.clsCourseCollection Courses = new DreamEDUClasses.clsCourseCollection();
        //set the data source to the list of courses in the collection
        lstCourses.DataSource = Courses.CourseList;
        //set the name of the primary key
        lstCourses.DataValueField = "IDno";
        //set the data field to display
        lstCourses.DataTextField = "Title";
        //bind the data to the list
        lstCourses.DataBind();
    }

    protected void lstCourses_SelectedIndexChanged(object sender, EventArgs e)
    {

    }
}

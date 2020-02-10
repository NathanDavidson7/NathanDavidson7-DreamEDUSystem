//using DreamEDU_Testing;
using DreamEDUClasses;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class ACourse : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {

    }

    protected void RadioButton1_CheckedChanged(object sender, EventArgs e)
    {

    }

    protected void Button1_Click(object sender, EventArgs e)
    {
        //create a new instance of clsCourses
        clsCourses aCourse = new clsCourses();
        //capture the CourseID
        aCourse.IDno =Convert.ToInt32( txtIDCourse.Text);
        //capture the CourseTitle
        aCourse.Title = txtTitleCourse.Text;
        //capture the  courseCategory
        aCourse.Category = txtCategoryCourse.Text;
        //capture the  courseTutor
        aCourse.Tutor = txtTutorCourse.Text;
        //capture the courseLiveDate
        aCourse.LiveDate = Convert.ToDateTime(txtLiveDateCourse.Text);
        //capture the availableCourse
        aCourse.Available = Available.Checked;
        //capture the coursePrice
        aCourse.Price = Convert.ToDecimal(txtpriceCourse.Text);
        //store the ID in the session object
        Session["aCourse"] = aCourse;
        //redirect to the viewer page
        Response.Redirect("CourseViewer.aspx");
    }

    protected void TextBox2_TextChanged(object sender, EventArgs e)
    {

    }
}
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
        aCourse.IDno =Convert.ToInt32( txtIDno.Text);
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

    protected void Find_Click(object sender, EventArgs e)
    {
        //create a new instance of clsCourses
        clsCourses aCourse = new clsCourses();
        //variable to store the primary key
        Int32 IDno;
        //variable to store the result of the find operation
        Boolean Found=false;
        //get the primary key entered by the user
        IDno =Convert.ToInt32( txtIDno.Text);
        //find the record
        Found = aCourse.Find(IDno);
        //if found
        if (Found == true)
        {
            //display the values of the properties in the form
            //txtIDno.Text = aCourse.IDno;
            txtTitleCourse.Text = aCourse.Title;
            txtCategoryCourse.Text = aCourse.Category;
            txtTutorCourse.Text = aCourse.Tutor;
            txtLiveDateCourse.Text = aCourse.LiveDate.ToString();
            Available.Text = aCourse.Available.ToString();
            txtpriceCourse.Text = aCourse.Price.ToString();

        }
    }

    protected void TextBox2_TextChanged(object sender, EventArgs e)
    {

    }

    protected void txtIDno_TextChanged(object sender, EventArgs e)
    {

    }
}
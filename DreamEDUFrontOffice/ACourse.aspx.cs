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
    public object chkAvailable { get; private set; }

    protected void Page_Load(object sender, EventArgs e)
    {

    }

    protected void RadioButton1_CheckedChanged(object sender, EventArgs e)
    {

    }

    protected void Button1_Click(object sender, EventArgs e)
    {
        lblError.Text = "";
        //create a new instance of clsCourses
        clsCourses aCourse = new clsCourses();
        //capture the CourseTitle
        string Title = txtTitleCourse.Text;
        //capture the  courseCategory
        string Category = txtCategoryCourse.Text;
        //capture the  courseTutor
        string Tutor = txtTutorCourse.Text;
        //capture the courseLiveDate
        string LiveDate = txtLiveDateCourse.Text;
        //capture the coursePrice
         string Price = txtpriceCourse.Text;
        //variable to store any error messages
        string Error = "";
        //validate the data
        Error = aCourse.Valid(Title, Category, Tutor, LiveDate, Price);
        if (Error == "")
        {
            //capture the Title
            aCourse.Title = Title;
            //capture the Category
            aCourse.Category = Category;
            //capture the Tutor
            aCourse.Tutor = Tutor;
            //capture the LiveDate
            aCourse.LiveDate = Convert.ToDateTime(LiveDate);
            //capture the Price
            aCourse.Price = Convert.ToDecimal(Price);
            //capture Available
            aCourse.Available = Available.Checked;
            //create a new instance of the address collection
            clsCourseCollection courseList = new clsCourseCollection();
            //set the ThisCourse property
            courseList.ThisCourse = aCourse;
            //add the new record
            courseList.Add();
            //redirect back to the listpage
            Response.Redirect("CourseList.aspx");
        }
        else
        {
            //display the error message
            lblError.Text = Error;
        }
        
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
            txtIDno.Text = aCourse.IDno.ToString();
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
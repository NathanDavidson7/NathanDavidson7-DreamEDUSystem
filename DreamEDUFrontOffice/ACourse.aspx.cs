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
    //variable to store the primary key with page level scope
    Int32 IDno;
    public object chkAvailable { get; private set; }

    protected void Page_Load(object sender, EventArgs e)
    {
        //get the number of the course to be processed
        IDno = Convert.ToInt32(Session["IDno"]);
        if (IsPostBack == false)
        {
            //if this is not a new record
            if (IDno != -1)
            {
                //display the current data for the record
                DisplayCourses();
            }
        }
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
            //capture the IDno
            aCourse.IDno = IDno;
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

            //if this is a new record i.e IDno = -1 then add the data
            if (IDno == -1)
            {
                //set the ThisCourse property
                courseList.ThisCourse = aCourse;
                //add the new record
                courseList.Add();
            }
            //otherwise it must be an update
            else
            {
                //find the record to update
                courseList.ThisCourse.Find(IDno);
                //set the ThisCourse property
                courseList.ThisCourse = aCourse;
                //update the record
                courseList.Update();
            }
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
            if (aCourse.LiveDate.Day < 10 & aCourse.LiveDate.Month < 10)
            {
                txtLiveDateCourse.Text = "0" + aCourse.LiveDate.Day + "/0" + aCourse.LiveDate.Month + "/" + aCourse.LiveDate.Year;
            }
            else if (aCourse.LiveDate.Day < 10)
            {
                txtLiveDateCourse.Text = "0" + aCourse.LiveDate.Day + "/" + aCourse.LiveDate.Month + "/" + aCourse.LiveDate.Year;
            }
            else if (aCourse.LiveDate.Month < 10)
            {
                txtLiveDateCourse.Text = aCourse.LiveDate.Day + "/0" + aCourse.LiveDate.Month + "/" + aCourse.LiveDate.Year;
            }
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

    void DisplayCourses()
    {
        //create and instance of the Courses
        clsCourseCollection Courses = new clsCourseCollection();
        //find the record to update
        Courses.ThisCourse.Find(IDno);
        //display the data for this record
        txtIDno.Text = Courses.ThisCourse.IDno.ToString();
        txtTitleCourse.Text = Courses.ThisCourse.Title;
        txtCategoryCourse.Text = Courses.ThisCourse.Category;
        txtTutorCourse.Text = Courses.ThisCourse.Tutor;
        if (Courses.ThisCourse.LiveDate.Day < 10 & Courses.ThisCourse.LiveDate.Month < 10 & Courses.ThisCourse.LiveDate.Year < 2)
        {
            txtLiveDateCourse.Text = "0" + Courses.ThisCourse.LiveDate.Day + "/0" + Courses.ThisCourse.LiveDate.Month + "/000" + Courses.ThisCourse.LiveDate.Year;
        }
        else if (Courses.ThisCourse.LiveDate.Day < 10 & Courses.ThisCourse.LiveDate.Month < 10)
        {
            txtLiveDateCourse.Text = "0" + Courses.ThisCourse.LiveDate.Day + "/0" + Courses.ThisCourse.LiveDate.Month + "/" + Courses.ThisCourse.LiveDate.Year;
        }
        else if (Courses.ThisCourse.LiveDate.Day < 10)
        {
            txtLiveDateCourse.Text = "0" + Courses.ThisCourse.LiveDate.Day + "/" + Courses.ThisCourse.LiveDate.Month + "/" + Courses.ThisCourse.LiveDate.Year;
        }
        else if (Courses.ThisCourse.LiveDate.Month < 10)
        {
            txtLiveDateCourse.Text = Courses.ThisCourse.LiveDate.Day + "/0" + Courses.ThisCourse.LiveDate.Month + "/" + Courses.ThisCourse.LiveDate.Year;
        }
        else if (Courses.ThisCourse.LiveDate.Year < 2)
        {
            txtLiveDateCourse.Text = Courses.ThisCourse.LiveDate.Day + "/0" + Courses.ThisCourse.LiveDate.Month + "/000" + Courses.ThisCourse.LiveDate.Year;
        }
        Available.Checked = Courses.ThisCourse.Available;
        txtpriceCourse.Text = Courses.ThisCourse.Price.ToString();

    }
}
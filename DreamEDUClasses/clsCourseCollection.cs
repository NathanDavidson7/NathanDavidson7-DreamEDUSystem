
using System;
using System.Collections.Generic;

namespace DreamEDUClasses
{
    public class clsCourseCollection
    {
        //constructor for the class
        public clsCourseCollection()
        {
            //var for the index
            Int32 Index = 0;
            //var to store the record count
            Int32 RecordCount = 0;
            //object for data connection
            clsDataConnection DB = new clsDataConnection();
            //execute the stroed procedure
            DB.Execute("Courses_SelectAll");
            //get the count of records
            RecordCount = DB.Count;
            //While there are records to process
            while (Index < RecordCount)
            {
                //create a blank address
                clsCourses aCourse = new clsCourses();
                //read in the fields from the current record
                aCourse.Available = Convert.ToBoolean(DB.DataTable.Rows[Index]["Available"]);
                aCourse.IDno = Convert.ToInt32(DB.DataTable.Rows[Index]["IDno"]);
                aCourse.Title = Convert.ToString(DB.DataTable.Rows[Index]["Title"]);
                aCourse.Category = Convert.ToString(DB.DataTable.Rows[Index]["Category"]);
                aCourse.Tutor = Convert.ToString(DB.DataTable.Rows[Index]["Tutor"]);
                aCourse.LiveDate = Convert.ToDateTime(DB.DataTable.Rows[Index]["LiveDate"]);
                aCourse.Price = Convert.ToDecimal(DB.DataTable.Rows[Index]["Price"]);
                //add the record to the private data member
                mCourseList.Add(aCourse);
                //point at the next record
                Index++;
            }

        }


        //private data member for the list
        List<clsCourses> mCourseList = new List<clsCourses>();
        //private data member thisCourse
        clsCourses mThisCourse = new clsCourses();
        //public property for the courses list
        public List<clsCourses> CourseList
        {
            get
            {
                //return the private data
                return mCourseList;
            }
            set
            {
                //Set the private data
                mCourseList = value;
            }
        }
        public int Count
        {
            get
            {
                //return the count of the list
                return mCourseList.Count;
            }
            set
            {
                //worry about this later
            }
         }
        //public property for ThisCourse
        public clsCourses ThisCourse
        {
            get
            {
                //return the private data
                return mThisCourse;
            }
            set
            {
                //set the private data
                mThisCourse = value;
            }
        }

        public int Add()
        {
            //adds a new recors to the database based on the values od mThisCourse
            //connect to the database
            clsDataConnection DB = new clsDataConnection();
            // set the parameters for the stored procedure
            DB.AddParameter("@Title", mThisCourse.Title);
            DB.AddParameter("@Category", mThisCourse.Category);
            DB.AddParameter("@Tutor", mThisCourse.Tutor);
            DB.AddParameter("@LiveDate", mThisCourse.LiveDate);
            DB.AddParameter("@Available", mThisCourse.Available);
            DB.AddParameter("@Price", mThisCourse.Price);
            //execute the query returning the primary key value
            return DB.Execute("sproc_Courses_Insert");
        }
    }
}
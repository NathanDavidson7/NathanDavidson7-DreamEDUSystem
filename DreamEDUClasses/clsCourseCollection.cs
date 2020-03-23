
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
        public clsCourses ThisCourse { get; set; }
    }
}
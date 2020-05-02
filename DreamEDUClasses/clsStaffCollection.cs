using System;
using System.Collections.Generic;

namespace DreamEDUClasses
{
    public class clsStaffCollection
    {
        //private data member for the list
        List<clsStaff> mStaffList = new List<clsStaff>();
        
        
        //constructor for the class
        public clsStaffCollection()
        {
            //var for the index
            Int32 Index = 0;
            //var to store the record count
            Int32 RecordCount = 0;
            //object for data connection
            clsDataConnection DB = new clsDataConnection();
            //execute the stored procedure
            DB.Execute("sproc_tblStaff_SelectAll");
            //get the count of records
            RecordCount = DB.Count;
            //while there are records to process
            while (Index < RecordCount)
            {
                //create blank address
                clsStaff aStaff = new clsStaff(); ;
                //read in the fields from the current record
                aStaff.sTutorOrNot = Convert.ToBoolean(DB.DataTable.Rows[Index]["sTutorOrNot"]);
                aStaff.sPhone = Convert.ToString(DB.DataTable.Rows[Index]["sPhone"]);
                aStaff.sName = Convert.ToString(DB.DataTable.Rows[Index]["sName"]);
                aStaff.sAddress = Convert.ToString(DB.DataTable.Rows[Index]["sAddress"]);
                aStaff.sJoinD = Convert.ToDateTime(DB.DataTable.Rows[Index]["sJoiningDate"]);
                aStaff.sID = Convert.ToInt32(DB.DataTable.Rows[Index]["sID"]);
                //addd the record to the private data member
                mStaffList.Add(aStaff);
                //point at the next record
                Index++;
            }
        }


        //public property for the staff list
        public List<clsStaff> StaffList
        {
            get
            {
                //return the private data
                return mStaffList;
            }
            set
            {
                //set the private data
                mStaffList = value;
            }
        }
        //public property for the staff list
        public int Count
        {
            get
            {
                //return the count of the list
                return mStaffList.Count;
            }
            set
            {
                //we shall worry about this later
            }
        }

        public clsStaff ThisStaff { get; set; }
    }
}
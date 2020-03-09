using System;

namespace DreamEDUClasses
{
    public class clsCourses
    {
        //Available private member variable
        private bool mAvailable;
        //Available public property
        public bool Available
        {
            get
            {
                return mAvailable;
            }
            set
            {
                mAvailable = value;
            }
        }
       

        //LiveDate private member variable
        private DateTime mLiveDate;
        //LiveDate public property
        public DateTime LiveDate
        {
            get
            {
                return mLiveDate;
            }
            set
            {
                mLiveDate = value;
            }
        }
        
        //addressNo private member variable
        private Int32 mIDno;
        //IDno public property
        public Int32 IDno
        {
            get
            {
                //this line of code sends data out of property
                return mIDno;
            }
            set
            {
                //this line of code allows data into the property
                mIDno = value;
            }
        }

        //Title private member variable
        private string mTitle;
        //Title public property
        public string Title
        {
            get
            {
                //return private data
                return mTitle;
            }
            set
            {
                //this line of code allows data into the property
                mTitle = value;
            }
        }

        //Category private member variable
        private string mCategory;
        //Category public property
        public string Category
        {
            get
            {
                //return private data
                return mCategory;
            }
            set
            {
                //this line of code allows data into the property
                mCategory = value;
            }
        }
        

        //Tutor private member variable
        private string mTutor;
        //Tutor public property
        public string Tutor
        {
            get
            {
                //return private data
                return mTutor;
            }
            set
            {
                //this line of code allows data into the property
                mTutor = value;
            }
        }

        //Price private member variable
        private Decimal mPrice;
        //Price public property
        public Decimal Price
        {
            get
            {
                return mPrice;
            }
            set
            {
                mPrice = value;
            }
        }

        

        public bool Find(int IDno)
        {
            //create an instance if the data connection
            clsDataConnection DB = new clsDataConnection();
            //add the parameter for the IDno to search for
            DB.AddParameter("@IDno", IDno);
            //execute the stroed procedure
            DB.Execute("sproc_Courses_FilterByIDno");
            //if one record is found (there should be either one or zero!)
            if (DB.Count == 1)
            {
                //copy the data from the database to the private data members
                mIDno = Convert.ToInt32(DB.DataTable.Rows[0]["IDno"]);
                mTitle = Convert.ToString(DB.DataTable.Rows[0]["Title"]);
                mTutor = Convert.ToString(DB.DataTable.Rows[0]["Tutor"]);
                mCategory = Convert.ToString(DB.DataTable.Rows[0]["Category"]);
                mLiveDate = Convert.ToDateTime(DB.DataTable.Rows[0]["LiveDate"]);
                mAvailable = Convert.ToBoolean(DB.DataTable.Rows[0]["Available"]);
                mPrice = Convert.ToDecimal(DB.DataTable.Rows[0]["Price"]);
                //return that everything worked OK
                return true;
            }
            //if no record was found
            else
            {
                //return false indicating a problem
                return false;
            }
            
        }

        //function for the public validation method
        public string Valid(string Title,
                            string Category,
                            string Tutor,
                            string LiveDate,
                            string Price)
            ///this function accepts 5 parameters for vaidation
            ///the function returns a string containing any error message
            ///if no errors found then a blank string is returned
        {
            //create a string variable to store the error
            String Error = "";
            //if the Title is blank
            if (Title.Length == 0)
            {
                //record the error
                Error = Error + "The Title may not be blank : ";
            }
            //return any error messages
            return Error;
        }

        
    }
}
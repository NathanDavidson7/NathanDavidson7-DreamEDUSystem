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
            //create a temporary variable to store date values
            DateTime DateTemp;
            //create a temporary variable to store decimal values
            Decimal DecimalTemp;
            //if the Title is blank
            if (Title.Length == 0)
            {
                //record the error
                Error = Error + "The Title may not be blank : ";
            }
            //if the Title is greater than 20 characters
            if (Title.Length > 20)
            {
                //record the error
                Error = Error + "The Title must be less 20 characters or less";
            }
            //if the Category is blank
            if (Category.Length == 0)
            {
                //record the error
                Error = Error + "The Category may not be blank : ";
            }
            //if the Category is greater than 20 characters
            if (Category.Length > 20)
            {
                //record the error
                Error = Error + "The Category must be less 20 characters or less";
            }
            //if the Tutor is blank
            if (Tutor.Length == 0)
            {
                //record the error
                Error = Error + "The Tutor may not be blank : ";
            }
            //if the Tutor is greater than 25 characters
            if (Tutor.Length > 25)
            {
                //record the error
                Error = Error + "The Tutor must be less 20 characters or less";
            }
            try
            {
                //copy the dateAdded value to the DateTemp variable
                DateTemp = Convert.ToDateTime(LiveDate);
                if (DateTemp < DateTime.Now.Date)
                {
                    //record the error 
                    Error = Error + "The date cannot be in the past :";
                }
                //check to see if the date is greater than today's date
                if (DateTemp > DateTime.Now.Date)
                {
                    //record the error
                    Error = Error + "The date cannot be in the future :";
                }
            }
            catch
            {
                //record the error
                Error = Error + "The date was not a valid date : ";
            }
            //copy the Price value to the DecimalTemp variable
            DecimalTemp = Convert.ToDecimal(Price);
            // if the Price is less than zero
            if (DecimalTemp < 00.00m)
            {
                //record the error
                Error = Error + "The price cannot be a negative value : ";
            }
            // if the price is more than 10thousand
            if (DecimalTemp > 10000.00m)
            {
                //record the error
                Error = Error + "The price has exceeded the maximum value : ";
            }
            //return any error messages
            return Error;
        }

        
    }
}
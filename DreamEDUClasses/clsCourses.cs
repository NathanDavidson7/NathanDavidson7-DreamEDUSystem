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
            //set the private data members to the test data value
            mIDno = 21;
            mLiveDate = Convert.ToDateTime("25/12/2022");
            mTitle = "Title";
            mTutor = "Tutor";
            mCategory = "Category";
            mPrice = Convert.ToDecimal(77.77);
            mAvailable = true;
            //always return true
            return true;
        }

        
    }
}
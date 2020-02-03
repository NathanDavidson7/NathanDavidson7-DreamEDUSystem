using System;

namespace DreamEDU_Testing
{
    public class clsCourses
    {
        internal decimal price;

        public bool Active { get; internal set; }
        public DateTime LiveDate { get; internal set; }
        public int IDno { get; internal set; }
        public string Title { get; internal set; }
        public string Category { get; internal set; }
        public string Tutor { get; internal set; }
    }
}
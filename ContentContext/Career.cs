using System.Collections.Generic;

namespace POO.ContentContext
{
    public class Career : Content
    {
        public Career(string title, string url) : base(title, url)
        {
            Items = new List<CareerItem>();
        }

        public int Courses { get; set; }
        public IList<CareerItem> Items { get; set; }
        public int TotalCourses => Items.Count; // Expression Body
    }
}
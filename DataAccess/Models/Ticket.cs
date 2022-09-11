using System;
using System.Collections.Generic;
using System.Text;

namespace DataAccess.Models
{
   public class Ticket
    {
        public long TicketID { get; set; }
        public string Account_Code { get; set; }
        public string Title { get; set; }
        public string Description { get; set; }
        public string FeedbackOfStudent { get; set; }
        public string FeedbackOfTeacher { get; set; }
        public int Type { get; set; }
        public int Status { get; set; }
        public int CourseID { get; set; }
        public string CourseName { get; set; }
        public int ClassID { get; set; }
        public string ClassName { get; set; }
        public string CreatedBy { get; set; }
        public DateTime CreatedTime { get; set; }
    }
}

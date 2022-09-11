using System;
using System.Collections.Generic;
using System.Text;

namespace DataAccess.Models
{
   public class Commob
    {
    }

    public class Combo
    {
        public int ID { get; set; }
        public string Name { get; set; }
    }

    public class ComboType
    {
        public int Type { get; set; }
        public string TypeName { get; set; }
    }

    public class ComboCourse
    {
        public long STT { get; set; }
        public int ID { get; set; }
        public int ComboID { get; set; }
        public int CourseID { get; set; }
        public string CourseName { get; set; }
        public string CourseCode { get; set; }
        public int Type { get; set; }
        public long Price { get; set; }
        public long TotalPrice { get; set; }
    }

    public class CourseList
    {
        public int CourseID { get; set; }
        public string CourseName { get; set; }
        public string CourseCode { get; set; }
        public int StartPoint { get; set; }
        public int LevelId { get; set; }
        public int NextCourseID { get; set; }
        public string NextCourseName { get; set; }
        public long Price { get; set; }
    }

    public class StudentCourse
    {
        public long StudentID { get; set; }
        public string StudentName { get; set; }
        public int CourseID { get; set; }
        public int Type { get; set; }
        public string CourseName { get; set; }
    }
    public class StudentComboCourse
    {
        public long StudentID { get; set; }
        public int ComboID { get; set; }
        public string Name { get; set; }
        public int Type { get; set; }
    }
}

using System;
using System.Collections.Generic;
using System.Text;

namespace DataAccess.Models
{
    public class Class
    {
        public int ClassID { get; set; }
        public string ClassName { get; set; }
        public string ClassCode { get; set; }
        public int CourseID { get; set; }
        public DateTime StartTime { get; set; }
        public DateTime EndTime { get; set; }
        public int CountStudentMax { get; set; }
        public int CountStudentMin { get; set; }
        public int MerchantID { get; set; }
        public string MerchantName { get; set; }
        public DateTime CreatedTime { get; set; }
        public string CreatedBy { get; set; }
        public int LevelOfClass { get; set; }
        public string LevelOfClassName { get; set; }
        public int TimeSlot { get; set; }
        public string TimeSlotText { get; set; }
        public int DateOfLearn { get; set; }
        public string DateOfLearnText { get; set; }
        public int Status { get; set; }
        public int CountStudent { get; set; }
        public string StrScheduleDays { get; set; }
    }

    public class Lesson
    {
        public int LessonID { get; set; }
        public string LessonName { get; set; }
        public int ClassID { get; set; }
        public string ClassName { get; set; }
        public int CourseID { get; set; }
        public string CourseName { get; set; }
        public int TeacherID { get; set; }
        public string TeacherName { get; set; }
        public DateTime DateOfLearn { get; set; }
        public int Status { get; set; }
        public int Participate { get; set; }
        public int SubTeacherID { get; set; }
        public string SubTeacherName { get; set; }
    }

    public class LessonStudent
    {
        public int ID { get; set; }
        public int LessonID { get; set; }
        public string LessonName { get; set; }
        public long StudentID { get; set; }
        public string StudentName { get; set; }
        public string FeedbackOfStu { get; set; }

        public string CommentOfTeacher { get; set; }
        public int Point { get; set; }
        public bool Attendance { get; set; }
    }

    public class StudentOfClass
    {
        public int ClassID { get; set; }
        public string ClassName { get; set; }
        public long StudentID { get; set; }
        public string StudentName { get; set; }
        public int CourseID { get; set; }
        public string CourseName { get; set; }
        public int Status { get; set; }
        public int CountParticipate { get; set; }
    }

    public class ScheduleDayClass
    {
        public int ClassID { get; set; }
        public int Day { get; set; }
        public string Name { get; set; }
    }

    public class TeacherOfClass
    {
        public int ID { get; set; }
        public int TeacherId { get; set; }
        public string FullName { get; set; }
        public int Status { get; set; }
        public int ClassId { get; set; }
        public string ClassName { get; set; }
    }
}

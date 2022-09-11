using System;
using System.Collections.Generic;
using System.Text;

namespace DataAccess.Models
{
    public class Teacher
    {
        public int TeacherID { get; set; }
        public string FullName { get; set; }
        public string Email { get; set; }
        public string PhoneNumber { get; set; }
        public string CmndNum { get; set; }
        public DateTime DateBy { get; set; }
        public string IssuedBy { get; set; }
        public string Cmnd_Path { get; set; }
        public string Cmnd_Before { get; set; }
        public string Cmnd_After { get; set; }
        public string Certificate { get; set; }
        public int MerchantID { get; set; }
        public string MerchantName { get; set; }
        public int Status { get; set; }
        public string ImagePath { get; set; }
        public string StrMerchantIDs { get; set; }
        public string StrLevelOfClass { get; set; }
        public string StrScheduleOfTeacher { get; set; }
        public string StrScheduleDay { get; set; }
        //public int ScheduleDay { get; set; }

    }

    public class MerchantOfTeacher
    {
        public int TeacherId { get; set; }
        public int MerchantID { get; set; }
        public string MerchantName { get; set; }
        public string Description { get; set; }
        public int Status { get; set; }
        public string Address { get; set; }
        public string PhoneNumber { get; set; }
    }

    public class ScheduleOfTeacher
    {
        public int TeacherId { get; set; }
        public int ScheduleId { get; set; }
        public TimeSpan StartTime { get; set; }
        public TimeSpan EndTime { get; set; }
        public bool Status { get; set; }
    }

    public class LevelOfTeacher
    {
        public int TeacherId { get; set; }
        public int Id { get; set; }
        public string Code { get; set; }
        public string Name { get; set; }
        public bool? Status { get; set; }
    }

    public class ScheduleDayOfTeacher
    {
        public int TeacherID { get; set; }
        public int Day { get; set; }
        public string Name { get; set; }
    }

    public class DayOfWeekend
    {
        public int ID { get; set; }
        public string Name { get; set; }
    }

    public class ListClassOfTeacher
    {
        public int TeacherId { get; set; }
        public int ClassId { get; set; }
        public string ClassName { get; set; }
        public string ClassCode { get; set; }
        public int CourseID { get; set; }
        public string CourseName { get; set; }
        public DateTime StartTime { get; set; }
        public DateTime EndTime { get; set; }
        public int CountStudentMax { get; set; }
        public int CountStudentMin { get; set; }
        public int MerchantID { get; set; }
        public string MerchantName { get; set; }
        public DateTime CreatedTime { get; set; }
        public string CreatedBy { get; set; }
        public int LevelOfClass { get; set; }
        public string LevelName { get; set; }
        public int TimeSlot { get; set; }
        public TimeSpan FromTime { get; set; }
        public TimeSpan ToTime { get; set; }
        public string DateOfLearn { get; set; }
        public int Status { get; set; }
        public int CountStudent { get; set; }
    }

    public class TicketsOfStudent
    {
        public int TicketID { get; set; }
        public string Account_Code { get; set; }
        public string Title { get; set; }
        public string FeedbackOfStudent { get; set; }
        public string FeedbackOfTeacher { get; set; }
        public int Type { get; set; }
        public int Status { get; set; }
        public int CourseID { get; set; }
        public int ClassID { get; set; }
        public string ClassName { get; set; }
        public string CreatedBy { get; set; }
        public DateTime CreatedTime { get; set; }
    }
}

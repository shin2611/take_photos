using System;
using System.Collections.Generic;
using System.Data;
using Microsoft.Data.SqlClient;
using DataAccess.Interface;
using DataAccess.Models;
using Utils;

namespace DataAccess.Implement
{
    public class ClassDAOImpl : IClassDAO
    {
        #region CLASS
        public List<Class> ClassGetList(string keyword, string startTime, string endTime, int merchantId)
        {
            try
            {
                var pars = new SqlParameter[4];
                pars[0] = new SqlParameter("@Keyword", keyword);
                pars[1] = new SqlParameter("@StartTime", startTime);
                pars[2] = new SqlParameter("@EndTime", endTime);
                pars[3] = new SqlParameter("@MerchantID", merchantId);
                var list = new DBHelper(Config.ConnectionString.SQLConnCMS).GetListSP<Class>("SP_Class_GetList", pars);
                if (list == null || list.Count <= 0)
                    return new List<Class>();

                return list;
            }
            catch (Exception ex)
            {
                NLogLogger.LogInfo(ex.ToString());
                return new List<Class>();
            }
        }

        public int ClassInsertUpdate(Class cls)
        {
            try
            {
                var pars = new SqlParameter[13];
                pars[0] = new SqlParameter("@ClassID", cls.ClassID);
                pars[1] = new SqlParameter("@ClassName", cls.ClassName);
                pars[2] = new SqlParameter("@CourseID", cls.CourseID);
                pars[3] = new SqlParameter("@StartTime", cls.StartTime);
                pars[4] = new SqlParameter("@EndTime", cls.EndTime);
                pars[5] = new SqlParameter("@StrScheduleDays", cls.StrScheduleDays);
                pars[6] = new SqlParameter("@MerchantID", cls.MerchantID);
                pars[7] = new SqlParameter("@LevelOfClass", cls.LevelOfClass);
                pars[8] = new SqlParameter("@CountStudentMax", cls.CountStudentMax);
                pars[9] = new SqlParameter("@CountStudentMin", cls.CountStudentMin);
                pars[10] = new SqlParameter("@TimeSlot", cls.TimeSlot);
                pars[11] = new SqlParameter("@CreatedBy", cls.CreatedBy);
                pars[12] = new SqlParameter("@ResponseStatus", SqlDbType.Int) { Direction = ParameterDirection.Output };
                new DBHelper(Config.ConnectionString.SQLConnCMS).ExecuteNonQuerySP("SP_Class_InsertUpdate", pars);
                return Convert.ToInt32(pars[12].Value);
            }
            catch (Exception e)
            {
                NLogLogger.PublishException(e);
                return -99;
            }
        }

        public int DeleteClass(int Id)
        {
            try
            {
                var pars = new SqlParameter[2];
                pars[0] = new SqlParameter("@ClassID", Id);
                pars[1] = new SqlParameter("@ResponseStatus", SqlDbType.Int) { Direction = ParameterDirection.Output };
                new DBHelper(Config.ConnectionString.SQLConnCMS).ExecuteNonQuerySP("SP_Class_Delete", pars);
                return Convert.ToInt32(pars[1].Value);
            }
            catch (Exception e)
            {
                NLogLogger.PublishException(e);
                return -99;
            }
        }

        public Class GetClassInfo(int Id)
        {
            try
            {
                var pars = new SqlParameter[1];
                pars[0] = new SqlParameter("@ClassID", Id);
                var list = new DBHelper(Config.ConnectionString.SQLConnCMS).GetInstanceSP<Class>("SP_Class_GetInfo_ByID", pars);
                if (list == null)
                    return new Class();
                return list;
            }
            catch (Exception ex)
            {
                NLogLogger.LogInfo(ex.ToString());
                return new Class();
            }
        }
        public int UpdateStatusClass(int Id, int status)
        {
            try
            {
                var pars = new SqlParameter[3];
                pars[0] = new SqlParameter("@ClassID", Id);
                pars[1] = new SqlParameter("@Status", status);
                pars[2] = new SqlParameter("@ResponseStatus", SqlDbType.Int) { Direction = ParameterDirection.Output };
                new DBHelper(Config.ConnectionString.SQLConnCMS).ExecuteNonQuerySP("SP_Class_UpdateStatus", pars);
                return Convert.ToInt32(pars[2].Value);
            }
            catch (Exception e)
            {
                NLogLogger.PublishException(e);
                return -99;
            }
        }

        #endregion

        #region LESSON
        public Lesson GetLessonInfo(int Id)
        {
            try
            {
                var pars = new SqlParameter[1];
                pars[0] = new SqlParameter("@ID", Id);
                var list = new DBHelper(Config.ConnectionString.SQLConnCMS).GetInstanceSP<Lesson>("SP_LessonClass_GetInfo", pars);
                if (list == null)
                    return new Lesson();
                return list;
            }
            catch (Exception ex)
            {
                NLogLogger.LogInfo(ex.ToString());
                return new Lesson();
            }
        }

        public List<LessonStudent> GetLessonStudents(int Id)
        {
            try
            {
                var pars = new SqlParameter[1];
                pars[0] = new SqlParameter("@ID", Id);
                var list = new DBHelper(Config.ConnectionString.SQLConnCMS).GetListSP<LessonStudent>("SP_LessonStudent_GetInfo", pars);
                if (list == null || list.Count <= 0)
                    return new List<LessonStudent>();

                return list;
            }
            catch (Exception ex)
            {
                NLogLogger.LogInfo(ex.ToString());
                return new List<LessonStudent>();
            }
        }

        public List<Lesson> LessonGetList(int classId)
        {
            try
            {
                var pars = new SqlParameter[1];
                pars[0] = new SqlParameter("@ClassID", classId);
                var list = new DBHelper(Config.ConnectionString.SQLConnCMS).GetListSP<Lesson>("SP_LessonClass_GetList", pars);
                if (list == null || list.Count <= 0)
                    return new List<Lesson>();

                return list;
            }
            catch (Exception ex)
            {
                NLogLogger.LogInfo(ex.ToString());
                return new List<Lesson>();
            }
        }

        public int UpdateLesson(int lessId, string dateOfLearn, int subTeacherId)
        {
            try
            {
                var pars = new SqlParameter[4];
                pars[0] = new SqlParameter("@LessonID", lessId);
                pars[1] = new SqlParameter("@DateOfLearn", dateOfLearn);
                pars[2] = new SqlParameter("@SubTeacherID", subTeacherId);
                pars[3] = new SqlParameter("@ResponseStatus", SqlDbType.Int) { Direction = ParameterDirection.Output };
                new DBHelper(Config.ConnectionString.SQLConnCMS).ExecuteNonQuerySP("SP_LessonClass_Update", pars);
                return Convert.ToInt32(pars[3].Value);
            }
            catch (Exception e)
            {
                NLogLogger.PublishException(e);
                return -99;
            }
        }

        public int UpdatePoint(int lessId, long studentId, int point)
        {
            try
            {
                var pars = new SqlParameter[4];
                pars[0] = new SqlParameter("@LessonID", lessId);
                pars[1] = new SqlParameter("@StudentID", studentId);
                pars[2] = new SqlParameter("@Point", point);
                pars[3] = new SqlParameter("@ResponseStatus", SqlDbType.Int) { Direction = ParameterDirection.Output };
                new DBHelper(Config.ConnectionString.SQLConnCMS).ExecuteNonQuerySP("SP_LessonStudent_UpdatePoint", pars);
                return Convert.ToInt32(pars[3].Value);
            }
            catch (Exception e)
            {
                NLogLogger.PublishException(e);
                return -99;
            }
        }

        public int UpdateStatusLesson(int lessId, int status)
        {
            try
            {
                var pars = new SqlParameter[3];
                pars[0] = new SqlParameter("@LessonID", lessId);
                pars[1] = new SqlParameter("@Status", status);
                pars[2] = new SqlParameter("@ResponseStatus", SqlDbType.Int) { Direction = ParameterDirection.Output };
                new DBHelper(Config.ConnectionString.SQLConnCMS).ExecuteNonQuerySP("SP_LessonClass_UpdateStatus", pars);
                return Convert.ToInt32(pars[2].Value);
            }
            catch (Exception e)
            {
                NLogLogger.PublishException(e);
                return -99;
            }
        }

        public int StartLession(int lessId, int classId)
        {
            try
            {
                var pars = new SqlParameter[3];
                pars[0] = new SqlParameter("@LessionID", lessId);
                pars[1] = new SqlParameter("@ClassID", classId);
                pars[2] = new SqlParameter("@ResponseStatus", SqlDbType.Int) { Direction = ParameterDirection.Output };
                new DBHelper(Config.ConnectionString.SQLConnCMS).ExecuteNonQuerySP("SP_LessionClass_Start", pars);
                return Convert.ToInt32(pars[2].Value);
            }
            catch (Exception e)
            {
                NLogLogger.PublishException(e);
                return -99;
            }
        }
        public int EndLession(int lessId, int classId)
        {
            try
            {
                var pars = new SqlParameter[3];
                pars[0] = new SqlParameter("@LessionID", lessId);
                pars[1] = new SqlParameter("@ClassID", classId);
                pars[2] = new SqlParameter("@ResponseStatus", SqlDbType.Int) { Direction = ParameterDirection.Output };
                new DBHelper(Config.ConnectionString.SQLConnCMS).ExecuteNonQuerySP("SP_LessionClass_End", pars);
                return Convert.ToInt32(pars[2].Value);
            }
            catch (Exception e)
            {
                NLogLogger.PublishException(e);
                return -99;
            }
        }
        public int AttendanceStudent(int lessId, long studentId, bool atten)
        {
            try
            {
                var pars = new SqlParameter[4];
                pars[0] = new SqlParameter("@LessonID", lessId);
                pars[1] = new SqlParameter("@StudentID", studentId);
                pars[2] = new SqlParameter("@Attendance", atten);
                pars[3] = new SqlParameter("@ResponseStatus", SqlDbType.Int) { Direction = ParameterDirection.Output };
                new DBHelper(Config.ConnectionString.SQLConnCMS).ExecuteNonQuerySP("SP_LessonStudent_Attendance", pars);
                return Convert.ToInt32(pars[3].Value);
            }
            catch (Exception e)
            {
                NLogLogger.PublishException(e);
                return -99;
            }
        }

        public List<StudentOfClass> GetStudentOfClass(int classId)
        {
            try
            {
                var pars = new SqlParameter[1];
                pars[0] = new SqlParameter("@ClassID", classId);
                var list = new DBHelper(Config.ConnectionString.SQLConnCMS).GetListSP<StudentOfClass>("SP_StudentClass_GetList", pars);
                if (list == null || list.Count <= 0)
                    return new List<StudentOfClass>();

                return list;
            }
            catch (Exception ex)
            {
                NLogLogger.LogInfo(ex.ToString());
                return new List<StudentOfClass>();
            }
        }

        public int AddStudentClass(int classId, long studentId)
        {
            try
            {
                var pars = new SqlParameter[3];
                pars[0] = new SqlParameter("@ClassID", classId);
                pars[1] = new SqlParameter("@StudentID", studentId);
                pars[2] = new SqlParameter("@ResponseStatus", SqlDbType.Int) { Direction = ParameterDirection.Output };
                new DBHelper(Config.ConnectionString.SQLConnCMS).ExecuteNonQuerySP("SP_StudentClass_Insert", pars);
                return Convert.ToInt32(pars[2].Value);
            }
            catch (Exception e)
            {
                NLogLogger.PublishException(e);
                return -99;
            }
        }

        public List<ScheduleDayClass> GetScheduleDayClasses(int classId)
        {
            try
            {
                var pars = new SqlParameter[1];
                pars[0] = new SqlParameter("@ClassID", classId);
                var list = new DBHelper(Config.ConnectionString.SQLConnCMS).GetListSP<ScheduleDayClass>("SP_ClassScheduleDay_GetByID", pars);
                if (list == null || list.Count <= 0)
                    return new List<ScheduleDayClass>();

                return list;
            }
            catch (Exception ex)
            {
                NLogLogger.LogInfo(ex.ToString());
                return new List<ScheduleDayClass>();
            }
        }

        public LessonStudent GetLessonStudentInfo(int Id)
        {
            try
            {
                var pars = new SqlParameter[1];
                pars[0] = new SqlParameter("@ID", Id);
                var list = new DBHelper(Config.ConnectionString.SQLConnCMS).GetInstanceSP<LessonStudent>("SP_LessonStudent_GetDetail", pars);
                if (list == null)
                    return new LessonStudent();
                return list;
            }
            catch (Exception ex)
            {
                NLogLogger.LogInfo(ex.ToString());
                return new LessonStudent();
            }
        }

        public int UpdateLessonStudent(int lessId, long studentId, string feedback, int point)
        {
            try
            {
                var pars = new SqlParameter[5];
                pars[0] = new SqlParameter("@LessionID", lessId);
                pars[1] = new SqlParameter("@StudentID", studentId);
                pars[2] = new SqlParameter("@FeedBack", feedback);
                pars[3] = new SqlParameter("@Point", point);
                pars[4] = new SqlParameter("@ResponseStatus", SqlDbType.Int) { Direction = ParameterDirection.Output };
                new DBHelper(Config.ConnectionString.SQLConnCMS).ExecuteNonQuerySP("SP_LessonStudent_Detail_Update", pars);
                return Convert.ToInt32(pars[4].Value);
            }
            catch (Exception e)
            {
                NLogLogger.PublishException(e);
                return -99;
            }
        }

        public List<TeacherOfClass> GetTeacherOfClasses(int classId)
        {
            try
            {
                var pars = new SqlParameter[1];
                pars[0] = new SqlParameter("@ClassID", classId);
                var list = new DBHelper(Config.ConnectionString.SQLConnCMS).GetListSP<TeacherOfClass>("SP_TeacherClass_GetList", pars);
                if (list == null || list.Count <= 0)
                    return new List<TeacherOfClass>();

                return list;
            }
            catch (Exception ex)
            {
                NLogLogger.LogInfo(ex.ToString());
                return new List<TeacherOfClass>();
            }
        }

        public int TeacherOfClass_Insert(int classId, int teacherId)
        {
            try
            {
                var pars = new SqlParameter[3];
                pars[0] = new SqlParameter("@ClassID", classId);
                pars[1] = new SqlParameter("@TeacherID", teacherId);
                pars[2] = new SqlParameter("@ResponseStatus", SqlDbType.Int) { Direction = ParameterDirection.Output };
                new DBHelper(Config.ConnectionString.SQLConnCMS).ExecuteNonQuerySP("SP_TeacherClass_Insert", pars);
                return Convert.ToInt32(pars[2].Value);
            }
            catch (Exception e)
            {
                NLogLogger.PublishException(e);
                return -99;
            }
        }

        public int TeacherOfClass_Delete(int id)
        {
            try
            {
                var pars = new SqlParameter[2];
                pars[0] = new SqlParameter("@ID", id);
                pars[1] = new SqlParameter("@ResponseStatus", SqlDbType.Int) { Direction = ParameterDirection.Output };
                new DBHelper(Config.ConnectionString.SQLConnCMS).ExecuteNonQuerySP("SP_TeacherClass_Delete", pars);
                return Convert.ToInt32(pars[1].Value);
            }
            catch (Exception e)
            {
                NLogLogger.PublishException(e);
                return -99;
            }
        }
        #endregion
    }
}

using System;
using System.Collections.Generic;
using System.Data;
using Microsoft.Data.SqlClient;
using DataAccess.Interface;
using DataAccess.Models;
using Utils;

namespace DataAccess.Implement
{
    public class TeacherDAOImpl : ITeacherDAO
    {
        #region TEACHER
        public List<Teacher> TeacherGetList(string keyword, int status, int merchantId)
        {
            try
            {
                var pars = new SqlParameter[3];
                pars[0] = new SqlParameter("@Keyword", keyword);
                pars[1] = new SqlParameter("@Status", status);
                pars[2] = new SqlParameter("@MerchantID", merchantId);
                var list = new DBHelper(Config.ConnectionString.SQLConnCMS).GetListSP<Teacher>("SP_Teacher_GetList", pars);
                if (list == null || list.Count <= 0)
                    return new List<Teacher>();

                return list;
            }
            catch (Exception ex)
            {
                NLogLogger.LogInfo(ex.ToString());
                return new List<Teacher>();
            }
        }

        public Teacher GetTeacherInfoByID(int teacherId)
        {
            try
            {
                var pars = new SqlParameter[1];
                pars[0] = new SqlParameter("@TeacherID", teacherId);
                var list = new DBHelper(Config.ConnectionString.SQLConnCMS).GetInstanceSP<Teacher>("SP_Teacher_GetInfoByID", pars);
                if (list == null)
                    return new Teacher();
                return list;
            }
            catch (Exception ex)
            {
                NLogLogger.LogInfo(ex.ToString());
                return new Teacher();
            }
        }

        public int Delete_Teacher(int teacherId)
        {
            try
            {
                var pars = new SqlParameter[2];
                pars[0] = new SqlParameter("@TeacherID", teacherId);
                pars[1] = new SqlParameter("@ResponeStatus", SqlDbType.Int) { Direction = ParameterDirection.Output };
                new DBHelper(Config.ConnectionString.SQLConnCMS).ExecuteNonQuerySP("SP_Teacher_Delete", pars);
                return Convert.ToInt32(pars[1].Value);
            }
            catch (Exception e)
            {
                NLogLogger.PublishException(e);
                return -99;
            }
        }
        public int INUP_Teacher_CMS(Teacher teacher)
        {
            try
            {
                var pars = new SqlParameter[16];
                pars[0] = new SqlParameter("@TeacherID", teacher.TeacherID);
                pars[1] = new SqlParameter("@FullName", teacher.FullName);
                pars[2] = new SqlParameter("@Email", teacher.Email);
                pars[3] = new SqlParameter("@PhoneNumber", teacher.PhoneNumber);
                pars[4] = new SqlParameter("@CmndNum", teacher.CmndNum);
                pars[5] = new SqlParameter("@DateBy", teacher.DateBy);
                pars[6] = new SqlParameter("@IssuedBy", teacher.IssuedBy);
                pars[7] = new SqlParameter("@Cmnd_Path", teacher.Cmnd_Path);
                pars[8] = new SqlParameter("@Certificate", teacher.Certificate);
                pars[9] = new SqlParameter("@StrMerchantID", teacher.StrMerchantIDs);
                pars[10] = new SqlParameter("@StrScheduleID", teacher.StrScheduleOfTeacher);
                pars[11] = new SqlParameter("@StrLevelOfClass", teacher.StrLevelOfClass);
                pars[12] = new SqlParameter("@Status", teacher.Status);
                pars[13] = new SqlParameter("@ImagePath", teacher.ImagePath);
                pars[14] = new SqlParameter("@StrScheduleDay", teacher.StrScheduleDay);
                pars[15] = new SqlParameter("@ResponseStatus", SqlDbType.Int) { Direction = ParameterDirection.Output };
                new DBHelper(Config.ConnectionString.SQLConnCMS).ExecuteNonQuerySP("SP_Teacher_InsertUpdate", pars);
                return Convert.ToInt32(pars[15].Value);
            }
            catch (Exception e)
            {
                NLogLogger.PublishException(e);
                return -99;
            }
        }
        public int UpdateTeacherStatus(int teacherId, int status)
        {
            try
            {
                var pars = new SqlParameter[3];
                pars[0] = new SqlParameter("@TeacherID", teacherId);
                pars[1] = new SqlParameter("@Status", status);
                pars[2] = new SqlParameter("@ResponseStatus", SqlDbType.Int) { Direction = ParameterDirection.Output };
                new DBHelper(Config.ConnectionString.SQLConnCMS).ExecuteNonQuerySP("SP_Teacher_UpdateStatus", pars);
                return Convert.ToInt32(pars[2].Value);
            }
            catch (Exception e)
            {
                NLogLogger.PublishException(e);
                return -99;
            }
        }
        public int ConfirmTicket(int ticketId)
        {
            try
            {
                var pars = new SqlParameter[2];
                pars[0] = new SqlParameter("@ID", ticketId);
                pars[1] = new SqlParameter("@ResponseStatus", SqlDbType.Int) { Direction = ParameterDirection.Output };
                new DBHelper(Config.ConnectionString.SQLConnCMS).ExecuteNonQuerySP("SP_Tickets_UpdateStatus", pars);
                return Convert.ToInt32(pars[1].Value);
            }
            catch (Exception e)
            {
                NLogLogger.PublishException(e);
                return -99;
            }
        }
        public int TeacherFeedback(int ticketId, string feedbackOfTeacher)
        {
            try
            {
                var pars = new SqlParameter[3];
                pars[0] = new SqlParameter("@TicketID", ticketId);
                pars[1] = new SqlParameter("@FeedbackTeacher", feedbackOfTeacher);
                pars[2] = new SqlParameter("@ResponseStatus", SqlDbType.Int) { Direction = ParameterDirection.Output };
                new DBHelper(Config.ConnectionString.SQLConnCMS).ExecuteNonQuerySP("SP_Ticket_Teacher_Update", pars);
                return Convert.ToInt32(pars[2].Value);
            }
            catch (Exception e)
            {
                NLogLogger.PublishException(e);
                return -99;
            }
        }
        public List<MerchantOfTeacher> GetMerchantByTeacherID(int teacherId)
        {
            try
            {
                var pars = new SqlParameter[1];
                pars[0] = new SqlParameter("@TeacherID", teacherId);
                var list = new DBHelper(Config.ConnectionString.SQLConnCMS).GetListSP<MerchantOfTeacher>("SP_Teacher_GetListMerchant_ByID", pars);
                if (list == null || list.Count <= 0)
                    return new List<MerchantOfTeacher>();

                return list;
            }
            catch (Exception ex)
            {
                NLogLogger.LogInfo(ex.ToString());
                return new List<MerchantOfTeacher>();
            }
        }

        public List<ScheduleOfTeacher> GetScheduleByTeacherID(int teacherId)
        {
            try
            {
                var pars = new SqlParameter[1];
                pars[0] = new SqlParameter("@TeacherID", teacherId);
                var list = new DBHelper(Config.ConnectionString.SQLConnCMS).GetListSP<ScheduleOfTeacher>("SP_Teacher_GetSchedules_ByID", pars);
                if (list == null || list.Count <= 0)
                    return new List<ScheduleOfTeacher>();

                return list;
            }
            catch (Exception ex)
            {
                NLogLogger.LogInfo(ex.ToString());
                return new List<ScheduleOfTeacher>();
            }
        }

        public List<LevelOfTeacher> GetLevelByTeacherID(int teacherId)
        {
            try
            {
                var pars = new SqlParameter[1];
                pars[0] = new SqlParameter("@TeacherID", teacherId);
                var list = new DBHelper(Config.ConnectionString.SQLConnCMS).GetListSP<LevelOfTeacher>("SP_Teacher_GetLevelOfClass_ByID", pars);
                if (list == null || list.Count <= 0)
                    return new List<LevelOfTeacher>();

                return list;
            }
            catch (Exception ex)
            {
                NLogLogger.LogInfo(ex.ToString());
                return new List<LevelOfTeacher>();
            }
        }

        public List<ScheduleDayOfTeacher> GetScheduleDayByTeacherID(int teacherId)
        {
            try
            {
                var pars = new SqlParameter[1];
                pars[0] = new SqlParameter("@TeacherID", teacherId);
                var list = new DBHelper(Config.ConnectionString.SQLConnCMS).GetListSP<ScheduleDayOfTeacher>("SP_TeacherScheduleDay_GetByID", pars);
                if (list == null || list.Count <= 0)
                    return new List<ScheduleDayOfTeacher>();

                return list;
            }
            catch (Exception ex)
            {
                NLogLogger.LogInfo(ex.ToString());
                return new List<ScheduleDayOfTeacher>();
            }
        }

        public List<ListClassOfTeacher> GetListClassOfTeacher(int teacherId)
        {
            try
            {
                var pars = new SqlParameter[1];
                pars[0] = new SqlParameter("@TeacherID", teacherId);
                var list = new DBHelper(Config.ConnectionString.SQLConnCMS).GetListSP<ListClassOfTeacher>("SP_Teacher_GetClass_ByTeacherID", pars);
                if (list == null || list.Count <= 0)
                    return new List<ListClassOfTeacher>();

                return list;
            }
            catch (Exception ex)
            {
                NLogLogger.LogInfo(ex.ToString());
                return new List<ListClassOfTeacher>();
            }
        }

        public List<TicketsOfStudent> GetListTicketByTeacher(int teacherId)
        {
            try
            {
                var pars = new SqlParameter[1];
                pars[0] = new SqlParameter("@TeacherID", teacherId);
                var list = new DBHelper(Config.ConnectionString.SQLConnCMS).GetListSP<TicketsOfStudent>("SP_Tickets_GetBy_TeacherID", pars);
                if (list == null || list.Count <= 0)
                    return new List<TicketsOfStudent>();

                return list;
            }
            catch (Exception ex)
            {
                NLogLogger.LogInfo(ex.ToString());
                return new List<TicketsOfStudent>();
            }
        }
        #endregion
    }
}

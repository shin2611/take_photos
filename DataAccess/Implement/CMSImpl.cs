using System;
using System.Collections.Generic;
using System.Data;
using Microsoft.Data.SqlClient;
using DataAccess.Interface;
using DataAccess.Models;
using Utils;
namespace DataAccess.Implement
{
    public class CMSImpl : ICMS
    {
        public List<Languages> GetListLanguage_CMS(int langType, int status, ref int totalRow)
        {
            try
            {
                var pars = new SqlParameter[3];
                pars[0] = new SqlParameter("@LanguageType", langType);
                pars[1] = new SqlParameter("@Status", status);
                pars[2] = new SqlParameter("@TotalRow", SqlDbType.Int) { Direction = ParameterDirection.Output };
                var list = new DBHelper(Config.ConnectionString.SQLConnWEB).GetListSP<Languages>("SP_LanguageType_GetList_CMS", pars);
                if (list == null || list.Count <= 0)
                    return new List<Languages>();
                totalRow = Convert.ToInt32(pars[2].Value);
                return list;
            }
            catch (Exception ex)
            {
                NLogLogger.LogInfo(ex.ToString());
                totalRow = 0;
                return new List<Languages>();
            }
        }

        public int INUP_Language_CMS(Languages language)
        {
            try
            {
                var pars = new SqlParameter[7];
                pars[0] = new SqlParameter("@LanguageType", language.LanguageType);
                pars[1] = new SqlParameter("@Language", language.Language);
                pars[2] = new SqlParameter("@Code", language.Code);
                pars[3] = new SqlParameter("@Icon", language.Icon);
                pars[4] = new SqlParameter("@Status", language.Status);
                pars[5] = new SqlParameter("@CreateUser", language.CreateUser);
                pars[6] = new SqlParameter("@ResponseStatus", SqlDbType.Int) { Direction = ParameterDirection.Output };
                new DBHelper(Config.ConnectionString.SQLConnWEB).ExecuteNonQuerySP("SP_LanguageType_INUP_CMS", pars);
                return Convert.ToInt32(pars[6].Value);
            }
            catch (Exception e)
            {
                NLogLogger.PublishException(e);
                return -99;
            }
        }

        public List<LevelOfClass> ListLevelOfClass(string name, string code, int status)
        {
            try
            {
                var pars = new SqlParameter[3];
                pars[0] = new SqlParameter("@Name", name);
                pars[1] = new SqlParameter("@Code", code);
                pars[2] = new SqlParameter("@Status", status);
                var list = new DBHelper(Config.ConnectionString.SQLConnCMS).GetListSP<LevelOfClass>("Sp_LevelOfClass_GetList", pars);
                if (list == null || list.Count <= 0)
                    return new List<LevelOfClass>();

                return list;
            }
            catch (Exception ex)
            {
                NLogLogger.LogInfo(ex.ToString());
                return new List<LevelOfClass>();
            }
        }

        public List<Schedule> ListScheduleOfTeach()
        {
            try
            {
                var list = new DBHelper(Config.ConnectionString.SQLConnCMS).GetListSP<Schedule>("SP_Schedule_GetList");
                if (list == null || list.Count <= 0)
                    return new List<Schedule>();

                return list;
            }
            catch (Exception ex)
            {
                NLogLogger.LogInfo(ex.ToString());
                return new List<Schedule>();
            }
        }

        public List<Merchant> MerchantGetList(int merchantId)
        {
            try
            {
                var pars = new SqlParameter[1];
                pars[0] = new SqlParameter("@MerchantID", merchantId);
                var list = new DBHelper(Config.ConnectionString.SQLConnCMS).GetListSP<Merchant>("SP_Merchant_GetList", pars);
                if (list == null || list.Count <= 0)
                    return new List<Merchant>();
               
                return list;
            }
            catch (Exception ex)
            {
                NLogLogger.LogInfo(ex.ToString());
                return new List<Merchant>();
            }
        }
        public List<DayOfWeekend> ListDayOfWeek()
        {
            try
            {
                var list = new DBHelper(Config.ConnectionString.SQLConnCMS).GetListSP<DayOfWeekend>("SP_Day_GetList");
                if (list == null || list.Count <= 0)
                    return new List<DayOfWeekend>();

                return list;
            }
            catch (Exception ex)
            {
                NLogLogger.LogInfo(ex.ToString());
                return new List<DayOfWeekend>();
            }
        }

        public List<ComboType> ListComboType(int id)
        {
            try
            {
                var pars = new SqlParameter[1];
                pars[0] = new SqlParameter("@ID", id);
                var list = new DBHelper(Config.ConnectionString.SQLConnCMS).GetListSP<ComboType>("SP_ComboCourse_GetType_ByCombo", pars);
                if (list == null || list.Count <= 0)
                    return new List<ComboType>();

                return list;
            }
            catch (Exception ex)
            {
                NLogLogger.LogInfo(ex.ToString());
                return new List<ComboType>();
            }
        }

        public List<Combo> GetAllCombo()
        {
            try
            {
                var list = new DBHelper(Config.ConnectionString.SQLConnCMS).GetListSP<Combo>("SP_Combo_GetAll");
                if (list == null || list.Count <= 0)
                    return new List<Combo>();

                return list;
            }
            catch (Exception ex)
            {
                NLogLogger.LogInfo(ex.ToString());
                return new List<Combo>();
            }
        }

        public List<ComboCourse> GetComboCourse(int id, int type)
        {
            try
            {
                var pars = new SqlParameter[2];
                pars[0] = new SqlParameter("@ID", id);
                pars[1] = new SqlParameter("@Type", type);
                var list = new DBHelper(Config.ConnectionString.SQLConnCMS).GetListSP<ComboCourse>("SP_ComboCourse_GetAll_ByID", pars);
                if (list == null || list.Count <= 0)
                    return new List<ComboCourse>();

                return list;
            }
            catch (Exception ex)
            {
                NLogLogger.LogInfo(ex.ToString());
                return new List<ComboCourse>();
            }
        }

        public ComboCourse GetComboCourseInfo(int id, int type)
        {
            try
            {
                var pars = new SqlParameter[2];
                pars[0] = new SqlParameter("@ID", id);
                pars[1] = new SqlParameter("@Type", type);
                var list = new DBHelper(Config.ConnectionString.SQLConnCMS).GetInstanceSP<ComboCourse>("SP_ComboCourse_GetAll_ByID", pars);
                if (list == null)
                    return new ComboCourse();
                return list;
            }
            catch (Exception ex)
            {
                NLogLogger.LogInfo(ex.ToString());
                return new ComboCourse();
            }
        }
        public List<CourseList> GetAllListCourse()
        {
            try
            {
                var list = new DBHelper(Config.ConnectionString.SQLConnCMS).GetListSP<CourseList>("SP_Course_GetList");
                if (list == null || list.Count <= 0)
                    return new List<CourseList>();

                return list;
            }
            catch (Exception ex)
            {
                NLogLogger.LogInfo(ex.ToString());
                return new List<CourseList>();
            }
        }

        public void CheckGiftCode(string giftcode, ref int type, ref int responseStatus)
        {
            try
            {
                var pars = new SqlParameter[3];
                pars[0] = new SqlParameter("@Giftcode", giftcode);
                pars[1] = new SqlParameter("@Type", SqlDbType.Int) { Direction = ParameterDirection.Output };
                pars[2] = new SqlParameter("@ResponseStatus", SqlDbType.Int) { Direction = ParameterDirection.Output };
                new DBHelper(Config.ConnectionString.SQLConnCMS).ExecuteNonQuerySP("SP_Giftcode_CheckGC", pars);
                type = Convert.ToInt32(pars[1].Value);
                responseStatus = Convert.ToInt32(pars[2].Value);
            }
            catch (Exception e)
            {
                NLogLogger.PublishException(e);
                type = -1;
                responseStatus = -99;
            }
        }

        public Merchant GetMerchantInfo(int merchantId)
        {
            try
            {
                var pars = new SqlParameter[1];
                pars[0] = new SqlParameter("@MerchantID", merchantId);
                var list = new DBHelper(Config.ConnectionString.SQLConnCMS).GetInstanceSP<Merchant>("SP_Merchant_GetInfo", pars);
                if (list == null)
                    return new Merchant();
                return list;
            }
            catch (Exception ex)
            {
                NLogLogger.LogInfo(ex.ToString());
                return new Merchant();
            }
        }

        public int InsertUpdateMerchant(Merchant merchant)
        {
            try
            {
                var pars = new SqlParameter[6];
                pars[0] = new SqlParameter("@MerchantID", merchant.MerchantID);
                pars[1] = new SqlParameter("@MerchantName", merchant.MerchantName);
                pars[2] = new SqlParameter("@Description", merchant.Description);
                pars[3] = new SqlParameter("@Address", merchant.Address);
                pars[4] = new SqlParameter("@PhoneNumber", merchant.PhoneNumber);
                pars[5] = new SqlParameter("@ResponseStatus", SqlDbType.Int) { Direction = ParameterDirection.Output };
                new DBHelper(Config.ConnectionString.SQLConnCMS).ExecuteNonQuerySP("SP_Merchant_InsertUpdate", pars);
                return Convert.ToInt32(pars[5].Value);
            }
            catch (Exception e)
            {
                NLogLogger.PublishException(e);
                return -99;
            }
        }

        public int DeleteMerchant(int merchantId)
        {
            try
            {
                var pars = new SqlParameter[2];
                pars[0] = new SqlParameter("@MerchantID", merchantId);
                pars[1] = new SqlParameter("@ResponseStatus", SqlDbType.Int) { Direction = ParameterDirection.Output };
                new DBHelper(Config.ConnectionString.SQLConnCMS).ExecuteNonQuerySP("SP_Merchant_Delete", pars);
                return Convert.ToInt32(pars[1].Value);
            }
            catch (Exception e)
            {
                NLogLogger.PublishException(e);
                return -99;
            }
        }

        public List<StudentCourse> GetStudentCourses(int studentId)
        {
            try
            {
                var pars = new SqlParameter[1];
                pars[0] = new SqlParameter("@StudentID", studentId);
                var list = new DBHelper(Config.ConnectionString.SQLConnCMS).GetListSP<StudentCourse>("SP_StudentCourse_Get", pars);
                if (list == null || list.Count <= 0)
                    return new List<StudentCourse>();

                return list;
            }
            catch (Exception ex)
            {
                NLogLogger.LogInfo(ex.ToString());
                return new List<StudentCourse>();
            }
        }

        public StudentComboCourse GetStudentComboByID(int studentId)
        {
            try
            {
                var pars = new SqlParameter[1];
                pars[0] = new SqlParameter("@StudentID", studentId);
                var list = new DBHelper(Config.ConnectionString.SQLConnCMS).GetInstanceSP<StudentComboCourse>("SP_StudentCombo_GetByID", pars);
                if (list == null)
                    return new StudentComboCourse();
                return list;
            }
            catch (Exception ex)
            {
                NLogLogger.LogInfo(ex.ToString());
                return new StudentComboCourse();
            }
        }
    }
}

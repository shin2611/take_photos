using System;
using System.Collections.Generic;
using System.Data;
using Microsoft.Data.SqlClient;
using DataAccess.Interface;
using DataAccess.Models;
using Utils;

namespace DataAccess.Implement
{
    public class FinanceDAOImpl : IFinanceDAO
    {
        #region FINANCE
        public List<Finance> FinanceGetList(string keyword, string startTime, string endTime, int merchantId)
        {
            try
            {
                var pars = new SqlParameter[4];
                pars[0] = new SqlParameter("@Keyword", keyword);
                pars[1] = new SqlParameter("@StartTime", startTime);
                pars[2] = new SqlParameter("@EndTime", endTime);
                pars[3] = new SqlParameter("@MerchantID", merchantId);
                var list = new DBHelper(Config.ConnectionString.SQLConnCMS).GetListSP<Finance>("SP_Finance_GetList", pars);
                if (list == null || list.Count <= 0)
                    return new List<Finance>();

                return list;
            }
            catch (Exception ex)
            {
                NLogLogger.LogInfo(ex.ToString());
                return new List<Finance>();
            }
        }

        public Finance FinanceGetInfoByID(int financeId)
        {
            try
            {
                var pars = new SqlParameter[1];
                pars[0] = new SqlParameter("@FinanceID", financeId);
                var list = new DBHelper(Config.ConnectionString.SQLConnCMS).GetInstanceSP<Finance>("SP_Finance_GetInfoByID", pars);
                if (list == null)
                    return new Finance();
                return list;
            }
            catch (Exception ex)
            {
                NLogLogger.LogInfo(ex.ToString());
                return new Finance();
            }
        }

        public int Finance_Insert(Finance finance)
        {
            try
            {
                var pars = new SqlParameter[23];
                pars[0] = new SqlParameter("@CourseType", finance.CourseType);
                pars[1] = new SqlParameter("@StudentName", finance.StudentName);
                pars[2] = new SqlParameter("@Title", finance.Title);
                pars[3] = new SqlParameter("@Description", finance.Description);
                pars[4] = new SqlParameter("@Amount", finance.Amount);
                pars[5] = new SqlParameter("@AmountOfCouse", finance.AmountOfCourse);
                pars[6] = new SqlParameter("@StrCourseIDs", finance.StrCourseIDs);
                pars[7] = new SqlParameter("@DateOfBirth", finance.DateOfBirth);
                pars[8] = new SqlParameter("@Cmnd", finance.Cmnd);
                pars[9] = new SqlParameter("@DateBy", finance.DateBy);
                pars[10] = new SqlParameter("@IssueBy", finance.IssuedBy);
                pars[11] = new SqlParameter("@PhoneNumber", finance.PhoneNumber);
                pars[12] = new SqlParameter("@ParentPhoneNumber", finance.ParentPhoneNumber);
                pars[13] = new SqlParameter("@Email", finance.Email);
                pars[14] = new SqlParameter("@TeamSaleCode", finance.TeamSaleCode);
                pars[15] = new SqlParameter("@RegisterPlace", finance.RegisterPlace);
                pars[16] = new SqlParameter("@CreatedBy", finance.CreatedBy);
                pars[17] = new SqlParameter("@MerchantID", finance.MerchantID);
                pars[18] = new SqlParameter("@GiftCode", finance.GiftCode);
                pars[19] = new SqlParameter("@ComboID", finance.ComboID);
                pars[20] = new SqlParameter("@TypeCombo", finance.ComboType);
                pars[21] = new SqlParameter("@EntryPoint", finance.EntryPoint);
                pars[22] = new SqlParameter("@ResponseStatus", SqlDbType.Int) { Direction = ParameterDirection.Output };
                new DBHelper(Config.ConnectionString.SQLConnCMS).ExecuteNonQuerySP("SP_Finance_Insert", pars);
                return Convert.ToInt32(pars[22].Value);
            }
            catch (Exception e)
            {
                NLogLogger.PublishException(e);
                return -99;
            }
        }

        public int Finance_Update(Finance finance)
        {
            try
            {
                var pars = new SqlParameter[20];
                pars[0] = new SqlParameter("@FinanceID", finance.FinanceID);
                pars[1] = new SqlParameter("@CourseID", finance.CourseID);
                pars[2] = new SqlParameter("@StudentName", finance.StudentName);
                pars[3] = new SqlParameter("@Title", finance.Title);
                pars[4] = new SqlParameter("@Description", finance.Description);
                pars[5] = new SqlParameter("@Amount", finance.Amount);
                pars[6] = new SqlParameter("@AmountOfCouse", finance.AmountOfCourse);
                pars[7] = new SqlParameter("@PaymentDate", finance.PaymentDate);
                pars[8] = new SqlParameter("@DateOfBirth", finance.DateOfBirth);
                pars[9] = new SqlParameter("@Cmnd", finance.Cmnd);
                pars[10] = new SqlParameter("@DateBy", finance.DateBy);
                pars[11] = new SqlParameter("@IssueBy", finance.IssuedBy);
                pars[12] = new SqlParameter("@PhoneNumber", finance.PhoneNumber);
                pars[13] = new SqlParameter("@ParentPhoneNumber", finance.ParentPhoneNumber);
                pars[14] = new SqlParameter("@Email", finance.Email);
                pars[15] = new SqlParameter("@TeamSaleCode", finance.TeamSaleCode);
                pars[16] = new SqlParameter("@RegisterPlace", finance.RegisterPlace);
                pars[17] = new SqlParameter("@CreatedBy", finance.CreatedBy);
                pars[18] = new SqlParameter("@MerchantID", finance.MerchantID);
                pars[19] = new SqlParameter("@ResponseStatus", SqlDbType.Int) { Direction = ParameterDirection.Output };
                new DBHelper(Config.ConnectionString.SQLConnCMS).ExecuteNonQuerySP("SP_Finance_Update", pars);
                return Convert.ToInt32(pars[19].Value);
            }
            catch (Exception e)
            {
                NLogLogger.PublishException(e);
                return -99;
            }
        }

        public List<Finance> FinanceGetListByID(long studentId)
        {
            try
            {
                var pars = new SqlParameter[1];
                pars[0] = new SqlParameter("@StudentID", studentId);
                var list = new DBHelper(Config.ConnectionString.SQLConnCMS).GetListSP<Finance>("SP_Finance_GetList_ByStuID", pars);
                if (list == null || list.Count <= 0)
                    return new List<Finance>();

                return list;
            }
            catch (Exception ex)
            {
                NLogLogger.LogInfo(ex.ToString());
                return new List<Finance>();
            }
        }

        public List<TransactionLog> GetTransactionByID(long studentId)
        {
            try
            {
                var pars = new SqlParameter[1];
                pars[0] = new SqlParameter("@StudentID", studentId);
                var list = new DBHelper(Config.ConnectionString.SQLConnCMS).GetListSP<TransactionLog>("SP_TransactionLog_GetList_ByStuID", pars);
                if (list == null || list.Count <= 0)
                    return new List<TransactionLog>();

                return list;
            }
            catch (Exception ex)
            {
                NLogLogger.LogInfo(ex.ToString());
                return new List<TransactionLog>();
            }
        }

        public int TransactionLog_Insert(Students student)
        {
            try
            {
                var pars = new SqlParameter[25];
                pars[0] = new SqlParameter("@StudentID", student.StudentID);
                pars[1] = new SqlParameter("@FinanceID", student.FinanceID);
                pars[2] = new SqlParameter("@DateOfBirth", student.DateOfBirth);
                pars[3] = new SqlParameter("@Cmnd", student.Cmnd);
                pars[4] = new SqlParameter("@DateBy", student.DateBy);
                pars[5] = new SqlParameter("@IssueBy", student.IssuedBy);
                pars[6] = new SqlParameter("@Type", student.TransactionType);
                pars[7] = new SqlParameter("@PhoneNumber", student.PhoneNumber);
                pars[8] = new SqlParameter("@ParentPhoneNumber", student.ParentPhoneNumber);
                pars[9] = new SqlParameter("@Email", student.Email);
                pars[10] = new SqlParameter("@TeamSaleCode", student.TeamSaleCode);
                pars[11] = new SqlParameter("@RegisterPlace", student.RegisterPlace);
                pars[12] = new SqlParameter("@Description", student.Description);
                pars[13] = new SqlParameter("@MerchantID", student.MerchantID);
                pars[14] = new SqlParameter("@VoucherType", student.VoucherType);
                pars[15] = new SqlParameter("@CourseType", student.CourseType);
                pars[16] = new SqlParameter("@StrCourseIDs", student.StrCourseIDs);
                pars[17] = new SqlParameter("@ComboID", student.ComboID);
                pars[18] = new SqlParameter("@TypeCombo", student.ComboType);
                pars[19] = new SqlParameter("@EntryPoint", student.EntryPoint);
                pars[20] = new SqlParameter("@CreatedBy", student.CreatedBy);
                pars[21] = new SqlParameter("@GiftCode", student.GiftCode);
                pars[22] = new SqlParameter("@Amount", student.Amount);
                pars[23] = new SqlParameter("@AmountOfCouse", student.AmountOfCourse);
                pars[24] = new SqlParameter("@ResponseStatus", SqlDbType.Int) { Direction = ParameterDirection.Output };
                new DBHelper(Config.ConnectionString.SQLConnCMS).ExecuteNonQuerySP("SP_TransactionLogs_Insert", pars);
                return Convert.ToInt32(pars[24].Value);
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

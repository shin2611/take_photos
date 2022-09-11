using System;
using System.Collections.Generic;
using System.Data;
using Microsoft.Data.SqlClient;
using DataAccess.Interface;
using DataAccess.Models;
using Utils;

namespace DataAccess.Implement
{
    public class StudentDAOImpl : IStudentDAO
    {
        public int DeleteStudent(long Id)
        {
            try
            {
                var pars = new SqlParameter[2];
                pars[0] = new SqlParameter("@StudentID", Id);
                pars[1] = new SqlParameter("@ResponseStatus", SqlDbType.Int) { Direction = ParameterDirection.Output };
                new DBHelper(Config.ConnectionString.SQLConnCMS).ExecuteNonQuerySP("SP_Student_Deltete", pars);
                return Convert.ToInt32(pars[1].Value);
            }
            catch (Exception e)
            {
                NLogLogger.PublishException(e);
                return -99;
            }
        }

        public List<Students> GetListStudent(string keyword, int status, string startDate, string endDate, int merchantId)
        {
            try
            {
                var pars = new SqlParameter[5];
                pars[0] = new SqlParameter("@Keyword", keyword);
                pars[1] = new SqlParameter("@Status", status);
                pars[2] = new SqlParameter("@StartDate", startDate);
                pars[3] = new SqlParameter("@EndDate", endDate);
                pars[4] = new SqlParameter("@MerchantID", merchantId);
                var list = new DBHelper(Config.ConnectionString.SQLConnCMS).GetListSP<Students>("SP_Student_GetListPage", pars);
                if (list == null || list.Count <= 0)
                    return new List<Students>();

                return list;
            }
            catch (Exception ex)
            {
                NLogLogger.LogInfo(ex.ToString());
                return new List<Students>();
            }
        }

        public List<Students> GetListStudentByCode(string keyword, int merchantId)
        {
            try
            {
                var pars = new SqlParameter[2];
                pars[0] = new SqlParameter("@Keyword", keyword);
                pars[1] = new SqlParameter("@MerchantID", merchantId);
                var list = new DBHelper(Config.ConnectionString.SQLConnCMS).GetListSP<Students>("SP_Student_GetList_ByCode", pars);
                if (list == null || list.Count <= 0)
                    return new List<Students>();

                return list;
            }
            catch (Exception ex)
            {
                NLogLogger.LogInfo(ex.ToString());
                return new List<Students>();
            }
        }

        public Students GetStudentInfo(long Id)
        {
            try
            {
                var pars = new SqlParameter[1];
                pars[0] = new SqlParameter("@StudentID", Id);
                var list = new DBHelper(Config.ConnectionString.SQLConnCMS).GetInstanceSP<Students>("SP_Student_GetInfo_ByID", pars);
                if (list == null)
                    return new Students();
                return list;
            }
            catch (Exception ex)
            {
                NLogLogger.LogInfo(ex.ToString());
                return new Students();
            }
        }

        public int InsertUpdate(Students student)
        {
            try
            {
                var pars = new SqlParameter[25];
                pars[0] = new SqlParameter("@StudentID", student.StudentID);
                pars[1] = new SqlParameter("@StudentName", student.StudentName);
                pars[2] = new SqlParameter("@DateOfBirth", student.DateOfBirth);
                pars[3] = new SqlParameter("@Cmnd", student.Cmnd);
                pars[4] = new SqlParameter("@DateBy", student.DateBy);
                pars[5] = new SqlParameter("@IssueBy", student.IssuedBy);
                pars[6] = new SqlParameter("@Cmnd_Path", student.Cmnd_Path);
                pars[7] = new SqlParameter("@PhoneNumber", student.PhoneNumber);
                pars[8] = new SqlParameter("@ParentPhoneNumber", student.ParentPhoneNumber);
                pars[9] = new SqlParameter("@Email", student.Email);
                pars[10] = new SqlParameter("@TeamSaleCode", student.TeamSaleCode);
                pars[11] = new SqlParameter("@RegisterPlace", student.RegisterPlace);
                pars[12] = new SqlParameter("@Status", student.Status);
                pars[13] = new SqlParameter("@MerchantID", student.MerchantID);
                pars[14] = new SqlParameter("@SaleID", student.SaleID);
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
                new DBHelper(Config.ConnectionString.SQLConnCMS).ExecuteNonQuerySP("SP_Student_InsertUpdate", pars);
                return Convert.ToInt32(pars[24].Value);
            }
            catch (Exception e)
            {
                NLogLogger.PublishException(e);
                return -99;
            }
        }
    }
}

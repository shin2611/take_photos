using System;
using System.Collections.Generic;
using System.Text;
using DataAccess.Models;
namespace DataAccess.Interface
{
    public interface IStudentDAO
    {
        List<Students> GetListStudent(string keyword, int status, string startDate, string endDate, int merchantId);
        List<Students> GetListStudentByCode(string keyword, int merchantId);
        Students GetStudentInfo(long Id);
        int InsertUpdate(Students student);
        int DeleteStudent(long Id);
    }
}

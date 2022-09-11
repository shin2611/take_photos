using System;
using System.Collections.Generic;
using System.Text;
using DataAccess.Models;

namespace DataAccess.Interface
{
    public interface ITeacherDAO
    {
        #region TEACHER
        List<Teacher> TeacherGetList(string keyword, int status, int merchantId);

        Teacher GetTeacherInfoByID(int teacherId);

        int INUP_Teacher_CMS(Teacher teacher);
        int Delete_Teacher(int teacherId);

        int UpdateTeacherStatus(int teacherId, int status);

        int ConfirmTicket(int ticketId);

        int TeacherFeedback(int ticketId, string feedbackOfTeacher);

        List<MerchantOfTeacher> GetMerchantByTeacherID(int teacherId);
        List<ScheduleOfTeacher> GetScheduleByTeacherID(int teacherId);

        List<LevelOfTeacher> GetLevelByTeacherID(int teacherId);
        List<ScheduleDayOfTeacher> GetScheduleDayByTeacherID(int teacherId);

        List<ListClassOfTeacher> GetListClassOfTeacher(int teacherId);
        List<TicketsOfStudent> GetListTicketByTeacher(int teacherId);
        #endregion
    }
}

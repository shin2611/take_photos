using System;
using System.Collections.Generic;
using System.Text;
using DataAccess.Models;

namespace DataAccess.Interface
{
    public interface ICMS
    {
        List<Languages> GetListLanguage_CMS(int langType, int status, ref int totalRow);
        int INUP_Language_CMS(Languages language);

        List<Merchant> MerchantGetList(int merchantId);
        Merchant GetMerchantInfo(int merchantId);
        int InsertUpdateMerchant(Merchant merchant);
        int DeleteMerchant(int merchantId);

        List<LevelOfClass> ListLevelOfClass(string name, string code, int status);

        List<Schedule> ListScheduleOfTeach();

        List<DayOfWeekend> ListDayOfWeek();

        List<ComboType> ListComboType(int id);
        List<Combo> GetAllCombo();
        List<ComboCourse> GetComboCourse(int id, int type);
        ComboCourse GetComboCourseInfo(int id, int type);
        List<CourseList> GetAllListCourse();
        List<StudentCourse> GetStudentCourses(int studentId);
        StudentComboCourse GetStudentComboByID(int studentId);

        void CheckGiftCode(string giftcode, ref int type, ref int responseStatus);
    }

}

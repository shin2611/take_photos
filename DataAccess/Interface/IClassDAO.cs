using System;
using System.Collections.Generic;
using System.Text;
using DataAccess.Models;

namespace DataAccess.Interface
{
    public interface IClassDAO
    {
        List<Class> ClassGetList(string keyword, string startTime, string endTime, int merchantId);
        Class GetClassInfo(int Id);
        int ClassInsertUpdate(Class cls);
        int UpdateStatusClass(int Id, int status);
        int DeleteClass(int Id);

        List<StudentOfClass> GetStudentOfClass(int classId);
        List<ScheduleDayClass> GetScheduleDayClasses(int classId);
        int AddStudentClass(int classId, long studentId);

        #region LESSON
        List<Lesson> LessonGetList(int classId);
        Lesson GetLessonInfo(int Id);
        int UpdateLesson(int lessId, string dateOfLearn, int subTeacherId);

        int StartLession(int lessId, int classId);
        int EndLession(int lessId, int classId);
        int UpdateStatusLesson(int lessId, int status);
        #endregion

        #region LESSON STUDENT
        List<LessonStudent> GetLessonStudents(int Id);
        LessonStudent GetLessonStudentInfo(int Id);
        int AttendanceStudent(int lessId, long studentId, bool atten);
        int UpdatePoint(int lessId, long studentId, int point);
        int UpdateLessonStudent(int lessId, long studentId, string feedback, int point);
        #endregion

        List<TeacherOfClass> GetTeacherOfClasses(int classId);
        int TeacherOfClass_Insert(int classId, int teacherId);
        int TeacherOfClass_Delete(int id);
    }
}

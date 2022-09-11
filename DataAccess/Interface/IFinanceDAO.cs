using System;
using System.Collections.Generic;
using System.Text;
using DataAccess.Models;

namespace DataAccess.Interface
{
    public interface IFinanceDAO
    {
        #region FINANCE
        List<Finance> FinanceGetList(string keyword, string startTime, string endTime, int merchantId);

        Finance FinanceGetInfoByID(int financeId);
        int Finance_Insert(Finance finance);
        int Finance_Update(Finance finance);

        List<TransactionLog> GetTransactionByID(long studentId);
        int TransactionLog_Insert(Students stud);

        List<Finance> FinanceGetListByID(long studentId);
        #endregion
    }
}

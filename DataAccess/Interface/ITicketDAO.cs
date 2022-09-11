using System;
using System.Collections.Generic;
using System.Text;
using DataAccess.Models;
namespace DataAccess.Interface
{
    public interface ITicketDAO
    {
        List<Ticket> GetListTicket(string keyword, int type, int status);
        List<Ticket> GetListByStudent(string accountCode, int type);
        Ticket GetTicketInfo(int id);
        int InsertUpdateTicket(Ticket tik);
        int UpdateStatusTicket(int Id, int status);
    }
}

using System;
using System.Collections.Generic;
using System.Data;
using Microsoft.Data.SqlClient;
using DataAccess.Interface;
using DataAccess.Models;
using Utils;

namespace DataAccess.Implement
{
    public class TicketDAOImpl : ITicketDAO
    {
        public List<Ticket> GetListByStudent(string accountCode, int type)
        {
            try
            {
                var pars = new SqlParameter[2];
                pars[0] = new SqlParameter("@AccountCode", accountCode);
                pars[1] = new SqlParameter("@Type", type);
                var list = new DBHelper(Config.ConnectionString.SQLConnCMS).GetListSP<Ticket>("SP_Tickets_GetList_ByCode", pars);
                if (list == null || list.Count <= 0)
                    return new List<Ticket>();

                return list;
            }
            catch (Exception ex)
            {
                NLogLogger.LogInfo(ex.ToString());
                return new List<Ticket>();
            }
        }

        public List<Ticket> GetListTicket(string keyword, int type, int status)
        {
            try
            {
                var pars = new SqlParameter[3];
                pars[0] = new SqlParameter("@Keyword", keyword);
                pars[1] = new SqlParameter("@Type", type);
                pars[2] = new SqlParameter("@Status", status);
                var list = new DBHelper(Config.ConnectionString.SQLConnCMS).GetListSP<Ticket>("SP_Tickets_GetList", pars);
                if (list == null || list.Count <= 0)
                    return new List<Ticket>();

                return list;
            }
            catch (Exception ex)
            {
                NLogLogger.LogInfo(ex.ToString());
                return new List<Ticket>();
            }
        }

        public Ticket GetTicketInfo(int id)
        {
            try
            {
                var pars = new SqlParameter[1];
                pars[0] = new SqlParameter("@ID", id);
                var list = new DBHelper(Config.ConnectionString.SQLConnCMS).GetInstanceSP<Ticket>("SP_Ticket_GetInfo", pars);
                if (list == null)
                    return new Ticket();
                return list;
            }
            catch (Exception ex)
            {
                NLogLogger.LogInfo(ex.ToString());
                return new Ticket();
            }
        }

        public int InsertUpdateTicket(Ticket tik)
        {
            throw new NotImplementedException();
        }

        public int UpdateStatusTicket(int Id, int status)
        {
            throw new NotImplementedException();
        }
    }
}

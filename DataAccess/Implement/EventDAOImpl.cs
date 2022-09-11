using System;
using System.Collections.Generic;
using System.Data;
using Microsoft.Data.SqlClient;
using DataAccess.Interface;
using DataAccess.Models;
using Utils;

namespace DataAccess.Implement
{
    public class EventDAOImpl : IEventDAO
    {
        public int DeleteEvent(int id)
        {
            try
            {
                var pars = new SqlParameter[2];
                pars[0] = new SqlParameter("@EventID", id);
                pars[1] = new SqlParameter("@ResponseStatus", SqlDbType.Int) { Direction = ParameterDirection.Output };
                new DBHelper(Config.ConnectionString.SQLConnCMS).ExecuteNonQuerySP("SP_Event_Delete", pars);
                return Convert.ToInt32(pars[1].Value);
            }
            catch (Exception e)
            {
                NLogLogger.PublishException(e);
                return -99;
            }
        }

        public Event GetEventInfo(int id)
        {
            try
            {
                var pars = new SqlParameter[1];
                pars[0] = new SqlParameter("@EventID", id);
                var list = new DBHelper(Config.ConnectionString.SQLConnCMS).GetInstanceSP<Event>("SP_Event_GetInfo_ByID", pars);
                if (list == null)
                    return new Event();
                return list;
            }
            catch (Exception ex)
            {
                NLogLogger.LogInfo(ex.ToString());
                return new Event();
            }
        }

        public List<Event> GetList(int merchantId)
        {
            try
            {
                var pars = new SqlParameter[1];
                pars[0] = new SqlParameter("@MerchantID", merchantId);
                var list = new DBHelper(Config.ConnectionString.SQLConnCMS).GetListSP<Event>("SP_Event_GetList2", pars);
                if (list == null || list.Count <= 0)
                    return new List<Event>();

                return list;
            }
            catch (Exception ex)
            {
                NLogLogger.LogInfo(ex.ToString());
                return new List<Event>();
            }
        }

        public List<Event> GetListEvent(string keyword, string startDate, string endDate, int type, int merchantId)
        {
            try
            {
                var pars = new SqlParameter[5];
                pars[0] = new SqlParameter("@Keyword", keyword);
                pars[1] = new SqlParameter("@FromDate", startDate);
                pars[2] = new SqlParameter("@ToDate", endDate);
                pars[3] = new SqlParameter("@MerchantID", merchantId);
                pars[4] = new SqlParameter("@Type", type);
                var list = new DBHelper(Config.ConnectionString.SQLConnCMS).GetListSP<Event>("SP_Event_GetList", pars);
                if (list == null || list.Count <= 0)
                    return new List<Event>();

                return list;
            }
            catch (Exception ex)
            {
                NLogLogger.LogInfo(ex.ToString());
                return new List<Event>();
            }
        }

        public int InsertUpdateEvent(Event events)
        {
            try
            {
                var pars = new SqlParameter[10];
                pars[0] = new SqlParameter("@EventID", events.EventID);
                pars[1] = new SqlParameter("@EventName", events.EventName);
                pars[2] = new SqlParameter("@AccountID", events.AccountID);
                pars[3] = new SqlParameter("@AccountName", events.AccountName);
                pars[4] = new SqlParameter("@FromDate", events.FromDate);
                pars[5] = new SqlParameter("@ToDate", events.ToDate);
                pars[6] = new SqlParameter("@EventType", events.EventType);
                pars[7] = new SqlParameter("@Money", events.Money);
                pars[8] = new SqlParameter("@MerchantID", events.MerchantID);
                pars[9] = new SqlParameter("@ResponseStatus", SqlDbType.Int) { Direction = ParameterDirection.Output };
                new DBHelper(Config.ConnectionString.SQLConnCMS).ExecuteNonQuerySP("SP_Event_InsertUpdate", pars);
                return Convert.ToInt32(pars[9].Value);
            }
            catch (Exception e)
            {
                NLogLogger.PublishException(e);
                return -99;
            }
        }
    }
}

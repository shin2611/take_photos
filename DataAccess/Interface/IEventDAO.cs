using System;
using System.Collections.Generic;
using System.Text;
using DataAccess.Models;

namespace DataAccess.Interface
{
   public interface IEventDAO
    {
        List<Event> GetListEvent(string keyword, string startDate, string endDate, int type, int merchantId);

        List<Event> GetList(int merchantId);
        Event GetEventInfo(int id);
        int DeleteEvent(int id);
        int InsertUpdateEvent(Event events);
    }
}

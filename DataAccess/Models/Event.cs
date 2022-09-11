using System;
using System.Collections.Generic;
using System.Text;

namespace DataAccess.Models
{
   public class Event
    {
        public int EventID { get; set; }
        public string EventName { get; set; }
        public int AccountID { get; set; }
        public string AccountName { get; set; }
        public DateTime FromDate { get; set; }
        public DateTime ToDate { get; set; }
        public int EventType { get; set; }
        public string EventTypeName { get; set; }
        public long Money { get; set; }
        public long MoneyUsed { get; set; }
        public int Status { get; set; }
        public int MerchantID { get; set; }
        public string MerchantName { get; set; }
        public DateTime CreatedTime { get; set; }
    }
}

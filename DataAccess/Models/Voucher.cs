using System;
using System.Collections.Generic;
using System.Text;

namespace DataAccess.Models
{
    public class Voucher
    {
        public int VoucherID { get; set; }
        public string VoucherName { get; set; }
        public long Values { get; set;}
        public int EventID { get; set; }
        public string EventName { get; set; }
        public int Status { get; set; }
        public int Quantity { get; set; }
        public int QuantityUsed { get; set; }
        public DateTime StartTime { get; set; }
        public DateTime EndTime { get; set; }
        public int StartTimeInt { get; set; }
        public int EndTimeInt { get; set; }
        public int TypeVoucher { get; set; }
        public int MerchantID { get; set; }
        public string MerchantName { get; set; }
        public int AccountID { get; set; }
        public string AccountName { get; set; }
        public DateTime CreatedTime { get; set; }
    }

    public class GiftCodeData
    {
        public long ID { get; set; }
        public int VoucherID { get; set; }
        public string GiftCode { get; set; }
        public long Value { get; set; }
        public int EventID { get; set; }
        public int IsUsed { get; set; }
        public int Status { get; set; }
        public long StudentID { get; set; }
        public string StudentName { get; set; }
        public DateTime UsedTime { get; set; }
        public DateTime CreatedTime { get; set; }
        public DateTime StartTime { get; set; }
        public DateTime EndTime { get; set; }
        public int Type { get; set; }
    }
}

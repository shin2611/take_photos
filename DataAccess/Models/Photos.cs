using System;
using System.Collections.Generic;
using System.Text;

namespace DataAccess.Models
{
    public class Photos
    {
        public long ID { get; set; }
        public string ImageUrl { get; set; }
        public string ImageBase64 { get; set; }
        public string StudentCode { get; set; }
        public string ExamId { get; set; }
        public int OrderNumber { get; set; }
    }
}

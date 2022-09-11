using System;
using System.Collections.Generic;
using System.Text;
using DataAccess.Models;
namespace DataAccess.Interface
{
   public interface IGiftcodeDAO
    {
        List<GiftCodeData> GetListGiftcode(int voucherId);
    }
}

using System;
using System.Collections.Generic;
using System.Text;
using DataAccess.Models;

namespace DataAccess.Interface
{
    public interface IVoucherDAO
    {
        List<Voucher> GetListVoucher(string keyword, int type, int eventId, int merchantId);
        int InsertUpdateVoucher(Voucher vouc);

        Voucher GetVoucherInfo(int voucherId);
    }
}

using System;
using System.Collections.Generic;
using System.Data;
using Microsoft.Data.SqlClient;
using DataAccess.Interface;
using DataAccess.Models;
using Utils;

namespace DataAccess.Implement
{
    public class GiftCodeDAOImpl : IGiftcodeDAO
    {
        public List<GiftCodeData> GetListGiftcode(int voucherId)
        {
            try
            {
                var pars = new SqlParameter[1];
                pars[0] = new SqlParameter("@VoucherID", voucherId);
                var list = new DBHelper(Config.ConnectionString.SQLConnCMS).GetListSP<GiftCodeData>("SP_Giftcode_GetList", pars);
                if (list == null || list.Count <= 0)
                    return new List<GiftCodeData>();

                return list;
            }
            catch (Exception ex)
            {
                NLogLogger.LogInfo(ex.ToString());
                return new List<GiftCodeData>();
            }
        }
    }
}

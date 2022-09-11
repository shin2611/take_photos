using System;
using System.Collections.Generic;
using System.Data;
using Microsoft.Data.SqlClient;
using DataAccess.Interface;
using DataAccess.Models;
using Utils;

namespace DataAccess.Implement
{
   public class VoucherDAOImpl : IVoucherDAO
    {
        public List<Voucher> GetListVoucher(string keyword, int type, int eventId, int merchantId)
        {
            try
            {
                var pars = new SqlParameter[4];
                pars[0] = new SqlParameter("@Keyword", keyword);
                pars[1] = new SqlParameter("@Type", type);
                pars[2] = new SqlParameter("@EventID", eventId);
                pars[3] = new SqlParameter("@MerchantID", merchantId);
                var list = new DBHelper(Config.ConnectionString.SQLConnCMS).GetListSP<Voucher>("SP_Voucher_GetList", pars);
                if (list == null || list.Count <= 0)
                    return new List<Voucher>();

                return list;
            }
            catch (Exception ex)
            {
                NLogLogger.LogInfo(ex.ToString());
                return new List<Voucher>();
            }
        }

        public Voucher GetVoucherInfo(int voucherId)
        {
            try
            {
                var pars = new SqlParameter[1];
                pars[0] = new SqlParameter("@VoucherID", voucherId);
                var list = new DBHelper(Config.ConnectionString.SQLConnCMS).GetInstanceSP<Voucher>("SP_Voucher_GetInfo", pars);
                if (list == null)
                    return new Voucher();
                return list;
            }
            catch (Exception ex)
            {
                NLogLogger.LogInfo(ex.ToString());
                return new Voucher();
            }
        }

        public int InsertUpdateVoucher(Voucher vouc)
        {
            try
            {
                var pars = new SqlParameter[13];
                pars[0] = new SqlParameter("@VoucherID", vouc.VoucherID);
                pars[1] = new SqlParameter("@VoucherName", vouc.VoucherName);
                pars[2] = new SqlParameter("@Values", vouc.Values);
                pars[3] = new SqlParameter("@EventID", vouc.EventID);
                pars[4] = new SqlParameter("@EventName", vouc.EventName);
                pars[5] = new SqlParameter("@Quantity", vouc.Quantity);
                pars[6] = new SqlParameter("@StartTime", vouc.StartTime);
                pars[7] = new SqlParameter("@EndTime", vouc.EndTime);
                pars[8] = new SqlParameter("@TypeVoucher", vouc.TypeVoucher);
                pars[9] = new SqlParameter("@AccountID", vouc.AccountID);
                pars[10] = new SqlParameter("@AccountName", vouc.AccountName);
                pars[11] = new SqlParameter("@MerchantID", vouc.MerchantID);
                pars[12] = new SqlParameter("@ResponseStatus", SqlDbType.Int) { Direction = ParameterDirection.Output };
                new DBHelper(Config.ConnectionString.SQLConnCMS).ExecuteNonQuerySP("SP_Vouchers_InsertUpdate", pars);
                return Convert.ToInt32(pars[12].Value);
            }
            catch (Exception e)
            {
                NLogLogger.PublishException(e);
                return -99;
            }
        }
    }
}

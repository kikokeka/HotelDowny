using DTO;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    public class CheckinoutDAL
    {
        private static CheckinoutDAL instance;
        public static CheckinoutDAL Instance
        {
            get { if (instance == null) instance = new CheckinoutDAL(); return CheckinoutDAL.instance; }
            private set { CheckinoutDAL.instance = value; }
        }
        private CheckinoutDAL() { }
        public string Checkin(Checkinout cko)
        {
            string insert = "usp_inserttp @mabill, @daycheckin, @phong, @type, @tknhan";
            int result = Connect.Instance.excutenonquery(insert,out string error, new SqlParameter[]{
                new SqlParameter("@mabill",cko.mabill),
                new SqlParameter("@daycheckin",cko.daycheckin),
                new SqlParameter("@phong",cko.phong),
                new SqlParameter("@type",cko.type),
                new SqlParameter("@tknhan",cko.tknhan)
                });
            if (error == null && result > 0) return "Nhận phòng thành công";
            return error;
        }
        public string Checkinonsite(Booking b)
        {
            string insert = "usp_checkinonsite @mabill, @cccd, @phong, @type, @ngaynhan, @tientratruoc, @tk, @namekh, @sdt";
            int result = Connect.Instance.excutenonquery(insert, out string error, new SqlParameter[] {
                new SqlParameter("@mabill", b.mabill),
                new SqlParameter("@cccd", b.cccd),
                new SqlParameter("@phong", b.phong),
                new SqlParameter("@type", b.type),
                new SqlParameter("@ngaynhan", b.ngaynhan),
                new SqlParameter("@tientratruoc", b.tientratruoc),
                new SqlParameter("@tk", b.tk),
                new SqlParameter("@namekh",b.namekh),
                new SqlParameter("@sdt",b.sdt)
                });
            if (error == null && result > 0) return "Nhận phòng thành công";
            return error;
        }
        public string Fix(string mabill, DateTime daycheckin, string type, int tientratruoc, string note, string tk)
        {
            string update = "usp_updatetp @mabill, @daycheckin, @type, @ttt, @note, @tk";
            int result = Connect.Instance.excutenonquery(update, out string error, new SqlParameter[] {
                new SqlParameter("@mabill", mabill),
                new SqlParameter("@daycheckin", daycheckin),
                new SqlParameter("@ttt", tientratruoc),
                new SqlParameter("@note", note),
                new SqlParameter("@tk", tk) });
            if (error == null && result > 0) return "Cập nhật thành công";
            return error;
        }
        public string Checkout(Checkinout cko)
        {
            string update = "usp_checkout @mabill,@daycheckin,@daycheckout,@phong,@type,@status,@menuprice,@roomprice,@totalprice,@tknhan,@tktra,@ghichu,@downprice";
            int result = Connect.Instance.excutenonquery(update, out string error, new SqlParameter[]{
                new SqlParameter("@mabill",cko.mabill),
                new SqlParameter("@daycheckin",cko.daycheckin),
                new SqlParameter("@daycheckout",cko.daycheckout),
                new SqlParameter("@phong",cko.phong),
                new SqlParameter("@type",cko.type),
                new SqlParameter("@status",cko.status),
                new SqlParameter("@menuprice",cko.menuprice),
                new SqlParameter("@roomprice", cko.roomprice),
                new SqlParameter("@totalprice", cko.totalprice),
                new SqlParameter("@tknhan",cko.tknhan),
                new SqlParameter("@tktra",cko.tktra),
                new SqlParameter("@ghichu",cko.ghichu),
                new SqlParameter("@downprice",cko.downprice)});
            if (error == null && result > 0) return "Trả phòng thành công";
            return error;
        }
    }
}

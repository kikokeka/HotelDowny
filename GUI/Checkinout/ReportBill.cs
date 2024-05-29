using BLL;
using DTO;
using Microsoft.Reporting.WinForms;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GUI.Checkinout
{
    public partial class ReportBill : Form
    {

        public ReportBill(string type, string id)
        {
            InitializeComponent();
            Loaddata(type,id);
        }
        void Loaddata(string type,string id)
        {
            reportViewer1.LocalReport.ReportPath = Path.Combine(AppContext.BaseDirectory, "Bill.rdlc");
            reportViewer1.LocalReport.DataSources.Clear();
            DataTable in4HotelData = SetupBLL.Instance.Report();
            ReportDataSource source1 = new ReportDataSource("In4Hotel", in4HotelData);
            reportViewer1.LocalReport.DataSources.Add(source1);
            var mabill = "";
            var namekh = "";
            var sdt = "";
            var tktra = "";
            var phong = "";
            var giovao = "";
            var giora = "";
            var roomprice = "";
            var menuprice = "";
            var downprice = "";
            var totalPrice = "";
            var tienTraTruoc = "";
            var canThanhToan = "";
            DataTable in4MenuData = null;
            if (type == "Đã trả phòng")
            {
                in4MenuData = MenuUseBLL.Instance.ReportMenu(id);

                DataTable in4Bill = CheckinoutBLL.Instance.ReportBill(id);

                mabill = in4Bill.Rows[0]["mabill"].ToString();
                namekh = in4Bill.Rows[0]["namekh"].ToString();
                sdt = in4Bill.Rows[0]["sdt"].ToString();
                tktra = in4Bill.Rows[0]["tktra"].ToString();
                phong = in4Bill.Rows[0]["phong"].ToString();
                giovao = in4Bill.Rows[0]["daycheckin"].ToString();
                giora = in4Bill.Rows[0]["daycheckout"].ToString();
                roomprice = in4Bill.Rows[0]["roomprice"].ToString();
                menuprice = in4Bill.Rows[0]["menuprice"].ToString();
                downprice = in4Bill.Rows[0]["downprice"].ToString();
                tienTraTruoc = in4Bill.Rows[0]["tientratruoc"].ToString();
                canThanhToan = in4Bill.Rows[0]["totalprice"].ToString();
                totalPrice = in4Bill.Rows[0]["totalprice"].ToString();
            }
            else
            {
                in4MenuData = MenuUseBLL.Instance.ReportMenu(id);

                DataTable in4Bill = CheckinoutBLL.Instance.ReportBill(id);

                DTO.Checkinout cko = RentRoom.cko;

                mabill = cko.mabill;
                namekh = in4Bill.Rows[0]["namekh"].ToString();
                sdt = in4Bill.Rows[0]["sdt"].ToString();
                tktra = Account.logged.Tk;
                phong = cko.phong;
                giovao = cko.daycheckin.ToString();
                giora = cko.daycheckout.ToString();
                roomprice = cko.roomprice.ToString();
                menuprice = cko.menuprice.ToString();
                downprice = cko.downprice.ToString();
                totalPrice = cko.totalprice.ToString();
                tienTraTruoc = in4Bill.Rows[0]["tientratruoc"].ToString();
                canThanhToan = (int.Parse(totalPrice) - int.Parse(tienTraTruoc)).ToString();
            }

            ReportDataSource source2 = new ReportDataSource("in4Menu", in4MenuData);
            reportViewer1.LocalReport.DataSources.Add(source2);

            reportViewer1.LocalReport.SetParameters(new ReportParameter("TienTraTruoc", tienTraTruoc.ToString()));
            reportViewer1.LocalReport.SetParameters(new ReportParameter("CanThanhToan", canThanhToan));
            reportViewer1.LocalReport.SetParameters(new ReportParameter("TotalPrice", totalPrice));
            reportViewer1.LocalReport.SetParameters(new ReportParameter("mabill", mabill));
            reportViewer1.LocalReport.SetParameters(new ReportParameter("namekh", namekh));
            reportViewer1.LocalReport.SetParameters(new ReportParameter("sdt", sdt));
            reportViewer1.LocalReport.SetParameters(new ReportParameter("nhanvien", tktra));
            reportViewer1.LocalReport.SetParameters(new ReportParameter("phong", phong));
            reportViewer1.LocalReport.SetParameters(new ReportParameter("daycheckin", giovao));
            reportViewer1.LocalReport.SetParameters(new ReportParameter("daycheckout", giora));
            reportViewer1.LocalReport.SetParameters(new ReportParameter("roomprice", roomprice));
            reportViewer1.LocalReport.SetParameters(new ReportParameter("menuprice", menuprice));
            reportViewer1.LocalReport.SetParameters(new ReportParameter("downprice", downprice));

            this.reportViewer1.RefreshReport();

        }
    }
}

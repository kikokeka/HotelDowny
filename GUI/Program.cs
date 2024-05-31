using GUI.Booking;
using GUI.Checkinout;
using GUI.ManageSys;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GUI
{
    internal static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(Login.Instance);
        }
        internal static void ExportDataGridView(DataGridView dataGridView1, string fileName, string name)
        {
            Microsoft.Office.Interop.Excel.Application excel;
            Microsoft.Office.Interop.Excel.Workbook workbook;
            Microsoft.Office.Interop.Excel.Worksheet worksheet;
            try
            {
                //Tạo đối tượng COM.
                excel = new Microsoft.Office.Interop.Excel.Application();
                excel.Visible = false;
                excel.DisplayAlerts = false;
                //tạo mới một Workbooks bằng phương thức add()
                workbook = excel.Workbooks.Add(Type.Missing);
                worksheet = (Microsoft.Office.Interop.Excel.Worksheet)workbook.Sheets["Sheet1"];
                //đặt tên cho sheet
                worksheet.Name = name;
                Microsoft.Office.Interop.Excel.Range head = worksheet.get_Range("A1", "G1");
                head.MergeCells = true;
                head.Value2 = name;
                head.Font.Bold = true;
                head.Font.Name = "Time new Roman";
                head.Font.Size = "20";
                head.HorizontalAlignment = Microsoft.Office.Interop.Excel.XlHAlign.xlHAlignCenter;
                // export header trong DataGridView
                for (int i = 0; i < dataGridView1.ColumnCount; i++)
                {
                    worksheet.Cells[2, i + 1] = dataGridView1.Columns[i].HeaderText;
                }
                // export nội dung trong DataGridView
                for (int i = 0; i < dataGridView1.RowCount; i++)
                {
                    for (int j = 0; j < dataGridView1.ColumnCount; j++)
                    {
                        worksheet.Cells[i + 3, j + 1] = dataGridView1.Rows[i].Cells[j].Value.ToString();
                    }
                }
                // sử dụng phương thức SaveAs() để lưu workbook với filename
                workbook.SaveAs(fileName);
                //đóng workbook
                workbook.Close();
                excel.Quit();
                MessageBox.Show("Xuất dữ liệu ra Excel thành công!");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                workbook = null;
                worksheet = null;
            }

        }
        internal static void ExportListView(ListView lv, bool bColHdr = true)
        {
            bool bRet = true; // Flag indicating success or failure of the export process
                              // Cờ chỉ ra thành công hoặc thất bại của quá trình xuất

            try
            {
                Cursor.Current = Cursors.WaitCursor; // Set cursor to wait cursor to indicate processing
                                                     // Đặt con trỏ thành dạng "đang chờ" để thể hiện quá trình xử lý

                Microsoft.Office.Interop.Excel.Application oXL; // Excel application object
                                                                // Đối tượng ứng dụng Excel
                Microsoft.Office.Interop.Excel._Workbook oWB;   // Workbook object
                                                                // Đối tượng workbook
                Microsoft.Office.Interop.Excel._Worksheet oSheet; // Worksheet object
                                                                  // Đối tượng worksheet

                try
                {
                    oXL = new Microsoft.Office.Interop.Excel.Application { SheetsInNewWorkbook = 1 };
                    // Create a new instance of Excel application
                    // Tạo một thể hiện mới của ứng dụng Excel
                    oWB = oXL.Workbooks.Add(Missing.Value); // Create a new workbook
                                                            // Tạo một workbook mới
                    oXL.Calculation = Microsoft.Office.Interop.Excel.XlCalculation.xlCalculationManual;
                    // Set calculation mode to manual
                    // Đặt chế độ tính toán thành thủ công

                    oSheet = (Microsoft.Office.Interop.Excel._Worksheet)oWB.Sheets[1]; // Get the first worksheet
                                                                                       // Lấy worksheet đầu tiên
                    Microsoft.Office.Interop.Excel.Range head = oSheet.get_Range("A1", "G1");
                    head.MergeCells = true;
                    head.Value2 = lv.Tag.ToString();
                    head.Font.Bold = true;
                    head.Font.Name = "Time new Roman";
                    head.Font.Size = "20";
                    head.HorizontalAlignment = Microsoft.Office.Interop.Excel.XlHAlign.xlHAlignCenter;
                    //oSheet.Name = lv.Tag.ToString();
                    // Copy ListView column headers to Excel if specified
                    // Sao chép tiêu đề cột của ListView vào Excel nếu được chỉ định
                    int startRow = 2; // Bắt đầu từ hàng thứ hai
                    if (bColHdr)
                    {
                        for (int iCol = 1; iCol <= lv.Columns.Count; iCol++)
                        {
                            oSheet.Cells[startRow, iCol] = lv.Columns[iCol - 1].Text;
                        }
                        startRow++; // Bắt đầu sao chép các mục từ hàng kế tiếp
                    }

                    // Sao chép các mục của ListView vào Excel
                    for (int iRow = 0; iRow < lv.Items.Count; iRow++)
                    {
                        for (int iCol = 1; iCol <= lv.Items[iRow].SubItems.Count; iCol++)
                        {
                            oSheet.Cells[startRow + iRow, iCol] = lv.Items[iRow].SubItems[iCol - 1].Text;
                        }
                    }

                    try
                    { // Kiểm tra xem workbook có nhiều hơn một trang tính không
                        if (oWB.Worksheets.Count > 1)
                        {
                            oWB.Worksheets[1].Delete();
                        }
                    }
                    catch (Exception ex)
                    {
                        throw ex;
                    }
                    // Delete the default sheet if present
                    // Xóa sheet mặc định nếu có
                    // Autofit columns on all sheets
                    // Tự động điều chỉnh độ rộng của cột trên tất cả các sheet
                    for (int iSheet = 1; iSheet <= oWB.Sheets.Count; iSheet++)
                        oWB.Sheets[iSheet].Columns.AutoFit();

                    oWB.Worksheets[1].Activate(); // Activate the first worksheet
                                                  // Kích hoạt worksheet đầu tiên

                    oXL.Visible = true; // Make Excel visible
                                        // Làm cho Excel hiển thị
                    oXL.UserControl = true; // Allow user control
                                            // Cho phép người dùng điều khiển
                }
                catch (Exception ex)
                {
                    throw ex;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                Cursor.Current = Cursors.Default; // Set cursor back to default
                                                  // Đặt con trỏ về dạng mặc định
            }
        }

    }
}

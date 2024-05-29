using BLL;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GUI.ManageSys
{
    public partial class CustomerForm : Form
    {
        private static CustomerForm instance;
        public static CustomerForm Instance
        {
            get { if (instance == null) instance = new CustomerForm(); return CustomerForm.instance; }
            private set { CustomerForm.instance = value; }
        }
        bool iswaiting;
        string searchText;
        DataTable dataTable = new DataTable();
        public CustomerForm()
        {
            InitializeComponent();
            Loaddata();
        }
        void Loaddata()
        {
            dataTable = ClientBLL.Instance.GetClientIn4();
            dtgrv_client.DataSource = dataTable;
        }
        void Sort()
        {
            foreach (DataGridViewColumn col in dtgrv_client.Columns)
            {
                col.SortMode = DataGridViewColumnSortMode.Automatic;
            }
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            DataView dataView = new DataView(dataTable);
            string[] searchColumns = { "CCCD", "Họ tên", "SĐT", "Phòng", "Ghi chú" };
            List<string> conditions = new List<string>();
            foreach (string column in searchColumns)
            {
                conditions.Add($"{column} LIKE '%{searchText}%'");
            }
            string filterCondition = string.Join(" OR ", conditions);
            dataView.RowFilter = filterCondition;
            dtgrv_client.DataSource = dataView;
        }

        private void txt_find_TextChanged(object sender, EventArgs e)
        {
            searchText = txt_find.Text;
            if (iswaiting) return;
            timer1.Start();
            iswaiting = true;
        }

        private void dtgrv_client_ColumnHeaderMouseDoubleClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            Sort();
        }
    }
}

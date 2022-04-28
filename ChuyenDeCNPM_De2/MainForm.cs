using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Security.Permissions;
using System.Text;
using System.Windows.Forms;

namespace ChuyenDeCNPM_De2
{
    public partial class MainForm : DevExpress.XtraEditors.XtraForm
    {
        private SqlConnection _connection = null;
        private SqlCommand _command = null;

        private int _vitriRow;
        private int _vitriColumn;

        String loaiGiaoDich = "M";
        public MainForm()
        {
            InitializeComponent();

        }
        //xóa cột đầu blank của gridview: RowHeadersVisible : false, xóa dòng cuối blank: AllowUserToAddRow: false
        //private void comboBoxMuaBan_SelectedIndexChanged(object sender, EventArgs e)
        //{
        //    if (comboBoxMuaBan.SelectedIndex == 0)
        //    {
        //        buttonMuaBan.Text = "Mua";
        //        loaiGiaoDich = "M";
        //        return;
        //    }
        //    buttonMuaBan.Text = "Bán";
        //    loaiGiaoDich = "B";
        //}

        private void DataGridViewBangGia_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            foreach (DataGridViewRow row in dataGridViewBangGiaTT.Rows)
            {
                row.Cells["Giá Khớp"].Style.BackColor = Color.LightGray;
                row.Cells["KL Khớp"].Style.BackColor = Color.LightGray;

                //row.Cells["Giá Khớp"].Style.ForeColor = Color.LimeGreen;
                //row.Cells["KL Khớp"].Style.ForeColor = Color.LimeGreen;
            }
        }

        private bool checkInput()
        {
            if (textEditMaCP.Text.Trim().Equals(""))
            {
                MessageBox.Show("Mã cổ phiếu không được để trống!", "", MessageBoxButtons.OK);
                textEditMaCP.Focus();
                return false;
            }

            if (comboBoxLoaiLenh.SelectedIndex == -1)
            {
                MessageBox.Show("Bạn chưa điền số lượng cổ phiếu!", "", MessageBoxButtons.OK);
                comboBoxLoaiLenh.Focus();
                return false;
            }
            if (spinEditGia.Value == 0)
            {
                MessageBox.Show("Bạn chưa điền giá!", "", MessageBoxButtons.OK);
                spinEditGia.Focus();
                return false;
            }

            return true;

        }

        private void buttonLamLai_Click(object sender, EventArgs e)
        {
            comboBoxMuaBan.SelectedIndex = 0;
            comboBoxLoaiLenh.SelectedIndex = 0;
            comboBoxLoaiLenh.SelectedIndex = 0;
            spinEditGia.Value = 1000;
            spinEditSoLuong.Value = 100;
            textEditMaCP.Text = "";
        }
        private void comboBoxMuaBan_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (comboBoxMuaBan.SelectedIndex == 0)
            {
                buttonMuaBan.Text = "Mua";
                loaiGiaoDich = "M";
                labelGia.Text = "Giá mua";
                return;
            }
            buttonMuaBan.Text = "Bán";
            loaiGiaoDich = "B";
            labelGia.Text = "Giá bán";
        }
        private void buttonMuaBan_Click(object sender, EventArgs e)
        {
            if (checkInput())
            {
                using (var conn = new SqlConnection(GetConnectionString()))
                using (var command = new SqlCommand("SP_KHOPLENH_LO", conn)
                {
                    CommandType = CommandType.StoredProcedure
                })
                {
                   
                    DateTime time = DateTime.Now;
                    string timeString = time.ToString("yyyy-MM-dd HH:mm:ss.mmm");

                    command.Parameters.Add(new SqlParameter("@maCP", textEditMaCP.Text.Trim()));
                    command.Parameters.Add(new SqlParameter("@ngay", timeString));
                    command.Parameters.Add(new SqlParameter("@loaiGD", loaiGiaoDich));
                    command.Parameters.Add(new SqlParameter("@soLuongMB", spinEditSoLuong.Value));
                    command.Parameters.Add(new SqlParameter("@giaDatMB", spinEditGia.Value));

                    conn.Open();
                    command.ExecuteNonQuery();
                }

            }
            else
            {
                // lỗi return;
                return;
            }
        }

        private String GetConnectionString()
        {
            return @"Data Source=TUANBUI-NOV09;Initial Catalog=CHUNGKHOAN;User ID=sa;Password=123";
        }
        private void MainForm_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'cHUNGKHOANDataSet.BANG_GIA_TRUC_TUYEN' table. You can move, or remove it, as needed

            comboBoxMuaBan.DisplayMember = "Text";
            comboBoxMuaBan.ValueMember = "Value";
            comboBoxMuaBan.Items.Add(new { Text = "Mua", Value = "M" });
            comboBoxMuaBan.Items.Add(new { Text = "Bán", Value = "B" });

            comboBoxMuaBan.SelectedIndex = 0;
            comboBoxMuaBan.SelectedValue = "M";
            comboBoxLoaiLenh.DisplayMember = "Text";
            comboBoxLoaiLenh.ValueMember = "Value";
            comboBoxLoaiLenh.Items.Add(new { Text = "Lệnh giới hạn(LO)", Value = "LO" });

            comboBoxLoaiLenh.SelectedIndex = 0;
            comboBoxLoaiLenh.SelectedValue = "LO";


            if (CanRequestNotifications() == true)
                BatDau();
            else
                MessageBox.Show("Bạn chưa kích hoạt dịch vụ Broker", "", MessageBoxButtons.OK);

        }
        private bool CanRequestNotifications()
        {
            // In order to use the callback feature of the
            // SqlDependency, the application must have
            // the SqlClientPermission permission.
            try
            {
                SqlClientPermission perm = new SqlClientPermission(PermissionState.Unrestricted);
                perm.Demand();
                return true;
            }
            catch (Exception ex)
            {
                return false;
            }
        }
        private void BatDau()
        {
            // Remove any existing dependency connection, then create a new one.
            SqlDependency.Stop(GetConnectionString());
            try
            {
                SqlDependency.Start(GetConnectionString());
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Loi", MessageBoxButtons.OK);
                return;
            }
            if (_connection == null)
            {
                _connection = new SqlConnection(GetConnectionString());
                _connection.Open();
            }

            if (_command == null)
            {
                _command = new SqlCommand(GetSQL(), _connection);
                _command.CommandType = CommandType.Text;
                _command.CommandTimeout = 600;

            }

            GetData();

        }
        private string GetSQL()
        {
            return " SELECT MACP AS[Mã CP],DM_GIA3 AS[Giá Mua 3], DM_SL3 AS[KL Mua 3], DM_GIA2 AS[Giá Mua 2], DM_SL2 AS[KL Mua 2], DM_GIA1 AS[Giá Mua 1], DM_SL1 AS[KL Mua 1], KL_GIA AS[Giá Khớp], "
                    + " KL_SL AS[KL Khớp], DB_GIA1 AS[Giá Bán 1], DB_SL1 AS[KL Bán 1], DB_GIA2 AS[Giá Bán 2], DB_SL2 AS[KL Bán 2], DB_GIA3 AS[Giá Bán 3], DB_SL3 AS[KL Bán 3] " +
                    "FROM dbo.BANG_GIA_TRUC_TUYEN ";
        }

        private void GetData()
        {

            // Make sure the command object does not already have
            // a notification object associated with it.
            _command.Notification = null;

            // Create and bind the SqlDependency object
            // to the command object.

            SqlDependency dependency = new SqlDependency(_command);
            dependency.OnChange += dependency_OnChange;


            // SqlDataReader is then loaded into a DataTable and finally the DataTable is used to populate the DataGridView.
            DataTable dt = new DataTable();
            dt.Load(_command.ExecuteReader());    // vì chỉ đọc thôi nên dùng data Reader. ko cần phải dùng dataset
            this.dataGridViewBangGiaTT.DataSource = dt;

            // giữ vị trí cursor
            try
            {
                dataGridViewBangGiaTT.ClearSelection();
                dataGridViewBangGiaTT.Rows[_vitriRow].Cells[_vitriColumn].Selected = true;
            }
            catch (Exception ex)
            {
                // neu co loi thi reset lai
                this.dataGridViewBangGiaTT.ClearSelection();
            }

        }

        private void dependency_OnChange(object sender, SqlNotificationEventArgs e)
        {
            // This event will occur on a thread pool thread.
            // It is illegal to update the UI from a worker thread
            // The following code checks to see if it is safe update the UI.
            ISynchronizeInvoke i = (ISynchronizeInvoke)this;

            // If InvokeRequired returns True, the code is executing on a worker thread.
            if (i.InvokeRequired)
            {
                // Create a delegate to perform the thread switch
                OnChangeEventHandler tempDelegate = new OnChangeEventHandler(dependency_OnChange);

                object[] args = new[] { sender, e };

                // Marshal the data from the worker thread
                // to the UI thread.
                i.BeginInvoke(tempDelegate, args);

                return;
            }
            // Remove the handler since it's only good
            // for a single notification
            SqlDependency dependency = (SqlDependency)sender;
            dependency.OnChange -= dependency_OnChange;
            // Reload the dataset that's bound to the grid.
            //MessageBox.Show("changed");

            GetData();

        }

        private void dataGridViewBangGiaTT_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                _vitriRow = dataGridViewBangGiaTT.CurrentCell.RowIndex;
                _vitriColumn = dataGridViewBangGiaTT.CurrentCell.ColumnIndex;

            }
            catch(Exception)
            {

            }
            
        }

    }

}

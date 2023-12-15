using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace RestaurantManagement
{
    public partial class Staff_Form : Form
    {
        public Staff_Form()
        {
            InitializeComponent();
        }

        Database db = new Database();
        Staff st = new Staff();

        private void Staff_Form_Load(object sender, EventArgs e)
        {
            db.Open();
            string query = Statement.getAllStaffSQL;
            MySqlCommand command = new MySqlCommand(query, db.con);
            DataTable table = Staff.getStaff(command);
            fillGrid(table);
        }

        // Đưa dữ liệu vào DataGridView
        private void fillGrid(DataTable table)
        {
            // Đặt lại tên cột cho phù hợp
            table.Columns[0].ColumnName = "Mã NV";
            table.Columns[1].ColumnName = "Tên NV";
            table.Columns[2].ColumnName = "Ngày sinh";
            table.Columns[3].ColumnName = "Giới tính";
            table.Columns[4].ColumnName = "CCCD";
            table.Columns[5].ColumnName = "Địa chỉ";
            table.Columns[6].ColumnName = "Điện thoại";
            table.Columns[7].ColumnName = "Ngày vào làm";
            table.Columns[8].ColumnName = "Lương";

            listStaffs.ReadOnly = true;
            listStaffs.DataSource = table;
        }

        // Hàm cập nhật lại danh sách nhân viên mới nhất từ cơ sở dữ liệu
        private void RefreshTable()
        {
            listStaffs.DataSource = null;
            string query = Statement.getAllStaffSQL;
            MySqlCommand command = new MySqlCommand(query, db.con);
            DataTable table = Staff.getStaff(command);
            fillGrid(table);
        }

        private void refreshBtn_Click(object sender, EventArgs e)
        {
            RefreshTable();
        }

        private void listStaffs_SelectionChanged(object sender, EventArgs e)
        {
            // Kiểm tra xem có hàng nào được chọn không
            if (listStaffs.SelectedRows.Count > 0)
            {
                // Lấy hàng được chọn
                DataGridViewRow selectedRow = listStaffs.SelectedRows[0];

                // Lấy giá trị từ các ô trong hàng
                idTbox.Text = selectedRow.Cells["Mã NV"].Value.ToString();
                nameTbox.Text = selectedRow.Cells["Tên NV"].Value.ToString();
                birthTbox.Value = DateTime.Parse(selectedRow.Cells["Ngày sinh"].Value.ToString());
                string gender = selectedRow.Cells["Giới tính"].Value.ToString();
                if(gender == "Nam")
                {
                    manOpt.Checked = true;
                } else
                {
                    womenOpt.Checked = true;
                }
                user_idTbox.Text = selectedRow.Cells["CCCD"].Value.ToString();
                addressTbox.Text = selectedRow.Cells["Địa chỉ"].Value.ToString();
                phoneTbox.Text = selectedRow.Cells["Điện thoại"].Value.ToString();
                startTbox.Value = DateTime.Parse(selectedRow.Cells["Ngày vào làm"].Value.ToString());
                salaryTbox.Text = selectedRow.Cells["Lương"].Value.ToString();
            }
        }

        private void searchBtn_Click(object sender, EventArgs e)
        {
            string name = name_searchTbox.Text;
            if (name == "")
            {
                MessageBox.Show("Vui lòng nhập họ và tên để tìm kiếm", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            listStaffs.DataSource = null;
            DataTable table = Staff.searchStaff(name, db);
            fillGrid(table);
        }

        private void sortBtn_Click(object sender, EventArgs e)
        {
            string type_sort = "";
            // Lấy kiểu để sắp xếp
            if (sortTypes.SelectedItem != null)
            {
                type_sort = sortTypes.SelectedItem.ToString();
            }
            else
            {
                MessageBox.Show("Bạn chưa chọn kiểu sắp xếp!! Vui lòng chọn rồi thực hiện lại!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            // Kiểm tra xem DataGridView có dữ liệu không
            if (listStaffs.Rows.Count > 0)
            {
                // Chọn cột cần sắp xếp
                DataGridViewColumn columnToSort = listStaffs.Columns[type_sort];

                // Sắp xếp lại dữ liệu dựa trên cột đã chọn
                listStaffs.Sort(columnToSort, ListSortDirection.Ascending);
            }
            else
            {
                MessageBox.Show("Không có dữ liệu để sắp xếp", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void addBtn_Click(object sender, EventArgs e)
        {
            AddStaff_Form add_form = new AddStaff_Form(db);
            add_form.Show();
        }

        private void deleteBtn_Click(object sender, EventArgs e)
        {
            // Kiểm tra xem có hàng nào được chọn không
            if (listStaffs.SelectedRows.Count > 0)
            {
                // Lấy hàng được chọn
                DataGridViewRow selectedRow = listStaffs.SelectedRows[0];

                string id = selectedRow.Cells["Mã NV"].Value.ToString();
                DialogResult result = MessageBox.Show($"Bạn có chắc muốn xóa nhân viên có mã '{id}'", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);

                if(result == DialogResult.Yes)
                {
                    Error err = Staff.deleteStaff(id, db);
                    if(!err.Status)
                    {
                        MessageBox.Show($"Xóa nhân viên thất bại: {err.Message}", "Lỗi hệ thống", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        return;
                    }
                    MessageBox.Show("Xóa nhân viên thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    RefreshTable();
                }

            }
            else
            {
                MessageBox.Show("Vui lòng chọn một hàng để xóa!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void modifyBtn_Click(object sender, EventArgs e)
        {
            dynamic st = new System.Dynamic.ExpandoObject();
            st.id = idTbox.Text;
            st.name = nameTbox.Text;
            st.birth = birthTbox.Text;
            st.gender = manOpt.Checked ? "Nam" : "Nữ";
            st.user_id = user_idTbox.Text;
            st.address = addressTbox.Text;
            st.phone = phoneTbox.Text;
            st.start = startTbox.Text;
            st.salary = salaryTbox.Text;

            UpdateStaff_Form update_form = new UpdateStaff_Form(st, db);
            update_form.Show();

        }

        private void exitBtn_Click(object sender, EventArgs e)
        {
            // Đóng kết nối tới cơ sở dữ liệu
            db.Close();

            if (db.status_connection)
            {
                // Đưa ra thông báo lỗi khi không thể đóng kết nối được tới cơ sở dữ liệu
                MessageBox.Show(db.err_database.Message, "Lỗi hệ thống", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            this.Close();
        }
    }
}

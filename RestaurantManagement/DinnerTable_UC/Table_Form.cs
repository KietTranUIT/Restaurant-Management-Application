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
    public partial class Table_Form : Form
    {
        public Table_Form()
        {
            InitializeComponent();
        }

        Database db = new Database();

        private void Table_Form_Load(object sender, EventArgs e)
        {
            db.Open();
            string query = Statement.getAllTableSQL;
            MySqlCommand command = new MySqlCommand(query, db.con);
            DataTable table = Staff.getStaff(command);
            fillGrid(table);
        }

        // Đưa dữ liệu vào DataGridView
        private void fillGrid(DataTable table)
        {
            // Đặt lại tên cột cho phù hợp
            table.Columns[0].ColumnName = "Mã bàn";
            table.Columns[1].ColumnName = "Tên bàn";

            listTables.ReadOnly = true;
            listTables.DataSource = table;
        }

        // Hàm cập nhật lại danh sách nhân viên mới nhất từ cơ sở dữ liệu
        private void RefreshTable()
        {
            listTables.DataSource = null;
            string query = Statement.getAllTableSQL;
            MySqlCommand command = new MySqlCommand(query, db.con);
            DataTable table = Table.getTable(command);
            fillGrid(table);
        }

        private void calBtn_Click(object sender, EventArgs e)
        {
            string query = Statement.getTableTotalSQL;
            MySqlCommand command = new MySqlCommand(query, db.con);

            idTbox.Text = "BA" + (Staff.countStaff(command) + 1).ToString("D4");
        }

        private void addBtn_Click(object sender, EventArgs e)
        {
            string id = idTbox.Text;
            string name = nameTbox.Text;

            if (id == "" || name == "")
            {
                MessageBox.Show("Chưa điền đầy đủ thông tin cho nhân viên", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            string insert = string.Format(Statement.insertTableSQL, id, name);
            Error err = Table.insertTable(insert, db);

            if (!err.Status)
            {
                MessageBox.Show(err.Message, "Thêm bàn ăn thất bại", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            MessageBox.Show("Thêm bàn ăn thành công", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            idTbox.Text = "";
            nameTbox.Text = "";
            RefreshTable();
        }

        private void deleteBtn_Click(object sender, EventArgs e)
        {
            // Kiểm tra xem có hàng nào được chọn không
            if (listTables.SelectedRows.Count > 0)
            {
                // Lấy hàng được chọn
                DataGridViewRow selectedRow = listTables.SelectedRows[0];

                string id = selectedRow.Cells["Mã bàn"].Value.ToString();
                DialogResult result = MessageBox.Show($"Bạn có chắc muốn xóa bàn ăn có mã '{id}'", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);

                if (result == DialogResult.Yes)
                {
                    Error err = Table.deleteTable(id, db);
                    if (!err.Status)
                    {
                        MessageBox.Show($"Xóa bàn ăn thất bại: {err.Message}", "Lỗi hệ thống", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        return;
                    }
                    MessageBox.Show("Xóa bàn ăn thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    RefreshTable();
                }

            }
            else
            {
                MessageBox.Show("Vui lòng chọn một hàng để xóa!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
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

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
    public partial class Dish_Form : Form
    {
        public Dish_Form()
        {
            InitializeComponent();
        }
        Database db = new Database();


        private void Dish_Form_Load(object sender, EventArgs e)
        {
            db.Open();
            string query = Statement.getFoodSQL;
            MySqlCommand command = new MySqlCommand(query, db.con);
            DataTable table = Food.getFood(command);
            fillGrid(table);

            string query1 = Statement.getNameGroupSQL;
            MySqlCommand command1 = new MySqlCommand(query1, db.con);
            List<string> dataList = Food.getNameGroupDish(command1);

            // Thêm từng mục từ danh sách vào ListBox
            foreach (string item in dataList)
            {
                listName.Items.Add(item);
            }

        }

        // Đưa dữ liệu vào DataGridView
        private void fillGrid(DataTable table)
        {
            // Đặt lại tên cột cho phù hợp
            table.Columns[0].ColumnName = "Mã món";
            table.Columns[1].ColumnName = "Tên món";
            table.Columns[2].ColumnName = "Đơn vị tính";
            table.Columns[3].ColumnName = "Tên nhóm";



            listGroupDishs.ReadOnly = true;
            listGroupDishs.DataSource = table;
        }

        // Hàm cập nhật lại danh sách nhân viên mới nhất từ cơ sở dữ liệu
        private void RefreshTable()
        {
            listGroupDishs.DataSource = null;
            string query = Statement.getFoodSQL;
            MySqlCommand command = new MySqlCommand(query, db.con);
            DataTable table = GroupDish.getGroupDish(command);
            fillGrid(table);
        }

        private void calBtn_Click(object sender, EventArgs e)
        {
            string query = Statement.getFoodTotalSQL;
            MySqlCommand command = new MySqlCommand(query, db.con);

            idTbox.Text = "MA" + (Food.countFood(command) + 1).ToString("D4");
        }

        private void addBtn_Click(object sender, EventArgs e)
        {
            string group_name = "";
            if (listName.SelectedItem != null)
            {
                group_name = listName.SelectedItem.ToString();
            }
            else
            {
                MessageBox.Show("Bạn chưa chọn nhóm món ăn! Vui lòng chọn rồi thực hiện lại!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            string id = idTbox.Text;
            string name = nameTbox.Text;
            string unit = unitTbox.Text;

            if (id == "" || name == "")
            {
                MessageBox.Show("Chưa điền đầy đủ thông tin cho món ăn", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            string insert = string.Format(Statement.insertFoodSQL, id, name, unit, group_name);
            Error err = Food.insertFood(insert, db);

            if (!err.Status)
            {
                MessageBox.Show(err.Message, "Thêm món ăn thất bại", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            MessageBox.Show("Thêm món ăn thành công", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            idTbox.Text = "";
            nameTbox.Text = "";
            RefreshTable();
        }

        private void deleteBtn_Click(object sender, EventArgs e)
        {
            // Kiểm tra xem có hàng nào được chọn không
            if (listGroupDishs.SelectedRows.Count > 0)
            {
                // Lấy hàng được chọn
                DataGridViewRow selectedRow = listGroupDishs.SelectedRows[0];

                string id = selectedRow.Cells["Mã món"].Value.ToString();
                DialogResult result = MessageBox.Show($"Bạn có chắc muốn xóa món ăn có mã '{id}'", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);

                if (result == DialogResult.Yes)
                {
                    Error err = Food.deleteFood(id, db);
                    if (!err.Status)
                    {
                        MessageBox.Show($"Xóa món ăn thất bại: {err.Message}", "Lỗi hệ thống", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        return;
                    }
                    MessageBox.Show("Xóa món ăn thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
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

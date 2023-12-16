using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Printing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace RestaurantManagement.Bill
{
    public partial class BillDetail_Form : Form
    {
        Database db;
        string id;
        int total;
        public BillDetail_Form(Database db, string id, int total)
        {
            InitializeComponent();
            this.db = db;
            this.id = id;
            this.total = total;
        }

        private void BillDetail_Form_Load(object sender, EventArgs e)
        {
            idTbox.Text = id;

            string query1 = string.Format(Statement.getAllNameFood, id);
            MySqlCommand command1 = new MySqlCommand(query1, db.con);
            List<string> data_dish = bill.getNameStaff(command1);

            // Thêm từng mục từ danh sách vào ListBox
            foreach (string item in data_dish)
            {
                listDish.Items.Add(item);
            }

            string query = Statement.getAllBillDetailSQL;
            MySqlCommand command = new MySqlCommand(query, db.con);
            DataTable table = bill.getBill(command);
            fillGrid(table);

            totalTbox.Text = total.ToString();
        }

        // Hàm cập nhật lại danh sách nhân viên mới nhất từ cơ sở dữ liệu
        private void RefreshTable()
        {
            listBills.DataSource = null;
            string query = Statement.getAllBillDetailSQL;
            MySqlCommand command = new MySqlCommand(query, db.con);
            DataTable table = Staff.getStaff(command);
            fillGrid(table);
        }

        // Đưa dữ liệu vào DataGridView
        private void fillGrid(DataTable table)
        {
            // Đặt lại tên cột cho phù hợp
            table.Columns[0].ColumnName = "Id";
            table.Columns[1].ColumnName = "Mã HĐ";
            table.Columns[2].ColumnName = "Tên món";
            table.Columns[3].ColumnName = "Đơn giá";
            table.Columns[4].ColumnName = "Số lượng";

            listBills.ReadOnly = true;
            listBills.DataSource = table;
        }

        private void addBtn_Click(object sender, EventArgs e)
        {
            string name_food = "";
            if (listDish.SelectedItem != null)
            {
                name_food = listDish.SelectedItem.ToString();
            }
            else
            {
                MessageBox.Show("Bạn chưa chọn tên món ăn! Vui lòng chọn rồi thực hiện lại!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            string q1 = string.Format(Statement.getIdFood, name_food);
            MySqlCommand c1 = new MySqlCommand(q1, db.con);
            string food_id = bill.execCommand(c1);


            string id = idTbox.Text;
            string price = priceTbox.Text;
            string count = countTbox.Text;

            if (id == "" || price == "" || count == "")
            {
                MessageBox.Show("Chưa điền đầy đủ thông tin cho hóa đơn", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            string insert = string.Format(Statement.insertBillDetailSQL, id, food_id, price, count);
            Error err = bill.insertFood(insert, db);

            if (!err.Status)
            {
                MessageBox.Show(err.Message, "Thêm thất bại", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            MessageBox.Show("Thêm thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);

            int temp = int.Parse(totalTbox.Text) + int.Parse(price) * int.Parse(count);
            totalTbox.Text = temp.ToString();
            bill.updateTotal(temp, db);

            countTbox.Text = "";
            priceTbox.Text = "";
            RefreshTable();
        }

        private void exitBtn_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void deleteBtn_Click(object sender, EventArgs e)
        {
            // Kiểm tra xem có hàng nào được chọn không
            if (listBills.SelectedRows.Count > 0)
            {
                // Lấy hàng được chọn
                DataGridViewRow selectedRow = listBills.SelectedRows[0];

                string id = selectedRow.Cells["Id"].Value.ToString();
                string price = selectedRow.Cells["Đơn giá"].Value.ToString();
                string count = selectedRow.Cells["Số lượng"].Value.ToString();
                DialogResult result = MessageBox.Show($"Bạn có chắc muốn xóa chi tiết hóa đơn có mã '{id}'", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);

                if (result == DialogResult.Yes)
                {
                    Error err = bill.deleteBillDetail(id, db);
                    if (!err.Status)
                    {
                        MessageBox.Show($"Xóa chi tiết hóa đơn thất bại: {err.Message}", "Lỗi hệ thống", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        return;
                    }
                    MessageBox.Show("Xóa chi tiết hóa đơn thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    int temp = int.Parse(totalTbox.Text) - int.Parse(price) * int.Parse(count);
                    totalTbox.Text = temp.ToString();
                    bill.updateTotal(temp, db);
                    RefreshTable();
                }

            }
            else
            {
                MessageBox.Show("Vui lòng chọn một hàng để xóa!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void printBtn_Click(object sender, EventArgs e)
        {
            PrintDocument printDocument = new PrintDocument();
            printDocument.PrintPage += new PrintPageEventHandler(PrintDocument_PrintPage);

            PrintDialog printDialog = new PrintDialog();
            printDialog.Document = printDocument;

            if (printDialog.ShowDialog() == DialogResult.OK)
            {
                printDocument.Print();
            }
        }

        private void PrintDocument_PrintPage(object sender, PrintPageEventArgs e)
        {
            string s = string.Format(Statement.select, id);
            MySqlCommand command = new MySqlCommand(s, db.con);
            MySqlDataReader reader = command.ExecuteReader();
            if(!reader.Read())
            {
                MessageBox.Show("In hóa đơn thất bại", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            // Ví dụ: Vẽ nội dung hóa đơn
            Graphics g = e.Graphics;
            Font font = new Font("Arial", 12);

            float yPos = 0;
            int count = 0;

            // Ví dụ: Vẽ nội dung từ DataGridView
            foreach (DataGridViewRow row in listBills.Rows)
            {
                // Thông tin hóa đơn
                string invoiceHeader = "HÓA ĐƠN";
                string customerName = $"Khách hàng: {reader["customer_name"].ToString()}";
                string date = $"Ngày: {reader["create_date"].ToString()}";

                // Vẽ thông tin hóa đơn
                g.DrawString(invoiceHeader, new Font("Arial", 18, FontStyle.Bold), Brushes.Black, 100, 100);
                g.DrawString(customerName, font, Brushes.Black, 100, 150);
                g.DrawString(date, font, Brushes.Black, 100, 180);

                // Vẽ bảng chi tiết hóa đơn
                int startX = 100;
                int startY = 220;
                int cellPadding = 30;

                // Tiêu đề cột
                g.DrawString("Mã hóa đơn", font, Brushes.Black, startX, startY);
                g.DrawString("Tên món", font, Brushes.Black, startX + cellPadding, startY);
                g.DrawString("Số lượng", font, Brushes.Black, startX + 2 * cellPadding, startY);
                g.DrawString("Đơn giá", font, Brushes.Black, startX + 3 * cellPadding, startY);

                // Dữ liệu chi tiết
                string[] products = { "Sản phẩm 1", "Sản phẩm 2", "Sản phẩm 3" };
                int[] quantities = { 2, 1, 3 };
                decimal[] unitPrices = { 20.5m, 10.75m, 15.0m };

                for (int i = 0; i < products.Length; i++)
                {
                    int currentY = startY + (i + 1) * 30;

                    g.DrawString(products[i], font, Brushes.Black, startX, currentY);
                    g.DrawString(quantities[i].ToString(), font, Brushes.Black, startX + cellPadding, currentY);
                    g.DrawString(unitPrices[i].ToString("C"), font, Brushes.Black, startX + 2 * cellPadding, currentY);
                    g.DrawString((quantities[i] * unitPrices[i]).ToString("C"), font, Brushes.Black, startX + 3 * cellPadding, currentY);
                }

                // Vẽ tổng cộng
                decimal total = 0;
                for (int i = 0; i < products.Length; i++)
                {
                    total += quantities[i] * unitPrices[i];
                }

                g.DrawString("Tổng cộng:", font, Brushes.Black, startX + 2 * cellPadding, startY + (products.Length + 1) * 30);
                g.DrawString(total.ToString("C"), font, Brushes.Black, startX + 3 * cellPadding, startY + (products.Length + 1) * 30);
            }
        }
    }
}

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
    public partial class Login_Form : Form
    {
        public Login_Form()
        {
            InitializeComponent();
        }

        Database db = new Database();

        private void Login_Form_Load(object sender, EventArgs e)
        {
            // Tạo một kết nối đến cơ sở dữ liệu
            db.Open();

            // Kiểm tra kết nối có thất bại không
            if (!db.status_connection)
            {
                // Đưa ra thông báo lỗi khi không kết nối được tới cơ sở dữ liệu
                MessageBox.Show(db.err_database.Message, "Lỗi hệ thống", MessageBoxButtons.OK, MessageBoxIcon.Error);
                Application.Exit();
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
            Application.Exit();
        }

        private void loginBtn_Click(object sender, EventArgs e)
        {
            string username = usernameTbox.Text;
            string password = passwordTbox.Text;

            if(username == "" || password == "")
            {
                MessageBox.Show("Tên đăng nhập và mật khẩu không được để trống", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            Error err = HandleLogin(username, password);
            if(!err.Status)
            {
                MessageBox.Show(err.Message, "Đăng nhập thất bại", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            MessageBox.Show("Chào mừng bạn đến với hệ thống", "Đăng nhập thành công", MessageBoxButtons.OK, MessageBoxIcon.Information);
            Main_Form main_form = new Main_Form();
            main_form.Show(this);
            this.Hide();

        }

        // Hàm xử lí yêu cầu đăng nhập vào hệ thống
        private Error HandleLogin(string username, string password)
        {
            Error err = new Error();

            try
            {
                // Lấy manager có username và password nhập từ form
                string query = string.Format(Statement.getLoginSQL, username, password);
                MySqlCommand command = new MySqlCommand(query, db.con);
                MySqlDataReader reader = command.ExecuteReader();

                if (!reader.Read())
                {
                    err.Message = "Tên đăng nhập hoặc mật khẩu không chính xác";
                    err.Status = false;

                    usernameTbox.Text = "";
                    passwordTbox.Text = "";
                }

                reader.Close();
            }
            catch (MySql.Data.MySqlClient.MySqlException ex)
            {
                err.Message = ex.Message;
                err.Status = false;
            }
            return err;
        }
    }
}

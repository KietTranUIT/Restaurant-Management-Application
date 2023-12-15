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
    public partial class AddStaff_Form : Form
    {
        Database db;
        public AddStaff_Form(Database db)
        {
            InitializeComponent();
            this.db = db;
        }

        private void calBtn_Click(object sender, EventArgs e)
        {
            string query = Statement.getStaffTotalSQL;
            MySqlCommand command = new MySqlCommand(query, db.con);

            idTbox.Text = "NV" + (Staff.countStaff(command) + 1).ToString("D4");
        }

        private void addBtn_Click(object sender, EventArgs e)
        {
            string id = idTbox.Text;
            string name = nameTbox.Text;
            string user_id = user_idTbox.Text;
            string address = addressTbox.Text;
            string phone = phoneTbox.Text;
            string salary = salaryTbox.Text;

            if(id == "" || name == "" || user_id == "" || address == "" || phone == "" || salary == "")
            {
                MessageBox.Show("Chưa điền đầy đủ thông tin cho nhân viên", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            string birth = birthTbox.Text;
            string start = startTbox.Text;
            string gender = "";
            if(manOpt.Checked)
            {
                gender = "Nam";
            } else
            {
                gender = "Nữ";
            }

            string insert = string.Format(Statement.insertStaffSQL, id, name, birth, gender, user_id, address, phone, start, salary);
            Error err = Staff.insertStaff(insert, db);

            if(!err.Status)
            {
                MessageBox.Show(err.Message, "Thêm nhân viên thất bại", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            MessageBox.Show("Quay trở lại!", "Thêm nhân viên thành công", MessageBoxButtons.OK, MessageBoxIcon.Information);
            this.Close();
        }
    }
}

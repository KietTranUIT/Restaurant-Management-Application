using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RestaurantManagement
{
    public partial class UpdateStaff_Form : Form
    {
        dynamic st;
        Database db;
        public UpdateStaff_Form(dynamic st, Database db)
        {
            InitializeComponent();
            this.st = st;
            this.db = db;
        }

        private void UpdateStaff_Form_Load(object sender, EventArgs e)
        {
            idTbox.Text = st.id;
            nameTbox.Text = st.name;
            birthTbox.Value = DateTime.Parse(st.birth);
            string gender = st.gender;
            if(gender == "Nam")
            {
                manOpt.Checked = true;
            } else
            {
                womenOpt.Checked = true;
            }
            user_idTbox.Text = st.user_id;
            addressTbox.Text = st.address;
            phoneTbox.Text = st.phone;
            startTbox.Value = DateTime.Parse(st.start);
            salaryTbox.Text = st.salary;
        }

        private void updateBtn_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show($"Bạn có chắc muốn cập nhật thông tin nhân viên có mã '{idTbox.Text}'", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);

            if (result == DialogResult.No)
            {
                return;
            }
            string gender = manOpt.Checked ? "Nam" : "Nữ";
            string update = string.Format(Statement.updateStaffSQL, idTbox.Text, nameTbox.Text, birthTbox.Text, gender, user_idTbox.Text, addressTbox.Text, phoneTbox.Text, startTbox.Text, salaryTbox.Text);
            Error err = Staff.updateStaff(update, db);

            if(!err.Status)
            {
                MessageBox.Show("Cập nhật thông tin nhân viên thất bại", "Lỗi hệ thống", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            MessageBox.Show("Cập nhật thông tin nhân viên thành công", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            this.Close();
        }
    }
}

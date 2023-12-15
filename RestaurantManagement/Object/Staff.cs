using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using MySql.Data.MySqlClient;

namespace RestaurantManagement
{
    class Staff
    {
        // Lấy tất cả nhân viên từ database
        public static DataTable getStaff(MySqlCommand command)
        {
            MySqlDataAdapter adapter = new MySqlDataAdapter(command);

            DataTable table = new DataTable();
            adapter.Fill(table);
            return table;
        }

        // Tìm kiếm nhân viên theo họ và tên
        public static DataTable searchStaff(string name, Database db)
        {
            string search = string.Format(Statement.searchStaffSQL, name);
            MySqlCommand command = new MySqlCommand(search, db.con);

            MySqlDataAdapter adapter = new MySqlDataAdapter(command);

            DataTable table = new DataTable();
            adapter.Fill(table);
            return table;
        }

        // Lấy số lượng nhân viên có trong cơ sở dữ liệu
        public static int countStaff(MySqlCommand command)
        {
            return Convert.ToInt32(command.ExecuteScalar());
        }

        // Thêm nhân viên vào cơ sở dữ liệu
        public static Error insertStaff(string insert, Database db)
        {
            Error err = new Error();
            try
            {
                MySqlCommand command = new MySqlCommand(insert, db.con);
                command.ExecuteNonQuery();
            } catch(MySqlException ex)
            {
                err.Message = ex.Message;
                err.Status = false;
            }

            return err;
        }

        // Xóa một nhân viên ra khỏi cơ sở dữ liệu
        public static Error deleteStaff(string id, Database db)
        {
            string del = string.Format(Statement.deleteStaffSQL, id);
            Error err = new Error();
            try
            {
                MySqlCommand command = new MySqlCommand(del, db.con);
                command.ExecuteNonQuery();
            }
            catch (MySqlException ex)
            {
                err.Message = ex.Message;
                err.Status = false;
            }

            return err;
        }

        // Cập nhật lại thông tin cho nhân viên
        public static Error updateStaff(string query, Database db)
        {
            Error err = new Error();
            try
            {
                MySqlCommand command = new MySqlCommand(query, db.con);
                command.ExecuteNonQuery();
            }
            catch (MySqlException ex)
            {
                err.Message = ex.Message;
                err.Status = false;
            }

            return err;
        }
    }
}

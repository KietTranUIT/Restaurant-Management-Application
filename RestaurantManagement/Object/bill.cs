using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;
using System.Data;

namespace RestaurantManagement
{
    class bill
    {
        public static DataTable getBill(MySqlCommand command)
        {
            MySqlDataAdapter adapter = new MySqlDataAdapter(command);

            DataTable table = new DataTable();
            adapter.Fill(table);
            return table;
        }

        public static int countBill(MySqlCommand command)
        {
            return Convert.ToInt32(command.ExecuteScalar());
        }

        // Thêm nhóm món ăn vào cơ sở dữ liệu vào cơ sở dữ liệu
        public static Error insertFood(string insert, Database db)
        {
            Error err = new Error();
            try
            {
                MySqlCommand command = new MySqlCommand(insert, db.con);
                command.ExecuteNonQuery();
            }
            catch (MySqlException ex)
            {
                err.Message = ex.Message;
                err.Status = false;
            }

            return err;
        }

        // Xóa một nhóm món ăn ra khỏi cơ sở dữ liệu
        public static Error deleteBill(string id, Database db)
        {
            string del = string.Format(Statement.deleteBillSQL, id);
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

        public static List<string> getNameStaff(MySqlCommand command)
        {
            List<string> ls = new List<string>();
            MySqlDataReader reader = command.ExecuteReader();

            while (reader.Read())
            {
                string name = reader.GetString("name");
                ls.Add(name);
            }
            reader.Close();
            return ls;
        }

        public static List<string> getNameTable(MySqlCommand command)
        {
            List<string> ls = new List<string>();
            MySqlDataReader reader = command.ExecuteReader();

            while (reader.Read())
            {
                string name = reader.GetString("name");
                ls.Add(name);
            }
            reader.Close();
            return ls;
        }

        public static string execCommand(MySqlCommand command)
        {
            object result = command.ExecuteScalar();

            return result.ToString();
        }

        public static void updateTotal(int total, Database db)
        {
            string update = string.Format(Statement.updateTotalBillDetail, total);
            MySqlCommand command = new MySqlCommand(update, db.con);
            command.ExecuteNonQuery();
        }

        // Xóa một nhóm món ăn ra khỏi cơ sở dữ liệu
        public static Error deleteBillDetail(string id, Database db)
        {
            string del = string.Format(Statement.deleteBillDetail, id);
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
    }
}

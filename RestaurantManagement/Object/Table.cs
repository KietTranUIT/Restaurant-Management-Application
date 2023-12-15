using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;
using System.Data;

namespace RestaurantManagement
{
    class Table
    {
        public static DataTable getTable(MySqlCommand command)
        {
            MySqlDataAdapter adapter = new MySqlDataAdapter(command);

            DataTable table = new DataTable();
            adapter.Fill(table);
            return table;
        }

        public static int countTable(MySqlCommand command)
        {
            return Convert.ToInt32(command.ExecuteScalar());
        }

        // Thêm bàn ăn vào cơ sở dữ liệu
        public static Error insertTable(string insert, Database db)
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

        // Xóa một bàn ăn ra khỏi cơ sở dữ liệu
        public static Error deleteTable(string id, Database db)
        {
            string del = string.Format(Statement.deleteTableSQL, id);
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

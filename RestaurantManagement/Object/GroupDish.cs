using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using MySql.Data.MySqlClient;

namespace RestaurantManagement
{
    class GroupDish
    {
        public static DataTable getGroupDish(MySqlCommand command)
        {
            MySqlDataAdapter adapter = new MySqlDataAdapter(command);

            DataTable table = new DataTable();
            adapter.Fill(table);
            return table;
        }

        public static int countGroupDish(MySqlCommand command)
        {
            return Convert.ToInt32(command.ExecuteScalar());
        }

        // Thêm nhóm món ăn vào cơ sở dữ liệu vào cơ sở dữ liệu
        public static Error insertGroupDish(string insert, Database db)
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
        public static Error deleteGroupDish(string id, Database db)
        {
            string del = string.Format(Statement.deleteGroupDishSQL, id);
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

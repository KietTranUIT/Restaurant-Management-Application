using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;
using System.Data;

namespace RestaurantManagement
{
    class Food
    {
        public static DataTable getFood(MySqlCommand command)
        {
            MySqlDataAdapter adapter = new MySqlDataAdapter(command);

            DataTable table = new DataTable();
            adapter.Fill(table);
            return table;
        }

        public static int countFood(MySqlCommand command)
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
        public static Error deleteFood(string id, Database db)
        {
            string del = string.Format(Statement.deleteFoodSQL, id);
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

        public static List<string> getNameGroupDish(MySqlCommand command)
        {
            List<string> ls = new List<string>();
            MySqlDataReader reader = command.ExecuteReader();

            while(reader.Read())
            {
                string name = reader.GetString("name");
                ls.Add(name);
            }
            reader.Close();
            return ls;
        }
    }
}

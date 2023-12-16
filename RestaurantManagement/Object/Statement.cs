using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RestaurantManagement
{
    class Statement
    {
        public static string getLoginSQL = "SELECT username, password FROM manager WHERE username='{0}' and password='{1}'";
        public static string getAllStaffSQL = "SELECT * FROM staff";
        public static string searchStaffSQL = "SELECT * FROM staff WHERE name LIKE '%{0}%'";
        public static string getStaffTotalSQL = "SELECT COUNT(*) FROM staff";
        public static string insertStaffSQL = "INSERT INTO staff VALUES ('{0}', '{1}', '{2}', '{3}', '{4}', '{5}', '{6}', '{7}', '{8}')";
        public static string deleteStaffSQL = "DELETE FROM staff WHERE id='{0}'";
        public static string updateStaffSQL = "UPDATE staff SET id='{0}', name='{1}', birth='{2}', gender='{3}', user_id='{4}', address='{5}', phone='{6}', start_work='{7}', salary='{8}' WHERE id='{0}'";

        public static string getAllTableSQL = "SELECT * FROM dinner_table";
        public static string getTableTotalSQL = "SELECT COUNT(*) FROM dinner_table";
        public static string insertTableSQL = "INSERT INTO dinner_table VALUES ('{0}', '{1}')";
        public static string deleteTableSQL = "DELETE FROM dinner_table WHERE id='{0}'";

        public static string getAllGroupDishSQL = "SELECT * FROM group_dish";
        public static string getGroupDishTotalSQL = "SELECT COUNT(*) FROM group_dish";
        public static string insertGroupDishSQL = "INSERT INTO group_dish VALUES ('{0}', '{1}')";
        public static string deleteGroupDishSQL = "DELETE FROM group_dish WHERE id='{0}'";

        public static string getFoodSQL = "SELECT * FROM food";
        public static string getFoodTotalSQL = "SELECT COUNT(*) FROM food";
        public static string insertFoodSQL = "INSERT INTO food VALUES ('{0}', '{1}', '{2}', '{3}')";
        public static string deleteFoodSQL = "DELETE FROM food WHERE id='{0}'";
        public static string getNameGroupSQL = "SELECT name FROM group_dish";

        public static string getAllBillSQL = "SELECT bill.id, bill.create_date, bill.total, dinner_table.name, staff.name, bill.customer_name, bill.status " +
                                           "FROM dinner_table INNER JOIN bill ON dinner_table.id = bill.id_table INNER JOIN staff ON bill.id_staff = staff.id";
        public static string getBillTotalSQL = "SELECT COUNT(*) FROM bill";
        public static string insertBillSQL = "INSERT INTO bill VALUES ('{0}', '{1}', '{2}', '{3}', '{4}', '{5}', '{6}')";
        public static string deleteBillSQL = "DELETE FROM bill WHERE id='{0}'";
        public static string getNameStaff = "SELECT name FROM staff";
        public static string getNameTable = "SELECT name FROM dinner_table";
        public static string getIdStaff = "SELECT id FROM staff WHERE name='{0}'";
        public static string getIdTable = "SELECT id FROM dinner_table WHERE name='{0}'";
        public static string getNameFood = "SELECT name FROM food WHERE id='{0}";
        public static string getAllNameFood = "SELECT name FROM food";


        public static string getAllBillDetailSQL = "SELECT bill_detail.id, bill_detail.bill_id, food.name, bill_detail.price, bill_detail.num " +
                                           "FROM bill INNER JOIN bill_detail ON bill.id = bill_detail.bill_id INNER JOIN food ON bill_detail.food_id = food.id";

        public static string getIdFood = "SELECT id FROM food WHERE name='{0}'";
        public static string insertBillDetailSQL = "INSERT INTO bill_detail(bill_id, food_id, price, num) VALUES ('{0}', '{1}', '{2}', '{3}')";
        public static string updateTotalBillDetail = "UPDATE bill SET total='{0}'";
        public static string deleteBillDetail = "DELETE FROM bill_detail WHERE id='{0}'";
        public static string select = "SELECT * FROM bill WHERE id='{0}'";

    }
}

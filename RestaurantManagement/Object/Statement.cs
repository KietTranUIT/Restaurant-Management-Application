﻿using System;
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
    }
}

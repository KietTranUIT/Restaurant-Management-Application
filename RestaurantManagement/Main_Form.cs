﻿using System;
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
    public partial class Main_Form : Form
    {
        public Main_Form()
        {
            InitializeComponent();
        }

        private void Main_Form_Load(object sender, EventArgs e)
        {
            Home_Form home = new Home_Form() { TopLevel = false, TopMost = true };
            home.FormBorderStyle = FormBorderStyle.None;
            panelShow.Controls.Clear();
            panelShow.Controls.Add(home);
            home.Show();
        }

        private void trangChủToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Home_Form home = new Home_Form() { TopLevel = false, TopMost = true };
            home.FormBorderStyle = FormBorderStyle.None;
            panelShow.Controls.Clear();
            panelShow.Controls.Add(home);
            home.Show();
        }

        private void Main_Form_FormClosing(object sender, FormClosingEventArgs e)
        {
            Form form = this.Owner;
            form.Show();
        }

        private void quảnLýToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Staff_Form staff_form = new Staff_Form() { TopLevel = false, TopMost = true };
            staff_form.FormBorderStyle = FormBorderStyle.None;
            panelShow.Controls.Clear();
            panelShow.Controls.Add(staff_form);
            staff_form.Show();
        }

        private void thôngTinBànĂnToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Table_Form table_form = new Table_Form() { TopLevel = false, TopMost = true };
            table_form.FormBorderStyle = FormBorderStyle.None;
            panelShow.Controls.Clear();
            panelShow.Controls.Add(table_form);
            table_form.Show();
        }

        private void nhómMónĂnToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Menu_Form menu_form = new Menu_Form() { TopLevel = false, TopMost = true };
            menu_form.FormBorderStyle = FormBorderStyle.None;
            panelShow.Controls.Clear();
            panelShow.Controls.Add(menu_form);
            menu_form.Show();
        }

        private void mónĂnToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Dish_Form dish_form = new Dish_Form() { TopLevel = false, TopMost = true };
            dish_form.FormBorderStyle = FormBorderStyle.None;
            panelShow.Controls.Clear();
            panelShow.Controls.Add(dish_form);
            dish_form.Show();
        }

        private void hóaĐơnToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Bill_Form bill_form = new Bill_Form() { TopLevel = false, TopMost = true };
            bill_form.FormBorderStyle = FormBorderStyle.None;
            panelShow.Controls.Clear();
            panelShow.Controls.Add(bill_form);
            bill_form.Show();
        }
    }
}

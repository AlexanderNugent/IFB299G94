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

namespace PptyMgmtSys {
    public partial class addStaff : Form {

        private string conn;
        private MySqlConnection connect;

        public addStaff() {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e) {
            insertStaff(PhoneBox.Text, NameBox.Text, DOBBox.Text, EmailBox.Text, PasswordBox.Text);
            this.Close();
        }

        private bool insertStaff(string staffPhone, string staffName, string staffDOB, string staffEmail, string password) {
            conn = "Server=sql6.freesqldatabase.com;Database=sql689558;Uid=sql689558;Pwd=vA7*lR3%;";
            connect = new MySqlConnection(conn);
            connect.Open();
            MySqlCommand cmd = new MySqlCommand();

            // INSERT INTO `sql689558`.`staff` (`StaffID`, `StaffPhone`, `StaffName`, `StaffDOB`, `StaffEmail`, `password`) VALUES ('2', '0455213687', 'Sten Rickards', '1985-07-06', 's.rickards@mail.com', 'mine');

            cmd.CommandText = "INSERT INTO `staff`(`StaffPhone`, `StaffName`, `StaffDOB`, `StaffEmail`, `password`) VALUES " +
                              "('" + staffPhone + "', '" + staffName + "', '" + staffDOB + "', '" + staffEmail + "', '" + password + "');";
            cmd.Connection = connect;
            MySqlDataReader login = cmd.ExecuteReader();
            System.Windows.Forms.MessageBox.Show(staffName + " successfully added.");
            
            if (login.Read()) {
                connect.Close();
                System.Windows.Forms.MessageBox.Show(staffName + " successfully added.");
                return true;
            } else {
                connect.Close();
                return false;
            }
        }
    }
}

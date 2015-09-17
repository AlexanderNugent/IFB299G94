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
    public partial class assignProperty : Form {
        public assignProperty() {
            InitializeComponent();
        }

        private string conn;
        private MySqlConnection connect;

        private void label2_Click(object sender, EventArgs e) {

        }

        private void button1_Click(object sender, EventArgs e) {
            insertAssigned(propertyBox.Text, staffBox.Text, "0");
        }

        private bool insertAssigned(string propertyID, string staffID, string hours) {
            conn = "Server=sql6.freesqldatabase.com;Database=sql689558;Uid=sql689558;Pwd=vA7*lR3%;";
            connect = new MySqlConnection(conn);
            connect.Open();
            MySqlCommand cmd = new MySqlCommand();


            cmd.CommandText = "INSERT INTO `assigned`(`PropertyID`, `StaffID`, `Hours`) VALUES " +
                              "(" + propertyID + ", " + staffID + ", " + hours + ");";
            cmd.Connection = connect;
            MySqlDataReader login = cmd.ExecuteReader();
            
            System.Windows.Forms.MessageBox.Show("Staff No. " + staffID + "assigned to property");

            if (login.Read()) {
                connect.Close();
                return true;
            } else {
                connect.Close();
                return false;
            }
        }
    }
}

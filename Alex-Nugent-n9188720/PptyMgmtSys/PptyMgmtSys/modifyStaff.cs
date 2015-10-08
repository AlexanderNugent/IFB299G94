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
    public partial class modifyStaff : Form {
        public modifyStaff() {
            InitializeComponent();
        }

        private string conn;
        private MySqlConnection connect;

        private void modifyStaff_Load(object sender, EventArgs e) {
            getStaff();
            StaffIDbox.SelectedIndex = 0;
            refreshInfo();
            refreshAssignments();
        }

        private void getStaff() {

            conn = "Server=team94.cczx3nnzcur7.us-west-2.rds.amazonaws.com;Database=propertyManagementDB;Uid=team94user;Pwd=592road$;";
            connect = new MySqlConnection(conn);
            connect.Open();
            MySqlCommand cmd = new MySqlCommand();
            cmd.CommandText = "SELECT StaffID from staff";
            cmd.Connection = connect;

            MySqlDataReader login = cmd.ExecuteReader();

            while (login.Read()) {
                StaffIDbox.Items.Add(login["StaffID"]);
            }

            login.Close();
            connect.Close();
        }

        private void refreshInfo() {
            conn = "Server=team94.cczx3nnzcur7.us-west-2.rds.amazonaws.com;Database=propertyManagementDB;Uid=team94user;Pwd=592road$;";
            connect = new MySqlConnection(conn);
            connect.Open();
            MySqlCommand cmd = new MySqlCommand();

            cmd.CommandText = "SELECT StaffName, StaffDOB, StaffEmail, Password from staff where StaffID='" + StaffIDbox.SelectedItem.ToString() + "'";
            cmd.Connection = connect;
            MySqlDataReader login = cmd.ExecuteReader();

            login.Read();
            NameBox.Text = login["StaffName"].ToString();
            DOBBox.Text = login["StaffDOB"].ToString().Substring(0,9);
            EmailBox.Text = login["StaffEmail"].ToString();
            PasswordBox.Text = login["Password"].ToString();

            login.Close();
            connect.Close();
        }

        private void StaffIDbox_SelectedIndexChanged(object sender, EventArgs e) {
            refreshInfo();
            refreshAssignments();
        }

        private void refreshAssignments() {
            conn = "Server=team94.cczx3nnzcur7.us-west-2.rds.amazonaws.com;Database=propertyManagementDB;Uid=team94user;Pwd=592road$;";
            connect = new MySqlConnection(conn);
            connect.Open();
            MySqlCommand cmd = new MySqlCommand();

            cmd.CommandText = "SELECT HouseNumber, StreetName, Suburb, Hours from property, assigned where assigned.StaffID='" + StaffIDbox.SelectedItem.ToString() + "'"+ 
                              " AND assigned.PropertyID = property.propertyID";
            cmd.Connection = connect;
            MySqlDataReader login = cmd.ExecuteReader();

             while (login.Read()) {
                 assignmentBox.AppendText(login["Hours"].ToString() + " hours at " + login["HouseNumber"].ToString() + " " + login["StreetName"].ToString() + ", " + login["Suburb"].ToString() + "\n");
            }

            assignmentBox.SelectAll();
            assignmentBox.SelectionAlignment = HorizontalAlignment.Right;
            
            login.Read();

            login.Close();
            connect.Close();
        }
    }
}

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

        private void assignProperty_Load(object sender, EventArgs e) {
            getProperties();
            getStaff();

            IDbox.SelectedIndex = 0;
            StaffIDbox.SelectedIndex = 0;

            refreshProperties();
            refreshStaff();
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

        private void getProperties() {

            conn = "Server=team94.cczx3nnzcur7.us-west-2.rds.amazonaws.com;Database=propertyManagementDB;Uid=team94user;Pwd=592road$;";
            connect = new MySqlConnection(conn);
            connect.Open();
            MySqlCommand cmd = new MySqlCommand();
            cmd.CommandText = "SELECT PropertyID from property";
            cmd.Connection = connect;

            MySqlDataReader login = cmd.ExecuteReader();

            while (login.Read()) {
                IDbox.Items.Add(login["PropertyID"]);
            }

            login.Close();
            connect.Close();
        }

        private void refreshStaff() {
            conn = "Server=team94.cczx3nnzcur7.us-west-2.rds.amazonaws.com;Database=propertyManagementDB;Uid=team94user;Pwd=592road$;";
            connect = new MySqlConnection(conn);
            connect.Open();
            MySqlCommand cmd = new MySqlCommand();

            cmd.CommandText = "SELECT StaffName, StaffDOB from staff where StaffID='" + StaffIDbox.SelectedItem.ToString() + "'";
            cmd.Connection = connect;
            MySqlDataReader login = cmd.ExecuteReader();

            login.Read();
            StaffNameLabel.Text = "Staff Name: " + login["StaffName"];
            DOBLabel.Text = "DOB: " + login["StaffDOB"].ToString().Substring(0,9);

            login.Close();
            connect.Close();
        }

        private void refreshProperties() {
            conn = "Server=team94.cczx3nnzcur7.us-west-2.rds.amazonaws.com;Database=propertyManagementDB;Uid=team94user;Pwd=592road$;";
            connect = new MySqlConnection(conn);
            connect.Open();
            MySqlCommand cmd = new MySqlCommand();

            cmd.CommandText = "SELECT StreetName, Suburb from property where PropertyID='" + IDbox.SelectedItem.ToString() + "'";
            cmd.Connection = connect;
            MySqlDataReader login = cmd.ExecuteReader();

            login.Read();
            StreetNameLabel.Text = "Street Name: " + login["StreetName"];
            SuburbLabel.Text = "Suburb: " + login["Suburb"];

            login.Close();
            connect.Close();
        }

        private void staffBox_SelectedIndexChanged(object sender, EventArgs e) {
            refreshStaff();
        }

        private void IDbox_SelectedIndexChanged(object sender, EventArgs e) {
            refreshProperties();
        }

        private void button1_Click(object sender, EventArgs e) {
            conn = "Server=team94.cczx3nnzcur7.us-west-2.rds.amazonaws.com;Database=propertyManagementDB;Uid=team94user;Pwd=592road$;";
            connect = new MySqlConnection(conn);
            connect.Open();
            MySqlCommand cmd = new MySqlCommand();


            cmd.CommandText = "INSERT INTO assigned VALUES ('" + IDbox.SelectedItem.ToString() + "', '" + StaffIDbox.SelectedItem.ToString() + "', '0.0')";

            cmd.Connection = connect;
            cmd.ExecuteNonQuery();

            connect.Close();

            MessageBox.Show("Property #" + IDbox.SelectedItem.ToString() + " assigned to Staff #" + StaffIDbox.SelectedItem.ToString());
            this.Close();
        }
    }
}

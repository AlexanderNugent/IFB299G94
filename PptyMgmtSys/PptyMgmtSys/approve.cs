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
    public partial class approve : Form {
        public approve() {
            InitializeComponent();
        }

        private string conn;
        private MySqlConnection connect;

        private void approve_Load(object sender, EventArgs e) {
            getProperties();
            IDbox.SelectedIndex = 0;
            refreshInfo();
        }

        private void getProperties() {

            conn = "Server=team94.cczx3nnzcur7.us-west-2.rds.amazonaws.com;Database=propertyManagementDB;Uid=team94user;Pwd=592road$;";
            connect = new MySqlConnection(conn);
            connect.Open();
            MySqlCommand cmd = new MySqlCommand();
            cmd.CommandText = "SELECT PropertyID from property WHERE Status = 'Awaiting Approval'";
            cmd.Connection = connect;

            MySqlDataReader login = cmd.ExecuteReader();

            while (login.Read()) {
                IDbox.Items.Add(login["PropertyID"]);
            }

            login.Close();
            connect.Close();
        }

        private void refreshInfo() {
            conn = "Server=team94.cczx3nnzcur7.us-west-2.rds.amazonaws.com;Database=propertyManagementDB;Uid=team94user;Pwd=592road$;";
            connect = new MySqlConnection(conn);
            connect.Open();
            MySqlCommand cmd = new MySqlCommand();

            cmd.CommandText = "SELECT StreetName, HouseNumber, Suburb, Postcode, Bedrooms, Bathrooms, TotalRent, PhotoOne, PhotoTwo, PhotoThree from property where PropertyID='" + IDbox.SelectedItem.ToString() + "'";
            cmd.Connection = connect;
            MySqlDataReader login = cmd.ExecuteReader();

            login.Read();
            StreetLabel.Text = "Street Name: " + login["StreetName"];
            HouseLabel.Text = "House Number: " + login["HouseNumber"];
            SuburbLabel.Text = "Suburb: " + login["Suburb"];
            PostcodeLabel.Text = "Postcode: " + login["Postcode"];
            BedroomsLabel.Text = "Bedrooms: " + login["Bedrooms"];
            BathroomsLabel.Text = "Bathrooms: " + login["Bathrooms"];
            RentLabel.Text = "Total Rent: " + login["TotalRent"];

            pictureBox1.ImageLocation = login["PhotoOne"].ToString();
            pictureBox2.ImageLocation = login["PhotoTwo"].ToString();
            pictureBox3.ImageLocation = login["PhotoThree"].ToString();




            login.Close();
            connect.Close();
        }

        private void button1_Click(object sender, EventArgs e) {

            conn = "Server=team94.cczx3nnzcur7.us-west-2.rds.amazonaws.com;Database=propertyManagementDB;Uid=team94user;Pwd=592road$;";
            connect = new MySqlConnection(conn);
            connect.Open();
            MySqlCommand cmd = new MySqlCommand();
            cmd.CommandText = "UPDATE property SET Status='Available' WHERE PropertyID='" + IDbox.SelectedItem.ToString() + "'";

            cmd.Connection = connect;
            cmd.ExecuteNonQuery();

            connect.Close();

            MessageBox.Show("Property #" + IDbox.SelectedItem.ToString() + " successfully approved.");
            this.Close();
        }

        private void IDbox_SelectedIndexChanged(object sender, EventArgs e) {
            refreshInfo();
        }

       




    }
    
}

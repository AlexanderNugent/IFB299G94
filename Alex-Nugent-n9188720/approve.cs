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
        }

        private void getProperties() {
            conn = "Server=sql6.freesqldatabase.com;Database=sql689558;Uid=sql689558;Pwd=vA7*lR3%;";
            connect = new MySqlConnection(conn);
            connect.Open();
            MySqlCommand cmd = new MySqlCommand();

            cmd.CommandText = "SELECT HouseNumber, StreetName from property WHERE Status = 'Awaiting Approval'";
            cmd.Connection = connect;
            MySqlDataReader login = cmd.ExecuteReader();

            while (login.Read()) {
                PropertyBox.Items.Add(login.GetString(0) + " " + login.GetString(1));
            }

        }

        private void PropertyBox_SelectedIndexChanged(object sender, EventArgs e) {

        }

        private void button1_Click(object sender, EventArgs e) {

            for(int x = 0; x < PropertyBox.Items.Count; x++){
                if (PropertyBox.GetItemChecked(x)) {
                    conn = "Server=sql6.freesqldatabase.com;Database=sql689558;Uid=sql689558;Pwd=vA7*lR3%;";
                    connect = new MySqlConnection(conn);
                    connect.Open();
                    MySqlCommand cmd = new MySqlCommand();
                    
                    cmd.CommandText = "UPDATE property SET Status='Available' WHERE HouseNumber=" + PropertyBox.GetItemText(x).Split(' ')[0];

                    
                    cmd.Connection = connect;
                    MySqlDataReader login = cmd.ExecuteReader();
                }

            }
            
        }

    }
}

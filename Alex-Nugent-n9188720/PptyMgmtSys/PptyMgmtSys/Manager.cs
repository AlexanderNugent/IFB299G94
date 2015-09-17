using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PptyMgmtSys {
    public partial class Manager : Form {
        public Manager() {
            InitializeComponent();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e) {

        }

        private void button2_Click(object sender, EventArgs e) {
            new addStaff().Show();
        }

        private void button1_Click(object sender, EventArgs e) {
            new approve().Show();
        }

        private void button3_Click(object sender, EventArgs e) {

        }
    }
}

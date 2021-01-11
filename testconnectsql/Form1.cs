using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace testconnectsql
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //SqlConnection myConnection = new SqlConnection("server=DESKTOP-KTK7PJB\HUUQUYENTRAN;" +
            //                           "integrated security=True;" +
            //                           "database=testusername; " +
            //                           "connection timeout=30");
            SqlConnection myConnection = new SqlConnection(@"server=DESKTOP-KTK7PJB\SQLEXPRESS; database=testusername; integrated security = true");
            
            try
            {
                myConnection.Open();
                MessageBox.Show("Well done!");
            }
            catch (SqlException ex)
            {
                MessageBox.Show("You failed!" + ex.Message);
            }

        }
    }
}

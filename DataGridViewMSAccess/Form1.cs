using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.OleDb;

namespace DataGridViewMSAccess
{
    public partial class Form1 : Form
    {
        
        string connStr = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source=C:\\Users\\Cola\\Documents\\MS ACCESS\\student.mdb";
        OleDbConnection conn;
        
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
           


        }

        private void btnView_Click(object sender, EventArgs e)
        {
            string query = "select fName,lName from table1 where fName = @fname and lName =@lame";
            conn = new OleDbConnection(connStr);
            conn.Open();
            OleDbCommand cmd = new OleDbCommand(query, conn);
            cmd.Parameters.AddWithValue("@fname", txtUsername.Text);
            cmd.Parameters.AddWithValue("@lname", txtPassword.Text);
            OleDbDataReader dr = cmd.ExecuteReader();


            if (dr.HasRows)
            {
                dr.Read();
                MessageBox.Show("Hello!" + " " + dr["fname"].ToString() + " " + dr["lname"].ToString(),"Welcome!",MessageBoxButtons.OK,MessageBoxIcon.Exclamation);
                conn.Close();
            }
            else
            {
                MessageBox.Show("Incorrect Username or Password","ERROR",MessageBoxButtons.OK,MessageBoxIcon.Error);
            }

 
            

        }

        

        private void btnClear_Click(object sender, EventArgs e)
        {
            
        }

        private void btnDisplay_TextChanged(object sender, EventArgs e)
        {
           
        }
    }
}

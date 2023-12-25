using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.OleDb;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WindowsFormsApp1;

namespace HealthCareTuto
{
    public partial class Tests : Form
    {
        Class1 ab = new Class1();
        OleDbConnection con;
        //Functions Con;
        public Tests()
        {
            InitializeComponent();
            //Con = new Functions();
            //ShowTest();
            con = new OleDbConnection(ab.connection());
        }
        private void tablerefresh()
        {
            TestsList.Rows.Clear();
            con.Open();
            string i1 = "Select * from Test";
            OleDbCommand cdr = new OleDbCommand(i1, con);
            OleDbDataReader dr = cdr.ExecuteReader();
            while (dr.Read())
            {
                TestsList.Rows.Add(dr[0].ToString(), dr[1].ToString());
            }
            con.Close();
        }
        //private void ShowTest()
        //{
        //    string Query = "Select * from TestTbl";
        //   TestsList.DataSource = Con.GetData(Query);
        //}

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }


        //int Key = 0;
        private void TestsList_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            //TNameTb.Text = TestsList.SelectedRows[0].Cells[1].Value.ToString();

            //TCostTb.Text = TestsList.SelectedRows[0].Cells[2].Value.ToString();

            // if (TNameTb.Text == "")
            // {
            //     Key = 0;
            // }
            // else
            // {
            //     Key = Convert.ToInt32(TestsList.SelectedRows[0].Cells[0].Value.ToString());
            // }
        }
        private void Clear()
        {
            TNameTb.Text = "";
            TCostTb.Text = "";
        }


        private void SaveBtn_Click(object sender, EventArgs e)
        {
            if (TNameTb.Text == "" || TCostTb.Text == "")
            {
                MessageBox.Show("Missing Data");
            }
            else
            {
                con.Open();
                string check = "select * from Test where Test_Name = '" + TNameTb.Text + "'";
                OleDbDataAdapter da = new OleDbDataAdapter(check, con);
                DataTable dt = new DataTable();
                da.Fill(dt);
                if (dt.Rows.Count > 0) {
                    MessageBox.Show("Already exist", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                }
                else {
                    //string TName = TNameTb.Text;
                    //int Cost = Convert.ToInt32(TCostTb.Text);
                    //string Query = "insert into TestTbl values('{0}','{1}')";
                    //Query = string.Format(Query,TName,Cost);
                    //Con.SetData(Query);
                    //ShowTest();
                    //Clear();
                    //MessageBox.Show("Test Added!!!");
                  
                    string insert = "insert into Test(Test_Name,Cost)values" + "(@test,@cost)";
                    OleDbCommand cd = new OleDbCommand(insert, con);
                    cd.Parameters.AddWithValue("@test", TNameTb.Text);
                    cd.Parameters.AddWithValue("@cost", TCostTb.Text);
                    cd.ExecuteNonQuery();
                    con.Close();
                    Clear();
                    tablerefresh();
                }
            }

        }

        private void EditBtn_Click(object sender, EventArgs e)
        {
            //if (TNameTb.Text == "" || TCostTb.Text == "")
            //{
            //    MessageBox.Show("Missing Data");
            //}
            //else
            //{
            //    string TName = TNameTb.Text;
            //    int Cost = Convert.ToInt32(TCostTb.Text);
            //    string Query = "Update TestTbl set TestName='{0}',TestCost='{1}' where TestCode={2}";
            //    Query = string.Format(Query, TName, Cost);
            //    Con.SetData(Query);
            //    ShowTest();
            //    Clear();
            //    MessageBox.Show("Test Updated!!!");

            //}
            if (TNameTb.Text == "" || TCostTb.Text == "") { }
            else { 
            con.Open();
            string update = "update Test set Cost = '" + TCostTb.Text + "' where Test_Name = '" + TNameTb.Text + "'";
            OleDbCommand cd = new OleDbCommand(update, con);
            cd.ExecuteNonQuery();
            con.Close();
            tablerefresh();
        } }

        private void DeleteBtn_Click(object sender, EventArgs e)
        {
            //if (Key==0)
            //{
            //    MessageBox.Show("Select a Test");
            //}
            //else
            //{
            //    string TName = TNameTb.Text;
            //    int Cost = Convert.ToInt32(TCostTb.Text);
            //    string Query = "Delete From TestTbl where TestCode={0}";
            //    Query = string.Format(Query,Key);
            //    Con.SetData(Query);
            //    ShowTest();
            //    Clear();
            //    MessageBox.Show("Test Deleted!!!");

            //}
            if (TNameTb.Text == "") { }
            else
            {
                con.Open();
                string delete = "delete from Test where Test_Name = '" + TNameTb.Text + "'";
                OleDbCommand cmd = new OleDbCommand(delete, con);
                cmd.ExecuteNonQuery();
                con.Close();
                tablerefresh();
                Clear();
            }
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            Patients hi = new Patients();
            hi.Show();
            Hide();
        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {
            Diagnosis hi = new Diagnosis();
            hi.Show();
            Hide();
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            Tests hi = new Tests();
            hi.Show();
            Hide();
        }

        private void pictureBox4_Click(object sender, EventArgs e)
        {
            Login hi = new Login();
            hi.Show();
            Hide();
        }

        private void Tests_Load(object sender, EventArgs e)
        {
            tablerefresh();
        }

        private void TestsList_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int index = e.RowIndex;
            DataGridViewRow selectedRow = TestsList.Rows[index];
            TNameTb.Text = selectedRow.Cells[0].Value.ToString();
            TCostTb.Text = selectedRow.Cells[1].Value.ToString();
        }
    }
}

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.OleDb;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web.UI.WebControls;
using System.Windows.Forms;
using WindowsFormsApp1;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace HealthCareTuto
{
    public partial class Diagnosis : Form
    {
        Class1 ab = new Class1();
        OleDbConnection con;
        //Functions Con;
        public Diagnosis()
        {
            InitializeComponent();
            //Con=new Functions();
            //GetPatients();
            //GetTest();
            //ShowDiagnosis();
            con = new OleDbConnection(ab.connection());
        }
        private void tablerefresh()
        {
            OleDbConnection conn = new OleDbConnection(ab.connection());
            conn.Open();
           Dglist.Rows.Clear(); 
            
            string i1 = "Select * from Diagnosis";
            OleDbCommand cdr = new OleDbCommand(i1, conn);
            OleDbDataReader dr = cdr.ExecuteReader();
            while (dr.Read())
            {
                Dglist.Rows.Add(dr[0].ToString(), dr[1].ToString(), dr[2].ToString(), dr[3].ToString(), dr[4].ToString());
            }
            conn.Close();
        }
    ////private void GetCost()
    //{
    //    string Query = "select * from TestTbl where TestCode={0}";
    //    Query= string.Format(Query,TestCb.SelectedValue.ToString());
    //    foreach (DataRow dr in Con.GetData(Query).Rows)
    //    {
    //        CostTb.Text = dr["TestCost"].ToString();
    //    }
    //}

    //private void ShowDiagnosis()
    //{
    //    string Query = "Select * from DiagnosisTbl";
    //    DiagnosisList.DataSource=Con.GetData(Query);
    //}


    //public void GetPatients()
    //{
    //    string Query = "Select * from PatientTb";
    //    PatientCb.DisplayMember = Con.GetData(Query).Columns["PatName"].ToString();
    //    PatientCb.ValueMember = Con.GetData(Query).Columns["PatCode"].ToString();
    //    PatientCb.DataSource = Con.GetData(Query);

    //}

    //public void GetTest()
    //{
    //    string Query = "Select * from TestTbl";
    //    TestCb.DisplayMember = Con.GetData(Query).Columns["TestName"].ToString();
    //    TestCb.ValueMember = Con.GetData(Query).Columns["TestCode"].ToString();
    //    TestCb.DataSource = Con.GetData(Query);

    //}

    private void groupBox2_Enter(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
        private void Clear()
        {
            CostTb.Text = "";
            ResultTb.Text = "";
            TestCb.SelectedIndex = -1;
            PatientCb.SelectedIndex = -1;
        }

        private void SaveBtn_Click(object sender, EventArgs e)
        {
            if (PatientCb.SelectedIndex == -1 || CostTb.Text == "" || ResultTb.Text == "")
            {
                MessageBox.Show("Missing Data");
            }
            else
            {
                //    string DDate =DiagDateTb.Value.Date.ToString();
                //    int Patient= Convert.ToInt32(PatientCb.SelectedValue.ToString());
                //    int Test = Convert.ToInt32(TestCb.SelectedValue.ToString());
                //    int Cost = Convert.ToInt32(CostTb.Text);
                //    string Result = ResultTb.Text;
                //    string Query = "insert into DiagnosisTbl values('{0}','{1}','{2}','{3}','{4}')";
                //    Query = string.Format(Query, DDate, Patient, Test, Cost,Result);
                //    Con.SetData(Query);
                //    ShowDiagnosis();
                //    Clear();
                //    MessageBox.Show("Diagnosis Added!!!");
                con.Open();
                string check = "select * from Diagnosis where Name = '" + PatientCb.Text + "'and Test_Name = '"+TestCb.Text+"'";
                OleDbDataAdapter da = new OleDbDataAdapter(check, con);
                DataTable dt = new DataTable();
                da.Fill(dt);
                if (dt.Rows.Count > 0)
                {
                    MessageBox.Show("Already exist", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                }
                else
                {
                 
                    string s = "insert into Diagnosis (Name,Test_Name,Cost,Result,D_Date)values" + "(@name,@tname,@cost,@result,@dat)";
                    OleDbCommand cd = new OleDbCommand(s, con);
                    string dat = DiagDateTb.Value.ToShortDateString();
                  
                    cd.Parameters.AddWithValue("@name", PatientCb.Text);
                    cd.Parameters.AddWithValue("@tname", TestCb.Text);
                    cd.Parameters.AddWithValue("@cost", CostTb.Text);
                    cd.Parameters.AddWithValue("@result", ResultTb.Text);
                    cd.Parameters.AddWithValue("@dat",dat );

                    cd.ExecuteNonQuery();
                    Clear();

                    tablerefresh();
                }
            }
            con.Close();

            con.Open();
            Dglist.Rows.Clear();

            string i1 = "Select * from Diagnosis";
            OleDbCommand cdr = new OleDbCommand(i1, con);
            OleDbDataReader dr = cdr.ExecuteReader();
            while (dr.Read())
            {
                Dglist.Rows.Add(dr[0].ToString(), dr[1].ToString(), dr[2].ToString(), dr[3].ToString(), dr[4].ToString());
            }
            con.Close();
        }

        private void TestCb_SelectionChangeCommitted(object sender, EventArgs e)
        {
            //GetCost();
        }
        //int Key = 0;
        private void DiagnosisList_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            //DiagDateTb.Text = DiagnosisList.SelectedRows[0].Cells[1].Value.ToString();
            //PatientCb.SelectedItem = DiagnosisList.SelectedRows[0].Cells[2].Value.ToString();
            //TestCb.SelectedItem = DiagnosisList.SelectedRows[0].Cells[3].Value.ToString();
            //CostTb.Text = DiagnosisList.SelectedRows[0].Cells[4].Value.ToString();
            //ResultTb.Text = DiagnosisList.SelectedRows[0].Cells[5].Value.ToString();
            //if (CostTb.Text == "")
            //{
            //    Key = 0;
            //}
            //else
            //{
            //    Key = Convert.ToInt32(DiagnosisList.SelectedRows[0].Cells[0].Value.ToString());
            //}
        }

        private void EditBtn_Click(object sender, EventArgs e)
        {
            if (PatientCb.SelectedIndex == -1 || CostTb.Text == "" || ResultTb.Text == "")
            {
                MessageBox.Show("Missing Data");
            }
            else
            {
                //    string DDate = DiagDateTb.Value.Date.ToString();
                //    int Patient = Convert.ToInt32(PatientCb.SelectedValue.ToString());
                //    int Test = Convert.ToInt32(TestCb.SelectedValue.ToString());
                //    int Cost = Convert.ToInt32(CostTb.Text);
                //    string Result = ResultTb.Text;
                //    string Query = "Update DiagnosisTbl set DiagDate='{0}',Patient='{1}',Test='{2}',Cost='{3}',Result='{4}' where DiagCode='{5}'";
                //    Query = string.Format(Query, DDate, Patient, Test, Cost, Result);
                //    Con.SetData(Query);
                //    ShowDiagnosis();
                //    Clear();
                //    MessageBox.Show("Diagnosis Updated!!!");


                con.Open();
                string update = "update Diagnosis set Result = '" + ResultTb.Text + "',D_Date='" + DiagDateTb.Value.ToShortDateString() + "' where Name = '" + PatientCb.Text + "'and Test_Name = '"+TestCb.Text+"'";
                OleDbCommand cd = new OleDbCommand(update, con);
                cd.ExecuteNonQuery();
                con.Close();
                tablerefresh();
            }
        }

        private void DeleteBtn_Click(object sender, EventArgs e)
        {
            //if (Key == 0)
            //{
            //    MessageBox.Show("Missing Data!!!");
            //}
            //else
            //{

            //    string Query = "Delete from DiagnosisTbl where DiagCode={0}";
            //    Query = string.Format(Query,Key);
            //    Con.SetData(Query);
            //    ShowDiagnosis();
            //    Clear();
            //    MessageBox.Show("Diagnosis Deleted!");

            //}
            if (PatientCb.Text == "") { }
            else
            {
                con.Open();
                string delete = "delete from Diagnosis where Name = '" + PatientCb.Text + "'and Test_Name='"+TestCb.Text+"'";
                OleDbCommand cmd = new OleDbCommand(delete, con);
                cmd.ExecuteNonQuery();
                con.Close();
                tablerefresh();
                Clear();
            }
        }

        private void Diagnosis_Load(object sender, EventArgs e)
        {
            tablerefresh();

            string B = "select * from Patient";
            OleDbDataAdapter da = new OleDbDataAdapter(B, con);
            DataTable dt = new DataTable();
            da.Fill(dt);
            foreach (DataRow row in dt.Rows)
            {
                PatientCb.Items.Add(row["Name"]);
               
            }
            con.Close();

            string bd = "select * from Test";
            OleDbDataAdapter daa = new OleDbDataAdapter(bd, con);
            DataTable dta = new DataTable();
            daa.Fill(dta);
            foreach (DataRow row in dta.Rows)
            {
                TestCb.Items.Add(row["Test_Name"]);

            }
            con.Close();
        }

        private void TestCb_TextChanged(object sender, EventArgs e)
        {
            OleDbConnection com = new OleDbConnection(ab.connection());
            com.Open();  
            string m = TestCb.Text;
            
            string c = "select Cost from Test where Test_Name = '" + m + "'";
            OleDbCommand cd = new OleDbCommand(c, com);
            OleDbDataAdapter cmd = new OleDbDataAdapter(c, com);
            DataTable hi = new DataTable();
            cmd.Fill(hi);
           
            if (hi.Rows.Count > 0)
            {
                CostTb.Text = cd.ExecuteScalar().ToString();
               
            }
            com.Close();
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void Dglist_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int index = e.RowIndex;
            DataGridViewRow selectedRow = Dglist.Rows[index];
            PatientCb.Text = selectedRow.Cells[0].Value.ToString();
            TestCb.Text = selectedRow.Cells[1].Value.ToString();
            CostTb.Text = selectedRow.Cells[2].Value.ToString();
            //DOBTb.s = selectedRow.Cells[3].Value;
            ResultTb.Text = selectedRow.Cells[3].Value.ToString();
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
    }
}

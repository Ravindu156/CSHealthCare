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
    public partial class Patients : Form
    {
        Class1 ab = new Class1();
        OleDbConnection con;
        //Functions Con;
        public Patients()
        {
            InitializeComponent();
            //Con = new Functions();
            //ShowPatients();
            con = new OleDbConnection(ab.connection());
        }
        private void tablerefresh()
        {
            PatientList.Rows.Clear();
            con.Open();
            string i1 = "Select * from Patient";
            OleDbCommand cdr = new OleDbCommand(i1, con);
            OleDbDataReader dr = cdr.ExecuteReader();
            while (dr.Read())
            {
                PatientList.Rows.Add(dr[0].ToString(), dr[1].ToString(), dr[2].ToString(), dr[3].ToString(), dr[4].ToString());
            }
            con.Close();
        }
        private void ShowPatients()
        { 
        //    string Query = "Select * from PatientTb";
        //    PatientList.DataSource = Con.GetData(Query);
        }
        private void textBox5_TextChanged(object sender, EventArgs e)
        {

        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void SaveBtn_Click(object sender, EventArgs e)
        {
            //if (PatNameTb.Text == "" || PatAddTb.Text == "" || PatPhoneTb.Text == "" || GenCb.SelectedIndex == -1)
            //{
            //    MessageBox.Show("Missing Data");
            //}else
            //{
            //    string Patient=PatNameTb.Text;
            //    string Gender=GenCb.SelectedItem.ToString();
            //    string BDate=DOBTb.Value.ToString();
            //    string Phone=PatPhoneTb.Text;
            //    string Address = PatAddTb.Text;
            //    string Query = "insert into PatientTbl values('{0}','{1}','{2}','{3}','{4}')";
            //    Query = string.Format(Query,Patient,Gender,BDate,Phone,Address);
            //    Con.SetData(Query);
            //    ShowPatients();
            //    Clear();
            //    MessageBox.Show("Patient Added!!!");

            //}
            if (PatNameTb.Text == "" || PatAddTb.Text == "" || PatPhoneTb.Text == "" || GenCb.SelectedIndex == -1)
            {

            }
            else
            {
                con.Open();
                string check = "select * from Patient where Name = '" + PatNameTb.Text + "'";
                OleDbDataAdapter da = new OleDbDataAdapter(check, con);
                DataTable dt = new DataTable();
                da.Fill(dt);
                if (dt.Rows.Count > 0)
                {
                    MessageBox.Show("Already exist", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                }
                else
                {
                  
                    string s = "insert into Patient (Name,Address,Phone,Dob,Gender)values" + "(@name,@address,@phone,@dob,@gender)";
                    OleDbCommand cd = new OleDbCommand(s, con);
                    string dat = DOBTb.Value.ToShortDateString();
                    string gen = GenCb.SelectedItem.ToString();
                    cd.Parameters.AddWithValue("@name", PatNameTb.Text);
                    cd.Parameters.AddWithValue("@address", PatAddTb.Text);
                    cd.Parameters.AddWithValue("@phone", PatPhoneTb.Text);
                    cd.Parameters.AddWithValue("@dob", dat);
                    cd.Parameters.AddWithValue("@username", gen);

                    cd.ExecuteNonQuery();
                    Clear();
                    con.Close();
                    tablerefresh();
                }
            }
        }

        //int Key = 0;
        private void PatientList_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            //PatNameTb.Text = PatientList.SelectedRows[0].Cells[1].Value.ToString();
            //GenCb.SelectedItem = PatientList.SelectedRows[0].Cells[2].Value.ToString();
            //DOBTb.Text = PatientList.SelectedRows[0].Cells[3].Value.ToString();
            //PatPhoneTb.Text = PatientList.SelectedRows[0].Cells[4].Value.ToString();
            //PatAddTb.Text = PatientList.SelectedRows[0].Cells[5].Value.ToString();
            //if (PatNameTb.Text == "")
            //{
            //    Key = 0;
            //}
            //else
            //{
            //    Key = Convert.ToInt32(PatientList.SelectedRows[0].Cells[0].Value.ToString());
            //}
        }

        private void PatientList_Enter(object sender, EventArgs e)
        {

        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void Patients_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'healthCareDBDataSet.PatientTb' table. You can move, or remove it, as needed.
            //this.patientTbTableAdapter.Fill(this.healthCareDBDataSet.PatientTb);
            tablerefresh();
        }

        private void EditBtn_Click(object sender, EventArgs e)
        {
            //if (PatNameTb.Text == "" || PatAddTb.Text == "" || PatPhoneTb.Text == "" || GenCb.SelectedIndex == -1)
            //{
            //    MessageBox.Show("Missing Data");
            //}
            //else
            //{
            //    string Patient = PatNameTb.Text;
            //    string Gender = GenCb.SelectedItem.ToString();
            //    string BDate = DOBTb.Value.ToString();
            //    string Phone = PatPhoneTb.Text;
            //    string Address = PatAddTb.Text;
            //    string Query = "Update PatientTbl set PatName='{0}',PatGen='{1}',PatDob='{2}',PatPhone='{3}',PatAdd='{4}' where PatCode='{5}')";
            //    Query = string.Format(Query, Patient, Gender, BDate, Phone, Address,Key);
            //    Con.SetData(Query);
            //    ShowPatients();
            //    Clear();
            //    MessageBox.Show("Patient Upadated!!!");

            //}
            if (PatNameTb.Text == "" || PatAddTb.Text == "" || PatPhoneTb.Text == "" || GenCb.SelectedIndex == -1)
            {

            }
            else
            {
                con.Open();
                string update = "update Patient set Address = '" + PatAddTb.Text + "',Phone = '" + PatPhoneTb.Text + "',Dob='" + DOBTb.Value.ToShortDateString() + "',Gender = '" + GenCb.SelectedItem.ToString() + "' where Name = '" + PatNameTb.Text + "'";
                OleDbCommand cd = new OleDbCommand(update, con);
                cd.ExecuteNonQuery();
                con.Close();
                tablerefresh();
            }
        }
        private void Clear()
        {
            PatNameTb.Text = "";
            GenCb.SelectedIndex = -1;
            PatPhoneTb.Text = "";
            PatAddTb.Text = "";
        }

        private void DeleteBtn_Click(object sender, EventArgs e)
        {
            //if (Key ==0)
            //{
            //    MessageBox.Show("Missing Data");
            //}
            //else
            //{
            //    string Query = "Delete from PatientTb where PatCode='{0}'";
            //    Query = string.Format(Query, Key);
            //    Con.SetData(Query);
            //    ShowPatients();
            //    Clear();
            //    MessageBox.Show("Patient Deleted!!!");

            //}
            if (PatNameTb.Text == "") { }
            else
            {
                con.Open();
                string delete = "delete from Patient where Name = '" + PatNameTb.Text + "'";
                OleDbCommand cmd = new OleDbCommand(delete, con);
                cmd.ExecuteNonQuery();
                con.Close();
                tablerefresh();
                Clear();
            }
        }

        private void PatientList_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int index = e.RowIndex;
            DataGridViewRow selectedRow = PatientList.Rows[index];
            PatNameTb.Text = selectedRow.Cells[0].Value.ToString();
            PatAddTb.Text = selectedRow.Cells[1].Value.ToString();
            PatPhoneTb.Text = selectedRow.Cells[2].Value.ToString();
            //DOBTb.s = selectedRow.Cells[3].Value;
            GenCb.Text = selectedRow.Cells[4].Value.ToString();
           
        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {
            Diagnosis hi = new Diagnosis();
            hi.Show();
            Hide();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            Patients hi = new Patients();
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

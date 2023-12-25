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
    public partial class Login : Form
    {
        Class1 ab = new Class1 ();
        OleDbConnection con;
    //    Patients patient = null;
        public Login()
        {
            InitializeComponent();
            con = new OleDbConnection (ab.connection());
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void Login_Load(object sender, EventArgs e)
        {

        }

        private void LoginBtn_Click(object sender, EventArgs e)
        {
            //    if (loginValidate())
            //    {
            //        if (patient == null || patient.IsDisposed)
            //        {
            //            patient=new Patients();
            //        }
            //        this.Hide();
            //        patient.Show();
            //    }

            if (UnameTb.Text != "" && PasswordTb.Text != "")
            {
                con.Open();
                string c = "select * from Login where UserName='" + UnameTb.Text + "' and Pass='" + PasswordTb.Text + "'";
                OleDbDataAdapter da = new OleDbDataAdapter(c, con);
                DataTable dt = new DataTable();
                da.Fill(dt);
                if (dt.Rows.Count > 0)
                {
                   Patients op = new Patients();
                    op.Show();
                    Hide();
                }
                else
                {
                    UnameTb.Text = "";
                    PasswordTb.Text = "";
                }
            }
        }

        //public bool loginValidate()
        //{
        ////    if (UnameTb.Text == "Admin" && PasswordTb.Text == "Password")
        ////    {
        ////        return true;
        ////    }
        ////    return false;
        //}
        private void pictureBox1_Click(object sender, EventArgs e)
        {
            /*
             * Login Obj = new Login();
            Obj.Show();
            this.Hide();
            */
        }
    }
}

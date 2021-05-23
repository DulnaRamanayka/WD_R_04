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

namespace TimeTableM
{
    public partial class SessionDash : Form
    {
        MySqlConnection con = null;
        public SessionDash()
        {
            InitializeComponent();
            con = DBConnect.ConnectDB();
        }
        string timee;
        private void button1_Click(object sender, EventArgs e)
        {
            Home Home = new Home();
            Home.Show();
            this.Hide();
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            AddSession1 AddSession1 = new AddSession1();
            AddSession1.Show();
            this.Hide();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            ManageSession ManageSession = new ManageSession();
            ManageSession.Show();
            this.Hide();
        }

        private void btnViewCon_Click(object sender, EventArgs e)
        {
            con.Open();
            try
            {
                string qu = "SELECT `firstLec` as FIRSTLECTURE , `secondLec` as SECONDLECUTURE , `tag` as TAG , `tagType` as TAGTYPE , `grp` as STDGROUP , `subject` as SUBJECT , `noOfStd` as NUMOFSTD, `day` as DAY, `time` as TIME, `AllDetails` FROM `addsesstion`";
                MySqlCommand cm = new MySqlCommand(qu, con);
                MySqlDataAdapter da = new MySqlDataAdapter(cm);

                DataTable dt = new DataTable();
                da.Fill(dt);
                dgvConsec.DataSource = dt;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            con.Close();
        }

        private void btnPereral_Click(object sender, EventArgs e)
        {
            con.Open();
            try
            {
                string qu = "SELECT `department` as DEPARTMENT,`dep2` as SECONDDEPARTMENT, `OfferdYear` as OFFERDYEAR, `OfferedSem` as SEMSETER, `SubjectName` as SUBJECTNAME, `SubjectCode` as SUBCODE, `NoOfLecHours` as LECHOURS, `NoOfTuHours` as TUTEHOURS, `NoOfLabHours` as LABHOURS, `NoOfEveHours` as EVEHOURS FROM addsubject WHERE dep2 != '' AND department = '" + cmbDepartment.Text + "';";
                MySqlCommand cm = new MySqlCommand(qu, con);
                MySqlDataAdapter da = new MySqlDataAdapter(cm);

                DataTable dt = new DataTable();
                da.Fill(dt);
                dgvPereral.DataSource = dt;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            con.Close();
        }

        private void btnNonOver_Click(object sender, EventArgs e)
        {
            con.Open();
            try
            {
                string qu = "SELECT `department` as DEPARTMENT,`dep2` as SECONDDEPARTMENT, `OfferdYear` as OFFERDYEAR, `OfferedSem` as SEMSETER, `SubjectName` as SUBJECTNAME, `SubjectCode` as SUBCODE, `NoOfLecHours` as LECHOURS, `NoOfTuHours` as TUTEHOURS, `NoOfLabHours` as LABHOURS, `NoOfEveHours` as EVEHOURS FROM addsubject WHERE dep2 = '' AND department = '" + cmbDepartment.Text + "';";
                MySqlCommand cm = new MySqlCommand(qu, con);
                MySqlDataAdapter da = new MySqlDataAdapter(cm);

                DataTable dt = new DataTable();
                da.Fill(dt);
                dgvNonOverL.DataSource = dt;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            con.Close();
        }

        private void btnNotOverLappingTime_Click(object sender, EventArgs e)
        {

        }

        private void cmbFaculty_SelectedIndexChanged(object sender, EventArgs e)
        {
            string fac = this.cmbFaculty.SelectedItem.ToString();
            if (fac == "Computing")
            {
                cmbDepartment.Items.Add("Computer Science");
                cmbDepartment.Items.Add("Software engneering");
                cmbDepartment.Items.Add("Business studies and software engneering");
                cmbDepartment.Items.Add("Information systems");

            }
            else if (fac == "Engineering")
            {
                cmbDepartment.Items.Add("Civil Engneering");
                cmbDepartment.Items.Add("Electrical and electronic engneering");
                cmbDepartment.Items.Add("Megatronic engneering");

            }
            else if (fac == "Business")
            {
                cmbDepartment.Items.Add("Business studies and analysis");
                cmbDepartment.Items.Add("Business studies");

            }
            else if (fac == "Sciences")
            {
                cmbDepartment.Items.Add("Medicine");
                cmbDepartment.Items.Add("Vetnory");
                cmbDepartment.Items.Add("Dental Surgen");

            }
        }

        private void rbnMorning_CheckedChanged(object sender, EventArgs e)
        {
            timee = "8.00 AM to 12.00 PM";
        }

        private void rbnEvening_CheckedChanged(object sender, EventArgs e)
        {
            timee = "1.00 PM to 5.00 PM";
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
           
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
          
        }

        private void rbnMorLoc_CheckedChanged(object sender, EventArgs e)
        {
            timee = "8.00 AM to 12.00 PM";
        }

        private void rbnEveLoc_CheckedChanged(object sender, EventArgs e)
        {
            timee = "1.00 PM to 5.00 PM";
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            con.Open();
            try
            {
                string qu = "UPDATE `addsesstion` SET `room`= '" + cmbLocation.Text + "',`time`= '" + timee + "' WHERE day = '" + cmbDayLoc.Text + "' AND time = '" + timee + "'";
                MySqlCommand cm = new MySqlCommand(qu, con);
                cm.ExecuteNonQuery();
                MessageBox.Show("Update succesfully");

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            con.Close();
        }

        private void btnView_Click(object sender, EventArgs e)
        {
            con.Open();
            try
            {
                string qu = "SELECT `firstLec` as FIRSTLECTURE , `secondLec` as SECONDLECUTURE , `tag` as TAG , `tagType` as TAGTYPE , `grp` as STDGROUP , `subject` as SUBJECT , `noOfStd` as NUMOFSTD, `day` as DAY,`room` as ROOM, `time` as TIME, `AllDetails` FROM `addsesstion` WHERE day = '" + cmbDayLoc.Text + "' AND time = '" + timee + "'";
                MySqlCommand cm = new MySqlCommand(qu, con);
                MySqlDataAdapter da = new MySqlDataAdapter(cm);

                DataTable dt = new DataTable();
                da.Fill(dt);
                dgvAddLoc.DataSource = dt;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            con.Close();
        }

        private void cmbDepartment_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void button4_Click(object sender, EventArgs e)
        {
            NotAvailableTime NotAvailableTime = new NotAvailableTime();
            NotAvailableTime.Show();
            this.Hide();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            con.Open();
            try
            {
                string qu = "SELECT `Lname` as LECTURENAME , `Ngroup` as STUDENTGROUP , `Sugrop` as SUBGROUP ,`Lroom` as LECTUREHALL ,`time` as TIME ,`day` as DAY FROM `nottime`";
                MySqlCommand cm = new MySqlCommand(qu, con);
                MySqlDataAdapter da = new MySqlDataAdapter(cm);

                DataTable dt = new DataTable();
                da.Fill(dt);
                dgvNotAvaTime.DataSource = dt;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            con.Close();
        }
    }
}

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
    public partial class TimeTable : Form
    {
        MySqlConnection con = null;
        
        public TimeTable()
        {
            InitializeComponent();
            con = DBConnect.ConnectDB();
        }

        DataTable table = new DataTable();

        private void btnGenerate_Click(object sender, EventArgs e)
        {

            con.Open();
            try
            {
                string qu = "SELECT `day` as DAY, `room` as ROOM, `time` as TIME, `AllDetails` as DETAILS FROM `addsesstion` WHERE `grp` = '" + cmbGrp.Text + "'";
                MySqlCommand cm = new MySqlCommand(qu, con);
                MySqlDataAdapter da = new MySqlDataAdapter(cm);

                DataTable dt = new DataTable();
                da.Fill(dt);
                dgvStdTimetBL.DataSource = dt;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            con.Close();
        }

        private void TimeTable_Load(object sender, EventArgs e)
        {
           
        }

        private void btnHome_Click(object sender, EventArgs e)
        {
            Home Home = new Home();
            Home.Show();
            this.Hide();
        }

        private void cmbGrp_Click(object sender, EventArgs e)
        {
            con.Open();
            try
            {
                cmbGrp.Items.Clear();
                MySqlCommand cmd = con.CreateCommand();
                cmd.CommandType = CommandType.Text;
                cmd.CommandText = "SELECT GrpID FROM addstudentgrp";
                cmd.ExecuteNonQuery();
                DataTable dt = new DataTable();
                MySqlDataAdapter da = new MySqlDataAdapter(cmd);

                da.Fill(dt);
                foreach (DataRow dr in dt.Rows)
                {
                    cmbGrp.Items.Add(dr["GrpID"].ToString());
                }
            }

            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            con.Close();
        }

        private void btnLecGenerate_Click(object sender, EventArgs e)
        {
            con.Open();
            try
            {
                string qu = "SELECT `day` as DAY, `room` as ROOM, `time` as TIME, `AllDetails` as DETAILS FROM `addsesstion` WHERE `firstLec` = '" + cmb1Lec.Text + "' AND `secondLec` = '" + cmb2Lec.Text + "'";
                MySqlCommand cm = new MySqlCommand(qu, con);
                MySqlDataAdapter da = new MySqlDataAdapter(cm);

                DataTable dt = new DataTable();
                da.Fill(dt);
                dgvLec.DataSource = dt;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            con.Close();
        }

        private void cmb1Lec_Click(object sender, EventArgs e)
        {
            con.Open();
            try
            {
                cmb1Lec.Items.Clear();
                MySqlCommand cmd = con.CreateCommand();
                cmd.CommandType = CommandType.Text;
                cmd.CommandText = "SELECT LecName FROM addlecture";
                cmd.ExecuteNonQuery();
                DataTable dt = new DataTable();
                MySqlDataAdapter da = new MySqlDataAdapter(cmd);

                da.Fill(dt);
                foreach (DataRow dr in dt.Rows)
                {
                    cmb1Lec.Items.Add(dr["LecName"].ToString());
                }
            }

            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            con.Close();
        }

        private void cmb2Lec_Click(object sender, EventArgs e)
        {
            con.Open();
            try
            {
                cmb2Lec.Items.Clear();
                MySqlCommand cmd = con.CreateCommand();
                cmd.CommandType = CommandType.Text;
                cmd.CommandText = "SELECT LecName FROM addlecture";
                cmd.ExecuteNonQuery();
                DataTable dt = new DataTable();
                MySqlDataAdapter da = new MySqlDataAdapter(cmd);

                da.Fill(dt);
                foreach (DataRow dr in dt.Rows)
                {
                    cmb2Lec.Items.Add(dr["LecName"].ToString());
                }
            }

            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            con.Close();
        }

        private void cmbLocation_Click(object sender, EventArgs e)
        {
            con.Open();
            try
            {
                cmbLocation.Items.Clear();
                MySqlCommand cmd = con.CreateCommand();
                cmd.CommandType = CommandType.Text;
                cmd.CommandText = "SELECT room FROM addsesstion";
                cmd.ExecuteNonQuery();
                DataTable dt = new DataTable();
                MySqlDataAdapter da = new MySqlDataAdapter(cmd);

                da.Fill(dt);
                foreach (DataRow dr in dt.Rows)
                {
                    cmbLocation.Items.Add(dr["room"].ToString());
                }
            }

            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            con.Close();
        }

        private void btnLocGenerate_Click(object sender, EventArgs e)
        {
            con.Open();
            try
            {
                string qu = "SELECT `day` as DAY, `room` as ROOM, `time` as TIME, `AllDetails` as DETAILS FROM `addsesstion` WHERE `room` = '" + cmbLocation.Text + "'";
                MySqlCommand cm = new MySqlCommand(qu, con);
                MySqlDataAdapter da = new MySqlDataAdapter(cm);

                DataTable dt = new DataTable();
                da.Fill(dt);
                dgvLoc.DataSource = dt;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            con.Close();
        }
    }
}

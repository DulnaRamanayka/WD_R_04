namespace TimeTableM
{
    partial class TimeTable
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.Windows.Forms.Label label7;
            System.Windows.Forms.Label label4;
            System.Windows.Forms.Label label1;
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(TimeTable));
            this.btnGenerate = new System.Windows.Forms.Button();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.cmbGrp = new System.Windows.Forms.ComboBox();
            this.dgvStdTimetBL = new System.Windows.Forms.DataGridView();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.cmb2Lec = new System.Windows.Forms.ComboBox();
            this.cmb1Lec = new System.Windows.Forms.ComboBox();
            this.btnLecGenerate = new System.Windows.Forms.Button();
            this.dgvLec = new System.Windows.Forms.DataGridView();
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.cmbLocation = new System.Windows.Forms.ComboBox();
            this.btnLocGenerate = new System.Windows.Forms.Button();
            this.dgvLoc = new System.Windows.Forms.DataGridView();
            this.btnHome = new System.Windows.Forms.Button();
            label7 = new System.Windows.Forms.Label();
            label4 = new System.Windows.Forms.Label();
            label1 = new System.Windows.Forms.Label();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvStdTimetBL)).BeginInit();
            this.tabPage2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvLec)).BeginInit();
            this.tabPage3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvLoc)).BeginInit();
            this.SuspendLayout();
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new System.Drawing.Font("Microsoft YaHei", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            label7.ForeColor = System.Drawing.Color.Black;
            label7.Location = new System.Drawing.Point(161, 17);
            label7.Name = "label7";
            label7.Size = new System.Drawing.Size(168, 31);
            label7.TabIndex = 39;
            label7.Text = "Select Group";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new System.Drawing.Font("Microsoft YaHei", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            label4.ForeColor = System.Drawing.Color.Black;
            label4.Location = new System.Drawing.Point(37, 23);
            label4.Name = "label4";
            label4.Size = new System.Drawing.Size(193, 31);
            label4.TabIndex = 29;
            label4.Text = "Select Lectures";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new System.Drawing.Font("Microsoft YaHei", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            label1.ForeColor = System.Drawing.Color.Black;
            label1.Location = new System.Drawing.Point(273, 17);
            label1.Name = "label1";
            label1.Size = new System.Drawing.Size(196, 31);
            label1.TabIndex = 47;
            label1.Text = "Select Location";
            // 
            // btnGenerate
            // 
            this.btnGenerate.BackColor = System.Drawing.Color.Teal;
            this.btnGenerate.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnGenerate.ForeColor = System.Drawing.Color.White;
            this.btnGenerate.Location = new System.Drawing.Point(796, 7);
            this.btnGenerate.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnGenerate.Name = "btnGenerate";
            this.btnGenerate.Size = new System.Drawing.Size(209, 53);
            this.btnGenerate.TabIndex = 19;
            this.btnGenerate.Text = "Generate";
            this.btnGenerate.UseVisualStyleBackColor = false;
            this.btnGenerate.Click += new System.EventHandler(this.btnGenerate_Click);
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Controls.Add(this.tabPage3);
            this.tabControl1.Location = new System.Drawing.Point(59, 64);
            this.tabControl1.Margin = new System.Windows.Forms.Padding(4);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(1232, 651);
            this.tabControl1.TabIndex = 20;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.tableLayoutPanel1);
            this.tabPage1.Controls.Add(label7);
            this.tabPage1.Controls.Add(this.cmbGrp);
            this.tabPage1.Controls.Add(this.dgvStdTimetBL);
            this.tabPage1.Controls.Add(this.btnGenerate);
            this.tabPage1.Location = new System.Drawing.Point(4, 25);
            this.tabPage1.Margin = new System.Windows.Forms.Padding(4);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(4);
            this.tabPage1.Size = new System.Drawing.Size(1224, 622);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Student";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 8;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 12.50062F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 12.50062F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 12.50062F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 12.50062F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 12.50062F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 12.50062F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 12.50062F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 12.49562F));
            this.tableLayoutPanel1.Location = new System.Drawing.Point(49, 417);
            this.tableLayoutPanel1.Margin = new System.Windows.Forms.Padding(4);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 3;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(1136, 176);
            this.tableLayoutPanel1.TabIndex = 40;
            // 
            // cmbGrp
            // 
            this.cmbGrp.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbGrp.FormattingEnabled = true;
            this.cmbGrp.Location = new System.Drawing.Point(385, 17);
            this.cmbGrp.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.cmbGrp.Name = "cmbGrp";
            this.cmbGrp.Size = new System.Drawing.Size(349, 33);
            this.cmbGrp.TabIndex = 38;
            this.cmbGrp.Click += new System.EventHandler(this.cmbGrp_Click);
            // 
            // dgvStdTimetBL
            // 
            this.dgvStdTimetBL.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvStdTimetBL.Location = new System.Drawing.Point(49, 57);
            this.dgvStdTimetBL.Margin = new System.Windows.Forms.Padding(4);
            this.dgvStdTimetBL.Name = "dgvStdTimetBL";
            this.dgvStdTimetBL.Size = new System.Drawing.Size(1136, 353);
            this.dgvStdTimetBL.TabIndex = 20;
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.cmb2Lec);
            this.tabPage2.Controls.Add(this.cmb1Lec);
            this.tabPage2.Controls.Add(label4);
            this.tabPage2.Controls.Add(this.btnLecGenerate);
            this.tabPage2.Controls.Add(this.dgvLec);
            this.tabPage2.Location = new System.Drawing.Point(4, 25);
            this.tabPage2.Margin = new System.Windows.Forms.Padding(4);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(4);
            this.tabPage2.Size = new System.Drawing.Size(1224, 622);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Lecture";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // cmb2Lec
            // 
            this.cmb2Lec.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmb2Lec.FormattingEnabled = true;
            this.cmb2Lec.Location = new System.Drawing.Point(604, 23);
            this.cmb2Lec.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.cmb2Lec.Name = "cmb2Lec";
            this.cmb2Lec.Size = new System.Drawing.Size(349, 33);
            this.cmb2Lec.TabIndex = 45;
            this.cmb2Lec.Click += new System.EventHandler(this.cmb2Lec_Click);
            // 
            // cmb1Lec
            // 
            this.cmb1Lec.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmb1Lec.FormattingEnabled = true;
            this.cmb1Lec.Location = new System.Drawing.Point(248, 23);
            this.cmb1Lec.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.cmb1Lec.Name = "cmb1Lec";
            this.cmb1Lec.Size = new System.Drawing.Size(349, 33);
            this.cmb1Lec.TabIndex = 30;
            this.cmb1Lec.Click += new System.EventHandler(this.cmb1Lec_Click);
            // 
            // btnLecGenerate
            // 
            this.btnLecGenerate.BackColor = System.Drawing.Color.Teal;
            this.btnLecGenerate.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLecGenerate.ForeColor = System.Drawing.Color.White;
            this.btnLecGenerate.Location = new System.Drawing.Point(969, 14);
            this.btnLecGenerate.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnLecGenerate.Name = "btnLecGenerate";
            this.btnLecGenerate.Size = new System.Drawing.Size(209, 53);
            this.btnLecGenerate.TabIndex = 22;
            this.btnLecGenerate.Text = "Generate";
            this.btnLecGenerate.UseVisualStyleBackColor = false;
            this.btnLecGenerate.Click += new System.EventHandler(this.btnLecGenerate_Click);
            // 
            // dgvLec
            // 
            this.dgvLec.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvLec.Location = new System.Drawing.Point(43, 73);
            this.dgvLec.Margin = new System.Windows.Forms.Padding(4);
            this.dgvLec.Name = "dgvLec";
            this.dgvLec.Size = new System.Drawing.Size(1136, 322);
            this.dgvLec.TabIndex = 21;
            // 
            // tabPage3
            // 
            this.tabPage3.Controls.Add(label1);
            this.tabPage3.Controls.Add(this.cmbLocation);
            this.tabPage3.Controls.Add(this.btnLocGenerate);
            this.tabPage3.Controls.Add(this.dgvLoc);
            this.tabPage3.Location = new System.Drawing.Point(4, 25);
            this.tabPage3.Margin = new System.Windows.Forms.Padding(4);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Size = new System.Drawing.Size(1224, 622);
            this.tabPage3.TabIndex = 2;
            this.tabPage3.Text = "Location";
            this.tabPage3.UseVisualStyleBackColor = true;
            // 
            // cmbLocation
            // 
            this.cmbLocation.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbLocation.FormattingEnabled = true;
            this.cmbLocation.Location = new System.Drawing.Point(519, 17);
            this.cmbLocation.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.cmbLocation.Name = "cmbLocation";
            this.cmbLocation.Size = new System.Drawing.Size(349, 33);
            this.cmbLocation.TabIndex = 46;
            this.cmbLocation.Click += new System.EventHandler(this.cmbLocation_Click);
            // 
            // btnLocGenerate
            // 
            this.btnLocGenerate.BackColor = System.Drawing.Color.Teal;
            this.btnLocGenerate.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLocGenerate.ForeColor = System.Drawing.Color.White;
            this.btnLocGenerate.Location = new System.Drawing.Point(965, 7);
            this.btnLocGenerate.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnLocGenerate.Name = "btnLocGenerate";
            this.btnLocGenerate.Size = new System.Drawing.Size(209, 53);
            this.btnLocGenerate.TabIndex = 23;
            this.btnLocGenerate.Text = "Generate";
            this.btnLocGenerate.UseVisualStyleBackColor = false;
            this.btnLocGenerate.Click += new System.EventHandler(this.btnLocGenerate_Click);
            // 
            // dgvLoc
            // 
            this.dgvLoc.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvLoc.Location = new System.Drawing.Point(39, 66);
            this.dgvLoc.Margin = new System.Windows.Forms.Padding(4);
            this.dgvLoc.Name = "dgvLoc";
            this.dgvLoc.Size = new System.Drawing.Size(1136, 343);
            this.dgvLoc.TabIndex = 22;
            // 
            // btnHome
            // 
            this.btnHome.BackColor = System.Drawing.Color.Red;
            this.btnHome.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnHome.ForeColor = System.Drawing.Color.White;
            this.btnHome.Location = new System.Drawing.Point(1147, 14);
            this.btnHome.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnHome.Name = "btnHome";
            this.btnHome.Size = new System.Drawing.Size(139, 53);
            this.btnHome.TabIndex = 21;
            this.btnHome.Text = "HOME";
            this.btnHome.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.btnHome.UseVisualStyleBackColor = false;
            this.btnHome.Click += new System.EventHandler(this.btnHome_Click);
            // 
            // TimeTable
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.ClientSize = new System.Drawing.Size(1363, 718);
            this.Controls.Add(this.tabControl1);
            this.Controls.Add(this.btnHome);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "TimeTable";
            this.Text = "Time Table";
            this.Load += new System.EventHandler(this.TimeTable_Load);
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvStdTimetBL)).EndInit();
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvLec)).EndInit();
            this.tabPage3.ResumeLayout(false);
            this.tabPage3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvLoc)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnGenerate;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.DataGridView dgvStdTimetBL;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.TabPage tabPage3;
        private System.Windows.Forms.Button btnHome;
        private System.Windows.Forms.DataGridView dgvLec;
        private System.Windows.Forms.ComboBox cmbGrp;
        private System.Windows.Forms.Button btnLecGenerate;
        private System.Windows.Forms.ComboBox cmb1Lec;
        private System.Windows.Forms.ComboBox cmb2Lec;
        private System.Windows.Forms.Button btnLocGenerate;
        private System.Windows.Forms.DataGridView dgvLoc;
        private System.Windows.Forms.ComboBox cmbLocation;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
    }
}
namespace HealthCareTuto
{
    partial class Diagnosis
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
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Diagnosis));
            this.SaveBtn = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.EditBtn = new System.Windows.Forms.Button();
            this.DeleteBtn = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.DiagDateTb = new Guna.UI2.WinForms.Guna2DateTimePicker();
            this.TestCb = new System.Windows.Forms.ComboBox();
            this.PatientCb = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.ResultTb = new System.Windows.Forms.TextBox();
            this.CostTb = new System.Windows.Forms.TextBox();
            this.Cost = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.DiagnosisList = new Guna.UI2.WinForms.Guna2DataGridView();
            this.healthCareDBDataSet2BindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.healthCareDBDataSet2 = new WindowsFormsApp1.HealthCareDBDataSet2();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Dglist = new Guna.UI2.WinForms.Guna2DataGridView();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.panel2 = new System.Windows.Forms.Panel();
            this.pictureBox4 = new System.Windows.Forms.PictureBox();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.groupBox1.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DiagnosisList)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.healthCareDBDataSet2BindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.healthCareDBDataSet2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Dglist)).BeginInit();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // SaveBtn
            // 
            this.SaveBtn.BackColor = System.Drawing.Color.MediumTurquoise;
            this.SaveBtn.Location = new System.Drawing.Point(758, 37);
            this.SaveBtn.Name = "SaveBtn";
            this.SaveBtn.Size = new System.Drawing.Size(199, 50);
            this.SaveBtn.TabIndex = 15;
            this.SaveBtn.Text = "Save";
            this.SaveBtn.UseVisualStyleBackColor = false;
            this.SaveBtn.Click += new System.EventHandler(this.SaveBtn_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(6, 37);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(137, 25);
            this.label2.TabIndex = 17;
            this.label2.Text = "Student Name";
            // 
            // EditBtn
            // 
            this.EditBtn.BackColor = System.Drawing.Color.MediumTurquoise;
            this.EditBtn.Location = new System.Drawing.Point(758, 93);
            this.EditBtn.Name = "EditBtn";
            this.EditBtn.Size = new System.Drawing.Size(199, 50);
            this.EditBtn.TabIndex = 14;
            this.EditBtn.Text = "Edit";
            this.EditBtn.UseVisualStyleBackColor = false;
            this.EditBtn.Click += new System.EventHandler(this.EditBtn_Click);
            // 
            // DeleteBtn
            // 
            this.DeleteBtn.BackColor = System.Drawing.Color.MediumTurquoise;
            this.DeleteBtn.Location = new System.Drawing.Point(758, 149);
            this.DeleteBtn.Name = "DeleteBtn";
            this.DeleteBtn.Size = new System.Drawing.Size(199, 50);
            this.DeleteBtn.TabIndex = 16;
            this.DeleteBtn.Text = "Delete";
            this.DeleteBtn.UseVisualStyleBackColor = false;
            this.DeleteBtn.Click += new System.EventHandler(this.DeleteBtn_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.Azure;
            this.groupBox1.Controls.Add(this.DiagDateTb);
            this.groupBox1.Controls.Add(this.TestCb);
            this.groupBox1.Controls.Add(this.PatientCb);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.ResultTb);
            this.groupBox1.Controls.Add(this.CostTb);
            this.groupBox1.Controls.Add(this.Cost);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.SaveBtn);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.EditBtn);
            this.groupBox1.Controls.Add(this.DeleteBtn);
            this.groupBox1.Location = new System.Drawing.Point(138, 30);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(984, 277);
            this.groupBox1.TabIndex = 21;
            this.groupBox1.TabStop = false;
            this.groupBox1.Enter += new System.EventHandler(this.groupBox1_Enter);
            // 
            // DiagDateTb
            // 
            this.DiagDateTb.Checked = true;
            this.DiagDateTb.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.DiagDateTb.Format = System.Windows.Forms.DateTimePickerFormat.Long;
            this.DiagDateTb.Location = new System.Drawing.Point(347, 149);
            this.DiagDateTb.MaxDate = new System.DateTime(9998, 12, 31, 0, 0, 0, 0);
            this.DiagDateTb.MinDate = new System.DateTime(1753, 1, 1, 0, 0, 0, 0);
            this.DiagDateTb.Name = "DiagDateTb";
            this.DiagDateTb.Size = new System.Drawing.Size(247, 36);
            this.DiagDateTb.TabIndex = 30;
            this.DiagDateTb.Value = new System.DateTime(2023, 12, 24, 20, 32, 8, 71);
            // 
            // TestCb
            // 
            this.TestCb.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TestCb.FormattingEnabled = true;
            this.TestCb.Location = new System.Drawing.Point(11, 140);
            this.TestCb.Name = "TestCb";
            this.TestCb.Size = new System.Drawing.Size(229, 33);
            this.TestCb.TabIndex = 29;
            this.TestCb.SelectedIndexChanged += new System.EventHandler(this.comboBox2_SelectedIndexChanged);
            this.TestCb.SelectionChangeCommitted += new System.EventHandler(this.TestCb_SelectionChangeCommitted);
            this.TestCb.TextChanged += new System.EventHandler(this.TestCb_TextChanged);
            // 
            // PatientCb
            // 
            this.PatientCb.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PatientCb.FormattingEnabled = true;
            this.PatientCb.Location = new System.Drawing.Point(9, 70);
            this.PatientCb.Name = "PatientCb";
            this.PatientCb.Size = new System.Drawing.Size(229, 33);
            this.PatientCb.TabIndex = 28;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(344, 109);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(144, 25);
            this.label5.TabIndex = 25;
            this.label5.Text = "Diagnosis Date";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(344, 37);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(66, 25);
            this.label4.TabIndex = 23;
            this.label4.Text = "Result";
            // 
            // ResultTb
            // 
            this.ResultTb.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ResultTb.Location = new System.Drawing.Point(347, 70);
            this.ResultTb.Name = "ResultTb";
            this.ResultTb.Size = new System.Drawing.Size(271, 30);
            this.ResultTb.TabIndex = 24;
            // 
            // CostTb
            // 
            this.CostTb.Enabled = false;
            this.CostTb.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CostTb.Location = new System.Drawing.Point(13, 220);
            this.CostTb.Name = "CostTb";
            this.CostTb.Size = new System.Drawing.Size(201, 30);
            this.CostTb.TabIndex = 22;
            // 
            // Cost
            // 
            this.Cost.AutoSize = true;
            this.Cost.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Cost.Location = new System.Drawing.Point(8, 183);
            this.Cost.Name = "Cost";
            this.Cost.Size = new System.Drawing.Size(53, 25);
            this.Cost.TabIndex = 21;
            this.Cost.Text = "Cost";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(6, 109);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(51, 25);
            this.label1.TabIndex = 19;
            this.label1.Text = "Test";
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.Dglist);
            this.panel1.Controls.Add(this.DiagnosisList);
            this.panel1.Location = new System.Drawing.Point(147, 351);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(975, 327);
            this.panel1.TabIndex = 22;
            // 
            // DiagnosisList
            // 
            dataGridViewCellStyle4.BackColor = System.Drawing.Color.White;
            this.DiagnosisList.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle4;
            this.DiagnosisList.AutoGenerateColumns = false;
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle5.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle5.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle5.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle5.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.DiagnosisList.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle5;
            this.DiagnosisList.ColumnHeadersHeight = 4;
            this.DiagnosisList.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            this.DiagnosisList.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.Column2,
            this.Column3,
            this.Column4,
            this.Column5});
            this.DiagnosisList.DataSource = this.healthCareDBDataSet2BindingSource;
            dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle6.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle6.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle6.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle6.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle6.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle6.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.DiagnosisList.DefaultCellStyle = dataGridViewCellStyle6;
            this.DiagnosisList.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.DiagnosisList.Location = new System.Drawing.Point(45, 34);
            this.DiagnosisList.Name = "DiagnosisList";
            this.DiagnosisList.RowHeadersVisible = false;
            this.DiagnosisList.RowHeadersWidth = 51;
            this.DiagnosisList.RowTemplate.Height = 24;
            this.DiagnosisList.Size = new System.Drawing.Size(903, 250);
            this.DiagnosisList.TabIndex = 1;
            this.DiagnosisList.ThemeStyle.AlternatingRowsStyle.BackColor = System.Drawing.Color.White;
            this.DiagnosisList.ThemeStyle.AlternatingRowsStyle.Font = null;
            this.DiagnosisList.ThemeStyle.AlternatingRowsStyle.ForeColor = System.Drawing.Color.Empty;
            this.DiagnosisList.ThemeStyle.AlternatingRowsStyle.SelectionBackColor = System.Drawing.Color.Empty;
            this.DiagnosisList.ThemeStyle.AlternatingRowsStyle.SelectionForeColor = System.Drawing.Color.Empty;
            this.DiagnosisList.ThemeStyle.BackColor = System.Drawing.Color.White;
            this.DiagnosisList.ThemeStyle.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.DiagnosisList.ThemeStyle.HeaderStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.DiagnosisList.ThemeStyle.HeaderStyle.BorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.DiagnosisList.ThemeStyle.HeaderStyle.Font = new System.Drawing.Font("Segoe UI", 10.5F);
            this.DiagnosisList.ThemeStyle.HeaderStyle.ForeColor = System.Drawing.Color.White;
            this.DiagnosisList.ThemeStyle.HeaderStyle.HeaightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            this.DiagnosisList.ThemeStyle.HeaderStyle.Height = 4;
            this.DiagnosisList.ThemeStyle.ReadOnly = false;
            this.DiagnosisList.ThemeStyle.RowsStyle.BackColor = System.Drawing.Color.White;
            this.DiagnosisList.ThemeStyle.RowsStyle.BorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.DiagnosisList.ThemeStyle.RowsStyle.Font = new System.Drawing.Font("Segoe UI", 10.5F);
            this.DiagnosisList.ThemeStyle.RowsStyle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            this.DiagnosisList.ThemeStyle.RowsStyle.Height = 24;
            this.DiagnosisList.ThemeStyle.RowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.DiagnosisList.ThemeStyle.RowsStyle.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            this.DiagnosisList.Visible = false;
            this.DiagnosisList.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DiagnosisList_CellContentClick);
            // 
            // healthCareDBDataSet2BindingSource
            // 
            this.healthCareDBDataSet2BindingSource.DataSource = this.healthCareDBDataSet2;
            this.healthCareDBDataSet2BindingSource.Position = 0;
            // 
            // healthCareDBDataSet2
            // 
            this.healthCareDBDataSet2.DataSetName = "HealthCareDBDataSet2";
            this.healthCareDBDataSet2.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // Column1
            // 
            this.Column1.HeaderText = "Patient_Name";
            this.Column1.MinimumWidth = 6;
            this.Column1.Name = "Column1";
            // 
            // Column2
            // 
            this.Column2.HeaderText = "Test_Name";
            this.Column2.MinimumWidth = 6;
            this.Column2.Name = "Column2";
            // 
            // Column3
            // 
            this.Column3.HeaderText = "Cost";
            this.Column3.MinimumWidth = 6;
            this.Column3.Name = "Column3";
            // 
            // Column4
            // 
            this.Column4.HeaderText = "Result";
            this.Column4.MinimumWidth = 6;
            this.Column4.Name = "Column4";
            // 
            // Column5
            // 
            this.Column5.HeaderText = "Date";
            this.Column5.MinimumWidth = 6;
            this.Column5.Name = "Column5";
            // 
            // Dglist
            // 
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.White;
            this.Dglist.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.Dglist.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.Dglist.ColumnHeadersHeight = 35;
            this.Dglist.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            this.Dglist.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn2,
            this.dataGridViewTextBoxColumn3,
            this.dataGridViewTextBoxColumn4,
            this.dataGridViewTextBoxColumn5});
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.Dglist.DefaultCellStyle = dataGridViewCellStyle3;
            this.Dglist.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.Dglist.Location = new System.Drawing.Point(43, 34);
            this.Dglist.Name = "Dglist";
            this.Dglist.RowHeadersVisible = false;
            this.Dglist.RowHeadersWidth = 51;
            this.Dglist.RowTemplate.Height = 24;
            this.Dglist.Size = new System.Drawing.Size(905, 250);
            this.Dglist.TabIndex = 31;
            this.Dglist.ThemeStyle.AlternatingRowsStyle.BackColor = System.Drawing.Color.White;
            this.Dglist.ThemeStyle.AlternatingRowsStyle.Font = null;
            this.Dglist.ThemeStyle.AlternatingRowsStyle.ForeColor = System.Drawing.Color.Empty;
            this.Dglist.ThemeStyle.AlternatingRowsStyle.SelectionBackColor = System.Drawing.Color.Empty;
            this.Dglist.ThemeStyle.AlternatingRowsStyle.SelectionForeColor = System.Drawing.Color.Empty;
            this.Dglist.ThemeStyle.BackColor = System.Drawing.Color.White;
            this.Dglist.ThemeStyle.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.Dglist.ThemeStyle.HeaderStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.Dglist.ThemeStyle.HeaderStyle.BorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.Dglist.ThemeStyle.HeaderStyle.Font = new System.Drawing.Font("Segoe UI", 10.5F);
            this.Dglist.ThemeStyle.HeaderStyle.ForeColor = System.Drawing.Color.White;
            this.Dglist.ThemeStyle.HeaderStyle.HeaightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            this.Dglist.ThemeStyle.HeaderStyle.Height = 35;
            this.Dglist.ThemeStyle.ReadOnly = false;
            this.Dglist.ThemeStyle.RowsStyle.BackColor = System.Drawing.Color.White;
            this.Dglist.ThemeStyle.RowsStyle.BorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.Dglist.ThemeStyle.RowsStyle.Font = new System.Drawing.Font("Segoe UI", 10.5F);
            this.Dglist.ThemeStyle.RowsStyle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            this.Dglist.ThemeStyle.RowsStyle.Height = 24;
            this.Dglist.ThemeStyle.RowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.Dglist.ThemeStyle.RowsStyle.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            this.Dglist.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.Dglist_CellClick);
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.HeaderText = "Name";
            this.dataGridViewTextBoxColumn1.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.HeaderText = "Test_Name";
            this.dataGridViewTextBoxColumn2.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.HeaderText = "Cost";
            this.dataGridViewTextBoxColumn3.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            // 
            // dataGridViewTextBoxColumn4
            // 
            this.dataGridViewTextBoxColumn4.HeaderText = "Result";
            this.dataGridViewTextBoxColumn4.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
            // 
            // dataGridViewTextBoxColumn5
            // 
            this.dataGridViewTextBoxColumn5.HeaderText = "Date";
            this.dataGridViewTextBoxColumn5.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn5.Name = "dataGridViewTextBoxColumn5";
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.pictureBox4);
            this.panel2.Controls.Add(this.pictureBox3);
            this.panel2.Controls.Add(this.pictureBox2);
            this.panel2.Controls.Add(this.pictureBox1);
            this.panel2.Location = new System.Drawing.Point(12, 30);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(102, 472);
            this.panel2.TabIndex = 23;
            // 
            // pictureBox4
            // 
            this.pictureBox4.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox4.Image")));
            this.pictureBox4.Location = new System.Drawing.Point(18, 371);
            this.pictureBox4.Name = "pictureBox4";
            this.pictureBox4.Size = new System.Drawing.Size(70, 72);
            this.pictureBox4.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox4.TabIndex = 3;
            this.pictureBox4.TabStop = false;
            this.pictureBox4.Click += new System.EventHandler(this.pictureBox4_Click);
            // 
            // pictureBox3
            // 
            this.pictureBox3.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox3.Image")));
            this.pictureBox3.Location = new System.Drawing.Point(18, 254);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(70, 72);
            this.pictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox3.TabIndex = 2;
            this.pictureBox3.TabStop = false;
            this.pictureBox3.Click += new System.EventHandler(this.pictureBox3_Click);
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
            this.pictureBox2.Location = new System.Drawing.Point(18, 140);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(62, 63);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox2.TabIndex = 1;
            this.pictureBox2.TabStop = false;
            this.pictureBox2.Click += new System.EventHandler(this.pictureBox2_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(18, 31);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(62, 63);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // Diagnosis
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Azure;
            this.ClientSize = new System.Drawing.Size(1146, 675);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.groupBox1);
            this.Name = "Diagnosis";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Diagnosis";
            this.Load += new System.EventHandler(this.Diagnosis_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.DiagnosisList)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.healthCareDBDataSet2BindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.healthCareDBDataSet2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Dglist)).EndInit();
            this.panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button SaveBtn;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button EditBtn;
        private System.Windows.Forms.Button DeleteBtn;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox ResultTb;
        private System.Windows.Forms.TextBox CostTb;
        private System.Windows.Forms.Label Cost;
        private System.Windows.Forms.ComboBox TestCb;
        private System.Windows.Forms.ComboBox PatientCb;
        private Guna.UI2.WinForms.Guna2DateTimePicker DiagDateTb;
        private System.Windows.Forms.Panel panel1;
        private Guna.UI2.WinForms.Guna2DataGridView DiagnosisList;
        private System.Windows.Forms.BindingSource healthCareDBDataSet2BindingSource;
        private WindowsFormsApp1.HealthCareDBDataSet2 healthCareDBDataSet2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column4;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column5;
        private Guna.UI2.WinForms.Guna2DataGridView Dglist;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn5;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.PictureBox pictureBox4;
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}
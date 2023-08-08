
namespace QLPhongKhamTuNhan
{
    partial class Patient
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Patient));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            this.LogOut = new System.Windows.Forms.Label();
            this.RegPage = new System.Windows.Forms.Label();
            this.PillsPage = new System.Windows.Forms.Label();
            this.StaffPage = new System.Windows.Forms.Label();
            this.PatientPage = new System.Windows.Forms.Label();
            this.Close = new System.Windows.Forms.PictureBox();
            this.HomePage = new System.Windows.Forms.PictureBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.pictureBox4 = new System.Windows.Forms.PictureBox();
            this.PatientName = new System.Windows.Forms.TextBox();
            this.PatientGen = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.PatientDOB = new Bunifu.Framework.UI.BunifuDatepicker();
            this.label1 = new System.Windows.Forms.Label();
            this.PatientAddress = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.PatientPhone = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.PatientEmail = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.AddButton = new Bunifu.Framework.UI.BunifuThinButton2();
            this.DeleteButton = new Bunifu.Framework.UI.BunifuThinButton2();
            this.EditButton = new Bunifu.Framework.UI.BunifuThinButton2();
            this.ListPatient = new Guna.UI.WinForms.GunaDataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.Close)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.HomePage)).BeginInit();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ListPatient)).BeginInit();
            this.SuspendLayout();
            // 
            // LogOut
            // 
            this.LogOut.AutoSize = true;
            this.LogOut.BackColor = System.Drawing.SystemColors.Control;
            this.LogOut.Font = new System.Drawing.Font("Times New Roman", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LogOut.ForeColor = System.Drawing.SystemColors.Desktop;
            this.LogOut.Location = new System.Drawing.Point(1100, 22);
            this.LogOut.Name = "LogOut";
            this.LogOut.Size = new System.Drawing.Size(92, 31);
            this.LogOut.TabIndex = 8;
            this.LogOut.Text = "Logout";
            this.LogOut.Click += new System.EventHandler(this.LogOut_Click);
            // 
            // RegPage
            // 
            this.RegPage.AutoSize = true;
            this.RegPage.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.RegPage.Font = new System.Drawing.Font("Times New Roman", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.RegPage.ForeColor = System.Drawing.SystemColors.Control;
            this.RegPage.Location = new System.Drawing.Point(610, 34);
            this.RegPage.Name = "RegPage";
            this.RegPage.Size = new System.Drawing.Size(198, 31);
            this.RegPage.TabIndex = 5;
            this.RegPage.Text = "Medical Register";
            this.RegPage.Click += new System.EventHandler(this.RegPage_Click);
            // 
            // PillsPage
            // 
            this.PillsPage.AutoSize = true;
            this.PillsPage.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.PillsPage.Font = new System.Drawing.Font("Times New Roman", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PillsPage.ForeColor = System.Drawing.SystemColors.Control;
            this.PillsPage.Location = new System.Drawing.Point(437, 34);
            this.PillsPage.Name = "PillsPage";
            this.PillsPage.Size = new System.Drawing.Size(139, 31);
            this.PillsPage.TabIndex = 5;
            this.PillsPage.Text = "List of Pills";
            this.PillsPage.Click += new System.EventHandler(this.PillsPage_Click);
            // 
            // StaffPage
            // 
            this.StaffPage.AutoSize = true;
            this.StaffPage.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.StaffPage.Font = new System.Drawing.Font("Times New Roman", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.StaffPage.ForeColor = System.Drawing.SystemColors.Control;
            this.StaffPage.Location = new System.Drawing.Point(332, 34);
            this.StaffPage.Name = "StaffPage";
            this.StaffPage.Size = new System.Drawing.Size(65, 31);
            this.StaffPage.TabIndex = 5;
            this.StaffPage.Text = "Staff";
            this.StaffPage.Click += new System.EventHandler(this.StaffPage_Click);
            // 
            // PatientPage
            // 
            this.PatientPage.AutoSize = true;
            this.PatientPage.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.PatientPage.Font = new System.Drawing.Font("Times New Roman", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PatientPage.ForeColor = System.Drawing.SystemColors.Control;
            this.PatientPage.Location = new System.Drawing.Point(190, 34);
            this.PatientPage.Name = "PatientPage";
            this.PatientPage.Size = new System.Drawing.Size(100, 31);
            this.PatientPage.TabIndex = 4;
            this.PatientPage.Text = "Patients";
            // 
            // Close
            // 
            this.Close.Image = ((System.Drawing.Image)(resources.GetObject("Close.Image")));
            this.Close.Location = new System.Drawing.Point(1270, 0);
            this.Close.Name = "Close";
            this.Close.Size = new System.Drawing.Size(53, 50);
            this.Close.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.Close.TabIndex = 1;
            this.Close.TabStop = false;
            this.Close.Click += new System.EventHandler(this.Close_Click);
            // 
            // HomePage
            // 
            this.HomePage.Image = ((System.Drawing.Image)(resources.GetObject("HomePage.Image")));
            this.HomePage.Location = new System.Drawing.Point(0, 0);
            this.HomePage.Name = "HomePage";
            this.HomePage.Size = new System.Drawing.Size(154, 100);
            this.HomePage.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.HomePage.TabIndex = 1;
            this.HomePage.TabStop = false;
            this.HomePage.Click += new System.EventHandler(this.HomePage_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.panel1.Controls.Add(this.LogOut);
            this.panel1.Controls.Add(this.pictureBox4);
            this.panel1.Controls.Add(this.RegPage);
            this.panel1.Controls.Add(this.PillsPage);
            this.panel1.Controls.Add(this.StaffPage);
            this.panel1.Controls.Add(this.PatientPage);
            this.panel1.Controls.Add(this.Close);
            this.panel1.Controls.Add(this.HomePage);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1323, 100);
            this.panel1.TabIndex = 3;
            // 
            // pictureBox4
            // 
            this.pictureBox4.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox4.Image")));
            this.pictureBox4.Location = new System.Drawing.Point(1038, 15);
            this.pictureBox4.Name = "pictureBox4";
            this.pictureBox4.Size = new System.Drawing.Size(56, 50);
            this.pictureBox4.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox4.TabIndex = 7;
            this.pictureBox4.TabStop = false;
            // 
            // PatientName
            // 
            this.PatientName.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PatientName.Location = new System.Drawing.Point(79, 179);
            this.PatientName.Name = "PatientName";
            this.PatientName.Size = new System.Drawing.Size(121, 29);
            this.PatientName.TabIndex = 11;
            // 
            // PatientGen
            // 
            this.PatientGen.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PatientGen.FormattingEnabled = true;
            this.PatientGen.Items.AddRange(new object[] {
            "Male",
            "Female"});
            this.PatientGen.Location = new System.Drawing.Point(853, 179);
            this.PatientGen.Name = "PatientGen";
            this.PatientGen.Size = new System.Drawing.Size(107, 29);
            this.PatientGen.TabIndex = 10;
            this.PatientGen.Text = "Gender";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.SystemColors.Control;
            this.label2.Font = new System.Drawing.Font("Times New Roman", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.SystemColors.Highlight;
            this.label2.Location = new System.Drawing.Point(73, 132);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(160, 31);
            this.label2.TabIndex = 9;
            this.label2.Text = "Patient Name";
            // 
            // PatientDOB
            // 
            this.PatientDOB.BackColor = System.Drawing.Color.SeaGreen;
            this.PatientDOB.BorderRadius = 0;
            this.PatientDOB.ForeColor = System.Drawing.Color.White;
            this.PatientDOB.Format = System.Windows.Forms.DateTimePickerFormat.Long;
            this.PatientDOB.FormatCustom = null;
            this.PatientDOB.Location = new System.Drawing.Point(253, 172);
            this.PatientDOB.Name = "PatientDOB";
            this.PatientDOB.Size = new System.Drawing.Size(225, 36);
            this.PatientDOB.TabIndex = 12;
            this.PatientDOB.Value = new System.DateTime(2023, 7, 20, 10, 3, 34, 45);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.SystemColors.Control;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.Highlight;
            this.label1.Location = new System.Drawing.Point(257, 132);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(157, 31);
            this.label1.TabIndex = 13;
            this.label1.Text = "Date of Birth";
            // 
            // PatientAddress
            // 
            this.PatientAddress.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PatientAddress.Location = new System.Drawing.Point(1010, 179);
            this.PatientAddress.Multiline = true;
            this.PatientAddress.Name = "PatientAddress";
            this.PatientAddress.Size = new System.Drawing.Size(167, 113);
            this.PatientAddress.TabIndex = 15;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.SystemColors.Control;
            this.label3.Font = new System.Drawing.Font("Times New Roman", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.SystemColors.Highlight;
            this.label3.Location = new System.Drawing.Point(1004, 132);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(102, 31);
            this.label3.TabIndex = 14;
            this.label3.Text = "Address";
            // 
            // PatientPhone
            // 
            this.PatientPhone.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PatientPhone.Location = new System.Drawing.Point(553, 179);
            this.PatientPhone.Name = "PatientPhone";
            this.PatientPhone.Size = new System.Drawing.Size(121, 29);
            this.PatientPhone.TabIndex = 17;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.SystemColors.Control;
            this.label4.Font = new System.Drawing.Font("Times New Roman", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.SystemColors.Highlight;
            this.label4.Location = new System.Drawing.Point(547, 132);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(83, 31);
            this.label4.TabIndex = 16;
            this.label4.Text = "Phone";
            // 
            // PatientEmail
            // 
            this.PatientEmail.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PatientEmail.Location = new System.Drawing.Point(709, 179);
            this.PatientEmail.Name = "PatientEmail";
            this.PatientEmail.Size = new System.Drawing.Size(121, 29);
            this.PatientEmail.TabIndex = 19;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.SystemColors.Control;
            this.label5.Font = new System.Drawing.Font("Times New Roman", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.SystemColors.Highlight;
            this.label5.Location = new System.Drawing.Point(703, 132);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(78, 31);
            this.label5.TabIndex = 18;
            this.label5.Text = "Email";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.BackColor = System.Drawing.SystemColors.Control;
            this.label12.Font = new System.Drawing.Font("Times New Roman", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.ForeColor = System.Drawing.SystemColors.Highlight;
            this.label12.Location = new System.Drawing.Point(847, 132);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(94, 31);
            this.label12.TabIndex = 20;
            this.label12.Text = "Gender";
            // 
            // AddButton
            // 
            this.AddButton.ActiveBorderThickness = 1;
            this.AddButton.ActiveCornerRadius = 20;
            this.AddButton.ActiveFillColor = System.Drawing.Color.SeaGreen;
            this.AddButton.ActiveForecolor = System.Drawing.Color.White;
            this.AddButton.ActiveLineColor = System.Drawing.Color.Gray;
            this.AddButton.BackColor = System.Drawing.SystemColors.Control;
            this.AddButton.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("AddButton.BackgroundImage")));
            this.AddButton.ButtonText = "Add";
            this.AddButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.AddButton.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AddButton.ForeColor = System.Drawing.Color.SeaGreen;
            this.AddButton.IdleBorderThickness = 1;
            this.AddButton.IdleCornerRadius = 20;
            this.AddButton.IdleFillColor = System.Drawing.Color.DeepSkyBlue;
            this.AddButton.IdleForecolor = System.Drawing.Color.GhostWhite;
            this.AddButton.IdleLineColor = System.Drawing.Color.SeaGreen;
            this.AddButton.Location = new System.Drawing.Point(79, 234);
            this.AddButton.Margin = new System.Windows.Forms.Padding(5);
            this.AddButton.Name = "AddButton";
            this.AddButton.Size = new System.Drawing.Size(107, 44);
            this.AddButton.TabIndex = 21;
            this.AddButton.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.AddButton.Click += new System.EventHandler(this.AddButton_Click);
            // 
            // DeleteButton
            // 
            this.DeleteButton.ActiveBorderThickness = 1;
            this.DeleteButton.ActiveCornerRadius = 20;
            this.DeleteButton.ActiveFillColor = System.Drawing.Color.SeaGreen;
            this.DeleteButton.ActiveForecolor = System.Drawing.Color.White;
            this.DeleteButton.ActiveLineColor = System.Drawing.Color.Gray;
            this.DeleteButton.BackColor = System.Drawing.SystemColors.Control;
            this.DeleteButton.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("DeleteButton.BackgroundImage")));
            this.DeleteButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.DeleteButton.ButtonText = "Delete";
            this.DeleteButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.DeleteButton.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DeleteButton.ForeColor = System.Drawing.Color.SeaGreen;
            this.DeleteButton.IdleBorderThickness = 1;
            this.DeleteButton.IdleCornerRadius = 20;
            this.DeleteButton.IdleFillColor = System.Drawing.Color.Red;
            this.DeleteButton.IdleForecolor = System.Drawing.Color.GhostWhite;
            this.DeleteButton.IdleLineColor = System.Drawing.Color.SeaGreen;
            this.DeleteButton.Location = new System.Drawing.Point(231, 234);
            this.DeleteButton.Margin = new System.Windows.Forms.Padding(5);
            this.DeleteButton.Name = "DeleteButton";
            this.DeleteButton.Size = new System.Drawing.Size(107, 44);
            this.DeleteButton.TabIndex = 22;
            this.DeleteButton.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.DeleteButton.Click += new System.EventHandler(this.DeleteButton_Click);
            // 
            // EditButton
            // 
            this.EditButton.ActiveBorderThickness = 1;
            this.EditButton.ActiveCornerRadius = 20;
            this.EditButton.ActiveFillColor = System.Drawing.Color.SeaGreen;
            this.EditButton.ActiveForecolor = System.Drawing.Color.White;
            this.EditButton.ActiveLineColor = System.Drawing.Color.Gray;
            this.EditButton.BackColor = System.Drawing.SystemColors.Control;
            this.EditButton.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("EditButton.BackgroundImage")));
            this.EditButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.EditButton.ButtonText = "Edit";
            this.EditButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.EditButton.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.EditButton.ForeColor = System.Drawing.Color.SeaGreen;
            this.EditButton.IdleBorderThickness = 1;
            this.EditButton.IdleCornerRadius = 20;
            this.EditButton.IdleFillColor = System.Drawing.Color.Navy;
            this.EditButton.IdleForecolor = System.Drawing.Color.GhostWhite;
            this.EditButton.IdleLineColor = System.Drawing.Color.SeaGreen;
            this.EditButton.Location = new System.Drawing.Point(393, 234);
            this.EditButton.Margin = new System.Windows.Forms.Padding(5);
            this.EditButton.Name = "EditButton";
            this.EditButton.Size = new System.Drawing.Size(107, 44);
            this.EditButton.TabIndex = 23;
            this.EditButton.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.EditButton.Click += new System.EventHandler(this.EditButton_Click);
            // 
            // ListPatient
            // 
            dataGridViewCellStyle4.BackColor = System.Drawing.Color.White;
            this.ListPatient.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle4;
            this.ListPatient.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.ListPatient.BackgroundColor = System.Drawing.Color.White;
            this.ListPatient.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.ListPatient.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.ListPatient.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle5.Font = new System.Drawing.Font("Segoe UI", 10.5F);
            dataGridViewCellStyle5.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle5.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle5.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.ListPatient.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle5;
            this.ListPatient.ColumnHeadersHeight = 30;
            dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle6.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle6.Font = new System.Drawing.Font("Segoe UI", 10.5F);
            dataGridViewCellStyle6.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle6.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle6.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle6.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.ListPatient.DefaultCellStyle = dataGridViewCellStyle6;
            this.ListPatient.EnableHeadersVisualStyles = false;
            this.ListPatient.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.ListPatient.Location = new System.Drawing.Point(0, 323);
            this.ListPatient.Name = "ListPatient";
            this.ListPatient.RowHeadersVisible = false;
            this.ListPatient.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.ListPatient.Size = new System.Drawing.Size(1323, 354);
            this.ListPatient.TabIndex = 24;
            this.ListPatient.Theme = Guna.UI.WinForms.GunaDataGridViewPresetThemes.Guna;
            this.ListPatient.ThemeStyle.AlternatingRowsStyle.BackColor = System.Drawing.Color.White;
            this.ListPatient.ThemeStyle.AlternatingRowsStyle.Font = null;
            this.ListPatient.ThemeStyle.AlternatingRowsStyle.ForeColor = System.Drawing.Color.Empty;
            this.ListPatient.ThemeStyle.AlternatingRowsStyle.SelectionBackColor = System.Drawing.Color.Empty;
            this.ListPatient.ThemeStyle.AlternatingRowsStyle.SelectionForeColor = System.Drawing.Color.Empty;
            this.ListPatient.ThemeStyle.BackColor = System.Drawing.Color.White;
            this.ListPatient.ThemeStyle.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.ListPatient.ThemeStyle.HeaderStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.ListPatient.ThemeStyle.HeaderStyle.BorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.ListPatient.ThemeStyle.HeaderStyle.Font = new System.Drawing.Font("Segoe UI", 10.5F);
            this.ListPatient.ThemeStyle.HeaderStyle.ForeColor = System.Drawing.Color.White;
            this.ListPatient.ThemeStyle.HeaderStyle.HeaightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            this.ListPatient.ThemeStyle.HeaderStyle.Height = 30;
            this.ListPatient.ThemeStyle.ReadOnly = false;
            this.ListPatient.ThemeStyle.RowsStyle.BackColor = System.Drawing.Color.White;
            this.ListPatient.ThemeStyle.RowsStyle.BorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.ListPatient.ThemeStyle.RowsStyle.Font = new System.Drawing.Font("Segoe UI", 10.5F);
            this.ListPatient.ThemeStyle.RowsStyle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            this.ListPatient.ThemeStyle.RowsStyle.Height = 22;
            this.ListPatient.ThemeStyle.RowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.ListPatient.ThemeStyle.RowsStyle.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            this.ListPatient.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.ListPatient_CellContentClick);
            // 
            // Patient
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1323, 672);
            this.Controls.Add(this.ListPatient);
            this.Controls.Add(this.EditButton);
            this.Controls.Add(this.DeleteButton);
            this.Controls.Add(this.AddButton);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.PatientEmail);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.PatientPhone);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.PatientAddress);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.PatientDOB);
            this.Controls.Add(this.PatientName);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.PatientGen);
            this.Controls.Add(this.label2);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Patient";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Patient";
            ((System.ComponentModel.ISupportInitialize)(this.Close)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.HomePage)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ListPatient)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label LogOut;
        private System.Windows.Forms.Label RegPage;
        private System.Windows.Forms.Label PillsPage;
        private System.Windows.Forms.Label StaffPage;
        private System.Windows.Forms.Label PatientPage;
        private System.Windows.Forms.PictureBox Close;
        private System.Windows.Forms.PictureBox HomePage;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.PictureBox pictureBox4;
        private System.Windows.Forms.TextBox PatientName;
        private System.Windows.Forms.ComboBox PatientGen;
        private System.Windows.Forms.Label label2;
        private Bunifu.Framework.UI.BunifuDatepicker PatientDOB;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox PatientAddress;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox PatientPhone;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox PatientEmail;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label12;
        private Bunifu.Framework.UI.BunifuThinButton2 AddButton;
        private Bunifu.Framework.UI.BunifuThinButton2 DeleteButton;
        private Bunifu.Framework.UI.BunifuThinButton2 EditButton;
        private Guna.UI.WinForms.GunaDataGridView ListPatient;
    }
}
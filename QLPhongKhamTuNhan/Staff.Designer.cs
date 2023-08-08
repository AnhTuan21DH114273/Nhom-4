
namespace QLPhongKhamTuNhan
{
    partial class Staff
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Staff));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            this.pictureBox4 = new System.Windows.Forms.PictureBox();
            this.StaffPage = new System.Windows.Forms.Label();
            this.PatientPage = new System.Windows.Forms.Label();
            this.Close = new System.Windows.Forms.PictureBox();
            this.HomePage = new System.Windows.Forms.PictureBox();
            this.EditButton = new Bunifu.Framework.UI.BunifuThinButton2();
            this.DeleteButton = new Bunifu.Framework.UI.BunifuThinButton2();
            this.AddButton = new Bunifu.Framework.UI.BunifuThinButton2();
            this.StaffEmail = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.StaffName = new System.Windows.Forms.TextBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.LogOut = new System.Windows.Forms.Label();
            this.RegPage = new System.Windows.Forms.Label();
            this.PillsPage = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.StaffPass = new System.Windows.Forms.TextBox();
            this.StaffNumPhone = new System.Windows.Forms.TextBox();
            this.ListStaff = new Guna.UI.WinForms.GunaDataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.StaffRole = new System.Windows.Forms.ComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Close)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.HomePage)).BeginInit();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ListStaff)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox4
            // 
            this.pictureBox4.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox4.Image")));
            this.pictureBox4.Location = new System.Drawing.Point(1121, 24);
            this.pictureBox4.Name = "pictureBox4";
            this.pictureBox4.Size = new System.Drawing.Size(56, 50);
            this.pictureBox4.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox4.TabIndex = 7;
            this.pictureBox4.TabStop = false;
            // 
            // StaffPage
            // 
            this.StaffPage.AutoSize = true;
            this.StaffPage.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.StaffPage.Font = new System.Drawing.Font("Times New Roman", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.StaffPage.ForeColor = System.Drawing.SystemColors.Control;
            this.StaffPage.Location = new System.Drawing.Point(368, 34);
            this.StaffPage.Name = "StaffPage";
            this.StaffPage.Size = new System.Drawing.Size(65, 31);
            this.StaffPage.TabIndex = 5;
            this.StaffPage.Text = "Staff";
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
            this.PatientPage.Click += new System.EventHandler(this.PatientPage_Click);
            // 
            // Close
            // 
            this.Close.Image = ((System.Drawing.Image)(resources.GetObject("Close.Image")));
            this.Close.Location = new System.Drawing.Point(1343, 0);
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
            this.EditButton.Location = new System.Drawing.Point(391, 232);
            this.EditButton.Margin = new System.Windows.Forms.Padding(5);
            this.EditButton.Name = "EditButton";
            this.EditButton.Size = new System.Drawing.Size(107, 44);
            this.EditButton.TabIndex = 40;
            this.EditButton.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.EditButton.Click += new System.EventHandler(this.EditButton_Click);
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
            this.DeleteButton.Location = new System.Drawing.Point(229, 232);
            this.DeleteButton.Margin = new System.Windows.Forms.Padding(5);
            this.DeleteButton.Name = "DeleteButton";
            this.DeleteButton.Size = new System.Drawing.Size(107, 44);
            this.DeleteButton.TabIndex = 39;
            this.DeleteButton.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.DeleteButton.Click += new System.EventHandler(this.DeleteButton_Click);
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
            this.AddButton.Location = new System.Drawing.Point(77, 232);
            this.AddButton.Margin = new System.Windows.Forms.Padding(5);
            this.AddButton.Name = "AddButton";
            this.AddButton.Size = new System.Drawing.Size(107, 44);
            this.AddButton.TabIndex = 38;
            this.AddButton.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.AddButton.Click += new System.EventHandler(this.AddButton_Click);
            // 
            // StaffEmail
            // 
            this.StaffEmail.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.StaffEmail.Location = new System.Drawing.Point(709, 177);
            this.StaffEmail.Name = "StaffEmail";
            this.StaffEmail.Size = new System.Drawing.Size(121, 29);
            this.StaffEmail.TabIndex = 36;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.SystemColors.Control;
            this.label5.Font = new System.Drawing.Font("Times New Roman", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.SystemColors.Highlight;
            this.label5.Location = new System.Drawing.Point(703, 130);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(78, 31);
            this.label5.TabIndex = 35;
            this.label5.Text = "Email";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.SystemColors.Control;
            this.label4.Font = new System.Drawing.Font("Times New Roman", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.SystemColors.Highlight;
            this.label4.Location = new System.Drawing.Point(510, 130);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(83, 31);
            this.label4.TabIndex = 33;
            this.label4.Text = "Phone";
            // 
            // StaffName
            // 
            this.StaffName.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.StaffName.Location = new System.Drawing.Point(77, 177);
            this.StaffName.Name = "StaffName";
            this.StaffName.Size = new System.Drawing.Size(121, 29);
            this.StaffName.TabIndex = 28;
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
            this.panel1.Size = new System.Drawing.Size(1395, 100);
            this.panel1.TabIndex = 25;
            // 
            // LogOut
            // 
            this.LogOut.AutoSize = true;
            this.LogOut.BackColor = System.Drawing.SystemColors.Control;
            this.LogOut.Font = new System.Drawing.Font("Times New Roman", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LogOut.ForeColor = System.Drawing.SystemColors.Desktop;
            this.LogOut.Location = new System.Drawing.Point(1183, 34);
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
            this.RegPage.Location = new System.Drawing.Point(703, 34);
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
            this.PillsPage.Location = new System.Drawing.Point(526, 34);
            this.PillsPage.Name = "PillsPage";
            this.PillsPage.Size = new System.Drawing.Size(139, 31);
            this.PillsPage.TabIndex = 5;
            this.PillsPage.Text = "List of Pills";
            this.PillsPage.Click += new System.EventHandler(this.PillsPage_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.SystemColors.Control;
            this.label2.Font = new System.Drawing.Font("Times New Roman", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.SystemColors.Highlight;
            this.label2.Location = new System.Drawing.Point(71, 130);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(135, 31);
            this.label2.TabIndex = 26;
            this.label2.Text = "Staff Name";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.BackColor = System.Drawing.SystemColors.Control;
            this.label13.Font = new System.Drawing.Font("Times New Roman", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label13.ForeColor = System.Drawing.SystemColors.Highlight;
            this.label13.Location = new System.Drawing.Point(316, 130);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(117, 31);
            this.label13.TabIndex = 42;
            this.label13.Text = "Password";
            // 
            // StaffPass
            // 
            this.StaffPass.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.StaffPass.Location = new System.Drawing.Point(312, 177);
            this.StaffPass.Name = "StaffPass";
            this.StaffPass.Size = new System.Drawing.Size(121, 29);
            this.StaffPass.TabIndex = 43;
            // 
            // StaffNumPhone
            // 
            this.StaffNumPhone.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.StaffNumPhone.Location = new System.Drawing.Point(516, 177);
            this.StaffNumPhone.Name = "StaffNumPhone";
            this.StaffNumPhone.Size = new System.Drawing.Size(121, 29);
            this.StaffNumPhone.TabIndex = 44;
            // 
            // ListStaff
            // 
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.White;
            this.ListStaff.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.ListStaff.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.ListStaff.BackgroundColor = System.Drawing.Color.White;
            this.ListStaff.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.ListStaff.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.ListStaff.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Segoe UI", 10.5F);
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.ListStaff.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.ListStaff.ColumnHeadersHeight = 25;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Segoe UI", 10.5F);
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.ListStaff.DefaultCellStyle = dataGridViewCellStyle3;
            this.ListStaff.EnableHeadersVisualStyles = false;
            this.ListStaff.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.ListStaff.Location = new System.Drawing.Point(0, 284);
            this.ListStaff.Name = "ListStaff";
            this.ListStaff.RowHeadersVisible = false;
            this.ListStaff.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.ListStaff.Size = new System.Drawing.Size(1396, 386);
            this.ListStaff.TabIndex = 46;
            this.ListStaff.Theme = Guna.UI.WinForms.GunaDataGridViewPresetThemes.Guna;
            this.ListStaff.ThemeStyle.AlternatingRowsStyle.BackColor = System.Drawing.Color.White;
            this.ListStaff.ThemeStyle.AlternatingRowsStyle.Font = null;
            this.ListStaff.ThemeStyle.AlternatingRowsStyle.ForeColor = System.Drawing.Color.Empty;
            this.ListStaff.ThemeStyle.AlternatingRowsStyle.SelectionBackColor = System.Drawing.Color.Empty;
            this.ListStaff.ThemeStyle.AlternatingRowsStyle.SelectionForeColor = System.Drawing.Color.Empty;
            this.ListStaff.ThemeStyle.BackColor = System.Drawing.Color.White;
            this.ListStaff.ThemeStyle.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.ListStaff.ThemeStyle.HeaderStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.ListStaff.ThemeStyle.HeaderStyle.BorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.ListStaff.ThemeStyle.HeaderStyle.Font = new System.Drawing.Font("Segoe UI", 10.5F);
            this.ListStaff.ThemeStyle.HeaderStyle.ForeColor = System.Drawing.Color.White;
            this.ListStaff.ThemeStyle.HeaderStyle.HeaightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            this.ListStaff.ThemeStyle.HeaderStyle.Height = 25;
            this.ListStaff.ThemeStyle.ReadOnly = false;
            this.ListStaff.ThemeStyle.RowsStyle.BackColor = System.Drawing.Color.White;
            this.ListStaff.ThemeStyle.RowsStyle.BorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.ListStaff.ThemeStyle.RowsStyle.Font = new System.Drawing.Font("Segoe UI", 10.5F);
            this.ListStaff.ThemeStyle.RowsStyle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            this.ListStaff.ThemeStyle.RowsStyle.Height = 22;
            this.ListStaff.ThemeStyle.RowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.ListStaff.ThemeStyle.RowsStyle.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            this.ListStaff.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.ListStaff_CellContentClick);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.SystemColors.Control;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.Highlight;
            this.label1.Location = new System.Drawing.Point(885, 130);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(66, 31);
            this.label1.TabIndex = 47;
            this.label1.Text = "Role";
            // 
            // StaffRole
            // 
            this.StaffRole.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.StaffRole.FormattingEnabled = true;
            this.StaffRole.Items.AddRange(new object[] {
            "Doctor",
            "Nurse"});
            this.StaffRole.Location = new System.Drawing.Point(891, 177);
            this.StaffRole.Name = "StaffRole";
            this.StaffRole.Size = new System.Drawing.Size(107, 29);
            this.StaffRole.TabIndex = 48;
            this.StaffRole.Text = "Role";
            // 
            // Staff
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1395, 668);
            this.Controls.Add(this.StaffRole);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.ListStaff);
            this.Controls.Add(this.StaffNumPhone);
            this.Controls.Add(this.StaffPass);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.EditButton);
            this.Controls.Add(this.DeleteButton);
            this.Controls.Add(this.AddButton);
            this.Controls.Add(this.StaffEmail);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.StaffName);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.label2);
            this.ForeColor = System.Drawing.SystemColors.ControlText;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Staff";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Staff";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Close)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.HomePage)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ListStaff)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox4;
        private System.Windows.Forms.Label StaffPage;
        private System.Windows.Forms.Label PatientPage;
        private System.Windows.Forms.PictureBox Close;
        private System.Windows.Forms.PictureBox HomePage;
        private Bunifu.Framework.UI.BunifuThinButton2 EditButton;
        private Bunifu.Framework.UI.BunifuThinButton2 DeleteButton;
        private Bunifu.Framework.UI.BunifuThinButton2 AddButton;
        private System.Windows.Forms.TextBox StaffEmail;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox StaffName;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label LogOut;
        private System.Windows.Forms.Label RegPage;
        private System.Windows.Forms.Label PillsPage;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.TextBox StaffPass;
        private System.Windows.Forms.TextBox StaffNumPhone;
        private Guna.UI.WinForms.GunaDataGridView ListStaff;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox StaffRole;
    }
}
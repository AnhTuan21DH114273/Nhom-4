
namespace QLPhongKhamTuNhan
{
    partial class MedicalRegister
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MedicalRegister));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            this.pictureBox4 = new System.Windows.Forms.PictureBox();
            this.PatientPage = new System.Windows.Forms.Label();
            this.Close = new System.Windows.Forms.PictureBox();
            this.HomePage = new System.Windows.Forms.PictureBox();
            this.DelButton = new Bunifu.Framework.UI.BunifuThinButton2();
            this.AddButton = new Bunifu.Framework.UI.BunifuThinButton2();
            this.StaffName = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.Medicines = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.LogOut = new System.Windows.Forms.Label();
            this.RegPage = new System.Windows.Forms.Label();
            this.PillsPage = new System.Windows.Forms.Label();
            this.StaffPage = new System.Windows.Forms.Label();
            this.Patient_ID = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.Staff_ID = new System.Windows.Forms.ComboBox();
            this.RegisterTxt = new System.Windows.Forms.TextBox();
            this.PatientName = new System.Windows.Forms.TextBox();
            this.Cost = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.ListReg = new Guna.UI.WinForms.GunaDataGridView();
            this.EditButton = new Bunifu.Framework.UI.BunifuThinButton2();
            this.PrtButton = new Bunifu.Framework.UI.BunifuThinButton2();
            this.printDocument1 = new System.Drawing.Printing.PrintDocument();
            this.printPreviewDialog1 = new System.Windows.Forms.PrintPreviewDialog();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Close)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.HomePage)).BeginInit();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ListReg)).BeginInit();
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
            // PatientPage
            // 
            this.PatientPage.AutoSize = true;
            this.PatientPage.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.PatientPage.Font = new System.Drawing.Font("Times New Roman", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PatientPage.ForeColor = System.Drawing.SystemColors.Control;
            this.PatientPage.Location = new System.Drawing.Point(223, 34);
            this.PatientPage.Name = "PatientPage";
            this.PatientPage.Size = new System.Drawing.Size(100, 31);
            this.PatientPage.TabIndex = 4;
            this.PatientPage.Text = "Patients";
            this.PatientPage.Click += new System.EventHandler(this.PatientPage_Click);
            // 
            // Close
            // 
            this.Close.Image = ((System.Drawing.Image)(resources.GetObject("Close.Image")));
            this.Close.Location = new System.Drawing.Point(1423, 0);
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
            // DelButton
            // 
            this.DelButton.ActiveBorderThickness = 1;
            this.DelButton.ActiveCornerRadius = 20;
            this.DelButton.ActiveFillColor = System.Drawing.Color.SeaGreen;
            this.DelButton.ActiveForecolor = System.Drawing.Color.White;
            this.DelButton.ActiveLineColor = System.Drawing.Color.Gray;
            this.DelButton.BackColor = System.Drawing.SystemColors.Control;
            this.DelButton.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("DelButton.BackgroundImage")));
            this.DelButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.DelButton.ButtonText = "Delete";
            this.DelButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.DelButton.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DelButton.ForeColor = System.Drawing.Color.SeaGreen;
            this.DelButton.IdleBorderThickness = 1;
            this.DelButton.IdleCornerRadius = 20;
            this.DelButton.IdleFillColor = System.Drawing.Color.Red;
            this.DelButton.IdleForecolor = System.Drawing.Color.GhostWhite;
            this.DelButton.IdleLineColor = System.Drawing.Color.SeaGreen;
            this.DelButton.Location = new System.Drawing.Point(549, 237);
            this.DelButton.Margin = new System.Windows.Forms.Padding(5);
            this.DelButton.Name = "DelButton";
            this.DelButton.Size = new System.Drawing.Size(107, 44);
            this.DelButton.TabIndex = 39;
            this.DelButton.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.DelButton.Click += new System.EventHandler(this.DelButton_Click);
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
            this.AddButton.Location = new System.Drawing.Point(549, 183);
            this.AddButton.Margin = new System.Windows.Forms.Padding(5);
            this.AddButton.Name = "AddButton";
            this.AddButton.Size = new System.Drawing.Size(107, 44);
            this.AddButton.TabIndex = 38;
            this.AddButton.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.AddButton.Click += new System.EventHandler(this.AddButton_Click);
            // 
            // StaffName
            // 
            this.StaffName.Enabled = false;
            this.StaffName.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.StaffName.Location = new System.Drawing.Point(169, 137);
            this.StaffName.Name = "StaffName";
            this.StaffName.Size = new System.Drawing.Size(121, 29);
            this.StaffName.TabIndex = 36;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.SystemColors.Control;
            this.label5.Font = new System.Drawing.Font("Times New Roman", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.SystemColors.Highlight;
            this.label5.Location = new System.Drawing.Point(543, 103);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(64, 31);
            this.label5.TabIndex = 35;
            this.label5.Text = "Cost";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.SystemColors.Control;
            this.label4.Font = new System.Drawing.Font("Times New Roman", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.SystemColors.Highlight;
            this.label4.Location = new System.Drawing.Point(343, 103);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(126, 31);
            this.label4.TabIndex = 33;
            this.label4.Text = "Medicines";
            // 
            // Medicines
            // 
            this.Medicines.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Medicines.Location = new System.Drawing.Point(349, 136);
            this.Medicines.Multiline = true;
            this.Medicines.Name = "Medicines";
            this.Medicines.Size = new System.Drawing.Size(167, 113);
            this.Medicines.TabIndex = 32;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.SystemColors.Control;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.Highlight;
            this.label1.Location = new System.Drawing.Point(163, 168);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(160, 31);
            this.label1.TabIndex = 30;
            this.label1.Text = "Patient Name";
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
            this.panel1.Size = new System.Drawing.Size(1476, 100);
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
            this.RegPage.Location = new System.Drawing.Point(686, 34);
            this.RegPage.Name = "RegPage";
            this.RegPage.Size = new System.Drawing.Size(198, 31);
            this.RegPage.TabIndex = 5;
            this.RegPage.Text = "Medical Register";
            // 
            // PillsPage
            // 
            this.PillsPage.AutoSize = true;
            this.PillsPage.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.PillsPage.Font = new System.Drawing.Font("Times New Roman", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PillsPage.ForeColor = System.Drawing.SystemColors.Control;
            this.PillsPage.Location = new System.Drawing.Point(506, 34);
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
            this.StaffPage.Location = new System.Drawing.Point(387, 34);
            this.StaffPage.Name = "StaffPage";
            this.StaffPage.Size = new System.Drawing.Size(65, 31);
            this.StaffPage.TabIndex = 5;
            this.StaffPage.Text = "Staff";
            this.StaffPage.Click += new System.EventHandler(this.StaffPage_Click);
            // 
            // Patient_ID
            // 
            this.Patient_ID.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Patient_ID.FormattingEnabled = true;
            this.Patient_ID.Location = new System.Drawing.Point(47, 202);
            this.Patient_ID.Name = "Patient_ID";
            this.Patient_ID.Size = new System.Drawing.Size(107, 29);
            this.Patient_ID.TabIndex = 27;
            this.Patient_ID.Text = "Patient ID";
            this.Patient_ID.SelectionChangeCommitted += new System.EventHandler(this.Patient_ID_SelectionChangeCommitted);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.SystemColors.Control;
            this.label2.Font = new System.Drawing.Font("Times New Roman", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.SystemColors.Highlight;
            this.label2.Location = new System.Drawing.Point(163, 103);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(135, 31);
            this.label2.TabIndex = 26;
            this.label2.Text = "Staff Name";
            // 
            // Staff_ID
            // 
            this.Staff_ID.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Staff_ID.FormattingEnabled = true;
            this.Staff_ID.Location = new System.Drawing.Point(47, 136);
            this.Staff_ID.Name = "Staff_ID";
            this.Staff_ID.Size = new System.Drawing.Size(107, 29);
            this.Staff_ID.TabIndex = 42;
            this.Staff_ID.Text = "Staff ID";
            this.Staff_ID.SelectionChangeCommitted += new System.EventHandler(this.Staff_ID_SelectionChangeCommitted);
            // 
            // RegisterTxt
            // 
            this.RegisterTxt.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.RegisterTxt.Location = new System.Drawing.Point(839, 137);
            this.RegisterTxt.Multiline = true;
            this.RegisterTxt.Name = "RegisterTxt";
            this.RegisterTxt.Size = new System.Drawing.Size(470, 234);
            this.RegisterTxt.TabIndex = 43;
            // 
            // PatientName
            // 
            this.PatientName.Enabled = false;
            this.PatientName.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PatientName.Location = new System.Drawing.Point(169, 202);
            this.PatientName.Name = "PatientName";
            this.PatientName.Size = new System.Drawing.Size(121, 29);
            this.PatientName.TabIndex = 44;
            // 
            // Cost
            // 
            this.Cost.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Cost.Location = new System.Drawing.Point(549, 146);
            this.Cost.Name = "Cost";
            this.Cost.Size = new System.Drawing.Size(121, 29);
            this.Cost.TabIndex = 45;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.SystemColors.Control;
            this.label3.Font = new System.Drawing.Font("Times New Roman", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.SystemColors.Highlight;
            this.label3.Location = new System.Drawing.Point(954, 103);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(198, 31);
            this.label3.TabIndex = 46;
            this.label3.Text = "Medical Register";
            // 
            // ListReg
            // 
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.White;
            this.ListReg.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.ListReg.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.ListReg.BackgroundColor = System.Drawing.Color.White;
            this.ListReg.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.ListReg.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.ListReg.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Segoe UI", 10.5F);
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.ListReg.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.ListReg.ColumnHeadersHeight = 30;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Segoe UI", 10.5F);
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.Coral;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.ListReg.DefaultCellStyle = dataGridViewCellStyle3;
            this.ListReg.EnableHeadersVisualStyles = false;
            this.ListReg.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.ListReg.Location = new System.Drawing.Point(0, 430);
            this.ListReg.Name = "ListReg";
            this.ListReg.RowHeadersVisible = false;
            this.ListReg.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.ListReg.Size = new System.Drawing.Size(1476, 393);
            this.ListReg.TabIndex = 47;
            this.ListReg.Theme = Guna.UI.WinForms.GunaDataGridViewPresetThemes.Guna;
            this.ListReg.ThemeStyle.AlternatingRowsStyle.BackColor = System.Drawing.Color.White;
            this.ListReg.ThemeStyle.AlternatingRowsStyle.Font = null;
            this.ListReg.ThemeStyle.AlternatingRowsStyle.ForeColor = System.Drawing.Color.Empty;
            this.ListReg.ThemeStyle.AlternatingRowsStyle.SelectionBackColor = System.Drawing.Color.Empty;
            this.ListReg.ThemeStyle.AlternatingRowsStyle.SelectionForeColor = System.Drawing.Color.Empty;
            this.ListReg.ThemeStyle.BackColor = System.Drawing.Color.White;
            this.ListReg.ThemeStyle.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.ListReg.ThemeStyle.HeaderStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.ListReg.ThemeStyle.HeaderStyle.BorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.ListReg.ThemeStyle.HeaderStyle.Font = new System.Drawing.Font("Segoe UI", 10.5F);
            this.ListReg.ThemeStyle.HeaderStyle.ForeColor = System.Drawing.Color.White;
            this.ListReg.ThemeStyle.HeaderStyle.HeaightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            this.ListReg.ThemeStyle.HeaderStyle.Height = 30;
            this.ListReg.ThemeStyle.ReadOnly = false;
            this.ListReg.ThemeStyle.RowsStyle.BackColor = System.Drawing.Color.White;
            this.ListReg.ThemeStyle.RowsStyle.BorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.ListReg.ThemeStyle.RowsStyle.Font = new System.Drawing.Font("Segoe UI", 10.5F);
            this.ListReg.ThemeStyle.RowsStyle.ForeColor = System.Drawing.Color.Coral;
            this.ListReg.ThemeStyle.RowsStyle.Height = 22;
            this.ListReg.ThemeStyle.RowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.ListReg.ThemeStyle.RowsStyle.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            this.ListReg.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.ListReg_CellContentClick);
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
            this.EditButton.Location = new System.Drawing.Point(549, 291);
            this.EditButton.Margin = new System.Windows.Forms.Padding(5);
            this.EditButton.Name = "EditButton";
            this.EditButton.Size = new System.Drawing.Size(107, 44);
            this.EditButton.TabIndex = 48;
            this.EditButton.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.EditButton.Click += new System.EventHandler(this.EditButton_Click);
            // 
            // PrtButton
            // 
            this.PrtButton.ActiveBorderThickness = 1;
            this.PrtButton.ActiveCornerRadius = 20;
            this.PrtButton.ActiveFillColor = System.Drawing.Color.SeaGreen;
            this.PrtButton.ActiveForecolor = System.Drawing.Color.White;
            this.PrtButton.ActiveLineColor = System.Drawing.Color.Gray;
            this.PrtButton.BackColor = System.Drawing.SystemColors.Control;
            this.PrtButton.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("PrtButton.BackgroundImage")));
            this.PrtButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.PrtButton.ButtonText = "Print";
            this.PrtButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.PrtButton.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PrtButton.ForeColor = System.Drawing.Color.SeaGreen;
            this.PrtButton.IdleBorderThickness = 1;
            this.PrtButton.IdleCornerRadius = 20;
            this.PrtButton.IdleFillColor = System.Drawing.Color.Red;
            this.PrtButton.IdleForecolor = System.Drawing.Color.GhostWhite;
            this.PrtButton.IdleLineColor = System.Drawing.Color.SeaGreen;
            this.PrtButton.Location = new System.Drawing.Point(1002, 378);
            this.PrtButton.Margin = new System.Windows.Forms.Padding(5);
            this.PrtButton.Name = "PrtButton";
            this.PrtButton.Size = new System.Drawing.Size(107, 44);
            this.PrtButton.TabIndex = 49;
            this.PrtButton.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.PrtButton.Click += new System.EventHandler(this.PrtButton_Click);
            // 
            // printDocument1
            // 
            this.printDocument1.PrintPage += new System.Drawing.Printing.PrintPageEventHandler(this.printDocument1_PrintPage);
            // 
            // printPreviewDialog1
            // 
            this.printPreviewDialog1.AutoScrollMargin = new System.Drawing.Size(0, 0);
            this.printPreviewDialog1.AutoScrollMinSize = new System.Drawing.Size(0, 0);
            this.printPreviewDialog1.ClientSize = new System.Drawing.Size(400, 300);
            this.printPreviewDialog1.Document = this.printDocument1;
            this.printPreviewDialog1.Enabled = true;
            this.printPreviewDialog1.Icon = ((System.Drawing.Icon)(resources.GetObject("printPreviewDialog1.Icon")));
            this.printPreviewDialog1.Name = "printPreviewDialog1";
            this.printPreviewDialog1.Visible = false;
            // 
            // MedicalRegister
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1476, 822);
            this.Controls.Add(this.PrtButton);
            this.Controls.Add(this.EditButton);
            this.Controls.Add(this.ListReg);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.Cost);
            this.Controls.Add(this.PatientName);
            this.Controls.Add(this.RegisterTxt);
            this.Controls.Add(this.Staff_ID);
            this.Controls.Add(this.DelButton);
            this.Controls.Add(this.AddButton);
            this.Controls.Add(this.StaffName);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.Medicines);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.Patient_ID);
            this.Controls.Add(this.label2);
            this.ForeColor = System.Drawing.Color.Coral;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "MedicalRegister";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "MedicalRegister";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Close)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.HomePage)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ListReg)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.PictureBox pictureBox4;
        private System.Windows.Forms.Label PatientPage;
        private System.Windows.Forms.PictureBox Close;
        private System.Windows.Forms.PictureBox HomePage;
        private Bunifu.Framework.UI.BunifuThinButton2 DelButton;
        private Bunifu.Framework.UI.BunifuThinButton2 AddButton;
        private System.Windows.Forms.TextBox StaffName;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox Medicines;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label LogOut;
        private System.Windows.Forms.Label PillsPage;
        private System.Windows.Forms.Label StaffPage;
        private System.Windows.Forms.ComboBox Patient_ID;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label RegPage;
        private System.Windows.Forms.ComboBox Staff_ID;
        private System.Windows.Forms.TextBox RegisterTxt;
        private System.Windows.Forms.TextBox PatientName;
        private System.Windows.Forms.TextBox Cost;
        private System.Windows.Forms.Label label3;
        private Guna.UI.WinForms.GunaDataGridView ListReg;
        private Bunifu.Framework.UI.BunifuThinButton2 EditButton;
        private Bunifu.Framework.UI.BunifuThinButton2 PrtButton;
        private System.Drawing.Printing.PrintDocument printDocument1;
        private System.Windows.Forms.PrintPreviewDialog printPreviewDialog1;
    }
}
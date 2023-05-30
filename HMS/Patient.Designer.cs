namespace HMS
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
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnRegistered = new System.Windows.Forms.Button();
            this.btnRegistration = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.panel3 = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.panel4 = new System.Windows.Forms.Panel();
            this.btnCancel = new System.Windows.Forms.Button();
            this.btnSave = new System.Windows.Forms.Button();
            this.cmbGender = new System.Windows.Forms.ComboBox();
            this.cmbBT = new System.Windows.Forms.ComboBox();
            this.txtAddress = new System.Windows.Forms.TextBox();
            this.txtCN = new System.Windows.Forms.TextBox();
            this.txtDOB = new System.Windows.Forms.TextBox();
            this.txtName = new System.Windows.Forms.TextBox();
            this.txtAge = new System.Windows.Forms.TextBox();
            this.txtId = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.btnExit = new System.Windows.Forms.Button();
            this.btnMin = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel3.SuspendLayout();
            this.panel4.SuspendLayout();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pictureBox1.BackgroundImage")));
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.pictureBox1.Location = new System.Drawing.Point(57, 40);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(167, 156);
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // panel1
            // 
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.btnRegistered);
            this.panel1.Controls.Add(this.btnRegistration);
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(283, 729);
            this.panel1.TabIndex = 1;
            // 
            // btnRegistered
            // 
            this.btnRegistered.Font = new System.Drawing.Font("Nirmala UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRegistered.Location = new System.Drawing.Point(-2, 399);
            this.btnRegistered.Name = "btnRegistered";
            this.btnRegistered.Size = new System.Drawing.Size(283, 60);
            this.btnRegistered.TabIndex = 4;
            this.btnRegistered.Text = "REGISTERED PATIENTS";
            this.btnRegistered.UseVisualStyleBackColor = true;
            this.btnRegistered.Click += new System.EventHandler(this.btnRegistered_Click);
            // 
            // btnRegistration
            // 
            this.btnRegistration.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(253)))), ((int)(((byte)(209)))), ((int)(((byte)(151)))));
            this.btnRegistration.FlatAppearance.BorderSize = 0;
            this.btnRegistration.Font = new System.Drawing.Font("Nirmala UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRegistration.Location = new System.Drawing.Point(-1, 339);
            this.btnRegistration.Name = "btnRegistration";
            this.btnRegistration.Size = new System.Drawing.Size(283, 60);
            this.btnRegistration.TabIndex = 3;
            this.btnRegistration.Text = "PATIENT\'S REGISTRATION";
            this.btnRegistration.UseVisualStyleBackColor = false;
            this.btnRegistration.Click += new System.EventHandler(this.btnRegistration_Click);
            // 
            // panel2
            // 
            this.panel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel2.Controls.Add(this.label1);
            this.panel2.Controls.Add(this.pictureBox1);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(281, 253);
            this.panel2.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Nirmala UI", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(110, 212);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(59, 21);
            this.label1.TabIndex = 2;
            this.label1.Text = "admin";
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.SystemColors.ControlDark;
            this.panel3.Controls.Add(this.label2);
            this.panel3.Location = new System.Drawing.Point(289, 42);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(1070, 38);
            this.panel3.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Nirmala UI", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(406, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(305, 38);
            this.label2.TabIndex = 0;
            this.label2.Text = "R E G I S T R A T I O N";
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.Color.Transparent;
            this.panel4.Controls.Add(this.btnCancel);
            this.panel4.Controls.Add(this.btnSave);
            this.panel4.Controls.Add(this.cmbGender);
            this.panel4.Controls.Add(this.cmbBT);
            this.panel4.Controls.Add(this.txtAddress);
            this.panel4.Controls.Add(this.txtCN);
            this.panel4.Controls.Add(this.txtDOB);
            this.panel4.Controls.Add(this.txtName);
            this.panel4.Controls.Add(this.txtAge);
            this.panel4.Controls.Add(this.txtId);
            this.panel4.Controls.Add(this.label10);
            this.panel4.Controls.Add(this.label9);
            this.panel4.Controls.Add(this.label8);
            this.panel4.Controls.Add(this.label7);
            this.panel4.Controls.Add(this.label6);
            this.panel4.Controls.Add(this.label5);
            this.panel4.Controls.Add(this.label4);
            this.panel4.Controls.Add(this.label3);
            this.panel4.Location = new System.Drawing.Point(289, 93);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(1070, 624);
            this.panel4.TabIndex = 3;
            // 
            // btnCancel
            // 
            this.btnCancel.Font = new System.Drawing.Font("Nirmala UI", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCancel.Location = new System.Drawing.Point(580, 559);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(87, 32);
            this.btnCancel.TabIndex = 17;
            this.btnCancel.Text = "CANCEL";
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // btnSave
            // 
            this.btnSave.Font = new System.Drawing.Font("Nirmala UI", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSave.Location = new System.Drawing.Point(465, 559);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(87, 32);
            this.btnSave.TabIndex = 16;
            this.btnSave.Text = "SAVE";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // cmbGender
            // 
            this.cmbGender.FormattingEnabled = true;
            this.cmbGender.Items.AddRange(new object[] {
            "Male",
            "Female"});
            this.cmbGender.Location = new System.Drawing.Point(767, 137);
            this.cmbGender.Name = "cmbGender";
            this.cmbGender.Size = new System.Drawing.Size(171, 28);
            this.cmbGender.TabIndex = 15;
            // 
            // cmbBT
            // 
            this.cmbBT.FormattingEnabled = true;
            this.cmbBT.Items.AddRange(new object[] {
            "A",
            "B",
            "AB",
            "O",
            "N/A"});
            this.cmbBT.Location = new System.Drawing.Point(357, 311);
            this.cmbBT.Name = "cmbBT";
            this.cmbBT.Size = new System.Drawing.Size(229, 28);
            this.cmbBT.TabIndex = 14;
            // 
            // txtAddress
            // 
            this.txtAddress.Location = new System.Drawing.Point(154, 392);
            this.txtAddress.Multiline = true;
            this.txtAddress.Name = "txtAddress";
            this.txtAddress.Size = new System.Drawing.Size(887, 68);
            this.txtAddress.TabIndex = 13;
            // 
            // txtCN
            // 
            this.txtCN.Location = new System.Drawing.Point(855, 230);
            this.txtCN.Name = "txtCN";
            this.txtCN.Size = new System.Drawing.Size(186, 26);
            this.txtCN.TabIndex = 12;
            // 
            // txtDOB
            // 
            this.txtDOB.Location = new System.Drawing.Point(357, 221);
            this.txtDOB.Name = "txtDOB";
            this.txtDOB.Size = new System.Drawing.Size(229, 26);
            this.txtDOB.TabIndex = 11;
            // 
            // txtName
            // 
            this.txtName.Location = new System.Drawing.Point(135, 137);
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(451, 26);
            this.txtName.TabIndex = 10;
            // 
            // txtAge
            // 
            this.txtAge.Location = new System.Drawing.Point(735, 47);
            this.txtAge.Name = "txtAge";
            this.txtAge.Size = new System.Drawing.Size(203, 26);
            this.txtAge.TabIndex = 9;
            // 
            // txtId
            // 
            this.txtId.Location = new System.Drawing.Point(97, 47);
            this.txtId.Name = "txtId";
            this.txtId.Size = new System.Drawing.Size(181, 26);
            this.txtId.TabIndex = 8;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Nirmala UI", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(669, 226);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(180, 28);
            this.label10.TabIndex = 7;
            this.label10.Text = "Contact Number: ";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Nirmala UI", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(669, 43);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(60, 28);
            this.label9.TabIndex = 6;
            this.label9.Text = "Age: ";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Nirmala UI", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(50, 307);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(301, 28);
            this.label8.TabIndex = 5;
            this.label8.Text = "Blood Type (N/A if unknown): ";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Nirmala UI", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(50, 133);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(79, 28);
            this.label7.TabIndex = 4;
            this.label7.Text = "Name: ";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Nirmala UI", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(669, 133);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(92, 28);
            this.label6.TabIndex = 3;
            this.label6.Text = "Gender: ";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Nirmala UI", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(49, 217);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(302, 28);
            this.label5.TabIndex = 2;
            this.label5.Text = "Date of Birth (YYYY/MM/DD): ";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Nirmala UI", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(50, 388);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(98, 28);
            this.label4.TabIndex = 1;
            this.label4.Text = "Address: ";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Nirmala UI", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(50, 43);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(41, 28);
            this.label3.TabIndex = 0;
            this.label3.Text = "Id: ";
            // 
            // btnExit
            // 
            this.btnExit.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnExit.BackgroundImage")));
            this.btnExit.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnExit.Location = new System.Drawing.Point(1331, 8);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(28, 28);
            this.btnExit.TabIndex = 4;
            this.btnExit.UseVisualStyleBackColor = true;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // btnMin
            // 
            this.btnMin.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnMin.BackgroundImage")));
            this.btnMin.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnMin.Location = new System.Drawing.Point(1297, 8);
            this.btnMin.Name = "btnMin";
            this.btnMin.Size = new System.Drawing.Size(28, 28);
            this.btnMin.TabIndex = 5;
            this.btnMin.UseVisualStyleBackColor = true;
            this.btnMin.Click += new System.EventHandler(this.btnMin_Click);
            // 
            // Patient
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.ClientSize = new System.Drawing.Size(1371, 729);
            this.Controls.Add(this.btnMin);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.panel4);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel1);
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Patient";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Patient";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.panel4.ResumeLayout(false);
            this.panel4.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btnRegistered;
        private System.Windows.Forms.Button btnRegistration;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.ComboBox cmbGender;
        private System.Windows.Forms.ComboBox cmbBT;
        private System.Windows.Forms.TextBox txtAddress;
        private System.Windows.Forms.TextBox txtCN;
        private System.Windows.Forms.TextBox txtDOB;
        private System.Windows.Forms.TextBox txtName;
        private System.Windows.Forms.TextBox txtAge;
        private System.Windows.Forms.TextBox txtId;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.Button btnMin;
    }
}
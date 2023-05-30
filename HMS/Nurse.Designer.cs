namespace HMS
{
    partial class Nurse
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Nurse));
            this.panel3 = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.panel4 = new System.Windows.Forms.Panel();
            this.cmbAva = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.btnCancel = new System.Windows.Forms.Button();
            this.btnInsert = new System.Windows.Forms.Button();
            this.cmbGender = new System.Windows.Forms.ComboBox();
            this.txtCN = new System.Windows.Forms.TextBox();
            this.txtName = new System.Windows.Forms.TextBox();
            this.txtAge = new System.Windows.Forms.TextBox();
            this.txtId = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.btnMin = new System.Windows.Forms.Button();
            this.btnExit = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnDF = new System.Windows.Forms.Button();
            this.btnFindings = new System.Windows.Forms.Button();
            this.btnNinfo = new System.Windows.Forms.Button();
            this.btnNRegistration = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.panel3.SuspendLayout();
            this.panel4.SuspendLayout();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.SystemColors.ControlDark;
            this.panel3.Controls.Add(this.label2);
            this.panel3.Location = new System.Drawing.Point(289, 42);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(1070, 38);
            this.panel3.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Nirmala UI", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(381, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(305, 38);
            this.label2.TabIndex = 0;
            this.label2.Text = "R E G I S T R A T I O N";
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.Color.Transparent;
            this.panel4.Controls.Add(this.cmbAva);
            this.panel4.Controls.Add(this.label4);
            this.panel4.Controls.Add(this.btnCancel);
            this.panel4.Controls.Add(this.btnInsert);
            this.panel4.Controls.Add(this.cmbGender);
            this.panel4.Controls.Add(this.txtCN);
            this.panel4.Controls.Add(this.txtName);
            this.panel4.Controls.Add(this.txtAge);
            this.panel4.Controls.Add(this.txtId);
            this.panel4.Controls.Add(this.label10);
            this.panel4.Controls.Add(this.label9);
            this.panel4.Controls.Add(this.label7);
            this.panel4.Controls.Add(this.label6);
            this.panel4.Controls.Add(this.label3);
            this.panel4.Location = new System.Drawing.Point(289, 93);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(1070, 624);
            this.panel4.TabIndex = 4;
            // 
            // cmbAva
            // 
            this.cmbAva.FormattingEnabled = true;
            this.cmbAva.Items.AddRange(new object[] {
            "Available ",
            "Unavailable"});
            this.cmbAva.Location = new System.Drawing.Point(801, 47);
            this.cmbAva.Name = "cmbAva";
            this.cmbAva.Size = new System.Drawing.Size(166, 28);
            this.cmbAva.TabIndex = 19;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Nirmala UI", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(664, 43);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(131, 28);
            this.label4.TabIndex = 18;
            this.label4.Text = "Availability: ";
            // 
            // btnCancel
            // 
            this.btnCancel.Font = new System.Drawing.Font("Nirmala UI", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCancel.Location = new System.Drawing.Point(949, 559);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(87, 32);
            this.btnCancel.TabIndex = 17;
            this.btnCancel.Text = "CANCEL";
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // btnInsert
            // 
            this.btnInsert.Font = new System.Drawing.Font("Nirmala UI", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnInsert.Location = new System.Drawing.Point(821, 559);
            this.btnInsert.Name = "btnInsert";
            this.btnInsert.Size = new System.Drawing.Size(87, 32);
            this.btnInsert.TabIndex = 16;
            this.btnInsert.Text = "INSERT";
            this.btnInsert.UseVisualStyleBackColor = true;
            this.btnInsert.Click += new System.EventHandler(this.btnInsert_Click);
            // 
            // cmbGender
            // 
            this.cmbGender.FormattingEnabled = true;
            this.cmbGender.Items.AddRange(new object[] {
            "Male",
            "Female"});
            this.cmbGender.Location = new System.Drawing.Point(148, 326);
            this.cmbGender.Name = "cmbGender";
            this.cmbGender.Size = new System.Drawing.Size(171, 28);
            this.cmbGender.TabIndex = 15;
            // 
            // txtCN
            // 
            this.txtCN.Location = new System.Drawing.Point(236, 420);
            this.txtCN.Name = "txtCN";
            this.txtCN.Size = new System.Drawing.Size(186, 26);
            this.txtCN.TabIndex = 12;
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
            this.txtAge.Location = new System.Drawing.Point(116, 230);
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
            this.label10.Location = new System.Drawing.Point(50, 416);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(180, 28);
            this.label10.TabIndex = 7;
            this.label10.Text = "Contact Number: ";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Nirmala UI", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(50, 226);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(60, 28);
            this.label9.TabIndex = 6;
            this.label9.Text = "Age: ";
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
            this.label6.Location = new System.Drawing.Point(50, 322);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(92, 28);
            this.label6.TabIndex = 3;
            this.label6.Text = "Gender: ";
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
            // btnMin
            // 
            this.btnMin.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnMin.BackgroundImage")));
            this.btnMin.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnMin.Location = new System.Drawing.Point(1297, 8);
            this.btnMin.Name = "btnMin";
            this.btnMin.Size = new System.Drawing.Size(28, 28);
            this.btnMin.TabIndex = 6;
            this.btnMin.UseVisualStyleBackColor = true;
            this.btnMin.Click += new System.EventHandler(this.btnMin_Click);
            // 
            // btnExit
            // 
            this.btnExit.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnExit.BackgroundImage")));
            this.btnExit.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnExit.Location = new System.Drawing.Point(1331, 8);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(28, 28);
            this.btnExit.TabIndex = 7;
            this.btnExit.UseVisualStyleBackColor = true;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // panel1
            // 
            this.panel1.AutoScroll = true;
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.btnDF);
            this.panel1.Controls.Add(this.btnFindings);
            this.panel1.Controls.Add(this.btnNinfo);
            this.panel1.Controls.Add(this.btnNRegistration);
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(283, 729);
            this.panel1.TabIndex = 8;
            // 
            // btnDF
            // 
            this.btnDF.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(250)))), ((int)(((byte)(249)))));
            this.btnDF.Font = new System.Drawing.Font("Nirmala UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDF.Location = new System.Drawing.Point(-1, 512);
            this.btnDF.Name = "btnDF";
            this.btnDF.Size = new System.Drawing.Size(283, 60);
            this.btnDF.TabIndex = 25;
            this.btnDF.Text = "DATA FINDINGS";
            this.btnDF.UseVisualStyleBackColor = false;
            this.btnDF.Click += new System.EventHandler(this.btnDF_Click);
            // 
            // btnFindings
            // 
            this.btnFindings.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(250)))), ((int)(((byte)(249)))));
            this.btnFindings.Font = new System.Drawing.Font("Nirmala UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnFindings.Location = new System.Drawing.Point(-1, 456);
            this.btnFindings.Name = "btnFindings";
            this.btnFindings.Size = new System.Drawing.Size(283, 60);
            this.btnFindings.TabIndex = 20;
            this.btnFindings.Text = "NURSE FINDINGS";
            this.btnFindings.UseVisualStyleBackColor = false;
            this.btnFindings.Click += new System.EventHandler(this.btnFindings_Click);
            // 
            // btnNinfo
            // 
            this.btnNinfo.Font = new System.Drawing.Font("Nirmala UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnNinfo.Location = new System.Drawing.Point(-2, 399);
            this.btnNinfo.Name = "btnNinfo";
            this.btnNinfo.Size = new System.Drawing.Size(283, 60);
            this.btnNinfo.TabIndex = 4;
            this.btnNinfo.Text = "NURSE INFORMATION";
            this.btnNinfo.UseVisualStyleBackColor = true;
            this.btnNinfo.Click += new System.EventHandler(this.btnNinfo_Click);
            // 
            // btnNRegistration
            // 
            this.btnNRegistration.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(253)))), ((int)(((byte)(209)))), ((int)(((byte)(151)))));
            this.btnNRegistration.FlatAppearance.BorderSize = 0;
            this.btnNRegistration.Font = new System.Drawing.Font("Nirmala UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnNRegistration.Location = new System.Drawing.Point(-1, 339);
            this.btnNRegistration.Name = "btnNRegistration";
            this.btnNRegistration.Size = new System.Drawing.Size(283, 60);
            this.btnNRegistration.TabIndex = 3;
            this.btnNRegistration.Text = "NURSE\'S REGISTRATION";
            this.btnNRegistration.UseVisualStyleBackColor = false;
            this.btnNRegistration.Click += new System.EventHandler(this.btnNRegistration_Click);
            // 
            // panel2
            // 
            this.panel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel2.Controls.Add(this.label1);
            this.panel2.Controls.Add(this.pictureBox1);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(282, 253);
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
            // Nurse
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.ClientSize = new System.Drawing.Size(1371, 729);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.btnMin);
            this.Controls.Add(this.panel4);
            this.Controls.Add(this.panel3);
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Nurse";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Nurse";
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.panel4.ResumeLayout(false);
            this.panel4.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.Button btnInsert;
        private System.Windows.Forms.ComboBox cmbGender;
        private System.Windows.Forms.TextBox txtCN;
        private System.Windows.Forms.TextBox txtName;
        private System.Windows.Forms.TextBox txtAge;
        private System.Windows.Forms.TextBox txtId;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btnMin;
        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.ComboBox cmbAva;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btnDF;
        private System.Windows.Forms.Button btnFindings;
        private System.Windows.Forms.Button btnNinfo;
        private System.Windows.Forms.Button btnNRegistration;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}
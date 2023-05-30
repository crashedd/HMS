namespace HMS
{
    partial class Dashboard
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Dashboard));
            this.label1 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnPatient = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.btnNurse = new System.Windows.Forms.Button();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.panel3 = new System.Windows.Forms.Panel();
            this.btnDoctor = new System.Windows.Forms.Button();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.btnExit = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Lato", 22F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(186, 51);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(753, 52);
            this.label1.TabIndex = 0;
            this.label1.Text = "HOSPITAL MANAGEMENT SYSTEM";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(173)))), ((int)(((byte)(172)))));
            this.panel1.Controls.Add(this.btnPatient);
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Location = new System.Drawing.Point(41, 151);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(302, 351);
            this.panel1.TabIndex = 1;
            // 
            // btnPatient
            // 
            this.btnPatient.Font = new System.Drawing.Font("Nirmala UI", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPatient.Location = new System.Drawing.Point(93, 255);
            this.btnPatient.Name = "btnPatient";
            this.btnPatient.Size = new System.Drawing.Size(119, 48);
            this.btnPatient.TabIndex = 1;
            this.btnPatient.Text = "PATIENT";
            this.btnPatient.UseVisualStyleBackColor = true;
            this.btnPatient.Click += new System.EventHandler(this.btnPatient_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pictureBox1.BackgroundImage")));
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.pictureBox1.Location = new System.Drawing.Point(61, 44);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(179, 171);
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(173)))), ((int)(((byte)(172)))));
            this.panel2.Controls.Add(this.btnNurse);
            this.panel2.Controls.Add(this.pictureBox2);
            this.panel2.Location = new System.Drawing.Point(396, 151);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(302, 351);
            this.panel2.TabIndex = 2;
            // 
            // btnNurse
            // 
            this.btnNurse.Font = new System.Drawing.Font("Nirmala UI", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnNurse.Location = new System.Drawing.Point(93, 255);
            this.btnNurse.Name = "btnNurse";
            this.btnNurse.Size = new System.Drawing.Size(119, 48);
            this.btnNurse.TabIndex = 1;
            this.btnNurse.Text = "NURSE";
            this.btnNurse.UseVisualStyleBackColor = true;
            this.btnNurse.Click += new System.EventHandler(this.btnNurse_Click);
            // 
            // pictureBox2
            // 
            this.pictureBox2.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pictureBox2.BackgroundImage")));
            this.pictureBox2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.pictureBox2.Location = new System.Drawing.Point(62, 44);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(179, 171);
            this.pictureBox2.TabIndex = 0;
            this.pictureBox2.TabStop = false;
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(173)))), ((int)(((byte)(172)))));
            this.panel3.Controls.Add(this.btnDoctor);
            this.panel3.Controls.Add(this.pictureBox3);
            this.panel3.Location = new System.Drawing.Point(746, 151);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(302, 351);
            this.panel3.TabIndex = 3;
            // 
            // btnDoctor
            // 
            this.btnDoctor.Font = new System.Drawing.Font("Nirmala UI", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDoctor.Location = new System.Drawing.Point(92, 255);
            this.btnDoctor.Name = "btnDoctor";
            this.btnDoctor.Size = new System.Drawing.Size(119, 48);
            this.btnDoctor.TabIndex = 1;
            this.btnDoctor.Text = "DOCTOR";
            this.btnDoctor.UseVisualStyleBackColor = true;
            this.btnDoctor.Click += new System.EventHandler(this.btnDoctor_Click);
            // 
            // pictureBox3
            // 
            this.pictureBox3.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pictureBox3.BackgroundImage")));
            this.pictureBox3.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.pictureBox3.Location = new System.Drawing.Point(61, 44);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(179, 171);
            this.pictureBox3.TabIndex = 0;
            this.pictureBox3.TabStop = false;
            // 
            // btnExit
            // 
            this.btnExit.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(250)))), ((int)(((byte)(249)))));
            this.btnExit.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnExit.BackgroundImage")));
            this.btnExit.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnExit.Location = new System.Drawing.Point(1065, 12);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(25, 25);
            this.btnExit.TabIndex = 4;
            this.btnExit.UseVisualStyleBackColor = false;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // Dashboard
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.ClientSize = new System.Drawing.Size(1102, 600);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.label1);
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Dashboard";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Dashboard";
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.panel3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btnPatient;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button btnNurse;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.Button btnDoctor;
        private System.Windows.Forms.Button btnExit;
    }
}
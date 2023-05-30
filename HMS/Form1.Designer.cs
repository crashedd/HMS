namespace HMS
{
    partial class Form1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.txtUsername = new System.Windows.Forms.TextBox();
            this.txtPass = new System.Windows.Forms.TextBox();
            this.btnLOG = new System.Windows.Forms.Button();
            this.timerlogin = new System.Windows.Forms.Timer(this.components);
            this.btnExit = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // txtUsername
            // 
            this.txtUsername.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(250)))), ((int)(((byte)(249)))));
            this.txtUsername.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtUsername.Location = new System.Drawing.Point(93, 233);
            this.txtUsername.Name = "txtUsername";
            this.txtUsername.Size = new System.Drawing.Size(281, 19);
            this.txtUsername.TabIndex = 0;
            // 
            // txtPass
            // 
            this.txtPass.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(250)))), ((int)(((byte)(249)))));
            this.txtPass.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtPass.Location = new System.Drawing.Point(93, 297);
            this.txtPass.Name = "txtPass";
            this.txtPass.PasswordChar = '*';
            this.txtPass.Size = new System.Drawing.Size(281, 19);
            this.txtPass.TabIndex = 1;
            // 
            // btnLOG
            // 
            this.btnLOG.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(63)))), ((int)(((byte)(62)))));
            this.btnLOG.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnLOG.FlatAppearance.BorderSize = 0;
            this.btnLOG.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnLOG.Font = new System.Drawing.Font("Nirmala UI", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLOG.Location = new System.Drawing.Point(140, 392);
            this.btnLOG.Name = "btnLOG";
            this.btnLOG.Size = new System.Drawing.Size(146, 58);
            this.btnLOG.TabIndex = 2;
            this.btnLOG.Text = "LOG IN";
            this.btnLOG.UseVisualStyleBackColor = false;
            this.btnLOG.Click += new System.EventHandler(this.btnLOG_Click);
            // 
            // timerlogin
            // 
            this.timerlogin.Interval = 1000;
            this.timerlogin.Tick += new System.EventHandler(this.timerlogin_Tick);
            // 
            // btnExit
            // 
            this.btnExit.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnExit.BackgroundImage")));
            this.btnExit.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnExit.Location = new System.Drawing.Point(382, 12);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(25, 25);
            this.btnExit.TabIndex = 3;
            this.btnExit.UseVisualStyleBackColor = true;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.ClientSize = new System.Drawing.Size(419, 499);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.btnLOG);
            this.Controls.Add(this.txtPass);
            this.Controls.Add(this.txtUsername);
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "LOG IN";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtUsername;
        private System.Windows.Forms.TextBox txtPass;
        private System.Windows.Forms.Button btnLOG;
        private System.Windows.Forms.Timer timerlogin;
        private System.Windows.Forms.Button btnExit;
    }
}


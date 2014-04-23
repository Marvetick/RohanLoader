namespace RohanLoader
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.webBrowser1 = new System.Windows.Forms.WebBrowser();
            this.button1 = new System.Windows.Forms.Button();
            this.btnStart = new System.Windows.Forms.Button();
            this.rbMainServer = new System.Windows.Forms.RadioButton();
            this.rbTestServer = new System.Windows.Forms.RadioButton();
            this.lblMainServStatus = new System.Windows.Forms.Label();
            this.lblTestServStatus = new System.Windows.Forms.Label();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.button5 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.lblStatus = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // webBrowser1
            // 
            this.webBrowser1.AllowWebBrowserDrop = false;
            this.webBrowser1.Location = new System.Drawing.Point(1, 50);
            this.webBrowser1.MinimumSize = new System.Drawing.Size(20, 20);
            this.webBrowser1.Name = "webBrowser1";
            this.webBrowser1.Size = new System.Drawing.Size(648, 319);
            this.webBrowser1.TabIndex = 0;
            this.webBrowser1.Url = new System.Uri("https://m.facebook.com/privateoldrohan", System.UriKind.Absolute);
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.SystemColors.HotTrack;
            this.button1.BackgroundImage = global::RohanLoader.Properties.Resources.QuitBtnInactive;
            this.button1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.button1.FlatAppearance.BorderSize = 0;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.button1.Location = new System.Drawing.Point(39, 440);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(79, 26);
            this.button1.TabIndex = 1;
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            this.button1.MouseEnter += new System.EventHandler(this.button1_MouseEnter);
            this.button1.MouseLeave += new System.EventHandler(this.button1_MouseLeave);
            // 
            // btnStart
            // 
            this.btnStart.BackgroundImage = global::RohanLoader.Properties.Resources.StartButtonInActive;
            this.btnStart.FlatAppearance.BorderSize = 0;
            this.btnStart.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnStart.Location = new System.Drawing.Point(674, 408);
            this.btnStart.Name = "btnStart";
            this.btnStart.Size = new System.Drawing.Size(92, 48);
            this.btnStart.TabIndex = 2;
            this.btnStart.UseVisualStyleBackColor = true;
            this.btnStart.Click += new System.EventHandler(this.btnStart_Click);
            this.btnStart.MouseEnter += new System.EventHandler(this.btnStart_MouseEnter);
            this.btnStart.MouseLeave += new System.EventHandler(this.btnStart_MouseLeave);
            // 
            // rbMainServer
            // 
            this.rbMainServer.AutoSize = true;
            this.rbMainServer.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.rbMainServer.Checked = true;
            this.rbMainServer.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.rbMainServer.ForeColor = System.Drawing.SystemColors.Control;
            this.rbMainServer.Location = new System.Drawing.Point(674, 256);
            this.rbMainServer.Name = "rbMainServer";
            this.rbMainServer.Size = new System.Drawing.Size(96, 20);
            this.rbMainServer.TabIndex = 3;
            this.rbMainServer.TabStop = true;
            this.rbMainServer.Text = "Main server";
            this.rbMainServer.UseVisualStyleBackColor = false;
            // 
            // rbTestServer
            // 
            this.rbTestServer.AutoSize = true;
            this.rbTestServer.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.rbTestServer.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.rbTestServer.ForeColor = System.Drawing.SystemColors.Control;
            this.rbTestServer.Location = new System.Drawing.Point(674, 296);
            this.rbTestServer.Name = "rbTestServer";
            this.rbTestServer.Size = new System.Drawing.Size(94, 20);
            this.rbTestServer.TabIndex = 4;
            this.rbTestServer.Text = "Test server";
            this.rbTestServer.UseVisualStyleBackColor = false;
            // 
            // lblMainServStatus
            // 
            this.lblMainServStatus.AutoSize = true;
            this.lblMainServStatus.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.lblMainServStatus.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.lblMainServStatus.ForeColor = System.Drawing.SystemColors.Control;
            this.lblMainServStatus.Location = new System.Drawing.Point(693, 279);
            this.lblMainServStatus.Name = "lblMainServStatus";
            this.lblMainServStatus.Size = new System.Drawing.Size(45, 16);
            this.lblMainServStatus.TabIndex = 5;
            this.lblMainServStatus.Text = "label1";
            // 
            // lblTestServStatus
            // 
            this.lblTestServStatus.AutoSize = true;
            this.lblTestServStatus.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.lblTestServStatus.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.lblTestServStatus.ForeColor = System.Drawing.SystemColors.Control;
            this.lblTestServStatus.Location = new System.Drawing.Point(693, 319);
            this.lblTestServStatus.Name = "lblTestServStatus";
            this.lblTestServStatus.Size = new System.Drawing.Size(45, 16);
            this.lblTestServStatus.TabIndex = 6;
            this.lblTestServStatus.Text = "label1";
            // 
            // button2
            // 
            this.button2.BackgroundImage = global::RohanLoader.Properties.Resources.btnHomepage;
            this.button2.FlatAppearance.BorderSize = 0;
            this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button2.Location = new System.Drawing.Point(12, 25);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(81, 19);
            this.button2.TabIndex = 7;
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button3
            // 
            this.button3.BackgroundImage = global::RohanLoader.Properties.Resources.btnRegi;
            this.button3.FlatAppearance.BorderSize = 0;
            this.button3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button3.Location = new System.Drawing.Point(99, 25);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(79, 19);
            this.button3.TabIndex = 8;
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // button4
            // 
            this.button4.BackgroundImage = global::RohanLoader.Properties.Resources.facebook;
            this.button4.FlatAppearance.BorderSize = 0;
            this.button4.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button4.Location = new System.Drawing.Point(663, 200);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(31, 27);
            this.button4.TabIndex = 9;
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // button5
            // 
            this.button5.BackgroundImage = global::RohanLoader.Properties.Resources.CheckBtnInActive;
            this.button5.FlatAppearance.BorderSize = 0;
            this.button5.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button5.Location = new System.Drawing.Point(39, 401);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(79, 25);
            this.button5.TabIndex = 10;
            this.button5.UseVisualStyleBackColor = true;
            this.button5.Click += new System.EventHandler(this.button5_Click);
            this.button5.MouseEnter += new System.EventHandler(this.button5_MouseEnter);
            this.button5.MouseLeave += new System.EventHandler(this.button5_MouseLeave);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(169, 383);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(0, 13);
            this.label1.TabIndex = 11;
            // 
            // lblStatus
            // 
            this.lblStatus.AutoSize = true;
            this.lblStatus.BackColor = System.Drawing.SystemColors.ControlText;
            this.lblStatus.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.lblStatus.ForeColor = System.Drawing.SystemColors.ButtonShadow;
            this.lblStatus.Location = new System.Drawing.Point(351, 28);
            this.lblStatus.Name = "lblStatus";
            this.lblStatus.Size = new System.Drawing.Size(0, 16);
            this.lblStatus.TabIndex = 12;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::RohanLoader.Properties.Resources.loaderbg;
            this.ClientSize = new System.Drawing.Size(798, 498);
            this.Controls.Add(this.lblStatus);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.button5);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.lblTestServStatus);
            this.Controls.Add(this.lblMainServStatus);
            this.Controls.Add(this.rbTestServer);
            this.Controls.Add(this.rbMainServer);
            this.Controls.Add(this.btnStart);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.webBrowser1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Old Rohan Loader";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.MouseDown += new System.Windows.Forms.MouseEventHandler(this.Form1_MouseDown);
            this.MouseMove += new System.Windows.Forms.MouseEventHandler(this.Form1_MouseMove);
            this.MouseUp += new System.Windows.Forms.MouseEventHandler(this.Form1_MouseUp);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.WebBrowser webBrowser1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button btnStart;
        private System.Windows.Forms.RadioButton rbMainServer;
        private System.Windows.Forms.RadioButton rbTestServer;
        private System.Windows.Forms.Label lblMainServStatus;
        private System.Windows.Forms.Label lblTestServStatus;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblStatus;
    }
}


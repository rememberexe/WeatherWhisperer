namespace WeatherWhisperer
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            WeatherPictureBox = new PictureBox();
            label1 = new Label();
            clsbtn = new Button();
            minimizebtn = new Button();
            textBox1 = new TextBox();
            label2 = new Label();
            panel1 = new Panel();
            wthr = new Label();
            hmd = new Label();
            Tmpr = new Label();
            citys = new Label();
            searchbtn = new Button();
            location = new Label();
            timer1 = new System.Windows.Forms.Timer(components);
            pictureBox1 = new PictureBox();
            clrpnl = new Panel();
            panel2 = new Panel();
            settingsbtn = new Button();
            ((System.ComponentModel.ISupportInitialize)WeatherPictureBox).BeginInit();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            clrpnl.SuspendLayout();
            panel2.SuspendLayout();
            SuspendLayout();
            // 
            // WeatherPictureBox
            // 
            WeatherPictureBox.Location = new Point(310, 0);
            WeatherPictureBox.Name = "WeatherPictureBox";
            WeatherPictureBox.Size = new Size(84, 84);
            WeatherPictureBox.SizeMode = PictureBoxSizeMode.StretchImage;
            WeatherPictureBox.TabIndex = 0;
            WeatherPictureBox.TabStop = false;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI Semibold", 16.75F, FontStyle.Bold, GraphicsUnit.Point);
            label1.Location = new Point(60, 13);
            label1.Name = "label1";
            label1.Size = new Size(208, 31);
            label1.TabIndex = 1;
            label1.Text = "WeatherWhisperer";
            // 
            // clsbtn
            // 
            clsbtn.FlatAppearance.BorderSize = 0;
            clsbtn.FlatStyle = FlatStyle.Flat;
            clsbtn.Image = Properties.Resources.darkclose;
            clsbtn.Location = new Point(380, 7);
            clsbtn.Name = "clsbtn";
            clsbtn.Size = new Size(38, 38);
            clsbtn.TabIndex = 2;
            clsbtn.UseVisualStyleBackColor = true;
            clsbtn.Click += clsbtn_Click;
            // 
            // minimizebtn
            // 
            minimizebtn.FlatAppearance.BorderSize = 0;
            minimizebtn.FlatStyle = FlatStyle.Flat;
            minimizebtn.Image = Properties.Resources.darkminimize;
            minimizebtn.Location = new Point(341, 7);
            minimizebtn.Name = "minimizebtn";
            minimizebtn.Size = new Size(38, 38);
            minimizebtn.TabIndex = 3;
            minimizebtn.UseVisualStyleBackColor = true;
            minimizebtn.Click += minimizebtn_Click;
            // 
            // textBox1
            // 
            textBox1.BackColor = Color.FromArgb(20, 20, 20);
            textBox1.BorderStyle = BorderStyle.None;
            textBox1.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point);
            textBox1.ForeColor = SystemColors.Window;
            textBox1.Location = new Point(60, 69);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(267, 22);
            textBox1.TabIndex = 4;
            textBox1.KeyPress += textBox1_KeyPress;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label2.Location = new Point(17, 69);
            label2.Name = "label2";
            label2.Size = new Size(43, 21);
            label2.TabIndex = 5;
            label2.Text = "Ara :";
            // 
            // panel1
            // 
            panel1.BackColor = Color.FromArgb(47, 47, 47);
            panel1.Controls.Add(wthr);
            panel1.Controls.Add(hmd);
            panel1.Controls.Add(Tmpr);
            panel1.Controls.Add(citys);
            panel1.Controls.Add(WeatherPictureBox);
            panel1.Location = new Point(12, 151);
            panel1.MaximumSize = new Size(395, 237);
            panel1.MinimumSize = new Size(395, 29);
            panel1.Name = "panel1";
            panel1.Size = new Size(395, 237);
            panel1.TabIndex = 6;
            // 
            // wthr
            // 
            wthr.AutoSize = true;
            wthr.Font = new Font("Segoe UI Semibold", 16F, FontStyle.Bold, GraphicsUnit.Point);
            wthr.Location = new Point(17, 176);
            wthr.Name = "wthr";
            wthr.Size = new Size(0, 30);
            wthr.TabIndex = 3;
            // 
            // hmd
            // 
            hmd.AutoSize = true;
            hmd.Font = new Font("Segoe UI Semibold", 16F, FontStyle.Bold, GraphicsUnit.Point);
            hmd.Location = new Point(17, 124);
            hmd.Name = "hmd";
            hmd.Size = new Size(0, 30);
            hmd.TabIndex = 2;
            // 
            // Tmpr
            // 
            Tmpr.AutoSize = true;
            Tmpr.Font = new Font("Segoe UI Semibold", 16F, FontStyle.Bold, GraphicsUnit.Point);
            Tmpr.Location = new Point(17, 72);
            Tmpr.Name = "Tmpr";
            Tmpr.Size = new Size(0, 30);
            Tmpr.TabIndex = 1;
            // 
            // citys
            // 
            citys.AutoSize = true;
            citys.Font = new Font("Segoe UI Semibold", 16F, FontStyle.Bold, GraphicsUnit.Point);
            citys.Location = new Point(17, 20);
            citys.Name = "citys";
            citys.Size = new Size(0, 30);
            citys.TabIndex = 0;
            // 
            // searchbtn
            // 
            searchbtn.FlatAppearance.BorderSize = 0;
            searchbtn.FlatStyle = FlatStyle.Flat;
            searchbtn.Image = Properties.Resources.searchicon2;
            searchbtn.Location = new Point(333, 65);
            searchbtn.Name = "searchbtn";
            searchbtn.Size = new Size(32, 32);
            searchbtn.TabIndex = 7;
            searchbtn.UseVisualStyleBackColor = true;
            searchbtn.Click += searchbtn_ClickAsync;
            // 
            // location
            // 
            location.AutoSize = true;
            location.Font = new Font("Segoe UI Semibold", 16F, FontStyle.Bold, GraphicsUnit.Point);
            location.Location = new Point(29, 104);
            location.Name = "location";
            location.Size = new Size(95, 30);
            location.TabIndex = 8;
            location.Text = "Konum :";
            // 
            // timer1
            // 
            timer1.Interval = 10;
            timer1.Tick += timer1_Tick;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = Properties.Resources.icon;
            pictureBox1.Location = new Point(5, 5);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(48, 48);
            pictureBox1.SizeMode = PictureBoxSizeMode.AutoSize;
            pictureBox1.TabIndex = 9;
            pictureBox1.TabStop = false;
            // 
            // clrpnl
            // 
            clrpnl.BackColor = SystemColors.MenuHighlight;
            clrpnl.Controls.Add(panel2);
            clrpnl.Dock = DockStyle.Fill;
            clrpnl.Location = new Point(0, 0);
            clrpnl.Name = "clrpnl";
            clrpnl.Size = new Size(423, 406);
            clrpnl.TabIndex = 10;
            // 
            // panel2
            // 
            panel2.BackColor = Color.FromArgb(33, 33, 33);
            panel2.Controls.Add(settingsbtn);
            panel2.Location = new Point(3, 3);
            panel2.Name = "panel2";
            panel2.Size = new Size(418, 401);
            panel2.TabIndex = 0;
            // 
            // settingsbtn
            // 
            settingsbtn.FlatAppearance.BorderSize = 0;
            settingsbtn.FlatStyle = FlatStyle.Flat;
            settingsbtn.Image = Properties.Resources.settings1;
            settingsbtn.Location = new Point(298, 4);
            settingsbtn.Name = "settingsbtn";
            settingsbtn.Size = new Size(38, 38);
            settingsbtn.TabIndex = 4;
            settingsbtn.UseVisualStyleBackColor = true;
            settingsbtn.Click += settingsbtn_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(33, 33, 33);
            ClientSize = new Size(423, 406);
            Controls.Add(pictureBox1);
            Controls.Add(location);
            Controls.Add(searchbtn);
            Controls.Add(panel1);
            Controls.Add(label2);
            Controls.Add(textBox1);
            Controls.Add(minimizebtn);
            Controls.Add(clsbtn);
            Controls.Add(label1);
            Controls.Add(clrpnl);
            Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point);
            ForeColor = SystemColors.ControlLight;
            FormBorderStyle = FormBorderStyle.None;
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "Form1";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "WeatherWhisperer";
            TopMost = true;
            MouseDown += Form1_MouseDown;
            MouseMove += Form1_MouseMove;
            MouseUp += Form1_MouseUp;
            ((System.ComponentModel.ISupportInitialize)WeatherPictureBox).EndInit();
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            clrpnl.ResumeLayout(false);
            panel2.ResumeLayout(false);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private PictureBox WeatherPictureBox;
        private Label label1;
        private Button clsbtn;
        private Button minimizebtn;
        private TextBox textBox1;
        private Label label2;
        private Panel panel1;
        private Button searchbtn;
        private Label hmd;
        private Label Tmpr;
        private Label citys;
        private Label wthr;
        private Label location;
        private System.Windows.Forms.Timer timer1;
        private PictureBox pictureBox1;
        private Panel clrpnl;
        private Panel panel2;
        private Button settingsbtn;
    }
}
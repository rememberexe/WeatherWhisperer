namespace WeatherWhisperer
{
    partial class settingsform
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
            components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(settingsform));
            clsbtn = new Button();
            pictureBox1 = new PictureBox();
            label1 = new Label();
            clrpnll = new Panel();
            panel1 = new Panel();
            pictureBox2 = new PictureBox();
            label2 = new Label();
            thminflbl = new Label();
            label3 = new Label();
            thmtglbtn = new Button();
            timer1 = new System.Windows.Forms.Timer(components);
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            clrpnll.SuspendLayout();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            SuspendLayout();
            // 
            // clsbtn
            // 
            clsbtn.BackColor = Color.Transparent;
            clsbtn.FlatAppearance.BorderSize = 0;
            clsbtn.FlatStyle = FlatStyle.Flat;
            clsbtn.Image = Properties.Resources.darkclose;
            clsbtn.Location = new Point(333, 2);
            clsbtn.Name = "clsbtn";
            clsbtn.Size = new Size(38, 38);
            clsbtn.TabIndex = 3;
            clsbtn.UseVisualStyleBackColor = false;
            clsbtn.Click += clsbtn_Click;
            // 
            // pictureBox1
            // 
            pictureBox1.BackColor = Color.Transparent;
            pictureBox1.Image = Properties.Resources.settings1;
            pictureBox1.Location = new Point(3, 6);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(24, 24);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 4;
            pictureBox1.TabStop = false;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.Transparent;
            label1.Font = new Font("Segoe UI Semibold", 15.75F, FontStyle.Bold, GraphicsUnit.Point);
            label1.ForeColor = SystemColors.ButtonFace;
            label1.Location = new Point(31, 0);
            label1.Name = "label1";
            label1.Size = new Size(81, 30);
            label1.TabIndex = 5;
            label1.Text = "Ayarlar";
            // 
            // clrpnll
            // 
            clrpnll.BackColor = SystemColors.MenuHighlight;
            clrpnll.Controls.Add(panel1);
            clrpnll.Dock = DockStyle.Fill;
            clrpnll.Location = new Point(0, 0);
            clrpnll.Name = "clrpnll";
            clrpnll.Size = new Size(379, 255);
            clrpnll.TabIndex = 6;
            // 
            // panel1
            // 
            panel1.BackColor = Color.FromArgb(40, 40, 40);
            panel1.Controls.Add(pictureBox2);
            panel1.Controls.Add(label2);
            panel1.Controls.Add(pictureBox1);
            panel1.Controls.Add(label1);
            panel1.Controls.Add(clsbtn);
            panel1.Controls.Add(thminflbl);
            panel1.Controls.Add(label3);
            panel1.Controls.Add(thmtglbtn);
            panel1.Location = new Point(3, 3);
            panel1.Name = "panel1";
            panel1.Size = new Size(373, 249);
            panel1.TabIndex = 0;
            // 
            // pictureBox2
            // 
            pictureBox2.Image = Properties.Resources.icon;
            pictureBox2.Location = new Point(55, 57);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(48, 48);
            pictureBox2.SizeMode = PictureBoxSizeMode.AutoSize;
            pictureBox2.TabIndex = 11;
            pictureBox2.TabStop = false;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI Semibold", 16.75F, FontStyle.Bold, GraphicsUnit.Point);
            label2.Location = new Point(105, 65);
            label2.Name = "label2";
            label2.Size = new Size(208, 31);
            label2.TabIndex = 10;
            label2.Text = "WeatherWhisperer";
            // 
            // thminflbl
            // 
            thminflbl.AutoSize = true;
            thminflbl.Font = new Font("Segoe UI Semibold", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            thminflbl.Location = new Point(241, 130);
            thminflbl.Name = "thminflbl";
            thminflbl.Size = new Size(75, 17);
            thminflbl.TabIndex = 3;
            thminflbl.Text = "Dark Mode";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label3.Location = new Point(49, 126);
            label3.Name = "label3";
            label3.Size = new Size(144, 21);
            label3.TabIndex = 1;
            label3.Text = "Tema Seçenekleri :";
            label3.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // thmtglbtn
            // 
            thmtglbtn.BackColor = Color.Transparent;
            thmtglbtn.FlatAppearance.BorderSize = 0;
            thmtglbtn.FlatStyle = FlatStyle.Flat;
            thmtglbtn.Font = new Font("Segoe UI Semibold", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            thmtglbtn.ForeColor = Color.White;
            thmtglbtn.Image = Properties.Resources.tglonn;
            thmtglbtn.Location = new Point(195, 124);
            thmtglbtn.Name = "thmtglbtn";
            thmtglbtn.Size = new Size(44, 29);
            thmtglbtn.TabIndex = 0;
            thmtglbtn.UseVisualStyleBackColor = false;
            thmtglbtn.Click += thmtglbtn_Click;
            // 
            // timer1
            // 
            timer1.Interval = 1;
            timer1.Tick += timer1_Tick;
            // 
            // settingsform
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(40, 40, 40);
            ClientSize = new Size(379, 255);
            Controls.Add(clrpnll);
            ForeColor = SystemColors.ControlLightLight;
            FormBorderStyle = FormBorderStyle.None;
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "settingsform";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Ayarlar";
            TopMost = true;
            FormClosing += settingsform_FormClosing;
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            clrpnll.ResumeLayout(false);
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Button clsbtn;
        private PictureBox pictureBox1;
        private Label label1;
        private Panel clrpnll;
        private Panel panel1;
        private Label thminflbl;
        private Label label3;
        private Button thmtglbtn;
        private PictureBox pictureBox2;
        private Label label2;
        private System.Windows.Forms.Timer timer1;
    }
}
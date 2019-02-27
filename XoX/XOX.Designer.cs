namespace XoX
{
    partial class XOX
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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.yeniOyunToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.puanlarıSıfırlaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.çıkışToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.A1 = new System.Windows.Forms.Button();
            this.A2 = new System.Windows.Forms.Button();
            this.A3 = new System.Windows.Forms.Button();
            this.B1 = new System.Windows.Forms.Button();
            this.B2 = new System.Windows.Forms.Button();
            this.B3 = new System.Windows.Forms.Button();
            this.C1 = new System.Windows.Forms.Button();
            this.C2 = new System.Windows.Forms.Button();
            this.C3 = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.x_win_count = new System.Windows.Forms.Label();
            this.draw_count = new System.Windows.Forms.Label();
            this.o_win_count = new System.Windows.Forms.Label();
            this.p1 = new System.Windows.Forms.TextBox();
            this.p2 = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.PlayerBar1 = new System.Windows.Forms.ProgressBar();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.radioButton1 = new System.Windows.Forms.RadioButton();
            this.radioButton2 = new System.Windows.Forms.RadioButton();
            this.PlayerBar2 = new System.Windows.Forms.ProgressBar();
            this.timer2 = new System.Windows.Forms.Timer(this.components);
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.BackColor = System.Drawing.Color.LemonChiffon;
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(337, 28);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.BackColor = System.Drawing.Color.Goldenrod;
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.yeniOyunToolStripMenuItem,
            this.puanlarıSıfırlaToolStripMenuItem,
            this.çıkışToolStripMenuItem});
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(61, 24);
            this.fileToolStripMenuItem.Text = "OYUN";
            // 
            // yeniOyunToolStripMenuItem
            // 
            this.yeniOyunToolStripMenuItem.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.yeniOyunToolStripMenuItem.Name = "yeniOyunToolStripMenuItem";
            this.yeniOyunToolStripMenuItem.Size = new System.Drawing.Size(216, 26);
            this.yeniOyunToolStripMenuItem.Text = "Yeni Oyun   (F5) ";
            this.yeniOyunToolStripMenuItem.Click += new System.EventHandler(this.yeniOyunToolStripMenuItem_Click);
            // 
            // puanlarıSıfırlaToolStripMenuItem
            // 
            this.puanlarıSıfırlaToolStripMenuItem.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.puanlarıSıfırlaToolStripMenuItem.Name = "puanlarıSıfırlaToolStripMenuItem";
            this.puanlarıSıfırlaToolStripMenuItem.Size = new System.Drawing.Size(216, 26);
            this.puanlarıSıfırlaToolStripMenuItem.Text = "Puanları Sıfırla  (R)";
            this.puanlarıSıfırlaToolStripMenuItem.Click += new System.EventHandler(this.puanlarıSıfırlaToolStripMenuItem_Click);
            // 
            // çıkışToolStripMenuItem
            // 
            this.çıkışToolStripMenuItem.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.çıkışToolStripMenuItem.Name = "çıkışToolStripMenuItem";
            this.çıkışToolStripMenuItem.Size = new System.Drawing.Size(216, 26);
            this.çıkışToolStripMenuItem.Text = "Çıkış  (Esc)";
            this.çıkışToolStripMenuItem.Click += new System.EventHandler(this.çıkışToolStripMenuItem_Click);
            // 
            // A1
            // 
            this.A1.BackColor = System.Drawing.Color.Red;
            this.A1.Font = new System.Drawing.Font("Microsoft Sans Serif", 36F, System.Drawing.FontStyle.Bold);
            this.A1.Location = new System.Drawing.Point(11, 57);
            this.A1.Name = "A1";
            this.A1.Size = new System.Drawing.Size(100, 100);
            this.A1.TabIndex = 1;
            this.A1.UseVisualStyleBackColor = false;
            this.A1.Click += new System.EventHandler(this.button_click);
            this.A1.MouseEnter += new System.EventHandler(this.button_enter);
            this.A1.MouseLeave += new System.EventHandler(this.button_leave);
            // 
            // A2
            // 
            this.A2.BackColor = System.Drawing.Color.Red;
            this.A2.Font = new System.Drawing.Font("Microsoft Sans Serif", 36F, System.Drawing.FontStyle.Bold);
            this.A2.Location = new System.Drawing.Point(117, 57);
            this.A2.Name = "A2";
            this.A2.Size = new System.Drawing.Size(100, 100);
            this.A2.TabIndex = 2;
            this.A2.UseVisualStyleBackColor = false;
            this.A2.Click += new System.EventHandler(this.button_click);
            this.A2.MouseEnter += new System.EventHandler(this.button_enter);
            this.A2.MouseLeave += new System.EventHandler(this.button_leave);
            // 
            // A3
            // 
            this.A3.BackColor = System.Drawing.Color.Red;
            this.A3.Font = new System.Drawing.Font("Microsoft Sans Serif", 36F, System.Drawing.FontStyle.Bold);
            this.A3.Location = new System.Drawing.Point(223, 57);
            this.A3.Name = "A3";
            this.A3.Size = new System.Drawing.Size(100, 100);
            this.A3.TabIndex = 3;
            this.A3.UseVisualStyleBackColor = false;
            this.A3.Click += new System.EventHandler(this.button_click);
            this.A3.MouseEnter += new System.EventHandler(this.button_enter);
            this.A3.MouseLeave += new System.EventHandler(this.button_leave);
            // 
            // B1
            // 
            this.B1.BackColor = System.Drawing.Color.Red;
            this.B1.Font = new System.Drawing.Font("Microsoft Sans Serif", 36F, System.Drawing.FontStyle.Bold);
            this.B1.Location = new System.Drawing.Point(11, 163);
            this.B1.Name = "B1";
            this.B1.Size = new System.Drawing.Size(100, 100);
            this.B1.TabIndex = 4;
            this.B1.UseVisualStyleBackColor = false;
            this.B1.Click += new System.EventHandler(this.button_click);
            this.B1.MouseEnter += new System.EventHandler(this.button_enter);
            this.B1.MouseLeave += new System.EventHandler(this.button_leave);
            // 
            // B2
            // 
            this.B2.BackColor = System.Drawing.Color.Red;
            this.B2.Font = new System.Drawing.Font("Microsoft Sans Serif", 36F, System.Drawing.FontStyle.Bold);
            this.B2.Location = new System.Drawing.Point(117, 163);
            this.B2.Name = "B2";
            this.B2.Size = new System.Drawing.Size(100, 100);
            this.B2.TabIndex = 5;
            this.B2.UseVisualStyleBackColor = false;
            this.B2.Click += new System.EventHandler(this.button_click);
            this.B2.MouseEnter += new System.EventHandler(this.button_enter);
            this.B2.MouseLeave += new System.EventHandler(this.button_leave);
            // 
            // B3
            // 
            this.B3.BackColor = System.Drawing.Color.Red;
            this.B3.Font = new System.Drawing.Font("Microsoft Sans Serif", 36F, System.Drawing.FontStyle.Bold);
            this.B3.Location = new System.Drawing.Point(223, 163);
            this.B3.Name = "B3";
            this.B3.Size = new System.Drawing.Size(100, 100);
            this.B3.TabIndex = 6;
            this.B3.UseVisualStyleBackColor = false;
            this.B3.Click += new System.EventHandler(this.button_click);
            this.B3.MouseEnter += new System.EventHandler(this.button_enter);
            this.B3.MouseLeave += new System.EventHandler(this.button_leave);
            // 
            // C1
            // 
            this.C1.BackColor = System.Drawing.Color.Red;
            this.C1.Font = new System.Drawing.Font("Microsoft Sans Serif", 36F, System.Drawing.FontStyle.Bold);
            this.C1.Location = new System.Drawing.Point(11, 269);
            this.C1.Name = "C1";
            this.C1.Size = new System.Drawing.Size(100, 100);
            this.C1.TabIndex = 7;
            this.C1.UseVisualStyleBackColor = false;
            this.C1.Click += new System.EventHandler(this.button_click);
            this.C1.MouseEnter += new System.EventHandler(this.button_enter);
            this.C1.MouseLeave += new System.EventHandler(this.button_leave);
            // 
            // C2
            // 
            this.C2.BackColor = System.Drawing.Color.Red;
            this.C2.Font = new System.Drawing.Font("Microsoft Sans Serif", 36F, System.Drawing.FontStyle.Bold);
            this.C2.Location = new System.Drawing.Point(117, 269);
            this.C2.Name = "C2";
            this.C2.Size = new System.Drawing.Size(100, 100);
            this.C2.TabIndex = 8;
            this.C2.UseVisualStyleBackColor = false;
            this.C2.Click += new System.EventHandler(this.button_click);
            this.C2.MouseEnter += new System.EventHandler(this.button_enter);
            this.C2.MouseLeave += new System.EventHandler(this.button_leave);
            // 
            // C3
            // 
            this.C3.BackColor = System.Drawing.Color.Red;
            this.C3.Font = new System.Drawing.Font("Microsoft Sans Serif", 36F, System.Drawing.FontStyle.Bold);
            this.C3.Location = new System.Drawing.Point(223, 269);
            this.C3.Name = "C3";
            this.C3.Size = new System.Drawing.Size(100, 100);
            this.C3.TabIndex = 9;
            this.C3.UseVisualStyleBackColor = false;
            this.C3.Click += new System.EventHandler(this.button_click);
            this.C3.MouseEnter += new System.EventHandler(this.button_enter);
            this.C3.MouseLeave += new System.EventHandler(this.button_leave);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label2.Location = new System.Drawing.Point(114, 417);
            this.label2.MaximumSize = new System.Drawing.Size(107, 17);
            this.label2.MinimumSize = new System.Drawing.Size(107, 17);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(107, 17);
            this.label2.TabIndex = 11;
            this.label2.Text = "Beraberlik";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // x_win_count
            // 
            this.x_win_count.AutoSize = true;
            this.x_win_count.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.x_win_count.Location = new System.Drawing.Point(57, 438);
            this.x_win_count.Name = "x_win_count";
            this.x_win_count.Size = new System.Drawing.Size(17, 17);
            this.x_win_count.TabIndex = 13;
            this.x_win_count.Text = "0";
            // 
            // draw_count
            // 
            this.draw_count.AutoSize = true;
            this.draw_count.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.draw_count.Location = new System.Drawing.Point(162, 438);
            this.draw_count.Name = "draw_count";
            this.draw_count.Size = new System.Drawing.Size(17, 17);
            this.draw_count.TabIndex = 14;
            this.draw_count.Text = "0";
            // 
            // o_win_count
            // 
            this.o_win_count.AutoSize = true;
            this.o_win_count.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.o_win_count.Location = new System.Drawing.Point(272, 438);
            this.o_win_count.Name = "o_win_count";
            this.o_win_count.Size = new System.Drawing.Size(17, 17);
            this.o_win_count.TabIndex = 15;
            this.o_win_count.Text = "0";
            // 
            // p1
            // 
            this.p1.Location = new System.Drawing.Point(15, 392);
            this.p1.Name = "p1";
            this.p1.Size = new System.Drawing.Size(100, 22);
            this.p1.TabIndex = 16;
            this.p1.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // p2
            // 
            this.p2.Location = new System.Drawing.Point(225, 392);
            this.p2.Name = "p2";
            this.p2.Size = new System.Drawing.Size(100, 22);
            this.p2.TabIndex = 17;
            this.p2.Text = "Player2";
            this.p2.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.p2.TextChanged += new System.EventHandler(this.p2_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.Location = new System.Drawing.Point(21, 372);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(82, 17);
            this.label1.TabIndex = 18;
            this.label1.Text = "1. Oyuncu";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label3.Location = new System.Drawing.Point(231, 373);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(82, 17);
            this.label3.TabIndex = 19;
            this.label3.Text = "2. Oyuncu";
            // 
            // label4
            // 
            this.label4.BackColor = System.Drawing.SystemColors.HotTrack;
            this.label4.Location = new System.Drawing.Point(12, 155);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(310, 10);
            this.label4.TabIndex = 20;
            // 
            // label5
            // 
            this.label5.BackColor = System.Drawing.SystemColors.HotTrack;
            this.label5.Location = new System.Drawing.Point(12, 261);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(310, 10);
            this.label5.TabIndex = 21;
            // 
            // label6
            // 
            this.label6.BackColor = System.Drawing.SystemColors.HotTrack;
            this.label6.Location = new System.Drawing.Point(109, 58);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(11, 310);
            this.label6.TabIndex = 22;
            // 
            // label7
            // 
            this.label7.BackColor = System.Drawing.SystemColors.HotTrack;
            this.label7.Location = new System.Drawing.Point(215, 58);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(10, 310);
            this.label7.TabIndex = 23;
            // 
            // PlayerBar1
            // 
            this.PlayerBar1.Location = new System.Drawing.Point(15, 469);
            this.PlayerBar1.Name = "PlayerBar1";
            this.PlayerBar1.Size = new System.Drawing.Size(100, 36);
            this.PlayerBar1.TabIndex = 24;
            this.PlayerBar1.Visible = false;
            // 
            // timer1
            // 
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // radioButton1
            // 
            this.radioButton1.AutoSize = true;
            this.radioButton1.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.radioButton1.Location = new System.Drawing.Point(15, 30);
            this.radioButton1.Name = "radioButton1";
            this.radioButton1.Size = new System.Drawing.Size(144, 21);
            this.radioButton1.TabIndex = 25;
            this.radioButton1.TabStop = true;
            this.radioButton1.Text = "Tek kişilik Oyun";
            this.radioButton1.UseVisualStyleBackColor = true;
            this.radioButton1.CheckedChanged += new System.EventHandler(this.radioButton1_CheckedChanged);
            // 
            // radioButton2
            // 
            this.radioButton2.AutoSize = true;
            this.radioButton2.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.radioButton2.Location = new System.Drawing.Point(178, 30);
            this.radioButton2.Name = "radioButton2";
            this.radioButton2.Size = new System.Drawing.Size(135, 21);
            this.radioButton2.TabIndex = 26;
            this.radioButton2.TabStop = true;
            this.radioButton2.Text = "İki Kişilik Oyun";
            this.radioButton2.UseVisualStyleBackColor = true;
            this.radioButton2.CheckedChanged += new System.EventHandler(this.radioButton2_CheckedChanged);
            // 
            // PlayerBar2
            // 
            this.PlayerBar2.Location = new System.Drawing.Point(225, 469);
            this.PlayerBar2.Name = "PlayerBar2";
            this.PlayerBar2.Size = new System.Drawing.Size(102, 36);
            this.PlayerBar2.TabIndex = 27;
            this.PlayerBar2.Visible = false;
            // 
            // timer2
            // 
            this.timer2.Tick += new System.EventHandler(this.timer2_Tick);
            // 
            // label8
            // 
            this.label8.Location = new System.Drawing.Point(21, 511);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(99, 23);
            this.label8.TabIndex = 28;
            this.label8.Text = "Süre İşliyor....";
            // 
            // label9
            // 
            this.label9.Location = new System.Drawing.Point(226, 511);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(99, 23);
            this.label9.TabIndex = 29;
            this.label9.Text = "Süre İşliyor....";
            // 
            // XOX
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(337, 543);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.PlayerBar2);
            this.Controls.Add(this.radioButton2);
            this.Controls.Add(this.radioButton1);
            this.Controls.Add(this.PlayerBar1);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.p2);
            this.Controls.Add(this.p1);
            this.Controls.Add(this.o_win_count);
            this.Controls.Add(this.draw_count);
            this.Controls.Add(this.x_win_count);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.C3);
            this.Controls.Add(this.C2);
            this.Controls.Add(this.C1);
            this.Controls.Add(this.B3);
            this.Controls.Add(this.B2);
            this.Controls.Add(this.B1);
            this.Controls.Add(this.A3);
            this.Controls.Add(this.A2);
            this.Controls.Add(this.A1);
            this.Controls.Add(this.menuStrip1);
            this.KeyPreview = true;
            this.MainMenuStrip = this.menuStrip1;
            this.MaximizeBox = false;
            this.Name = "XOX";
            this.Text = "XOX";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.XOX_KeyDown);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem yeniOyunToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem çıkışToolStripMenuItem;
        private System.Windows.Forms.Button A1;
        private System.Windows.Forms.Button A2;
        private System.Windows.Forms.Button A3;
        private System.Windows.Forms.Button B1;
        private System.Windows.Forms.Button B2;
        private System.Windows.Forms.Button B3;
        private System.Windows.Forms.Button C1;
        private System.Windows.Forms.Button C2;
        private System.Windows.Forms.Button C3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label x_win_count;
        private System.Windows.Forms.Label draw_count;
        private System.Windows.Forms.Label o_win_count;
        private System.Windows.Forms.ToolStripMenuItem puanlarıSıfırlaToolStripMenuItem;
        private System.Windows.Forms.TextBox p1;
        private System.Windows.Forms.TextBox p2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.ProgressBar PlayerBar1;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.RadioButton radioButton1;
        private System.Windows.Forms.RadioButton radioButton2;
        private System.Windows.Forms.ProgressBar PlayerBar2;
        private System.Windows.Forms.Timer timer2;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
    }
}


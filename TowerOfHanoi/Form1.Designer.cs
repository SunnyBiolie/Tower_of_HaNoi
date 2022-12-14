namespace TowerOfHanoi
{
    partial class FormGame
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormGame));
            this.label1 = new System.Windows.Forms.Label();
            this.plate5 = new System.Windows.Forms.PictureBox();
            this.plate4 = new System.Windows.Forms.PictureBox();
            this.plate3 = new System.Windows.Forms.PictureBox();
            this.plate2 = new System.Windows.Forms.PictureBox();
            this.plate1 = new System.Windows.Forms.PictureBox();
            this.plate6 = new System.Windows.Forms.PictureBox();
            this.plate7 = new System.Windows.Forms.PictureBox();
            this.plate8 = new System.Windows.Forms.PictureBox();
            this.RodC = new System.Windows.Forms.PictureBox();
            this.RodB = new System.Windows.Forms.PictureBox();
            this.RodA = new System.Windows.Forms.PictureBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.btnGiveUp = new System.Windows.Forms.Button();
            this.btnPlay = new System.Windows.Forms.Button();
            this.numudNumPlate = new System.Windows.Forms.NumericUpDown();
            this.label4 = new System.Windows.Forms.Label();
            this.lableTimer = new System.Windows.Forms.Label();
            this.labelCountMove = new System.Windows.Forms.Label();
            this.timerCountTime = new System.Windows.Forms.Timer(this.components);
            this.btnPause = new System.Windows.Forms.Button();
            this.cBoxPause = new System.Windows.Forms.CheckBox();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.lawToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.expToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.richTextBox1 = new System.Windows.Forms.RichTextBox();
            this.labelMinMove = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.plate5)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.plate4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.plate3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.plate2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.plate1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.plate6)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.plate7)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.plate8)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.RodC)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.RodB)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.RodA)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numudNumPlate)).BeginInit();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(170, 610);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(77, 25);
            this.label1.TabIndex = 6;
            this.label1.Text = "Tháp A";
            // 
            // plate5
            // 
            this.plate5.Image = global::TowerOfHanoi.Properties.Resources._5;
            this.plate5.Location = new System.Drawing.Point(43, 459);
            this.plate5.Margin = new System.Windows.Forms.Padding(0);
            this.plate5.Name = "plate5";
            this.plate5.Size = new System.Drawing.Size(340, 28);
            this.plate5.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.plate5.TabIndex = 11;
            this.plate5.TabStop = false;
            this.plate5.Tag = "5";
            this.plate5.Visible = false;
            this.plate5.Click += new System.EventHandler(this.plate_Click);
            // 
            // plate4
            // 
            this.plate4.Image = global::TowerOfHanoi.Properties.Resources._4;
            this.plate4.Location = new System.Drawing.Point(43, 431);
            this.plate4.Margin = new System.Windows.Forms.Padding(0);
            this.plate4.Name = "plate4";
            this.plate4.Size = new System.Drawing.Size(340, 28);
            this.plate4.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.plate4.TabIndex = 10;
            this.plate4.TabStop = false;
            this.plate4.Tag = "4";
            this.plate4.Visible = false;
            this.plate4.Click += new System.EventHandler(this.plate_Click);
            // 
            // plate3
            // 
            this.plate3.Image = global::TowerOfHanoi.Properties.Resources._3;
            this.plate3.Location = new System.Drawing.Point(43, 403);
            this.plate3.Margin = new System.Windows.Forms.Padding(0);
            this.plate3.Name = "plate3";
            this.plate3.Size = new System.Drawing.Size(340, 28);
            this.plate3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.plate3.TabIndex = 9;
            this.plate3.TabStop = false;
            this.plate3.Tag = "3";
            this.plate3.Visible = false;
            this.plate3.Click += new System.EventHandler(this.plate_Click);
            // 
            // plate2
            // 
            this.plate2.Image = global::TowerOfHanoi.Properties.Resources._2;
            this.plate2.Location = new System.Drawing.Point(43, 375);
            this.plate2.Margin = new System.Windows.Forms.Padding(0);
            this.plate2.Name = "plate2";
            this.plate2.Size = new System.Drawing.Size(340, 28);
            this.plate2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.plate2.TabIndex = 8;
            this.plate2.TabStop = false;
            this.plate2.Tag = "2";
            this.plate2.Visible = false;
            this.plate2.Click += new System.EventHandler(this.plate_Click);
            // 
            // plate1
            // 
            this.plate1.Image = global::TowerOfHanoi.Properties.Resources._1;
            this.plate1.Location = new System.Drawing.Point(43, 347);
            this.plate1.Margin = new System.Windows.Forms.Padding(0);
            this.plate1.Name = "plate1";
            this.plate1.Size = new System.Drawing.Size(340, 28);
            this.plate1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.plate1.TabIndex = 7;
            this.plate1.TabStop = false;
            this.plate1.Tag = "1";
            this.plate1.Visible = false;
            this.plate1.Click += new System.EventHandler(this.plate_Click);
            // 
            // plate6
            // 
            this.plate6.Image = global::TowerOfHanoi.Properties.Resources._6;
            this.plate6.Location = new System.Drawing.Point(43, 487);
            this.plate6.Margin = new System.Windows.Forms.Padding(0);
            this.plate6.Name = "plate6";
            this.plate6.Size = new System.Drawing.Size(340, 28);
            this.plate6.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.plate6.TabIndex = 5;
            this.plate6.TabStop = false;
            this.plate6.Tag = "6";
            this.plate6.Visible = false;
            this.plate6.Click += new System.EventHandler(this.plate_Click);
            // 
            // plate7
            // 
            this.plate7.Image = global::TowerOfHanoi.Properties.Resources._7;
            this.plate7.Location = new System.Drawing.Point(43, 515);
            this.plate7.Margin = new System.Windows.Forms.Padding(0);
            this.plate7.Name = "plate7";
            this.plate7.Size = new System.Drawing.Size(340, 28);
            this.plate7.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.plate7.TabIndex = 4;
            this.plate7.TabStop = false;
            this.plate7.Tag = "7";
            this.plate7.Visible = false;
            this.plate7.Click += new System.EventHandler(this.plate_Click);
            // 
            // plate8
            // 
            this.plate8.Image = global::TowerOfHanoi.Properties.Resources._8;
            this.plate8.Location = new System.Drawing.Point(43, 543);
            this.plate8.Margin = new System.Windows.Forms.Padding(0);
            this.plate8.Name = "plate8";
            this.plate8.Size = new System.Drawing.Size(340, 28);
            this.plate8.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.plate8.TabIndex = 3;
            this.plate8.TabStop = false;
            this.plate8.Tag = "8";
            this.plate8.Visible = false;
            this.plate8.Click += new System.EventHandler(this.plate_Click);
            // 
            // RodC
            // 
            this.RodC.Image = global::TowerOfHanoi.Properties.Resources.rod;
            this.RodC.Location = new System.Drawing.Point(812, 271);
            this.RodC.Margin = new System.Windows.Forms.Padding(0);
            this.RodC.Name = "RodC";
            this.RodC.Size = new System.Drawing.Size(350, 350);
            this.RodC.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.RodC.TabIndex = 2;
            this.RodC.TabStop = false;
            this.RodC.Click += new System.EventHandler(this.Rod_Click);
            // 
            // RodB
            // 
            this.RodB.Image = global::TowerOfHanoi.Properties.Resources.rod;
            this.RodB.Location = new System.Drawing.Point(425, 271);
            this.RodB.Margin = new System.Windows.Forms.Padding(0);
            this.RodB.Name = "RodB";
            this.RodB.Size = new System.Drawing.Size(350, 350);
            this.RodB.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.RodB.TabIndex = 1;
            this.RodB.TabStop = false;
            this.RodB.Click += new System.EventHandler(this.Rod_Click);
            // 
            // RodA
            // 
            this.RodA.Image = global::TowerOfHanoi.Properties.Resources.rod;
            this.RodA.Location = new System.Drawing.Point(38, 271);
            this.RodA.Margin = new System.Windows.Forms.Padding(0);
            this.RodA.Name = "RodA";
            this.RodA.Size = new System.Drawing.Size(350, 350);
            this.RodA.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.RodA.TabIndex = 0;
            this.RodA.TabStop = false;
            this.RodA.Click += new System.EventHandler(this.Rod_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(558, 610);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(76, 25);
            this.label2.TabIndex = 12;
            this.label2.Text = "Tháp B";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(944, 610);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(78, 25);
            this.label3.TabIndex = 13;
            this.label3.Text = "Tháp C";
            // 
            // btnGiveUp
            // 
            this.btnGiveUp.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnGiveUp.Enabled = false;
            this.btnGiveUp.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnGiveUp.Location = new System.Drawing.Point(680, 200);
            this.btnGiveUp.Name = "btnGiveUp";
            this.btnGiveUp.Size = new System.Drawing.Size(120, 42);
            this.btnGiveUp.TabIndex = 3;
            this.btnGiveUp.Text = "Kết thúc";
            this.btnGiveUp.UseVisualStyleBackColor = true;
            this.btnGiveUp.Click += new System.EventHandler(this.btnGiveUp_Click);
            // 
            // btnPlay
            // 
            this.btnPlay.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnPlay.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPlay.Location = new System.Drawing.Point(400, 200);
            this.btnPlay.Name = "btnPlay";
            this.btnPlay.Size = new System.Drawing.Size(120, 42);
            this.btnPlay.TabIndex = 1;
            this.btnPlay.Text = "Bắt đầu";
            this.btnPlay.UseVisualStyleBackColor = true;
            this.btnPlay.Click += new System.EventHandler(this.btnPlay_Click);
            // 
            // numudNumPlate
            // 
            this.numudNumPlate.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.numudNumPlate.Location = new System.Drawing.Point(635, 150);
            this.numudNumPlate.Maximum = new decimal(new int[] {
            8,
            0,
            0,
            0});
            this.numudNumPlate.Minimum = new decimal(new int[] {
            2,
            0,
            0,
            0});
            this.numudNumPlate.Name = "numudNumPlate";
            this.numudNumPlate.Size = new System.Drawing.Size(50, 30);
            this.numudNumPlate.TabIndex = 4;
            this.numudNumPlate.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.numudNumPlate.Value = new decimal(new int[] {
            3,
            0,
            0,
            0});
            // 
            // label4
            // 
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(515, 150);
            this.label4.Margin = new System.Windows.Forms.Padding(3, 0, 0, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(120, 25);
            this.label4.TabIndex = 17;
            this.label4.Text = "Chọn số đĩa";
            // 
            // lableTimer
            // 
            this.lableTimer.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.lableTimer.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lableTimer.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lableTimer.ForeColor = System.Drawing.SystemColors.ControlText;
            this.lableTimer.Location = new System.Drawing.Point(510, 55);
            this.lableTimer.Margin = new System.Windows.Forms.Padding(3);
            this.lableTimer.Name = "lableTimer";
            this.lableTimer.Padding = new System.Windows.Forms.Padding(4);
            this.lableTimer.Size = new System.Drawing.Size(180, 36);
            this.lableTimer.TabIndex = 18;
            this.lableTimer.Text = "Thời gian: 00:00:00";
            this.lableTimer.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // labelCountMove
            // 
            this.labelCountMove.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.labelCountMove.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.labelCountMove.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelCountMove.Location = new System.Drawing.Point(480, 100);
            this.labelCountMove.Margin = new System.Windows.Forms.Padding(3);
            this.labelCountMove.Name = "labelCountMove";
            this.labelCountMove.Padding = new System.Windows.Forms.Padding(4);
            this.labelCountMove.Size = new System.Drawing.Size(250, 36);
            this.labelCountMove.TabIndex = 18;
            this.labelCountMove.Text = "Số lượt di chuyển: 0 lần\r\n";
            this.labelCountMove.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // timerCountTime
            // 
            this.timerCountTime.Interval = 1000;
            this.timerCountTime.Tick += new System.EventHandler(this.timerCount_Tick);
            // 
            // btnPause
            // 
            this.btnPause.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnPause.Enabled = false;
            this.btnPause.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPause.Location = new System.Drawing.Point(540, 200);
            this.btnPause.Name = "btnPause";
            this.btnPause.Size = new System.Drawing.Size(120, 42);
            this.btnPause.TabIndex = 2;
            this.btnPause.Text = "Tạm dừng";
            this.btnPause.UseVisualStyleBackColor = true;
            this.btnPause.Click += new System.EventHandler(this.btnPause_Click);
            // 
            // cBoxPause
            // 
            this.cBoxPause.AutoSize = true;
            this.cBoxPause.Location = new System.Drawing.Point(1073, 60);
            this.cBoxPause.Name = "cBoxPause";
            this.cBoxPause.Size = new System.Drawing.Size(124, 20);
            this.cBoxPause.TabIndex = 19;
            this.cBoxPause.Text = "checkForPause";
            this.cBoxPause.UseVisualStyleBackColor = true;
            this.cBoxPause.Visible = false;
            // 
            // menuStrip1
            // 
            this.menuStrip1.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.menuStrip1.Font = new System.Drawing.Font("Segoe UI", 11F);
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.lawToolStripMenuItem,
            this.expToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Padding = new System.Windows.Forms.Padding(0);
            this.menuStrip1.Size = new System.Drawing.Size(1200, 39);
            this.menuStrip1.TabIndex = 20;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // lawToolStripMenuItem
            // 
            this.lawToolStripMenuItem.ForeColor = System.Drawing.SystemColors.Desktop;
            this.lawToolStripMenuItem.Name = "lawToolStripMenuItem";
            this.lawToolStripMenuItem.Padding = new System.Windows.Forms.Padding(5);
            this.lawToolStripMenuItem.Size = new System.Drawing.Size(103, 39);
            this.lawToolStripMenuItem.Text = "Luật chơi";
            this.lawToolStripMenuItem.Click += new System.EventHandler(this.lawToolStripMenuItem_Click);
            // 
            // expToolStripMenuItem
            // 
            this.expToolStripMenuItem.Enabled = false;
            this.expToolStripMenuItem.ForeColor = System.Drawing.SystemColors.Desktop;
            this.expToolStripMenuItem.Name = "expToolStripMenuItem";
            this.expToolStripMenuItem.Size = new System.Drawing.Size(120, 39);
            this.expToolStripMenuItem.Text = "Hướng dẫn";
            this.expToolStripMenuItem.Click += new System.EventHandler(this.expToolStripMenuItem_Click);
            // 
            // richTextBox1
            // 
            this.richTextBox1.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.richTextBox1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.richTextBox1.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.richTextBox1.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.richTextBox1.ForeColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.richTextBox1.Location = new System.Drawing.Point(25, 50);
            this.richTextBox1.Name = "richTextBox1";
            this.richTextBox1.ReadOnly = true;
            this.richTextBox1.ScrollBars = System.Windows.Forms.RichTextBoxScrollBars.Vertical;
            this.richTextBox1.Size = new System.Drawing.Size(360, 150);
            this.richTextBox1.TabIndex = 21;
            this.richTextBox1.Text = "Đây khung là hướng dẫn";
            this.richTextBox1.Visible = false;
            // 
            // labelMinMove
            // 
            this.labelMinMove.AutoSize = true;
            this.labelMinMove.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.labelMinMove.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelMinMove.Location = new System.Drawing.Point(735, 100);
            this.labelMinMove.Name = "labelMinMove";
            this.labelMinMove.Padding = new System.Windows.Forms.Padding(3, 6, 3, 6);
            this.labelMinMove.Size = new System.Drawing.Size(157, 36);
            this.labelMinMove.TabIndex = 22;
            this.labelMinMove.Text = "Tối thiểu: 0 bước";
            // 
            // FormGame
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(1200, 675);
            this.Controls.Add(this.labelMinMove);
            this.Controls.Add(this.richTextBox1);
            this.Controls.Add(this.cBoxPause);
            this.Controls.Add(this.labelCountMove);
            this.Controls.Add(this.lableTimer);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.numudNumPlate);
            this.Controls.Add(this.btnPause);
            this.Controls.Add(this.btnPlay);
            this.Controls.Add(this.btnGiveUp);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.plate5);
            this.Controls.Add(this.plate4);
            this.Controls.Add(this.plate3);
            this.Controls.Add(this.plate2);
            this.Controls.Add(this.plate1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.plate6);
            this.Controls.Add(this.plate7);
            this.Controls.Add(this.plate8);
            this.Controls.Add(this.RodC);
            this.Controls.Add(this.RodB);
            this.Controls.Add(this.RodA);
            this.Controls.Add(this.menuStrip1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menuStrip1;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.MaximizeBox = false;
            this.Name = "FormGame";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Game - Tháp Hà Nội";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.FormGame_FormClosing);
            ((System.ComponentModel.ISupportInitialize)(this.plate5)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.plate4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.plate3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.plate2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.plate1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.plate6)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.plate7)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.plate8)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.RodC)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.RodB)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.RodA)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numudNumPlate)).EndInit();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox RodA;
        private System.Windows.Forms.PictureBox RodB;
        private System.Windows.Forms.PictureBox RodC;
        private System.Windows.Forms.PictureBox plate8;
        private System.Windows.Forms.PictureBox plate7;
        private System.Windows.Forms.PictureBox plate6;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox plate1;
        private System.Windows.Forms.PictureBox plate2;
        private System.Windows.Forms.PictureBox plate3;
        private System.Windows.Forms.PictureBox plate4;
        private System.Windows.Forms.PictureBox plate5;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btnGiveUp;
        private System.Windows.Forms.Button btnPlay;
        private System.Windows.Forms.NumericUpDown numudNumPlate;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label lableTimer;
        private System.Windows.Forms.Label labelCountMove;
        private System.Windows.Forms.Timer timerCountTime;
        private System.Windows.Forms.Button btnPause;
        private System.Windows.Forms.CheckBox cBoxPause;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem lawToolStripMenuItem;
        private System.Windows.Forms.RichTextBox richTextBox1;
        private System.Windows.Forms.ToolStripMenuItem expToolStripMenuItem;
        private System.Windows.Forms.Label labelMinMove;
    }
}
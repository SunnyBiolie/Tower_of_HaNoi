using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TowerOfHanoi
{
    public partial class FormGame : Form
    {
        TimeSpan timer;
        bool isPlaying = false, isPause = false;
        int countMove;
        int minMove;
        PictureBox[] plates;
        Stack<PictureBox> towerA, towerB, towerC, fClickedPlates, sClickedPlates;
        const int fPlatePosY = 543, plateHeight = 28, plateRodDisX = (350 - 340) / 2;   // tọa độ y của đĩa đầu tiên trong stack, chiều cao của mỗi đĩa, khoảng cách giữa đĩa và trụ
        
        public FormGame()
        {
            InitializeComponent();
            plates = new PictureBox[] { plate1, plate2, plate3, plate4, plate5, plate6, plate7, plate8 };
            // Tag lưu trữ stack các đĩa của tháp 
            RodA.Tag = towerA = new Stack<PictureBox>();
            RodB.Tag = towerB = new Stack<PictureBox>();
            RodC.Tag = towerC = new Stack<PictureBox>();
        }

        private void timerCount_Tick(object sender, EventArgs e)
        {
            timer = timer.Add(new TimeSpan(0, 0, 1));
            lableTimer.Text = string.Format("Thời gian: {0:00}:{1:00}:{2:00}", timer.Hours, timer.Minutes, timer.Seconds);
        }
         
        private void FormGame_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (isPlaying || isPause)
            {
                DialogResult closeForm;
                closeForm = MessageBox.Show(
                    "Trò chơi vẫn chưa kết thúc, hệ thống sẽ không lưu tiến trình của bạn, bạn có thực sự muốn thoát",
                    "Thông báo",
                    MessageBoxButtons.YesNo,
                    MessageBoxIcon.Question
                    );
                if (closeForm == DialogResult.No)
                    e.Cancel = true;
            }
        }

        private void lawToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show(
                "Người chơi phải di chuyển toàn bộ số đĩa từ cột ban đầu (Tháp A) sang cột cuối cùng (Tháp C) với các quy tắc sau:\n - Mỗi lần chỉ được di chuyển một đĩa trên cùng\n - Mỗi đĩa chỉ có thể được đặt lên trên đĩa lớn hơn",
                "Luật chơi",
                MessageBoxButtons.OK,
                icon: MessageBoxIcon.Information);
        }
        
        private void expToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (expToolStripMenuItem.BackColor == SystemColors.GradientInactiveCaption)
                expToolStripMenuItem.BackColor = SystemColors.ActiveBorder;
            else if (expToolStripMenuItem.BackColor == SystemColors.ActiveBorder)
                expToolStripMenuItem.BackColor = SystemColors.GradientInactiveCaption;

            richTextBox1.Visible = !richTextBox1.Visible;
            richTextBox1.Text = $" - HƯỚNG DẪN ĐỐI VỚI {numudNumPlate.Value} ĐĨA\n";

            char a = 'A', b = 'B', c = 'C';
            int i = 0;
            solveThapHN((int)numudNumPlate.Value, a, b, c, ref i);
        }

        private void moveAction(int n, char first, char second, ref int i)
        {
            i++;
            richTextBox1.Text += ($" Step {i}:  Chuyển đĩa số  ({n})  từ tháp  {first} --> {second}\n");
        }

        private void solveThapHN(int n, char start, char mid, char end, ref int i)
        {
            if (n == 1) moveAction(1, start, end, ref i);
            else
            {
                solveThapHN(n - 1, start, end, mid, ref i);
                moveAction(n, start, end, ref i);
                solveThapHN(n - 1, mid, start, end, ref i);
            }
        }

        private void btnPlay_Click(object sender, EventArgs e)
        {
            // reset game về trạng thái ban đầu
            timerCountTime.Stop();
            countMove = 0;
            timer = new TimeSpan(0);
            minMove = (int)Math.Pow(2, (double)numudNumPlate.Value) - 1;
            lableTimer.Text = "Thời gian: 00:00:00";
            labelCountMove.Text = $"Số lượt di chuyển: 0 lần";

            foreach (PictureBox plate in plates)
                plate.Visible = false;
            towerA.Clear(); towerB.Clear(); towerC.Clear();
            fClickedPlates = sClickedPlates = null;
            RodA.BorderStyle = RodB.BorderStyle = RodC.BorderStyle = BorderStyle.None;

            // khởi tạo game mới
            isPlaying = true;
            isPause = false;

            expToolStripMenuItem.Enabled = true;
            labelMinMove.Text = $"Tối thiểu: {minMove} bước";
            numudNumPlate.Enabled = false;
            btnPlay.Text = "Chơi lại";
            cBoxPause.Checked = false;
            btnPause.Enabled = true;
            btnPause.Text = "Tạm dừng";
            btnGiveUp.Enabled = true;

            generatePlates();

            timerCountTime.Start();
        }

        private void generatePlates()   // khởi tạo các đĩa
        {
            int x = RodA.Location.X + plateRodDisX;
            int y = fPlatePosY;
            for (int i = (int)numudNumPlate.Value - 1; i >= 0; i--, y -= plateHeight)
            {
                plates[i].Location = new Point(x, y);
                plates[i].Visible = true;

                towerA.Push(plates[i]);
            }
        }

        private void btnPause_Click(object sender, EventArgs e)
        {
            isPlaying = !isPlaying;
            isPause = !isPause;

            cBoxPause.Checked = !cBoxPause.Checked;

            if (cBoxPause.Checked)
            {
                timerCountTime.Stop();
                btnPause.Text = "Tiếp tục";
            }
            else
            {
                timerCountTime.Start();
                btnPause.Text = "Tạm dừng";
            }
        }

        private void btnGiveUp_Click(object sender, EventArgs e)
        {
            isPlaying = false;
            isPause = false;
            timerCountTime.Stop();

            expToolStripMenuItem.BackColor = SystemColors.GradientInactiveCaption;
            expToolStripMenuItem.Enabled = false;
            richTextBox1.Visible = false;

            numudNumPlate.Enabled = true;
            btnPlay.Text = "Bắt đầu";
            btnPause.Enabled = false;
            btnGiveUp.Enabled = false;
        }

        private void Rod_Click(object sender, EventArgs e)
        {
            if (!isPlaying) return;  // không cho tương tác khi người dùng chưa chơi

            PictureBox clickedRod = (PictureBox)sender; // trỏ đến chính xác Rod được click
            Stack<PictureBox> clickedRodPlates = (Stack<PictureBox>)clickedRod.Tag; // stack lưu các đĩa của chính xác rod được click

            if (fClickedPlates == null) // chưa chọn cọc cần di chuyển đĩa (chọn cọc thứ nhất)
            {
                if (clickedRodPlates.Count == 0) return;

                fClickedPlates = clickedRodPlates;
                clickedRod.BorderStyle = BorderStyle.FixedSingle;
            }
            else    // chọn cọc cần chuyển đĩa đến (chọn cọc thứ hai)
            {
                if (sClickedPlates == null)
                {
                    if (clickedRodPlates == fClickedPlates) // hủy chọn tháp cần di chuyển
                    {
                        fClickedPlates = null;
                        clickedRod.BorderStyle = BorderStyle.None;
                        return;
                    }
                    sClickedPlates = clickedRodPlates;
                    ChecknMovePlate(clickedRod);
                }
            }
        }

        private void ChecknMovePlate(PictureBox clickedRod)
        {
            if (sClickedPlates.Count == 0)
                MovePlate(new Point(clickedRod.Location.X + plateRodDisX, fPlatePosY));
            else
            {
                PictureBox fRod_TopPlate = fClickedPlates.Peek();
                PictureBox sRod_TopPlate = sClickedPlates.Peek();
                if (Convert.ToInt32(fRod_TopPlate.Tag.ToString()) < Convert.ToInt32(sRod_TopPlate.Tag.ToString()))
                {
                    MovePlate(new Point(sRod_TopPlate.Location.X, sRod_TopPlate.Location.Y - plateHeight));
                }
                else
                    sClickedPlates = null;  // bỏ đánh dấu lần chọn cọc thứ hai
            }
        }

        private void MovePlate(Point point)
        {
            PictureBox fRod_TopPlate = fClickedPlates.Pop();
            fRod_TopPlate.Location = point;
            sClickedPlates.Push(fRod_TopPlate);

            fClickedPlates = sClickedPlates = null;
            countMove++;
            labelCountMove.Text = String.Format($"Số lần di chuyển: {countMove} lần");
            RodA.BorderStyle = RodB.BorderStyle = RodC.BorderStyle = BorderStyle.None;

            // Kiểm tra để kết thúc trò chơi (người chơi thắng)
            if (towerC.Count == numudNumPlate.Value)
            {
                btnGiveUp.PerformClick();
                MessageBox.Show($"Chúc mừng bạn đã hoàn thành trò chơi với số bước di chuyển là {countMove}, với số bước tối thiểu cho {numudNumPlate.Value} đĩa là {minMove} bước", "Congratulations");
            }
        }

        private void plate_Click(object sender, EventArgs e)
        {
            PictureBox plateClicked = (PictureBox)sender;
            if (towerA.Contains(plateClicked))
                Rod_Click(RodA, new EventArgs());
            else if (towerB.Contains(plateClicked))
                Rod_Click(RodB, new EventArgs());
            else
                Rod_Click(RodC, new EventArgs());
        }
    
    }
}
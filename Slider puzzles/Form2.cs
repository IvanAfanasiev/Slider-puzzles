using System;
using System.Drawing;
using System.Windows.Forms;
using System.Resources;
using System.Reflection;

namespace Slider_puzzles
{
    public partial class GameForm : Form
    {
        int time = 0;
        int moves = 0;
        public ImageList imgList;
        public Image currentImage;
        public Image emptyImage;
        byte emptySlotIndx = 8;
        public GameForm()
        {
            InitializeComponent();
            timerLabel.Text = "timer: 00:00";
            movesLabel.Text = "moves: 0";
            emptyImage = Properties.Resources.emptySlot;
        }
        public void Setup()
        {
            ConvertImageToList();
        }

        void ConvertImageToList()
        {
            imageList.Images.Clear();
            //rows
            for (int i = 0; i < 3; i++)
            {
                //columns
                for (int j = 0; j < 3; j++)
                {
                    Rectangle rectCropArea = new Rectangle((currentImage.Width / 3) * i, (currentImage.Width / 3) * j, currentImage.Width/3, currentImage.Height/3);
                    Bitmap bit = new Bitmap(currentImage, currentImage.Width, currentImage.Height);
                    Bitmap crop = new Bitmap(currentImage.Width / 3, currentImage.Height / 3);
                    Graphics g = Graphics.FromImage(crop);
                    g.DrawImage(bit, 0, 0, rectCropArea, GraphicsUnit.Pixel);
                    imageList.Images.Add(crop);
                }
            }
            imageList.Images.RemoveAt(8);
            imageList.Images.Add(emptyImage);
            BuildField();
        }

        void BuildField()
        {
            int indx = 0;
            foreach (Image img in imageList.Images)
            {
                PictureBox newPicture = new PictureBox();
                newPicture.Tag = indx;
                indx++;
                newPicture.Parent = flowLayoutPanel;
                newPicture.Margin = new Padding(0);
                newPicture.Size = new Size(flowLayoutPanel.Width / 3, flowLayoutPanel.Height / 3);
                newPicture.Image = img;
                newPicture.SizeMode = PictureBoxSizeMode.StretchImage;
                newPicture.BackColor = SystemColors.ActiveBorder;
                newPicture.Click += MakeMove;
            }

        }

        void MakeMove(object sender, EventArgs e)
        {
            PictureBox currentPicture = (PictureBox)sender;
            label1.Text = CanMove((int)currentPicture.Tag).ToString();
            if (!CanMove((int)currentPicture.Tag)) return;

            moves++;
            movesLabel.Text = "moves: " + moves;


        }

        bool CanMove(int indx)
        {
            //empty slot on top
            if (indx -3 == emptySlotIndx) return true;
            //empty slot at the bottom
            else if (indx + 3 == emptySlotIndx) return true;
            //empty slot on the left 
            else if (indx - 1 == emptySlotIndx && indx%3 != 0) return true;
            //empty slot on the right 
            else if (indx + 1 == emptySlotIndx && indx != 2 && indx != 5 && indx != 8) return true;

            return false;
        }


        private void gameTimer_Tick(object sender, EventArgs e)
        {
            timerLabel.Text = "timer: " + ConvertIntToTime(++time);
        }
        string ConvertIntToTime(int value)
        {
            return (value / 60).ToString("0#:") + (value % 60).ToString("0#");
        }


        private void GameForm_Leave(object sender, EventArgs e)
        {
            this.Hide();
        }

        private void GameForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }
    }
}

using System;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;

namespace Slider_puzzles
{
    public partial class GameForm : Form
    {
        bool isWin = false;
        int time = 0;
        int moves = 0;
        public Image currentImage;
        public Image emptyImage;
        int emptySlotIndx;
        public int fieldSize = 3;
        int[] field = new int[25];
        int[] answer = new int[25];

        public GameForm()
        {
            InitializeComponent(); 
            emptyImage = Properties.Resources.emptySlot;
        }
        public void Setup()
        {
            emptySlotIndx = (int)Math.Pow(fieldSize, 2) - 1;
            for (int i = 0; i <= emptySlotIndx; i++)
            {
                field[i] = i;
                answer[i] = i;
            }

            this.AllowTransparency = true;
            ConvertImageToList();
        }

        //divides the image into (fieldSize^2) equal parts 
        void ConvertImageToList()
        {
            imageList.Images.Clear();
            Random rand = new Random();
            //rows
            for (int i = 0; i < fieldSize; i++)
            {
                //columns
                for (int j = 0; j < fieldSize; j++)
                {
                    Rectangle rectCropArea = new Rectangle((currentImage.Width / fieldSize - 4) * j, (currentImage.Width / fieldSize - 4) * i, currentImage.Width/ fieldSize, currentImage.Height/ fieldSize);
                    Bitmap bit = new Bitmap(currentImage, currentImage.Width, currentImage.Height);
                    Bitmap crop = new Bitmap(currentImage.Width / fieldSize - 4, currentImage.Height / fieldSize - 4);
                    Graphics g = Graphics.FromImage(crop);
                    g.DrawImage(bit, 0, 0, rectCropArea, GraphicsUnit.Pixel);
                    imageList.Images.Add(crop);
                }
            }

            //randomize all cells;
            for (int i = imageList.Images.Count - 1; i >= 0; i--)
            {
                int j = rand.Next(i + 1);
                Image tmp = imageList.Images[j];
                imageList.Images[j] = imageList.Images[i];
                imageList.Images[i] = tmp;

                int tmpInt = field[j];
                field[j] = field[i];
                field[i] = tmpInt;
            }
            imageList.Images[(int)Math.Pow(fieldSize, 2) - 1] = emptyImage;
            DrawField();
        }

        string ConvertIntToTime(int value)
        {
            return (value / 60).ToString("0#:") + (value % 60).ToString("0#");
        }

        void DrawField()
        {
            flowLayoutPanel.Controls.Clear();
            int indx = 0;
            foreach (Image img in imageList.Images)
            {
                PictureBox newPicture = new PictureBox();
                newPicture.Tag = indx;
                indx++;
                newPicture.Parent = flowLayoutPanel;
                newPicture.Margin = new Padding(2);
                newPicture.Size = new Size(flowLayoutPanel.Width / fieldSize - 4, flowLayoutPanel.Height / fieldSize - 4);
                newPicture.Image = img;
                newPicture.SizeMode = PictureBoxSizeMode.Zoom;
                newPicture.BackColor = SystemColors.ActiveBorder;
                newPicture.Click += MakeMove;
            }
        }

        void MakeMove(object sender, EventArgs e)
        {
            if (isWin) return;
            PictureBox currentPicture = (PictureBox)sender;
            int imgIndx = (int)currentPicture.Tag;

            if (!CanMove(imgIndx)) return;

            imageList.Images[emptySlotIndx] = imageList.Images[imgIndx];
            imageList.Images[imgIndx] = emptyImage;

            int tmp = field[imgIndx];
            field[imgIndx] = field[emptySlotIndx];
            field[emptySlotIndx] = tmp;

            emptySlotIndx = imgIndx;

            DrawField();

            moves++;
            movesLabel.Text = "moves: " + moves;

            if (IsWin())
            {
                isWin = true;
                label1.Text = "You win!";
                menu_button.Visible = true;
                restart_button.Visible = true;
                backButton.Visible = false;
            }
        }

        bool IsWin()
        {
            return field.SequenceEqual(answer);
        }

        bool CanMove(int indx)
        {
            //empty slot on top
            if (indx - fieldSize == emptySlotIndx) return true;
            //empty slot at the bottom
            else if (indx + fieldSize == emptySlotIndx) return true;
            //empty slot on the left 
            else if (indx - 1 == emptySlotIndx && indx % fieldSize != 0) return true;
            //empty slot on the right 
            else if (indx + 1 == emptySlotIndx && (indx+1) % fieldSize != 0) return true;

            return false;
        }

        private void gameTimer_Tick(object sender, EventArgs e)
        {
            if (isWin) return;
            timerLabel.Text = "timer: " + ConvertIntToTime(++time);
        }

        private void GameForm_Leave(object sender, EventArgs e)
        {
            this.Hide();
        }

        private void GameForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }

        private void menu_button_Click(object sender, EventArgs e)
        {
            OpenMenu();
        }

        private void restart_button_Click(object sender, EventArgs e)
        {
            this.Hide();
            GameForm gameForm = new GameForm();
            gameForm.Location = this.Location;
            gameForm.currentImage = currentImage;
            gameForm.fieldSize = fieldSize;
            gameForm.Setup();
            gameForm.Show();
        }

        private void backButton_Click(object sender, EventArgs e)
        {
            OpenMenu();
        }

        void OpenMenu()
        {
            this.Hide();
            MainMenu menuForm = new MainMenu();
            menuForm.Show();
        }
    }
}

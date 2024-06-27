using System;
using System.Drawing;
using System.Windows.Forms;

namespace Slider_puzzles
{
    public partial class MainMenu : Form
    {
        Image currentImage;
        int fieldSize = 3;

        public MainMenu()
        {
            InitializeComponent();
            LoadImages();
            BuildImagesList();
            BGpicture.SendToBack();
        }

        void LoadImages()
        {
            imageList.Images.Add(Properties.Resources._1);
            imageList.Images.Add(Properties.Resources._2);
            imageList.Images.Add(Properties.Resources._3);
            imageList.Images.Add(Properties.Resources._4);
            imageList.Images.Add(Properties.Resources._5);
            imageList.Images.Add(Properties.Resources._6);
            imageList.Images.Add(Properties.Resources._7);
        }
        void BuildImagesList()
        {
            foreach (Image img in imageList.Images)
            {
                PictureBox newPicture = new PictureBox();
                newPicture.Parent = flowLayoutPanel;
                newPicture.Margin = new Padding(15);
                newPicture.Size = new Size(100, 100);
                newPicture.Image = img;
                newPicture.SizeMode = PictureBoxSizeMode.StretchImage;
                newPicture.BackColor = SystemColors.ActiveBorder;
                newPicture.Cursor = Cursors.Hand;
                newPicture.Click += SetNewCurrentImage;
            }
            currentImage = imageList.Images[0];
            BGpicture.Image = currentImage;
        }

        void SetNewCurrentImage(object sender, EventArgs e)
        {
            PictureBox currentPicture = (PictureBox)sender;
            currentImage = currentPicture.Image;
            BGpicture.Image = currentImage;
        }

        private void startGame_button_Click(object sender, EventArgs e)
        {
            StartGame();
        }

        void StartGame()
        {
            this.Hide();
            GameForm gameForm = new GameForm();
            gameForm.Location = this.Location;
            gameForm.currentImage = currentImage;
            gameForm.fieldSize = fieldSize;
            gameForm.Setup();
            gameForm.Show();
        }

        void ChangeCurrentImage(int imgIndx)
        {
            currentImage = imageList.Images[imgIndx];
        }

        private void FileUpload_button_Click(object sender, EventArgs e)
        {
            openFileDialog.ShowDialog(this);
            if (openFileDialog.FileName == "") return;
            Image img = Image.FromFile(openFileDialog.FileName);
            AddNewImage(img);
        }
        void AddNewImage(Image newImage)
        {
            imageList.Images.Add(newImage);
            flowLayoutPanel.Controls.Clear();
            BuildImagesList();
        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
            fieldSize = 2;
        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {
            fieldSize = 3;
        }

        private void radioButton3_CheckedChanged(object sender, EventArgs e)
        {
            fieldSize = 4;
        }
    }
}

namespace Slider_puzzles
{
    partial class Form1
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.startGame_button = new System.Windows.Forms.Button();
            this.imageList = new System.Windows.Forms.ImageList(this.components);
            this.flowLayoutPanel = new System.Windows.Forms.FlowLayoutPanel();
            this.openFileDialog = new System.Windows.Forms.OpenFileDialog();
            this.FileUpload_button = new System.Windows.Forms.Button();
            this.BGpicture = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.BGpicture)).BeginInit();
            this.SuspendLayout();
            // 
            // startGame_button
            // 
            this.startGame_button.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.startGame_button.Location = new System.Drawing.Point(225, 50);
            this.startGame_button.Name = "startGame_button";
            this.startGame_button.Size = new System.Drawing.Size(250, 50);
            this.startGame_button.TabIndex = 0;
            this.startGame_button.Text = "Start game";
            this.startGame_button.UseVisualStyleBackColor = true;
            this.startGame_button.Click += new System.EventHandler(this.startGame_button_Click);
            // 
            // imageList
            // 
            this.imageList.ColorDepth = System.Windows.Forms.ColorDepth.Depth24Bit;
            this.imageList.ImageSize = new System.Drawing.Size(256, 256);
            this.imageList.TransparentColor = System.Drawing.Color.Transparent;
            // 
            // flowLayoutPanel
            // 
            this.flowLayoutPanel.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.flowLayoutPanel.AutoScroll = true;
            this.flowLayoutPanel.AutoScrollMinSize = new System.Drawing.Size(100, 100);
            this.flowLayoutPanel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.flowLayoutPanel.Location = new System.Drawing.Point(12, 250);
            this.flowLayoutPanel.Name = "flowLayoutPanel";
            this.flowLayoutPanel.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.flowLayoutPanel.Size = new System.Drawing.Size(658, 191);
            this.flowLayoutPanel.TabIndex = 4;
            this.flowLayoutPanel.WrapContents = false;
            // 
            // openFileDialog
            // 
            this.openFileDialog.Filter = "*.jpg|*.png";
            // 
            // FileUpload_button
            // 
            this.FileUpload_button.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.FileUpload_button.Location = new System.Drawing.Point(275, 196);
            this.FileUpload_button.Name = "FileUpload_button";
            this.FileUpload_button.Size = new System.Drawing.Size(150, 48);
            this.FileUpload_button.TabIndex = 5;
            this.FileUpload_button.Text = "Add own image";
            this.FileUpload_button.UseVisualStyleBackColor = true;
            this.FileUpload_button.Click += new System.EventHandler(this.FileUpload_button_Click);
            // 
            // BGpicture
            // 
            this.BGpicture.Dock = System.Windows.Forms.DockStyle.Fill;
            this.BGpicture.Location = new System.Drawing.Point(0, 0);
            this.BGpicture.Name = "BGpicture";
            this.BGpicture.Size = new System.Drawing.Size(682, 453);
            this.BGpicture.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.BGpicture.TabIndex = 6;
            this.BGpicture.TabStop = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(682, 453);
            this.Controls.Add(this.BGpicture);
            this.Controls.Add(this.FileUpload_button);
            this.Controls.Add(this.flowLayoutPanel);
            this.Controls.Add(this.startGame_button);
            this.MaximumSize = new System.Drawing.Size(1000, 500);
            this.MinimizeBox = false;
            this.MinimumSize = new System.Drawing.Size(500, 500);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.BGpicture)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button startGame_button;
        private System.Windows.Forms.ImageList imageList;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel;
        private System.Windows.Forms.OpenFileDialog openFileDialog;
        private System.Windows.Forms.Button FileUpload_button;
        private System.Windows.Forms.PictureBox BGpicture;
    }
}


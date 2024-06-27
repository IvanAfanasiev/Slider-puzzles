namespace Slider_puzzles
{
    partial class MainMenu
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
            this.label1 = new System.Windows.Forms.Label();
            this.radioButton1 = new System.Windows.Forms.RadioButton();
            this.radioButton2 = new System.Windows.Forms.RadioButton();
            this.radioButton3 = new System.Windows.Forms.RadioButton();
            this.label2 = new System.Windows.Forms.Label();
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
            this.imageList.ColorDepth = System.Windows.Forms.ColorDepth.Depth32Bit;
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
            this.FileUpload_button.Location = new System.Drawing.Point(562, 196);
            this.FileUpload_button.Name = "FileUpload_button";
            this.FileUpload_button.Size = new System.Drawing.Size(108, 48);
            this.FileUpload_button.TabIndex = 5;
            this.FileUpload_button.Text = "Add own image";
            this.FileUpload_button.UseVisualStyleBackColor = true;
            this.FileUpload_button.Click += new System.EventHandler(this.FileUpload_button_Click);
            // 
            // BGpicture
            // 
            this.BGpicture.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.BGpicture.BackColor = System.Drawing.SystemColors.ControlLight;
            this.BGpicture.Location = new System.Drawing.Point(115, 124);
            this.BGpicture.Name = "BGpicture";
            this.BGpicture.Size = new System.Drawing.Size(120, 120);
            this.BGpicture.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.BGpicture.TabIndex = 6;
            this.BGpicture.TabStop = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 228);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(97, 16);
            this.label1.TabIndex = 7;
            this.label1.Text = "Chosen image:";
            // 
            // radioButton1
            // 
            this.radioButton1.AutoSize = true;
            this.radioButton1.Location = new System.Drawing.Point(318, 147);
            this.radioButton1.Name = "radioButton1";
            this.radioButton1.Size = new System.Drawing.Size(48, 20);
            this.radioButton1.TabIndex = 8;
            this.radioButton1.TabStop = true;
            this.radioButton1.Text = "2x2";
            this.radioButton1.UseVisualStyleBackColor = true;
            this.radioButton1.CheckedChanged += new System.EventHandler(this.radioButton1_CheckedChanged);
            // 
            // radioButton2
            // 
            this.radioButton2.AutoSize = true;
            this.radioButton2.Checked = true;
            this.radioButton2.Location = new System.Drawing.Point(318, 173);
            this.radioButton2.Name = "radioButton2";
            this.radioButton2.Size = new System.Drawing.Size(48, 20);
            this.radioButton2.TabIndex = 9;
            this.radioButton2.TabStop = true;
            this.radioButton2.Text = "3x3";
            this.radioButton2.UseVisualStyleBackColor = true;
            this.radioButton2.CheckedChanged += new System.EventHandler(this.radioButton2_CheckedChanged);
            // 
            // radioButton3
            // 
            this.radioButton3.AutoSize = true;
            this.radioButton3.Location = new System.Drawing.Point(318, 199);
            this.radioButton3.Name = "radioButton3";
            this.radioButton3.Size = new System.Drawing.Size(48, 20);
            this.radioButton3.TabIndex = 10;
            this.radioButton3.TabStop = true;
            this.radioButton3.Text = "4x4";
            this.radioButton3.UseVisualStyleBackColor = true;
            this.radioButton3.CheckedChanged += new System.EventHandler(this.radioButton3_CheckedChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(315, 124);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(67, 16);
            this.label2.TabIndex = 11;
            this.label2.Text = "Field size:";
            // 
            // MainMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(682, 453);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.radioButton3);
            this.Controls.Add(this.radioButton2);
            this.Controls.Add(this.radioButton1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.BGpicture);
            this.Controls.Add(this.FileUpload_button);
            this.Controls.Add(this.flowLayoutPanel);
            this.Controls.Add(this.startGame_button);
            this.MaximumSize = new System.Drawing.Size(700, 500);
            this.MinimizeBox = false;
            this.MinimumSize = new System.Drawing.Size(700, 500);
            this.Name = "MainMenu";
            this.Text = "Menu";
            ((System.ComponentModel.ISupportInitialize)(this.BGpicture)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button startGame_button;
        private System.Windows.Forms.ImageList imageList;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel;
        private System.Windows.Forms.OpenFileDialog openFileDialog;
        private System.Windows.Forms.Button FileUpload_button;
        private System.Windows.Forms.PictureBox BGpicture;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.RadioButton radioButton1;
        private System.Windows.Forms.RadioButton radioButton2;
        private System.Windows.Forms.RadioButton radioButton3;
        private System.Windows.Forms.Label label2;
    }
}


namespace Slider_puzzles
{
    partial class GameForm
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
            this.timerLabel = new System.Windows.Forms.Label();
            this.movesLabel = new System.Windows.Forms.Label();
            this.flowLayoutPanel = new System.Windows.Forms.FlowLayoutPanel();
            this.imageList = new System.Windows.Forms.ImageList(this.components);
            this.gameTimer = new System.Windows.Forms.Timer(this.components);
            this.openFileDialog = new System.Windows.Forms.OpenFileDialog();
            this.label1 = new System.Windows.Forms.Label();
            this.menu_button = new System.Windows.Forms.Button();
            this.restart_button = new System.Windows.Forms.Button();
            this.backButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // timerLabel
            // 
            this.timerLabel.AutoSize = true;
            this.timerLabel.Location = new System.Drawing.Point(12, 9);
            this.timerLabel.Name = "timerLabel";
            this.timerLabel.Size = new System.Drawing.Size(73, 16);
            this.timerLabel.TabIndex = 0;
            this.timerLabel.Text = "timer: 00:00";
            // 
            // movesLabel
            // 
            this.movesLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.movesLabel.Location = new System.Drawing.Point(374, 9);
            this.movesLabel.Name = "movesLabel";
            this.movesLabel.Size = new System.Drawing.Size(146, 16);
            this.movesLabel.TabIndex = 1;
            this.movesLabel.Text = "moves: 0";
            this.movesLabel.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // flowLayoutPanel
            // 
            this.flowLayoutPanel.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.flowLayoutPanel.Location = new System.Drawing.Point(20, 91);
            this.flowLayoutPanel.Name = "flowLayoutPanel";
            this.flowLayoutPanel.Size = new System.Drawing.Size(500, 500);
            this.flowLayoutPanel.TabIndex = 2;
            // 
            // imageList
            // 
            this.imageList.ColorDepth = System.Windows.Forms.ColorDepth.Depth32Bit;
            this.imageList.ImageSize = new System.Drawing.Size(256, 256);
            this.imageList.TransparentColor = System.Drawing.Color.Transparent;
            // 
            // gameTimer
            // 
            this.gameTimer.Enabled = true;
            this.gameTimer.Interval = 1000;
            this.gameTimer.Tick += new System.EventHandler(this.gameTimer_Tick);
            // 
            // openFileDialog
            // 
            this.openFileDialog.FileName = "openFileDialog1";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label1.Location = new System.Drawing.Point(212, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(95, 25);
            this.label1.TabIndex = 3;
            this.label1.Text = "You win!";
            this.label1.Visible = false;
            // 
            // menu_button
            // 
            this.menu_button.Cursor = System.Windows.Forms.Cursors.Hand;
            this.menu_button.Location = new System.Drawing.Point(152, 49);
            this.menu_button.Name = "menu_button";
            this.menu_button.Size = new System.Drawing.Size(90, 36);
            this.menu_button.TabIndex = 4;
            this.menu_button.Text = "Main menu";
            this.menu_button.UseVisualStyleBackColor = true;
            this.menu_button.Visible = false;
            this.menu_button.Click += new System.EventHandler(this.menu_button_Click);
            // 
            // restart_button
            // 
            this.restart_button.Cursor = System.Windows.Forms.Cursors.Hand;
            this.restart_button.Location = new System.Drawing.Point(267, 49);
            this.restart_button.Name = "restart_button";
            this.restart_button.Size = new System.Drawing.Size(90, 36);
            this.restart_button.TabIndex = 5;
            this.restart_button.Text = "Restart";
            this.restart_button.UseVisualStyleBackColor = true;
            this.restart_button.Visible = false;
            this.restart_button.Click += new System.EventHandler(this.restart_button_Click);
            // 
            // backButton
            // 
            this.backButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.backButton.Location = new System.Drawing.Point(20, 28);
            this.backButton.Name = "backButton";
            this.backButton.Size = new System.Drawing.Size(90, 57);
            this.backButton.TabIndex = 6;
            this.backButton.Text = "Back to the menu";
            this.backButton.UseVisualStyleBackColor = true;
            this.backButton.Click += new System.EventHandler(this.backButton_Click);
            // 
            // GameForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(532, 603);
            this.Controls.Add(this.backButton);
            this.Controls.Add(this.restart_button);
            this.Controls.Add(this.menu_button);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.flowLayoutPanel);
            this.Controls.Add(this.movesLabel);
            this.Controls.Add(this.timerLabel);
            this.MinimumSize = new System.Drawing.Size(550, 650);
            this.Name = "GameForm";
            this.Text = "Game";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.GameForm_FormClosed);
            this.Leave += new System.EventHandler(this.GameForm_Leave);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label timerLabel;
        private System.Windows.Forms.Label movesLabel;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel;
        private System.Windows.Forms.ImageList imageList;
        private System.Windows.Forms.Timer gameTimer;
        private System.Windows.Forms.OpenFileDialog openFileDialog;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button menu_button;
        private System.Windows.Forms.Button restart_button;
        private System.Windows.Forms.Button backButton;
    }
}
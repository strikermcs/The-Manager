namespace Meneger
{
    partial class DealForm
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label2 = new System.Windows.Forms.Label();
            this.ActivePriceBox = new System.Windows.Forms.MaskedTextBox();
            this.SellButton = new System.Windows.Forms.Button();
            this.StocksListBoxAct = new System.Windows.Forms.ListBox();
            this.ActivePlayerNameLab = new System.Windows.Forms.Label();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.label3 = new System.Windows.Forms.Label();
            this.BayTextBox = new System.Windows.Forms.MaskedTextBox();
            this.BayButton = new System.Windows.Forms.Button();
            this.PlayerListBox = new System.Windows.Forms.ComboBox();
            this.StockListBox = new System.Windows.Forms.ListBox();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.ActivePriceBox);
            this.groupBox1.Controls.Add(this.SellButton);
            this.groupBox1.Controls.Add(this.StocksListBoxAct);
            this.groupBox1.Controls.Add(this.ActivePlayerNameLab);
            this.groupBox1.Controls.Add(this.pictureBox2);
            this.groupBox1.Location = new System.Drawing.Point(22, 14);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(379, 432);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.Location = new System.Drawing.Point(331, 235);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(28, 16);
            this.label2.TabIndex = 6;
            this.label2.Text = "АС";
            // 
            // ActivePriceBox
            // 
            this.ActivePriceBox.Location = new System.Drawing.Point(284, 231);
            this.ActivePriceBox.Mask = "00000";
            this.ActivePriceBox.Name = "ActivePriceBox";
            this.ActivePriceBox.Size = new System.Drawing.Size(39, 20);
            this.ActivePriceBox.TabIndex = 4;
            this.ActivePriceBox.ValidatingType = typeof(int);
            // 
            // SellButton
            // 
            this.SellButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.SellButton.Enabled = false;
            this.SellButton.Location = new System.Drawing.Point(263, 189);
            this.SellButton.Name = "SellButton";
            this.SellButton.Size = new System.Drawing.Size(92, 33);
            this.SellButton.TabIndex = 3;
            this.SellButton.Text = "Продать";
            this.SellButton.UseVisualStyleBackColor = true;
            this.SellButton.Click += new System.EventHandler(this.SellButton_Click);
            // 
            // StocksListBoxAct
            // 
            this.StocksListBoxAct.FormattingEnabled = true;
            this.StocksListBoxAct.Location = new System.Drawing.Point(27, 178);
            this.StocksListBoxAct.Name = "StocksListBoxAct";
            this.StocksListBoxAct.Size = new System.Drawing.Size(216, 225);
            this.StocksListBoxAct.TabIndex = 2;
            this.StocksListBoxAct.SelectedIndexChanged += new System.EventHandler(this.StocksListBoxAct_SelectedIndexChanged);
            // 
            // ActivePlayerNameLab
            // 
            this.ActivePlayerNameLab.AutoSize = true;
            this.ActivePlayerNameLab.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.ActivePlayerNameLab.Location = new System.Drawing.Point(160, 153);
            this.ActivePlayerNameLab.Name = "ActivePlayerNameLab";
            this.ActivePlayerNameLab.Size = new System.Drawing.Size(51, 16);
            this.ActivePlayerNameLab.TabIndex = 1;
            this.ActivePlayerNameLab.Text = "label1";
            this.ActivePlayerNameLab.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = global::Meneger.IconsRes.iconfinder_indian_man_male_person_4043256;
            this.pictureBox2.Location = new System.Drawing.Point(102, 19);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(173, 120);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox2.TabIndex = 0;
            this.pictureBox2.TabStop = false;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.label3);
            this.groupBox2.Controls.Add(this.BayTextBox);
            this.groupBox2.Controls.Add(this.BayButton);
            this.groupBox2.Controls.Add(this.PlayerListBox);
            this.groupBox2.Controls.Add(this.StockListBox);
            this.groupBox2.Controls.Add(this.pictureBox3);
            this.groupBox2.Location = new System.Drawing.Point(499, 14);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(379, 432);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label3.Location = new System.Drawing.Point(340, 235);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(28, 16);
            this.label3.TabIndex = 8;
            this.label3.Text = "АС";
            // 
            // BayTextBox
            // 
            this.BayTextBox.Location = new System.Drawing.Point(293, 231);
            this.BayTextBox.Mask = "00000";
            this.BayTextBox.Name = "BayTextBox";
            this.BayTextBox.Size = new System.Drawing.Size(39, 20);
            this.BayTextBox.TabIndex = 7;
            this.BayTextBox.ValidatingType = typeof(int);
            // 
            // BayButton
            // 
            this.BayButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BayButton.Enabled = false;
            this.BayButton.Location = new System.Drawing.Point(268, 189);
            this.BayButton.Name = "BayButton";
            this.BayButton.Size = new System.Drawing.Size(92, 33);
            this.BayButton.TabIndex = 4;
            this.BayButton.Text = "Купить";
            this.BayButton.UseVisualStyleBackColor = true;
            this.BayButton.Click += new System.EventHandler(this.BayButton_Click);
            // 
            // PlayerListBox
            // 
            this.PlayerListBox.Cursor = System.Windows.Forms.Cursors.Hand;
            this.PlayerListBox.FormattingEnabled = true;
            this.PlayerListBox.Location = new System.Drawing.Point(110, 149);
            this.PlayerListBox.Name = "PlayerListBox";
            this.PlayerListBox.Size = new System.Drawing.Size(172, 21);
            this.PlayerListBox.TabIndex = 4;
            this.PlayerListBox.SelectedIndexChanged += new System.EventHandler(this.PlayerListBox_SelectedIndexChanged);
            // 
            // StockListBox
            // 
            this.StockListBox.FormattingEnabled = true;
            this.StockListBox.Location = new System.Drawing.Point(33, 178);
            this.StockListBox.Name = "StockListBox";
            this.StockListBox.Size = new System.Drawing.Size(216, 225);
            this.StockListBox.TabIndex = 3;
            this.StockListBox.SelectedIndexChanged += new System.EventHandler(this.StockListBox_SelectedIndexChanged);
            // 
            // pictureBox3
            // 
            this.pictureBox3.Image = global::Meneger.IconsRes.iconfinder_male3_403019;
            this.pictureBox3.Location = new System.Drawing.Point(110, 19);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(173, 120);
            this.pictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox3.TabIndex = 0;
            this.pictureBox3.TabStop = false;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::Meneger.IconsRes.iconfinder_Arrows_Refresh_Replace_Round_Circle_1329089;
            this.pictureBox1.Location = new System.Drawing.Point(414, 167);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(73, 98);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 2;
            this.pictureBox1.TabStop = false;
            // 
            // DealForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(907, 482);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "DealForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Сделка";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button SellButton;
        private System.Windows.Forms.ListBox StocksListBoxAct;
        private System.Windows.Forms.Label ActivePlayerNameLab;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Button BayButton;
        private System.Windows.Forms.ComboBox PlayerListBox;
        private System.Windows.Forms.ListBox StockListBox;
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.MaskedTextBox ActivePriceBox;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.MaskedTextBox BayTextBox;
    }
}
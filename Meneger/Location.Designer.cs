namespace Meneger
{
    partial class Locationmy
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
            this.AboutText = new System.Windows.Forms.RichTextBox();
            this.UserNameLabel = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.QuantityHauseLabel = new System.Windows.Forms.Label();
            this.QuantityHotelLabel = new System.Windows.Forms.Label();
            this.CloseButton = new System.Windows.Forms.Button();
            this.BuyHotelButton = new System.Windows.Forms.Button();
            this.BuyHouseButton = new System.Windows.Forms.Button();
            this.HotelBox = new System.Windows.Forms.PictureBox();
            this.HouseBox = new System.Windows.Forms.PictureBox();
            this.PlayerBox = new System.Windows.Forms.PictureBox();
            this.CanselSaleButton = new System.Windows.Forms.Button();
            this.BuyLayButton = new System.Windows.Forms.Button();
            this.StockBox = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.HotelBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.HouseBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.PlayerBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.StockBox)).BeginInit();
            this.SuspendLayout();
            // 
            // AboutText
            // 
            this.AboutText.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.AboutText.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.AboutText.Cursor = System.Windows.Forms.Cursors.Hand;
            this.AboutText.Font = new System.Drawing.Font("Sneakerhead BTN", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AboutText.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.AboutText.Location = new System.Drawing.Point(12, 633);
            this.AboutText.Name = "AboutText";
            this.AboutText.ReadOnly = true;
            this.AboutText.Size = new System.Drawing.Size(683, 117);
            this.AboutText.TabIndex = 3;
            this.AboutText.Text = "";
            // 
            // UserNameLabel
            // 
            this.UserNameLabel.AutoSize = true;
            this.UserNameLabel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.UserNameLabel.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.UserNameLabel.Location = new System.Drawing.Point(538, 59);
            this.UserNameLabel.Name = "UserNameLabel";
            this.UserNameLabel.Size = new System.Drawing.Size(82, 19);
            this.UserNameLabel.TabIndex = 7;
            this.UserNameLabel.Text = "Владелец";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.DarkGray;
            this.label1.Font = new System.Drawing.Font("Lucida Console", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(554, 125);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(20, 19);
            this.label1.TabIndex = 8;
            this.label1.Text = "X";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.DarkGray;
            this.label2.Font = new System.Drawing.Font("Lucida Console", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.Location = new System.Drawing.Point(554, 188);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(20, 19);
            this.label2.TabIndex = 9;
            this.label2.Text = "X";
            // 
            // QuantityHauseLabel
            // 
            this.QuantityHauseLabel.AutoSize = true;
            this.QuantityHauseLabel.BackColor = System.Drawing.Color.DarkGray;
            this.QuantityHauseLabel.Font = new System.Drawing.Font("Lucida Console", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.QuantityHauseLabel.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.QuantityHauseLabel.Location = new System.Drawing.Point(596, 125);
            this.QuantityHauseLabel.Name = "QuantityHauseLabel";
            this.QuantityHauseLabel.Size = new System.Drawing.Size(24, 24);
            this.QuantityHauseLabel.TabIndex = 10;
            this.QuantityHauseLabel.Text = "0";
            // 
            // QuantityHotelLabel
            // 
            this.QuantityHotelLabel.AutoSize = true;
            this.QuantityHotelLabel.BackColor = System.Drawing.Color.DarkGray;
            this.QuantityHotelLabel.Font = new System.Drawing.Font("Lucida Console", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.QuantityHotelLabel.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.QuantityHotelLabel.Location = new System.Drawing.Point(596, 188);
            this.QuantityHotelLabel.Name = "QuantityHotelLabel";
            this.QuantityHotelLabel.Size = new System.Drawing.Size(24, 24);
            this.QuantityHotelLabel.TabIndex = 11;
            this.QuantityHotelLabel.Text = "0";
            // 
            // CloseButton
            // 
            this.CloseButton.BackColor = System.Drawing.Color.Transparent;
            this.CloseButton.Enabled = false;
            this.CloseButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.CloseButton.Image = global::Meneger.IconsRes.iconfinder_emblem_nowrite_24698;
            this.CloseButton.Location = new System.Drawing.Point(673, 0);
            this.CloseButton.Name = "CloseButton";
            this.CloseButton.Size = new System.Drawing.Size(35, 34);
            this.CloseButton.TabIndex = 14;
            this.CloseButton.UseVisualStyleBackColor = false;
            this.CloseButton.Click += new System.EventHandler(this.CloseButton_Click);
            // 
            // BuyHotelButton
            // 
            this.BuyHotelButton.BackColor = System.Drawing.Color.Transparent;
            this.BuyHotelButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BuyHotelButton.Enabled = false;
            this.BuyHotelButton.Image = global::Meneger.IconsRes.Hotelsmall;
            this.BuyHotelButton.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.BuyHotelButton.Location = new System.Drawing.Point(504, 298);
            this.BuyHotelButton.Name = "BuyHotelButton";
            this.BuyHotelButton.Size = new System.Drawing.Size(174, 43);
            this.BuyHotelButton.TabIndex = 13;
            this.BuyHotelButton.Text = "     Построить отель";
            this.BuyHotelButton.UseVisualStyleBackColor = false;
            this.BuyHotelButton.Click += new System.EventHandler(this.BuyHotelButton_Click);
            // 
            // BuyHouseButton
            // 
            this.BuyHouseButton.BackColor = System.Drawing.Color.Transparent;
            this.BuyHouseButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BuyHouseButton.Enabled = false;
            this.BuyHouseButton.Image = global::Meneger.IconsRes.housesmall;
            this.BuyHouseButton.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.BuyHouseButton.Location = new System.Drawing.Point(504, 245);
            this.BuyHouseButton.Name = "BuyHouseButton";
            this.BuyHouseButton.Size = new System.Drawing.Size(174, 47);
            this.BuyHouseButton.TabIndex = 12;
            this.BuyHouseButton.Text = "   Построить дом";
            this.BuyHouseButton.UseVisualStyleBackColor = false;
            this.BuyHouseButton.Click += new System.EventHandler(this.BuyHouseButton_Click);
            // 
            // HotelBox
            // 
            this.HotelBox.BackColor = System.Drawing.Color.Transparent;
            this.HotelBox.Image = global::Meneger.IconsRes.Hotel;
            this.HotelBox.Location = new System.Drawing.Point(484, 173);
            this.HotelBox.Name = "HotelBox";
            this.HotelBox.Size = new System.Drawing.Size(48, 48);
            this.HotelBox.TabIndex = 6;
            this.HotelBox.TabStop = false;
            // 
            // HouseBox
            // 
            this.HouseBox.BackColor = System.Drawing.Color.Transparent;
            this.HouseBox.Image = global::Meneger.IconsRes.House;
            this.HouseBox.Location = new System.Drawing.Point(484, 113);
            this.HouseBox.Name = "HouseBox";
            this.HouseBox.Size = new System.Drawing.Size(48, 40);
            this.HouseBox.TabIndex = 5;
            this.HouseBox.TabStop = false;
            // 
            // PlayerBox
            // 
            this.PlayerBox.BackColor = System.Drawing.Color.Transparent;
            this.PlayerBox.Image = global::Meneger.IconsRes.Player;
            this.PlayerBox.Location = new System.Drawing.Point(484, 44);
            this.PlayerBox.Name = "PlayerBox";
            this.PlayerBox.Size = new System.Drawing.Size(48, 48);
            this.PlayerBox.TabIndex = 4;
            this.PlayerBox.TabStop = false;
            // 
            // CanselSaleButton
            // 
            this.CanselSaleButton.BackColor = System.Drawing.Color.Transparent;
            this.CanselSaleButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.CanselSaleButton.Enabled = false;
            this.CanselSaleButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.CanselSaleButton.Image = global::Meneger.IconsRes.iconfinder_Delete_1493279;
            this.CanselSaleButton.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.CanselSaleButton.Location = new System.Drawing.Point(484, 556);
            this.CanselSaleButton.Name = "CanselSaleButton";
            this.CanselSaleButton.Size = new System.Drawing.Size(211, 53);
            this.CanselSaleButton.TabIndex = 2;
            this.CanselSaleButton.Text = "    Отказатся";
            this.CanselSaleButton.UseVisualStyleBackColor = false;
            this.CanselSaleButton.Click += new System.EventHandler(this.button2_Click);
            // 
            // BuyLayButton
            // 
            this.BuyLayButton.BackColor = System.Drawing.Color.Transparent;
            this.BuyLayButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BuyLayButton.Enabled = false;
            this.BuyLayButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.BuyLayButton.Image = global::Meneger.IconsRes.iconfinder_Finance_loan_money_1889199;
            this.BuyLayButton.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.BuyLayButton.Location = new System.Drawing.Point(484, 487);
            this.BuyLayButton.Name = "BuyLayButton";
            this.BuyLayButton.Size = new System.Drawing.Size(211, 51);
            this.BuyLayButton.TabIndex = 1;
            this.BuyLayButton.UseVisualStyleBackColor = false;
            this.BuyLayButton.Click += new System.EventHandler(this.button1_Click);
            // 
            // StockBox
            // 
            this.StockBox.Location = new System.Drawing.Point(12, 26);
            this.StockBox.Name = "StockBox";
            this.StockBox.Size = new System.Drawing.Size(449, 583);
            this.StockBox.TabIndex = 0;
            this.StockBox.TabStop = false;
            // 
            // Locationmy
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(707, 774);
            this.ControlBox = false;
            this.Controls.Add(this.CloseButton);
            this.Controls.Add(this.BuyHotelButton);
            this.Controls.Add(this.BuyHouseButton);
            this.Controls.Add(this.QuantityHotelLabel);
            this.Controls.Add(this.QuantityHauseLabel);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.UserNameLabel);
            this.Controls.Add(this.HotelBox);
            this.Controls.Add(this.HouseBox);
            this.Controls.Add(this.PlayerBox);
            this.Controls.Add(this.AboutText);
            this.Controls.Add(this.CanselSaleButton);
            this.Controls.Add(this.BuyLayButton);
            this.Controls.Add(this.StockBox);
            this.Cursor = System.Windows.Forms.Cursors.Default;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.MaximumSize = new System.Drawing.Size(707, 774);
            this.MinimumSize = new System.Drawing.Size(707, 774);
            this.Name = "Locationmy";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Location";
            this.Paint += new System.Windows.Forms.PaintEventHandler(this.Locationmy_Paint);
            this.MouseDown += new System.Windows.Forms.MouseEventHandler(this.Locationmy_MouseDown);
            ((System.ComponentModel.ISupportInitialize)(this.HotelBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.HouseBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.PlayerBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.StockBox)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox StockBox;
        private System.Windows.Forms.Button BuyLayButton;
        private System.Windows.Forms.Button CanselSaleButton;
        private System.Windows.Forms.RichTextBox AboutText;
        private System.Windows.Forms.PictureBox PlayerBox;
        private System.Windows.Forms.PictureBox HouseBox;
        private System.Windows.Forms.PictureBox HotelBox;
        private System.Windows.Forms.Label UserNameLabel;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label QuantityHauseLabel;
        private System.Windows.Forms.Label QuantityHotelLabel;
        private System.Windows.Forms.Button BuyHouseButton;
        private System.Windows.Forms.Button BuyHotelButton;
        private System.Windows.Forms.Button CloseButton;
    }
}
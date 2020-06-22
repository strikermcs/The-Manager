namespace Meneger
{
    partial class Auction
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.SecondPlayerUpPrice = new System.Windows.Forms.Button();
            this.FirstplayerUpPrice = new System.Windows.Forms.Button();
            this.CancelAuction = new System.Windows.Forms.Button();
            this.EndAuctiom = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(96, 213);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(51, 16);
            this.label1.TabIndex = 5;
            this.label1.Text = "label1";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(353, 213);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(51, 16);
            this.label2.TabIndex = 6;
            this.label2.Text = "label2";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(112, 101);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(51, 16);
            this.label3.TabIndex = 7;
            this.label3.Text = "label3";
            // 
            // SecondPlayerUpPrice
            // 
            this.SecondPlayerUpPrice.Image = global::Meneger.IconsRes.iconfinder_Stock_Index_Up_27881;
            this.SecondPlayerUpPrice.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.SecondPlayerUpPrice.Location = new System.Drawing.Point(265, 138);
            this.SecondPlayerUpPrice.Name = "SecondPlayerUpPrice";
            this.SecondPlayerUpPrice.Size = new System.Drawing.Size(233, 58);
            this.SecondPlayerUpPrice.TabIndex = 4;
            this.SecondPlayerUpPrice.Text = "button4";
            this.SecondPlayerUpPrice.UseVisualStyleBackColor = true;
            this.SecondPlayerUpPrice.Click += new System.EventHandler(this.SecondPlayerUpPrice_Click);
            // 
            // FirstplayerUpPrice
            // 
            this.FirstplayerUpPrice.Image = global::Meneger.IconsRes.iconfinder_Stock_Index_Up_27881;
            this.FirstplayerUpPrice.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.FirstplayerUpPrice.Location = new System.Drawing.Point(12, 138);
            this.FirstplayerUpPrice.Name = "FirstplayerUpPrice";
            this.FirstplayerUpPrice.Size = new System.Drawing.Size(237, 58);
            this.FirstplayerUpPrice.TabIndex = 3;
            this.FirstplayerUpPrice.Text = "button3";
            this.FirstplayerUpPrice.UseVisualStyleBackColor = true;
            this.FirstplayerUpPrice.Click += new System.EventHandler(this.FirstplayerUpPrice_Click);
            // 
            // CancelAuction
            // 
            this.CancelAuction.Cursor = System.Windows.Forms.Cursors.Hand;
            this.CancelAuction.Image = global::Meneger.IconsRes.iconfinder_Delete_1493279;
            this.CancelAuction.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.CancelAuction.Location = new System.Drawing.Point(265, 244);
            this.CancelAuction.Name = "CancelAuction";
            this.CancelAuction.Size = new System.Drawing.Size(233, 42);
            this.CancelAuction.TabIndex = 2;
            this.CancelAuction.Text = "Отменить сделку";
            this.CancelAuction.UseVisualStyleBackColor = true;
            this.CancelAuction.Click += new System.EventHandler(this.button2_Click);
            // 
            // EndAuctiom
            // 
            this.EndAuctiom.Cursor = System.Windows.Forms.Cursors.Hand;
            this.EndAuctiom.Image = global::Meneger.IconsRes.iconfinder_auction_hammer_gavel_63869;
            this.EndAuctiom.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.EndAuctiom.Location = new System.Drawing.Point(12, 244);
            this.EndAuctiom.Name = "EndAuctiom";
            this.EndAuctiom.Size = new System.Drawing.Size(237, 42);
            this.EndAuctiom.TabIndex = 1;
            this.EndAuctiom.Text = "Завершить сделку";
            this.EndAuctiom.UseVisualStyleBackColor = true;
            this.EndAuctiom.Click += new System.EventHandler(this.EndAuctiom_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox1.Image = global::Meneger.BackGround.image__2_;
            this.pictureBox1.Location = new System.Drawing.Point(99, -8);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(283, 106);
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // Auction
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(510, 298);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.SecondPlayerUpPrice);
            this.Controls.Add(this.FirstplayerUpPrice);
            this.Controls.Add(this.CancelAuction);
            this.Controls.Add(this.EndAuctiom);
            this.Controls.Add(this.pictureBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Auction";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Auction";
            this.Load += new System.EventHandler(this.Auction_Load);
            this.Paint += new System.Windows.Forms.PaintEventHandler(this.Auction_Paint);
            this.MouseDown += new System.Windows.Forms.MouseEventHandler(this.Auction_MouseDown);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button EndAuctiom;
        private System.Windows.Forms.Button CancelAuction;
        private System.Windows.Forms.Button FirstplayerUpPrice;
        private System.Windows.Forms.Button SecondPlayerUpPrice;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
    }
}
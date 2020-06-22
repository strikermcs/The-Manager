namespace Meneger
{
    partial class TvCompForm
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
            this.UserNameLabel = new System.Windows.Forms.Label();
            this.PlayerBox = new System.Windows.Forms.PictureBox();
            this.CanselSaleButton = new System.Windows.Forms.Button();
            this.BuyLayButton = new System.Windows.Forms.Button();
            this.TvCompBox = new System.Windows.Forms.PictureBox();
            this.CloseButton = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.PlayerBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.TvCompBox)).BeginInit();
            this.SuspendLayout();
            // 
            // UserNameLabel
            // 
            this.UserNameLabel.AutoSize = true;
            this.UserNameLabel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.UserNameLabel.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.UserNameLabel.Location = new System.Drawing.Point(541, 173);
            this.UserNameLabel.Name = "UserNameLabel";
            this.UserNameLabel.Size = new System.Drawing.Size(82, 19);
            this.UserNameLabel.TabIndex = 13;
            this.UserNameLabel.Text = "Владелец";
            // 
            // PlayerBox
            // 
            this.PlayerBox.BackColor = System.Drawing.Color.Transparent;
            this.PlayerBox.Image = global::Meneger.IconsRes.Player;
            this.PlayerBox.Location = new System.Drawing.Point(487, 158);
            this.PlayerBox.Name = "PlayerBox";
            this.PlayerBox.Size = new System.Drawing.Size(48, 48);
            this.PlayerBox.TabIndex = 11;
            this.PlayerBox.TabStop = false;
            // 
            // CanselSaleButton
            // 
            this.CanselSaleButton.BackColor = System.Drawing.Color.Transparent;
            this.CanselSaleButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.CanselSaleButton.Enabled = false;
            this.CanselSaleButton.Image = global::Meneger.IconsRes.iconfinder_Delete_1493279;
            this.CanselSaleButton.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.CanselSaleButton.Location = new System.Drawing.Point(546, 369);
            this.CanselSaleButton.Name = "CanselSaleButton";
            this.CanselSaleButton.Size = new System.Drawing.Size(132, 53);
            this.CanselSaleButton.TabIndex = 4;
            this.CanselSaleButton.Text = "    Отказатся";
            this.CanselSaleButton.UseVisualStyleBackColor = false;
            this.CanselSaleButton.Click += new System.EventHandler(this.CanselSaleButton_Click);
            // 
            // BuyLayButton
            // 
            this.BuyLayButton.BackColor = System.Drawing.Color.Transparent;
            this.BuyLayButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BuyLayButton.Enabled = false;
            this.BuyLayButton.Image = global::Meneger.IconsRes.iconfinder_Finance_loan_money_1889199;
            this.BuyLayButton.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.BuyLayButton.Location = new System.Drawing.Point(546, 300);
            this.BuyLayButton.Name = "BuyLayButton";
            this.BuyLayButton.Size = new System.Drawing.Size(132, 51);
            this.BuyLayButton.TabIndex = 3;
            this.BuyLayButton.Text = "Купить";
            this.BuyLayButton.UseVisualStyleBackColor = false;
            this.BuyLayButton.Click += new System.EventHandler(this.BuyLayButton_Click);
            // 
            // TvCompBox
            // 
            this.TvCompBox.Location = new System.Drawing.Point(12, 12);
            this.TvCompBox.Name = "TvCompBox";
            this.TvCompBox.Size = new System.Drawing.Size(449, 583);
            this.TvCompBox.TabIndex = 1;
            this.TvCompBox.TabStop = false;
            // 
            // CloseButton
            // 
            this.CloseButton.BackColor = System.Drawing.Color.Transparent;
            this.CloseButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.CloseButton.Image = global::Meneger.IconsRes.iconfinder_emblem_nowrite_24698;
            this.CloseButton.Location = new System.Drawing.Point(660, 5);
            this.CloseButton.Name = "CloseButton";
            this.CloseButton.Size = new System.Drawing.Size(35, 33);
            this.CloseButton.TabIndex = 16;
            this.CloseButton.UseVisualStyleBackColor = false;
            this.CloseButton.Click += new System.EventHandler(this.CloseButton_Click);
            // 
            // TvCompForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(697, 613);
            this.Controls.Add(this.CloseButton);
            this.Controls.Add(this.UserNameLabel);
            this.Controls.Add(this.PlayerBox);
            this.Controls.Add(this.CanselSaleButton);
            this.Controls.Add(this.BuyLayButton);
            this.Controls.Add(this.TvCompBox);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "TvCompForm";
            this.Text = "TvCompForm";
            this.Paint += new System.Windows.Forms.PaintEventHandler(this.TvCompForm_Paint);
            this.MouseDown += new System.Windows.Forms.MouseEventHandler(this.TvCompForm_MouseDown);
            ((System.ComponentModel.ISupportInitialize)(this.PlayerBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.TvCompBox)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox TvCompBox;
        private System.Windows.Forms.Button CanselSaleButton;
        private System.Windows.Forms.Button BuyLayButton;
        private System.Windows.Forms.Label UserNameLabel;
        private System.Windows.Forms.PictureBox PlayerBox;
        private System.Windows.Forms.Button CloseButton;
    }
}
namespace Meneger
{
    partial class briefcase
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
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.MogStockButton = new System.Windows.Forms.Button();
            this.BuyStockButton = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.MorStockBox = new System.Windows.Forms.TextBox();
            this.BuyStockBox = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.ListOfStocks = new System.Windows.Forms.ListBox();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.ExecBirCardButton = new System.Windows.Forms.Button();
            this.BuyBirCardButton = new System.Windows.Forms.Button();
            this.CardBirBox = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.BuyInterpolCardButton = new System.Windows.Forms.Button();
            this.CardInterpolBox = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Location = new System.Drawing.Point(12, 12);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(565, 427);
            this.tabControl1.TabIndex = 0;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.pictureBox3);
            this.tabPage1.Controls.Add(this.MogStockButton);
            this.tabPage1.Controls.Add(this.BuyStockButton);
            this.tabPage1.Controls.Add(this.groupBox1);
            this.tabPage1.Controls.Add(this.ListOfStocks);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(557, 401);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Мои акции";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // MogStockButton
            // 
            this.MogStockButton.Location = new System.Drawing.Point(423, 159);
            this.MogStockButton.Name = "MogStockButton";
            this.MogStockButton.Size = new System.Drawing.Size(87, 33);
            this.MogStockButton.TabIndex = 3;
            this.MogStockButton.Text = "Заложить";
            this.MogStockButton.UseVisualStyleBackColor = true;
            this.MogStockButton.Click += new System.EventHandler(this.MogStockButton_Click);
            // 
            // BuyStockButton
            // 
            this.BuyStockButton.Location = new System.Drawing.Point(301, 159);
            this.BuyStockButton.Name = "BuyStockButton";
            this.BuyStockButton.Size = new System.Drawing.Size(87, 33);
            this.BuyStockButton.TabIndex = 2;
            this.BuyStockButton.Text = "Продать";
            this.BuyStockButton.UseVisualStyleBackColor = true;
            this.BuyStockButton.Click += new System.EventHandler(this.BuyStockButton_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.MorStockBox);
            this.groupBox1.Controls.Add(this.BuyStockBox);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.groupBox1.Location = new System.Drawing.Point(280, 28);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(251, 114);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Цены банка на:";
            // 
            // MorStockBox
            // 
            this.MorStockBox.Location = new System.Drawing.Point(111, 75);
            this.MorStockBox.Name = "MorStockBox";
            this.MorStockBox.ReadOnly = true;
            this.MorStockBox.Size = new System.Drawing.Size(100, 21);
            this.MorStockBox.TabIndex = 3;
            // 
            // BuyStockBox
            // 
            this.BuyStockBox.Location = new System.Drawing.Point(111, 36);
            this.BuyStockBox.Name = "BuyStockBox";
            this.BuyStockBox.ReadOnly = true;
            this.BuyStockBox.Size = new System.Drawing.Size(100, 21);
            this.BuyStockBox.TabIndex = 2;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(39, 75);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(50, 15);
            this.label4.TabIndex = 1;
            this.label4.Text = "Залог:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(18, 36);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(71, 15);
            this.label3.TabIndex = 0;
            this.label3.Text = "Продажа:";
            // 
            // ListOfStocks
            // 
            this.ListOfStocks.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.ListOfStocks.FormattingEnabled = true;
            this.ListOfStocks.ItemHeight = 16;
            this.ListOfStocks.Location = new System.Drawing.Point(31, 28);
            this.ListOfStocks.Name = "ListOfStocks";
            this.ListOfStocks.Size = new System.Drawing.Size(225, 308);
            this.ListOfStocks.TabIndex = 0;
            this.ListOfStocks.SelectedIndexChanged += new System.EventHandler(this.ListOfStocks_SelectedIndexChanged);
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.ExecBirCardButton);
            this.tabPage2.Controls.Add(this.BuyBirCardButton);
            this.tabPage2.Controls.Add(this.CardBirBox);
            this.tabPage2.Controls.Add(this.label2);
            this.tabPage2.Controls.Add(this.BuyInterpolCardButton);
            this.tabPage2.Controls.Add(this.CardInterpolBox);
            this.tabPage2.Controls.Add(this.label1);
            this.tabPage2.Controls.Add(this.pictureBox2);
            this.tabPage2.Controls.Add(this.pictureBox1);
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(557, 401);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Мои бонус-карточки";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // ExecBirCardButton
            // 
            this.ExecBirCardButton.Location = new System.Drawing.Point(377, 339);
            this.ExecBirCardButton.Name = "ExecBirCardButton";
            this.ExecBirCardButton.Size = new System.Drawing.Size(101, 37);
            this.ExecBirCardButton.TabIndex = 8;
            this.ExecBirCardButton.Text = "Использовать";
            this.ExecBirCardButton.UseVisualStyleBackColor = true;
            this.ExecBirCardButton.Click += new System.EventHandler(this.ExecBirCardButton_Click);
            // 
            // BuyBirCardButton
            // 
            this.BuyBirCardButton.Location = new System.Drawing.Point(377, 296);
            this.BuyBirCardButton.Name = "BuyBirCardButton";
            this.BuyBirCardButton.Size = new System.Drawing.Size(101, 37);
            this.BuyBirCardButton.TabIndex = 7;
            this.BuyBirCardButton.Text = "Продать";
            this.BuyBirCardButton.UseVisualStyleBackColor = true;
            this.BuyBirCardButton.Click += new System.EventHandler(this.BuyBirCardButton_Click);
            // 
            // CardBirBox
            // 
            this.CardBirBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.CardBirBox.Location = new System.Drawing.Point(416, 255);
            this.CardBirBox.Name = "CardBirBox";
            this.CardBirBox.ReadOnly = true;
            this.CardBirBox.Size = new System.Drawing.Size(62, 26);
            this.CardBirBox.TabIndex = 6;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.Location = new System.Drawing.Point(358, 221);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(120, 20);
            this.label2.TabIndex = 5;
            this.label2.Text = "Количество: ";
            // 
            // BuyInterpolCardButton
            // 
            this.BuyInterpolCardButton.Location = new System.Drawing.Point(377, 130);
            this.BuyInterpolCardButton.Name = "BuyInterpolCardButton";
            this.BuyInterpolCardButton.Size = new System.Drawing.Size(101, 37);
            this.BuyInterpolCardButton.TabIndex = 4;
            this.BuyInterpolCardButton.Text = "Продать";
            this.BuyInterpolCardButton.UseVisualStyleBackColor = true;
            this.BuyInterpolCardButton.Click += new System.EventHandler(this.BuyInterpolCardButton_Click);
            // 
            // CardInterpolBox
            // 
            this.CardInterpolBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.CardInterpolBox.Location = new System.Drawing.Point(416, 69);
            this.CardInterpolBox.Name = "CardInterpolBox";
            this.CardInterpolBox.ReadOnly = true;
            this.CardInterpolBox.Size = new System.Drawing.Size(62, 26);
            this.CardInterpolBox.TabIndex = 3;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(358, 35);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(120, 20);
            this.label1.TabIndex = 2;
            this.label1.Text = "Количество: ";
            // 
            // pictureBox3
            // 
            this.pictureBox3.Image = global::Meneger.IconsRes.iconfinder_Stocks_201350;
            this.pictureBox3.Location = new System.Drawing.Point(301, 233);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(221, 162);
            this.pictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox3.TabIndex = 4;
            this.pictureBox3.TabStop = false;
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = global::Meneger.Res.off5;
            this.pictureBox2.Location = new System.Drawing.Point(17, 208);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(335, 182);
            this.pictureBox2.TabIndex = 1;
            this.pictureBox2.TabStop = false;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::Meneger.Res.off1;
            this.pictureBox1.Location = new System.Drawing.Point(17, 20);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(335, 182);
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // briefcase
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(589, 450);
            this.Controls.Add(this.tabControl1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "briefcase";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Портфель";
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.Button ExecBirCardButton;
        private System.Windows.Forms.Button BuyBirCardButton;
        private System.Windows.Forms.TextBox CardBirBox;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button BuyInterpolCardButton;
        private System.Windows.Forms.TextBox CardInterpolBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button MogStockButton;
        private System.Windows.Forms.Button BuyStockButton;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox MorStockBox;
        private System.Windows.Forms.TextBox BuyStockBox;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ListBox ListOfStocks;
        private System.Windows.Forms.PictureBox pictureBox3;
    }
}
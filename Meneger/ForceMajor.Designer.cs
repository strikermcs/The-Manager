namespace Meneger
{
    partial class Force
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
            this.ForcePicture = new System.Windows.Forms.PictureBox();
            this.forcok = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.ForcePicture)).BeginInit();
            this.SuspendLayout();
            // 
            // ForcePicture
            // 
            this.ForcePicture.Location = new System.Drawing.Point(8, 18);
            this.ForcePicture.Name = "ForcePicture";
            this.ForcePicture.Size = new System.Drawing.Size(335, 177);
            this.ForcePicture.TabIndex = 0;
            this.ForcePicture.TabStop = false;
            // 
            // forcok
            // 
            this.forcok.Cursor = System.Windows.Forms.Cursors.Hand;
            this.forcok.Location = new System.Drawing.Point(82, 205);
            this.forcok.Name = "forcok";
            this.forcok.Size = new System.Drawing.Size(182, 38);
            this.forcok.TabIndex = 1;
            this.forcok.Text = "OK";
            this.forcok.UseVisualStyleBackColor = true;
            this.forcok.Click += new System.EventHandler(this.forcok_Click);
            // 
            // Force
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(348, 251);
            this.Controls.Add(this.forcok);
            this.Controls.Add(this.ForcePicture);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Name = "Force";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Форс-Мажор";
            this.Load += new System.EventHandler(this.Force_Load);
            ((System.ComponentModel.ISupportInitialize)(this.ForcePicture)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox ForcePicture;
        private System.Windows.Forms.Button forcok;
    }
}
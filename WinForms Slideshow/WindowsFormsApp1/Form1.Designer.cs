namespace WindowsFormsApp1
{
    partial class Form1
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
            this.bBack = new System.Windows.Forms.Button();
            this.bNext = new System.Windows.Forms.Button();
            this.flpSmallPictures = new System.Windows.Forms.FlowLayoutPanel();
            this.bPlay = new System.Windows.Forms.Button();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.pbSmallPicture1 = new System.Windows.Forms.PictureBox();
            this.pbSmallPicture2 = new System.Windows.Forms.PictureBox();
            this.pbSmallPicture3 = new System.Windows.Forms.PictureBox();
            this.pbSmallPicture4 = new System.Windows.Forms.PictureBox();
            this.pbSmallPicture5 = new System.Windows.Forms.PictureBox();
            this.pbBigPicture = new System.Windows.Forms.PictureBox();
            this.flpSmallPictures.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbSmallPicture1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbSmallPicture2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbSmallPicture3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbSmallPicture4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbSmallPicture5)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbBigPicture)).BeginInit();
            this.SuspendLayout();
            // 
            // bBack
            // 
            this.bBack.Location = new System.Drawing.Point(16, 70);
            this.bBack.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.bBack.Name = "bBack";
            this.bBack.Size = new System.Drawing.Size(153, 747);
            this.bBack.TabIndex = 0;
            this.bBack.Text = "<<";
            this.bBack.UseVisualStyleBackColor = true;
            this.bBack.Click += new System.EventHandler(this.bBack_Click);
            // 
            // bNext
            // 
            this.bNext.Location = new System.Drawing.Point(925, 15);
            this.bNext.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.bNext.Name = "bNext";
            this.bNext.Size = new System.Drawing.Size(153, 802);
            this.bNext.TabIndex = 0;
            this.bNext.Text = ">>";
            this.bNext.UseVisualStyleBackColor = true;
            this.bNext.Click += new System.EventHandler(this.bNext_Click);
            // 
            // flpSmallPictures
            // 
            this.flpSmallPictures.AutoScroll = true;
            this.flpSmallPictures.Controls.Add(this.pbSmallPicture1);
            this.flpSmallPictures.Controls.Add(this.pbSmallPicture2);
            this.flpSmallPictures.Controls.Add(this.pbSmallPicture3);
            this.flpSmallPictures.Controls.Add(this.pbSmallPicture4);
            this.flpSmallPictures.Controls.Add(this.pbSmallPicture5);
            this.flpSmallPictures.FlowDirection = System.Windows.Forms.FlowDirection.TopDown;
            this.flpSmallPictures.Location = new System.Drawing.Point(177, 582);
            this.flpSmallPictures.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.flpSmallPictures.Name = "flpSmallPictures";
            this.flpSmallPictures.Size = new System.Drawing.Size(740, 235);
            this.flpSmallPictures.TabIndex = 2;
            // 
            // bPlay
            // 
            this.bPlay.Location = new System.Drawing.Point(16, 15);
            this.bPlay.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.bPlay.Name = "bPlay";
            this.bPlay.Size = new System.Drawing.Size(153, 48);
            this.bPlay.TabIndex = 0;
            this.bPlay.Text = "AUTO/STOP";
            this.bPlay.UseVisualStyleBackColor = true;
            this.bPlay.Click += new System.EventHandler(this.bPlay_Click);
            // 
            // backgroundWorker1
            // 
            this.backgroundWorker1.DoWork += new System.ComponentModel.DoWorkEventHandler(this.backgroundWorker1_DoWork);
            // 
            // pbSmallPicture1
            // 
            this.pbSmallPicture1.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.pbSmallPicture1.Image = global::WindowsFormsApp1.Properties.Resources.book;
            this.pbSmallPicture1.Location = new System.Drawing.Point(4, 4);
            this.pbSmallPicture1.Margin = new System.Windows.Forms.Padding(4);
            this.pbSmallPicture1.Name = "pbSmallPicture1";
            this.pbSmallPicture1.Size = new System.Drawing.Size(161, 194);
            this.pbSmallPicture1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbSmallPicture1.TabIndex = 3;
            this.pbSmallPicture1.TabStop = false;
            // 
            // pbSmallPicture2
            // 
            this.pbSmallPicture2.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.pbSmallPicture2.Image = global::WindowsFormsApp1.Properties.Resources.car;
            this.pbSmallPicture2.Location = new System.Drawing.Point(173, 4);
            this.pbSmallPicture2.Margin = new System.Windows.Forms.Padding(4);
            this.pbSmallPicture2.Name = "pbSmallPicture2";
            this.pbSmallPicture2.Size = new System.Drawing.Size(161, 194);
            this.pbSmallPicture2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbSmallPicture2.TabIndex = 3;
            this.pbSmallPicture2.TabStop = false;
            // 
            // pbSmallPicture3
            // 
            this.pbSmallPicture3.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.pbSmallPicture3.Image = global::WindowsFormsApp1.Properties.Resources.computer;
            this.pbSmallPicture3.Location = new System.Drawing.Point(342, 4);
            this.pbSmallPicture3.Margin = new System.Windows.Forms.Padding(4);
            this.pbSmallPicture3.Name = "pbSmallPicture3";
            this.pbSmallPicture3.Size = new System.Drawing.Size(161, 194);
            this.pbSmallPicture3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbSmallPicture3.TabIndex = 3;
            this.pbSmallPicture3.TabStop = false;
            // 
            // pbSmallPicture4
            // 
            this.pbSmallPicture4.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.pbSmallPicture4.Image = global::WindowsFormsApp1.Properties.Resources.HotDog;
            this.pbSmallPicture4.Location = new System.Drawing.Point(511, 4);
            this.pbSmallPicture4.Margin = new System.Windows.Forms.Padding(4);
            this.pbSmallPicture4.Name = "pbSmallPicture4";
            this.pbSmallPicture4.Size = new System.Drawing.Size(161, 194);
            this.pbSmallPicture4.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbSmallPicture4.TabIndex = 3;
            this.pbSmallPicture4.TabStop = false;
            // 
            // pbSmallPicture5
            // 
            this.pbSmallPicture5.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.pbSmallPicture5.Image = global::WindowsFormsApp1.Properties.Resources.coffe;
            this.pbSmallPicture5.Location = new System.Drawing.Point(680, 4);
            this.pbSmallPicture5.Margin = new System.Windows.Forms.Padding(4);
            this.pbSmallPicture5.Name = "pbSmallPicture5";
            this.pbSmallPicture5.Size = new System.Drawing.Size(161, 194);
            this.pbSmallPicture5.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbSmallPicture5.TabIndex = 4;
            this.pbSmallPicture5.TabStop = false;
            // 
            // pbBigPicture
            // 
            this.pbBigPicture.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.pbBigPicture.Image = global::WindowsFormsApp1.Properties.Resources.book;
            this.pbBigPicture.Location = new System.Drawing.Point(177, 15);
            this.pbBigPicture.Margin = new System.Windows.Forms.Padding(4);
            this.pbBigPicture.Name = "pbBigPicture";
            this.pbBigPicture.Size = new System.Drawing.Size(740, 560);
            this.pbBigPicture.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbBigPicture.TabIndex = 1;
            this.pbBigPicture.TabStop = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1096, 832);
            this.Controls.Add(this.flpSmallPictures);
            this.Controls.Add(this.pbBigPicture);
            this.Controls.Add(this.bNext);
            this.Controls.Add(this.bPlay);
            this.Controls.Add(this.bBack);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "Form1";
            this.Text = "Form1";
            this.flpSmallPictures.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pbSmallPicture1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbSmallPicture2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbSmallPicture3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbSmallPicture4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbSmallPicture5)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbBigPicture)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button bBack;
        private System.Windows.Forms.Button bNext;
        private System.Windows.Forms.PictureBox pbBigPicture;
        private System.Windows.Forms.FlowLayoutPanel flpSmallPictures;
        private System.Windows.Forms.PictureBox pbSmallPicture1;
        private System.Windows.Forms.PictureBox pbSmallPicture2;
        private System.Windows.Forms.PictureBox pbSmallPicture3;
        private System.Windows.Forms.PictureBox pbSmallPicture4;
        private System.Windows.Forms.PictureBox pbSmallPicture5;
        private System.Windows.Forms.Button bPlay;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
    }
}


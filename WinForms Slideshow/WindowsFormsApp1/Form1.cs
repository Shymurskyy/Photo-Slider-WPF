using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Threading;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class Form1 : Form
    {
        private readonly List<Image> images;
        private int Selected { get; set; }

        public Form1()
        {
            InitializeComponent();
            images = new List<Image>();
            backgroundWorker1.WorkerSupportsCancellation = true;

            images.Add(pbSmallPicture1.Image);
            images.Add(pbSmallPicture2.Image);
            images.Add(pbSmallPicture3.Image);
            images.Add(pbSmallPicture4.Image);
            images.Add(pbSmallPicture5.Image);
        }

        private void bNext_Click(object sender, EventArgs e)
        {
            NextImage();
        }

        private void bBack_Click(object sender, EventArgs e)
        {
            PrevImage();
        }

        private void bPlay_Click(object sender, EventArgs e)
        {
            if (backgroundWorker1.IsBusy != true)
            {
                bPlay.Text = "STOP";
                backgroundWorker1.RunWorkerAsync();
            }
            else
            {
                bPlay.Text = "AUTO";
                backgroundWorker1.CancelAsync(); 
            }

        }

        private void backgroundWorker1_DoWork(object sender, DoWorkEventArgs e)
        {
            while (true)
            {
                if (backgroundWorker1.CancellationPending == true)
                {
                    e.Cancel = true;
                    break;
                }
                else
                {
                    NextImage();
                    Thread.Sleep(1000);
                }
            }
        }

        private void NextImage()
        {
            if (Selected == images.Count - 1)
            {
                Selected = 0;
                pbBigPicture.Image = images[Selected];
            }
            else
            {
                Selected += 1;
                pbBigPicture.Image = images[Selected];
            }
        }

        private void PrevImage()
        {
            if (Selected == 0)
            {
                Selected = images.Count - 1;
                pbBigPicture.Image = images[Selected];
            }
            else
            {
                Selected -= 1;
                pbBigPicture.Image = images[Selected];
            }
        }
    }
}
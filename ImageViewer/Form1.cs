using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ImageViewer
{
    public partial class Form1 : Form
    {
        int ImgCount = 0; //현재 보고 있는 이미지 번호
        public Form1()
        {
            InitializeComponent();
        }

        private void btnPrev_Click(object sender, EventArgs e)
        {
            this.ImgCount--;

            if (this.ImgCount < 0)
            {
                this.ImgCount = this.imgList.Images.Count - 1; // 현재 이미지 count에서 1 감소한 값을 imgCount에 넣음
            }
            this.picImg.Image = (Image)this.imgList.Images[this.ImgCount];
            this.lblNum.Text = (this.ImgCount + 1) + "/" + this.imgList.Images.Count;

        }

        private void btnNext_Click(object sender, EventArgs e)
        {
            this.ImgCount++;

            if (this.ImgCount >= this.imgList.Images.Count) 
            {
                this.ImgCount = 0;
            }

            this.picImg.Image = (Image)this.imgList.Images[this.ImgCount];
            this.lblNum.Text = (this.ImgCount + 1) + "/" + this.imgList.Images.Count;

        }

        private void LblNum_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            ShowImage();
        }

        private void ShowImage()
        {
            this.picImg.Image = this.imgList.Images[this.ImgCount]; //이미지 리스트에 있는 0번째 이미지를 pictureBox 에 넣음
            this.lblNum.Text = (this.ImgCount + 1) + "/" + this.imgList.Images.Count;
        }
    }
}

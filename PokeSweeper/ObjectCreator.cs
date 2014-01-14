using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Drawing;

namespace PokeSweeper
{
    class ObjectCreator
    {
        Random r = new Random();


        int spaceLeft = 100;

        public int getSpace()
        {
            return spaceLeft;
        }
        public void setSpace(int space)
        {
            this.spaceLeft = space;
        }
        public void dropSpace()
        {
            --spaceLeft;
        }

        public void makeMine(PictureBox pb)
        {
            if (pb.Tag != "Mine")
            {
                pb.Image = Properties.Resources.GeoBro;
                pb.Tag = "Mine";

            }
           
                
        }

        

        public void clearSpace(PictureBox picStart, PictureBox pic1, PictureBox pic2, PictureBox pic3, PictureBox pic4, PictureBox pic5, PictureBox pic6, PictureBox pic7, PictureBox pic8)
        {
            if (picStart.Image == null)
            {
                if (pic1.Image == null)
                {
                    pic1.Visible = true;

                }
                else if (pic1.Image != null && pic1.Tag != "Mine")
                {
                    pic1.Visible = true;
                }
                if (pic2.Image == null)
                {
                    pic2.Visible = true;

                }
                else if (pic2.Image != null && pic2.Tag != "Mine")
                {
                    pic2.Visible = true;
                }
                if (pic3.Image == null)
                {
                    pic3.Visible = true;

                }
                else if (pic3.Image != null && pic3.Tag != "Mine")
                {
                    pic3.Visible = true;
                }
                if (pic4.Image == null)
                {
                    pic4.Visible = true;

                }
                else if (pic4.Image != null && pic4.Tag != "Mine")
                {
                    pic4.Visible = true;
                }
                if (pic5.Image == null)
                {
                    pic5.Visible = true;

                }
                else if (pic5.Image != null && pic5.Tag != "Mine")
                {
                    pic5.Visible = true;
                }
                if (pic6.Image == null)
                {
                    pic6.Visible = true;

                }
                else if (pic6.Image != null && pic6.Tag != "Mine")
                {
                    pic6.Visible = true;
                }
                if (pic7.Image == null)
                {
                    pic7.Visible = true;

                }
                else if (pic7.Image != null && pic7.Tag != "Mine")
                {
                    pic7.Visible = true;
                }
                if (pic8.Image == null)
                {
                    pic8.Visible = true;

                }
                else if (pic8.Image != null && pic8.Tag != "Mine")
                {
                    pic8.Visible = true;
                }
            }
        }

        public void clearSpace(PictureBox picStart, PictureBox pic1, PictureBox pic2, PictureBox pic3)
        {
            if (picStart.Image == null)
            {
                if (pic1.Image == null)
                {
                    pic1.Visible = true;
                }
                else if (pic1.Image != null && pic1.Tag != "Mine")
                {
                    pic1.Visible = true;
                }
                if (pic2.Image == null)
                {
                    pic2.Visible = true;

                }
                else if (pic2.Image != null && pic2.Tag != "Mine")
                {
                    pic2.Visible = true;
                }
                if (pic3.Image == null)
                {
                    pic3.Visible = true;

                }
                else if (pic3.Image != null && pic3.Tag != "Mine")
                {
                    pic3.Visible = true;
                }
                
            }
        }

        public void clearSpace(PictureBox picStart, PictureBox pic1, PictureBox pic2, PictureBox pic3, PictureBox pic4, PictureBox pic5)
        {
            if (picStart.Image == null)
            {
                if (pic1.Image == null)
                {
                    pic1.Visible = true;

                }
                else if (pic1.Image != null && pic1.Tag != "Mine")
                {
                    pic1.Visible = true;
                }
                if (pic2.Image == null)
                {
                    pic2.Visible = true;

                }
                else if (pic2.Image != null && pic2.Tag != "Mine")
                {
                    pic2.Visible = true;
                }
                if (pic3.Image == null)
                {
                    pic3.Visible = true;

                }
                else if (pic3.Image != null && pic3.Tag != "Mine")
                {
                    pic3.Visible = true;
                }
                if (pic4.Image == null)
                {
                    pic4.Visible = true;

                }
                else if (pic4.Image != null && pic4.Tag != "Mine")
                {
                    pic4.Visible = true;
                }
                if (pic5.Image == null)
                {
                    pic5.Visible = true;

                }
                else if (pic5.Image != null && pic5.Tag != "Mine")
                {
                    pic5.Visible = true;
                }
                
            }
        }

        public bool loseOrWin(PictureBox clicked)
        {
            int mineCount = 15;
            --spaceLeft;
            bool lost = false;
            
            if (clicked.Tag == "Mine")
            {
                System.Windows.Forms.MessageBox.Show("A wild Geodude has appeared. \n Geodude used self-destruct. \n Game over.");
                return lost = true;
            }
            else if (spaceLeft == mineCount && lost == false)
            {
                System.Windows.Forms.MessageBox.Show("Gratz you win!!!!");
                return lost = false;
            }

            return lost;
        }

        public void mineCount(PictureBox start, PictureBox pic1, PictureBox pic2, PictureBox pic3)
        {
            int count = 0;

            if (start.Tag != "Mine")
            {
                if (pic1 != null && pic1.Tag == "Mine")
                    ++count;
                if (pic2 != null && pic2.Tag == "Mine")
                    ++count;
                if (pic3 != null && pic3.Tag == "Mine")
                    ++count;

                if (count == 1)
                {
                    start.Image = Properties.Resources._1;
                    start.Tag = "1";
                }
                if (count == 2)
                {
                    start.Image = Properties.Resources._2;
                    start.Tag = "2";
                }
                if (count == 3)
                {
                    start.Image = Properties.Resources._3;
                    start.Tag = "3";
                }
            }

            
        }
        public void mineCount(PictureBox start, PictureBox pic1, PictureBox pic2, PictureBox pic3, PictureBox pic4, PictureBox pic5)
        {
            int count = 0;

            if (start.Tag != "Mine")
            {
                if (pic1 != null && pic1.Tag == "Mine")
                    ++count;
                if (pic2 != null && pic2.Tag == "Mine")
                    ++count;
                if (pic3 != null && pic3.Tag == "Mine")
                    ++count;
                if (pic4 != null && pic4.Tag == "Mine")
                    ++count;
                if (pic5 != null && pic5.Tag == "Mine")
                    ++count;

                if (count == 1)
                {
                    start.Image = Properties.Resources._1;
                    start.Tag = "1";
                }
                if (count == 2)
                {
                    start.Image = Properties.Resources._2;
                    start.Tag = "2";
                }
                if (count == 3)
                {
                    start.Image = Properties.Resources._3;
                    start.Tag = "3";
                }
                if (count == 4)
                {
                    start.Image = Properties.Resources._4;
                    start.Tag = "4";
                }
                if (count == 5)
                {
                    start.Image = Properties.Resources._5;
                    start.Tag = "5";
                }
            }

           
        }
        public void mineCount(PictureBox start, PictureBox pic1, PictureBox pic2, PictureBox pic3, PictureBox pic4, PictureBox pic5, PictureBox pic6, PictureBox pic7, PictureBox pic8)
        {
            int count = 0;

            if (start.Tag != "Mine")
            {
                if (pic1 != null && pic1.Tag == "Mine")
                    ++count;
                if (pic2 != null && pic2.Tag == "Mine")
                    ++count;
                if (pic3 != null && pic3.Tag == "Mine")
                    ++count;
                if (pic4 != null && pic4.Tag == "Mine")
                    ++count;
                if (pic5 != null && pic5.Tag == "Mine")
                    ++count;
                if (pic6 != null && pic6.Tag == "Mine")
                    ++count;
                if (pic7 != null && pic7.Tag == "Mine")
                    ++count;
                if (pic8 != null && pic8.Tag == "Mine")
                    ++count;

                if (count == 1)
                {
                    start.Image = Properties.Resources._1;
                    start.Tag = "1";
                }
                if (count == 2)
                {
                    start.Image = Properties.Resources._2;
                    start.Tag = "2";
                }
                if (count == 3)
                {
                    start.Image = Properties.Resources._3;
                    start.Tag = "3";
                }
                if (count == 4)
                {
                    start.Image = Properties.Resources._4;
                    start.Tag = "4";
                }
                if (count == 5)
                {
                    start.Image = Properties.Resources._5;
                    start.Tag = "5";
                }
                if (count == 6)
                {
                    start.Image = Properties.Resources._6;
                    start.Tag = "6";
                }
                if (count == 7)
                {
                    start.Image = Properties.Resources._7;
                    start.Tag = "7";
                }
                if (count == 8)
                {
                    start.Image = Properties.Resources._8;
                    start.Tag = "8";
                }
            }
           
        }
    }
}

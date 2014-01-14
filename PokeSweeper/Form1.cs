using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;


namespace PokeSweeper
{
    public partial class Form1 : Form
    {
        private ObjectCreator oC;
        Random r = new Random();

        int mine1;
        int mine2;
        int mine3;
        int mine4;
        int mine5;
        int mine6;
        int mine7;
        int mine8;
        int mine9;
        int mine10;
        int mine11;
        int mine12;
        int mine13;
        int mine14;
        int mine15;

        public Form1()
        {
            InitializeComponent();
            oC = new ObjectCreator();

            for (int i = 1; i <= 100; ++i)
            {
                converter(i).Image = Properties.Resources.Grass;
                converter(i).Tag = "Grass";
            }

            

            #region setMines
            mine1 = r.Next(1, 101);
            mine2 = r.Next(1, 101);
            if (mine2 == mine1)
                mine2 = r.Next(1, 101);
            mine3 = r.Next(1, 101);
            if (mine3 == mine1 || mine3 == mine2)
                mine3 = r.Next(1, 101);
            mine4 = r.Next(1, 101);
            if (mine4 == mine1 || mine4 == mine2 || mine4 == mine3)
                mine4 = r.Next(1, 101);
            mine5 = r.Next(1, 101);
            if (mine5 == mine1 || mine5 == mine2 || mine5 == mine3 || mine5 == mine4)
                mine5 = r.Next(1, 101);
            mine6 = r.Next(1, 101);
            if (mine6 == mine1 || mine6 == mine2 || mine6 == mine3 || mine6 == mine4 || mine6 == mine5)
                mine6 = r.Next(1, 101);
            mine7 = r.Next(1, 101);
            if (mine7 == mine1 || mine7 == mine2 || mine7 == mine3 || mine7 == mine4 || mine7 == mine5 || mine7 == mine6)
                mine7 = r.Next(1, 101);
            mine8 = r.Next(1, 101);
            if (mine8 == mine1 || mine8 == mine2 || mine8 == mine3 || mine8 == mine4 || mine8 == mine5 || mine8 == mine6 || mine8 == mine7)
                mine8 = r.Next(1, 101);
            mine9 = r.Next(1, 101);
            if (mine9 == mine1 || mine9 == mine2 || mine9 == mine3 || mine9 == mine4 || mine9 == mine5 || mine9 == mine6 || mine9 == mine7 || mine9 == mine8)
                mine9 = r.Next(1, 101);
            mine10 = r.Next(1, 101);
            if (mine10 == mine1 || mine10 == mine2 || mine10 == mine3 || mine10 == mine4 || mine10 == mine5 || mine10 == mine6 || mine10 == mine7 || mine10 == mine8 || mine10 == mine9)
                mine10 = r.Next(1, 101);
            mine11 = r.Next(1, 101);
            if (mine11 == mine1 || mine11 == mine2 || mine11 == mine3 || mine11 == mine4 || mine11 == mine5 || mine11 == mine6 || mine11 == mine7 || mine11 == mine8 || mine11 == mine9 || mine11 == mine10)
                mine11 = r.Next(1, 101);
            mine12 = r.Next(1, 101);
            if (mine12 == mine1 || mine12 == mine2 || mine12 == mine3 || mine12 == mine4 || mine12 == mine5 || mine12 == mine6 || mine12 == mine7 || mine12 == mine8 || mine12 == mine9 || mine12 == mine10 || mine12 == mine11)
                mine12 = r.Next(1, 101);
            mine13 = r.Next(1, 101);
            if (mine13 == mine1 || mine13 == mine2 || mine13 == mine3 || mine13 == mine4 || mine13 == mine5 || mine13 == mine6 || mine13 == mine7 || mine13 == mine8 || mine13 == mine9 || mine13 == mine10 || mine13 == mine11 || mine13 == mine12)
                mine13 = r.Next(1, 101);
            mine14 = r.Next(1, 101);
            if (mine14 == mine1 || mine14 == mine2 || mine14 == mine3 || mine14 == mine4 || mine14 == mine5 || mine14 == mine6 || mine14 == mine7 || mine14 == mine8 || mine14 == mine9 || mine14 == mine10 || mine14 == mine11 || mine14 == mine12 || mine14 == mine13)
                mine14 = r.Next(1, 101);
            mine15 = r.Next(1, 101);
            if (mine15 == mine1 || mine15 == mine2 || mine15 == mine3 || mine15 == mine4 || mine15 == mine5 || mine15 == mine6 || mine15 == mine7 || mine15 == mine8 || mine15 == mine9 || mine15 == mine10 || mine15 == mine11 || mine15 == mine12 || mine15 == mine13 || mine15 == mine14)
                mine15 = r.Next(1, 101);
            
            oC.makeMine(converter(mine1));
            oC.makeMine(converter(mine2));
            oC.makeMine(converter(mine3));
            oC.makeMine(converter(mine4));
            oC.makeMine(converter(mine5));
            oC.makeMine(converter(mine6));
            oC.makeMine(converter(mine7));
            oC.makeMine(converter(mine8));
            oC.makeMine(converter(mine9));
            oC.makeMine(converter(mine10));
            oC.makeMine(converter(mine11));
            oC.makeMine(converter(mine12));
            oC.makeMine(converter(mine13));
            oC.makeMine(converter(mine14));
            oC.makeMine(converter(mine15));

            for (int i = 1; i <= 100; ++i)
            {
                if (i == 1)
                    oC.mineCount(converter(i), getRightPic(i), getBotRightPic(i), getBotPic(i));
                if (i > 1 && i < 10)
                    oC.mineCount(converter(i), getRightPic(i), getBotRightPic(i), getBotPic(i), getBotLeftPic(i), getLeftPic(i));
                if (i == 10)
                    oC.mineCount(converter(i), getBotPic(i), getBotLeftPic(i), getLeftPic(i));
                if (i == 11 || i == 21 || i == 31 || i == 41 || i == 51 || i == 61 || i == 71 || i == 81)
                    oC.mineCount(converter(i), getTopPic(i), getTopRightPic(i), getRightPic(i), getBotRightPic(i), getBotPic(i));
                if (i == 20 || i == 30 || i == 40 || i == 50 || i == 60 || i == 70 || i == 80 || i == 90)
                    oC.mineCount(converter(i), getBotPic(i), getBotLeftPic(i), getLeftPic(i), getTopLeftPic(i), getTopPic(i));
                if (i == 91)
                    oC.mineCount(converter(i), getTopPic(i), getTopRightPic(i), getRightPic(i));
                if (i == 100)
                    oC.mineCount(converter(i), getLeftPic(i), getTopLeftPic(i), getTopPic(i));
                if (i > 91 && i < 100)
                    oC.mineCount(converter(i), getLeftPic(i), getTopLeftPic(i), getTopPic(i), getTopRightPic(i), getRightPic(i));
                if (i > 11 && i < 90 && i != 21 && i != 31 && i != 41 && i != 51 && i != 61 && i != 71 && i != 81
                    && i != 20 && i != 30 && i != 40 && i != 50 && i != 60 && i != 70 && i != 80)
                    oC.mineCount(converter(i), getTopPic(i), getTopRightPic(i), getRightPic(i), getBotRightPic(i), getBotPic(i), getBotLeftPic(i), getLeftPic(i), getTopLeftPic(i));
            }

            #endregion setMines

            
        }

        private void newGame()
        {
            oC.setSpace(100);

            for (int i = 1; i < 101; ++i)
            {
                converter(i).Image = Properties.Resources.Grass;
                converter(i).Tag = "Grass";
                converter(i).Visible = false;
            }

            mine1 = r.Next(1, 101);
            mine2 = r.Next(1, 101);
            if (mine2 == mine1)
                mine2 = r.Next(1, 101);
            mine3 = r.Next(1, 101);
            if (mine3 == mine1 || mine3 == mine2)
                mine3 = r.Next(1, 101);
            mine4 = r.Next(1, 101);
            if (mine4 == mine1 || mine4 == mine2 || mine4 == mine3)
                mine4 = r.Next(1, 101);
            mine5 = r.Next(1, 101);
            if (mine5 == mine1 || mine5 == mine2 || mine5 == mine3 || mine5 == mine4)
                mine5 = r.Next(1, 101);
            mine6 = r.Next(1, 101);
            if (mine6 == mine1 || mine6 == mine2 || mine6 == mine3 || mine6 == mine4 || mine6 == mine5)
                mine6 = r.Next(1, 101);
            mine7 = r.Next(1, 101);
            if (mine7 == mine1 || mine7 == mine2 || mine7 == mine3 || mine7 == mine4 || mine7 == mine5 || mine7 == mine6)
                mine7 = r.Next(1, 101);
            mine8 = r.Next(1, 101);
            if (mine8 == mine1 || mine8 == mine2 || mine8 == mine3 || mine8 == mine4 || mine8 == mine5 || mine8 == mine6 || mine8 == mine7)
                mine8 = r.Next(1, 101);
            mine9 = r.Next(1, 101);
            if (mine9 == mine1 || mine9 == mine2 || mine9 == mine3 || mine9 == mine4 || mine9 == mine5 || mine9 == mine6 || mine9 == mine7 || mine9 == mine8)
                mine9 = r.Next(1, 101);
            mine10 = r.Next(1, 101);
            if (mine10 == mine1 || mine10 == mine2 || mine10 == mine3 || mine10 == mine4 || mine10 == mine5 || mine10 == mine6 || mine10 == mine7 || mine10 == mine8 || mine10 == mine9)
                mine10 = r.Next(1, 101);
            mine11 = r.Next(1, 101);
            if (mine11 == mine1 || mine11 == mine2 || mine11 == mine3 || mine11 == mine4 || mine11 == mine5 || mine11 == mine6 || mine11 == mine7 || mine11 == mine8 || mine11 == mine9 || mine11 == mine10)
                mine11 = r.Next(1, 101);
            mine12 = r.Next(1, 101);
            if (mine12 == mine1 || mine12 == mine2 || mine12 == mine3 || mine12 == mine4 || mine12 == mine5 || mine12 == mine6 || mine12 == mine7 || mine12 == mine8 || mine12 == mine9 || mine12 == mine10 || mine12 == mine11)
                mine12 = r.Next(1, 101);
            mine13 = r.Next(1, 101);
            if (mine13 == mine1 || mine13 == mine2 || mine13 == mine3 || mine13 == mine4 || mine13 == mine5 || mine13 == mine6 || mine13 == mine7 || mine13 == mine8 || mine13 == mine9 || mine13 == mine10 || mine13 == mine11 || mine13 == mine12)
                mine13 = r.Next(1, 101);
            mine14 = r.Next(1, 101);
            if (mine14 == mine1 || mine14 == mine2 || mine14 == mine3 || mine14 == mine4 || mine14 == mine5 || mine14 == mine6 || mine14 == mine7 || mine14 == mine8 || mine14 == mine9 || mine14 == mine10 || mine14 == mine11 || mine14 == mine12 || mine14 == mine13)
                mine14 = r.Next(1, 101);
            mine15 = r.Next(1, 101);
            if (mine15 == mine1 || mine15 == mine2 || mine15 == mine3 || mine15 == mine4 || mine15 == mine5 || mine15 == mine6 || mine15 == mine7 || mine15 == mine8 || mine15 == mine9 || mine15 == mine10 || mine15 == mine11 || mine15 == mine12 || mine15 == mine13 || mine15 == mine14)
                mine15 = r.Next(1, 101);

            oC.makeMine(converter(mine1));
            oC.makeMine(converter(mine2));
            oC.makeMine(converter(mine3));
            oC.makeMine(converter(mine4));
            oC.makeMine(converter(mine5));
            oC.makeMine(converter(mine6));
            oC.makeMine(converter(mine7));
            oC.makeMine(converter(mine8));
            oC.makeMine(converter(mine9));
            oC.makeMine(converter(mine10));
            oC.makeMine(converter(mine11));
            oC.makeMine(converter(mine12));
            oC.makeMine(converter(mine13));
            oC.makeMine(converter(mine14));
            oC.makeMine(converter(mine15));

            for (int i = 1; i <= 100; ++i)
            {
                if (i == 1)
                    oC.mineCount(converter(i), getRightPic(i), getBotRightPic(i), getBotPic(i));
                if (i > 1 && i < 10)
                    oC.mineCount(converter(i), getRightPic(i), getBotRightPic(i), getBotPic(i), getBotLeftPic(i), getLeftPic(i));
                if (i == 10)
                    oC.mineCount(converter(i), getBotPic(i), getBotLeftPic(i), getLeftPic(i));
                if (i == 11 || i == 21 || i == 31 || i == 41 || i == 51 || i == 61 || i == 71 || i == 81)
                    oC.mineCount(converter(i), getTopPic(i), getTopRightPic(i), getRightPic(i), getBotRightPic(i), getBotPic(i));
                if (i == 20 || i == 30 || i == 40 || i == 50 || i == 60 || i == 70 || i == 80 || i == 90)
                    oC.mineCount(converter(i), getBotPic(i), getBotLeftPic(i), getLeftPic(i), getTopLeftPic(i), getTopPic(i));
                if (i == 91)
                    oC.mineCount(converter(i), getTopPic(i), getTopLeftPic(i), getLeftPic(i));
                if (i == 100)
                    oC.mineCount(converter(i), getLeftPic(i), getTopLeftPic(i), getTopPic(i));
                if (i > 91 && i < 100)
                    oC.mineCount(converter(i), getLeftPic(i), getTopLeftPic(i), getTopPic(i), getTopRightPic(i), getRightPic(i));
                if (i > 11 && i < 90 && i != 21 && i != 31 && i != 41 && i != 51 && i != 61 && i != 71 && i != 81
                    && i != 20 && i != 30 && i != 40 && i != 50 && i != 60 && i != 70 && i != 80)
                    oC.mineCount(converter(i), getTopPic(i), getTopRightPic(i), getRightPic(i), getBotRightPic(i), getBotPic(i), getBotLeftPic(i), getLeftPic(i), getTopLeftPic(i));
            }
        }

        private void clickedEvent(int clicked)
        {
            converter(clicked).Visible = true;
            clear(clicked);

            
            if (oC.loseOrWin(converter(clicked)) == true)
            {
                for (int i = 1; i <= 100; ++i)
                {
                    if (converter(i).Tag.Equals("Mine"))
                        converter(i).Visible = true;
                }
            }
            
        }

        public PictureBox converter(int x)
        {
            if (x == 1)
                return pictureBox1;
            else if (x == 2)
                return pictureBox2;
            else if (x == 3)
                return pictureBox3;
            else if (x == 4)
                return pictureBox4;
            else if (x == 5)
                return pictureBox5;
            else if (x == 6)
                return pictureBox6;
            else if (x == 7)
                return pictureBox7;
            else if (x == 8)
                return pictureBox8;
            else if (x == 9)
                return pictureBox9;
            else if (x == 10)
                return pictureBox10;
            else if (x == 11)
                return pictureBox11;
            else if (x == 12)
                return pictureBox12;
            else if (x == 13)
                return pictureBox13;
            else if (x == 14)
                return pictureBox14;
            else if (x == 15)
                return pictureBox15;
            else if (x == 16)
                return pictureBox16;
            else if (x == 17)
                return pictureBox17;
            else if (x == 18)
                return pictureBox18;
            else if (x == 19)
                return pictureBox19;
            else if (x == 20)
                return pictureBox20;
            else if (x == 21)
                return pictureBox21;
            else if (x == 22)
                return pictureBox22;
            else if (x == 23)
                return pictureBox23;
            else if (x == 24)
                return pictureBox24;
            else if (x == 25)
                return pictureBox25;
            else if (x == 26)
                return pictureBox26;
            else if (x == 27)
                return pictureBox27;
            else if (x == 28)
                return pictureBox28;
            else if (x == 29)
                return pictureBox29;
            else if (x == 30)
                return pictureBox30;
            else if (x == 31)
                return pictureBox31;
            else if (x == 32)
                return pictureBox32;
            else if (x == 33)
                return pictureBox33;
            else if (x == 34)
                return pictureBox34;
            else if (x == 35)
                return pictureBox35;
            else if (x == 36)
                return pictureBox36;
            else if (x == 37)
                return pictureBox37;
            else if (x == 38)
                return pictureBox38;
            else if (x == 39)
                return pictureBox39;
            else if (x == 40)
                return pictureBox40;
            else if (x == 41)
                return pictureBox41;
            else if (x == 42)
                return pictureBox42;
            else if (x == 43)
                return pictureBox43;
            else if (x == 44)
                return pictureBox44;
            else if (x == 45)
                return pictureBox45;
            else if (x == 46)
                return pictureBox46;
            else if (x == 47)
                return pictureBox47;
            else if (x == 48)
                return pictureBox48;
            else if (x == 49)
                return pictureBox49;
            else if (x == 50)
                return pictureBox50;
            else if (x == 51)
                return pictureBox51;
            else if (x == 52)
                return pictureBox52;
            else if (x == 53)
                return pictureBox53;
            else if (x == 54)
                return pictureBox54;
            else if (x == 55)
                return pictureBox55;
            else if (x == 56)
                return pictureBox56;
            else if (x == 57)
                return pictureBox57;
            else if (x == 58)
                return pictureBox58;
            else if (x == 59)
                return pictureBox59;
            else if (x == 60)
                return pictureBox60;
            else if (x == 61)
                return pictureBox61;
            else if (x == 62)
                return pictureBox62;
            else if (x == 63)
                return pictureBox63;
            else if (x == 64)
                return pictureBox64;
            else if (x == 65)
                return pictureBox65;
            else if (x == 66)
                return pictureBox66;
            else if (x == 67)
                return pictureBox67;
            else if (x == 68)
                return pictureBox68;
            else if (x == 69)
                return pictureBox69;
            else if (x == 70)
                return pictureBox70;
            else if (x == 71)
                return pictureBox71;
            else if (x == 72)
                return pictureBox72;
            else if (x == 73)
                return pictureBox73;
            else if (x == 74)
                return pictureBox74;
            else if (x == 75)
                return pictureBox75;
            else if (x == 76)
                return pictureBox76;
            else if (x == 77)
                return pictureBox77;
            else if (x == 78)
                return pictureBox78;
            else if (x == 79)
                return pictureBox79;
            else if (x == 80)
                return pictureBox80;
            else if (x == 81)
                return pictureBox81;
            else if (x == 82)
                return pictureBox82;
            else if (x == 83)
                return pictureBox83;
            else if (x == 84)
                return pictureBox84;
            else if (x == 85)
                return pictureBox85;
            else if (x == 86)
                return pictureBox86;
            else if (x == 87)
                return pictureBox87;
            else if (x == 88)
                return pictureBox88;
            else if (x == 89)
                return pictureBox89;
            else if (x == 90)
                return pictureBox90;
            else if (x == 91)
                return pictureBox91;
            else if (x == 92)
                return pictureBox92;
            else if (x == 93)
                return pictureBox93;
            else if (x == 94)
                return pictureBox94;
            else if (x == 95)
                return pictureBox95;
            else if (x == 96)
                return pictureBox96;
            else if (x == 97)
                return pictureBox97;
            else if (x == 98)
                return pictureBox98;
            else if (x == 99)
                return pictureBox99;
            else if (x == 100)
                return pictureBox100;



            return null;
        }

        public PictureBox getTopPic(int x)
        {
            if (x >= 11 && x > 0)
                return converter(x - 10);
            else 
                return null;
        }

        public PictureBox getTopRightPic(int x)
        {
            if (x >= 11 && x != 10 && x != 20 && x != 30 && x != 40 && x != 50 && x != 60 && x != 70 && x != 80 && x != 90 && x != 100)
                return converter(x - 9);
            else
                return null;
        }

        public PictureBox getRightPic(int x)
        {
            if (x != 10 && x != 20 && x != 30 && x != 40 && x != 50 && x != 60 && x != 70 && x != 80 && x != 90 && x != 100)
                return converter(x + 1);
            else
                return null;
        }

        public PictureBox getBotRightPic(int x)
        {
            if (x != 10 && x != 20 && x != 30 && x != 40 && x != 50 && x != 60 && x != 70 && x != 80 && x <= 89 && x > 0)
                return converter(x + 11);
            else
                return null;
        }

        public PictureBox getBotPic(int x)
        {
            if (x <= 90 && x > 0)
                return converter(x + 10);
            else
                return null;
        }

        public PictureBox getBotLeftPic(int x)
        {
            if (x != 1 && x != 11 && x != 21 && x != 31 && x != 41 && x != 51 && x != 61 && x != 71 && x != 81 && x <= 90)
                return converter(x + 9);
            else
                return null;
        }

        public PictureBox getLeftPic(int x)
        {
            if (x != 1 && x != 11 && x != 21 && x != 31 && x != 41 && x != 51 && x != 61 && x != 71 && x != 81 && x != 91)
                return converter(x - 1);
            else
                return null;
        }

        public PictureBox getTopLeftPic(int x)
        {
            if (x > 11 && x != 21 && x != 31 && x != 41 && x != 51 && x != 61 && x != 71 && x != 81 && x != 91)
                return converter(x - 11);
            else
                return null;
        }

        public void clear(int start)
        {
            bool top = false;
            bool topRight = false;
            bool right = false;
            bool botRight = false;
            bool bot = false;
            bool botLeft = false;
            bool left = false;
            bool topLeft = false;

           
            PictureBox current = converter(start);
            String testy = current.Tag.ToString();

            if (converter(start) != null && converter(start).Tag.Equals("Grass"))
            {
                if (getTopPic(start) != null && getTopPic(start).Tag.Equals("Grass") && getTopPic(start).Visible == false)
                {
                    getTopPic(start).Visible = true;
                    top = true;
                    oC.dropSpace();
                }
                else if (getTopPic(start) != null && !getTopPic(start).Tag.Equals("Grass") && !getTopPic(start).Tag.Equals("Mine") && getTopPic(start).Visible == false)
                {
                    getTopPic(start).Visible = true;
                    oC.dropSpace();
                }

                if (getTopRightPic(start) != null && getTopRightPic(start).Tag.Equals("Grass") && getTopRightPic(start).Visible == false)
                {
                    getTopRightPic(start).Visible = true;
                    topRight = true;
                    oC.dropSpace();
                }
                else if (getTopRightPic(start) != null && !getTopRightPic(start).Tag.Equals("Grass") && !getTopRightPic(start).Tag.Equals("Mine") && getRightPic(start).Visible == false)
                {
                    getTopRightPic(start).Visible = true;
                    oC.dropSpace();
                }

                if (getRightPic(start) != null && getRightPic(start).Tag.Equals("Grass") && getRightPic(start).Visible == false)
                {
                    getRightPic(start).Visible = true;
                    right = true;
                    oC.dropSpace();
                }
                else if (getRightPic(start) != null && !getRightPic(start).Tag.Equals("Grass") && !getRightPic(start).Tag.Equals("Mine") && getRightPic(start).Visible == false)
                {
                    getRightPic(start).Visible = true;
                    oC.dropSpace();
                }

                if (getBotRightPic(start) != null && getBotRightPic(start).Tag.Equals("Grass") && getBotRightPic(start).Visible == false)
                {

                    getBotRightPic(start).Visible = true;
                    oC.dropSpace();
                    botRight = true;
                }
                else if (getBotRightPic(start) != null && !getBotRightPic(start).Tag.Equals("Grass") && !getBotRightPic(start).Tag.Equals("Mine") && getBotRightPic(start).Visible == false)
                {
                    getBotRightPic(start).Visible = true;
                    oC.dropSpace();
                }

                if (getBotPic(start) != null && getBotPic(start).Tag.Equals("Grass") && getBotPic(start).Visible == false)
                {

                    getBotPic(start).Visible = true;
                    oC.dropSpace();
                    bot = true;
                }
                else if (getBotPic(start) != null && !getBotPic(start).Tag.Equals("Grass") && !getBotPic(start).Tag.Equals("Mine") && getBotPic(start).Visible == false)
                {
                    getBotPic(start).Visible = true;
                    oC.dropSpace();
                }

                if (getBotLeftPic(start) != null && getBotLeftPic(start).Tag.Equals("Grass") && getBotLeftPic(start).Visible == false)
                {
                    getBotLeftPic(start).Visible = true;
                    oC.dropSpace();
                    botLeft = true;
                }
                else if (getBotLeftPic(start) != null && !getBotLeftPic(start).Tag.Equals("Grass") && !getBotLeftPic(start).Tag.Equals("Mine") && getBotLeftPic(start).Visible == false)
                {
                    getBotLeftPic(start).Visible = true;
                    oC.dropSpace();
                }

                if (getLeftPic(start) != null && getLeftPic(start).Tag.Equals("Grass") && getLeftPic(start).Visible == false)
                {
                    getLeftPic(start).Visible = true;
                    left = true;
                    oC.dropSpace();
                }
                else if (getLeftPic(start) != null && !getLeftPic(start).Tag.Equals("Grass") && !getLeftPic(start).Tag.Equals("Mine") && getLeftPic(start).Visible == false)
                {
                    getLeftPic(start).Visible = true;
                    oC.dropSpace();
                }
                if (getTopLeftPic(start) != null && getTopLeftPic(start).Tag.Equals("Grass") && getTopLeftPic(start).Visible == false)
                {
                    getTopLeftPic(start).Visible = true;
                    topLeft = true;
                    oC.dropSpace();
                }
                else if (getTopLeftPic(start) != null && !getTopLeftPic(start).Tag.Equals("Grass") && !getTopLeftPic(start).Tag.Equals("Mine") && getTopLeftPic(start).Visible == false)
                {
                    getTopLeftPic(start).Visible = true;
                    oC.dropSpace();
                }
            }

            if (top == true)
                clear(start - 10);
            if (topRight == true)
                clear(start - 9);
            if (right == true)
                clear(start + 1);
            if (botRight == true)
                clear(start + 11);
            if (bot == true)
                clear(start + 10);
            if (botLeft == true)
                clear(start + 9);
            if (left == true)
                clear(start - 1);
            if (topLeft == true)
                clear(start - 11);

        }

        #region buttonClicks

        private void button1_Click(object sender, EventArgs e)
        {
            clickedEvent(1);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            clickedEvent(2);
        }

        private void button3_Click(object sender, EventArgs e)
        {
            clickedEvent(3);
        }

        private void button4_Click(object sender, EventArgs e)
        {
            clickedEvent(4);
        }

        private void button5_Click(object sender, EventArgs e)
        {
            clickedEvent(5);
        }

        private void button6_Click(object sender, EventArgs e)
        {
            clickedEvent(6);
        }

        private void button7_Click(object sender, EventArgs e)
        {
            clickedEvent(7);
        }

        private void button8_Click(object sender, EventArgs e)
        {
            clickedEvent(8);
        }

        private void button9_Click(object sender, EventArgs e)
        {
            clickedEvent(9);
        }

        private void button10_Click(object sender, EventArgs e)
        {
            clickedEvent(10);
        }

        private void button11_Click(object sender, EventArgs e)
        {
            clickedEvent(11);
        }

        private void button12_Click(object sender, EventArgs e)
        {
            clickedEvent(12);
        }

        private void button13_Click(object sender, EventArgs e)
        {
            clickedEvent(13);
        }

        private void button14_Click(object sender, EventArgs e)
        {
            clickedEvent(14);
        }

        private void button15_Click(object sender, EventArgs e)
        {
            clickedEvent(15);
        }

        private void button16_Click(object sender, EventArgs e)
        {
            clickedEvent(16);
        }

        private void button17_Click(object sender, EventArgs e)
        {
            clickedEvent(17);
        }

        private void button18_Click(object sender, EventArgs e)
        {
            clickedEvent(18);
        }

        private void button19_Click(object sender, EventArgs e)
        {
            clickedEvent(19);
        }

        private void button20_Click(object sender, EventArgs e)
        {
            clickedEvent(20);
        }

        private void button21_Click(object sender, EventArgs e)
        {
            clickedEvent(21);
        }

        private void button22_Click(object sender, EventArgs e)
        {
            clickedEvent(22);
        }

        private void button23_Click(object sender, EventArgs e)
        {
            clickedEvent(23);
        }

        private void button24_Click(object sender, EventArgs e)
        {
            clickedEvent(24);
        }

        private void button25_Click(object sender, EventArgs e)
        {
            clickedEvent(25);
        }

        private void button26_Click(object sender, EventArgs e)
        {
            clickedEvent(26);
        }

        private void button27_Click(object sender, EventArgs e)
        {
            clickedEvent(27);
        }

        private void button28_Click(object sender, EventArgs e)
        {
            clickedEvent(28);
        }

        private void button29_Click(object sender, EventArgs e)
        {
            clickedEvent(29);
        }

        private void button30_Click(object sender, EventArgs e)
        {
            clickedEvent(30);
        }

        private void button31_Click(object sender, EventArgs e)
        {
            clickedEvent(31);
        }

        private void button32_Click(object sender, EventArgs e)
        {
            clickedEvent(32);
        }

        private void button33_Click(object sender, EventArgs e)
        {
            clickedEvent(33);
        }

        private void button34_Click(object sender, EventArgs e)
        {
            clickedEvent(34);
        }

        private void button35_Click(object sender, EventArgs e)
        {
            clickedEvent(35);
        }

        private void button36_Click(object sender, EventArgs e)
        {
            clickedEvent(36);
        }

        private void button37_Click(object sender, EventArgs e)
        {
            clickedEvent(37);
        }

        private void button38_Click(object sender, EventArgs e)
        {
            clickedEvent(38);
        }

        private void button39_Click(object sender, EventArgs e)
        {
            clickedEvent(39);
        }

        private void button40_Click(object sender, EventArgs e)
        {
            clickedEvent(40);
        }

        private void button41_Click(object sender, EventArgs e)
        {
            clickedEvent(41);
        }

        private void button42_Click(object sender, EventArgs e)
        {
            clickedEvent(42);
        }

        private void button43_Click(object sender, EventArgs e)
        {
            clickedEvent(43);
        }

        private void button44_Click(object sender, EventArgs e)
        {
            clickedEvent(44);
        }

        private void button45_Click(object sender, EventArgs e)
        {
            clickedEvent(45);
        }

        private void button46_Click(object sender, EventArgs e)
        {
            clickedEvent(46);
        }

        private void button47_Click(object sender, EventArgs e)
        {
            clickedEvent(47);
        }

        private void button48_Click(object sender, EventArgs e)
        {
            clickedEvent(48);
        }

        private void button49_Click(object sender, EventArgs e)
        {
            clickedEvent(49);
        }

        private void button50_Click(object sender, EventArgs e)
        {
            clickedEvent(50);
        }

        private void button51_Click(object sender, EventArgs e)
        {
            clickedEvent(51);
        }

        private void button52_Click(object sender, EventArgs e)
        {
            clickedEvent(52);
        }

        private void button53_Click(object sender, EventArgs e)
        {
            clickedEvent(53);
        }

        private void button54_Click(object sender, EventArgs e)
        {
            clickedEvent(54);
        }

        private void button55_Click(object sender, EventArgs e)
        {
            clickedEvent(55);
        }

        private void button56_Click(object sender, EventArgs e)
        {
            clickedEvent(56);
        }

        private void button57_Click(object sender, EventArgs e)
        {
            clickedEvent(57);
        }

        private void button58_Click(object sender, EventArgs e)
        {
            clickedEvent(58);
        }

        private void button59_Click(object sender, EventArgs e)
        {
            clickedEvent(59);
        }

        private void button60_Click(object sender, EventArgs e)
        {
            clickedEvent(60);
        }

        private void button61_Click(object sender, EventArgs e)
        {
            clickedEvent(61);
        }

        private void button62_Click(object sender, EventArgs e)
        {
            clickedEvent(62);
        }

        private void button63_Click(object sender, EventArgs e)
        {
            clickedEvent(63);
        }

        private void button64_Click(object sender, EventArgs e)
        {
            clickedEvent(64);
        }

        private void button65_Click(object sender, EventArgs e)
        {
            clickedEvent(65);
        }

        private void button66_Click(object sender, EventArgs e)
        {
            clickedEvent(66);
        }

        private void button67_Click(object sender, EventArgs e)
        {
            clickedEvent(67);
        }

        private void button68_Click(object sender, EventArgs e)
        {
            clickedEvent(68);
        }

        private void button69_Click(object sender, EventArgs e)
        {
            clickedEvent(69);
        }

        private void button70_Click(object sender, EventArgs e)
        {
            clickedEvent(70);
        }

        private void button71_Click(object sender, EventArgs e)
        {
            clickedEvent(71);
        }

        private void button72_Click(object sender, EventArgs e)
        {
            clickedEvent(72);
        }

        private void button73_Click(object sender, EventArgs e)
        {
            clickedEvent(73);
        }

        private void button74_Click(object sender, EventArgs e)
        {
           clickedEvent(74);
        }

        private void button75_Click(object sender, EventArgs e)
        {
            clickedEvent(75);
        }

        private void button76_Click(object sender, EventArgs e)
        {
            clickedEvent(76);
        }

        private void button77_Click(object sender, EventArgs e)
        {
            clickedEvent(77);
        }

        private void button78_Click(object sender, EventArgs e)
        {
            clickedEvent(78);
        }

        private void button79_Click(object sender, EventArgs e)
        {
            clickedEvent(79);
        }

        private void button80_Click(object sender, EventArgs e)
        {
            clickedEvent(80);
        }

        private void button81_Click(object sender, EventArgs e)
        {
            clickedEvent(81);
        }

        private void button82_Click(object sender, EventArgs e)
        {
            clickedEvent(82);
        }

        private void button83_Click(object sender, EventArgs e)
        {
            clickedEvent(83);
        }

        private void button84_Click(object sender, EventArgs e)
        {
            clickedEvent(84);
        }

        private void button85_Click(object sender, EventArgs e)
        {
            clickedEvent(85);
        }

        private void button86_Click(object sender, EventArgs e)
        {
            clickedEvent(86);
        }

        private void button87_Click(object sender, EventArgs e)
        {
            clickedEvent(87);
        }

        private void button88_Click(object sender, EventArgs e)
        {
            clickedEvent(88);
        }

        private void button89_Click(object sender, EventArgs e)
        {
            clickedEvent(89);
        }

        private void button90_Click(object sender, EventArgs e)
        {
            clickedEvent(90);
        }

        private void button91_Click(object sender, EventArgs e)
        {
            clickedEvent(91);
        }

        private void button92_Click(object sender, EventArgs e)
        {
            clickedEvent(92);
        }

        private void button93_Click(object sender, EventArgs e)
        {
            clickedEvent(93);
        }

        private void button94_Click(object sender, EventArgs e)
        {
            clickedEvent(94);
        }

        private void button95_Click(object sender, EventArgs e)
        {
            clickedEvent(95);
        }

        private void button96_Click(object sender, EventArgs e)
        {
            clickedEvent(96);
        }

        private void button97_Click(object sender, EventArgs e)
        {
            clickedEvent(97);
        }

        private void button98_Click(object sender, EventArgs e)
        {
            clickedEvent(98);
        }

        private void button99_Click(object sender, EventArgs e)
        {
            clickedEvent(99);
        }

        private void button100_Click(object sender, EventArgs e)
        {
            clickedEvent(100);
        }

        #endregion buttonClicks

        private void button101_Click(object sender, EventArgs e)
        {
            newGame();
        }
    }
}

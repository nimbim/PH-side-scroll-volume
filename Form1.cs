using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PHnewnew
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        const int xTL = 50;
        const int yTL = 110;
        const int xyC = 30;
        const int xBR = xTL + xyC * 14;
        Point CornerTopLeft = new Point(xTL, yTL);

        Random rnd;
        Graphics g;
        Pen p;
        Size blockSize = new Size(xyC, xyC);
        
        List<ABlock> theBlocks = new List<ABlock>();
        BlockRandomizer BlockRnd;
        int theVolume = 50;
        const int VolumeStep = 2;
        int activeLabel = 2;

        private void Form1_Load(object sender, EventArgs e)
        {
            g = CreateGraphics();
            p = new Pen(Brushes.Black);
            rnd = new Random();
            BlockRnd = new BlockRandomizer();

            //Create All White Blocks
            int Xtemp = xTL;
            int Ytemp = yTL;
            Point tempLoc;
            for (int i = 0; i < 15; i++)
            {
                for (int j = 0; j < 3; j++)
                {
                    Ytemp = yTL + (xyC * j);

                    tempLoc = new Point(Xtemp, Ytemp);
                    
                    theBlocks.Add(new ABlock(tempLoc, 1, xTL, yTL));
                }
                Xtemp = xTL + (xyC * i);
            }
        }

        private int GetTimerValue()
        {
            return 600 - theVolume * 5;
        }
        private void PrintVolume()
        {
            LbVolume.Text = theVolume + "%";
        }

        private void button1_Click(object sender, EventArgs e)
        {
            foreach(ABlock ab in theBlocks)
            {
                ab.Draw(g, p);
            }
            PrintVolume();
            timer1.Enabled = true;
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            timer1.Interval = GetTimerValue();
            
            foreach (ABlock ab in theBlocks)
            {
                int EdgeIndicator = ab.MoveLeftOrReturnEdgeRow();
                int CurrentType = ab.Modus;
                if (EdgeIndicator == 0)
                {
                    ab.Draw(g, p);
                }
                else
                {
                    CheckAgainstActiveLb(CurrentType, EdgeIndicator);
                }
            }
            for(int i = 0; i < 3; i++)
            {
                theBlocks.RemoveAt(0);
                
                Point tempLoc = new Point(xBR, yTL + xyC * i);
                
                theBlocks.Add(new ABlock(tempLoc, BlockRnd.NextBlockType(), xTL, yTL));
            }

            PrintVolume();
        }

        private void buttonUp_Click(object sender, EventArgs e)
        {
            activeLabel--;
            UpDownLbManage();
        }
        private void buttonDown_Click(object sender, EventArgs e)
        {
            activeLabel++;
            UpDownLbManage();
        }

        private void UpDownLbManage()
        {
            if(activeLabel < 1)
            {
                activeLabel = 1;
            }
            else if(activeLabel > 3)
            {
                activeLabel = 3;
            }

            if(activeLabel == 1)
            {
                LbRow1.Visible = true;
                LbRow2.Visible = false;
                LbRow3.Visible = false;
            }
            if (activeLabel == 2)
            {
                LbRow1.Visible = false;
                LbRow2.Visible = true;
                LbRow3.Visible = false;
            }
            if (activeLabel == 3)
            {
                LbRow1.Visible = false;
                LbRow2.Visible = false;
                LbRow3.Visible = true;
            }
        }

        private void CheckAgainstActiveLb(int Type, int Edge)
        {
            if(Edge == activeLabel)
            {
                switch(Type)
                {
                    case 2: theVolume += VolumeStep;
                        break;
                    case 3: theVolume -= VolumeStep;
                        break;
                    case 4: theVolume = 0;
                        break;
                }
            }
            FixVolume();
        }
        private void FixVolume()
        {
            if(theVolume < 0)
            {
                theVolume = 0;
            }
            if (theVolume > 100)
            {
                theVolume = 100;
            }
        }
    }
}

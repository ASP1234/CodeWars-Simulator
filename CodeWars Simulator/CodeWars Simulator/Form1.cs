using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace CodeWars_Simulator
{
    public partial class Form1 : Form
    {
        public int MINS, SECS;

        public Form1()
        {
            InitializeComponent();

            team[] TEAM = new team[6];
            TEAM[0] = new team(teamID_tb1, mainQ_tb1, score_tb1, bonusQ_tb1, mainQ_btn1, neg_btn1, bonus_btn1, "1");
            TEAM[1] = new team(teamID_tb2, mainQ_tb2, score_tb2, bonusQ_tb2, mainQ_btn2, neg_btn2, bonus_btn2, "2");
            TEAM[2] = new team(teamID_tb3, mainQ_tb3, score_tb3, bonusQ_tb3, mainQ_btn3, neg_btn3, bonus_btn3, "3");
            TEAM[3] = new team(teamID_tb4, mainQ_tb4, score_tb4, bonusQ_tb4, mainQ_btn4, neg_btn4, bonus_btn4, "4");
            TEAM[4] = new team(teamID_tb5, mainQ_tb5, score_tb5, bonusQ_tb5, mainQ_btn5, neg_btn5, bonus_btn5, "5");
            TEAM[5] = new team(teamID_tb6, mainQ_tb6, score_tb6, bonusQ_tb6, mainQ_btn6, neg_btn6, bonus_btn6, "6");

            for (int i = 0; i < 6; i++)
            {
                TEAM[i].Qnum = i + 1;
                TEAM[i].display("");
            }

            timer1.Stop();

            
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            if (SECS == 0)
            {
                SECS = 59;
                MINS--;
            }

            else
                SECS--;

            if(MINS>=10)
                mins_tb.Text = MINS.ToString();
            else
                mins_tb.Text = "0"+MINS.ToString();

            if(SECS>=10)
                secs_tb.Text = SECS.ToString();
            else
                secs_tb.Text = "0"+SECS.ToString();
        }

        private void start_btn_Click(object sender, EventArgs e)
        {
            MINS = 20;
            SECS = 0;
            timer1.Start();
            start_btn.Visible = false;
        }

       
    }


    public class team
    {
        public TextBox teamID;
        public String ID;
        public TextBox mainQ;
        public int Qnum;
        public TextBox Score;
        public int points;
        public TextBox bonusQ;
        public Button mainQ_btn;
        public Button neg_btn;
        public Button bonusQ_btn;

        public team(TextBox teamID, TextBox mainQ, TextBox Score, TextBox bonusQ, Button mainQ_btn, Button neg_btn, Button bonusQ_btn, String ID)
        {
            this.teamID = teamID;
            this.mainQ = mainQ;
            this.Score = Score;
            this.bonusQ = bonusQ;
            this.mainQ_btn = mainQ_btn;
            this.neg_btn = neg_btn;
            this.bonusQ_btn = bonusQ_btn;
            this.ID = ID;
            this.points = 0;
            this.teamID.Text = this.ID;
        }

        public void display(String bonus_num)
        {
            this.mainQ.Text = this.Qnum.ToString();
            this.Score.Text = this.points.ToString();
            this.bonusQ.Text = bonus_num;
        }
    }

}

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
        public Form1()
        {
            InitializeComponent();
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

        public void display(int bonus_num)
        {
            this.mainQ.Text = this.Qnum.ToString();
            this.Score.Text = this.points.ToString();
            this.bonusQ.Text = bonus_num.ToString();
        }
    }

}

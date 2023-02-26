using System.Drawing.Text;

namespace MemoryGameApp
{
    public partial class frmMemory : Form
    {
        List<Button> lstcardbuttons;
        //AF good to keep to keep to uniform naming convention - variable below should be all lowercase, as you named the rest of the variables in the project like that
        bool GameActive = false;
        Random rnd = new();
        private enum TurnEnum { Player1, Player2 }
        TurnEnum currentturn = TurnEnum.Player1;
        Button button1;
        Button button2;
        int Score1 = 0;
        int Score2 = 0;
        //AF I found this to be a confusing name - what is this variable for?  The card count?  I recommend to rename it
        int intcards;


        public frmMemory()
        {
            InitializeComponent();
            lstcardbuttons = new()
            { btn1, btn2, btn3, btn4, btn5, btn6, btn7, btn8, btn9, btn10,
            btn11, btn12, btn13, btn14, btn15, btn16, btn17, btn18, btn19, btn20 };
            lblGameStatus.Text = "Click Start to begin game";
            intcards = lstcardbuttons.Count();
            btnStart.Click += BtnStart_Click;
            lstcardbuttons.ForEach(b => b.Click += B_Click);
            btnNextTurn.Click += BtnNextTurn_Click;
        }

        private void SetupGame()
        {
            lstcardbuttons.ForEach(b => b.Visible = true);
            List<String> lstpictures = new() { "A", "B", "C", "D", "E", "F", "G", "H", "I", "J",
               "A", "B", "C", "D", "E", "F", "G", "H", "I", "J" };
            int n = lstpictures.Count();
            foreach (Button btn in lstcardbuttons)
            {
                int index = rnd.Next(0, n);
                btn.Text = lstpictures[index];
                lstpictures.Remove(lstpictures[index]);
                n = n - 1;
            }
            currentturn = TurnEnum.Player1;
            lblGameStatus.Text = currentturn.ToString();
            lblScorePlayer1.Text = "Score Player 1 = ";
            lblScorePlayer2.Text = "Score Player 2 = ";
            lblMessage.Text = "";
            btnNextTurn.Text = "Next Turn";
            Score1 = 0;
            Score2 = 0;
        }

        private void B_Click(object? sender, EventArgs e)
        {
            if (GameActive == true)
            {
                Button btn = (Button)sender;
                if (lstcardbuttons.Count(b => b.ForeColor == Color.Black) == 0)
                {
                    button1 = btn;
                }
                else if (lstcardbuttons.Count(b => b.ForeColor == Color.Black) == 1)
                {
                    button2 = btn;
                }
                //why does this not work?
                //btn = lstcardbuttons.Count(b => b.ForeColor == Color.Black) == 0 ? button1 : button2;
                //AF Because that statement is setting the btn variable.  Really you need the reverse though - to set button1 = btn, here you are trying to do btn = button1 (and same for button2)
                if (lstcardbuttons.Count(b => b.ForeColor == Color.Black) == 0 ||
                    lstcardbuttons.Count(b => b.ForeColor == Color.Black) == 1)
                {
                    btn.ForeColor = Color.Black;
                }
                DetectingPoints();
                DetectingWinnerOrTie();
            }
        }

        private void BtnStart_Click(object? sender, EventArgs e)
        {
            GameActive = true;
            SetupGame();
        }
        private bool TurnOver()
        {
            return lstcardbuttons.Count(b => b.ForeColor == Color.Black) == 2 == true;
        }

        private void BtnNextTurn_Click(object? sender, EventArgs e)
        {
            if (TurnOver())
            {
                lstcardbuttons.ForEach(b => b.ForeColor = Color.DodgerBlue);
                currentturn = currentturn == TurnEnum.Player1 ? TurnEnum.Player2 : TurnEnum.Player1;
                lblGameStatus.Text = currentturn.ToString();
                lblMessage.Text = "";
                if (button1.Text == button2.Text)
                {
                    button1.Visible = false;
                    button2.Visible = false;
                }
                if (btnNextTurn.Text == "End Game")
                {
                    lblGameStatus.Text = "Press Start to start new game";
                }
            }
        }

        private void DetectingPoints()
        {
            if (TurnOver())
            {
                lblMessage.Text = button1.Text != button2.Text ? "Nice Try" : "Match!";
                if (lblMessage.Text == "Match!")
                {
                    if (currentturn == TurnEnum.Player1)
                    {
                        Score1 = Score1 + 1;
                        lblScorePlayer1.Text = "Score Player 1 = " + (Score1).ToString();
                    }
                    if (currentturn == TurnEnum.Player2)
                    {
                        Score2 = Score2 + 1;
                        lblScorePlayer2.Text = "Score Player 2 = " + (Score2).ToString();
                    }
                }
            }
        }

        private void DetectingWinnerOrTie()
        {
            if (lstcardbuttons.Count(b => b.Visible == false) == intcards - 2 && (TurnOver()))
            {
                btnNextTurn.Text = "End Game";
                var msg = "";
                if (Score1 == Score2)
                {
                    msg = "Tie Game!";
                }
                else
                {
                    msg = Score1 > Score2 ? TurnEnum.Player1.ToString() + " wins!" : TurnEnum.Player2.ToString() + " wins!";
                }
                lblGameStatus.Text = msg;
            }
        }
    }
}
//do yo think I should add these in? I don't want to complicate things
//display current turn procedure
//display game status procedure
//AF I think you can go eitherway.  It is generally nice to use a procedure when you have repeated code, but you are not repeating
//that code too much, only in a couple places, so it is less of a need but still a good thing
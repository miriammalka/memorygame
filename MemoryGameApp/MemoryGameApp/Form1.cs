using Microsoft.VisualBasic;
using System.Drawing.Text;

namespace MemoryGameApp
{
    public partial class frmMemory : Form
    {
        List<Button> lstcardbuttons;
        bool gameactive = false;
        Random rnd = new();
        private enum TurnEnum { Player1, Player2 }
        TurnEnum currentturn = TurnEnum.Player1;
        private enum GameStatusEnum { NotStarted, Playing, Winner, Tie, GameOver}
        GameStatusEnum gamestatus = GameStatusEnum.NotStarted;
        Button button1;
        Button button2;
        int Score1 = 0;
        int Score2 = 0;
        int totalnumberofcards;


        public frmMemory()
        {
            InitializeComponent();
            lstcardbuttons = new()
            { btn1, btn2, btn3, btn4, btn5, btn6, btn7, btn8, btn9, btn10,
            btn11, btn12, btn13, btn14, btn15, btn16, btn17, btn18, btn19, btn20 };
            gamestatus = GameStatusEnum.NotStarted;
            DisplayGameStatus();
            totalnumberofcards = lstcardbuttons.Count();
            btnStart.Click += BtnStart_Click;
            lstcardbuttons.ForEach(b => b.Click += B_Click);
            btnNextTurn.Click += BtnNextTurn_Click;
        }

        private void SetupGame()
        {
            gamestatus = GameStatusEnum.Playing;
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
            DisplayGameStatus();
            lblScorePlayer1.Text = "Score Player 1 = ";
            lblScorePlayer2.Text = "Score Player 2 = ";
            lblMessage.Text = "";
            btnNextTurn.Text = "Next Turn";
            Score1 = 0;
            Score2 = 0;
        }

        private void B_Click(object? sender, EventArgs e)
        {
            if (gameactive == true)
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
                //mmg is this what you are saying I should do?
                //button1 = lstcardbuttons.Count(b => b.ForeColor == Color.Black) == 0 ? btn : null;
                //button2 = lstcardbuttons.Count(b => b.ForeColor == Color.Black) == 1 ? btn : null;
                //AF No, what you did is fine as is

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
            gameactive = true;
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
                DisplayGameStatus();
                lblMessage.Text = "";
                if (button1.Text == button2.Text)
                {
                    button1.Visible = false;
                    button2.Visible = false;
                }
                if (btnNextTurn.Text == "End Game")
                {
                    gamestatus = GameStatusEnum.GameOver;
                    DisplayGameStatus();
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
            if (lstcardbuttons.Count(b => b.Visible == false) == totalnumberofcards - 2 && (TurnOver()))
            {
                btnNextTurn.Text = "End Game";
                if (Score1 == Score2)
                {
                    gamestatus = GameStatusEnum.Tie;
                    DisplayGameStatus();
                }
                else
                {
                    gamestatus = GameStatusEnum.Winner;
                    DisplayGameStatus();
                }
            }
        }

        //AF this is a nice procedure to have, happy you added this
        private void DisplayGameStatus()
        {
            var msg = "";
            switch (gamestatus)
            {
                case GameStatusEnum.NotStarted:
                    msg = "Click Start to begin game";
                    break;
                case GameStatusEnum.Playing:
                    msg = currentturn.ToString();
                    break;
                case GameStatusEnum.Winner:
                    msg = Score1 > Score2 ? TurnEnum.Player1.ToString() + " wins!" : TurnEnum.Player2.ToString() + " wins!";
                    break;
                case GameStatusEnum.Tie:
                    msg = "Tie!";
                    break;
                case GameStatusEnum.GameOver:
                    msg = "Press Start to start new game";
                    break;
            }
            lblGameStatus.Text = msg;
        }
    }
}

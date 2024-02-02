using Microsoft.VisualBasic;
using System.Drawing.Text;
using MemoryGameSystem;

namespace MemoryGameApp
{
    public partial class frmMemory : Form
    {
        Game game = new();
        List<Button> lstcardbuttons;

        public frmMemory()
        {
            InitializeComponent();
            lstcardbuttons = new()
            { btn1, btn2, btn3, btn4, btn5, btn6, btn7, btn8, btn9, btn10,
            btn11, btn12, btn13, btn14, btn15, btn16, btn17, btn18, btn19, btn20 };
  
            btnStart.Click += BtnStart_Click;
            lstcardbuttons.ForEach(b => { b.Click += B_Click;
                b.DataBindings.Add("Text", game.Cards[lstcardbuttons.IndexOf(b)], "CardValue");
                b.DataBindings.Add("ForeColor", game.Cards[lstcardbuttons.IndexOf(b)], "cardforecolor");
                b.DataBindings.Add("BackColor", game.Cards[lstcardbuttons.IndexOf(b)], "cardbackcolor");
            }) ;
            btnNextTurn.Click += BtnNextTurn_Click;
            lblGameStatus.DataBindings.Add("Text", game, "GameStatusDescription");
            lblMessage.DataBindings.Add("Text", game, "TurnMessageDescription");
            lblScorePlayer1.DataBindings.Add("Text", game, "Score1Description");
            lblScorePlayer2.DataBindings.Add("Text", game, "Score2Description");
        }

        private void DoTurn(Button btn)
        {
            int n = lstcardbuttons.IndexOf(btn);
            game.TakeTurn(n);
        }

        private void B_Click(object? sender, EventArgs e)
        {
            if (sender is Button)
            {
                DoTurn((Button)sender);
            }
            
        }

        private void BtnStart_Click(object? sender, EventArgs e)
        {
            game.StartGame();
        }

        private void BtnNextTurn_Click(object? sender, EventArgs e)
        {
            game.NextTurn();           
        }
    }
}

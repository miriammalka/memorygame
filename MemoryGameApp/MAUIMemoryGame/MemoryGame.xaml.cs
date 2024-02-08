using MemoryGameSystem;
namespace MAUIMemoryGame;

public partial class MemoryGame : ContentPage
{
    Game activegame;
    List<Game> lstgame = new() { new Game(), new Game(), new Game() };
    List<Button> lstcardbuttons;
	public MemoryGame()
	{
		InitializeComponent();
        lstgame.ForEach(g => g.ScoreChanged += G_ScoreChanged);
        Game1Rb.BindingContext = lstgame[0];
        Game2Rb.BindingContext = lstgame[1];
        Game3Rb.BindingContext = lstgame[2];
        activegame = lstgame[0];
        this.BindingContext = activegame;
        lstcardbuttons = new() { Btn1, Btn2, Btn3, Btn4, Btn5, Btn6, Btn7, Btn8, Btn9, Btn10, Btn11, Btn12, Btn13, Btn14, Btn15, Btn16, Btn17, Btn18, Btn19, Btn20 };
    }

    private void G_ScoreChanged(object sender, EventArgs e)
    {
        ScoreLbl.Text = Game.TotalScore;
    }

    private void StartBtn_Clicked(object sender, EventArgs e)
    {
        if(activegame.GameStatus == Game.GameStatusEnum.NotStarted)
        {
            activegame.StartGame();
        }
        else
        {
            activegame.StopGame();
        }
    }


    private void Btn_Clicked(object sender, EventArgs e)
    {
        activegame.TakeTurn(lstcardbuttons.IndexOf((Button)sender));
    }


    private void NextTurnBtn_Clicked(object sender, EventArgs e)
    {
        activegame.NextTurn();
    }

    private void Game_CheckedChanged(object sender, CheckedChangedEventArgs e)
    {
        RadioButton rb = (RadioButton)sender;
        if(rb.IsChecked && rb.BindingContext != null)
        {
            activegame = (Game)rb.BindingContext;
            this.BindingContext = activegame;
        }
    }
}
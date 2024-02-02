using MemoryGameSystem;
namespace MAUIMemoryGame;

public partial class MemoryGame : ContentPage
{
    Game game = new();
    List<Button> lstcardbuttons;
	public MemoryGame()
	{
		InitializeComponent();
        this.BindingContext = game;
        lstcardbuttons = new() { Btn1, Btn2, Btn3, Btn4, Btn5, Btn6, Btn7, Btn8, Btn9, Btn10, Btn11, Btn12, Btn13, Btn14, Btn15, Btn16, Btn17, Btn18, Btn19, Btn20 };
	}

    private void StartBtn_Clicked(object sender, EventArgs e)
    {
        game.StartGame();
    }

    private void Btn_Clicked(object sender, EventArgs e)
    {
        game.TakeTurn(lstcardbuttons.IndexOf((Button)sender));
    }


    private void NextTurnBtn_Clicked(object sender, EventArgs e)
    {
        game.NextTurn();
    }
}
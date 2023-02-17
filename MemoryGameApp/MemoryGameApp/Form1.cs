namespace MemoryGameApp
{
    public partial class frmMemory : Form
    {
        List<Button> lstcardbuttons;
        bool GameActive = false;
        Random rnd = new();
        public frmMemory()
        {
            InitializeComponent();
            lstcardbuttons = new()
            { btn1, btn2, btn3, btn4, btn5, btn6, btn7, btn8, btn9, btn10,
            btn11, btn12, btn13, btn14, btn15, btn16, btn17, btn18, btn19, btn20 };
            lblGameStatus.Text = "Click Start to begin game";

            SetupGame();
            btnStart.Click += BtnStart_Click;
            


            

            lstcardbuttons.ForEach(b => b.Click += B_Click);
        }

        private void SetupGame()
        {
            lstcardbuttons.ForEach(b => b.ForeColor = Color.DodgerBlue);
            List<String> lstpictures = new() { "A", "B", "C", "D", "E", "F", "G", "H", "I", "J",
               "A", "B", "C", "D", "E", "F", "G", "H", "I", "J" };
            int n = lstpictures.Count();
            foreach(Button btn in lstcardbuttons)
            {
                int index = rnd.Next(0, n);                
                btn.Text = lstpictures[index];
                lstpictures.Remove(lstpictures[index]);                
                n = n - 1;
            }
        }

        private void DetectingTurn()
        {
            lblGameStatus.Text = "Player 1 Turn";
            if(lstcardbuttons.Count(b => b.ForeColor == Color.Black) == 3 && lblGameStatus.Text == "Player 1 Turn")
            {
                lblGameStatus.Text = "Player 2 turn";
                lstcardbuttons.Where(b => b.ForeColor == Color.Black).ToList().ForEach(b => b.ForeColor = Color.DodgerBlue);

            }
            if (lstcardbuttons.Count(b => b.ForeColor == Color.Black) == 3 && lblGameStatus.Text == "Player 2 Turn")
            {
                lblGameStatus.Text = "Player 1 turn";
                lstcardbuttons.Where(b => b.ForeColor == Color.Black).ToList().ForEach(b => b.ForeColor = Color.DodgerBlue);
            }
        }
        private void B_Click(object? sender, EventArgs e)
        {
            if (GameActive == true)
            {
                Button btn = (Button)sender;
                btn.ForeColor = Color.Black;
                DetectingTurn();

            }
                        
        }
        //need to switch turns
        //delete text on buttons
        //why does button5 not work

        private void BtnStart_Click(object? sender, EventArgs e)
        {
            lblGameStatus.Text = "Player 1 Turn";
            GameActive = true;
            lstcardbuttons.ForEach(b => b.ForeColor = Color.DodgerBlue);
        }
    }
}
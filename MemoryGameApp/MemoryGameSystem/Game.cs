using System.ComponentModel;
using System.Runtime.CompilerServices;
using System.Security.Cryptography.X509Certificates;
using static System.Formats.Asn1.AsnWriter;

namespace MemoryGameSystem
{
    public class Game : INotifyPropertyChanged
    {
        //I think I wrote all the backend code for HW 37, now need to implement it to front end
        public event PropertyChangedEventHandler? PropertyChanged;
        public event EventHandler? ScoreChanged;
        
        GameStatusEnum _gamestatus = GameStatusEnum.NotStarted;
        TurnEnum _currentturn = TurnEnum.None;
        int _score1 = 0;
        int _score2 = 0;
        TurnMessageEnum _turnmessageenum = TurnMessageEnum.None;
        public bool gameenabled { get; set; } = false;
        
        private static int score1wins;
        private static int score2wins;
        private static int scoreties;
        private static int numgames;

        public static string TotalScore { get => $"Player 1 wins = {score1wins}, Player 2 wins = {score2wins}, Tie = {scoreties}"; }

        public string GameName { get; private set; }

        public List<Card> Cards { get; private set; } = new();
        public enum GameStatusEnum { NotStarted, Playing, Winner, Tie }

        public GameStatusEnum GameStatus { 
            get => _gamestatus; 
            private set
            {
                _gamestatus = value;
                this.InvokePropertyChanged();
                this.InvokePropertyChanged("GameStatusDescription");
                this.InvokePropertyChanged("StartButtonText");
            }
        }

        public string GameStatusDescription
        {
            get
            {
                string s = $"{this.GameName}, {GameStatus}";
                string winner = Score1 > Score2 ? TurnEnum.Player1.ToString() : TurnEnum.Player2.ToString();
                switch (this.GameStatus)
                {
                    case GameStatusEnum.NotStarted:
                        s = s + " Click Start";
                        break;
                    case GameStatusEnum.Playing:
                        s = s + $" : Current Turn: {CurrentTurn}";
                        break;
                    case GameStatusEnum.Winner:
                        s = s + " : " + winner + "! Game Over.";
                        break;
                    case GameStatusEnum.Tie:
                        s = s;
                        break;
                }
                return s;
            }
        }

        public string StartButtonText
        {
            
            get
            {
                string s = "";
                switch (this.GameStatus)
                {
                    case GameStatusEnum.NotStarted:
                        s = s + "Start ";
                        break;
                    case GameStatusEnum.Playing:
                    case GameStatusEnum.Winner:
                    case GameStatusEnum.Tie:
                        s = "Stop ";
                        break;
                }
                s = s + this.GameName;
                return s;
            }
        }
        public string Score1Description { get => $"Score Player 1 = {this.Score1}"; }
        public string Score2Description { get => $"Score Player 2 = {this.Score2}"; }

        public static string Score { get => $"Player1 wins = {score1wins}: Player2 wins = {score2wins}: Ties = {scoreties}"; }
        public enum TurnEnum { None, Player1, Player2 }

        public TurnEnum CurrentTurn { 
            get => _currentturn;
            private set 
            {
                _currentturn = value;
                this.InvokePropertyChanged();
                this.InvokePropertyChanged("GameStatusDescription");
            } 
        }
        public string PlayerDescription { get => this.CurrentTurn == TurnEnum.None ? "" : this.CurrentTurn.ToString(); }
        public string TurnMessageDescription { get => this.turnmessage == TurnMessageEnum.None ? "" : this.turnmessage.ToString(); }
        public bool turnover  { get => Cards.Count(b => b.cardforecolor == this.CardTurnColor) == 2; }

        public int Score1 { 
            get => _score1;
            set 
            {
                _score1 = value;
                this.InvokePropertyChanged();
                this.InvokePropertyChanged("Score1Description");
            }
        }

        public int Score2
        {
            get => _score2;
            set
            {
                _score2 = value;
                this.InvokePropertyChanged();
                this.InvokePropertyChanged("Score2Description");
            }
        }

        public enum TurnMessageEnum { None, Match, NiceTry}

        public TurnMessageEnum turnmessage { 
            get => _turnmessageenum;
            set 
            {
                _turnmessageenum = value;
                this.InvokePropertyChanged();
                this.InvokePropertyChanged("TurnMessageDescription");
            }
        }
        public List<string> lstpictures = new();
        public Random rnd = new();
        public Card Card1 { get; set; }
        public Card Card2 { get; set; }

        public System.Drawing.Color CardTurnColor { get; set; } = System.Drawing.Color.Black;
        public System.Drawing.Color CardTurnOverColor { get; set; } = System.Drawing.Color.DodgerBlue;
        public System.Drawing.Color CardMatchColor { get; set; } = System.Drawing.Color.Red;
        public System.Drawing.Color CardBackColor { get; set; } = System.Drawing.Color.DodgerBlue;


        public Game()
        {            
            numgames++;
            this.GameName = "Game " + numgames;
            for (int i = 0; i < 20; i++)
            {
                this.Cards.Add(new Card());
            }
            this.CurrentTurn = TurnEnum.None;
            this.turnmessage = TurnMessageEnum.None;
        }

        public void SetupGame()
        {
            lstpictures = new() { "A", "B", "C", "D", "E", "F", "G", "H", "I", "J",
               "A", "B", "C", "D", "E", "F", "G", "H", "I", "J" };
            int n = lstpictures.Count();
            foreach (Card c in Cards)
            {
                ClearCards();
                int index = rnd.Next(0, n);
                c.CardValue = lstpictures[index];
                lstpictures.Remove(lstpictures[index]);
                n = n - 1;
                c.cardenabled = true;
                c.cardbackcolor = CardBackColor;
            }
            this.gameenabled = true;
            this.Score1 = 0;
            this.Score2 = 0;
    }

        public void StartGame()
        {
            this.GameStatus = GameStatusEnum.Playing;          
            this.CurrentTurn = TurnEnum.Player1;
            SetupGame();
        }

        public void StopGame()
        {
            this.GameStatus = GameStatusEnum.NotStarted;
            this.gameenabled = false;
            this.Score1 = 0;
            this.Score2 = 0;
            ClearCards();
        }

        private void ClearCards()
        {
            Cards.ForEach(c => c.cardforecolor = CardBackColor);
        }

        //pass in cardnum
        public void TakeTurn(int cardnum)
        {
            Card card = this.Cards[cardnum];
            if (card.cardenabled && this.gameenabled)
            {                
                if (Cards.Count(b => b.cardforecolor == this.CardTurnColor) == 0)
                {
                    Card1 = card;
                }
                else if (Cards.Count(b => b.cardforecolor == CardTurnColor) == 1)
                {
                    Card2 = card;
                }

                if (Cards.Count(b => b.cardforecolor == this.CardTurnColor) == 0 ||
                    Cards.Count(b => b.cardforecolor == this.CardTurnColor) == 1)
                {
                    card.cardforecolor = this.CardTurnColor;
                }

                DetectPoints();
                DetectWinnerOrTie();
            }

        }
    
        public void NextTurn()
        {
            if (this.turnover && this.gameenabled)
            {
                this.turnmessage = TurnMessageEnum.None;
                
                this.CurrentTurn = CurrentTurn == TurnEnum.Player1 ? TurnEnum.Player2 : TurnEnum.Player1;   
               
                if (Card1.CardValue == Card2.CardValue)
                {
                    Card1.cardforecolor = CardMatchColor;
                    Card2.cardforecolor = CardMatchColor;
                    Card1.cardenabled = false;
                    Card2.cardenabled = false;                   
                }
                else
                {
                    Card1.cardforecolor = CardTurnOverColor;
                    Card2.cardforecolor = CardTurnOverColor;
                }
            }
        }

        private void DetectPoints()
        {
            if (turnover)
            {
                this.turnmessage = Card1.CardValue != Card2.CardValue ? TurnMessageEnum.NiceTry : TurnMessageEnum.Match;
                if (this.turnmessage == TurnMessageEnum.Match)
                {
                    if (this.CurrentTurn == TurnEnum.Player1)
                    {
                        this.Score1 = Score1 + 1;
                    }
                    if (this.CurrentTurn == TurnEnum.Player2)
                    {
                        this.Score2 = Score2 + 1;                      
                    }
                }
            }
        }

        private void DetectWinnerOrTie()
        {
            if (Score1 + Score2 == 10)
            {
                Cards.ForEach(c => c.cardforecolor = CardMatchColor);
                this.gameenabled = false;
                if (Score1 == Score2)
                {
                    scoreties++;
                    GameStatus = GameStatusEnum.Tie;
                    
                }
                else
                {
                    GameStatus = GameStatusEnum.Winner;
                    if(Score1 > Score2)
                    {
                        score1wins++;
                        
                    }
                    if (Score2 > Score1)
                    {
                        score2wins++;
                        
                    }
                }
                ScoreChanged?.Invoke(this, new EventArgs());
            }
        }

        private void InvokePropertyChanged([CallerMemberName] string propertyname = "")
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyname));
        }
    }
}

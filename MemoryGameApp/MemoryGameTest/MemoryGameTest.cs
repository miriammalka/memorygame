using MemoryGameSystem;
using Microsoft.VisualBasic;
using System.Collections.Concurrent;

namespace MemoryGameTest
{


    public class Tests
    {
        Game game = new();
        Card card = new();
        Card c1 = new();
        Card c2 = new();
        int n = 0;
        int m = 0;
        List<Card> lst = new();

        [SetUp]
        public void Setup()
        {

        }

        [Test]
        public void TestStartGame()
        {
            Game game = new();
            game.StartGame();
            string msg = $"Game Status = {game.GameStatus} Current Turn = {game.CurrentTurn} Num Cards = {game.Cards.Count} Player1 Score = {game.Score1} Player2 Score = {game.Score2}";
            //I also want to assert that they each have a picture
            Assert.IsTrue(game.GameStatus == Game.GameStatusEnum.Playing && game.CurrentTurn == Game.TurnEnum.Player1 && game.Cards.Count == 20 && game.Score1 == 0 && game.Score2 == 0, msg);
            TestContext.WriteLine(msg);
        }

        [Test]
        public void TestTakeTurn()
        {
            Game game = new();
            game.StartGame();
            game.TakeTurn(0);
            game.TakeTurn(1);
            string msg = $"Turn = {game.CurrentTurn} Card 0 Forecolor = {game.Cards[0].cardforecolor} Card 1 Forecolor = {game.Cards[1].cardforecolor} Turn Message = {game.TurnMessageDescription} Turn Over = {game.turnover}";
            Assert.IsTrue(game.CurrentTurn == Game.TurnEnum.Player1 && game.Cards[0].cardforecolor == game.CardTurnColor && game.Cards[1].cardforecolor == game.CardTurnColor && game.turnmessage != Game.TurnMessageEnum.None && game.turnover == true, msg);
            TestContext.WriteLine(msg);
        }

        [Test]
        public void TestNextTurn()
        {
            Game game = new();
            game.StartGame();
            game.TakeTurn(0);
            game.TakeTurn(1);
            game.NextTurn();
            string msg = $"Current Turn = {game.CurrentTurn} TurnMessage = {game.turnmessage}";
            Assert.IsTrue(game.CurrentTurn == Game.TurnEnum.Player2 && game.turnmessage == Game.TurnMessageEnum.None, msg);
            TestContext.WriteLine(msg);
        }

        private void TakeTurnMatch()
        {
            card = game.Cards.FirstOrDefault(c => c.cardenabled);

            lst = game.Cards.Where(c => c.CardValue == card.CardValue).ToList();

            c1 = lst[0];
            n = game.Cards.IndexOf(c1);
            game.TakeTurn(n);

            c2 = lst[1];
            m = game.Cards.IndexOf(c2);
            game.TakeTurn(m);
        }

        private void TakeTurnNotMatch()
        {
            c1 = game.Cards.FirstOrDefault(c => c.cardenabled);
            n = game.Cards.IndexOf(c1);
            game.TakeTurn(n);

            c2 = game.Cards.FirstOrDefault(c => c.CardValue != c1.CardValue && c.cardenabled);
            m = game.Cards.IndexOf(c2);
            game.TakeTurn(m);
        }

        [Test]
        public void TestMatch()
        {
            game.StartGame();

            TakeTurnMatch();

            string msg = $"Current Turn: {game.CurrentTurn} Score 1: {game.Score1} Turn Message: {game.turnmessage}";
            Assert.IsTrue(game.CurrentTurn == Game.TurnEnum.Player1 && game.Score1 == 1 && game.turnmessage == Game.TurnMessageEnum.Match, msg);
            TestContext.WriteLine(msg);
        }

        [Test]
        public void TestWinner()
        {
            game.StartGame();

            for (int i = 0; i < 7; i++)
            {
                TakeTurnMatch();
                game.NextTurn();
            }
            //score1 = 4
            //score2 = 3

            //score2 = 3
            TakeTurnNotMatch();
            game.NextTurn();

            //Score1 = 5
            TakeTurnMatch();
            game.NextTurn();

            //Score2 = 3
            TakeTurnNotMatch();
            game.NextTurn();

            //Score1 = 6
            TakeTurnMatch();
            game.NextTurn();

            //score2 = 4
            TakeTurnMatch();

            string msg = $"Game Status: {game.GameStatus} Current Turn: {game.CurrentTurn} Score 1: {game.Score1} Score 2: {game.Score2} Turn Message: {game.turnmessage}";
            Assert.IsTrue(game.GameStatus == Game.GameStatusEnum.Winner && game.CurrentTurn == Game.TurnEnum.Player2 && game.Score1 == 6 && game.Score2 == 4 && game.turnmessage == Game.TurnMessageEnum.Match, msg);
            TestContext.WriteLine(msg);
        }

        [Test]
        public void TestTie()
        {
            game.StartGame();

            for (int i = 0; i < 10; i++)
            {
                TakeTurnMatch();

                game.NextTurn();
            }

            string msg = $"Game Status: {game.GameStatus} Current Turn: {game.CurrentTurn} Score 1: {game.Score1} Score 2: {game.Score2} Turn Message: {game.turnmessage}";
            Assert.IsTrue(game.GameStatus == Game.GameStatusEnum.Tie && game.CurrentTurn == Game.TurnEnum.Player2 && game.Score1 == 5 && game.Score2 == 5 && game.turnmessage == Game.TurnMessageEnum.Match, msg);
            TestContext.WriteLine(msg);
        }
    }
}
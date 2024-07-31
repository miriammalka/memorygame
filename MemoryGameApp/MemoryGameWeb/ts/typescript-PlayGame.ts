namespace TypespcriptMemoryGame {
    let scoreDisplay1: Element = document.querySelector("#scoreplayer1");
    let scoreDisplay2: Element = document.querySelector("#scoreplayer2");
    const player1 = { name: "Player 1", score: 0, scoreDisplay: scoreDisplay1 };
    const player2 = { name: "Player 2", score: 0, scoreDisplay: scoreDisplay2 };
    let currentPlayer = player1;
    let gameover = false;
    let lstpictures = [];
    let clickedCards: HTMLButtonElement[] = [];
    let messageDisplay: Element = document.querySelector("#messageDisplay");
    let currentPlayerDisplay: Element = document.querySelector("#currentPlayerDisplay");
    const memorycards = ([...document.querySelectorAll(".memory-card")] as HTMLButtonElement[]);
    const btnStart: HTMLButtonElement = document.querySelector("#btnStart");
    const btnNextTurn: HTMLButtonElement = document.querySelector("#btnNextTurn");
    const table = document.querySelector("table");
    let match = {};


    document.querySelector("#btnStart").addEventListener("click", startGame);
    document.querySelector("#btnNextTurn").addEventListener("click", nextTurn);
    memorycards.forEach(c => c.addEventListener("click", cardClicked));




    function startGame() {
        gameover = false;
        currentPlayer = player1;
        setUpGame();
        displayCurrentPlayer();
        startButtonText();
    }

    function setUpGame() {
        clearCards();
        lstpictures = ["A", "B", "C", "D", "E", "F", "G", "H", "I", "J",
            "A", "B", "C", "D", "E", "F", "G", "H", "I", "J"];
        let n = lstpictures.length;
        for (let m of memorycards) {

            let index = Math.floor(Math.random() * n);
            m.textContent = lstpictures[index];
            lstpictures.splice(index, 1);
            n = n - 1;
        }
        memorycards.forEach(m => m.style.color = "deeppink");
        scoreDisplay1.textContent = "";
        scoreDisplay2.textContent = "";
        messageDisplay.textContent = "";
        toggleTableEvents();
        memorycards.forEach(m => m.disabled = false);
        memorycards.forEach(m => m.style.pointerEvents = "all");
        btnNextTurn.disabled = true;
        clickedCards.length = 0;
        player1.score = 0;
        player2.score = 0;
    }

    function startButtonText() {
        btnStart.textContent = gameover == false ? "Restart Game" : "Click to Start New Game";
    }

    function displayCurrentPlayer() {
        currentPlayerDisplay.textContent = currentPlayer.name;
    }

    function displayGameMessage() {
        if (gameover == false) {
            if (clickedCards.length == 2) {
                messageDisplay.textContent = match ?
                    "Match!" : "No Match";
            }
            else {
                messageDisplay.textContent = "";
            }
        }
        if (gameover) {
            if (player1.score == player2.score) {
                messageDisplay.textContent = "Tie!";
            }
            else {
                messageDisplay.textContent = player1.score > player2.score ? "Winner is: " + player1.name : "Winner is: " + player2.name;

            }
        }
    }

    function toggleTableEvents() {
        //MME look into this
        table.style.pointerEvents = "none" ? "all" : "none";
        // table.style.pointerEvents == "none" ? 
        //     table.style.pointerEvents = "all" : 
        //     table.style.pointerEvents = "none";
    }

    function toggleButtonEvents() {
        // btnNextTurn.disabled == true ? btnNextTurn.disabled = false : btnNextTurn.disabled = true;
        btnNextTurn.disabled = !btnNextTurn.disabled;
        console.log("button next turn disabled = ", btnNextTurn.disabled);
    }

    function cardClicked(event: Event) {
        const btn = event.target as HTMLButtonElement;
        doTurn(btn);
    }

    function doTurn(btn: HTMLButtonElement) {
        clickedCards.push(btn);
        btn.style.pointerEvents = "none";
        console.log(clickedCards.length);
        btn.style.color = "black";
        if (clickedCards.length == 2) {
            toggleTableEvents();
            toggleButtonEvents();
            memorycards.forEach(m => m.style.pointerEvents = "none");
            //btnNextTurn.disabled = false;
            //determine if both cards clicked match
            match = clickedCards[0].textContent == clickedCards[1].textContent;
            console.log(match);
            if (match) {
                //increment score of curent turn if match
                currentPlayer.score += 1;
                console.log(currentPlayer.score);
                currentPlayer.scoreDisplay.textContent = currentPlayer.score.toString();
                //tell player outcome of turn
            }
            displayGameMessage();
            detectWinnerOrTie();
        }
    }

    function nextTurn() {
        toggleButtonEvents();
        memorycards.forEach(m => m.style.pointerEvents = "all");
        if (match) {
            //if match, remove cards    
            clickedCards.forEach(c => c.disabled = true);
        }
        else {
            //turn over cards if no match
            clickedCards.forEach(c => c.style.color = "deeppink");
        }
        toggleTableEvents();
        //empty clickedCards
        clickedCards.length = 0;
        console.log("clicked cards length", clickedCards.length);
        //switch turn
        currentPlayer = currentPlayer == player1 ? player2 : player1;
        displayCurrentPlayer();
        displayGameMessage();
    }

    function detectWinnerOrTie() {
        if (player1.score + player2.score == 10) {
            clickedCards.forEach(c => c.disabled = true);
            gameover = true;
            //disable next turn button
            toggleButtonEvents();
            startButtonText();
            displayGameMessage();
        }
    }

    function clearCards() {
        memorycards.forEach(m => m.textContent = "");
    }
}
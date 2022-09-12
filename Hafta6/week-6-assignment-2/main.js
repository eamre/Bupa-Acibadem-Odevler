const blocks = document.querySelectorAll(".box");
const playerText = document.getElementById("player");
const errorText = document.getElementById("error");
const winningMessageElement = document.getElementById('winningMessage')
const restartButton = document.getElementById('restart')
const winningMessageTextElement = document.querySelector('[data-winning-message-text]')
//const resetButton = document.querySelector('#reset');

function message(){
    winningMessageElement.classList.add('show');
}

let player = "X";
let gameOver = false;

const winningConditions = [
    [0, 1, 2],[3, 4, 5],[6, 7, 8],
    [0, 3, 6],[1, 4, 7],[2, 5, 8],
    [0, 4, 8],[2, 4, 6]
];

function startGame() {
    playerText.textContent = `${player}'s Turn!`;
    winningMessageElement.classList.remove('show');
    blocks.forEach(block => block.addEventListener("click", () => chooseArea(block)));
}

function chooseArea(block) {

    if (block.textContent === "") {
        block.textContent = player;
        if (player === "O") {
            block.style.color = "orange";
        }
        else if (player === "X") {
            block.style.color = "#025EFA";
        }
        turnPlayer();

    } else {
        errorText.textContent = "Box it's not empty"
        errorText.style.margin="10px"
        block.style.border = "2px solid red"
        setTimeout(() => {
            errorText.textContent = ""
            block.style.border = "1px solid white"
        }, 2000)
    }

    checkGame();

    if (gameOver) {
        player ==='X'? player='O':player='X';
        blocks.forEach(block => block.style.pointerEvents = 'none');
        playerText.textContent = " ";
        winningMessageTextElement.innerText=`Game Over, ${player} Won`;
        setInterval(message,180);
    }
}

function checkGame(){

    const valuess = [];
    blocks.forEach(block => valuess.push(block.textContent));
    for (let i = 0; i <= 7; i++) {
        const winCondition = winningConditions[i];
        let a = valuess[winCondition[0]];
        let b = valuess[winCondition[1]];
        let c = valuess[winCondition[2]];
        console.log(b);
        if (a === '' || b === '' || c === '') {
            continue;
        }
        if (a === b && b === c) {
            gameOver = true;
            break;
        }
    }

    if (!valuess.includes("")) {

        playerText.textContent = "Tie!";
        blocks.forEach(block => block.style.pointerEvents = 'none');
        winningMessageTextElement.innerText=`Game Over, Tie!`;
        setInterval(message,350);
    }
}  

function turnPlayer() {
    if (player === "X") {
        player = "O";
        playerText.textContent = `${player}'s Turn!`
        return;
    } else if (player === "O") {
        player = "X";
        playerText.textContent = `${player}'s Turn!`
    }
}

startGame();

const resetBoard = () => {
    blocks.forEach(block => block.textContent = "");
    window.location.assign("index.html")
    //startGame();
}

 restartButton.addEventListener('click', resetBoard);
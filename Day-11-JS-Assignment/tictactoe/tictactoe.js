let board = ["","","","","","","","",""]
let currentPlayer = "X"
let gameActive = true

const statusText = document.getElementById("status")
const boardDiv = document.getElementById("board")

const winPatterns = [
    [0,1,2],[3,4,5],[6,7,8],
    [0,3,6],[1,4,7],[2,5,8],
    [0,4,8],[2,4,6]
]

function createBoard(){
    boardDiv.innerHTML=""
    board.forEach((val,i)=>{
        let cell=document.createElement("div")
        cell.className="cell"
        cell.textContent=val
        cell.onclick=()=>handleClick(i)
        boardDiv.appendChild(cell)
    })
}

function handleClick(index){
    if(board[index]!=="" || !gameActive) return
    board[index]=currentPlayer
    checkResult()
    currentPlayer=currentPlayer==="X"?"O":"X"
    if(gameActive) statusText.textContent=`Player ${currentPlayer} turn`
    createBoard()
}

function checkResult(){
    for(let p of winPatterns){
        let [a,b,c]=p
        if(board[a] && board[a]===board[b] && board[a]===board[c]){
            statusText.textContent=`Player ${board[a]} wins`
            gameActive=false
            return
        }
    }
    if(!board.includes("")){
        statusText.textContent="Match Draw"
        gameActive=false
    }
}

function resetGame(){
    board=["","","","","","","","",""]
    currentPlayer="X"
    gameActive=true
    statusText.textContent="Player X turn"
    createBoard()
}

createBoard()
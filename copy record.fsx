open System

type Game ={
    Name : string
    Year : int
    Platforms : string list
}

let myGame={Name="sam"; Year = 2; Platforms=["samplat"]}
let newGame={ myGame with Platforms="new one"::myGame.Platforms}
let someOthergame={newGame with Year=100;  Name="jksdbj"}


myGame,newGame,someOthergame

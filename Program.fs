﻿// For more information see https://aka.ms/fsharp-console-apps
type Genre =
    | Horror
    | Drama
    | Thriller
    | Comedy
    | Fantasy
    | Sport

type Dir = {
    Name: string
    Mov: int 
}

type Mov = {
    Name: string
    RunLgth: int
    Genre: Genre
    Dir: Dir
    IMDB: float
}

let mov = [
    { Name = "CODA"; RunLgth = 111; Genre = Drama; Dir = { Name = "Sian Heder"; Mov = 9 }; IMDB = 8.1 }
    { Name = "Belfast"; RunLgth = 98; Genre = Comedy; Dir = { Name = "Kenneth Branagh"; Mov = 23 }; IMDB = 7.3 }
    { Name = "Don't Look Up"; RunLgth = 138; Genre = Comedy; Dir = { Name = "Adam McKay"; Mov = 27 }; IMDB = 7.2 }
    { Name = "Drive My Car"; RunLgth = 179; Genre = Drama; Dir = { Name = "Ryusuke Hamaguchi"; Mov = 16 }; IMDB = 7.6 }
    { Name = "Dune"; RunLgth = 155; Genre = Fantasy; Dir = { Name = "Denis Villeneuve"; Mov = 24 }; IMDB = 8.1 }
    { Name = "King Richard"; RunLgth = 144; Genre = Sport; Dir = { Name = "Reinaldo Marcus Green"; Mov = 15 }; IMDB = 7.5 }
    { Name = "Licorice Pizza"; RunLgth = 133; Genre = Comedy; Dir = { Name = "Paul Thomas Anderson"; Mov = 49 }; IMDB = 7.4 }
    { Name = "Nightmare Alley"; RunLgth = 150; Genre = Thriller; Dir = { Name = "Guillermo Del Toro"; Mov = 22 }; IMDB = 7.1 }
]

let oscarWinrs = mov |> List.filter (fun mov -> mov.IMDB > 7.4)
printfn "Probable Oscar Winrs: %A" oscarWinrs


let convertRunLgth (minutes: int) =
    let hours = minutes / 60
    let remainingMinutes = minutes % 60
    sprintf "%dh %02dmin" hours remainingMinutes

let runLgthsInHours = mov |> List.map (fun mov -> convertRunLgth mov.RunLgth)
printfn "Mov Run Lgths in Hours: %A" runLgthsInHours

// For more information see https://aka.ms/fsharp-console-apps
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



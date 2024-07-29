Design Tic Tac Toe game - For two player as of now but can be extended to multiple players

Entities : 
    Board
    Piece -> X , O
    Player
    Game

Piece can have multiple type -> PieceX and PieceO => Realization -> Inheritance

Board has a Piece -> Composition

Player has a Piece -> Composition

Game has a Board and has a Player -> Composition and it uses for initialization and start game.
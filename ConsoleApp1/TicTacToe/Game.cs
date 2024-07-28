public class Game
{
    Board board;
    Queue<Player> players;

    public Game()
    {
        InitializeBoard();
    }

    private void InitializeBoard()
    {
        board = new Board(3);

        players = new Queue<Player>();

        // add player
        Piece pieceX = new PieceX();
        Player p1 = new Player("Viren", pieceX);

        Piece pieceO = new PieceO();
        Player p2 = new Player("Akshay", pieceO);

        players.Enqueue(p1);
        players.Enqueue(p2);
    }

    public string StartGame()
    {
        bool noWinner = true;

        while(noWinner)
        {
            // get player
            Player player = players.Dequeue();

            // get free space
            List<Pair> freeSpaces = board.GetFreeCells();

            if(freeSpaces.Count == 0) return "tie";

            Console.WriteLine("Enter row and col by comma saperated");

            var input = Console.ReadLine();

            var s = input.Split(',');
            int row = Convert.ToInt32(s[0]);
            int col = Convert.ToInt32(s[1]);

            // add row and col
            board.AddPiece(row, col, player.piece);

            // TODO : handle no space scenario and add at front 

            players.Enqueue(player);

            // check winner 
            bool winner = FindWinner(row, col, player.piece.pieceType);

            if(winner)
            {
                return player.name;
            }
        }
        return "tie";
    }

    private bool FindWinner(int row, int col, PieceType pieceType)
    {
        // Write Algo to find the winner
        // check row, col, diagonal and anti diagonal
        return true;

    }
}
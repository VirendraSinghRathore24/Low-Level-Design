public class Player
{
    public string name;
    public Piece piece;

    public Player(string name, Piece piece)
    {
        this.name = name;
        this.piece = piece;
    }

    public void SetPlayerName(string name)
    {
        this.name = name;
    }

    public string GetPlayerName()
    {
        return name;
    }

    public void SetPiece(Piece piece)
    {
        this.piece = piece;
    }

    public Piece GetPiece()
    {
        return piece;
    }
}
public abstract class Piece1
{
    PieceType1 pieceType;
    bool isWhite;
    bool killed;
    public Piece1(PieceType1 pieceType, bool isWhite)
    {
        this.pieceType = pieceType;
        this.isWhite = isWhite;
    }

    public bool isKilled()
    {
        return killed;
    }

    public void SetKilled(bool killed)
    {
        this.killed = killed;
    }

    public abstract bool CanMove();
    
}
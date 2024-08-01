public class Block
{
    int x;
    int y;
    Piece1 piece;

    public Block(int x, int y, Piece1 piece)
    {
        this.x = x;
        this.y = y;
        this.piece = piece;
    }

    public Piece1 GetPiece()
    {
        return piece;
    }

    public void SetPiece(Piece1 piece)
    {
        this.piece = piece;
    }
}
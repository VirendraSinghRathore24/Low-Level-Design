public class KingPiece : Piece1
{
    public KingPiece(bool isWhite) : base(PieceType1.KING, isWhite)
    {

    }

    public override bool CanMove()
    {   
        // logic for king to be moved

        return false;
    }
}
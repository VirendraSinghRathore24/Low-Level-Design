public class Board
{
    public int size;
    Piece[,] pieces;

    public Board(int size)
    {
        this.size = size;
        pieces = new Piece[size, size];
    }

    public bool AddPiece(int row, int col, Piece piece)
    {
        if(pieces[row,col] != null)
        {
            return false;
        }

        pieces[row,col] = piece;
        return true;
    }

    public List<Pair> GetFreeCells()
    {
        List<Pair> result = new List<Pair>();

        for(int i = 0; i < size; i++)
        {
            for(int j = 0; j < size; j++)
            {
                if(pieces[i,j] == null)
                {
                    result.Add(new Pair(i, j));
                }
            }
        }

        return result;
    }
}

public class Pair 
{
    public int row;
    public int col;

    public Pair(int row, int col)
    {
        this.row = row;
        this.col = col;
    }
}
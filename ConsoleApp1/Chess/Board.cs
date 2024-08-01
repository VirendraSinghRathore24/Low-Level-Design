public class Board2
{
    private Block[,] blocks;

    public Board2() {
        initializeBoard();
    }

    private void initializeBoard()
    {
        blocks = new Block[8,8];

        // Setting White Pieces

        blocks[0,0] = new Block(0, 0, new KingPiece(true));
        blocks[0,1] = new Block(0, 1, new KingPiece(true));

        for(int j=0; j<8 ; j++){
           // blocks[1,j] = new Block(1,j,new Pawn(true));
        }

        // Setting Black Pieces
        blocks[7,0] = new Block(0, 0, new KingPiece(false));
        blocks[7,1] = new Block(0, 1, new KingPiece(false));

        for(int j=0; j<8 ; j++){
            //blocks[6,j] = new Block(6,j,new Pawn(false));
        }

        // Defining rest of the blocks having no pieces
        for(int i=2;i<6;i++){
            for( int j=0; j<8; j++){
                blocks[i,j] = new Block(i,j,null);
            }
        }
    }
}
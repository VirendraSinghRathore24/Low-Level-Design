public class Game1
{
    Board1 board;
    Dice dice;
    Queue<Player1> players;
    Dictionary<string, int> currentPostionMap;
    int size;

    List<Snakes> snakes;
    List<Ladders> ladders;

    public Game1(int size)
    {
        this.size = size;
        Initialize(size);
    }

    private void Initialize(int size)
    {
        // TODO : need to use board - in progress
        board = new Board1(size);
        dice = new Dice(6);

        Player1 player1 = new Player1("Viren", 1);
        Player1 player2 = new Player1("Amit", 2);

        players = new Queue<Player1>();
        players.Enqueue(player1);
        players.Enqueue(player2);

        currentPostionMap = new Dictionary<string, int>();
        currentPostionMap.Add(player1.name, 0);
        currentPostionMap.Add(player2.name, 0);

        snakes = new List<Snakes>();

        snakes.Add(new Snakes(10, 4));
        snakes.Add(new Snakes(16, 9));
        snakes.Add(new Snakes(22, 15));

        ladders = new List<Ladders>();
        ladders.Add(new Ladders(2, 11));
        ladders.Add(new Ladders(12, 20));
        ladders.Add(new Ladders(17, 33));
    }

    public void StartGame()
    {
        while(true)
        {
            // Get player
            var player = players.Dequeue();

            // TODO: Here we need to track current position of the player, so we will take <player, pos> map
            // Get current position
            var pos = currentPostionMap[player.name];

            // Roll dice
            var number = dice.RollDice();

            var nextPos = pos + number;

            if(nextPos > size)
            {
                players.Enqueue(player);
                continue;
            }
            else if(nextPos == size)
            {
                // Winner
                Console.WriteLine("Winner is => " + player.name);
                break;
            }
            else
            {
                bool isSnakeFound = false;

                // check for snakes
                foreach(var sn in snakes)
                {
                    if(sn.start == nextPos)
                    {
                        currentPostionMap[player.name] = sn.end;
                        isSnakeFound = true;
                        players.Enqueue(player);
                        break;
                    }
                }

                if(isSnakeFound) continue;

                bool isLadderFound = false;

                // check for ladder
                foreach(var ld in ladders)
                {
                    if(ld.start == nextPos)
                    {
                        currentPostionMap[player.name] = ld.end;
                        isLadderFound = true;
                        players.Enqueue(player);
                        break;
                    }
                }

                if(isLadderFound) continue;

                // else just move to that pos
                currentPostionMap[player.name] = nextPos;
                players.Enqueue(player);
            }
        }
        
    }
}
public class Player1
{
    public string name;
    public int id;

    public Player1(string name, int id)
    {
        this.name = name;
        this.id = id;
    }

    public void SetPlayerName(string name)
    {
        this.name = name;
    }

    public string GetPlayerName()
    {
        return name;
    }
}
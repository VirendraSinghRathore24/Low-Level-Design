public class VendingMachine
{
    private int collectedCash;
    private IState state;
    private Dictionary<string, HashSet<string>> productCodeItemMap;
    private Dictionary<string, int> productCodePriceMap;

    public void AddCollectedCash(int cash)
    {
        collectedCash += cash;
    }

    public int CalculateChange(string productCode)
    {
        return collectedCash - productCodePriceMap[productCode];
    }

    public VendingMachine SetState(IState state)
    {
        this.state = state;
        return this;
    }
}
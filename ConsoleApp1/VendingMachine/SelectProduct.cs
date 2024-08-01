public class SelectProduct : IState
{
    VendingMachine vendingMachine;
    public SelectProduct(VendingMachine vendingMachine)
    {
        this.vendingMachine = vendingMachine;
    }
    public void CancelTransactionState()
    {
        throw new Exception("Selecting Product, Unable to process this request");
    }

    public void CollectCashState(int cash)
    {
        throw new Exception("Selecting Product, Unable to process this request");
    }

    public void DispenseChangeState(string productCode)
    {
        throw new Exception("Selecting Product, Unable to process this request");
    }

    public void DispenseItemState(string productCode)
    {
        throw new Exception("Selecting Product, Unable to process this request");
    }

    public void SelectProductState(string productCode)
    {
        
    }
}
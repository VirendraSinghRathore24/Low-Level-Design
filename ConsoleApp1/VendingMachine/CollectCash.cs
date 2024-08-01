public class CollectCash : IState
{
    VendingMachine vendingMachine;
    public CollectCash(VendingMachine vendingMachine)
    {
        this.vendingMachine = vendingMachine;
    }

    public void CancelTransactionState()
    {
        throw new Exception("Collecting Cash, Unable to process this request");
    }

    public void CollectCashState(int cash)
    {
        vendingMachine.AddCollectedCash(cash);
        vendingMachine.SetState(new SelectProduct(vendingMachine));
    }

    public void DispenseChangeState(string productCode)
    {
         throw new Exception("Collecting Cash, Unable to process this request");
    }

    public void DispenseItemState(string productCode)
    {
         throw new Exception("Collecting Cash, Unable to process this request");
    }

    public void SelectProductState(string productCode)
    {
        throw new Exception("Collecting Cash, Unable to process this request");
    }
}
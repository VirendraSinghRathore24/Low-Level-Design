public class DispenseChange : IState
{
    private VendingMachine vendingMachine;
    public DispenseChange(VendingMachine vendingMachine)
    {
        this.vendingMachine = vendingMachine;
    }

    public void CancelTransactionState()
    {
        throw new Exception("Dispansing change. Unable to collect the cash");
    }

    public void CollectCashState(int cash)
    {
        throw new Exception("Dispansing change. Unable to collect the cash");
    }

    public void DispenseItemState(string productCode)
    {
        throw new Exception("Dispansing change. Unable to collect the cash");
    }

    public void DispenseChangeState(string productCode)
    {
        // calculate change
        vendingMachine.CalculateChange(productCode);
       // vendingMachine.SetState(new DispanseItem(this.vendingMachine));

        
    }

    public void SelectProductState(string productCode)
    {
        throw new NotImplementedException();
    }
}
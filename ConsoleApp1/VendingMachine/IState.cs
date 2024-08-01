public interface IState
{
    // states -> Ready, CollectCash, DispenseChange,  DispenseItem, CancelTransaction
    void CollectCashState(int cash);

    void SelectProductState(string productCode);

    void DispenseChangeState(string productCode);

    void DispenseItemState(string productCode);

    void CancelTransactionState();
}
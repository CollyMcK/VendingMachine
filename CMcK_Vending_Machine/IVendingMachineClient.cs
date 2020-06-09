namespace CMcK_Vending_Machine
{
    // vending machine interface for the customers
    public interface IVendingMachineClient
    {
        // user action for selecting product from machine
        void SelectProduct(string productName);

        // Represents a user action to insert coins into the machine
        void InsertCoin(int coinValue);

        // Represents a user action to eject the coin from the machine
        void EjectCoin();
    }
}

namespace CMcK_Vending_Machine
{
    // vending machine interface to handle user actions and current transactions
    public interface IVendingMachine
    {

        // keep track off current state of machine
        IState State { get; set; }

        // return the wait user selection state
        IState GetUserSelectProductState { get; }

        // return the await coin state
        IState GetWaitCoinState { get; }

        // return the sold state
        IState GetSoldState { get; }

        // product could be sold out - return that state
        IState GetSoldOutState { get; }

        // return the Dispense change state
        IState GetDispenseChangeState { get; }

        // return the currently selected product
        IProduct SelectedProduct { get; }

        // return the total products in the machine
        int TotalProductCount { get; }

        // return the customers balance for current transaction (negative signifys change is required)
        int CustomerBalance { get; }

        // get quantity of product 
        int GetProductCount(string productName);

        // display message to customer
        void DisplayMessage(string message);

        // user action for selecting product from the machine
        void SelectProduct(string productName);

        // user action for inserting coins to the machine
        void InsertCoin(int coinValue);

        // action to eject button from machine
        void EjectCoin();

        // update inventory based on current transaction after vending the product
        void ReleaseProduct();

        // add the product for tracking in the current transaction
        void AddProduct(string name);

        // return a string to show user how there change will be made up if they eject coins
        string RefundMoney();

        // return a string off how user change will be made up if it is required
        string RefundChange();
    }
}

namespace CMcK_Vending_Machine
{
    // define the common states that the vending machine can have
    // whenever a request by end user is made to the vending machine, it will be handled by the appropriate current state
    public interface IState
    {
        // define different actions on state
        void DispenseProduct();
     
        void DispenseChange();

        void EjectCoins();

        void InsertCoins();

        void SelectProduct(string productName);

       
    }
}

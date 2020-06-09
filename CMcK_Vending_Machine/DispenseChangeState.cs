using System;
namespace CMcK_Vending_Machine
{
    // DispenseChangeState confirms that product has been sold and whether machine owes user change - if it does will dispense change to User
    public class DispenseChangeState : IState
    {
        private readonly IVendingMachine machine;

        public DispenseChangeState(IVendingMachine vendingMachine)
        {
            machine = vendingMachine;
        }


        public void DispenseProduct()
        {
            // No Action
        }

        public void DispenseChange()
        {
            string change = machine.RefundChange();
            machine.DisplayMessage(string.Format("Please collect your change : \n{0}", change));
            machine.State = machine.GetUserSelectProductState;
        }

        public void EjectCoins()
        {
            // No Action
        }

        public void InsertCoins()
        {
            // No Action
        }

        public void SelectProduct(string productName)
        {
            // No Action
        }
    }
}

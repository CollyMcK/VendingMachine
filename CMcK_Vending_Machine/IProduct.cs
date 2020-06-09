namespace CMcK_Vending_Machine
{
    // absraction for the Vending machine Proudct - the assumption in my constants is that the products are soft drinks
    public interface IProduct
    {
        // N.B - assumption is whole numbers for simplicity- could be replaced with decimal
        int Price { get; set; }

        string Name { get; set; }

        int Quantity { get; set; }
    }
}

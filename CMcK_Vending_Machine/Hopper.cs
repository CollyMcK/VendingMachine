namespace CMcK_Vending_Machine
{
    // class for keeping track of the count of coins and values in the machine
    public class Hopper
    {
        // Hopper contructor - initialize hopper object with value and quantity
        public Hopper(int value, int count)
        {
            this.HopperValue = value;
            this.HopperCount = count;        
        }

        // getters and setters for Value and Count
        public int HopperValue { get; set; }

        public int HopperCount { get; set; }
    }
}

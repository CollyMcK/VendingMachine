# VendingMachine

My implementation of Vending Machine.

To run - double click the .exe from the Bin\Debug folder.  Note to allow the solution to be emailed there are two .exe files that are renamed to have .test on the end - please remove this and set it back to .exe

The prices are hard coded for each product.  They are:

Coke - 65p
Fanta Orange - 60p
Fanta Lemon - 54p
Lilt - 58p
Sprite - 90p
Diet Coke - 85p

On running you can select 1-6 to vend a product.  In this simple Main program the machine is filled with only 1 of each product so if you try to select it a 2nd time you should see a Sold out message.  For each case in the main program for the first time buying the product the coins inserted have been hardcoded.

ToDo - refactor the code into better folders within the solution. 

ToDo - write more Unit Tests.  

A number of assumptions for simplictity were also used - in loading from the main program the machine was loaded with 1 of each product.  I made an assumption that the machine vending soft drinks and set up 6 different types of drinks which can be seen in the constants class.

I also only used coin denominations 1p, 2p, 5p, 10, 20, and 50p - did not code for £1 and £2 coins and also for simplicity the coin values were set an ints rather than using decimal or float.

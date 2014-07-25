Consider a grocery market where items have prices per unit but also volume prices. For example, doughnuts may be $1.25 each or 3 for $3 dollars. There could only be a single volume discount per product.<br/><br/>
Implement a point-of-sale scanning API that accepts an arbitrary ordering of products (similar to what would happen when actually at a checkout line) then returns the correct total price for an entire shopping cart based on the per unit prices or the volume prices as applicable.<br/><br/>
Here are the products listed by code and the prices to use (there is no sales tax):
<table>
<tr><td>Product Code</td><td>Price</td></tr>
<tr><td>A</td><td>$1.25 each or 3 for $3.00</td></tr>
<tr><td>B</td><td>$4.25</td></tr>
<tr><td>C</td><td>$1.00 or $5 for a six pack</td></tr>
<tr><td>D</td><td>$0.75</td></tr>
</table>
The interface at the top level PointOfSaleTerminal service object should look something like this. You are free to design/implement the rest of the code however you wish, including how you specify the prices in the system:<br/><br/>
PointOfSaleTerminal terminal = new PointOfSaleTerminal();
terminal.SetPricing(...);
terminal.Scan("A");
terminal.Scan("C");
... etc.
double result = terminal.CalculateTotal();<br/><br/>
Here are the minimal inputs you should use for your test cases. These test cases must be shown to work in your program:<br/><br/>
Scan these items in this order: ABCDABA; Verify the total price is $13.25.<br/>
Scan these items in this order: CCCCCCC; Verify the total price is $6.00.<br/>
Scan these items in this order: ABCD; Verify the total price is $7.25<br/>

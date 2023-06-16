// Define a delegate named CalculationDelegate 
delegate int CalculationDelegate(int a, int b); 

// Create methods that match the delegate's signature 
int Add(int a, int b) 
{ 
    return a + b; 
} 
int Subtract(int a, int b) 
{ return a - b; 
} 

// Main method 
static void Main() 
{ 
    // Create an instance of the delegate and assign it to the Add method 
    CalculationDelegate calcDelegate = Add; 
    
    // Invoke the delegate, which calls the Add method 
    int result = calcDelegate(5, 3); 
    Console.WriteLine(result); // Output: 8 
    
    // Assign the delegate to the Subtract method 
    calcDelegate = Subtract; 
    
    // Invoke the delegate, which calls the Subtract method 
    result = calcDelegate(5, 3); 
    Console.WriteLine(result); // Output: 2 
} 

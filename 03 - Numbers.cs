int a = 18;
int b = 6;

//sum
int c = a + b;
Console.WriteLine(c);


//Subtraction
int c = a - b;

//Multiplication
int c = a * b; 

//Division
int c = a / b;

//order of operations

int d = (a + b) - 6 * c + (12 * 4) / 3 + 12;


// integer precision and limits

//remainder
int a = 7;
int b = 4;
int c = 3;
int d = (a + b) / c;
int e = (a + b) % c;
Console.WriteLine($"quotient: {d}");
Console.WriteLine($"remainder: {e}");

// min-max value

int max = int.MaxValue;
int min = int.MinValue;
Console.WriteLine($"The range of integers is {min} to {max}");

//overflow

int what = max + 3;
Console.WriteLine($"An example of overflow: {what}");
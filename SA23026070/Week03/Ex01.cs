using System;

class Program {
    static void Main(string[] args) {
        int a = 5;
        int b = 7;


// Greater than
bool isAGreaterThanB = a > b;
Console.WriteLine("Is a>b? "+isAGreaterThanB);

// Less than or equal to
bool isALessThanOrEqualToB = a <= b;
Console.WriteLine("Is a <= b? "+isALessThanOrEqualToB);

// Equal to
bool areAAndBEqual = a == b;
Console.WriteLine("Are a and b equal? "+areAAndBEqual);

// Not equal to
bool areAAndBNotEqual = a != b;
Console.WriteLine("Are a and b not equal? "+areAAndBNotEqual);
    }
}
# Introduction to test driven development part 2

In this tutorial we will continue from where we left off in part 1. 
Our goal is to be less verbose (repeated code) and to make the tests more readable and flexible.

## Writing tests
A basic test is simply evaluating if what you expect is equal to what you get. 

```csharp
if( expected == actual )
{
    Console.WriteLine("🟢 Test passed");
}
else
{
    Console.WriteLine("🔴 Test failed");
}
```
But this is not very readable and it is not very flexible.
Our first step is to remove repetition of code. We can do this by creating a function that takes in the expected and actual values and returns a string. 
```csharp
void Test( int expected, int actual )
{
    if( expected == actual )
    {
        Console.WriteLine( "🟢 Test passed");
    }
    else
    {
        Console.WriteLine("🔴 Test failed");
    }
}
```

We can then use this function to write our tests. 
With the original way we wher testing this would be 20+ lines, now it is only 3. 
```csharp
Test(3, Add(1, 2));
Test(5, Add(2, 3));
Test(7, Add(3, 4));
```

## Making the tests more valuable
The tests do tell us when something is broken, but they do not tell us what is broken.
We can make the tests more valuable by adding a message to the Test function. 
```csharp
void Test( int expected, int actual, string description = "Test" )
{
    if( expected == actual )
    {
        Console.WriteLine( $"🟢 {description}");
    }
    else
    {
        Console.WriteLine($"🔴 {description}, expected {expected}, recived {actual}");
    }
}
```

## Making the tests more flexible
Now there are diffrent things we can do to make the tests more flexible.
We could use overloading to make the Test function take in difrent types of values https://www.w3schools.com/cs/cs_method_overloading.php.
Or we could use generics https://learn.microsoft.com/en-us/dotnet/csharp/fundamentals/types/generics 
Or we could have the Test function take in a function that returns a bool, so we do the evaluation in the parsed function. 
Or we could combine the difrent options.
For now we will use generics to make the tests more flexible, and implement some overloaded functions to make the tests more readable. 
```csharp
void Test<T>( T expected, T actual, string description = "Test" )
{
    if( expected.Equals(actual) ) // Note that we use the Equals method to compare the values not the == operator. 
    {
        Console.WriteLine( $"🟢 {description}");
    }
    else
    {
        Console.WriteLine($"🔴 {description}, expected {expected}, recived {actual}");
    }
}
```


## The example
This time we are going to write a function that converts from integer to roman numerals.
The tests are in the Tests.cs file and the code is in Program.cs. The test framwork is moved to the file TestFramework.cs, for better readability.
Notise how we use the Test function to make the tests more readable and flexible compared to the first part.

- Try refactoring the convert function so that all the tests pass.
- Can you make a function that takes a roman numeral and returns an integer using TDD ?
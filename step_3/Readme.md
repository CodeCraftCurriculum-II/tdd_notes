# An intermission
Somtimes we need to run code that should throw an error to test that it does throw an error. This is a good practice to ensure that the code is working as expected. But we don't want to stop the execution of the code because one test fail. We can use the `try` and `catch` statements to catch the error and continue the execution of the other tests.

Simmilarly we want to test for misc situations, and we could write functions to do that, but we can also use the `assert` statement to test for conditions. If the condition is `False` the `assert` statement will throw an error and stop the execution of the notebook. 


## Try Catch Finally
The `try` statement is used to catch errors. The `catch` statement is used to catch the error and do something with it. The `finally` statement is used to do something after the `try` and `catch` statements. 

```csharp
try
{
    // Code that may throw an error
    double bad = 1 / 0;
}
catch (Exception e)
{
    // Code to handle the error
    Console.WriteLine(e.Message);
}
finally
{
    // Code that will run after the try and catch statements
}

Console.WriteLine("This will run after the try, catch, and finally statements, because the error was handled.");
```

## Assert
A `Assert` statement is used to test for conditions. If the condition is `False` the `Assert` statement will throw an error and stop the execution.
There is not a `Assert` statement in C#, but we can use the `Assert` class from sources like `XUnit.Framework` `NUnit.Framework` .  

```csharp
using Assert = Xunit.Assert;

int x = 1;
int y = 2;
Assert.True(x == y, "x is not equal to y");
```

Or if combined with the `try` and `catch` statements, the `Assert` statement will throw an error and the `catch` statement will catch the error and continue the execution.  

```csharp
using Assert = Xunit.Assert;

try
{
    int x = 1;
    int y = 2;
    Assert.True(x == y, "x is not equal to y");
}
catch (Exception e)
{
    Console.WriteLine(e.Message);
}
Console.WriteLine("This will run after the try, catch, and finally statements, because the error was handled.");
```


## Exercise
In the Program.cs file we have added examples of evrything discussed in this section. Run the code and see what happens. 
Looking back to Step 2, Overloading is a method that could have been used to make this code more readable. 
As en exercise, refactor the code to use overloading.
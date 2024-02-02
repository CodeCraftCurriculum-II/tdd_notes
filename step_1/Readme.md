# Introduction to test driven development

In this tutorial, we will learn about test driven development. We will learn how to write tests and then write code to pass the tests. 
We will also learn about the red-green-refactor cycle.

## What is test driven development?
Test drivend development is a software development process in which the tests are written before the code. The tests are written to fail and then the code is written to pass the tests. The most important aspect is to write the tests before the code, never after. 
If we writ the tests before the code, we can be sure that the code is testable and that the tests are not written to pass the code.
We will also understand the problem we are trying to solve better.

## Red-Green-Refactor cycle
The red-green-refactor cycle is the cycle of test driven development.
1. Red: Write a test that fails
2. Green: Write the code to pass the test
3. Refactor: Refactor the code to make it better
4. Repeat until the code meats the requirements (solves the problem).

## Writing tests
A basic test is simply evaluating if what you expect is equal to what you get.
Writing tests in this way is very simple and easy to understand, but it is not very flexible and requires a lot of repeted code. 

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

## The example
In this tutorial, we will write a simple function that adds two numbers. We will write the tests first and then the code to pass the tests.
The tests are in the Tests.cs file and the code is in Program.cs. 
Notise that there is a lot of repeated code, and that the tests do not tell us a lot without us adding even more code. 
We will refactor the tests to make them more readable and flexible in step_2. 
But for now:
- Try refactoring the Add function so that the final test goes green 
- Write some tests for a function that multiplies two numbers.
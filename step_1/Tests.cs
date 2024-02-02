using M = example.MathFunctions;

// Given two integers, the function returns an integer
var actual = M.Add(1, 1);
if (typeof(int) == actual.GetType())
{
    Console.WriteLine("🟢 Test passed");
}
else
{
    Console.WriteLine("🔴 Test failed");
}

// Given two integers, the function returns the sum of the two integers
actual = M.Add(1, 1);
int expected = 2;
if (expected == actual)
{
    Console.WriteLine("🟢 Test passed");
}
else
{
    Console.WriteLine("🔴 Test failed");
}

// Given two new integers, the function returns the sum of the two integers
Random rnd = new Random();
int a = rnd.Next();
int b = rnd.Next();
expected = a + b;
actual = M.Add(a, b);

if (expected == actual)
{
    Console.WriteLine("🟢 Test passed");
}
else
{
    Console.WriteLine("🔴 Test failed");
}
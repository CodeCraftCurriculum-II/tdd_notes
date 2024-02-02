using Assert = Xunit.Assert;


#region Test using try catch and assert. 

try
{
    int x = 1;
    int y = 2;
    Assert.True(x == y, "x is not equal to y");
    // Assert.Equal(x, y); // Assert has many suport functions, this achives the same as the previous with less typing

    Console.WriteLine("🟢 Test pased");
}
catch (Exception e)
{
    Console.WriteLine($"🔴 Test failed {e.Message}");
}


#endregion

Console.WriteLine("".PadLeft(20, '-'));

#region Test wrapping the assertion and error handling in a test function 


void TestIsEqual(int a, int b)
{

    try
    {
        Assert.Equal(a, b); // This is where the actual test is beeing done.
        Console.WriteLine("🟢 Test pased");
    }
    catch (Exception e)
    {
        Console.WriteLine($"🔴 Test failed {e.Message}");
    }

}

TestIsEqual(1, 1);
TestIsEqual(1, 2);


#endregion

Console.WriteLine("".PadLeft(20, '-'));

#region Extending with generics


void IsEqual<T>(T a, T b)
{

    try
    {
        Assert.Equal(a, b); // This is where the actual test is beeing done.
        Console.WriteLine("🟢 Test pased");
    }
    catch (Exception e)
    {
        Console.WriteLine($"🔴 Test failed {e.Message}");
    }

}

// We can do the same for array types.

void IsArrayEqual<T>(T[] a, T[] b)
{
    try
    {
        Assert.Equal(a, b); // This is where the actual test is beeing done.
        Console.WriteLine("🟢 Test pased");
    }
    catch (Exception e)
    {
        Console.WriteLine($"🔴 Test failed {e.Message}");
    }
}

IsEqual<String>("1", "1");
IsEqual<bool>(true, false);

IsArrayEqual<int>(new int[] { 1, 2 }, new int[] { 3, 4 });
IsArrayEqual<String>(new String[] { "A", "B" }, new String[] { "A", "B" });


#endregion
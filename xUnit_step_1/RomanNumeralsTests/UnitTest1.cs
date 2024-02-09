using Roman = RomanNumerals.RomanNumerals;


namespace RomanNumeralsTests;

public class RomanNumeralsConvertionFromIntTests
{
    [Fact]
    public void GivenAIntegerReturnAString()
    {
        var actual = Roman.Convert(1);
        Assert.True(actual.GetType() == typeof(string));
    }


    [Fact]
    public void GivenAIntegerBellowFourReturnsARomenNUmeral()
    {
        var actual = Roman.Convert(1);
        Assert.Equal(actual, "I");
    }

    [Fact]
    public void GivenAIntegerAboveFourReturnsARomenNUmeral()
    {
        var actual = Roman.Convert(4);
        Assert.Equal(actual, "IV");
    }

    [Fact]
    public void TestDanger()
    {
        // Testing code that should fail
        Assert.Throws<System.DivideByZeroException>(() =>
        {
            int a = 0;
            float b = 1 / a;
        });



    }

}
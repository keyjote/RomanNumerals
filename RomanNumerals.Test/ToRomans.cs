namespace RomanNumerals.Test;

public class ToRomans 
{
    [Theory]
    [InlineData(-6)]
    [InlineData(0)]
    [InlineData(99999)]
    [InlineData(-99999)]
    public void BadNumbers(int number)
    {
        Assert.Throws<ArgumentException>(() => Romans.ToRomans(number));
    }
    
    [Theory]
    [InlineData(1, "I")]
    [InlineData(4, "IV")]
    [InlineData(5, "V")]
    [InlineData(9, "IX")]
    [InlineData(10, "X")]
    [InlineData(50, "L")]
    [InlineData(100, "C")]
    [InlineData(500, "D")]
    [InlineData(1000, "M")]
    public void BasicNumbers(int number, string expectedResult)
    {
        Assert.Equal(expectedResult, Romans.ToRomans(number));
    }
    
    [Theory]
    [InlineData(2, "II")]
    [InlineData(3, "III")]
    [InlineData(6, "VI")]
    [InlineData(7, "VII")]
    [InlineData(8, "VIII")]
    [InlineData(11, "XI")]
    [InlineData(19, "XIX")]
    [InlineData(59, "LIX")]
    [InlineData(77, "LXXVII")]
    [InlineData(99, "XCIX")]
    [InlineData(777, "DCCLXXVII")]
    [InlineData(999, "CMXCIX")]
    [InlineData(3999, "MMMCMXCIX")]
    public void NotSoBasicNumbers(int number, string expectedResult)
    {
        Assert.Equal(expectedResult, Romans.ToRomans(number));
    }
}
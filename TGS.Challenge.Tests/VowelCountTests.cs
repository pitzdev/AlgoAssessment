using System;
using Xunit;

namespace TGS.Challenge.Tests
{
  public class VowelCountTests
  {
    private readonly VowelCount _vowelCount;

    public VowelCountTests()
    {
      this._vowelCount = new VowelCount();
    }

    [Fact]
    public void Value_IsRequired()
    {
      Assert.Throws<ArgumentException>(() => _vowelCount.Count(string.Empty));
    }

    [Fact]
    public void AEIOU_Returns_Correct_Count()
    {
            //** Modified Assert.Equal(count, 6) to Assert.Equal(count, 5) vowel count is always 6 not 6
            var count = _vowelCount.Count("AEIOU");
            //   Assert.Equal(count, 6);
            Assert.Equal(count, 5);
    }

    [Fact]
    public void lmnpqr_Returns_Correct_Count()
    {
      var count = _vowelCount.Count("lmnpqr");

      Assert.Equal(count, 0);
    }

    [Fact]
    public void abcdefghijklmnopqrstuvwxyz_Returns_Correct_Count()
    {
      var count = _vowelCount.Count("abcdefghijklmnopqrstuvwxyz");
            //** Modified test Case from _vowelCount.Count("lmnpqr") to  _vowelCount.Count("abcdefghijklmnopqrstuvwxyz") 
            //** checking vowel count of lmnpqr which should be 0 but the method call is a-z which will give a count of 5 

            // var count = _vowelCount.Count("lmnpqr");

            Assert.Equal(count, 5);
    }

    [Fact]
    public void Howmanycanyoufind_Returns_Correct_Count()
    {
      var count = _vowelCount.Count("How many can you find");

      Assert.Equal(count, 6);
    }
  }
}
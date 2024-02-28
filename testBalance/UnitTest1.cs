using bracketbalance;

namespace testBalance
{
    public class UnitTest1
    {
        [Theory]
        [InlineData("{}}}}}")]
        [InlineData("{}")]
        [InlineData("}{")]
        [InlineData("{{{}  }}}")]
        [InlineData("{{}}}")]
        [InlineData("}{}}{}")]
        [InlineData("{{{}}}")]
        [InlineData("{{{{{}}}}}")]
        [InlineData("{}}}}{{}{}{}{{")]
        [InlineData("}{}")]
        public void Test1(string value)
        {

            Assert.True(Balance.isBalance(value));
        }
    }
}
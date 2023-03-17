using Add;

using Xunit;

namespace Add
{
    public class AddNumbersTest
    {
        [Fact]
        public void HappyPath()
        {
            int fivePlus2 = NumberCruncher.AddNumbers(5, 2);
            Assert.True(fivePlus2 == 7);

            int sevenPlusOne = NumberCruncher.AddNumbers(7, 1);
            Assert.True(sevenPlusOne == 8);
        }

        [Fact]
        public void SadPath()
        {
            int onePlusOne = NumberCruncher.AddNumbers(1, 1);
            Assert.False(onePlusOne == 7);
        }
    }
}
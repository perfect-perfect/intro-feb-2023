namespace Demo1.UnitTests
{
    public class UnitTest1
    {
        [Fact]
        public void Test1()
        {
            int a = 10, b = 20, c;

            c = a + b;

            Assert.Equal(30, c);
        }

        [Fact]
        public void AddTwoNumbers() 
        { 
            
        }

        [Theory]
        [InlineData(2, 2, 4)]
        [InlineData(8, 2, 10)]
        [InlineData(40, 2, 42)]
        public void CanAddTwoNumbersTheory(int a, int b, int expected)
        {

            int answer = a + b;
            Assert.Equal(expected, answer);

        }
    }
}
using System;
using Moq;

namespace ConsoleApp1.Tests
{
    public interface ITestInterface
    {
        int BuildSomething(int theInt, string theString, bool theBool);
    }

    public class Test1
    {
       public void METHOD()
        {
            var mock = new Mock<ITestInterface>();
            var count = 0;
            mock.Setup(x => x.BuildSomething(It.IsAny<int>(), It.IsAny<string>(), It.IsAny<bool>()))
                .Returns(0)
                .Callback<int, string, bool>((i, s, arg3) => count += i);
            Console.WriteLine(count);
        }
    }
}
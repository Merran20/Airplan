using Airplan;
using NUnit.Framework;
using System;
using System.IO;


namespace TestContext
{
    [TestFixture, Parallelizable(ParallelScope.All)]
    public class TestAirplan
    {
        private readonly string[] realData = File.ReadAllLines(Path.Combine(NUnit.Framework.TestContext.CurrentContext.TestDirectory, "Data", "airplan1.dat"));
        private readonly string[] realData2 = File.ReadAllLines(Path.Combine(NUnit.Framework.TestContext.CurrentContext.TestDirectory, "Data", "airplan2.dat"));


        [Test]
        [TestCase("forward 5,down 5,forward 8,up 3,down 8,forward 2", 150)]
        public void FlyTest1(string input, int? expected)
        {
            var lines = input != null ? input.Split(',') : realData;
            var result = Flight.Calculate(lines, false);

            if (expected != null)
            {
                Assert.AreEqual(expected.Value, result);
            }
            Console.WriteLine(result);
        }

        [Test]
        [TestCase("forward 5,down 5,forward 8,up 3,down 8,forward 2", 900)]
        public void FlyTest2(string input, int? expected)
        {
            var lines = input != null ? input.Split(',') : realData;
            var result = Flight.Calculate(lines, true);

            if (expected != null)
            {
                Assert.AreEqual(expected.Value, result);
            }
            Console.WriteLine(result);
        }

        [Test]
        [TestCase("forward 4,up 2,forward 8,down 1,forward 2,up 3,forward 3", 510)]

        public void FlyTest3(string input, int? expected)
        {
            var lines = input != null ? input.Split(',') : realData2;
            var result = Flight.Calculate(lines, true);

            if (expected != null)
            {
                Assert.AreEqual(expected.Value, result);
            }
            Console.WriteLine(result);
        }
    }
}

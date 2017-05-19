using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace ProcessKata
{
    [TestClass]
    public class RuleTests
    {
        [TestMethod]
        public void Rule1()
        {
            var rule = new Rule1();
            var input = new ProcessInput(1, 2, 3);

            var result = rule.Handle(input);
            Assert.AreEqual(11, result.A);   
            Assert.AreEqual(12, result.B); 
        }

        [TestMethod]
        public void Rule2()
        {
            var rule = new Rule2();
            var input = new ProcessInput(1, 2, 3);
            var output = new ProcessOutput(11, 12);

            var result = rule.Handle(input, output);
            Assert.AreEqual(33, result.A);
            Assert.AreEqual(36, result.B);
        }

        [TestMethod]
        public void Rule3()
        {
            var rule = new Rule3();
            var input = new ProcessInput(1, 2, 3);
            var output = new ProcessOutput(33, 36);

            var result = rule.Handle(input, output);
            Assert.AreEqual(36, result.A);
            Assert.AreEqual(39, result.B);
        }

        [TestMethod]
        public void Rule4()
        {
            var rule = new Rule4();
            var input = new ProcessInput(1, 2, 3);
            var output = new ProcessOutput(36, 39);

            var result = rule.Handle(input, output);
            Assert.AreEqual(40, result.A);
            Assert.AreEqual(43, result.B);
        }
    }
}
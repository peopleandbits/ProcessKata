using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace ProcessKata
{
    [TestClass]
    public class RuleTests
    {
        [TestMethod]
        public void Rule1()
        {
            var rule = new R1();
            var input = new Input(1, 2, 3);
            Assert.AreEqual(2, rule.Handle(input));
        }

        [TestMethod]
        public void Rule2()
        {
            var rule = new R2();
            var input = new Input(1, 2, 3);
            Assert.AreEqual(4, rule.Handle(input));
        }

        [TestMethod]
        public void Rule3()
        {
            var rule = new R3();
            var input = new Input(1, 2, 3);
            Assert.AreEqual(6, rule.Handle(input));
        }

        [TestMethod]
        public void Rule4()
        {
            var rule = new R4();
            var input = new Input(1, 2, 3);
            Assert.AreEqual(6, rule.Handle(input));
        }
    }
}
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace ProcessKata
{
    [TestClass]
    public class ProcessTests
    {
        [TestMethod]
        public void RunOldest()
        {
            IProcess p = new ProcessOld();
            RunTests(p);
        }

        [TestMethod]
        public void RunOld()
        {
            IProcess p = new ProcessOld();
            RunTests(p);
        }

        [TestMethod]
        public void RunRules1to4()
        {
            var rules = new IRule[] { new Rule1(), new Rule2(), new Rule3(), new Rule4() };
            IProcess p = new Process(rules);
            RunTests(p);
        }

        [TestMethod]
        public void RunRules1and4()
        {
            var rules = new IRule[] { new Rule1(), new Rule4() };
            var input = new ProcessInput(1, 2, 3);
            IProcess p = new Process(rules);
            var result = p.Run(input);

            // rules 1 and 3 applied
            Assert.AreEqual(15, result.A); // (1 + 10 * 3) + 3 + 4 = 40  
            Assert.AreEqual(16, result.B); // (2 + 10 * 3) + 3 + 4 = 43
        }

        static void RunTests(IProcess p)
        {
            var input = new ProcessInput(1, 2, 3);
            var result = p.Run(input);

            // rules 1, 2, 3 and 4 applied
            Assert.AreEqual(40, result.A); // (1 + 10 * 3) + 3 + 4 = 40  
            Assert.AreEqual(43, result.B); // (2 + 10 * 3) + 3 + 4 = 43
        }
    }
}
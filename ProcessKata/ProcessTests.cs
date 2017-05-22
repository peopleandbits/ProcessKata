using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace ProcessKata
{
    [TestClass]
    public class ProcessTests
    {
        [TestMethod]
        public void RunOldest()
        {
            RunTests(new Process1());
        }

        [TestMethod]
        public void RunOld()
        {
            RunTests(new Process2());
        }

        [TestMethod]
        public void Run()
        {
            var rules = new IRule[] { new R1(), new R2(), new R3(), new R4() };
            RunTests(new Process3(rules));
        }

        [TestMethod]
        public void RunRules1and3()
        {
            var rules = new IRule[] { new R1(), new R3() };
            var input = new Input(1, 2, 3);
            int result = new Process3(rules).Run(input);
            
            // rules 1 and 3 applied
            Assert.AreEqual(8, result);

            IProcess p = new Process1();
            p.Run(new Input(1,2,3));
        }

        static void RunTests(IProcess p)
        {
            var input = new Input(1, 2, 3);
            var result = p.Run(input);

            // rules 1, 2, 3 and 4 applied
            Assert.AreEqual(18, result);
        }
    }
}
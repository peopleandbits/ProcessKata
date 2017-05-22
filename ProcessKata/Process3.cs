using System.Linq;

namespace ProcessKata
{
    public class Process3 : IProcess
    {
        public Process3(IRule[] rules = null) { _Rules = rules; }
        IRule[] _Rules;
        public int Run(Input input) => _Rules.Sum(r => r.Handle(input));
    }
}
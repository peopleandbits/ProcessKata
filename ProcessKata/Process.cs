namespace ProcessKata
{
    public class Process : IProcess
    {
        public Process(IRule[] rules = null) { _InputRules = rules; }

        IRule[] _InputRules;

        public ProcessOutput Run(ProcessInput input)
        {
            ProcessOutput result = null;
            
            foreach (var rule in _InputRules)
                result = rule.Handle(input, result);

            return result;
        }
    }
}
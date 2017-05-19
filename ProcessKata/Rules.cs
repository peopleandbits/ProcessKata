namespace ProcessKata
{
    public interface IRule { ProcessOutput Handle(ProcessInput i, ProcessOutput o = null); }

    public class Rule1 : IRule
    {
        public ProcessOutput Handle(ProcessInput i, ProcessOutput o = null)
            => new ProcessOutput(i.Input1 + 10, i.Input2 + 10);
    }

    public class Rule2 : IRule
    {
        public ProcessOutput Handle(ProcessInput i, ProcessOutput o = null)
            => new ProcessOutput(o.A * i.Input3, o.B * i.Input3);
    }

    public class Rule3 : IRule
    {
        public ProcessOutput Handle(ProcessInput i, ProcessOutput o = null)
            => new ProcessOutput(o.A += 3, o.B += 3);
    }

    public class Rule4 : IRule
    {
        public ProcessOutput Handle(ProcessInput i, ProcessOutput o = null)
            => new ProcessOutput(o.A += 4, o.B += 4);
    }
}

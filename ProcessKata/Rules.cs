namespace ProcessKata
{
    public interface IRule { int Handle(Input i); }
    public class R1 : IRule { public int Handle(Input i) => i.Input1 + 1; }
    public class R2 : IRule { public int Handle(Input i) => i.Input2 + 2; }
    public class R3 : IRule { public int Handle(Input i) => i.Input3 + 3; }
    public class R4 : IRule { public int Handle(Input i) => i.Input1 * i.Input2 * i.Input3; }
}
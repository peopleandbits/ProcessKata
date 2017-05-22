namespace ProcessKata
{
    public interface IProcess
    {
        int Run(Input input);
    }

    public class Input
    {
        public Input(int i1, int i2, int i3)
        {
            Input1 = i1;
            Input2 = i2;
            Input3 = i3;
        }

        public int Input1 { get; set; }
        public int Input2 { get; set; }
        public int Input3 { get; set; }
    }
}

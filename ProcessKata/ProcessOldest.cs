namespace ProcessKata
{
    public class ProcessOldest : IProcess
    {
        public ProcessOutput Run(ProcessInput i)
        {
            return new ProcessOutput(Calculate(i.Input1), Calculate(i.Input2));
        }

        static int Calculate(int i) => (i + 10 * 3) + 7;
    }
}
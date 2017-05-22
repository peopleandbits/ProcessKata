namespace ProcessKata
{
    public class Process1 : IProcess
    {
        public int Run(Input i)
        {
            return  (i.Input1 + 1) + 
                    (i.Input2 + 2) + 
                    (i.Input3 + 3) + 
                    (i.Input1 * i.Input2 * i.Input3);
        }
    }
}
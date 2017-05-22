namespace ProcessKata
{
    public class Process2 : IProcess
    {
        public int Run(Input i) => Step1(i) + Step2(i) + Step3(i) + Step4(i);
        int Step1(Input i) => i.Input1 + 1;
        int Step2(Input i) => i.Input2 + 2;
        int Step3(Input i) => i.Input3 + 3;
        int Step4(Input i) => i.Input1 * i.Input2 * i.Input3;
    }
}
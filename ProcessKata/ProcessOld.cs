namespace ProcessKata
{
    public class ProcessOld : IProcess
    {
        public ProcessOutput Run(ProcessInput i)
        {
            // Step1: output a is input1 plus 10, output b is input2 plus 10
            int a = i.Input1 + 10;
            int b = i.Input2 + 10;

            // Step2: outputs are multiplied by input3
            a *= i.Input3;
            b *= i.Input3;

            // Step3: a is added by day num, b is added with month num 
            a += 3;
            b += 3;

            // Step4: add 5 to both
            a += 4;
            b += 4;

            return new ProcessOutput(a, b);
        }
    }
}
using System;

namespace EasyInput
{
    public class Execute
    {
        static void Main()
        {
            var input = EasyInput.InputLine("How's the weather today? ");
            Console.WriteLine(input);
        }
    }
}
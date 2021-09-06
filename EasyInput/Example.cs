using System;

namespace EasyInput
{
    public class Execute
    {
        static void Main()
        {
            var easyInput = EasyInput.InputLine("How's the weather today? ");
            Console.WriteLine(easyInput);

            Console.WriteLine("How many years old is the Earth? ");
            var controlledInput = ControlledInput.ReadLong();
            Console.WriteLine(controlledInput);
        }
    }
}
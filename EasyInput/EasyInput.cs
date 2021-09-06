using System;

namespace EasyInput
{
    class EasyInput
    {
        public static void ExecuteLine(string str)
        {
            Console.WriteLine(str);
            var inputGiven = Console.ReadLine();

            var inputGivenString = typeof(string);
            var inputGivenChar = typeof(char);
            var inputGivenSByte = typeof(sbyte);
            var inputGivenByte = typeof(byte);
            var inputGivenInt = typeof(int);
            var inputGivenUInt = typeof(uint);
            var inputGivenShort = typeof(short);
            var inputGivenLong = typeof(long);
            var inputGivenULong = typeof(ulong);
            var inputGivenDouble = typeof(double);
            var inputGivenFloat = typeof(float);
            var inputGivenDecimal = typeof(decimal);
            var inputGivenBoolean = typeof(bool);
        }
    }
}
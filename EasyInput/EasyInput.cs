using System;

namespace EasyInput
{
    class EasyInput
    {
        public static dynamic InputLine(string str)
        {
            Console.WriteLine(str);
            var inputGiven = Console.ReadLine();
            var inputGivenType = inputGiven.GetType();
            
            var inputGivenString = typeof(string);
            var inputGivenChar = typeof(char);
            var inputGivenSByte = typeof(sbyte);
            var inputGivenByte = typeof(byte);
            var inputGivenInt = typeof(int);
            var inputGivenUInt = typeof(uint);
            var inputGivenShort = typeof(short);
            var inputGivenUShort = typeof(ushort);
            var inputGivenLong = typeof(long);
            var inputGivenULong = typeof(ulong);
            var inputGivenDouble = typeof(double);
            var inputGivenFloat = typeof(float);
            var inputGivenDecimal = typeof(decimal);
            var inputGivenBoolean = typeof(bool);
            
            
            if (inputGivenType == inputGivenString)
            {
                return Convert.ToString(inputGiven);
            }
            if (inputGivenType == inputGivenChar)
            { 
                return Convert.ToChar(inputGiven);   
            }
            if (inputGivenType == inputGivenSByte)
            {
                return Convert.ToSByte(inputGiven);
            }
            if (inputGivenType == inputGivenByte)
            {
                return Convert.ToByte(inputGiven);
            }
            if (inputGivenType == inputGivenInt)
            {
                return Convert.ToInt32(inputGiven);
            }
            if (inputGivenType == inputGivenUInt)
            {
                return Convert.ToUInt32(inputGiven);
            }
            if (inputGivenType == inputGivenShort)
            {
                return Convert.ToInt16(inputGiven);
            }
            if (inputGivenType == inputGivenUShort)
            {
                return Convert.ToUInt16(inputGiven);
            }
            if (inputGivenType == inputGivenLong)
            {
                return Convert.ToInt64(inputGiven);
            } 
            if (inputGivenType == inputGivenULong)
            {
                return Convert.ToUInt64(inputGiven);
            }
            if (inputGivenType == inputGivenDouble)
            {
                return Convert.ToDouble(inputGiven);
            }
            if (inputGivenType == inputGivenFloat)
            {
                return Convert.ToSingle(inputGiven);
            }
            if (inputGivenType == inputGivenDecimal)
            {
                return Convert.ToDecimal(inputGiven);
            }
            if (inputGivenType == inputGivenBoolean)
            {
                return Convert.ToBoolean(inputGiven);
            }

            throw new Exception("Cannot covert parameter str from " + str.GetType() + " to string");
        }
    }
}
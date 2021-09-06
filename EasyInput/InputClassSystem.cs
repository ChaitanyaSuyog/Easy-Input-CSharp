
using System;
using System.Diagnostics.CodeAnalysis;


namespace EasyInput
{
    //Suppress "Method not used" warnings.
    [SuppressMessage("ReSharper", "UnusedMember.Global")]
    
    class Input
    {
        public static string ReadString()
        {
            return Console.ReadLine();
        }

        public static char ReadChar()
        {
            return Convert.ToChar(Console.ReadLine());
        }

        public static sbyte ReadSByte()
        {
            return Convert.ToSByte(Console.ReadLine());
        }
        
        public static byte ReadByte()
        {
            return Convert.ToByte(Console.ReadLine());
        }
        
        public static int ReadInt()
        {
            return Convert.ToInt32(Console.ReadLine());
        }

        public static uint ReadUInt()
        {
            return Convert.ToUInt32(Console.ReadLine());
        }

        public static short ReadShort()
        {
            return Convert.ToInt16(Console.ReadLine());
        }

        public static ushort ReadUShort()
        {
            return Convert.ToUInt16(Console.ReadLine());
        }

        public static long ReadLong()
        {
            return Convert.ToInt64(Console.ReadLine());
        }

        public static ulong ReadULong()
        {
            return Convert.ToUInt64(Console.ReadLine());
        }
        
        public static double ReadDouble()
        {
            return Convert.ToDouble(Console.ReadLine());
        }

        public static float ReadFloat()
        {
            return Convert.ToSingle(Console.ReadLine());
        }

        public static decimal ReadDecimal()
        {
            return Convert.ToDecimal(Console.ReadLine());
        }

        public static bool ReadBoolean()
        {
            return Convert.ToBoolean(Console.ReadLine());
        }
        
    }
}
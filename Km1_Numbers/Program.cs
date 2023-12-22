namespace Km1_Numbers
{
    internal class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine("{0,-15} {1,-15} {2,-20} {3,-15}", "Type", "Byte(s) of memory", "Min", "Max");
            Console.WriteLine("{0,-15} {1,-15} {2,-20:E2} {3,-15:E2}", "sByte", sizeof(sbyte), sbyte.MinValue, sbyte.MaxValue);
            Console.WriteLine("{0,-15} {1,-15} {2,-20:E2} {3,-15:E2}", "byte", sizeof(byte), byte.MinValue, byte.MaxValue);
            Console.WriteLine("{0,-15} {1,-15} {2,-20:E2} {3,-15:E2}", "short", sizeof(short), short.MinValue, short.MaxValue);
            Console.WriteLine("{0,-15} {1,-15} {2,-20:E2} {3,-15:E2}", "uShort", sizeof(ushort), ushort.MinValue, ushort.MaxValue);
            Console.WriteLine("{0,-15} {1,-15} {2,-20:E2} {3,-15:E2}", "int", sizeof(int), int.MinValue, int.MaxValue);
            Console.WriteLine("{0,-15} {1,-15} {2,-20:E2} {3,-15:E2}", "uInt", sizeof(uint), uint.MinValue, uint.MaxValue);
            Console.WriteLine("{0,-15} {1,-15} {2,-20:E2} {3,-15:E2}", "long", sizeof(long), long.MinValue, long.MaxValue);
            Console.WriteLine("{0,-15} {1,-15} {2,-20:E2} {3,-15:E2}", "uLong", sizeof(ulong), ulong.MinValue, ulong.MaxValue);
            Console.WriteLine("{0,-15} {1,-15} {2,-20:E2} {3,-15:E2}", "float", sizeof(float), float.MinValue, float.MaxValue);
            Console.WriteLine("{0,-15} {1,-15} {2,-20:E2} {3,-15:E2}", "double", sizeof(double), double.MinValue, double.MaxValue);
            Console.WriteLine("{0,-15} {1,-15} {2,-20:E2} {3,-15:E2}", "decimal", sizeof(decimal), decimal.MinValue, decimal.MaxValue);
        }
    }
}

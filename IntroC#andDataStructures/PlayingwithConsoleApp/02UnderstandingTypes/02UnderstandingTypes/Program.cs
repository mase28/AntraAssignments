// See https://aka.ms/new-console-template for more information

namespace UnderstandingTypes
{
    class Program
    {
        public static int Main(string[] args)
        {
            Console.WriteLine("sbyte: , byte, short, ushort, int, uint, long, ulong, float, double, and decimal");
            Console.WriteLine($"sbyte has size: {sizeof(sbyte)}, and can range from -128 to 127.");
            Console.WriteLine($"byte has size: {sizeof(byte)}, and can range from 0 to 255.");
            Console.WriteLine($"short has size: {sizeof(short)}, and can range from -32,768 to 32,767.");
            Console.WriteLine($"ushort has size: {sizeof(ushort)}, and can range from 0 to 65,535");
            Console.WriteLine($"int has size: {sizeof(int)}, and can range from -2,147,483,648 to 2,147,483,647.");
            Console.WriteLine($"unit has size: {sizeof(uint)}, and can range from 0 to 4,294,967,295");
            Console.WriteLine($"long has size: {sizeof(long)}, and can range from -9,223,372,036,854,775,808 to 9,223,372,036,854,775,807");
            Console.WriteLine($"long has size: {sizeof(ulong)}, and can range from 0 to 18,446,744,073,709,551,615");
            Console.WriteLine($"float has size: {sizeof(float)}, and can range from ±1.5 x 10^-45 to ±3.4 x 10^38");
            Console.WriteLine($"double has size: {sizeof(double)}, and can range from ±5.0 x 10^-324 to ±1.7 x 10^308");
            Console.WriteLine($"decimal has size: {sizeof(decimal)}, and can range from ±1.0 x 10^-28 to ±7.9228 x 10^28");

            Console.WriteLine();
            Console.WriteLine();
            Console.Write("Enter Number of Centuries: ");
            sbyte centuries = Convert.ToSByte(Console.ReadLine());
            CenturyConvert CC = new CenturyConvert();
            CC.CenturyConvertPrint(centuries);
            return 0;
        }
    }
}

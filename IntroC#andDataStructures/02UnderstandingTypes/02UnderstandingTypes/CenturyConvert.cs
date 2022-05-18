namespace UnderstandingTypes
{
    public class CenturyConvert
    {
        public void CenturyConvertPrint(sbyte centuries)
        {
            ushort years = (ushort)(centuries * 100);
            uint days = (uint)(years * 365.2425);
            uint hours = days * 24;
            ulong minutes = (ulong)(hours * 60);
            ulong seconds = (minutes * 60);
            ulong milliseconds = (seconds * 1000);
            ulong microseconds = milliseconds * 1000;
            ulong nanosecond = microseconds * 1000;
            Console.WriteLine($"{centuries} centuries = {years} years = {days} days = {hours} hours = {minutes} minutes = {seconds} seconds = {milliseconds} milliseconds = {microseconds} microseconds = {nanosecond} nanoseconds");
        }
    }
}
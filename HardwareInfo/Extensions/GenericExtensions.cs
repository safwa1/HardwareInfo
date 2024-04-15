namespace HardwareInfo.Extensions;

public static class GenericExtensions
{
    public static void Dump<T>(this T value) => Console.WriteLine(value);
    public static void Dump<T>(this T value, string label) => Console.WriteLine($"{label}: {value}");
}
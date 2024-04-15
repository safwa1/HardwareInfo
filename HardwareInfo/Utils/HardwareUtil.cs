using HardwareInfo.Extensions;
using HardwareInfo.Types;

namespace HardwareInfo.Utils;

public static class HardwareUtil
{
    private static string FilteredCommand(string command, string filter)
        => $"{command} | findstr /v /r \"^$ {filter}\"";
    
    public static string GetBaseBoardPropertyValue(BaseBoard baseBoard)
    {
        var property = baseBoard.GetText();
        return CommandLine
            .Execute(FilteredCommand($"wmic baseboard get {property}", property))
            .Trim();
    }
    
    public static string GetCpuPropertyValue(Cpu cpu)
    {
        var property = cpu.GetText();
        return CommandLine
            .Execute(FilteredCommand($"wmic cpu get {property}", property))
            .Trim();
    }
    
    public static string GetDiskdrivePropertyValue(Diskdrive diskDrive, int index = 0)
    {
        var property = diskDrive.GetText();
        return CommandLine
            .Execute(FilteredCommand($"wmic diskdrive {index} get {property}", property))
            .Trim();
    }
    
    public static string GetBiosPropertyValue(Bios bios)
    {
        var property = bios.GetText();
        return CommandLine
            .Execute(FilteredCommand($"wmic bios get {property}", property))
            .Trim();
    }
    
    public static string GetOsPropertyValue(Os os)
    {
        var property = os.GetText();
        return CommandLine
            .Execute(FilteredCommand($"wmic os get {property}", property))
            .Trim();
    }

    public static string GetMemoryPropertyValue(MemoryChip memoryChip)
    {
        var property = memoryChip.GetText();
        return CommandLine
            .Execute(FilteredCommand($"wmic memorychip get {property}", property))
            .Trim();
    }
}



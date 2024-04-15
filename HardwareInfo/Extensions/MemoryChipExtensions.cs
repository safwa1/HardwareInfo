using HardwareInfo.Types;

namespace HardwareInfo.Extensions;

public static class MemoryChipExtensions
{
    public static string GetText(this MemoryChip memoryChip) => memoryChip switch
    {
        MemoryChip.Attributes => "Attributes",
        MemoryChip.BankLabel => "BankLabel",
        MemoryChip.Capacity => "Capacity",
        MemoryChip.Caption => "Caption",
        MemoryChip.ConfiguredClockSpeed => "ConfiguredClockSpeed",
        MemoryChip.ConfiguredVoltage => "ConfiguredVoltage",
        MemoryChip.CreationClassName => "CreationClassName",
        MemoryChip.DataWidth => "DataWidth",
        MemoryChip.Description => "Description",
        MemoryChip.DeviceLocator => "DeviceLocator",
        MemoryChip.FormFactor => "FormFactor",
        MemoryChip.HotSwappable => "HotSwappable",
        MemoryChip.InstallDate => "InstallDate",
        MemoryChip.InterleaveDataDepth => "InterleaveDataDepth",
        MemoryChip.InterleavePosition => "InterleavePosition",
        MemoryChip.Manufacturer => "Manufacturer",
        MemoryChip.MaxVoltage => "MaxVoltage",
        MemoryChip.MemoryType => "MemoryType",
        MemoryChip.MinVoltage => "MinVoltage",
        MemoryChip.Model => "Model",
        MemoryChip.Name => "Name",
        MemoryChip.OtherIdentifyingInfo => "OtherIdentifyingInfo",
        MemoryChip.PartNumber => "PartNumber",
        MemoryChip.PositionInRow => "PositionInRow",
        MemoryChip.PoweredOn => "PoweredOn",
        MemoryChip.Removable => "Removable",
        MemoryChip.Replaceable => "Replaceable",
        MemoryChip.SerialNumber => "SerialNumber",
        MemoryChip.SKU => "SKU",
        MemoryChip.SMBIOSMemoryType => "SMBIOSMemoryType",
        MemoryChip.Speed => "Speed",
        MemoryChip.Status => "Status",
        MemoryChip.Tag => "Tag",
        MemoryChip.TotalWidth => "TotalWidth",
        MemoryChip.TypeDetail => "TypeDetail",
        MemoryChip.Version => "Version",
        _ => throw new ArgumentOutOfRangeException(nameof(memoryChip), memoryChip, null)
    };
}
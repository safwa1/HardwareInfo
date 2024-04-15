using HardwareInfo.Types;

namespace HardwareInfo.Extensions;

public static class CpuExtensions
{
    public static string GetText(this Cpu cpu) => cpu switch
    {
        Cpu.AddressWidth => "AddressWidth",
        Cpu.Architecture => "Architecture",
        Cpu.AssetTag => "AssetTag",
        Cpu.Availability => "Availability",
        Cpu.Caption => "Caption",
        Cpu.Characteristics => "Characteristics",
        Cpu.ConfigManagerErrorCode => "ConfigManagerErrorCode",
        Cpu.ConfigManagerUserConfig => "ConfigManagerUserConfig",
        Cpu.CpuStatus => "CpuStatus",
        Cpu.CreationClassName => "CreationClassName",
        Cpu.CurrentClockSpeed => "CurrentClockSpeed",
        Cpu.CurrentVoltage => "CurrentVoltage",
        Cpu.DataWidth => "DataWidth",
        Cpu.Description => "Description",
        Cpu.DeviceID => "DeviceID",
        Cpu.ErrorCleared => "ErrorCleared",
        Cpu.ErrorDescription => "ErrorDescription",
        Cpu.ExtClock => "ExtClock",
        Cpu.Family => "Family",
        Cpu.InstallDate => "InstallDate",
        Cpu.L2CacheSize => "L2CacheSize",
        Cpu.L2CacheSpeed => "L2CacheSpeed",
        Cpu.L3CacheSize => "L3CacheSize",
        Cpu.L3CacheSpeed => "L3CacheSpeed",
        Cpu.LastErrorCode => "LastErrorCode",
        Cpu.Level => "Level",
        Cpu.LoadPercentage => "LoadPercentage",
        Cpu.Manufacturer => "Manufacturer",
        Cpu.MaxClockSpeed => "MaxClockSpeed",
        Cpu.Name => "Name",
        Cpu.NumberOfCores => "NumberOfCores",
        Cpu.NumberOfEnabledCore => "NumberOfEnabledCore",
        Cpu.NumberOfLogicalProcessors => "NumberOfLogicalProcessors",
        Cpu.OtherFamilyDescription => "OtherFamilyDescription",
        Cpu.PartNumber => "PartNumber",
        Cpu.PNPDeviceID => "PNPDeviceID",
        Cpu.PowerManagementCapabilities => "PowerManagementCapabilities",
        Cpu.PowerManagementSupported => "PowerManagementSupported",
        Cpu.ProcessorId => "ProcessorId",
        Cpu.ProcessorType => "ProcessorType",
        Cpu.Revision => "Revision",
        Cpu.Role => "Role",
        Cpu.SecondLevelAddressTranslationExtensions => "SecondLevelAddressTranslationExtensions",
        Cpu.SerialNumber => "SerialNumber",
        Cpu.SocketDesignation => "SocketDesignation",
        Cpu.Status => "Status",
        Cpu.StatusInfo => "StatusInfo",
        Cpu.Stepping => "Stepping",
        Cpu.SystemCreationClassName => "SystemCreationClassName",
        Cpu.SystemName => "SystemName",
        Cpu.ThreadCount => "ThreadCount",
        Cpu.UniqueId => "UniqueId",
        Cpu.UpgradeMethod => "UpgradeMethod",
        Cpu.Version => "Version",
        Cpu.VirtualizationFirmwareEnabled => "VirtualizationFirmwareEnabled",
        Cpu.VMMonitorModeExtensions => "VMMonitorModeExtensions",
        Cpu.VoltageCaps => "VoltageCaps",
        _ => throw new ArgumentOutOfRangeException(nameof(cpu), cpu, null)
    };
}
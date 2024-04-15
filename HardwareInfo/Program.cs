using HardwareInfo.Extensions;
using HardwareInfo.Types;
using HardwareInfo.Utils;

// get bios serial number
HardwareUtil.GetBiosPropertyValue(Bios.SerialNumber).Dump("Bios Serial Number");

// get board serial number
HardwareUtil.GetBaseBoardPropertyValue(BaseBoard.SerialNumber).Dump("BaseBoard Serial Number");

// get some disk drive info
HardwareUtil.GetDiskdrivePropertyValue(Diskdrive.SerialNumber).Dump("Diskdrive Serial Number");
HardwareUtil.GetDiskdrivePropertyValue(Diskdrive.Model).Dump("Diskdrive Model");

// get some os info
HardwareUtil.GetOsPropertyValue(Os.Name).Dump("OS Name");
HardwareUtil.GetOsPropertyValue(Os.BuildNumber).Dump("OS Build Number");
HardwareUtil.GetOsPropertyValue(Os.Version).Dump("OS Version");

// get memory info
HardwareUtil.GetMemoryPropertyValue(MemoryChip.SerialNumber).Dump("Memory Serial Number");




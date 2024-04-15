# HardwareInfo Console Application 

# HardwareInfo Utils

This utility class provides methods to retrieve hardware information using `wmic` commands.

## Usage

```csharp
// Example usage to get baseboard information
var baseBoardInfo = HardwareUtil.GetBaseBoardPropertyValue(BaseBoard.SerialNumber);
Console.WriteLine($"Baseboard Serial Number: {baseBoardInfo}");
```

![image](https://github.com/safwa1/HardwareInfo/assets/81883530/4c0aaadf-45c5-4df7-8354-0f96641b738e)


## Methods

### `GetBaseBoardPropertyValue(BaseBoard baseBoard)`

Returns the value of the specified baseboard property.

### `GetCpuPropertyValue(Cpu cpu)`

Returns the value of the specified CPU property.

### `GetDiskdrivePropertyValue(Diskdrive diskDrive, int index = 0)`

Returns the value of the specified disk drive property for the given index.

### `GetBiosPropertyValue(Bios bios)`

Returns the value of the specified BIOS property.

### `GetOsPropertyValue(Os os)`

Returns the value of the specified OS property.

### `GetMemoryPropertyValue(MemoryChip memoryChip)`

Returns the value of the specified memory chip property.

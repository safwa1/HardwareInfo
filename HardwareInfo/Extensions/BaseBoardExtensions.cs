using HardwareInfo.Types;

namespace HardwareInfo.Extensions;

public static class BaseBoardExtensions
{
    public static string GetText(this BaseBoard value)
    {
        return value switch
        {
            BaseBoard.Caption => "Caption",
            BaseBoard.ConfigOptions => "ConfigOptions",
            BaseBoard.CreationClassName => "CreationClassName",
            BaseBoard.Depth => "Depth",
            BaseBoard.Description => "Description",
            BaseBoard.Height => "Height",
            BaseBoard.HostingBoard => "HostingBoard",
            BaseBoard.HotSwappable => "HotSwappable",
            BaseBoard.InstallDate => "InstallDate",
            BaseBoard.Manufacturer => "Manufacturer",
            BaseBoard.Model => "Model",
            BaseBoard.Name => "Name",
            BaseBoard.OtherIdentifyingInfo => "OtherIdentifyingInfo",
            BaseBoard.PartNumber => "PartNumber",
            BaseBoard.PoweredOn => "PoweredOn",
            BaseBoard.Product => "Product",
            BaseBoard.Removable => "Removable",
            BaseBoard.Replaceable => "Replaceable",
            BaseBoard.RequirementsDescription => "RequirementsDescription",
            BaseBoard.RequiresDaughterBoard => "RequiresDaughterBoard",
            BaseBoard.SerialNumber => "SerialNumber",
            BaseBoard.SKU => "SKU",
            BaseBoard.SlotLayout => "SlotLayout",
            BaseBoard.SpecialRequirements => "SpecialRequirements",
            BaseBoard.Status => "Status",
            BaseBoard.Tag => "Tag",
            BaseBoard.Version => "Version",
            BaseBoard.Weight => "Weight",
            BaseBoard.Width => "Width",
            _ => throw new ArgumentOutOfRangeException(nameof(value), value, null)
        };
    }
}
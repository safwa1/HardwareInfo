using HardwareInfo.Types;

namespace HardwareInfo.Extensions;

public static class BiosExtensions
{
    public static string GetText(this Bios bios) => bios switch
    {
        Bios.BiosCharacteristics => "BiosCharacteristics",
        Bios.BIOSVersion => "BIOSVersion",
        Bios.BuildNumber => "BuildNumber",
        Bios.Caption => "Caption",
        Bios.CodeSet => "CodeSet",
        Bios.CurrentLanguage => "CurrentLanguage",
        Bios.Description => "Description",
        Bios.EmbeddedControllerMajorVersion => "EmbeddedControllerMajorVersion",
        Bios.EmbeddedControllerMinorVersion => "EmbeddedControllerMinorVersion",
        Bios.IdentificationCode => "IdentificationCode",
        Bios.InstallableLanguages => "InstallableLanguages",
        Bios.InstallDate => "InstallDate",
        Bios.LanguageEdition => "LanguageEdition",
        Bios.ListOfLanguages => "ListOfLanguages",
        Bios.Manufacturer => "Manufacturer",
        Bios.Name => "Name",
        Bios.OtherTargetOS => "OtherTargetOS",
        Bios.PrimaryBIOS => "PrimaryBIOS",
        Bios.ReleaseDate => "ReleaseDate",
        Bios.SerialNumber => "SerialNumber",
        Bios.SMBIOSBIOSVersion => "SMBIOSBIOSVersion",
        Bios.SMBIOSMajorVersion => "SMBIOSMajorVersion",
        Bios.SMBIOSMinorVersion => "SMBIOSMinorVersion",
        Bios.SMBIOSPresent => "SMBIOSPresent",
        Bios.SoftwareElementID => "SoftwareElementID",
        Bios.SoftwareElementState => "SoftwareElementState",
        Bios.Status => "Status",
        Bios.SystemBiosMajorVersion => "SystemBiosMajorVersion",
        Bios.SystemBiosMinorVersion => "SystemBiosMinorVersion",
        Bios.TargetOperatingSystem => "TargetOperatingSystem",
        Bios.Version => "Version",
        _ => throw new ArgumentOutOfRangeException(nameof(bios), bios, null)
    };
}
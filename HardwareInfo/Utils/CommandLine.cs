using System.Diagnostics;
namespace HardwareInfo.Utils;

public static class CommandLine
{
    private static readonly Process Process = new();

    public static string Run(string app, string commands)
    {
        Process.StartInfo.FileName = app;
        Process.StartInfo.Arguments = "/c " + commands;
        Process.StartInfo.CreateNoWindow = true;
        Process.StartInfo.UseShellExecute = false;
        Process.StartInfo.RedirectStandardOutput = true;
        Process.Start();
        Process.WaitForExit();

        return Process.StandardOutput.ReadToEnd();
    }

    public static string Execute(string commands) => Run("cmd.exe", commands);
        
    public static string Powershell(string commands) => Run("powershell.exe", commands);

    public static void Kill() => Process.Kill();
}
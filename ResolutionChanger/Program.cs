using System.Diagnostics;

class C_Main
{
    public static void Main(string[] args)
    {
        while (true)
        {
           string process = "notepad";
           string command = "nircmd.exe setdisplay 1280 720 32";
           string original = "nircmd.exe setdisplay 1920 1080 32";

           if (IsProcessRunning(process))
           {
               Console.WriteLine($"'{process}' is currently running.");
               Process.Start("cmd.exe", $"/C {command}");
           }
           else
           {
               Console.WriteLine($"'{process}' is not running.");
               Process.Start("cmd.exe", $"/C {original}");
           }
           Thread.Sleep(1000); // Check every second
        }
    }

    private static bool IsProcessRunning(string processName)
    {
        // Get all running processes
        Process[] processes = Process.GetProcessesByName(processName);
        return processes.Length > 0; // Return true if any processes are found
    }
}
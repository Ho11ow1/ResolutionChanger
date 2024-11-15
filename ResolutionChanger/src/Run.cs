using System.Diagnostics;

class C_Run
{
    private readonly C_GetResolution get_res = new C_GetResolution();
    private readonly C_ChangeResolution set_res = new C_ChangeResolution();

    public void Run()
    {
        while (true)
        {
            if (IsProcessRunning(Constants.Constant.process))
            {
                Console.WriteLine($"'{Constants.Constant.process}' is currently running.");
                if (get_res.IsScreenResolution(Constants.Constant.DES_WIDTH, Constants.Constant.DES_HEIGHT))
                {
                    Thread.Sleep(Constants.Constant.SLEEP_S);
                    continue;
                }

                if (set_res.SetResolution(Constants.Constant.DES_WIDTH, Constants.Constant.DES_HEIGHT))
                {
                    Console.WriteLine($"Resolution changed to {Constants.Constant.DES_WIDTH}X{Constants.Constant.DES_HEIGHT} successfully.");
                }
                else
                {
                    Console.WriteLine("Failed to change resolution.");
                }
            }
            else
            {
                Console.WriteLine($"'{Constants.Constant.process}' is not running.");

                if (get_res.IsScreenResolution(Constants.Constant.MAX_WIDTH, Constants.Constant.MAX_HEIGHT))
                {
                    Thread.Sleep(Constants.Constant.SLEEP_S);
                    continue;
                }

                if (set_res.SetResolution(Constants.Constant.MAX_WIDTH, Constants.Constant.MAX_HEIGHT))
                {
                    Console.WriteLine($"Resolution changed to {Constants.Constant.MAX_WIDTH}X{Constants.Constant.MAX_HEIGHT} successfully.");
                }
                else
                {
                    Console.WriteLine("Failed to change resolution.");
                }
            }
            Thread.Sleep(Constants.Constant.SLEEP);
        }
    }

    private static bool IsProcessRunning(string processName)
    {
        // Get all running processes
        Process[] processes = Process.GetProcessesByName(processName);
        return processes.Length > 0; // Return true if any processes are found
    }
}
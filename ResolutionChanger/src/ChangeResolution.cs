using System;
using System.Runtime.InteropServices;

class C_ChangeResolution
{
    [DllImport("user32.dll")]
    private static extern int ChangeDisplaySettings(ref DEVMODE devMode, int flags);

    private const int DM_PELSWIDTH = 0x80000;
    private const int DM_PELSHEIGHT = 0x100000;
    private const int DM_BITSPERPEL = 0x40000;
    private const int DM_DISPLAYFREQUENCY = 0x400000;

    private const int CDS_UPDATEREGISTRY = 0x01;
    private const int DISP_CHANGE_SUCCESSFUL = 0;
    private const int DISP_CHANGE_BADMODE = -2;

    public bool SetResolution(int width, int height, uint bitsPerPel = 32, uint frequency = 60)
    {
        DEVMODE dm = new DEVMODE();
        dm.dmSize = (ushort)Marshal.SizeOf(typeof(DEVMODE));

        dm.dmFields = DM_PELSWIDTH | DM_PELSHEIGHT | DM_BITSPERPEL | DM_DISPLAYFREQUENCY;
        dm.dmPelsWidth = (uint)width;
        dm.dmPelsHeight = (uint)height;
        dm.dmBitsPerPel = bitsPerPel;
        dm.dmDisplayFrequency = frequency;

        int result = ChangeDisplaySettings(ref dm, CDS_UPDATEREGISTRY);

        switch (result)
        {
            case DISP_CHANGE_SUCCESSFUL:
                Console.WriteLine("Resolution change successful.");
                return true;

            case DISP_CHANGE_BADMODE:
                Console.WriteLine("The resolution, color depth, or refresh rate is not supported.");
                return false;

            default:
                Console.WriteLine($"Failed to change resolution. Error code: {result}");
                return false;
        }
    }
}
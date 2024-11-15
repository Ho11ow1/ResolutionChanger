using System.Runtime.InteropServices;

class C_GetResolution
{
    [DllImport("user32.dll")]
    private static extern int GetSystemMetrics(int nIndex);
    private const int SM_CXSCREEN = 0; // Width of the screen
    private const int SM_CYSCREEN = 1; // Height of the screen

    //private static int screenWidth = GetSystemMetrics(SM_CXSCREEN); // DEBUG OPTION
    //private static int screenHeight = GetSystemMetrics(SM_CYSCREEN); // DEBUG OPTION

    public bool IsScreenResolution(int width, int height)
    {
        return GetSystemMetrics(SM_CXSCREEN) == width && GetSystemMetrics(SM_CYSCREEN) == height;
    }
}
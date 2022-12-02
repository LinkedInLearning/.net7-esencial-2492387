using System.Runtime.InteropServices;

namespace COMInterop;

public partial class Form1 : Form
{
    public Form1()
    {
        InitializeComponent();
    }

    protected override void OnLoad(EventArgs e)
    {
        base.OnLoad(e);

        WindowHelper.RemoveSystemMenuFromWindow(this.Handle);
    }
}

public static class WindowHelper
{
    private const int MF_BYPOSITION = 0x400;

    [DllImport("User32")]
    private static extern nint GetSystemMenu(nint hWnd, bool bRevert);

    [DllImport("User32")]
    private static extern int GetMenuItemCount(nint hWnd);

    [DllImport("User32")]
    private static extern int RemoveMenu(nint hMenu, int nPosition, int wFlags);

    public static void RemoveSystemMenuFromWindow(nint handle)
    {
        nint hMenu = GetSystemMenu(handle, false);
        int num_menu_items = GetMenuItemCount(hMenu);
        for (int i = num_menu_items; i >= 0; i--)
        {
            RemoveMenu(hMenu, i, MF_BYPOSITION);
        }
    }
}
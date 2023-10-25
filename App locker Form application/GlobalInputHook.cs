using System;
using System.Collections.Generic;
using System.Text;
using System.Windows.Forms;
using System.Runtime.InteropServices;
using System.Diagnostics;

namespace App_locker_Form_application
{
    /*public class GlobalInputHook
    {
        private const int WH_MOUSE_LL = 14;
        private const int WH_KEYBOARD_LL = 13;
        private const int WH_MOUSEMOVE = 0*0200;
        private const int WH_KEYDOWN = 0*0100;

        private delegate IntPtr HookDelegate(int nCode, IntPtr wParam, IntPtr iParam);
        private static HookDelegate mouseDelegate;
        private static HookDelegate keyboardDelegate;
        private static IntPtr mouseHookID = IntPtr.Zero;
        private static IntPtr keyboardHookID = IntPtr.Zero;

        [DllImport("user32.dll", CharSet = CharSet.Auto, SetLastError = true)]
        private static extern IntPtr SetWindowsHookEx(int idHook, HookDelegate ipfn, IntPtr hMod, uint dwThreadId);
        [DllImport("user32.dll", CharSet = CharSet.Auto, SetLastError = true)]
        private static extern bool UnhookWindowsHookEx(IntPtr hhk);
        [DllImport("user32.dll", CharSet = CharSet.Auto, SetLastError = true)]
        private static extern IntPtr CallNextHookEx(IntPtr hhk, int nCode, IntPtr wParam, IntPtr iParam);

        public static event EventHandler<MouseEventArgs> MouseMove;
        public static event EventHandler<KeyEventHandler> KeyDown;

        public static void Hook()
        {
            mouseDelegate = MouseHookProc;
            mouseHookID = SetHook(WH_MOUSE_LL, mouseDelegate);

            keyboardDelegate = KeyboardHookProc;
            keyboardHookID = SetHook(WH_KEYBOARD_LL, keyboardDelegate);
        }

        public static void Unhook()
        {
            UnhookWindowsHookEx(mouseHookID);
            UnhookWindowsHookEx(keyboardHookID);
        }

        private static IntPtr SetHook(int hookType, HookDelegate hookDelegate)
        {
           using (Process curProcess = Process.GetCurrentProcess())
           using(ProcessModule curModule = curProcess.MainModule)
            {
                return SetWindowsHookEx(hookType, hookDelegate, GetModuleHandle(curModule.ModuleName), 0);
            }
        }

        private static IntPtr GetModuleHandle(string moduleName)
        {
            throw new NotImplementedException();
        }

        private static IntPtr MouseHookProc(int nCode, IntPtr wParam, IntPtr iParam)
        {
            if(nCode >= 0 && wParam == (IntPtr)WH_MOUSEMOVE)
            {
                MSLLHOOKSTRUCT mouseData = (MSLLHOOKSTRUCT)Marshal.PtrToStructure(iParam, typeof(MSLLHOOKSTRUCT));
                MouseMove?.Invoke(null, new MouseEventArgs(MouseButtons.None, 0, mouseData.pt.x, mouseData.pt.y, 0));
            }
            return CallNextHookEx(mouseHookID, nCode, wParam, iParam);
        }

        private static IntPtr KeyboardHookProc(int nCode, IntPtr wParam, IntPtr iParam)
        {
            if (nCode >= 0 && wParam == (IntPtr)WH_KEYDOWN)
            {
                KBDLLHOOKSTRUCT keyboardData = (KBDLLHOOKSTRUCT)Marshal.PtrToStructure(iParam, typeof(KBDLLHOOKSTRUCT));
                KeyDown?.Invoke(null, new KeyEventArgs((Keys)keyboardData.vkCode));
            }
            return CallNextHookEx(keyboardHookID, nCode, wParam, iParam);
        }

        [StructLayout(LayoutKind.Sequential)]
        private struct MSLLHOOKSTRUCT
        {
            public POINT pt;
            public uint mouseData;
            public uint flags;
            public uint time;
            public IntPtr dwExtraInfo;
        }

        [StructLayout(LayoutKind.Sequential)]
        private struct KBDLLHOOKSTRUCT
        {
            public uint vkCode;
            public uint scanCode;
            public uint flags;
            public uint time;
            public IntPtr dwExtraInfo;
        }

        [StructLayout(LayoutKind.Sequential)]
        private struct POINT
        {
            public int x;
            public int y;
        }
    }*/
}
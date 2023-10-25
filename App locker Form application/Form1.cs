using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.Diagnostics;
using System.Runtime.InteropServices;

namespace App_locker_Form_application
{
    public partial class Form1 : Form
    {
        private const int WH_MOUSE_LL = 14;
        private const int WH_KEYBOARD_LL = 13;
        private const int WH_MOUSEMOVE = 0 * 0200;
        private const int WH_KEYDOWN = 0 * 0100;

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
            using (ProcessModule curModule = curProcess.MainModule)
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
            if (nCode >= 0 && wParam == (IntPtr)WH_MOUSEMOVE)
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
        public Form1()
        {
            InitializeComponent();
        }
        SqlConnection conn = new SqlConnection(@"Data Source=DESKTOP-FEMUI2B;Initial Catalog=App Locker;Integrated Security=True");

        internal SqlConnection Conn { get => conn; set => conn = value; }

        private void label1_Click(object sender, EventArgs e)
        {

        }


        private void button_login_Click(object sender, EventArgs e)
        {
           
        }

     

        private void button_next_Click(object sender, EventArgs e)
        {
            Registerer r2 = new Registerer();
            r2.Show();
            Visible = false;

        }

        private void button_contact_Click(object sender, EventArgs e)
        {
            contact C2 = new contact();
            C2.Show();
            Visible = false;
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void browse_Click(object sender, EventArgs e)
        {
            FolderBrowserDialog diag = new FolderBrowserDialog();
            if(diag.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {
                location.Text = diag.SelectedPath;
            }
            else
            {
                location.Text = "";
            }
        }
    }
}

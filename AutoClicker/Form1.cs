using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AutoClicker
{
    public partial class Form1 : Form
    {
        private const int WH_KEYBOARD_LL = 13;
        private LowLevelKeyboardProcDelegate m_callback;
        private IntPtr m_hHook;

        [DllImport("user32.dll", SetLastError = true)]
        private static extern IntPtr SetWindowsHookEx(int idHook, LowLevelKeyboardProcDelegate lpfn, IntPtr hMod, int dwThreadId);

        [DllImport("user32.dll", SetLastError = true)]
        private static extern bool UnhookWindowsHookEx(IntPtr hhk);

        [DllImport("Kernel32.dll", SetLastError = true)]
        private static extern IntPtr GetModuleHandle(IntPtr lpModuleName);

        [DllImport("user32.dll", SetLastError = true)]
        private static extern IntPtr CallNextHookEx(IntPtr hhk, int nCode, IntPtr wParam, IntPtr lParam);

        private IntPtr LowLevelKeyboardHookProc(int nCode, IntPtr wParam, IntPtr lParam)
        {
            if (nCode >= 0)
            {
                var khs = (KeyboardHookStruct)
                          Marshal.PtrToStructure(lParam,
                          typeof(KeyboardHookStruct));
                if (Convert.ToInt32("" + wParam) == 256)
                {
                    if ((int)khs.VirtualKeyCode == 114) // F3
                    {
                        buttonStop.PerformClick();
                        WindowState = FormWindowState.Normal;
                    }
                    if ((int)khs.VirtualKeyCode == 113) // F2
                    {
                        buttonStart.PerformClick();
                        WindowState = FormWindowState.Normal;
                    }
                    if ((int)khs.VirtualKeyCode == 115) // F4
                    {
                        buttonPickLoc.PerformClick();
                        WindowState = FormWindowState.Normal;
                    }
                }
            }
            return CallNextHookEx(m_hHook, nCode, wParam, lParam);
        }
        [StructLayout(LayoutKind.Sequential)]
        private struct KeyboardHookStruct
        {
            public readonly int VirtualKeyCode;
            public readonly int ScanCode;
            public readonly int Flags;
            public readonly int Time;
            public readonly IntPtr ExtraInfo;
        }
        private delegate IntPtr LowLevelKeyboardProcDelegate(
            int nCode, IntPtr wParam, IntPtr lParam);

        public void SetHook()
        {
            m_callback = LowLevelKeyboardHookProc;
            m_hHook = SetWindowsHookEx(WH_KEYBOARD_LL,
                m_callback,
                GetModuleHandle(IntPtr.Zero), 0);
        }
        public void Unhook()
        {
            UnhookWindowsHookEx(m_hHook);
        }

        // хуки для мыши
        [DllImport("user32.dll", CharSet = CharSet.Auto, CallingConvention = CallingConvention.StdCall)]
        public static extern void mouse_event(uint dwFlags, int dx, int dy, int dwData, int dwExtraInfo);

        // нормированные абсолютные координаты
        private const int MOUSEEVENTF_ABSOLUTE = 0x8000;
        // нажатие на левую кнопку мыши
        private const int MOUSEEVENTF_LEFTDOWN = 0x0002;
        // поднятие левой кнопки мыши
        private const int MOUSEEVENTF_LEFTUP = 0x0004;
        // нажатие на правую кнопку мыши
        private const int MOUSEEVENTF_RIGHTDOWN = 0x0008;
        // поднятие правой кнопки мыши
        private const int MOUSEEVENTF_RIGHTUP = 0x0010;
        // перемещение указателя мыши
        private const int MOUSEEVENTF_MOVE = 0x0001;

        // для определения позиции курсора
        [DllImport("user32.dll")]
        static extern bool GetCursorPos(ref Point lpPoint);
        static protected long totalPixels = 0;
        static protected int diffX;
        static protected int diffY;
        
        public Form1()
        {
            InitializeComponent();
            SetHook();
            this.Focus();
        }

        static public bool IsStart = false;

        private void label1_Click(object sender, EventArgs e)
        {

        }

        // кнопка сворачивания
        private void turnPicture_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void radioButtonDoubleClick_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void radioButtonOneClick_CheckedChanged(object sender, EventArgs e)
        {

        }

        // кнопка закрыть 
        private void closePicture_Click(object sender, EventArgs e) 
        {
            this.Close();
        }

        Point lastPoint;
        private void TopPanel_MouseMove(object sender, MouseEventArgs e)
        {
            if(e.Button == MouseButtons.Left)
            {
                this.Left += e.X - lastPoint.X;
                this.Top += e.Y - lastPoint.Y;
            }
        }

        private void TopPanel_MouseDown(object sender, MouseEventArgs e)
        {
            lastPoint = new Point(e.X, e.Y);
        }
       
        private void buttonStop_Click(object sender, EventArgs e)
        {
            IsStart = false;           
        }

        private void textBoxForMins_KeyPress(object sender, KeyPressEventArgs e)
        {
            char number = e.KeyChar;

            if (!char.IsDigit(number))
            {
                e.Handled = true;
            }
        }

        // функция определения позиции курсора 
        private void buttonPickLoc_Click(object sender, EventArgs e)
        {
            Point defPnt = new Point();
            GetCursorPos(ref defPnt);
            textBoxForX.Text = defPnt.X.ToString();
            textBoxForY.Text = defPnt.Y.ToString();
        }

        async private void buttonStart_Click(object sender, EventArgs e)
        {
            IsStart = true;
            Size resolution = Screen.PrimaryScreen.Bounds.Size;
            int X = 65535 / resolution.Width * Convert.ToInt32(textBoxForX.Text);
            int Y = 65535 / resolution.Height * Convert.ToInt32(textBoxForY.Text);

            while (IsStart)
            {
                if (radioButton3.Checked == true && radioButton1.Checked == true)
                {
                    mouse_event(MOUSEEVENTF_ABSOLUTE | MOUSEEVENTF_MOVE, X, Y, 0, 0);
                    //Выполнение первого клика левой клавишей мыши
                    mouse_event(MOUSEEVENTF_ABSOLUTE | MOUSEEVENTF_LEFTDOWN | MOUSEEVENTF_LEFTUP, X, Y, 0, 0);
                }
                if (radioButton4.Checked == true && radioButton1.Checked == true)
                {
                    mouse_event(MOUSEEVENTF_ABSOLUTE | MOUSEEVENTF_MOVE, X, Y, 0, 0);
                    //Выполнение первого клика левой клавишей мыши
                    mouse_event(MOUSEEVENTF_ABSOLUTE | MOUSEEVENTF_LEFTDOWN | MOUSEEVENTF_LEFTUP, X, Y, 0, 0);
                    //Выполнение второго клика левой клавишей мыши
                    mouse_event(MOUSEEVENTF_ABSOLUTE | MOUSEEVENTF_LEFTDOWN | MOUSEEVENTF_LEFTUP, X, Y, 0, 0);
                }
                if (radioButton3.Checked == true && radioButton2.Checked == true)
                {
                    mouse_event(MOUSEEVENTF_ABSOLUTE | MOUSEEVENTF_MOVE, X, Y, 0, 0);
                    //Выполнение первого клика левой клавишей мыши
                    mouse_event(MOUSEEVENTF_ABSOLUTE | MOUSEEVENTF_RIGHTDOWN | MOUSEEVENTF_RIGHTUP, X, Y, 0, 0);
                }
                if (radioButton4.Checked == true && radioButton2.Checked == true)
                {
                    mouse_event(MOUSEEVENTF_ABSOLUTE | MOUSEEVENTF_MOVE, X, Y, 0, 0);
                    //Выполнение первого клика левой клавишей мыши
                    mouse_event(MOUSEEVENTF_ABSOLUTE | MOUSEEVENTF_RIGHTDOWN | MOUSEEVENTF_RIGHTUP, X, Y, 0, 0);
                    //Выполнение второго клика левой клавишей мыши
                    mouse_event(MOUSEEVENTF_ABSOLUTE | MOUSEEVENTF_RIGHTDOWN | MOUSEEVENTF_RIGHTUP, X, Y, 0, 0);
                }
                await Task.Delay(Convert.ToInt32(textBoxForWrite.Text) * 10); 
            }
        }
    }
}

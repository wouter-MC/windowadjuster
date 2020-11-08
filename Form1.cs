using System;
using System.Diagnostics;
using System.Runtime.InteropServices;
using System.Threading;
using System.Windows.Forms;

namespace WindowAdjuster
{
    public partial class Form1 : Form
    {

        private string currentApp;
        private bool autoUpdate;
        private RECT previoursRECT;
        private bool running = true;

        public Form1()
        {
            InitializeComponent();
            this.FormClosing += Form1_FormClosing;

            ReloadApplicationList();
            StartAutoUpdateThread();
        }

        //#############################
        //# Application Logic methods #
        //#############################

        private void ReloadApplicationList()
        {
            WindowApplicationList.Items.Clear();

            foreach (var app in Process.GetProcesses())
            {
                if (!string.IsNullOrEmpty(app.MainWindowTitle))
                {
                    WindowApplicationList.Items.Add(app.MainWindowTitle);
                }
            }
        }

        private void StartAutoUpdateThread()
        {
            var thread = new Thread(() =>
            {
                while (running)
                {
                    Thread.Sleep(1000);

                    if (autoUpdate)
                    {
                        UpdateCurrentAppLocation();
                    }
                }
            })
            {
                Name = "Auto-update"
            };
            thread.Start();
        }

        private void UpdateCurrentAppLocation()
        {
            IntPtr targetWindow = FindWindowByCaption(IntPtr.Zero, currentApp);

            if (targetWindow == IntPtr.Zero)
            {
                return;
            }


            if (!GetWindowRect(targetWindow, out RECT rct))
            {
                return;
            }

            if (!rct.Equals(previoursRECT))
            {
                SetWindowPos(targetWindow,
                IntPtr.Zero,
                (int)WindowScreenXInput.Value,
                (int)WindowScreenYInput.Value,
                (int)WindowWidthInput.Value,
                (int)WindowHeightInput.Value,
                0);

                previoursRECT = rct;
            }
        }

        private void UpdateInputFields()
        {
            IntPtr targetWindow = FindWindowByCaption(IntPtr.Zero, currentApp);
            if (targetWindow == IntPtr.Zero)
            {
                MessageBox.Show("Could not find a window with title: " + currentApp);
                ReloadApplicationList();
                return;
            }


            if (!GetWindowRect(targetWindow, out RECT rct))
            {
                MessageBox.Show("Could not get inital window size: " + currentApp);
                return;
            }

            WindowScreenXInput.Value = rct.Left;
            WindowScreenYInput.Value = rct.Top;
            WindowWidthInput.Value = rct.Right - rct.Left;
            WindowHeightInput.Value = rct.Bottom - rct.Top;
        }


        //#####################
        //# Form input events #
        //#####################

        //When changing current application check if the list is up-to-date
        //And set original postition and size into input fields
        private void WindowApplicationList_SelectedIndexChanged(object sender, EventArgs e)
        {
            var index = WindowApplicationList.SelectedItem;

            if (index == null)
            {
                return;
            }

            currentApp = index.ToString();

            UpdateInputFields();
        }

        private void WindowWidthInput_ValueChanged(object sender, EventArgs e)
        {
            UpdateCurrentAppLocation();
        }

        private void WindowHeightInput_ValueChanged(object sender, EventArgs e)
        {
            UpdateCurrentAppLocation();
        }

        private void WindowScreenXInput_ValueChanged(object sender, EventArgs e)
        {
            UpdateCurrentAppLocation();
        }

        private void WindowScreenYInput_ValueChanged(object sender, EventArgs e)
        {
            UpdateCurrentAppLocation();
        }


        private void WindowActivationButton_Click(object sender, EventArgs e)
        {
            var state = !autoUpdate;
            autoUpdate = state;

            if (state)
            {
                WindowActivationButton.Text = "Automatic Adjust: Enabled";
            }
            else
            {
                WindowActivationButton.Text = "Automatic Adjust: Disabled";
            }
        }

        private void WindowReloadApplicationsButton_Click(object sender, EventArgs e)
        {
            ReloadApplicationList();
        }

        private void Form1_FormClosing(Object sender, FormClosingEventArgs e)
        {
            running = false;
        }

        //###########################################
        //# A lot of stuff to import from DLL       #
        //# to get the slightest bit of information #
        //# and change window size and/or location  #
        //###########################################

        // Define the FindWindow API function.
        [DllImport("user32.dll", EntryPoint = "FindWindow", SetLastError = true)]
        static extern IntPtr FindWindowByCaption(IntPtr ZeroOnly, string lpWindowName);

        // Define the SetWindowPos API function.
        [DllImport("user32.dll")]
        [return: MarshalAs(UnmanagedType.Bool)]
        static extern bool SetWindowPos(IntPtr hWnd, IntPtr hWndInsertAfter, int X, int Y, int cx, int cy, SetWindowPosFlags uFlags);

        [DllImport("user32.dll", SetLastError = true)]
        static extern bool GetWindowRect(IntPtr hwnd, out RECT lpRect);

        [StructLayout(LayoutKind.Sequential)]
        public struct RECT
        {
            public int Left;        // x position of upper-left corner
            public int Top;         // y position of upper-left corner
            public int Right;       // x position of lower-right corner
            public int Bottom;      // y position of lower-right corner
        }

        // Define the SetWindowPosFlags enumeration.
        [Flags()]
        private enum SetWindowPosFlags : uint
        {
            SynchronousWindowPosition = 0x4000,
            DeferErase = 0x2000,
            DrawFrame = 0x0020,
            FrameChanged = 0x0020,
            HideWindow = 0x0080,
            DoNotActivate = 0x0010,
            DoNotCopyBits = 0x0100,
            IgnoreMove = 0x0002,
            DoNotChangeOwnerZOrder = 0x0200,
            DoNotRedraw = 0x0008,
            DoNotReposition = 0x0200,
            DoNotSendChangingEvent = 0x0400,
            IgnoreResize = 0x0001,
            IgnoreZOrder = 0x0004,
            ShowWindow = 0x0040,
        }
    }
}

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Imaging;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace PRTSC_TO_FILE
{
    public partial class GUI : Form
    {
        //Thanks to:
        //http://stackoverflow.com/questions/15413172/capture-a-keyboard-keypress-in-the-background
        //http://stackoverflow.com/questions/4605727/how-to-export-image-of-my-form-c-sharp
        //http://alanbondo.wordpress.com/2008/06/22/creating-a-system-tray-app-with-c/


        // DLL libraries used to manage hotkeys
        [DllImport("user32.dll")]
        public static extern bool RegisterHotKey(IntPtr hWnd, int id, int fsModifiers, int vlc);
        [DllImport("user32.dll")]
        public static extern bool UnregisterHotKey(IntPtr hWnd, int id);

        //Reference for hotkey in code
        const int MYACTION_HOTKEY_ID = 1;

        private NotifyIcon trayIcon;
        private ContextMenu trayMenu;

        private static int count;
        public string directory = @"C:\Testing\output";

        public GUI()
        {
            
            InitializeComponent();

            RegisterHotKey(this.Handle, MYACTION_HOTKEY_ID, 0, (int)Keys.PrintScreen);

            // Create a simple tray menu with only one item.
            trayMenu = new ContextMenu();
            trayMenu.MenuItems.Add("Exit", OnExit);
            
            // Create a tray icon. In this example we use a
            // standard system icon for simplicity, but you
            // can of course use your own custom icon too.
            trayIcon = new NotifyIcon();
            trayIcon.Text = "MyTrayApp";
            trayIcon.Icon = new Icon(SystemIcons.Application, 40, 40);

            // Add menu to tray icon and show it.
            trayIcon.ContextMenu = trayMenu;
            trayIcon.Visible = true;


        }

        protected override void WndProc(ref Message m)
        {
            if (m.Msg == 0x0312 && m.WParam.ToInt32() == MYACTION_HOTKEY_ID)
            {
                PrintScreen();
                // My hotkey has been typed

                // Do what you want here
                // ...
            }
            base.WndProc(ref m);
        }


        private void PrintScreen()
        {

            Bitmap printscreen = new Bitmap(Screen.PrimaryScreen.Bounds.Width, Screen.PrimaryScreen.Bounds.Height);

            Graphics graphics = Graphics.FromImage(printscreen as Image);

            graphics.CopyFromScreen(0, 0, 0, 0, printscreen.Size);

            printscreen.Save(directory + DateTime.Now.ToString(), ImageFormat.Tiff);

        }

        private void OnShow(object sender, EventArgs e)
        {
            trayMenu.MenuItems.Remove(trayMenu.MenuItems[0]);
            this.Show();
        }

        private void OnExit(object sender, EventArgs e)
        {
            closeCheckBox.Checked = true;
            this.Close();
        }

        private void directoryButton_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void directoryButton_Click(object sender, EventArgs e)
        {
            directory = directoryText.Text;
        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            this.Hide();

            trayMenu.MenuItems.Remove(trayMenu.MenuItems[0]);

            trayMenu.MenuItems.Add("Show", OnShow);
            trayMenu.MenuItems.Add("Exit", OnExit);
            
            if (!closeCheckBox.Checked)
            {
                e.Cancel = true;
            }
            else
            {
                trayIcon.Visible = false;
            }
        }

    }
}

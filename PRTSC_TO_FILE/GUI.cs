﻿using System;
using System.Drawing;
using System.Drawing.Imaging;
using System.IO;
using System.Runtime.InteropServices;
using System.Windows.Forms;
using Microsoft.Win32;


namespace PRTSC_TO_FILE
{
    public partial class GUI : Form
    {
        //Thanks to:
        //http://stackoverflow.com/questions/15413172/capture-a-keyboard-keypress-in-the-background - Global keyboard shortcut
        //http://stackoverflow.com/questions/4605727/how-to-export-image-of-my-form-c-sharp - Print screen
        //http://alanbondo.wordpress.com/2008/06/22/creating-a-system-tray-app-with-c/ - System tray icon
        //http://msdn.microsoft.com/en-us/library/microsoft.win32.registry.aspx - Registry keys

        //Icon credit:
        public static readonly string iconURL = "http://officinadigitale.forumcommunity.net/";

        // DLL libraries used to manage hotkeys
        [DllImport("user32.dll")]
        public static extern bool RegisterHotKey(IntPtr hWnd, int id, int fsModifiers, int vlc);
        [DllImport("user32.dll")]
        public static extern bool UnregisterHotKey(IntPtr hWnd, int id);

        //Reference for hotkey in code
        const int MYACTION_HOTKEY_ID = 1;

        private NotifyIcon trayIcon;
        private ContextMenu trayMenu;

        public static int count = 1;
        public string directory = @"C:\Testing\output\";
        public string outputFile = "";
        public ImageFormat imageFormatPicked = null;

        public static readonly string myURL = "http://www.github.com/Rebant";

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
            trayIcon.Text = "PRTSC_TO_FILE";
            trayIcon.Icon = Properties.Resources.MainIcon;

            // Add menu to tray icon and show it.
            trayIcon.ContextMenu = trayMenu;
            trayIcon.Visible = true;

            //Make .bmp format default
            imageFormatList.SelectedIndex = 0;

            //Make count output default
            outputFormatCombo.SelectedIndex = 0;

            startHiddenCheckBox.Checked = readRegistry();

        }

        protected override void WndProc(ref Message m)
        {
            if (m.Msg == 0x0312 && m.WParam.ToInt32() == MYACTION_HOTKEY_ID)
            {
                PrintScreen();
            }
            base.WndProc(ref m);
        }

        private void PrintScreen()
        {

            Bitmap printscreen = new Bitmap(Screen.PrimaryScreen.Bounds.Width, Screen.PrimaryScreen.Bounds.Height);

            Graphics graphics = Graphics.FromImage(printscreen as Image);

            graphics.CopyFromScreen(0, 0, 0, 0, printscreen.Size);

            if (!Directory.Exists(directory))
            {
                Directory.CreateDirectory(directory);
            }

            if (File.Exists(outputExampleTextField.Text))
            {
                if (!(MessageBox.Show("File Exists... Replace?", "File Exists", MessageBoxButtons.YesNo) == DialogResult.Yes))
                {
                    return;
                }
            }
            

            printscreen.Save(outputExampleTextField.Text, imageFormatPicked);

            if (outputFormatCombo.Text == "Number")
            {
                countTextBox.Text = (++count).ToString();
            }
            
            outputFormatCombo_SelectedIndexChanged(null, null);

        }

        private void OnShow(object sender, EventArgs e)
        {
            Visible = true;
            ShowInTaskbar = true;
            trayMenu.MenuItems.Remove(trayMenu.MenuItems[0]);
            this.Show();
        }

        private void OnExit(object sender, EventArgs e)
        {
            closeCheckBox.Checked = true;
            this.Close();
        }
        
        private void directoryButton_Click(object sender, EventArgs e)
        {
            directory = directoryText.Text;
            outputFormatCombo_SelectedIndexChanged(null, null);
        }

        private void GUI_FormClosing(object sender, FormClosingEventArgs e)
        {
            this.Hide();

            trayMenu.MenuItems.Remove(trayMenu.MenuItems[0]);

            trayMenu.MenuItems.Add("Show", OnShow);
            trayMenu.MenuItems.Add("Exit", OnExit);

            if (sender is String)
            {
                return;
            }

            if (!closeCheckBox.Checked)
            {
                e.Cancel = true;
            }
            else
            {
                trayIcon.Visible = false;
            }
        }

        private void outputFormatCombo_SelectedIndexChanged(object sender, EventArgs e)
        {
            //Format selection
            imageFormatPicked = null;

            switch (imageFormatList.SelectedItem.ToString())
            {

                case "Bmp":
                    imageFormatPicked = ImageFormat.Bmp;
                    break;

                case "Emf":
                    imageFormatPicked = ImageFormat.Emf;
                    break;

                case "Exif":
                    imageFormatPicked = ImageFormat.Exif;
                    break;

                case "Gif":
                    imageFormatPicked = ImageFormat.Gif;
                    break;

                case "Icon":
                    imageFormatPicked = ImageFormat.Icon;
                    break;

                case "Jpeg":
                    imageFormatPicked = ImageFormat.Jpeg;
                    break;

                case "MemoryBmp":
                    imageFormatPicked = ImageFormat.MemoryBmp;
                    break;

                case "Png":
                    imageFormatPicked = ImageFormat.Png;
                    break;

                case "Tiff":
                    imageFormatPicked = ImageFormat.Tiff;
                    break;

                case "Wmf":
                    imageFormatPicked = ImageFormat.Wmf;
                    break;

            }

            //Output format selection
            string directoryToOutput = directory + (directory.EndsWith("\\") ? "" : "\\");

            if (outputFormatCombo.SelectedItem == null)
            {
                return;
            }

            switch (outputFormatCombo.SelectedItem.ToString())
            {
                case "Number":
                    directoryToOutput += count;
                    break;

                case "Date/Time":
                    directoryToOutput += "M" + DateTime.Now.Month + "D" + DateTime.Now.Day + "Y" + DateTime.Now.Year + "H" + DateTime.Now.Hour + "Mi" + DateTime.Now.Minute + "S" + DateTime.Now.Second;
                    break;

                case "Custom":
                    directoryToOutput = outputExampleTextField.Text;
                    break;
            }

            outputExampleTextField.Text = directoryToOutput + "." + imageFormatPicked.ToString().ToLower();
        }

        private void imageFormatList_SelectedIndexChanged(object sender, EventArgs e)
        {
            outputFormatCombo_SelectedIndexChanged(null, null);
        }

        private void countTextBox_TextChanged(object sender, EventArgs e)
        {
            try
            {
                count = Convert.ToInt32(countTextBox.Text);
            }
            catch (Exception)
            {
                countTextBox.Text = count.ToString();
            }

            outputFormatCombo_SelectedIndexChanged(null, null);
        }

        private void iconLink_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            System.Diagnostics.Process.Start(iconURL);
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            System.Diagnostics.Process.Start(myURL);
        }

        private void startHiddenCheckBox_CheckedChanged(object sender, EventArgs e)
        {
            writeRegistry(startHiddenCheckBox.Checked);
        }

        #region Registry Tools
        /// <summary>
        /// Reads the registry entry at "HKEY_CURRENT_USER\Software\PRTSC_TO_FILE" and returns true
        /// if there is a key with value ("StartClosed", "true") and false otherwise.
        /// </summary>
        /// <returns>True if there is a registry entry at "HKEY_CURRENT_USER\Software\PRTSC_TO_FILE"
        ///             with value ("StartClosed", "true") and false otherwise.</returns>
        public static bool readRegistry()
        {
            try
            {
                RegistryKey key = Registry.CurrentUser;
                key = key.OpenSubKey("Software").OpenSubKey("PRTSC_TO_FILE");

                if (key == null)
                {
                    return false;
                }

                if (key.GetValue("StartClosed").ToString() == "True")
                {
                    return true;
                }
                return false;
            }
            catch (Exception)
            {
                return false;
            }

        }

        /// <summary>
        /// Writes the registry entry at "HKEY_CURRENT_USER\Software\PRTSC_TO_FILE" with the value
        /// ("StartClosed", <option>). 
        /// </summary>
        /// <param name="option">A bool that decides which value to write to the registry.</param>
        /// <returns>Returns true if successfully wrote the value to the registry.</returns>
        public static bool writeRegistry(bool option)
        {
            try
            {
                RegistryKey key = Registry.CurrentUser;
                key = key.OpenSubKey("Software", true).OpenSubKey("PRTSC_TO_FILE", true);

                key.SetValue("StartClosed", option.ToString());

                return true;

            }
            catch (Exception)
            {
                return false;
            }
        }

        #endregion

        private void GUI_Load(object sender, EventArgs e)
        {
            if (startHiddenCheckBox.Checked)
            {
                Visible = false;
                ShowInTaskbar = false;
                GUI_FormClosing("I am a string!", null);
            }
        }

    }
}

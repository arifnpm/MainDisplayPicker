using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MainDisplayPicker
{
	public partial class Form1 : Form
	{
		public Form1()
		{
			InitializeComponent();
		}

		private void Form1_Load(object sender, EventArgs e)
		{
            var device = new DISPLAY_DEVICE();
            device.cb = Marshal.SizeOf(device);
			// iterate for more than 1 active monitor
			var monitorActiveCount = 0;
			for (uint otherid = 0; NativeMethods.EnumDisplayDevices(null, otherid, ref device, 0); otherid++)
			{
				if (device.StateFlags.HasFlag(DisplayDeviceStateFlags.AttachedToDesktop))
				{
					device.cb = Marshal.SizeOf(device);
					var otherDeviceMode = new DEVMODE();

					NativeMethods.EnumDisplaySettings(device.DeviceName, -1, ref otherDeviceMode);

					if(otherDeviceMode.dmPelsWidth>0 && otherDeviceMode.dmPelsHeight > 0)
					{
						monitorActiveCount++;
                    }
				}
			}
            if (monitorActiveCount>1)
			{
                btnSetAsMain.Enabled = true;
                btnExtend.Enabled = false;
				btnShowThisOnly.Enabled = true;
			} 
			else // Only 1 active Monitor
			{
				btnSetAsMain.Enabled = false;
                btnExtend.Enabled = true;
                btnShowThisOnly.Enabled = false;
            }
        }

		private void Form1_Shown(object sender, EventArgs e)
		{
			Screen screen = Screen.FromControl(this);
			//Screen[] allScreens = Screen.AllScreens;
			//uint dispNum = 0;
			//for (uint i = 0; i < allScreens.Length; i++)
			//{
			//	if (allScreens[i].Equals(screen))
			//	{
			//		dispNum = i+1;
			//		break;
			//	}
			//}
			string display_number = Regex.Match(screen.DeviceName, @"\d+").Value;
			//MonitorChanger.SetAsPrimaryMonitor(uint.Parse(display_number)-1);
			//timer1.Start();
		}

		private void timer1_Tick(object sender, EventArgs e)
		{
			this.Close();
		}


		private void btnSetAsMain_Click(object sender, EventArgs e)
		{
            this.btnSetAsMain.Enabled = false;
            this.btnExtend.Enabled = false;
            this.btnShowThisOnly.Enabled = false;
            Screen screen = Screen.FromControl(this);
			string display_number = Regex.Match(screen.DeviceName, @"\d+").Value;
			MonitorChanger.SetAsPrimaryMonitor(uint.Parse(display_number)-1);
			timer1.Interval = 2000;
			timer1.Start();
		}

        private void btnExtend_Click(object sender, EventArgs e)
        {
            this.btnSetAsMain.Enabled = false;
            this.btnExtend.Enabled = false;
            this.btnShowThisOnly.Enabled = false;
            MonitorChanger.ExtendDisplays();
            timer1.Interval = 5000;
            timer1.Start();
        }

        private void btnShowThisOnly_Click(object sender, EventArgs e)
        {
            this.btnSetAsMain.Enabled = false;
            this.btnExtend.Enabled = false;
            this.btnShowThisOnly.Enabled = false;
            Screen screen = Screen.FromControl(this);
            string display_number = Regex.Match(screen.DeviceName, @"\d+").Value;
            MonitorChanger.ShowOnlyMonitor(uint.Parse(display_number) - 1);
            timer1.Interval = 5000;
            timer1.Start();
        }
    }
}

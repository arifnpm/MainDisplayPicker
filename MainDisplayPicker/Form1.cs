using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
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
			MonitorChanger.SetAsPrimaryMonitor(uint.Parse(display_number)-1);
			timer1.Start();
		}

		private void timer1_Tick(object sender, EventArgs e)
		{
			this.Close();
		}
	}
}

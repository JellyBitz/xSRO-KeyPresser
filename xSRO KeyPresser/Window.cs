using System;
using System.Collections.Generic;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using AutoIt;
using System.Diagnostics;
using System.Drawing.Text;
using System.IO;
using System.Runtime.InteropServices;
using System.Text.RegularExpressions;
using System.Threading;
using System.Xml;
using xSROKeyPresser.Properties;

namespace xSRO_KeyPresser
{
	public partial class Window : Form
	{
		private bool isRunning = false;
		private Random rand = new Random();
		private PrivateFontCollection pfc = new PrivateFontCollection();
		private ListView lastListview = (ListView)null;
		private ListViewItem _itemDnD = (ListViewItem)null;
		private object[] optBeltNumbers = new object[10]
		{
			(object) "1",
			(object) "2",
			(object) "3",
			(object) "4",
			(object) "5",
			(object) "6",
			(object) "7",
			(object) "8",
			(object) "9",
			(object) "0"
		};
		private object[] optCustomKeys = new object[35]
		{
			(object) "A",
			(object) "B",
			(object) "C",
			(object) "D",
			(object) "E",
			(object) "F",
			(object) "G",
			(object) "H",
			(object) "I",
			(object) "J",
			(object) "K",
			(object) "L",
			(object) "M",
			(object) "N",
			(object) "O",
			(object) "P",
			(object) "Q",
			(object) "R",
			(object) "S",
			(object) "T",
			(object) "U",
			(object) "V",
			(object) "W",
			(object) "X",
			(object) "Y",
			(object) "Z",
			(object) "{SPACE}",
			(object) "{TAB}",
			(object) "{ENTER}",
			(object) "{ESC}",
			(object) "{HOME}",
			(object) "{END}",
			(object) "{PGUP}",
			(object) "{PGDN}",
			(object) "{INSERT}"
		};
		private string appPath;
		private int tSec;
		private int tMin;
		private int tHrs;
		private Thread tMainThread;
		private AutoResetEvent threadsExit;
		private List<ListViewItem>[] keyBuffs;
		public Window()
		{
			this.InitializeComponent();
			this.InitializeCustomFonts();
			this.appPath = Application.ExecutablePath.Substring(0,Application.ExecutablePath.Length-4)+".xml";
			this.isRunning = false;
			this.tSec = this.tMin = this.tHrs = 0;
			this.rbOrder.Checked = true;
			this.rbAttacker.Checked = true;
			this.cbxKSFKey.SelectedIndex = 0;
			this.cbxSSFKey.SelectedIndex = 0;
			this.lstKeys.setColor(Color.Gray);
			this.keyBuffs = new List<ListViewItem>[8];
			for (int index = 0; index < 8; ++index)
			{
				this.lstParty.Items.Add(string.Concat((object)(index + 1)));
				this.lstParty.Items[index].Font = new Font(this.lstParty.Font.FontFamily, 8f);
				if (index == 0)
					this.lstParty.Items[index].SubItems.Add("You");
				else
					this.lstParty.Items[index].SubItems.Add("Teammate #" + (object)index);
				this.keyBuffs[index] = new List<ListViewItem>();
			}
			this.threadsExit = new AutoResetEvent(false);
			AutoItX.AutoItSetOption("SendKeyDelay", 10);
			AutoItX.AutoItSetOption("SendKeyDownDelay", 50);
			WindowsAPI.RegisterHotKey(this.Handle, 1, 0U, 116);
			WindowsAPI.RegisterHotKey(this.Handle, 2, 0U, 117);
			WindowsAPI.RegisterHotKey(this.Handle, 3, 2U, 70);
			this.tabControl.Font = this.getCustomFont(Window.CustomFont.FONT_Corbel, this.tabControl.Font);
			this.groupBox1.Font = this.getCustomFont(Window.CustomFont.FONT_Corbel, this.groupBox1.Font);
			this.groupBox2.Font = this.getCustomFont(Window.CustomFont.FONT_Corbel, this.groupBox2.Font);
			this.groupBox3.Font = this.getCustomFont(Window.CustomFont.FONT_Corbel, this.groupBox3.Font);
			this.groupBox4.Font = this.getCustomFont(Window.CustomFont.FONT_Corbel, this.groupBox4.Font);
			this.groupBox5.Font = this.getCustomFont(Window.CustomFont.FONT_Corbel, this.groupBox5.Font);
			this.groupBox6.Font = this.getCustomFont(Window.CustomFont.FONT_Corbel, this.groupBox6.Font);
			this.groupBox7.Font = this.getCustomFont(Window.CustomFont.FONT_Corbel, this.groupBox7.Font);
			this.label1.Font = this.getCustomFont(Window.CustomFont.FONT_Corbel, this.label1.Font);
			this.label2.Font = this.getCustomFont(Window.CustomFont.FONT_Corbel, this.label2.Font);
			this.label3.Font = this.getCustomFont(Window.CustomFont.FONT_Corbel, this.label3.Font);
			this.label4.Font = this.getCustomFont(Window.CustomFont.FONT_Corbel, this.label4.Font);
			this.label5.Font = this.getCustomFont(Window.CustomFont.FONT_Corbel, this.label5.Font);
			this.label6.Font = this.getCustomFont(Window.CustomFont.FONT_Corbel, this.label6.Font);
			this.label7.Font = this.getCustomFont(Window.CustomFont.FONT_Corbel, this.label7.Font);
			this.label8.Font = this.getCustomFont(Window.CustomFont.FONT_Corbel, this.label8.Font);
			this.label9.Font = this.getCustomFont(Window.CustomFont.FONT_Corbel, this.label9.Font);
			this.label10.Font = this.getCustomFont(Window.CustomFont.FONT_Corbel, this.label10.Font);
			this.label11.Font = this.getCustomFont(Window.CustomFont.FONT_Corbel, this.label11.Font);
			this.label12.Font = this.getCustomFont(Window.CustomFont.FONT_Corbel, this.label12.Font);
			this.cbxKSFKey.Font = this.getCustomFont(Window.CustomFont.FONT_Corbel, this.cbxKSFKey.Font);
			this.cbxSSFKey.Font = this.getCustomFont(Window.CustomFont.FONT_Corbel, this.cbxSSFKey.Font);
			this.cbxKSNumber.Font = this.getCustomFont(Window.CustomFont.FONT_Corbel, this.cbxKSNumber.Font);
			this.cbxSSNumber.Font = this.getCustomFont(Window.CustomFont.FONT_Corbel, this.cbxSSNumber.Font);
			this.btnAddKeySetting.Font = this.getCustomFont(Window.CustomFont.FONT_Corbel, this.btnAddKeySetting.Font);
			this.btnAddSkillSetting.Font = this.getCustomFont(Window.CustomFont.FONT_Corbel, this.btnAddSkillSetting.Font);
			this.rbOrder.Font = this.getCustomFont(Window.CustomFont.FONT_Corbel, this.rbOrder.Font);
			this.rbRandom.Font = this.getCustomFont(Window.CustomFont.FONT_Corbel, this.rbRandom.Font);
			this.rbAttacker.Font = this.getCustomFont(Window.CustomFont.FONT_Corbel, this.rbAttacker.Font);
			this.rbBuffer.Font = this.getCustomFont(Window.CustomFont.FONT_Corbel, this.rbBuffer.Font);
			this.btnStartStop.Font = this.getCustomFont(Window.CustomFont.FONT_Merienda, this.btnStartStop.Font);
			this.tbxNickname.Font = this.getCustomFont(Window.CustomFont.FONT_Corbel, this.tbxNickname.Font);
			this.btnEditNick.Font = this.getCustomFont(Window.CustomFont.FONT_Corbel, this.btnEditNick.Font);
			this.btnRefresh.Font = this.getCustomFont(Window.CustomFont.FONT_Corbel, this.btnRefresh.Font);
			this.btnHideClient.Font = this.getCustomFont(Window.CustomFont.FONT_Corbel, this.btnHideClient.Font);
			this.btnShowClient.Font = this.getCustomFont(Window.CustomFont.FONT_Corbel, this.btnShowClient.Font);
			this.btnReduceMemory.Font = this.getCustomFont(Window.CustomFont.FONT_Corbel, this.btnReduceMemory.Font);
			this.btnKill.Font = this.getCustomFont(Window.CustomFont.FONT_Corbel, this.btnKill.Font);
			this.tbxClientProcessName.Font = this.getCustomFont(Window.CustomFont.FONT_Corbel, this.tbxClientProcessName.Font);
			this.cbxCastOwnLast.Font = this.getCustomFont(Window.CustomFont.FONT_Corbel, this.cbxCastOwnLast.Font);
			this.tbxClientTitle.Font = this.getCustomFont(Window.CustomFont.FONT_Corbel, this.tbxClientTitle.Font);
			this.btnSaveSettings.Font = this.getCustomFont(Window.CustomFont.FONT_Corbel, this.btnSaveSettings.Font);
		}

		private void InitializeCustomFonts()
		{
			string[] strArray = new string[6]
			{
				"Merienda_Regular",
				"Merienda_Bold",
				"corbel",
				"corbelb",
				"corbeli",
				"corbelz"
			};
			foreach (string name in strArray)
			{
				byte[] source = (byte[])Resources.ResourceManager.GetObject(name);
				IntPtr num = Marshal.AllocCoTaskMem(source.Length);
				Marshal.Copy(source, 0, num, source.Length);
				uint pcFonts = 0;
				this.pfc.AddMemoryFont(num, source.Length);
				WindowsAPI.AddFontMemResourceEx(num, (uint)source.Length, IntPtr.Zero, ref pcFonts);
				Marshal.FreeCoTaskMem(num);
			}
		}
		public Font getCustomFont(Window.CustomFont option, Font font)
		{
			return new Font(this.pfc.Families[(int)option], font.Size, this.pfc.Families[(int)option].IsStyleAvailable(font.Style) ? font.Style : FontStyle.Regular);
		}
		private void Window_Load(object sender, EventArgs e)
		{
			try
			{
				this.loadSettings();
			}
			catch
			{
				int num = (int)MessageBox.Show((IWin32Window)this, "Error trying to load XML settings. Settings by default will be loaded.", "Error - XML Settings", MessageBoxButtons.OK, MessageBoxIcon.Hand);
				this.saveSettings();
			}
			this.loadArguments();
			this.BringToFront();
		}

		private void loadArguments()
		{
			bool openAds = true;
			string[] args = Environment.GetCommandLineArgs();
			for (int i=0;i<args.Length;i++)
			{
				switch (args[i])
				{
					case "--noads":
						openAds = false;
						break;
					case "-title ":
						if (i+1<args.Length)
						{
							this.Text = args[i + 1];
            }
						break;
				}
			}
			if (openAds)
				Process.Start("http://bit.ly/WWOnLine");
		}

		private void Window_FormClosing(object sender, FormClosingEventArgs e)
		{
			this.keypresserStop();
			this.notifyIcon.Visible = false;
		}

		private void loadSettings()
		{
			XmlDocument xmlDocument = new XmlDocument();
			xmlDocument.Load(appPath);
			XmlNode xmlNode = xmlDocument.DocumentElement.SelectSingleNode("/Settings");
			foreach (XmlNode childNode in ((XmlElement)xmlNode).GetElementsByTagName("AttackList")[0].ChildNodes)
			{
				ListViewItem listViewItem = new ListViewItem();
				listViewItem.Font = new Font(listViewItem.Font.FontFamily, 8f);
				listViewItem.Checked = bool.Parse(childNode.ChildNodes[0].InnerText);
				listViewItem.Tag = (object)childNode.ChildNodes[1].InnerText;
				listViewItem.Text = this.isAutoItCustomKey(listViewItem.Tag.ToString());
				listViewItem.SubItems.Add(childNode.ChildNodes[2].InnerText);
				listViewItem.SubItems.Add(childNode.ChildNodes[3].InnerText);
				listViewItem.SubItems.Add(childNode.ChildNodes[4].InnerText);
				this.lstKeys.Items.Add(listViewItem);
			}
			XmlNodeList childNodes = ((XmlElement)xmlNode).GetElementsByTagName("PartyList")[0].ChildNodes;
			for (int index = 0; index < childNodes.Count; ++index)
			{
				this.lstParty.Items[index].SubItems[1].Text = childNodes[index].Attributes["Nickname"].InnerText;
				foreach (XmlNode childNode in childNodes[index].ChildNodes)
				{
					ListViewItem listViewItem = new ListViewItem();
					listViewItem.Font = new Font(listViewItem.Font.FontFamily, 8f);
					listViewItem.Checked = bool.Parse(childNode.ChildNodes[0].InnerText);
					listViewItem.Tag = (object)childNode.ChildNodes[1].InnerText;
					listViewItem.Text = this.isAutoItCustomKey(listViewItem.Tag.ToString());
					listViewItem.SubItems.Add(childNode.ChildNodes[2].InnerText);
					listViewItem.SubItems.Add(childNode.ChildNodes[3].InnerText);
					listViewItem.SubItems.Add(childNode.ChildNodes[4].InnerText);
					this.keyBuffs[index].Add(listViewItem);
				}
			}
			if (this.keyBuffs[0].Count > 0)
				this.lstParty.Items[0].Selected = true;
			this.tbxClientTitle.Text = ((XmlElement)xmlNode).GetElementsByTagName("ClientTitle")[0].InnerText;
			this.tbxBackToClient.Text = string.Concat((object)int.Parse(((XmlElement)xmlNode).GetElementsByTagName("BackToClient")[0].InnerText));
			this.tbxBetweenBuffs.Text = string.Concat((object)int.Parse(((XmlElement)xmlNode).GetElementsByTagName("BetweenPartyBuffs")[0].InnerText));
			this.cbxCastOwnLast.Checked = bool.Parse(((XmlElement)xmlNode).GetElementsByTagName("CastOwnBuffsLast")[0].InnerText);
		}

		private void saveSettings()
		{
			XmlDocument xmlDocument = new XmlDocument();
			xmlDocument.AppendChild((XmlNode)xmlDocument.CreateXmlDeclaration("1.0", "UTF-8", ""));
			XmlNode element1 = (XmlNode)xmlDocument.CreateElement("Settings");
			xmlDocument.AppendChild(element1);
			XmlAttribute attribute1 = xmlDocument.CreateAttribute("Description");
			attribute1.Value = this.Text + " - " + this.Tag.ToString().Replace("\\n", " ");
			element1.Attributes.Append(attribute1);
			XmlNode element2 = (XmlNode)xmlDocument.CreateElement("AttackList");
			element1.AppendChild(element2);
			for (int index = 0; index < this.lstKeys.Items.Count; ++index)
			{
				XmlNode element3 = (XmlNode)xmlDocument.CreateElement("Key");
				XmlNode element4 = (XmlNode)xmlDocument.CreateElement("UseKey");
				element4.InnerText = this.lstKeys.Items[index].Checked.ToString();
				element3.AppendChild(element4);
				XmlNode element5 = (XmlNode)xmlDocument.CreateElement("AutoItCode");
				element5.InnerText = this.lstKeys.Items[index].Tag.ToString();
				element3.AppendChild(element5);
				XmlNode element6 = (XmlNode)xmlDocument.CreateElement("Cooldown");
				element6.InnerText = this.lstKeys.Items[index].SubItems[1].Text;
				element3.AppendChild(element6);
				XmlNode element7 = (XmlNode)xmlDocument.CreateElement("Casttime");
				element7.InnerText = this.lstKeys.Items[index].SubItems[2].Text;
				element3.AppendChild(element7);
				XmlNode element8 = (XmlNode)xmlDocument.CreateElement("Description");
				element8.InnerText = this.lstKeys.Items[index].SubItems[3].Text;
				element3.AppendChild(element8);
				element2.AppendChild(element3);
			}
			XmlNode element9 = (XmlNode)xmlDocument.CreateElement("PartyList");
			element1.AppendChild(element9);
			bool flag;
			for (int index1 = 0; index1 < this.lstParty.Items.Count; ++index1)
			{
				XmlNode element3 = (XmlNode)xmlDocument.CreateElement("Player");
				XmlAttribute attribute2 = xmlDocument.CreateAttribute("Nickname");
				attribute2.InnerText = this.lstParty.Items[index1].SubItems[1].Text;
				element3.Attributes.Append(attribute2);
				element9.AppendChild(element3);
				for (int index2 = 0; index2 < this.keyBuffs[index1].Count; ++index2)
				{
					XmlNode element4 = (XmlNode)xmlDocument.CreateElement("Key");
					XmlNode element5 = (XmlNode)xmlDocument.CreateElement("UseKey");
					XmlNode xmlNode = element5;
					flag = this.keyBuffs[index1][index2].Checked;
					string str = flag.ToString();
					xmlNode.InnerText = str;
					element4.AppendChild(element5);
					XmlNode element6 = (XmlNode)xmlDocument.CreateElement("AutoItCode");
					element6.InnerText = this.keyBuffs[index1][index2].Tag.ToString();
					element4.AppendChild(element6);
					XmlNode element7 = (XmlNode)xmlDocument.CreateElement("Cooldown");
					element7.InnerText = this.keyBuffs[index1][index2].SubItems[1].Text;
					element4.AppendChild(element7);
					XmlNode element8 = (XmlNode)xmlDocument.CreateElement("Casttime");
					element8.InnerText = this.keyBuffs[index1][index2].SubItems[2].Text;
					element4.AppendChild(element8);
					XmlNode element10 = (XmlNode)xmlDocument.CreateElement("Description");
					element10.InnerText = this.keyBuffs[index1][index2].SubItems[3].Text;
					element4.AppendChild(element10);
					element3.AppendChild(element4);
				}
			}
			XmlNode element11 = (XmlNode)xmlDocument.CreateElement("ClientTitle");
			element11.InnerText = this.tbxClientTitle.Text;
			element1.AppendChild(element11);
			XmlNode element12 = (XmlNode)xmlDocument.CreateElement("BackToClient");
			element12.InnerText = this.tbxBackToClient.Text;
			element1.AppendChild(element12);
			XmlNode element13 = (XmlNode)xmlDocument.CreateElement("BetweenPartyBuffs");
			element13.InnerText = this.tbxBetweenBuffs.Text;
			element1.AppendChild(element13);
			XmlNode element14 = (XmlNode)xmlDocument.CreateElement("CastOwnBuffsLast");
			XmlNode xmlNode1 = element14;
			flag = this.cbxCastOwnLast.Checked;
			string str1 = flag.ToString();
			xmlNode1.InnerText = str1;
			element1.AppendChild(element14);
			xmlDocument.Save(appPath);
		}

		private void getSROWindowToFront()
		{
			string wTitle = "";
			this.tbxClientTitle.Invoke((MethodInvoker)delegate
			{
				wTitle = tbxClientTitle.Text;
			});
			IntPtr window = WindowsAPI.FindWindow((string)null, wTitle);
			if (wTitle.Length <= 0 || !(WindowsAPI.GetForegroundWindow() != window))
				return;
			int waitSec = 0;
			this.tbxClientTitle.Invoke((MethodInvoker)delegate {
				waitSec = int.Parse(this.tbxBackToClient.Text);
			});
			if (!this.threadsExit.WaitOne(waitSec * 1000))
			{
				WindowsAPI.SetForegroundWindow(window);
				Thread.Sleep(250);
			}
		}
		private void AutoIt_SendKey(string k)
		{
			AutoItX.Send(k, 0);
			Thread.Sleep(5);
			AutoItX.Send(k, 0);
		}
		private void btn_Click(object sender, EventArgs e)
		{
			Button button = (Button)sender;
			switch (button.Name)
			{
				case "btnAddKeySetting":
					this.lstKeys.Items.Add(this.createListViewItem_Key(this.cbxKSFKey.Text.Contains("Custom") ? this.cbxKSNumber.Text : "{" + this.cbxKSFKey.Text + "}|" + this.cbxKSNumber.Text, this.tbxKSCooldown.Text, this.tbxKSCasttime.Text, this.tbxKSDesc.Text, true));
					break;
				case "btnAddSkillSetting":
					if (this.lstParty.SelectedItems.Count <= 0)
						break;
					this.lstBuffs.Items.Add(this.createListViewItem_Key(this.cbxSSFKey.Text.Contains("Custom") ? this.cbxSSNumber.Text : "{" + this.cbxSSFKey.Text + "}|" + this.cbxSSNumber.Text, this.tbxSSCooldown.Text, this.tbxSSCasttime.Text, this.tbxSSDesc.Text, true));
					this.keyBuffs[this.lstParty.SelectedItems[0].Index].Add(this.lstBuffs.Items[this.lstBuffs.Items.Count - 1]);
					break;
				case "btnStartStop":
					if (this.isRunning)
					{
						this.keypresserStop();
						break;
					}
					this.keypresserStart();
					break;
				case "btnEditNick":
					if (this.lstParty.SelectedItems.Count <= 0)
						break;
					this.lstParty.SelectedItems[0].SubItems[1].Text = this.tbxNickname.Text;
					break;
				case "btnSaveSettings":
					this.saveSettings();
					break;
				case "btnRefresh":
					this.lstClients.Items.Clear();
					Process[] processesByName = Process.GetProcessesByName(this.tbxClientProcessName.Text);
					StringBuilder stringBuilder = new StringBuilder(256);
					for (int index = 0; index < processesByName.Length; ++index)
					{
						ListViewItem listViewItem = new ListViewItem(processesByName[index].Id.ToString())
						{
							SubItems = {
								processesByName[index].MainWindowTitle
							}
						};
						listViewItem.Font = new Font(listViewItem.Font.FontFamily, 8f);
						this.lstClients.Items.Add(listViewItem);
					}
					break;
				case "btnHideClient":
				case "btnShowClient":
					if (this.lstClients.SelectedItems.Count <= 0)
						break;
					try
					{
						foreach (IntPtr hWnd in WindowsAPI.GetRootWindowsOfProcess(int.Parse(this.lstClients.SelectedItems[0].Text)))
							WindowsAPI.ShowWindow(hWnd, button.Name.Contains("Hide") ? WindowsAPI.ShowWindowOp.SW_HIDE : WindowsAPI.ShowWindowOp.SW_SHOW);
					}
					catch
					{
						this.lstClients.SelectedItems[0].Remove();
					}
					break;
				case "btnKill":
					if (this.lstClients.SelectedItems.Count <= 0)
						break;
					try
					{
						Process processById = Process.GetProcessById(int.Parse(this.lstClients.SelectedItems[0].Text));
						this.lstClients.SelectedItems[0].Remove();
						processById.Kill();
					}
					catch
					{
						this.lstClients.SelectedItems[0].Remove();
					}
					break;
				case "btnReduceMemory":
					if (this.lstClients.SelectedItems.Count <= 0)
						break;
					try
					{
						WindowsAPI.EmptyWorkingSet(Process.GetProcessById(int.Parse(this.lstClients.SelectedItems[0].Text)).Handle);
					}
					catch
					{
						this.lstClients.SelectedItems[0].Remove();
					}
					break;
				case "btnSupportMe":
					Process.Start("https://www.buymeacoffee.com/JellyBitz");
					break;
			}
		}

		private void keypresserStart()
		{
			if (this.isRunning)
				return;
			this.isRunning = true;
			this.btnStartStop.BackColor = Color.Red;
			this.btnStartStop.Text = "STOP";
			this.tSec = this.tMin = this.tHrs = 0;
			this.lblTimer.Text = "Time :  00:00:00";
			this.rbAttacker.Enabled = this.rbBuffer.Enabled = false;
			this.threadsExit.Reset();
			this.tMainThread = !this.rbAttacker.Checked ? new Thread(new ThreadStart(this.threadBuffer)) : new Thread(new ThreadStart(this.threadAttacker));
			this.tMainThread.Priority = ThreadPriority.Highest;
			this.tMainThread.Start();
			this.timer.Start();
			this.notifyIcon.ShowBalloonTip(2500,this.Text,"started", ToolTipIcon.Info);
		}

		private void keypresserStop()
		{
			if (!this.isRunning)
				return;
			this.isRunning = false;
			this.btnStartStop.BackColor = Color.Green;
			this.btnStartStop.Text = "START";
			this.rbAttacker.Enabled = this.rbBuffer.Enabled = true;
			this.threadsExit.Set();
			this.timer.Stop();
			this.tMainThread.Abort();
			this.AutoIt_SendFix();
			this.notifyIcon.ShowBalloonTip(5000, this.Text, "stoped", ToolTipIcon.Info);
		}

		private ListViewItem createListViewItem_Key(
			string autoItCode,
			string cooldown,
			string casttime,
			string desc,
			bool useKey = true)
		{
			ListViewItem listViewItem = new ListViewItem();
			listViewItem.Font = new Font(listViewItem.Font.FontFamily, 8f);
			listViewItem.Checked = useKey;
			listViewItem.Text = this.isAutoItCustomKey(autoItCode);
			listViewItem.Tag = (object)autoItCode;
			int result;
			int.TryParse(cooldown, out result);
			if (result < 0)
				result = 5;
			listViewItem.SubItems.Add(result.ToString() + " sec");
			int.TryParse(casttime, out result);
			if (result == 0)
				result = 2000;
			listViewItem.SubItems.Add(result.ToString() + " ms");
			listViewItem.SubItems.Add(desc.Trim());
			return listViewItem;
		}

		private void editListViewItem_Key(
			ListViewItem keyInfo,
			ComboBox key1,
			ComboBox key2,
			string cooldown,
			string casttime,
			string desc)
		{
			string code = key1.Text.Contains("Custom") ? key2.Text : "{" + key1.Text + "}|" + key2.Text;
			keyInfo.Text = this.isAutoItCustomKey(code);
			keyInfo.Tag = (object)code;
			int result;
			int.TryParse(cooldown, out result);
			if (result < 0)
				result = 5;
			keyInfo.SubItems[1].Text = result.ToString() + " sec";
			int.TryParse(casttime, out result);
			if (result == 0)
				result = 2000;
			keyInfo.SubItems[2].Text = result.ToString() + " ms";
			keyInfo.SubItems[3].Text = desc.Trim();
		}

		private void loadFromListViewItem_Key(
			ListViewItem keyInfo,
			ref ComboBox key1,
			ref ComboBox key2,
			ref TextBox tbxCooldown,
			ref TextBox tbxCasttime,
			ref TextBox tbxDesc)
		{
			if (keyInfo.Text.Contains("Custom"))
			{
				key1.Text = keyInfo.Text;
				if (!key2.Items.Contains((object)keyInfo.Tag.ToString().ToUpper()))
					key2.Items.Add((object)keyInfo.Tag.ToString());
				key2.Text = keyInfo.Tag.ToString();
			}
			else
			{
				key1.Text = keyInfo.Tag.ToString().Split('|')[0].Substring(1, 2);
				key2.Text = keyInfo.Tag.ToString().Split('|')[1];
			}
			tbxCooldown.Text = keyInfo.SubItems[1].Text.Replace(" sec", "");
			tbxCasttime.Text = keyInfo.SubItems[2].Text.Replace(" ms", "");
			tbxDesc.Text = keyInfo.SubItems[3].Text;
		}

		private void menuKeys_Enter(object sender, EventArgs e)
		{
			this.lastListview = (ListView)sender;
		}

		private void menuKeys_Click(object sender, EventArgs e)
		{
			ToolStripMenuItem toolStripMenuItem = (ToolStripMenuItem)sender;
			switch (toolStripMenuItem.Name)
			{
				case "mKSLoad":
					if (this.lastListview.SelectedItems.Count <= 0)
						break;
					this.loadFromListViewItem_Key(this.lastListview.SelectedItems[0], ref this.cbxKSFKey, ref this.cbxKSNumber, ref this.tbxKSCooldown, ref this.tbxKSCasttime, ref this.tbxKSDesc);
					break;
				case "mSSLoad":
					if (this.lastListview.SelectedItems.Count <= 0)
						break;
					this.loadFromListViewItem_Key(this.lastListview.SelectedItems[0], ref this.cbxSSFKey, ref this.cbxSSNumber, ref this.tbxSSCooldown, ref this.tbxSSCasttime, ref this.tbxSSDesc);
					break;
				case "mKSSave":
					if (this.lastListview.SelectedItems.Count <= 0)
						break;
					this.editListViewItem_Key(this.lastListview.SelectedItems[0], this.cbxKSFKey, this.cbxKSNumber, this.tbxKSCooldown.Text, this.tbxKSCasttime.Text, this.tbxKSDesc.Text);
					break;
				case "mSSSave":
					if (this.lastListview.SelectedItems.Count <= 0)
						break;
					this.editListViewItem_Key(this.lastListview.SelectedItems[0], this.cbxSSFKey, this.cbxSSNumber, this.tbxSSCooldown.Text, this.tbxSSCasttime.Text, this.tbxSSDesc.Text);
					this.editListViewItem_Key(this.keyBuffs[this.lstParty.SelectedItems[0].Index][this.lastListview.SelectedItems[0].Index], this.cbxSSFKey, this.cbxSSNumber, this.tbxSSCooldown.Text, this.tbxSSCasttime.Text, this.tbxSSDesc.Text);
					break;
				case "mKSRemoveOne":
					if (this.lastListview.SelectedItems.Count <= 0)
						break;
					this.lastListview.SelectedItems[0].Remove();
					break;
				case "mSSRemoveOne":
					if (this.lastListview.SelectedItems.Count <= 0)
						break;
					this.keyBuffs[this.lstParty.SelectedItems[0].Index].RemoveAt(this.lastListview.SelectedItems[0].Index);
					this.lastListview.SelectedItems[0].Remove();
					break;
				case "mKSRemoveAll":
					this.lastListview.Items.Clear();
					break;
				case "mSSRemoveAll":
					this.keyBuffs[this.lstParty.SelectedItems[0].Index].Clear();
					this.lastListview.Items.Clear();
					break;
				case "mKSScriptSave":
				case "mSSScriptSave":
					if (this.lastListview.Items.Count <= 0)
						break;
					SaveFileDialog saveFileDialog = new SaveFileDialog();
					saveFileDialog.Title = "Save KeyScript";
					saveFileDialog.AddExtension = true;
					saveFileDialog.Filter = "Save your keyscript|*.txt";
					saveFileDialog.DefaultExt = "txt";
					int num1 = (int)saveFileDialog.ShowDialog((IWin32Window)this);
					if (saveFileDialog.FileName != "")
						this.saveKeyScript(saveFileDialog.FileName, this.lastListview);
					break;
				case "mKSScriptReload":
				case "mKSScriptLoad":
				case "mSSScriptReload":
				case "mSSScriptLoad":
					if (this.lastListview.Name == "lstBuffs" && this.lstParty.SelectedItems.Count == 0)
						break;
					OpenFileDialog openFileDialog = new OpenFileDialog();
					openFileDialog.Title = "Load KeyScript";
					openFileDialog.Filter = "Select your keyscript|*.txt";
					int num2 = (int)openFileDialog.ShowDialog((IWin32Window)this);
					if (!(openFileDialog.FileName != "") || !openFileDialog.FileName.ToLower().EndsWith(".txt"))
						break;
					if (toolStripMenuItem.Name.Contains("Reload"))
					{
						this.lastListview.Items.Clear();
						if (this.lastListview.Name == "lstBuffs")
							this.keyBuffs[this.lstParty.SelectedItems[0].Index].Clear();
					}
					this.loadKeyScript(openFileDialog.FileName, this.lastListview);
					break;
				case "mHideWindow":
					if (this.Visible)
					{
						this.WindowState = FormWindowState.Minimized;
						Thread.Sleep(50);
						this.Visible = false;
						toolStripMenuItem.Text = "Show";
						break;
					}
					this.Visible = true;
					toolStripMenuItem.Text = "Hide";
					Thread.Sleep(50);
					this.WindowState = FormWindowState.Normal;
					if (WindowsAPI.GetForegroundWindow() != this.Handle)
						WindowsAPI.SetForegroundWindow(this.Handle);
					break;
			}
		}

		private void threadAttacker()
		{
			ListView keys = new ListView();
			keys.CheckBoxes = true;
			this.lstKeys.Invoke((MethodInvoker)(() =>
			{
				foreach (ListViewItem checkedItem in this.lstKeys.CheckedItems)
					keys.Items.Add((ListViewItem)checkedItem.Clone());
			}));
			if (keys.Items.Count > 0)
			{
				while (this.isRunning)
				{
					for (int index = 0; index < keys.Items.Count; ++index)
					{
						ListViewItem selectedKey = (ListViewItem)null;
						selectedKey = !this.rbRandom.Checked ? keys.Items[index] : keys.Items[this.rand.Next(keys.Items.Count)];
						if (selectedKey.Checked)
						{
							this.getSROWindowToFront();
							string[] strArray = new string[1];
							if (selectedKey.Tag.ToString().Contains("|"))
								strArray = selectedKey.Tag.ToString().Split('|');
							else
								strArray[0] = selectedKey.Tag.ToString();
							foreach (string k in strArray)
							{
								this.AutoIt_SendKey(k);
								Thread.Sleep(5);
							}
							selectedKey.Checked = false;
							new Thread((ThreadStart)(() =>
							{
								if (this.threadsExit.WaitOne(int.Parse(selectedKey.SubItems[1].Text.Replace("sec", "")) * 1000))
									return;
								selectedKey.Checked = true;
							}))
							{
								Priority = ThreadPriority.AboveNormal
							}.Start();
							Thread.Sleep(int.Parse(selectedKey.SubItems[2].Text.Replace("ms", "")));
						}
					}
				}
			}
			else
				this.btnStartStop.Invoke((MethodInvoker)(() => this.btnStartStop.PerformClick()));
		}

		private void threadBuffer()
		{
			ListView[] buffs = new ListView[8];
			bool useAnyBuffs = false;
			for (int pos = 0; pos < 8; ++pos)
			{
				buffs[pos] = new ListView();
				buffs[pos].CheckBoxes = true;
				this.lstKeys.Invoke((MethodInvoker)(() =>
				{
					foreach (ListViewItem listViewItem in this.keyBuffs[pos])
					{
						if (listViewItem.Checked)
						{
							buffs[pos].Items.Add((ListViewItem)listViewItem.Clone());
							useAnyBuffs = true;
						}
					}
				}));
			}
			if (useAnyBuffs)
			{
				bool castLast = false;
				this.cbxCastOwnLast.Invoke((MethodInvoker)(() => castLast = this.cbxCastOwnLast.Checked));
				int timeBetweenBuffs = 0;
				this.cbxCastOwnLast.Invoke((MethodInvoker)(() => timeBetweenBuffs = int.Parse(this.tbxBetweenBuffs.Text) * 1000));
				if (timeBetweenBuffs > 0)
					timeBetweenBuffs -= 500;
				while (this.isRunning)
				{
					for (int pos = castLast ? 7 : 0; castLast ? pos >= 0 : pos < 8; pos += castLast ? -1 : 1)
					{
						for (int i = 0; i < buffs[pos].Items.Count; ++i)
						{
							if (buffs[pos].Items[i].Checked)
							{
								this.getSROWindowToFront();
								AutoItX.Send("^" + (object)(pos + 1), 0);
								this.threadsExit.WaitOne(250);
								AutoItX.Send("^" + (object)(pos + 1), 0);
								this.threadsExit.WaitOne(250);
								string[] strArray = new string[1];
								if (buffs[pos].Items[i].Tag.ToString().Contains("|"))
									strArray = buffs[pos].Items[i].Tag.ToString().Split('|');
								else
									strArray[0] = buffs[pos].Items[i].Tag.ToString();
								foreach (string k in strArray)
									this.AutoIt_SendKey(k);
								buffs[pos].Items[i].Checked = false;
								new Thread((ThreadStart)(() =>
								{
									int index1 = pos;
									int index2 = i;
									if (this.threadsExit.WaitOne(int.Parse(buffs[pos].Items[i].SubItems[1].Text.Replace("sec", "")) * 1000))
										return;
									buffs[index1].Items[index2].Checked = true;
								}))
								{
									Priority = ThreadPriority.Highest
								}.Start();
								Thread.Sleep(int.Parse(buffs[pos].Items[i].SubItems[2].Text.Replace("ms", "")));
							}
						}
						this.threadsExit.WaitOne(timeBetweenBuffs);
					}
				}
			}
			else
				this.btnStartStop.Invoke((MethodInvoker)(() => this.btnStartStop.PerformClick()));
		}

		private void saveKeyScript(string path, ListView list)
		{
			string contents = "";
			foreach (ListViewItem listViewItem in list.Items)
				contents = contents + "UseKey " + listViewItem.Checked.ToString() + " AutoItCode " + listViewItem.Tag.ToString() + " Cooldown " + listViewItem.SubItems[1].Text.Replace("sec", "").Trim() + " Casttime " + listViewItem.SubItems[2].Text.Replace("ms", "").Trim() + " Description " + listViewItem.SubItems[3].Text + Environment.NewLine;
			File.WriteAllText(path, contents);
		}

		private void loadKeyScript(string path, ListView list)
		{
			foreach (string readAllLine in File.ReadAllLines(path))
			{
				string[] strArray;
				try
				{
					strArray = readAllLine.Split(new string[5]
					{
						"UseKey ",
						" AutoItCode ",
						" Cooldown ",
						" Casttime ",
						" Description"
					}, StringSplitOptions.RemoveEmptyEntries);
					if (strArray.Length != 5)
						continue;
				}
				catch
				{
					continue;
				}
				ListViewItem listViewItemKey = this.createListViewItem_Key(strArray[1], strArray[2], strArray[3], strArray[4], bool.Parse(strArray[0]));
				list.Items.Add(listViewItemKey);
				if (list.Name == "lstBuffs")
					this.keyBuffs[this.lstParty.SelectedItems[0].Index].Add(listViewItemKey);
			}
		}

		private string isAutoItCustomKey(string code)
		{
			if (!Regex.Match(code, "{F[1-4]}|[0-9]").Success || code.Length != 6)
				return "Custom Key";
			return "[ " + code.Split('|')[0].Replace("{", "").Replace("}", "") + " ] Press " + code.Split('|')[1];
		}

		private void timer_Tick(object sender, EventArgs e)
		{
			++this.tSec;
			if (this.tSec >= 60)
			{
				this.tSec = 0;
				++this.tMin;
				if (this.tMin >= 60)
				{
					this.tMin = 0;
					++this.tHrs;
				}
			}
			this.lblTimer.Text = "Time :  " + (this.tHrs < 10 ? "0" + (object)this.tHrs : string.Concat((object)this.tHrs)) + ":" + (this.tMin < 10 ? "0" + (object)this.tMin : string.Concat((object)this.tMin)) + ":" + (this.tSec < 10 ? "0" + (object)this.tSec : string.Concat((object)this.tSec));
		}

		protected override void WndProc(ref Message m)
		{
			base.WndProc(ref m);
			if (m.Msg != 786)
				return;
			switch (m.WParam.ToInt32())
			{
				case 1:
					this.keypresserStart();
					break;
				case 2:
					this.keypresserStop();
					break;
				case 3:
					uint lpdwProcessId;
					int windowThreadProcessId = (int)WindowsAPI.GetWindowThreadProcessId(WindowsAPI.GetForegroundWindow(), out lpdwProcessId);
					if (Process.GetProcessById((int)lpdwProcessId).ProcessName == this.tbxClientProcessName.Text)
					{
						string text = Clipboard.GetText();
						if (text.Length != 0)
						{
							try
							{
								AutoItX.Send(text, 1);
								this.AutoIt_SendFix();
							}
							catch
							{
							}
						}
						break;
					}
					break;
			}
		}

		private void AutoIt_SendFix()
		{
			AutoItX.Send("{CTRLDOWN}", 0);
			AutoItX.Send("{CTRLUP}", 0);
		}

		private void listView_ColumWidthChanging(object sender, ColumnWidthChangingEventArgs e)
		{
			e.Cancel = true;
			e.NewWidth = ((ListView)sender).Columns[e.ColumnIndex].Width;
		}

		private void ListView_ItemChecked(object sender, ItemCheckedEventArgs e)
		{
			switch (((Control)sender).Name)
			{
				case "lstBuffs":
					this.keyBuffs[this.lstParty.SelectedItems[0].Index][e.Item.Index].Checked = e.Item.Checked;
					break;
			}
		}

		private void txbNumber_KeyPress(object sender, KeyPressEventArgs e)
		{
			if (char.IsControl(e.KeyChar) || char.IsDigit(e.KeyChar))
				return;
			e.Handled = true;
		}

		private void listViewDrag_MouseDown(object sender, MouseEventArgs e)
		{
			this._itemDnD = ((ListView)sender).GetItemAt(e.X, e.Y);
		}

		private void listViewDrag_MouseMove(object sender, MouseEventArgs e)
		{
			ListViewEx listViewEx = (ListViewEx)sender;
			if (this._itemDnD == null)
				return;
			this.Cursor = Cursors.Hand;
			int y = Math.Min(e.Y, listViewEx.Items[listViewEx.Items.Count - 1].GetBounds(ItemBoundsPortion.Entire).Bottom - 1);
			ListViewItem itemAt = listViewEx.GetItemAt(0, y);
			if (itemAt == null)
				return;
			Rectangle bounds = itemAt.GetBounds(ItemBoundsPortion.Entire);
			if (e.Y < bounds.Top + bounds.Height / 2)
			{
				listViewEx.LineBefore = itemAt.Index;
				listViewEx.LineAfter = -1;
			}
			else
			{
				listViewEx.LineBefore = -1;
				listViewEx.LineAfter = itemAt.Index;
			}
			listViewEx.Invalidate();
		}

		private void listViewDrag_MouseUp(object sender, MouseEventArgs e)
		{
			ListViewEx listViewEx = (ListViewEx)sender;
			if (this._itemDnD == null)
				return;
			try
			{
				int y = Math.Min(e.Y, listViewEx.Items[listViewEx.Items.Count - 1].GetBounds(ItemBoundsPortion.Entire).Bottom - 1);
				ListViewItem itemAt = listViewEx.GetItemAt(0, y);
				if (itemAt == null)
					return;
				Rectangle bounds = itemAt.GetBounds(ItemBoundsPortion.Entire);
				bool flag = e.Y < bounds.Top + bounds.Height / 2;
				if (this._itemDnD != itemAt)
				{
					int index = this._itemDnD.Index;
					if (flag)
					{
						listViewEx.Items.Remove(this._itemDnD);
						listViewEx.Items.Insert(itemAt.Index, this._itemDnD);
					}
					else
					{
						listViewEx.Items.Remove(this._itemDnD);
						listViewEx.Items.Insert(itemAt.Index + 1, this._itemDnD);
					}
					if (listViewEx.Name == "lstBuffs")
					{
						ListViewItem listViewItem = this.keyBuffs[this.lstParty.SelectedItems[0].Index][index];
						this.keyBuffs[this.lstParty.SelectedItems[0].Index].RemoveAt(index);
						this.keyBuffs[this.lstParty.SelectedItems[0].Index].Insert(itemAt.Index + (flag ? -1 : 1), listViewItem);
					}
				}
				listViewEx.LineAfter = listViewEx.LineBefore = -1;
				listViewEx.Invalidate();
			}
			finally
			{
				this._itemDnD = (ListViewItem)null;
				this.Cursor = Cursors.Default;
			}
		}

		private void listView_SelectionChanged(object sender, ListViewItemSelectionChangedEventArgs e)
		{
			ListView listView = (ListView)sender;
			if (listView.SelectedItems.Count <= 0)
				return;
			switch (listView.Name)
			{
				case "lstParty":
					int index = listView.SelectedItems[0].Index;
					this.tbxNickname.Text = listView.SelectedItems[0].SubItems[1].Text;
					this.lstBuffs.Items.Clear();
					if (this.keyBuffs[index].Count > 0)
					{
						this.lstBuffs.Items.AddRange(this.keyBuffs[index].ToArray());
						break;
					}
					break;
			}
		}

		private void comboBox_SelectionChanged(object sender, EventArgs e)
		{
			switch (((Control)sender).Name)
			{
				case "cbxKSFKey":
					if (this.cbxKSFKey.Text.Contains("Custom"))
					{
						this.cbxKSNumber.Items.Clear();
						this.cbxKSNumber.Items.AddRange(this.optCustomKeys);
					}
					else
					{
						this.cbxKSNumber.Items.Clear();
						this.cbxKSNumber.Items.AddRange(this.optBeltNumbers);
					}
					this.cbxKSNumber.SelectedIndex = 0;
					this.cbxKSNumber.MaxDropDownItems = 10;
					break;
				case "cbxSSFKey":
					if (this.cbxSSFKey.Text.Contains("Custom"))
					{
						this.cbxSSNumber.Items.Clear();
						this.cbxSSNumber.Items.AddRange(this.optCustomKeys);
					}
					else
					{
						this.cbxSSNumber.Items.Clear();
						this.cbxSSNumber.Items.AddRange(this.optBeltNumbers);
					}
					this.cbxSSNumber.SelectedIndex = 0;
					this.cbxSSNumber.MaxDropDownItems = 10;
					break;
			}
		}
		public enum CustomFont
		{
			FONT_Corbel,
			FONT_Merienda,
		}
	}
}


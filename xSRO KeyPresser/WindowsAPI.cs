// Decompiled with JetBrains decompiler
// Type: xSRO_KeyPresser.SpecialFunctions
// Assembly: xSRO KeyPresser, Version=0.0.0.1, Culture=neutral, PublicKeyToken=null
// MVID: 428579D7-7BC6-41FC-A1A8-3499407A23CB
// Assembly location: C:\Users\Luisana\Desktop\xSRO KeyPresser\xSRO KeyPresser.exe

using System;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using System.Text;

namespace xSRO_KeyPresser
{
	internal class WindowsAPI
	{
		private static WindowsAPI.PerformanceInformation pi = new WindowsAPI.PerformanceInformation();

		[DllImport("user32.dll")]
		public static extern IntPtr FindWindow(string lpClassName, string lpWindowName);

		[DllImport("user32.dll")]
		private static extern bool EnumChildWindows(
			IntPtr hwndParent,
			WindowsAPI.EnumWindowsProc lpEnumFunc,
			IntPtr lParam);

		[DllImport("user32.dll")]
		public static extern uint GetWindowThreadProcessId(IntPtr hWnd, out uint lpdwProcessId);

		private static bool EnumWindow(IntPtr handle, IntPtr pointer)
		{
			List<IntPtr> target = GCHandle.FromIntPtr(pointer).Target as List<IntPtr>;
			if (target == null)
				throw new InvalidCastException("GCHandle Target could not be cast as List<IntPtr>");
			target.Add(handle);
			return true;
		}

		public static List<IntPtr> GetChildWindows(IntPtr parent)
		{
			List<IntPtr> numList = new List<IntPtr>();
			GCHandle gcHandle = GCHandle.Alloc((object)numList);
			try
			{
				WindowsAPI.EnumWindowsProc lpEnumFunc = new WindowsAPI.EnumWindowsProc(WindowsAPI.EnumWindow);
				WindowsAPI.EnumChildWindows(parent, lpEnumFunc, GCHandle.ToIntPtr(gcHandle));
			}
			finally
			{
				if (gcHandle.IsAllocated)
					gcHandle.Free();
			}
			return numList;
		}

		public static List<IntPtr> GetRootWindowsOfProcess(int pid)
		{
			List<IntPtr> childWindows = WindowsAPI.GetChildWindows(IntPtr.Zero);
			List<IntPtr> numList = new List<IntPtr>();
			foreach (IntPtr hWnd in childWindows)
			{
				uint lpdwProcessId;
				int windowThreadProcessId = (int)WindowsAPI.GetWindowThreadProcessId(hWnd, out lpdwProcessId);
				if ((long)lpdwProcessId == (long)pid)
					numList.Add(hWnd);
			}
			return numList;
		}

		[DllImport("user32.dll")]
		public static extern int GetClassName(IntPtr hWnd, StringBuilder lpClassName, int nMaxCount);

		[DllImport("user32.dll")]
		public static extern int GetWindowText(IntPtr hWnd, [Out] StringBuilder lpString, int nMaxCount);

		[DllImport("user32.dll")]
		public static extern bool SetWindowPos(
			IntPtr hWnd,
			IntPtr hWndInsertAfter,
			int X,
			int Y,
			int cx,
			int cy,
			uint wFlags);
		public enum SetWindowPosOp
		{
			SWP_NOSIZE = 1,
			SWP_SHOWWINDOW = 64, // 0x00000040
		}
		public enum ShowWindowOp
		{
			SW_HIDE = 0,
			SW_SHOW = 5,
		}
		[DllImport("user32.dll")]
		public static extern bool ShowWindow(IntPtr hWnd, ShowWindowOp nCmdShow);

		[DllImport("user32.dll", CharSet = CharSet.Auto)]
		public static extern IntPtr GetForegroundWindow();

		[DllImport("user32.dll")]
		public static extern bool SetForegroundWindow(IntPtr hWnd);

		[DllImport("wininet.dll")]
		private static extern bool InternetGetConnectedState(out int Description, int ReservedValue);

		public static bool isConnectedToInternet()
		{
			int Description;
			return WindowsAPI.InternetGetConnectedState(out Description, 0);
		}

		[DllImport("uxtheme.dll", CharSet = CharSet.Unicode)]
		public static extern int SetWindowTheme(IntPtr hwnd, string pszSubAppName, string pszSubIdList);

		[DllImport("user32.dll", CharSet = CharSet.Auto)]
		public static extern IntPtr SendMessage(IntPtr hWnd, int Msg, int wParam, int lParam);

		[DllImport("user32.dll")]
		public static extern bool PostMessage(IntPtr hWnd, int Msg, int wParam, int lParam);

		public static int MakeLong(int wLow, int wHigh)
		{
			return (int)WindowsAPI.IntLoWord(wLow) | 65536 * (int)WindowsAPI.IntLoWord(wHigh);
		}

		private static short IntLoWord(int word)
		{
			return (short)(word & (int)short.MaxValue);
		}

		[DllImport("psapi.dll", SetLastError = true)]
		[return: MarshalAs(UnmanagedType.Bool)]
		private static extern bool GetPerformanceInfo(
			out WindowsAPI.PerformanceInformation PerformanceInformation,
			[In] int Size);

		public static long GetPhysicalAvailableMemoryInMiB()
		{
			if (WindowsAPI.GetPerformanceInfo(out WindowsAPI.pi, Marshal.SizeOf((object)WindowsAPI.pi)))
				return Convert.ToInt64(WindowsAPI.pi.PhysicalAvailable.ToInt64() * WindowsAPI.pi.PageSize.ToInt64() / 1048576L);
			return 0;
		}

		public static long GetTotalMemoryInMiB()
		{
			if (WindowsAPI.GetPerformanceInfo(out WindowsAPI.pi, Marshal.SizeOf((object)WindowsAPI.pi)))
				return Convert.ToInt64(WindowsAPI.pi.PhysicalTotal.ToInt64() * WindowsAPI.pi.PageSize.ToInt64() / 1048576L);
			return 0;
		}

		[DllImport("user32.dll", CharSet = CharSet.Auto)]
		public static extern bool RegisterHotKey(IntPtr hWnd, int id, uint fsModifiers, int vk);

		[DllImport("user32.dll")]
		public static extern bool UnregisterHotKey(IntPtr hWnd, int id);

		[DllImport("psapi.dll")]
		public static extern bool EmptyWorkingSet(IntPtr hProcess);

		[DllImport("gdi32.dll")]
		public static extern IntPtr AddFontMemResourceEx(
			IntPtr pbFont,
			uint cbFont,
			IntPtr pdv,
			[In] ref uint pcFonts);

		private delegate bool EnumWindowsProc(IntPtr hWnd, IntPtr lParam);

		private struct PerformanceInformation
		{
			public int Size;
			public IntPtr CommitTotal;
			public IntPtr CommitLimit;
			public IntPtr CommitPeak;
			public IntPtr PhysicalTotal;
			public IntPtr PhysicalAvailable;
			public IntPtr SystemCache;
			public IntPtr KernelTotal;
			public IntPtr KernelPaged;
			public IntPtr KernelNonPaged;
			public IntPtr PageSize;
			public int HandlesCount;
			public int ProcessCount;
			public int ThreadCount;
		}
	}
}

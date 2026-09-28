using System;
using System.Buffers.Text;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlTypes;
using System.Linq;
using System.Runtime.Remoting.Messaging;
using System.Threading;
using Cpp2ILInjected;
using DG.Tweening;
using HuaweiMobileServices.Location.Location;
using Kammelna.Server;
using Kammelna.Server.Models.Clans;
using Newtonsoft.Json.Linq.JsonPath;
using Sfs2X.Entities.Data;
using Unity.Properties;
using Unity.Services.Authentication.Shared;
using UnityEngine;
using UnityEngine.AdaptivePerformance;
using UnityEngine.Device;
using UnityEngine.InputSystem.XR;
using UnityEngine.Purchasing.Telemetry;
using UnityEngine.ResourceManagement.Exceptions;

public static class Config
{
	[Serializable]
	private sealed class <>c
	{
		public static readonly <>c <>9;

		public static Func<SFSConfig, bool> <>9__56_0;

		public static Func<GameConfiguration, bool> <>9__58_0;

		public static Func<SFSConfig, bool> <>9__60_0;

		public static Func<SFSConfig, bool> <>9__62_0;

		public static Func<SFSConfig, bool> <>9__79_1;

		public static Func<SFSConfig, bool> <>9__80_0;

		public static Func<SFSConfig, bool> <>9__80_1;

		public static Func<SFSConfig, bool> <>9__80_2;

		public static Func<SFSConfig, bool> <>9__81_0;

		public static Func<SFSConfig, bool> <>9__81_1;

		public static Func<SFSConfig, int> <>9__82_0;

		public static Func<SFSConfig, int> <>9__82_1;

		public static Func<SFSConfig, int> <>9__83_0;

		public static Func<SFSConfig, bool> <>9__83_1;

		static <>c()
		{
			//IL_000f: Unknown result type (might be due to invalid IL or missing references)
			//IL_0014: Expected O, but got Unknown
			object obj = typeof(CardUtils.<>c) + 2160;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
			object obj2 = default(object);
			obj2..ctor();
			object obj3 = obj;
			object obj4 = obj2;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
		}

		internal bool <get_CurrentSFS>b__56_0(SFSConfig s)
		{
			//IL_0182: Expected I4, but got O
			//IL_0014: Unknown result type (might be due to invalid IL or missing references)
			//IL_0019: Expected O, but got Unknown
			//IL_00f7: Expected O, but got I
			//IL_0111: Expected O, but got I4
			//IL_005c: Expected O, but got I
			//IL_014f: Expected O, but got I4
			object obj;
			object obj6;
			object obj8;
			if (s != null)
			{
				obj = typeof(System.Runtime.Remoting.Messaging.CallContextSecurityData) + 2360;
				object obj2 = obj;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v46 @ X0_v3+E4]");
				if ((nint)0 != 0)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [91E721A]");
					object obj3 = (nint)0 & (nint)1;
					if (obj3 != null)
					{
						goto IL_0079;
					}
				}
				else
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [91E721A]");
					object obj4 = (nint)0 & (nint)1;
					bool flag = obj4 == null;
					object obj5 = !flag;
					if (obj5 != null)
					{
						goto IL_0079;
					}
				}
				_ = 1;
				obj6 = obj;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v98 @ X0_v12+E4]");
				bool flag2 = (nint)0 == 0;
				object obj7 = !flag2;
				obj8 = obj6;
				if (obj7 != null)
				{
					goto IL_00ae;
				}
				goto IL_0165;
			}
			NullReferenceException ex = new NullReferenceException();
			return (byte)(int)ex != 0;
			IL_0079:
			obj6 = obj;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v98 @ X0_v12+E4]");
			bool flag3 = (nint)0 == 0;
			obj8 = obj6;
			if (!flag3)
			{
				goto IL_00ae;
			}
			goto IL_0165;
			IL_0165:
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			goto IL_00ae;
			IL_00ae:
			string currentServerId = GetCurrentServerId();
			return s.<ID>k__BackingField == currentServerId;
		}

		internal bool <get_CurrentGameConfiguration>b__58_0(GameConfiguration g)
		{
			//IL_009d: Expected I4, but got O
			//IL_0014: Unknown result type (might be due to invalid IL or missing references)
			//IL_0019: Expected O, but got Unknown
			//IL_0043: Expected O, but got I4
			//IL_007b: Expected O, but got I4
			if (g != null)
			{
				object obj = typeof(System.Buffers.Text.ParserHelpers) + 1624;
				object obj2 = obj;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v42 @ X0_v3+E4]");
				bool flag = (nint)0 == 0;
				object obj3 = !flag;
				if (obj3 == null)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
				}
				Games currentGame = Preferences.CurrentGame;
				object obj4 = g.<Game>k__BackingField - currentGame;
				return obj4 == null;
			}
			NullReferenceException ex = new NullReferenceException();
			return (byte)(int)ex != 0;
		}

		internal bool <get_FTServerForCurrentGame>b__60_0(SFSConfig s)
		{
			//IL_00e3: Expected I4, but got O
			//IL_0046: Unknown result type (might be due to invalid IL or missing references)
			//IL_004b: Expected O, but got Unknown
			//IL_0075: Expected O, but got I4
			if (s != null)
			{
				if (!s.<IsFastTrack>k__BackingField)
				{
					return false;
				}
				List<Games> availableGames = s.AvailableGames;
				object obj = typeof(System.Buffers.Text.ParserHelpers) + 1624;
				object obj2 = obj;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v89 @ X0_v7+E4]");
				bool flag = (nint)0 == 0;
				object obj3 = !flag;
				if (obj3 == null)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
				}
				Games currentGame = Preferences.CurrentGame;
				if (availableGames != null)
				{
					return ((List<System.Int32Enum>)(object)availableGames).Contains((System.Int32Enum)currentGame);
				}
			}
			NullReferenceException ex = new NullReferenceException();
			return (byte)(int)ex != 0;
		}

		internal bool <get_RestrictedServerForCurrentGame>b__62_0(SFSConfig s)
		{
			//IL_00e3: Expected I4, but got O
			//IL_0046: Unknown result type (might be due to invalid IL or missing references)
			//IL_004b: Expected O, but got Unknown
			//IL_0075: Expected O, but got I4
			if (s != null)
			{
				if (!s.<IsRestricted>k__BackingField)
				{
					return false;
				}
				List<Games> availableGames = s.AvailableGames;
				object obj = typeof(System.Buffers.Text.ParserHelpers) + 1624;
				object obj2 = obj;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v89 @ X0_v7+E4]");
				bool flag = (nint)0 == 0;
				object obj3 = !flag;
				if (obj3 == null)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
				}
				Games currentGame = Preferences.CurrentGame;
				if (availableGames != null)
				{
					return ((List<System.Int32Enum>)(object)availableGames).Contains((System.Int32Enum)currentGame);
				}
			}
			NullReferenceException ex = new NullReferenceException();
			return (byte)(int)ex != 0;
		}

		internal bool <GetCurrentServerId>b__79_1(SFSConfig s)
		{
			//IL_0035: Expected I4, but got O
			if (s != null)
			{
				return s.<IsMain>k__BackingField;
			}
			NullReferenceException ex = new NullReferenceException();
			return (byte)(int)ex != 0;
		}

		internal bool <GetCurrentGameServers>b__80_0(SFSConfig s)
		{
			//IL_00b8: Expected I4, but got O
			//IL_0014: Unknown result type (might be due to invalid IL or missing references)
			//IL_0019: Expected O, but got Unknown
			//IL_0050: Expected O, but got I4
			if (s != null)
			{
				object obj = typeof(System.Buffers.Text.ParserHelpers) + 1624;
				List<Games> availableGames = s.AvailableGames;
				object obj2 = obj;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v56 @ X0_v6+E4]");
				bool flag = (nint)0 == 0;
				object obj3 = !flag;
				if (obj3 == null)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
				}
				Games currentGame = Preferences.CurrentGame;
				if (availableGames != null)
				{
					return ((List<System.Int32Enum>)(object)availableGames).Contains((System.Int32Enum)currentGame);
				}
			}
			NullReferenceException ex = new NullReferenceException();
			return (byte)(int)ex != 0;
		}

		internal bool <GetCurrentGameServers>b__80_1(SFSConfig s)
		{
			//IL_004c: Expected I4, but got O
			//IL_002b: Expected O, but got I4
			//IL_0034: Unknown result type (might be due to invalid IL or missing references)
			//IL_0039: Expected I4, but got Unknown
			if (s != null)
			{
				object obj = ~(s.<IsRestricted>k__BackingField ? 1 : 0);
				return (byte)(1 & obj) != 0;
			}
			NullReferenceException ex = new NullReferenceException();
			return (byte)(int)ex != 0;
		}

		internal bool <GetCurrentGameServers>b__80_2(SFSConfig s)
		{
			//IL_004c: Expected I4, but got O
			//IL_002b: Expected O, but got I4
			//IL_0034: Unknown result type (might be due to invalid IL or missing references)
			//IL_0039: Expected I4, but got Unknown
			if (s != null)
			{
				object obj = ~(s.<IsFastTrack>k__BackingField ? 1 : 0);
				return (byte)(1 & obj) != 0;
			}
			NullReferenceException ex = new NullReferenceException();
			return (byte)(int)ex != 0;
		}

		internal bool <GetAllServers>b__81_0(SFSConfig s)
		{
			//IL_004c: Expected I4, but got O
			//IL_002b: Expected O, but got I4
			//IL_0034: Unknown result type (might be due to invalid IL or missing references)
			//IL_0039: Expected I4, but got Unknown
			if (s != null)
			{
				object obj = ~(s.<IsRestricted>k__BackingField ? 1 : 0);
				return (byte)(1 & obj) != 0;
			}
			NullReferenceException ex = new NullReferenceException();
			return (byte)(int)ex != 0;
		}

		internal bool <GetAllServers>b__81_1(SFSConfig s)
		{
			//IL_004c: Expected I4, but got O
			//IL_002b: Expected O, but got I4
			//IL_0034: Unknown result type (might be due to invalid IL or missing references)
			//IL_0039: Expected I4, but got Unknown
			if (s != null)
			{
				object obj = ~(s.<IsFastTrack>k__BackingField ? 1 : 0);
				return (byte)(1 & obj) != 0;
			}
			NullReferenceException ex = new NullReferenceException();
			return (byte)(int)ex != 0;
		}

		internal int <Validate>b__82_0(SFSConfig i)
		{
			//IL_0035: Expected I4, but got O
			if (i != null)
			{
				return i.<OnlineUsers>k__BackingField;
			}
			NullReferenceException ex = new NullReferenceException();
			return (int)ex;
		}

		internal int <Validate>b__82_1(SFSConfig i)
		{
			//IL_0035: Expected I4, but got O
			if (i != null)
			{
				return i.<OnlineUsers>k__BackingField;
			}
			NullReferenceException ex = new NullReferenceException();
			return (int)ex;
		}

		internal int <SwitchToDefaultServer>b__83_0(SFSConfig i)
		{
			//IL_0035: Expected I4, but got O
			if (i != null)
			{
				return i.<OnlineUsers>k__BackingField;
			}
			NullReferenceException ex = new NullReferenceException();
			return (int)ex;
		}

		internal bool <SwitchToDefaultServer>b__83_1(SFSConfig s)
		{
			//IL_0182: Expected I4, but got O
			//IL_0014: Unknown result type (might be due to invalid IL or missing references)
			//IL_0019: Expected O, but got Unknown
			//IL_00f7: Expected O, but got I
			//IL_0111: Expected O, but got I4
			//IL_005c: Expected O, but got I
			//IL_014f: Expected O, but got I4
			object obj;
			object obj6;
			object obj8;
			if (s != null)
			{
				obj = typeof(System.Runtime.Remoting.Messaging.CallContextSecurityData) + 2360;
				object obj2 = obj;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v46 @ X0_v3+E4]");
				if ((nint)0 != 0)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [91E721A]");
					object obj3 = (nint)0 & (nint)1;
					if (obj3 != null)
					{
						goto IL_0079;
					}
				}
				else
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [91E721A]");
					object obj4 = (nint)0 & (nint)1;
					bool flag = obj4 == null;
					object obj5 = !flag;
					if (obj5 != null)
					{
						goto IL_0079;
					}
				}
				_ = 1;
				obj6 = obj;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v98 @ X0_v12+E4]");
				bool flag2 = (nint)0 == 0;
				object obj7 = !flag2;
				obj8 = obj6;
				if (obj7 != null)
				{
					goto IL_00ae;
				}
				goto IL_0165;
			}
			NullReferenceException ex = new NullReferenceException();
			return (byte)(int)ex != 0;
			IL_0079:
			obj6 = obj;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v98 @ X0_v12+E4]");
			bool flag3 = (nint)0 == 0;
			obj8 = obj6;
			if (!flag3)
			{
				goto IL_00ae;
			}
			goto IL_0165;
			IL_0165:
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			goto IL_00ae;
			IL_00ae:
			string currentServerId = GetCurrentServerId();
			return s.<ID>k__BackingField != currentServerId;
		}
	}

	private sealed class <>c__DisplayClass79_0
	{
		public string savedServerId;

		internal bool <GetCurrentServerId>b__0(SFSConfig s)
		{
			//IL_0048: Expected I4, but got O
			if (s != null)
			{
				return s.<ID>k__BackingField == savedServerId;
			}
			NullReferenceException ex = new NullReferenceException();
			return (byte)(int)ex != 0;
		}
	}

	private static KammelnaConfigLoader <Loader>k__BackingField;

	private static List<SFSConfig> <Servers>k__BackingField;

	private static MaintenanceInfo <Maintenance>k__BackingField;

	private static PlatformConfiguration <ForcedVersion>k__BackingField;

	private static PlatformConfiguration <DownMessage>k__BackingField;

	private static string <BlobHost>k__BackingField;

	private static string <SignalRServerUrl>k__BackingField;

	private const string DevelopmentHostPrefKey = "DevelopmentHostOverride";

	private static string _bakedLocalHostUrl;

	private static bool <BackendSwitchPending>k__BackingField;

	private static readonly string _unityCachePath;

	private static ServerEnvironment _lastKnownEnvironment;

	private static KammelnaConfigLoader Loader
	{
		get
		{
			//IL_0009: Expected O, but got I4
			//IL_0018: Unknown result type (might be due to invalid IL or missing references)
			//IL_001d: Expected O, but got Unknown
			//IL_0033: Expected O, but got I
			//IL_00ca: Expected O, but got I4
			//IL_0095: Expected O, but got I
			//IL_0102: Expected O, but got I
			object obj = 152989696;
			object obj2 = typeof(System.Runtime.Remoting.Messaging.CallContextSecurityData) + 2360;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [91E70DF]");
			object obj3 = (nint)0 & (nint)1;
			if (obj3 != null)
			{
				object obj4 = obj2;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v37 @ X0_v9+E4]");
				bool flag = (nint)0 == 0;
				object obj5 = obj4;
				if (!flag)
				{
					goto IL_0085;
				}
			}
			else
			{
				_ = 1;
				object obj4 = obj2;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v37 @ X0_v9+E4]");
				bool flag2 = (nint)0 == 0;
				object obj6 = !flag2;
				object obj5 = obj4;
				if (obj6 != null)
				{
					goto IL_0085;
				}
			}
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			object obj7 = obj2;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v68 @ X0_v3+B8]");
			return (KammelnaConfigLoader)0;
			IL_0085:
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v37 @ X0_v9+B8]");
			return (KammelnaConfigLoader)0;
		}
		set
		{
			//IL_000f: Unknown result type (might be due to invalid IL or missing references)
			//IL_0014: Expected O, but got Unknown
			//IL_005a: Expected O, but got I4
			object obj = typeof(System.Runtime.Remoting.Messaging.CallContextSecurityData) + 2360;
			object obj2 = obj;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v49 @ X0_v3+E4]");
			bool flag = (nint)0 == 0;
			object obj3 = !flag;
			if (obj3 == null)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
				obj2 = obj;
			}
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
		}
	}

	public static List<SFSConfig> Servers
	{
		get
		{
			//IL_0009: Expected O, but got I4
			//IL_0018: Unknown result type (might be due to invalid IL or missing references)
			//IL_001d: Expected O, but got Unknown
			//IL_0033: Expected O, but got I
			//IL_00d2: Expected O, but got I4
			//IL_0095: Expected O, but got I
			//IL_00a2: Expected O, but got I
			//IL_010a: Expected O, but got I
			//IL_0117: Expected O, but got I
			object obj = 152989696;
			object obj2 = typeof(System.Runtime.Remoting.Messaging.CallContextSecurityData) + 2360;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [91E70E1]");
			object obj3 = (nint)0 & (nint)1;
			if (obj3 != null)
			{
				object obj4 = obj2;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v37 @ X0_v9+E4]");
				bool flag = (nint)0 == 0;
				object obj5 = obj4;
				if (!flag)
				{
					goto IL_0085;
				}
			}
			else
			{
				_ = 1;
				object obj4 = obj2;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v37 @ X0_v9+E4]");
				bool flag2 = (nint)0 == 0;
				object obj6 = !flag2;
				object obj5 = obj4;
				if (obj6 != null)
				{
					goto IL_0085;
				}
			}
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			object obj7 = obj2;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v68 @ X0_v3+B8]");
			object obj8 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v63 @ X8_v3+8]");
			return (List<SFSConfig>)0;
			IL_0085:
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v37 @ X0_v9+B8]");
			object obj9 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v43 @ X8_v7+8]");
			return (List<SFSConfig>)0;
		}
		set
		{
			//IL_000f: Unknown result type (might be due to invalid IL or missing references)
			//IL_0014: Expected O, but got Unknown
			//IL_005a: Expected O, but got I4
			//IL_007e: Expected O, but got I
			object obj = typeof(System.Runtime.Remoting.Messaging.CallContextSecurityData) + 2360;
			object obj2 = obj;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v49 @ X0_v3+E4]");
			bool flag = (nint)0 == 0;
			object obj3 = !flag;
			if (obj3 == null)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
				obj2 = obj;
			}
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v49 @ X0_v3+B8]");
			object obj4 = (nint)0 + (nint)8;
			obj4 = value;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
		}
	}

	public static MaintenanceInfo Maintenance
	{
		get
		{
			//IL_0009: Expected O, but got I4
			//IL_0018: Unknown result type (might be due to invalid IL or missing references)
			//IL_001d: Expected O, but got Unknown
			//IL_0033: Expected O, but got I
			//IL_00d2: Expected O, but got I4
			//IL_0095: Expected O, but got I
			//IL_00a2: Expected O, but got I
			//IL_010a: Expected O, but got I
			//IL_0117: Expected O, but got I
			object obj = 152989696;
			object obj2 = typeof(System.Runtime.Remoting.Messaging.CallContextSecurityData) + 2360;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [91E70E3]");
			object obj3 = (nint)0 & (nint)1;
			if (obj3 != null)
			{
				object obj4 = obj2;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v37 @ X0_v9+E4]");
				bool flag = (nint)0 == 0;
				object obj5 = obj4;
				if (!flag)
				{
					goto IL_0085;
				}
			}
			else
			{
				_ = 1;
				object obj4 = obj2;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v37 @ X0_v9+E4]");
				bool flag2 = (nint)0 == 0;
				object obj6 = !flag2;
				object obj5 = obj4;
				if (obj6 != null)
				{
					goto IL_0085;
				}
			}
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			object obj7 = obj2;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v68 @ X0_v3+B8]");
			object obj8 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v63 @ X8_v3+10]");
			return (MaintenanceInfo)0;
			IL_0085:
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v37 @ X0_v9+B8]");
			object obj9 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v43 @ X8_v7+10]");
			return (MaintenanceInfo)0;
		}
		set
		{
			//IL_000f: Unknown result type (might be due to invalid IL or missing references)
			//IL_0014: Expected O, but got Unknown
			//IL_005a: Expected O, but got I4
			//IL_007e: Expected O, but got I
			object obj = typeof(System.Runtime.Remoting.Messaging.CallContextSecurityData) + 2360;
			object obj2 = obj;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v49 @ X0_v3+E4]");
			bool flag = (nint)0 == 0;
			object obj3 = !flag;
			if (obj3 == null)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
				obj2 = obj;
			}
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v49 @ X0_v3+B8]");
			object obj4 = (nint)0 + (nint)16;
			obj4 = value;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
		}
	}

	public static PlatformConfiguration ForcedVersion
	{
		get
		{
			//IL_0009: Expected O, but got I4
			//IL_0018: Unknown result type (might be due to invalid IL or missing references)
			//IL_001d: Expected O, but got Unknown
			//IL_0033: Expected O, but got I
			//IL_00d2: Expected O, but got I4
			//IL_0095: Expected O, but got I
			//IL_00a2: Expected O, but got I
			//IL_010a: Expected O, but got I
			//IL_0117: Expected O, but got I
			object obj = 152989696;
			object obj2 = typeof(System.Runtime.Remoting.Messaging.CallContextSecurityData) + 2360;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [91E70E5]");
			object obj3 = (nint)0 & (nint)1;
			if (obj3 != null)
			{
				object obj4 = obj2;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v37 @ X0_v9+E4]");
				bool flag = (nint)0 == 0;
				object obj5 = obj4;
				if (!flag)
				{
					goto IL_0085;
				}
			}
			else
			{
				_ = 1;
				object obj4 = obj2;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v37 @ X0_v9+E4]");
				bool flag2 = (nint)0 == 0;
				object obj6 = !flag2;
				object obj5 = obj4;
				if (obj6 != null)
				{
					goto IL_0085;
				}
			}
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			object obj7 = obj2;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v68 @ X0_v3+B8]");
			object obj8 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v63 @ X8_v3+18]");
			return (PlatformConfiguration)0;
			IL_0085:
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v37 @ X0_v9+B8]");
			object obj9 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v43 @ X8_v7+18]");
			return (PlatformConfiguration)0;
		}
		set
		{
			//IL_000f: Unknown result type (might be due to invalid IL or missing references)
			//IL_0014: Expected O, but got Unknown
			//IL_005a: Expected O, but got I4
			//IL_007e: Expected O, but got I
			object obj = typeof(System.Runtime.Remoting.Messaging.CallContextSecurityData) + 2360;
			object obj2 = obj;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v49 @ X0_v3+E4]");
			bool flag = (nint)0 == 0;
			object obj3 = !flag;
			if (obj3 == null)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
				obj2 = obj;
			}
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v49 @ X0_v3+B8]");
			object obj4 = (nint)0 + (nint)24;
			obj4 = value;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
		}
	}

	public static PlatformConfiguration DownMessage
	{
		get
		{
			//IL_0009: Expected O, but got I4
			//IL_0018: Unknown result type (might be due to invalid IL or missing references)
			//IL_001d: Expected O, but got Unknown
			//IL_0033: Expected O, but got I
			//IL_00d2: Expected O, but got I4
			//IL_0095: Expected O, but got I
			//IL_00a2: Expected O, but got I
			//IL_010a: Expected O, but got I
			//IL_0117: Expected O, but got I
			object obj = 152989696;
			object obj2 = typeof(System.Runtime.Remoting.Messaging.CallContextSecurityData) + 2360;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [91E70E7]");
			object obj3 = (nint)0 & (nint)1;
			if (obj3 != null)
			{
				object obj4 = obj2;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v37 @ X0_v9+E4]");
				bool flag = (nint)0 == 0;
				object obj5 = obj4;
				if (!flag)
				{
					goto IL_0085;
				}
			}
			else
			{
				_ = 1;
				object obj4 = obj2;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v37 @ X0_v9+E4]");
				bool flag2 = (nint)0 == 0;
				object obj6 = !flag2;
				object obj5 = obj4;
				if (obj6 != null)
				{
					goto IL_0085;
				}
			}
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			object obj7 = obj2;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v68 @ X0_v3+B8]");
			object obj8 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v63 @ X8_v3+20]");
			return (PlatformConfiguration)0;
			IL_0085:
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v37 @ X0_v9+B8]");
			object obj9 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v43 @ X8_v7+20]");
			return (PlatformConfiguration)0;
		}
		set
		{
			//IL_000f: Unknown result type (might be due to invalid IL or missing references)
			//IL_0014: Expected O, but got Unknown
			//IL_005a: Expected O, but got I4
			//IL_007e: Expected O, but got I
			object obj = typeof(System.Runtime.Remoting.Messaging.CallContextSecurityData) + 2360;
			object obj2 = obj;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v49 @ X0_v3+E4]");
			bool flag = (nint)0 == 0;
			object obj3 = !flag;
			if (obj3 == null)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
				obj2 = obj;
			}
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v49 @ X0_v3+B8]");
			object obj4 = (nint)0 + (nint)32;
			obj4 = value;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
		}
	}

	public static string BlobHost
	{
		get
		{
			//IL_0009: Expected O, but got I4
			//IL_0018: Unknown result type (might be due to invalid IL or missing references)
			//IL_001d: Expected O, but got Unknown
			//IL_0033: Expected O, but got I
			//IL_00d2: Expected O, but got I4
			//IL_0095: Expected O, but got I
			//IL_00a2: Expected O, but got I
			//IL_010a: Expected O, but got I
			//IL_0117: Expected O, but got I
			object obj = 152989696;
			object obj2 = typeof(System.Runtime.Remoting.Messaging.CallContextSecurityData) + 2360;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [91E70E9]");
			object obj3 = (nint)0 & (nint)1;
			if (obj3 != null)
			{
				object obj4 = obj2;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v37 @ X0_v9+E4]");
				bool flag = (nint)0 == 0;
				object obj5 = obj4;
				if (!flag)
				{
					goto IL_0085;
				}
			}
			else
			{
				_ = 1;
				object obj4 = obj2;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v37 @ X0_v9+E4]");
				bool flag2 = (nint)0 == 0;
				object obj6 = !flag2;
				object obj5 = obj4;
				if (obj6 != null)
				{
					goto IL_0085;
				}
			}
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			object obj7 = obj2;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v68 @ X0_v3+B8]");
			object obj8 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v63 @ X8_v3+28]");
			return (string)0;
			IL_0085:
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v37 @ X0_v9+B8]");
			object obj9 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v43 @ X8_v7+28]");
			return (string)0;
		}
		set
		{
			//IL_000f: Unknown result type (might be due to invalid IL or missing references)
			//IL_0014: Expected O, but got Unknown
			//IL_005a: Expected O, but got I4
			//IL_007e: Expected O, but got I
			object obj = typeof(System.Runtime.Remoting.Messaging.CallContextSecurityData) + 2360;
			object obj2 = obj;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v49 @ X0_v3+E4]");
			bool flag = (nint)0 == 0;
			object obj3 = !flag;
			if (obj3 == null)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
				obj2 = obj;
			}
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v49 @ X0_v3+B8]");
			object obj4 = (nint)0 + (nint)40;
			obj4 = value;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
		}
	}

	public static string SignalRServerUrl
	{
		get
		{
			//IL_0009: Expected O, but got I4
			//IL_0018: Unknown result type (might be due to invalid IL or missing references)
			//IL_001d: Expected O, but got Unknown
			//IL_0033: Expected O, but got I
			//IL_00d2: Expected O, but got I4
			//IL_0095: Expected O, but got I
			//IL_00a2: Expected O, but got I
			//IL_010a: Expected O, but got I
			//IL_0117: Expected O, but got I
			object obj = 152989696;
			object obj2 = typeof(System.Runtime.Remoting.Messaging.CallContextSecurityData) + 2360;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [91E70EB]");
			object obj3 = (nint)0 & (nint)1;
			if (obj3 != null)
			{
				object obj4 = obj2;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v37 @ X0_v9+E4]");
				bool flag = (nint)0 == 0;
				object obj5 = obj4;
				if (!flag)
				{
					goto IL_0085;
				}
			}
			else
			{
				_ = 1;
				object obj4 = obj2;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v37 @ X0_v9+E4]");
				bool flag2 = (nint)0 == 0;
				object obj6 = !flag2;
				object obj5 = obj4;
				if (obj6 != null)
				{
					goto IL_0085;
				}
			}
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			object obj7 = obj2;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v68 @ X0_v3+B8]");
			object obj8 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v63 @ X8_v3+30]");
			return (string)0;
			IL_0085:
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v37 @ X0_v9+B8]");
			object obj9 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v43 @ X8_v7+30]");
			return (string)0;
		}
		set
		{
			//IL_000f: Unknown result type (might be due to invalid IL or missing references)
			//IL_0014: Expected O, but got Unknown
			//IL_005a: Expected O, but got I4
			//IL_007e: Expected O, but got I
			object obj = typeof(System.Runtime.Remoting.Messaging.CallContextSecurityData) + 2360;
			object obj2 = obj;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v49 @ X0_v3+E4]");
			bool flag = (nint)0 == 0;
			object obj3 = !flag;
			if (obj3 == null)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
				obj2 = obj;
			}
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v49 @ X0_v3+B8]");
			object obj4 = (nint)0 + (nint)48;
			obj4 = value;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
		}
	}

	public static bool IsInitialized
	{
		get
		{
			//IL_0009: Expected O, but got I4
			//IL_0018: Unknown result type (might be due to invalid IL or missing references)
			//IL_001d: Expected O, but got Unknown
			//IL_0033: Expected O, but got I
			//IL_0144: Expected O, but got I4
			//IL_0093: Expected O, but got I
			//IL_01ca: Expected O, but got I4
			//IL_0172: Expected O, but got I
			//IL_018c: Expected O, but got I4
			//IL_00f5: Expected O, but got I
			object obj = 152989696;
			object obj2 = typeof(System.Runtime.Remoting.Messaging.CallContextSecurityData) + 2360;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [91E7219]");
			object obj3 = (nint)0 & (nint)1;
			if (obj3 != null)
			{
				object obj4 = obj2;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v47 @ X0_v9+E4]");
				if ((nint)0 != 0)
				{
					goto IL_007d;
				}
			}
			else
			{
				_ = 1;
				object obj4 = obj2;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v47 @ X0_v9+E4]");
				bool flag = (nint)0 == 0;
				object obj5 = !flag;
				if (obj5 != null)
				{
					goto IL_007d;
				}
			}
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [8BE45C6]");
			object obj6 = (nint)0 & (nint)1;
			bool flag2 = obj6 == null;
			object obj7 = !flag2;
			if (obj7 != null)
			{
				goto IL_00b0;
			}
			goto IL_019a;
			IL_00e5:
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v72 @ X0_v15+B8]");
			object obj8 = 0;
			bool flag3 = obj8 == null;
			return !flag3;
			IL_01e0:
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			object obj9 = obj2;
			goto IL_00e5;
			IL_00b0:
			obj9 = obj2;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v72 @ X0_v15+E4]");
			bool flag4 = (nint)0 == 0;
			object obj10 = obj9;
			if (!flag4)
			{
				goto IL_00e5;
			}
			goto IL_01e0;
			IL_007d:
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [8BE45C6]");
			object obj11 = (nint)0 & (nint)1;
			if (obj11 != null)
			{
				goto IL_00b0;
			}
			goto IL_019a;
			IL_019a:
			_ = 1;
			obj9 = obj2;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v72 @ X0_v15+E4]");
			bool flag5 = (nint)0 == 0;
			object obj12 = !flag5;
			obj10 = obj9;
			if (obj12 != null)
			{
				goto IL_00e5;
			}
			goto IL_01e0;
		}
	}

	public static string ServerID
	{
		get
		{
			//IL_000f: Unknown result type (might be due to invalid IL or missing references)
			//IL_0014: Expected O, but got Unknown
			//IL_002a: Expected O, but got I
			//IL_00ba: Expected O, but got I4
			object obj = typeof(System.Runtime.Remoting.Messaging.CallContextSecurityData) + 2360;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [91E721A]");
			object obj2 = (nint)0 & (nint)1;
			if (obj2 != null)
			{
				object obj3 = obj;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v37 @ X0_v8+E4]");
				bool flag = (nint)0 == 0;
				object obj4 = obj3;
				if (!flag)
				{
					goto IL_007c;
				}
			}
			else
			{
				_ = 1;
				object obj3 = obj;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v37 @ X0_v8+E4]");
				bool flag2 = (nint)0 == 0;
				object obj5 = !flag2;
				object obj4 = obj3;
				if (obj5 != null)
				{
					goto IL_007c;
				}
			}
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			return GetCurrentServerId();
			IL_007c:
			return GetCurrentServerId();
		}
		set
		{
			//IL_000a: Unknown result type (might be due to invalid IL or missing references)
			//IL_000f: Expected O, but got Unknown
			object key = "SERVICE_DISABLED" + 3488;
			Prefs.SetString((string)key, value);
		}
	}

	public static bool IsProduction
	{
		get
		{
			//IL_000f: Unknown result type (might be due to invalid IL or missing references)
			//IL_0014: Expected O, but got Unknown
			//IL_002a: Expected O, but got I
			//IL_0151: Expected O, but got I4
			//IL_008a: Expected O, but got I
			//IL_01d7: Expected O, but got I4
			//IL_017f: Expected O, but got I
			//IL_0199: Expected O, but got I4
			//IL_00ec: Expected O, but got I
			//IL_010e: Expected O, but got I4
			//IL_0244: Expected O, but got I
			//IL_020f: Expected O, but got I
			//IL_0293: Expected I4, but got O
			object obj = typeof(System.Runtime.Remoting.Messaging.CallContextSecurityData) + 2360;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [91E70F1]");
			object obj2 = (nint)0 & (nint)1;
			if (obj2 != null)
			{
				object obj3 = obj;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v47 @ X0_v13+E4]");
				if ((nint)0 != 0)
				{
					goto IL_0074;
				}
			}
			else
			{
				_ = 1;
				object obj3 = obj;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v47 @ X0_v13+E4]");
				bool flag = (nint)0 == 0;
				object obj4 = !flag;
				if (obj4 != null)
				{
					goto IL_0074;
				}
			}
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [8BE45C6]");
			object obj5 = (nint)0 & (nint)1;
			bool flag2 = obj5 == null;
			object obj6 = !flag2;
			if (obj6 != null)
			{
				goto IL_00a7;
			}
			goto IL_01a7;
			IL_0285:
			NullReferenceException ex = new NullReferenceException();
			return (byte)(int)ex != 0;
			IL_0234:
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v94 @ X8_v3+18]");
			object obj7 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v94 @ X8_v3+18]");
			if ((nint)0 != 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v97 @ X8_v4+18]");
				return (nint)0 == 0;
			}
			goto IL_0285;
			IL_00dc:
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v72 @ X0_v19+B8]");
			object obj8 = 0;
			object obj9 = obj8;
			bool flag3 = obj8 == null;
			object obj10 = !flag3;
			if (obj10 != null)
			{
				goto IL_0234;
			}
			goto IL_0285;
			IL_0074:
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [8BE45C6]");
			object obj11 = (nint)0 & (nint)1;
			if (obj11 != null)
			{
				goto IL_00a7;
			}
			goto IL_01a7;
			IL_01a7:
			_ = 1;
			object obj12 = obj;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v72 @ X0_v19+E4]");
			bool flag4 = (nint)0 == 0;
			object obj13 = !flag4;
			object obj14 = obj12;
			if (obj13 != null)
			{
				goto IL_00dc;
			}
			goto IL_01ed;
			IL_00a7:
			obj12 = obj;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v72 @ X0_v19+E4]");
			bool flag5 = (nint)0 == 0;
			obj14 = obj12;
			if (!flag5)
			{
				goto IL_00dc;
			}
			goto IL_01ed;
			IL_01ed:
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			object obj15 = obj;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v91 @ X0_v7+B8]");
			object obj16 = 0;
			obj9 = obj16;
			if (obj16 != null)
			{
				goto IL_0234;
			}
			goto IL_0285;
		}
	}

	public static string BackendURL
	{
		get
		{
			//IL_000f: Unknown result type (might be due to invalid IL or missing references)
			//IL_0014: Expected O, but got Unknown
			//IL_002a: Expected O, but got I
			//IL_0151: Expected O, but got I4
			//IL_008a: Expected O, but got I
			//IL_01d7: Expected O, but got I4
			//IL_017f: Expected O, but got I
			//IL_0199: Expected O, but got I4
			//IL_00ec: Expected O, but got I
			//IL_010e: Expected O, but got I4
			//IL_022c: Expected O, but got I
			//IL_020f: Expected O, but got I
			//IL_02da: Unknown result type (might be due to invalid IL or missing references)
			//IL_02df: Expected O, but got Unknown
			//IL_02c7: Unknown result type (might be due to invalid IL or missing references)
			//IL_02cc: Expected O, but got Unknown
			//IL_029d: Expected O, but got I4
			//IL_02fe: Unknown result type (might be due to invalid IL or missing references)
			//IL_0303: Expected O, but got Unknown
			//IL_0331: Expected O, but got I
			//IL_02b4: Unknown result type (might be due to invalid IL or missing references)
			//IL_02b9: Expected O, but got Unknown
			object obj = typeof(System.Runtime.Remoting.Messaging.CallContextSecurityData) + 2360;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [91E70F2]");
			object obj2 = (nint)0 & (nint)1;
			if (obj2 != null)
			{
				object obj3 = obj;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v47 @ X0_v25+E4]");
				if ((nint)0 != 0)
				{
					goto IL_0074;
				}
			}
			else
			{
				_ = 1;
				object obj3 = obj;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v47 @ X0_v25+E4]");
				bool flag = (nint)0 == 0;
				object obj4 = !flag;
				if (obj4 != null)
				{
					goto IL_0074;
				}
			}
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [8BE45C6]");
			object obj5 = (nint)0 & (nint)1;
			bool flag2 = obj5 == null;
			object obj6 = !flag2;
			if (obj6 != null)
			{
				goto IL_00a7;
			}
			goto IL_01a7;
			IL_021c:
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v94 @ X8_v4+18]");
			object obj7 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v97 @ X9_v3+18]");
			object obj9;
			if ((nint)0 != 2)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v97 @ X9_v3+18]");
				if ((nint)0 != 1)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v97 @ X9_v3+18]");
					bool flag3 = (nint)0 == 0;
					object obj8 = !flag3;
					if (obj8 == null)
					{
						return (string)(obj9 + 32);
					}
					object obj10 = typeof(Unity.Services.Authentication.Shared.ApiConfiguration) + 656;
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC17CC");
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
					ArgumentOutOfRangeException ex = default(ArgumentOutOfRangeException);
					ex..ctor();
					object obj11 = (nint)0 + (nint)3472;
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC17CC");
					return (string)(object)new OutOfMemoryException();
				}
				return (string)(obj9 + 40);
			}
			return (string)(obj7 + 32);
			IL_00dc:
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v72 @ X0_v31+B8]");
			object obj12 = 0;
			obj9 = obj12;
			bool flag4 = obj12 == null;
			object obj13 = !flag4;
			if (obj13 == null)
			{
				throw new NullReferenceException();
			}
			goto IL_021c;
			IL_01ed:
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			object obj14 = obj;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v91 @ X0_v19+B8]");
			object obj15 = 0;
			obj9 = obj15;
			goto IL_021c;
			IL_0074:
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [8BE45C6]");
			object obj16 = (nint)0 & (nint)1;
			if (obj16 != null)
			{
				goto IL_00a7;
			}
			goto IL_01a7;
			IL_01a7:
			_ = 1;
			object obj17 = obj;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v72 @ X0_v31+E4]");
			bool flag5 = (nint)0 == 0;
			object obj18 = !flag5;
			object obj19 = obj17;
			if (obj18 != null)
			{
				goto IL_00dc;
			}
			goto IL_01ed;
			IL_00a7:
			obj17 = obj;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v72 @ X0_v31+E4]");
			bool flag6 = (nint)0 == 0;
			obj19 = obj17;
			if (!flag6)
			{
				goto IL_00dc;
			}
			goto IL_01ed;
		}
	}

	public static bool BackendSwitchPending
	{
		get
		{
			//IL_0009: Expected O, but got I4
			//IL_0018: Unknown result type (might be due to invalid IL or missing references)
			//IL_001d: Expected O, but got Unknown
			//IL_002c: Unknown result type (might be due to invalid IL or missing references)
			//IL_0031: Expected O, but got Unknown
			//IL_00d0: Expected O, but got I4
			//IL_0093: Expected O, but got I
			//IL_0108: Expected O, but got I
			object obj = 152989696;
			object obj2 = typeof(System.Runtime.Remoting.Messaging.CallContextSecurityData) + 2360;
			object obj3 = typeof(SFS.<>c) & 1;
			if (obj3 != null)
			{
				object obj4 = obj2;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v37 @ X0_v9+E4]");
				bool flag = (nint)0 == 0;
				object obj5 = obj4;
				if (!flag)
				{
					goto IL_0083;
				}
			}
			else
			{
				_ = 1;
				object obj4 = obj2;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v37 @ X0_v9+E4]");
				bool flag2 = (nint)0 == 0;
				object obj6 = !flag2;
				object obj5 = obj4;
				if (obj6 != null)
				{
					goto IL_0083;
				}
			}
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			object obj7 = obj2;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v68 @ X0_v3+B8]");
			object obj8 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v63 @ X8_v3+50]");
			return false;
			IL_0083:
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v37 @ X0_v9+B8]");
			object obj9 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v43 @ X8_v7+50]");
			return false;
		}
		set
		{
			//IL_000f: Unknown result type (might be due to invalid IL or missing references)
			//IL_0014: Expected O, but got Unknown
			//IL_002a: Expected O, but got I
			//IL_00c2: Expected O, but got I4
			//IL_008c: Expected O, but got I
			//IL_00fa: Expected O, but got I
			object obj = typeof(System.Runtime.Remoting.Messaging.CallContextSecurityData) + 2360;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [91E70F4]");
			object obj2 = (nint)0 & (nint)1;
			if (obj2 != null)
			{
				object obj3 = obj;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v43 @ X0_v8+E4]");
				bool flag = (nint)0 == 0;
				object obj4 = obj3;
				if (!flag)
				{
					goto IL_007c;
				}
			}
			else
			{
				_ = 1;
				object obj3 = obj;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v43 @ X0_v8+E4]");
				bool flag2 = (nint)0 == 0;
				object obj5 = !flag2;
				object obj4 = obj3;
				if (obj5 != null)
				{
					goto IL_007c;
				}
			}
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			object obj6 = obj;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v67 @ X0_v3+B8]");
			object obj7 = 0;
			return;
			IL_007c:
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v43 @ X0_v8+B8]");
			object obj8 = 0;
		}
	}

	private static ServerEnvironment _environmentFolder
	{
		get
		{
			//IL_000f: Unknown result type (might be due to invalid IL or missing references)
			//IL_0014: Expected O, but got Unknown
			//IL_002a: Expected O, but got I
			//IL_02a5: Expected O, but got I4
			//IL_008a: Expected O, but got I
			//IL_032b: Expected O, but got I4
			//IL_02d3: Expected O, but got I
			//IL_02ed: Expected O, but got I4
			//IL_00ea: Expected O, but got I
			//IL_0102: Expected O, but got I4
			//IL_010b: Expected O, but got I4
			//IL_03c3: Expected O, but got I4
			//IL_0359: Expected O, but got I
			//IL_0373: Expected O, but got I4
			//IL_037c: Expected O, but got I4
			//IL_0385: Expected O, but got I4
			//IL_0166: Expected O, but got I
			//IL_0176: Expected O, but got I
			//IL_0195: Expected O, but got I
			//IL_0475: Expected O, but got I4
			//IL_0403: Expected O, but got I
			//IL_0413: Expected O, but got I
			//IL_042d: Expected O, but got I4
			//IL_0445: Expected O, but got I
			//IL_05d6: Unknown result type (might be due to invalid IL or missing references)
			//IL_05db: Expected O, but got Unknown
			//IL_05e0: Expected I4, but got O
			//IL_04a5: Expected O, but got I
			//IL_04ca: Expected O, but got I
			//IL_04e4: Expected O, but got I4
			//IL_01de: Expected O, but got I
			//IL_055a: Expected O, but got I
			//IL_0522: Expected O, but got I4
			//IL_05cd: Expected I4, but got O
			//IL_0240: Expected O, but got I
			//IL_0262: Expected O, but got I4
			//IL_05ba: Expected O, but got I
			//IL_05bf: Expected I4, but got O
			object obj = typeof(System.Runtime.Remoting.Messaging.CallContextSecurityData) + 2360;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [91E721C]");
			object obj2 = (nint)0 & (nint)1;
			if (obj2 != null)
			{
				object obj3 = obj;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v47 @ X0_v20+E4]");
				if ((nint)0 != 0)
				{
					goto IL_0074;
				}
			}
			else
			{
				_ = 1;
				object obj3 = obj;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v47 @ X0_v20+E4]");
				bool flag = (nint)0 == 0;
				object obj4 = !flag;
				if (obj4 != null)
				{
					goto IL_0074;
				}
			}
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [91E7219]");
			object obj5 = (nint)0 & (nint)1;
			bool flag2 = obj5 == null;
			object obj6 = !flag2;
			if (obj6 != null)
			{
				goto IL_00a7;
			}
			goto IL_02fb;
			IL_01fb:
			object obj7 = obj;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v198 @ X0_v40+E4]");
			bool flag3 = (nint)0 == 0;
			object obj8 = obj7;
			if (!flag3)
			{
				goto IL_0230;
			}
			goto IL_0538;
			IL_0538:
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			object obj9 = obj;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v215 @ X0_v33+B8]");
			object obj10 = 0;
			object obj11 = obj10;
			if (obj10 != null)
			{
				goto IL_057f;
			}
			goto IL_05bf;
			IL_0230:
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v198 @ X0_v40+B8]");
			object obj12 = 0;
			obj11 = obj12;
			bool flag4 = obj12 == null;
			object obj13 = !flag4;
			if (obj13 != null)
			{
				goto IL_057f;
			}
			goto IL_05bf;
			IL_0074:
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [91E7219]");
			object obj14 = (nint)0 & (nint)1;
			if (obj14 != null)
			{
				goto IL_00a7;
			}
			goto IL_02fb;
			IL_02fb:
			_ = 1;
			object obj15 = obj;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v83 @ X0_v13+E4]");
			bool flag5 = (nint)0 == 0;
			object obj16 = !flag5;
			if (obj16 != null)
			{
				goto IL_00d4;
			}
			goto IL_0339;
			IL_00a7:
			obj15 = obj;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v83 @ X0_v13+E4]");
			if ((nint)0 != 0)
			{
				goto IL_00d4;
			}
			goto IL_0339;
			IL_0339:
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [8BE45C6]");
			object obj17 = (nint)0 & (nint)1;
			bool flag6 = obj17 == null;
			object obj18 = !flag6;
			object obj19 = 146685952;
			object obj20 = 146685952;
			if (obj18 != null)
			{
				goto IL_0119;
			}
			goto IL_0393;
			IL_00d4:
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [8BE45C6]");
			object obj21 = (nint)0 & (nint)1;
			bool flag7 = obj21 == null;
			obj19 = 146685952;
			obj20 = 146685952;
			if (!flag7)
			{
				goto IL_0119;
			}
			goto IL_0393;
			IL_0393:
			_ = 1;
			object obj22 = obj;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v131 @ X0_v26+E4]");
			bool flag8 = (nint)0 == 0;
			object obj23 = !flag8;
			obj19 = obj20;
			object obj24 = obj22;
			if (obj23 != null)
			{
				goto IL_0156;
			}
			goto IL_03e1;
			IL_0119:
			obj22 = obj;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v131 @ X0_v26+E4]");
			bool flag9 = (nint)0 == 0;
			obj24 = obj22;
			obj20 = obj19;
			if (!flag9)
			{
				goto IL_0156;
			}
			goto IL_03e1;
			IL_03e1:
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			obj22 = obj;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v131 @ X0_v26+B8]");
			object obj25 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v131 @ X0_v26+E4]");
			object obj26 = 0;
			bool flag10 = obj25 == null;
			object obj27 = !flag10;
			obj19 = obj20;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v131 @ X0_v26+E4]");
			object obj28 = 0;
			object obj29 = obj22;
			if (obj27 != null)
			{
				goto IL_01ab;
			}
			goto IL_045b;
			IL_0156:
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v131 @ X0_v26+B8]");
			obj25 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v131 @ X0_v26+E4]");
			obj26 = 0;
			bool flag11 = obj25 == null;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v131 @ X0_v26+E4]");
			obj28 = 0;
			obj29 = obj22;
			if (!flag11)
			{
				goto IL_01ab;
			}
			goto IL_045b;
			IL_045b:
			bool flag12 = obj28 == null;
			object obj30 = !flag12;
			if (obj30 == null)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
				object obj31 = obj;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v178 @ X8_v5+B8]");
				obj25 = 0;
			}
			object obj32 = obj25 + 96;
			return (ServerEnvironment)obj32;
			IL_05bf:
			NullReferenceException ex = new NullReferenceException();
			return (ServerEnvironment)ex;
			IL_057f:
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v218 @ X8_v23+18]");
			if ((nint)0 != 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v218 @ X8_v23+18]");
				object obj33 = (nint)0 + (nint)24;
				return (ServerEnvironment)obj33;
			}
			goto IL_05bf;
			IL_01ab:
			if (obj26 != null)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [8BE45C6]");
				object obj34 = (nint)0 & (nint)1;
				if (obj34 != null)
				{
					goto IL_01fb;
				}
			}
			else
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v137 @ X20_v10+5C6]");
				object obj35 = (nint)0 & (nint)1;
				bool flag13 = obj35 == null;
				object obj36 = !flag13;
				if (obj36 != null)
				{
					goto IL_01fb;
				}
			}
			_ = 1;
			obj7 = obj;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v198 @ X0_v40+E4]");
			bool flag14 = (nint)0 == 0;
			object obj37 = !flag14;
			obj8 = obj7;
			if (obj37 != null)
			{
				goto IL_0230;
			}
			goto IL_0538;
		}
	}

	public static string CachePath
	{
		get
		{
			//IL_000f: Unknown result type (might be due to invalid IL or missing references)
			//IL_0014: Expected O, but got Unknown
			//IL_0044: Unknown result type (might be due to invalid IL or missing references)
			//IL_0049: Expected O, but got Unknown
			//IL_0053: Unknown result type (might be due to invalid IL or missing references)
			//IL_0058: Expected O, but got Unknown
			//IL_0082: Expected O, but got I4
			//IL_00a0: Expected O, but got I
			//IL_00cc: Expected O, but got I
			object obj = typeof(System.Runtime.Remoting.Messaging.CallContextSecurityData) + 2360;
			object obj2 = typeof(RegisteredWaitHandle) + 3776;
			object format = "{0} color encoding is currently unsupported for outputting to HDR." + 776;
			object obj3 = obj;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v56 @ X0_v3+E4]");
			bool flag = (nint)0 == 0;
			object obj4 = !flag;
			if (obj4 == null)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
				obj3 = obj;
			}
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v56 @ X0_v3+B8]");
			object obj5 = 0;
			ServerEnvironment environmentFolder = _environmentFolder;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC195C");
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v58 @ X8_v4+58]");
			object arg = default(object);
			return string.Format((string)format, 0, arg);
		}
	}

	public static SFSConfig CurrentSFS
	{
		get
		{
			//IL_0009: Expected O, but got I4
			//IL_0018: Unknown result type (might be due to invalid IL or missing references)
			//IL_001d: Expected O, but got Unknown
			//IL_0033: Expected O, but got I
			//IL_0217: Expected O, but got I4
			//IL_0093: Expected O, but got I
			//IL_0282: Unknown result type (might be due to invalid IL or missing references)
			//IL_0287: Expected O, but got Unknown
			//IL_02b1: Expected O, but got I4
			//IL_0245: Expected O, but got I
			//IL_025f: Expected O, but got I4
			//IL_0111: Expected O, but got I
			//IL_0121: Expected O, but got I
			//IL_0160: Expected O, but got I
			//IL_00bf: Unknown result type (might be due to invalid IL or missing references)
			//IL_00c4: Expected O, but got Unknown
			//IL_0377: Expected O, but got I
			//IL_0387: Expected O, but got I
			//IL_0397: Expected O, but got I
			//IL_03b9: Expected O, but got I4
			//IL_02f1: Expected O, but got I
			//IL_0301: Expected O, but got I
			//IL_032b: Expected O, but got I4
			//IL_034b: Expected O, but got I
			//IL_017a: Expected O, but got I
			//IL_018a: Expected O, but got I
			//IL_019a: Expected O, but got I
			//IL_01bc: Expected O, but got I4
			//IL_03f9: Expected O, but got I4
			//IL_0453: Unknown result type (might be due to invalid IL or missing references)
			//IL_0458: Expected O, but got Unknown
			//IL_046e: Expected O, but got I
			//IL_047f: Expected I, but got O
			//IL_049d: Expected O, but got I
			//IL_0429: Expected O, but got I
			object obj = 152989696;
			object obj2 = typeof(System.Runtime.Remoting.Messaging.CallContextSecurityData) + 2360;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [91E70F6]");
			object obj3 = (nint)0 & (nint)1;
			if (obj3 != null)
			{
				object obj4 = obj2;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v55 @ X0_v24+E4]");
				if ((nint)0 != 0)
				{
					goto IL_007d;
				}
			}
			else
			{
				_ = 1;
				object obj4 = obj2;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v55 @ X0_v24+E4]");
				bool flag = (nint)0 == 0;
				object obj5 = !flag;
				if (obj5 != null)
				{
					goto IL_007d;
				}
			}
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [8BE45C7]");
			object obj6 = (nint)0 & (nint)1;
			bool flag2 = obj6 == null;
			object obj7 = !flag2;
			if (obj7 != null)
			{
				goto IL_00b0;
			}
			goto IL_026d;
			IL_03d7:
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v187 @ X0_v4+E4]");
			bool flag3 = (nint)0 == 0;
			object obj8 = !flag3;
			object obj10;
			object obj11;
			if (obj8 == null)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
				object obj9 = obj10;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v200 @ X8_v10+B8]");
				obj11 = 0;
			}
			object obj12 = typeof(Func<AndroidJavaObject, IList<HWLocation>>) + 3208;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
			object obj13 = (nint)0 + (nint)1672;
			Func<object, bool> func = default(Func<object, bool>);
			func..ctor(obj11, (IntPtr)obj13);
			object obj14 = obj10;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v166 @ X8_v9+B8]");
			object obj15 = (nint)0 + (nint)8;
			obj15 = func;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
			object obj17;
			object obj16 = obj17;
			IEnumerable<object> enumerable2;
			IEnumerable<object> enumerable = enumerable2;
			Func<object, bool> predicate = func;
			goto IL_042e;
			IL_042e:
			return (SFSConfig)Enumerable.FirstOrDefault(enumerable, predicate);
			IL_016e:
			obj16 = (nint)0 + (nint)1176;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v187 @ X0_v4+B8]");
			obj11 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v194 @ X8_v4+8]");
			predicate = (Func<object, bool>)0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v194 @ X8_v4+8]");
			bool flag4 = (nint)0 == 0;
			object obj18 = !flag4;
			object obj19;
			if (obj18 == null)
			{
				obj17 = obj16;
				obj10 = obj19;
				enumerable2 = enumerable;
				goto IL_03d7;
			}
			goto IL_042e;
			IL_007d:
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [8BE45C7]");
			object obj20 = (nint)0 & (nint)1;
			if (obj20 != null)
			{
				goto IL_00b0;
			}
			goto IL_026d;
			IL_026d:
			_ = 1;
			obj19 = typeof(CardUtils.<>c) + 2160;
			object obj21 = obj2;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v88 @ X0_v43+E4]");
			bool flag5 = (nint)0 == 0;
			object obj22 = !flag5;
			obj10 = obj19;
			object obj23 = obj21;
			if (obj22 != null)
			{
				goto IL_0101;
			}
			goto IL_02cf;
			IL_00b0:
			obj19 = typeof(CardUtils.<>c) + 2160;
			obj21 = obj2;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v88 @ X0_v43+E4]");
			bool flag6 = (nint)0 == 0;
			obj10 = obj19;
			obj23 = obj21;
			if (!flag6)
			{
				goto IL_0101;
			}
			goto IL_02cf;
			IL_02cf:
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			object obj24 = obj2;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v135 @ X0_v17+B8]");
			object obj25 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v136 @ X8_v15+8]");
			enumerable = (IEnumerable<object>)0;
			object obj26 = obj10;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v187 @ X0_v4+E4]");
			bool flag7 = (nint)0 == 0;
			object obj27 = !flag7;
			obj19 = obj10;
			object obj28 = obj26;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v136 @ X8_v15+8]");
			enumerable2 = (IEnumerable<object>)0;
			if (obj27 != null)
			{
				goto IL_016e;
			}
			goto IL_0359;
			IL_0101:
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v88 @ X0_v43+B8]");
			object obj29 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v95 @ X8_v27+8]");
			enumerable = (IEnumerable<object>)0;
			obj26 = obj19;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v187 @ X0_v4+E4]");
			bool flag8 = (nint)0 == 0;
			obj10 = obj19;
			obj28 = obj26;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v95 @ X8_v27+8]");
			enumerable2 = (IEnumerable<object>)0;
			if (!flag8)
			{
				goto IL_016e;
			}
			goto IL_0359;
			IL_0359:
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			obj26 = obj10;
			obj17 = (nint)0 + (nint)1176;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v187 @ X0_v4+B8]");
			obj11 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v194 @ X8_v4+8]");
			predicate = (Func<object, bool>)0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v194 @ X8_v4+8]");
			bool flag9 = (nint)0 == 0;
			object obj30 = !flag9;
			obj16 = obj17;
			enumerable = enumerable2;
			if (obj30 == null)
			{
				goto IL_03d7;
			}
			goto IL_042e;
		}
	}

	public static GameConfiguration CurrentGameConfiguration
	{
		get
		{
			//IL_0009: Expected O, but got I4
			//IL_0018: Unknown result type (might be due to invalid IL or missing references)
			//IL_001d: Expected O, but got Unknown
			//IL_0033: Expected O, but got I
			//IL_01ac: Expected O, but got I4
			//IL_0214: Expected O, but got I4
			//IL_0237: Expected O, but got I
			//IL_0247: Expected O, but got I
			//IL_0257: Expected O, but got I
			//IL_0279: Expected O, but got I4
			//IL_00ba: Unknown result type (might be due to invalid IL or missing references)
			//IL_00bf: Expected O, but got Unknown
			//IL_01f4: Expected O, but got I4
			//IL_02c1: Expected O, but got I4
			//IL_0105: Expected O, but got I
			//IL_0115: Expected O, but got I
			//IL_0125: Expected O, but got I
			//IL_0147: Expected O, but got I4
			//IL_031b: Unknown result type (might be due to invalid IL or missing references)
			//IL_0320: Expected O, but got Unknown
			//IL_0336: Expected O, but got I
			//IL_0347: Expected I, but got O
			//IL_0365: Expected O, but got I
			//IL_02f1: Expected O, but got I
			List<GameConfiguration> list = (List<GameConfiguration>)152989696;
			object obj = typeof(System.Runtime.Remoting.Messaging.CallContextSecurityData) + 2360;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [91E70F7]");
			object obj2 = (nint)0 & (nint)1;
			if (obj2 != null)
			{
				object obj3 = obj;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v45 @ X0_v38+E4]");
				bool flag = (nint)0 == 0;
				object obj4 = obj3;
				if (!flag)
				{
					goto IL_0085;
				}
			}
			else
			{
				_ = 1;
				object obj3 = obj;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v45 @ X0_v38+E4]");
				bool flag2 = (nint)0 == 0;
				object obj5 = !flag2;
				object obj4 = obj3;
				if (obj5 != null)
				{
					goto IL_0085;
				}
			}
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			SFSConfig currentSFS = CurrentSFS;
			bool flag3 = currentSFS == null;
			object obj6 = !flag3;
			if (obj6 != null)
			{
				goto IL_00ab;
			}
			goto IL_0202;
			IL_02f6:
			IEnumerable<object> source;
			Func<object, bool> predicate;
			return (GameConfiguration)Enumerable.FirstOrDefault(source, predicate);
			IL_029f:
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v143 @ X0_v4 (System.NullReferenceException)+E4]");
			bool flag4 = (nint)0 == 0;
			object obj7 = !flag4;
			object obj9 = default(object);
			object obj10;
			if (obj7 == null)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
				object obj8 = obj9;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v156 @ X8_v10+B8]");
				obj10 = 0;
			}
			object obj11 = typeof(Func<AndroidJavaObject, IList<HWLocation>>) + 1304;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
			object obj12 = (nint)0 + (nint)1664;
			Func<object, bool> func = default(Func<object, bool>);
			func..ctor(obj10, (IntPtr)obj12);
			object obj13 = obj9;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v123 @ X8_v9+B8]");
			object obj14 = (nint)0 + (nint)16;
			obj14 = func;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
			object obj16;
			object obj15 = obj16;
			predicate = func;
			IEnumerable<object> enumerable;
			source = enumerable;
			goto IL_02f6;
			IL_0219:
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			NullReferenceException ex = (NullReferenceException)obj9;
			obj16 = (nint)0 + (nint)832;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v143 @ X0_v4 (System.NullReferenceException)+B8]");
			obj10 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v150 @ X8_v4+10]");
			predicate = (Func<object, bool>)0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v150 @ X8_v4+10]");
			bool flag5 = (nint)0 == 0;
			object obj17 = !flag5;
			List<GameConfiguration> list2;
			enumerable = list2;
			obj15 = obj16;
			source = list2;
			if (obj17 == null)
			{
				goto IL_029f;
			}
			goto IL_02f6;
			IL_0085:
			currentSFS = CurrentSFS;
			if (currentSFS != null)
			{
				goto IL_00ab;
			}
			goto IL_0202;
			IL_0202:
			ex = new NullReferenceException();
			list2 = (List<GameConfiguration>)152989696;
			goto IL_0219;
			IL_00ab:
			obj9 = typeof(CardUtils.<>c) + 2160;
			list2 = currentSFS.<Games>k__BackingField;
			ex = (NullReferenceException)obj9;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v143 @ X0_v4 (System.NullReferenceException)+E4]");
			if ((nint)0 == 0)
			{
				goto IL_0219;
			}
			obj15 = (nint)0 + (nint)832;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v143 @ X0_v4 (System.NullReferenceException)+B8]");
			obj10 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v150 @ X8_v4+10]");
			predicate = (Func<object, bool>)0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v150 @ X8_v4+10]");
			bool flag6 = (nint)0 == 0;
			object obj18 = !flag6;
			source = currentSFS.<Games>k__BackingField;
			if (obj18 == null)
			{
				obj16 = obj15;
				enumerable = currentSFS.<Games>k__BackingField;
				goto IL_029f;
			}
			goto IL_02f6;
		}
	}

	public static SFSConfig FTServerForCurrentGame
	{
		get
		{
			//IL_0009: Expected O, but got I4
			//IL_0018: Unknown result type (might be due to invalid IL or missing references)
			//IL_001d: Expected O, but got Unknown
			//IL_0033: Expected O, but got I
			//IL_0217: Expected O, but got I4
			//IL_0093: Expected O, but got I
			//IL_0282: Unknown result type (might be due to invalid IL or missing references)
			//IL_0287: Expected O, but got Unknown
			//IL_02b1: Expected O, but got I4
			//IL_0245: Expected O, but got I
			//IL_025f: Expected O, but got I4
			//IL_0111: Expected O, but got I
			//IL_0121: Expected O, but got I
			//IL_0160: Expected O, but got I
			//IL_00bf: Unknown result type (might be due to invalid IL or missing references)
			//IL_00c4: Expected O, but got Unknown
			//IL_0377: Expected O, but got I
			//IL_0387: Expected O, but got I
			//IL_0397: Expected O, but got I
			//IL_03b9: Expected O, but got I4
			//IL_02f1: Expected O, but got I
			//IL_0301: Expected O, but got I
			//IL_032b: Expected O, but got I4
			//IL_034b: Expected O, but got I
			//IL_017a: Expected O, but got I
			//IL_018a: Expected O, but got I
			//IL_019a: Expected O, but got I
			//IL_01bc: Expected O, but got I4
			//IL_03f9: Expected O, but got I4
			//IL_0453: Unknown result type (might be due to invalid IL or missing references)
			//IL_0458: Expected O, but got Unknown
			//IL_046e: Expected O, but got I
			//IL_047f: Expected I, but got O
			//IL_049d: Expected O, but got I
			//IL_0429: Expected O, but got I
			object obj = 152989696;
			object obj2 = typeof(System.Runtime.Remoting.Messaging.CallContextSecurityData) + 2360;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [91E70F8]");
			object obj3 = (nint)0 & (nint)1;
			if (obj3 != null)
			{
				object obj4 = obj2;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v55 @ X0_v24+E4]");
				if ((nint)0 != 0)
				{
					goto IL_007d;
				}
			}
			else
			{
				_ = 1;
				object obj4 = obj2;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v55 @ X0_v24+E4]");
				bool flag = (nint)0 == 0;
				object obj5 = !flag;
				if (obj5 != null)
				{
					goto IL_007d;
				}
			}
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [8BE45C7]");
			object obj6 = (nint)0 & (nint)1;
			bool flag2 = obj6 == null;
			object obj7 = !flag2;
			if (obj7 != null)
			{
				goto IL_00b0;
			}
			goto IL_026d;
			IL_03d7:
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v187 @ X0_v4+E4]");
			bool flag3 = (nint)0 == 0;
			object obj8 = !flag3;
			object obj10;
			object obj11;
			if (obj8 == null)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
				object obj9 = obj10;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v200 @ X8_v10+B8]");
				obj11 = 0;
			}
			object obj12 = typeof(Func<AndroidJavaObject, IList<HWLocation>>) + 3208;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
			object obj13 = (nint)0 + (nint)1680;
			Func<object, bool> func = default(Func<object, bool>);
			func..ctor(obj11, (IntPtr)obj13);
			object obj14 = obj10;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v166 @ X8_v9+B8]");
			object obj15 = (nint)0 + (nint)24;
			obj15 = func;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
			object obj17;
			object obj16 = obj17;
			IEnumerable<object> enumerable2;
			IEnumerable<object> enumerable = enumerable2;
			Func<object, bool> predicate = func;
			goto IL_042e;
			IL_042e:
			return (SFSConfig)Enumerable.FirstOrDefault(enumerable, predicate);
			IL_016e:
			obj16 = (nint)0 + (nint)1176;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v187 @ X0_v4+B8]");
			obj11 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v194 @ X8_v4+18]");
			predicate = (Func<object, bool>)0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v194 @ X8_v4+18]");
			bool flag4 = (nint)0 == 0;
			object obj18 = !flag4;
			object obj19;
			if (obj18 == null)
			{
				obj17 = obj16;
				obj10 = obj19;
				enumerable2 = enumerable;
				goto IL_03d7;
			}
			goto IL_042e;
			IL_007d:
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [8BE45C7]");
			object obj20 = (nint)0 & (nint)1;
			if (obj20 != null)
			{
				goto IL_00b0;
			}
			goto IL_026d;
			IL_026d:
			_ = 1;
			obj19 = typeof(CardUtils.<>c) + 2160;
			object obj21 = obj2;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v88 @ X0_v43+E4]");
			bool flag5 = (nint)0 == 0;
			object obj22 = !flag5;
			obj10 = obj19;
			object obj23 = obj21;
			if (obj22 != null)
			{
				goto IL_0101;
			}
			goto IL_02cf;
			IL_00b0:
			obj19 = typeof(CardUtils.<>c) + 2160;
			obj21 = obj2;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v88 @ X0_v43+E4]");
			bool flag6 = (nint)0 == 0;
			obj10 = obj19;
			obj23 = obj21;
			if (!flag6)
			{
				goto IL_0101;
			}
			goto IL_02cf;
			IL_02cf:
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			object obj24 = obj2;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v135 @ X0_v17+B8]");
			object obj25 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v136 @ X8_v15+8]");
			enumerable = (IEnumerable<object>)0;
			object obj26 = obj10;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v187 @ X0_v4+E4]");
			bool flag7 = (nint)0 == 0;
			object obj27 = !flag7;
			obj19 = obj10;
			object obj28 = obj26;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v136 @ X8_v15+8]");
			enumerable2 = (IEnumerable<object>)0;
			if (obj27 != null)
			{
				goto IL_016e;
			}
			goto IL_0359;
			IL_0101:
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v88 @ X0_v43+B8]");
			object obj29 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v95 @ X8_v27+8]");
			enumerable = (IEnumerable<object>)0;
			obj26 = obj19;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v187 @ X0_v4+E4]");
			bool flag8 = (nint)0 == 0;
			obj10 = obj19;
			obj28 = obj26;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v95 @ X8_v27+8]");
			enumerable2 = (IEnumerable<object>)0;
			if (!flag8)
			{
				goto IL_016e;
			}
			goto IL_0359;
			IL_0359:
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			obj26 = obj10;
			obj17 = (nint)0 + (nint)1176;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v187 @ X0_v4+B8]");
			obj11 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v194 @ X8_v4+18]");
			predicate = (Func<object, bool>)0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v194 @ X8_v4+18]");
			bool flag9 = (nint)0 == 0;
			object obj30 = !flag9;
			obj16 = obj17;
			enumerable = enumerable2;
			if (obj30 == null)
			{
				goto IL_03d7;
			}
			goto IL_042e;
		}
	}

	public static SFSConfig RestrictedServerForCurrentGame
	{
		get
		{
			//IL_0009: Expected O, but got I4
			//IL_0018: Unknown result type (might be due to invalid IL or missing references)
			//IL_001d: Expected O, but got Unknown
			//IL_0033: Expected O, but got I
			//IL_0217: Expected O, but got I4
			//IL_0093: Expected O, but got I
			//IL_0282: Unknown result type (might be due to invalid IL or missing references)
			//IL_0287: Expected O, but got Unknown
			//IL_02b1: Expected O, but got I4
			//IL_0245: Expected O, but got I
			//IL_025f: Expected O, but got I4
			//IL_0111: Expected O, but got I
			//IL_0121: Expected O, but got I
			//IL_0160: Expected O, but got I
			//IL_00bf: Unknown result type (might be due to invalid IL or missing references)
			//IL_00c4: Expected O, but got Unknown
			//IL_0377: Expected O, but got I
			//IL_0387: Expected O, but got I
			//IL_0397: Expected O, but got I
			//IL_03b9: Expected O, but got I4
			//IL_02f1: Expected O, but got I
			//IL_0301: Expected O, but got I
			//IL_032b: Expected O, but got I4
			//IL_034b: Expected O, but got I
			//IL_017a: Expected O, but got I
			//IL_018a: Expected O, but got I
			//IL_019a: Expected O, but got I
			//IL_01bc: Expected O, but got I4
			//IL_03f9: Expected O, but got I4
			//IL_0453: Unknown result type (might be due to invalid IL or missing references)
			//IL_0458: Expected O, but got Unknown
			//IL_046e: Expected O, but got I
			//IL_047f: Expected I, but got O
			//IL_049d: Expected O, but got I
			//IL_0429: Expected O, but got I
			object obj = 152989696;
			object obj2 = typeof(System.Runtime.Remoting.Messaging.CallContextSecurityData) + 2360;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [91E70F9]");
			object obj3 = (nint)0 & (nint)1;
			if (obj3 != null)
			{
				object obj4 = obj2;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v55 @ X0_v24+E4]");
				if ((nint)0 != 0)
				{
					goto IL_007d;
				}
			}
			else
			{
				_ = 1;
				object obj4 = obj2;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v55 @ X0_v24+E4]");
				bool flag = (nint)0 == 0;
				object obj5 = !flag;
				if (obj5 != null)
				{
					goto IL_007d;
				}
			}
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [8BE45C7]");
			object obj6 = (nint)0 & (nint)1;
			bool flag2 = obj6 == null;
			object obj7 = !flag2;
			if (obj7 != null)
			{
				goto IL_00b0;
			}
			goto IL_026d;
			IL_03d7:
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v187 @ X0_v4+E4]");
			bool flag3 = (nint)0 == 0;
			object obj8 = !flag3;
			object obj10;
			object obj11;
			if (obj8 == null)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
				object obj9 = obj10;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v200 @ X8_v10+B8]");
				obj11 = 0;
			}
			object obj12 = typeof(Func<AndroidJavaObject, IList<HWLocation>>) + 3208;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
			object obj13 = (nint)0 + (nint)1688;
			Func<object, bool> func = default(Func<object, bool>);
			func..ctor(obj11, (IntPtr)obj13);
			object obj14 = obj10;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v166 @ X8_v9+B8]");
			object obj15 = (nint)0 + (nint)32;
			obj15 = func;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
			object obj17;
			object obj16 = obj17;
			IEnumerable<object> enumerable2;
			IEnumerable<object> enumerable = enumerable2;
			Func<object, bool> predicate = func;
			goto IL_042e;
			IL_042e:
			return (SFSConfig)Enumerable.FirstOrDefault(enumerable, predicate);
			IL_016e:
			obj16 = (nint)0 + (nint)1176;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v187 @ X0_v4+B8]");
			obj11 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v194 @ X8_v4+20]");
			predicate = (Func<object, bool>)0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v194 @ X8_v4+20]");
			bool flag4 = (nint)0 == 0;
			object obj18 = !flag4;
			object obj19;
			if (obj18 == null)
			{
				obj17 = obj16;
				obj10 = obj19;
				enumerable2 = enumerable;
				goto IL_03d7;
			}
			goto IL_042e;
			IL_007d:
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [8BE45C7]");
			object obj20 = (nint)0 & (nint)1;
			if (obj20 != null)
			{
				goto IL_00b0;
			}
			goto IL_026d;
			IL_026d:
			_ = 1;
			obj19 = typeof(CardUtils.<>c) + 2160;
			object obj21 = obj2;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v88 @ X0_v43+E4]");
			bool flag5 = (nint)0 == 0;
			object obj22 = !flag5;
			obj10 = obj19;
			object obj23 = obj21;
			if (obj22 != null)
			{
				goto IL_0101;
			}
			goto IL_02cf;
			IL_00b0:
			obj19 = typeof(CardUtils.<>c) + 2160;
			obj21 = obj2;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v88 @ X0_v43+E4]");
			bool flag6 = (nint)0 == 0;
			obj10 = obj19;
			obj23 = obj21;
			if (!flag6)
			{
				goto IL_0101;
			}
			goto IL_02cf;
			IL_02cf:
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			object obj24 = obj2;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v135 @ X0_v17+B8]");
			object obj25 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v136 @ X8_v15+8]");
			enumerable = (IEnumerable<object>)0;
			object obj26 = obj10;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v187 @ X0_v4+E4]");
			bool flag7 = (nint)0 == 0;
			object obj27 = !flag7;
			obj19 = obj10;
			object obj28 = obj26;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v136 @ X8_v15+8]");
			enumerable2 = (IEnumerable<object>)0;
			if (obj27 != null)
			{
				goto IL_016e;
			}
			goto IL_0359;
			IL_0101:
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v88 @ X0_v43+B8]");
			object obj29 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v95 @ X8_v27+8]");
			enumerable = (IEnumerable<object>)0;
			obj26 = obj19;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v187 @ X0_v4+E4]");
			bool flag8 = (nint)0 == 0;
			obj10 = obj19;
			obj28 = obj26;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v95 @ X8_v27+8]");
			enumerable2 = (IEnumerable<object>)0;
			if (!flag8)
			{
				goto IL_016e;
			}
			goto IL_0359;
			IL_0359:
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			obj26 = obj10;
			obj17 = (nint)0 + (nint)1176;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v187 @ X0_v4+B8]");
			obj11 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v194 @ X8_v4+20]");
			predicate = (Func<object, bool>)0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v194 @ X8_v4+20]");
			bool flag9 = (nint)0 == 0;
			object obj30 = !flag9;
			obj16 = obj17;
			enumerable = enumerable2;
			if (obj30 == null)
			{
				goto IL_03d7;
			}
			goto IL_042e;
		}
	}

	public static bool IsDown
	{
		get
		{
			//IL_0009: Expected O, but got I4
			//IL_0018: Unknown result type (might be due to invalid IL or missing references)
			//IL_001d: Expected O, but got Unknown
			//IL_0033: Expected O, but got I
			//IL_014c: Expected O, but got I4
			//IL_0093: Expected O, but got I
			//IL_01d2: Expected O, but got I4
			//IL_017a: Expected O, but got I
			//IL_0194: Expected O, but got I4
			//IL_00f5: Expected O, but got I
			object obj = 152989696;
			object obj2 = typeof(System.Runtime.Remoting.Messaging.CallContextSecurityData) + 2360;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [91E70FA]");
			object obj3 = (nint)0 & (nint)1;
			if (obj3 != null)
			{
				object obj4 = obj2;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v47 @ X0_v9+E4]");
				if ((nint)0 != 0)
				{
					goto IL_007d;
				}
			}
			else
			{
				_ = 1;
				object obj4 = obj2;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v47 @ X0_v9+E4]");
				bool flag = (nint)0 == 0;
				object obj5 = !flag;
				if (obj5 != null)
				{
					goto IL_007d;
				}
			}
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [8BE45C8]");
			object obj6 = (nint)0 & (nint)1;
			bool flag2 = obj6 == null;
			object obj7 = !flag2;
			if (obj7 != null)
			{
				goto IL_00b0;
			}
			goto IL_01a2;
			IL_00e5:
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v72 @ X0_v15+B8]");
			object obj8 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v83 @ X8_v11+20]");
			bool flag3 = (nint)0 == 0;
			return !flag3;
			IL_01e8:
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			object obj9 = obj2;
			goto IL_00e5;
			IL_00b0:
			obj9 = obj2;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v72 @ X0_v15+E4]");
			bool flag4 = (nint)0 == 0;
			object obj10 = obj9;
			if (!flag4)
			{
				goto IL_00e5;
			}
			goto IL_01e8;
			IL_007d:
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [8BE45C8]");
			object obj11 = (nint)0 & (nint)1;
			if (obj11 != null)
			{
				goto IL_00b0;
			}
			goto IL_01a2;
			IL_01a2:
			_ = 1;
			obj9 = obj2;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v72 @ X0_v15+E4]");
			bool flag5 = (nint)0 == 0;
			object obj12 = !flag5;
			obj10 = obj9;
			if (obj12 != null)
			{
				goto IL_00e5;
			}
			goto IL_01e8;
		}
	}

	public static bool IsWrongVersion
	{
		get
		{
			//IL_000f: Unknown result type (might be due to invalid IL or missing references)
			//IL_0014: Expected O, but got Unknown
			//IL_002a: Expected O, but got I
			//IL_01eb: Expected O, but got I4
			//IL_008a: Expected O, but got I
			//IL_00a2: Expected O, but got I4
			//IL_00ab: Expected O, but got I4
			//IL_0283: Expected O, but got I4
			//IL_0219: Expected O, but got I
			//IL_0233: Expected O, but got I4
			//IL_023c: Expected O, but got I4
			//IL_0245: Expected O, but got I4
			//IL_0104: Expected O, but got I
			//IL_0319: Expected O, but got I4
			//IL_02b9: Expected O, but got I
			//IL_02d3: Expected O, but got I4
			//IL_0176: Expected O, but got I
			//IL_0186: Expected O, but got I
			//IL_01a8: Expected O, but got I4
			//IL_0359: Expected O, but got I
			//IL_0369: Expected O, but got I
			//IL_03d8: Unknown result type (might be due to invalid IL or missing references)
			//IL_03dd: Expected O, but got Unknown
			//IL_0578: Expected O, but got I
			//IL_0592: Expected O, but got I4
			//IL_043c: Expected O, but got I
			//IL_05fe: Expected O, but got I
			//IL_0618: Expected O, but got I4
			//IL_05d0: Expected O, but got I4
			//IL_049c: Expected O, but got I
			//IL_068e: Expected O, but got I
			//IL_069e: Expected O, but got I
			//IL_06c0: Expected O, but got I4
			//IL_0656: Expected O, but got I4
			//IL_04fe: Expected O, but got I
			//IL_050e: Expected O, but got I
			object obj = typeof(System.Runtime.Remoting.Messaging.CallContextSecurityData) + 2360;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [91E721D]");
			object obj2 = (nint)0 & (nint)1;
			if (obj2 != null)
			{
				object obj3 = obj;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v55 @ X0_v58+E4]");
				if ((nint)0 != 0)
				{
					goto IL_0074;
				}
			}
			else
			{
				_ = 1;
				object obj3 = obj;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v55 @ X0_v58+E4]");
				bool flag = (nint)0 == 0;
				object obj4 = !flag;
				if (obj4 != null)
				{
					goto IL_0074;
				}
			}
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [91E721E]");
			object obj5 = (nint)0 & (nint)1;
			bool flag2 = obj5 == null;
			object obj6 = !flag2;
			object obj7 = 152989696;
			object obj8 = 152989696;
			if (obj6 != null)
			{
				goto IL_00b9;
			}
			goto IL_0253;
			IL_04ee:
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v259 @ X0_v35+B8]");
			object obj9 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v265 @ X8_v20+18]");
			PlatformConfiguration platformConfiguration = (PlatformConfiguration)0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v265 @ X8_v20+18]");
			if ((nint)0 != 0)
			{
				goto IL_0533;
			}
			goto IL_06ce;
			IL_066c:
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			object obj10 = obj;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v286 @ X0_v18+B8]");
			object obj11 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v279 @ X8_v8+18]");
			platformConfiguration = (PlatformConfiguration)0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v279 @ X8_v8+18]");
			bool flag3 = (nint)0 == 0;
			object obj12 = !flag3;
			if (obj12 != null)
			{
				goto IL_0533;
			}
			goto IL_06ce;
			IL_04b9:
			object obj13 = obj;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v259 @ X0_v35+E4]");
			bool flag4 = (nint)0 == 0;
			object obj14 = obj13;
			if (!flag4)
			{
				goto IL_04ee;
			}
			goto IL_066c;
			IL_0074:
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [91E721E]");
			object obj15 = (nint)0 & (nint)1;
			bool flag5 = obj15 == null;
			obj7 = 152989696;
			obj8 = 152989696;
			if (!flag5)
			{
				goto IL_00b9;
			}
			goto IL_0253;
			IL_0253:
			_ = 1;
			object obj16 = obj;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v95 @ X0_v51+E4]");
			bool flag6 = (nint)0 == 0;
			object obj17 = !flag6;
			obj7 = obj8;
			if (obj17 != null)
			{
				goto IL_00ee;
			}
			goto IL_0299;
			IL_00b9:
			obj16 = obj;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v95 @ X0_v51+E4]");
			bool flag7 = (nint)0 == 0;
			obj8 = obj7;
			if (!flag7)
			{
				goto IL_00ee;
			}
			goto IL_0299;
			IL_0299:
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [8BE45C9]");
			object obj18 = (nint)0 & (nint)1;
			bool flag8 = obj18 == null;
			object obj19 = !flag8;
			obj7 = obj8;
			if (obj19 != null)
			{
				goto IL_0129;
			}
			goto IL_02e9;
			IL_00ee:
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [8BE45C9]");
			object obj20 = (nint)0 & (nint)1;
			bool flag9 = obj20 == null;
			obj8 = obj7;
			if (!flag9)
			{
				goto IL_0129;
			}
			goto IL_02e9;
			IL_02e9:
			_ = 1;
			object obj21 = obj;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v124 @ X0_v67+E4]");
			bool flag10 = (nint)0 == 0;
			object obj22 = !flag10;
			obj7 = obj8;
			object obj23 = obj21;
			if (obj22 != null)
			{
				goto IL_0166;
			}
			goto IL_0337;
			IL_0129:
			obj21 = obj;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v124 @ X0_v67+E4]");
			bool flag11 = (nint)0 == 0;
			obj8 = obj7;
			obj23 = obj21;
			if (!flag11)
			{
				goto IL_0166;
			}
			goto IL_0337;
			IL_0337:
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			object obj24 = obj;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v152 @ X0_v44+B8]");
			object obj25 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v149 @ X8_v29+18]");
			PlatformConfiguration platformConfiguration2 = (PlatformConfiguration)0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v149 @ X8_v29+18]");
			bool flag12 = (nint)0 == 0;
			obj7 = obj8;
			if (!flag12)
			{
				goto IL_0396;
			}
			goto IL_0552;
			IL_0166:
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v124 @ X0_v67+B8]");
			object obj26 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v130 @ X8_v43+18]");
			platformConfiguration2 = (PlatformConfiguration)0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v130 @ X8_v43+18]");
			bool flag13 = (nint)0 == 0;
			object obj27 = !flag13;
			if (obj27 != null)
			{
				goto IL_0396;
			}
			goto IL_0552;
			IL_0396:
			string platformSpecificValue = platformConfiguration2.PlatformSpecificValue;
			if (platformSpecificValue == null)
			{
				goto IL_0552;
			}
			string version = UnityEngine.Device.Application.version;
			object obj28 = typeof(UsageHint) + 992;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
			Version version2 = default(Version);
			version2..ctor(version);
			object obj29 = obj;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v205 @ X0_v9+E4]");
			if ((nint)0 != 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [91E721E]");
				object obj30 = (nint)0 & (nint)1;
				if (obj30 != null)
				{
					goto IL_0459;
				}
			}
			else
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v143 @ X22_v3+21E]");
				object obj31 = (nint)0 & (nint)1;
				bool flag14 = obj31 == null;
				object obj32 = !flag14;
				if (obj32 != null)
				{
					goto IL_0459;
				}
			}
			_ = 1;
			object obj33 = obj;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v237 @ X0_v25+E4]");
			bool flag15 = (nint)0 == 0;
			object obj34 = !flag15;
			if (obj34 != null)
			{
				goto IL_0486;
			}
			goto IL_05de;
			IL_06ce:
			string version3 = null;
			string text = version;
			goto IL_06e5;
			IL_0552:
			return false;
			IL_06e5:
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
			Version version4 = default(Version);
			version4..ctor(version3);
			return version2 < version4;
			IL_0533:
			string platformSpecificValue2 = platformConfiguration.PlatformSpecificValue;
			version3 = platformSpecificValue2;
			text = null;
			goto IL_06e5;
			IL_0459:
			obj33 = obj;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v237 @ X0_v25+E4]");
			if ((nint)0 != 0)
			{
				goto IL_0486;
			}
			goto IL_05de;
			IL_05de:
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [8BE45C9]");
			object obj35 = (nint)0 & (nint)1;
			bool flag16 = obj35 == null;
			object obj36 = !flag16;
			if (obj36 != null)
			{
				goto IL_04b9;
			}
			goto IL_0626;
			IL_0486:
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [8BE45C9]");
			object obj37 = (nint)0 & (nint)1;
			if (obj37 != null)
			{
				goto IL_04b9;
			}
			goto IL_0626;
			IL_0626:
			_ = 1;
			obj13 = obj;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v259 @ X0_v35+E4]");
			bool flag17 = (nint)0 == 0;
			object obj38 = !flag17;
			obj14 = obj13;
			if (obj38 != null)
			{
				goto IL_04ee;
			}
			goto IL_066c;
		}
	}

	public static bool IsUnderMaintenance
	{
		get
		{
			//IL_0009: Expected O, but got I4
			//IL_0018: Unknown result type (might be due to invalid IL or missing references)
			//IL_001d: Expected O, but got Unknown
			//IL_0033: Expected O, but got I
			//IL_0248: Expected O, but got I4
			//IL_0093: Expected O, but got I
			//IL_00ab: Expected O, but got I4
			//IL_00b4: Expected O, but got I4
			//IL_02e0: Expected O, but got I4
			//IL_0276: Expected O, but got I
			//IL_0290: Expected O, but got I4
			//IL_0299: Expected O, but got I4
			//IL_02a2: Expected O, but got I4
			//IL_010f: Expected O, but got I
			//IL_0320: Expected O, but got I
			//IL_0342: Expected O, but got I4
			//IL_037e: Expected O, but got I
			//IL_0398: Expected O, but got I4
			//IL_016f: Expected O, but got I
			//IL_040e: Expected O, but got I
			//IL_041e: Expected O, but got I
			//IL_0440: Expected O, but got I4
			//IL_03d6: Expected O, but got I4
			//IL_01d1: Expected O, but got I
			//IL_01e1: Expected O, but got I
			//IL_045c: Expected I4, but got O
			object obj = 152989696;
			object obj2 = typeof(System.Runtime.Remoting.Messaging.CallContextSecurityData) + 2360;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [91E70FB]");
			object obj3 = (nint)0 & (nint)1;
			if (obj3 != null)
			{
				object obj4 = obj2;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v47 @ X0_v11+E4]");
				if ((nint)0 != 0)
				{
					goto IL_007d;
				}
			}
			else
			{
				_ = 1;
				object obj4 = obj2;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v47 @ X0_v11+E4]");
				bool flag = (nint)0 == 0;
				object obj5 = !flag;
				if (obj5 != null)
				{
					goto IL_007d;
				}
			}
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [8BE45C4]");
			object obj6 = (nint)0 & (nint)1;
			bool flag2 = obj6 == null;
			object obj7 = !flag2;
			object obj8 = 146685952;
			object obj9 = 146685952;
			if (obj7 != null)
			{
				goto IL_00c2;
			}
			goto IL_02b0;
			IL_03ec:
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			object obj10 = obj2;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v166 @ X0_v22+B8]");
			object obj11 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v164 @ X8_v17+10]");
			MaintenanceInfo maintenanceInfo = (MaintenanceInfo)0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v164 @ X8_v17+10]");
			bool flag3 = (nint)0 == 0;
			object obj12 = !flag3;
			if (obj12 != null)
			{
				goto IL_0206;
			}
			goto IL_044e;
			IL_018c:
			object obj13 = obj2;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v146 @ X0_v32+E4]");
			bool flag4 = (nint)0 == 0;
			object obj14 = obj13;
			if (!flag4)
			{
				goto IL_01c1;
			}
			goto IL_03ec;
			IL_01c1:
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v146 @ X0_v32+B8]");
			object obj15 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v152 @ X8_v24+10]");
			maintenanceInfo = (MaintenanceInfo)0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v152 @ X8_v24+10]");
			if ((nint)0 != 0)
			{
				goto IL_0206;
			}
			goto IL_044e;
			IL_007d:
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [8BE45C4]");
			object obj16 = (nint)0 & (nint)1;
			bool flag5 = obj16 == null;
			obj8 = 146685952;
			obj9 = 146685952;
			if (!flag5)
			{
				goto IL_00c2;
			}
			goto IL_02b0;
			IL_02b0:
			_ = 1;
			object obj17 = obj2;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v89 @ X0_v17+E4]");
			bool flag6 = (nint)0 == 0;
			object obj18 = !flag6;
			obj8 = obj9;
			object obj19 = obj17;
			if (obj18 != null)
			{
				goto IL_00ff;
			}
			goto IL_02fe;
			IL_00c2:
			obj17 = obj2;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v89 @ X0_v17+E4]");
			bool flag7 = (nint)0 == 0;
			obj19 = obj17;
			obj9 = obj8;
			if (!flag7)
			{
				goto IL_00ff;
			}
			goto IL_02fe;
			IL_02fe:
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			obj17 = obj2;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v89 @ X0_v17+B8]");
			object obj20 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v107 @ X8_v4+10]");
			bool flag8 = (nint)0 == 0;
			object obj21 = !flag8;
			obj8 = obj9;
			if (obj21 != null)
			{
				goto IL_0134;
			}
			goto IL_0358;
			IL_00ff:
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v89 @ X0_v17+B8]");
			object obj22 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v79 @ X8_v29+10]");
			if ((nint)0 != 0)
			{
				goto IL_0134;
			}
			goto IL_0358;
			IL_0358:
			return false;
			IL_0134:
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v89 @ X0_v17+E4]");
			if ((nint)0 != 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [8BE45C4]");
				object obj23 = (nint)0 & (nint)1;
				if (obj23 != null)
				{
					goto IL_018c;
				}
			}
			else
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v95 @ X20_v7+5C4]");
				object obj24 = (nint)0 & (nint)1;
				bool flag9 = obj24 == null;
				object obj25 = !flag9;
				if (obj25 != null)
				{
					goto IL_018c;
				}
			}
			_ = 1;
			obj13 = obj2;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v146 @ X0_v32+E4]");
			bool flag10 = (nint)0 == 0;
			object obj26 = !flag10;
			obj14 = obj13;
			if (obj26 != null)
			{
				goto IL_01c1;
			}
			goto IL_03ec;
			IL_0206:
			return maintenanceInfo.IsUnderMaintenance();
			IL_044e:
			NullReferenceException ex = new NullReferenceException();
			return (byte)(int)ex != 0;
		}
	}

	public static string NewVersion
	{
		get
		{
			//IL_0009: Expected O, but got I4
			//IL_0018: Unknown result type (might be due to invalid IL or missing references)
			//IL_001d: Expected O, but got Unknown
			//IL_0033: Expected O, but got I
			//IL_017c: Expected O, but got I4
			//IL_0093: Expected O, but got I
			//IL_0202: Expected O, but got I4
			//IL_01aa: Expected O, but got I
			//IL_01c4: Expected O, but got I4
			//IL_00f5: Expected O, but got I
			//IL_0105: Expected O, but got I
			//IL_012c: Expected O, but got I
			//IL_023a: Expected O, but got I
			//IL_024a: Expected O, but got I
			//IL_026c: Expected O, but got I4
			//IL_027c: Expected O, but got I
			object obj = 152989696;
			object obj2 = typeof(System.Runtime.Remoting.Messaging.CallContextSecurityData) + 2360;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [91E721E]");
			object obj3 = (nint)0 & (nint)1;
			if (obj3 != null)
			{
				object obj4 = obj2;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v47 @ X0_v11+E4]");
				if ((nint)0 != 0)
				{
					goto IL_007d;
				}
			}
			else
			{
				_ = 1;
				object obj4 = obj2;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v47 @ X0_v11+E4]");
				bool flag = (nint)0 == 0;
				object obj5 = !flag;
				if (obj5 != null)
				{
					goto IL_007d;
				}
			}
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [8BE45C9]");
			object obj6 = (nint)0 & (nint)1;
			bool flag2 = obj6 == null;
			object obj7 = !flag2;
			if (obj7 != null)
			{
				goto IL_00b0;
			}
			goto IL_01d2;
			IL_013a:
			PlatformConfiguration platformConfiguration;
			return platformConfiguration.PlatformSpecificValue;
			IL_028a:
			string result;
			return result;
			IL_00e5:
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v72 @ X0_v19+B8]");
			object obj8 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v79 @ X8_v14+18]");
			platformConfiguration = (PlatformConfiguration)0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v79 @ X8_v14+18]");
			bool flag3 = (nint)0 == 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v79 @ X8_v14+18]");
			result = (string)0;
			if (!flag3)
			{
				goto IL_013a;
			}
			goto IL_028a;
			IL_007d:
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [8BE45C9]");
			object obj9 = (nint)0 & (nint)1;
			if (obj9 != null)
			{
				goto IL_00b0;
			}
			goto IL_01d2;
			IL_01d2:
			_ = 1;
			object obj10 = obj2;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v72 @ X0_v19+E4]");
			bool flag4 = (nint)0 == 0;
			object obj11 = !flag4;
			object obj12 = obj10;
			if (obj11 != null)
			{
				goto IL_00e5;
			}
			goto IL_0218;
			IL_00b0:
			obj10 = obj2;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v72 @ X0_v19+E4]");
			bool flag5 = (nint)0 == 0;
			obj12 = obj10;
			if (!flag5)
			{
				goto IL_00e5;
			}
			goto IL_0218;
			IL_0218:
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			object obj13 = obj2;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v110 @ X0_v4+B8]");
			object obj14 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v94 @ X8_v4+18]");
			platformConfiguration = (PlatformConfiguration)0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v94 @ X8_v4+18]");
			bool flag6 = (nint)0 == 0;
			object obj15 = !flag6;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v94 @ X8_v4+18]");
			result = (string)0;
			if (obj15 != null)
			{
				goto IL_013a;
			}
			goto IL_028a;
		}
	}

	public static ServerEnvironment Environment
	{
		get
		{
			//IL_000f: Unknown result type (might be due to invalid IL or missing references)
			//IL_0014: Expected O, but got Unknown
			//IL_002a: Expected O, but got I
			//IL_02a5: Expected O, but got I4
			//IL_008a: Expected O, but got I
			//IL_032b: Expected O, but got I4
			//IL_02d3: Expected O, but got I
			//IL_02ed: Expected O, but got I4
			//IL_00ea: Expected O, but got I
			//IL_0102: Expected O, but got I4
			//IL_010b: Expected O, but got I4
			//IL_03c3: Expected O, but got I4
			//IL_0359: Expected O, but got I
			//IL_0373: Expected O, but got I4
			//IL_037c: Expected O, but got I4
			//IL_0385: Expected O, but got I4
			//IL_0166: Expected O, but got I
			//IL_0176: Expected O, but got I
			//IL_0195: Expected O, but got I
			//IL_0475: Expected O, but got I4
			//IL_0403: Expected O, but got I
			//IL_0413: Expected O, but got I
			//IL_042d: Expected O, but got I4
			//IL_0445: Expected O, but got I
			//IL_05d6: Unknown result type (might be due to invalid IL or missing references)
			//IL_05db: Expected O, but got Unknown
			//IL_05e0: Expected I4, but got O
			//IL_04a5: Expected O, but got I
			//IL_04ca: Expected O, but got I
			//IL_04e4: Expected O, but got I4
			//IL_01de: Expected O, but got I
			//IL_055a: Expected O, but got I
			//IL_0522: Expected O, but got I4
			//IL_05cd: Expected I4, but got O
			//IL_0240: Expected O, but got I
			//IL_0262: Expected O, but got I4
			//IL_05ba: Expected O, but got I
			//IL_05bf: Expected I4, but got O
			object obj = typeof(System.Runtime.Remoting.Messaging.CallContextSecurityData) + 2360;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [91E721F]");
			object obj2 = (nint)0 & (nint)1;
			if (obj2 != null)
			{
				object obj3 = obj;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v47 @ X0_v20+E4]");
				if ((nint)0 != 0)
				{
					goto IL_0074;
				}
			}
			else
			{
				_ = 1;
				object obj3 = obj;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v47 @ X0_v20+E4]");
				bool flag = (nint)0 == 0;
				object obj4 = !flag;
				if (obj4 != null)
				{
					goto IL_0074;
				}
			}
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [91E7219]");
			object obj5 = (nint)0 & (nint)1;
			bool flag2 = obj5 == null;
			object obj6 = !flag2;
			if (obj6 != null)
			{
				goto IL_00a7;
			}
			goto IL_02fb;
			IL_01fb:
			object obj7 = obj;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v198 @ X0_v40+E4]");
			bool flag3 = (nint)0 == 0;
			object obj8 = obj7;
			if (!flag3)
			{
				goto IL_0230;
			}
			goto IL_0538;
			IL_0538:
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			object obj9 = obj;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v215 @ X0_v33+B8]");
			object obj10 = 0;
			object obj11 = obj10;
			if (obj10 != null)
			{
				goto IL_057f;
			}
			goto IL_05bf;
			IL_0230:
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v198 @ X0_v40+B8]");
			object obj12 = 0;
			obj11 = obj12;
			bool flag4 = obj12 == null;
			object obj13 = !flag4;
			if (obj13 != null)
			{
				goto IL_057f;
			}
			goto IL_05bf;
			IL_0074:
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [91E7219]");
			object obj14 = (nint)0 & (nint)1;
			if (obj14 != null)
			{
				goto IL_00a7;
			}
			goto IL_02fb;
			IL_02fb:
			_ = 1;
			object obj15 = obj;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v83 @ X0_v13+E4]");
			bool flag5 = (nint)0 == 0;
			object obj16 = !flag5;
			if (obj16 != null)
			{
				goto IL_00d4;
			}
			goto IL_0339;
			IL_00a7:
			obj15 = obj;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v83 @ X0_v13+E4]");
			if ((nint)0 != 0)
			{
				goto IL_00d4;
			}
			goto IL_0339;
			IL_0339:
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [8BE45C6]");
			object obj17 = (nint)0 & (nint)1;
			bool flag6 = obj17 == null;
			object obj18 = !flag6;
			object obj19 = 146685952;
			object obj20 = 146685952;
			if (obj18 != null)
			{
				goto IL_0119;
			}
			goto IL_0393;
			IL_00d4:
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [8BE45C6]");
			object obj21 = (nint)0 & (nint)1;
			bool flag7 = obj21 == null;
			obj19 = 146685952;
			obj20 = 146685952;
			if (!flag7)
			{
				goto IL_0119;
			}
			goto IL_0393;
			IL_0393:
			_ = 1;
			object obj22 = obj;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v131 @ X0_v26+E4]");
			bool flag8 = (nint)0 == 0;
			object obj23 = !flag8;
			obj19 = obj20;
			object obj24 = obj22;
			if (obj23 != null)
			{
				goto IL_0156;
			}
			goto IL_03e1;
			IL_0119:
			obj22 = obj;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v131 @ X0_v26+E4]");
			bool flag9 = (nint)0 == 0;
			obj24 = obj22;
			obj20 = obj19;
			if (!flag9)
			{
				goto IL_0156;
			}
			goto IL_03e1;
			IL_03e1:
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			obj22 = obj;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v131 @ X0_v26+B8]");
			object obj25 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v131 @ X0_v26+E4]");
			object obj26 = 0;
			bool flag10 = obj25 == null;
			object obj27 = !flag10;
			obj19 = obj20;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v131 @ X0_v26+E4]");
			object obj28 = 0;
			object obj29 = obj22;
			if (obj27 != null)
			{
				goto IL_01ab;
			}
			goto IL_045b;
			IL_0156:
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v131 @ X0_v26+B8]");
			obj25 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v131 @ X0_v26+E4]");
			obj26 = 0;
			bool flag11 = obj25 == null;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v131 @ X0_v26+E4]");
			obj28 = 0;
			obj29 = obj22;
			if (!flag11)
			{
				goto IL_01ab;
			}
			goto IL_045b;
			IL_045b:
			bool flag12 = obj28 == null;
			object obj30 = !flag12;
			if (obj30 == null)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
				object obj31 = obj;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v178 @ X8_v5+B8]");
				obj25 = 0;
			}
			object obj32 = obj25 + 96;
			return (ServerEnvironment)obj32;
			IL_05bf:
			NullReferenceException ex = new NullReferenceException();
			return (ServerEnvironment)ex;
			IL_057f:
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v218 @ X8_v23+18]");
			if ((nint)0 != 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v218 @ X8_v23+18]");
				object obj33 = (nint)0 + (nint)24;
				return (ServerEnvironment)obj33;
			}
			goto IL_05bf;
			IL_01ab:
			if (obj26 != null)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [8BE45C6]");
				object obj34 = (nint)0 & (nint)1;
				if (obj34 != null)
				{
					goto IL_01fb;
				}
			}
			else
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v137 @ X20_v10+5C6]");
				object obj35 = (nint)0 & (nint)1;
				bool flag13 = obj35 == null;
				object obj36 = !flag13;
				if (obj36 != null)
				{
					goto IL_01fb;
				}
			}
			_ = 1;
			obj7 = obj;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v198 @ X0_v40+E4]");
			bool flag14 = (nint)0 == 0;
			object obj37 = !flag14;
			obj8 = obj7;
			if (obj37 != null)
			{
				goto IL_0230;
			}
			goto IL_0538;
		}
		set
		{
			//IL_000f: Unknown result type (might be due to invalid IL or missing references)
			//IL_0014: Expected O, but got Unknown
			//IL_002a: Expected O, but got I
			//IL_0151: Expected O, but got I4
			//IL_008a: Expected O, but got I
			//IL_01d7: Expected O, but got I4
			//IL_017f: Expected O, but got I
			//IL_0199: Expected O, but got I4
			//IL_00ec: Expected O, but got I
			//IL_010e: Expected O, but got I4
			//IL_022c: Expected O, but got I
			//IL_020f: Expected O, but got I
			object obj = typeof(System.Runtime.Remoting.Messaging.CallContextSecurityData) + 2360;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [91E70FC]");
			object obj2 = (nint)0 & (nint)1;
			if (obj2 != null)
			{
				object obj3 = obj;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v53 @ X0_v12+E4]");
				if ((nint)0 != 0)
				{
					goto IL_0074;
				}
			}
			else
			{
				_ = 1;
				object obj3 = obj;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v53 @ X0_v12+E4]");
				bool flag = (nint)0 == 0;
				object obj4 = !flag;
				if (obj4 != null)
				{
					goto IL_0074;
				}
			}
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [8BE45C6]");
			object obj5 = (nint)0 & (nint)1;
			bool flag2 = obj5 == null;
			object obj6 = !flag2;
			if (obj6 != null)
			{
				goto IL_00a7;
			}
			goto IL_01a7;
			IL_021c:
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v100 @ X8_v3+18]");
			object obj7 = 0;
			return;
			IL_00dc:
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v78 @ X0_v18+B8]");
			object obj8 = 0;
			object obj9 = obj8;
			bool flag3 = obj8 == null;
			object obj10 = !flag3;
			if (obj10 == null)
			{
				throw new NullReferenceException();
			}
			goto IL_021c;
			IL_01ed:
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			object obj11 = obj;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v97 @ X0_v6+B8]");
			object obj12 = 0;
			obj9 = obj12;
			goto IL_021c;
			IL_0074:
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [8BE45C6]");
			object obj13 = (nint)0 & (nint)1;
			if (obj13 != null)
			{
				goto IL_00a7;
			}
			goto IL_01a7;
			IL_01a7:
			_ = 1;
			object obj14 = obj;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v78 @ X0_v18+E4]");
			bool flag4 = (nint)0 == 0;
			object obj15 = !flag4;
			object obj16 = obj14;
			if (obj15 != null)
			{
				goto IL_00dc;
			}
			goto IL_01ed;
			IL_00a7:
			obj14 = obj;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v78 @ X0_v18+E4]");
			bool flag5 = (nint)0 == 0;
			obj16 = obj14;
			if (!flag5)
			{
				goto IL_00dc;
			}
			goto IL_01ed;
		}
	}

	public static event Action OnLastUpdatesChanged
	{
		add
		{
			//IL_000f: Unknown result type (might be due to invalid IL or missing references)
			//IL_0014: Expected O, but got Unknown
			//IL_0152: Expected O, but got I4
			//IL_016f: Unknown result type (might be due to invalid IL or missing references)
			//IL_0174: Expected O, but got Unknown
			//IL_0184: Expected O, but got I
			//IL_0194: Expected O, but got I
			//IL_00fb: Expected O, but got I4
			//IL_0046: Expected O, but got I
			object obj = typeof(System.Runtime.Remoting.Messaging.CallContextSecurityData) + 2360;
			object obj2 = obj;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v56 @ X0_v3+E4]");
			bool flag = (nint)0 == 0;
			object obj3 = !flag;
			if (obj3 == null)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
				obj2 = obj;
			}
			object obj4 = typeof(SqlSingle[]) + 2376;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v56 @ X0_v3+B8]");
			object obj5 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v60 @ X8_v4+38]");
			Delegate obj6 = (Delegate)0;
			Delegate obj12 = default(Delegate);
			while (true)
			{
				Delegate obj7 = Delegate.Combine(obj6, value);
				bool flag2 = (object)obj7 == null;
				Delegate obj8 = value;
				if (!flag2)
				{
					obj8 = (Delegate)obj4;
					if (obj7 != obj4)
					{
						break;
					}
				}
				object obj9 = obj;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v136 @ X0_v10+E4]");
				bool flag3 = (nint)0 == 0;
				object obj10 = !flag3;
				if (obj10 == null)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
					obj9 = obj;
				}
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v136 @ X0_v10+B8]");
				object obj11 = (nint)0 + (nint)56;
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @B0C814");
				bool flag4 = (object)obj12 == obj6;
				obj6 = obj12;
				if (!flag4)
				{
					continue;
				}
				return;
			}
			throw new InvalidCastException();
		}
		remove
		{
			//IL_000f: Unknown result type (might be due to invalid IL or missing references)
			//IL_0014: Expected O, but got Unknown
			//IL_0152: Expected O, but got I4
			//IL_016f: Unknown result type (might be due to invalid IL or missing references)
			//IL_0174: Expected O, but got Unknown
			//IL_0184: Expected O, but got I
			//IL_0194: Expected O, but got I
			//IL_00fb: Expected O, but got I4
			//IL_0046: Expected O, but got I
			object obj = typeof(System.Runtime.Remoting.Messaging.CallContextSecurityData) + 2360;
			object obj2 = obj;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v56 @ X0_v3+E4]");
			bool flag = (nint)0 == 0;
			object obj3 = !flag;
			if (obj3 == null)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
				obj2 = obj;
			}
			object obj4 = typeof(SqlSingle[]) + 2376;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v56 @ X0_v3+B8]");
			object obj5 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v60 @ X8_v4+38]");
			Delegate obj6 = (Delegate)0;
			Delegate obj12 = default(Delegate);
			while (true)
			{
				Delegate obj7 = Delegate.Remove(obj6, value);
				bool flag2 = (object)obj7 == null;
				Delegate obj8 = value;
				if (!flag2)
				{
					obj8 = (Delegate)obj4;
					if (obj7 != obj4)
					{
						break;
					}
				}
				object obj9 = obj;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v136 @ X0_v10+E4]");
				bool flag3 = (nint)0 == 0;
				object obj10 = !flag3;
				if (obj10 == null)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
					obj9 = obj;
				}
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v136 @ X0_v10+B8]");
				object obj11 = (nint)0 + (nint)56;
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @B0C814");
				bool flag4 = (object)obj12 == obj6;
				obj6 = obj12;
				if (!flag4)
				{
					continue;
				}
				return;
			}
			throw new InvalidCastException();
		}
	}

	public static event Action OnLoggedIn
	{
		add
		{
			//IL_000f: Unknown result type (might be due to invalid IL or missing references)
			//IL_0014: Expected O, but got Unknown
			//IL_0152: Expected O, but got I4
			//IL_016f: Unknown result type (might be due to invalid IL or missing references)
			//IL_0174: Expected O, but got Unknown
			//IL_0184: Expected O, but got I
			//IL_0194: Expected O, but got I
			//IL_00fb: Expected O, but got I4
			//IL_0046: Expected O, but got I
			object obj = typeof(System.Runtime.Remoting.Messaging.CallContextSecurityData) + 2360;
			object obj2 = obj;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v56 @ X0_v3+E4]");
			bool flag = (nint)0 == 0;
			object obj3 = !flag;
			if (obj3 == null)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
				obj2 = obj;
			}
			object obj4 = typeof(SqlSingle[]) + 2376;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v56 @ X0_v3+B8]");
			object obj5 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v60 @ X8_v4+40]");
			Delegate obj6 = (Delegate)0;
			Delegate obj12 = default(Delegate);
			while (true)
			{
				Delegate obj7 = Delegate.Combine(obj6, value);
				bool flag2 = (object)obj7 == null;
				Delegate obj8 = value;
				if (!flag2)
				{
					obj8 = (Delegate)obj4;
					if (obj7 != obj4)
					{
						break;
					}
				}
				object obj9 = obj;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v136 @ X0_v10+E4]");
				bool flag3 = (nint)0 == 0;
				object obj10 = !flag3;
				if (obj10 == null)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
					obj9 = obj;
				}
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v136 @ X0_v10+B8]");
				object obj11 = (nint)0 + (nint)64;
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @B0C814");
				bool flag4 = (object)obj12 == obj6;
				obj6 = obj12;
				if (!flag4)
				{
					continue;
				}
				return;
			}
			throw new InvalidCastException();
		}
		remove
		{
			//IL_000f: Unknown result type (might be due to invalid IL or missing references)
			//IL_0014: Expected O, but got Unknown
			//IL_0152: Expected O, but got I4
			//IL_016f: Unknown result type (might be due to invalid IL or missing references)
			//IL_0174: Expected O, but got Unknown
			//IL_0184: Expected O, but got I
			//IL_0194: Expected O, but got I
			//IL_00fb: Expected O, but got I4
			//IL_0046: Expected O, but got I
			object obj = typeof(System.Runtime.Remoting.Messaging.CallContextSecurityData) + 2360;
			object obj2 = obj;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v56 @ X0_v3+E4]");
			bool flag = (nint)0 == 0;
			object obj3 = !flag;
			if (obj3 == null)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
				obj2 = obj;
			}
			object obj4 = typeof(SqlSingle[]) + 2376;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v56 @ X0_v3+B8]");
			object obj5 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v60 @ X8_v4+40]");
			Delegate obj6 = (Delegate)0;
			Delegate obj12 = default(Delegate);
			while (true)
			{
				Delegate obj7 = Delegate.Remove(obj6, value);
				bool flag2 = (object)obj7 == null;
				Delegate obj8 = value;
				if (!flag2)
				{
					obj8 = (Delegate)obj4;
					if (obj7 != obj4)
					{
						break;
					}
				}
				object obj9 = obj;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v136 @ X0_v10+E4]");
				bool flag3 = (nint)0 == 0;
				object obj10 = !flag3;
				if (obj10 == null)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
					obj9 = obj;
				}
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v136 @ X0_v10+B8]");
				object obj11 = (nint)0 + (nint)64;
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @B0C814");
				bool flag4 = (object)obj12 == obj6;
				obj6 = obj12;
				if (!flag4)
				{
					continue;
				}
				return;
			}
			throw new InvalidCastException();
		}
	}

	public static void Initialize(KammelnaConfigLoader configLoader, Action<bool> action)
	{
		//IL_000f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0014: Expected O, but got Unknown
		//IL_002a: Expected O, but got I
		//IL_0293: Expected O, but got I4
		//IL_008a: Expected O, but got I
		//IL_0319: Expected O, but got I4
		//IL_02c1: Expected O, but got I
		//IL_02db: Expected O, but got I4
		//IL_00ea: Expected O, but got I
		//IL_039f: Expected O, but got I4
		//IL_0347: Expected O, but got I
		//IL_0361: Expected O, but got I4
		//IL_014c: Expected O, but got I
		//IL_03d7: Expected O, but got I
		//IL_03f1: Expected O, but got I4
		//IL_0619: Expected O, but got I
		//IL_0633: Expected O, but got I4
		//IL_0442: Expected O, but got I
		//IL_050e: Expected O, but got I
		//IL_0528: Expected O, but got I4
		//IL_0671: Expected O, but got I4
		//IL_01bc: Expected O, but got I
		//IL_04d0: Expected O, but got I4
		//IL_05ae: Expected O, but got I
		//IL_056e: Expected O, but got I4
		//IL_05d3: Expected O, but got I
		//IL_022e: Expected O, but got I
		//IL_0250: Expected O, but got I4
		object obj = typeof(System.Runtime.Remoting.Messaging.CallContextSecurityData) + 2360;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [91E7220]");
		object obj2 = (nint)0 & (nint)1;
		if (obj2 != null)
		{
			object obj3 = obj;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v58 @ X0_v46+E4]");
			if ((nint)0 != 0)
			{
				goto IL_0074;
			}
		}
		else
		{
			_ = 1;
			object obj3 = obj;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v58 @ X0_v46+E4]");
			bool flag = (nint)0 == 0;
			object obj4 = !flag;
			if (obj4 != null)
			{
				goto IL_0074;
			}
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [91E7219]");
		object obj5 = (nint)0 & (nint)1;
		bool flag2 = obj5 == null;
		object obj6 = !flag2;
		if (obj6 != null)
		{
			goto IL_00a7;
		}
		goto IL_02e9;
		IL_01e1:
		object obj7 = obj;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v263 @ X0_v3+E4]");
		bool flag3 = (nint)0 == 0;
		Action<bool> action3;
		Action<bool> action2 = action3;
		object obj8 = obj7;
		if (!flag3)
		{
			goto IL_021e;
		}
		goto IL_058c;
		IL_053e:
		_ = 1;
		obj7 = obj;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v263 @ X0_v3+E4]");
		bool flag4 = (nint)0 == 0;
		object obj9 = !flag4;
		action3 = action2;
		obj8 = obj7;
		if (obj9 != null)
		{
			goto IL_021e;
		}
		goto IL_058c;
		IL_01a6:
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [8BE45C6]");
		object obj10 = (nint)0 & (nint)1;
		bool flag5 = obj10 == null;
		action2 = action3;
		if (!flag5)
		{
			goto IL_01e1;
		}
		goto IL_053e;
		IL_0074:
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [91E7219]");
		object obj11 = (nint)0 & (nint)1;
		if (obj11 != null)
		{
			goto IL_00a7;
		}
		goto IL_02e9;
		IL_02e9:
		_ = 1;
		object obj12 = obj;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v94 @ X0_v39+E4]");
		bool flag6 = (nint)0 == 0;
		object obj13 = !flag6;
		if (obj13 != null)
		{
			goto IL_00d4;
		}
		goto IL_0327;
		IL_00a7:
		obj12 = obj;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v94 @ X0_v39+E4]");
		if ((nint)0 != 0)
		{
			goto IL_00d4;
		}
		goto IL_0327;
		IL_0327:
		Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [8BE45C6]");
		object obj14 = (nint)0 & (nint)1;
		bool flag7 = obj14 == null;
		object obj15 = !flag7;
		if (obj15 != null)
		{
			goto IL_0107;
		}
		goto IL_036f;
		IL_00d4:
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [8BE45C6]");
		object obj16 = (nint)0 & (nint)1;
		if (obj16 != null)
		{
			goto IL_0107;
		}
		goto IL_036f;
		IL_036f:
		_ = 1;
		object obj17 = obj;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v170 @ X0_v13+E4]");
		bool flag8 = (nint)0 == 0;
		object obj18 = !flag8;
		object obj19 = obj17;
		if (obj18 != null)
		{
			goto IL_013c;
		}
		goto IL_03b5;
		IL_0107:
		obj17 = obj;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v170 @ X0_v13+E4]");
		bool flag9 = (nint)0 == 0;
		obj19 = obj17;
		if (!flag9)
		{
			goto IL_013c;
		}
		goto IL_03b5;
		IL_03b5:
		Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		obj17 = obj;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v170 @ X0_v13+B8]");
		object obj20 = 0;
		bool flag10 = obj20 == null;
		object obj21 = !flag10;
		object obj22 = obj17;
		if (obj21 != null)
		{
			goto IL_0171;
		}
		goto IL_0407;
		IL_013c:
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v170 @ X0_v13+B8]");
		object obj23 = 0;
		bool flag11 = obj23 == null;
		obj22 = obj17;
		if (!flag11)
		{
			goto IL_0171;
		}
		goto IL_0407;
		IL_0407:
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v146 @ X0_v15+E4]");
		if ((nint)0 != 0)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [8BE45CA]");
			object obj24 = (nint)0 & (nint)1;
			if (obj24 != null)
			{
				goto IL_045f;
			}
		}
		else
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [8BE45CA]");
			object obj25 = (nint)0 & (nint)1;
			bool flag12 = obj25 == null;
			object obj26 = !flag12;
			if (obj26 != null)
			{
				goto IL_045f;
			}
		}
		_ = 1;
		object obj27 = obj;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v244 @ X0_v25+E4]");
		bool flag13 = (nint)0 == 0;
		object obj28 = !flag13;
		object obj29 = obj27;
		if (obj28 != null)
		{
			goto IL_0494;
		}
		goto IL_0687;
		IL_05c3:
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v261 @ X9_v2+18]");
		object obj30 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v270 @ X9_v3+18]");
		_ = 0;
		ApplySavedDevelopmentHost();
		LoadServersConfig(action);
		return;
		IL_021e:
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v263 @ X0_v3+B8]");
		object obj31 = 0;
		object obj32 = obj31;
		bool flag14 = obj31 == null;
		object obj33 = !flag14;
		if (obj33 == null)
		{
			throw new NullReferenceException();
		}
		goto IL_05c3;
		IL_058c:
		Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		obj7 = obj;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v263 @ X0_v3+B8]");
		obj31 = 0;
		obj32 = obj31;
		action3 = action2;
		goto IL_05c3;
		IL_045f:
		obj27 = obj;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v244 @ X0_v25+E4]");
		bool flag15 = (nint)0 == 0;
		obj29 = obj27;
		if (!flag15)
		{
			goto IL_0494;
		}
		goto IL_0687;
		IL_0687:
		Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		obj27 = obj;
		goto IL_0494;
		IL_0494:
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
		obj17 = obj;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v170 @ X0_v13+E4]");
		bool flag16 = (nint)0 == 0;
		object obj34 = !flag16;
		action3 = (Action<bool>)(object)configLoader;
		action2 = (Action<bool>)(object)configLoader;
		if (obj34 != null)
		{
			goto IL_01a6;
		}
		goto IL_04ee;
		IL_0171:
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v170 @ X0_v13+E4]");
		bool flag17 = (nint)0 == 0;
		action3 = action;
		action2 = action;
		if (!flag17)
		{
			goto IL_01a6;
		}
		goto IL_04ee;
		IL_04ee:
		Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [8BE45C6]");
		object obj35 = (nint)0 & (nint)1;
		bool flag18 = obj35 == null;
		object obj36 = !flag18;
		action3 = action2;
		if (obj36 != null)
		{
			goto IL_01e1;
		}
		goto IL_053e;
	}

	private static void ApplySavedDevelopmentHost()
	{
		//IL_000f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0014: Expected O, but got Unknown
		//IL_002a: Expected O, but got I
		//IL_0151: Expected O, but got I4
		//IL_008a: Expected O, but got I
		//IL_01d7: Expected O, but got I4
		//IL_017f: Expected O, but got I
		//IL_0199: Expected O, but got I4
		//IL_00ec: Expected O, but got I
		//IL_010e: Expected O, but got I4
		//IL_022c: Expected O, but got I
		//IL_020f: Expected O, but got I
		//IL_034b: Expected O, but got I
		//IL_0365: Expected O, but got I4
		//IL_0294: Expected O, but got I
		//IL_03db: Expected O, but got I
		//IL_03a3: Expected O, but got I4
		//IL_03f8: Expected O, but got I
		//IL_02f6: Expected O, but got I
		//IL_0318: Expected O, but got I4
		//IL_0406: Unknown result type (might be due to invalid IL or missing references)
		//IL_040b: Expected O, but got Unknown
		//IL_041b: Expected O, but got I
		//IL_042f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0434: Expected O, but got Unknown
		//IL_0440: Expected O, but got I
		//IL_057b: Expected O, but got I
		//IL_0595: Expected O, but got I4
		//IL_04c4: Expected O, but got I
		//IL_060b: Expected O, but got I
		//IL_05d3: Expected O, but got I4
		//IL_062e: Expected O, but got I
		//IL_0526: Expected O, but got I
		//IL_0548: Expected O, but got I4
		object obj = typeof(System.Runtime.Remoting.Messaging.CallContextSecurityData) + 2360;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [91E70FD]");
		object obj2 = (nint)0 & (nint)1;
		if (obj2 != null)
		{
			object obj3 = obj;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v51 @ X0_v50+E4]");
			if ((nint)0 != 0)
			{
				goto IL_0074;
			}
		}
		else
		{
			_ = 1;
			object obj3 = obj;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v51 @ X0_v50+E4]");
			bool flag = (nint)0 == 0;
			object obj4 = !flag;
			if (obj4 != null)
			{
				goto IL_0074;
			}
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [8BE45C6]");
		object obj5 = (nint)0 & (nint)1;
		bool flag2 = obj5 == null;
		object obj6 = !flag2;
		if (obj6 != null)
		{
			goto IL_00a7;
		}
		goto IL_01a7;
		IL_05e9:
		Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		object obj7 = obj;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v147 @ X0_v18+B8]");
		object obj8 = 0;
		object obj9 = obj8;
		goto IL_0618;
		IL_03e8:
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v247 @ X8_v8+18]");
		object obj10 = 0;
		object obj12;
		object obj11 = obj12 + 72;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v159 @ X8_v9+20]");
		obj11 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
		object key = "DNQUALIFIER" + 2912;
		object defaultValue = (nint)0 + (nint)2000;
		string text = Prefs.GetString((string)key, (string)defaultValue);
		if (string.IsNullOrEmpty(text))
		{
			return;
		}
		object obj13 = obj;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v259 @ X0_v11+E4]");
		if ((nint)0 != 0)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [8BE45C6]");
			object obj14 = (nint)0 & (nint)1;
			if (obj14 != null)
			{
				goto IL_04e1;
			}
		}
		else
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [8BE45C6]");
			object obj15 = (nint)0 & (nint)1;
			bool flag3 = obj15 == null;
			object obj16 = !flag3;
			if (obj16 != null)
			{
				goto IL_04e1;
			}
		}
		_ = 1;
		object obj17 = obj;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v146 @ X0_v25+E4]");
		bool flag4 = (nint)0 == 0;
		object obj18 = !flag4;
		object obj19 = obj17;
		if (obj18 != null)
		{
			goto IL_0516;
		}
		goto IL_05e9;
		IL_02e6:
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v233 @ X0_v38+B8]");
		obj12 = 0;
		object obj20 = obj12;
		bool flag5 = obj12 == null;
		object obj21 = !flag5;
		if (obj21 != null)
		{
			goto IL_03e8;
		}
		goto IL_0641;
		IL_0074:
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [8BE45C6]");
		object obj22 = (nint)0 & (nint)1;
		if (obj22 != null)
		{
			goto IL_00a7;
		}
		goto IL_01a7;
		IL_01a7:
		_ = 1;
		object obj23 = obj;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v101 @ X0_v3+E4]");
		bool flag6 = (nint)0 == 0;
		object obj24 = !flag6;
		object obj25 = obj23;
		if (obj24 != null)
		{
			goto IL_00dc;
		}
		goto IL_01ed;
		IL_00a7:
		obj23 = obj;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v101 @ X0_v3+E4]");
		bool flag7 = (nint)0 == 0;
		obj25 = obj23;
		if (!flag7)
		{
			goto IL_00dc;
		}
		goto IL_01ed;
		IL_01ed:
		Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		obj23 = obj;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v101 @ X0_v3+B8]");
		object obj26 = 0;
		object obj27 = obj26;
		goto IL_021c;
		IL_00dc:
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v101 @ X0_v3+B8]");
		object obj28 = 0;
		obj27 = obj28;
		bool flag8 = obj28 == null;
		object obj29 = !flag8;
		if (obj29 != null)
		{
			goto IL_021c;
		}
		goto IL_0641;
		IL_021c:
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v105 @ X8_v3+18]");
		object obj30 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v107 @ X8_v4+18]");
		if ((nint)0 != 2)
		{
			return;
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v101 @ X0_v3+E4]");
		if ((nint)0 != 0)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [8BE45C6]");
			object obj31 = (nint)0 & (nint)1;
			if (obj31 != null)
			{
				goto IL_02b1;
			}
		}
		else
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [8BE45C6]");
			object obj32 = (nint)0 & (nint)1;
			bool flag9 = obj32 == null;
			object obj33 = !flag9;
			if (obj33 != null)
			{
				goto IL_02b1;
			}
		}
		_ = 1;
		object obj34 = obj;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v233 @ X0_v38+E4]");
		bool flag10 = (nint)0 == 0;
		object obj35 = !flag10;
		object obj36 = obj34;
		if (obj35 != null)
		{
			goto IL_02e6;
		}
		goto IL_03b9;
		IL_0641:
		throw new NullReferenceException();
		IL_04e1:
		obj17 = obj;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v146 @ X0_v25+E4]");
		bool flag11 = (nint)0 == 0;
		obj19 = obj17;
		if (!flag11)
		{
			goto IL_0516;
		}
		goto IL_05e9;
		IL_0516:
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v146 @ X0_v25+B8]");
		object obj37 = 0;
		obj9 = obj37;
		bool flag12 = obj37 == null;
		object obj38 = !flag12;
		if (obj38 != null)
		{
			goto IL_0618;
		}
		goto IL_0641;
		IL_0618:
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v162 @ X8_v15+18]");
		object obj39 = (nint)0 + (nint)32;
		obj39 = text;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
		return;
		IL_02b1:
		obj34 = obj;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v233 @ X0_v38+E4]");
		bool flag13 = (nint)0 == 0;
		obj36 = obj34;
		if (!flag13)
		{
			goto IL_02e6;
		}
		goto IL_03b9;
		IL_03b9:
		Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		object obj40 = obj;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v248 @ X0_v30+B8]");
		obj12 = 0;
		obj20 = obj12;
		goto IL_03e8;
	}

	public static void LoadServersConfig(Action<bool> action)
	{
		//IL_000f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0014: Expected O, but got Unknown
		//IL_002a: Expected O, but got I
		//IL_0137: Expected O, but got I4
		//IL_008a: Expected O, but got I
		//IL_01bd: Expected O, but got I4
		//IL_0165: Expected O, but got I
		//IL_017f: Expected O, but got I4
		//IL_00ec: Expected O, but got I
		//IL_01f5: Expected O, but got I
		//IL_0217: Expected O, but got I4
		object obj = typeof(System.Runtime.Remoting.Messaging.CallContextSecurityData) + 2360;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [91E70FE]");
		object obj2 = (nint)0 & (nint)1;
		if (obj2 != null)
		{
			object obj3 = obj;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v53 @ X0_v12+E4]");
			if ((nint)0 != 0)
			{
				goto IL_0074;
			}
		}
		else
		{
			_ = 1;
			object obj3 = obj;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v53 @ X0_v12+E4]");
			bool flag = (nint)0 == 0;
			object obj4 = !flag;
			if (obj4 != null)
			{
				goto IL_0074;
			}
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [8BE45C6]");
		object obj5 = (nint)0 & (nint)1;
		bool flag2 = obj5 == null;
		object obj6 = !flag2;
		if (obj6 != null)
		{
			goto IL_00a7;
		}
		goto IL_018d;
		IL_00dc:
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v78 @ X0_v19+B8]");
		object obj7 = 0;
		KammelnaConfigLoader kammelnaConfigLoader = (KammelnaConfigLoader)obj7;
		goto IL_00f9;
		IL_00f9:
		kammelnaConfigLoader.LoadServersConfig(action);
		return;
		IL_01d3:
		Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		object obj8 = obj;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v114 @ X0_v5+B8]");
		object obj9 = 0;
		kammelnaConfigLoader = (KammelnaConfigLoader)obj9;
		bool flag3 = obj9 == null;
		object obj10 = !flag3;
		if (obj10 == null)
		{
			throw new NullReferenceException();
		}
		goto IL_00f9;
		IL_0074:
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [8BE45C6]");
		object obj11 = (nint)0 & (nint)1;
		if (obj11 != null)
		{
			goto IL_00a7;
		}
		goto IL_018d;
		IL_018d:
		_ = 1;
		object obj12 = obj;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v78 @ X0_v19+E4]");
		bool flag4 = (nint)0 == 0;
		object obj13 = !flag4;
		object obj14 = obj12;
		if (obj13 != null)
		{
			goto IL_00dc;
		}
		goto IL_01d3;
		IL_00a7:
		obj12 = obj;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v78 @ X0_v19+E4]");
		bool flag5 = (nint)0 == 0;
		obj14 = obj12;
		if (!flag5)
		{
			goto IL_00dc;
		}
		goto IL_01d3;
	}

	public static void SetDevelopmentHost(string host)
	{
		//IL_000f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0014: Expected O, but got Unknown
		//IL_002a: Expected O, but got I
		//IL_01c3: Expected O, but got I4
		//IL_008a: Expected O, but got I
		//IL_0249: Expected O, but got I4
		//IL_01f1: Expected O, but got I
		//IL_020b: Expected O, but got I4
		//IL_00ea: Expected O, but got I
		//IL_0102: Expected O, but got I4
		//IL_010b: Expected O, but got I4
		//IL_02e1: Expected O, but got I4
		//IL_0277: Expected O, but got I
		//IL_0291: Expected O, but got I4
		//IL_029a: Expected O, but got I4
		//IL_02a3: Expected O, but got I4
		//IL_0166: Expected O, but got I
		//IL_0180: Expected O, but got I4
		//IL_0368: Expected O, but got I4
		//IL_0321: Expected O, but got I
		//IL_0d72: Unknown result type (might be due to invalid IL or missing references)
		//IL_0d77: Expected O, but got Unknown
		//IL_0d9a: Unknown result type (might be due to invalid IL or missing references)
		//IL_0d9f: Expected O, but got Unknown
		//IL_0dc8: Expected O, but got I
		//IL_0417: Expected O, but got I4
		//IL_0427: Expected O, but got I
		//IL_0437: Expected O, but got I
		//IL_03f2: Expected O, but got I4
		//IL_0470: Unknown result type (might be due to invalid IL or missing references)
		//IL_0475: Expected O, but got Unknown
		//IL_04a5: Expected O, but got I4
		//IL_04ae: Expected O, but got I4
		//IL_051f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0524: Expected O, but got Unknown
		//IL_04cf: Unknown result type (might be due to invalid IL or missing references)
		//IL_04d4: Expected O, but got Unknown
		//IL_04fe: Expected O, but got I4
		//IL_06a2: Expected O, but got I
		//IL_06b3: Expected O, but got I
		//IL_07f2: Expected O, but got I4
		//IL_06d6: Expected O, but got I4
		//IL_0574: Expected O, but got I
		//IL_0585: Expected O, but got I
		//IL_082b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0830: Expected O, but got Unknown
		//IL_085a: Expected O, but got I4
		//IL_0b2c: Expected O, but got I
		//IL_0b46: Expected O, but got I4
		//IL_09e7: Expected O, but got I
		//IL_0a01: Expected O, but got I4
		//IL_05fb: Expected O, but got I
		//IL_0731: Expected O, but got I
		//IL_0b9c: Expected O, but got I4
		//IL_0a77: Expected O, but got I
		//IL_0a3f: Expected O, but got I4
		//IL_08df: Expected O, but got I4
		//IL_0675: Expected O, but got I
		//IL_0a94: Expected O, but got I
		//IL_0aaa: Expected O, but got I
		//IL_0aba: Expected O, but got I
		//IL_0aee: Expected O, but got I4
		//IL_0afe: Expected O, but got I
		//IL_0793: Expected O, but got I
		//IL_07b5: Expected O, but got I4
		//IL_0c01: Expected O, but got I
		//IL_0c1b: Expected O, but got I4
		//IL_0930: Expected O, but got I
		//IL_0c91: Expected O, but got I
		//IL_0c59: Expected O, but got I4
		//IL_0cb4: Expected O, but got I
		//IL_0cd0: Unknown result type (might be due to invalid IL or missing references)
		//IL_0cd5: Expected O, but got Unknown
		//IL_0992: Expected O, but got I
		//IL_09b4: Expected O, but got I4
		//IL_0d02: Expected O, but got I
		//IL_0d1c: Expected O, but got I4
		//IL_0d25: Expected O, but got I4
		//IL_0d4d: Expected O, but got I4
		object obj = typeof(System.Runtime.Remoting.Messaging.CallContextSecurityData) + 2360;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [91E7221]");
		object obj2 = (nint)0 & (nint)1;
		if (obj2 != null)
		{
			object obj3 = obj;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v56 @ X0_v122+E4]");
			if ((nint)0 != 0)
			{
				goto IL_0074;
			}
		}
		else
		{
			_ = 1;
			object obj3 = obj;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v56 @ X0_v122+E4]");
			bool flag = (nint)0 == 0;
			object obj4 = !flag;
			if (obj4 != null)
			{
				goto IL_0074;
			}
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [91E7219]");
		object obj5 = (nint)0 & (nint)1;
		bool flag2 = obj5 == null;
		object obj6 = !flag2;
		if (obj6 != null)
		{
			goto IL_00a7;
		}
		goto IL_0219;
		IL_0a84:
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v300 @ X8_v27+48]");
		string text = (string)0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v254 @ X9_v9+18]");
		object obj7 = (nint)0 + (nint)32;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v300 @ X8_v27+48]");
		obj7 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
		object obj8 = obj;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v448 @ X0_v39+E4]");
		bool flag3 = (nint)0 == 0;
		object obj9 = !flag3;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v300 @ X8_v27+48]");
		string text2 = (string)0;
		if (obj9 != null)
		{
			goto IL_05e5;
		}
		goto IL_0b0c;
		IL_05b0:
		obj8 = obj;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v448 @ X0_v39+E4]");
		bool flag4 = (nint)0 == 0;
		text2 = text;
		if (!flag4)
		{
			goto IL_05e5;
		}
		goto IL_0b0c;
		IL_0b0c:
		Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [8BE4592]");
		object obj10 = (nint)0 & (nint)1;
		bool flag5 = obj10 == null;
		object obj11 = !flag5;
		text = text2;
		object obj13;
		object obj12 = obj13;
		StringComparison stringComparison2;
		StringComparison stringComparison = stringComparison2;
		if (obj11 != null)
		{
			goto IL_0630;
		}
		goto IL_0b6c;
		IL_0074:
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [91E7219]");
		object obj14 = (nint)0 & (nint)1;
		if (obj14 != null)
		{
			goto IL_00a7;
		}
		goto IL_0219;
		IL_0219:
		_ = 1;
		object obj15 = obj;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v100 @ X0_v115+E4]");
		bool flag6 = (nint)0 == 0;
		object obj16 = !flag6;
		if (obj16 != null)
		{
			goto IL_00d4;
		}
		goto IL_0257;
		IL_00a7:
		obj15 = obj;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v100 @ X0_v115+E4]");
		if ((nint)0 != 0)
		{
			goto IL_00d4;
		}
		goto IL_0257;
		IL_0257:
		Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [8BE45C6]");
		object obj17 = (nint)0 & (nint)1;
		bool flag7 = obj17 == null;
		object obj18 = !flag7;
		object obj19 = 146685952;
		object obj20 = 146685952;
		if (obj18 != null)
		{
			goto IL_0119;
		}
		goto IL_02b1;
		IL_00d4:
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [8BE45C6]");
		object obj21 = (nint)0 & (nint)1;
		bool flag8 = obj21 == null;
		obj19 = 146685952;
		obj20 = 146685952;
		if (!flag8)
		{
			goto IL_0119;
		}
		goto IL_02b1;
		IL_02b1:
		_ = 1;
		object obj22 = obj;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v212 @ X0_v18+E4]");
		bool flag9 = (nint)0 == 0;
		object obj23 = !flag9;
		obj19 = obj20;
		object obj24 = obj22;
		if (obj23 != null)
		{
			goto IL_0156;
		}
		goto IL_02ff;
		IL_0119:
		obj22 = obj;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v212 @ X0_v18+E4]");
		bool flag10 = (nint)0 == 0;
		obj20 = obj19;
		obj24 = obj22;
		if (!flag10)
		{
			goto IL_0156;
		}
		goto IL_02ff;
		IL_02ff:
		Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		obj22 = obj;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v212 @ X0_v18+B8]");
		object obj25 = 0;
		bool flag11 = obj25 == null;
		obj19 = obj20;
		if (!flag11)
		{
			goto IL_0346;
		}
		goto IL_0d63;
		IL_0156:
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v212 @ X0_v18+B8]");
		object obj26 = 0;
		bool flag12 = obj26 == null;
		object obj27 = !flag12;
		if (obj27 != null)
		{
			goto IL_0346;
		}
		goto IL_0d63;
		IL_0346:
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v212 @ X0_v18+E4]");
		bool flag13 = (nint)0 == 0;
		object obj28 = !flag13;
		if (obj28 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		}
		ServerEnvironment environment = Environment;
		string text4;
		if (environment == ServerEnvironment.Development)
		{
			if (host != null)
			{
				string text3 = host.Trim();
				bool flag14 = text3 == null;
				object obj29 = !flag14;
				text4 = text3;
				if (obj29 != null)
				{
					goto IL_0444;
				}
			}
			object obj30 = 153100288 + 1024;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v234 @ X8_v71+90]");
			object obj31 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v235 @ X8_v72+B8]");
			object obj32 = 0;
			text4 = (string)obj32;
			goto IL_0444;
		}
		goto IL_0d63;
		IL_0c6f:
		Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		object obj33 = obj;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v283 @ X0_v91+B8]");
		object obj34 = 0;
		object obj35 = obj34;
		goto IL_0c9e;
		IL_094d:
		object obj36 = obj;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v280 @ X0_v98+E4]");
		bool flag15 = (nint)0 == 0;
		object obj37 = obj36;
		if (!flag15)
		{
			goto IL_0982;
		}
		goto IL_0c6f;
		IL_0982:
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v280 @ X0_v98+B8]");
		object obj38 = 0;
		obj35 = obj38;
		bool flag16 = obj38 == null;
		object obj39 = !flag16;
		if (obj39 != null)
		{
			goto IL_0c9e;
		}
		goto IL_0de0;
		IL_05e5:
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [8BE4592]");
		object obj40 = (nint)0 & (nint)1;
		bool flag17 = obj40 == null;
		obj12 = obj13;
		stringComparison = stringComparison2;
		text2 = text;
		if (!flag17)
		{
			goto IL_0630;
		}
		goto IL_0b6c;
		IL_0c9e:
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v302 @ X8_v53+18]");
		object obj41 = (nint)0 + (nint)32;
		string text5;
		obj41 = text5;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
		object key = "DNQUALIFIER" + 2912;
		Prefs.SetString((string)key, text5);
		Prefs.Save();
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [8BE4592]");
		object obj42 = (nint)0 & (nint)1;
		bool flag18 = obj42 == null;
		object obj43 = !flag18;
		obj13 = 0;
		stringComparison2 = StringComparison.CurrentCulture;
		text = text5;
		if (obj43 != null)
		{
			goto IL_0630;
		}
		obj12 = 0;
		stringComparison = StringComparison.CurrentCulture;
		text2 = text5;
		goto IL_0b6c;
		IL_0444:
		if (text4._stringLength == 0)
		{
			return;
		}
		object b = "com.unity.services.authentication.profile" + 3560;
		bool flag19 = string.Equals(text4, (string)b, StringComparison.OrdinalIgnoreCase);
		bool flag20 = !flag19;
		object obj44 = !flag20;
		obj13 = 0;
		stringComparison2 = StringComparison.OrdinalIgnoreCase;
		if (obj44 == null)
		{
			object b2 = "placementId" + 3520;
			bool flag21 = string.Equals(text4, (string)b2, StringComparison.OrdinalIgnoreCase);
			bool flag22 = !flag21;
			obj13 = 0;
			stringComparison2 = StringComparison.OrdinalIgnoreCase;
			if (flag22)
			{
				object obj45 = obj;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v386 @ X0_v71+E4]");
				bool flag23 = (nint)0 == 0;
				object obj46 = !flag23;
				if (obj46 == null)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
				}
				text5 = NormalizeDevelopmentHost(host);
				object obj47 = typeof(UnityEngine.Purchasing.Telemetry.TelemetryMetricsInstanceWrapper) + 4024;
				object obj48 = obj47;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v404 @ X0_v75+E4]");
				bool flag24 = (nint)0 == 0;
				object obj49 = !flag24;
				if (obj49 == null)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
				}
				if (!Uri.TryCreate(text5, UriKind.Absolute, out var result))
				{
					return;
				}
				string host2 = result.Host;
				bool flag25 = string.IsNullOrEmpty(host2);
				bool flag26 = !flag25;
				object obj50 = !flag26;
				if (obj50 != null)
				{
					return;
				}
				object obj51 = obj;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v545 @ X0_v82+E4]");
				if ((nint)0 != 0)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v161 @ X22_v3+5C6]");
					object obj52 = (nint)0 & (nint)1;
					if (obj52 != null)
					{
						goto IL_094d;
					}
				}
				else
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v161 @ X22_v3+5C6]");
					object obj53 = (nint)0 & (nint)1;
					bool flag27 = obj53 == null;
					object obj54 = !flag27;
					if (obj54 != null)
					{
						goto IL_094d;
					}
				}
				_ = 1;
				obj36 = obj;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v280 @ X0_v98+E4]");
				bool flag28 = (nint)0 == 0;
				object obj55 = !flag28;
				obj37 = obj36;
				if (obj55 != null)
				{
					goto IL_0982;
				}
				goto IL_0c6f;
			}
		}
		object key2 = "DNQUALIFIER" + 2912;
		Prefs.DeleteKey((string)key2);
		Prefs.Save();
		object obj56 = obj;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v390 @ X0_v38+E4]");
		if ((nint)0 != 0)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v390 @ X0_v38+B8]");
			object obj57 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v397 @ X8_v45+48]");
			bool flag29 = string.IsNullOrEmpty((string)0);
			bool flag30 = !flag29;
			text = null;
			string text6 = null;
			if (!flag30)
			{
				goto IL_05b0;
			}
		}
		else
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			object obj58 = obj;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v409 @ X0_v61+B8]");
			object obj59 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v410 @ X8_v40+48]");
			bool flag31 = string.IsNullOrEmpty((string)0);
			bool flag32 = !flag31;
			object obj60 = !flag32;
			text = null;
			string text6 = null;
			if (obj60 != null)
			{
				goto IL_05b0;
			}
		}
		object obj61 = obj;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v428 @ X0_v42+E4]");
		if ((nint)0 != 0)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v161 @ X22_v3+5C6]");
			object obj62 = (nint)0 & (nint)1;
			if (obj62 != null)
			{
				goto IL_074e;
			}
		}
		else
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v161 @ X22_v3+5C6]");
			object obj63 = (nint)0 & (nint)1;
			bool flag33 = obj63 == null;
			object obj64 = !flag33;
			if (obj64 != null)
			{
				goto IL_074e;
			}
		}
		_ = 1;
		object obj65 = obj;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v278 @ X0_v57+E4]");
		bool flag34 = (nint)0 == 0;
		object obj66 = !flag34;
		object obj67 = obj65;
		if (obj66 != null)
		{
			goto IL_0783;
		}
		goto IL_0a55;
		IL_0bca:
		Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		object obj68 = obj;
		goto IL_0665;
		IL_0630:
		obj68 = obj;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v324 @ X0_v32+E4]");
		bool flag35 = (nint)0 == 0;
		object obj69 = obj68;
		if (!flag35)
		{
			goto IL_0665;
		}
		goto IL_0bca;
		IL_0b6c:
		_ = 1;
		obj68 = obj;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v324 @ X0_v32+E4]");
		bool flag36 = (nint)0 == 0;
		object obj70 = !flag36;
		obj13 = obj12;
		stringComparison2 = stringComparison;
		text = text2;
		obj69 = obj68;
		if (obj70 != null)
		{
			goto IL_0665;
		}
		goto IL_0bca;
		IL_0d63:
		object obj71 = typeof(MemberAchievementClanFeedData) + 3544;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC17CC");
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
		object obj72 = "COORDINATE_TYPE_GCJ_02" + 2624;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC17CC");
		OperationException ex = default(OperationException);
		string message = default(string);
		ex..ctor(message);
		object obj73 = (nint)0 + (nint)1752;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC17CC");
		OutOfMemoryException ex2 = new OutOfMemoryException();
		goto IL_0de0;
		IL_0de0:
		throw new NullReferenceException();
		IL_074e:
		obj65 = obj;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v278 @ X0_v57+E4]");
		bool flag37 = (nint)0 == 0;
		obj67 = obj65;
		if (!flag37)
		{
			goto IL_0783;
		}
		goto IL_0a55;
		IL_0665:
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v324 @ X0_v32+B8]");
		object obj74 = 0;
		_ = 1;
		return;
		IL_0a55:
		Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		object obj75 = obj;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v281 @ X0_v50+B8]");
		object obj76 = 0;
		object obj77 = obj76;
		goto IL_0a84;
		IL_0783:
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v278 @ X0_v57+B8]");
		obj76 = 0;
		obj77 = obj76;
		bool flag38 = obj76 == null;
		object obj78 = !flag38;
		if (obj78 != null)
		{
			goto IL_0a84;
		}
		goto IL_0de0;
	}

	private unsafe static string NormalizeDevelopmentHost(string host)
	{
		//IL_0604: Unknown result type (might be due to invalid IL or missing references)
		//IL_0609: Expected O, but got Unknown
		//IL_00ee: Expected O, but got I4
		//IL_00fe: Expected O, but got I
		//IL_010e: Expected O, but got I
		//IL_0140: Expected O, but got I4
		//IL_00a2: Expected O, but got I4
		//IL_00ab: Expected O, but got I4
		//IL_00b3: Expected O, but got Ref
		//IL_0026: Expected I, but got O
		//IL_00ca: Expected O, but got I4
		//IL_00d2: Expected O, but got Ref
		//IL_018f: Expected O, but got I4
		//IL_0197: Expected O, but got Ref
		//IL_01a8: Expected O, but got I4
		//IL_01b0: Expected O, but got Ref
		//IL_0060: Expected I, but got O
		//IL_0493: Unknown result type (might be due to invalid IL or missing references)
		//IL_0498: Expected O, but got Unknown
		//IL_028b: Expected O, but got I
		//IL_02a0: Expected O, but got I
		//IL_02c3: Expected O, but got I4
		//IL_02cc: Expected O, but got I4
		//IL_0225: Expected O, but got I
		//IL_023a: Expected O, but got I
		//IL_0256: Expected O, but got I4
		//IL_03b3: Unknown result type (might be due to invalid IL or missing references)
		//IL_03b8: Expected O, but got Unknown
		//IL_03e3: Expected O, but got I4
		//IL_0429: Expected O, but got I
		//IL_043e: Expected O, but got I
		//IL_045d: Expected O, but got I4
		//IL_046e: Expected O, but got I4
		//IL_0341: Expected O, but got I
		//IL_0356: Expected O, but got I
		//IL_0376: Expected O, but got I4
		//IL_054a: Unknown result type (might be due to invalid IL or missing references)
		//IL_054f: Expected O, but got Unknown
		//IL_0559: Unknown result type (might be due to invalid IL or missing references)
		//IL_055e: Expected O, but got Unknown
		//IL_0581: Expected I4, but got I8
		//IL_059b: Expected O, but got I4
		object obj = typeof(UnityEngine.Purchasing.Telemetry.TelemetryMetricsInstanceWrapper) + 4024;
		string text = default(string);
		string text3;
		string text4;
		object obj2;
		if (text != null)
		{
			string text2 = text.Trim();
			bool flag = text2 == null;
			nint num = unchecked((nint)null);
			if (!flag)
			{
				obj2 = obj;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v73 @ X0_v40+E4]");
				bool flag2 = (nint)0 == 0;
				text3 = text2;
				num = unchecked((nint)null);
				text4 = text2;
				if (!flag2)
				{
					goto IL_0076;
				}
				goto IL_0156;
			}
		}
		object obj3 = 153100288 + 1024;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v61 @ X8_v25+90]");
		object obj4 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v62 @ X8_v26+B8]");
		object obj5 = 0;
		text3 = (string)obj5;
		obj2 = obj;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v73 @ X0_v40+E4]");
		bool flag3 = (nint)0 == 0;
		object obj6 = !flag3;
		text4 = (string)obj5;
		if (obj6 != null)
		{
			goto IL_0076;
		}
		goto IL_0156;
		IL_05cc:
		string text5;
		text3 = text5;
		goto IL_0626;
		IL_0484:
		object obj7 = typeof(TypeConverter<ushort, char>) + 1952;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC18B4");
		char[] array = default(char[]);
		if (array == null)
		{
			goto IL_05d9;
		}
		if (array.Length != 0)
		{
			array[0] = ':';
			if (array.Length != 1)
			{
				array[1] = '/';
				if (text4 != null)
				{
					object obj8 = "getSecondRescanTask" + 3376;
					object obj9 = "1.2.840.113549.1.12.1.5" + 1816;
					int num2 = text4.IndexOfAny(array);
					int num3 = (int)(num2 & 0x80000000L);
					bool flag4 = num3 == 0;
					object obj10 = !flag4;
					if (obj10 == null)
					{
						string text6 = text4.Substring(0, num2);
						text4 = text6;
					}
					text5 = (string)obj8 + text4 + (string)obj9;
					goto IL_05cc;
				}
				goto IL_05d9;
			}
		}
		goto IL_05e7;
		IL_05e7:
		return (string)(object)new IndexOutOfRangeException();
		IL_0156:
		Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		Uri result;
		bool flag5 = Uri.TryCreate(text4, UriKind.Absolute, out result);
		bool flag6 = !flag5;
		object obj11 = 0;
		object obj12 = (object)(&result);
		text3 = text4;
		object obj13 = 0;
		object obj14 = (object)(&result);
		if (!flag6)
		{
			goto IL_01be;
		}
		goto IL_0484;
		IL_0076:
		bool flag7 = Uri.TryCreate(text3, UriKind.Absolute, out result);
		bool flag8 = !flag7;
		object obj15 = !flag8;
		obj11 = 0;
		obj12 = (object)(&result);
		if (obj15 != null)
		{
			goto IL_01be;
		}
		obj13 = 0;
		obj14 = (object)(&result);
		text4 = text3;
		goto IL_0484;
		IL_01be:
		if ((object)result != null)
		{
			string scheme = result.Scheme;
			object obj16 = obj;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v201 @ X8_v13+E4]");
			if ((nint)0 != 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v201 @ X8_v13+B8]");
				object obj17 = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v224 @ X8_v22+18]");
				bool flag9 = scheme == (string)0;
				bool flag10 = !flag9;
				object obj18 = 0;
				if (flag10)
				{
					goto IL_02da;
				}
			}
			else
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
				object obj19 = obj;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v235 @ X8_v20+B8]");
				object obj20 = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v236 @ X8_v21+18]");
				bool flag11 = scheme == (string)0;
				bool flag12 = !flag11;
				object obj21 = !flag12;
				object obj18 = 0;
				if (obj21 == null)
				{
					goto IL_02da;
				}
			}
			goto IL_038c;
		}
		goto IL_05d9;
		IL_0626:
		return text3;
		IL_038c:
		if (text3 == null)
		{
			goto IL_05d9;
		}
		object obj22 = ", stale={0}" + 2920;
		bool flag13 = text3.EndsWith((string)obj22);
		bool flag14 = !flag13;
		object obj23 = !flag14;
		if (obj23 == null)
		{
			text5 = text3 + (string)obj22;
			goto IL_05cc;
		}
		goto IL_0626;
		IL_05d9:
		NullReferenceException ex = new NullReferenceException();
		goto IL_05e7;
		IL_02da:
		if ((object)result != null)
		{
			string scheme2 = result.Scheme;
			object obj24 = obj;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v308 @ X8_v16+E4]");
			if ((nint)0 != 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v308 @ X8_v16+B8]");
				object obj25 = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v139 @ X8_v19+20]");
				bool flag15 = scheme2 == (string)0;
				bool flag16 = !flag15;
				obj13 = obj11;
				obj14 = 0;
				text4 = text3;
				if (!flag16)
				{
					goto IL_038c;
				}
			}
			else
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
				object obj26 = obj;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v360 @ X8_v17+B8]");
				object obj27 = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v138 @ X8_v18+20]");
				bool flag17 = scheme2 == (string)0;
				bool flag18 = !flag17;
				object obj28 = !flag18;
				obj13 = obj11;
				obj14 = 0;
				text4 = text3;
				if (obj28 != null)
				{
					goto IL_038c;
				}
			}
			goto IL_0484;
		}
		goto IL_05d9;
	}

	private static string GetCurrentServerId()
	{
		//IL_000f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0014: Expected O, but got Unknown
		//IL_0023: Unknown result type (might be due to invalid IL or missing references)
		//IL_0028: Expected O, but got Unknown
		//IL_0355: Unknown result type (might be due to invalid IL or missing references)
		//IL_035a: Expected O, but got Unknown
		//IL_0366: Expected O, but got I
		//IL_03a3: Expected O, but got I4
		//IL_0091: Unknown result type (might be due to invalid IL or missing references)
		//IL_0096: Expected O, but got Unknown
		//IL_00a2: Expected O, but got I
		//IL_00ab: Unknown result type (might be due to invalid IL or missing references)
		//IL_00b0: Expected O, but got Unknown
		//IL_00e2: Expected I, but got O
		//IL_010b: Expected O, but got I
		//IL_0151: Unknown result type (might be due to invalid IL or missing references)
		//IL_0156: Expected O, but got Unknown
		//IL_01fa: Expected O, but got I
		//IL_020a: Expected O, but got I
		//IL_022c: Expected O, but got I4
		//IL_0193: Expected O, but got I
		//IL_01a3: Expected O, but got I
		//IL_01c5: Expected O, but got I4
		//IL_025c: Expected O, but got I4
		//IL_02cd: Expected O, but got I
		//IL_03c0: Unknown result type (might be due to invalid IL or missing references)
		//IL_03c5: Expected O, but got Unknown
		//IL_03db: Expected O, but got I
		//IL_03ec: Expected I, but got O
		//IL_040a: Expected O, but got I
		//IL_0308: Expected O, but got I
		//IL_032a: Expected O, but got I4
		//IL_028c: Expected O, but got I
		object obj = typeof(CardUtils.<>c) + 2168;
		object obj2 = typeof(System.Runtime.Remoting.Messaging.CallContextSecurityData) + 2360;
		object key = "SERVICE_DISABLED" + 3488;
		object defaultValue = (nint)0 + (nint)2000;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
		object obj3 = default(object);
		obj3..ctor();
		object obj4 = obj2;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v64 @ X0_v4+E4]");
		bool flag = (nint)0 == 0;
		object obj5 = !flag;
		if (obj5 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		}
		List<SFSConfig> currentGameServers = GetCurrentGameServers(includeRestricted: false, includeFastTrack: true);
		string text = Prefs.GetString((string)key, (string)defaultValue);
		object obj8;
		object obj10;
		object obj12;
		Func<object, bool> predicate2;
		if (obj3 != null)
		{
			object obj6 = typeof(List<Tween>) + 3432;
			object obj7 = (nint)0 + (nint)1696;
			obj8 = obj3 + 16;
			obj8 = text;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
			Predicate<object> predicate = default(Predicate<object>);
			predicate..ctor(obj3, (IntPtr)obj7);
			if (currentGameServers != null)
			{
				object obj9 = (nint)0 + (nint)432;
				if (((List<object>)(object)currentGameServers).Exists(predicate))
				{
					goto IL_0135;
				}
				obj10 = typeof(CardUtils.<>c) + 2160;
				object obj11 = obj10;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v237 @ X0_v27+E4]");
				if ((nint)0 != 0)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v237 @ X0_v27+B8]");
					obj12 = 0;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v244 @ X8_v14+28]");
					predicate2 = (Func<object, bool>)0;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v244 @ X8_v14+28]");
					bool flag2 = (nint)0 == 0;
					object obj13 = !flag2;
					if (obj13 == null)
					{
						goto IL_023a;
					}
				}
				else
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
					obj11 = obj10;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v237 @ X0_v27+B8]");
					obj12 = 0;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v244 @ X8_v14+28]");
					predicate2 = (Func<object, bool>)0;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v244 @ X8_v14+28]");
					bool flag3 = (nint)0 == 0;
					object obj14 = !flag3;
					if (obj14 == null)
					{
						goto IL_023a;
					}
				}
				goto IL_0291;
			}
		}
		return (string)(object)new NullReferenceException();
		IL_0429:
		string result;
		return result;
		IL_023a:
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v237 @ X0_v27+E4]");
		bool flag4 = (nint)0 == 0;
		object obj15 = !flag4;
		if (obj15 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			object obj16 = obj10;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v252 @ X8_v20+B8]");
			obj12 = 0;
		}
		object obj17 = typeof(Func<AndroidJavaObject, IList<HWLocation>>) + 3208;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
		object obj18 = (nint)0 + (nint)1624;
		Func<object, bool> func = default(Func<object, bool>);
		func..ctor(obj12, (IntPtr)obj18);
		object obj19 = obj10;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v229 @ X8_v19+B8]");
		object obj20 = (nint)0 + (nint)40;
		obj20 = func;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
		predicate2 = func;
		goto IL_0291;
		IL_0135:
		result = (string)obj8;
		goto IL_0429;
		IL_0291:
		object obj21 = Enumerable.FirstOrDefault(currentGameServers, predicate2);
		if (obj21 != null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v235 @ X0_v22 (System.Object)+10]");
			return (string)0;
		}
		object obj22 = Enumerable.FirstOrDefault((IEnumerable<object>)currentGameServers);
		if (obj22 != null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v193 @ X0_v24 (System.Object)+10]");
			result = (string)0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v193 @ X0_v24 (System.Object)+10]");
			bool flag5 = (nint)0 == 0;
			object obj23 = !flag5;
			if (obj23 != null)
			{
				goto IL_0429;
			}
		}
		goto IL_0135;
	}

	public static List<SFSConfig> GetCurrentGameServers(bool includeRestricted = false, bool includeFastTrack = false)
	{
		//IL_0009: Expected O, but got I4
		//IL_0018: Unknown result type (might be due to invalid IL or missing references)
		//IL_001d: Expected O, but got Unknown
		//IL_0033: Expected O, but got I
		//IL_037d: Expected O, but got I4
		//IL_0093: Expected O, but got I
		//IL_00ab: Expected O, but got I4
		//IL_00b4: Expected O, but got I4
		//IL_0415: Expected O, but got I4
		//IL_03ab: Expected O, but got I
		//IL_03c5: Expected O, but got I4
		//IL_03ce: Expected O, but got I4
		//IL_03d7: Expected O, but got I4
		//IL_010f: Expected O, but got I
		//IL_049c: Unknown result type (might be due to invalid IL or missing references)
		//IL_04a1: Expected O, but got Unknown
		//IL_0455: Expected O, but got I
		//IL_0477: Expected O, but got I4
		//IL_04df: Expected O, but got I
		//IL_04f9: Expected O, but got I4
		//IL_019b: Unknown result type (might be due to invalid IL or missing references)
		//IL_01a0: Expected O, but got Unknown
		//IL_016f: Expected O, but got I
		//IL_058b: Expected O, but got I
		//IL_059b: Expected O, but got I
		//IL_05c5: Expected O, but got I4
		//IL_05e5: Expected O, but got I
		//IL_051c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0521: Expected O, but got Unknown
		//IL_054b: Expected O, but got I4
		//IL_0256: Expected O, but got I
		//IL_0266: Expected O, but got I
		//IL_0276: Expected O, but got I
		//IL_01ed: Expected O, but got I
		//IL_01fd: Expected O, but got I
		//IL_023c: Expected O, but got I
		//IL_069b: Expected O, but got I4
		//IL_0611: Expected O, but got I
		//IL_0621: Expected O, but got I
		//IL_0631: Expected O, but got I
		//IL_0653: Expected O, but got I4
		//IL_0a3d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0a42: Expected O, but got Unknown
		//IL_0a58: Expected O, but got I
		//IL_0a69: Expected I, but got O
		//IL_0a87: Expected O, but got I
		//IL_0703: Expected O, but got I4
		//IL_070c: Expected O, but got I4
		//IL_072d: Expected O, but got I4
		//IL_06cb: Expected O, but got I
		//IL_07ff: Expected O, but got I
		//IL_080f: Expected O, but got I
		//IL_0831: Expected O, but got I4
		//IL_0ad2: Expected O, but got I4
		//IL_0790: Expected O, but got I
		//IL_07a0: Expected O, but got I
		//IL_07c2: Expected O, but got I4
		//IL_0968: Expected O, but got I
		//IL_0978: Expected O, but got I
		//IL_099a: Expected O, but got I4
		//IL_0869: Expected O, but got I4
		//IL_08f9: Expected O, but got I
		//IL_0909: Expected O, but got I
		//IL_092b: Expected O, but got I4
		//IL_0b18: Unknown result type (might be due to invalid IL or missing references)
		//IL_0b1d: Expected O, but got Unknown
		//IL_0b33: Expected O, but got I
		//IL_0b44: Expected I, but got O
		//IL_0b62: Expected O, but got I
		//IL_09d2: Expected O, but got I4
		//IL_08a7: Expected O, but got I4
		//IL_0899: Expected O, but got I
		//IL_0ba7: Unknown result type (might be due to invalid IL or missing references)
		//IL_0bac: Expected O, but got Unknown
		//IL_0bc2: Expected O, but got I
		//IL_0bd3: Expected I, but got O
		//IL_0bf1: Expected O, but got I
		//IL_0a02: Expected O, but got I
		object obj = 152989696;
		object obj2 = typeof(System.Runtime.Remoting.Messaging.CallContextSecurityData) + 2360;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [91E7101]");
		object obj3 = (nint)0 & (nint)1;
		if (obj3 != null)
		{
			object obj4 = obj2;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v62 @ X0_v13+E4]");
			if ((nint)0 != 0)
			{
				goto IL_007d;
			}
		}
		else
		{
			_ = 1;
			object obj4 = obj2;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v62 @ X0_v13+E4]");
			bool flag = (nint)0 == 0;
			object obj5 = !flag;
			if (obj5 != null)
			{
				goto IL_007d;
			}
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [8BE45C7]");
		object obj6 = (nint)0 & (nint)1;
		bool flag2 = obj6 == null;
		object obj7 = !flag2;
		object obj8 = 146685952;
		object obj9 = 146685952;
		if (obj7 != null)
		{
			goto IL_00c2;
		}
		goto IL_03e5;
		IL_08bc:
		object obj11;
		object obj10 = obj11;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v474 @ X8_v23+E4]");
		object obj12;
		Func<object, bool> predicate;
		IEnumerable<object> source;
		IEnumerable<object> enumerable;
		if ((nint)0 != 0)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v474 @ X8_v23+B8]");
			obj12 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v442 @ X9_v6+40]");
			predicate = (Func<object, bool>)0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v442 @ X9_v6+40]");
			bool flag3 = (nint)0 == 0;
			object obj13 = !flag3;
			source = enumerable;
			if (obj13 == null)
			{
				goto IL_09b0;
			}
		}
		else
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			obj10 = obj11;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v474 @ X8_v23+B8]");
			obj12 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v442 @ X9_v6+40]");
			predicate = (Func<object, bool>)0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v442 @ X9_v6+40]");
			bool flag4 = (nint)0 == 0;
			object obj14 = !flag4;
			source = enumerable;
			if (obj14 == null)
			{
				goto IL_09b0;
			}
		}
		goto IL_0b79;
		IL_0b79:
		IEnumerable<object> enumerable2 = Enumerable.Where(source, predicate);
		IEnumerable<object> source2 = enumerable2;
		goto IL_0a1c;
		IL_0753:
		object obj16;
		object obj15 = obj16;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v463 @ X8_v35+E4]");
		object obj17;
		Func<object, bool> func;
		IEnumerable<object> source3;
		IEnumerable<object> enumerable3;
		if ((nint)0 != 0)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v463 @ X8_v35+B8]");
			obj17 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v419 @ X9_v14+38]");
			func = (Func<object, bool>)0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v419 @ X9_v14+38]");
			bool flag5 = (nint)0 == 0;
			object obj18 = !flag5;
			source3 = enumerable3;
			if (obj18 == null)
			{
				goto IL_0847;
			}
		}
		else
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			obj15 = obj16;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v463 @ X8_v35+B8]");
			obj17 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v419 @ X9_v14+38]");
			func = (Func<object, bool>)0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v419 @ X9_v14+38]");
			bool flag6 = (nint)0 == 0;
			object obj19 = !flag6;
			source3 = enumerable3;
			if (obj19 == null)
			{
				goto IL_0847;
			}
		}
		goto IL_0a9e;
		IL_007d:
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [8BE45C7]");
		object obj20 = (nint)0 & (nint)1;
		bool flag7 = obj20 == null;
		obj8 = 146685952;
		obj9 = 146685952;
		if (!flag7)
		{
			goto IL_00c2;
		}
		goto IL_03e5;
		IL_03e5:
		_ = 1;
		object obj21 = obj2;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v111 @ X0_v46+E4]");
		bool flag8 = (nint)0 == 0;
		object obj22 = !flag8;
		obj8 = obj9;
		object obj23 = obj21;
		if (obj22 != null)
		{
			goto IL_00ff;
		}
		goto IL_0433;
		IL_00c2:
		obj21 = obj2;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v111 @ X0_v46+E4]");
		bool flag9 = (nint)0 == 0;
		obj23 = obj21;
		obj9 = obj8;
		if (!flag9)
		{
			goto IL_00ff;
		}
		goto IL_0433;
		IL_0433:
		Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		obj21 = obj2;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v111 @ X0_v46+B8]");
		object obj24 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v128 @ X8_v8+8]");
		bool flag10 = (nint)0 == 0;
		object obj25 = !flag10;
		obj8 = obj9;
		if (obj25 != null)
		{
			goto IL_0134;
		}
		goto IL_048d;
		IL_00ff:
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v111 @ X0_v46+B8]");
		object obj26 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v98 @ X8_v73+8]");
		if ((nint)0 != 0)
		{
			goto IL_0134;
		}
		goto IL_048d;
		IL_048d:
		object obj27 = typeof(List<AdaptivePerformanceScaler>) + 3136;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
		List<object> list = default(List<object>);
		list..ctor();
		return (List<SFSConfig>)(object)list;
		IL_0134:
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v111 @ X0_v46+E4]");
		if ((nint)0 != 0)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [8BE45C7]");
			object obj28 = (nint)0 & (nint)1;
			if (obj28 != null)
			{
				goto IL_018c;
			}
		}
		else
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v117 @ X22_v7+5C7]");
			object obj29 = (nint)0 & (nint)1;
			bool flag11 = obj29 == null;
			object obj30 = !flag11;
			if (obj30 != null)
			{
				goto IL_018c;
			}
		}
		_ = 1;
		obj11 = typeof(CardUtils.<>c) + 2160;
		object obj31 = obj2;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v178 @ X0_v109+E4]");
		bool flag12 = (nint)0 == 0;
		object obj32 = !flag12;
		obj16 = obj11;
		object obj33 = obj31;
		if (obj32 != null)
		{
			goto IL_01dd;
		}
		goto IL_0569;
		IL_0a1c:
		return (List<SFSConfig>)(object)Enumerable.ToList(source2);
		IL_09b0:
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v474 @ X8_v23+E4]");
		bool flag13 = (nint)0 == 0;
		object obj34 = !flag13;
		if (obj34 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			object obj35 = obj11;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v492 @ X8_v30+B8]");
			obj12 = 0;
		}
		object obj36 = typeof(Func<AndroidJavaObject, IList<HWLocation>>) + 3208;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
		object obj37 = (nint)0 + (nint)1616;
		Func<object, bool> func2 = default(Func<object, bool>);
		func2..ctor(obj12, (IntPtr)obj37);
		object obj38 = obj11;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v453 @ X8_v29+B8]");
		object obj39 = (nint)0 + (nint)64;
		obj39 = func2;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
		source = enumerable;
		predicate = func2;
		goto IL_0b79;
		IL_0847:
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v463 @ X8_v35+E4]");
		bool flag14 = (nint)0 == 0;
		object obj40 = !flag14;
		if (obj40 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			object obj41 = obj16;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v482 @ X8_v42+B8]");
			obj17 = 0;
		}
		object obj42 = typeof(Func<AndroidJavaObject, IList<HWLocation>>) + 3208;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
		object obj43 = (nint)0 + (nint)1608;
		Func<object, bool> func3 = default(Func<object, bool>);
		func3..ctor(obj17, (IntPtr)obj43);
		object obj44 = obj16;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v433 @ X8_v41+B8]");
		object obj45 = (nint)0 + (nint)56;
		obj45 = func3;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
		object obj46 = 0;
		source3 = enumerable3;
		func = func3;
		goto IL_0a9e;
		IL_018c:
		obj11 = typeof(CardUtils.<>c) + 2160;
		obj31 = obj2;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v178 @ X0_v109+E4]");
		bool flag15 = (nint)0 == 0;
		obj16 = obj11;
		obj33 = obj31;
		if (!flag15)
		{
			goto IL_01dd;
		}
		goto IL_0569;
		IL_0569:
		Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		object obj47 = obj2;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v258 @ X0_v96+B8]");
		object obj48 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v259 @ X8_v56+8]");
		IEnumerable<object> enumerable4 = (IEnumerable<object>)0;
		object obj49 = obj16;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v282 @ X0_v81+E4]");
		bool flag16 = (nint)0 == 0;
		object obj50 = !flag16;
		obj11 = obj16;
		object obj51 = obj49;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v259 @ X8_v56+8]");
		IEnumerable<object> enumerable5 = (IEnumerable<object>)0;
		if (obj50 != null)
		{
			goto IL_024a;
		}
		goto IL_05f3;
		IL_01dd:
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v178 @ X0_v109+B8]");
		object obj52 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v184 @ X8_v67+8]");
		enumerable4 = (IEnumerable<object>)0;
		obj49 = obj11;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v282 @ X0_v81+E4]");
		bool flag17 = (nint)0 == 0;
		obj16 = obj11;
		obj51 = obj49;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v184 @ X8_v67+8]");
		enumerable5 = (IEnumerable<object>)0;
		if (!flag17)
		{
			goto IL_024a;
		}
		goto IL_05f3;
		IL_05f3:
		Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		obj49 = obj16;
		object obj53 = (nint)0 + (nint)3744;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v282 @ X0_v81+B8]");
		object obj54 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v299 @ X8_v45+30]");
		Func<object, bool> func4 = (Func<object, bool>)0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v299 @ X8_v45+30]");
		bool flag18 = (nint)0 == 0;
		object obj55 = !flag18;
		obj11 = obj16;
		enumerable4 = enumerable5;
		object obj56 = obj53;
		if (obj55 != null)
		{
			goto IL_02b3;
		}
		goto IL_0679;
		IL_024a:
		obj53 = (nint)0 + (nint)3744;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v282 @ X0_v81+B8]");
		obj54 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v299 @ X8_v45+30]");
		func4 = (Func<object, bool>)0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v299 @ X8_v45+30]");
		bool flag19 = (nint)0 == 0;
		obj56 = obj53;
		obj16 = obj11;
		enumerable5 = enumerable4;
		if (!flag19)
		{
			goto IL_02b3;
		}
		goto IL_0679;
		IL_0679:
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v282 @ X0_v81+E4]");
		bool flag20 = (nint)0 == 0;
		object obj57 = !flag20;
		if (obj57 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			object obj58 = obj16;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v346 @ X8_v51+B8]");
			obj54 = 0;
		}
		object obj59 = typeof(Func<AndroidJavaObject, IList<HWLocation>>) + 3208;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
		object obj60 = (nint)0 + (nint)1600;
		Func<object, bool> func5 = default(Func<object, bool>);
		func5..ctor(obj54, (IntPtr)obj60);
		object obj61 = obj16;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v324 @ X8_v50+B8]");
		object obj62 = (nint)0 + (nint)48;
		obj62 = func5;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
		object obj63 = obj56;
		enumerable = Enumerable.Where(enumerable5, func5);
		bool flag21 = !includeRestricted;
		object obj64 = !flag21;
		object obj65 = 0;
		Func<object, bool> func6 = func5;
		obj53 = obj56;
		obj11 = obj16;
		obj46 = 0;
		Func<object, bool> func7 = func5;
		object obj66 = obj56;
		enumerable3 = enumerable;
		if (obj64 != null)
		{
			goto IL_0321;
		}
		goto IL_0753;
		IL_0321:
		if (!includeFastTrack)
		{
			goto IL_08bc;
		}
		source2 = enumerable;
		goto IL_0a1c;
		IL_0a9e:
		obj63 = obj56;
		enumerable = Enumerable.Where(source3, func);
		bool flag22 = !includeFastTrack;
		object obj67 = !flag22;
		obj65 = obj46;
		func6 = func;
		obj53 = obj56;
		obj11 = obj16;
		source2 = enumerable;
		if (obj67 == null)
		{
			goto IL_08bc;
		}
		goto IL_0a1c;
		IL_02b3:
		obj63 = obj53;
		enumerable = Enumerable.Where(enumerable4, func4);
		bool flag23 = !includeRestricted;
		func6 = func4;
		obj46 = obj65;
		func7 = func4;
		obj66 = obj53;
		obj56 = obj53;
		obj16 = obj11;
		enumerable3 = enumerable;
		if (!flag23)
		{
			goto IL_0321;
		}
		goto IL_0753;
	}

	public static List<SFSConfig> GetAllServers(bool includeRestricted = false, bool includeFastTrack = false)
	{
		//IL_0009: Expected O, but got I4
		//IL_0018: Unknown result type (might be due to invalid IL or missing references)
		//IL_001d: Expected O, but got Unknown
		//IL_0033: Expected O, but got I
		//IL_027f: Expected O, but got I4
		//IL_0093: Expected O, but got I
		//IL_00ab: Expected O, but got I4
		//IL_00b4: Expected O, but got I4
		//IL_0317: Expected O, but got I4
		//IL_02ad: Expected O, but got I
		//IL_02c7: Expected O, but got I4
		//IL_02d0: Expected O, but got I4
		//IL_02d9: Expected O, but got I4
		//IL_010f: Expected O, but got I
		//IL_039e: Unknown result type (might be due to invalid IL or missing references)
		//IL_03a3: Expected O, but got Unknown
		//IL_0357: Expected O, but got I
		//IL_0379: Expected O, but got I4
		//IL_03e1: Expected O, but got I
		//IL_03fb: Expected O, but got I4
		//IL_016f: Expected O, but got I
		//IL_0471: Expected O, but got I
		//IL_0481: Expected O, but got I
		//IL_049b: Expected O, but got I4
		//IL_04ab: Expected O, but got I
		//IL_0439: Expected O, but got I4
		//IL_0226: Expected O, but got I4
		//IL_01d1: Expected O, but got I
		//IL_01e1: Expected O, but got I
		//IL_0200: Expected O, but got I
		//IL_063c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0641: Expected O, but got Unknown
		//IL_04c8: Unknown result type (might be due to invalid IL or missing references)
		//IL_04cd: Expected O, but got Unknown
		//IL_06ed: Expected O, but got I
		//IL_06fd: Expected O, but got I
		//IL_071f: Expected O, but got I4
		//IL_0579: Expected O, but got I
		//IL_0589: Expected O, but got I
		//IL_05ab: Expected O, but got I4
		//IL_067e: Expected O, but got I
		//IL_068e: Expected O, but got I
		//IL_06b0: Expected O, but got I4
		//IL_07ad: Expected O, but got I
		//IL_07d9: Expected O, but got I4
		//IL_050a: Expected O, but got I
		//IL_051a: Expected O, but got I
		//IL_053c: Expected O, but got I4
		//IL_0757: Expected O, but got I4
		//IL_05e3: Expected O, but got I4
		//IL_089b: Unknown result type (might be due to invalid IL or missing references)
		//IL_08a0: Expected O, but got Unknown
		//IL_08b6: Expected O, but got I
		//IL_08c7: Expected I, but got O
		//IL_08e5: Expected O, but got I
		//IL_0807: Unknown result type (might be due to invalid IL or missing references)
		//IL_080c: Expected O, but got Unknown
		//IL_0822: Expected O, but got I
		//IL_0833: Expected I, but got O
		//IL_0851: Expected O, but got I
		//IL_0787: Expected O, but got I
		//IL_0613: Expected O, but got I
		object obj = 152989696;
		object obj2 = typeof(System.Runtime.Remoting.Messaging.CallContextSecurityData) + 2360;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [91E7102]");
		object obj3 = (nint)0 & (nint)1;
		if (obj3 != null)
		{
			object obj4 = obj2;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v58 @ X0_v13+E4]");
			if ((nint)0 != 0)
			{
				goto IL_007d;
			}
		}
		else
		{
			_ = 1;
			object obj4 = obj2;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v58 @ X0_v13+E4]");
			bool flag = (nint)0 == 0;
			object obj5 = !flag;
			if (obj5 != null)
			{
				goto IL_007d;
			}
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [8BE45C7]");
		object obj6 = (nint)0 & (nint)1;
		bool flag2 = obj6 == null;
		object obj7 = !flag2;
		object obj8 = 146685952;
		object obj9 = 146685952;
		if (obj7 != null)
		{
			goto IL_00c2;
		}
		goto IL_02e7;
		IL_05c1:
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v365 @ X8_v38+E4]");
		bool flag3 = (nint)0 == 0;
		object obj10 = !flag3;
		object obj12;
		object obj13;
		if (obj10 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			object obj11 = obj12;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v382 @ X8_v45+B8]");
			obj13 = 0;
		}
		object obj14 = typeof(Func<AndroidJavaObject, IList<HWLocation>>) + 3208;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
		object obj15 = (nint)0 + (nint)1584;
		Func<object, bool> func = default(Func<object, bool>);
		func..ctor(obj13, (IntPtr)obj15);
		object obj16 = obj12;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v329 @ X8_v44+B8]");
		object obj17 = (nint)0 + (nint)72;
		obj17 = func;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
		IEnumerable<object> enumerable2;
		IEnumerable<object> enumerable = enumerable2;
		Func<object, bool> func2 = func;
		goto IL_07a1;
		IL_0868:
		IEnumerable<object> source2;
		Func<object, bool> predicate;
		IEnumerable<object> source = Enumerable.Where(source2, predicate);
		return (List<SFSConfig>)(object)Enumerable.ToList(source);
		IL_020e:
		bool flag4 = !includeFastTrack;
		Func<object, bool> func3 = (Func<object, bool>)includeFastTrack;
		IEnumerable<object> enumerable4;
		IEnumerable<object> enumerable3 = enumerable4;
		if (!flag4)
		{
			goto IL_023d;
		}
		goto IL_062d;
		IL_007d:
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [8BE45C7]");
		object obj18 = (nint)0 & (nint)1;
		bool flag5 = obj18 == null;
		obj8 = 146685952;
		obj9 = 146685952;
		if (!flag5)
		{
			goto IL_00c2;
		}
		goto IL_02e7;
		IL_02e7:
		_ = 1;
		object obj19 = obj2;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v107 @ X0_v43+E4]");
		bool flag6 = (nint)0 == 0;
		object obj20 = !flag6;
		obj8 = obj9;
		object obj21 = obj19;
		if (obj20 != null)
		{
			goto IL_00ff;
		}
		goto IL_0335;
		IL_00c2:
		obj19 = obj2;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v107 @ X0_v43+E4]");
		bool flag7 = (nint)0 == 0;
		obj21 = obj19;
		obj9 = obj8;
		if (!flag7)
		{
			goto IL_00ff;
		}
		goto IL_0335;
		IL_0335:
		Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		obj19 = obj2;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v107 @ X0_v43+B8]");
		object obj22 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v124 @ X8_v8+8]");
		bool flag8 = (nint)0 == 0;
		object obj23 = !flag8;
		obj8 = obj9;
		if (obj23 != null)
		{
			goto IL_0134;
		}
		goto IL_038f;
		IL_00ff:
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v107 @ X0_v43+B8]");
		object obj24 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v94 @ X8_v61+8]");
		if ((nint)0 != 0)
		{
			goto IL_0134;
		}
		goto IL_038f;
		IL_038f:
		object obj25 = typeof(List<AdaptivePerformanceScaler>) + 3136;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
		List<object> list = default(List<object>);
		list..ctor();
		return (List<SFSConfig>)(object)list;
		IL_0134:
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v107 @ X0_v43+E4]");
		if ((nint)0 != 0)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [8BE45C7]");
			object obj26 = (nint)0 & (nint)1;
			if (obj26 != null)
			{
				goto IL_018c;
			}
		}
		else
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v113 @ X22_v7+5C7]");
			object obj27 = (nint)0 & (nint)1;
			bool flag9 = obj27 == null;
			object obj28 = !flag9;
			if (obj28 != null)
			{
				goto IL_018c;
			}
		}
		_ = 1;
		object obj29 = obj2;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v168 @ X0_v90+E4]");
		bool flag10 = (nint)0 == 0;
		object obj30 = !flag10;
		object obj31 = obj29;
		if (obj30 != null)
		{
			goto IL_01c1;
		}
		goto IL_044f;
		IL_07a1:
		object obj32 = (nint)0 + (nint)3744;
		enumerable3 = Enumerable.Where(enumerable, func2);
		bool flag11 = !includeFastTrack;
		object obj33 = !flag11;
		enumerable4 = enumerable3;
		func3 = func2;
		if (obj33 != null)
		{
			goto IL_023d;
		}
		goto IL_062d;
		IL_023d:
		return (List<SFSConfig>)(object)Enumerable.ToList(enumerable4);
		IL_0735:
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v374 @ X8_v24+E4]");
		bool flag12 = (nint)0 == 0;
		object obj34 = !flag12;
		object obj36;
		object obj37;
		if (obj34 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			object obj35 = obj36;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v392 @ X8_v31+B8]");
			obj37 = 0;
		}
		object obj38 = typeof(Func<AndroidJavaObject, IList<HWLocation>>) + 3208;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
		object obj39 = (nint)0 + (nint)1592;
		Func<object, bool> func4 = default(Func<object, bool>);
		func4..ctor(obj37, (IntPtr)obj39);
		object obj40 = obj36;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v351 @ X8_v30+B8]");
		object obj41 = (nint)0 + (nint)80;
		obj41 = func4;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
		source2 = enumerable3;
		predicate = func4;
		goto IL_0868;
		IL_018c:
		obj29 = obj2;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v168 @ X0_v90+E4]");
		bool flag13 = (nint)0 == 0;
		obj31 = obj29;
		if (!flag13)
		{
			goto IL_01c1;
		}
		goto IL_044f;
		IL_044f:
		Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		object obj42 = obj2;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v255 @ X0_v79+B8]");
		object obj43 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v242 @ X8_v48+8]");
		enumerable4 = (IEnumerable<object>)0;
		bool flag14 = !includeRestricted;
		object obj44 = !flag14;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v242 @ X8_v48+8]");
		enumerable = (IEnumerable<object>)0;
		if (obj44 != null)
		{
			goto IL_020e;
		}
		goto IL_04b9;
		IL_01c1:
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v168 @ X0_v90+B8]");
		object obj45 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v174 @ X8_v56+8]");
		enumerable4 = (IEnumerable<object>)0;
		bool flag15 = !includeRestricted;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v174 @ X8_v56+8]");
		enumerable = (IEnumerable<object>)0;
		if (!flag15)
		{
			goto IL_020e;
		}
		goto IL_04b9;
		IL_04b9:
		obj12 = typeof(CardUtils.<>c) + 2160;
		object obj46 = obj12;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v365 @ X8_v38+E4]");
		if ((nint)0 != 0)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v365 @ X8_v38+B8]");
			obj13 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v315 @ X9_v12+48]");
			func2 = (Func<object, bool>)0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v315 @ X9_v12+48]");
			bool flag16 = (nint)0 == 0;
			object obj47 = !flag16;
			if (obj47 == null)
			{
				enumerable2 = enumerable;
				goto IL_05c1;
			}
		}
		else
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			obj46 = obj12;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v365 @ X8_v38+B8]");
			obj13 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v315 @ X9_v12+48]");
			func2 = (Func<object, bool>)0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v315 @ X9_v12+48]");
			bool flag17 = (nint)0 == 0;
			object obj48 = !flag17;
			enumerable2 = enumerable;
			if (obj48 == null)
			{
				goto IL_05c1;
			}
		}
		goto IL_07a1;
		IL_062d:
		obj36 = typeof(CardUtils.<>c) + 2160;
		object obj49 = obj36;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v374 @ X8_v24+E4]");
		if ((nint)0 != 0)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v374 @ X8_v24+B8]");
			obj37 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v339 @ X9_v5+50]");
			predicate = (Func<object, bool>)0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v339 @ X9_v5+50]");
			bool flag18 = (nint)0 == 0;
			object obj50 = !flag18;
			source2 = enumerable3;
			if (obj50 == null)
			{
				goto IL_0735;
			}
		}
		else
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			obj49 = obj36;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v374 @ X8_v24+B8]");
			obj37 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v339 @ X9_v5+50]");
			predicate = (Func<object, bool>)0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v339 @ X9_v5+50]");
			bool flag19 = (nint)0 == 0;
			object obj51 = !flag19;
			source2 = enumerable3;
			if (obj51 == null)
			{
				goto IL_0735;
			}
		}
		goto IL_0868;
	}

	public static bool Validate()
	{
		//IL_000f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0014: Expected O, but got Unknown
		//IL_002a: Expected O, but got I
		//IL_00ed: Expected O, but got I4
		//IL_00a1: Expected O, but got I4
		//IL_03bc: Unknown result type (might be due to invalid IL or missing references)
		//IL_03c1: Expected O, but got Unknown
		//IL_03eb: Expected O, but got I4
		//IL_0412: Unknown result type (might be due to invalid IL or missing references)
		//IL_0417: Expected O, but got Unknown
		//IL_018f: Expected O, but got I4
		//IL_0a59: Expected I4, but got O
		//IL_01e1: Unknown result type (might be due to invalid IL or missing references)
		//IL_01e6: Expected O, but got Unknown
		//IL_021d: Expected O, but got I4
		//IL_026c: Expected O, but got I
		//IL_0297: Expected O, but got I4
		//IL_02cf: Expected O, but got I4
		//IL_030e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0313: Expected O, but got Unknown
		//IL_043e: Expected O, but got I
		//IL_044e: Expected O, but got I
		//IL_0470: Expected O, but got I4
		//IL_0480: Expected O, but got I
		//IL_0a65: Expected O, but got I
		//IL_0a82: Expected O, but got I
		//IL_0350: Expected O, but got I
		//IL_0360: Expected O, but got I
		//IL_0382: Expected O, but got I4
		//IL_0590: Expected O, but got I4
		//IL_04b8: Expected O, but got I4
		//IL_05c5: Unknown result type (might be due to invalid IL or missing references)
		//IL_05ca: Expected O, but got Unknown
		//IL_0535: Expected O, but got I4
		//IL_0ac0: Unknown result type (might be due to invalid IL or missing references)
		//IL_0ac5: Expected O, but got Unknown
		//IL_0adb: Expected O, but got I
		//IL_0aec: Expected I, but got O
		//IL_0b0a: Expected O, but got I
		//IL_03a8: Expected O, but got I
		//IL_05e3: Unknown result type (might be due to invalid IL or missing references)
		//IL_05e8: Expected O, but got Unknown
		//IL_0608: Unknown result type (might be due to invalid IL or missing references)
		//IL_060d: Expected O, but got Unknown
		//IL_0637: Expected O, but got I4
		//IL_055c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0561: Expected O, but got Unknown
		//IL_04f6: Expected O, but got I4
		//IL_04e8: Expected O, but got I
		//IL_0b6e: Expected O, but got I4
		//IL_0b36: Expected O, but got I
		//IL_06b0: Expected O, but got I4
		//IL_0b8c: Expected O, but got I
		//IL_0b9c: Expected O, but got I
		//IL_0bbe: Expected O, but got I4
		//IL_06f7: Expected O, but got I4
		//IL_0955: Expected O, but got I4
		//IL_0bdb: Unknown result type (might be due to invalid IL or missing references)
		//IL_0be0: Expected O, but got Unknown
		//IL_0bf6: Expected O, but got I
		//IL_0c07: Expected I, but got O
		//IL_0c25: Expected O, but got I
		//IL_0c40: Expected O, but got I4
		//IL_097c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0981: Expected O, but got Unknown
		//IL_0796: Expected O, but got I4
		//IL_0727: Expected O, but got I
		//IL_0c57: Unknown result type (might be due to invalid IL or missing references)
		//IL_0c5c: Expected O, but got Unknown
		//IL_0c71: Expected O, but got I
		//IL_0c8a: Expected O, but got I
		//IL_09b4: Expected O, but got I
		//IL_09ce: Expected O, but got I4
		//IL_09d7: Expected O, but got I4
		//IL_09e0: Expected O, but got I4
		//IL_0804: Expected O, but got I
		//IL_081c: Expected O, but got I4
		//IL_0825: Expected O, but got I4
		//IL_0a1e: Expected O, but got I4
		//IL_0893: Unknown result type (might be due to invalid IL or missing references)
		//IL_0898: Expected O, but got Unknown
		//IL_08c1: Unknown result type (might be due to invalid IL or missing references)
		//IL_08c6: Expected O, but got Unknown
		//IL_08f0: Expected O, but got I4
		object obj = typeof(System.Runtime.Remoting.Messaging.CallContextSecurityData) + 2360;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [91E7222]");
		object obj2 = (nint)0 & (nint)1;
		if (obj2 != null)
		{
			object obj3 = obj;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v62 @ X0_v125+E4]");
			if ((nint)0 != 0)
			{
				goto IL_0074;
			}
		}
		else
		{
			_ = 1;
			object obj3 = obj;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v62 @ X0_v125+E4]");
			bool flag = (nint)0 == 0;
			object obj4 = !flag;
			if (obj4 != null)
			{
				goto IL_0074;
			}
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		List<SFSConfig> allServers = GetAllServers(includeRestricted: true, includeFastTrack: true);
		bool flag2 = allServers == null;
		bool flag3 = true;
		if (!flag2)
		{
			goto IL_0143;
		}
		goto IL_0a4b;
		IL_0a59:
		object obj5 = (nint)0 + (nint)2200;
		IEnumerable<object> source2;
		Func<object, int> keySelector;
		IOrderedEnumerable<object> source = Enumerable.OrderBy(source2, keySelector);
		object obj6 = (nint)0 + (nint)464;
		object obj7 = Enumerable.FirstOrDefault(source);
		if (obj7 != null)
		{
			object obj8 = obj;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v385 @ X0_v101+E4]");
			bool flag4 = (nint)0 == 0;
			object obj9 = !flag4;
			if (obj9 == null)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			}
			object key = "SERVICE_DISABLED" + 3488;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v368 @ X0_v29 (System.Object)+10]");
			Prefs.SetString((string)key, (string)0);
			goto IL_091d;
		}
		object obj11;
		object obj10 = obj11;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v389 @ X0_v30+E4]");
		bool flag5 = (nint)0 == 0;
		object obj12 = !flag5;
		if (obj12 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		}
		Games currentGame = Preferences.CurrentGame;
		object obj13 = typeof(System.ComponentModel.ExtendedPropertyDescriptor) + 2232;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC195C");
		object format = "The operation is not allowed on non-connected sockets." + 3072;
		object arg = default(object);
		string text = string.Format((string)format, arg);
		object obj14 = typeof(Newtonsoft.Json.Linq.JsonPath.JPath) + 1144;
		object obj15 = obj14;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v423 @ X8_v23+E4]");
		bool flag6 = (nint)0 == 0;
		object obj16 = !flag6;
		object obj17 = text;
		if (obj16 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			obj17 = text;
		}
		KLogger.LogError(obj17);
		object obj18 = obj;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v434 @ X0_v39+E4]");
		bool flag7 = (nint)0 == 0;
		object obj19 = !flag7;
		if (obj19 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		}
		List<SFSConfig> allServers2 = GetAllServers();
		object obj21;
		object obj20 = obj21;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v448 @ X0_v44+E4]");
		bool flag8 = (nint)0 == 0;
		object obj22 = !flag8;
		if (obj22 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			obj20 = obj21;
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v448 @ X0_v44+B8]");
		object obj23 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v474 @ X8_v54+60]");
		Func<object, int> keySelector2 = (Func<object, int>)0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v474 @ X8_v54+60]");
		bool flag9 = (nint)0 == 0;
		object obj24 = !flag9;
		object obj31;
		if (obj24 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v448 @ X0_v44+E4]");
			bool flag10 = (nint)0 == 0;
			object obj25 = !flag10;
			if (obj25 == null)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
				object obj26 = obj21;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v481 @ X8_v60+B8]");
				obj23 = 0;
			}
			object obj27 = typeof(Func<AndroidJavaObject, IList<HWLocation>>) + 3216;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
			object obj28 = (nint)0 + (nint)1656;
			Func<object, int> func = default(Func<object, int>);
			func..ctor(obj23, (IntPtr)obj28);
			object obj29 = obj21;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v468 @ X8_v59+B8]");
			object obj30 = (nint)0 + (nint)96;
			obj30 = func;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
			obj31 = 0;
			keySelector2 = func;
		}
		IOrderedEnumerable<object> source3 = Enumerable.OrderBy(allServers2, keySelector2);
		object obj32 = Enumerable.FirstOrDefault(source3);
		object obj42;
		object obj44;
		if (obj32 != null)
		{
			object obj33 = obj;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v489 @ X0_v52+E4]");
			bool flag11 = (nint)0 == 0;
			object obj34 = !flag11;
			if (obj34 == null)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			}
			object key2 = "SERVICE_DISABLED" + 3488;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v480 @ X0_v48 (System.Object)+10]");
			Prefs.SetString((string)key2, (string)0);
			List<Games> availableGames = ((SFSConfig)obj32).AvailableGames;
			object obj35 = (nint)0 + (nint)368;
			System.Int32Enum currentGame2 = Enumerable.FirstOrDefault((IEnumerable<System.Int32Enum>)availableGames);
			object obj36 = obj11;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v521 @ X8_v38+E4]");
			object obj39;
			object obj38;
			if ((nint)0 != 0)
			{
				Preferences.CurrentGame = (Games)currentGame2;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [91E721A]");
				object obj37 = (nint)0 & (nint)1;
				bool flag12 = obj37 == null;
				obj38 = 0;
				obj39 = 0;
				if (!flag12)
				{
					goto IL_0833;
				}
			}
			else
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
				Preferences.CurrentGame = (Games)currentGame2;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [91E721A]");
				object obj40 = (nint)0 & (nint)1;
				bool flag13 = obj40 == null;
				object obj41 = !flag13;
				obj38 = 0;
				obj39 = 0;
				if (obj41 != null)
				{
					goto IL_0833;
				}
			}
			_ = 1;
			obj42 = obj;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v557 @ X0_v69+E4]");
			bool flag14 = (nint)0 == 0;
			object obj43 = !flag14;
			obj38 = obj39;
			obj44 = obj42;
			if (obj43 != null)
			{
				goto IL_0868;
			}
			goto IL_0a3c;
		}
		object obj45 = obj14;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v493 @ X0_v49+E4]");
		bool flag15 = (nint)0 == 0;
		object obj46 = !flag15;
		if (obj46 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		}
		object obj47 = "The operation is not allowed on non-connected sockets." + 3056;
		goto IL_0caa;
		IL_0833:
		obj42 = obj;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v557 @ X0_v69+E4]");
		bool flag16 = (nint)0 == 0;
		obj44 = obj42;
		if (!flag16)
		{
			goto IL_0868;
		}
		goto IL_0a3c;
		IL_0496:
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v363 @ X8_v66+E4]");
		bool flag17 = (nint)0 == 0;
		object obj48 = !flag17;
		object obj50;
		if (obj48 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			object obj49 = obj21;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v376 @ X8_v73+B8]");
			obj50 = 0;
		}
		object obj51 = typeof(Func<AndroidJavaObject, IList<HWLocation>>) + 3216;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
		object obj52 = (nint)0 + (nint)1648;
		Func<object, int> func2 = default(Func<object, int>);
		func2..ctor(obj50, (IntPtr)obj52);
		object obj53 = obj21;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v348 @ X8_v72+B8]");
		object obj54 = (nint)0 + (nint)88;
		obj54 = func2;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
		obj31 = 0;
		keySelector = func2;
		List<SFSConfig> currentGameServers;
		source2 = currentGameServers;
		goto IL_0a59;
		IL_0074:
		allServers = GetAllServers(includeRestricted: true, includeFastTrack: true);
		bool flag18 = allServers == null;
		object obj55 = !flag18;
		flag3 = true;
		if (obj55 != null)
		{
			goto IL_0143;
		}
		goto IL_0a4b;
		IL_0143:
		if (allServers._size != 0)
		{
			object obj56 = obj;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v115 @ X0_v12+E4]");
			bool flag19 = (nint)0 == 0;
			object obj57 = !flag19;
			if (obj57 == null)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			}
			SFSConfig currentSFS = CurrentSFS;
			if (currentSFS != null)
			{
				obj11 = typeof(System.Buffers.Text.ParserHelpers) + 1624;
				List<Games> availableGames2 = currentSFS.AvailableGames;
				object obj58 = obj11;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v217 @ X0_v15+E4]");
				bool flag20 = (nint)0 == 0;
				object obj59 = !flag20;
				if (obj59 == null)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
				}
				Games currentGame3 = Preferences.CurrentGame;
				if (availableGames2 != null)
				{
					object obj60 = (nint)0 + (nint)2728;
					bool flag21 = ((List<System.Int32Enum>)(object)availableGames2).Contains((System.Int32Enum)currentGame3);
					bool flag22 = !flag21;
					object obj61 = !flag22;
					if (obj61 != null)
					{
						goto IL_091d;
					}
					object obj62 = obj;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v274 @ X0_v23+E4]");
					bool flag23 = (nint)0 == 0;
					object obj63 = !flag23;
					if (obj63 == null)
					{
						Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
					}
					currentGameServers = GetCurrentGameServers();
					obj21 = typeof(CardUtils.<>c) + 2160;
					object obj64 = obj21;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v363 @ X8_v66+E4]");
					if ((nint)0 != 0)
					{
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v363 @ X8_v66+B8]");
						obj50 = 0;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v334 @ X9_v12+58]");
						keySelector = (Func<object, int>)0;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v334 @ X9_v12+58]");
						bool flag24 = (nint)0 == 0;
						object obj65 = !flag24;
						source2 = currentGameServers;
						if (obj65 == null)
						{
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v334 @ X9_v12+58]");
							Func<object, int> func3 = (Func<object, int>)0;
							goto IL_0496;
						}
					}
					else
					{
						Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
						obj64 = obj21;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v363 @ X8_v66+B8]");
						obj50 = 0;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v334 @ X9_v12+58]");
						Func<object, int> func3 = (Func<object, int>)0;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v334 @ X9_v12+58]");
						bool flag25 = (nint)0 == 0;
						object obj66 = !flag25;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v334 @ X9_v12+58]");
						keySelector = (Func<object, int>)0;
						source2 = currentGameServers;
						if (obj66 == null)
						{
							goto IL_0496;
						}
					}
					goto IL_0a59;
				}
			}
			goto IL_0a4b;
		}
		object obj67 = typeof(Newtonsoft.Json.Linq.JsonPath.JPath) + 1144;
		object obj68 = obj67;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v107 @ X0_v8+E4]");
		bool flag26 = (nint)0 == 0;
		object obj69 = !flag26;
		if (obj69 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		}
		obj47 = "The operation is not allowed on non-connected sockets." + 2840;
		goto IL_0caa;
		IL_0a3c:
		Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		goto IL_0868;
		IL_0a4b:
		NullReferenceException ex = new NullReferenceException();
		return (byte)(int)ex != 0;
		IL_091d:
		return true;
		IL_0868:
		string currentServerId = GetCurrentServerId();
		Games currentGame4 = Preferences.CurrentGame;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC195C");
		object format2 = "___# Content push apply failed [{0}]: {1}" + 1216;
		object arg2 = default(object);
		string text2 = string.Format((string)format2, currentServerId, arg2);
		object obj70 = typeof(DataRelation) + 856;
		object obj71 = obj70;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v296 @ X8_v49+E4]");
		bool flag27 = (nint)0 == 0;
		object obj72 = !flag27;
		object message = text2;
		if (obj72 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			message = text2;
		}
		Debug.Log(message);
		goto IL_091d;
		IL_0caa:
		KLogger.LogError(obj47);
		return false;
	}

	public static bool SwitchToDefaultServer()
	{
		//IL_000f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0014: Expected O, but got Unknown
		//IL_0661: Unknown result type (might be due to invalid IL or missing references)
		//IL_0666: Expected O, but got Unknown
		//IL_0690: Expected O, but got I4
		//IL_00ef: Expected O, but got I
		//IL_00ff: Expected O, but got I
		//IL_010f: Expected O, but got I
		//IL_0131: Expected O, but got I4
		//IL_0074: Expected O, but got I
		//IL_0084: Expected O, but got I
		//IL_0094: Expected O, but got I
		//IL_00b6: Expected O, but got I4
		//IL_02b9: Expected O, but got I
		//IL_02c9: Expected O, but got I
		//IL_02d9: Expected O, but got I
		//IL_02fb: Expected O, but got I4
		//IL_0169: Expected O, but got I4
		//IL_0268: Expected O, but got I4
		//IL_01e8: Expected O, but got I
		//IL_01f8: Expected O, but got I
		//IL_0208: Expected O, but got I
		//IL_06ad: Unknown result type (might be due to invalid IL or missing references)
		//IL_06b2: Expected O, but got Unknown
		//IL_06c8: Expected O, but got I
		//IL_06d9: Expected I, but got O
		//IL_06f7: Expected O, but got I
		//IL_0712: Expected O, but got I4
		//IL_0333: Expected O, but got I4
		//IL_0199: Expected O, but got I
		//IL_04f5: Expected O, but got I
		//IL_050f: Expected O, but got I4
		//IL_0736: Unknown result type (might be due to invalid IL or missing references)
		//IL_073b: Expected O, but got Unknown
		//IL_0751: Expected O, but got I
		//IL_0762: Expected I, but got O
		//IL_0780: Expected O, but got I
		//IL_040b: Expected O, but got I
		//IL_05e8: Unknown result type (might be due to invalid IL or missing references)
		//IL_05ed: Expected O, but got Unknown
		//IL_05f7: Unknown result type (might be due to invalid IL or missing references)
		//IL_05fc: Expected O, but got Unknown
		//IL_0626: Expected O, but got I4
		//IL_0399: Expected O, but got I4
		//IL_03aa: Expected O, but got I4
		//IL_0363: Expected O, but got I
		//IL_054d: Expected O, but got I4
		//IL_058b: Expected O, but got I
		//IL_05a0: Expected O, but got I
		//IL_05ba: Expected O, but got I4
		//IL_05cb: Expected O, but got I4
		//IL_0476: Expected O, but got I
		//IL_048b: Expected O, but got I
		//IL_04cf: Expected O, but got I
		//IL_04b0: Expected O, but got I4
		object obj = typeof(System.Runtime.Remoting.Messaging.CallContextSecurityData) + 2360;
		object obj2 = typeof(CardUtils.<>c) + 2160;
		object obj3 = obj;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v50 @ X0_v2+E4]");
		bool flag = (nint)0 == 0;
		object obj4 = !flag;
		if (obj4 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		}
		List<SFSConfig> currentGameServers = GetCurrentGameServers();
		object obj5 = obj2;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v118 @ X0_v53+E4]");
		object obj7;
		Func<object, int> keySelector;
		object obj9;
		object obj6;
		if ((nint)0 != 0)
		{
			obj6 = (nint)0 + (nint)2200;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v118 @ X0_v53+B8]");
			obj7 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v131 @ X8_v37+68]");
			keySelector = (Func<object, int>)0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v131 @ X8_v37+68]");
			bool flag2 = (nint)0 == 0;
			object obj8 = !flag2;
			if (obj8 == null)
			{
				obj9 = obj6;
				goto IL_0147;
			}
		}
		else
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			obj5 = obj2;
			obj9 = (nint)0 + (nint)2200;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v118 @ X0_v53+B8]");
			obj7 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v131 @ X8_v37+68]");
			keySelector = (Func<object, int>)0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v131 @ X8_v37+68]");
			bool flag3 = (nint)0 == 0;
			object obj10 = !flag3;
			obj6 = obj9;
			if (obj10 == null)
			{
				goto IL_0147;
			}
		}
		goto IL_019e;
		IL_045d:
		string currentServerId = GetCurrentServerId();
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v203 @ X0_v17 (System.Object)+10]");
		string text = (string)0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v203 @ X0_v17 (System.Object)+10]");
		bool flag4 = currentServerId != (string)0;
		bool flag5 = !flag4;
		object obj12 = default(object);
		object obj11 = obj12;
		object obj13 = 0;
		if (!flag5)
		{
			goto IL_04be;
		}
		goto IL_05d9;
		IL_04be:
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v203 @ X0_v17 (System.Object)+10]");
		SFS.SwitchServer((string)0);
		return true;
		IL_0563:
		Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		string currentServerId2 = GetCurrentServerId();
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v203 @ X0_v17 (System.Object)+10]");
		text = (string)0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v203 @ X0_v17 (System.Object)+10]");
		bool flag6 = currentServerId2 != (string)0;
		bool flag7 = !flag6;
		object obj14 = !flag7;
		obj11 = obj12;
		obj13 = 0;
		if (obj14 != null)
		{
			goto IL_04be;
		}
		goto IL_05d9;
		IL_05d9:
		object obj15 = typeof(Newtonsoft.Json.Linq.JsonPath.JPath) + 1144;
		object obj16 = "The operation is not allowed on non-connected sockets." + 3048;
		object obj17 = obj15;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v245 @ X0_v12+E4]");
		bool flag8 = (nint)0 == 0;
		object obj18 = !flag8;
		if (obj18 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		}
		KLogger.LogError(obj16);
		return false;
		IL_0428:
		object obj19 = obj;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v291 @ X0_v32+E4]");
		bool flag9 = (nint)0 == 0;
		object obj20 = obj19;
		if (!flag9)
		{
			goto IL_045d;
		}
		goto IL_0563;
		IL_0147:
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v118 @ X0_v53+E4]");
		bool flag10 = (nint)0 == 0;
		object obj21 = !flag10;
		if (obj21 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			object obj22 = obj2;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v146 @ X8_v43+B8]");
			obj7 = 0;
		}
		object obj23 = typeof(Func<AndroidJavaObject, IList<HWLocation>>) + 3216;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
		object obj24 = (nint)0 + (nint)1632;
		Func<object, int> func = default(Func<object, int>);
		func..ctor(obj7, (IntPtr)obj24);
		object obj25 = obj2;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v106 @ X8_v42+B8]");
		object obj26 = (nint)0 + (nint)104;
		obj26 = func;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
		obj12 = 0;
		keySelector = func;
		obj6 = obj9;
		goto IL_019e;
		IL_03c8:
		object obj27 = obj;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v210 @ X0_v18+E4]");
		if ((nint)0 != 0)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [91E721A]");
			object obj28 = (nint)0 & (nint)1;
			if (obj28 != null)
			{
				goto IL_0428;
			}
		}
		else
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [91E721A]");
			object obj29 = (nint)0 & (nint)1;
			bool flag11 = obj29 == null;
			object obj30 = !flag11;
			if (obj30 != null)
			{
				goto IL_0428;
			}
		}
		_ = 1;
		obj19 = obj;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v291 @ X0_v32+E4]");
		bool flag12 = (nint)0 == 0;
		object obj31 = !flag12;
		obj20 = obj19;
		if (obj31 != null)
		{
			goto IL_045d;
		}
		goto IL_0563;
		IL_0235:
		object obj33;
		object obj32 = obj33;
		IOrderedEnumerable<object> source;
		Func<object, bool> func2;
		object obj34 = Enumerable.FirstOrDefault(source, func2);
		bool flag13 = obj34 == null;
		object obj35 = !flag13;
		Func<object, bool> func3 = func2;
		if (obj35 != null)
		{
			goto IL_03c8;
		}
		obj11 = obj12;
		obj13 = obj33;
		text = (string)(object)func2;
		goto IL_05d9;
		IL_019e:
		source = Enumerable.OrderBy(currentGameServers, keySelector);
		object obj36 = obj2;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v166 @ X0_v37+E4]");
		object obj37;
		object obj38;
		if ((nint)0 != 0)
		{
			obj33 = (nint)0 + (nint)1176;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v166 @ X0_v37+B8]");
			obj37 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v183 @ X8_v24+70]");
			func2 = (Func<object, bool>)0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v183 @ X8_v24+70]");
			bool flag14 = (nint)0 == 0;
			obj38 = obj33;
			if (!flag14)
			{
				goto IL_0235;
			}
		}
		else
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			obj36 = obj2;
			obj33 = (nint)0 + (nint)1176;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v166 @ X0_v37+B8]");
			obj37 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v183 @ X8_v24+70]");
			func2 = (Func<object, bool>)0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v183 @ X8_v24+70]");
			bool flag15 = (nint)0 == 0;
			object obj39 = !flag15;
			obj38 = obj33;
			if (obj39 != null)
			{
				goto IL_0235;
			}
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v166 @ X0_v37+E4]");
		bool flag16 = (nint)0 == 0;
		object obj40 = !flag16;
		if (obj40 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			object obj41 = obj2;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v213 @ X8_v30+B8]");
			obj37 = 0;
		}
		object obj42 = typeof(Func<AndroidJavaObject, IList<HWLocation>>) + 3208;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
		object obj43 = (nint)0 + (nint)1640;
		Func<object, bool> func4 = default(Func<object, bool>);
		func4..ctor(obj37, (IntPtr)obj43);
		object obj44 = obj2;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v208 @ X8_v29+B8]");
		object obj45 = (nint)0 + (nint)112;
		obj45 = func4;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
		obj32 = obj38;
		obj34 = Enumerable.FirstOrDefault(source, func4);
		bool flag17 = obj34 == null;
		obj12 = 0;
		func3 = func4;
		obj11 = 0;
		obj13 = obj38;
		text = (string)(object)func4;
		if (!flag17)
		{
			goto IL_03c8;
		}
		goto IL_05d9;
	}

	public static void SetServerExtraConfigs(ISFSObject data, bool isLogin = false)
	{
		//IL_0009: Expected O, but got I4
		//IL_0018: Unknown result type (might be due to invalid IL or missing references)
		//IL_001d: Expected O, but got Unknown
		//IL_0033: Expected O, but got I
		//IL_0166: Expected O, but got I4
		//IL_00b8: Expected O, but got I
		//IL_00c9: Expected O, but got I
		//IL_01ae: Expected O, but got I4
		//IL_0111: Expected O, but got I4
		//IL_01d8: Expected O, but got I
		//IL_01e9: Expected O, but got I
		object obj = 152989696;
		object obj2 = typeof(System.Runtime.Remoting.Messaging.CallContextSecurityData) + 2360;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [91E7103]");
		object obj3 = (nint)0 & (nint)1;
		if (obj3 != null)
		{
			object obj4 = obj2;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v44 @ X0_v18+E4]");
			bool flag = (nint)0 == 0;
			object obj5 = obj4;
			if (!flag)
			{
				goto IL_0085;
			}
		}
		else
		{
			_ = 1;
			object obj4 = obj2;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v44 @ X0_v18+E4]");
			bool flag2 = (nint)0 == 0;
			object obj6 = !flag2;
			object obj5 = obj4;
			if (obj6 != null)
			{
				goto IL_0085;
			}
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		SFSConfig currentSFS = CurrentSFS;
		bool flag3 = currentSFS == null;
		object obj7 = !flag3;
		if (obj7 == null)
		{
			throw new NullReferenceException();
		}
		goto IL_0093;
		IL_0085:
		currentSFS = CurrentSFS;
		goto IL_0093;
		IL_0093:
		currentSFS.SetServerExtraConfigs(data);
		object obj8 = obj2;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v69 @ X8_v8+B8]");
		object obj9 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v70 @ X8_v9+38]");
		Actions.SafeInvoke((Action)0);
		if (isLogin)
		{
			object obj10 = obj2;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v108 @ X0_v14+E4]");
			bool flag4 = (nint)0 == 0;
			object obj11 = !flag4;
			if (obj11 == null)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
				obj10 = obj2;
			}
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v108 @ X0_v14+B8]");
			object obj12 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v95 @ X8_v11+40]");
			Actions.SafeInvoke((Action)0);
		}
	}

	static Config()
	{
		//IL_000f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0014: Expected O, but got Unknown
		//IL_0040: Expected O, but got I
		//IL_006a: Expected O, but got I
		object obj = typeof(System.Runtime.Remoting.Messaging.CallContextSecurityData) + 2360;
		string persistentDataPath = UnityEngine.Device.Application.persistentDataPath;
		object obj2 = obj;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v42 @ X8_v3+B8]");
		object obj3 = (nint)0 + (nint)88;
		obj3 = persistentDataPath;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
		object obj4 = obj;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v46 @ X8_v4+B8]");
		object obj5 = 0;
		_ = 0;
	}
}

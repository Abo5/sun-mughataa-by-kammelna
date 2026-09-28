using System;
using System.Buffers.Text;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlTypes;
using System.Diagnostics;
using System.Formats.Asn1;
using System.Globalization;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Runtime.Remoting.Messaging;
using System.Threading;
using Cpp2ILInjected;
using DataTracking;
using HuaweiMobileServices.Location.Location;
using Kammelna.Server;
using Kammelna.Server.Models.Clans;
using Newtonsoft.Json.Linq.JsonPath;
using Server.Models;
using Sfs2X.Entities;
using Spine;
using Unity.Properties;
using UnityEngine;
using UnityEngine.Purchasing.Telemetry;
using UnityEngine.UI;
using Util;

public static class TournamentPopupUtil
{
	[Serializable]
	private sealed class <>c
	{
		public static readonly <>c <>9;

		public static Action<OnlyForSubscribersReq> <>9__0_1;

		public static Action <>9__4_0;

		public static Func<QueuePlayer, string> <>9__5_0;

		static <>c()
		{
			//IL_000f: Unknown result type (might be due to invalid IL or missing references)
			//IL_0014: Expected O, but got Unknown
			object obj = typeof(SkeletonBinary.SkeletonInput) + 3776;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
			object obj2 = default(object);
			obj2..ctor();
			object obj3 = obj;
			object obj4 = obj2;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
		}

		internal void <ShowParticipationPopup>b__0_1(OnlyForSubscribersReq req)
		{
			//IL_0014: Unknown result type (might be due to invalid IL or missing references)
			//IL_0019: Expected O, but got Unknown
			//IL_0028: Unknown result type (might be due to invalid IL or missing references)
			//IL_002d: Expected O, but got Unknown
			//IL_0073: Expected O, but got I4
			object obj = typeof(UnityEngine.Purchasing.Telemetry.TelemetryMetricsInstanceWrapper) + 1608;
			object obj2 = typeof(MemberAchievementClanFeedData) + 3448;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC195C");
			Enum enumeration = default(Enum);
			string friendlyName = EnumExtensions.GetFriendlyName(enumeration);
			object obj3 = obj2;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v65 @ X0_v6+E4]");
			bool flag = (nint)0 == 0;
			object obj4 = !flag;
			if (obj4 == null)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			}
			OnlyForSubscribersPopup.Show(TrackingFeature.Tournament, req.featureIcon, req.featureText, null, req.featureBottomObject, friendlyName);
		}

		internal void <ShowTournamentHubError>b__4_0()
		{
			//IL_000f: Unknown result type (might be due to invalid IL or missing references)
			//IL_0014: Expected O, but got Unknown
			//IL_002a: Expected O, but got I
			//IL_00aa: Expected O, but got I4
			object obj = typeof(RegisteredWaitHandle) + 3136;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [91E6E93]");
			object obj2 = (nint)0 & (nint)1;
			if (obj2 != null)
			{
				object obj3 = obj;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v48 @ X0_v1+E4]");
				if ((nint)0 != 0)
				{
					goto IL_0074;
				}
			}
			else
			{
				_ = 1;
				object obj3 = obj;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v48 @ X0_v1+E4]");
				bool flag = (nint)0 == 0;
				object obj4 = !flag;
				if (obj4 != null)
				{
					goto IL_0074;
				}
			}
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			ScreenManager.LoadPreviousScene();
			return;
			IL_0074:
			ScreenManager.LoadPreviousScene();
		}

		internal string <ShowForceStartWarning>b__5_0(QueuePlayer player)
		{
			if (player != null)
			{
				PlayerInfo <info>k__BackingField = player.<info>k__BackingField;
				if (player.<info>k__BackingField != null)
				{
					return <info>k__BackingField.<Name>k__BackingField;
				}
			}
			return (string)(object)new NullReferenceException();
		}
	}

	private sealed class <>c__DisplayClass0_0
	{
		public bool isLocked;

		public Action<string> acceptCallback;

		internal void <ShowParticipationPopup>b__0()
		{
			//IL_003f: Expected O, but got I
			//IL_004f: Expected O, but got I
			//IL_005f: Expected O, but got I
			if (isLocked)
			{
				return;
			}
			Action<string> action = acceptCallback;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v4 @ X8_v2 (System.Action`1<System.String>)+18]");
			object obj = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v4 @ X8_v2 (System.Action`1<System.String>)+40]");
			object obj2 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v4 @ X8_v2 (System.Action`1<System.String>)+28]");
			object obj3 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Indirect jump: v26 @ X3_v1 (should have been resolved before IL gen)");
			/*Error: End of method reached without returning.*/;
		}
	}

	private sealed class <>c__DisplayClass8_0
	{
		public GameObject lifecycle;

		public TournamentsEventsChannel eventsChannel;

		public int otherTournamentRoomId;

		public Action retryAction;

		internal void <ShowConflictPopup>b__0()
		{
			ForfeitAndRetry(lifecycle, eventsChannel, otherTournamentRoomId, retryAction);
		}
	}

	private sealed class <>c__DisplayClass9_0
	{
		public Action retryAction;

		internal void <ForfeitAndRetry>b__0(int seat)
		{
			//IL_000f: Unknown result type (might be due to invalid IL or missing references)
			//IL_0014: Expected O, but got Unknown
			//IL_00e1: Expected I4, but got I8
			//IL_00fb: Expected O, but got I4
			//IL_0094: Expected O, but got I4
			//IL_0023: Unknown result type (might be due to invalid IL or missing references)
			//IL_0028: Expected O, but got Unknown
			//IL_004a: Expected O, but got I4
			object obj = typeof(System.Buffers.Text.ParserHelpers) + 1432;
			object obj2 = obj;
			int num = (int)(seat & 0x80000000L);
			bool flag = num == 0;
			object obj3 = !flag;
			if (obj3 == null)
			{
				object message = "Index = {0} position = {1}" + 1736;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v46 @ X0_v2+E4]");
				bool flag2 = (nint)0 == 0;
				object obj4 = !flag2;
				if (obj4 == null)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
				}
				PopupWindow.ShowError((string)message);
			}
			else
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v46 @ X0_v2+E4]");
				bool flag3 = (nint)0 == 0;
				object obj5 = !flag3;
				if (obj5 == null)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
				}
				PopupWindow.DismissMessage();
				Actions.SafeInvoke(retryAction);
			}
		}
	}

	public unsafe static void ShowParticipationPopup(TournamentData data, Action<string> acceptCallback, List<GameObject> extraContents, bool confirmButton, bool isLocked, Sprite passwordIcon)
	{
		//IL_000f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0014: Expected O, but got Unknown
		//IL_0022: Unknown result type (might be due to invalid IL or missing references)
		//IL_0027: Expected O, but got Unknown
		//IL_009b: Unknown result type (might be due to invalid IL or missing references)
		//IL_00a0: Expected O, but got Unknown
		//IL_00ac: Expected O, but got I
		//IL_04ce: Expected O, but got I4
		//IL_0101: Expected O, but got I4
		//IL_0546: Unknown result type (might be due to invalid IL or missing references)
		//IL_054b: Expected O, but got Unknown
		//IL_055a: Unknown result type (might be due to invalid IL or missing references)
		//IL_055f: Expected O, but got Unknown
		//IL_056e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0573: Expected I4, but got Unknown
		//IL_05f6: Unknown result type (might be due to invalid IL or missing references)
		//IL_05fb: Expected O, but got Unknown
		//IL_0625: Expected O, but got I4
		//IL_0690: Expected O, but got I4
		//IL_06bc: Unknown result type (might be due to invalid IL or missing references)
		//IL_06c1: Expected O, but got Unknown
		//IL_021a: Expected O, but got I4
		//IL_0790: Unknown result type (might be due to invalid IL or missing references)
		//IL_0795: Expected O, but got Unknown
		//IL_0701: Unknown result type (might be due to invalid IL or missing references)
		//IL_0706: Expected O, but got Unknown
		//IL_0730: Expected O, but got I4
		//IL_222f: Unknown result type (might be due to invalid IL or missing references)
		//IL_2234: Expected O, but got Unknown
		//IL_225e: Expected O, but got I4
		//IL_0c87: Expected O, but got I4
		//IL_026b: Expected O, but got I4
		//IL_1193: Expected O, but got I4
		//IL_257c: Unknown result type (might be due to invalid IL or missing references)
		//IL_2581: Expected O, but got Unknown
		//IL_25ce: Expected O, but got I4
		//IL_25d7: Expected O, but got I4
		//IL_25ed: Expected F8, but got I4
		//IL_2beb: Expected O, but got I
		//IL_2c05: Unknown result type (might be due to invalid IL or missing references)
		//IL_2c0a: Expected O, but got Unknown
		//IL_2c2c: Expected O, but got I4
		//IL_0d7a: Expected F8, but got O
		//IL_0d86: Expected O, but got I
		//IL_0dbd: Expected O, but got I4
		//IL_0812: Unknown result type (might be due to invalid IL or missing references)
		//IL_0817: Expected O, but got Unknown
		//IL_0841: Expected F8, but got I4
		//IL_086b: Expected O, but got I4
		//IL_0874: Expected O, but got I4
		//IL_087c: Expected I4, but got O
		//IL_088d: Expected O, but got I4
		//IL_0895: Expected I4, but got O
		//IL_08aa: Expected F8, but got I4
		//IL_091a: Expected O, but got I4
		//IL_0944: Expected O, but got I4
		//IL_2d2a: Expected O, but got I
		//IL_0ca1: Expected O, but got I
		//IL_0ca9: Expected I4, but got O
		//IL_09a0: Unknown result type (might be due to invalid IL or missing references)
		//IL_09a5: Expected O, but got Unknown
		//IL_09cf: Expected O, but got I4
		//IL_0756: Expected O, but got I4
		//IL_0774: Expected F8, but got I4
		//IL_0424: Unknown result type (might be due to invalid IL or missing references)
		//IL_0429: Expected O, but got Unknown
		//IL_043f: Expected O, but got I
		//IL_044d: Expected I, but got O
		//IL_22a5: Expected O, but got I4
		//IL_0e08: Unknown result type (might be due to invalid IL or missing references)
		//IL_0e0d: Expected O, but got Unknown
		//IL_0e37: Expected O, but got I4
		//IL_2644: Expected O, but got I4
		//IL_047f: Expected I4, but got O
		//IL_2c49: Unknown result type (might be due to invalid IL or missing references)
		//IL_2c4e: Expected O, but got Unknown
		//IL_2c64: Expected O, but got I
		//IL_2c75: Expected I, but got O
		//IL_2c93: Expected O, but got I
		//IL_2765: Unknown result type (might be due to invalid IL or missing references)
		//IL_276a: Expected O, but got Unknown
		//IL_27a5: Expected I4, but got O
		//IL_0ce0: Expected O, but got I
		//IL_0ce8: Expected I4, but got O
		//IL_0a3b: Expected O, but got I4
		//IL_0a44: Expected O, but got I4
		//IL_0a4c: Expected I4, but got O
		//IL_22e2: Expected I4, but got O
		//IL_22d5: Expected O, but got I
		//IL_0e5e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0e63: Expected O, but got Unknown
		//IL_0e83: Unknown result type (might be due to invalid IL or missing references)
		//IL_0e88: Expected O, but got Unknown
		//IL_0d21: Unknown result type (might be due to invalid IL or missing references)
		//IL_0d26: Expected O, but got Unknown
		//IL_0d3d: Expected I4, but got O
		//IL_0ebd: Expected O, but got I4
		//IL_0ec5: Expected I4, but got O
		//IL_037d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0382: Expected O, but got Unknown
		//IL_03ac: Expected O, but got I4
		//IL_0ab2: Expected O, but got I4
		//IL_03d6: Expected O, but got I4
		//IL_03e3: Unknown result type (might be due to invalid IL or missing references)
		//IL_03e8: Expected I8, but got Unknown
		//IL_03ff: Expected O, but got I4
		//IL_0ef3: Expected O, but got I4
		//IL_0f9d: Expected I4, but got O
		//IL_2669: Unknown result type (might be due to invalid IL or missing references)
		//IL_266e: Expected O, but got Unknown
		//IL_0b0d: Expected O, but got I4
		//IL_0f09: Expected I, but got O
		//IL_0f19: Expected O, but got I
		//IL_0f50: Expected O, but got I
		//IL_0f58: Expected I4, but got O
		//IL_0fbc: Unknown result type (might be due to invalid IL or missing references)
		//IL_0fc1: Expected O, but got Unknown
		//IL_0fdd: Unknown result type (might be due to invalid IL or missing references)
		//IL_0fe2: Expected O, but got Unknown
		//IL_1025: Expected I4, but got O
		//IL_1209: Unknown result type (might be due to invalid IL or missing references)
		//IL_120e: Expected O, but got Unknown
		//IL_1218: Unknown result type (might be due to invalid IL or missing references)
		//IL_121d: Expected O, but got Unknown
		//IL_1225: Expected I4, but got O
		//IL_122d: Expected I, but got O
		//IL_123d: Expected O, but got I
		//IL_0b65: Expected O, but got I4
		//IL_1043: Expected I, but got O
		//IL_1053: Expected O, but got I
		//IL_2814: Expected O, but got I
		//IL_282d: Unknown result type (might be due to invalid IL or missing references)
		//IL_2832: Expected O, but got Unknown
		//IL_286a: Expected O, but got I4
		//IL_1278: Expected O, but got I
		//IL_26ed: Unknown result type (might be due to invalid IL or missing references)
		//IL_26f2: Expected O, but got Unknown
		//IL_10e9: Expected O, but got I
		//IL_110d: Expected O, but got I4
		//IL_0ba2: Expected O, but got I4
		//IL_2390: Expected O, but got I
		//IL_108e: Expected O, but got I
		//IL_1318: Expected O, but got I4
		//IL_12e0: Unknown result type (might be due to invalid IL or missing references)
		//IL_12e5: Expected O, but got Unknown
		//IL_12ee: Unknown result type (might be due to invalid IL or missing references)
		//IL_12f3: Expected O, but got Unknown
		//IL_241f: Expected O, but got I4
		//IL_1134: Expected O, but got I
		//IL_1144: Expected I4, but got O
		//IL_13d2: Expected I4, but got O
		//IL_1286: Unknown result type (might be due to invalid IL or missing references)
		//IL_128b: Expected O, but got Unknown
		//IL_1294: Unknown result type (might be due to invalid IL or missing references)
		//IL_1299: Expected O, but got Unknown
		//IL_23cb: Expected O, but got I
		//IL_22f0: Unknown result type (might be due to invalid IL or missing references)
		//IL_22f5: Expected O, but got Unknown
		//IL_22fd: Unknown result type (might be due to invalid IL or missing references)
		//IL_2302: Expected O, but got Unknown
		//IL_230b: Unknown result type (might be due to invalid IL or missing references)
		//IL_2310: Expected O, but got Unknown
		//IL_2320: Expected O, but got I
		//IL_2352: Expected O, but got I
		//IL_2362: Expected I4, but got O
		//IL_132e: Expected I, but got O
		//IL_133e: Expected O, but got I
		//IL_137d: Expected O, but got I
		//IL_1385: Expected I4, but got O
		//IL_109c: Unknown result type (might be due to invalid IL or missing references)
		//IL_10a1: Expected O, but got Unknown
		//IL_10aa: Unknown result type (might be due to invalid IL or missing references)
		//IL_10af: Expected O, but got Unknown
		//IL_13f1: Unknown result type (might be due to invalid IL or missing references)
		//IL_13f6: Expected O, but got Unknown
		//IL_2435: Unknown result type (might be due to invalid IL or missing references)
		//IL_243a: Expected O, but got Unknown
		//IL_2450: Unknown result type (might be due to invalid IL or missing references)
		//IL_2455: Expected O, but got Unknown
		//IL_14b6: Expected O, but got I8
		//IL_14eb: Expected I4, but got O
		//IL_23d9: Unknown result type (might be due to invalid IL or missing references)
		//IL_23de: Expected O, but got Unknown
		//IL_23e7: Unknown result type (might be due to invalid IL or missing references)
		//IL_23ec: Expected O, but got Unknown
		//IL_1435: Expected I, but got O
		//IL_1445: Expected O, but got I
		//IL_1484: Expected O, but got I
		//IL_148c: Expected I4, but got O
		//IL_0c54: Unknown result type (might be due to invalid IL or missing references)
		//IL_0c59: Expected O, but got Unknown
		//IL_150a: Unknown result type (might be due to invalid IL or missing references)
		//IL_150f: Expected O, but got Unknown
		//IL_15d7: Expected O, but got I4
		//IL_15e7: Expected O, but got I4
		//IL_1607: Unknown result type (might be due to invalid IL or missing references)
		//IL_160c: Expected O, but got Unknown
		//IL_1632: Expected I4, but got O
		//IL_154e: Expected I, but got O
		//IL_155e: Expected O, but got I
		//IL_159d: Expected O, but got I
		//IL_15a5: Expected I4, but got O
		//IL_1657: Unknown result type (might be due to invalid IL or missing references)
		//IL_165c: Expected O, but got Unknown
		//IL_166b: Unknown result type (might be due to invalid IL or missing references)
		//IL_1670: Expected O, but got Unknown
		//IL_1679: Unknown result type (might be due to invalid IL or missing references)
		//IL_167e: Expected O, but got Unknown
		//IL_16d6: Expected O, but got I4
		//IL_289c: Unknown result type (might be due to invalid IL or missing references)
		//IL_28a1: Expected O, but got Unknown
		//IL_1789: Expected O, but got I8
		//IL_17cb: Expected I4, but got O
		//IL_16fb: Expected I, but got O
		//IL_170b: Expected O, but got I
		//IL_1757: Expected O, but got I
		//IL_175f: Expected I4, but got O
		//IL_17ea: Unknown result type (might be due to invalid IL or missing references)
		//IL_17ef: Expected O, but got Unknown
		//IL_185e: Expected I4, but got O
		//IL_188c: Expected O, but got I
		//IL_28f8: Expected O, but got I
		//IL_291a: Expected O, but got I
		//IL_18c7: Expected O, but got I
		//IL_1cc4: Unknown result type (might be due to invalid IL or missing references)
		//IL_1cc9: Expected O, but got Unknown
		//IL_1d17: Expected O, but got I4
		//IL_1d24: Expected I4, but got O
		//IL_195f: Unknown result type (might be due to invalid IL or missing references)
		//IL_1964: Expected O, but got Unknown
		//IL_1928: Unknown result type (might be due to invalid IL or missing references)
		//IL_192d: Expected O, but got Unknown
		//IL_1943: Unknown result type (might be due to invalid IL or missing references)
		//IL_1948: Expected O, but got Unknown
		//IL_1b24: Unknown result type (might be due to invalid IL or missing references)
		//IL_1b29: Expected O, but got Unknown
		//IL_1b3f: Expected O, but got I
		//IL_1b50: Expected I, but got O
		//IL_19ca: Expected I4, but got O
		//IL_19e2: Expected I4, but got O
		//IL_18d5: Unknown result type (might be due to invalid IL or missing references)
		//IL_18da: Expected O, but got Unknown
		//IL_18e3: Unknown result type (might be due to invalid IL or missing references)
		//IL_18e8: Expected O, but got Unknown
		//IL_1d4f: Expected I, but got O
		//IL_1d5f: Expected O, but got I
		//IL_1d81: Expected O, but got I4
		//IL_1b5f: Unknown result type (might be due to invalid IL or missing references)
		//IL_1b64: Expected O, but got Unknown
		//IL_1bb5: Expected O, but got I4
		//IL_1bc5: Expected I4, but got O
		//IL_1e11: Expected O, but got I
		//IL_1a00: Expected I, but got O
		//IL_1a10: Expected O, but got I
		//IL_2b06: Expected O, but got I
		//IL_1be3: Expected I, but got O
		//IL_1bf3: Expected O, but got I
		//IL_1f41: Unknown result type (might be due to invalid IL or missing references)
		//IL_1f46: Expected O, but got Unknown
		//IL_1f4f: Unknown result type (might be due to invalid IL or missing references)
		//IL_1f54: Expected O, but got Unknown
		//IL_1f64: Expected O, but got I
		//IL_1fbf: Expected O, but got I
		//IL_1fcf: Expected I4, but got O
		//IL_1eb8: Expected O, but got I
		//IL_1edc: Expected O, but got I4
		//IL_29c6: Expected O, but got I
		//IL_1a4b: Expected O, but got I
		//IL_1e1f: Unknown result type (might be due to invalid IL or missing references)
		//IL_1e24: Expected O, but got Unknown
		//IL_1e2d: Unknown result type (might be due to invalid IL or missing references)
		//IL_1e32: Expected O, but got Unknown
		//IL_1e3d: Unknown result type (might be due to invalid IL or missing references)
		//IL_1e42: Expected O, but got Unknown
		//IL_2a55: Unknown result type (might be due to invalid IL or missing references)
		//IL_2a5a: Expected O, but got Unknown
		//IL_2a82: Expected I, but got O
		//IL_2a92: Expected O, but got I
		//IL_1c2e: Expected O, but got I
		//IL_2988: Expected O, but got I
		//IL_1f1c: Expected O, but got I
		//IL_1f2c: Expected I4, but got O
		//IL_2a13: Expected O, but got I
		//IL_1ae0: Unknown result type (might be due to invalid IL or missing references)
		//IL_1ae5: Expected O, but got Unknown
		//IL_1aed: Unknown result type (might be due to invalid IL or missing references)
		//IL_1af2: Expected O, but got Unknown
		//IL_1afb: Unknown result type (might be due to invalid IL or missing references)
		//IL_1b00: Expected O, but got Unknown
		//IL_1dd3: Unknown result type (might be due to invalid IL or missing references)
		//IL_1dd8: Expected O, but got Unknown
		//IL_1de1: Unknown result type (might be due to invalid IL or missing references)
		//IL_1de6: Expected O, but got Unknown
		//IL_1a61: Unknown result type (might be due to invalid IL or missing references)
		//IL_1a66: Expected O, but got Unknown
		//IL_1a6f: Unknown result type (might be due to invalid IL or missing references)
		//IL_1a74: Expected O, but got Unknown
		//IL_1a7f: Unknown result type (might be due to invalid IL or missing references)
		//IL_1a84: Expected O, but got Unknown
		//IL_214e: Expected I, but got O
		//IL_215e: Expected O, but got I
		//IL_2030: Expected I, but got O
		//IL_2040: Expected O, but got I
		//IL_1c44: Unknown result type (might be due to invalid IL or missing references)
		//IL_1c49: Expected O, but got Unknown
		//IL_1c52: Unknown result type (might be due to invalid IL or missing references)
		//IL_1c57: Expected O, but got Unknown
		//IL_1c62: Unknown result type (might be due to invalid IL or missing references)
		//IL_1c67: Expected O, but got Unknown
		//IL_21ed: Expected O, but got I4
		//IL_2199: Expected O, but got I
		//IL_2019: Expected O, but got I
		//IL_207b: Expected O, but got I
		//IL_2b75: Expected O, but got I
		//IL_21fb: Unknown result type (might be due to invalid IL or missing references)
		//IL_2200: Expected O, but got Unknown
		//IL_2208: Unknown result type (might be due to invalid IL or missing references)
		//IL_220d: Expected O, but got Unknown
		//IL_2216: Unknown result type (might be due to invalid IL or missing references)
		//IL_221b: Expected O, but got Unknown
		//IL_20ee: Unknown result type (might be due to invalid IL or missing references)
		//IL_20f3: Expected O, but got Unknown
		//IL_20fb: Unknown result type (might be due to invalid IL or missing references)
		//IL_2100: Expected O, but got Unknown
		//IL_2109: Unknown result type (might be due to invalid IL or missing references)
		//IL_210e: Expected O, but got Unknown
		//IL_21a7: Unknown result type (might be due to invalid IL or missing references)
		//IL_21ac: Expected O, but got Unknown
		//IL_21b5: Unknown result type (might be due to invalid IL or missing references)
		//IL_21ba: Expected O, but got Unknown
		//IL_2089: Unknown result type (might be due to invalid IL or missing references)
		//IL_208e: Expected O, but got Unknown
		//IL_2097: Unknown result type (might be due to invalid IL or missing references)
		//IL_209c: Expected O, but got Unknown
		//IL_20a7: Unknown result type (might be due to invalid IL or missing references)
		//IL_20ac: Expected O, but got Unknown
		object obj = typeof(SkeletonBinary.SkeletonInput) + 3784;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
		object obj2 = default(object);
		obj2..ctor();
		bool flag = obj2 == null;
		bool flag3 = default(bool);
		bool flag2 = flag3;
		List<GameObject> list = extraContents;
		Action<string> action = null;
		int num = 152985600;
		TournamentData tournamentData = data;
		bool flag4 = flag3;
		object obj3;
		object obj4;
		if (!flag)
		{
			obj3 = obj2 + 24;
			Action<string> action2 = default(Action<string>);
			obj3 = action2;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
			bool flag5 = data == null;
			flag2 = flag3;
			list = extraContents;
			action = action2;
			num = 152985600;
			tournamentData = data;
			flag4 = flag3;
			if (!flag5)
			{
				obj4 = typeof(Queue<string>) + 848;
				object obj5 = (nint)0 + (nint)2200;
				bool flag6 = data.<JoiningPrice>k__BackingField < 1;
				num = 152985600;
				if (flag6)
				{
					goto IL_04a4;
				}
				object obj6 = obj4;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v632 @ X0_v276+E4]");
				bool flag7 = (nint)0 == 0;
				object obj7 = !flag7;
				if (obj7 == null)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
				}
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @3CEC320");
				SessionModel sessionModel = default(SessionModel);
				bool flag8 = (object)sessionModel == null;
				flag2 = flag3;
				list = extraContents;
				action = action2;
				num = 152985600;
				tournamentData = data;
				flag4 = flag3;
				if (!flag8)
				{
					User localUser = sessionModel.LocalUser;
					int aces = SFSKammelnaUserExtensions.GetAces(localUser);
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @3CEC320");
					SessionModel sessionModel2 = default(SessionModel);
					bool flag9 = (object)sessionModel2 == null;
					flag2 = flag3;
					list = extraContents;
					action = null;
					num = aces;
					tournamentData = data;
					flag4 = flag3;
					if (!flag9)
					{
						User localUser2 = sessionModel2.LocalUser;
						int tournamentJoiningDiscount = SFSKammelnaUserExtensions.GetTournamentJoiningDiscount(localUser2);
						object obj8 = data.<JoiningPrice>k__BackingField - tournamentJoiningDiscount;
						bool flag10 = aces >= (nint)obj8;
						num = aces;
						if (flag10)
						{
							goto IL_04a4;
						}
						object obj9 = obj4;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1037 @ X0_v286+E4]");
						bool flag11 = (nint)0 == 0;
						object obj10 = !flag11;
						if (obj10 == null)
						{
							Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
						}
						Cpp2ILHelpers.NoteDecompilerIssue("Method not found @3CEC320");
						SessionModel sessionModel3 = default(SessionModel);
						bool flag12 = (object)sessionModel3 == null;
						flag2 = flag3;
						list = extraContents;
						action = null;
						num = aces;
						tournamentData = data;
						flag4 = flag3;
						if (!flag12)
						{
							User localUser3 = sessionModel3.LocalUser;
							int tournamentJoiningDiscount2 = SFSKammelnaUserExtensions.GetTournamentJoiningDiscount(localUser3);
							Cpp2ILHelpers.NoteDecompilerIssue("Method not found @3CEC320");
							SessionModel sessionModel4 = default(SessionModel);
							bool flag13 = (object)sessionModel4 == null;
							flag2 = flag3;
							list = extraContents;
							action = null;
							num = tournamentJoiningDiscount2;
							tournamentData = data;
							flag4 = flag3;
							if (!flag13)
							{
								User localUser4 = sessionModel4.LocalUser;
								int aces2 = SFSKammelnaUserExtensions.GetAces(localUser4);
								object obj11 = typeof(MemberAchievementClanFeedData) + 2608;
								object obj12 = obj11;
								Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1380 @ X0_v296+E4]");
								bool flag14 = (nint)0 == 0;
								object obj13 = !flag14;
								if (obj13 == null)
								{
									Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
								}
								object obj14 = tournamentJoiningDiscount2 + aces2;
								long remaining = data.<JoiningPrice>k__BackingField - obj14;
								NotEnoughAcesPopup.ShowNotEnoughAces(remaining, TrackingFeature.Tournament);
								object obj15 = 0;
								TrackingFeature trackingFeature = TrackingFeature.Tournament;
								flag4 = flag3;
								goto IL_0415;
							}
						}
					}
				}
			}
		}
		goto IL_245a;
		IL_1e9e:
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @B0D070");
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v2029 @ X0_v115+8]");
		List<GameObject> list2 = (List<GameObject>)0;
		Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v2029 @ X0_v115] (should have been resolved before IL gen)");
		bool flag15 = extraContents == null;
		object obj16 = !flag15;
		if (obj16 != null)
		{
			goto IL_1fe5;
		}
		TournamentType <Type>k__BackingField = data.<Type>k__BackingField;
		double num2 = 8.000000000465661;
		bool flag16;
		flag2 = flag16;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v2029 @ X0_v115+8]");
		list = (List<GameObject>)0;
		PopupButton popupButton;
		action = (Action<string>)(object)popupButton;
		num = (int)popupButton;
		TournamentData tournamentData2 = default(TournamentData);
		tournamentData = tournamentData2;
		goto IL_245a;
		IL_08f7:
		double a;
		double num3 = Math.Log(a, 2.0);
		TimeSpan timeSpan = (TimeSpan)data.<BestOf>k__BackingField;
		object obj18;
		object obj17 = obj18;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1344 @ X0_v53+E4]");
		bool flag17 = (nint)0 == 0;
		object obj19 = !flag17;
		if (obj19 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		}
		double num4 = num3 * (double)timeSpan;
		double value = num4 * 8.000000000465661;
		TimeSpan timeSpan2 = TimeSpan.FromMinutes(value);
		object obj20 = typeof(DataRelation) + 824;
		object obj21 = obj20;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1372 @ X8_v22+E4]");
		bool flag18 = (nint)0 == 0;
		object obj22 = !flag18;
		if (obj22 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			timeSpan = timeSpan2;
		}
		string durationText = DateTimeUtil.GetDurationText(timeSpan2);
		object obj23 = obj4;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1397 @ X0_v59+E4]");
		bool flag19 = (nint)0 == 0;
		object obj24 = !flag19;
		if (obj24 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @3CEC320");
		SessionModel sessionModel5 = default(SessionModel);
		bool flag20 = (object)sessionModel5 == null;
		num2 = 8.000000000465661;
		flag2 = false;
		list = (List<GameObject>)4;
		action = (Action<string>)2;
		num = (int)timeSpan;
		tournamentData = data;
		if (flag20)
		{
			goto IL_245a;
		}
		num = (int)((nint)0 + (nint)2000);
		User localUser5 = sessionModel5.LocalUser;
		TicketRecord tournamentTickets = SFSKammelnaUserExtensions.GetTournamentTickets(localUser5, data.<Type>k__BackingField);
		bool flag21 = tournamentTickets == null;
		action = (Action<string>)data.<Type>k__BackingField;
		string text = (string)(object)tournamentTickets;
		if (!flag21)
		{
			int num5 = default(int);
			text = num5.ToString();
			action = null;
		}
		string text2 = ((text != null) ? text : ((string)((int*)num)->m_value));
		TournamentType <Type>k__BackingField2 = data.<Type>k__BackingField;
		object text3 = "startPosition" + 4088;
		bool flag22 = data.<Type>k__BackingField == TournamentType.OfficialMonthly;
		list = null;
		object obj28;
		if (!flag22)
		{
			bool flag23 = data.<Type>k__BackingField == TournamentType.Private;
			list = null;
			if (!flag23)
			{
				bool flag24 = data.<Type>k__BackingField == TournamentType.Public;
				object obj25 = !flag24;
				list = null;
				if (obj25 == null)
				{
					object obj26 = obj4;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1621 @ X0_v163+E4]");
					bool flag25 = (nint)0 == 0;
					object obj27 = !flag25;
					if (obj27 == null)
					{
						Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
					}
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @3CEC320");
					SessionModel sessionModel6 = default(SessionModel);
					bool flag26 = (object)sessionModel6 == null;
					num2 = 8.000000000465661;
					flag2 = false;
					list = null;
					tournamentData = data;
					if (flag26)
					{
						goto IL_245a;
					}
					User localUser6 = sessionModel6.LocalUser;
					if (SFSKammelnaUserExtensions.IsSubscribed(localUser6))
					{
						text3 = "startPosition" + 4088;
						list = null;
						goto IL_2695;
					}
					<Type>k__BackingField2 = data.<Type>k__BackingField;
					list = null;
				}
				obj28 = "tournament_participate_warning_body_with_tickets_warning_daily" + 8;
				text3 = ((<Type>k__BackingField2 != TournamentType.Public) ? "tournament_participate_warning_body_with_tickets_warning_daily" : obj28);
			}
		}
		goto IL_2695;
		IL_2bcc:
		Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v1089 @ X0_v25] (should have been resolved before IL gen)");
		return;
		IL_1fe5:
		List<object>.Enumerator enumerator = ((List<object>)(object)extraContents).GetEnumerator();
		List<object>.Enumerator enumerator2 = default(List<object>.Enumerator);
		object obj30;
		bool flag27;
		for (; enumerator2.MoveNext(); Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v2230 @ X0_v108+8]"), list2 = (List<GameObject>)0, Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v2230 @ X0_v108] (should have been resolved before IL gen)"))
		{
			nint num6 = (nint)tournamentData2;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v2176 @ X8_v55 (Il2CppClass<TournamentData>)+12E]");
			object obj29 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v2176 @ X8_v55 (Il2CppClass<TournamentData>)+12E]");
			if ((nint)0 != 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v2176 @ X8_v55 (Il2CppClass<TournamentData>)+B0]");
				obj28 = (nint)0 + (nint)8;
				while (true)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v2151 @ X10_v22-8]");
					obj30 = -(((bool*)(flag4 ? 1 : 0))->m_value ? 1 : 0);
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v2151 @ X10_v22-8]");
					if ((nint)0 == (((bool*)(flag4 ? 1 : 0))->m_value ? 1 : 0))
					{
						break;
					}
					obj28 += 16;
					obj29--;
					obj30 = obj29 - 1;
					flag27 = obj30 == null;
					if ((nint)obj29 != 1)
					{
						continue;
					}
					goto IL_1ffa;
				}
				object obj31 = obj28 + 1;
				object obj32 = num6 + obj31;
				object obj33 = obj32 + 312;
				continue;
			}
			goto IL_1ffa;
			IL_1ffa:
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @B0D070");
		}
		enumerator2.Dispose();
		num2 = 8.000000000465661;
		flag2 = flag16;
		list = list2;
		tournamentData = tournamentData2;
		nint num7 = (nint)tournamentData;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v826 @ X8_v8 (Il2CppClass<TournamentData>)+12E]");
		object obj34 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v826 @ X8_v8 (Il2CppClass<TournamentData>)+12E]");
		if ((nint)0 == 0)
		{
			goto IL_21da;
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v826 @ X8_v8 (Il2CppClass<TournamentData>)+B0]");
		object obj35 = (nint)0 + (nint)8;
		while (true)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1014 @ X10_v10-8]");
			if ((nint)0 == (((bool*)(flag4 ? 1 : 0))->m_value ? 1 : 0))
			{
				break;
			}
			obj35 += 16;
			obj34--;
			if ((nint)obj34 != 1)
			{
				continue;
			}
			goto IL_21da;
		}
		object obj36 = obj35 + 9;
		object obj37 = num7 + obj36;
		object obj38 = obj37 + 312;
		goto IL_2bcc;
		IL_21da:
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @B0D070");
		list = (List<GameObject>)9;
		goto IL_2bcc;
		IL_2468:
		IndexOutOfRangeException ex = new IndexOutOfRangeException();
		goto IL_2476;
		IL_12c1:
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @B0D070");
		object obj40 = default(object);
		object obj39 = obj40;
		goto IL_2804;
		IL_04a4:
		object obj41 = obj4;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v640 @ X0_v34+E4]");
		bool flag28 = (nint)0 == 0;
		object obj42 = !flag28;
		if (obj42 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @3CEC320");
		SessionModel sessionModel7 = default(SessionModel);
		bool flag29 = (object)sessionModel7 == null;
		flag2 = flag3;
		list = extraContents;
		action = null;
		tournamentData = data;
		flag4 = flag3;
		object obj43;
		object obj44;
		TicketRecord tournamentTickets2;
		if (!flag29)
		{
			obj43 = typeof(DataRelation) + 712;
			obj44 = typeof(System.IOAsyncCallback) + 384;
			flag4 = (byte)(typeof(System.IOAsyncCallback) + 368) != 0;
			User localUser7 = sessionModel7.LocalUser;
			TournamentType <Type>k__BackingField3 = data.<Type>k__BackingField;
			tournamentTickets2 = SFSKammelnaUserExtensions.GetTournamentTickets(localUser7, data.<Type>k__BackingField);
			if (tournamentTickets2 == null || tournamentTickets2.<RemainingCount>k__BackingField != 0)
			{
				goto IL_05e7;
			}
			bool flag30 = !data.<IsCluster>k__BackingField;
			TournamentType <Type>k__BackingField4 = data.<Type>k__BackingField;
			if (!flag30)
			{
				bool flag31 = data.<Type>k__BackingField == TournamentType.Public;
				object obj45 = !flag31;
				if (obj45 != null)
				{
					goto IL_0d6d;
				}
				object obj46 = (nint)0 + (nint)504;
				<Type>k__BackingField4 = (TournamentType)obj46;
				if (TournamentAddonListExtensions.HasAddonOfType<T>(data.Addons))
				{
					object obj47 = (nint)0 + (nint)496;
					<Type>k__BackingField4 = (TournamentType)obj47;
					if (TournamentAddonListExtensions.HasAddonOfType<T>(data.Addons))
					{
						object obj48 = (??)data.<SpawnerId>k__BackingField & 1;
						bool flag32 = obj48 == null;
						<Type>k__BackingField3 = (TournamentType)obj47;
						if (flag32)
						{
							goto IL_05e7;
						}
					}
				}
			}
			if (data.<Type>k__BackingField != TournamentType.Public)
			{
				goto IL_0d6d;
			}
			object obj49 = typeof(SkeletonBinary.SkeletonInput) + 3776;
			object obj50 = obj49;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1108 @ X0_v244+E4]");
			bool flag33 = (nint)0 == 0;
			object obj51 = !flag33;
			if (obj51 == null)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
				obj50 = obj49;
			}
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1108 @ X0_v244+B8]");
			object obj52 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1165 @ X9_v96+8]");
			TrackingFeature trackingFeature = TrackingFeature.FirstUseExperience;
			object obj53 = "Picking audio files is not supported on iOS" + 2784;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1165 @ X9_v96+8]");
			bool flag34 = (nint)0 == 0;
			object obj54 = !flag34;
			if (obj54 == null)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1108 @ X0_v244+E4]");
				bool flag35 = (nint)0 == 0;
				object obj55 = !flag35;
				if (obj55 == null)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
					object obj56 = obj49;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1211 @ X8_v162+B8]");
					obj52 = 0;
				}
				object obj57 = typeof(System.Diagnostics.DiagnosticSourceEventSource.TransformSpec.PropertySpec.PropertyFetch.EnumeratePropertyFetch<>) + 2896;
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
				object obj58 = (nint)0 + (nint)192;
				Action<object> action3 = default(Action<object>);
				action3..ctor(obj52, (IntPtr)obj58);
				object obj59 = obj49;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1284 @ X8_v160+B8]");
				object obj60 = (nint)0 + (nint)8;
				obj60 = action3;
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
				trackingFeature = (TrackingFeature)action3;
			}
			object obj61 = (nint)0 + (nint)3384;
			object obj15 = obj61;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2F3ABAC");
			goto IL_0415;
		}
		goto IL_245a;
		IL_28e8:
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1856 @ X0_v96+8]");
		object obj62 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v1856 @ X0_v96] (should have been resolved before IL gen)");
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v75 @ X0_v3 (System.Object)+10]");
		obj30 = -1;
		flag27 = obj30 == null;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v75 @ X0_v3 (System.Object)+10]");
		bool flag36 = (nint)0 != 1;
		Sprite sprite = null;
		LocalizableText localizableText2;
		LocalizableText localizableText = localizableText2;
		LocalizableText localizableText3 = localizableText2;
		IPopupWindowBuilderInput popupWindowBuilderInput;
		bool flag38;
		if (!flag36)
		{
			object text4 = "October" + 3392;
			LocalizableText localizableText4 = TextMeshProExtensions.Localize((string)text4);
			popupWindowBuilderInput = PopupInput.From(InputField.ContentType.Pin, (Action<string>)obj3, localizableText4, passwordIcon);
			bool flag37 = tournamentData2 == null;
			flag38 = false;
			<Type>k__BackingField = data.<Type>k__BackingField;
			num2 = 8.000000000465661;
			flag2 = (byte)(int)passwordIcon != 0;
			list = (List<GameObject>)(object)localizableText4;
			action = (Action<string>)obj3;
			num = (int)obj3;
			tournamentData = tournamentData2;
			if (flag37)
			{
				goto IL_245a;
			}
			nint num8 = (nint)tournamentData2;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1908 @ X8_v82 (Il2CppClass<TournamentData>)+12E]");
			object obj63 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1908 @ X8_v82 (Il2CppClass<TournamentData>)+12E]");
			if ((nint)0 == 0)
			{
				goto IL_1ac8;
			}
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1908 @ X8_v82 (Il2CppClass<TournamentData>)+B0]");
			object obj64 = (nint)0 + (nint)8;
			bool flag39 = flag36;
			while (true)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1986 @ X10_v40-8]");
				obj30 = -(((bool*)(flag4 ? 1 : 0))->m_value ? 1 : 0);
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1986 @ X10_v40-8]");
				if ((nint)0 == (((bool*)(flag4 ? 1 : 0))->m_value ? 1 : 0))
				{
					break;
				}
				obj28 = obj64 + 16;
				obj63--;
				obj30 = obj63 - 1;
				flag27 = obj30 == null;
				flag36 = (nint)obj63 != 1;
				obj64 = obj28;
				flag39 = flag36;
				if (flag36)
				{
					continue;
				}
				goto IL_1ac8;
			}
			object obj65 = obj64 + 8;
			object obj66 = num8 + obj65;
			object obj67 = obj66 + 312;
			obj28 = obj64;
			flag36 = flag39;
			goto IL_29b6;
		}
		goto IL_2d05;
		IL_1cab:
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @B0D070");
		goto IL_2a41;
		IL_10cf:
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @B0D070");
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1476 @ X0_v230+8]");
		List<GameObject> list3 = (List<GameObject>)0;
		Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v1476 @ X0_v230] (should have been resolved before IL gen)");
		object obj68 = default(object);
		bool flag40 = obj68 == null;
		object obj69 = !flag40;
		if (obj69 != null)
		{
			goto IL_2378;
		}
		flag2 = false;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1476 @ X0_v230+8]");
		list = (List<GameObject>)0;
		LocalizableText localizableText5;
		action = (Action<string>)(object)localizableText5;
		num = (int)localizableText5;
		tournamentData = data;
		goto IL_245a;
		IL_240c:
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @B0D070");
		list3 = (List<GameObject>)9;
		object obj71 = default(object);
		object obj70 = obj71;
		goto IL_2cd3;
		IL_2cd3:
		Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v1141 @ X8_v139] (should have been resolved before IL gen)");
		return;
		IL_05e7:
		obj18 = typeof(UnityEngine.Purchasing.Telemetry.TelemetryMetricsInstanceWrapper) + 1032;
		object obj72 = obj43;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v740 @ X0_v41+E4]");
		bool flag41 = (nint)0 == 0;
		object obj73 = !flag41;
		if (obj73 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		}
		DateTime now = DateTime.Now;
		TimeSpan timeSpan3 = data.<StartingTime>k__BackingField - now;
		object obj74 = obj18;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1009 @ X0_v47+E4]");
		bool flag42 = (nint)0 == 0;
		object obj75 = !flag42;
		if (obj75 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		}
		object obj76 = typeof(Newtonsoft.Json.Linq.JsonPath.JPath) + 4000;
		TimeSpan timeSpan4 = default(TimeSpan);
		double totalDays = timeSpan4.TotalDays;
		string text6;
		object obj84;
		bool flag46;
		string text7;
		double num9;
		string text8;
		object obj81;
		object obj83;
		bool flag45;
		string text5;
		if (totalDays < 4.000000000698492)
		{
			object obj77 = typeof(DataRelation) + 824;
			object obj78 = obj77;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1188 @ X8_v111+E4]");
			bool flag43 = (nint)0 == 0;
			object obj79 = !flag43;
			if (obj79 == null)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			}
			object obj80 = "{0} color encoding is currently unsupported for outputting to HDR." + 2176;
			text5 = (string)obj80;
			string dayOfWeekTimeFormat = DateTimeUtil.GetDayOfWeekTimeFormat(data.<StartingTime>k__BackingField, (string)obj80);
			obj81 = obj76;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1342 @ X0_v177+E4]");
			bool flag44 = (nint)0 == 0;
			object obj82 = !flag44;
			obj83 = 0;
			flag45 = false;
			a = data.<Size>k__BackingField;
			text6 = dayOfWeekTimeFormat;
			if (obj82 == null)
			{
				obj84 = 0;
				flag46 = false;
				text7 = (string)obj80;
				num9 = data.<Size>k__BackingField;
				text8 = dayOfWeekTimeFormat;
				goto IL_08c0;
			}
			goto IL_08f7;
		}
		object obj85 = typeof(System.Runtime.Remoting.Messaging.CallContextSecurityData) + 3632;
		object obj86 = obj85;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1195 @ X0_v179+E4]");
		CultureInfo cultureInfo;
		CultureInfo cultureInfo2;
		if ((nint)0 != 0)
		{
			CultureInfo invariantCulture = CultureInfo.InvariantCulture;
			object obj87 = obj43;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1335 @ X0_v180+E4]");
			bool flag47 = (nint)0 == 0;
			cultureInfo = invariantCulture;
			cultureInfo2 = invariantCulture;
			if (!flag47)
			{
				goto IL_0808;
			}
		}
		else
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			CultureInfo invariantCulture2 = CultureInfo.InvariantCulture;
			object obj87 = obj43;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1335 @ X0_v180+E4]");
			bool flag48 = (nint)0 == 0;
			object obj88 = !flag48;
			cultureInfo = invariantCulture2;
			cultureInfo2 = invariantCulture2;
			if (obj88 != null)
			{
				goto IL_0808;
			}
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		cultureInfo = cultureInfo2;
		goto IL_0808;
		IL_2378:
		object obj89 = obj68;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1532 @ X8_v138+12E]");
		object obj90 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1532 @ X8_v138+12E]");
		if ((nint)0 == 0)
		{
			goto IL_240c;
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1532 @ X8_v138+B0]");
		object obj91 = (nint)0 + (nint)8;
		while (true)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1599 @ X10_v59-8]");
			if ((nint)0 == (((bool*)(flag4 ? 1 : 0))->m_value ? 1 : 0))
			{
				break;
			}
			obj91 += 16;
			obj90--;
			if ((nint)obj90 != 1)
			{
				continue;
			}
			goto IL_240c;
		}
		object obj92 = obj91 + 9;
		object obj93 = obj89 + obj92;
		obj70 = obj93 + 312;
		goto IL_2cd3;
		IL_2a41:
		Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v2139 @ X0_v128] (should have been resolved before IL gen)");
		object label = "COORDINATE_TYPE_GCJ_02" + 1864;
		PopupButton popupButton2 = PopupButton.Neutral((string)label, null, dismiss: true);
		bool value2 = ((bool*)(flag4 ? 1 : 0))->m_value;
		nint num10 = (nint)tournamentData2;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1980 @ X8_v61 (Il2CppClass<TournamentData>)+12E]");
		object obj94 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1980 @ X8_v61 (Il2CppClass<TournamentData>)+12E]");
		bool flag49 = (nint)0 == 0;
		flag2 = false;
		PopupButton popupButton3 = popupButton2;
		flag16 = false;
		bool flag50 = flag36;
		bool value3 = ((bool*)(flag4 ? 1 : 0))->m_value;
		popupButton = popupButton2;
		if (!flag49)
		{
			goto IL_1dfb;
		}
		goto IL_1e9e;
		IL_1dfb:
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1980 @ X8_v61 (Il2CppClass<TournamentData>)+B0]");
		object obj95 = (nint)0 + (nint)8;
		while (true)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v117 @ X10_v28-8]");
			obj30 = -(value2 ? 1 : 0);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v117 @ X10_v28-8]");
			if ((nint)0 == (value2 ? 1 : 0))
			{
				break;
			}
			obj28 = obj95 + 16;
			obj94--;
			obj30 = obj94 - 1;
			flag27 = obj30 == null;
			flag50 = (nint)obj94 != 1;
			flag16 = flag2;
			value3 = value2;
			popupButton = popupButton3;
			obj95 = obj28;
			flag36 = flag50;
			if (flag50)
			{
				continue;
			}
			goto IL_1e9e;
		}
		object obj96 = num10 + obj95;
		object obj97 = obj96 + 312;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v2083 @ X0_v119+8]");
		list2 = (List<GameObject>)0;
		Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v2083 @ X0_v119] (should have been resolved before IL gen)");
		bool flag51 = extraContents == null;
		obj28 = obj95;
		flag16 = flag2;
		flag50 = flag36;
		<Type>k__BackingField = data.<Type>k__BackingField;
		num2 = 8.000000000465661;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v2083 @ X0_v119+8]");
		list = (List<GameObject>)0;
		action = (Action<string>)(object)popupButton3;
		num = (int)popupButton3;
		tournamentData = tournamentData2;
		if (!flag51)
		{
			goto IL_1fe5;
		}
		goto IL_245a;
		IL_1910:
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @B0D070");
		goto IL_28e8;
		IL_2804:
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1717 @ X8_v31+8]");
		list = (List<GameObject>)0;
		Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v1717 @ X8_v31] (should have been resolved before IL gen)");
		object obj98 = typeof(TypeConverter<ushort, char>) + 3400;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC18B4");
		object[] array = default(object[]);
		bool flag52 = array == null;
		num2 = 8.000000000465661;
		flag2 = false;
		action = (Action<string>)4;
		tournamentData = data;
		if (flag52)
		{
			goto IL_245a;
		}
		bool flag53 = durationText == null;
		Action<string> action4 = (Action<string>)4;
		if (!flag53)
		{
			nint num11 = (nint)array;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v617 @ X8_v90 (Il2CppClass<System.Object[]>)+40]");
			action4 = (Action<string>)0;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1958");
			bool flag54 = ex == null;
			num2 = 8.000000000465661;
			flag2 = false;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v617 @ X8_v90 (Il2CppClass<System.Object[]>)+40]");
			action = (Action<string>)0;
			num = (int)array;
			tournamentData = data;
			if (flag54)
			{
				goto IL_2476;
			}
		}
		bool flag55 = array.Length == 0;
		num2 = 8.000000000465661;
		flag2 = false;
		action = action4;
		num = (int)array;
		tournamentData = data;
		if (!flag55)
		{
			object obj99 = array + 32;
			obj99 = durationText;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
			bool flag56 = text6 == null;
			Action<string> action5 = (Action<string>)(object)durationText;
			if (!flag56)
			{
				nint num12 = (nint)array;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v618 @ X8_v89 (Il2CppClass<System.Object[]>)+40]");
				action5 = (Action<string>)0;
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1958");
				bool flag57 = ex == null;
				num2 = 8.000000000465661;
				flag2 = false;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v618 @ X8_v89 (Il2CppClass<System.Object[]>)+40]");
				action = (Action<string>)0;
				num = (int)array;
				tournamentData = data;
				if (flag57)
				{
					goto IL_2476;
				}
			}
			object obj100 = array.Length & 0xFFFFFFFEL;
			bool flag58 = obj100 == null;
			num2 = 8.000000000465661;
			flag2 = false;
			action = action5;
			num = (int)array;
			tournamentData = data;
			if (!flag58)
			{
				object obj101 = array + 40;
				obj101 = text6;
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
				bool flag59 = text2 == null;
				Action<string> action6 = (Action<string>)(object)text6;
				if (!flag59)
				{
					nint num13 = (nint)array;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v619 @ X8_v88 (Il2CppClass<System.Object[]>)+40]");
					action6 = (Action<string>)0;
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1958");
					bool flag60 = ex == null;
					num2 = 8.000000000465661;
					flag2 = false;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v619 @ X8_v88 (Il2CppClass<System.Object[]>)+40]");
					action = (Action<string>)0;
					num = (int)array;
					tournamentData = data;
					if (flag60)
					{
						goto IL_2476;
					}
				}
				bool flag61 = array.Length < 2;
				object obj102 = !flag61;
				object obj103 = array.Length - 2;
				bool flag62 = obj103 == null;
				object obj104 = ~obj102;
				object obj105 = obj104 | flag62;
				num2 = 8.000000000465661;
				flag2 = false;
				action = action6;
				num = (int)array;
				tournamentData = data;
				if (obj105 == null)
				{
					object obj106 = typeof(UnityEngine.Purchasing.Telemetry.TelemetryMetricsInstanceWrapper) + 1608;
					object obj107 = typeof(Newtonsoft.Json.Linq.JsonPath.JPath) + 2656;
					object obj108 = array + 48;
					obj108 = text2;
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC195C");
					Enum enumeration = default(Enum);
					string friendlyName = EnumExtensions.GetFriendlyName(enumeration);
					object obj109 = obj107;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1765 @ X8_v41+E4]");
					bool flag63 = (nint)0 == 0;
					object obj110 = !flag63;
					if (obj110 == null)
					{
						Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
					}
					string text9 = LocalizationUtil.Localize(friendlyName);
					object obj111 = typeof(System.IOAsyncCallback) + 384;
					bool flag64 = text9 == null;
					Action<string> action7 = null;
					if (!flag64)
					{
						nint num14 = (nint)array;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v620 @ X8_v87 (Il2CppClass<System.Object[]>)+40]");
						action7 = (Action<string>)0;
						Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1958");
						bool flag65 = ex == null;
						<Type>k__BackingField = data.<Type>k__BackingField;
						num2 = 8.000000000465661;
						flag2 = false;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v620 @ X8_v87 (Il2CppClass<System.Object[]>)+40]");
						action = (Action<string>)0;
						num = (int)array;
						tournamentData = (TournamentData)(object)text9;
						if (flag65)
						{
							goto IL_2476;
						}
					}
					object obj112 = array.Length & 0xFFFFFFFCL;
					bool flag66 = obj112 == null;
					<Type>k__BackingField = data.<Type>k__BackingField;
					num2 = 8.000000000465661;
					flag2 = false;
					action = action7;
					num = (int)array;
					tournamentData = (TournamentData)(object)text9;
					if (!flag66)
					{
						object obj113 = array + 56;
						obj113 = text9;
						Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
						localizableText2 = TextMeshProExtensions.LocalizeWith((string)text3, array);
						object obj114 = default(object);
						bool flag67 = obj114 == null;
						<Type>k__BackingField = data.<Type>k__BackingField;
						num2 = 8.000000000465661;
						flag2 = false;
						list = null;
						action = (Action<string>)(object)array;
						num = (int)array;
						tournamentData = (TournamentData)(object)text9;
						if (flag67)
						{
							goto IL_245a;
						}
						object obj115 = obj114;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1788 @ X8_v44+12E]");
						object obj116 = 0;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1788 @ X8_v44+12E]");
						if ((nint)0 == 0)
						{
							goto IL_1910;
						}
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1788 @ X8_v44+B0]");
						object obj117 = (nint)0 + (nint)8;
						while (true)
						{
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1821 @ X10_v45-8]");
							if (0 == (nint)obj111)
							{
								break;
							}
							obj28 = obj117 + 16;
							obj116--;
							bool flag68 = (nint)obj116 != 1;
							obj117 = obj28;
							if (flag68)
							{
								continue;
							}
							goto IL_1910;
						}
						object obj118 = obj117 + 1;
						object obj119 = obj115 + obj118;
						object obj120 = obj119 + 312;
						obj28 = obj117;
						goto IL_28e8;
					}
				}
			}
		}
		goto IL_2468;
		IL_2695:
		IPopupWindowBuilderNeedsTitle popupWindowBuilderNeedsTitle = PopupWindowBuilder.Create(PopupWindow.MessageType.Action);
		bool flag69 = popupWindowBuilderNeedsTitle == null;
		num2 = 8.000000000465661;
		flag2 = false;
		action = null;
		tournamentData = data;
		if (flag69)
		{
			goto IL_245a;
		}
		object obj121 = typeof(System.IOAsyncCallback) + 392;
		object obj122 = "tournament_participate_warning_body_with_tickets_warning_daily" + 16;
		num = (int)obj122;
		nint num15 = (nint)popupWindowBuilderNeedsTitle;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1634 @ X8_v30 (Il2CppClass<IPopupWindowBuilderNeedsTitle>)+12E]");
		object obj123 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1634 @ X8_v30 (Il2CppClass<IPopupWindowBuilderNeedsTitle>)+12E]");
		if ((nint)0 == 0)
		{
			goto IL_12c1;
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1634 @ X8_v30 (Il2CppClass<IPopupWindowBuilderNeedsTitle>)+B0]");
		object obj124 = (nint)0 + (nint)8;
		while (true)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1683 @ X10_v50-8]");
			if (0 == (nint)obj121)
			{
				break;
			}
			obj28 = obj124 + 16;
			obj123--;
			bool flag70 = (nint)obj123 != 1;
			obj124 = obj28;
			if (flag70)
			{
				continue;
			}
			goto IL_12c1;
		}
		object obj125 = num15 + obj124;
		obj39 = obj125 + 312;
		obj28 = obj124;
		goto IL_2804;
		IL_2d05:
		if (flag3)
		{
			object obj126 = typeof(SqlSingle[]) + 2376;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
			object obj127 = (nint)0 + (nint)208;
			Action action8 = default(Action);
			action8..ctor(obj2, (IntPtr)obj127);
			object label2 = "Complete" + 256;
			PopupButton popupButton4 = PopupButton.Positive((string)label2, action8, dismiss: true);
			bool flag71 = tournamentData2 == null;
			<Type>k__BackingField = data.<Type>k__BackingField;
			num2 = 8.000000000465661;
			flag2 = false;
			list = (List<GameObject>)1;
			action = (Action<string>)(object)action8;
			num = (int)action8;
			tournamentData = tournamentData2;
			if (!flag71)
			{
				nint num16 = (nint)tournamentData2;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v2008 @ X8_v73 (Il2CppClass<TournamentData>)+12E]");
				object obj128 = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v2008 @ X8_v73 (Il2CppClass<TournamentData>)+12E]");
				if ((nint)0 == 0)
				{
					goto IL_1cab;
				}
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v2008 @ X8_v73 (Il2CppClass<TournamentData>)+B0]");
				object obj129 = (nint)0 + (nint)8;
				bool flag72 = flag36;
				while (true)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v2086 @ X10_v34-8]");
					obj30 = -(((bool*)(flag4 ? 1 : 0))->m_value ? 1 : 0);
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v2086 @ X10_v34-8]");
					if ((nint)0 == (((bool*)(flag4 ? 1 : 0))->m_value ? 1 : 0))
					{
						break;
					}
					obj28 = obj129 + 16;
					obj128--;
					obj30 = obj128 - 1;
					flag27 = obj30 == null;
					flag36 = (nint)obj128 != 1;
					obj129 = obj28;
					flag72 = flag36;
					if (flag36)
					{
						continue;
					}
					goto IL_1cab;
				}
				object obj130 = num16 + obj129;
				object obj131 = obj130 + 312;
				obj28 = obj129;
				flag36 = flag72;
				goto IL_2a41;
			}
		}
		else
		{
			object label3 = "COORDINATE_TYPE_GCJ_02" + 1864;
			PopupButton popupButton5 = PopupButton.Neutral((string)label3, null, dismiss: true);
			bool flag73 = tournamentData2 == null;
			<Type>k__BackingField = data.<Type>k__BackingField;
			num2 = 8.000000000465661;
			flag2 = false;
			list = (List<GameObject>)1;
			action = null;
			num = (int)localizableText3;
			tournamentData = tournamentData2;
			if (!flag73)
			{
				value2 = ((bool*)(flag4 ? 1 : 0))->m_value;
				num10 = (nint)tournamentData2;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1980 @ X8_v61 (Il2CppClass<TournamentData>)+12E]");
				obj94 = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1980 @ X8_v61 (Il2CppClass<TournamentData>)+12E]");
				bool flag74 = (nint)0 == 0;
				object obj132 = !flag74;
				flag2 = false;
				popupButton3 = popupButton5;
				if (obj132 != null)
				{
					goto IL_1dfb;
				}
				flag16 = false;
				flag50 = flag36;
				value3 = ((bool*)(flag4 ? 1 : 0))->m_value;
				popupButton = popupButton5;
				goto IL_1e9e;
			}
		}
		goto IL_245a;
		IL_2476:
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1ABC");
		OutOfMemoryException ex2 = new OutOfMemoryException();
		int num17 = 0;
		OutOfMemoryException ex3 = ex2;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @22389E8");
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @6CB03A0");
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2B060");
		return;
		IL_29b6:
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v2047 @ X0_v140+8]");
		obj62 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v2047 @ X0_v140] (should have been resolved before IL gen)");
		flag38 = false;
		sprite = passwordIcon;
		localizableText = (LocalizableText)popupWindowBuilderInput;
		localizableText3 = (LocalizableText)popupWindowBuilderInput;
		goto IL_2d05;
		IL_0808:
		object obj133 = "utf-32" + 3048;
		text7 = (string)obj133;
		DateTime dateTime = default(DateTime);
		string text10 = dateTime.ToString((string)obj133, cultureInfo);
		num9 = data.<Size>k__BackingField;
		obj81 = obj76;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1342 @ X0_v177+E4]");
		bool flag75 = (nint)0 == 0;
		object obj134 = !flag75;
		obj84 = 0;
		flag46 = (byte)(int)cultureInfo != 0;
		text8 = text10;
		obj83 = 0;
		flag45 = (byte)(int)cultureInfo != 0;
		text5 = (string)obj133;
		a = data.<Size>k__BackingField;
		text6 = text10;
		if (obj134 == null)
		{
			goto IL_08c0;
		}
		goto IL_08f7;
		IL_0415:
		object obj135 = typeof(System.Diagnostics.DiagnosticSourceEventSource.TransformSpec.PropertySpec.PropertyFetch.EnumeratePropertyFetch<>) + 2096;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
		object obj136 = (nint)0 + (nint)1120;
		Action<object> action9 = default(Action<object>);
		action9..ctor((object)null, (IntPtr)obj136);
		bool flag76 = extraContents == null;
		flag2 = false;
		list = (List<GameObject>)obj136;
		action = null;
		num = (int)action9;
		tournamentData = data;
		if (!flag76)
		{
			((List<object>)(object)extraContents).ForEach(action9);
			return;
		}
		goto IL_245a;
		IL_0d6d:
		value = (double)tournamentTickets2.<NextTicketTime>k__BackingField;
		object obj137 = (nint)0 + (nint)2296;
		DateTime? dateTime2 = default(DateTime?);
		DateTime value4 = dateTime2.Value;
		object obj138 = obj43;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1103 @ X0_v205+E4]");
		bool flag77 = (nint)0 == 0;
		object obj139 = !flag77;
		if (obj139 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		}
		DateTime now2 = DateTime.Now;
		TimeSpan timeSpan5 = value4 - now2;
		object obj140 = typeof(DataRelation) + 824;
		object obj141 = obj140;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1238 @ X8_v125+E4]");
		bool flag78 = (nint)0 == 0;
		object obj142 = !flag78;
		if (obj142 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		}
		string durationText2 = DateTimeUtil.GetDurationText(timeSpan5);
		object obj143 = "Network Authentication Required" + 3128;
		PopupWindowBuilder popupWindowBuilder = PopupWindowBuilder.CreateError(null, (string)obj143);
		bool flag79 = popupWindowBuilder == null;
		flag2 = false;
		list = null;
		action = (Action<string>)obj143;
		num = (int)durationText2;
		tournamentData = data;
		if (!flag79)
		{
			object title = "Drop Menu Toggle" + 3600;
			IPopupWindowBuilderNeedsBody popupWindowBuilderNeedsBody = popupWindowBuilder.Titled((string)title);
			object obj144 = typeof(TypeConverter<ushort, char>) + 3400;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC18B4");
			object[] array2 = default(object[]);
			bool flag80 = array2 == null;
			flag2 = false;
			list = null;
			action = (Action<string>)1;
			num = (int)durationText2;
			tournamentData = data;
			if (!flag80)
			{
				bool flag81 = durationText2 == null;
				Action<string> action10 = (Action<string>)1;
				if (!flag81)
				{
					nint num18 = (nint)array2;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v616 @ X8_v146 (Il2CppClass<System.Object[]>)+40]");
					action10 = (Action<string>)0;
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1958");
					bool flag82 = ex == null;
					flag2 = false;
					list = null;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v616 @ X8_v146 (Il2CppClass<System.Object[]>)+40]");
					action = (Action<string>)0;
					num = (int)durationText2;
					tournamentData = data;
					if (flag82)
					{
						goto IL_2476;
					}
				}
				bool flag83 = array2.Length == 0;
				flag2 = false;
				list = null;
				action = action10;
				num = (int)durationText2;
				tournamentData = data;
				if (flag83)
				{
					goto IL_2468;
				}
				object obj145 = array2 + 32;
				obj145 = durationText2;
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
				object text11 = "startPosition" + 4064;
				localizableText5 = TextMeshProExtensions.LocalizeWith((string)text11, array2);
				bool flag84 = popupWindowBuilderNeedsBody == null;
				flag2 = false;
				list = null;
				action = (Action<string>)(object)array2;
				num = (int)durationText2;
				tournamentData = data;
				if (!flag84)
				{
					nint num19 = (nint)popupWindowBuilderNeedsBody;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1438 @ X8_v136 (Il2CppClass<IPopupWindowBuilderNeedsBody>)+12E]");
					object obj146 = 0;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1438 @ X8_v136 (Il2CppClass<IPopupWindowBuilderNeedsBody>)+12E]");
					if ((nint)0 == 0)
					{
						goto IL_10cf;
					}
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1438 @ X8_v136 (Il2CppClass<IPopupWindowBuilderNeedsBody>)+B0]");
					object obj147 = (nint)0 + (nint)8;
					while (true)
					{
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v118 @ X10_v64-8]");
						if (0 == (nint)obj44)
						{
							break;
						}
						obj147 += 16;
						obj146--;
						if ((nint)obj146 != 1)
						{
							continue;
						}
						goto IL_10cf;
					}
					object obj148 = obj147 + 1;
					object obj149 = num19 + obj148;
					object obj150 = obj149 + 312;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1512 @ X0_v233+8]");
					list3 = (List<GameObject>)0;
					Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v1512 @ X0_v233] (should have been resolved before IL gen)");
					bool flag85 = obj68 == null;
					flag2 = false;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1512 @ X0_v233+8]");
					list = (List<GameObject>)0;
					action = (Action<string>)(object)localizableText5;
					num = (int)localizableText5;
					tournamentData = data;
					if (!flag85)
					{
						goto IL_2378;
					}
				}
			}
		}
		goto IL_245a;
		IL_245a:
		NullReferenceException ex4 = new NullReferenceException();
		goto IL_2468;
		IL_1ac8:
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @B0D070");
		goto IL_29b6;
		IL_08c0:
		Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		obj83 = obj84;
		flag45 = flag46;
		text5 = text7;
		a = num9;
		text6 = text8;
		goto IL_08f7;
	}

	public static void ShowMessage(TournamentData data, string message)
	{
		//IL_0009: Expected O, but got I4
		//IL_0018: Unknown result type (might be due to invalid IL or missing references)
		//IL_001d: Expected O, but got Unknown
		//IL_0033: Expected O, but got I
		//IL_00fa: Expected O, but got I
		//IL_0134: Expected O, but got I4
		//IL_00d5: Expected O, but got I4
		//IL_005c: Expected O, but got I
		//IL_0204: Expected O, but got I4
		//IL_0674: Unknown result type (might be due to invalid IL or missing references)
		//IL_0679: Expected O, but got Unknown
		//IL_0681: Unknown result type (might be due to invalid IL or missing references)
		//IL_0686: Expected O, but got Unknown
		//IL_068f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0694: Expected O, but got Unknown
		//IL_06ac: Expected O, but got I
		//IL_03f4: Unknown result type (might be due to invalid IL or missing references)
		//IL_03f9: Expected O, but got Unknown
		//IL_0401: Unknown result type (might be due to invalid IL or missing references)
		//IL_0406: Expected O, but got Unknown
		//IL_040f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0414: Expected O, but got Unknown
		//IL_041c: Expected I, but got O
		//IL_035e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0363: Expected O, but got Unknown
		//IL_036c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0371: Expected O, but got Unknown
		//IL_045a: Unknown result type (might be due to invalid IL or missing references)
		//IL_045f: Expected O, but got Unknown
		//IL_0477: Expected O, but got I
		//IL_028a: Unknown result type (might be due to invalid IL or missing references)
		//IL_028f: Expected I, but got Unknown
		//IL_0299: Expected O, but got I
		//IL_03ab: Expected I, but got O
		//IL_03cf: Expected O, but got I4
		//IL_04b2: Expected O, but got I
		//IL_054b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0550: Expected O, but got Unknown
		//IL_0558: Expected I, but got O
		//IL_0568: Expected O, but got I
		//IL_0606: Expected O, but got I
		//IL_0626: Unknown result type (might be due to invalid IL or missing references)
		//IL_062b: Expected I, but got Unknown
		//IL_064f: Expected O, but got I4
		//IL_02f8: Unknown result type (might be due to invalid IL or missing references)
		//IL_02fd: Expected O, but got Unknown
		//IL_0305: Expected I, but got O
		//IL_0315: Expected O, but got I
		//IL_05a3: Expected O, but got I
		//IL_04c0: Unknown result type (might be due to invalid IL or missing references)
		//IL_04c5: Expected O, but got Unknown
		//IL_04ce: Unknown result type (might be due to invalid IL or missing references)
		//IL_04d3: Expected O, but got Unknown
		//IL_0350: Expected O, but got I
		//IL_05b1: Unknown result type (might be due to invalid IL or missing references)
		//IL_05b6: Expected O, but got Unknown
		//IL_05bf: Unknown result type (might be due to invalid IL or missing references)
		//IL_05c4: Expected O, but got Unknown
		object obj = 152985600;
		object obj2 = typeof(Queue<string>) + 848;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [91E6E8B]");
		object obj3 = (nint)0 & (nint)1;
		nint num;
		nint num2;
		object obj6;
		object obj4;
		if (obj3 != null)
		{
			obj4 = (nint)0 + (nint)2200;
			object obj5 = obj2;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v56 @ X0_v33+E4]");
			num = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v56 @ X0_v33+E4]");
			bool flag = (nint)0 == 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v56 @ X0_v33+E4]");
			num2 = 0;
			obj6 = obj4;
			if (!flag)
			{
				goto IL_00b1;
			}
		}
		else
		{
			_ = 1;
			obj4 = (nint)0 + (nint)2200;
			object obj5 = obj2;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v56 @ X0_v33+E4]");
			num = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v56 @ X0_v33+E4]");
			bool flag2 = (nint)0 == 0;
			object obj7 = !flag2;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v56 @ X0_v33+E4]");
			num2 = 0;
			obj6 = obj4;
			if (obj7 != null)
			{
				goto IL_00b1;
			}
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @3CEC320");
		SessionModel sessionModel = default(SessionModel);
		bool flag3 = (object)sessionModel == null;
		obj4 = obj6;
		num = num2;
		if (!flag3)
		{
			goto IL_01a0;
		}
		goto IL_065d;
		IL_065d:
		NullReferenceException ex = new NullReferenceException();
		goto IL_066b;
		IL_053c:
		object obj8 = typeof(System.IOAsyncCallback) + 368;
		num = (nint)ex;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v233 @ X8_v2 (Il2CppClass<System.NullReferenceException>)+12E]");
		object obj9 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v233 @ X8_v2 (Il2CppClass<System.NullReferenceException>)+12E]");
		if ((nint)0 == 0)
		{
			goto IL_05e4;
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v233 @ X8_v2 (Il2CppClass<System.NullReferenceException>)+B0]");
		object obj10 = (nint)0 + (nint)8;
		while (true)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v144 @ X10_v15-8]");
			if (0 == (nint)obj8)
			{
				break;
			}
			obj10 += 16;
			obj9--;
			if ((nint)obj9 != 1)
			{
				continue;
			}
			goto IL_05e4;
		}
		goto IL_066b;
		IL_04fb:
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @B0D070");
		Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v403 @ X0_v21 (Il2CppClass<System.NullReferenceException>)] (should have been resolved before IL gen)");
		bool flag4 = ex == null;
		object obj11 = default(object);
		obj10 = obj11;
		IntPtr intPtr = default(IntPtr);
		num = intPtr;
		if (!flag4)
		{
			goto IL_053c;
		}
		goto IL_065d;
		IL_00b1:
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @3CEC320");
		bool flag5 = (object)sessionModel == null;
		object obj12 = !flag5;
		if (obj12 != null)
		{
			goto IL_01a0;
		}
		goto IL_065d;
		IL_01a0:
		Room currentRoom = sessionModel.CurrentRoom;
		if (currentRoom == null)
		{
			return;
		}
		object obj13 = obj2;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v250 @ X0_v7+E4]");
		num = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v250 @ X0_v7+E4]");
		bool flag6 = (nint)0 == 0;
		object obj14 = !flag6;
		if (obj14 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @3CEC320");
		SessionModel sessionModel2 = default(SessionModel);
		object obj15 = default(object);
		nint num3 = default(nint);
		object obj16 = default(object);
		if ((object)sessionModel2 != null)
		{
			Room currentRoom2 = sessionModel2.CurrentRoom;
			if (!SFSKammelnaRoomExtensions.IsTournamentHub(currentRoom2))
			{
				return;
			}
			num = (nint)("Network Authentication Required" + 3128);
			IPopupWindowBuilderNeedsTitle popupWindowBuilderNeedsTitle = PopupWindowBuilder.CreateInfo(null, (string)num);
			if (data != null)
			{
				LocalizableText localizableText = TextMeshProExtensions.FixOnly(data.<Name>k__BackingField);
				if (popupWindowBuilderNeedsTitle != null)
				{
					obj15 = typeof(System.IOAsyncCallback) + 392;
					num3 = (nint)popupWindowBuilderNeedsTitle;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v328 @ X8_v13 (Il2CppClass<IPopupWindowBuilderNeedsTitle>)+12E]");
					obj16 = 0;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v328 @ X8_v13 (Il2CppClass<IPopupWindowBuilderNeedsTitle>)+12E]");
					if ((nint)0 == 0)
					{
						goto IL_0399;
					}
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v328 @ X8_v13 (Il2CppClass<IPopupWindowBuilderNeedsTitle>)+B0]");
					obj11 = (nint)0 + (nint)8;
					goto IL_06b6;
				}
			}
		}
		goto IL_065d;
		IL_066b:
		object obj17 = obj10 + 9;
		object obj18 = num + obj17;
		object obj19 = obj18 + 312;
		object obj20 = obj19;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v241 @ X8_v4+8]");
		object obj21 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Indirect jump: v242 @ X2_v2 (should have been resolved before IL gen)");
		goto IL_06b6;
		IL_05e4:
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @B0D070");
		object obj23 = default(object);
		object obj22 = obj23;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v453 @ X0_v19+8]");
		object obj24 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Indirect jump: v296 @ X2_v8 (should have been resolved before IL gen)");
		goto IL_0610;
		IL_06b6:
		while (true)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v146 @ X10_v10-8]");
			if (0 == (nint)obj15)
			{
				break;
			}
			obj10 = obj11 + 16;
			obj16--;
			bool flag7 = (nint)obj16 != 1;
			obj11 = obj10;
			if (flag7)
			{
				continue;
			}
			goto IL_0399;
		}
		object obj25 = obj11 + 1;
		object obj26 = num3 + obj25;
		object obj27 = obj26 + 312;
		num = (nint)obj27;
		Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v363 @ X0_v29] (should have been resolved before IL gen)");
		object obj28 = default(object);
		bool flag8 = obj28 == null;
		obj10 = obj11;
		if (!flag8)
		{
			goto IL_044b;
		}
		goto IL_065d;
		IL_0610:
		object obj30;
		object obj29 = obj30 + obj10;
		num = (nint)(obj29 + 312);
		Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v233 @ X8_v2 (Il2CppClass<System.NullReferenceException>)] (should have been resolved before IL gen)");
		bool flag9 = ex == null;
		object obj31 = !flag9;
		if (obj31 != null)
		{
			goto IL_053c;
		}
		goto IL_065d;
		IL_0399:
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @B0D070");
		object obj32 = default(object);
		num = (nint)obj32;
		Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v346 @ X0_v26] (should have been resolved before IL gen)");
		bool flag10 = obj28 == null;
		object obj33 = !flag10;
		obj11 = obj10;
		if (obj33 != null)
		{
			goto IL_044b;
		}
		goto IL_065d;
		IL_044b:
		object obj34 = typeof(System.IOAsyncCallback) + 384;
		obj30 = obj28;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v385 @ X8_v17+12E]");
		object obj35 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v385 @ X8_v17+12E]");
		if ((nint)0 == 0)
		{
			goto IL_04fb;
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v385 @ X8_v17+B0]");
		obj10 = (nint)0 + (nint)8;
		while (true)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v144 @ X10_v15-8]");
			if (0 == (nint)obj34)
			{
				break;
			}
			obj11 = obj10 + 16;
			obj35--;
			bool flag11 = (nint)obj35 != 1;
			obj10 = obj11;
			if (flag11)
			{
				continue;
			}
			goto IL_04fb;
		}
		goto IL_0610;
	}

	public static void ShowTournamentCancelled()
	{
		//IL_000f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0014: Expected O, but got Unknown
		//IL_0348: Expected O, but got I
		//IL_0357: Unknown result type (might be due to invalid IL or missing references)
		//IL_035c: Expected O, but got Unknown
		//IL_0368: Expected O, but got I
		//IL_0372: Unknown result type (might be due to invalid IL or missing references)
		//IL_0377: Expected O, but got Unknown
		//IL_03b1: Expected O, but got I4
		//IL_0052: Expected I, but got O
		//IL_02fa: Unknown result type (might be due to invalid IL or missing references)
		//IL_02ff: Expected O, but got Unknown
		//IL_0307: Unknown result type (might be due to invalid IL or missing references)
		//IL_030c: Expected O, but got Unknown
		//IL_0315: Unknown result type (might be due to invalid IL or missing references)
		//IL_031a: Expected O, but got Unknown
		//IL_0332: Expected O, but got I
		//IL_008f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0094: Expected I, but got Unknown
		//IL_00a1: Expected O, but got I
		//IL_00d1: Unknown result type (might be due to invalid IL or missing references)
		//IL_00d6: Expected O, but got Unknown
		//IL_00e0: Unknown result type (might be due to invalid IL or missing references)
		//IL_00e5: Expected O, but got Unknown
		//IL_00ed: Expected I, but got O
		//IL_00fd: Expected O, but got I
		//IL_0138: Expected O, but got I
		//IL_01c9: Unknown result type (might be due to invalid IL or missing references)
		//IL_01ce: Expected O, but got Unknown
		//IL_01d6: Expected I, but got O
		//IL_01e6: Expected O, but got I
		//IL_0284: Expected O, but got I
		//IL_0296: Unknown result type (might be due to invalid IL or missing references)
		//IL_029b: Expected O, but got Unknown
		//IL_02a4: Unknown result type (might be due to invalid IL or missing references)
		//IL_02a9: Expected I, but got Unknown
		//IL_02cd: Expected O, but got I4
		//IL_0221: Expected O, but got I
		//IL_0146: Unknown result type (might be due to invalid IL or missing references)
		//IL_014b: Expected O, but got Unknown
		//IL_0154: Unknown result type (might be due to invalid IL or missing references)
		//IL_0159: Expected O, but got Unknown
		//IL_022f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0234: Expected O, but got Unknown
		//IL_023d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0242: Expected O, but got Unknown
		object obj = typeof(Queue<string>) + 840;
		Action action = default(Action);
		object obj7 = default(object);
		object obj11 = default(object);
		object obj12 = default(object);
		NullReferenceException ex = default(NullReferenceException);
		IntPtr intPtr = default(IntPtr);
		object obj21 = default(object);
		while (true)
		{
			object obj2 = (nint)0 + (nint)2184;
			object obj3 = typeof(SqlSingle[]) + 2376;
			object obj4 = (nint)0 + (nint)1032;
			object buttonText = "Network Authentication Required" + 3128;
			object obj5 = obj;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v56 @ X0_v2+E4]");
			nint num = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v56 @ X0_v2+E4]");
			bool flag = (nint)0 == 0;
			object obj6 = !flag;
			if (obj6 == null)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			}
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @3CEC320");
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
			action..ctor(obj7, (IntPtr)obj4);
			PopupWindowBuilder popupWindowBuilder = PopupWindowBuilder.CreateError(action, (string)buttonText);
			nint num2;
			if (popupWindowBuilder != null)
			{
				num = (nint)("ThisIsFakeReceiptData" + 1232);
				IPopupWindowBuilderNeedsBody popupWindowBuilderNeedsBody = popupWindowBuilder.Titled((string)num);
				if (popupWindowBuilderNeedsBody != null)
				{
					object obj8 = typeof(System.IOAsyncCallback) + 384;
					object obj9 = "ThisIsFakeReceiptData" + 1448;
					num2 = (nint)popupWindowBuilderNeedsBody;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v229 @ X8_v12 (Il2CppClass<IPopupWindowBuilderNeedsBody>)+12E]");
					object obj10 = 0;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v229 @ X8_v12 (Il2CppClass<IPopupWindowBuilderNeedsBody>)+12E]");
					if ((nint)0 == 0)
					{
						goto IL_0181;
					}
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v229 @ X8_v12 (Il2CppClass<IPopupWindowBuilderNeedsBody>)+B0]");
					obj11 = (nint)0 + (nint)8;
					while (true)
					{
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v140 @ X10_v12-8]");
						if (0 == (nint)obj8)
						{
							break;
						}
						obj12 = obj11 + 16;
						obj10--;
						bool flag2 = (nint)obj10 != 1;
						obj11 = obj12;
						if (flag2)
						{
							continue;
						}
						goto IL_0181;
					}
					goto IL_028e;
				}
			}
			goto IL_02e3;
			IL_01ba:
			object obj13 = typeof(System.IOAsyncCallback) + 368;
			num = (nint)ex;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v204 @ X8_v4 (Il2CppClass<System.NullReferenceException>)+12E]");
			object obj14 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v204 @ X8_v4 (Il2CppClass<System.NullReferenceException>)+12E]");
			if ((nint)0 != 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v204 @ X8_v4 (Il2CppClass<System.NullReferenceException>)+B0]");
				obj12 = (nint)0 + (nint)8;
				while (true)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v142 @ X10_v9-8]");
					if (0 == (nint)obj13)
					{
						break;
					}
					obj12 += 16;
					obj14--;
					if ((nint)obj14 != 1)
					{
						continue;
					}
					goto IL_0262;
				}
				goto IL_02f1;
			}
			goto IL_0262;
			IL_0181:
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @B0D070");
			Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v296 @ X0_v17 (Il2CppClass<System.NullReferenceException>)] (should have been resolved before IL gen)");
			bool flag3 = ex == null;
			num = intPtr;
			if (!flag3)
			{
				goto IL_01ba;
			}
			goto IL_02e3;
			IL_02e3:
			ex = new NullReferenceException();
			goto IL_02f1;
			IL_02f1:
			object obj15 = obj12 + 9;
			object obj16 = num + obj15;
			object obj17 = obj16 + 312;
			object obj18 = obj17;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v211 @ X8_v6+8]");
			object obj19 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Indirect jump: v212 @ X2_v4 (should have been resolved before IL gen)");
			continue;
			IL_0262:
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @B0D070");
			object obj20 = obj21;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v346 @ X0_v15+8]");
			object obj22 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Indirect jump: v269 @ X2_v9 (should have been resolved before IL gen)");
			goto IL_028e;
			IL_028e:
			object obj23 = num2 + obj11;
			num = (nint)(obj23 + 312);
			Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v204 @ X8_v4 (Il2CppClass<System.NullReferenceException>)] (should have been resolved before IL gen)");
			bool flag4 = ex == null;
			object obj24 = !flag4;
			obj12 = obj11;
			if (obj24 != null)
			{
				goto IL_01ba;
			}
			goto IL_02e3;
		}
	}

	public static void ShowTicketsForfeitWarning(Action forfeitAction)
	{
		//IL_001a: Unknown result type (might be due to invalid IL or missing references)
		//IL_001f: Expected O, but got Unknown
		//IL_0029: Unknown result type (might be due to invalid IL or missing references)
		//IL_002e: Expected O, but got Unknown
		//IL_02a8: Unknown result type (might be due to invalid IL or missing references)
		//IL_02ad: Expected O, but got Unknown
		//IL_02b5: Unknown result type (might be due to invalid IL or missing references)
		//IL_02ba: Expected O, but got Unknown
		//IL_02c3: Unknown result type (might be due to invalid IL or missing references)
		//IL_02c8: Expected O, but got Unknown
		//IL_02e0: Expected O, but got I
		//IL_003d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0042: Expected I, but got Unknown
		//IL_004f: Expected O, but got I
		//IL_007f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0084: Expected O, but got Unknown
		//IL_008e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0093: Expected O, but got Unknown
		//IL_009b: Expected I, but got O
		//IL_00ab: Expected O, but got I
		//IL_00e6: Expected O, but got I
		//IL_0177: Unknown result type (might be due to invalid IL or missing references)
		//IL_017c: Expected O, but got Unknown
		//IL_0184: Expected I, but got O
		//IL_0194: Expected O, but got I
		//IL_0232: Expected O, but got I
		//IL_0244: Unknown result type (might be due to invalid IL or missing references)
		//IL_0249: Expected O, but got Unknown
		//IL_0252: Unknown result type (might be due to invalid IL or missing references)
		//IL_0257: Expected I, but got Unknown
		//IL_027b: Expected O, but got I4
		//IL_01cf: Expected O, but got I
		//IL_00f4: Unknown result type (might be due to invalid IL or missing references)
		//IL_00f9: Expected O, but got Unknown
		//IL_0102: Unknown result type (might be due to invalid IL or missing references)
		//IL_0107: Expected O, but got Unknown
		//IL_01dd: Unknown result type (might be due to invalid IL or missing references)
		//IL_01e2: Expected O, but got Unknown
		//IL_01eb: Unknown result type (might be due to invalid IL or missing references)
		//IL_01f0: Expected O, but got Unknown
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [91E6E8D]");
		nint num = 0;
		object confirmText = "FilterFunction '{0}' expects {1} parameters but only {2} were provided. Missing parameters will be set to their default values." + 832;
		object cancelText = "AvailableVoices" + 768;
		Action confirmAction = default(Action);
		object obj4 = default(object);
		object obj5 = default(object);
		NullReferenceException ex = default(NullReferenceException);
		object obj12 = default(object);
		IntPtr intPtr = default(IntPtr);
		while (true)
		{
			PopupWindowBuilder popupWindowBuilder = PopupWindowBuilder.CreateNegativeConfirm(confirmAction, (string)confirmText, (string)cancelText);
			nint num2;
			if (popupWindowBuilder != null)
			{
				num = (nint)("Unsupported map type" + 3592);
				IPopupWindowBuilderNeedsBody popupWindowBuilderNeedsBody = popupWindowBuilder.Titled((string)num);
				if (popupWindowBuilderNeedsBody != null)
				{
					object obj = typeof(System.IOAsyncCallback) + 384;
					object obj2 = "ThisIsFakeReceiptData" + 128;
					num2 = (nint)popupWindowBuilderNeedsBody;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v194 @ X8_v11 (Il2CppClass<IPopupWindowBuilderNeedsBody>)+12E]");
					object obj3 = 0;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v194 @ X8_v11 (Il2CppClass<IPopupWindowBuilderNeedsBody>)+12E]");
					if ((nint)0 == 0)
					{
						goto IL_012f;
					}
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v194 @ X8_v11 (Il2CppClass<IPopupWindowBuilderNeedsBody>)+B0]");
					obj4 = (nint)0 + (nint)8;
					while (true)
					{
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v106 @ X10_v12-8]");
						if (0 == (nint)obj)
						{
							break;
						}
						obj5 = obj4 + 16;
						obj3--;
						bool flag = (nint)obj3 != 1;
						obj4 = obj5;
						if (flag)
						{
							continue;
						}
						goto IL_012f;
					}
					goto IL_023c;
				}
			}
			goto IL_0291;
			IL_0291:
			ex = new NullReferenceException();
			goto IL_029f;
			IL_029f:
			object obj6 = obj5 + 9;
			object obj7 = num + obj6;
			object obj8 = obj7 + 312;
			object obj9 = obj8;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v177 @ X8_v5+8]");
			object obj10 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Indirect jump: v178 @ X2_v3 (should have been resolved before IL gen)");
			continue;
			IL_0210:
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @B0D070");
			object obj11 = obj12;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v310 @ X0_v8+8]");
			object obj13 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Indirect jump: v224 @ X2_v8 (should have been resolved before IL gen)");
			goto IL_023c;
			IL_023c:
			object obj14 = num2 + obj4;
			num = (nint)(obj14 + 312);
			Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v171 @ X8_v3 (Il2CppClass<System.NullReferenceException>)] (should have been resolved before IL gen)");
			bool flag2 = ex == null;
			object obj15 = !flag2;
			obj5 = obj4;
			if (obj15 != null)
			{
				goto IL_0168;
			}
			goto IL_0291;
			IL_012f:
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @B0D070");
			Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v260 @ X0_v10 (Il2CppClass<System.NullReferenceException>)] (should have been resolved before IL gen)");
			bool flag3 = ex == null;
			num = intPtr;
			if (!flag3)
			{
				goto IL_0168;
			}
			goto IL_0291;
			IL_0168:
			object obj16 = typeof(System.IOAsyncCallback) + 368;
			num = (nint)ex;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v171 @ X8_v3 (Il2CppClass<System.NullReferenceException>)+12E]");
			object obj17 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v171 @ X8_v3 (Il2CppClass<System.NullReferenceException>)+12E]");
			if ((nint)0 != 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v171 @ X8_v3 (Il2CppClass<System.NullReferenceException>)+B0]");
				obj5 = (nint)0 + (nint)8;
				while (true)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v108 @ X10_v9-8]");
					if (0 == (nint)obj16)
					{
						break;
					}
					obj5 += 16;
					obj17--;
					if ((nint)obj17 != 1)
					{
						continue;
					}
					goto IL_0210;
				}
				goto IL_029f;
			}
			goto IL_0210;
		}
	}

	public static void ShowTournamentHubError()
	{
		//IL_000f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0014: Expected O, but got Unknown
		//IL_002a: Expected O, but got I
		//IL_0176: Expected O, but got I4
		//IL_00a6: Unknown result type (might be due to invalid IL or missing references)
		//IL_00ab: Expected O, but got Unknown
		//IL_00bb: Expected O, but got I
		//IL_00cb: Expected O, but got I
		//IL_023f: Expected O, but got I4
		//IL_01b8: Unknown result type (might be due to invalid IL or missing references)
		//IL_01bd: Expected O, but got Unknown
		//IL_01cd: Expected O, but got I
		//IL_01dd: Expected O, but got I
		//IL_01ff: Expected O, but got I4
		//IL_0559: Unknown result type (might be due to invalid IL or missing references)
		//IL_055e: Expected O, but got Unknown
		//IL_0574: Expected O, but got I
		//IL_0585: Expected I, but got O
		//IL_058d: Expected I, but got O
		//IL_05a3: Expected O, but got I
		//IL_0123: Expected O, but got I4
		//IL_029d: Expected O, but got I4
		//IL_026f: Expected O, but got I
		//IL_02b5: Unknown result type (might be due to invalid IL or missing references)
		//IL_02ba: Expected I, but got Unknown
		//IL_02c7: Expected O, but got I
		//IL_0508: Unknown result type (might be due to invalid IL or missing references)
		//IL_050d: Expected O, but got Unknown
		//IL_0515: Unknown result type (might be due to invalid IL or missing references)
		//IL_051a: Expected O, but got Unknown
		//IL_0523: Unknown result type (might be due to invalid IL or missing references)
		//IL_0528: Expected O, but got Unknown
		//IL_0540: Expected O, but got I
		//IL_02f7: Unknown result type (might be due to invalid IL or missing references)
		//IL_02fc: Expected O, but got Unknown
		//IL_0306: Unknown result type (might be due to invalid IL or missing references)
		//IL_030b: Expected O, but got Unknown
		//IL_0313: Expected I, but got O
		//IL_0323: Expected O, but got I
		//IL_035e: Expected O, but got I
		//IL_03ef: Unknown result type (might be due to invalid IL or missing references)
		//IL_03f4: Expected O, but got Unknown
		//IL_03fc: Expected I, but got O
		//IL_040c: Expected O, but got I
		//IL_04a4: Unknown result type (might be due to invalid IL or missing references)
		//IL_04a9: Expected O, but got Unknown
		//IL_04b2: Unknown result type (might be due to invalid IL or missing references)
		//IL_04b7: Expected I, but got Unknown
		//IL_04db: Expected O, but got I4
		//IL_0447: Expected O, but got I
		//IL_036c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0371: Expected O, but got Unknown
		//IL_037a: Unknown result type (might be due to invalid IL or missing references)
		//IL_037f: Expected O, but got Unknown
		//IL_0455: Unknown result type (might be due to invalid IL or missing references)
		//IL_045a: Expected O, but got Unknown
		//IL_0463: Unknown result type (might be due to invalid IL or missing references)
		//IL_0468: Expected O, but got Unknown
		object obj = typeof(SkeletonBinary.SkeletonInput) + 3776;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [91E6E8E]");
		object obj2 = (nint)0 & (nint)1;
		nint num;
		nint num2;
		object obj3;
		if (obj2 != null)
		{
			obj3 = obj;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v77 @ X0_v13+E4]");
			num = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v77 @ X0_v13+E4]");
			bool flag = (nint)0 == 0;
			object obj4 = obj3;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v77 @ X0_v13+E4]");
			num2 = 0;
			if (!flag)
			{
				goto IL_009c;
			}
		}
		else
		{
			_ = 1;
			obj3 = obj;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v77 @ X0_v13+E4]");
			num = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v77 @ X0_v13+E4]");
			bool flag2 = (nint)0 == 0;
			object obj5 = !flag2;
			object obj4 = obj3;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v77 @ X0_v13+E4]");
			num2 = 0;
			if (obj5 != null)
			{
				goto IL_009c;
			}
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		obj3 = obj;
		object obj6 = "Network Authentication Required" + 3128;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v77 @ X0_v13+B8]");
		object obj7 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v91 @ X9_v21+10]");
		Action action = (Action)0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v91 @ X9_v21+10]");
		bool flag3 = (nint)0 == 0;
		object obj8 = !flag3;
		num = num2;
		object buttonText = obj6;
		if (obj8 != null)
		{
			goto IL_00f8;
		}
		goto IL_021d;
		IL_049c:
		nint num3;
		object obj10 = default(object);
		object obj9 = num3 + obj10;
		num = (nint)(obj9 + 312);
		Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v246 @ X8_v2 (Il2CppClass<System.NullReferenceException>)] (should have been resolved before IL gen)");
		NullReferenceException ex = default(NullReferenceException);
		bool flag4 = ex == null;
		object obj11 = !flag4;
		object obj12 = obj10;
		if (obj11 != null)
		{
			goto IL_03e0;
		}
		goto IL_04f1;
		IL_03e0:
		object obj13 = typeof(System.IOAsyncCallback) + 368;
		num = (nint)ex;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v246 @ X8_v2 (Il2CppClass<System.NullReferenceException>)+12E]");
		object obj14 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v246 @ X8_v2 (Il2CppClass<System.NullReferenceException>)+12E]");
		if ((nint)0 == 0)
		{
			goto IL_0488;
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v246 @ X8_v2 (Il2CppClass<System.NullReferenceException>)+B0]");
		obj12 = (nint)0 + (nint)8;
		while (true)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v176 @ X10_v9-8]");
			if (0 == (nint)obj13)
			{
				break;
			}
			obj12 += 16;
			obj14--;
			if ((nint)obj14 != 1)
			{
				continue;
			}
			goto IL_0488;
		}
		goto IL_04ff;
		IL_03a7:
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @B0D070");
		Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v334 @ X0_v9 (Il2CppClass<System.NullReferenceException>)] (should have been resolved before IL gen)");
		bool flag5 = ex == null;
		IntPtr intPtr = default(IntPtr);
		num = intPtr;
		if (!flag5)
		{
			goto IL_03e0;
		}
		goto IL_04f1;
		IL_009c:
		obj6 = "Network Authentication Required" + 3128;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v77 @ X0_v13+B8]");
		obj7 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v91 @ X9_v21+10]");
		action = (Action)0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v91 @ X9_v21+10]");
		bool flag6 = (nint)0 == 0;
		buttonText = obj6;
		if (!flag6)
		{
			goto IL_00f8;
		}
		goto IL_021d;
		IL_021d:
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v77 @ X0_v13+E4]");
		bool flag7 = (nint)0 == 0;
		object obj15 = !flag7;
		if (obj15 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			object obj16 = obj;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v95 @ X8_v28+B8]");
			obj7 = 0;
		}
		goto IL_054a;
		IL_0488:
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @B0D070");
		Cpp2ILHelpers.NoteDecompilerIssue("Indirect jump: [v389 @ X0_v7] (should have been resolved before IL gen)");
		goto IL_049c;
		IL_00f8:
		PopupWindowBuilder popupWindowBuilder = PopupWindowBuilder.CreateError(action, (string)obj6);
		bool flag8 = popupWindowBuilder == null;
		object obj17 = !flag8;
		if (obj17 != null)
		{
			goto IL_02ab;
		}
		goto IL_04f1;
		IL_04f1:
		ex = new NullReferenceException();
		goto IL_04ff;
		IL_04ff:
		object obj18 = obj12 + 9;
		object obj19 = num + obj18;
		object obj20 = obj19 + 312;
		object obj21 = obj20;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v252 @ X8_v4+8]");
		object obj22 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Indirect jump: v253 @ X2_v2 (should have been resolved before IL gen)");
		goto IL_054a;
		IL_054a:
		object obj23 = typeof(SqlSingle[]) + 2376;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
		object obj24 = (nint)0 + (nint)200;
		Action action2 = default(Action);
		action2..ctor(obj7, (IntPtr)obj24);
		num = (nint)obj;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v246 @ X8_v2 (Il2CppClass<System.NullReferenceException>)+B8]");
		object obj25 = (nint)0 + (nint)16;
		obj25 = action2;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
		popupWindowBuilder = PopupWindowBuilder.CreateError(action2, (string)buttonText);
		bool flag9 = popupWindowBuilder == null;
		object obj26 = 0;
		if (!flag9)
		{
			goto IL_02ab;
		}
		goto IL_04f1;
		IL_02ab:
		num = (nint)("Drop Menu Toggle" + 3600);
		IPopupWindowBuilderNeedsBody popupWindowBuilderNeedsBody = popupWindowBuilder.Titled((string)num);
		if (popupWindowBuilderNeedsBody != null)
		{
			object obj27 = typeof(System.IOAsyncCallback) + 384;
			object obj28 = "Error reading data from socket: " + 3320;
			num3 = (nint)popupWindowBuilderNeedsBody;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v266 @ X8_v11 (Il2CppClass<IPopupWindowBuilderNeedsBody>)+12E]");
			object obj29 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v266 @ X8_v11 (Il2CppClass<IPopupWindowBuilderNeedsBody>)+12E]");
			if ((nint)0 == 0)
			{
				goto IL_03a7;
			}
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v266 @ X8_v11 (Il2CppClass<IPopupWindowBuilderNeedsBody>)+B0]");
			obj10 = (nint)0 + (nint)8;
			while (true)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v174 @ X10_v12-8]");
				if (0 == (nint)obj27)
				{
					break;
				}
				obj12 = obj10 + 16;
				obj29--;
				bool flag10 = (nint)obj29 != 1;
				obj10 = obj12;
				if (flag10)
				{
					continue;
				}
				goto IL_03a7;
			}
			goto IL_049c;
		}
		goto IL_04f1;
	}

	public unsafe static void ShowForceStartWarning(List<QueuePlayer> missingPlayers, Action startAction)
	{
		//IL_000c: Expected O, but got I
		//IL_001b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0020: Expected O, but got Unknown
		//IL_09eb: Unknown result type (might be due to invalid IL or missing references)
		//IL_09f0: Expected O, but got Unknown
		//IL_00e4: Expected O, but got I
		//IL_0104: Expected O, but got I
		//IL_012e: Expected O, but got I4
		//IL_0146: Expected O, but got I
		//IL_0031: Expected O, but got I
		//IL_0051: Expected O, but got I
		//IL_007b: Expected O, but got I4
		//IL_0196: Expected O, but got I4
		//IL_0990: Unknown result type (might be due to invalid IL or missing references)
		//IL_0995: Expected O, but got Unknown
		//IL_099d: Unknown result type (might be due to invalid IL or missing references)
		//IL_09a2: Expected O, but got Unknown
		//IL_09ab: Unknown result type (might be due to invalid IL or missing references)
		//IL_09b0: Expected O, but got Unknown
		//IL_0a86: Unknown result type (might be due to invalid IL or missing references)
		//IL_0a8b: Expected O, but got Unknown
		//IL_0aa1: Expected O, but got I
		//IL_0ab2: Expected I, but got O
		//IL_0ab2: Expected O, but got I
		//IL_0aba: Expected I, but got O
		//IL_0ad0: Expected O, but got I
		//IL_00a1: Expected O, but got I
		//IL_023a: Unknown result type (might be due to invalid IL or missing references)
		//IL_023f: Expected I4, but got Unknown
		//IL_0251: Expected O, but got I4
		//IL_027a: Unknown result type (might be due to invalid IL or missing references)
		//IL_027f: Expected O, but got Unknown
		//IL_0289: Unknown result type (might be due to invalid IL or missing references)
		//IL_028e: Expected O, but got Unknown
		//IL_029d: Unknown result type (might be due to invalid IL or missing references)
		//IL_02a2: Expected O, but got Unknown
		//IL_02aa: Expected I, but got O
		//IL_02ba: Expected O, but got I
		//IL_02f5: Expected O, but got I
		//IL_0394: Expected O, but got Ref
		//IL_035d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0362: Expected O, but got Unknown
		//IL_036b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0370: Expected O, but got Unknown
		//IL_0303: Unknown result type (might be due to invalid IL or missing references)
		//IL_0308: Expected O, but got Unknown
		//IL_0311: Unknown result type (might be due to invalid IL or missing references)
		//IL_0316: Expected O, but got Unknown
		//IL_03aa: Expected I, but got O
		//IL_03ba: Expected O, but got I
		//IL_03e3: Expected O, but got I
		//IL_0419: Unknown result type (might be due to invalid IL or missing references)
		//IL_041e: Expected O, but got Unknown
		//IL_04c2: Expected O, but got I8
		//IL_045d: Expected I, but got O
		//IL_046d: Expected O, but got I
		//IL_0496: Expected O, but got I
		//IL_04e9: Unknown result type (might be due to invalid IL or missing references)
		//IL_04ee: Expected O, but got Unknown
		//IL_04f7: Unknown result type (might be due to invalid IL or missing references)
		//IL_04fc: Expected O, but got Unknown
		//IL_0559: Unknown result type (might be due to invalid IL or missing references)
		//IL_055e: Expected O, but got Unknown
		//IL_0568: Unknown result type (might be due to invalid IL or missing references)
		//IL_056d: Expected O, but got Unknown
		//IL_0585: Expected O, but got I
		//IL_0bc5: Expected I, but got O
		//IL_05c0: Expected O, but got I
		//IL_065d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0662: Expected O, but got Unknown
		//IL_066c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0671: Expected O, but got Unknown
		//IL_0689: Expected O, but got I
		//IL_0621: Unknown result type (might be due to invalid IL or missing references)
		//IL_0626: Expected O, but got Unknown
		//IL_063c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0641: Expected O, but got Unknown
		//IL_05ce: Unknown result type (might be due to invalid IL or missing references)
		//IL_05d3: Expected O, but got Unknown
		//IL_05dc: Unknown result type (might be due to invalid IL or missing references)
		//IL_05e1: Expected O, but got Unknown
		//IL_0c39: Expected I, but got O
		//IL_06c4: Expected O, but got I
		//IL_075c: Expected O, but got I
		//IL_0732: Unknown result type (might be due to invalid IL or missing references)
		//IL_0737: Expected O, but got Unknown
		//IL_07f2: Expected I, but got O
		//IL_06d2: Unknown result type (might be due to invalid IL or missing references)
		//IL_06d7: Expected O, but got Unknown
		//IL_06e0: Unknown result type (might be due to invalid IL or missing references)
		//IL_06e5: Expected O, but got Unknown
		//IL_0797: Expected O, but got I
		//IL_0846: Expected I, but got O
		//IL_0856: Expected O, but got I
		//IL_090d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0912: Expected O, but got Unknown
		//IL_091a: Expected I, but got O
		//IL_094e: Expected O, but got I4
		//IL_0891: Expected O, but got I
		//IL_07a5: Unknown result type (might be due to invalid IL or missing references)
		//IL_07aa: Expected O, but got Unknown
		//IL_07b3: Unknown result type (might be due to invalid IL or missing references)
		//IL_07b8: Expected O, but got Unknown
		//IL_089f: Unknown result type (might be due to invalid IL or missing references)
		//IL_08a4: Expected O, but got Unknown
		//IL_08ad: Unknown result type (might be due to invalid IL or missing references)
		//IL_08b2: Expected O, but got Unknown
		object obj = (nint)0 + (nint)888;
		object obj2 = typeof(SkeletonBinary.SkeletonInput) + 3776;
		object obj3 = "{0} color encoding is currently unsupported for outputting to HDR." + 2176;
		IEnumerable<object> enumerable = Enumerable.Take((IEnumerable<object>)missingPlayers, 9);
		object obj4 = obj2;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v126 @ X0_v74+E4]");
		nint num;
		Func<object, object> selector;
		string separator;
		object obj7;
		IEnumerable<object> enumerable2;
		string text;
		nint num2;
		object obj5;
		IEnumerable<object> source;
		if ((nint)0 != 0)
		{
			obj5 = (nint)0 + (nint)3904;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v126 @ X0_v74+B8]");
			num = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v372 @ X8_v6 (Il2CppClass<System.NullReferenceException>)+18]");
			selector = (Func<object, object>)0;
			separator = (string)obj3;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v372 @ X8_v6 (Il2CppClass<System.NullReferenceException>)+18]");
			bool flag = (nint)0 == 0;
			object obj6 = !flag;
			source = enumerable;
			if (obj6 == null)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v372 @ X8_v6 (Il2CppClass<System.NullReferenceException>)+18]");
				Func<object, object> func = (Func<object, object>)0;
				obj7 = obj5;
				enumerable2 = enumerable;
				text = (string)obj3;
				num2 = num;
				goto IL_0174;
			}
		}
		else
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			obj4 = obj2;
			obj7 = (nint)0 + (nint)3904;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v126 @ X0_v74+B8]");
			num2 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v139 @ X8_v51 (Il2CppClass<System.NullReferenceException>)+18]");
			Func<object, object> func = (Func<object, object>)0;
			text = (string)obj3;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v139 @ X8_v51 (Il2CppClass<System.NullReferenceException>)+18]");
			bool flag2 = (nint)0 == 0;
			object obj8 = !flag2;
			enumerable2 = enumerable;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v139 @ X8_v51 (Il2CppClass<System.NullReferenceException>)+18]");
			selector = (Func<object, object>)0;
			obj5 = obj7;
			source = enumerable;
			separator = (string)obj3;
			num = num2;
			if (obj8 == null)
			{
				goto IL_0174;
			}
		}
		goto IL_0a2f;
		IL_0b3e:
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v558 @ X8_v15+8]");
		bool flag3 = false;
		Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v558 @ X8_v15] (should have been resolved before IL gen)");
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC18B4");
		num = 153101312;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC195C");
		object[] array = default(object[]);
		if (array == null)
		{
			goto IL_0979;
		}
		object obj9 = default(object);
		bool flag4 = obj9 == null;
		int num3 = default(int);
		object obj10 = (object)(&num3);
		IndexOutOfRangeException ex = default(IndexOutOfRangeException);
		object obj11;
		if (!flag4)
		{
			nint num4 = (nint)array;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v576 @ X8_v43 (Il2CppClass<System.Object[]>)+40]");
			obj10 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1958");
			bool flag5 = ex == null;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v576 @ X8_v43 (Il2CppClass<System.Object[]>)+40]");
			obj11 = 0;
			if (flag5)
			{
				goto IL_09cb;
			}
		}
		string text2;
		object label;
		object obj20 = default(object);
		object obj23 = default(object);
		if (array.Length != 0)
		{
			object obj12 = array + 32;
			obj12 = obj9;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
			bool flag6 = text2 == null;
			obj10 = obj9;
			if (!flag6)
			{
				nint num5 = (nint)array;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v608 @ X8_v42 (Il2CppClass<System.Object[]>)+40]");
				obj10 = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1958");
				bool flag7 = ex == null;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v608 @ X8_v42 (Il2CppClass<System.Object[]>)+40]");
				obj11 = 0;
				if (flag7)
				{
					goto IL_09cb;
				}
			}
			num = array.Length;
			object obj13 = array.Length & 0xFFFFFFFEL;
			if (obj13 != null)
			{
				object text3 = "{0} color encoding is currently unsupported for outputting to HDR." + 264;
				object obj14 = array + 40;
				obj14 = text2;
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
				LocalizableText localizableText = TextMeshProExtensions.LocalizeWith((string)text3, array);
				object obj15 = default(object);
				bool flag8 = obj15 == null;
				flag3 = false;
				if (flag8)
				{
					goto IL_0979;
				}
				object obj16 = typeof(System.IOAsyncCallback) + 384;
				label = "AvailableVoices" + 768;
				object obj17 = obj15;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v625 @ X8_v27+12E]");
				object obj18 = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v625 @ X8_v27+12E]");
				if ((nint)0 == 0)
				{
					goto IL_0609;
				}
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v625 @ X8_v27+B0]");
				object obj19 = (nint)0 + (nint)8;
				while (true)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v658 @ X10_v26-8]");
					if (0 == (nint)obj16)
					{
						break;
					}
					obj20 = obj19 + 16;
					obj18--;
					bool flag9 = (nint)obj18 != 1;
					obj19 = obj20;
					if (flag9)
					{
						continue;
					}
					goto IL_0609;
				}
				object obj21 = obj19 + 1;
				object obj22 = obj17 + obj21;
				obj23 = obj22 + 312;
				obj20 = obj19;
				goto IL_0bbd;
			}
		}
		ex = new IndexOutOfRangeException();
		obj11 = obj10;
		goto IL_09cb;
		IL_033e:
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @B0D070");
		object obj25 = default(object);
		object obj24 = obj25;
		goto IL_0b3e;
		IL_07e0:
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @B0D070");
		object obj26 = default(object);
		num = (nint)obj26;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v778 @ X0_v53+8]");
		bool flag10 = false;
		Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v778 @ X0_v53] (should have been resolved before IL gen)");
		NullReferenceException ex2 = default(NullReferenceException);
		bool flag11 = ex2 == null;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v778 @ X0_v53+8]");
		flag3 = false;
		source = null;
		if (!flag11)
		{
			goto IL_083e;
		}
		goto IL_0979;
		IL_0174:
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v126 @ X0_v74+E4]");
		bool flag12 = (nint)0 == 0;
		object obj27 = !flag12;
		if (obj27 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			object obj28 = obj2;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v149 @ X8_v57+B8]");
			num2 = 0;
		}
		object obj29 = typeof(Func<AndroidJavaObject, IList<HWLocation>>) + 3008;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
		object obj30 = (nint)0 + (nint)184;
		Func<object, object> func2 = default(Func<object, object>);
		func2..ctor((object)num2, (IntPtr)obj30);
		num = (nint)obj2;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v372 @ X8_v6 (Il2CppClass<System.NullReferenceException>)+B8]");
		object obj31 = (nint)0 + (nint)24;
		obj31 = func2;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
		selector = func2;
		obj5 = obj7;
		source = enumerable2;
		separator = text;
		goto IL_0a2f;
		IL_0cd9:
		Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v419 @ X8_v5] (should have been resolved before IL gen)");
		return;
		IL_070d:
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @B0D070");
		goto IL_0c31;
		IL_0a2f:
		IEnumerable<object> values = Enumerable.Select(source, selector);
		string text4 = string.Join(separator, (IEnumerable<string>)values);
		bool flag13 = missingPlayers == null;
		flag3 = false;
		if (!flag13)
		{
			int num6 = missingPlayers._size;
			bool flag14 = missingPlayers._size < 10;
			flag3 = false;
			text2 = text4;
			if (!flag14)
			{
				num6 = (int)(", stale={0}" + 1624);
				string text5 = text4 + (string)((int*)num6)->m_value;
				flag3 = false;
				text2 = text5;
			}
			IPopupWindowBuilderNeedsTitle popupWindowBuilderNeedsTitle = PopupWindowBuilder.Create(PopupWindow.MessageType.Action);
			bool flag15 = popupWindowBuilderNeedsTitle == null;
			num = num6;
			if (!flag15)
			{
				object obj32 = typeof(System.IOAsyncCallback) + 392;
				object obj33 = "Unsupported map type" + 3592;
				object obj34 = typeof(TypeConverter<ushort, char>) + 3400;
				nint num7 = (nint)popupWindowBuilderNeedsTitle;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v448 @ X8_v14 (Il2CppClass<IPopupWindowBuilderNeedsTitle>)+12E]");
				object obj35 = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v448 @ X8_v14 (Il2CppClass<IPopupWindowBuilderNeedsTitle>)+12E]");
				if ((nint)0 == 0)
				{
					goto IL_033e;
				}
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v448 @ X8_v14 (Il2CppClass<IPopupWindowBuilderNeedsTitle>)+B0]");
				object obj36 = (nint)0 + (nint)8;
				while (true)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v525 @ X10_v31-8]");
					if (0 == (nint)obj32)
					{
						break;
					}
					obj20 = obj36 + 16;
					obj35--;
					bool flag16 = (nint)obj35 != 1;
					obj36 = obj20;
					if (flag16)
					{
						continue;
					}
					goto IL_033e;
				}
				object obj37 = num7 + obj36;
				obj24 = obj37 + 312;
				obj20 = obj36;
				goto IL_0b3e;
			}
		}
		goto IL_0979;
		IL_0609:
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @B0D070");
		goto IL_0bbd;
		IL_0bbd:
		num = (nint)obj23;
		Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v684 @ X0_v39] (should have been resolved before IL gen)");
		PopupButton popupButton = PopupButton.Neutral((string)label, null, dismiss: true);
		object obj38 = default(object);
		bool flag17 = obj38 == null;
		flag3 = true;
		source = null;
		if (flag17)
		{
			goto IL_0979;
		}
		object obj39 = typeof(System.IOAsyncCallback) + 368;
		object label2 = "SetRoomVariables request error" + 2624;
		object obj40 = obj38;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v694 @ X8_v30+12E]");
		object obj41 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v694 @ X8_v30+12E]");
		if ((nint)0 == 0)
		{
			goto IL_070d;
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v694 @ X8_v30+B0]");
		object obj42 = (nint)0 + (nint)8;
		while (true)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v727 @ X10_v21-8]");
			if (0 == (nint)obj39)
			{
				break;
			}
			obj20 = obj42 + 16;
			obj41--;
			bool flag18 = (nint)obj41 != 1;
			obj42 = obj20;
			if (flag18)
			{
				continue;
			}
			goto IL_070d;
		}
		object obj43 = obj40 + obj42;
		object obj44 = obj43 + 312;
		obj20 = obj42;
		goto IL_0c31;
		IL_0c31:
		num = (nint)obj44;
		Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v752 @ X0_v44] (should have been resolved before IL gen)");
		PopupButton popupButton2 = PopupButton.Neutral((string)label2, startAction, dismiss: true);
		object obj45 = default(object);
		bool flag19 = obj45 == null;
		flag3 = true;
		source = null;
		if (!flag19)
		{
			object obj46 = obj45;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v760 @ X8_v33+12E]");
			object obj47 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v760 @ X8_v33+12E]");
			if ((nint)0 == 0)
			{
				goto IL_07e0;
			}
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v760 @ X8_v33+B0]");
			object obj48 = (nint)0 + (nint)8;
			while (true)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v178 @ X10_v16-8]");
				if (0 == (nint)obj39)
				{
					break;
				}
				obj20 = obj48 + 16;
				obj47--;
				bool flag20 = (nint)obj47 != 1;
				obj48 = obj20;
				if (flag20)
				{
					continue;
				}
				goto IL_07e0;
			}
			object obj49 = obj46 + obj48;
			object obj50 = obj49 + 312;
			num = (nint)obj50;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v793 @ X0_v56+8]");
			flag10 = false;
			Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v793 @ X0_v56] (should have been resolved before IL gen)");
			bool flag21 = ex2 == null;
			object obj51 = !flag21;
			obj20 = obj48;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v793 @ X0_v56+8]");
			flag3 = false;
			source = null;
			if (obj51 != null)
			{
				goto IL_083e;
			}
		}
		goto IL_0979;
		IL_0987:
		object obj52 = obj20 + 9;
		object obj53 = num + obj52;
		object obj54 = obj53 + 312;
		goto IL_0cd9;
		IL_09cb:
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1ABC");
		throw new OutOfMemoryException();
		IL_0979:
		ex2 = new NullReferenceException();
		goto IL_0987;
		IL_08d2:
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @B0D070");
		flag3 = true;
		source = null;
		object obj55 = default(object);
		obj54 = obj55;
		goto IL_0cd9;
		IL_083e:
		num = (nint)ex2;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v372 @ X8_v6 (Il2CppClass<System.NullReferenceException>)+12E]");
		object obj56 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v372 @ X8_v6 (Il2CppClass<System.NullReferenceException>)+12E]");
		if ((nint)0 == 0)
		{
			goto IL_08d2;
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v372 @ X8_v6 (Il2CppClass<System.NullReferenceException>)+B0]");
		obj20 = (nint)0 + (nint)8;
		while (true)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v183 @ X10_v13-8]");
			bool flag22 = 0 == (nint)obj39;
			flag3 = flag10;
			source = null;
			if (flag22)
			{
				break;
			}
			obj20 += 16;
			obj56--;
			if ((nint)obj56 != 1)
			{
				continue;
			}
			goto IL_08d2;
		}
		goto IL_0987;
	}

	public static void ShowNotEnoughParticipantsWarning()
	{
		//IL_000f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0014: Expected O, but got Unknown
		//IL_0045: Unknown result type (might be due to invalid IL or missing references)
		//IL_004a: Expected O, but got Unknown
		//IL_0054: Unknown result type (might be due to invalid IL or missing references)
		//IL_0059: Expected O, but got Unknown
		//IL_0063: Unknown result type (might be due to invalid IL or missing references)
		//IL_0068: Expected O, but got Unknown
		//IL_0092: Expected O, but got I4
		object obj = typeof(System.Buffers.Text.ParserHelpers) + 1432;
		object title = "Unsupported map type" + 3592;
		object message = "startPosition" + 4072;
		object buttonText = "Network Authentication Required" + 3128;
		object obj2 = obj;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v50 @ X0_v2+E4]");
		bool flag = (nint)0 == 0;
		object obj3 = !flag;
		if (obj3 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		}
		PopupWindow.ShowError((string)title, (string)message, (string)buttonText);
	}

	public static void ShowNotEnoughTeamsAssignedWarning()
	{
		//IL_000f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0014: Expected O, but got Unknown
		//IL_0045: Unknown result type (might be due to invalid IL or missing references)
		//IL_004a: Expected O, but got Unknown
		//IL_0054: Unknown result type (might be due to invalid IL or missing references)
		//IL_0059: Expected O, but got Unknown
		//IL_0063: Unknown result type (might be due to invalid IL or missing references)
		//IL_0068: Expected O, but got Unknown
		//IL_0092: Expected O, but got I4
		object obj = typeof(System.Buffers.Text.ParserHelpers) + 1432;
		object title = "Unsupported map type" + 3592;
		object message = "startPosition" + 4080;
		object buttonText = "Network Authentication Required" + 3128;
		object obj2 = obj;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v50 @ X0_v2+E4]");
		bool flag = (nint)0 == 0;
		object obj3 = !flag;
		if (obj3 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		}
		PopupWindow.ShowError((string)title, (string)message, (string)buttonText);
	}

	public static void ShowConflictPopup(GameObject lifecycle, TournamentsEventsChannel eventsChannel, TournamentData tournament, int otherTournamentRoomId, string otherTournamentName, DateTime otherTournamentTime, Action retryAction)
	{
		//IL_001f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0024: Expected O, but got Unknown
		//IL_0ae1: Unknown result type (might be due to invalid IL or missing references)
		//IL_0ae6: Expected O, but got Unknown
		//IL_0aee: Unknown result type (might be due to invalid IL or missing references)
		//IL_0af3: Expected O, but got Unknown
		//IL_0afc: Unknown result type (might be due to invalid IL or missing references)
		//IL_0b01: Expected O, but got Unknown
		//IL_0032: Unknown result type (might be due to invalid IL or missing references)
		//IL_0037: Expected O, but got Unknown
		//IL_0052: Unknown result type (might be due to invalid IL or missing references)
		//IL_0057: Expected O, but got Unknown
		//IL_0d5c: Expected O, but got I
		//IL_0077: Unknown result type (might be due to invalid IL or missing references)
		//IL_007c: Expected O, but got Unknown
		//IL_00bf: Unknown result type (might be due to invalid IL or missing references)
		//IL_00c4: Expected O, but got Unknown
		//IL_00ce: Unknown result type (might be due to invalid IL or missing references)
		//IL_00d3: Expected O, but got Unknown
		//IL_00dd: Unknown result type (might be due to invalid IL or missing references)
		//IL_00e2: Expected O, but got Unknown
		//IL_00f1: Unknown result type (might be due to invalid IL or missing references)
		//IL_00f6: Expected O, but got Unknown
		//IL_0120: Expected O, but got I4
		//IL_016d: Expected O, but got I4
		//IL_024b: Expected O, but got I4
		//IL_01c1: Expected O, but got I4
		//IL_01ca: Expected O, but got I4
		//IL_0200: Expected O, but got I4
		//IL_0268: Unknown result type (might be due to invalid IL or missing references)
		//IL_026d: Expected O, but got Unknown
		//IL_02a7: Expected O, but got I4
		//IL_0318: Unknown result type (might be due to invalid IL or missing references)
		//IL_031d: Expected O, but got Unknown
		//IL_0327: Unknown result type (might be due to invalid IL or missing references)
		//IL_032c: Expected O, but got Unknown
		//IL_033b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0340: Expected O, but got Unknown
		//IL_0348: Expected I, but got O
		//IL_0358: Expected O, but got I
		//IL_0393: Expected O, but got I
		//IL_0433: Expected O, but got I4
		//IL_03fb: Unknown result type (might be due to invalid IL or missing references)
		//IL_0400: Expected O, but got Unknown
		//IL_0409: Unknown result type (might be due to invalid IL or missing references)
		//IL_040e: Expected I, but got Unknown
		//IL_03a1: Unknown result type (might be due to invalid IL or missing references)
		//IL_03a6: Expected O, but got Unknown
		//IL_03af: Unknown result type (might be due to invalid IL or missing references)
		//IL_03b4: Expected O, but got Unknown
		//IL_0449: Expected I, but got O
		//IL_0459: Expected O, but got I
		//IL_0482: Expected O, but got I
		//IL_04c2: Unknown result type (might be due to invalid IL or missing references)
		//IL_04c7: Expected O, but got Unknown
		//IL_051b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0520: Expected O, but got Unknown
		//IL_0538: Expected O, but got I
		//IL_05ce: Expected I, but got O
		//IL_05de: Expected O, but got I
		//IL_0602: Expected O, but got I4
		//IL_069c: Unknown result type (might be due to invalid IL or missing references)
		//IL_06a1: Expected O, but got Unknown
		//IL_06b0: Unknown result type (might be due to invalid IL or missing references)
		//IL_06b5: Expected O, but got Unknown
		//IL_06c1: Expected O, but got I
		//IL_06cb: Unknown result type (might be due to invalid IL or missing references)
		//IL_06d0: Expected O, but got Unknown
		//IL_06e8: Expected O, but got I
		//IL_0573: Expected O, but got I
		//IL_077f: Expected O, but got I4
		//IL_0c61: Expected I, but got O
		//IL_0723: Expected O, but got I
		//IL_0626: Unknown result type (might be due to invalid IL or missing references)
		//IL_062b: Expected O, but got Unknown
		//IL_0641: Unknown result type (might be due to invalid IL or missing references)
		//IL_0646: Expected O, but got Unknown
		//IL_064e: Expected I, but got O
		//IL_065e: Expected O, but got I
		//IL_0581: Unknown result type (might be due to invalid IL or missing references)
		//IL_0586: Expected O, but got Unknown
		//IL_058f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0594: Expected O, but got Unknown
		//IL_0795: Unknown result type (might be due to invalid IL or missing references)
		//IL_079a: Expected O, but got Unknown
		//IL_07b0: Unknown result type (might be due to invalid IL or missing references)
		//IL_07b5: Expected I, but got Unknown
		//IL_07fa: Unknown result type (might be due to invalid IL or missing references)
		//IL_07ff: Expected O, but got Unknown
		//IL_0817: Expected O, but got I
		//IL_0731: Unknown result type (might be due to invalid IL or missing references)
		//IL_0736: Expected O, but got Unknown
		//IL_073f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0744: Expected O, but got Unknown
		//IL_0ca8: Expected I, but got O
		//IL_0852: Expected O, but got I
		//IL_08ea: Expected O, but got I
		//IL_08c0: Unknown result type (might be due to invalid IL or missing references)
		//IL_08c5: Expected O, but got Unknown
		//IL_0980: Expected I, but got O
		//IL_0860: Unknown result type (might be due to invalid IL or missing references)
		//IL_0865: Expected O, but got Unknown
		//IL_086e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0873: Expected O, but got Unknown
		//IL_0925: Expected O, but got I
		//IL_09c0: Expected I, but got O
		//IL_09d0: Expected O, but got I
		//IL_0a82: Unknown result type (might be due to invalid IL or missing references)
		//IL_0a87: Expected O, but got Unknown
		//IL_0a8f: Expected I, but got O
		//IL_0ab3: Expected O, but got I4
		//IL_0a0b: Expected O, but got I
		//IL_0933: Unknown result type (might be due to invalid IL or missing references)
		//IL_0938: Expected O, but got Unknown
		//IL_0941: Unknown result type (might be due to invalid IL or missing references)
		//IL_0946: Expected O, but got Unknown
		//IL_0a19: Unknown result type (might be due to invalid IL or missing references)
		//IL_0a1e: Expected O, but got Unknown
		//IL_0a27: Unknown result type (might be due to invalid IL or missing references)
		//IL_0a2c: Expected O, but got Unknown
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [91E6E90]");
		nint num = 0;
		object obj = typeof(SkeletonBinary.SkeletonInput) + 3792;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
		object obj2 = default(object);
		obj2..ctor();
		object text;
		IPopupWindowBuilderNeedsTitle popupWindowBuilderNeedsTitle;
		string text3;
		if (obj2 != null)
		{
			object obj3 = obj2 + 16;
			obj3 = lifecycle;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
			object obj4 = obj2 + 24;
			obj4 = eventsChannel;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
			object obj5 = obj2 + 40;
			obj5 = retryAction;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
			if (tournament != null)
			{
				object obj6 = typeof(DataRelation) + 712;
				object obj7 = "destinationTimeZone" + 2736;
				object obj8 = "destinationTimeZone" + 2728;
				object obj9 = typeof(System.Formats.Asn1.SetOfValueComparer) + 2504;
				object obj10 = obj6;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v450 @ X0_v17+E4]");
				bool flag = (nint)0 == 0;
				object obj11 = !flag;
				if (obj11 == null)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
				}
				bool flag2 = tournament.<StartingTime>k__BackingField > otherTournamentTime;
				bool flag3 = !flag2;
				object obj12 = !flag3;
				object obj13 = ~obj12;
				text = ((obj13 != null) ? obj8 : obj7);
				object obj14 = obj9;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v475 @ X0_v21+E4]");
				num = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v475 @ X0_v21+E4]");
				if ((nint)0 != 0)
				{
					bool flag4 = StringUtil.IsEnglishText(otherTournamentName);
					bool flag5 = !flag4;
					object obj15 = !flag5;
					object obj16 = 0;
					if (obj15 == null)
					{
						goto IL_01d8;
					}
				}
				else
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
					bool flag6 = StringUtil.IsEnglishText(otherTournamentName);
					bool flag7 = !flag6;
					object obj16 = 0;
					if (flag7)
					{
						goto IL_01d8;
					}
				}
				object obj17 = typeof(System.Formats.Asn1.SetOfValueComparer) + 2536;
				object obj18 = obj17;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v504 @ X0_v76+E4]");
				num = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v504 @ X0_v76+E4]");
				bool flag8 = (nint)0 == 0;
				object obj19 = !flag8;
				if (obj19 == null)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
				}
				string text2 = StringsExtensions.Reverse(otherTournamentName);
				popupWindowBuilderNeedsTitle = PopupWindowBuilder.Create(PopupWindow.MessageType.Error);
				bool flag9 = popupWindowBuilderNeedsTitle == null;
				text3 = text2;
				if (!flag9)
				{
					goto IL_0309;
				}
			}
		}
		goto IL_0aca;
		IL_09b8:
		NullReferenceException ex = default(NullReferenceException);
		num = (nint)ex;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v330 @ X8_v4 (Il2CppClass<System.NullReferenceException>)+12E]");
		object obj20 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v330 @ X8_v4 (Il2CppClass<System.NullReferenceException>)+12E]");
		if ((nint)0 == 0)
		{
			goto IL_0a4c;
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v330 @ X8_v4 (Il2CppClass<System.NullReferenceException>)+B0]");
		object obj21 = (nint)0 + (nint)8;
		object obj22;
		int num2;
		while (true)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v97 @ X10_v29-8]");
			bool flag10 = 0 == (nint)obj22;
			num2 = 0;
			if (flag10)
			{
				break;
			}
			obj21 += 16;
			obj20--;
			if ((nint)obj20 != 1)
			{
				continue;
			}
			goto IL_0a4c;
		}
		goto IL_0ad8;
		IL_03dc:
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @B0D070");
		IntPtr intPtr = default(IntPtr);
		num = intPtr;
		goto IL_0bc3;
		IL_068d:
		obj22 = typeof(System.IOAsyncCallback) + 368;
		object obj23 = typeof(SqlSingle[]) + 2376;
		object obj24 = (nint)0 + (nint)216;
		object label = "fetch_products" + 1056;
		object obj26 = default(object);
		object obj25 = obj26;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v673 @ X8_v25+12E]");
		object obj27 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v673 @ X8_v25+12E]");
		if ((nint)0 == 0)
		{
			goto IL_076c;
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v673 @ X8_v25+B0]");
		object obj28 = (nint)0 + (nint)8;
		object obj29;
		while (true)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v706 @ X10_v27-8]");
			if (0 == (nint)obj22)
			{
				break;
			}
			obj29 = obj28 + 16;
			obj27--;
			bool flag11 = (nint)obj27 != 1;
			obj28 = obj29;
			if (flag11)
			{
				continue;
			}
			goto IL_076c;
		}
		object obj30 = obj28 + 4;
		object obj31 = obj25 + obj30;
		num = (nint)(obj31 + 312);
		obj29 = obj28;
		goto IL_0c3c;
		IL_0bc3:
		Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v330 @ X8_v4 (Il2CppClass<System.NullReferenceException>)] (should have been resolved before IL gen)");
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC18B4");
		object[] array = default(object[]);
		object obj42;
		if (array != null)
		{
			bool flag12 = text3 == null;
			object obj32 = 1;
			if (!flag12)
			{
				nint num3 = (nint)array;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v591 @ X8_v44 (Il2CppClass<System.Object[]>)+40]");
				obj32 = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1958");
				IndexOutOfRangeException ex2 = default(IndexOutOfRangeException);
				bool flag13 = ex2 == null;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v591 @ X8_v44 (Il2CppClass<System.Object[]>)+40]");
				object obj33 = 0;
				if (flag13)
				{
					goto IL_0b1c;
				}
			}
			num = array.Length;
			if (array.Length == 0)
			{
				IndexOutOfRangeException ex2 = new IndexOutOfRangeException();
				object obj33 = obj32;
				goto IL_0b1c;
			}
			object obj34 = array + 32;
			obj34 = text3;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
			LocalizableText localizableText = TextMeshProExtensions.LocalizeWith((string)text, array);
			object obj35 = default(object);
			if (obj35 != null)
			{
				object obj36 = typeof(System.IOAsyncCallback) + 384;
				object obj37 = obj35;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v613 @ X8_v23+12E]");
				object obj38 = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v613 @ X8_v23+12E]");
				if ((nint)0 == 0)
				{
					goto IL_05bc;
				}
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v613 @ X8_v23+B0]");
				obj29 = (nint)0 + (nint)8;
				while (true)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v101 @ X10_v14-8]");
					if (0 == (nint)obj36)
					{
						break;
					}
					obj21 = obj29 + 16;
					obj38--;
					bool flag14 = (nint)obj38 != 1;
					obj29 = obj21;
					if (flag14)
					{
						continue;
					}
					goto IL_05bc;
				}
				object obj39 = obj29 + 1;
				object obj40 = obj37 + obj39;
				object obj41 = obj40 + 312;
				num = (nint)obj41;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v648 @ X0_v68+8]");
				obj42 = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v648 @ X0_v68] (should have been resolved before IL gen)");
				bool flag15 = obj26 == null;
				obj21 = obj29;
				if (!flag15)
				{
					goto IL_068d;
				}
			}
		}
		goto IL_0aca;
		IL_0a4c:
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @B0D070");
		num2 = 0;
		object obj44 = default(object);
		object obj43 = obj44;
		goto IL_0d44;
		IL_0ad8:
		object obj45 = obj21 + 9;
		object obj46 = num + obj45;
		obj43 = obj46 + 312;
		goto IL_0d44;
		IL_096e:
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @B0D070");
		object obj47 = default(object);
		num = (nint)obj47;
		Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v832 @ X0_v53] (should have been resolved before IL gen)");
		bool flag16 = ex == null;
		num2 = 0;
		obj21 = obj29;
		if (!flag16)
		{
			goto IL_09b8;
		}
		goto IL_0aca;
		IL_076c:
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @B0D070");
		obj42 = 4;
		IntPtr intPtr2 = default(IntPtr);
		num = intPtr2;
		goto IL_0c3c;
		IL_0aca:
		ex = new NullReferenceException();
		goto IL_0ad8;
		IL_0b1c:
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1ABC");
		throw new OutOfMemoryException();
		IL_089b:
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @B0D070");
		goto IL_0ca0;
		IL_0c3c:
		Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v330 @ X8_v4 (Il2CppClass<System.NullReferenceException>)] (should have been resolved before IL gen)");
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
		Action action = default(Action);
		action..ctor(obj2, (IntPtr)obj24);
		PopupButton popupButton = PopupButton.Negative((string)label, action);
		object obj48 = default(object);
		bool flag17 = obj48 == null;
		num2 = 0;
		obj21 = obj29;
		if (flag17)
		{
			goto IL_0aca;
		}
		object label2 = "AvailableVoices" + 768;
		object obj49 = obj48;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v748 @ X8_v27+12E]");
		object obj50 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v748 @ X8_v27+12E]");
		if ((nint)0 == 0)
		{
			goto IL_089b;
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v748 @ X8_v27+B0]");
		object obj51 = (nint)0 + (nint)8;
		while (true)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v781 @ X10_v22-8]");
			if (0 == (nint)obj22)
			{
				break;
			}
			obj29 = obj51 + 16;
			obj50--;
			bool flag18 = (nint)obj50 != 1;
			obj51 = obj29;
			if (flag18)
			{
				continue;
			}
			goto IL_089b;
		}
		object obj52 = obj49 + obj51;
		object obj53 = obj52 + 312;
		obj29 = obj51;
		goto IL_0ca0;
		IL_01d8:
		popupWindowBuilderNeedsTitle = PopupWindowBuilder.Create(PopupWindow.MessageType.Error);
		bool flag19 = popupWindowBuilderNeedsTitle == null;
		object obj54 = !flag19;
		text3 = otherTournamentName;
		if (obj54 != null)
		{
			goto IL_0309;
		}
		goto IL_0aca;
		IL_0309:
		object obj55 = typeof(System.IOAsyncCallback) + 392;
		object obj56 = "Drop Menu Toggle" + 3600;
		object obj57 = typeof(TypeConverter<ushort, char>) + 3400;
		nint num4 = (nint)popupWindowBuilderNeedsTitle;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v524 @ X8_v16 (Il2CppClass<IPopupWindowBuilderNeedsTitle>)+12E]");
		object obj58 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v524 @ X8_v16 (Il2CppClass<IPopupWindowBuilderNeedsTitle>)+12E]");
		if ((nint)0 == 0)
		{
			goto IL_03dc;
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v524 @ X8_v16 (Il2CppClass<IPopupWindowBuilderNeedsTitle>)+B0]");
		object obj59 = (nint)0 + (nint)8;
		while (true)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v558 @ X10_v37-8]");
			if (0 == (nint)obj55)
			{
				break;
			}
			obj21 = obj59 + 16;
			obj58--;
			bool flag20 = (nint)obj58 != 1;
			obj59 = obj21;
			if (flag20)
			{
				continue;
			}
			goto IL_03dc;
		}
		object obj60 = num4 + obj59;
		num = (nint)(obj60 + 312);
		obj21 = obj59;
		goto IL_0bc3;
		IL_0ca0:
		num = (nint)obj53;
		Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v806 @ X0_v44] (should have been resolved before IL gen)");
		PopupButton popupButton2 = PopupButton.Neutral((string)label2, null, dismiss: true);
		object obj61 = default(object);
		bool flag21 = obj61 == null;
		num2 = 0;
		obj21 = obj29;
		if (!flag21)
		{
			object obj62 = obj61;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v814 @ X8_v30+12E]");
			object obj63 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v814 @ X8_v30+12E]");
			if ((nint)0 == 0)
			{
				goto IL_096e;
			}
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v814 @ X8_v30+B0]");
			obj21 = (nint)0 + (nint)8;
			while (true)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v97 @ X10_v29-8]");
				if (0 == (nint)obj22)
				{
					break;
				}
				obj29 = obj21 + 16;
				obj63--;
				bool flag22 = (nint)obj63 != 1;
				obj21 = obj29;
				if (flag22)
				{
					continue;
				}
				goto IL_096e;
			}
			object obj64 = obj62 + obj21;
			object obj65 = obj64 + 312;
			num = (nint)obj65;
			Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v847 @ X0_v56] (should have been resolved before IL gen)");
			bool flag23 = ex == null;
			object obj66 = !flag23;
			num2 = 0;
			if (obj66 != null)
			{
				goto IL_09b8;
			}
		}
		goto IL_0aca;
		IL_0d44:
		object obj67 = obj43;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v380 @ X8_v3+8]");
		object obj68 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Indirect jump: v390 @ X2_v2 (should have been resolved before IL gen)");
		Cpp2ILHelpers.NoteDecompilerIssue("Warning: Method ends with non empty stack (-60), the output could be wrong!");
		/*Error: End of method reached without returning.*/;
		IL_05bc:
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @B0D070");
		object obj69 = default(object);
		num = (nint)obj69;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v631 @ X0_v65+8]");
		obj42 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v631 @ X0_v65] (should have been resolved before IL gen)");
		bool flag24 = obj26 == null;
		object obj70 = !flag24;
		obj29 = obj21;
		if (obj70 != null)
		{
			goto IL_068d;
		}
		goto IL_0aca;
	}

	private static void ForfeitAndRetry(GameObject lifecycle, TournamentsEventsChannel eventsChannel, int otherTournamentRoomId, Action retryAction)
	{
		//IL_000f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0014: Expected O, but got Unknown
		//IL_0028: Unknown result type (might be due to invalid IL or missing references)
		//IL_002d: Expected O, but got Unknown
		//IL_003c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0041: Expected O, but got Unknown
		//IL_004a: Unknown result type (might be due to invalid IL or missing references)
		//IL_004f: Expected O, but got Unknown
		//IL_008b: Expected O, but got I4
		//IL_00b7: Unknown result type (might be due to invalid IL or missing references)
		//IL_00bc: Expected O, but got Unknown
		//IL_00e9: Unknown result type (might be due to invalid IL or missing references)
		//IL_00ee: Expected O, but got Unknown
		//IL_017e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0183: Expected O, but got Unknown
		//IL_011d: Expected O, but got I
		//IL_012e: Expected I, but got O
		object obj = typeof(SkeletonBinary.SkeletonInput) + 3800;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
		object obj2 = default(object);
		obj2..ctor();
		object obj3 = typeof(System.Buffers.Text.ParserHelpers) + 1432;
		object obj4 = typeof(UnityEngine.Purchasing.Telemetry.TelemetryMetricsInstanceWrapper) + 1504;
		object obj5 = obj2 + 16;
		obj5 = retryAction;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
		object obj6 = obj3;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v85 @ X0_v8+E4]");
		bool flag = (nint)0 == 0;
		object obj7 = !flag;
		if (obj7 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		}
		object obj8 = typeof(RankedPlayManager.<>c__DisplayClass36_0) + 2424;
		PopupWindow.ClearError();
		PopupWindow.SetLoading(loading: true);
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
		object obj9 = typeof(ConditionalWeakTable<System.Net.HttpWebRequest, Mono.Http.NtlmSession>.CreateValueCallback) + 3104;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
		Dictionary<System.Int32Enum, object> dictionary = default(Dictionary<System.Int32Enum, object>);
		dictionary..ctor();
		object obj11 = default(object);
		object obj10 = obj11 + 64;
		obj10 = dictionary;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
		obj11..ctor();
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
		object obj12 = (nint)0 + (nint)224;
		SFS.TournamentParticipateSuccess tournamentParticipateSuccess = default(SFS.TournamentParticipateSuccess);
		tournamentParticipateSuccess..ctor(obj2, (IntPtr)obj12);
		TournamentParticipationUtil.Forfeit((TournamentData)obj11, lifecycle, eventsChannel, tournamentParticipateSuccess);
	}
}

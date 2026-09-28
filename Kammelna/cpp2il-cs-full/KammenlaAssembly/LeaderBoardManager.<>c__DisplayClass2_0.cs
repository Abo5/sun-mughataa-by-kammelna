using System;
using System.Buffers.Text;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data.SqlTypes;
using System.Diagnostics;
using System.Formats.Asn1;
using System.Runtime.CompilerServices;
using Cpp2ILInjected;
using Newtonsoft.Json.Linq.JsonPath;
using Server.Models;
using UnityEngine;
using UnityEngine.TextCore;

public static class LeaderBoardManager
{
	private sealed class <>c__DisplayClass2_0
	{
		public ILeaderboardSource source;

		public Action<LeaderboardModel> callback;

		internal void <GetLeaderBoard>g__SuccessCallback|0(LeaderboardModel model)
		{
			//IL_0014: Unknown result type (might be due to invalid IL or missing references)
			//IL_0019: Expected O, but got Unknown
			//IL_0025: Expected O, but got I
			//IL_004f: Expected O, but got I4
			//IL_0094: Unknown result type (might be due to invalid IL or missing references)
			//IL_0099: Expected O, but got Unknown
			//IL_00b1: Expected O, but got I
			//IL_00b9: Expected I, but got O
			//IL_00c9: Expected O, but got I
			//IL_0104: Expected O, but got I
			//IL_018e: Unknown result type (might be due to invalid IL or missing references)
			//IL_0193: Expected O, but got Unknown
			//IL_019c: Unknown result type (might be due to invalid IL or missing references)
			//IL_01a1: Expected O, but got Unknown
			//IL_01c5: Expected O, but got I4
			//IL_0112: Unknown result type (might be due to invalid IL or missing references)
			//IL_0117: Expected O, but got Unknown
			//IL_0120: Unknown result type (might be due to invalid IL or missing references)
			//IL_0125: Expected O, but got Unknown
			object obj = typeof(Newtonsoft.Json.Linq.JsonPath.JPath) + 1688;
			object obj2 = (nint)0 + (nint)512;
			object obj3 = obj;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v58 @ X0_v4+E4]");
			bool flag = (nint)0 == 0;
			object obj4 = !flag;
			if (obj4 == null)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			}
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2EA2AB4");
			ILeaderboardSource leaderboardSource = source;
			object obj5 = typeof(UnityEngine.TextCore.HorizontalAlignment) + 3464;
			object obj6 = obj;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v201 @ X9_v2+B8]");
			object obj7 = 0;
			nint num = (nint)leaderboardSource;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v204 @ X8_v7 (Il2CppClass<ILeaderboardSource>)+12E]");
			object obj8 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v204 @ X8_v7 (Il2CppClass<ILeaderboardSource>)+12E]");
			if ((nint)0 == 0)
			{
				goto IL_0145;
			}
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v204 @ X8_v7 (Il2CppClass<ILeaderboardSource>)+B0]");
			object obj9 = (nint)0 + (nint)8;
			while (true)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v103 @ X10_v6-8]");
				if (0 == (nint)obj5)
				{
					break;
				}
				obj9 += 16;
				obj8--;
				if ((nint)obj8 != 1)
				{
					continue;
				}
				goto IL_0145;
			}
			object obj10 = num + obj9;
			object obj11 = obj10 + 312;
			Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v236 @ X0_v14] (should have been resolved before IL gen)");
			bool flag2 = obj7 == null;
			object obj12 = !flag2;
			if (obj12 == null)
			{
				throw new NullReferenceException();
			}
			goto IL_015e;
			IL_0145:
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @B0D070");
			Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v221 @ X0_v11] (should have been resolved before IL gen)");
			goto IL_015e;
			IL_015e:
			object key = default(object);
			((Dictionary<object, object>)obj7).set_Item(key, (object)model);
			Actions.SafeInvoke((Action<object>)callback, model);
		}

		internal void <GetLeaderBoard>g__UseCacheCallback|1()
		{
			//IL_0014: Unknown result type (might be due to invalid IL or missing references)
			//IL_0019: Expected O, but got Unknown
			//IL_0028: Unknown result type (might be due to invalid IL or missing references)
			//IL_002d: Expected O, but got Unknown
			//IL_0035: Expected I, but got O
			//IL_0045: Expected O, but got I
			//IL_0080: Expected O, but got I
			//IL_016f: Expected O, but got I4
			//IL_0178: Expected O, but got I4
			//IL_0124: Expected O, but got I4
			//IL_00d9: Unknown result type (might be due to invalid IL or missing references)
			//IL_00de: Expected O, but got Unknown
			//IL_00e6: Unknown result type (might be due to invalid IL or missing references)
			//IL_00eb: Expected O, but got Unknown
			//IL_00f4: Unknown result type (might be due to invalid IL or missing references)
			//IL_00f9: Expected O, but got Unknown
			//IL_0196: Unknown result type (might be due to invalid IL or missing references)
			//IL_019b: Expected O, but got Unknown
			//IL_01c5: Expected O, but got I4
			//IL_008e: Unknown result type (might be due to invalid IL or missing references)
			//IL_0093: Expected O, but got Unknown
			//IL_009c: Unknown result type (might be due to invalid IL or missing references)
			//IL_00a1: Expected O, but got Unknown
			//IL_01ee: Expected O, but got I
			//IL_0228: Unknown result type (might be due to invalid IL or missing references)
			//IL_022d: Expected O, but got Unknown
			//IL_0257: Expected O, but got I4
			//IL_028c: Expected O, but got I
			//IL_0294: Expected I, but got O
			//IL_02a4: Expected O, but got I
			//IL_02df: Expected O, but got I
			//IL_0380: Unknown result type (might be due to invalid IL or missing references)
			//IL_0385: Expected O, but got Unknown
			//IL_038e: Unknown result type (might be due to invalid IL or missing references)
			//IL_0393: Expected O, but got Unknown
			//IL_03b7: Expected O, but got I4
			//IL_02ed: Unknown result type (might be due to invalid IL or missing references)
			//IL_02f2: Expected O, but got Unknown
			//IL_02fb: Unknown result type (might be due to invalid IL or missing references)
			//IL_0300: Expected O, but got Unknown
			ILeaderboardSource leaderboardSource = source;
			object obj = typeof(UnityEngine.TextCore.HorizontalAlignment) + 3464;
			object obj2 = typeof(System.Formats.Asn1.SetOfValueComparer) + 2536;
			nint num = (nint)leaderboardSource;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v58 @ X8_v4 (Il2CppClass<ILeaderboardSource>)+12E]");
			object obj3 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v58 @ X8_v4 (Il2CppClass<ILeaderboardSource>)+12E]");
			if ((nint)0 == 0)
			{
				goto IL_00c1;
			}
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v58 @ X8_v4 (Il2CppClass<ILeaderboardSource>)+B0]");
			object obj4 = (nint)0 + (nint)8;
			while (true)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v196 @ X10_v13-8]");
				if (0 == (nint)obj)
				{
					break;
				}
				obj4 += 16;
				obj3--;
				if ((nint)obj3 != 1)
				{
					continue;
				}
				goto IL_00c1;
			}
			object obj5 = obj4 + 8;
			object obj6 = num + obj5;
			object obj7 = obj6 + 312;
			goto IL_03ff;
			IL_0320:
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @B0D070");
			Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v373 @ X0_v22] (should have been resolved before IL gen)");
			goto IL_0339;
			IL_0187:
			object obj8 = typeof(System.ComponentModel.ExtendedPropertyDescriptor) + 488;
			object obj9 = obj8;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v304 @ X0_v12+E4]");
			bool flag = (nint)0 == 0;
			object obj10 = !flag;
			if (obj10 == null)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			}
			object obj11 = (nint)0 + (nint)3376;
			string text = default(string);
			object obj16;
			if (FileUtils.TryLoadObject<object>(text, out var obj12))
			{
				object obj13 = typeof(Newtonsoft.Json.Linq.JsonPath.JPath) + 1688;
				object obj14 = obj13;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v138 @ X0_v17+E4]");
				bool flag2 = (nint)0 == 0;
				object obj15 = !flag2;
				if (obj15 == null)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
					obj14 = obj13;
				}
				ILeaderboardSource leaderboardSource2 = source;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v138 @ X0_v17+B8]");
				obj16 = 0;
				nint num2 = (nint)leaderboardSource2;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v356 @ X8_v17 (Il2CppClass<ILeaderboardSource>)+12E]");
				object obj17 = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v356 @ X8_v17 (Il2CppClass<ILeaderboardSource>)+12E]");
				if ((nint)0 == 0)
				{
					goto IL_0320;
				}
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v356 @ X8_v17 (Il2CppClass<ILeaderboardSource>)+B0]");
				object obj18 = (nint)0 + (nint)8;
				while (true)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v119 @ X10_v8-8]");
					if (0 == (nint)obj)
					{
						break;
					}
					obj18 += 16;
					obj17--;
					if ((nint)obj17 != 1)
					{
						continue;
					}
					goto IL_0320;
				}
				object obj19 = num2 + obj18;
				object obj20 = obj19 + 312;
				Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v388 @ X0_v25] (should have been resolved before IL gen)");
				bool flag3 = obj16 == null;
				object obj21 = !flag3;
				if (obj21 == null)
				{
					throw new NullReferenceException();
				}
				goto IL_0339;
			}
			goto IL_0363;
			IL_0469:
			Action<object> action;
			object arg;
			Actions.SafeInvoke(action, arg);
			return;
			IL_0363:
			action = (Action<object>)callback;
			arg = null;
			goto IL_0469;
			IL_00c1:
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @B0D070");
			goto IL_03ff;
			IL_03ff:
			Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v270 @ X0_v4] (should have been resolved before IL gen)");
			object obj22 = obj2;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v277 @ X0_v7+E4]");
			if ((nint)0 != 0)
			{
				bool flag4 = StringsExtensions.IsNullOrEmpty(text);
				bool flag5 = !flag4;
				object obj23 = 0;
				if (flag5)
				{
					goto IL_0187;
				}
			}
			else
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
				bool flag6 = StringsExtensions.IsNullOrEmpty(text);
				bool flag7 = !flag6;
				object obj24 = !flag7;
				object obj23 = 0;
				if (obj24 == null)
				{
					goto IL_0187;
				}
			}
			goto IL_0363;
			IL_0339:
			object key = default(object);
			((Dictionary<object, object>)obj16).set_Item(key, obj12);
			action = (Action<object>)callback;
			arg = obj12;
			goto IL_0469;
		}

		internal void <GetLeaderBoard>g__ErrorCallback|2(string error)
		{
			//IL_0009: Expected O, but got I4
			//IL_0018: Unknown result type (might be due to invalid IL or missing references)
			//IL_001d: Expected O, but got Unknown
			//IL_0033: Expected O, but got I
			//IL_00ee: Expected O, but got I4
			//IL_00ab: Expected O, but got I4
			//IL_0134: Unknown result type (might be due to invalid IL or missing references)
			//IL_0139: Expected O, but got Unknown
			//IL_0149: Expected O, but got I
			//IL_0151: Expected I, but got O
			//IL_0161: Expected O, but got I
			//IL_019c: Expected O, but got I
			//IL_0223: Unknown result type (might be due to invalid IL or missing references)
			//IL_0228: Expected O, but got Unknown
			//IL_0231: Unknown result type (might be due to invalid IL or missing references)
			//IL_0236: Expected O, but got Unknown
			//IL_025a: Expected O, but got I4
			//IL_01aa: Unknown result type (might be due to invalid IL or missing references)
			//IL_01af: Expected O, but got Unknown
			//IL_01b8: Unknown result type (might be due to invalid IL or missing references)
			//IL_01bd: Expected O, but got Unknown
			object obj = 152985600;
			object obj2 = typeof(Newtonsoft.Json.Linq.JsonPath.JPath) + 1688;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [91E622A]");
			object obj3 = (nint)0 & (nint)1;
			object obj4;
			if (obj3 != null)
			{
				obj4 = obj2;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v59 @ X0_v3+E4]");
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
				obj4 = obj2;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v59 @ X0_v3+E4]");
				bool flag2 = (nint)0 == 0;
				object obj6 = !flag2;
				object obj5 = obj4;
				if (obj6 != null)
				{
					goto IL_0085;
				}
			}
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			obj4 = obj2;
			ILeaderboardSource leaderboardSource = source;
			goto IL_0125;
			IL_01f6:
			object obj7;
			object key = default(object);
			bool flag3 = ((Dictionary<object, object>)obj7).Remove(key);
			Actions.SafeInvoke((Action<object>)callback, null);
			return;
			IL_01dd:
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @B0D070");
			Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v156 @ X0_v9] (should have been resolved before IL gen)");
			goto IL_01f6;
			IL_0268:
			throw new NullReferenceException();
			IL_0085:
			leaderboardSource = source;
			bool flag4 = source == null;
			object obj8 = !flag4;
			if (obj8 != null)
			{
				goto IL_0125;
			}
			goto IL_0268;
			IL_0125:
			object obj9 = typeof(UnityEngine.TextCore.HorizontalAlignment) + 3464;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v59 @ X0_v3+B8]");
			obj7 = 0;
			nint num = (nint)leaderboardSource;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v71 @ X8_v6 (Il2CppClass<ILeaderboardSource>)+12E]");
			object obj10 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v71 @ X8_v6 (Il2CppClass<ILeaderboardSource>)+12E]");
			if ((nint)0 == 0)
			{
				goto IL_01dd;
			}
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v71 @ X8_v6 (Il2CppClass<ILeaderboardSource>)+B0]");
			object obj11 = (nint)0 + (nint)8;
			while (true)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v120 @ X10_v6-8]");
				if (0 == (nint)obj9)
				{
					break;
				}
				obj11 += 16;
				obj10--;
				if ((nint)obj10 != 1)
				{
					continue;
				}
				goto IL_01dd;
			}
			object obj12 = num + obj11;
			object obj13 = obj12 + 312;
			Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v222 @ X0_v12] (should have been resolved before IL gen)");
			bool flag5 = obj7 == null;
			object obj14 = !flag5;
			if (obj14 != null)
			{
				goto IL_01f6;
			}
			goto IL_0268;
		}
	}

	private static readonly Dictionary<string, LeaderboardModel> LeaderboardsCache;

	public static void Initialize()
	{
		//IL_000f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0014: Expected O, but got Unknown
		//IL_0020: Expected O, but got I
		//IL_002f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0034: Expected O, but got Unknown
		//IL_0074: Expected I, but got O
		object obj = typeof(SqlSingle[]) + 2376;
		object obj2 = (nint)0 + (nint)520;
		object obj3 = typeof(System.Buffers.Text.ParserHelpers) + 1624;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
		Action action = default(Action);
		action..ctor(null, (IntPtr)obj2);
		object obj4 = obj3;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v59 @ X0_v4+E4]");
		if ((nint)0 != 0)
		{
			Preferences.OnGameChanged += action;
			return;
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		Preferences.OnGameChanged += action;
	}

	public unsafe static void GetLeaderBoard(GameObject lifecycle, ILeaderboardSource source, Action<LeaderboardModel> callback)
	{
		//IL_000f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0014: Expected O, but got Unknown
		//IL_0022: Unknown result type (might be due to invalid IL or missing references)
		//IL_0027: Expected O, but got Unknown
		//IL_0042: Unknown result type (might be due to invalid IL or missing references)
		//IL_0047: Expected O, but got Unknown
		//IL_007a: Unknown result type (might be due to invalid IL or missing references)
		//IL_007f: Expected O, but got Unknown
		//IL_0097: Expected O, but got I
		//IL_012d: Expected O, but got I
		//IL_0140: Unknown result type (might be due to invalid IL or missing references)
		//IL_0145: Expected O, but got Unknown
		//IL_0220: Unknown result type (might be due to invalid IL or missing references)
		//IL_0225: Expected O, but got Unknown
		//IL_024f: Expected O, but got I4
		//IL_00d2: Expected O, but got I
		//IL_016b: Expected O, but got I4
		//IL_017b: Expected O, but got I
		//IL_0284: Expected O, but got I
		//IL_029c: Expected O, but got I
		//IL_0410: Unknown result type (might be due to invalid IL or missing references)
		//IL_0415: Expected O, but got Unknown
		//IL_0421: Expected O, but got I
		//IL_0430: Unknown result type (might be due to invalid IL or missing references)
		//IL_0435: Expected O, but got Unknown
		//IL_0441: Expected O, but got I
		//IL_0450: Unknown result type (might be due to invalid IL or missing references)
		//IL_0455: Expected O, but got Unknown
		//IL_0461: Expected O, but got I
		//IL_0471: Expected O, but got I
		//IL_048c: Expected I, but got O
		//IL_0189: Unknown result type (might be due to invalid IL or missing references)
		//IL_018e: Expected O, but got Unknown
		//IL_01a4: Unknown result type (might be due to invalid IL or missing references)
		//IL_01a9: Expected O, but got Unknown
		//IL_01b9: Expected O, but got I
		//IL_01cc: Unknown result type (might be due to invalid IL or missing references)
		//IL_01d1: Expected O, but got Unknown
		//IL_01eb: Expected O, but got I4
		//IL_0203: Expected O, but got I
		//IL_0346: Expected O, but got I4
		//IL_04ac: Expected I, but got O
		//IL_00e0: Unknown result type (might be due to invalid IL or missing references)
		//IL_00e5: Expected O, but got Unknown
		//IL_00ee: Unknown result type (might be due to invalid IL or missing references)
		//IL_00f3: Expected O, but got Unknown
		//IL_038f: Expected O, but got I
		//IL_03b7: Expected O, but got Ref
		//IL_02d7: Expected O, but got I
		//IL_04cc: Expected I, but got O
		//IL_04e9: Expected O, but got I
		//IL_036f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0374: Expected O, but got Unknown
		//IL_02e5: Unknown result type (might be due to invalid IL or missing references)
		//IL_02ea: Expected O, but got Unknown
		//IL_02f3: Unknown result type (might be due to invalid IL or missing references)
		//IL_02f8: Expected O, but got Unknown
		//IL_0524: Expected O, but got I
		//IL_057d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0582: Expected O, but got Unknown
		//IL_0598: Unknown result type (might be due to invalid IL or missing references)
		//IL_059d: Expected O, but got Unknown
		//IL_0532: Unknown result type (might be due to invalid IL or missing references)
		//IL_0537: Expected O, but got Unknown
		//IL_0540: Unknown result type (might be due to invalid IL or missing references)
		//IL_0545: Expected O, but got Unknown
		object obj = typeof(InvitationsNotifier.<>c__DisplayClass16_0) + 1664;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
		object obj2 = default(object);
		obj2..ctor();
		object obj3 = obj2 + 16;
		obj3 = source;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
		object obj4 = obj2 + 24;
		Action<LeaderboardModel> action = default(Action<LeaderboardModel>);
		obj4 = action;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
		object obj5 = obj3;
		object obj6 = typeof(UnityEngine.TextCore.HorizontalAlignment) + 3464;
		object obj7 = obj5;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v282 @ X8_v4+12E]");
		object obj8 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v282 @ X8_v4+12E]");
		if ((nint)0 == 0)
		{
			goto IL_0113;
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v282 @ X8_v4+B0]");
		object obj9 = (nint)0 + (nint)8;
		while (true)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v330 @ X10_v20-8]");
			if (0 == (nint)obj6)
			{
				break;
			}
			obj9 += 16;
			obj8--;
			if ((nint)obj8 != 1)
			{
				continue;
			}
			goto IL_0113;
		}
		object obj10 = obj9 + 2;
		object obj11 = obj7 + obj10;
		object obj12 = obj11 + 312;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v353 @ X0_v45+8]");
		object obj13 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v353 @ X0_v45] (should have been resolved before IL gen)");
		object obj15 = default(object);
		object obj14 = obj15 & 1;
		bool flag = obj14 == null;
		object obj16 = !flag;
		Action<LeaderboardModel> action2 = action;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v353 @ X0_v45+8]");
		object obj17 = 0;
		if (obj16 == null)
		{
			goto IL_0211;
		}
		goto IL_0401;
		IL_0565:
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @B0D070");
		goto IL_063b;
		IL_0383:
		object obj18 = (nint)0 + (nint)3888;
		object obj19;
		object obj20 = default(object);
		object value;
		bool flag2 = ((Dictionary<object, object>)obj19).TryGetValue(obj20, out value);
		bool flag3 = !flag2;
		action2 = (Action<LeaderboardModel>)(&value);
		obj17 = obj20;
		if (!flag3)
		{
			object obj21 = obj4;
			if (obj4 != null)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v461 @ X8_v20+18] (should have been resolved before IL gen)");
			}
			return;
		}
		goto IL_0401;
		IL_0401:
		object obj22 = typeof(System.Diagnostics.DiagnosticSourceEventSource.TransformSpec.PropertySpec.PropertyFetch.EnumeratePropertyFetch<>) + 2536;
		object obj23 = (nint)0 + (nint)3704;
		object obj24 = typeof(SqlSingle[]) + 2376;
		object obj25 = (nint)0 + (nint)3712;
		object obj26 = typeof(System.Diagnostics.DiagnosticSourceEventSource.TransformSpec.PropertySpec.PropertyFetch.EnumeratePropertyFetch<>) + 3576;
		object obj27 = (nint)0 + (nint)3696;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v61 @ X0_v3 (System.Object)+10]");
		object obj28 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
		Action<object> action3 = default(Action<object>);
		action3..ctor(obj2, (IntPtr)obj23);
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
		Action action4 = default(Action);
		action4..ctor(obj2, (IntPtr)obj25);
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
		Action<object> action5 = default(Action<object>);
		action5..ctor(obj2, (IntPtr)obj27);
		object obj29 = obj28;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v464 @ X8_v9+12E]");
		object obj30 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v464 @ X8_v9+12E]");
		if ((nint)0 == 0)
		{
			goto IL_0565;
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v464 @ X8_v9+B0]");
		object obj31 = (nint)0 + (nint)8;
		while (true)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v537 @ X10_v8-8]");
			if (0 == (nint)obj6)
			{
				break;
			}
			obj31 += 16;
			obj30--;
			if ((nint)obj30 != 1)
			{
				continue;
			}
			goto IL_0565;
		}
		object obj32 = obj31 + 4;
		object obj33 = obj29 + obj32;
		object obj34 = obj33 + 312;
		goto IL_063b;
		IL_063b:
		Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v554 @ X0_v18] (should have been resolved before IL gen)");
		return;
		IL_0113:
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @B0D070");
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v316 @ X0_v42+8]");
		obj13 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v316 @ X0_v42] (should have been resolved before IL gen)");
		object obj36 = default(object);
		object obj35 = obj36 & 1;
		if (obj35 == null)
		{
			goto IL_0211;
		}
		action2 = (Action<LeaderboardModel>)2;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v316 @ X0_v42+8]");
		obj17 = 0;
		goto IL_0401;
		IL_0211:
		object obj37 = typeof(Newtonsoft.Json.Linq.JsonPath.JPath) + 1688;
		object obj38 = obj37;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v180 @ X0_v26+E4]");
		bool flag4 = (nint)0 == 0;
		object obj39 = !flag4;
		if (obj39 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			obj38 = obj37;
		}
		object obj40 = obj3;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v180 @ X0_v26+B8]");
		obj19 = 0;
		object obj41 = obj40;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v413 @ X8_v16+12E]");
		object obj42 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v413 @ X8_v16+12E]");
		if ((nint)0 == 0)
		{
			goto IL_0318;
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v413 @ X8_v16+B0]");
		object obj43 = (nint)0 + (nint)8;
		while (true)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v158 @ X10_v15-8]");
			if (0 == (nint)obj6)
			{
				break;
			}
			obj43 += 16;
			obj42--;
			if ((nint)obj42 != 1)
			{
				continue;
			}
			goto IL_0318;
		}
		object obj44 = obj41 + obj43;
		object obj45 = obj44 + 312;
		Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v452 @ X0_v36] (should have been resolved before IL gen)");
		goto IL_0383;
		IL_0318:
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @B0D070");
		Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v432 @ X0_v33] (should have been resolved before IL gen)");
		bool flag5 = obj19 == null;
		object obj46 = !flag5;
		if (obj46 == null)
		{
			throw new NullReferenceException();
		}
		goto IL_0383;
	}

	public static void InvalidateCache(ILeaderboardSource source)
	{
		//IL_000f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0014: Expected O, but got Unknown
		//IL_002a: Expected O, but got I
		//IL_00d9: Expected O, but got I4
		//IL_0096: Expected O, but got I4
		//IL_0115: Unknown result type (might be due to invalid IL or missing references)
		//IL_011a: Expected O, but got Unknown
		//IL_012a: Expected O, but got I
		//IL_0132: Expected I, but got O
		//IL_0142: Expected O, but got I
		//IL_017d: Expected O, but got I
		//IL_01f2: Unknown result type (might be due to invalid IL or missing references)
		//IL_01f7: Expected O, but got Unknown
		//IL_0200: Unknown result type (might be due to invalid IL or missing references)
		//IL_0205: Expected O, but got Unknown
		//IL_0229: Expected O, but got I4
		//IL_018b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0190: Expected O, but got Unknown
		//IL_0199: Unknown result type (might be due to invalid IL or missing references)
		//IL_019e: Expected O, but got Unknown
		object obj = typeof(Newtonsoft.Json.Linq.JsonPath.JPath) + 1688;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [91E6225]");
		object obj2 = (nint)0 & (nint)1;
		object obj3;
		if (obj2 != null)
		{
			obj3 = obj;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v58 @ X0_v3+E4]");
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
			obj3 = obj;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v58 @ X0_v3+E4]");
			bool flag2 = (nint)0 == 0;
			object obj5 = !flag2;
			object obj4 = obj3;
			if (obj5 != null)
			{
				goto IL_007c;
			}
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		obj3 = obj;
		goto IL_0106;
		IL_01d7:
		object obj6;
		object key = default(object);
		bool flag3 = ((Dictionary<object, object>)obj6).Remove(key);
		return;
		IL_01be:
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @B0D070");
		Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v152 @ X0_v8] (should have been resolved before IL gen)");
		goto IL_01d7;
		IL_0237:
		throw new NullReferenceException();
		IL_007c:
		bool flag4 = source == null;
		object obj7 = !flag4;
		if (obj7 != null)
		{
			goto IL_0106;
		}
		goto IL_0237;
		IL_0106:
		object obj8 = typeof(UnityEngine.TextCore.HorizontalAlignment) + 3464;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v58 @ X0_v3+B8]");
		obj6 = 0;
		nint num = (nint)source;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v68 @ X8_v6 (Il2CppClass<ILeaderboardSource>)+12E]");
		object obj9 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v68 @ X8_v6 (Il2CppClass<ILeaderboardSource>)+12E]");
		if ((nint)0 == 0)
		{
			goto IL_01be;
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v68 @ X8_v6 (Il2CppClass<ILeaderboardSource>)+B0]");
		object obj10 = (nint)0 + (nint)8;
		while (true)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v117 @ X10_v6-8]");
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
			goto IL_01be;
		}
		object obj11 = num + obj10;
		object obj12 = obj11 + 312;
		Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v215 @ X0_v11] (should have been resolved before IL gen)");
		bool flag5 = obj6 == null;
		object obj13 = !flag5;
		if (obj13 != null)
		{
			goto IL_01d7;
		}
		goto IL_0237;
	}

	public static void ResetModels()
	{
		//IL_0009: Expected O, but got I4
		//IL_0018: Unknown result type (might be due to invalid IL or missing references)
		//IL_001d: Expected O, but got Unknown
		//IL_0033: Expected O, but got I
		//IL_00dd: Expected O, but got I4
		//IL_0095: Expected O, but got I
		//IL_0115: Expected O, but got I
		//IL_0137: Expected O, but got I4
		object obj = 152985600;
		object obj2 = typeof(Newtonsoft.Json.Linq.JsonPath.JPath) + 1688;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [91E6226]");
		object obj3 = (nint)0 & (nint)1;
		if (obj3 != null)
		{
			object obj4 = obj2;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v37 @ X0_v15+E4]");
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
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v37 @ X0_v15+E4]");
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
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v70 @ X0_v5+B8]");
		object obj8 = 0;
		Dictionary<object, object> dictionary = (Dictionary<object, object>)obj8;
		bool flag3 = obj8 == null;
		object obj9 = !flag3;
		if (obj9 == null)
		{
			throw new NullReferenceException();
		}
		goto IL_00a2;
		IL_0085:
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v37 @ X0_v15+B8]");
		object obj10 = 0;
		dictionary = (Dictionary<object, object>)obj10;
		goto IL_00a2;
		IL_00a2:
		dictionary.Clear();
	}

	private static void StoreInCache<T>(ILeaderboardSource source, T model, string etag)
	{
		//IL_0028: Unknown result type (might be due to invalid IL or missing references)
		//IL_002d: Expected O, but got Unknown
		//IL_0035: Expected I, but got O
		//IL_0045: Expected O, but got I
		//IL_00d4: Expected O, but got I4
		//IL_0338: Unknown result type (might be due to invalid IL or missing references)
		//IL_033d: Expected O, but got Unknown
		//IL_0080: Expected O, but got I
		//IL_0170: Expected O, but got I4
		//IL_00e2: Unknown result type (might be due to invalid IL or missing references)
		//IL_00e7: Expected O, but got Unknown
		//IL_00ef: Unknown result type (might be due to invalid IL or missing references)
		//IL_00f4: Expected O, but got Unknown
		//IL_00fd: Unknown result type (might be due to invalid IL or missing references)
		//IL_0102: Expected O, but got Unknown
		//IL_0186: Expected I, but got O
		//IL_0196: Expected O, but got I
		//IL_008e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0093: Expected O, but got Unknown
		//IL_009c: Unknown result type (might be due to invalid IL or missing references)
		//IL_00a1: Expected O, but got Unknown
		//IL_039e: Expected O, but got I
		//IL_03b0: Expected I, but got O
		//IL_03c0: Expected O, but got I
		//IL_01d1: Expected O, but got I
		//IL_02b9: Expected O, but got I4
		//IL_0422: Unknown result type (might be due to invalid IL or missing references)
		//IL_0427: Expected O, but got Unknown
		//IL_0451: Expected O, but got I4
		//IL_0265: Expected O, but got I
		//IL_022a: Unknown result type (might be due to invalid IL or missing references)
		//IL_022f: Expected O, but got Unknown
		//IL_0237: Unknown result type (might be due to invalid IL or missing references)
		//IL_023c: Expected O, but got Unknown
		//IL_0245: Unknown result type (might be due to invalid IL or missing references)
		//IL_024a: Expected O, but got Unknown
		//IL_01df: Unknown result type (might be due to invalid IL or missing references)
		//IL_01e4: Expected O, but got Unknown
		//IL_01ed: Unknown result type (might be due to invalid IL or missing references)
		//IL_01f2: Expected O, but got Unknown
		//IL_02c7: Unknown result type (might be due to invalid IL or missing references)
		//IL_02cc: Expected O, but got Unknown
		//IL_02d4: Unknown result type (might be due to invalid IL or missing references)
		//IL_02d9: Expected O, but got Unknown
		//IL_02e2: Unknown result type (might be due to invalid IL or missing references)
		//IL_02e7: Expected O, but got Unknown
		//IL_0273: Unknown result type (might be due to invalid IL or missing references)
		//IL_0278: Expected O, but got Unknown
		//IL_0281: Unknown result type (might be due to invalid IL or missing references)
		//IL_0286: Expected O, but got Unknown
		object obj = typeof(UnityEngine.TextCore.HorizontalAlignment) + 3464;
		nint num = (nint)source;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v58 @ X8_v3 (Il2CppClass<ILeaderboardSource>)+12E]");
		object obj2 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v58 @ X8_v3 (Il2CppClass<ILeaderboardSource>)+12E]");
		if ((nint)0 == 0)
		{
			goto IL_00c1;
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v58 @ X8_v3 (Il2CppClass<ILeaderboardSource>)+B0]");
		object obj3 = (nint)0 + (nint)8;
		while (true)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v115 @ X10_v17-8]");
			if (0 == (nint)obj)
			{
				break;
			}
			obj3 += 16;
			obj2--;
			if ((nint)obj2 != 1)
			{
				continue;
			}
			goto IL_00c1;
		}
		object obj4 = obj3 + 8;
		object obj5 = num + obj4;
		object obj6 = obj5 + 312;
		string text = etag;
		goto IL_031f;
		IL_038e:
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v308 @ X0_v7+8]");
		object obj7 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v308 @ X0_v7] (should have been resolved before IL gen)");
		nint num2 = (nint)source;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v316 @ X8_v12 (Il2CppClass<ILeaderboardSource>)+12E]");
		object obj8 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v316 @ X8_v12 (Il2CppClass<ILeaderboardSource>)+12E]");
		if ((nint)0 == 0)
		{
			goto IL_02a6;
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v316 @ X8_v12 (Il2CppClass<ILeaderboardSource>)+B0]");
		object obj9 = (nint)0 + (nint)8;
		while (true)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v358 @ X10_v7-8]");
			if (0 == (nint)obj)
			{
				break;
			}
			obj9 += 16;
			obj8--;
			if ((nint)obj8 != 1)
			{
				continue;
			}
			goto IL_02a6;
		}
		object obj10 = obj9 + 8;
		object obj11 = num2 + obj10;
		object obj12 = obj11 + 312;
		goto IL_0409;
		IL_0212:
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @B0D070");
		goto IL_038e;
		IL_02a6:
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @B0D070");
		obj7 = 8;
		goto IL_0409;
		IL_0409:
		Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v376 @ X0_v10] (should have been resolved before IL gen)");
		object obj13 = typeof(System.ComponentModel.ExtendedPropertyDescriptor) + 488;
		object obj14 = obj13;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v384 @ X8_v17+E4]");
		bool flag = (nint)0 == 0;
		object obj15 = !flag;
		if (obj15 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		}
		string path = default(string);
		FileUtils.SaveObject(path, (object)model);
		return;
		IL_00c1:
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @B0D070");
		text = (string)8;
		goto IL_031f;
		IL_031f:
		Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v209 @ X0_v3] (should have been resolved before IL gen)");
		object obj16 = typeof(System.Formats.Asn1.SetOfValueComparer) + 2536;
		object obj17 = obj16;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v185 @ X8_v8+E4]");
		string value = default(string);
		if ((nint)0 != 0)
		{
			if (StringsExtensions.IsNullOrEmpty(value))
			{
				return;
			}
		}
		else
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			bool flag2 = StringsExtensions.IsNullOrEmpty(value);
			bool flag3 = !flag2;
			object obj18 = !flag3;
			if (obj18 != null)
			{
				return;
			}
		}
		nint num3 = (nint)source;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v235 @ X8_v9 (Il2CppClass<ILeaderboardSource>)+12E]");
		object obj19 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v235 @ X8_v9 (Il2CppClass<ILeaderboardSource>)+12E]");
		if ((nint)0 == 0)
		{
			goto IL_0212;
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v235 @ X8_v9 (Il2CppClass<ILeaderboardSource>)+B0]");
		object obj20 = (nint)0 + (nint)8;
		while (true)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v279 @ X10_v12-8]");
			if (0 == (nint)obj)
			{
				break;
			}
			obj20 += 16;
			obj19--;
			if ((nint)obj19 != 1)
			{
				continue;
			}
			goto IL_0212;
		}
		object obj21 = obj20 + 7;
		object obj22 = num3 + obj21;
		object obj23 = obj22 + 312;
		goto IL_038e;
	}

	static LeaderBoardManager()
	{
		//IL_000f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0014: Expected O, but got Unknown
		//IL_0024: Unknown result type (might be due to invalid IL or missing references)
		//IL_0029: Expected O, but got Unknown
		object obj = typeof(ConditionalWeakTable<System.Net.HttpWebRequest, Mono.Http.NtlmSession>.CreateValueCallback) + 2608;
		object obj2 = typeof(Newtonsoft.Json.Linq.JsonPath.JPath) + 1688;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
		Dictionary<object, object> dictionary = default(Dictionary<object, object>);
		dictionary..ctor();
		object obj3 = obj2;
		object obj4 = dictionary;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
	}
}

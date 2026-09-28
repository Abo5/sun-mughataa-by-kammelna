using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Runtime.Remoting.Messaging;
using Cpp2ILInjected;
using HuaweiMobileServices.Location.Location;
using Kammelna.Server;
using Sfs2X.Entities;
using UnityEngine;
using UnityEngine.AdaptivePerformance;

public static class ClanRequestsBadge
{
	[Serializable]
	private sealed class <>c
	{
		public static readonly <>c <>9;

		public static Func<ClanUserModel, long> <>9__6_0;

		static <>c()
		{
			//IL_000f: Unknown result type (might be due to invalid IL or missing references)
			//IL_0014: Expected O, but got Unknown
			object obj = typeof(CardUtils.<>c) + 1264;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
			object obj2 = default(object);
			obj2..ctor();
			object obj3 = obj;
			object obj4 = obj2;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
		}

		internal unsafe long <LatestTicks>b__6_0(ClanUserModel request)
		{
			//IL_00a3: Expected I8, but got O
			//IL_0014: Unknown result type (might be due to invalid IL or missing references)
			//IL_0019: Expected O, but got Unknown
			//IL_0079: Unknown result type (might be due to invalid IL or missing references)
			//IL_007e: Expected O, but got Unknown
			//IL_004f: Unknown result type (might be due to invalid IL or missing references)
			//IL_0054: Expected O, but got Unknown
			if (request != null)
			{
				object obj = typeof(DataRelation) + 712;
				object obj2 = obj;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v41 @ X0_v3+E4]");
				if ((nint)0 != 0)
				{
					DateTime dateTime = (DateTime)(request + 80);
					return ((DateTime*)dateTime)->Ticks;
				}
				Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
				DateTime dateTime2 = (DateTime)(request + 80);
				return ((DateTime*)dateTime2)->Ticks;
			}
			NullReferenceException ex = new NullReferenceException();
			return (long)ex;
		}
	}

	private sealed class <>c__DisplayClass5_0
	{
		public long watermark;

		internal unsafe bool <UnseenCount>b__0(ClanUserModel request)
		{
			//IL_0119: Expected I4, but got O
			//IL_0014: Unknown result type (might be due to invalid IL or missing references)
			//IL_0019: Expected O, but got Unknown
			//IL_0043: Expected O, but got I4
			//IL_0069: Unknown result type (might be due to invalid IL or missing references)
			//IL_006e: Expected O, but got Unknown
			//IL_008a: Expected O, but got I8
			//IL_00bf: Unknown result type (might be due to invalid IL or missing references)
			//IL_00c4: Expected I8, but got Unknown
			//IL_00f9: Expected O, but got I4
			//IL_0101: Unknown result type (might be due to invalid IL or missing references)
			//IL_0106: Expected I4, but got Unknown
			if (request != null)
			{
				object obj = typeof(DataRelation) + 712;
				object obj2 = obj;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v46 @ X0_v3+E4]");
				bool flag = (nint)0 == 0;
				object obj3 = !flag;
				if (obj3 == null)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
				}
				DateTime dateTime = (DateTime)(request + 80);
				long ticks = ((DateTime*)dateTime)->Ticks;
				object obj4 = ticks - watermark;
				bool flag2 = (nint)obj4 < 0;
				bool flag3 = obj4 == null;
				long num = ticks ^ watermark;
				long num2 = ticks ^ obj4;
				long num3 = num & num2;
				bool flag4 = num3 < 0;
				bool flag5 = flag2 == flag4;
				object obj5 = !flag3;
				return (byte)((flag5 & obj5) ? 1 : 0) != 0;
			}
			NullReferenceException ex = new NullReferenceException();
			return (byte)(int)ex != 0;
		}
	}

	private const string WATERMARK_KEY_PREFIX = "clan_requests_seen_watermark_";

	public static void Publish(IEnumerable<ClanUserModel> requests)
	{
		//IL_000f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0014: Expected O, but got Unknown
		//IL_006f: Expected O, but got I4
		object obj = typeof(System.Runtime.Remoting.Messaging.CallContextSecurityData) + 3312;
		IEnumerable<ClanUserModel> requests2 = default(IEnumerable<ClanUserModel>);
		int newCount = UnseenCount(requests2);
		object obj2 = obj;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v49 @ X0_v3+E4]");
		bool flag = (nint)0 == 0;
		object obj3 = !flag;
		if (obj3 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		}
		CounterBubbleManager.UpdateCounter(CounterBubbleType.ClanJoinRequests, newCount);
	}

	public static void PublishZero()
	{
		//IL_000f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0014: Expected O, but got Unknown
		//IL_0063: Expected O, but got I4
		object obj = typeof(System.Runtime.Remoting.Messaging.CallContextSecurityData) + 3312;
		object obj2 = obj;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v39 @ X0_v2+E4]");
		bool flag = (nint)0 == 0;
		object obj3 = !flag;
		if (obj3 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		}
		CounterBubbleManager.UpdateCounter(CounterBubbleType.ClanJoinRequests, 0);
	}

	public unsafe static void MarkSeen(IEnumerable<ClanUserModel> requests)
	{
		//IL_0030: Unknown result type (might be due to invalid IL or missing references)
		//IL_0035: Expected O, but got Unknown
		//IL_0296: Unknown result type (might be due to invalid IL or missing references)
		//IL_029b: Expected O, but got Unknown
		//IL_0076: Expected O, but got I4
		//IL_00a3: Expected I8, but got I4
		//IL_00b7: Unknown result type (might be due to invalid IL or missing references)
		//IL_00bc: Expected O, but got Unknown
		//IL_00d2: Expected O, but got I
		//IL_00ea: Expected O, but got I4
		//IL_00f2: Expected O, but got Ref
		//IL_00fb: Expected O, but got I4
		//IL_0103: Expected O, but got Ref
		//IL_0198: Unknown result type (might be due to invalid IL or missing references)
		//IL_019d: Expected O, but got Unknown
		//IL_01b3: Expected O, but got I
		//IL_01cd: Expected O, but got I4
		//IL_01d6: Expected O, but got I4
		//IL_01e7: Expected O, but got I4
		//IL_0235: Expected O, but got I4
		List<ClanUserModel> requests2;
		if (requests != null)
		{
			List<object> list = Enumerable.ToList((IEnumerable<object>)requests);
			requests2 = (List<ClanUserModel>)(object)list;
		}
		else
		{
			object obj = typeof(List<AdaptivePerformanceScaler>) + 560;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
			List<object> list2 = default(List<object>);
			list2..ctor();
			requests2 = (List<ClanUserModel>)(object)list2;
		}
		long num = LatestTicks(requests2);
		object defaultValue = ", stale={0}" + 3424;
		string key = WatermarkKey();
		string s = Prefs.GetString(key, (string)defaultValue);
		long result;
		bool flag = long.TryParse(s, out result);
		bool flag2 = !flag;
		object obj2 = !flag2;
		object obj3 = ~obj2;
		long num2 = ((obj3 != null) ? 0 : result);
		object obj4;
		object obj7;
		string text2;
		object obj8;
		object obj6;
		string text;
		if (num <= num2)
		{
			obj4 = typeof(System.Runtime.Remoting.Messaging.CallContextSecurityData) + 3312;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [91E88C7]");
			object obj5 = (nint)0 & (nint)1;
			bool flag3 = obj5 == null;
			obj6 = 0;
			text = (string)(&result);
			obj7 = 0;
			text2 = (string)(&result);
			obj8 = obj4;
			if (!flag3)
			{
				goto IL_0119;
			}
		}
		else
		{
			string key2 = WatermarkKey();
			string text3 = result.ToString();
			Prefs.SetString(key2, text3);
			Prefs.Save();
			obj4 = typeof(System.Runtime.Remoting.Messaging.CallContextSecurityData) + 3312;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [91E88C7]");
			object obj9 = (nint)0 & (nint)1;
			bool flag4 = obj9 == null;
			object obj10 = !flag4;
			obj6 = 0;
			text = text3;
			obj7 = 0;
			text2 = text3;
			obj8 = obj4;
			if (obj10 != null)
			{
				goto IL_0119;
			}
		}
		_ = 1;
		object obj11 = obj8;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v184 @ X0_v8+E4]");
		bool flag5 = (nint)0 == 0;
		object obj12 = !flag5;
		obj6 = obj7;
		text = text2;
		if (obj12 != null)
		{
			goto IL_0146;
		}
		goto IL_0253;
		IL_0146:
		CounterBubbleManager.UpdateCounter(CounterBubbleType.ClanJoinRequests, 0);
		return;
		IL_0253:
		Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		goto IL_0146;
		IL_0119:
		obj11 = obj4;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v184 @ X0_v8+E4]");
		if ((nint)0 != 0)
		{
			goto IL_0146;
		}
		goto IL_0253;
	}

	public static void ResetSeen()
	{
		string key = WatermarkKey();
		Prefs.DeleteKey(key);
		Prefs.Save();
	}

	private static int UnseenCount(IEnumerable<ClanUserModel> requests)
	{
		//IL_000f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0014: Expected O, but got Unknown
		//IL_0159: Unknown result type (might be due to invalid IL or missing references)
		//IL_015e: Expected O, but got Unknown
		//IL_013c: Expected I4, but got O
		//IL_0050: Expected O, but got I4
		//IL_007d: Expected I8, but got I4
		//IL_01ac: Unknown result type (might be due to invalid IL or missing references)
		//IL_01b1: Expected O, but got Unknown
		//IL_01bd: Expected O, but got I
		//IL_00bf: Unknown result type (might be due to invalid IL or missing references)
		//IL_00c4: Expected O, but got Unknown
		//IL_00da: Expected O, but got I
		//IL_0113: Expected I, but got O
		//IL_008e: Expected O, but got I
		object obj = typeof(CardUtils.<>c) + 1272;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
		object obj2 = default(object);
		obj2..ctor();
		object defaultValue = ", stale={0}" + 3424;
		string key = WatermarkKey();
		string s = Prefs.GetString(key, (string)defaultValue);
		long result;
		bool flag = long.TryParse(s, out result);
		if (obj2 != null)
		{
			bool flag2 = !flag;
			object obj3 = !flag2;
			object obj4 = ~obj3;
			if (obj4 == null)
			{
				long num = result;
			}
			else
			{
				long num = 0L;
			}
			object obj5 = typeof(Func<AndroidJavaObject, IList<HWLocation>>) + 760;
			object obj6 = (nint)0 + (nint)496;
			List<object> source;
			if (requests != null)
			{
				object obj7 = (nint)0 + (nint)2000;
				object obj8 = obj7;
				List<object> list = Enumerable.ToList((IEnumerable<object>)requests);
				source = list;
			}
			else
			{
				object obj9 = typeof(List<AdaptivePerformanceScaler>) + 560;
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
				object obj10 = (nint)0 + (nint)3448;
				object obj8 = obj10;
				List<object> list2 = default(List<object>);
				list2..ctor();
				source = list2;
			}
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
			Func<object, bool> func = default(Func<object, bool>);
			func..ctor(obj2, (IntPtr)obj6);
			return Enumerable.Count(source, func);
		}
		NullReferenceException ex = new NullReferenceException();
		return (int)ex;
	}

	private static long LatestTicks(List<ClanUserModel> requests)
	{
		//IL_01c1: Expected I8, but got O
		//IL_00d7: Expected I8, but got I4
		//IL_0036: Unknown result type (might be due to invalid IL or missing references)
		//IL_003b: Expected O, but got Unknown
		//IL_00f5: Expected O, but got I
		//IL_0105: Expected O, but got I
		//IL_0115: Expected O, but got I
		//IL_0137: Expected O, but got I4
		//IL_0074: Expected O, but got I
		//IL_0084: Expected O, but got I
		//IL_0094: Expected O, but got I
		//IL_00b6: Expected O, but got I4
		//IL_016f: Expected O, but got I4
		//IL_01ed: Unknown result type (might be due to invalid IL or missing references)
		//IL_01f2: Expected O, but got Unknown
		//IL_0208: Expected O, but got I
		//IL_0219: Expected I, but got O
		//IL_0237: Expected O, but got I
		//IL_019f: Expected O, but got I
		object obj;
		object obj4;
		object obj6;
		object obj3;
		Func<object, long> func;
		if (requests != null)
		{
			if (requests._size != 0)
			{
				obj = typeof(CardUtils.<>c) + 1264;
				object obj2 = obj;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v138 @ X0_v8+E4]");
				if ((nint)0 != 0)
				{
					obj3 = (nint)0 + (nint)1864;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v138 @ X0_v8+B8]");
					obj4 = 0;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v145 @ X8_v7+8]");
					func = (Func<object, long>)0;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v145 @ X8_v7+8]");
					bool flag = (nint)0 == 0;
					object obj5 = !flag;
					if (obj5 == null)
					{
						obj6 = obj3;
						goto IL_014d;
					}
				}
				else
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
					obj2 = obj;
					obj6 = (nint)0 + (nint)1864;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v138 @ X0_v8+B8]");
					obj4 = 0;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v145 @ X8_v7+8]");
					func = (Func<object, long>)0;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v145 @ X8_v7+8]");
					bool flag2 = (nint)0 == 0;
					object obj7 = !flag2;
					obj3 = obj6;
					if (obj7 == null)
					{
						goto IL_014d;
					}
				}
				goto IL_01a4;
			}
			return 0L;
		}
		NullReferenceException ex = new NullReferenceException();
		return (long)ex;
		IL_014d:
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v138 @ X0_v8+E4]");
		bool flag3 = (nint)0 == 0;
		object obj8 = !flag3;
		if (obj8 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			object obj9 = obj;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v151 @ X8_v13+B8]");
			obj4 = 0;
		}
		object obj10 = typeof(Func<AndroidJavaObject, IList<HWLocation>>) + 776;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
		object obj11 = (nint)0 + (nint)488;
		Func<object, long> func2 = default(Func<object, long>);
		func2..ctor(obj4, (IntPtr)obj11);
		object obj12 = obj;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v130 @ X8_v12+B8]");
		object obj13 = (nint)0 + (nint)8;
		obj13 = func2;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
		obj3 = obj6;
		func = func2;
		goto IL_01a4;
		IL_01a4:
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2DCAABC");
		long result = default(long);
		return result;
	}

	private static List<ClanUserModel> AsList(IEnumerable<ClanUserModel> requests)
	{
		//IL_0027: Unknown result type (might be due to invalid IL or missing references)
		//IL_002c: Expected O, but got Unknown
		if (requests != null)
		{
			return (List<ClanUserModel>)(object)Enumerable.ToList((IEnumerable<object>)requests);
		}
		object obj = typeof(List<AdaptivePerformanceScaler>) + 560;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
		List<object> list = default(List<object>);
		list..ctor();
		return (List<ClanUserModel>)(object)list;
	}

	private static long LoadWatermark()
	{
		//IL_000a: Unknown result type (might be due to invalid IL or missing references)
		//IL_000f: Expected O, but got Unknown
		//IL_002e: Expected O, but got I4
		//IL_005b: Expected I8, but got I4
		object defaultValue = ", stale={0}" + 3424;
		string key = WatermarkKey();
		string s = Prefs.GetString(key, (string)defaultValue);
		long result;
		bool flag = long.TryParse(s, out result);
		bool flag2 = !flag;
		object obj = !flag2;
		object obj2 = ~obj;
		if (obj2 == null)
		{
			return result;
		}
		return 0L;
	}

	private static void SaveWatermark(long ticks)
	{
		string key = WatermarkKey();
		long num = default(long);
		string value = num.ToString();
		Prefs.SetString(key, value);
		Prefs.Save();
	}

	private static string WatermarkKey()
	{
		//IL_0009: Expected O, but got I4
		//IL_0018: Unknown result type (might be due to invalid IL or missing references)
		//IL_001d: Expected O, but got Unknown
		//IL_0033: Expected O, but got I
		//IL_0120: Expected O, but got I
		//IL_014a: Expected O, but got I4
		//IL_005c: Expected O, but got I
		//IL_00c2: Unknown result type (might be due to invalid IL or missing references)
		//IL_00c7: Expected O, but got Unknown
		//IL_0193: Expected O, but got I4
		object obj = 152993792;
		object obj2 = typeof(Queue<string>) + 848;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [91E87F8]");
		object obj3 = (nint)0 & (nint)1;
		if (obj3 != null)
		{
			object obj4 = (nint)0 + (nint)2200;
			object obj5 = obj2;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v49 @ X0_v3+E4]");
			bool flag = (nint)0 == 0;
			object obj6 = obj4;
			if (!flag)
			{
				goto IL_0091;
			}
		}
		else
		{
			_ = 1;
			object obj4 = (nint)0 + (nint)2200;
			object obj5 = obj2;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v49 @ X0_v3+E4]");
			bool flag2 = (nint)0 == 0;
			object obj7 = !flag2;
			object obj6 = obj4;
			if (obj7 != null)
			{
				goto IL_0091;
			}
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @3CEC320");
		SessionModel sessionModel = default(SessionModel);
		bool flag3 = (object)sessionModel == null;
		object obj8 = !flag3;
		if (obj8 != null)
		{
			goto IL_00b8;
		}
		goto IL_01a1;
		IL_00b8:
		object obj9 = "because MSAA is on. Turn MSAA off on the camera or current URP Asset." + 3920;
		User localUser = sessionModel.LocalUser;
		int clanId = SFSKammelnaUserExtensions.GetClanId(localUser);
		int num = default(int);
		string text = num.ToString();
		return (string)obj9 + text;
		IL_01a1:
		return (string)(object)new NullReferenceException();
		IL_0091:
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @3CEC320");
		if ((object)sessionModel != null)
		{
			goto IL_00b8;
		}
		goto IL_01a1;
	}
}

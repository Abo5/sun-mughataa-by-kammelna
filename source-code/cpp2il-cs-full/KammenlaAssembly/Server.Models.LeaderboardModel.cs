using System;
using System.Collections.Generic;
using System.Linq;
using Cpp2ILInjected;
using HuaweiMobileServices.Location.Location;
using Newtonsoft.Json.Linq.JsonPath;
using Sfs2X.Entities.Data;
using UnityEngine;
using UnityEngine.AdaptivePerformance;

namespace Server.Models;

public class LeaderboardModel
{
	[Serializable]
	private sealed class <>c
	{
		public static readonly <>c <>9;

		public static Func<LeaderBoardPlayer, bool> <>9__16_0;

		static <>c()
		{
			//IL_000f: Unknown result type (might be due to invalid IL or missing references)
			//IL_0014: Expected O, but got Unknown
			object obj = typeof(InvitationsNotifier.<>c__DisplayClass16_0) + 1672;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
			object obj2 = default(object);
			obj2..ctor();
			object obj3 = obj;
			object obj4 = obj2;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
		}

		internal bool <GetTopPlayers>b__16_0(LeaderBoardPlayer player)
		{
			//IL_0034: Expected I4, but got O
			//IL_001c: Unknown result type (might be due to invalid IL or missing references)
			//IL_0021: Expected I4, but got Unknown
			if (player != null)
			{
				object obj = ~player.MonthlyWinningTier;
				return (byte)(1 & obj) != 0;
			}
			NullReferenceException ex = new NullReferenceException();
			return (byte)(int)ex != 0;
		}
	}

	private string <ETag>k__BackingField;

	private List<LeaderBoardPlayer> <PlayersList>k__BackingField;

	private List<LeaderBoardPlayer> <MonthlyWinners>k__BackingField;

	private string <Title>k__BackingField;

	public string ETag
	{
		get
		{
			return <ETag>k__BackingField;
		}
		set
		{
			//IL_0006: Unknown result type (might be due to invalid IL or missing references)
			//IL_000b: Expected O, but got Unknown
			object obj = this + 16;
			obj = value;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
		}
	}

	public List<LeaderBoardPlayer> PlayersList
	{
		get
		{
			return <PlayersList>k__BackingField;
		}
		set
		{
			//IL_0006: Unknown result type (might be due to invalid IL or missing references)
			//IL_000b: Expected O, but got Unknown
			object obj = this + 24;
			obj = value;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
		}
	}

	public List<LeaderBoardPlayer> MonthlyWinners
	{
		get
		{
			return <MonthlyWinners>k__BackingField;
		}
		set
		{
			//IL_0006: Unknown result type (might be due to invalid IL or missing references)
			//IL_000b: Expected O, but got Unknown
			object obj = this + 32;
			obj = value;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
		}
	}

	public string Title
	{
		get
		{
			return <Title>k__BackingField;
		}
		set
		{
			//IL_0006: Unknown result type (might be due to invalid IL or missing references)
			//IL_000b: Expected O, but got Unknown
			object obj = this + 40;
			obj = value;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
		}
	}

	public List<LeaderBoardPlayer> GetTopPlayers()
	{
		//IL_000c: Expected O, but got I
		//IL_0052: Unknown result type (might be due to invalid IL or missing references)
		//IL_0057: Expected O, but got Unknown
		//IL_0081: Expected O, but got I4
		//IL_0161: Expected O, but got I
		//IL_0171: Expected O, but got I
		//IL_0193: Expected O, but got I4
		//IL_0020: Unknown result type (might be due to invalid IL or missing references)
		//IL_0025: Expected O, but got Unknown
		//IL_00c8: Expected O, but got I4
		//IL_01b0: Unknown result type (might be due to invalid IL or missing references)
		//IL_01b5: Expected O, but got Unknown
		//IL_01cb: Expected O, but got I
		//IL_01dc: Expected I, but got O
		//IL_01fa: Expected O, but got I
		//IL_00f8: Expected O, but got I
		object obj = (nint)0 + (nint)2664;
		if (ArraysExtensions.IsNullOrEmpty((IEnumerable<object>)<PlayersList>k__BackingField))
		{
			object obj2 = typeof(List<AdaptivePerformanceScaler>) + 2096;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
			List<object> list = default(List<object>);
			list..ctor();
			return (List<LeaderBoardPlayer>)(object)list;
		}
		object obj3 = typeof(InvitationsNotifier.<>c__DisplayClass16_0) + 1672;
		object obj4 = obj3;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v78 @ X0_v5+E4]");
		bool flag = (nint)0 == 0;
		object obj5 = !flag;
		if (obj5 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			obj4 = obj3;
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v78 @ X0_v5+B8]");
		object obj6 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v154 @ X8_v6+8]");
		Func<object, bool> predicate = (Func<object, bool>)0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v154 @ X8_v6+8]");
		bool flag2 = (nint)0 == 0;
		object obj7 = !flag2;
		if (obj7 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v78 @ X0_v5+E4]");
			bool flag3 = (nint)0 == 0;
			object obj8 = !flag3;
			if (obj8 == null)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
				object obj9 = obj3;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v163 @ X8_v12+B8]");
				obj6 = 0;
			}
			object obj10 = typeof(Func<AndroidJavaObject, IList<HWLocation>>) + 2248;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
			object obj11 = (nint)0 + (nint)3720;
			Func<object, bool> func = default(Func<object, bool>);
			func..ctor(obj6, (IntPtr)obj11);
			object obj12 = obj3;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v117 @ X8_v11+B8]");
			object obj13 = (nint)0 + (nint)8;
			obj13 = func;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
			predicate = func;
		}
		IEnumerable<object> source = Enumerable.Where(<PlayersList>k__BackingField, predicate);
		return (List<LeaderBoardPlayer>)(object)Enumerable.ToList(source);
	}

	public static LeaderboardModel FromSfsObject(ISFSObject data)
	{
		//IL_000f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0014: Expected O, but got Unknown
		//IL_001e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0023: Expected O, but got Unknown
		//IL_0404: Expected I8, but got I4
		//IL_005b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0060: Expected O, but got Unknown
		//IL_009e: Unknown result type (might be due to invalid IL or missing references)
		//IL_00a3: Expected O, but got Unknown
		//IL_00ad: Unknown result type (might be due to invalid IL or missing references)
		//IL_00b2: Expected O, but got Unknown
		//IL_00c1: Unknown result type (might be due to invalid IL or missing references)
		//IL_00c6: Expected O, but got Unknown
		//IL_00d2: Expected O, but got I
		//IL_00de: Expected O, but got I
		//IL_00e8: Unknown result type (might be due to invalid IL or missing references)
		//IL_00ed: Expected O, but got Unknown
		//IL_00f5: Expected I, but got O
		//IL_0105: Expected O, but got I
		//IL_0453: Expected I, but got O
		//IL_0140: Expected O, but got I
		//IL_01c7: Unknown result type (might be due to invalid IL or missing references)
		//IL_01cc: Expected O, but got Unknown
		//IL_01e6: Expected I, but got O
		//IL_01f6: Expected O, but got I
		//IL_0199: Unknown result type (might be due to invalid IL or missing references)
		//IL_019e: Expected O, but got Unknown
		//IL_01a6: Unknown result type (might be due to invalid IL or missing references)
		//IL_01ab: Expected O, but got Unknown
		//IL_01b4: Unknown result type (might be due to invalid IL or missing references)
		//IL_01b9: Expected O, but got Unknown
		//IL_0490: Unknown result type (might be due to invalid IL or missing references)
		//IL_0495: Expected O, but got Unknown
		//IL_04a5: Expected O, but got I
		//IL_04c7: Expected O, but got I4
		//IL_0231: Expected O, but got I
		//IL_014e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0153: Expected O, but got Unknown
		//IL_015c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0161: Expected O, but got Unknown
		//IL_033f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0344: Expected O, but got Unknown
		//IL_037e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0383: Expected O, but got Unknown
		//IL_02c7: Expected I, but got O
		//IL_028a: Unknown result type (might be due to invalid IL or missing references)
		//IL_028f: Expected O, but got Unknown
		//IL_0297: Unknown result type (might be due to invalid IL or missing references)
		//IL_029c: Expected O, but got Unknown
		//IL_02a5: Unknown result type (might be due to invalid IL or missing references)
		//IL_02aa: Expected O, but got Unknown
		//IL_03b5: Unknown result type (might be due to invalid IL or missing references)
		//IL_03ba: Expected O, but got Unknown
		//IL_02f8: Expected O, but got I4
		//IL_0301: Expected O, but got I4
		//IL_0312: Expected O, but got I4
		//IL_023f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0244: Expected O, but got Unknown
		//IL_024d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0252: Expected O, but got Unknown
		object obj = typeof(Newtonsoft.Json.Linq.JsonPath.JPath) + 1736;
		object varName = "destinationTimeZone" + 1040;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
		object obj2 = default(object);
		obj2..ctor();
		long num = SFSExtensions.Get(data, (string)varName, 0L);
		long num2 = default(long);
		string text = num2.ToString();
		object obj4;
		object obj7;
		object obj8;
		object obj9;
		if (obj2 != null)
		{
			object obj3 = obj2 + 16;
			obj3 = text;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
			if (data != null)
			{
				obj4 = typeof(System.IOAsyncCallback) + 976;
				object obj5 = "com.unity.services.authentication.profile" + 2776;
				object obj6 = typeof(Func<AndroidJavaObject, IList<HWLocation>>) + 1632;
				obj7 = (nint)0 + (nint)536;
				obj8 = (nint)0 + (nint)464;
				obj9 = "m_StencilDeferredPS" + 2824;
				nint num3 = (nint)data;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v117 @ X8_v5 (Il2CppClass<Sfs2X.Entities.Data.ISFSObject>)+12E]");
				object obj10 = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v117 @ X8_v5 (Il2CppClass<Sfs2X.Entities.Data.ISFSObject>)+12E]");
				if ((nint)0 == 0)
				{
					goto IL_0181;
				}
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v117 @ X8_v5 (Il2CppClass<Sfs2X.Entities.Data.ISFSObject>)+B0]");
				object obj11 = (nint)0 + (nint)8;
				while (true)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v237 @ X10_v11-8]");
					if (0 == (nint)obj4)
					{
						break;
					}
					obj11 += 16;
					obj10--;
					if ((nint)obj10 != 1)
					{
						continue;
					}
					goto IL_0181;
				}
				object obj12 = obj11 + 28;
				object obj13 = num3 + obj12;
				object obj14 = obj13 + 312;
				goto IL_0431;
			}
		}
		return (LeaderboardModel)(object)new NullReferenceException();
		IL_0486:
		object varName2 = "java.io.FileOutputStream" + 3528;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v351 @ X0_v23+8]");
		object obj15 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v351 @ X0_v23] (should have been resolved before IL gen)");
		object obj16 = default(object);
		bool flag = obj16 == null;
		object obj17 = 0;
		Func<object, object> func = (Func<object, object>)obj9;
		List<object> list2;
		object obj19;
		object obj20;
		if (!flag)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
			Func<object, object> func2 = default(Func<object, object>);
			func2..ctor((object)null, (IntPtr)obj7);
			obj15 = obj8;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @3020370");
			List<object> list = default(List<object>);
			bool flag2 = list == null;
			object obj18 = !flag2;
			obj17 = 0;
			func = func2;
			obj19 = 0;
			obj20 = obj8;
			list2 = list;
			if (obj18 != null)
			{
				goto IL_0375;
			}
		}
		object obj21 = typeof(List<AdaptivePerformanceScaler>) + 2096;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
		List<object> list3 = default(List<object>);
		list3..ctor();
		obj19 = obj17;
		obj20 = obj15;
		list2 = list3;
		goto IL_0375;
		IL_0375:
		object obj22 = obj2 + 32;
		obj22 = list2;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
		string text2 = SFSExtensions.Get(data, (string)varName2, (string)null);
		object obj23 = obj2 + 40;
		obj23 = text2;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
		return (LeaderboardModel)obj2;
		IL_0181:
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @B0D070");
		goto IL_0431;
		IL_0431:
		Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v268 @ X0_v13] (should have been resolved before IL gen)");
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
		Func<object, object> func3 = default(Func<object, object>);
		func3..ctor((object)null, (IntPtr)obj7);
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @3020370");
		object obj24 = obj2 + 24;
		object obj25 = default(object);
		obj24 = obj25;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
		nint num4 = (nint)data;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v292 @ X8_v8 (Il2CppClass<Sfs2X.Entities.Data.ISFSObject>)+12E]");
		object obj26 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v292 @ X8_v8 (Il2CppClass<Sfs2X.Entities.Data.ISFSObject>)+12E]");
		if ((nint)0 == 0)
		{
			goto IL_0272;
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v292 @ X8_v8 (Il2CppClass<Sfs2X.Entities.Data.ISFSObject>)+B0]");
		object obj27 = (nint)0 + (nint)8;
		while (true)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v334 @ X10_v6-8]");
			if (0 == (nint)obj4)
			{
				break;
			}
			obj27 += 16;
			obj26--;
			if ((nint)obj26 != 1)
			{
				continue;
			}
			goto IL_0272;
		}
		object obj28 = obj27 + 28;
		object obj29 = num4 + obj28;
		object obj30 = obj29 + 312;
		goto IL_0486;
		IL_0272:
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @B0D070");
		goto IL_0486;
	}

	public static LeaderboardModel FromList(List<LeaderBoardPlayer> list, string etag)
	{
		//IL_000f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0014: Expected O, but got Unknown
		//IL_0022: Unknown result type (might be due to invalid IL or missing references)
		//IL_0027: Expected O, but got Unknown
		//IL_0042: Unknown result type (might be due to invalid IL or missing references)
		//IL_0047: Expected O, but got Unknown
		object obj = typeof(Newtonsoft.Json.Linq.JsonPath.JPath) + 1736;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
		object obj2 = default(object);
		obj2..ctor();
		if (obj2 != null)
		{
			object obj3 = obj2 + 24;
			obj3 = list;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
			object obj4 = obj2 + 16;
			obj4 = etag;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
			return (LeaderboardModel)obj2;
		}
		return (LeaderboardModel)(object)new NullReferenceException();
	}
}

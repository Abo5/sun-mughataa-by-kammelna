using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Formats.Asn1;
using System.Linq;
using Cpp2ILInjected;
using HuaweiMobileServices.Location.Location;
using Kammelna.Server.Models.Clans;
using Server.Models;
using Spine;
using Unity.Services.Authentication.Shared;
using UnityEngine;
using UnityEngine.Rendering;

public static class SportTeamsUtil
{
	private sealed class <>c__DisplayClass4_0
	{
		public int teamId;

		internal bool <GetSportTeamById>b__0(SportTeam st)
		{
			//IL_0053: Expected I4, but got O
			//IL_0031: Expected O, but got I4
			if (st != null)
			{
				object obj = st.<id>k__BackingField - teamId;
				return obj == null;
			}
			NullReferenceException ex = new NullReferenceException();
			return (byte)(int)ex != 0;
		}
	}

	private sealed class <>c__DisplayClass5_0
	{
		public Action<SportTeam> callback;

		public int id;

		internal void <GetSportTeamById>b__0(List<SportTeam> _)
		{
			//IL_000f: Unknown result type (might be due to invalid IL or missing references)
			//IL_0014: Expected O, but got Unknown
			//IL_0077: Expected O, but got I4
			object obj = typeof(System.Formats.Asn1.SetOfValueComparer) + 1176;
			object obj2 = obj;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v49 @ X0_v2+E4]");
			bool flag = (nint)0 == 0;
			object obj3 = !flag;
			if (obj3 == null)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			}
			SportTeam sportTeamById = GetSportTeamById(id);
			Actions.SafeInvoke((Action<object>)callback, sportTeamById);
		}
	}

	private sealed class <>c__DisplayClass6_0
	{
		public Action<List<SportTeam>> callback;

		internal void <GetSportTeams>b__0(KammelnaResponseModel<List<SportTeam>> response)
		{
			//IL_0046: Unknown result type (might be due to invalid IL or missing references)
			//IL_004b: Expected O, but got Unknown
			//IL_012c: Expected O, but got I
			//IL_0146: Expected O, but got I4
			//IL_0011: Expected O, but got I
			//IL_008e: Expected O, but got I
			//IL_01bc: Expected O, but got I
			//IL_01de: Expected O, but got I4
			//IL_0184: Expected O, but got I4
			//IL_00f0: Expected O, but got I
			bool flag = callback == null;
			object obj = response;
			if (!flag)
			{
				object obj2 = (nint)0 + (nint)2016;
				obj = response.<Model>k__BackingField;
				Actions.SafeInvoke((Action<object>)callback, response.<Model>k__BackingField);
			}
			object obj3 = typeof(System.Formats.Asn1.SetOfValueComparer) + 1176;
			object obj4 = obj3;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v59 @ X0_v5+E4]");
			if ((nint)0 != 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [8BE45A4]");
				object obj5 = (nint)0 & (nint)1;
				if (obj5 != null)
				{
					goto IL_00ab;
				}
			}
			else
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [8BE45A4]");
				object obj6 = (nint)0 & (nint)1;
				bool flag2 = obj6 == null;
				object obj7 = !flag2;
				if (obj7 != null)
				{
					goto IL_00ab;
				}
			}
			_ = 1;
			object obj8 = obj3;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v127 @ X0_v17+E4]");
			bool flag3 = (nint)0 == 0;
			object obj9 = !flag3;
			object obj10 = obj8;
			if (obj9 != null)
			{
				goto IL_00e0;
			}
			goto IL_019a;
			IL_00ab:
			obj8 = obj3;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v127 @ X0_v17+E4]");
			bool flag4 = (nint)0 == 0;
			obj10 = obj8;
			if (!flag4)
			{
				goto IL_00e0;
			}
			goto IL_019a;
			IL_019a:
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			object obj11 = obj3;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v140 @ X0_v8+B8]");
			object obj12 = 0;
			OneShotEvent oneShotEvent = (OneShotEvent)obj12;
			bool flag5 = obj12 == null;
			object obj13 = !flag5;
			if (obj13 == null)
			{
				throw new NullReferenceException();
			}
			goto IL_00fd;
			IL_00e0:
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v127 @ X0_v17+B8]");
			object obj14 = 0;
			oneShotEvent = (OneShotEvent)obj14;
			goto IL_00fd;
			IL_00fd:
			oneShotEvent.IsReady = true;
		}
	}

	private static readonly OneShotEvent <ReadyState>k__BackingField;

	private static OneShotEvent ReadyState
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
			object obj = 152985600;
			object obj2 = typeof(System.Formats.Asn1.SetOfValueComparer) + 1176;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [91E6603]");
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
			return (OneShotEvent)0;
			IL_0085:
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v37 @ X0_v9+B8]");
			return (OneShotEvent)0;
		}
	}

	public static void CallWhenReady(Action callback)
	{
		//IL_000f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0014: Expected O, but got Unknown
		//IL_002a: Expected O, but got I
		//IL_0159: Expected O, but got I4
		//IL_008a: Expected O, but got I
		//IL_01df: Expected O, but got I4
		//IL_0187: Expected O, but got I
		//IL_01a1: Expected O, but got I4
		//IL_00ec: Expected O, but got I
		//IL_010e: Expected O, but got I4
		//IL_0267: Expected O, but got I
		//IL_0217: Expected O, but got I
		//IL_0236: Expected O, but got I
		//IL_0374: Expected O, but got I4
		//IL_0124: Expected O, but got I
		//IL_02c9: Expected O, but got I
		//IL_02e9: Expected O, but got I4
		//IL_03ac: Expected O, but got I
		//IL_03ce: Expected O, but got I4
		//IL_03d7: Expected O, but got I4
		//IL_0315: Expected O, but got I
		//IL_032d: Expected O, but got I4
		//IL_0407: Unknown result type (might be due to invalid IL or missing references)
		//IL_040c: Expected O, but got Unknown
		//IL_0422: Expected O, but got I
		//IL_0430: Expected I, but got O
		object obj = typeof(System.Formats.Asn1.SetOfValueComparer) + 1176;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [91E6604]");
		object obj2 = (nint)0 & (nint)1;
		if (obj2 != null)
		{
			object obj3 = obj;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v53 @ X0_v30+E4]");
			if ((nint)0 != 0)
			{
				goto IL_0074;
			}
		}
		else
		{
			_ = 1;
			object obj3 = obj;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v53 @ X0_v30+E4]");
			bool flag = (nint)0 == 0;
			object obj4 = !flag;
			if (obj4 != null)
			{
				goto IL_0074;
			}
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [8BE45A4]");
		object obj5 = (nint)0 & (nint)1;
		bool flag2 = obj5 == null;
		object obj6 = !flag2;
		if (obj6 != null)
		{
			goto IL_00a7;
		}
		goto IL_01af;
		IL_02ff:
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v169 @ X8_v16+18]");
		object obj7 = (nint)0 & (nint)1;
		bool flag3 = obj7 == null;
		object obj8 = 0;
		Action action = callback;
		if (flag3)
		{
			object obj9 = typeof(System.Diagnostics.DiagnosticSourceEventSource.TransformSpec.PropertySpec.PropertyFetch.EnumeratePropertyFetch<>) + 872;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
			object obj10 = (nint)0 + (nint)1880;
			Action<object> action2 = default(Action<object>);
			action2..ctor((object)null, (IntPtr)obj10);
			object obj11 = obj;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v165 @ X0_v4+E4]");
			if ((nint)0 != 0)
			{
				GetSportTeams(action2);
				return;
			}
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			GetSportTeams(action2);
		}
		return;
		IL_02b9:
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v116 @ X0_v19+B8]");
		object obj12 = 0;
		object obj13 = obj12;
		bool flag4 = obj12 == null;
		obj8 = 0;
		action = callback;
		if (!flag4)
		{
			goto IL_02ff;
		}
		goto IL_03ed;
		IL_03ed:
		throw new NullReferenceException();
		IL_0074:
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [8BE45A4]");
		object obj14 = (nint)0 & (nint)1;
		if (obj14 != null)
		{
			goto IL_00a7;
		}
		goto IL_01af;
		IL_01af:
		_ = 1;
		object obj15 = obj;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v82 @ X0_v42+E4]");
		bool flag5 = (nint)0 == 0;
		object obj16 = !flag5;
		object obj17 = obj15;
		if (obj16 != null)
		{
			goto IL_00dc;
		}
		goto IL_01f5;
		IL_00a7:
		obj15 = obj;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v82 @ X0_v42+E4]");
		bool flag6 = (nint)0 == 0;
		obj17 = obj15;
		if (!flag6)
		{
			goto IL_00dc;
		}
		goto IL_01f5;
		IL_01f5:
		Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		object obj18 = obj;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v111 @ X0_v23+B8]");
		object obj19 = 0;
		OneShotEvent oneShotEvent = (OneShotEvent)obj19;
		bool flag7 = obj19 == null;
		IntPtr intPtr = default(IntPtr);
		action = (Action)(nint)intPtr;
		if (!flag7)
		{
			goto IL_0244;
		}
		goto IL_03ed;
		IL_00dc:
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v82 @ X0_v42+B8]");
		object obj20 = 0;
		oneShotEvent = (OneShotEvent)obj20;
		bool flag8 = obj20 == null;
		object obj21 = !flag8;
		if (obj21 != null)
		{
			goto IL_0244;
		}
		action = (Action)(nint)intPtr;
		goto IL_03ed;
		IL_0244:
		oneShotEvent.CallWhenReady(callback);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [8BE45A4]");
		object obj22 = (nint)0 & (nint)1;
		if (obj22 != null)
		{
			object obj23 = obj;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v116 @ X0_v19+E4]");
			bool flag9 = (nint)0 == 0;
			object obj24 = obj23;
			if (!flag9)
			{
				goto IL_02b9;
			}
		}
		else
		{
			_ = 1;
			object obj23 = obj;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v116 @ X0_v19+E4]");
			bool flag10 = (nint)0 == 0;
			object obj25 = !flag10;
			object obj24 = obj23;
			if (obj25 != null)
			{
				goto IL_02b9;
			}
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		object obj26 = obj;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v115 @ X0_v13+B8]");
		object obj27 = 0;
		obj13 = obj27;
		bool flag11 = obj27 == null;
		object obj28 = !flag11;
		obj8 = 0;
		action = callback;
		if (obj28 != null)
		{
			goto IL_02ff;
		}
		goto IL_03ed;
	}

	public static SportTeam GetSportTeamById(int teamId)
	{
		//IL_000f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0014: Expected O, but got Unknown
		//IL_0028: Unknown result type (might be due to invalid IL or missing references)
		//IL_002d: Expected O, but got Unknown
		//IL_0064: Expected O, but got I4
		//IL_00b3: Expected O, but got I
		//IL_017b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0180: Expected O, but got Unknown
		//IL_0199: Unknown result type (might be due to invalid IL or missing references)
		//IL_019e: Expected O, but got Unknown
		//IL_020c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0211: Expected O, but got Unknown
		//IL_00f4: Unknown result type (might be due to invalid IL or missing references)
		//IL_00f9: Expected O, but got Unknown
		//IL_0105: Expected O, but got I
		//IL_0111: Expected O, but got I
		//IL_012c: Expected I, but got O
		object obj = typeof(SkeletonBinary.SkeletonInput) + 896;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
		<>c__DisplayClass4_0 <>c__DisplayClass4_ = default(<>c__DisplayClass4_0);
		<>c__DisplayClass4_..ctor();
		if (<>c__DisplayClass4_ != null)
		{
			object obj2 = typeof(Unity.Services.Authentication.Shared.ApiConfiguration) + 4040;
			<>c__DisplayClass4_.teamId = teamId;
			object obj3 = obj2;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v65 @ X0_v6+E4]");
			bool flag = (nint)0 == 0;
			object obj4 = !flag;
			if (obj4 == null)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			}
			CachedModel<List<SportTeam>> sportTeams = CachedModels.SportTeams;
			if (sportTeams != null)
			{
				object obj5 = (nint)0 + (nint)560;
				Func<object, bool> func = (Func<object, bool>)obj5;
				object model = ((CachedModel<object>)(object)sportTeams).Model;
				if (model != null)
				{
					object obj6 = typeof(Func<AndroidJavaObject, IList<HWLocation>>) + 3312;
					object obj7 = (nint)0 + (nint)792;
					object obj8 = (nint)0 + (nint)1216;
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
					Func<object, bool> func2 = default(Func<object, bool>);
					func2..ctor((object)<>c__DisplayClass4_, (IntPtr)obj7);
					object obj9 = Enumerable.FirstOrDefault((IEnumerable<object>)model, func2);
					bool flag2 = obj9 == null;
					func = func2;
					if (!flag2)
					{
						return (SportTeam)obj9;
					}
				}
				object obj10 = typeof(System.Formats.Asn1.SetOfValueComparer) + 1160;
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
				object obj11 = typeof(IEnumerator<KeyValuePair<int, (RTHandle, int)>>) + 3656;
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
				List<object> list = default(List<object>);
				list..ctor();
				object obj13 = default(object);
				object obj12 = obj13 + 56;
				obj12 = list;
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
				obj13..ctor();
				return (SportTeam)obj13;
			}
		}
		return (SportTeam)(object)new NullReferenceException();
	}

	public static void GetSportTeamById(int id, Action<SportTeam> callback)
	{
		//IL_000f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0014: Expected O, but got Unknown
		//IL_0028: Unknown result type (might be due to invalid IL or missing references)
		//IL_002d: Expected O, but got Unknown
		//IL_0039: Expected O, but got I
		//IL_0048: Unknown result type (might be due to invalid IL or missing references)
		//IL_004d: Expected O, but got Unknown
		//IL_0056: Unknown result type (might be due to invalid IL or missing references)
		//IL_005b: Expected O, but got Unknown
		//IL_009a: Expected I, but got O
		object obj = typeof(SkeletonBinary.SkeletonInput) + 904;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
		<>c__DisplayClass5_0 <>c__DisplayClass5_ = default(<>c__DisplayClass5_0);
		<>c__DisplayClass5_..ctor();
		object obj2 = typeof(System.Diagnostics.DiagnosticSourceEventSource.TransformSpec.PropertySpec.PropertyFetch.EnumeratePropertyFetch<>) + 872;
		object obj3 = (nint)0 + (nint)800;
		object obj4 = typeof(System.Formats.Asn1.SetOfValueComparer) + 1176;
		object obj5 = <>c__DisplayClass5_ + 16;
		obj5 = callback;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
		<>c__DisplayClass5_.id = id;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
		Action<object> action = default(Action<object>);
		action..ctor((object)<>c__DisplayClass5_, (IntPtr)obj3);
		object obj6 = obj4;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v114 @ X0_v10+E4]");
		if ((nint)0 != 0)
		{
			GetSportTeams(action);
			return;
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		GetSportTeams(action);
	}

	public static void GetSportTeams(Action<List<SportTeam>> callback)
	{
		//IL_000f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0014: Expected O, but got Unknown
		//IL_0028: Unknown result type (might be due to invalid IL or missing references)
		//IL_002d: Expected O, but got Unknown
		//IL_0039: Expected O, but got I
		//IL_0042: Unknown result type (might be due to invalid IL or missing references)
		//IL_0047: Expected O, but got Unknown
		//IL_0079: Expected I, but got O
		object obj = typeof(SkeletonBinary.SkeletonInput) + 912;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
		<>c__DisplayClass6_0 <>c__DisplayClass6_ = default(<>c__DisplayClass6_0);
		<>c__DisplayClass6_..ctor();
		object obj2 = typeof(System.Diagnostics.DiagnosticSourceEventSource.TransformSpec.PropertySpec.PropertyFetch.EnumeratePropertyFetch<>) + 408;
		object obj3 = (nint)0 + (nint)808;
		object obj4 = <>c__DisplayClass6_ + 16;
		obj4 = callback;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
		Action<object> action = default(Action<object>);
		action..ctor((object)<>c__DisplayClass6_, (IntPtr)obj3);
		KammelnaRequests.GetSportTeams(action);
	}

	static SportTeamsUtil()
	{
		//IL_000f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0014: Expected O, but got Unknown
		//IL_0023: Unknown result type (might be due to invalid IL or missing references)
		//IL_0028: Expected O, but got Unknown
		object obj = typeof(MemberAchievementClanFeedData) + 3440;
		object obj2 = typeof(System.Formats.Asn1.SetOfValueComparer) + 1176;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
		OneShotEvent oneShotEvent = default(OneShotEvent);
		oneShotEvent..ctor();
		object obj3 = obj2;
		object obj4 = oneShotEvent;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
	}
}

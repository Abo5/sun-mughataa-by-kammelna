using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlTypes;
using System.Diagnostics;
using Cpp2ILInjected;
using Kammelna.Server;
using Microsoft.Extensions.DependencyInjection.ServiceLookup;
using Sfs2X.Entities;
using UnityEngine;
using UnityEngine.Purchasing.Telemetry;
using UnityEngine.Rendering;
using UnityEngine.TextCore;

public class MassTournamentsListConnector : MonoBehaviour
{
	private MassTournamentsListEventsChannel eventsChannels;

	private void Awake()
	{
		//IL_000f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0014: Expected O, but got Unknown
		//IL_0020: Expected O, but got I
		//IL_002f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0034: Expected O, but got Unknown
		//IL_0040: Expected O, but got I
		//IL_0100: Expected I, but got O
		//IL_005d: Expected I, but got O
		//IL_0088: Expected I, but got O
		//IL_00ae: Expected I, but got O
		//IL_00d9: Expected I, but got O
		object obj = typeof(System.Diagnostics.DiagnosticSourceEventSource.TransformSpec.PropertySpec.PropertyFetch.EnumeratePropertyFetch<>) + 3344;
		object obj2 = (nint)0 + (nint)3640;
		object obj3 = typeof(System.Diagnostics.DiagnosticSourceEventSource.TransformSpec.PropertySpec.PropertyFetch.EnumeratePropertyFetch<>) + 3576;
		object obj4 = (nint)0 + (nint)3648;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
		Action<object> action = default(Action<object>);
		action..ctor((object)this, (IntPtr)obj2);
		SFS.OnRoomCreated += action;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
		Action<object> action2 = default(Action<object>);
		action2..ctor((object)this, (IntPtr)obj2);
		SFS.OnRoomRemoved += action2;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
		Action<object> action3 = default(Action<object>);
		action3..ctor((object)this, (IntPtr)obj2);
		SFS.OnJoinRoom += action3;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
		Action<object> action4 = default(Action<object>);
		action4..ctor((object)this, (IntPtr)obj4);
		SFS.OnRoomGroupSubscribe += action4;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
		Action<object> action5 = default(Action<object>);
		action5..ctor((object)this, (IntPtr)obj4);
		SFS.OnRoomGroupUnsubscribe += action5;
	}

	private void OnDestroy()
	{
		//IL_000f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0014: Expected O, but got Unknown
		//IL_0020: Expected O, but got I
		//IL_002f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0034: Expected O, but got Unknown
		//IL_0040: Expected O, but got I
		//IL_0100: Expected I, but got O
		//IL_005d: Expected I, but got O
		//IL_0088: Expected I, but got O
		//IL_00ae: Expected I, but got O
		//IL_00d9: Expected I, but got O
		object obj = typeof(System.Diagnostics.DiagnosticSourceEventSource.TransformSpec.PropertySpec.PropertyFetch.EnumeratePropertyFetch<>) + 3344;
		object obj2 = (nint)0 + (nint)3640;
		object obj3 = typeof(System.Diagnostics.DiagnosticSourceEventSource.TransformSpec.PropertySpec.PropertyFetch.EnumeratePropertyFetch<>) + 3576;
		object obj4 = (nint)0 + (nint)3648;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
		Action<object> action = default(Action<object>);
		action..ctor((object)this, (IntPtr)obj2);
		SFS.OnRoomCreated -= action;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
		Action<object> action2 = default(Action<object>);
		action2..ctor((object)this, (IntPtr)obj2);
		SFS.OnRoomRemoved -= action2;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
		Action<object> action3 = default(Action<object>);
		action3..ctor((object)this, (IntPtr)obj2);
		SFS.OnJoinRoom -= action3;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
		Action<object> action4 = default(Action<object>);
		action4..ctor((object)this, (IntPtr)obj4);
		SFS.OnRoomGroupSubscribe -= action4;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
		Action<object> action5 = default(Action<object>);
		action5..ctor((object)this, (IntPtr)obj4);
		SFS.OnRoomGroupUnsubscribe -= action5;
	}

	private void Refresh(string _)
	{
		eventsChannels.TriggerTournamentsChanged();
		ScheduleUpdates();
	}

	private void Refresh(Room _)
	{
		eventsChannels.TriggerTournamentsChanged();
		ScheduleUpdates();
	}

	private void Refresh()
	{
		eventsChannels.TriggerTournamentsChanged();
		ScheduleUpdates();
	}

	private unsafe void ScheduleUpdates()
	{
		//IL_0010: Expected O, but got I
		//IL_09f2: Expected O, but got I4
		//IL_09fb: Expected O, but got I4
		//IL_0a04: Expected O, but got I4
		//IL_0024: Unknown result type (might be due to invalid IL or missing references)
		//IL_0029: Expected O, but got Unknown
		//IL_0031: Expected I, but got O
		//IL_0041: Expected O, but got I
		//IL_011b: Expected O, but got I
		//IL_013f: Expected O, but got I4
		//IL_0149: Expected O, but got I4
		//IL_0152: Expected O, but got I4
		//IL_0239: Unknown result type (might be due to invalid IL or missing references)
		//IL_023e: Expected O, but got Unknown
		//IL_024d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0252: Expected O, but got Unknown
		//IL_0261: Unknown result type (might be due to invalid IL or missing references)
		//IL_0266: Expected O, but got Unknown
		//IL_0275: Unknown result type (might be due to invalid IL or missing references)
		//IL_027a: Expected O, but got Unknown
		//IL_0289: Unknown result type (might be due to invalid IL or missing references)
		//IL_028e: Expected O, but got Unknown
		//IL_029a: Expected O, but got I
		//IL_02b3: Expected O, but got I4
		//IL_007c: Expected O, but got I
		//IL_0330: Expected O, but got I
		//IL_016a: Expected O, but got I4
		//IL_0174: Expected O, but got I4
		//IL_017d: Expected O, but got I4
		//IL_018d: Expected O, but got Ref
		//IL_0a30: Unknown result type (might be due to invalid IL or missing references)
		//IL_0a35: Expected O, but got Unknown
		//IL_0403: Expected O, but got I4
		//IL_019a: Unknown result type (might be due to invalid IL or missing references)
		//IL_019f: Expected O, but got Unknown
		//IL_01a8: Unknown result type (might be due to invalid IL or missing references)
		//IL_01ad: Expected O, but got Unknown
		//IL_01c5: Expected O, but got I
		//IL_01e8: Expected O, but got I4
		//IL_0202: Expected O, but got I4
		//IL_020c: Expected O, but got I4
		//IL_021c: Expected O, but got Ref
		//IL_0ab7: Expected O, but got I
		//IL_0aca: Unknown result type (might be due to invalid IL or missing references)
		//IL_0acf: Expected O, but got Unknown
		//IL_036b: Expected O, but got I
		//IL_0092: Unknown result type (might be due to invalid IL or missing references)
		//IL_0097: Expected O, but got Unknown
		//IL_00a0: Unknown result type (might be due to invalid IL or missing references)
		//IL_00a5: Expected O, but got Unknown
		//IL_00b0: Unknown result type (might be due to invalid IL or missing references)
		//IL_00b5: Expected O, but got Unknown
		//IL_07ba: Expected O, but got I4
		//IL_0a71: Unknown result type (might be due to invalid IL or missing references)
		//IL_0a76: Expected O, but got Unknown
		//IL_0426: Unknown result type (might be due to invalid IL or missing references)
		//IL_042b: Expected O, but got Unknown
		//IL_0b83: Expected O, but got I4
		//IL_0381: Unknown result type (might be due to invalid IL or missing references)
		//IL_0386: Expected O, but got Unknown
		//IL_039c: Expected O, but got I
		//IL_03a7: Unknown result type (might be due to invalid IL or missing references)
		//IL_03ac: Expected O, but got Unknown
		//IL_07ce: Unknown result type (might be due to invalid IL or missing references)
		//IL_07d3: Expected O, but got Unknown
		//IL_07eb: Expected O, but got I
		//IL_0476: Expected O, but got I
		//IL_088a: Expected O, but got I4
		//IL_0549: Expected O, but got I4
		//IL_0bc5: Expected O, but got I
		//IL_0826: Expected O, but got I
		//IL_04b1: Expected O, but got I
		//IL_0901: Expected O, but got I4
		//IL_0aff: Unknown result type (might be due to invalid IL or missing references)
		//IL_0b04: Expected O, but got Unknown
		//IL_08ad: Unknown result type (might be due to invalid IL or missing references)
		//IL_08b2: Expected O, but got Unknown
		//IL_05b0: Expected O, but got I4
		//IL_056c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0571: Expected O, but got Unknown
		//IL_0834: Unknown result type (might be due to invalid IL or missing references)
		//IL_0839: Expected O, but got Unknown
		//IL_084f: Expected O, but got I
		//IL_04c7: Unknown result type (might be due to invalid IL or missing references)
		//IL_04cc: Expected O, but got Unknown
		//IL_04e2: Expected O, but got I
		//IL_04ed: Unknown result type (might be due to invalid IL or missing references)
		//IL_04f2: Expected O, but got Unknown
		//IL_0609: Expected O, but got I
		//IL_068a: Unknown result type (might be due to invalid IL or missing references)
		//IL_068f: Expected O, but got Unknown
		//IL_06a9: Expected O, but got I4
		//IL_06b2: Expected O, but got I4
		//IL_02e1: Expected O, but got I4
		//IL_063b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0640: Expected O, but got Unknown
		//IL_06e0: Expected O, but got I
		//IL_0702: Expected O, but got I4
		//IL_0666: Expected O, but got I4
		//IL_074e: Expected I, but got O
		//IL_0782: Expected O, but got I4
		//IL_0793: Expected O, but got I4
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [91E6D05]");
		object obj = 0;
		StopAllCoroutines();
		IEnumerable<Room> massTournamentRooms = SFS.MassTournamentRooms;
		bool flag = massTournamentRooms == null;
		TimeSpan timeSpan = (TimeSpan)0;
		object obj2 = 0;
		DateTime dateTime = (DateTime)0;
		object obj5;
		bool flag3 = default(bool);
		object obj11 = default(object);
		object obj13;
		object obj14 = default(object);
		object obj7 = default(object);
		object obj10;
		object obj12;
		if (!flag)
		{
			object obj3 = typeof(Func<Type, Microsoft.Extensions.DependencyInjection.ServiceLookup.ServiceCallSite>) + 3696;
			nint num = (nint)massTournamentRooms;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v78 @ X8_v15 (Il2CppClass<System.Collections.Generic.IEnumerable`1<Sfs2X.Entities.Room>>)+12E]");
			object obj4 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v78 @ X8_v15 (Il2CppClass<System.Collections.Generic.IEnumerable`1<Sfs2X.Entities.Room>>)+12E]");
			if ((nint)0 == 0)
			{
				goto IL_00f9;
			}
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v78 @ X8_v15 (Il2CppClass<System.Collections.Generic.IEnumerable`1<Sfs2X.Entities.Room>>)+B0]");
			obj5 = (nint)0 + (nint)8;
			bool flag2 = flag3;
			while (true)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v146 @ X10_v11-8]");
				object obj6 = 0 - obj3;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v146 @ X10_v11-8]");
				if (0 == (nint)obj3)
				{
					break;
				}
				obj7 = obj5 + 16;
				obj4--;
				obj6 = obj4 - 1;
				bool flag4 = obj6 == null;
				flag3 = (nint)obj4 != 1;
				flag2 = flag3;
				obj5 = obj7;
				if (flag3)
				{
					continue;
				}
				goto IL_00f9;
			}
			object obj8 = num + obj5;
			object obj9 = obj8 + 312;
			obj10 = obj9;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v306 @ X8_v35+8]");
			dateTime = (DateTime)0;
			Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v306 @ X8_v35] (should have been resolved before IL gen)");
			bool flag5 = obj11 == null;
			obj12 = 0;
			flag3 = flag2;
			obj7 = obj5;
			timeSpan = (TimeSpan)0;
			obj12 = 0;
			obj13 = obj14;
			obj = (object)(&obj2);
			if (!flag5)
			{
				goto IL_022a;
			}
			goto IL_08c0;
		}
		goto IL_0a12;
		IL_022a:
		object obj15 = typeof(UnityEngine.TextCore.HorizontalAlignment) + 2528;
		object obj16 = typeof(IEnumerator<KeyValuePair<int, (RTHandle, int)>>) + 1128;
		object obj17 = typeof(DataRelation) + 712;
		object obj18 = typeof(UnityEngine.Purchasing.Telemetry.TelemetryMetricsInstanceWrapper) + 1032;
		object obj19 = typeof(SqlSingle[]) + 2376;
		object obj20 = (nint)0 + (nint)3656;
		object obj22 = default(object);
		object obj21 = obj22;
		float num3 = default(float);
		float num2 = num3;
		timeSpan = (TimeSpan)0;
		object obj23 = obj11;
		object obj27 = default(object);
		object obj28 = default(object);
		Room room = default(Room);
		Action action = default(Action);
		object obj37 = default(object);
		object obj48 = default(object);
		while (true)
		{
			object obj24 = obj23;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v444 @ X8_v20+12E]");
			obj10 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v444 @ X8_v20+12E]");
			if ((nint)0 == 0)
			{
				goto IL_03f0;
			}
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v444 @ X8_v20+B0]");
			object obj25 = (nint)0 + (nint)8;
			bool flag6 = flag3;
			while (true)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v519 @ X10_v25-8]");
				object obj6 = 0 - obj15;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v519 @ X10_v25-8]");
				if (0 == (nint)obj15)
				{
					break;
				}
				obj7 = obj25 + 16;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v444 @ X8_v20+12E]");
				obj10 = -1;
				obj6 = obj10 - 1;
				bool flag4 = obj6 == null;
				flag3 = (nint)obj10 != 1;
				flag6 = flag3;
				obj25 = obj7;
				if (flag3)
				{
					continue;
				}
				goto IL_03f0;
			}
			obj10 = obj25;
			object obj26 = obj24 + obj25;
			obj27 = obj26 + 312;
			flag3 = flag6;
			obj7 = obj25;
			goto IL_0a9f;
			IL_02c0:
			bool flag7 = 0 == 0;
			TimeSpan timeSpan2;
			timeSpan = timeSpan2;
			obj23 = 0;
			obj22 = obj21;
			num3 = num2;
			timeSpan = timeSpan2;
			obj13 = obj14;
			obj5 = obj7;
			if (!flag7)
			{
				continue;
			}
			goto IL_08c0;
			IL_0536:
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @B0D070");
			obj14 = 0;
			goto IL_0b2d;
			IL_0b2d:
			obj = obj28;
			Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v751 @ X0_v34] (should have been resolved before IL gen)");
			MassTournamentInfo massTournamentInfo = SFSKammelnaRoomExtensions.GetMassTournamentInfo(room);
			if (massTournamentInfo != null)
			{
				object obj29 = obj17;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v758 @ X0_v39+E4]");
				bool flag8 = (nint)0 == 0;
				object obj30 = !flag8;
				if (obj30 == null)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
				}
				DateTime now = DateTime.Now;
				timeSpan2 = massTournamentInfo.<FinishTime>k__BackingField - now;
				obj = obj18;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v257 @ X8_v4+E4]");
				obj10 = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v257 @ X8_v4+E4]");
				if ((nint)0 != 0)
				{
					object obj31 = timeSpan2 & -9223372036854775808L;
					if (obj31 != null)
					{
						obj14 = 0;
						dateTime = now;
						goto IL_02c0;
					}
				}
				else
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
					object obj32 = timeSpan2 & -9223372036854775808L;
					bool flag9 = obj32 == null;
					object obj33 = !flag9;
					obj14 = 0;
					dateTime = now;
					if (obj33 != null)
					{
						goto IL_02c0;
					}
				}
				object obj34 = obj18;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v780 @ X0_v46+E4]");
				obj = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v780 @ X0_v46+E4]");
				bool flag10 = (nint)0 == 0;
				object obj35 = !flag10;
				if (obj35 == null)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
				}
				double totalSeconds = timeSpan.TotalSeconds;
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
				action..ctor(eventsChannels, (IntPtr)obj20);
				double num4 = totalSeconds + 1.0;
				Coroutine coroutine = UIExtensions.WaitForSeconds(this, (float)num4, action);
				obj21 = 0;
				num2 = (float)num4;
				obj14 = 0;
				dateTime = (DateTime)action;
				goto IL_02c0;
			}
			goto IL_08ce;
			IL_03f0:
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @B0D070");
			obj14 = 0;
			goto IL_0a9f;
			IL_0a9f:
			obj = obj27;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v535 @ X0_v30+8]");
			dateTime = (DateTime)0;
			Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v535 @ X0_v30] (should have been resolved before IL gen)");
			object obj36 = obj37 & 1;
			if (obj36 != null)
			{
				if (0 == 0)
				{
					break;
				}
				object obj38 = obj2;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v637 @ X8_v23+12E]");
				obj10 = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v637 @ X8_v23+12E]");
				if ((nint)0 == 0)
				{
					goto IL_0536;
				}
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v637 @ X8_v23+B0]");
				object obj39 = (nint)0 + (nint)8;
				bool flag11 = flag3;
				while (true)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v729 @ X10_v20-8]");
					object obj6 = 0 - obj16;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v729 @ X10_v20-8]");
					if (0 == (nint)obj16)
					{
						break;
					}
					obj7 = obj39 + 16;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v637 @ X8_v23+12E]");
					obj10 = -1;
					obj6 = obj10 - 1;
					bool flag4 = obj6 == null;
					flag3 = (nint)obj10 != 1;
					flag11 = flag3;
					obj39 = obj7;
					if (flag3)
					{
						continue;
					}
					goto IL_0536;
				}
				obj10 = obj39;
				object obj40 = obj38 + obj39;
				obj28 = obj40 + 312;
				flag3 = flag11;
				obj7 = obj39;
				goto IL_0b2d;
			}
			obj22 = obj21;
			num3 = num2;
			object obj41 = 0;
			while (true)
			{
				if (0 == 0)
				{
					goto IL_0b69;
				}
				object obj42 = typeof(UnityEngine.TextCore.HorizontalAlignment) + 2344;
				object obj43 = obj2;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v564 @ X8_v7+12E]");
				obj10 = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v564 @ X8_v7+12E]");
				if ((nint)0 == 0)
				{
					goto IL_0877;
				}
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v564 @ X8_v7+B0]");
				object obj44 = (nint)0 + (nint)8;
				while (true)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v708 @ X10_v7-8]");
					if (0 == (nint)obj42)
					{
						break;
					}
					obj7 = obj44 + 16;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v564 @ X8_v7+12E]");
					obj10 = -1;
					bool flag12 = (nint)obj10 != 1;
					obj44 = obj7;
					if (flag12)
					{
						continue;
					}
					goto IL_0877;
				}
				obj10 = obj44;
				object obj45 = obj43 + obj44;
				object obj46 = obj45 + 312;
				obj7 = obj44;
				goto IL_0bb5;
				IL_0b69:
				bool flag13 = obj41 == null;
				object obj47 = !flag13;
				if (obj47 == null)
				{
					return;
				}
				OutOfMemoryException ex = new OutOfMemoryException();
				if ((nint)dateTime != 1)
				{
					break;
				}
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @6CB0B80");
				obj41 = obj48;
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @6CB0BB0");
				obj12 = obj48;
				continue;
				IL_0877:
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @B0D070");
				obj14 = 0;
				goto IL_0bb5;
				IL_0bb5:
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v744 @ X0_v7+8]");
				dateTime = (DateTime)0;
				Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v744 @ X0_v7] (should have been resolved before IL gen)");
				goto IL_0b69;
			}
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @1C99C14");
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @6CB03A0");
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2B060");
			return;
		}
		NullReferenceException ex2 = new NullReferenceException();
		obj22 = obj21;
		num3 = num2;
		obj13 = obj14;
		obj5 = obj7;
		goto IL_0935;
		IL_0a12:
		throw new NullReferenceException();
		IL_0935:
		obj14 = obj13;
		obj7 = obj5;
		goto IL_0a12;
		IL_08c0:
		NullReferenceException ex3 = new NullReferenceException();
		goto IL_0935;
		IL_08ce:
		NullReferenceException ex4 = new NullReferenceException();
		obj22 = obj21;
		num3 = num2;
		obj13 = obj14;
		obj5 = obj7;
		dateTime = (DateTime)0;
		goto IL_0935;
		IL_00f9:
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @B0D070");
		object obj49 = default(object);
		obj10 = obj49;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v193 @ X0_v65+8]");
		dateTime = (DateTime)0;
		Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v193 @ X0_v65] (should have been resolved before IL gen)");
		bool flag14 = obj11 == null;
		object obj50 = !flag14;
		obj12 = 0;
		obj14 = 0;
		if (obj50 != null)
		{
			goto IL_022a;
		}
		timeSpan = (TimeSpan)0;
		obj12 = 0;
		obj13 = 0;
		obj5 = obj7;
		obj = (object)(&obj2);
		goto IL_08c0;
	}
}

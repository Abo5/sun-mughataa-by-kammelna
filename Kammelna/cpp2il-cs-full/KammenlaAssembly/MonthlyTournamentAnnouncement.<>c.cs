using System;
using System.Collections.Generic;
using System.Data.SqlTypes;
using Cpp2ILInjected;
using HuaweiMobileServices.Location.Location;
using ListView;
using Mono.Btls;
using UnityEngine;

public class MonthlyTournamentAnnouncement : ListViewItem<TournamentDataHolder, int>
{
	[Serializable]
	private sealed class <>c
	{
		public static readonly <>c <>9;

		public static Func<TournamentModel, DateTime> <>9__4_0;

		static <>c()
		{
			//IL_000f: Unknown result type (might be due to invalid IL or missing references)
			//IL_0014: Expected O, but got Unknown
			object obj = typeof(Mono.Btls.MonoBtlsBioMono.BioControlFunc) + 184;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
			object obj2 = default(object);
			obj2..ctor();
			object obj3 = obj;
			object obj4 = obj2;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
		}

		internal DateTime <SetStartTime>b__4_0(TournamentModel model)
		{
			if (model != null)
			{
				TournamentData <Info>k__BackingField = model.<Info>k__BackingField;
				if (model.<Info>k__BackingField != null)
				{
					return <Info>k__BackingField.<StartingTime>k__BackingField;
				}
			}
			return (DateTime)new NullReferenceException();
		}
	}

	private DateTimeText timeToStart;

	private TournamentsEventsChannel eventsChannel;

	private void Awake()
	{
		//IL_000f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0014: Expected O, but got Unknown
		//IL_0020: Expected O, but got I
		//IL_0058: Expected I, but got O
		object obj = typeof(SqlSingle[]) + 2376;
		object obj2 = (nint)0 + (nint)184;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
		Action action = default(Action);
		action..ctor(this, (IntPtr)obj2);
		eventsChannel.OnTournamentsChanged += action;
		SetStartTime();
	}

	private void OnDestroy()
	{
		//IL_000f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0014: Expected O, but got Unknown
		//IL_0020: Expected O, but got I
		//IL_004d: Expected I, but got O
		object obj = typeof(SqlSingle[]) + 2376;
		object obj2 = (nint)0 + (nint)184;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
		Action action = default(Action);
		action..ctor(this, (IntPtr)obj2);
		eventsChannel.OnTournamentsChanged -= action;
	}

	private void SetStartTime()
	{
		//IL_0014: Unknown result type (might be due to invalid IL or missing references)
		//IL_0019: Expected O, but got Unknown
		//IL_00e1: Expected O, but got I
		//IL_00f1: Expected O, but got I
		//IL_0101: Expected O, but got I
		//IL_0123: Expected O, but got I4
		//IL_0066: Expected O, but got I
		//IL_0076: Expected O, but got I
		//IL_0086: Expected O, but got I
		//IL_00a8: Expected O, but got I4
		//IL_015b: Expected O, but got I4
		//IL_01be: Unknown result type (might be due to invalid IL or missing references)
		//IL_01c3: Expected O, but got Unknown
		//IL_01d9: Expected O, but got I
		//IL_01ea: Expected I, but got O
		//IL_0208: Expected O, but got I
		//IL_018b: Expected O, but got I
		object obj = typeof(Mono.Btls.MonoBtlsBioMono.BioControlFunc) + 184;
		IEnumerable<TournamentModel> tournaments = eventsChannel.GetTournaments(TournamentType.OfficialMonthly);
		object obj2 = obj;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v146 @ X0_v11+E4]");
		object obj4;
		object obj6;
		Func<object, DateTime> func;
		object obj3;
		if ((nint)0 != 0)
		{
			obj3 = (nint)0 + (nint)1944;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v146 @ X0_v11+B8]");
			obj4 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v152 @ X8_v7+8]");
			func = (Func<object, DateTime>)0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v152 @ X8_v7+8]");
			bool flag = (nint)0 == 0;
			object obj5 = !flag;
			if (obj5 == null)
			{
				obj6 = obj3;
				goto IL_0139;
			}
		}
		else
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			obj2 = obj;
			obj6 = (nint)0 + (nint)1944;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v146 @ X0_v11+B8]");
			obj4 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v152 @ X8_v7+8]");
			func = (Func<object, DateTime>)0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v152 @ X8_v7+8]");
			bool flag2 = (nint)0 == 0;
			object obj7 = !flag2;
			obj3 = obj6;
			if (obj7 == null)
			{
				goto IL_0139;
			}
		}
		goto IL_0190;
		IL_0139:
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v146 @ X0_v11+E4]");
		bool flag3 = (nint)0 == 0;
		object obj8 = !flag3;
		if (obj8 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			object obj9 = obj;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v158 @ X8_v13+B8]");
			obj4 = 0;
		}
		object obj10 = typeof(Func<AndroidJavaObject, IList<HWLocation>>) + 3928;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
		object obj11 = (nint)0 + (nint)2072;
		Func<object, DateTime> func2 = default(Func<object, DateTime>);
		func2..ctor(obj4, (IntPtr)obj11);
		object obj12 = obj;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v138 @ X8_v12+B8]");
		object obj13 = (nint)0 + (nint)8;
		obj13 = func2;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
		func = func2;
		obj3 = obj6;
		goto IL_0190;
		IL_0190:
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2DCBA74");
		DateTime date = default(DateTime);
		timeToStart.SetDate(date);
	}

	public MonthlyTournamentAnnouncement()
	{
		((ListViewItem<object, int>)(object)this)..ctor();
	}
}

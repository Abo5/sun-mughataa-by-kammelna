using System;
using System.Collections.Generic;
using System.Linq;
using Cpp2ILInjected;
using HuaweiMobileServices.Location.Location;
using Mono.Btls;
using UnityEngine;
using UnityEngine.AdaptivePerformance;
using UnityEngine.Purchasing.Telemetry;

public class OfficialMonthlyTournamentFilter : ITournamentFilter
{
	[Serializable]
	private sealed class <>c
	{
		public static readonly <>c <>9;

		public static Func<TournamentModel, bool> <>9__0_0;

		public static Func<TournamentModel, DateTime> <>9__0_1;

		static <>c()
		{
			//IL_000f: Unknown result type (might be due to invalid IL or missing references)
			//IL_0014: Expected O, but got Unknown
			object obj = typeof(Mono.Btls.MonoBtlsBioMono.BioControlFunc) + 1456;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
			object obj2 = default(object);
			obj2..ctor();
			object obj3 = obj;
			object obj4 = obj2;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
		}

		internal bool <ApplyFilter>b__0_0(TournamentModel tournament)
		{
			//IL_0081: Expected I4, but got O
			//IL_005f: Expected O, but got I4
			if (tournament != null)
			{
				TournamentData <Info>k__BackingField = tournament.<Info>k__BackingField;
				if (tournament.<Info>k__BackingField != null)
				{
					object obj = <Info>k__BackingField.<Type>k__BackingField - 4;
					return obj == null;
				}
			}
			NullReferenceException ex = new NullReferenceException();
			return (byte)(int)ex != 0;
		}

		internal DateTime <ApplyFilter>b__0_1(TournamentModel tournament)
		{
			if (tournament != null)
			{
				TournamentData <Info>k__BackingField = tournament.<Info>k__BackingField;
				if (tournament.<Info>k__BackingField != null)
				{
					return <Info>k__BackingField.<StartingTime>k__BackingField;
				}
			}
			return (DateTime)new NullReferenceException();
		}
	}

	public IEnumerable<TournamentModel> ApplyFilter(IEnumerable<TournamentModel> tournaments)
	{
		//IL_0009: Expected O, but got I4
		//IL_0018: Unknown result type (might be due to invalid IL or missing references)
		//IL_001d: Expected O, but got Unknown
		//IL_0033: Expected O, but got I
		//IL_011e: Expected O, but got I4
		//IL_0091: Expected O, but got I
		//IL_00a1: Expected O, but got I
		//IL_00b1: Expected O, but got I
		//IL_00d3: Expected O, but got I4
		//IL_0152: Expected O, but got I
		//IL_0162: Expected O, but got I
		//IL_0172: Expected O, but got I
		//IL_0194: Expected O, but got I4
		//IL_02c6: Expected O, but got I
		//IL_02d6: Expected O, but got I
		//IL_02e6: Expected O, but got I
		//IL_0308: Expected O, but got I4
		//IL_024b: Expected O, but got I
		//IL_025b: Expected O, but got I
		//IL_026b: Expected O, but got I
		//IL_028d: Expected O, but got I4
		//IL_01cc: Expected O, but got I4
		//IL_0340: Expected O, but got I4
		//IL_039a: Unknown result type (might be due to invalid IL or missing references)
		//IL_039f: Expected O, but got Unknown
		//IL_03b5: Expected O, but got I
		//IL_03c6: Expected I, but got O
		//IL_03e4: Expected O, but got I
		//IL_041a: Unknown result type (might be due to invalid IL or missing references)
		//IL_041f: Expected O, but got Unknown
		//IL_0435: Expected O, but got I
		//IL_0446: Expected I, but got O
		//IL_0464: Expected O, but got I
		//IL_01fc: Expected O, but got I
		//IL_0370: Expected O, but got I
		object obj = 152985600;
		object obj2 = typeof(Mono.Btls.MonoBtlsBioMono.BioControlFunc) + 1456;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [91E6D09]");
		object obj3 = (nint)0 & (nint)1;
		object obj4;
		if (obj3 != null)
		{
			obj4 = obj2;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v100 @ X0_v18+E4]");
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
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v100 @ X0_v18+E4]");
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
		object obj7 = (nint)0 + (nint)3808;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v100 @ X0_v18+B8]");
		object obj8 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v114 @ X8_v17+8]");
		Func<object, bool> predicate = (Func<object, bool>)0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v114 @ X8_v17+8]");
		bool flag3 = (nint)0 == 0;
		object obj9 = !flag3;
		object obj10 = obj7;
		if (obj9 == null)
		{
			goto IL_01aa;
		}
		goto IL_0201;
		IL_031e:
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v178 @ X0_v8+E4]");
		bool flag4 = (nint)0 == 0;
		object obj11 = !flag4;
		object obj13;
		if (obj11 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			object obj12 = obj2;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v196 @ X8_v12+B8]");
			obj13 = 0;
		}
		object obj14 = typeof(Func<AndroidJavaObject, IList<HWLocation>>) + 3928;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
		object obj15 = (nint)0 + (nint)3824;
		Func<object, DateTime> func = default(Func<object, DateTime>);
		func..ctor(obj13, (IntPtr)obj15);
		object obj16 = obj2;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v154 @ X8_v11+B8]");
		object obj17 = (nint)0 + (nint)16;
		obj17 = func;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
		object obj19;
		object obj18 = obj19;
		Func<object, DateTime> keySelector = func;
		goto IL_0375;
		IL_0375:
		IEnumerable<object> source;
		return (IEnumerable<TournamentModel>)Enumerable.OrderByDescending(source, keySelector);
		IL_01aa:
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v100 @ X0_v18+E4]");
		bool flag5 = (nint)0 == 0;
		object obj20 = !flag5;
		if (obj20 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			object obj21 = obj2;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v130 @ X8_v23+B8]");
			obj8 = 0;
		}
		object obj22 = typeof(Func<AndroidJavaObject, IList<HWLocation>>) + 3920;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
		object obj23 = (nint)0 + (nint)3816;
		Func<object, bool> func2 = default(Func<object, bool>);
		func2..ctor(obj8, (IntPtr)obj23);
		object obj24 = obj2;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v86 @ X8_v22+B8]");
		object obj25 = (nint)0 + (nint)8;
		obj25 = func2;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
		obj10 = obj7;
		predicate = func2;
		goto IL_0201;
		IL_0085:
		obj10 = (nint)0 + (nint)3808;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v100 @ X0_v18+B8]");
		obj8 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v114 @ X8_v17+8]");
		predicate = (Func<object, bool>)0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v114 @ X8_v17+8]");
		bool flag6 = (nint)0 == 0;
		object obj26 = !flag6;
		if (obj26 == null)
		{
			obj7 = obj10;
			goto IL_01aa;
		}
		goto IL_0201;
		IL_0201:
		source = Enumerable.Where(tournaments, predicate);
		object obj27 = obj2;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v178 @ X0_v8+E4]");
		if ((nint)0 != 0)
		{
			obj18 = (nint)0 + (nint)2536;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v178 @ X0_v8+B8]");
			obj13 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v188 @ X8_v6+10]");
			keySelector = (Func<object, DateTime>)0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v188 @ X8_v6+10]");
			bool flag7 = (nint)0 == 0;
			object obj28 = !flag7;
			if (obj28 == null)
			{
				obj19 = obj18;
				goto IL_031e;
			}
		}
		else
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			obj27 = obj2;
			obj19 = (nint)0 + (nint)2536;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v178 @ X0_v8+B8]");
			obj13 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v188 @ X8_v6+10]");
			keySelector = (Func<object, DateTime>)0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v188 @ X8_v6+10]");
			bool flag8 = (nint)0 == 0;
			object obj29 = !flag8;
			obj18 = obj19;
			if (obj29 == null)
			{
				goto IL_031e;
			}
		}
		goto IL_0375;
	}

	public List<TournamentListGroup> CreateGrouping(List<TournamentModel> tournaments)
	{
		//IL_000f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0014: Expected O, but got Unknown
		//IL_0020: Expected O, but got I
		//IL_002f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0034: Expected O, but got Unknown
		//IL_00d4: Expected O, but got I4
		//IL_0114: Unknown result type (might be due to invalid IL or missing references)
		//IL_0119: Expected O, but got Unknown
		//IL_0122: Unknown result type (might be due to invalid IL or missing references)
		//IL_0127: Expected O, but got Unknown
		object obj = typeof(List<AdaptivePerformanceScaler>) + 4008;
		object obj2 = (nint)0 + (nint)1416;
		object obj3 = typeof(UnityEngine.Purchasing.Telemetry.TelemetryMetricsInstanceWrapper) + 1568;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
		List<object> list = default(List<object>);
		list..ctor();
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
		TournamentListGroup tournamentListGroup = default(TournamentListGroup);
		tournamentListGroup..ctor(tournaments);
		if (list != null)
		{
			int version = list._version + 1;
			list._version = version;
			object[] items = list._items;
			if (list._items != null)
			{
				bool flag = list._size < items.Length;
				object obj4 = !flag;
				if (obj4 == null)
				{
					int size = list._size + 1;
					list._size = size;
					object obj5 = list._items + list._size;
					object obj6 = obj5 + 32;
					obj6 = tournamentListGroup;
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
					return (List<TournamentListGroup>)(object)list;
				}
				list.AddWithResize((object)tournamentListGroup);
				return (List<TournamentListGroup>)(object)list;
			}
		}
		return (List<TournamentListGroup>)(object)new NullReferenceException();
	}
}

using System;
using System.Collections.Generic;
using System.Data.SqlTypes;
using System.Linq;
using Cpp2ILInjected;
using HuaweiMobileServices.Location.Location;
using ListView;
using Microsoft.Extensions.DependencyInjection.ServiceLookup;
using Spine;
using UnityEngine;
using UnityEngine.AdaptivePerformance;
using UnityEngine.Purchasing.Telemetry;

public class TournamentsListView : UiGridView<TournamentDataHolder, ListViewItem<TournamentDataHolder, int>>
{
	[Serializable]
	private sealed class <>c
	{
		public static readonly <>c <>9;

		public static Func<TournamentRoomModel, int, TournamentDataHolder> <>9__11_0;

		static <>c()
		{
			//IL_000f: Unknown result type (might be due to invalid IL or missing references)
			//IL_0014: Expected O, but got Unknown
			object obj = typeof(SkeletonBinary.SkeletonInput) + 4040;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
			object obj2 = default(object);
			obj2..ctor();
			object obj3 = obj;
			object obj4 = obj2;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
		}

		internal TournamentDataHolder <SetTournamentRooms>b__11_0(TournamentRoomModel room, int i)
		{
			//IL_000f: Unknown result type (might be due to invalid IL or missing references)
			//IL_0014: Expected O, but got Unknown
			//IL_0048: Unknown result type (might be due to invalid IL or missing references)
			//IL_004d: Expected O, but got Unknown
			object obj = typeof(UnityEngine.Purchasing.Telemetry.TelemetryMetricsInstanceWrapper) + 1512;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
			object obj2 = default(object);
			obj2..ctor();
			object obj3 = obj2 + 48;
			obj3 = room;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
			((TournamentDataHolder)obj2).SetTemplate();
			return (TournamentDataHolder)obj2;
		}
	}

	private sealed class <>c__DisplayClass12_0
	{
		public int index;

		public Func<TournamentModel, TournamentDataHolder> <>9__0;

		internal TournamentDataHolder <SetData>b__0(TournamentModel t)
		{
			//IL_0014: Unknown result type (might be due to invalid IL or missing references)
			//IL_0019: Expected O, but got Unknown
			//IL_005b: Unknown result type (might be due to invalid IL or missing references)
			//IL_0060: Expected O, but got Unknown
			if (t != null)
			{
				object obj = typeof(UnityEngine.Purchasing.Telemetry.TelemetryMetricsInstanceWrapper) + 1512;
				int num = index + 1;
				index = num;
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
				object obj2 = default(object);
				obj2..ctor();
				_ = index;
				object obj3 = obj2 + 40;
				obj3 = t.<Room>k__BackingField;
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
				((TournamentDataHolder)obj2).SetTemplate();
				return (TournamentDataHolder)obj2;
			}
			return (TournamentDataHolder)(object)new NullReferenceException();
		}
	}

	private TournamentsEventsChannel eventsChannel;

	private bool noFilters;

	private bool isRequestBased;

	private TournamentType type;

	private TournamentEmptyStateMessage emptyMessage;

	private ITournamentFilter _filter;

	protected override void Awake()
	{
		//IL_015d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0162: Expected O, but got Unknown
		//IL_007f: Expected O, but got I4
		//IL_00bb: Unknown result type (might be due to invalid IL or missing references)
		//IL_00c0: Expected O, but got Unknown
		//IL_002f: Expected O, but got I4
		//IL_00eb: Expected O, but got I4
		//IL_0191: Expected O, but got I
		//IL_01a9: Unknown result type (might be due to invalid IL or missing references)
		//IL_01ae: Expected O, but got Unknown
		//IL_0110: Unknown result type (might be due to invalid IL or missing references)
		//IL_0115: Expected O, but got Unknown
		//IL_012b: Expected O, but got I
		//IL_0139: Expected I, but got O
		object obj = typeof(UnityEngine.Purchasing.Telemetry.TelemetryMetricsInstanceWrapper) + 1552;
		if (noFilters)
		{
			object obj2 = obj;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v63 @ X0_v16+E4]");
			bool flag = (nint)0 == 0;
			object obj3 = !flag;
			if (obj3 == null)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
				obj2 = obj;
			}
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v63 @ X0_v16+B8]");
			ITournamentFilter tournamentFilter = (_filter = (ITournamentFilter)0);
			object obj4 = this + 392;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
			if (isRequestBased)
			{
				return;
			}
		}
		else
		{
			object obj5 = obj;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v56 @ X0_v7+E4]");
			bool flag2 = (nint)0 == 0;
			object obj6 = !flag2;
			if (obj6 == null)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			}
			ITournamentFilter tournamentFilter2 = (_filter = TournamentFilterFactory.GetFilter(type));
			object obj7 = this + 392;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
			bool flag3 = !isRequestBased;
			object obj8 = !flag3;
			ITournamentFilter tournamentFilter = tournamentFilter2;
			if (obj8 != null)
			{
				return;
			}
		}
		object obj9 = typeof(SqlSingle[]) + 2376;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
		object obj10 = (nint)0 + (nint)1704;
		Action action = default(Action);
		action..ctor(this, (IntPtr)obj10);
		eventsChannel.OnTournamentsChanged += action;
	}

	private void OnEnable()
	{
		//IL_003c: Expected O, but got I4
		if (!isRequestBased)
		{
			bool flag = !noFilters;
			object obj = !flag;
			if (obj == null)
			{
				eventsChannel.TriggerLastSeanUpdated(type);
			}
			RefreshList();
		}
	}

	private void OnDestroy()
	{
		//IL_000f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0014: Expected O, but got Unknown
		//IL_0020: Expected O, but got I
		//IL_004d: Expected I, but got O
		object obj = typeof(SqlSingle[]) + 2376;
		object obj2 = (nint)0 + (nint)1704;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
		Action action = default(Action);
		action..ctor(this, (IntPtr)obj2);
		eventsChannel.OnTournamentsChanged -= action;
	}

	public void RefreshList()
	{
		//IL_0032: Unknown result type (might be due to invalid IL or missing references)
		//IL_0037: Expected O, but got Unknown
		//IL_0040: Expected I, but got O
		//IL_0050: Expected O, but got I
		//IL_008b: Expected O, but got I
		//IL_00e3: Unknown result type (might be due to invalid IL or missing references)
		//IL_00e8: Expected O, but got Unknown
		//IL_00f1: Unknown result type (might be due to invalid IL or missing references)
		//IL_00f6: Expected O, but got Unknown
		//IL_0099: Unknown result type (might be due to invalid IL or missing references)
		//IL_009e: Expected O, but got Unknown
		//IL_00a7: Unknown result type (might be due to invalid IL or missing references)
		//IL_00ac: Expected O, but got Unknown
		//IL_01be: Expected I, but got O
		//IL_01ce: Expected O, but got I
		//IL_0176: Expected O, but got I4
		//IL_0209: Expected O, but got I
		//IL_0262: Unknown result type (might be due to invalid IL or missing references)
		//IL_0267: Expected O, but got Unknown
		//IL_026f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0274: Expected O, but got Unknown
		//IL_027d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0282: Expected O, but got Unknown
		//IL_0217: Unknown result type (might be due to invalid IL or missing references)
		//IL_021c: Expected O, but got Unknown
		//IL_0225: Unknown result type (might be due to invalid IL or missing references)
		//IL_022a: Expected O, but got Unknown
		ITournamentFilter filter = _filter;
		IEnumerable<TournamentModel> tournaments = eventsChannel.GetTournaments();
		object obj = typeof(System.IOAsyncCallback) + 1784;
		nint num = (nint)filter;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v148 @ X8_v4 (Il2CppClass<ITournamentFilter>)+12E]");
		object obj2 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v148 @ X8_v4 (Il2CppClass<ITournamentFilter>)+12E]");
		if ((nint)0 == 0)
		{
			goto IL_00cc;
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v148 @ X8_v4 (Il2CppClass<ITournamentFilter>)+B0]");
		object obj3 = (nint)0 + (nint)8;
		while (true)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v243 @ X10_v12-8]");
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
			goto IL_00cc;
		}
		object obj4 = num + obj3;
		object obj5 = obj4 + 312;
		goto IL_02b2;
		IL_00cc:
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @B0D070");
		goto IL_02b2;
		IL_02b2:
		Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v259 @ X0_v6] (should have been resolved before IL gen)");
		IEnumerable<object> source = default(IEnumerable<object>);
		List<object> list = Enumerable.ToList(source);
		IEnumerable<TournamentModel> tournaments2 = eventsChannel.GetTournaments(type);
		int totalCount = Enumerable.Count((IEnumerable<object>)tournaments2);
		ITournamentFilter filter2;
		if (list._size >= 1)
		{
			emptyMessage.HideMessage();
			filter2 = _filter;
			bool flag = _filter == null;
			object obj6 = !flag;
			if (obj6 == null)
			{
				throw new NullReferenceException();
			}
		}
		else
		{
			emptyMessage.ShowMessage(type, list._size, totalCount);
			filter2 = _filter;
		}
		nint num2 = (nint)filter2;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v276 @ X8_v7 (Il2CppClass<ITournamentFilter>)+12E]");
		object obj7 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v276 @ X8_v7 (Il2CppClass<ITournamentFilter>)+12E]");
		if ((nint)0 == 0)
		{
			goto IL_024a;
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v276 @ X8_v7 (Il2CppClass<ITournamentFilter>)+B0]");
		object obj8 = (nint)0 + (nint)8;
		while (true)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v317 @ X10_v7-8]");
			if (0 == (nint)obj)
			{
				break;
			}
			obj8 += 16;
			obj7--;
			if ((nint)obj7 != 1)
			{
				continue;
			}
			goto IL_024a;
		}
		object obj9 = obj8 + 1;
		object obj10 = num2 + obj9;
		object obj11 = obj10 + 312;
		goto IL_02f2;
		IL_024a:
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @B0D070");
		goto IL_02f2;
		IL_02f2:
		Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v334 @ X0_v14] (should have been resolved before IL gen)");
		List<TournamentListGroup> list2 = default(List<TournamentListGroup>);
		SetData(list2);
	}

	private void UpdateStateMessage(int filteredCount, int totalCount)
	{
		if (filteredCount >= 1)
		{
			emptyMessage.HideMessage();
		}
		else
		{
			emptyMessage.ShowMessage(type, filteredCount, totalCount);
		}
	}

	public void SetTournamentRooms(List<TournamentRoomModel> rooms)
	{
		//IL_0014: Unknown result type (might be due to invalid IL or missing references)
		//IL_0019: Expected O, but got Unknown
		//IL_004e: Expected O, but got I4
		//IL_012e: Expected O, but got I
		//IL_013e: Expected O, but got I
		//IL_0160: Expected O, but got I4
		//IL_00f2: Expected I, but got O
		//IL_0102: Expected O, but got I
		//IL_0112: Expected O, but got I
		//IL_0095: Expected O, but got I4
		//IL_017d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0182: Expected O, but got Unknown
		//IL_0198: Expected O, but got I
		//IL_01a9: Expected I, but got O
		//IL_01c7: Expected O, but got I
		//IL_00c5: Expected O, but got I
		object obj = typeof(SkeletonBinary.SkeletonInput) + 4040;
		emptyMessage.HideMessage();
		object obj2 = obj;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v72 @ X0_v5+E4]");
		bool flag = (nint)0 == 0;
		object obj3 = !flag;
		if (obj3 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			obj2 = obj;
		}
		Func<object, int, object> func = default(Func<object, int, object>);
		while (true)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v72 @ X0_v5+B8]");
			object obj4 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v142 @ X8_v7+8]");
			Func<object, int, object> selector = (Func<object, int, object>)0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v142 @ X8_v7+8]");
			bool flag2 = (nint)0 == 0;
			object obj5 = !flag2;
			if (obj5 == null)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v72 @ X0_v5+E4]");
				bool flag3 = (nint)0 == 0;
				object obj6 = !flag3;
				if (obj6 == null)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
					object obj7 = obj;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v150 @ X8_v13+B8]");
					obj4 = 0;
				}
				object obj8 = typeof(Func<Type, Microsoft.Extensions.DependencyInjection.ServiceLookup.ServiceCallSite>) + 1072;
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
				object obj9 = (nint)0 + (nint)592;
				func..ctor(obj4, (IntPtr)obj9);
				object obj10 = obj;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v133 @ X8_v12+B8]");
				object obj11 = (nint)0 + (nint)8;
				obj11 = func;
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
				selector = func;
			}
			IEnumerable<object> source = Enumerable.Select(rooms, selector);
			List<object> list = Enumerable.ToList(source);
			nint num = (nint)this;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v108 @ X8_v6 (Il2CppClass<TournamentsListView>)+2A8]");
			object obj12 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v108 @ X8_v6 (Il2CppClass<TournamentsListView>)+2B0]");
			object obj13 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Indirect jump: v93 @ X3_v2 (should have been resolved before IL gen)");
		}
	}

	private void SetData(List<TournamentListGroup> tournamentGroups)
	{
		//IL_000f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0014: Expected O, but got Unknown
		//IL_0023: Unknown result type (might be due to invalid IL or missing references)
		//IL_0028: Expected O, but got Unknown
		//IL_0034: Expected O, but got I
		//IL_0866: Expected O, but got I4
		//IL_009c: Expected O, but got I
		//IL_00ab: Unknown result type (might be due to invalid IL or missing references)
		//IL_00b0: Expected O, but got Unknown
		//IL_00bc: Expected O, but got I
		//IL_0a23: Expected O, but got I4
		//IL_097f: Expected O, but got I
		//IL_0816: Expected O, but got I4
		//IL_04fa: Expected O, but got I
		//IL_013c: Expected O, but got I4
		//IL_0152: Expected O, but got I
		//IL_06d3: Expected O, but got I
		//IL_06f5: Expected O, but got I4
		//IL_0536: Expected O, but got I
		//IL_0897: Expected O, but got I
		//IL_0779: Expected O, but got I
		//IL_0781: Expected I, but got O
		//IL_0796: Expected O, but got I
		//IL_01c5: Expected O, but got I
		//IL_01de: Expected O, but got I
		//IL_0842: Expected O, but got I4
		//IL_0712: Unknown result type (might be due to invalid IL or missing references)
		//IL_0717: Expected O, but got Unknown
		//IL_072d: Expected O, but got I
		//IL_073e: Expected I, but got O
		//IL_08f6: Expected O, but got I4
		//IL_07c3: Expected O, but got I
		//IL_07cb: Expected I, but got O
		//IL_0751: Unknown result type (might be due to invalid IL or missing references)
		//IL_0756: Expected O, but got Unknown
		//IL_021f: Expected O, but got I
		//IL_05e7: Expected O, but got I4
		//IL_05fb: Expected O, but got I4
		//IL_0922: Expected O, but got I4
		//IL_0463: Expected O, but got I
		//IL_0473: Expected O, but got I
		//IL_025b: Expected O, but got I
		//IL_064f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0654: Expected O, but got Unknown
		//IL_065d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0662: Expected O, but got Unknown
		//IL_0281: Unknown result type (might be due to invalid IL or missing references)
		//IL_0286: Expected O, but got Unknown
		//IL_0296: Expected O, but got I
		//IL_02f0: Expected O, but got I4
		//IL_0305: Expected O, but got I
		//IL_0375: Expected O, but got I4
		//IL_038a: Expected O, but got I
		//IL_03b9: Expected O, but got I4
		//IL_03cd: Expected O, but got I4
		//IL_0689: Expected O, but got I
		//IL_0699: Expected O, but got I
		//IL_0421: Unknown result type (might be due to invalid IL or missing references)
		//IL_0426: Expected O, but got Unknown
		//IL_042f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0434: Expected O, but got Unknown
		object obj = typeof(SkeletonBinary.SkeletonInput) + 4048;
		object obj2 = typeof(List<AdaptivePerformanceScaler>) + 3984;
		object obj3 = (nint)0 + (nint)1344;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
		object obj4 = default(object);
		obj4..ctor();
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
		IEnumerable<object> enumerable = (IEnumerable<object>)obj3;
		List<object> list = default(List<object>);
		list..ctor();
		TournamentsListView tournamentsListView = default(TournamentsListView);
		List<object>.Enumerator enumerator2 = default(List<object>.Enumerator);
		IEnumerable<object> enumerable2;
		NullReferenceException ex;
		List<object>.Enumerator enumerator3;
		List<object>.Enumerator enumerator5;
		List<object>.Enumerator enumerator4 = default(List<object>.Enumerator);
		if (obj4 != null)
		{
			_ = 0;
			bool flag = tournamentGroups == null;
			tournamentsListView = this;
			if (!flag)
			{
				object obj5 = (nint)0 + (nint)2592;
				object obj6 = typeof(UnityEngine.Purchasing.Telemetry.TelemetryMetricsInstanceWrapper) + 1512;
				object obj7 = (nint)0 + (nint)1352;
				List<object>.Enumerator enumerator = ((List<object>)(object)tournamentGroups).GetEnumerator();
				object obj9 = default(object);
				object obj14 = default(object);
				object obj17 = default(object);
				object[] array = default(object[]);
				Func<object, object> func = default(Func<object, object>);
				object obj33 = default(object);
				while (true)
				{
					bool flag2 = list == null;
					object obj8 = !flag2;
					if (obj8 == null)
					{
						enumerable = (IEnumerable<object>)obj5;
						if (!enumerator2.MoveNext())
						{
							break;
						}
						if (obj9 == null)
						{
							goto IL_07f4;
						}
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v190 @ stack_-88+20]");
						bool flag3 = (nint)0 < (nint)1;
						object obj10 = !flag3;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v190 @ stack_-88+20]");
						object obj11 = -1;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v190 @ stack_-88+20]");
						bool flag4 = (nint)0 == 1;
						object obj12 = obj9;
						if (!flag4)
						{
							goto IL_0184;
						}
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v66 @ X0_v3 (System.Object)+10]");
						object obj13 = (nint)0 + (nint)1;
						Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
						obj14..ctor();
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v66 @ X0_v3 (System.Object)+10]");
						_ = 0;
						((TournamentDataHolder)obj14).SetTemplate();
						enumerable = null;
						goto IL_08d4;
					}
					nint num;
					while (true)
					{
						enumerable = (IEnumerable<object>)obj5;
						if (!enumerator2.MoveNext())
						{
							break;
						}
						if (obj9 == null)
						{
							goto IL_07f4;
						}
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v190 @ stack_-88+20]");
						object obj15 = (nint)0 & (nint)1;
						bool flag5 = obj15 == null;
						object obj12 = obj9;
						if (flag5)
						{
							goto IL_0184;
						}
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v66 @ X0_v3 (System.Object)+10]");
						object obj16 = (nint)0 + (nint)1;
						Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
						obj17..ctor();
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v66 @ X0_v3 (System.Object)+10]");
						_ = 0;
						((TournamentDataHolder)obj17).SetTemplate();
						object obj18 = obj7;
						int version = list._version + 1;
						list._version = version;
						array = list._items;
						bool flag6 = list._items == null;
						enumerable = null;
						if (!flag6)
						{
							bool flag7 = list._size < array.Length;
							object obj10 = !flag7;
							object obj11 = list._size - array.Length;
							bool flag4 = obj11 == null;
							if (obj10 != null)
							{
								Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v621 @ X8_v24+20]");
								object obj19 = 0;
								Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v632 @ X8_v26+C0]");
								object obj20 = 0;
								Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v358 @ X8_v27+70]");
								num = 0;
								list.AddWithResize(obj17);
							}
							else
							{
								int num2 = list._size + 1;
								list._size = num2;
								object obj21 = list._items + list._size;
								object obj22 = obj21 + 32;
								obj22 = obj17;
								Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
							}
							continue;
						}
						goto IL_08d4;
					}
					break;
					IL_06c3:
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v66 @ X0_v3 (System.Object)+18]");
					Func<object, object> selector = (Func<object, object>)0;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v66 @ X0_v3 (System.Object)+18]");
					bool flag8 = (nint)0 == 0;
					object obj23 = !flag8;
					if (obj23 == null)
					{
						object obj24 = typeof(Func<AndroidJavaObject, IList<HWLocation>>) + 3960;
						Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
						object obj25 = (nint)0 + (nint)600;
						func..ctor(obj4, (IntPtr)obj25);
						object obj26 = obj4 + 24;
						Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
						selector = func;
					}
					object obj27 = (nint)0 + (nint)136;
					num = (nint)obj27;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v180 @ X24_v12+18]");
					enumerable2 = Enumerable.Select((IEnumerable<object>)0, selector);
					object[] array2;
					if (list != null)
					{
						object obj28 = (nint)0 + (nint)1360;
						num = (nint)obj28;
						list.AddRange(enumerable2);
						array = array2;
						continue;
					}
					goto IL_0820;
					IL_08d4:
					ex = new NullReferenceException();
					enumerator3 = enumerator4;
					enumerator5 = enumerator4;
					enumerator4 = (List<object>.Enumerator)0;
					tournamentsListView = this;
					goto IL_0932;
					IL_0184:
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v180 @ X24_v12+10]");
					bool flag9 = (nint)0 == 0;
					array2 = array;
					object obj29 = enumerable;
					if (!flag9)
					{
						object obj30 = (nint)0 + (nint)2384;
						enumerable = (IEnumerable<object>)obj30;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v180 @ X24_v12+18]");
						bool flag10 = Enumerable.Any((IEnumerable<object>)0);
						bool flag11 = !flag10;
						array2 = array;
						obj29 = obj30;
						if (!flag11)
						{
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v180 @ X24_v12+18]");
							object obj31 = 0;
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v180 @ X24_v12+18]");
							if ((nint)0 != 0)
							{
								Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v66 @ X0_v3 (System.Object)+10]");
								object obj32 = (nint)0 + (nint)1;
								Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
								obj33..ctor();
								object obj34 = obj33 + 56;
								Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v180 @ X24_v12+10]");
								obj34 = 0;
								Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v66 @ X0_v3 (System.Object)+10]");
								_ = 0;
								Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
								Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v304 @ X8_v42+18]");
								_ = 0;
								((TournamentDataHolder)obj33).SetTemplate();
								bool flag12 = list == null;
								enumerator2 = enumerator4;
								enumerator5 = enumerator4;
								enumerator4 = (List<object>.Enumerator)0;
								tournamentsListView = this;
								Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v180 @ X24_v12+10]");
								enumerable = (IEnumerable<object>)0;
								if (!flag12)
								{
									object obj35 = obj7;
									int version2 = list._version + 1;
									list._version = version2;
									array2 = list._items;
									bool flag13 = list._items == null;
									enumerator2 = enumerator4;
									enumerator5 = enumerator4;
									enumerator4 = (List<object>.Enumerator)0;
									tournamentsListView = this;
									Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v180 @ X24_v12+10]");
									enumerable = (IEnumerable<object>)0;
									if (!flag13)
									{
										bool flag14 = list._size < array2.Length;
										object obj10 = !flag14;
										object obj11 = list._size - array2.Length;
										bool flag4 = obj11 == null;
										if (obj10 == null)
										{
											int num3 = list._size + 1;
											list._size = num3;
											object obj36 = list._items + list._size;
											object obj37 = obj36 + 32;
											obj37 = obj33;
											Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
											obj29 = obj33;
										}
										else
										{
											Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v178 @ X8_v44+20]");
											object obj38 = 0;
											Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v641 @ X8_v45+C0]");
											object obj39 = 0;
											Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v551 @ X8_v46+70]");
											num = 0;
											list.AddWithResize(obj33);
											obj29 = obj33;
										}
										goto IL_06c3;
									}
								}
								goto IL_086b;
							}
							goto IL_0900;
						}
					}
					goto IL_06c3;
				}
				enumerator2.Dispose();
				goto IL_0a31;
			}
		}
		NullReferenceException ex2 = new NullReferenceException();
		enumerator2 = (List<object>.Enumerator)0;
		goto IL_086b;
		IL_0900:
		ex = new NullReferenceException();
		enumerator3 = enumerator4;
		enumerator5 = enumerator4;
		enumerator4 = (List<object>.Enumerator)0;
		tournamentsListView = this;
		goto IL_0932;
		IL_0820:
		ex = new NullReferenceException();
		enumerator3 = enumerator4;
		enumerator5 = enumerator4;
		enumerator4 = (List<object>.Enumerator)0;
		tournamentsListView = this;
		enumerable = enumerable2;
		goto IL_0932;
		IL_0a31:
		tournamentsListView.data = (List<TournamentDataHolder>)(object)list;
		return;
		IL_0932:
		bool flag15 = (nint)enumerable != 1;
		OutOfMemoryException ex3 = (OutOfMemoryException)(object)ex;
		if (!flag15)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @6CB0B80");
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @6CB0BB0");
			object obj40 = (nint)0 + (nint)2584;
			enumerable = (IEnumerable<object>)obj40;
			enumerator3.Dispose();
			object obj41 = default(object);
			if (obj41 == null)
			{
				goto IL_0a31;
			}
			ex3 = new OutOfMemoryException();
			enumerator4 = (List<object>.Enumerator)obj41;
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @22393E4");
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @6CB03A0");
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2B060");
		return;
		IL_086b:
		ex = new NullReferenceException();
		enumerator3 = enumerator2;
		goto IL_0932;
		IL_07f4:
		ex = new NullReferenceException();
		enumerator3 = enumerator4;
		enumerator5 = enumerator4;
		enumerator4 = (List<object>.Enumerator)0;
		tournamentsListView = this;
		goto IL_0932;
	}

	private void ShowEmptyState(int filteredCount, int totalCount)
	{
		emptyMessage.ShowMessage(type, filteredCount, totalCount);
	}

	private void HideEmptyState()
	{
		emptyMessage.HideMessage();
	}

	public TournamentsListView()
	{
		((UiGridView<object, object>)(object)this)..ctor();
	}
}

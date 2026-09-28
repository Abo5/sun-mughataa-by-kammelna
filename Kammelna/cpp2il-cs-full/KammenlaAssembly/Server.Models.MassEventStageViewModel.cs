using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using Cpp2ILInjected;
using HuaweiMobileServices.Location.Location;
using UnityEngine;

namespace Server.Models;

[Serializable]
public class MassEventStageViewModel
{
	private sealed class <>c__DisplayClass43_0
	{
		public DateTime dateTime;

		internal bool <WithinPlayPeriod>b__0(MassEventPlayWindowViewModel timePeriod)
		{
			//IL_0217: Expected I4, but got O
			//IL_0026: Expected O, but got I4
			//IL_0035: Unknown result type (might be due to invalid IL or missing references)
			//IL_003a: Expected O, but got Unknown
			//IL_0050: Expected O, but got I
			//IL_0192: Expected O, but got I4
			//IL_00db: Expected O, but got I4
			//IL_011b: Expected O, but got I4
			//IL_01e5: Expected O, but got I4
			//IL_01ee: Expected O, but got I4
			object obj2;
			DateTime <StartingTime>k__BackingField;
			bool flag3;
			object obj7;
			DateTime dateTime;
			if (timePeriod != null)
			{
				object obj = 152989696;
				obj2 = typeof(DataRelation) + 712;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [91E7BC0]");
				object obj3 = (nint)0 & (nint)1;
				DateTime <StartingTime>k__BackingField2;
				if (obj3 != null)
				{
					<StartingTime>k__BackingField = timePeriod.<StartingTime>k__BackingField;
					object obj4 = obj2;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v59 @ X0_v3+E4]");
					bool flag = (nint)0 == 0;
					<StartingTime>k__BackingField2 = timePeriod.<StartingTime>k__BackingField;
					if (!flag)
					{
						goto IL_00b4;
					}
				}
				else
				{
					_ = 1;
					<StartingTime>k__BackingField = timePeriod.<StartingTime>k__BackingField;
					object obj4 = obj2;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v59 @ X0_v3+E4]");
					bool flag2 = (nint)0 == 0;
					object obj5 = !flag2;
					<StartingTime>k__BackingField2 = timePeriod.<StartingTime>k__BackingField;
					if (obj5 != null)
					{
						goto IL_00b4;
					}
				}
				Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
				flag3 = this.dateTime >= <StartingTime>k__BackingField2;
				bool flag4 = !flag3;
				object obj6 = !flag4;
				obj7 = 0;
				dateTime = <StartingTime>k__BackingField2;
				if (obj6 != null)
				{
					goto IL_00f1;
				}
				goto IL_0204;
			}
			NullReferenceException ex = new NullReferenceException();
			return (byte)(int)ex != 0;
			IL_00b4:
			flag3 = this.dateTime >= <StartingTime>k__BackingField;
			bool flag5 = !flag3;
			obj7 = 0;
			dateTime = <StartingTime>k__BackingField;
			if (!flag5)
			{
				goto IL_00f1;
			}
			goto IL_0204;
			IL_0204:
			return flag3;
			IL_00f1:
			object obj8 = obj2;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v113 @ X0_v12+E4]");
			bool flag6 = (nint)0 == 0;
			object obj9 = !flag6;
			if (obj9 == null)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			}
			return this.dateTime < timePeriod.<FinishTime>k__BackingField;
		}
	}

	private sealed class <>c__DisplayClass44_0
	{
		public DateTime dateTime;

		internal bool <NextPlayWindow>b__0(MassEventPlayWindowViewModel timePeriod)
		{
			//IL_008b: Expected I4, but got O
			//IL_0014: Unknown result type (might be due to invalid IL or missing references)
			//IL_0019: Expected O, but got Unknown
			//IL_0043: Expected O, but got I4
			if (timePeriod != null)
			{
				object obj = typeof(DataRelation) + 712;
				object obj2 = obj;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v48 @ X0_v3+E4]");
				bool flag = (nint)0 == 0;
				object obj3 = !flag;
				if (obj3 == null)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
				}
				return timePeriod.<StartingTime>k__BackingField > dateTime;
			}
			NullReferenceException ex = new NullReferenceException();
			return (byte)(int)ex != 0;
		}
	}

	private int <Id>k__BackingField;

	private MassEventStageType <Type>k__BackingField;

	private int? <FilterValue>k__BackingField;

	private int? <MaxTrails>k__BackingField;

	private DateTime <StartingDate>k__BackingField;

	private DateTime <FinishDate>k__BackingField;

	private TimeSpan <TrailsRefreshWindow>k__BackingField;

	private string <PhysicalFinalTitle>k__BackingField;

	private string <PhysicalFinalDescription>k__BackingField;

	private List<MassEventPlayWindowViewModel> <PlayWindows>k__BackingField;

	private int <TournamentSize>k__BackingField;

	private int <Prize>k__BackingField;

	private int? <SecondaryPrize>k__BackingField;

	private int? <TertiaryPrize>k__BackingField;

	public int Id
	{
		get
		{
			return <Id>k__BackingField;
		}
		set
		{
			<Id>k__BackingField = value;
		}
	}

	public MassEventStageType Type
	{
		get
		{
			return <Type>k__BackingField;
		}
		set
		{
			<Type>k__BackingField = value;
		}
	}

	public int? FilterValue
	{
		get
		{
			return <FilterValue>k__BackingField;
		}
		set
		{
			<FilterValue>k__BackingField = value;
		}
	}

	public int? MaxTrails
	{
		get
		{
			return <MaxTrails>k__BackingField;
		}
		set
		{
			<MaxTrails>k__BackingField = value;
		}
	}

	public bool RequiredTickets
	{
		get
		{
			//IL_001c: Expected O, but got I4
			//IL_0025: Expected I4, but got O
			bool flag = <Type>k__BackingField < MassEventStageType.TournamentWinnersFilter;
			object obj = !flag;
			return (byte)(int)(~obj) != 0;
		}
	}

	public DateTime StartingDate
	{
		get
		{
			return <StartingDate>k__BackingField;
		}
		set
		{
			<StartingDate>k__BackingField = value;
		}
	}

	public DateTime FinishDate
	{
		get
		{
			return <FinishDate>k__BackingField;
		}
		set
		{
			<FinishDate>k__BackingField = value;
		}
	}

	public TimeSpan TrailsRefreshWindow
	{
		get
		{
			return <TrailsRefreshWindow>k__BackingField;
		}
		set
		{
			<TrailsRefreshWindow>k__BackingField = value;
		}
	}

	public string PhysicalFinalTitle
	{
		get
		{
			return <PhysicalFinalTitle>k__BackingField;
		}
		set
		{
			//IL_0006: Unknown result type (might be due to invalid IL or missing references)
			//IL_000b: Expected O, but got Unknown
			object obj = this + 64;
			obj = value;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
		}
	}

	public string PhysicalFinalDescription
	{
		get
		{
			return <PhysicalFinalDescription>k__BackingField;
		}
		set
		{
			//IL_0006: Unknown result type (might be due to invalid IL or missing references)
			//IL_000b: Expected O, but got Unknown
			object obj = this + 72;
			obj = value;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
		}
	}

	public List<MassEventPlayWindowViewModel> PlayWindows
	{
		get
		{
			return <PlayWindows>k__BackingField;
		}
		set
		{
			//IL_0006: Unknown result type (might be due to invalid IL or missing references)
			//IL_000b: Expected O, but got Unknown
			object obj = this + 80;
			obj = value;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
		}
	}

	public int TournamentSize
	{
		get
		{
			return <TournamentSize>k__BackingField;
		}
		set
		{
			<TournamentSize>k__BackingField = value;
		}
	}

	public int Prize
	{
		get
		{
			return <Prize>k__BackingField;
		}
		set
		{
			<Prize>k__BackingField = value;
		}
	}

	public int? SecondaryPrize
	{
		get
		{
			return <SecondaryPrize>k__BackingField;
		}
		set
		{
			<SecondaryPrize>k__BackingField = value;
		}
	}

	public int? TertiaryPrize
	{
		get
		{
			return <TertiaryPrize>k__BackingField;
		}
		set
		{
			<TertiaryPrize>k__BackingField = value;
		}
	}

	public bool IsTimeWithinStage(DateTime dateTime)
	{
		//IL_0009: Expected O, but got I4
		//IL_0018: Unknown result type (might be due to invalid IL or missing references)
		//IL_001d: Expected O, but got Unknown
		//IL_0033: Expected O, but got I
		//IL_0165: Expected O, but got I4
		//IL_00b6: Expected O, but got I4
		//IL_00f6: Expected O, but got I4
		//IL_01b3: Expected O, but got I4
		//IL_01bc: Expected O, but got I4
		object obj = 152989696;
		object obj2 = typeof(DataRelation) + 712;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [91E7D66]");
		object obj3 = (nint)0 & (nint)1;
		DateTime dateTime2;
		DateTime dateTime3;
		if (obj3 != null)
		{
			dateTime2 = <StartingDate>k__BackingField;
			object obj4 = obj2;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v57 @ X0_v2+E4]");
			bool flag = (nint)0 == 0;
			dateTime3 = <StartingDate>k__BackingField;
			if (!flag)
			{
				goto IL_0091;
			}
		}
		else
		{
			_ = 1;
			dateTime2 = <StartingDate>k__BackingField;
			object obj4 = obj2;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v57 @ X0_v2+E4]");
			bool flag2 = (nint)0 == 0;
			object obj5 = !flag2;
			dateTime3 = <StartingDate>k__BackingField;
			if (obj5 != null)
			{
				goto IL_0091;
			}
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		bool flag3 = dateTime >= dateTime3;
		bool flag4 = !flag3;
		object obj6 = !flag4;
		object obj7 = 0;
		DateTime dateTime4 = dateTime3;
		if (obj6 != null)
		{
			goto IL_00cc;
		}
		goto IL_01d2;
		IL_00cc:
		object obj8 = obj2;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v77 @ X0_v11+E4]");
		bool flag5 = (nint)0 == 0;
		object obj9 = !flag5;
		if (obj9 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		}
		return dateTime < <FinishDate>k__BackingField;
		IL_01d2:
		return flag3;
		IL_0091:
		flag3 = dateTime >= dateTime2;
		bool flag6 = !flag3;
		obj7 = 0;
		dateTime4 = dateTime2;
		if (!flag6)
		{
			goto IL_00cc;
		}
		goto IL_01d2;
	}

	public bool WithinPlayPeriod(DateTime dateTime)
	{
		//IL_000f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0014: Expected O, but got Unknown
		//IL_0085: Expected I4, but got O
		//IL_0028: Unknown result type (might be due to invalid IL or missing references)
		//IL_002d: Expected O, but got Unknown
		//IL_0039: Expected O, but got I
		//IL_005a: Expected I, but got O
		object obj = typeof(InvitationsNotifier.<>c__DisplayClass16_0) + 2896;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
		object obj2 = default(object);
		obj2..ctor();
		if (obj2 != null)
		{
			object obj3 = typeof(Func<AndroidJavaObject, IList<HWLocation>>) + 2352;
			object obj4 = (nint)0 + (nint)664;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
			Func<object, bool> func = default(Func<object, bool>);
			func..ctor(obj2, (IntPtr)obj4);
			return Enumerable.Any(<PlayWindows>k__BackingField, func);
		}
		NullReferenceException ex = new NullReferenceException();
		return (byte)(int)ex != 0;
	}

	public MassEventPlayWindowViewModel NextPlayWindow(DateTime dateTime)
	{
		//IL_000f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0014: Expected O, but got Unknown
		//IL_0028: Unknown result type (might be due to invalid IL or missing references)
		//IL_002d: Expected O, but got Unknown
		//IL_0039: Expected O, but got I
		//IL_005a: Expected I, but got O
		object obj = typeof(InvitationsNotifier.<>c__DisplayClass16_0) + 2904;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
		object obj2 = default(object);
		obj2..ctor();
		if (obj2 != null)
		{
			object obj3 = typeof(Func<AndroidJavaObject, IList<HWLocation>>) + 2352;
			object obj4 = (nint)0 + (nint)672;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
			Func<object, bool> func = default(Func<object, bool>);
			func..ctor(obj2, (IntPtr)obj4);
			return (MassEventPlayWindowViewModel)Enumerable.FirstOrDefault(<PlayWindows>k__BackingField, func);
		}
		return (MassEventPlayWindowViewModel)(object)new NullReferenceException();
	}

	public MassEventPlayWindowViewModel NextPlayWindow()
	{
		//IL_000f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0014: Expected O, but got Unknown
		//IL_0073: Expected O, but got I4
		object obj = typeof(DataRelation) + 712;
		object obj2 = obj;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v44 @ X0_v2+E4]");
		bool flag = (nint)0 == 0;
		object obj3 = !flag;
		if (obj3 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		}
		DateTime now = DateTime.Now;
		return NextPlayWindow(now);
	}
}

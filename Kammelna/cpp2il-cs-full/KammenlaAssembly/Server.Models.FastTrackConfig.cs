using System.Collections.Generic;
using Cpp2ILInjected;
using UnityEngine.AdaptivePerformance;
using UnityEngine.Rendering;

namespace Server.Models;

public class FastTrackConfig
{
	public const int FT_MATCH_TIMER_CONNECTION_BUFFER_SECONDS = 5;

	private int <TicketPrice>k__BackingField;

	private int <MaxWaitingTimeSeconds>k__BackingField;

	private List<List<int>> <LevelStages>k__BackingField;

	public int TicketPrice
	{
		get
		{
			return <TicketPrice>k__BackingField;
		}
		set
		{
			<TicketPrice>k__BackingField = value;
		}
	}

	public int MaxWaitingTimeSeconds
	{
		get
		{
			return <MaxWaitingTimeSeconds>k__BackingField;
		}
		set
		{
			<MaxWaitingTimeSeconds>k__BackingField = value;
		}
	}

	public List<List<int>> LevelStages
	{
		get
		{
			return <LevelStages>k__BackingField;
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

	public int MatchMakerTimerSeconds => <MaxWaitingTimeSeconds>k__BackingField + 5;

	public FastTrackConfig()
	{
		//IL_000f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0014: Expected O, but got Unknown
		//IL_0020: Expected O, but got I
		//IL_002f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0034: Expected O, but got Unknown
		//IL_0054: Expected O, but got I
		//IL_0072: Expected O, but got I
		//IL_0087: Expected O, but got I
		//IL_00b5: Expected O, but got I4
		//IL_0129: Expected O, but got I
		//IL_0139: Expected O, but got I
		//IL_0149: Expected O, but got I
		//IL_016f: Expected O, but got I
		//IL_0185: Expected O, but got I
		//IL_01b8: Expected O, but got I4
		//IL_00d9: Expected O, but got I
		//IL_00ee: Unknown result type (might be due to invalid IL or missing references)
		//IL_00f3: Expected O, but got Unknown
		//IL_010f: Expected O, but got I
		//IL_022c: Expected O, but got I
		//IL_023c: Expected O, but got I
		//IL_024c: Expected O, but got I
		//IL_0272: Expected O, but got I
		//IL_0288: Expected O, but got I
		//IL_02bb: Expected O, but got I4
		//IL_01dc: Expected O, but got I
		//IL_01f1: Unknown result type (might be due to invalid IL or missing references)
		//IL_01f6: Expected O, but got Unknown
		//IL_0212: Expected O, but got I
		//IL_032f: Expected O, but got I
		//IL_033f: Expected O, but got I
		//IL_034f: Expected O, but got I
		//IL_0375: Expected O, but got I
		//IL_038b: Expected O, but got I
		//IL_03be: Expected O, but got I4
		//IL_02df: Expected O, but got I
		//IL_02f4: Unknown result type (might be due to invalid IL or missing references)
		//IL_02f9: Expected O, but got Unknown
		//IL_0315: Expected O, but got I
		//IL_0432: Expected O, but got I
		//IL_0442: Expected O, but got I
		//IL_0452: Expected O, but got I
		//IL_0478: Expected O, but got I
		//IL_048e: Expected O, but got I
		//IL_04c1: Expected O, but got I4
		//IL_03e2: Expected O, but got I
		//IL_03f7: Unknown result type (might be due to invalid IL or missing references)
		//IL_03fc: Expected O, but got Unknown
		//IL_0418: Expected O, but got I
		//IL_0535: Expected O, but got I
		//IL_0545: Expected O, but got I
		//IL_0555: Expected O, but got I
		//IL_057b: Expected O, but got I
		//IL_0591: Expected O, but got I
		//IL_05c4: Expected O, but got I4
		//IL_04e5: Expected O, but got I
		//IL_04fa: Unknown result type (might be due to invalid IL or missing references)
		//IL_04ff: Expected O, but got Unknown
		//IL_051b: Expected O, but got I
		//IL_061d: Expected O, but got I
		//IL_062d: Expected O, but got I
		//IL_063d: Expected O, but got I
		//IL_065c: Expected O, but got I
		//IL_05e8: Expected O, but got I
		//IL_05fd: Unknown result type (might be due to invalid IL or missing references)
		//IL_0602: Expected O, but got Unknown
		//IL_06b6: Expected O, but got I4
		//IL_0733: Expected O, but got I
		//IL_0743: Expected O, but got I
		//IL_0753: Expected O, but got I
		//IL_06f1: Unknown result type (might be due to invalid IL or missing references)
		//IL_06f6: Expected O, but got Unknown
		//IL_06ff: Unknown result type (might be due to invalid IL or missing references)
		//IL_0704: Expected O, but got Unknown
		//IL_07a3: Expected O, but got I
		//IL_07b8: Expected O, but got I
		//IL_07e6: Expected O, but got I4
		//IL_085a: Expected O, but got I
		//IL_086a: Expected O, but got I
		//IL_087a: Expected O, but got I
		//IL_08a0: Expected O, but got I
		//IL_08b6: Expected O, but got I
		//IL_08e9: Expected O, but got I4
		//IL_080a: Expected O, but got I
		//IL_081f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0824: Expected O, but got Unknown
		//IL_0840: Expected O, but got I
		//IL_095d: Expected O, but got I
		//IL_096d: Expected O, but got I
		//IL_097d: Expected O, but got I
		//IL_09a3: Expected O, but got I
		//IL_09b9: Expected O, but got I
		//IL_09ec: Expected O, but got I4
		//IL_090d: Expected O, but got I
		//IL_0922: Unknown result type (might be due to invalid IL or missing references)
		//IL_0927: Expected O, but got Unknown
		//IL_0943: Expected O, but got I
		//IL_0a60: Expected O, but got I
		//IL_0a70: Expected O, but got I
		//IL_0a80: Expected O, but got I
		//IL_0aa6: Expected O, but got I
		//IL_0abc: Expected O, but got I
		//IL_0aef: Expected O, but got I4
		//IL_0a10: Expected O, but got I
		//IL_0a25: Unknown result type (might be due to invalid IL or missing references)
		//IL_0a2a: Expected O, but got Unknown
		//IL_0a46: Expected O, but got I
		//IL_0b63: Expected O, but got I
		//IL_0b73: Expected O, but got I
		//IL_0b83: Expected O, but got I
		//IL_0ba9: Expected O, but got I
		//IL_0bbf: Expected O, but got I
		//IL_0bf2: Expected O, but got I4
		//IL_0b13: Expected O, but got I
		//IL_0b28: Unknown result type (might be due to invalid IL or missing references)
		//IL_0b2d: Expected O, but got Unknown
		//IL_0b49: Expected O, but got I
		//IL_0c66: Expected O, but got I
		//IL_0c76: Expected O, but got I
		//IL_0c86: Expected O, but got I
		//IL_0cac: Expected O, but got I
		//IL_0cc2: Expected O, but got I
		//IL_0cf5: Expected O, but got I4
		//IL_0c16: Expected O, but got I
		//IL_0c2b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0c30: Expected O, but got Unknown
		//IL_0c4c: Expected O, but got I
		//IL_0d69: Expected O, but got I
		//IL_0d79: Expected O, but got I
		//IL_0d89: Expected O, but got I
		//IL_0daf: Expected O, but got I
		//IL_0dc5: Expected O, but got I
		//IL_0df8: Expected O, but got I4
		//IL_0d19: Expected O, but got I
		//IL_0d2e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0d33: Expected O, but got Unknown
		//IL_0d4f: Expected O, but got I
		//IL_0e6c: Expected O, but got I
		//IL_0e7c: Expected O, but got I
		//IL_0e8c: Expected O, but got I
		//IL_0eb2: Expected O, but got I
		//IL_0ec8: Expected O, but got I
		//IL_0efb: Expected O, but got I4
		//IL_0e1c: Expected O, but got I
		//IL_0e31: Unknown result type (might be due to invalid IL or missing references)
		//IL_0e36: Expected O, but got Unknown
		//IL_0e52: Expected O, but got I
		//IL_0f54: Expected O, but got I
		//IL_0f64: Expected O, but got I
		//IL_0f74: Expected O, but got I
		//IL_0f1f: Expected O, but got I
		//IL_0f34: Unknown result type (might be due to invalid IL or missing references)
		//IL_0f39: Expected O, but got Unknown
		//IL_0fe1: Expected O, but got I4
		//IL_1056: Expected O, but got I
		//IL_1066: Expected O, but got I
		//IL_1076: Expected O, but got I
		//IL_108e: Unknown result type (might be due to invalid IL or missing references)
		//IL_1093: Expected O, but got Unknown
		//IL_101c: Unknown result type (might be due to invalid IL or missing references)
		//IL_1021: Expected O, but got Unknown
		//IL_102a: Unknown result type (might be due to invalid IL or missing references)
		//IL_102f: Expected O, but got Unknown
		object obj = typeof(IEnumerator<KeyValuePair<int, (RTHandle, int)>>) + 3736;
		object obj2 = (nint)0 + (nint)2912;
		object obj3 = typeof(List<AdaptivePerformanceScaler>) + 1800;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [7253208]");
		<TicketPrice>k__BackingField = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
		List<object> list = default(List<object>);
		list..ctor();
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
		List<int> list2 = default(List<int>);
		list2..ctor();
		object obj4 = (nint)0 + (nint)1336;
		object obj5 = obj4;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v72 @ X0_v5 (System.Collections.Generic.List`1<System.Int32>)+1C]");
		object obj6 = (nint)0 + (nint)1;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v72 @ X0_v5 (System.Collections.Generic.List`1<System.Int32>)+10]");
		object obj7 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v72 @ X0_v5 (System.Collections.Generic.List`1<System.Int32>)+18]");
		nint num = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v503 @ X9_v9+18]");
		if ((object)(num >= 0) == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v72 @ X0_v5 (System.Collections.Generic.List`1<System.Int32>)+18]");
			object obj8 = (nint)0 + (nint)1;
			object obj9 = obj7;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v72 @ X0_v5 (System.Collections.Generic.List`1<System.Int32>)+18]");
			object obj10 = obj9 + 0;
			_ = 1001;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v72 @ X0_v5 (System.Collections.Generic.List`1<System.Int32>)+1C]");
			object obj11 = (nint)0 + (nint)1;
		}
		else
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v507 @ X8_v10+20]");
			object obj12 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v376 @ X8_v72+C0]");
			object obj13 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v377 @ X8_v73+70]");
			object obj14 = 0;
			list2.AddWithResize(1001);
			obj5 = obj4;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v72 @ X0_v5 (System.Collections.Generic.List`1<System.Int32>)+10]");
			obj7 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v72 @ X0_v5 (System.Collections.Generic.List`1<System.Int32>)+1C]");
			object obj15 = (nint)0 + (nint)1;
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v72 @ X0_v5 (System.Collections.Generic.List`1<System.Int32>)+18]");
		nint num2 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v503 @ X9_v9+18]");
		if ((object)(num2 >= 0) == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v72 @ X0_v5 (System.Collections.Generic.List`1<System.Int32>)+18]");
			object obj16 = (nint)0 + (nint)1;
			object obj17 = obj7;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v72 @ X0_v5 (System.Collections.Generic.List`1<System.Int32>)+18]");
			object obj18 = obj17 + 0;
			_ = 2501;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v72 @ X0_v5 (System.Collections.Generic.List`1<System.Int32>)+1C]");
			object obj19 = (nint)0 + (nint)1;
		}
		else
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v507 @ X8_v10+20]");
			object obj20 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v444 @ X8_v69+C0]");
			object obj21 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v445 @ X8_v70+70]");
			object obj14 = 0;
			list2.AddWithResize(2501);
			obj5 = obj4;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v72 @ X0_v5 (System.Collections.Generic.List`1<System.Int32>)+10]");
			obj7 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v72 @ X0_v5 (System.Collections.Generic.List`1<System.Int32>)+1C]");
			object obj22 = (nint)0 + (nint)1;
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v72 @ X0_v5 (System.Collections.Generic.List`1<System.Int32>)+18]");
		nint num3 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v503 @ X9_v9+18]");
		if ((object)(num3 >= 0) == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v72 @ X0_v5 (System.Collections.Generic.List`1<System.Int32>)+18]");
			object obj23 = (nint)0 + (nint)1;
			object obj24 = obj7;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v72 @ X0_v5 (System.Collections.Generic.List`1<System.Int32>)+18]");
			object obj25 = obj24 + 0;
			_ = 4001;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v72 @ X0_v5 (System.Collections.Generic.List`1<System.Int32>)+1C]");
			object obj26 = (nint)0 + (nint)1;
		}
		else
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v507 @ X8_v10+20]");
			object obj27 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v462 @ X8_v66+C0]");
			object obj28 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v463 @ X8_v67+70]");
			object obj14 = 0;
			list2.AddWithResize(4001);
			obj5 = obj4;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v72 @ X0_v5 (System.Collections.Generic.List`1<System.Int32>)+10]");
			obj7 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v72 @ X0_v5 (System.Collections.Generic.List`1<System.Int32>)+1C]");
			object obj29 = (nint)0 + (nint)1;
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v72 @ X0_v5 (System.Collections.Generic.List`1<System.Int32>)+18]");
		nint num4 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v503 @ X9_v9+18]");
		if ((object)(num4 >= 0) == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v72 @ X0_v5 (System.Collections.Generic.List`1<System.Int32>)+18]");
			object obj30 = (nint)0 + (nint)1;
			object obj31 = obj7;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v72 @ X0_v5 (System.Collections.Generic.List`1<System.Int32>)+18]");
			object obj32 = obj31 + 0;
			_ = 6001;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v72 @ X0_v5 (System.Collections.Generic.List`1<System.Int32>)+1C]");
			object obj33 = (nint)0 + (nint)1;
		}
		else
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v507 @ X8_v10+20]");
			object obj34 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v480 @ X8_v63+C0]");
			object obj35 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v481 @ X8_v64+70]");
			object obj14 = 0;
			list2.AddWithResize(6001);
			obj5 = obj4;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v72 @ X0_v5 (System.Collections.Generic.List`1<System.Int32>)+10]");
			obj7 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v72 @ X0_v5 (System.Collections.Generic.List`1<System.Int32>)+1C]");
			object obj36 = (nint)0 + (nint)1;
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v72 @ X0_v5 (System.Collections.Generic.List`1<System.Int32>)+18]");
		nint num5 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v503 @ X9_v9+18]");
		if ((object)(num5 >= 0) == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v72 @ X0_v5 (System.Collections.Generic.List`1<System.Int32>)+18]");
			object obj37 = (nint)0 + (nint)1;
			object obj38 = obj7;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v72 @ X0_v5 (System.Collections.Generic.List`1<System.Int32>)+18]");
			object obj39 = obj38 + 0;
			_ = 8001;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v72 @ X0_v5 (System.Collections.Generic.List`1<System.Int32>)+1C]");
			object obj40 = (nint)0 + (nint)1;
		}
		else
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v507 @ X8_v10+20]");
			object obj41 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v498 @ X8_v60+C0]");
			object obj42 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v499 @ X8_v61+70]");
			object obj14 = 0;
			list2.AddWithResize(8001);
			obj5 = obj4;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v72 @ X0_v5 (System.Collections.Generic.List`1<System.Int32>)+10]");
			obj7 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v72 @ X0_v5 (System.Collections.Generic.List`1<System.Int32>)+1C]");
			object obj43 = (nint)0 + (nint)1;
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v72 @ X0_v5 (System.Collections.Generic.List`1<System.Int32>)+18]");
		nint num6 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v503 @ X9_v9+18]");
		if ((object)(num6 >= 0) == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v72 @ X0_v5 (System.Collections.Generic.List`1<System.Int32>)+18]");
			object obj44 = (nint)0 + (nint)1;
			object obj45 = obj7;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v72 @ X0_v5 (System.Collections.Generic.List`1<System.Int32>)+18]");
			object obj46 = obj45 + 0;
			_ = 10500;
		}
		else
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v507 @ X8_v10+20]");
			object obj47 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v513 @ X8_v56+C0]");
			object obj48 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v514 @ X8_v57+70]");
			object obj14 = 0;
			list2.AddWithResize(10500);
		}
		object obj49 = (nint)0 + (nint)2920;
		object obj50 = obj49;
		list._version++;
		object[] items = list._items;
		if ((object)(list._size >= items.Length) == null)
		{
			list._size++;
			object obj51 = (object)(items + list._size) + 32;
			obj51 = list2;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
			object obj52 = list2;
		}
		else
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v356 @ X8_v12+20]");
			object obj53 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v527 @ X8_v53+C0]");
			object obj54 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v528 @ X8_v54+70]");
			object obj14 = 0;
			list.AddWithResize((object)list2);
			object obj52 = list2;
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
		List<int> list3 = default(List<int>);
		list3..ctor();
		object obj55 = obj4;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v320 @ X0_v16 (System.Collections.Generic.List`1<System.Int32>)+1C]");
		object obj56 = (nint)0 + (nint)1;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v320 @ X0_v16 (System.Collections.Generic.List`1<System.Int32>)+10]");
		object obj57 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v320 @ X0_v16 (System.Collections.Generic.List`1<System.Int32>)+18]");
		nint num7 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v657 @ X9_v23+18]");
		if ((object)(num7 >= 0) == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v320 @ X0_v16 (System.Collections.Generic.List`1<System.Int32>)+18]");
			object obj58 = (nint)0 + (nint)1;
			object obj59 = obj57;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v320 @ X0_v16 (System.Collections.Generic.List`1<System.Int32>)+18]");
			object obj60 = obj59 + 0;
			_ = 12501;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v320 @ X0_v16 (System.Collections.Generic.List`1<System.Int32>)+1C]");
			object obj61 = (nint)0 + (nint)1;
		}
		else
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v661 @ X8_v21+20]");
			object obj62 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v544 @ X8_v50+C0]");
			object obj63 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v545 @ X8_v51+70]");
			object obj14 = 0;
			list3.AddWithResize(12501);
			obj55 = obj4;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v320 @ X0_v16 (System.Collections.Generic.List`1<System.Int32>)+10]");
			obj57 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v320 @ X0_v16 (System.Collections.Generic.List`1<System.Int32>)+1C]");
			object obj64 = (nint)0 + (nint)1;
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v320 @ X0_v16 (System.Collections.Generic.List`1<System.Int32>)+18]");
		nint num8 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v657 @ X9_v23+18]");
		if ((object)(num8 >= 0) == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v320 @ X0_v16 (System.Collections.Generic.List`1<System.Int32>)+18]");
			object obj65 = (nint)0 + (nint)1;
			object obj66 = obj57;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v320 @ X0_v16 (System.Collections.Generic.List`1<System.Int32>)+18]");
			object obj67 = obj66 + 0;
			_ = 15001;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v320 @ X0_v16 (System.Collections.Generic.List`1<System.Int32>)+1C]");
			object obj68 = (nint)0 + (nint)1;
		}
		else
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v661 @ X8_v21+20]");
			object obj69 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v562 @ X8_v47+C0]");
			object obj70 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v563 @ X8_v48+70]");
			object obj14 = 0;
			list3.AddWithResize(15001);
			obj55 = obj4;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v320 @ X0_v16 (System.Collections.Generic.List`1<System.Int32>)+10]");
			obj57 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v320 @ X0_v16 (System.Collections.Generic.List`1<System.Int32>)+1C]");
			object obj71 = (nint)0 + (nint)1;
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v320 @ X0_v16 (System.Collections.Generic.List`1<System.Int32>)+18]");
		nint num9 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v657 @ X9_v23+18]");
		if ((object)(num9 >= 0) == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v320 @ X0_v16 (System.Collections.Generic.List`1<System.Int32>)+18]");
			object obj72 = (nint)0 + (nint)1;
			object obj73 = obj57;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v320 @ X0_v16 (System.Collections.Generic.List`1<System.Int32>)+18]");
			object obj74 = obj73 + 0;
			_ = 17501;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v320 @ X0_v16 (System.Collections.Generic.List`1<System.Int32>)+1C]");
			object obj75 = (nint)0 + (nint)1;
		}
		else
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v661 @ X8_v21+20]");
			object obj76 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v580 @ X8_v44+C0]");
			object obj77 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v581 @ X8_v45+70]");
			object obj14 = 0;
			list3.AddWithResize(17501);
			obj55 = obj4;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v320 @ X0_v16 (System.Collections.Generic.List`1<System.Int32>)+10]");
			obj57 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v320 @ X0_v16 (System.Collections.Generic.List`1<System.Int32>)+1C]");
			object obj78 = (nint)0 + (nint)1;
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v320 @ X0_v16 (System.Collections.Generic.List`1<System.Int32>)+18]");
		nint num10 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v657 @ X9_v23+18]");
		if ((object)(num10 >= 0) == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v320 @ X0_v16 (System.Collections.Generic.List`1<System.Int32>)+18]");
			object obj79 = (nint)0 + (nint)1;
			object obj80 = obj57;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v320 @ X0_v16 (System.Collections.Generic.List`1<System.Int32>)+18]");
			object obj81 = obj80 + 0;
			_ = 20001;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v320 @ X0_v16 (System.Collections.Generic.List`1<System.Int32>)+1C]");
			object obj82 = (nint)0 + (nint)1;
		}
		else
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v661 @ X8_v21+20]");
			object obj83 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v598 @ X8_v41+C0]");
			object obj84 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v599 @ X8_v42+70]");
			object obj14 = 0;
			list3.AddWithResize(20001);
			obj55 = obj4;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v320 @ X0_v16 (System.Collections.Generic.List`1<System.Int32>)+10]");
			obj57 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v320 @ X0_v16 (System.Collections.Generic.List`1<System.Int32>)+1C]");
			object obj85 = (nint)0 + (nint)1;
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v320 @ X0_v16 (System.Collections.Generic.List`1<System.Int32>)+18]");
		nint num11 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v657 @ X9_v23+18]");
		if ((object)(num11 >= 0) == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v320 @ X0_v16 (System.Collections.Generic.List`1<System.Int32>)+18]");
			object obj86 = (nint)0 + (nint)1;
			object obj87 = obj57;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v320 @ X0_v16 (System.Collections.Generic.List`1<System.Int32>)+18]");
			object obj88 = obj87 + 0;
			_ = 25001;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v320 @ X0_v16 (System.Collections.Generic.List`1<System.Int32>)+1C]");
			object obj89 = (nint)0 + (nint)1;
		}
		else
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v661 @ X8_v21+20]");
			object obj90 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v616 @ X8_v38+C0]");
			object obj91 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v617 @ X8_v39+70]");
			object obj14 = 0;
			list3.AddWithResize(25001);
			obj55 = obj4;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v320 @ X0_v16 (System.Collections.Generic.List`1<System.Int32>)+10]");
			obj57 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v320 @ X0_v16 (System.Collections.Generic.List`1<System.Int32>)+1C]");
			object obj92 = (nint)0 + (nint)1;
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v320 @ X0_v16 (System.Collections.Generic.List`1<System.Int32>)+18]");
		nint num12 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v657 @ X9_v23+18]");
		if ((object)(num12 >= 0) == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v320 @ X0_v16 (System.Collections.Generic.List`1<System.Int32>)+18]");
			object obj93 = (nint)0 + (nint)1;
			object obj94 = obj57;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v320 @ X0_v16 (System.Collections.Generic.List`1<System.Int32>)+18]");
			object obj95 = obj94 + 0;
			_ = 30001;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v320 @ X0_v16 (System.Collections.Generic.List`1<System.Int32>)+1C]");
			object obj96 = (nint)0 + (nint)1;
		}
		else
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v661 @ X8_v21+20]");
			object obj97 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v634 @ X8_v35+C0]");
			object obj98 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v635 @ X8_v36+70]");
			object obj14 = 0;
			list3.AddWithResize(30001);
			obj55 = obj4;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v320 @ X0_v16 (System.Collections.Generic.List`1<System.Int32>)+10]");
			obj57 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v320 @ X0_v16 (System.Collections.Generic.List`1<System.Int32>)+1C]");
			object obj99 = (nint)0 + (nint)1;
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v320 @ X0_v16 (System.Collections.Generic.List`1<System.Int32>)+18]");
		nint num13 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v657 @ X9_v23+18]");
		if ((object)(num13 >= 0) == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v320 @ X0_v16 (System.Collections.Generic.List`1<System.Int32>)+18]");
			object obj100 = (nint)0 + (nint)1;
			object obj101 = obj57;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v320 @ X0_v16 (System.Collections.Generic.List`1<System.Int32>)+18]");
			object obj102 = obj101 + 0;
			_ = 35001;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v320 @ X0_v16 (System.Collections.Generic.List`1<System.Int32>)+1C]");
			object obj103 = (nint)0 + (nint)1;
		}
		else
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v661 @ X8_v21+20]");
			object obj104 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v652 @ X8_v32+C0]");
			object obj105 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v653 @ X8_v33+70]");
			object obj14 = 0;
			list3.AddWithResize(35001);
			obj55 = obj4;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v320 @ X0_v16 (System.Collections.Generic.List`1<System.Int32>)+10]");
			obj57 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v320 @ X0_v16 (System.Collections.Generic.List`1<System.Int32>)+1C]");
			object obj106 = (nint)0 + (nint)1;
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v320 @ X0_v16 (System.Collections.Generic.List`1<System.Int32>)+18]");
		nint num14 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v657 @ X9_v23+18]");
		if ((object)(num14 >= 0) == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v320 @ X0_v16 (System.Collections.Generic.List`1<System.Int32>)+18]");
			object obj107 = (nint)0 + (nint)1;
			object obj108 = obj57;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v320 @ X0_v16 (System.Collections.Generic.List`1<System.Int32>)+18]");
			object obj109 = obj108 + 0;
			_ = 40001;
		}
		else
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v661 @ X8_v21+20]");
			object obj110 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v667 @ X8_v28+C0]");
			object obj111 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v668 @ X8_v29+70]");
			object obj14 = 0;
			list3.AddWithResize(40001);
		}
		object obj112 = obj49;
		list._version++;
		object[] items2 = list._items;
		if ((object)(list._size >= items2.Length) == null)
		{
			list._size++;
			object obj113 = (object)(items2 + list._size) + 32;
			obj113 = list3;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
		}
		else
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v366 @ X8_v23+20]");
			object obj114 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v682 @ X8_v25+C0]");
			object obj115 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v683 @ X8_v26+70]");
			object obj14 = 0;
			list.AddWithResize((object)list3);
		}
		object obj116 = this + 24;
		obj116 = list;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
		base..ctor();
	}
}

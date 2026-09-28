using System;
using System.Data;
using System.Runtime.Remoting.Messaging;
using Cpp2ILInjected;
using Kammelna.Server.Models.Clans;
using Newtonsoft.Json.Linq.JsonPath;
using UnityEngine;

public class KTimeOnlyPicker : KBaseTimePicker
{
	private UIPicker hoursPicker;

	private UIPicker minutesPicker;

	protected override void Initialize()
	{
		//IL_000c: Expected O, but got I
		//IL_0021: Unknown result type (might be due to invalid IL or missing references)
		//IL_0026: Expected O, but got Unknown
		//IL_003d: Expected I, but got O
		//IL_004d: Expected O, but got I
		//IL_005d: Expected O, but got I
		object obj = (nint)0 + (nint)4008;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2D3103C");
		object obj2 = this + 88;
		object obj3 = default(object);
		obj2 = obj3;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
		nint num = (nint)this;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v51 @ X8_v3 (Il2CppClass<KTimeOnlyPicker>)+1E8]");
		object obj4 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v51 @ X8_v3 (Il2CppClass<KTimeOnlyPicker>)+1F0]");
		object obj5 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Indirect jump: v52 @ X2_v1 (should have been resolved before IL gen)");
		/*Error: End of method reached without returning.*/;
	}

	protected override void SetPickedDateTime()
	{
		//IL_000f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0014: Expected O, but got Unknown
		//IL_03bb: Expected O, but got I4
		//IL_00a6: Unknown result type (might be due to invalid IL or missing references)
		//IL_00ab: Expected O, but got Unknown
		//IL_02da: Expected O, but got I4
		//IL_02e3: Expected O, but got I4
		//IL_02ec: Expected O, but got I4
		//IL_0103: Expected O, but got I4
		//IL_010c: Expected O, but got I4
		//IL_0309: Unknown result type (might be due to invalid IL or missing references)
		//IL_030e: Expected O, but got Unknown
		//IL_0325: Unknown result type (might be due to invalid IL or missing references)
		//IL_032a: Expected O, but got Unknown
		//IL_0354: Expected O, but got I4
		//IL_013a: Expected O, but got I
		//IL_019f: Unknown result type (might be due to invalid IL or missing references)
		//IL_01a4: Expected O, but got Unknown
		//IL_01db: Expected O, but got I4
		//IL_03d8: Unknown result type (might be due to invalid IL or missing references)
		//IL_03dd: Expected O, but got Unknown
		//IL_0233: Expected O, but got I4
		//IL_0171: Expected I, but got O
		//IL_0181: Expected O, but got I
		object obj = typeof(DataRelation) + 712;
		object obj2 = obj;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v53 @ X0_v2+E4]");
		bool flag = (nint)0 == 0;
		object obj3 = !flag;
		if (obj3 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		}
		DateTime now = DateTime.Now;
		DateTime dateTime = default(DateTime);
		int year = dateTime.Year;
		DateTime now2 = DateTime.Now;
		int month = dateTime.Month;
		DateTime now3 = DateTime.Now;
		int day = dateTime.Day;
		UIPicker uIPicker = hoursPicker;
		UIPicker uIPicker2 = minutesPicker;
		object obj4 = typeof(MemberAchievementClanFeedData) + 2976;
		object obj5 = obj4;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v122 @ X0_v18+E4]");
		object obj6;
		UnityEngine.Object obj8;
		object obj7;
		if ((nint)0 != 0)
		{
			bool flag2 = uIPicker2.currentSelection != null;
			bool flag3 = !flag2;
			obj6 = 0;
			obj7 = 0;
			obj8 = null;
			if (!flag3)
			{
				goto IL_011f;
			}
		}
		else
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			bool flag4 = uIPicker2.currentSelection != null;
			bool flag5 = !flag4;
			object obj9 = !flag5;
			obj6 = 0;
			obj7 = 0;
			obj8 = null;
			if (obj9 != null)
			{
				goto IL_011f;
			}
		}
		object obj10 = ", stale={0}" + 3424;
		string text = (string)obj10;
		object obj11 = typeof(System.Runtime.Remoting.Messaging.CallContextSecurityData) + 3016;
		object obj12 = obj11;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v208 @ X8_v7+E4]");
		bool flag6 = (nint)0 == 0;
		object obj13 = !flag6;
		obj6 = obj7;
		string text2 = (string)obj10;
		if (obj13 != null)
		{
			goto IL_0190;
		}
		goto IL_0372;
		IL_011f:
		UIPicker uIPicker3 = minutesPicker;
		object obj14 = (nint)0 + (nint)1472;
		obj8 = (UnityEngine.Object)obj14;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2E32EDC");
		if (text != null)
		{
			nint num = (nint)text;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v241 @ X8_v25 (Il2CppClass<System.String>)+550]");
			obj8 = (UnityEngine.Object)0;
			Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v241 @ X8_v25 (Il2CppClass<System.String>)+548] (should have been resolved before IL gen)");
		}
		object obj15 = typeof(System.Runtime.Remoting.Messaging.CallContextSecurityData) + 3016;
		obj12 = obj15;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v208 @ X8_v7+E4]");
		bool flag7 = (nint)0 == 0;
		obj7 = obj6;
		text2 = text;
		if (!flag7)
		{
			goto IL_0190;
		}
		goto IL_0372;
		IL_0190:
		object obj16 = typeof(Newtonsoft.Json.Linq.JsonPath.JPath) + 4000;
		int minute = Convert.ToInt32(text);
		object obj17 = obj;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v230 @ X0_v30+E4]");
		bool flag8 = (nint)0 == 0;
		object obj18 = !flag8;
		if (obj18 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		}
		int val = DateTime.DaysInMonth(year, month);
		object obj19 = obj16;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v250 @ X0_v34+E4]");
		bool flag9 = (nint)0 == 0;
		object obj20 = !flag9;
		if (obj20 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		}
		int day2 = Math.Min(day, val);
		DateTime dateTime2 = new DateTime(year, month, day2, uIPicker._currentSelectionIndex, minute, 0);
		DateTime = dateTime2;
		AdjustDateTime();
		return;
		IL_0372:
		Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		obj7 = obj6;
		text = text2;
		goto IL_0190;
	}

	protected override void SetUiTo(DateTime time)
	{
		//IL_0009: Expected O, but got I4
		//IL_0018: Unknown result type (might be due to invalid IL or missing references)
		//IL_001d: Expected O, but got Unknown
		//IL_0033: Expected O, but got I
		//IL_0105: Expected O, but got I4
		//IL_00b8: Expected O, but got I4
		//IL_0158: Expected O, but got I4
		//IL_017e: Expected O, but got I4
		object obj = 152989696;
		object obj2 = typeof(DataRelation) + 712;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [91E75B4]");
		object obj3 = (nint)0 & (nint)1;
		UIPicker uIPicker;
		UIPicker uIPicker2;
		if (obj3 != null)
		{
			uIPicker = hoursPicker;
			object obj4 = obj2;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v56 @ X0_v8+E4]");
			bool flag = (nint)0 == 0;
			uIPicker2 = hoursPicker;
			if (!flag)
			{
				goto IL_0091;
			}
		}
		else
		{
			_ = 1;
			uIPicker = hoursPicker;
			object obj4 = obj2;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v56 @ X0_v8+E4]");
			bool flag2 = (nint)0 == 0;
			object obj5 = !flag2;
			uIPicker2 = hoursPicker;
			if (obj5 != null)
			{
				goto IL_0091;
			}
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		DateTime dateTime = default(DateTime);
		int hour = dateTime.Hour;
		uIPicker = uIPicker2;
		goto IL_0146;
		IL_0146:
		uIPicker.LerpToItemWithIndex(hour, (int?)(object)0);
		int minute = dateTime.Minute;
		minutesPicker.LerpToItemWithIndex(minute, (int?)(object)0);
		return;
		IL_0091:
		hour = dateTime.Hour;
		bool flag3 = (object)uIPicker == null;
		object obj6 = !flag3;
		if (obj6 == null)
		{
			throw new NullReferenceException();
		}
		goto IL_0146;
	}

	protected unsafe override void AdjustDateTime()
	{
		//IL_0009: Expected O, but got I4
		//IL_001f: Expected O, but got I
		//IL_00b4: Unknown result type (might be due to invalid IL or missing references)
		//IL_00b9: Expected O, but got Unknown
		//IL_004b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0050: Expected O, but got Unknown
		//IL_01fe: Unknown result type (might be due to invalid IL or missing references)
		//IL_0203: Expected O, but got Unknown
		//IL_022d: Expected O, but got I4
		//IL_00f3: Unknown result type (might be due to invalid IL or missing references)
		//IL_00f8: Expected O, but got Unknown
		//IL_0122: Expected O, but got I4
		//IL_0265: Expected O, but got I8
		//IL_015a: Expected O, but got I8
		//IL_0176: Expected I, but got O
		//IL_02b1: Expected O, but got I4
		//IL_01ae: Expected O, but got I4
		//IL_02f1: Expected I8, but got O
		//IL_02ec: Expected native int or pointer, but got O
		//IL_01ee: Expected I8, but got O
		//IL_01e9: Expected native int or pointer, but got O
		//IL_01f3: Expected I, but got O
		object obj = 152989696;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [91E75B5]");
		object obj2 = (nint)0 & (nint)1;
		object obj3;
		IPicker.PickerMode mode;
		object obj4;
		if (obj2 != null)
		{
			obj3 = typeof(DataRelation) + 712;
			mode = Mode;
			bool flag = Mode == IPicker.PickerMode.PastOnly;
			obj4 = obj3;
			if (!flag)
			{
				goto IL_0081;
			}
		}
		else
		{
			_ = 1;
			obj3 = typeof(DataRelation) + 712;
			mode = Mode;
			bool flag2 = Mode != IPicker.PickerMode.PastOnly;
			obj4 = obj3;
			if (flag2)
			{
				goto IL_0081;
			}
		}
		DateTime dateTime = (DateTime)(this + 80);
		object obj5 = obj4;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v98 @ X0_v15+E4]");
		bool flag3 = (nint)0 == 0;
		object obj6 = !flag3;
		if (obj6 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		}
		DateTime now = DateTime.Now;
		bool flag4 = (DateTime)dateTime._dateData > now;
		bool flag5 = !flag4;
		nint num = (nint)now;
		if (!flag5)
		{
			object obj7 = obj4;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v218 @ X0_v22+E4]");
			bool flag6 = (nint)0 == 0;
			object obj8 = !flag6;
			if (obj8 == null)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			}
			DateTime dateTime2 = ((DateTime*)dateTime)->AddDays(-1.0);
			((DateTime*)(nint)dateTime)->_dateData = (ulong)(long)dateTime2;
			num = unchecked((nint)null);
		}
		bool flag7 = Mode != IPicker.PickerMode.FutureOnly;
		obj3 = obj4;
		if (flag7)
		{
			return;
		}
		goto IL_01f8;
		IL_0081:
		if (mode != IPicker.PickerMode.FutureOnly)
		{
			return;
		}
		goto IL_01f8;
		IL_01f8:
		DateTime dateTime3 = (DateTime)(this + 80);
		object obj9 = obj3;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v170 @ X0_v2+E4]");
		bool flag8 = (nint)0 == 0;
		object obj10 = !flag8;
		if (obj10 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		}
		DateTime now2 = DateTime.Now;
		if ((DateTime)dateTime3._dateData < now2)
		{
			object obj11 = obj3;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v227 @ X0_v8+E4]");
			bool flag9 = (nint)0 == 0;
			object obj12 = !flag9;
			if (obj12 == null)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			}
			DateTime dateTime4 = ((DateTime*)dateTime3)->AddDays(1.0);
			((DateTime*)(nint)dateTime3)->_dateData = (ulong)(long)dateTime4;
		}
	}
}

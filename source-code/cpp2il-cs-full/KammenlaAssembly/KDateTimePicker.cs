using System;
using System.Data;
using System.Data.SqlTypes;
using System.Runtime.Remoting.Messaging;
using Cpp2ILInjected;
using Kammelna.Server.Models.Clans;
using Newtonsoft.Json.Linq.JsonPath;
using TMPro;
using UnityEngine;

public class KDateTimePicker : KBaseTimePicker
{
	private UIPicker monthPicker;

	private UIPicker dayPicker;

	private UIPicker hoursPicker;

	private UIPicker minutesPicker;

	protected override void Initialize()
	{
		//IL_000c: Expected O, but got I
		//IL_001b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0020: Expected O, but got Unknown
		//IL_002c: Expected O, but got I
		//IL_02d0: Unknown result type (might be due to invalid IL or missing references)
		//IL_02d5: Expected O, but got Unknown
		//IL_0036: Expected I, but got O
		//IL_0055: Expected I, but got O
		//IL_02fe: Expected O, but got I
		//IL_030a: Expected O, but got I
		//IL_0316: Expected O, but got I
		//IL_0321: Unknown result type (might be due to invalid IL or missing references)
		//IL_0326: Expected O, but got Unknown
		//IL_00f4: Expected I, but got O
		//IL_033e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0343: Expected O, but got Unknown
		//IL_0193: Expected I, but got O
		//IL_035b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0360: Expected O, but got Unknown
		//IL_0232: Expected I, but got O
		//IL_0378: Unknown result type (might be due to invalid IL or missing references)
		//IL_037d: Expected O, but got Unknown
		object obj = (nint)0 + (nint)4008;
		object obj2 = typeof(SqlSingle[]) + 2376;
		object obj3 = (nint)0 + (nint)3216;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2D3103C");
		object obj4 = this + 88;
		object obj5 = default(object);
		obj4 = obj5;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
		LocalizeMonthItems();
		nint num = (nint)this;
		SetPickedDateTime();
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
		Action action = default(Action);
		action..ctor(this, (IntPtr)obj3);
		object obj6 = (nint)0 + (nint)3224;
		object obj7 = (nint)0 + (nint)3232;
		object obj8 = (nint)0 + (nint)3240;
		object obj9 = monthPicker + 136;
		Delegate obj10 = (Delegate)obj9;
		Delegate obj12 = default(Delegate);
		Action action2 = default(Action);
		Delegate obj16 = default(Delegate);
		Action action3 = default(Action);
		Delegate obj20 = default(Delegate);
		Action action4 = default(Action);
		Delegate obj24 = default(Delegate);
		while (true)
		{
			Delegate obj11 = Delegate.Combine(obj10, action);
			if ((object)obj11 == null || obj11 == obj2)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @B0C814");
				bool flag = (object)obj12 == obj10;
				obj10 = obj12;
				if (!flag)
				{
					continue;
				}
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
				action2..ctor(this, (IntPtr)obj6);
				object obj13 = dayPicker + 136;
				Delegate obj14 = (Delegate)obj13;
				while (true)
				{
					Delegate obj15 = Delegate.Combine(obj14, action2);
					if ((object)obj15 != null && obj15 != obj2)
					{
						break;
					}
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @B0C814");
					bool flag2 = (object)obj16 == obj14;
					obj14 = obj16;
					if (!flag2)
					{
						continue;
					}
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
					action3..ctor(this, (IntPtr)obj7);
					object obj17 = hoursPicker + 136;
					Delegate obj18 = (Delegate)obj17;
					while (true)
					{
						Delegate obj19 = Delegate.Combine(obj18, action3);
						if ((object)obj19 != null && obj19 != obj2)
						{
							break;
						}
						Cpp2ILHelpers.NoteDecompilerIssue("Method not found @B0C814");
						bool flag3 = (object)obj20 == obj18;
						obj18 = obj20;
						if (!flag3)
						{
							continue;
						}
						Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
						action4..ctor(this, (IntPtr)obj8);
						object obj21 = minutesPicker + 136;
						Delegate obj22 = (Delegate)obj21;
						while (true)
						{
							Delegate obj23 = Delegate.Combine(obj22, action4);
							if ((object)obj23 == null || obj23 == obj2)
							{
								Cpp2ILHelpers.NoteDecompilerIssue("Method not found @B0C814");
								bool flag4 = (object)obj24 == obj22;
								obj22 = obj24;
								if (!flag4)
								{
									continue;
								}
								return;
							}
							break;
						}
						break;
					}
					break;
				}
			}
			throw new InvalidCastException();
		}
	}

	protected override void SetPickedDateTime()
	{
		//IL_000f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0014: Expected O, but got Unknown
		//IL_03dc: Expected O, but got I4
		//IL_008e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0093: Expected O, but got Unknown
		//IL_02fb: Expected O, but got I4
		//IL_0304: Expected O, but got I4
		//IL_030d: Expected O, but got I4
		//IL_00eb: Expected O, but got I4
		//IL_00f4: Expected O, but got I4
		//IL_032a: Unknown result type (might be due to invalid IL or missing references)
		//IL_032f: Expected O, but got Unknown
		//IL_0346: Unknown result type (might be due to invalid IL or missing references)
		//IL_034b: Expected O, but got Unknown
		//IL_0375: Expected O, but got I4
		//IL_0122: Expected O, but got I
		//IL_0187: Unknown result type (might be due to invalid IL or missing references)
		//IL_018c: Expected O, but got Unknown
		//IL_01c3: Expected O, but got I4
		//IL_03f9: Unknown result type (might be due to invalid IL or missing references)
		//IL_03fe: Expected O, but got Unknown
		//IL_022e: Expected O, but got I4
		//IL_0159: Expected I, but got O
		//IL_0169: Expected O, but got I
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
		UIPicker uIPicker = monthPicker;
		UIPicker uIPicker2 = dayPicker;
		UIPicker uIPicker3 = hoursPicker;
		UIPicker uIPicker4 = minutesPicker;
		object obj4 = typeof(MemberAchievementClanFeedData) + 2976;
		object obj5 = obj4;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v170 @ X8_v6+E4]");
		object obj6;
		UnityEngine.Object obj8;
		object obj7;
		if ((nint)0 != 0)
		{
			bool flag2 = uIPicker4.currentSelection != null;
			bool flag3 = !flag2;
			obj6 = 0;
			obj7 = 0;
			obj8 = null;
			if (!flag3)
			{
				goto IL_0107;
			}
		}
		else
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			bool flag4 = uIPicker4.currentSelection != null;
			bool flag5 = !flag4;
			object obj9 = !flag5;
			obj6 = 0;
			obj7 = 0;
			obj8 = null;
			if (obj9 != null)
			{
				goto IL_0107;
			}
		}
		object obj10 = ", stale={0}" + 3424;
		string text = (string)obj10;
		object obj11 = typeof(System.Runtime.Remoting.Messaging.CallContextSecurityData) + 3016;
		object obj12 = obj11;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v212 @ X8_v7+E4]");
		bool flag6 = (nint)0 == 0;
		object obj13 = !flag6;
		obj6 = obj7;
		string text2 = (string)obj10;
		if (obj13 != null)
		{
			goto IL_0178;
		}
		goto IL_0393;
		IL_0107:
		UIPicker uIPicker5 = minutesPicker;
		object obj14 = (nint)0 + (nint)1472;
		obj8 = (UnityEngine.Object)obj14;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2E32EDC");
		if (text != null)
		{
			nint num = (nint)text;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v245 @ X8_v25 (Il2CppClass<System.String>)+550]");
			obj8 = (UnityEngine.Object)0;
			Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v245 @ X8_v25 (Il2CppClass<System.String>)+548] (should have been resolved before IL gen)");
		}
		object obj15 = typeof(System.Runtime.Remoting.Messaging.CallContextSecurityData) + 3016;
		obj12 = obj15;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v212 @ X8_v7+E4]");
		bool flag7 = (nint)0 == 0;
		obj7 = obj6;
		text2 = text;
		if (!flag7)
		{
			goto IL_0178;
		}
		goto IL_0393;
		IL_0178:
		object obj16 = typeof(Newtonsoft.Json.Linq.JsonPath.JPath) + 4000;
		int minute = Convert.ToInt32(text);
		object obj17 = obj;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v234 @ X0_v23+E4]");
		bool flag8 = (nint)0 == 0;
		object obj18 = !flag8;
		if (obj18 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		}
		int month = uIPicker._currentSelectionIndex + 1;
		int val = DateTime.DaysInMonth(year, month);
		object obj19 = obj16;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v254 @ X0_v27+E4]");
		bool flag9 = (nint)0 == 0;
		object obj20 = !flag9;
		if (obj20 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		}
		int val2 = uIPicker2._currentSelectionIndex + 1;
		int day = Math.Min(val2, val);
		int month2 = uIPicker._currentSelectionIndex + 1;
		DateTime dateTime2 = new DateTime(year, month2, day, uIPicker3._currentSelectionIndex, minute, 0);
		DateTime = dateTime2;
		base.AdjustDateTime();
		return;
		IL_0393:
		Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		obj7 = obj6;
		text = text2;
		goto IL_0178;
	}

	protected override void SetUiTo(DateTime time)
	{
		//IL_0009: Expected O, but got I4
		//IL_0018: Unknown result type (might be due to invalid IL or missing references)
		//IL_001d: Expected O, but got Unknown
		//IL_0033: Expected O, but got I
		//IL_0105: Expected O, but got I4
		//IL_00b8: Expected O, but got I4
		//IL_0166: Expected O, but got I4
		//IL_019a: Expected O, but got I4
		//IL_01c0: Expected O, but got I4
		//IL_01e6: Expected O, but got I4
		object obj = 152989696;
		object obj2 = typeof(DataRelation) + 712;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [91E7591]");
		object obj3 = (nint)0 & (nint)1;
		UIPicker uIPicker;
		UIPicker uIPicker2;
		if (obj3 != null)
		{
			uIPicker = monthPicker;
			object obj4 = obj2;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v56 @ X0_v14+E4]");
			bool flag = (nint)0 == 0;
			uIPicker2 = monthPicker;
			if (!flag)
			{
				goto IL_0091;
			}
		}
		else
		{
			_ = 1;
			uIPicker = monthPicker;
			object obj4 = obj2;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v56 @ X0_v14+E4]");
			bool flag2 = (nint)0 == 0;
			object obj5 = !flag2;
			uIPicker2 = monthPicker;
			if (obj5 != null)
			{
				goto IL_0091;
			}
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		DateTime dateTime = default(DateTime);
		int month = dateTime.Month;
		uIPicker = uIPicker2;
		goto IL_0146;
		IL_0146:
		int index = month - 1;
		uIPicker.LerpToItemWithIndex(index, (int?)(object)0);
		int day = dateTime.Day;
		int index2 = day - 1;
		dayPicker.LerpToItemWithIndex(index2, (int?)(object)0);
		int hour = dateTime.Hour;
		hoursPicker.LerpToItemWithIndex(hour, (int?)(object)0);
		int minute = dateTime.Minute;
		minutesPicker.LerpToItemWithIndex(minute, (int?)(object)0);
		return;
		IL_0091:
		month = dateTime.Month;
		bool flag3 = (object)uIPicker == null;
		object obj6 = !flag3;
		if (obj6 == null)
		{
			throw new NullReferenceException();
		}
		goto IL_0146;
	}

	private void LocalizeMonthItems()
	{
		//IL_0042: Expected O, but got I
		//IL_004b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0050: Expected O, but got Unknown
		//IL_0059: Expected O, but got I4
		//IL_0067: Unknown result type (might be due to invalid IL or missing references)
		//IL_006c: Expected O, but got Unknown
		UIPicker uIPicker = monthPicker;
		GameObject[] items = uIPicker.items;
		if (items.Length >= 1)
		{
			object obj = (nint)0 + (nint)1472;
			object obj2 = items + 32;
			object obj3 = 0;
			TextMeshProUGUI textMesh = default(TextMeshProUGUI);
			do
			{
				obj3++;
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2E32EDC");
				TextMeshProExtensions.Localize(textMesh);
			}
			while ((nint)obj3 < items.Length);
		}
	}

	public void SetTodayDate()
	{
		//IL_000f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0014: Expected O, but got Unknown
		//IL_009f: Expected O, but got I4
		//IL_0040: Expected I, but got O
		//IL_0050: Expected O, but got I
		//IL_0060: Expected O, but got I
		object obj = typeof(DataRelation) + 712;
		while (true)
		{
			skipPickerRebuild = true;
			object obj2 = obj;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v45 @ X0_v2+E4]");
			bool flag = (nint)0 == 0;
			object obj3 = !flag;
			if (obj3 == null)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			}
			DateTime now = DateTime.Now;
			DateTime = now;
			nint num = (nint)this;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v54 @ X8_v5 (Il2CppClass<KDateTimePicker>)+1F8]");
			object obj4 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v54 @ X8_v5 (Il2CppClass<KDateTimePicker>)+200]");
			object obj5 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Indirect jump: v55 @ X3_v1 (should have been resolved before IL gen)");
		}
	}

	private void <Initialize>b__4_0()
	{
		skipPickerRebuild = false;
	}

	private void <Initialize>b__4_1()
	{
		skipPickerRebuild = false;
	}

	private void <Initialize>b__4_2()
	{
		skipPickerRebuild = false;
	}

	private void <Initialize>b__4_3()
	{
		skipPickerRebuild = false;
	}
}

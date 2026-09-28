using System;
using System.Collections;
using System.Data;
using Cpp2ILInjected;
using Newtonsoft.Json.Linq.JsonPath;
using UnityEngine.Purchasing.Telemetry;
using UnityEngine.TextCore;
using Util;

[Serializable]
public class TextCountdownFormat : DateTimeFormat
{
	private readonly bool <IsCountDown>k__BackingField = true;

	private DateTimeUnit minUnit;

	private int activeUnits;

	public override bool IsCountDown => <IsCountDown>k__BackingField;

	public TextCountdownFormat()
	{
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [70DF8B0]");
		minUnit = DateTimeUnit.Years;
		((object)this)..ctor();
	}

	public TextCountdownFormat(int activeUnits, DateTimeUnit minUnit)
	{
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [70DF8B0]");
		this.minUnit = DateTimeUnit.Years;
		((object)this)..ctor();
		this.minUnit = minUnit;
		this.activeUnits = activeUnits;
	}

	public string Format(TimeSpan timeSpan)
	{
		//IL_000f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0014: Expected O, but got Unknown
		//IL_0084: Expected O, but got I4
		object obj = typeof(DataRelation) + 712;
		object obj2 = obj;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v45 @ X0_v2+E4]");
		bool flag = (nint)0 == 0;
		object obj3 = !flag;
		if (obj3 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		}
		DateTime now = DateTime.Now;
		DateTime dateTime2 = default(DateTime);
		DateTime dateTime = dateTime2.Add(timeSpan);
		return FormatDate(dateTime);
	}

	protected unsafe override string FormatDate(DateTime dateTime)
	{
		//IL_000f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0014: Expected O, but got Unknown
		//IL_0a5c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0a61: Expected O, but got Unknown
		//IL_0a8b: Expected O, but got I4
		//IL_0034: Expected O, but got I
		//IL_0043: Unknown result type (might be due to invalid IL or missing references)
		//IL_0048: Expected O, but got Unknown
		//IL_0091: Expected O, but got I4
		//IL_00b8: Unknown result type (might be due to invalid IL or missing references)
		//IL_00bd: Expected O, but got Unknown
		//IL_00c9: Expected O, but got I
		//IL_00d8: Expected O, but got I4
		//IL_0117: Expected O, but got I4
		//IL_0166: Expected O, but got I4
		//IL_0176: Expected O, but got I
		//IL_0787: Expected O, but got I
		//IL_07a9: Expected O, but got I4
		//IL_07b2: Expected O, but got I4
		//IL_01b8: Expected O, but got I
		//IL_01d8: Expected O, but got I4
		//IL_0823: Expected O, but got I4
		//IL_07fe: Expected O, but got I4
		//IL_0242: Expected O, but got I4
		//IL_0745: Expected O, but got Ref
		//IL_074d: Expected O, but got Ref
		//IL_0756: Expected O, but got I4
		//IL_0264: Unknown result type (might be due to invalid IL or missing references)
		//IL_0269: Expected O, but got Unknown
		//IL_0278: Unknown result type (might be due to invalid IL or missing references)
		//IL_027d: Expected O, but got Unknown
		//IL_028c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0291: Expected O, but got Unknown
		//IL_029a: Expected O, but got I4
		//IL_02ab: Expected O, but got I4
		//IL_0c0d: Expected I, but got O
		//IL_0c1d: Expected O, but got I
		//IL_032a: Expected O, but got I4
		//IL_0902: Unknown result type (might be due to invalid IL or missing references)
		//IL_0907: Expected O, but got Unknown
		//IL_0ace: Expected O, but got I
		//IL_0ae1: Unknown result type (might be due to invalid IL or missing references)
		//IL_0ae6: Expected O, but got Unknown
		//IL_0afd: Expected O, but got Ref
		//IL_0b05: Expected O, but got Ref
		//IL_0b0e: Expected O, but got I4
		//IL_02ce: Expected O, but got I
		//IL_0c5c: Expected O, but got I4
		//IL_0956: Expected O, but got I
		//IL_0376: Expected O, but got Ref
		//IL_037e: Expected O, but got Ref
		//IL_0387: Expected O, but got I4
		//IL_0337: Unknown result type (might be due to invalid IL or missing references)
		//IL_033c: Expected O, but got Unknown
		//IL_0345: Unknown result type (might be due to invalid IL or missing references)
		//IL_034a: Expected O, but got Unknown
		//IL_09e5: Expected O, but got I4
		//IL_02dc: Unknown result type (might be due to invalid IL or missing references)
		//IL_02e1: Expected O, but got Unknown
		//IL_02ea: Unknown result type (might be due to invalid IL or missing references)
		//IL_02ef: Expected O, but got Unknown
		//IL_0c9e: Expected O, but got I
		//IL_0991: Expected O, but got I
		//IL_03a5: Expected I, but got O
		//IL_03b5: Expected O, but got I
		//IL_044c: Expected O, but got I4
		//IL_0a08: Unknown result type (might be due to invalid IL or missing references)
		//IL_0a0d: Expected O, but got Unknown
		//IL_0b50: Expected O, but got I
		//IL_03f0: Expected O, but got I
		//IL_099f: Unknown result type (might be due to invalid IL or missing references)
		//IL_09a4: Expected O, but got Unknown
		//IL_09ad: Unknown result type (might be due to invalid IL or missing references)
		//IL_09b2: Expected O, but got Unknown
		//IL_087e: Expected O, but got Ref
		//IL_0886: Expected O, but got Ref
		//IL_088f: Expected O, but got I4
		//IL_045a: Unknown result type (might be due to invalid IL or missing references)
		//IL_045f: Expected O, but got Unknown
		//IL_0467: Unknown result type (might be due to invalid IL or missing references)
		//IL_046c: Expected O, but got Unknown
		//IL_0475: Unknown result type (might be due to invalid IL or missing references)
		//IL_047a: Expected O, but got Unknown
		//IL_0847: Expected O, but got Ref
		//IL_084f: Expected O, but got Ref
		//IL_0858: Expected O, but got I4
		//IL_03fe: Unknown result type (might be due to invalid IL or missing references)
		//IL_0403: Expected O, but got Unknown
		//IL_040c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0411: Expected O, but got Unknown
		//IL_04eb: Expected O, but got Ref
		//IL_04f3: Expected O, but got Ref
		//IL_04fc: Expected O, but got I4
		//IL_0522: Expected O, but got Ref
		//IL_052a: Expected O, but got Ref
		//IL_0533: Expected O, but got I4
		//IL_056b: Expected O, but got I4
		//IL_0595: Expected I4, but got O
		//IL_0b98: Unknown result type (might be due to invalid IL or missing references)
		//IL_0b9d: Expected O, but got Unknown
		//IL_0bb7: Expected O, but got I4
		//IL_0bc0: Expected O, but got I4
		//IL_0bd9: Expected O, but got I4
		//IL_06c2: Unknown result type (might be due to invalid IL or missing references)
		//IL_06c7: Expected O, but got Unknown
		//IL_06f1: Expected O, but got I4
		//IL_071b: Expected I8, but got I4
		//IL_0727: Expected I4, but got O
		//IL_060f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0614: Expected O, but got Unknown
		//IL_063e: Expected O, but got I4
		//IL_0668: Expected I8, but got I4
		//IL_068a: Expected I4, but got O
		object obj = typeof(DataRelation) + 712;
		object obj2 = typeof(UnityEngine.Purchasing.Telemetry.TelemetryMetricsInstanceWrapper) + 1032;
		object obj3 = obj;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v63 @ X0_v2+E4]");
		bool flag = (nint)0 == 0;
		object obj4 = !flag;
		if (obj4 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		}
		object obj5 = (nint)0 + (nint)2000;
		object obj6 = typeof(Newtonsoft.Json.Linq.JsonPath.JPath) + 2656;
		DateTime now = DateTime.Now;
		TimeSpan timeSpan = dateTime - now;
		object obj7 = obj2;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v89 @ X0_v8+E4]");
		bool flag2 = (nint)0 == 0;
		object obj8 = !flag2;
		if (obj8 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		}
		object input = "alignContent" + 264;
		object obj9 = (nint)0 + (nint)3072;
		object handle = 147423232 + 2616;
		TimeSpan timeSpan2 = default(TimeSpan);
		TimeSpan timeLeft = timeSpan2.Duration();
		string text = (string)obj5;
		object obj10 = obj6;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v112 @ X0_v12+E4]");
		bool flag3 = (nint)0 == 0;
		object obj11 = !flag3;
		if (obj11 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		}
		string text2 = LocalizationUtil.Localize((string)input);
		string text3 = (string)obj9 + text2;
		object obj12 = 153100288 + 1024;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v137 @ X22_v7+E0]");
		object obj13 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v138 @ X8_v6+E4]");
		Type typeFromHandle;
		Type enumType;
		if ((nint)0 != 0)
		{
			typeFromHandle = Type.GetTypeFromHandle((RuntimeTypeHandle)handle);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v137 @ X22_v7+98]");
			object obj14 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v173 @ X8_v21+E4]");
			bool flag4 = (nint)0 == 0;
			object obj15 = 0;
			enumType = typeFromHandle;
			if (!flag4)
			{
				goto IL_01ee;
			}
		}
		else
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			typeFromHandle = Type.GetTypeFromHandle((RuntimeTypeHandle)handle);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v137 @ X22_v7+98]");
			object obj14 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v173 @ X8_v21+E4]");
			bool flag5 = (nint)0 == 0;
			object obj16 = !flag5;
			object obj15 = 0;
			enumType = typeFromHandle;
			if (obj16 != null)
			{
				goto IL_01ee;
			}
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		Array values = Enum.GetValues(enumType);
		bool flag6 = values == null;
		object obj17 = !flag6;
		string text4 = null;
		if (obj17 != null)
		{
			goto IL_021d;
		}
		goto IL_0811;
		IL_0c42:
		object obj18;
		bool flag7 = obj18 == null;
		object obj19 = !flag7;
		string text5;
		if (obj19 == null)
		{
			return text5;
		}
		OutOfMemoryException ex = new OutOfMemoryException();
		goto IL_0a25;
		IL_08f3:
		object obj20 = typeof(UnityEngine.TextCore.HorizontalAlignment) + 2344;
		text4 = (string)obj20;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1958");
		object obj22 = default(object);
		object obj21 = obj22;
		if (obj22 == null)
		{
			goto IL_0c42;
		}
		object obj23 = obj22;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v638 @ X8_v12+12E]");
		object obj24 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v638 @ X8_v12+12E]");
		if ((nint)0 == 0)
		{
			goto IL_09d2;
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v638 @ X8_v12+B0]");
		object obj25 = (nint)0 + (nint)8;
		while (true)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v779 @ X10_v8-8]");
			if (0 == (nint)obj20)
			{
				break;
			}
			obj25 += 16;
			obj24--;
			if ((nint)obj24 != 1)
			{
				continue;
			}
			goto IL_09d2;
		}
		object obj26 = obj23 + obj25;
		object obj27 = obj26 + 312;
		goto IL_0c8e;
		IL_09d2:
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @B0D070");
		object obj28 = 0;
		object obj29 = default(object);
		obj27 = obj29;
		goto IL_0c8e;
		IL_0c8e:
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v658 @ X8_v13+8]");
		text4 = (string)0;
		Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v658 @ X8_v13] (should have been resolved before IL gen)");
		goto IL_0c42;
		IL_086d:
		NullReferenceException ex2 = new NullReferenceException();
		object obj30 = default(object);
		obj21 = (object)(&obj30);
		IEnumerator enumerator = default(IEnumerator);
		object obj31 = (object)(&enumerator);
		obj18 = 0;
		text = text5;
		goto IL_08a2;
		IL_0836:
		InvalidCastException ex3 = new InvalidCastException();
		obj21 = (object)(&obj30);
		obj31 = (object)(&enumerator);
		obj18 = 0;
		ex2 = (NullReferenceException)(object)ex3;
		text = text5;
		goto IL_08a2;
		IL_0828:
		ex2 = new NullReferenceException();
		goto IL_08a2;
		IL_08a2:
		bool flag8 = (nint)text4 != 1;
		ex = (OutOfMemoryException)(object)ex2;
		if (!flag8)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @6CB0B80");
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @6CB0BB0");
			object obj32 = default(object);
			obj18 = obj32;
			text5 = text;
			goto IL_08f3;
		}
		goto IL_0a25;
		IL_0734:
		ex2 = new NullReferenceException();
		obj21 = (object)(&obj30);
		obj31 = (object)(&enumerator);
		obj18 = 0;
		goto IL_08a2;
		IL_01ee:
		values = Enum.GetValues(typeFromHandle);
		bool flag9 = values == null;
		text4 = null;
		if (!flag9)
		{
			goto IL_021d;
		}
		goto IL_0811;
		IL_0811:
		NullReferenceException ex4 = new NullReferenceException();
		obj28 = 0;
		goto IL_0828;
		IL_021d:
		IEnumerator enumerator2 = values.GetEnumerator();
		bool flag10 = enumerator2 == null;
		obj28 = 0;
		text4 = null;
		if (flag10)
		{
			goto IL_0734;
		}
		object obj33 = typeof(UnityEngine.TextCore.HorizontalAlignment) + 2528;
		object obj34 = typeof(DataRelation) + 816;
		object obj35 = typeof(DataRelation) + 824;
		object obj36 = 0;
		IEnumerator enumerator3 = enumerator2;
		object obj37 = 0;
		text5 = text;
		object obj44 = default(object);
		object obj50 = default(object);
		object obj52 = default(object);
		Enum enumeration = default(Enum);
		Enum enumeration2 = default(Enum);
		while (true)
		{
			nint num = (nint)enumerator3;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v356 @ X8_v28 (Il2CppClass<System.Collections.IEnumerator>)+12E]");
			object obj38 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v356 @ X8_v28 (Il2CppClass<System.Collections.IEnumerator>)+12E]");
			if ((nint)0 == 0)
			{
				goto IL_0317;
			}
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v356 @ X8_v28 (Il2CppClass<System.Collections.IEnumerator>)+B0]");
			object obj39 = (nint)0 + (nint)8;
			object obj40;
			while (true)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v465 @ X10_v24-8]");
				if (0 == (nint)obj33)
				{
					break;
				}
				obj40 = obj39 + 16;
				obj38--;
				bool flag11 = (nint)obj38 != 1;
				obj39 = obj40;
				if (flag11)
				{
					continue;
				}
				goto IL_0317;
			}
			object obj41 = num + obj39;
			object obj42 = obj41 + 312;
			obj40 = obj39;
			obj28 = obj37;
			goto IL_0abe;
			IL_0abe:
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v546 @ X0_v57+8]");
			text4 = (string)0;
			Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v546 @ X0_v57] (should have been resolved before IL gen)");
			object obj43 = obj44 & 1;
			bool flag12 = obj43 == null;
			obj21 = (object)(&obj30);
			obj31 = (object)(&enumerator);
			obj18 = 0;
			if (flag12)
			{
				break;
			}
			bool flag13 = enumerator == null;
			obj21 = (object)(&obj30);
			obj31 = (object)(&enumerator);
			obj18 = 0;
			text = text5;
			if (flag13)
			{
				goto IL_0828;
			}
			nint num2 = (nint)enumerator;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v603 @ X8_v31 (Il2CppClass<System.Collections.IEnumerator>)+12E]");
			object obj45 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v603 @ X8_v31 (Il2CppClass<System.Collections.IEnumerator>)+12E]");
			if ((nint)0 == 0)
			{
				goto IL_0439;
			}
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v603 @ X8_v31 (Il2CppClass<System.Collections.IEnumerator>)+B0]");
			object obj46 = (nint)0 + (nint)8;
			while (true)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v720 @ X10_v19-8]");
				if (0 == (nint)obj33)
				{
					break;
				}
				obj40 = obj46 + 16;
				obj45--;
				bool flag14 = (nint)obj45 != 1;
				obj46 = obj40;
				if (flag14)
				{
					continue;
				}
				goto IL_0439;
			}
			object obj47 = obj46 + 1;
			object obj48 = num2 + obj47;
			object obj49 = obj48 + 312;
			obj40 = obj46;
			goto IL_0b40;
			IL_0b40:
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v765 @ X0_v60+8]");
			text4 = (string)0;
			Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v765 @ X0_v60] (should have been resolved before IL gen)");
			if (obj50 != null)
			{
				text4 = (string)obj34;
				object obj51 = obj50;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v792 @ X8_v34+40]");
				nint num3 = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v523 @ X1_v5 (System.String)+40]");
				if (num3 == 0)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1960");
					bool flag15 = (nint)obj36 >= activeUnits;
					obj21 = (object)(&obj30);
					obj31 = (object)(&enumerator);
					obj18 = 0;
					if (flag15)
					{
						break;
					}
					bool flag16 = (nint)obj52 > (nint)minUnit;
					obj21 = (object)(&obj30);
					obj31 = (object)(&enumerator);
					obj18 = 0;
					if (flag16)
					{
						break;
					}
					object obj53 = obj35;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v803 @ X0_v66+E4]");
					bool flag17 = (nint)0 == 0;
					object obj54 = !flag17;
					if (obj54 == null)
					{
						Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
					}
					int amountForUnit = DateTimeUtil.GetAmountForUnit(timeLeft, (DateTimeUnit)obj52);
					if (amountForUnit >= 1)
					{
						string text8;
						if (text5 != (string)obj5)
						{
							Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC195C");
							string friendlyName = EnumExtensions.GetFriendlyName(enumeration);
							object obj55 = typeof(Newtonsoft.Json.Linq.JsonPath.JPath) + 2656;
							object obj56 = obj55;
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v851 @ X0_v89+E4]");
							bool flag18 = (nint)0 == 0;
							object obj57 = !flag18;
							if (obj57 == null)
							{
								Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
							}
							string text6 = LocalizationUtil.Localize(friendlyName, amountForUnit);
							string text7 = text3 + text6;
							DateTimeUnit dateTimeUnit = (DateTimeUnit)obj52;
							text8 = text7;
						}
						else
						{
							Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC195C");
							string friendlyName2 = EnumExtensions.GetFriendlyName(enumeration2);
							object obj58 = typeof(Newtonsoft.Json.Linq.JsonPath.JPath) + 2656;
							object obj59 = obj58;
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v858 @ X0_v81+E4]");
							bool flag19 = (nint)0 == 0;
							object obj60 = !flag19;
							if (obj60 == null)
							{
								Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
							}
							string text9 = LocalizationUtil.Localize(friendlyName2, amountForUnit);
							DateTimeUnit dateTimeUnit = (DateTimeUnit)obj52;
							text8 = text9;
						}
						string text10 = text5 + text8;
						text5 = text10;
					}
					text4 = (string)obj5;
					bool flag20 = text5 != (string)obj5;
					obj36 += flag20;
					bool flag21 = enumerator == null;
					object obj61 = !flag21;
					obj28 = 0;
					text = text5;
					enumerator3 = enumerator;
					obj37 = 0;
					if (obj61 != null)
					{
						continue;
					}
					goto IL_0734;
				}
				goto IL_0836;
			}
			goto IL_086d;
			IL_0439:
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @B0D070");
			obj28 = 1;
			goto IL_0b40;
			IL_0317:
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @B0D070");
			obj28 = 0;
			goto IL_0abe;
		}
		goto IL_08f3;
		IL_0a25:
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @1C99B68");
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @6CB03A0");
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2B060");
		string result = default(string);
		return result;
	}
}

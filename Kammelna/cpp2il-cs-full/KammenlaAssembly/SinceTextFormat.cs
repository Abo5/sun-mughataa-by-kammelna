using System;
using System.Collections;
using System.Data;
using Cpp2ILInjected;
using Newtonsoft.Json.Linq.JsonPath;
using UnityEngine.Purchasing.Telemetry;
using UnityEngine.TextCore;
using Util;

[Serializable]
public class SinceTextFormat : DateTimeFormat
{
	private DateTimeUnit minUnit = DateTimeUnit.Minutes;

	public override bool IsCountDown => false;

	public SinceTextFormat()
	{
	}

	public SinceTextFormat(DateTimeUnit minUnit)
	{
		this.minUnit = minUnit;
	}

	protected unsafe override string FormatDate(DateTime dateTime)
	{
		//IL_000f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0014: Expected O, but got Unknown
		//IL_0c2f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0c34: Expected O, but got Unknown
		//IL_0c5e: Expected O, but got I4
		//IL_0037: Expected O, but got I4
		//IL_0080: Expected O, but got I4
		//IL_00b9: Expected O, but got I4
		//IL_00c9: Expected O, but got I
		//IL_0957: Expected O, but got I4
		//IL_0970: Expected O, but got I4
		//IL_014b: Expected O, but got I4
		//IL_09fc: Expected O, but got I4
		//IL_09c4: Expected O, but got I4
		//IL_0a16: Unknown result type (might be due to invalid IL or missing references)
		//IL_0a1b: Expected O, but got Unknown
		//IL_0a24: Unknown result type (might be due to invalid IL or missing references)
		//IL_0a29: Expected I4, but got Unknown
		//IL_01aa: Unknown result type (might be due to invalid IL or missing references)
		//IL_01af: Expected O, but got Unknown
		//IL_01be: Unknown result type (might be due to invalid IL or missing references)
		//IL_01c3: Expected O, but got Unknown
		//IL_01d2: Unknown result type (might be due to invalid IL or missing references)
		//IL_01d7: Expected O, but got Unknown
		//IL_01e6: Unknown result type (might be due to invalid IL or missing references)
		//IL_01eb: Expected O, but got Unknown
		//IL_0201: Expected O, but got I4
		//IL_0d9f: Expected O, but got I4
		//IL_021f: Expected I, but got O
		//IL_02ce: Expected O, but got I4
		//IL_0a83: Expected O, but got I
		//IL_0a93: Expected O, but got I
		//IL_0ca8: Expected I4, but got O
		//IL_0ccb: Unknown result type (might be due to invalid IL or missing references)
		//IL_0cd0: Expected O, but got Unknown
		//IL_026a: Expected O, but got I
		//IL_0a65: Expected O, but got I4
		//IL_06fe: Expected I4, but got O
		//IL_073f: Expected O, but got Ref
		//IL_0775: Expected O, but got I4
		//IL_0783: Expected O, but got I4
		//IL_0793: Expected O, but got Ref
		//IL_07a9: Expected O, but got I4
		//IL_07b7: Expected O, but got I4
		//IL_0c7c: Expected O, but got I
		//IL_0b50: Expected I4, but got O
		//IL_0b74: Expected O, but got I4
		//IL_0bdd: Expected O, but got I4
		//IL_0be6: Expected O, but got I4
		//IL_02db: Expected I4, but got O
		//IL_02e3: Unknown result type (might be due to invalid IL or missing references)
		//IL_02e8: Expected O, but got Unknown
		//IL_02f1: Unknown result type (might be due to invalid IL or missing references)
		//IL_02f6: Expected O, but got Unknown
		//IL_07cd: Expected I, but got O
		//IL_07dd: Expected O, but got I
		//IL_0278: Unknown result type (might be due to invalid IL or missing references)
		//IL_027d: Expected O, but got Unknown
		//IL_08cc: Expected O, but got I4
		//IL_0c05: Expected O, but got I4
		//IL_0c16: Expected O, but got I4
		//IL_0328: Expected I, but got O
		//IL_0818: Expected O, but got I
		//IL_03d7: Expected O, but got I4
		//IL_0dbd: Expected O, but got I
		//IL_0d31: Expected I4, but got O
		//IL_0373: Expected O, but got I
		//IL_0d05: Expected O, but got I
		//IL_0826: Unknown result type (might be due to invalid IL or missing references)
		//IL_082b: Expected O, but got Unknown
		//IL_0834: Unknown result type (might be due to invalid IL or missing references)
		//IL_0839: Expected O, but got Unknown
		//IL_085b: Expected O, but got I
		//IL_041a: Expected I4, but got O
		//IL_03e5: Unknown result type (might be due to invalid IL or missing references)
		//IL_03ea: Expected I4, but got Unknown
		//IL_03f7: Expected O, but got I
		//IL_0400: Unknown result type (might be due to invalid IL or missing references)
		//IL_0405: Expected O, but got Unknown
		//IL_0381: Unknown result type (might be due to invalid IL or missing references)
		//IL_0386: Expected O, but got Unknown
		//IL_048f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0494: Expected O, but got Unknown
		//IL_04ae: Expected O, but got I4
		//IL_050e: Expected O, but got I4
		//IL_0538: Expected I4, but got O
		//IL_0554: Expected O, but got I4
		//IL_055c: Expected I4, but got O
		//IL_0595: Unknown result type (might be due to invalid IL or missing references)
		//IL_059a: Expected O, but got Unknown
		//IL_05d4: Expected O, but got I4
		//IL_05fe: Expected I8, but got I4
		//IL_060a: Expected I4, but got O
		//IL_0633: Expected O, but got I4
		//IL_065b: Expected O, but got Ref
		//IL_0689: Expected O, but got I4
		//IL_0691: Expected O, but got I4
		//IL_069a: Expected O, but got I4
		//IL_06c5: Expected O, but got Ref
		//IL_06d3: Expected O, but got I4
		//IL_06db: Expected O, but got I4
		//IL_06e4: Expected O, but got I4
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
		object obj5 = 147423232 + 2616;
		DateTime now = DateTime.Now;
		TimeSpan timeSpan = now - dateTime;
		object obj6 = obj2;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v86 @ X0_v7+E4]");
		bool flag2 = (nint)0 == 0;
		object obj7 = !flag2;
		if (obj7 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		}
		TimeSpan timeSpan3 = default(TimeSpan);
		TimeSpan timeSpan2 = timeSpan3.Duration();
		object obj8 = 153100288 + 1024;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v104 @ X23_v2+E0]");
		object obj9 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v105 @ X0_v11+E4]");
		Type typeFromHandle;
		nint num;
		int num3;
		Type type;
		IntPtr intPtr;
		int num2;
		if ((nint)0 != 0)
		{
			typeFromHandle = Type.GetTypeFromHandle((RuntimeTypeHandle)obj5);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v104 @ X23_v2+98]");
			num = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v250 @ X8_v12 (Il2CppClass<System.NullReferenceException>)+E4]");
			num2 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v250 @ X8_v12 (Il2CppClass<System.NullReferenceException>)+E4]");
			bool flag3 = (nint)0 == 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v250 @ X8_v12 (Il2CppClass<System.NullReferenceException>)+E4]");
			num3 = 0;
			object obj10 = 0;
			type = typeFromHandle;
			intPtr = num;
			if (!flag3)
			{
				goto IL_0169;
			}
		}
		else
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			typeFromHandle = Type.GetTypeFromHandle((RuntimeTypeHandle)obj5);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v104 @ X23_v2+98]");
			num = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v250 @ X8_v12 (Il2CppClass<System.NullReferenceException>)+E4]");
			num2 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v250 @ X8_v12 (Il2CppClass<System.NullReferenceException>)+E4]");
			bool flag4 = (nint)0 == 0;
			object obj11 = !flag4;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v250 @ X8_v12 (Il2CppClass<System.NullReferenceException>)+E4]");
			num3 = 0;
			object obj10 = 0;
			type = typeFromHandle;
			intPtr = num;
			if (obj11 != null)
			{
				goto IL_0169;
			}
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		Array values = Enum.GetValues(type);
		bool flag5 = values == null;
		object obj12 = !flag5;
		num2 = num3;
		Type type2 = type;
		num = intPtr;
		if (obj12 != null)
		{
			goto IL_019b;
		}
		goto IL_09ea;
		IL_056a:
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC195C");
		Enum enumeration = default(Enum);
		string friendlyName = EnumExtensions.GetFriendlyName(enumeration);
		object obj13 = typeof(Newtonsoft.Json.Linq.JsonPath.JPath) + 2656;
		object obj14 = obj13;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v818 @ X0_v68+E4]");
		DateTimeUnit dateTimeUnit = DateTimeUnit.Years;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v818 @ X0_v68+E4]");
		bool flag6 = (nint)0 == 0;
		object obj15 = !flag6;
		if (obj15 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		}
		int amountForUnit;
		string text = LocalizationUtil.Localize(friendlyName, amountForUnit);
		object obj16 = default(object);
		DateTimeUnit dateTimeUnit2 = (DateTimeUnit)obj16;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1958");
		NullReferenceException ex = default(NullReferenceException);
		bool flag7 = ex == null;
		object obj17 = !flag7;
		object obj19 = default(object);
		object obj18 = obj19;
		object obj21 = default(object);
		object obj20 = obj21;
		object obj23 = default(object);
		object obj22 = obj23;
		object obj24 = default(object);
		DateTimeUnit dateTimeUnit3 = (DateTimeUnit)(int)(&obj24);
		Type type3 = default(Type);
		object obj25 = (object)(&type3);
		SinceTextFormat sinceTextFormat = null;
		object obj26 = obj16;
		object obj28 = default(object);
		object obj27 = obj28;
		object obj30 = default(object);
		object obj29 = obj30;
		object obj32 = default(object);
		object obj31 = obj32;
		object obj33 = 0;
		Type type4 = (Type)amountForUnit;
		object obj34 = 6;
		SinceTextFormat sinceTextFormat2 = null;
		TimeSpan timeSpan4 = (TimeSpan)text;
		if (obj17 != null)
		{
			goto IL_07c5;
		}
		DateTimeUnit dateTimeUnit4 = (DateTimeUnit)(int)(&obj24);
		object obj35 = (object)(&type3);
		sinceTextFormat = null;
		object obj36 = 0;
		type2 = (Type)amountForUnit;
		obj2 = 6;
		SinceTextFormat sinceTextFormat3 = null;
		TimeSpan result = (TimeSpan)text;
		goto IL_0d85;
		IL_019b:
		obj32 = typeof(UnityEngine.TextCore.HorizontalAlignment) + 2528;
		obj30 = typeof(DataRelation) + 816;
		obj28 = typeof(DataRelation) + 824;
		obj16 = typeof(UnityEngine.TextCore.HorizontalAlignment) + 2344;
		IEnumerator enumerator = values.GetEnumerator();
		obj36 = 0;
		dateTimeUnit2 = DateTimeUnit.Years;
		dateTimeUnit = (DateTimeUnit)(int)(&obj24);
		object obj39 = default(object);
		object obj41 = default(object);
		object obj44 = default(object);
		object obj45 = default(object);
		object obj48 = default(object);
		while (true)
		{
			if ((object)type3 != null)
			{
				nint num4 = (nint)type3;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v355 @ X8_v26 (Il2CppClass<System.Type>)+12E]");
				num2 = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v355 @ X8_v26 (Il2CppClass<System.Type>)+12E]");
				if ((nint)0 == 0)
				{
					goto IL_02bb;
				}
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v355 @ X8_v26 (Il2CppClass<System.Type>)+B0]");
				object obj37 = (nint)0 + (nint)8;
				while (true)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v543 @ X10_v24-8]");
					obj19 = 0;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v543 @ X10_v24-8]");
					if (0 == (nint)obj32)
					{
						break;
					}
					obj23 = obj37 + 16;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v355 @ X8_v26 (Il2CppClass<System.Type>)+12E]");
					num2 = (int)(-1);
					bool flag8 = num2 != 1;
					obj37 = obj23;
					if (flag8)
					{
						continue;
					}
					goto IL_02bb;
				}
				num2 = (int)obj37;
				object obj38 = num4 + obj37;
				obj39 = obj38 + 312;
				obj23 = obj37;
				goto IL_0ca0;
			}
			throw new NullReferenceException();
			IL_02bb:
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @B0D070");
			obj36 = 0;
			goto IL_0ca0;
			IL_0ca0:
			dateTimeUnit = (DateTimeUnit)obj39;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v609 @ X0_v48+8]");
			dateTimeUnit2 = DateTimeUnit.Years;
			Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v609 @ X0_v48] (should have been resolved before IL gen)");
			object obj40 = obj41 & 1;
			bool flag9 = obj40 == null;
			type4 = type3;
			if (flag9)
			{
				break;
			}
			if ((object)type3 != null)
			{
				nint num5 = (nint)type3;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v691 @ X8_v30 (Il2CppClass<System.Type>)+12E]");
				num2 = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v691 @ X8_v30 (Il2CppClass<System.Type>)+12E]");
				if ((nint)0 == 0)
				{
					goto IL_03c4;
				}
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v691 @ X8_v30 (Il2CppClass<System.Type>)+B0]");
				object obj42 = (nint)0 + (nint)8;
				while (true)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v753 @ X10_v19-8]");
					obj19 = 0;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v753 @ X10_v19-8]");
					if (0 == (nint)obj32)
					{
						break;
					}
					obj23 = obj42 + 16;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v691 @ X8_v30 (Il2CppClass<System.Type>)+12E]");
					num2 = (int)(-1);
					bool flag10 = num2 != 1;
					obj42 = obj23;
					if (flag10)
					{
						continue;
					}
					goto IL_03c4;
				}
				num2 = obj42 + 1;
				object obj43 = num5 + num2;
				obj44 = obj43 + 312;
				obj23 = obj42;
				goto IL_0d29;
			}
			throw new NullReferenceException();
			IL_03c4:
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @B0D070");
			obj36 = 1;
			goto IL_0d29;
			IL_0d29:
			dateTimeUnit = (DateTimeUnit)obj44;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v784 @ X0_v55+8]");
			dateTimeUnit2 = DateTimeUnit.Years;
			Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v784 @ X0_v55] (should have been resolved before IL gen)");
			if (obj45 != null)
			{
				dateTimeUnit2 = (DateTimeUnit)obj30;
				object obj46 = obj45;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v798 @ X8_v33+40]");
				dateTimeUnit = DateTimeUnit.Years;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v520 @ X1_v3 (DateTimeUnit)+40]");
				num2 = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v798 @ X8_v33+40]");
				nint num6 = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v520 @ X1_v3 (DateTimeUnit)+40]");
				if (num6 == 0)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1960");
					dateTimeUnit = minUnit;
					object obj47 = obj48 - minUnit;
					bool flag11 = obj47 == null;
					obj21 = !flag11;
					bool flag12 = (nint)obj48 > (nint)minUnit;
					type4 = type3;
					if (flag12)
					{
						break;
					}
					object obj49 = obj28;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v803 @ X0_v61+E4]");
					dateTimeUnit = DateTimeUnit.Years;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v803 @ X0_v61+E4]");
					bool flag13 = (nint)0 == 0;
					object obj50 = !flag13;
					if (obj50 == null)
					{
						Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
					}
					amountForUnit = DateTimeUtil.GetAmountForUnit(timeSpan2, (DateTimeUnit)obj48);
					bool flag14 = amountForUnit < 1;
					obj36 = 0;
					dateTimeUnit2 = (DateTimeUnit)obj48;
					if (flag14)
					{
						continue;
					}
					goto IL_056a;
				}
				type2 = type3;
				throw new InvalidCastException();
			}
			throw new NullReferenceException();
		}
		dateTimeUnit2 = (DateTimeUnit)obj16;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1958");
		bool flag15 = ex == null;
		obj18 = obj19;
		obj20 = obj21;
		obj22 = obj23;
		dateTimeUnit3 = (DateTimeUnit)(int)(&obj24);
		obj25 = (object)(&type3);
		sinceTextFormat = null;
		obj26 = obj16;
		obj27 = obj28;
		obj29 = obj30;
		obj31 = obj32;
		obj33 = obj36;
		obj34 = 5;
		sinceTextFormat2 = null;
		timeSpan4 = (TimeSpan)0;
		dateTimeUnit4 = (DateTimeUnit)(int)(&obj24);
		obj35 = (object)(&type3);
		sinceTextFormat = null;
		type2 = type4;
		obj2 = 5;
		sinceTextFormat3 = null;
		result = (TimeSpan)0;
		if (!flag15)
		{
			goto IL_07c5;
		}
		goto IL_0d85;
		IL_07c5:
		num = (nint)ex;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v250 @ X8_v12 (Il2CppClass<System.NullReferenceException>)+12E]");
		object obj51 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v250 @ X8_v12 (Il2CppClass<System.NullReferenceException>)+12E]");
		if ((nint)0 == 0)
		{
			goto IL_0871;
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v250 @ X8_v12 (Il2CppClass<System.NullReferenceException>)+B0]");
		obj23 = (nint)0 + (nint)8;
		while (true)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v284 @ X10_v15-8]");
			obj19 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v284 @ X10_v15-8]");
			bool flag16 = 0 == (nint)obj26;
			obj21 = obj20;
			dateTimeUnit4 = dateTimeUnit3;
			obj35 = obj25;
			obj16 = obj26;
			obj28 = obj27;
			obj30 = obj29;
			obj32 = obj31;
			obj36 = obj33;
			type2 = type4;
			obj2 = obj34;
			sinceTextFormat3 = sinceTextFormat2;
			result = timeSpan4;
			if (flag16)
			{
				break;
			}
			obj22 = obj23 + 16;
			obj51--;
			bool flag17 = (nint)obj51 != 1;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v284 @ X10_v15-8]");
			obj18 = 0;
			obj23 = obj22;
			if (flag17)
			{
				continue;
			}
			goto IL_0871;
		}
		goto IL_0a0e;
		IL_0d85:
		object obj56 = default(object);
		string result2 = default(string);
		while (true)
		{
			bool flag18 = sinceTextFormat3 == null;
			object obj52 = !flag18;
			if (obj52 == null)
			{
				if ((nint)obj2 != 5)
				{
					bool flag19 = obj2 == null;
					object obj53 = !flag19;
					if (obj53 != null)
					{
						goto IL_0e60;
					}
				}
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v104 @ X23_v2+90]");
				object obj54 = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v602 @ X8_v10+B8]");
				object obj55 = 0;
				result = (TimeSpan)obj55;
				goto IL_0e60;
			}
			OutOfMemoryException ex2 = new OutOfMemoryException();
			if (dateTimeUnit2 == DateTimeUnit.Months)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @6CB0B80");
				sinceTextFormat2 = (SinceTextFormat)obj56;
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @6CB0BB0");
				dateTimeUnit2 = (DateTimeUnit)obj16;
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1958");
				bool flag20 = ex == null;
				object obj57 = !flag20;
				obj18 = obj19;
				obj20 = obj21;
				obj22 = obj23;
				dateTimeUnit3 = dateTimeUnit4;
				obj25 = obj35;
				sinceTextFormat = (SinceTextFormat)obj56;
				obj26 = obj16;
				obj27 = obj28;
				obj29 = obj30;
				obj31 = obj32;
				obj33 = obj36;
				type4 = type2;
				obj34 = 0;
				timeSpan4 = (TimeSpan)0;
				if (obj57 != null)
				{
					break;
				}
				sinceTextFormat = (SinceTextFormat)obj56;
				obj2 = 0;
				sinceTextFormat3 = (SinceTextFormat)obj56;
				result = (TimeSpan)0;
				continue;
			}
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @1C99B68");
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @6CB03A0");
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2B060");
			return result2;
			IL_0e60:
			return (string)result;
		}
		goto IL_07c5;
		IL_0e41:
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v443 @ X8_v6 (DateTimeUnit)+8]");
		dateTimeUnit2 = DateTimeUnit.Years;
		Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: v443.value__ (System.Int32) (should have been resolved before IL gen)");
		goto IL_0d85;
		IL_0a0e:
		object obj58 = num + obj23;
		dateTimeUnit = (DateTimeUnit)(obj58 + 312);
		goto IL_0e41;
		IL_0871:
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @B0D070");
		obj19 = obj18;
		obj21 = obj20;
		obj23 = obj22;
		dateTimeUnit4 = dateTimeUnit3;
		obj35 = obj25;
		obj16 = obj26;
		obj28 = obj27;
		obj30 = obj29;
		obj32 = obj31;
		obj36 = 0;
		type2 = (Type)(object)ex;
		DateTimeUnit dateTimeUnit5 = default(DateTimeUnit);
		dateTimeUnit = dateTimeUnit5;
		obj2 = obj34;
		sinceTextFormat3 = sinceTextFormat2;
		result = timeSpan4;
		goto IL_0e41;
		IL_0169:
		values = Enum.GetValues(typeFromHandle);
		bool flag21 = values == null;
		type2 = (Type)obj5;
		if (!flag21)
		{
			goto IL_019b;
		}
		goto IL_09ea;
		IL_09ea:
		ex = new NullReferenceException();
		obj36 = 0;
		sinceTextFormat3 = this;
		result = timeSpan2;
		goto IL_0a0e;
	}
}

using System;
using System.ComponentModel;
using System.Data;
using System.Runtime.Remoting.Messaging;
using Cpp2ILInjected;
using Newtonsoft.Json.Linq.JsonPath;

namespace UI.Conditions;

public static class ComparisonOperatorExtensions
{
	public unsafe static bool Apply<T>(ComparisonOperator op, T userValue, T filterValue, string caller = null) where T : IComparable
	{
		//IL_04fb: Expected O, but got Ref
		//IL_065f: Expected O, but got I4
		//IL_066f: Expected O, but got I
		//IL_0691: Expected O, but got I4
		//IL_0420: Expected O, but got I4
		//IL_0430: Expected O, but got I
		//IL_0452: Expected O, but got I4
		//IL_0393: Expected O, but got I4
		//IL_03a3: Expected O, but got I
		//IL_03c5: Expected O, but got I4
		//IL_054a: Unknown result type (might be due to invalid IL or missing references)
		//IL_054f: Expected O, but got Unknown
		//IL_0563: Unknown result type (might be due to invalid IL or missing references)
		//IL_0568: Expected O, but got Unknown
		//IL_048f: Expected O, but got I4
		//IL_04b4: Unknown result type (might be due to invalid IL or missing references)
		//IL_04b9: Expected I4, but got Unknown
		//IL_036f: Expected O, but got Ref
		//IL_0591: Unknown result type (might be due to invalid IL or missing references)
		//IL_0596: Expected O, but got Unknown
		//IL_05c0: Expected O, but got I4
		//IL_031c: Expected O, but got Ref
		//IL_0606: Expected O, but got I4
		//IL_0616: Expected O, but got I
		//IL_0638: Expected O, but got I4
		//IL_025a: Expected O, but got I4
		//IL_026a: Expected O, but got I
		//IL_028c: Expected O, but got I4
		//IL_00ea: Expected O, but got I4
		//IL_00fa: Expected O, but got I
		//IL_011c: Expected O, but got I4
		//IL_01ab: Expected O, but got I4
		//IL_01b3: Unknown result type (might be due to invalid IL or missing references)
		//IL_01b8: Expected I4, but got Unknown
		//IL_0089: Expected O, but got Ref
		bool flag2 = default(bool);
		if (op <= ComparisonOperator.GreaterThan)
		{
			if (op <= ComparisonOperator.NotEqual)
			{
				if (op == ComparisonOperator.Equal)
				{
					T val = default(T);
					object obj = (object)(&val);
					nint num = 0;
					goto IL_0646;
				}
				if (op == ComparisonOperator.NotEqual)
				{
					T val2 = default(T);
					object obj2 = (object)(&val2);
					nint num2 = 0;
					goto IL_05ed;
				}
			}
			else
			{
				switch (op)
				{
				case ComparisonOperator.GreaterThan:
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC195C");
					object obj7 = 153100288 + 1024;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v320 @ X8_v42+28]");
					object obj8 = 0;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v321 @ X0_v57+E4]");
					bool flag3 = (nint)0 == 0;
					object obj9 = !flag3;
					if (obj9 == null)
					{
						Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
					}
					object obj10 = default(object);
					int num4 = flag2.CompareTo(obj10);
					bool flag4 = num4 < 0;
					bool flag5 = num4 == 0;
					int num5 = num4 ^ num4;
					int num6 = num4 & num5;
					bool flag6 = num6 < 0;
					bool flag7 = flag4 == flag6;
					object obj11 = !flag5;
					return (byte)((flag7 & obj11) ? 1 : 0) != 0;
				}
				case ComparisonOperator.LessThan:
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC195C");
					object obj3 = 153100288 + 1024;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v261 @ X8_v37+28]");
					object obj4 = 0;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v262 @ X0_v49+E4]");
					bool flag = (nint)0 == 0;
					object obj5 = !flag;
					if (obj5 == null)
					{
						Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
					}
					object obj6 = default(object);
					int num3 = flag2.CompareTo(obj6);
					return (byte)(num3 >> 31) != 0;
				}
				}
			}
		}
		else if (op <= ComparisonOperator.GreaterThanOrEqual)
		{
			switch (op)
			{
			case ComparisonOperator.GreaterThanOrEqual:
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC195C");
				object obj17 = 153100288 + 1024;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v334 @ X8_v30+28]");
				object obj18 = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v335 @ X0_v40+E4]");
				bool flag12 = (nint)0 == 0;
				object obj19 = !flag12;
				if (obj19 == null)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
				}
				object obj20 = default(object);
				int num11 = flag2.CompareTo(obj20);
				int num12 = ~num11;
				return (byte)(num12 >> 31) != 0;
			}
			case ComparisonOperator.LessThanOrEqual:
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC195C");
				object obj12 = 153100288 + 1024;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v273 @ X8_v25+28]");
				object obj13 = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v274 @ X0_v32+E4]");
				bool flag8 = (nint)0 == 0;
				object obj14 = !flag8;
				if (obj14 == null)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
				}
				object obj15 = default(object);
				int num7 = flag2.CompareTo(obj15);
				object obj16 = num7 - 1;
				bool flag9 = (nint)obj16 < 0;
				int num8 = num7 ^ 1;
				int num9 = num7 ^ obj16;
				int num10 = num8 & num9;
				bool flag10 = num10 < 0;
				bool flag11 = flag9 == flag10;
				return !flag11;
			}
			}
		}
		else
		{
			if (op == ComparisonOperator.In)
			{
				T val3 = default(T);
				object obj = (object)(&val3);
				nint num = 0;
				goto IL_0646;
			}
			if (op == ComparisonOperator.NotIn)
			{
				T val4 = default(T);
				object obj2 = (object)(&val4);
				nint num2 = 0;
				goto IL_05ed;
			}
		}
		object obj21 = typeof(System.Runtime.Remoting.Messaging.CallContextSecurityData) + 2136;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC195C");
		object format = "October" + 1144;
		object arg = default(object);
		string text = string.Format((string)format, arg, caller);
		object obj22 = typeof(Newtonsoft.Json.Linq.JsonPath.JPath) + 1144;
		object obj23 = obj22;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v355 @ X8_v19+E4]");
		bool flag13 = (nint)0 == 0;
		object obj24 = !flag13;
		object obj25 = text;
		if (obj24 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			obj25 = text;
		}
		KLogger.LogWarning(obj25);
		return true;
		IL_05ed:
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC195C");
		object obj26 = 153100288 + 1024;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v348 @ X8_v9+28]");
		object obj27 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v349 @ X0_v11+E4]");
		bool flag14 = (nint)0 == 0;
		object obj28 = !flag14;
		if (obj28 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		}
		object obj29 = default(object);
		int num13 = flag2.CompareTo(obj29);
		bool flag15 = num13 == 0;
		return !flag15;
		IL_0646:
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC195C");
		object obj30 = 153100288 + 1024;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v313 @ X8_v4+28]");
		object obj31 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v314 @ X0_v3+E4]");
		bool flag16 = (nint)0 == 0;
		object obj32 = !flag16;
		if (obj32 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		}
		object obj33 = default(object);
		int num14 = flag2.CompareTo(obj33);
		return num14 == 0;
	}

	public unsafe static bool Apply<T>(EqualityOperator op, T userValue, T filterValue, string caller = null) where T : IComparable
	{
		//IL_01b3: Expected O, but got I
		//IL_01bc: Unknown result type (might be due to invalid IL or missing references)
		//IL_01c1: Expected O, but got Unknown
		//IL_01db: Expected O, but got I4
		//IL_0206: Expected O, but got Ref
		//IL_0041: Expected O, but got I4
		//IL_00d0: Unknown result type (might be due to invalid IL or missing references)
		//IL_00d5: Expected O, but got Unknown
		//IL_00e9: Unknown result type (might be due to invalid IL or missing references)
		//IL_00ee: Expected O, but got Unknown
		//IL_0117: Unknown result type (might be due to invalid IL or missing references)
		//IL_011c: Expected O, but got Unknown
		//IL_0146: Expected O, but got I4
		//IL_0065: Expected O, but got I
		//IL_006e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0073: Expected O, but got Unknown
		//IL_008d: Expected O, but got I4
		//IL_00b8: Expected O, but got Ref
		if (op != EqualityOperator.NotEqual)
		{
			bool flag = op == EqualityOperator.Equal;
			object obj = !flag;
			if (obj == null)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC195C");
				object obj2 = (nint)0 + (nint)309;
				object obj3 = obj2 & 1;
				bool flag2 = obj3 == null;
				object obj4 = !flag2;
				if (obj4 == null)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @B0CCA4");
				}
				IntPtr intPtr = default(IntPtr);
				object obj5 = default(object);
				return ((Enum)(&intPtr)).Equals(obj5);
			}
			object obj6 = typeof(DataRelation) + 3488;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC195C");
			object format = "October" + 1144;
			object arg = default(object);
			string text = string.Format((string)format, arg, caller);
			object obj7 = typeof(Newtonsoft.Json.Linq.JsonPath.JPath) + 1144;
			object obj8 = obj7;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v164 @ X8_v15+E4]");
			bool flag3 = (nint)0 == 0;
			object obj9 = !flag3;
			object obj10 = text;
			if (obj9 == null)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
				obj10 = text;
			}
			KLogger.LogWarning(obj10);
			return true;
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC195C");
		object obj11 = (nint)0 + (nint)309;
		object obj12 = obj11 & 1;
		bool flag4 = obj12 == null;
		object obj13 = !flag4;
		if (obj13 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @B0CCA4");
		}
		IntPtr intPtr2 = default(IntPtr);
		object obj14 = default(object);
		bool flag5 = ((Enum)(&intPtr2)).Equals(obj14);
		return (byte)((flag5 ? 1u : 0u) ^ 1u) != 0;
	}

	public static bool Apply<T>(FlagsOperator op, T userValue, T filterValue, string caller = null) where T : Enum
	{
		//IL_01cc: Unknown result type (might be due to invalid IL or missing references)
		//IL_01d1: Expected O, but got Unknown
		//IL_01fb: Expected O, but got I4
		//IL_007c: Expected O, but got I4
		//IL_0110: Unknown result type (might be due to invalid IL or missing references)
		//IL_0115: Expected O, but got Unknown
		//IL_0129: Unknown result type (might be due to invalid IL or missing references)
		//IL_012e: Expected O, but got Unknown
		//IL_0157: Unknown result type (might be due to invalid IL or missing references)
		//IL_015c: Expected O, but got Unknown
		//IL_0186: Expected O, but got I4
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC195C");
		object obj = typeof(System.Runtime.Remoting.Messaging.CallContextSecurityData) + 3016;
		object obj2 = obj;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v62 @ X8_v5+E4]");
		bool flag = (nint)0 == 0;
		object obj3 = !flag;
		if (obj3 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		}
		object value = default(object);
		long num = Convert.ToInt64(value);
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC195C");
		object value2 = default(object);
		long num2 = Convert.ToInt64(value2);
		switch (op)
		{
		default:
		{
			bool flag3 = op == FlagsOperator.HaveAll;
			object obj4 = !flag3;
			if (obj4 == null)
			{
				long num5 = ~num;
				long num6 = num2 & num5;
				return num6 == 0;
			}
			object obj5 = typeof(System.ComponentModel.ExtendedPropertyDescriptor) + 944;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC195C");
			object format = "October" + 1144;
			object arg = default(object);
			string text = string.Format((string)format, arg, caller);
			object obj6 = typeof(Newtonsoft.Json.Linq.JsonPath.JPath) + 1144;
			object obj7 = obj6;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v188 @ X8_v13+E4]");
			bool flag4 = (nint)0 == 0;
			object obj8 = !flag4;
			object obj9 = text;
			if (obj8 == null)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
				obj9 = text;
			}
			KLogger.LogWarning(obj9);
			return true;
		}
		case FlagsOperator.HaveSome:
		{
			long num4 = num2 & num;
			bool flag2 = num4 == 0;
			return !flag2;
		}
		case FlagsOperator.HaveNone:
		{
			long num3 = num2 & num;
			return num3 == 0;
		}
		}
	}
}

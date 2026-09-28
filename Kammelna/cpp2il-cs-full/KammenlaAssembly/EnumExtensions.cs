using System;
using System.ComponentModel;
using System.Reflection;
using System.Runtime.Remoting.Messaging;
using Cpp2ILInjected;

public static class EnumExtensions
{
	public static string GetFriendlyName(Enum enumeration)
	{
		//IL_0291: Expected I, but got O
		//IL_02a1: Expected O, but got I
		//IL_02b1: Expected O, but got I
		//IL_00b7: Expected O, but got I4
		//IL_00d8: Expected O, but got I4
		//IL_00e8: Expected O, but got I
		//IL_010a: Expected O, but got I4
		//IL_012f: Expected I, but got O
		//IL_013f: Expected O, but got I
		//IL_01e3: Unknown result type (might be due to invalid IL or missing references)
		//IL_01e8: Expected O, but got Unknown
		//IL_01f8: Expected I, but got O
		//IL_0221: Expected O, but got I4
		//IL_0255: Expected O, but got I
		//IL_0289: Expected O, but got I
		if (enumeration != null)
		{
			Type type = enumeration.GetType();
			string name = enumeration.ToString();
			if ((object)type != null)
			{
				MemberInfo[] member = type.GetMember(name);
				if (member != null)
				{
					if (member.Length == 0)
					{
						goto IL_0289;
					}
					if (member.Length == 0)
					{
						goto IL_02c9;
					}
					object handle = 147423232 + 3472;
					MemberInfo memberInfo = member[0];
					object obj = 153100288 + 1024;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v209 @ X8_v13+E0]");
					object obj2 = 0;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v78 @ X8_v14+E4]");
					bool flag = (nint)0 == 0;
					object obj3 = !flag;
					if (obj3 == null)
					{
						Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
					}
					Type typeFromHandle = Type.GetTypeFromHandle((RuntimeTypeHandle)handle);
					if ((object)member[0] != null)
					{
						nint num = (nint)memberInfo;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v79 @ X8_v15 (Il2CppClass<System.Reflection.MemberInfo>)+220]");
						object obj4 = 0;
						object[] customAttributes = member[0].GetCustomAttributes(typeFromHandle, inherit: false);
						if (customAttributes != null)
						{
							if (customAttributes.Length == 0)
							{
								goto IL_02c9;
							}
							object obj5 = customAttributes[0];
							if (customAttributes[0] == null)
							{
								goto IL_0289;
							}
							object obj6 = typeof(System.ComponentModel.ExtendedPropertyDescriptor) + 1520;
							object obj7 = obj6;
							nint num2 = (nint)obj5;
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v151 @ X8_v19 (Il2CppClass<System.Object>)+130]");
							nint num3 = 0;
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v145 @ X1_v11+130]");
							bool flag2 = num3 < 0;
							object obj8 = !flag2;
							object obj9 = ~obj8;
							if (obj9 == null)
							{
								Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v151 @ X8_v19 (Il2CppClass<System.Object>)+C8]");
								nint num4 = 0;
								Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v145 @ X1_v11+130]");
								object obj10 = num4 + 0;
								Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v222 @ X8_v21-8]");
								if (0 == (nint)obj7)
								{
									Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v147 @ X0_v21 (System.Object)+10]");
									return (string)0;
								}
							}
							goto IL_02d7;
						}
					}
				}
			}
		}
		goto IL_02bb;
		IL_02c9:
		IndexOutOfRangeException ex = new IndexOutOfRangeException();
		goto IL_02d7;
		IL_0289:
		nint num5 = (nint)enumeration;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v189 @ X8_v9 (Il2CppClass<System.Enum>)+168]");
		object obj11 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v189 @ X8_v9 (Il2CppClass<System.Enum>)+170]");
		object obj12 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Indirect jump: v178 @ X2_v6 (should have been resolved before IL gen)");
		goto IL_02bb;
		IL_02d7:
		return (string)(object)new InvalidCastException();
		IL_02bb:
		NullReferenceException ex2 = new NullReferenceException();
		goto IL_02c9;
	}

	public static T ToEnum<T>(int index, T defaultValue) where T : Enum
	{
		//IL_0014: Expected O, but got I4
		//IL_0024: Expected O, but got I
		//IL_0046: Expected O, but got I4
		//IL_0102: Expected O, but got I
		//IL_0125: Expected O, but got I
		//IL_0147: Expected O, but got I4
		//IL_01aa: Expected O, but got I
		//IL_01cc: Expected O, but got I4
		//IL_01f0: Expected O, but got I
		//IL_0204: Expected O, but got I
		//IL_0226: Expected O, but got I4
		//IL_0260: Expected O, but got I
		//IL_0269: Unknown result type (might be due to invalid IL or missing references)
		//IL_026e: Expected O, but got Unknown
		//IL_0288: Expected O, but got I4
		//IL_02bb: Expected I, but got O
		object obj = 153100288 + 1024;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v51 @ X24_v1+E0]");
		object obj2 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v69 @ X0_v37+E4]");
		bool flag = (nint)0 == 0;
		object obj3 = !flag;
		nint num = 0;
		if (obj3 == null)
		{
			object obj4 = obj;
			nint num2 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			obj = obj4;
			num = num2;
		}
		Type typeFromHandle = Type.GetTypeFromHandle((RuntimeTypeHandle)num);
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC195C");
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v51 @ X24_v1+98]");
		object obj5 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v76 @ X0_v6+E4]");
		bool flag2 = (nint)0 == 0;
		object obj6 = !flag2;
		if (obj6 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		}
		object value = default(object);
		bool flag3 = Enum.IsDefined(typeFromHandle, value);
		bool flag4 = !flag3;
		T result = defaultValue;
		if (!flag4)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v51 @ X24_v1+E0]");
			object obj7 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v90 @ X0_v12+E4]");
			bool flag5 = (nint)0 == 0;
			object obj8 = !flag5;
			if (obj8 == null)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			}
			Type typeFromHandle2 = Type.GetTypeFromHandle((RuntimeTypeHandle)0);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v51 @ X24_v1+98]");
			object obj9 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v190 @ X0_v16+E4]");
			bool flag6 = (nint)0 == 0;
			object obj10 = !flag6;
			if (obj10 == null)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			}
			object obj11 = Enum.ToObject(typeFromHandle2, index);
			object obj12 = (nint)0 + (nint)309;
			object obj13 = obj12 & 1;
			bool flag7 = obj13 == null;
			object obj14 = !flag7;
			nint num3 = 0;
			if (obj14 == null)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @B0CCA4");
				IntPtr intPtr = default(IntPtr);
				num3 = intPtr;
			}
			if (obj11 != null)
			{
				nint num4 = (nint)obj11;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v210 @ X8_v12 (Il2CppClass<System.Object>)+40]");
				nint num5 = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v127 @ X1_v8 (Il2CppClass<T>)+40]");
				if (num5 == 0)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1960");
					object obj15 = default(object);
					result = (T)obj15;
					goto IL_034e;
				}
				InvalidCastException ex = new InvalidCastException();
				NullReferenceException ex2 = (NullReferenceException)(object)ex;
			}
			else
			{
				NullReferenceException ex2 = new NullReferenceException();
			}
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @6CB0BB0");
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @6CB03A0");
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2B060");
			T result2 = default(T);
			return result2;
		}
		goto IL_034e;
		IL_034e:
		return result;
	}

	public static bool IsDefined<T>(T enumeration) where T : Enum
	{
		//IL_0014: Expected O, but got I4
		//IL_0024: Expected O, but got I
		//IL_0066: Expected O, but got I
		//IL_0089: Expected O, but got I
		//IL_00ab: Expected O, but got I4
		object obj = 153100288 + 1024;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v45 @ X22_v4+E0]");
		object obj2 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v60 @ X0_v1+E4]");
		bool flag = (nint)0 == 0;
		nint num = 0;
		object obj3 = obj;
		nint num2 = 0;
		if (flag)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			obj = obj3;
			num = num2;
		}
		Type typeFromHandle = Type.GetTypeFromHandle((RuntimeTypeHandle)num);
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC195C");
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v45 @ X22_v4+98]");
		object obj4 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v71 @ X0_v11+E4]");
		bool flag2 = (nint)0 == 0;
		object obj5 = !flag2;
		if (obj5 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		}
		object value = default(object);
		return Enum.IsDefined(typeFromHandle, value);
	}

	public unsafe static T AddFlag<T>(T @this, T flag) where T : Enum
	{
		//IL_0008: Expected O, but got Ref
		//IL_0018: Expected O, but got I
		//IL_002d: Expected O, but got I
		//IL_004f: Expected O, but got I4
		//IL_03a2: Expected O, but got I
		//IL_03af: Unknown result type (might be due to invalid IL or missing references)
		//IL_03b4: Expected O, but got Unknown
		//IL_03c1: Expected O, but got Ref
		//IL_03ce: Expected O, but got Ref
		//IL_03f1: Unknown result type (might be due to invalid IL or missing references)
		//IL_03f6: Expected O, but got Unknown
		//IL_0420: Expected O, but got I4
		//IL_0455: Expected O, but got I
		//IL_006d: Expected O, but got I
		//IL_008f: Expected O, but got I4
		//IL_00e8: Expected O, but got I
		//IL_00f7: Expected O, but got I4
		//IL_0107: Expected O, but got I
		//IL_02df: Expected O, but got I
		//IL_00b7: Expected O, but got I
		//IL_02f8: Expected O, but got I
		//IL_031a: Expected O, but got I4
		//IL_0323: Expected O, but got I4
		//IL_013d: Expected O, but got I
		//IL_0151: Expected O, but got I
		//IL_0171: Expected O, but got I4
		//IL_01b5: Expected O, but got I
		//IL_01c6: Unknown result type (might be due to invalid IL or missing references)
		//IL_01cb: Expected O, but got Unknown
		//IL_01d4: Unknown result type (might be due to invalid IL or missing references)
		//IL_01d9: Expected O, but got Unknown
		//IL_01f3: Expected O, but got I4
		//IL_0370: Expected O, but got I4
		//IL_0220: Expected I, but got O
		//IL_0278: Expected O, but got I
		//IL_02a1: Expected O, but got I
		object obj2 = default(object);
		object obj = (object)(&obj2);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [8434110]");
		object obj3 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v22 @ X3+38]");
		object obj4 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v22 @ X3+38]");
		bool flag2 = (nint)0 == 0;
		object obj5 = !flag2;
		if (obj5 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v22 @ X3+38]");
			obj4 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v22 @ X3+38]");
			bool flag3 = (nint)0 == 0;
			object obj6 = !flag3;
			if (obj6 == null)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @B0CD24");
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v22 @ X3+38]");
				obj4 = 0;
			}
		}
		object obj7 = obj4;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v57 @ X25_v1+FC]");
		object obj8 = (nint)0 + (nint)15;
		object obj9 = obj8 & 0x1FFFFFFF0L;
		object obj11 = default(object);
		object obj10 = (ref *(?*)(&obj11)) - (ref *(?*)obj9);
		object obj12 = (ref *(?*)(&obj11)) - (ref *(?*)obj9);
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @6CB181C");
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC195C");
		object obj13 = typeof(System.Runtime.Remoting.Messaging.CallContextSecurityData) + 3016;
		object obj14 = obj13;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v80 @ X8_v10+E4]");
		bool flag4 = (nint)0 == 0;
		object obj15 = !flag4;
		if (obj15 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		}
		object value = default(object);
		long num = Convert.ToInt64(value);
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @6CB181C");
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v22 @ X3+38]");
		object obj16 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC195C");
		object value2 = default(object);
		long num2 = Convert.ToInt64(value2);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v22 @ X3+38]");
		object obj17 = 0;
		object obj18 = 153100288 + 1024;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v107 @ X25_v3+E0]");
		object obj19 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v108 @ X0_v13+E4]");
		Type type;
		Type type2;
		if ((nint)0 != 0)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v104 @ X8_v12+8]");
			type = Type.GetTypeFromHandle((RuntimeTypeHandle)0);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v107 @ X25_v3+98]");
			object obj20 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v135 @ X8_v14+E4]");
			bool flag5 = (nint)0 == 0;
			object obj21 = 0;
			type2 = type;
			if (!flag5)
			{
				goto IL_0187;
			}
		}
		else
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v104 @ X8_v12+8]");
			type = Type.GetTypeFromHandle((RuntimeTypeHandle)0);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v107 @ X25_v3+98]");
			object obj20 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v135 @ X8_v14+E4]");
			bool flag6 = (nint)0 == 0;
			object obj22 = !flag6;
			object obj21 = 0;
			type2 = type;
			if (obj22 != null)
			{
				goto IL_0187;
			}
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		type = type2;
		goto IL_0187;
		IL_0187:
		long value3 = num2 | num;
		object obj23 = Enum.ToObject(type, value3);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v22 @ X3+38]");
		object obj24 = 0;
		object obj25 = obj24;
		object obj26 = obj24 + 309;
		object obj27 = obj26 & 1;
		bool flag7 = obj27 == null;
		object obj28 = !flag7;
		if (obj28 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @B0CCA4");
			object obj29 = default(object);
			obj25 = obj29;
		}
		InvalidCastException ex;
		object obj31;
		if (obj23 != null)
		{
			nint num3 = (nint)obj23;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v159 @ X8_v22 (Il2CppClass<System.Object>)+40]");
			nint num4 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v221 @ X1_v13+40]");
			if (num4 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1960");
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @6CB181C");
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [8434110]");
				object obj30 = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v20 @ X29_v1-48]");
				bool flag8 = obj30 != null;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v57 @ X25_v1+FC]");
				obj31 = 0;
				object obj32 = default(object);
				obj25 = obj32;
				T val = default(T);
				ex = (InvalidCastException)val;
				if (!flag8)
				{
					return val;
				}
				goto IL_0375;
			}
		}
		else
		{
			NullReferenceException ex2 = new NullReferenceException();
		}
		ex = new InvalidCastException();
		obj31 = 0;
		goto IL_0375;
		IL_0375:
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @6CB0CA0");
		T result = default(T);
		return result;
	}

	public unsafe static T RemoveFlag<T>(T @this, T flag) where T : Enum
	{
		//IL_0008: Expected O, but got Ref
		//IL_0018: Expected O, but got I
		//IL_002d: Expected O, but got I
		//IL_004f: Expected O, but got I4
		//IL_03ab: Expected O, but got I
		//IL_03b8: Unknown result type (might be due to invalid IL or missing references)
		//IL_03bd: Expected O, but got Unknown
		//IL_03ca: Expected O, but got Ref
		//IL_03d7: Expected O, but got Ref
		//IL_03fa: Unknown result type (might be due to invalid IL or missing references)
		//IL_03ff: Expected O, but got Unknown
		//IL_0429: Expected O, but got I4
		//IL_045e: Expected O, but got I
		//IL_006d: Expected O, but got I
		//IL_008f: Expected O, but got I4
		//IL_00e8: Expected O, but got I
		//IL_00f7: Expected O, but got I4
		//IL_0107: Expected O, but got I
		//IL_02e8: Expected O, but got I
		//IL_00b7: Expected O, but got I
		//IL_0301: Expected O, but got I
		//IL_0323: Expected O, but got I4
		//IL_032c: Expected O, but got I4
		//IL_013d: Expected O, but got I
		//IL_0151: Expected O, but got I
		//IL_0171: Expected O, but got I4
		//IL_01be: Expected O, but got I
		//IL_01cf: Unknown result type (might be due to invalid IL or missing references)
		//IL_01d4: Expected O, but got Unknown
		//IL_01dd: Unknown result type (might be due to invalid IL or missing references)
		//IL_01e2: Expected O, but got Unknown
		//IL_01fc: Expected O, but got I4
		//IL_0379: Expected O, but got I4
		//IL_0229: Expected I, but got O
		//IL_0281: Expected O, but got I
		//IL_02aa: Expected O, but got I
		object obj2 = default(object);
		object obj = (object)(&obj2);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [8434110]");
		object obj3 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v22 @ X3+38]");
		object obj4 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v22 @ X3+38]");
		bool flag2 = (nint)0 == 0;
		object obj5 = !flag2;
		if (obj5 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v22 @ X3+38]");
			obj4 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v22 @ X3+38]");
			bool flag3 = (nint)0 == 0;
			object obj6 = !flag3;
			if (obj6 == null)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @B0CD24");
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v22 @ X3+38]");
				obj4 = 0;
			}
		}
		object obj7 = obj4;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v57 @ X25_v1+FC]");
		object obj8 = (nint)0 + (nint)15;
		object obj9 = obj8 & 0x1FFFFFFF0L;
		object obj11 = default(object);
		object obj10 = (ref *(?*)(&obj11)) - (ref *(?*)obj9);
		object obj12 = (ref *(?*)(&obj11)) - (ref *(?*)obj9);
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @6CB181C");
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC195C");
		object obj13 = typeof(System.Runtime.Remoting.Messaging.CallContextSecurityData) + 3016;
		object obj14 = obj13;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v80 @ X8_v10+E4]");
		bool flag4 = (nint)0 == 0;
		object obj15 = !flag4;
		if (obj15 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		}
		object value = default(object);
		long num = Convert.ToInt64(value);
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @6CB181C");
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v22 @ X3+38]");
		object obj16 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC195C");
		object value2 = default(object);
		long num2 = Convert.ToInt64(value2);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v22 @ X3+38]");
		object obj17 = 0;
		object obj18 = 153100288 + 1024;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v107 @ X25_v3+E0]");
		object obj19 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v108 @ X0_v13+E4]");
		Type type;
		Type type2;
		if ((nint)0 != 0)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v104 @ X8_v12+8]");
			type = Type.GetTypeFromHandle((RuntimeTypeHandle)0);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v107 @ X25_v3+98]");
			object obj20 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v135 @ X8_v14+E4]");
			bool flag5 = (nint)0 == 0;
			object obj21 = 0;
			type2 = type;
			if (!flag5)
			{
				goto IL_0187;
			}
		}
		else
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v104 @ X8_v12+8]");
			type = Type.GetTypeFromHandle((RuntimeTypeHandle)0);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v107 @ X25_v3+98]");
			object obj20 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v135 @ X8_v14+E4]");
			bool flag6 = (nint)0 == 0;
			object obj22 = !flag6;
			object obj21 = 0;
			type2 = type;
			if (obj22 != null)
			{
				goto IL_0187;
			}
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		type = type2;
		goto IL_0187;
		IL_0187:
		long num3 = ~num2;
		long value3 = num & num3;
		object obj23 = Enum.ToObject(type, value3);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v22 @ X3+38]");
		object obj24 = 0;
		object obj25 = obj24;
		object obj26 = obj24 + 309;
		object obj27 = obj26 & 1;
		bool flag7 = obj27 == null;
		object obj28 = !flag7;
		if (obj28 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @B0CCA4");
			object obj29 = default(object);
			obj25 = obj29;
		}
		InvalidCastException ex;
		object obj31;
		if (obj23 != null)
		{
			nint num4 = (nint)obj23;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v160 @ X8_v22 (Il2CppClass<System.Object>)+40]");
			nint num5 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v222 @ X1_v13+40]");
			if (num5 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1960");
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @6CB181C");
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [8434110]");
				object obj30 = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v20 @ X29_v1-48]");
				bool flag8 = obj30 != null;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v57 @ X25_v1+FC]");
				obj31 = 0;
				object obj32 = default(object);
				obj25 = obj32;
				T val = default(T);
				ex = (InvalidCastException)val;
				if (!flag8)
				{
					return val;
				}
				goto IL_037e;
			}
		}
		else
		{
			NullReferenceException ex2 = new NullReferenceException();
		}
		ex = new InvalidCastException();
		obj31 = 0;
		goto IL_037e;
		IL_037e:
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @6CB0CA0");
		T result = default(T);
		return result;
	}

	public unsafe static T ToggleFlag<T>(T @this, T flag) where T : Enum
	{
		//IL_0008: Expected O, but got Ref
		//IL_0018: Expected O, but got I
		//IL_002d: Expected O, but got I
		//IL_004f: Expected O, but got I4
		//IL_03a2: Expected O, but got I
		//IL_03af: Unknown result type (might be due to invalid IL or missing references)
		//IL_03b4: Expected O, but got Unknown
		//IL_03c1: Expected O, but got Ref
		//IL_03ce: Expected O, but got Ref
		//IL_03f1: Unknown result type (might be due to invalid IL or missing references)
		//IL_03f6: Expected O, but got Unknown
		//IL_0420: Expected O, but got I4
		//IL_0455: Expected O, but got I
		//IL_006d: Expected O, but got I
		//IL_008f: Expected O, but got I4
		//IL_00e8: Expected O, but got I
		//IL_00f7: Expected O, but got I4
		//IL_0107: Expected O, but got I
		//IL_02df: Expected O, but got I
		//IL_00b7: Expected O, but got I
		//IL_02f8: Expected O, but got I
		//IL_031a: Expected O, but got I4
		//IL_0323: Expected O, but got I4
		//IL_013d: Expected O, but got I
		//IL_0151: Expected O, but got I
		//IL_0171: Expected O, but got I4
		//IL_01b5: Expected O, but got I
		//IL_01c6: Unknown result type (might be due to invalid IL or missing references)
		//IL_01cb: Expected O, but got Unknown
		//IL_01d4: Unknown result type (might be due to invalid IL or missing references)
		//IL_01d9: Expected O, but got Unknown
		//IL_01f3: Expected O, but got I4
		//IL_0370: Expected O, but got I4
		//IL_0220: Expected I, but got O
		//IL_0278: Expected O, but got I
		//IL_02a1: Expected O, but got I
		object obj2 = default(object);
		object obj = (object)(&obj2);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [8434110]");
		object obj3 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v22 @ X3+38]");
		object obj4 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v22 @ X3+38]");
		bool flag2 = (nint)0 == 0;
		object obj5 = !flag2;
		if (obj5 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v22 @ X3+38]");
			obj4 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v22 @ X3+38]");
			bool flag3 = (nint)0 == 0;
			object obj6 = !flag3;
			if (obj6 == null)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @B0CD24");
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v22 @ X3+38]");
				obj4 = 0;
			}
		}
		object obj7 = obj4;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v57 @ X25_v1+FC]");
		object obj8 = (nint)0 + (nint)15;
		object obj9 = obj8 & 0x1FFFFFFF0L;
		object obj11 = default(object);
		object obj10 = (ref *(?*)(&obj11)) - (ref *(?*)obj9);
		object obj12 = (ref *(?*)(&obj11)) - (ref *(?*)obj9);
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @6CB181C");
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC195C");
		object obj13 = typeof(System.Runtime.Remoting.Messaging.CallContextSecurityData) + 3016;
		object obj14 = obj13;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v80 @ X8_v10+E4]");
		bool flag4 = (nint)0 == 0;
		object obj15 = !flag4;
		if (obj15 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		}
		object value = default(object);
		long num = Convert.ToInt64(value);
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @6CB181C");
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v22 @ X3+38]");
		object obj16 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC195C");
		object value2 = default(object);
		long num2 = Convert.ToInt64(value2);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v22 @ X3+38]");
		object obj17 = 0;
		object obj18 = 153100288 + 1024;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v107 @ X25_v3+E0]");
		object obj19 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v108 @ X0_v13+E4]");
		Type type;
		Type type2;
		if ((nint)0 != 0)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v104 @ X8_v12+8]");
			type = Type.GetTypeFromHandle((RuntimeTypeHandle)0);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v107 @ X25_v3+98]");
			object obj20 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v135 @ X8_v14+E4]");
			bool flag5 = (nint)0 == 0;
			object obj21 = 0;
			type2 = type;
			if (!flag5)
			{
				goto IL_0187;
			}
		}
		else
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v104 @ X8_v12+8]");
			type = Type.GetTypeFromHandle((RuntimeTypeHandle)0);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v107 @ X25_v3+98]");
			object obj20 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v135 @ X8_v14+E4]");
			bool flag6 = (nint)0 == 0;
			object obj22 = !flag6;
			object obj21 = 0;
			type2 = type;
			if (obj22 != null)
			{
				goto IL_0187;
			}
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		type = type2;
		goto IL_0187;
		IL_0187:
		long value3 = num2 ^ num;
		object obj23 = Enum.ToObject(type, value3);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v22 @ X3+38]");
		object obj24 = 0;
		object obj25 = obj24;
		object obj26 = obj24 + 309;
		object obj27 = obj26 & 1;
		bool flag7 = obj27 == null;
		object obj28 = !flag7;
		if (obj28 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @B0CCA4");
			object obj29 = default(object);
			obj25 = obj29;
		}
		InvalidCastException ex;
		object obj31;
		if (obj23 != null)
		{
			nint num3 = (nint)obj23;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v159 @ X8_v22 (Il2CppClass<System.Object>)+40]");
			nint num4 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v221 @ X1_v13+40]");
			if (num4 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1960");
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @6CB181C");
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [8434110]");
				object obj30 = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v20 @ X29_v1-48]");
				bool flag8 = obj30 != null;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v57 @ X25_v1+FC]");
				obj31 = 0;
				object obj32 = default(object);
				obj25 = obj32;
				T val = default(T);
				ex = (InvalidCastException)val;
				if (!flag8)
				{
					return val;
				}
				goto IL_0375;
			}
		}
		else
		{
			NullReferenceException ex2 = new NullReferenceException();
		}
		ex = new InvalidCastException();
		obj31 = 0;
		goto IL_0375;
		IL_0375:
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @6CB0CA0");
		T result = default(T);
		return result;
	}
}

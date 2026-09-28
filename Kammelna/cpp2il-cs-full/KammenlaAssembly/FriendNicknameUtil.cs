using System;
using System.Diagnostics;
using Cpp2ILInjected;
using Newtonsoft.Json.Linq.JsonPath;
using Unity.Properties;
using UnityEngine.Rendering;

public class FriendNicknameUtil
{
	private sealed class <>c__DisplayClass6_0
	{
		public FriendProfile friendProfile;

		internal void <OpenChangeNicknamePopup>g__SaveNickname|0(string nickname)
		{
			//IL_0011: Unknown result type (might be due to invalid IL or missing references)
			//IL_0016: Expected O, but got Unknown
			//IL_002b: Expected O, but got I4
			object format = "m_StencilDeferredPS" + 3648;
			object obj = 153100288 + 1024;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC195C");
			object arg = default(object);
			string key = string.Format((string)format, arg);
			Prefs.SetString(key, nickname);
		}
	}

	private static string Key(int userId)
	{
		//IL_000a: Unknown result type (might be due to invalid IL or missing references)
		//IL_000f: Expected O, but got Unknown
		//IL_0023: Expected O, but got I4
		object format = "m_StencilDeferredPS" + 3648;
		object obj = 153100288 + 1024;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC195C");
		object arg = default(object);
		return string.Format((string)format, arg);
	}

	private static string Key(string userId)
	{
		//IL_000a: Unknown result type (might be due to invalid IL or missing references)
		//IL_000f: Expected O, but got Unknown
		object obj = "m_StencilDeferredPS" + 3632;
		return (string)obj + userId;
	}

	public static string GetNickname(int userId)
	{
		//IL_000a: Unknown result type (might be due to invalid IL or missing references)
		//IL_000f: Expected O, but got Unknown
		//IL_0028: Expected O, but got I4
		//IL_0053: Expected O, but got I
		//IL_0063: Expected O, but got I
		object format = "m_StencilDeferredPS" + 3648;
		object obj = 153100288 + 1024;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC195C");
		object arg = default(object);
		string key = string.Format((string)format, arg);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v46 @ X19_v3+90]");
		object obj2 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v54 @ X8_v3+B8]");
		object defaultValue = 0;
		return Prefs.GetString(key, (string)defaultValue);
	}

	public static string GetNickname(string userId)
	{
		//IL_000a: Unknown result type (might be due to invalid IL or missing references)
		//IL_000f: Expected O, but got Unknown
		//IL_0034: Expected O, but got I4
		//IL_0044: Expected O, but got I
		//IL_0054: Expected O, but got I
		object obj = "m_StencilDeferredPS" + 3632;
		string key = (string)obj + userId;
		object obj2 = 153100288 + 1024;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v49 @ X8_v4+90]");
		object obj3 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v50 @ X8_v5+B8]");
		object defaultValue = 0;
		return Prefs.GetString(key, (string)defaultValue);
	}

	public static bool HasNickname(int userId)
	{
		//IL_000a: Unknown result type (might be due to invalid IL or missing references)
		//IL_000f: Expected O, but got Unknown
		//IL_0028: Expected O, but got I4
		object format = "m_StencilDeferredPS" + 3648;
		object obj = 153100288 + 1024;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC195C");
		object arg = default(object);
		string key = string.Format((string)format, arg);
		return Prefs.HasKey(key);
	}

	public static bool HasNickname(string userId)
	{
		//IL_000a: Unknown result type (might be due to invalid IL or missing references)
		//IL_000f: Expected O, but got Unknown
		object obj = "m_StencilDeferredPS" + 3632;
		string key = (string)obj + userId;
		return Prefs.HasKey(key);
	}

	public static void OpenChangeNicknamePopup(FriendProfile friendProfile)
	{
		//IL_001f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0024: Expected O, but got Unknown
		//IL_0a65: Unknown result type (might be due to invalid IL or missing references)
		//IL_0a6a: Expected O, but got Unknown
		//IL_0a72: Unknown result type (might be due to invalid IL or missing references)
		//IL_0a77: Expected O, but got Unknown
		//IL_0a80: Unknown result type (might be due to invalid IL or missing references)
		//IL_0a85: Expected O, but got Unknown
		//IL_0032: Unknown result type (might be due to invalid IL or missing references)
		//IL_0037: Expected O, but got Unknown
		//IL_0088: Unknown result type (might be due to invalid IL or missing references)
		//IL_008d: Expected O, but got Unknown
		//IL_0097: Unknown result type (might be due to invalid IL or missing references)
		//IL_009c: Expected O, but got Unknown
		//IL_00ab: Unknown result type (might be due to invalid IL or missing references)
		//IL_00b0: Expected O, but got Unknown
		//IL_00b8: Expected I, but got O
		//IL_00c8: Expected O, but got I
		//IL_0b26: Expected I, but got O
		//IL_0103: Expected O, but got I
		//IL_016b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0170: Expected O, but got Unknown
		//IL_0179: Unknown result type (might be due to invalid IL or missing references)
		//IL_017e: Expected O, but got Unknown
		//IL_0111: Unknown result type (might be due to invalid IL or missing references)
		//IL_0116: Expected O, but got Unknown
		//IL_011f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0124: Expected O, but got Unknown
		//IL_01c8: Expected O, but got I4
		//IL_01de: Expected I, but got O
		//IL_01ee: Expected O, but got I
		//IL_0217: Expected O, but got I
		//IL_025d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0262: Expected O, but got Unknown
		//IL_026c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0271: Expected O, but got Unknown
		//IL_027a: Unknown result type (might be due to invalid IL or missing references)
		//IL_027f: Expected O, but got Unknown
		//IL_028f: Expected O, but got I
		//IL_02d1: Expected O, but got I4
		//IL_02ee: Unknown result type (might be due to invalid IL or missing references)
		//IL_02f3: Expected O, but got Unknown
		//IL_02ff: Expected O, but got I
		//IL_0317: Expected O, but got I
		//IL_0b89: Expected O, but got I
		//IL_0352: Expected O, but got I
		//IL_066e: Expected O, but got I
		//IL_067e: Expected O, but got I
		//IL_0694: Expected O, but got I
		//IL_069d: Unknown result type (might be due to invalid IL or missing references)
		//IL_06a2: Expected O, but got Unknown
		//IL_06bc: Expected O, but got I4
		//IL_06cc: Expected O, but got I
		//IL_03f0: Expected O, but got I
		//IL_0406: Expected O, but got I
		//IL_040f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0414: Expected O, but got Unknown
		//IL_0433: Expected O, but got I
		//IL_03b3: Unknown result type (might be due to invalid IL or missing references)
		//IL_03b8: Expected O, but got Unknown
		//IL_03ce: Unknown result type (might be due to invalid IL or missing references)
		//IL_03d3: Expected O, but got Unknown
		//IL_0706: Expected O, but got I4
		//IL_0360: Unknown result type (might be due to invalid IL or missing references)
		//IL_0365: Expected O, but got Unknown
		//IL_036e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0373: Expected O, but got Unknown
		//IL_0470: Unknown result type (might be due to invalid IL or missing references)
		//IL_0475: Expected O, but got Unknown
		//IL_0484: Unknown result type (might be due to invalid IL or missing references)
		//IL_0489: Expected O, but got Unknown
		//IL_0495: Expected O, but got I
		//IL_04a5: Expected O, but got I
		//IL_04b5: Expected O, but got I
		//IL_04cb: Expected O, but got I
		//IL_04d4: Unknown result type (might be due to invalid IL or missing references)
		//IL_04d9: Expected O, but got Unknown
		//IL_04f3: Expected O, but got I4
		//IL_053b: Expected O, but got I
		//IL_055b: Expected I, but got O
		//IL_0578: Expected O, but got I4
		//IL_0595: Unknown result type (might be due to invalid IL or missing references)
		//IL_059a: Expected O, but got Unknown
		//IL_05a4: Unknown result type (might be due to invalid IL or missing references)
		//IL_05a9: Expected O, but got Unknown
		//IL_05c1: Expected O, but got I
		//IL_0bda: Expected I, but got O
		//IL_0c0f: Expected O, but got I4
		//IL_0c18: Expected O, but got I4
		//IL_05fc: Expected O, but got I
		//IL_0763: Unknown result type (might be due to invalid IL or missing references)
		//IL_0768: Expected O, but got Unknown
		//IL_0780: Expected O, but got I
		//IL_072c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0731: Expected O, but got Unknown
		//IL_0747: Unknown result type (might be due to invalid IL or missing references)
		//IL_074c: Expected O, but got Unknown
		//IL_060a: Unknown result type (might be due to invalid IL or missing references)
		//IL_060f: Expected O, but got Unknown
		//IL_0618: Unknown result type (might be due to invalid IL or missing references)
		//IL_061d: Expected O, but got Unknown
		//IL_0c52: Expected I, but got O
		//IL_0c87: Expected O, but got I4
		//IL_0c90: Expected O, but got I4
		//IL_07bb: Expected O, but got I
		//IL_0853: Expected O, but got I
		//IL_0829: Unknown result type (might be due to invalid IL or missing references)
		//IL_082e: Expected O, but got Unknown
		//IL_08e9: Expected I, but got O
		//IL_090b: Expected O, but got I4
		//IL_0914: Expected O, but got I4
		//IL_07c9: Unknown result type (might be due to invalid IL or missing references)
		//IL_07ce: Expected O, but got Unknown
		//IL_07d7: Unknown result type (might be due to invalid IL or missing references)
		//IL_07dc: Expected O, but got Unknown
		//IL_088e: Expected O, but got I
		//IL_092a: Expected I, but got O
		//IL_093a: Expected O, but got I
		//IL_09c9: Expected O, but got I4
		//IL_09d2: Expected O, but got I4
		//IL_09f5: Unknown result type (might be due to invalid IL or missing references)
		//IL_09fa: Expected O, but got Unknown
		//IL_0a02: Expected I, but got O
		//IL_0a26: Expected O, but got I4
		//IL_0a2f: Expected O, but got I4
		//IL_0a38: Expected O, but got I4
		//IL_0975: Expected O, but got I
		//IL_089c: Unknown result type (might be due to invalid IL or missing references)
		//IL_08a1: Expected O, but got Unknown
		//IL_08aa: Unknown result type (might be due to invalid IL or missing references)
		//IL_08af: Expected O, but got Unknown
		//IL_0ce1: Expected O, but got I4
		//IL_0cea: Expected O, but got I4
		//IL_0983: Unknown result type (might be due to invalid IL or missing references)
		//IL_0988: Expected O, but got Unknown
		//IL_0991: Unknown result type (might be due to invalid IL or missing references)
		//IL_0996: Expected O, but got Unknown
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [91E6155]");
		nint num = 0;
		object obj = typeof(DebugUI.BitField) + 3136;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
		object obj2 = default(object);
		obj2..ctor();
		object obj3;
		object obj9 = default(object);
		object obj11;
		if (obj2 != null)
		{
			obj3 = obj2 + 16;
			obj3 = friendProfile;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
			IPopupWindowBuilderNeedsTitle popupWindowBuilderNeedsTitle = PopupWindowBuilder.Create(PopupWindow.MessageType.Action);
			if (popupWindowBuilderNeedsTitle != null)
			{
				object obj4 = typeof(System.IOAsyncCallback) + 392;
				object obj5 = "Drop Menu Toggle" + 1904;
				object obj6 = typeof(TypeConverter<ushort, char>) + 3400;
				nint num2 = (nint)popupWindowBuilderNeedsTitle;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v372 @ X8_v10 (Il2CppClass<IPopupWindowBuilderNeedsTitle>)+12E]");
				object obj7 = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v372 @ X8_v10 (Il2CppClass<IPopupWindowBuilderNeedsTitle>)+12E]");
				if ((nint)0 == 0)
				{
					goto IL_014c;
				}
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v372 @ X8_v10 (Il2CppClass<IPopupWindowBuilderNeedsTitle>)+B0]");
				object obj8 = (nint)0 + (nint)8;
				while (true)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v455 @ X10_v37-8]");
					if (0 == (nint)obj4)
					{
						break;
					}
					obj9 = obj8 + 16;
					obj7--;
					bool flag = (nint)obj7 != 1;
					obj8 = obj9;
					if (flag)
					{
						continue;
					}
					goto IL_014c;
				}
				object obj10 = num2 + obj8;
				obj11 = obj10 + 312;
				obj9 = obj8;
				goto IL_0b0a;
			}
		}
		goto IL_0a4e;
		IL_08d7:
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @B0D070");
		object obj12 = default(object);
		num = (nint)obj12;
		Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v797 @ X0_v57] (should have been resolved before IL gen)");
		NullReferenceException ex = default(NullReferenceException);
		bool flag2 = ex == null;
		object obj13 = 0;
		object obj14 = 0;
		if (!flag2)
		{
			goto IL_0922;
		}
		goto IL_0a4e;
		IL_0922:
		num = (nint)ex;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v295 @ X8_v4 (Il2CppClass<System.NullReferenceException>)+12E]");
		object obj15 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v295 @ X8_v4 (Il2CppClass<System.NullReferenceException>)+12E]");
		if ((nint)0 == 0)
		{
			goto IL_09b6;
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v295 @ X8_v4 (Il2CppClass<System.NullReferenceException>)+B0]");
		obj9 = (nint)0 + (nint)8;
		object obj16;
		while (true)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v188 @ X10_v14-8]");
			bool flag3 = 0 == (nint)obj16;
			obj13 = 0;
			obj14 = 0;
			if (flag3)
			{
				break;
			}
			obj9 += 16;
			obj15--;
			if ((nint)obj15 != 1)
			{
				continue;
			}
			goto IL_09b6;
		}
		goto IL_0a5c;
		IL_039b:
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @B0D070");
		goto IL_0b67;
		IL_0b67:
		Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v579 @ X0_v26] (should have been resolved before IL gen)");
		object obj18;
		object obj17 = obj18;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v586 @ X21_v11+38]");
		object obj19 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v586 @ X21_v11+38]");
		if ((nint)0 != 0)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v587 @ X8_v21+10]");
			object obj20 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v587 @ X8_v21+10]");
			object obj21 = (nint)0 + (nint)309;
			object obj22 = obj21 & 1;
			bool flag4 = obj22 == null;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v587 @ X8_v21+10]");
			object obj23 = 0;
			if (!flag4)
			{
				goto IL_0441;
			}
		}
		else
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @B0CD24");
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v586 @ X21_v11+38]");
			object obj24 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v608 @ X8_v25+10]");
			object obj20 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v608 @ X8_v25+10]");
			object obj25 = (nint)0 + (nint)309;
			object obj26 = obj25 & 1;
			bool flag5 = obj26 == null;
			object obj27 = !flag5;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v608 @ X8_v25+10]");
			object obj23 = 0;
			if (obj27 != null)
			{
				goto IL_0441;
			}
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @B0CCA4");
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v630 @ X0_v29+E4]");
		bool flag6 = (nint)0 == 0;
		object obj28 = !flag6;
		if (obj28 != null)
		{
			goto IL_0466;
		}
		goto IL_0714;
		IL_0645:
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @B0D070");
		goto IL_0bd2;
		IL_0a4e:
		ex = new NullReferenceException();
		goto IL_0a5c;
		IL_014c:
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @B0D070");
		object obj29 = default(object);
		obj11 = obj29;
		goto IL_0b0a;
		IL_0b0a:
		Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v478 @ X8_v11] (should have been resolved before IL gen)");
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC18B4");
		num = (nint)obj3;
		object[] array = default(object[]);
		if (obj3 != null && array != null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v295 @ X8_v4 (Il2CppClass<System.NullReferenceException>)+18]");
			bool flag7 = (nint)0 == 0;
			object obj30 = 1;
			if (!flag7)
			{
				nint num3 = (nint)array;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v494 @ X8_v53 (Il2CppClass<System.Object[]>)+40]");
				obj30 = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1958");
				IndexOutOfRangeException ex2 = default(IndexOutOfRangeException);
				bool flag8 = ex2 == null;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v494 @ X8_v53 (Il2CppClass<System.Object[]>)+40]");
				object obj31 = 0;
				if (flag8)
				{
					goto IL_0aa0;
				}
			}
			num = array.Length;
			if (array.Length == 0)
			{
				IndexOutOfRangeException ex2 = new IndexOutOfRangeException();
				object obj31 = obj30;
				goto IL_0aa0;
			}
			object obj32 = typeof(Newtonsoft.Json.Linq.JsonPath.JPath) + 2640;
			object text = "October" + 1432;
			object obj33 = array + 32;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v295 @ X8_v4 (Il2CppClass<System.NullReferenceException>)+18]");
			obj33 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
			LocalizableText localizableText = default(LocalizableText);
			localizableText..ctor((string)text, array);
			object obj34 = default(object);
			bool flag9 = obj34 == null;
			obj14 = 0;
			if (!flag9)
			{
				object obj35 = typeof(System.IOAsyncCallback) + 384;
				obj18 = (nint)0 + (nint)3232;
				object obj36 = obj34;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v520 @ X8_v18+12E]");
				object obj37 = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v520 @ X8_v18+12E]");
				if ((nint)0 == 0)
				{
					goto IL_039b;
				}
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v520 @ X8_v18+B0]");
				object obj38 = (nint)0 + (nint)8;
				while (true)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v562 @ X10_v32-8]");
					if (0 == (nint)obj35)
					{
						break;
					}
					obj9 = obj38 + 16;
					obj37--;
					bool flag10 = (nint)obj37 != 1;
					obj38 = obj9;
					if (flag10)
					{
						continue;
					}
					goto IL_039b;
				}
				object obj39 = obj38 + 1;
				object obj40 = obj36 + obj39;
				object obj41 = obj40 + 312;
				obj9 = obj38;
				goto IL_0b67;
			}
		}
		goto IL_0a4e;
		IL_0a5c:
		object obj42 = obj9 + 9;
		object obj43 = num + obj42;
		object obj44 = obj43 + 312;
		goto IL_0cf8;
		IL_0cf8:
		Cpp2ILHelpers.NoteDecompilerIssue("Indirect jump: [v345 @ X8_v3] (should have been resolved before IL gen)");
		Cpp2ILHelpers.NoteDecompilerIssue("Warning: Method ends with non empty stack (-50), the output could be wrong!");
		/*Error: End of method reached without returning.*/;
		IL_0714:
		Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		goto IL_0466;
		IL_0441:
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v630 @ X0_v29+E4]");
		if ((nint)0 != 0)
		{
			goto IL_0466;
		}
		goto IL_0714;
		IL_0804:
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @B0D070");
		goto IL_0c4a;
		IL_0aa0:
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1ABC");
		throw new OutOfMemoryException();
		IL_0466:
		object text2 = "Material with texture name \"" + 3600;
		object obj45 = typeof(System.Diagnostics.DiagnosticSourceEventSource.TransformSpec.PropertySpec.PropertyFetch.EnumeratePropertyFetch<>) + 3576;
		object obj46 = (nint)0 + (nint)696;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v586 @ X21_v11+38]");
		object obj47 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v623 @ X8_v29+10]");
		object obj48 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v623 @ X8_v29+10]");
		object obj49 = (nint)0 + (nint)309;
		object obj50 = obj49 & 1;
		bool flag11 = obj50 == null;
		object obj51 = !flag11;
		if (obj51 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @B0CCA4");
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v633 @ X0_v38+B8]");
		num = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
		LocalizableText localizableText2 = default(LocalizableText);
		localizableText2..ctor((string)text2, (object[])num);
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
		Action<object> action = default(Action<object>);
		action..ctor(obj2, (IntPtr)obj46);
		object obj52 = default(object);
		bool flag12 = obj52 == null;
		obj14 = 0;
		if (flag12)
		{
			goto IL_0a4e;
		}
		obj16 = typeof(System.IOAsyncCallback) + 368;
		object label = "SERVICE_DISABLED" + 1632;
		object obj53 = obj52;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v644 @ X8_v33+12E]");
		object obj54 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v644 @ X8_v33+12E]");
		if ((nint)0 == 0)
		{
			goto IL_0645;
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v644 @ X8_v33+B0]");
		object obj55 = (nint)0 + (nint)8;
		while (true)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v686 @ X10_v27-8]");
			if (0 == (nint)obj16)
			{
				break;
			}
			obj9 = obj55 + 16;
			obj54--;
			bool flag13 = (nint)obj54 != 1;
			obj55 = obj9;
			if (flag13)
			{
				continue;
			}
			goto IL_0645;
		}
		object obj56 = obj55 + 7;
		object obj57 = obj53 + obj56;
		object obj58 = obj57 + 312;
		obj9 = obj55;
		goto IL_0bd2;
		IL_0bd2:
		num = (nint)obj58;
		Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v703 @ X0_v43] (should have been resolved before IL gen)");
		PopupButton popupButton = PopupButton.Positive((string)label, null, dismiss: true);
		object obj59 = default(object);
		bool flag14 = obj59 == null;
		obj13 = 0;
		obj14 = 0;
		if (flag14)
		{
			goto IL_0a4e;
		}
		object label2 = "AvailableVoices" + 768;
		object obj60 = obj59;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v713 @ X8_v36+12E]");
		object obj61 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v713 @ X8_v36+12E]");
		if ((nint)0 == 0)
		{
			goto IL_0804;
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v713 @ X8_v36+B0]");
		object obj62 = (nint)0 + (nint)8;
		while (true)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v755 @ X10_v22-8]");
			if (0 == (nint)obj16)
			{
				break;
			}
			obj9 = obj62 + 16;
			obj61--;
			bool flag15 = (nint)obj61 != 1;
			obj62 = obj9;
			if (flag15)
			{
				continue;
			}
			goto IL_0804;
		}
		object obj63 = obj60 + obj62;
		object obj64 = obj63 + 312;
		obj9 = obj62;
		goto IL_0c4a;
		IL_0c4a:
		num = (nint)obj64;
		Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v771 @ X0_v48] (should have been resolved before IL gen)");
		PopupButton popupButton2 = PopupButton.Neutral((string)label2, null, dismiss: true);
		object obj65 = default(object);
		bool flag16 = obj65 == null;
		obj13 = 0;
		obj14 = 0;
		if (!flag16)
		{
			object obj66 = obj65;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v779 @ X8_v39+12E]");
			object obj67 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v779 @ X8_v39+12E]");
			if ((nint)0 == 0)
			{
				goto IL_08d7;
			}
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v779 @ X8_v39+B0]");
			object obj68 = (nint)0 + (nint)8;
			while (true)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v182 @ X10_v17-8]");
				if (0 == (nint)obj16)
				{
					break;
				}
				obj9 = obj68 + 16;
				obj67--;
				bool flag17 = (nint)obj67 != 1;
				obj68 = obj9;
				if (flag17)
				{
					continue;
				}
				goto IL_08d7;
			}
			object obj69 = obj66 + obj68;
			object obj70 = obj69 + 312;
			num = (nint)obj70;
			Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v812 @ X0_v60] (should have been resolved before IL gen)");
			bool flag18 = ex == null;
			object obj71 = !flag18;
			obj13 = 0;
			obj14 = 0;
			obj9 = obj68;
			if (obj71 != null)
			{
				goto IL_0922;
			}
		}
		goto IL_0a4e;
		IL_09b6:
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @B0D070");
		obj13 = 0;
		obj14 = 0;
		object obj72 = default(object);
		obj44 = obj72;
		goto IL_0cf8;
	}
}

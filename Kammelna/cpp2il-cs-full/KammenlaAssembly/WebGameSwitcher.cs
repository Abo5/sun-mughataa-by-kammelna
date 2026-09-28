using System;
using System.Buffers.Text;
using System.Collections;
using System.ComponentModel;
using System.Formats.Asn1;
using Cpp2ILInjected;
using Newtonsoft.Json.Linq.JsonPath;
using Unity.Services.Authentication.Shared;
using UnityEngine;
using UnityEngine.TextCore;

public class WebGameSwitcher : MonoBehaviour
{
	private unsafe void Awake()
	{
		//IL_000f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0014: Expected O, but got Unknown
		//IL_002a: Expected O, but got I
		//IL_00e1: Expected O, but got I4
		//IL_00ea: Expected O, but got I4
		//IL_00f3: Expected O, but got I4
		//IL_006f: Expected O, but got I4
		//IL_0078: Expected O, but got I4
		//IL_0148: Unknown result type (might be due to invalid IL or missing references)
		//IL_014d: Expected O, but got Unknown
		//IL_015c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0161: Expected O, but got Unknown
		//IL_0246: Expected O, but got I4
		//IL_01f1: Expected O, but got I4
		//IL_02b8: Expected O, but got I4
		//IL_02c7: Expected O, but got I4
		//IL_02d7: Expected O, but got I
		//IL_0292: Expected O, but got I4
		//IL_029b: Expected O, but got I4
		//IL_09ed: Expected O, but got I
		//IL_0a0f: Expected O, but got I4
		//IL_0a18: Expected O, but got I4
		//IL_0a28: Expected O, but got I
		//IL_0329: Expected O, but got I
		//IL_0349: Expected O, but got I4
		//IL_0359: Expected O, but got I
		//IL_0a7c: Expected O, but got I4
		//IL_0ab8: Unknown result type (might be due to invalid IL or missing references)
		//IL_0abd: Expected O, but got Unknown
		//IL_0ac6: Unknown result type (might be due to invalid IL or missing references)
		//IL_0acb: Expected O, but got Unknown
		//IL_03ca: Expected O, but got Ref
		//IL_0e3f: Expected O, but got I
		//IL_0d95: Expected O, but got I4
		//IL_03e7: Unknown result type (might be due to invalid IL or missing references)
		//IL_03ec: Expected O, but got Unknown
		//IL_03fb: Unknown result type (might be due to invalid IL or missing references)
		//IL_0400: Expected O, but got Unknown
		//IL_040f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0414: Expected O, but got Unknown
		//IL_04e6: Expected I, but got O
		//IL_04f6: Expected O, but got I
		//IL_0595: Expected O, but got I4
		//IL_0cfe: Unknown result type (might be due to invalid IL or missing references)
		//IL_0d03: Expected O, but got Unknown
		//IL_0531: Expected O, but got I
		//IL_0cbf: Expected O, but got I
		//IL_0e5d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0e62: Expected O, but got Unknown
		//IL_05aa: Unknown result type (might be due to invalid IL or missing references)
		//IL_05af: Expected O, but got Unknown
		//IL_05b8: Unknown result type (might be due to invalid IL or missing references)
		//IL_05bd: Expected O, but got Unknown
		//IL_053f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0544: Expected O, but got Unknown
		//IL_055a: Expected O, but got I
		//IL_08c5: Expected I, but got O
		//IL_08d5: Expected O, but got I
		//IL_05ef: Expected I, but got O
		//IL_05ff: Expected O, but got I
		//IL_0984: Expected O, but got I4
		//IL_06ae: Expected O, but got I4
		//IL_0910: Expected O, but got I
		//IL_0d6c: Expected O, but got I
		//IL_064a: Expected O, but got I
		//IL_0de3: Expected O, but got I
		//IL_0d30: Expected O, but got I
		//IL_06bc: Unknown result type (might be due to invalid IL or missing references)
		//IL_06c1: Expected O, but got Unknown
		//IL_06c9: Unknown result type (might be due to invalid IL or missing references)
		//IL_06ce: Expected O, but got Unknown
		//IL_06d7: Unknown result type (might be due to invalid IL or missing references)
		//IL_06dc: Expected O, but got Unknown
		//IL_091e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0923: Expected O, but got Unknown
		//IL_092c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0931: Expected O, but got Unknown
		//IL_0953: Expected O, but got I
		//IL_0764: Expected O, but got I4
		//IL_0658: Unknown result type (might be due to invalid IL or missing references)
		//IL_065d: Expected O, but got Unknown
		//IL_0673: Expected O, but got I
		//IL_0847: Expected O, but got I
		//IL_0466: Expected I4, but got O
		//IL_046f: Expected O, but got I4
		//IL_048f: Expected I4, but got O
		//IL_0498: Expected O, but got I4
		//IL_04d0: Expected O, but got I
		//IL_086d: Expected O, but got I
		//IL_088f: Expected O, but got I4
		//IL_0442: Expected I4, but got O
		object obj = typeof(Newtonsoft.Json.Linq.JsonPath.JPath) + 1168;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [91E72B2]");
		object obj2 = (nint)0 & (nint)1;
		object obj4;
		if (obj2 != null)
		{
			object obj3 = obj;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v56 @ X0_v93+E4]");
			bool flag = (nint)0 == 0;
			obj4 = 0;
			obj4 = 0;
			if (!flag)
			{
				goto IL_0086;
			}
		}
		else
		{
			_ = 1;
			object obj3 = obj;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v56 @ X0_v93+E4]");
			bool flag2 = (nint)0 == 0;
			object obj5 = !flag2;
			obj4 = 0;
			obj4 = 0;
			if (obj5 != null)
			{
				goto IL_0086;
			}
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		Platform platform = KUtil.GetPlatform();
		if (platform == Platform.Web)
		{
			goto IL_0139;
		}
		return;
		IL_03a1:
		Array values;
		IEnumerator enumerator = values.GetEnumerator();
		bool flag3 = enumerator == null;
		string text = null;
		object obj6 = (object)(&obj4);
		if (flag3)
		{
			goto IL_0ad1;
		}
		object obj7 = typeof(UnityEngine.TextCore.HorizontalAlignment) + 2528;
		object obj8 = typeof(System.ComponentModel.ExtendedPropertyDescriptor) + 2232;
		object obj9 = typeof(System.Buffers.Text.ParserHelpers) + 1624;
		object obj11 = default(object);
		object obj10 = obj11;
		object obj13 = default(object);
		object obj12 = obj13;
		object obj15 = default(object);
		object obj14 = obj15;
		IEnumerator enumerator2 = enumerator;
		object obj16;
		object obj19 = default(object);
		object obj20;
		object obj22 = default(object);
		IEnumerator enumerator3 = default(IEnumerator);
		object obj28 = default(object);
		object obj32 = default(object);
		object obj34;
		Enum enumeration = default(Enum);
		object obj38 = default(object);
		object obj39 = default(object);
		object obj40 = default(object);
		object obj41 = default(object);
		object obj30;
		object obj42;
		string text2;
		object obj23;
		object obj24;
		object obj29;
		object obj25;
		while (true)
		{
			nint num = (nint)enumerator2;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v546 @ X8_v27 (Il2CppClass<System.Collections.IEnumerator>)+12E]");
			obj16 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v546 @ X8_v27 (Il2CppClass<System.Collections.IEnumerator>)+12E]");
			if ((nint)0 == 0)
			{
				goto IL_0582;
			}
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v546 @ X8_v27 (Il2CppClass<System.Collections.IEnumerator>)+B0]");
			object obj17 = (nint)0 + (nint)8;
			while (true)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v677 @ X10_v25-8]");
				obj10 = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v677 @ X10_v25-8]");
				if (0 == (nint)obj7)
				{
					break;
				}
				obj14 = obj17 + 16;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v546 @ X8_v27 (Il2CppClass<System.Collections.IEnumerator>)+12E]");
				obj16 = -1;
				bool flag4 = (nint)obj16 != 1;
				obj17 = obj14;
				if (flag4)
				{
					continue;
				}
				goto IL_0582;
			}
			obj16 = obj17;
			object obj18 = num + obj17;
			obj19 = obj18 + 312;
			obj14 = obj17;
			goto IL_0ce3;
			IL_0ce3:
			obj20 = obj19;
			Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v701 @ X0_v42] (should have been resolved before IL gen)");
			object obj21 = obj22 & 1;
			if (obj21 == null)
			{
				break;
			}
			if (enumerator3 != null)
			{
				nint num2 = (nint)enumerator3;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v713 @ X8_v30 (Il2CppClass<System.Collections.IEnumerator>)+12E]");
				obj23 = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v713 @ X8_v30 (Il2CppClass<System.Collections.IEnumerator>)+12E]");
				bool flag5 = (nint)0 == 0;
				obj24 = obj10;
				obj25 = obj14;
				if (flag5)
				{
					goto IL_069b;
				}
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v713 @ X8_v30 (Il2CppClass<System.Collections.IEnumerator>)+B0]");
				object obj26 = (nint)0 + (nint)8;
				while (true)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v758 @ X10_v20-8]");
					obj24 = 0;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v758 @ X10_v20-8]");
					if (0 == (nint)obj7)
					{
						break;
					}
					obj25 = obj26 + 16;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v713 @ X8_v30 (Il2CppClass<System.Collections.IEnumerator>)+12E]");
					obj23 = -1;
					bool flag6 = (nint)obj23 != 1;
					obj26 = obj25;
					if (flag6)
					{
						continue;
					}
					goto IL_069b;
				}
				obj23 = obj26 + 1;
				object obj27 = num2 + obj23;
				obj28 = obj27 + 312;
				obj29 = obj12;
				obj25 = obj26;
				goto IL_0d54;
			}
			throw new NullReferenceException();
			IL_069b:
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @B0D070");
			obj29 = 1;
			goto IL_0d54;
			IL_0d54:
			obj30 = obj28;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v784 @ X0_v46+8]");
			text2 = (string)0;
			Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v784 @ X0_v46] (should have been resolved before IL gen)");
			string text3 = (string)obj8;
			object obj31 = obj32;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v802 @ X8_v33+40]");
			nint num3 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v608 @ X1_v24 (System.String)+40]");
			if (num3 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1960");
				object obj33 = obj34;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v816 @ X0_v52+E4]");
				bool flag7 = (nint)0 == 0;
				object obj35 = !flag7;
				if (obj35 == null)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
				}
				string absoluteURL = Application.absoluteURL;
				if (absoluteURL != null)
				{
					string text4 = absoluteURL.ToLower();
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC195C");
					string friendlyName = EnumExtensions.GetFriendlyName(enumeration);
					if (friendlyName != null)
					{
						string text5 = friendlyName.ToLower();
						if (text4 != null)
						{
							bool flag8 = text4.Contains(text5);
							bool flag9 = !flag8;
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v816 @ X0_v52+E4]");
							obj6 = 0;
							if (!flag9)
							{
								object obj36 = obj9;
								Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v835 @ X0_v66+E4]");
								obj6 = 0;
								Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v835 @ X0_v66+E4]");
								bool flag10 = (nint)0 == 0;
								object obj37 = !flag10;
								if (obj37 == null)
								{
									Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
								}
								Preferences.CurrentGame = (Games)obj38;
							}
							bool flag11 = enumerator3 == null;
							obj10 = obj24;
							Games games = (Games)obj38;
							obj12 = 0;
							obj14 = obj25;
							enumerator2 = enumerator3;
							obj11 = obj24;
							games = (Games)obj38;
							obj13 = 0;
							obj15 = obj25;
							obj39 = obj9;
							obj40 = obj8;
							obj41 = obj7;
							text = text5;
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v608 @ X1_v24 (System.String)+40]");
							obj42 = 0;
							if (!flag11)
							{
								continue;
							}
							goto IL_0ad1;
						}
						throw new NullReferenceException();
					}
					throw new NullReferenceException();
				}
				throw new NullReferenceException();
			}
			throw new InvalidCastException();
			IL_0582:
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @B0D070");
			obj12 = 0;
			goto IL_0ce3;
		}
		Type type = null;
		Type type2 = null;
		goto IL_0e4e;
		IL_0aa2:
		NullReferenceException ex = new NullReferenceException();
		goto IL_0ab0;
		IL_0377:
		Type typeFromHandle;
		values = Enum.GetValues(typeFromHandle);
		if (values != null)
		{
			goto IL_03a1;
		}
		goto IL_0aa2;
		IL_0086:
		Platform platform2 = KUtil.GetPlatform();
		if (platform2 != Platform.Web)
		{
			return;
		}
		goto IL_0139;
		IL_0139:
		obj34 = typeof(Unity.Services.Authentication.Shared.ApiConfiguration) + 520;
		object obj43 = typeof(System.Formats.Asn1.SetOfValueComparer) + 2536;
		object obj44 = obj34;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v105 @ X0_v3+E4]");
		string absoluteURL2;
		string value;
		if ((nint)0 != 0)
		{
			absoluteURL2 = Application.absoluteURL;
			object obj45 = obj43;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v185 @ X8_v42+E4]");
			bool flag12 = (nint)0 == 0;
			value = absoluteURL2;
			if (!flag12)
			{
				goto IL_01cc;
			}
		}
		else
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			absoluteURL2 = Application.absoluteURL;
			object obj45 = obj43;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v185 @ X8_v42+E4]");
			bool flag13 = (nint)0 == 0;
			object obj46 = !flag13;
			value = absoluteURL2;
			if (obj46 != null)
			{
				goto IL_01cc;
			}
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		bool flag14 = StringsExtensions.IsNullOrEmpty(value);
		bool flag15 = !flag14;
		object obj47 = !flag15;
		object obj48 = 0;
		if (obj47 == null)
		{
			goto IL_02a9;
		}
		return;
		IL_0969:
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @B0D070");
		obj11 = obj10;
		obj13 = 0;
		obj15 = obj14;
		obj39 = obj9;
		obj40 = obj8;
		obj41 = obj7;
		object obj49 = default(object);
		obj30 = obj49;
		goto IL_0e27;
		IL_0ad1:
		throw new NullReferenceException();
		IL_0ab0:
		nint num4;
		object obj50 = num4 + obj15;
		obj30 = obj50 + 312;
		goto IL_0e27;
		IL_01cc:
		bool flag16 = StringsExtensions.IsNullOrEmpty(absoluteURL2);
		bool flag17 = !flag16;
		obj48 = 0;
		if (!flag17)
		{
			return;
		}
		goto IL_02a9;
		IL_02a9:
		object handle = 147423232 + 3744;
		type2 = (Type)(153100288 + 1024);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v180 @ X19_v15 (System.Type)+E0]");
		object obj51 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v298 @ X8_v8+E4]");
		object obj53;
		Type type3;
		IntPtr intPtr;
		if ((nint)0 != 0)
		{
			typeFromHandle = Type.GetTypeFromHandle((RuntimeTypeHandle)handle);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v180 @ X19_v15 (System.Type)+98]");
			num4 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v420 @ X8_v15 (Il2CppClass<System.NullReferenceException>)+E4]");
			obj42 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v420 @ X8_v15 (Il2CppClass<System.NullReferenceException>)+E4]");
			bool flag18 = (nint)0 == 0;
			object obj52 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v420 @ X8_v15 (Il2CppClass<System.NullReferenceException>)+E4]");
			obj53 = 0;
			type3 = typeFromHandle;
			intPtr = num4;
			if (!flag18)
			{
				goto IL_0377;
			}
		}
		else
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			typeFromHandle = Type.GetTypeFromHandle((RuntimeTypeHandle)handle);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v180 @ X19_v15 (System.Type)+98]");
			num4 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v420 @ X8_v15 (Il2CppClass<System.NullReferenceException>)+E4]");
			obj42 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v420 @ X8_v15 (Il2CppClass<System.NullReferenceException>)+E4]");
			bool flag19 = (nint)0 == 0;
			object obj54 = !flag19;
			object obj52 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v420 @ X8_v15 (Il2CppClass<System.NullReferenceException>)+E4]");
			obj53 = 0;
			type3 = typeFromHandle;
			intPtr = num4;
			if (obj54 != null)
			{
				goto IL_0377;
			}
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		values = Enum.GetValues(type3);
		bool flag20 = values == null;
		object obj55 = !flag20;
		obj42 = obj53;
		type2 = type3;
		num4 = intPtr;
		if (obj55 != null)
		{
			goto IL_03a1;
		}
		goto IL_0aa2;
		IL_0e4e:
		object obj56 = typeof(UnityEngine.TextCore.HorizontalAlignment) + 2344;
		text2 = (string)obj56;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1958");
		bool flag21 = ex == null;
		obj11 = obj10;
		obj13 = obj12;
		obj15 = obj14;
		obj39 = obj9;
		obj40 = obj8;
		obj41 = obj7;
		obj23 = obj16;
		obj30 = obj20;
		if (!flag21)
		{
			num4 = (nint)ex;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v420 @ X8_v15 (Il2CppClass<System.NullReferenceException>)+12E]");
			object obj57 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v420 @ X8_v15 (Il2CppClass<System.NullReferenceException>)+12E]");
			if ((nint)0 == 0)
			{
				goto IL_0969;
			}
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v420 @ X8_v15 (Il2CppClass<System.NullReferenceException>)+B0]");
			obj15 = (nint)0 + (nint)8;
			while (true)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v121 @ X10_v10-8]");
				obj11 = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v121 @ X10_v10-8]");
				bool flag22 = 0 == (nint)obj56;
				obj13 = obj12;
				obj39 = obj9;
				obj40 = obj8;
				obj41 = obj7;
				if (flag22)
				{
					break;
				}
				obj14 = obj15 + 16;
				obj57--;
				bool flag23 = (nint)obj57 != 1;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v121 @ X10_v10-8]");
				obj10 = 0;
				obj15 = obj14;
				if (flag23)
				{
					continue;
				}
				goto IL_0969;
			}
			goto IL_0ab0;
		}
		goto IL_0d7b;
		IL_0d7b:
		bool flag24 = (object)type2 == null;
		object obj58 = !flag24;
		obj24 = obj11;
		obj29 = obj13;
		obj25 = obj15;
		obj9 = obj39;
		obj8 = obj40;
		obj7 = obj41;
		if (obj58 == null)
		{
			return;
		}
		OutOfMemoryException ex2 = new OutOfMemoryException();
		if ((nint)text2 == 1)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @6CB0B80");
			object obj59 = default(object);
			type2 = (Type)obj59;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @6CB0BB0");
			obj10 = obj24;
			obj12 = obj29;
			obj14 = obj25;
			type = (Type)obj59;
			obj16 = obj23;
			obj20 = obj30;
			goto IL_0e4e;
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @1C99B68");
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @6CB03A0");
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2B060");
		return;
		IL_0e27:
		obj23 = obj30;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v257 @ X8_v9+8]");
		text2 = (string)0;
		Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v257 @ X8_v9] (should have been resolved before IL gen)");
		goto IL_0d7b;
	}
}

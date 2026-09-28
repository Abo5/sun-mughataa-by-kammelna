using System;
using System.Collections.Generic;
using System.Data.SqlTypes;
using System.Formats.Asn1;
using System.Globalization;
using System.Linq;
using System.Runtime.Remoting.Messaging;
using System.Text;
using Cpp2ILInjected;
using DG.Tweening;
using HuaweiMobileServices.Location.Location;
using Kammelna.Server.Models.Clans;
using Newtonsoft.Json.Linq.JsonPath;
using Spine;
using TMPro;
using Unity.Services.Authentication.Shared;
using UnityEngine;

public static class TextMeshProExtensions
{
	[Serializable]
	private sealed class <>c
	{
		public static readonly <>c <>9;

		public static Func<string, string> <>9__4_0;

		static <>c()
		{
			//IL_000f: Unknown result type (might be due to invalid IL or missing references)
			//IL_0014: Expected O, but got Unknown
			object obj = typeof(SkeletonBinary.SkeletonInput) + 2776;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
			object obj2 = default(object);
			obj2..ctor();
			object obj3 = obj;
			object obj4 = obj2;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
		}

		internal string <LocalizeArguments>b__4_0(string arg)
		{
			//IL_0009: Expected O, but got I4
			//IL_0018: Unknown result type (might be due to invalid IL or missing references)
			//IL_001d: Expected O, but got Unknown
			//IL_0033: Expected O, but got I
			//IL_00bf: Expected O, but got I4
			object obj = 152981504;
			object obj2 = typeof(Newtonsoft.Json.Linq.JsonPath.JPath) + 2656;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [91E5E99]");
			object obj3 = (nint)0 & (nint)1;
			if (obj3 != null)
			{
				object obj4 = obj2;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v57 @ X0_v1+E4]");
				if ((nint)0 != 0)
				{
					goto IL_007d;
				}
			}
			else
			{
				_ = 1;
				object obj4 = obj2;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v57 @ X0_v1+E4]");
				bool flag = (nint)0 == 0;
				object obj5 = !flag;
				if (obj5 != null)
				{
					goto IL_007d;
				}
			}
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			return LocalizationUtil.Localize(arg);
			IL_007d:
			return LocalizationUtil.Localize(arg);
		}
	}

	private const string CrownForText = "<sprite name=\"crown\">";

	private const string VerifyForText = "<sprite name=\"verified\">";

	public static void Localize(TextMeshProUGUI textMesh, string text = null)
	{
		//IL_000f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0014: Expected O, but got Unknown
		//IL_002a: Expected O, but got I
		//IL_00de: Expected O, but got I4
		//IL_009a: Expected O, but got I4
		//IL_01d5: Expected I, but got O
		//IL_01e5: Expected O, but got I
		//IL_0201: Unknown result type (might be due to invalid IL or missing references)
		//IL_0206: Expected O, but got Unknown
		//IL_0230: Expected O, but got I4
		//IL_0123: Expected O, but got I4
		//IL_012c: Expected O, but got I4
		//IL_016b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0170: Expected O, but got Unknown
		object obj = typeof(MemberAchievementClanFeedData) + 2976;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [91E5E8A]");
		object obj2 = (nint)0 & (nint)1;
		if (obj2 != null)
		{
			object obj3 = obj;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v54 @ X0_v13+E4]");
			if ((nint)0 != 0)
			{
				goto IL_0074;
			}
		}
		else
		{
			_ = 1;
			object obj3 = obj;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v54 @ X0_v13+E4]");
			bool flag = (nint)0 == 0;
			object obj4 = !flag;
			if (obj4 != null)
			{
				goto IL_0074;
			}
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		bool flag2 = textMesh == null;
		bool flag3 = !flag2;
		object obj5 = !flag3;
		object obj6 = 0;
		UnityEngine.Object obj7 = null;
		if (obj5 != null)
		{
			return;
		}
		goto IL_013f;
		IL_01ad:
		string input;
		string text2 = LocalizationUtil.Localize(input);
		FixArabic(textMesh, text2);
		return;
		IL_013f:
		string text3;
		if (text != null)
		{
			object obj8 = typeof(Newtonsoft.Json.Linq.JsonPath.JPath) + 2656;
			object obj9 = obj8;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v138 @ X0_v2+E4]");
			bool flag4 = (nint)0 == 0;
			input = text;
			text3 = text;
			if (!flag4)
			{
				goto IL_01ad;
			}
		}
		else
		{
			nint num = (nint)textMesh;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v139 @ X8_v4 (Il2CppClass<TMPro.TextMeshProUGUI>)+550]");
			obj7 = (UnityEngine.Object)0;
			string text4 = textMesh.text;
			object obj10 = typeof(Newtonsoft.Json.Linq.JsonPath.JPath) + 2656;
			object obj9 = obj10;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v138 @ X0_v2+E4]");
			bool flag5 = (nint)0 == 0;
			object obj11 = !flag5;
			input = text4;
			text3 = text4;
			if (obj11 != null)
			{
				goto IL_01ad;
			}
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		input = text3;
		goto IL_01ad;
		IL_0074:
		bool flag6 = textMesh == null;
		bool flag7 = !flag6;
		obj6 = 0;
		obj7 = null;
		if (!flag7)
		{
			return;
		}
		goto IL_013f;
	}

	public static void Localize(TextMeshProUGUI textMesh, string text, object[] formattedArguments)
	{
		//IL_0009: Expected O, but got I4
		//IL_0018: Unknown result type (might be due to invalid IL or missing references)
		//IL_001d: Expected O, but got Unknown
		//IL_0033: Expected O, but got I
		//IL_00e7: Expected O, but got I4
		//IL_00a3: Expected O, but got I4
		//IL_012c: Expected O, but got I4
		//IL_0135: Expected O, but got I4
		//IL_021a: Unknown result type (might be due to invalid IL or missing references)
		//IL_021f: Expected O, but got Unknown
		//IL_0249: Expected O, but got I4
		//IL_01cf: Expected O, but got I4
		//IL_01df: Expected O, but got I
		//IL_01e7: Expected I, but got O
		//IL_02d3: Unknown result type (might be due to invalid IL or missing references)
		//IL_02d8: Expected O, but got Unknown
		//IL_0302: Expected O, but got I4
		//IL_032c: Expected I8, but got O
		object obj = 152981504;
		object obj2 = typeof(MemberAchievementClanFeedData) + 2976;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [91E5E8B]");
		object obj3 = (nint)0 & (nint)1;
		if (obj3 != null)
		{
			object obj4 = obj2;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v59 @ X0_v20+E4]");
			if ((nint)0 != 0)
			{
				goto IL_007d;
			}
		}
		else
		{
			_ = 1;
			object obj4 = obj2;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v59 @ X0_v20+E4]");
			bool flag = (nint)0 == 0;
			object obj5 = !flag;
			if (obj5 != null)
			{
				goto IL_007d;
			}
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		bool flag2 = textMesh == null;
		bool flag3 = !flag2;
		object obj6 = !flag3;
		object obj7 = 0;
		UnityEngine.Object obj8 = null;
		if (obj6 != null)
		{
			return;
		}
		goto IL_0148;
		IL_0344:
		throw new InvalidCastException();
		IL_027d:
		string text2;
		FixArabic(textMesh, text2);
		return;
		IL_0148:
		if (formattedArguments != null)
		{
			if (formattedArguments.Length == 1)
			{
				object obj9 = formattedArguments[0];
				if (formattedArguments[0] != null)
				{
					object obj10 = 153100288 + 1024;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v221 @ X8_v11+48]");
					obj8 = (UnityEngine.Object)0;
					nint num = (nint)obj9;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v221 @ X8_v11+48]");
					if (obj9 == null)
					{
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v201 @ X8_v12 (Il2CppClass<System.Object>)+40]");
						nint num2 = 0;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v196 @ X1_v5 (UnityEngine.Object)+40]");
						if (num2 == 0)
						{
							Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1960");
							object obj11 = typeof(Newtonsoft.Json.Linq.JsonPath.JPath) + 2656;
							object obj12 = obj11;
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v242 @ X0_v15+E4]");
							bool flag4 = (nint)0 == 0;
							object obj13 = !flag4;
							if (obj13 == null)
							{
								Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
							}
							object obj14 = default(object);
							text2 = LocalizationUtil.Localize(text, (long)obj14);
							goto IL_027d;
						}
						goto IL_0344;
					}
				}
			}
			object obj15 = typeof(Newtonsoft.Json.Linq.JsonPath.JPath) + 2656;
			object obj16 = obj15;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v204 @ X0_v8+E4]");
			bool flag5 = (nint)0 == 0;
			object obj17 = !flag5;
			if (obj17 == null)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			}
			text2 = LocalizationUtil.Localize(text, formattedArguments);
			goto IL_027d;
		}
		NullReferenceException ex = new NullReferenceException();
		goto IL_0344;
		IL_007d:
		bool flag6 = textMesh == null;
		bool flag7 = !flag6;
		obj7 = 0;
		obj8 = null;
		if (!flag7)
		{
			return;
		}
		goto IL_0148;
	}

	public static void LocalizeArguments(TextMeshProUGUI textMesh, string text, object[] arguments)
	{
		//IL_0009: Expected O, but got I4
		//IL_0018: Unknown result type (might be due to invalid IL or missing references)
		//IL_001d: Expected O, but got Unknown
		//IL_0033: Expected O, but got I
		//IL_00e7: Expected O, but got I4
		//IL_00a3: Expected O, but got I4
		//IL_0157: Unknown result type (might be due to invalid IL or missing references)
		//IL_015c: Expected O, but got Unknown
		//IL_0168: Expected O, but got I
		//IL_0174: Expected O, but got I
		//IL_0183: Unknown result type (might be due to invalid IL or missing references)
		//IL_0188: Expected O, but got Unknown
		//IL_01a0: Expected I, but got O
		//IL_01e0: Expected O, but got I4
		//IL_012c: Expected O, but got I4
		//IL_0135: Expected O, but got I4
		//IL_0303: Expected O, but got I
		//IL_0310: Expected O, but got I
		//IL_031f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0324: Expected O, but got Unknown
		//IL_0334: Expected O, but got I
		//IL_0344: Expected O, but got I
		//IL_0366: Expected O, but got I4
		//IL_036f: Expected O, but got I4
		//IL_02b6: Expected O, but got I4
		//IL_0227: Expected O, but got I4
		//IL_038c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0391: Expected O, but got Unknown
		//IL_03a7: Expected O, but got I
		//IL_03b8: Expected I, but got O
		//IL_03d6: Expected O, but got I
		//IL_03f1: Expected O, but got I4
		//IL_0257: Expected O, but got I
		object obj = 152981504;
		object obj2 = typeof(MemberAchievementClanFeedData) + 2976;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [91E5E8C]");
		object obj3 = (nint)0 & (nint)1;
		if (obj3 != null)
		{
			object obj4 = obj2;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v67 @ X0_v28+E4]");
			if ((nint)0 != 0)
			{
				goto IL_007d;
			}
		}
		else
		{
			_ = 1;
			object obj4 = obj2;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v67 @ X0_v28+E4]");
			bool flag = (nint)0 == 0;
			object obj5 = !flag;
			if (obj5 != null)
			{
				goto IL_007d;
			}
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		bool flag2 = textMesh == null;
		bool flag3 = !flag2;
		object obj6 = !flag3;
		object obj7 = 0;
		UnityEngine.Object obj8 = null;
		if (obj6 != null)
		{
			return;
		}
		goto IL_0148;
		IL_0148:
		object obj9 = typeof(Func<AndroidJavaObject, IList<HWLocation>>) + 2600;
		object obj10 = (nint)0 + (nint)3144;
		object obj11 = (nint)0 + (nint)3728;
		object obj12 = typeof(SkeletonBinary.SkeletonInput) + 2776;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
		Func<object, object> func = default(Func<object, object>);
		func..ctor((object)null, (IntPtr)obj10);
		IEnumerable<object> source = Enumerable.Select(arguments, func);
		object obj13 = obj12;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v183 @ X0_v7+E4]");
		bool flag4 = (nint)0 == 0;
		object obj14 = !flag4;
		if (obj14 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			obj13 = obj12;
		}
		object obj15 = (nint)0 + (nint)72;
		object obj16 = (nint)0 + (nint)1400;
		object obj17 = typeof(Newtonsoft.Json.Linq.JsonPath.JPath) + 2656;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v183 @ X0_v7+B8]");
		object obj18 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v226 @ X8_v9+8]");
		Func<object, object> selector = (Func<object, object>)0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v226 @ X8_v9+8]");
		bool flag5 = (nint)0 == 0;
		object obj19 = !flag5;
		object obj20 = 0;
		if (obj19 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v183 @ X0_v7+E4]");
			bool flag6 = (nint)0 == 0;
			object obj21 = !flag6;
			if (obj21 == null)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
				object obj22 = obj12;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v237 @ X8_v15+B8]");
				obj18 = 0;
			}
			object obj23 = typeof(Func<AndroidJavaObject, IList<HWLocation>>) + 3640;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
			object obj24 = (nint)0 + (nint)2952;
			Func<object, object> func2 = default(Func<object, object>);
			func2..ctor(obj18, (IntPtr)obj24);
			object obj25 = obj12;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v214 @ X8_v14+B8]");
			object obj26 = (nint)0 + (nint)8;
			obj26 = func2;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
			obj20 = 0;
			selector = func2;
		}
		IEnumerable<object> source2 = Enumerable.Select(source, selector);
		IEnumerable<object> source3 = Enumerable.Cast<object>(source2);
		object[] formattedArguments = Enumerable.ToArray(source3);
		object obj27 = obj17;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v249 @ X0_v13+E4]");
		bool flag7 = (nint)0 == 0;
		object obj28 = !flag7;
		if (obj28 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		}
		string text2 = LocalizationUtil.Localize(text, formattedArguments);
		FixArabic(textMesh, text2);
		return;
		IL_007d:
		bool flag8 = textMesh == null;
		bool flag9 = !flag8;
		obj7 = 0;
		obj8 = null;
		if (!flag9)
		{
			return;
		}
		goto IL_0148;
	}

	public static void LocalizeOrdinal(TextMeshProUGUI textMesh, string text, int order)
	{
		//IL_0009: Expected O, but got I4
		//IL_0018: Unknown result type (might be due to invalid IL or missing references)
		//IL_001d: Expected O, but got Unknown
		//IL_0033: Expected O, but got I
		//IL_00e7: Expected O, but got I4
		//IL_00a3: Expected O, but got I4
		//IL_0157: Unknown result type (might be due to invalid IL or missing references)
		//IL_015c: Expected O, but got Unknown
		//IL_0186: Expected O, but got I4
		//IL_012c: Expected O, but got I4
		//IL_0135: Expected O, but got I4
		object obj = 152981504;
		object obj2 = typeof(MemberAchievementClanFeedData) + 2976;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [91E5E8D]");
		object obj3 = (nint)0 & (nint)1;
		if (obj3 != null)
		{
			object obj4 = obj2;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v59 @ X0_v8+E4]");
			if ((nint)0 != 0)
			{
				goto IL_007d;
			}
		}
		else
		{
			_ = 1;
			object obj4 = obj2;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v59 @ X0_v8+E4]");
			bool flag = (nint)0 == 0;
			object obj5 = !flag;
			if (obj5 != null)
			{
				goto IL_007d;
			}
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		bool flag2 = textMesh == null;
		bool flag3 = !flag2;
		object obj6 = !flag3;
		object obj7 = 0;
		UnityEngine.Object obj8 = null;
		if (obj6 != null)
		{
			return;
		}
		goto IL_0148;
		IL_0148:
		object obj9 = typeof(Newtonsoft.Json.Linq.JsonPath.JPath) + 2656;
		object obj10 = obj9;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v95 @ X0_v2+E4]");
		bool flag4 = (nint)0 == 0;
		object obj11 = !flag4;
		if (obj11 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		}
		string text2 = LocalizationUtil.LocalizeOrdinal(text, order);
		FixArabic(textMesh, text2);
		return;
		IL_007d:
		bool flag5 = textMesh == null;
		bool flag6 = !flag5;
		obj7 = 0;
		obj8 = null;
		if (!flag6)
		{
			return;
		}
		goto IL_0148;
	}

	public static void FixArabic(TextMeshProUGUI textMesh, string text)
	{
		//IL_000f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0014: Expected O, but got Unknown
		//IL_002a: Expected O, but got I
		//IL_0107: Expected O, but got I4
		//IL_00ad: Expected I, but got O
		//IL_00bd: Expected O, but got I
		//IL_00cd: Expected O, but got I
		//IL_014b: Expected O, but got I4
		object obj = typeof(Newtonsoft.Json.Linq.JsonPath.JPath) + 2656;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [91E5E8E]");
		object obj2 = (nint)0 & (nint)1;
		if (obj2 == null)
		{
			goto IL_00d7;
		}
		object obj3 = obj;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v53 @ X0_v3+E4]");
		if ((nint)0 != 0)
		{
			goto IL_0074;
		}
		goto IL_0115;
		IL_0115:
		Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		bool isRightToLeftText = LocalizationUtil.ShouldFixArabic(text);
		bool flag = (object)textMesh == null;
		object obj4 = !flag;
		if (obj4 == null)
		{
			throw new NullReferenceException();
		}
		goto IL_0086;
		IL_0074:
		isRightToLeftText = LocalizationUtil.ShouldFixArabic(text);
		goto IL_0086;
		IL_0086:
		textMesh.isRightToLeftText = isRightToLeftText;
		string text2 = LocalizationUtil.FixArabic(text);
		nint num = (nint)textMesh;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v81 @ X8_v7 (Il2CppClass<TMPro.TextMeshProUGUI>)+558]");
		object obj5 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v81 @ X8_v7 (Il2CppClass<TMPro.TextMeshProUGUI>)+560]");
		object obj6 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Indirect jump: v82 @ X3_v1 (should have been resolved before IL gen)");
		goto IL_00d7;
		IL_00d7:
		_ = 1;
		obj3 = obj;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v53 @ X0_v3+E4]");
		bool flag2 = (nint)0 == 0;
		object obj7 = !flag2;
		if (obj7 != null)
		{
			goto IL_0074;
		}
		goto IL_0115;
	}

	public static void SetNumber(TextMeshProUGUI textMesh, int number, bool useCommas = false, bool includeSign = false, bool percentage = false)
	{
		//IL_000a: Unknown result type (might be due to invalid IL or missing references)
		//IL_000f: Expected O, but got Unknown
		//IL_0019: Unknown result type (might be due to invalid IL or missing references)
		//IL_001e: Expected O, but got Unknown
		//IL_0034: Expected O, but got I
		//IL_00ed: Expected O, but got I4
		//IL_006b: Expected O, but got I4
		//IL_00b2: Expected O, but got I4
		//IL_040c: Expected O, but got I4
		//IL_0176: Unknown result type (might be due to invalid IL or missing references)
		//IL_017b: Expected O, but got Unknown
		//IL_0128: Unknown result type (might be due to invalid IL or missing references)
		//IL_012d: Expected O, but got Unknown
		//IL_01b3: Unknown result type (might be due to invalid IL or missing references)
		//IL_01b8: Expected O, but got Unknown
		//IL_01c1: Unknown result type (might be due to invalid IL or missing references)
		//IL_01c6: Expected O, but got Unknown
		//IL_01f2: Expected O, but got I8
		//IL_0218: Unknown result type (might be due to invalid IL or missing references)
		//IL_021d: Expected O, but got Unknown
		//IL_0251: Expected O, but got I4
		//IL_0267: Expected O, but got I
		//IL_0287: Unknown result type (might be due to invalid IL or missing references)
		//IL_028c: Expected O, but got Unknown
		//IL_02a4: Unknown result type (might be due to invalid IL or missing references)
		//IL_02a9: Expected O, but got Unknown
		//IL_02b2: Unknown result type (might be due to invalid IL or missing references)
		//IL_02b7: Expected O, but got Unknown
		//IL_02e3: Expected O, but got I8
		//IL_0309: Unknown result type (might be due to invalid IL or missing references)
		//IL_030e: Expected O, but got Unknown
		//IL_0342: Expected O, but got I4
		//IL_0358: Expected O, but got I
		//IL_0378: Unknown result type (might be due to invalid IL or missing references)
		//IL_037d: Expected O, but got Unknown
		//IL_0395: Unknown result type (might be due to invalid IL or missing references)
		//IL_039a: Expected O, but got Unknown
		//IL_03a3: Unknown result type (might be due to invalid IL or missing references)
		//IL_03a8: Expected O, but got Unknown
		object obj = " SDK from working.  If you would like to change it's implementation please override StartVivoxUnity method in " + 3192;
		object obj2 = ", stale={0}" + 3424;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [91E5E8F]");
		object obj3 = (nint)0 & (nint)1;
		bool flag2 = default(bool);
		string text;
		string text2;
		if (obj3 != null)
		{
			bool flag = !flag2;
			object obj4 = !flag;
			object obj5 = ~obj4;
			object obj6 = ((obj5 != null) ? obj2 : obj);
			text = (string)obj6;
			bool flag3 = !percentage;
			object obj7 = !flag3;
			text2 = (string)obj6;
			if (obj7 == null)
			{
				goto IL_009c;
			}
		}
		else
		{
			_ = 1;
			bool flag4 = !flag2;
			object obj8 = !flag4;
			object obj9 = ~obj8;
			object obj10 = ((obj9 != null) ? obj2 : obj);
			text = (string)obj10;
			bool flag5 = !percentage;
			text2 = (string)obj10;
			if (flag5)
			{
				goto IL_009c;
			}
		}
		object obj11 = "[{0}]:{1}" + 64;
		string text3 = text2 + (string)obj11;
		bool flag6 = !includeSign;
		text = text3;
		string text4 = text3;
		if (!flag6)
		{
			goto IL_0167;
		}
		goto IL_0422;
		IL_009c:
		bool flag7 = !includeSign;
		object obj12 = !flag7;
		if (obj12 != null)
		{
			goto IL_0167;
		}
		text4 = text;
		goto IL_0422;
		IL_0422:
		int num = default(int);
		string text5 = num.ToString(text4);
		FixArabic(textMesh, text5);
		return;
		IL_0167:
		object obj13 = typeof(SqlSingle[]) + 32;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC18B4");
		string[] array = default(string[]);
		if (array.Length != 0)
		{
			object obj14 = "&action=sign-up" + 3352;
			object obj15 = array + 32;
			obj15 = obj14;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v248 @ X22_v7-8]");
			object obj16 = 0 & 0xFFFFFFFEL;
			if (obj16 != null)
			{
				object obj17 = array + 40;
				obj17 = text;
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v280 @ X22_v9-10]");
				bool flag8 = (nint)0 < (nint)2;
				object obj18 = !flag8;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v280 @ X22_v9-10]");
				object obj19 = -2;
				bool flag9 = obj19 == null;
				object obj20 = ~obj18;
				object obj21 = obj20 | flag9;
				if (obj21 == null)
				{
					object obj22 = "1.2.840.113549.1.12.1.5" + 2080;
					object obj23 = array + 48;
					obj23 = obj22;
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v281 @ X22_v11-18]");
					object obj24 = 0 & 0xFFFFFFFCL;
					if (obj24 != null)
					{
						object obj25 = array + 56;
						obj25 = text;
						Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v189 @ X22_v13-20]");
						bool flag10 = (nint)0 < (nint)4;
						object obj26 = !flag10;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v189 @ X22_v13-20]");
						object obj27 = -4;
						bool flag11 = obj27 == null;
						object obj28 = ~obj26;
						object obj29 = obj28 | flag11;
						if (obj29 == null)
						{
							object obj30 = "1.2.840.113549.1.12.1.5" + 2096;
							object obj31 = array + 64;
							obj31 = obj30;
							Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
							string text6 = string.Concat(array);
							text4 = text6;
							goto IL_0422;
						}
					}
				}
			}
		}
		IndexOutOfRangeException ex = new IndexOutOfRangeException();
		throw new NullReferenceException();
	}

	private static string GetPrefixes(bool isSubscribed, bool isVerified)
	{
		//IL_000a: Unknown result type (might be due to invalid IL or missing references)
		//IL_000f: Expected O, but got Unknown
		//IL_0019: Unknown result type (might be due to invalid IL or missing references)
		//IL_001e: Expected O, but got Unknown
		//IL_002a: Expected O, but got I
		//IL_0070: Expected O, but got I4
		//IL_00a1: Expected O, but got I4
		object obj = "<ds.DataTable.OnColumnChanging|INFO> {0}" + 672;
		object obj2 = "<ds.DataTable.OnColumnChanging|INFO> {0}" + 664;
		object obj3 = (nint)0 + (nint)3072;
		bool flag = !isSubscribed;
		object obj4 = !flag;
		object obj5 = ~obj4;
		object result = ((obj5 != null) ? obj3 : obj2);
		bool flag2 = !isVerified;
		object obj6 = !flag2;
		object obj7 = ~obj6;
		if (obj7 == null)
		{
			result = obj;
		}
		return (string)result;
	}

	public static void SetUsername(TextMeshProUGUI textMesh, string username, bool isSubscribed, bool isVerified, string nickName = null)
	{
		//IL_0014: Unknown result type (might be due to invalid IL or missing references)
		//IL_0019: Expected O, but got Unknown
		//IL_007b: Expected O, but got I4
		//IL_00af: Expected O, but got I
		//IL_040d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0412: Expected O, but got Unknown
		//IL_041b: Expected O, but got I4
		//IL_0425: Unknown result type (might be due to invalid IL or missing references)
		//IL_042a: Expected O, but got Unknown
		//IL_0434: Unknown result type (might be due to invalid IL or missing references)
		//IL_0439: Expected O, but got Unknown
		//IL_0445: Expected O, but got I
		//IL_045b: Expected O, but got I
		//IL_023c: Expected O, but got I4
		//IL_016c: Expected O, but got I4
		//IL_0185: Expected O, but got I4
		//IL_02fa: Expected O, but got I4
		//IL_01c5: Expected O, but got I4
		//IL_0298: Expected O, but got I4
		//IL_02b1: Expected O, but got I4
		//IL_02c2: Expected O, but got I4
		//IL_035b: Expected O, but got I4
		//IL_0492: Expected O, but got I4
		//IL_04c2: Expected I, but got O
		//IL_04d2: Expected O, but got I
		//IL_04e2: Expected O, but got I
		object obj = typeof(System.Formats.Asn1.SetOfValueComparer) + 2536;
		textMesh.isRightToLeftText = true;
		object obj2 = obj;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v71 @ X0_v4+E4]");
		string text3;
		string text2;
		bool flag3;
		string text;
		if ((nint)0 != 0)
		{
			bool flag = string.IsNullOrEmpty(nickName);
			bool flag2 = !flag;
			object obj3 = !flag2;
			flag3 = isVerified;
			text = null;
			text2 = null;
			text3 = username;
			if (obj3 == null)
			{
				goto IL_00a3;
			}
		}
		else
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			if (!string.IsNullOrEmpty(nickName))
			{
				goto IL_00a3;
			}
			flag3 = isVerified;
			text = null;
			text2 = null;
			text3 = username;
		}
		goto IL_03fe;
		IL_02d0:
		object obj4 = obj;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v243 @ X0_v13+E4]");
		bool flag4 = (nint)0 == 0;
		object obj5 = !flag4;
		if (obj5 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		}
		string text4 = StringsExtensions.Reverse(text3);
		string text6;
		string text5 = text6;
		string text8;
		string text7 = text8;
		string text10;
		string text9 = text10;
		goto IL_0341;
		IL_0147:
		bool flag5 = LocalizationUtil.ShouldFixArabic(text3);
		bool flag6 = !flag5;
		object obj6 = 0;
		text6 = text5;
		text8 = text7;
		object obj7 = 0;
		text10 = text9;
		if (!flag6)
		{
			goto IL_019b;
		}
		goto IL_02d0;
		IL_0341:
		bool flag7 = !isSubscribed;
		object obj8 = !flag7;
		object obj9 = ~obj8;
		string text11 = ((obj9 != null) ? text5 : text7);
		bool flag8 = !isVerified;
		object obj10 = !flag8;
		object obj11 = ~obj10;
		string text12 = ((obj11 != null) ? text11 : text9);
		string text13 = text12 + text4;
		nint num = (nint)textMesh;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v129 @ X8_v8 (Il2CppClass<TMPro.TextMeshProUGUI>)+558]");
		object obj12 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v129 @ X8_v8 (Il2CppClass<TMPro.TextMeshProUGUI>)+560]");
		object obj13 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Indirect jump: v119 @ X3_v2 (should have been resolved before IL gen)");
		/*Error: End of method reached without returning.*/;
		IL_00a3:
		object obj14 = (nint)0 + (nint)3488;
		text2 = (string)obj14;
		string text14 = nickName + (string)obj14 + username;
		flag3 = false;
		text = username;
		text3 = text14;
		goto IL_03fe;
		IL_03fe:
		object obj15 = typeof(Newtonsoft.Json.Linq.JsonPath.JPath) + 2656;
		object obj16 = 152981504;
		object obj17 = "<ds.DataTable.OnColumnChanging|INFO> {0}" + 672;
		object obj18 = "<ds.DataTable.OnColumnChanging|INFO> {0}" + 664;
		object obj19 = (nint)0 + (nint)3072;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [91E5F98]");
		object obj20 = (nint)0 & (nint)1;
		if (obj20 != null)
		{
			text9 = (string)obj17;
			text7 = (string)obj18;
			text5 = (string)obj19;
			object obj21 = obj15;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v208 @ X0_v18+E4]");
			bool flag9 = (nint)0 == 0;
			text6 = (string)obj19;
			text8 = (string)obj18;
			text10 = (string)obj17;
			if (!flag9)
			{
				goto IL_0147;
			}
		}
		else
		{
			_ = 1;
			text9 = (string)obj17;
			text7 = (string)obj18;
			text5 = (string)obj19;
			object obj21 = obj15;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v208 @ X0_v18+E4]");
			bool flag10 = (nint)0 == 0;
			object obj22 = !flag10;
			text6 = (string)obj19;
			text8 = (string)obj18;
			text10 = (string)obj17;
			if (obj22 != null)
			{
				goto IL_0147;
			}
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		bool flag11 = LocalizationUtil.ShouldFixArabic(text3);
		bool flag12 = !flag11;
		object obj23 = !flag12;
		text5 = text6;
		text7 = text8;
		obj6 = 0;
		text9 = text10;
		obj7 = 0;
		if (obj23 != null)
		{
			goto IL_019b;
		}
		goto IL_02d0;
		IL_019b:
		object obj24 = obj15;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v232 @ X0_v33+E4]");
		bool flag13 = (nint)0 == 0;
		object obj25 = !flag13;
		if (obj25 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		}
		text4 = LocalizationUtil.FixArabic(text3);
		goto IL_0341;
	}

	public static void SetPriceText(TextMeshProUGUI text, int price, bool useCommas = false, bool animate = false)
	{
		//IL_000a: Unknown result type (might be due to invalid IL or missing references)
		//IL_000f: Expected O, but got Unknown
		//IL_0019: Unknown result type (might be due to invalid IL or missing references)
		//IL_001e: Expected O, but got Unknown
		//IL_0129: Expected O, but got I4
		//IL_00d5: Expected O, but got I
		//IL_004c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0051: Expected O, but got Unknown
		//IL_007b: Expected O, but got I4
		object obj = " SDK from working.  If you would like to change it's implementation please override StartVivoxUnity method in " + 3200;
		object obj2 = ", stale={0}" + 3720;
		bool flag = !useCommas;
		object obj3 = !flag;
		object obj4 = ~obj3;
		object obj5 = ((obj4 != null) ? obj2 : obj);
		if (animate)
		{
			object obj6 = typeof(SqlSingle[]) + 3912;
			object obj7 = obj6;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v85 @ X0_v7+E4]");
			bool flag2 = (nint)0 == 0;
			object obj8 = !flag2;
			if (obj8 == null)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			}
			Tweener tweener = AnimationExtensions.DONumber(text, price, 0.3f, (string)obj5);
		}
		else
		{
			int num = default(int);
			string text2 = num.ToString((string)obj5);
			object obj9 = (nint)0 + (nint)2000;
			string text3 = (string)((text2 != null) ? text2 : obj9);
			text.text = text3;
		}
	}

	public static string SanitizeHasCharacter(TextMeshProUGUI input, string text)
	{
		//IL_0019: Unknown result type (might be due to invalid IL or missing references)
		//IL_001e: Expected O, but got Unknown
		//IL_015f: Expected I, but got O
		//IL_016f: Expected O, but got I
		//IL_017f: Expected O, but got I
		//IL_01b6: Expected O, but got I4
		//IL_0098: Expected O, but got I4
		//IL_0108: Expected O, but got I4
		//IL_0140: Expected O, but got I4
		if (string.IsNullOrEmpty(text))
		{
			return text;
		}
		object obj = typeof(System.Formats.Asn1.SetOfValueComparer) + 2344;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
		StringBuilder stringBuilder = default(StringBuilder);
		stringBuilder..ctor(text._stringLength);
		int num2 = default(int);
		object obj4;
		bool flag5;
		if (text._stringLength >= 1)
		{
			if ((object)input == null)
			{
				char c = text.get_Chars(0);
				return (string)(object)new NullReferenceException();
			}
			bool flag = stringBuilder == null;
			object obj2 = !flag;
			int num = 0;
			num2 = 0;
			if (obj2 != null)
			{
				goto IL_01cd;
			}
			bool flag4;
			do
			{
				char character = text.get_Chars(num);
				bool flag2 = ((TMP_Text)input).m_fontAsset.HasCharacter(character);
				bool flag3 = !flag2;
				object obj3 = !flag3;
				if (obj3 == null)
				{
					num++;
					flag4 = num < text._stringLength;
					obj4 = 0;
					flag5 = false;
					continue;
				}
				throw new NullReferenceException();
			}
			while (flag4);
		}
		goto IL_0157;
		IL_0189:
		num2++;
		bool flag6 = num2 >= text._stringLength;
		obj4 = 0;
		flag5 = false;
		if (flag6)
		{
			goto IL_0157;
		}
		goto IL_01cd;
		IL_01cd:
		char c2 = text.get_Chars(num2);
		if (((TMP_Text)input).m_fontAsset.HasCharacter(c2))
		{
			StringBuilder stringBuilder2 = stringBuilder.Append(c2);
		}
		goto IL_0189;
		IL_0157:
		nint num3 = (nint)stringBuilder;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v127 @ X8_v9 (Il2CppClass<System.Text.StringBuilder>)+168]");
		object obj5 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v127 @ X8_v9 (Il2CppClass<System.Text.StringBuilder>)+170]");
		object obj6 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Indirect jump: v105 @ X2_v6 (should have been resolved before IL gen)");
		goto IL_0189;
	}

	public static void Localize(TextMeshProUGUI textMesh, LocalizableText text)
	{
		//IL_000f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0014: Expected O, but got Unknown
		//IL_002a: Expected O, but got I
		//IL_00de: Expected O, but got I4
		//IL_009a: Expected O, but got I4
		//IL_0123: Expected O, but got I4
		//IL_012c: Expected O, but got I4
		//IL_01a2: Expected O, but got I4
		//IL_020a: Unknown result type (might be due to invalid IL or missing references)
		//IL_020f: Expected O, but got Unknown
		//IL_0232: Unknown result type (might be due to invalid IL or missing references)
		//IL_0237: Expected O, but got Unknown
		//IL_025f: Expected O, but got I
		object obj = typeof(MemberAchievementClanFeedData) + 2976;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [91E5E92]");
		object obj2 = (nint)0 & (nint)1;
		if (obj2 != null)
		{
			object obj3 = obj;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v54 @ X0_v20+E4]");
			if ((nint)0 != 0)
			{
				goto IL_0074;
			}
		}
		else
		{
			_ = 1;
			object obj3 = obj;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v54 @ X0_v20+E4]");
			bool flag = (nint)0 == 0;
			object obj4 = !flag;
			if (obj4 != null)
			{
				goto IL_0074;
			}
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		bool flag2 = textMesh == null;
		bool flag3 = !flag2;
		object obj5 = !flag3;
		object obj6 = 0;
		UnityEngine.Object obj7 = null;
		if (obj5 != null)
		{
			return;
		}
		goto IL_013f;
		IL_013f:
		if (text.LocalizeMode != LocalizableText.Mode.LocalizeArguments)
		{
			if (text.LocalizeMode != LocalizableText.Mode.Localize)
			{
				bool flag4 = text.LocalizeMode == LocalizableText.Mode.FixOnly;
				object obj8 = !flag4;
				if (obj8 != null)
				{
					object obj9 = typeof(Unity.Services.Authentication.Shared.ApiConfiguration) + 656;
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC17CC");
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
					object obj10 = "LAK" + 2224;
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC17CC");
					ArgumentOutOfRangeException ex = default(ArgumentOutOfRangeException);
					string paramName = default(string);
					ex..ctor(paramName);
					object obj11 = (nint)0 + (nint)2008;
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC17CC");
					throw new OutOfMemoryException();
				}
				FixArabic(textMesh, text.Text);
			}
			else
			{
				Localize(textMesh, text.Text, text.Arguments);
			}
		}
		else
		{
			LocalizeArguments(textMesh, text.Text, text.Arguments);
		}
		return;
		IL_0074:
		bool flag5 = textMesh == null;
		bool flag6 = !flag5;
		obj6 = 0;
		obj7 = null;
		if (!flag6)
		{
			return;
		}
		goto IL_013f;
	}

	public static LocalizableText FixOnly(string text)
	{
		//IL_0009: Expected O, but got I4
		//IL_0015: Expected O, but got I
		//IL_002b: Expected O, but got I
		//IL_020a: Expected O, but got I
		//IL_022c: Expected O, but got I4
		//IL_009d: Expected O, but got I
		//IL_00b3: Expected O, but got I
		//IL_00bc: Unknown result type (might be due to invalid IL or missing references)
		//IL_00c1: Expected O, but got Unknown
		//IL_00e0: Expected O, but got I
		//IL_0060: Expected O, but got I
		//IL_02fc: Expected O, but got I4
		//IL_025c: Expected O, but got I
		//IL_026c: Expected O, but got I
		//IL_0282: Expected O, but got I
		//IL_028b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0290: Expected O, but got Unknown
		//IL_02aa: Expected O, but got I4
		//IL_02c2: Expected O, but got I
		//IL_0132: Unknown result type (might be due to invalid IL or missing references)
		//IL_0137: Expected O, but got Unknown
		//IL_0147: Expected O, but got I
		//IL_0157: Expected O, but got I
		//IL_016d: Expected O, but got I
		//IL_0176: Unknown result type (might be due to invalid IL or missing references)
		//IL_017b: Expected O, but got Unknown
		//IL_0195: Expected O, but got I4
		//IL_01c2: Expected O, but got I
		object obj = 152981504;
		object obj2 = (nint)0 + (nint)3232;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [91E5E93]");
		object obj3 = (nint)0 & (nint)1;
		object obj6;
		object obj4;
		if (obj3 != null)
		{
			obj4 = obj2;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v92 @ X20_v6+38]");
			object obj5 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v92 @ X20_v6+38]");
			bool flag = (nint)0 == 0;
			obj6 = obj4;
			if (!flag)
			{
				goto IL_008d;
			}
		}
		else
		{
			_ = 1;
			obj4 = obj2;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v92 @ X20_v6+38]");
			object obj5 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v92 @ X20_v6+38]");
			bool flag2 = (nint)0 == 0;
			object obj7 = !flag2;
			obj6 = obj4;
			if (obj7 != null)
			{
				goto IL_008d;
			}
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @B0CD24");
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v93 @ X20_v2+38]");
		object obj8 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v78 @ X8_v6+10]");
		object obj9 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v78 @ X8_v6+10]");
		object obj10 = (nint)0 + (nint)309;
		object obj11 = obj10 & 1;
		bool flag3 = obj11 == null;
		object obj12 = !flag3;
		obj4 = obj6;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v78 @ X8_v6+10]");
		object obj13 = 0;
		if (obj12 != null)
		{
			goto IL_00f6;
		}
		goto IL_02d0;
		IL_0123:
		object obj14 = typeof(Newtonsoft.Json.Linq.JsonPath.JPath) + 2640;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v92 @ X20_v6+38]");
		object obj15 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v96 @ X8_v12+10]");
		object obj16 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v96 @ X8_v12+10]");
		object obj17 = (nint)0 + (nint)309;
		object obj18 = obj17 & 1;
		bool flag4 = obj18 == null;
		object obj19 = !flag4;
		if (obj19 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @B0CCA4");
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v106 @ X0_v17+B8]");
		object arguments = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
		LocalizableText localizableText = default(LocalizableText);
		localizableText..ctor(text, LocalizableText.Mode.FixOnly, (object[])arguments);
		return localizableText;
		IL_0312:
		Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		obj4 = obj6;
		goto IL_0123;
		IL_00f6:
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v103 @ X0_v1+E4]");
		bool flag5 = (nint)0 == 0;
		obj6 = obj4;
		if (!flag5)
		{
			goto IL_0123;
		}
		goto IL_0312;
		IL_008d:
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v47 @ X8_v18+10]");
		obj9 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v47 @ X8_v18+10]");
		object obj20 = (nint)0 + (nint)309;
		object obj21 = obj20 & 1;
		bool flag6 = obj21 == null;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v47 @ X8_v18+10]");
		obj13 = 0;
		obj6 = obj4;
		if (!flag6)
		{
			goto IL_00f6;
		}
		goto IL_02d0;
		IL_02d0:
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @B0CCA4");
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v103 @ X0_v1+E4]");
		bool flag7 = (nint)0 == 0;
		object obj22 = !flag7;
		obj4 = obj6;
		if (obj22 != null)
		{
			goto IL_0123;
		}
		goto IL_0312;
	}

	public static LocalizableText Localize(string text)
	{
		//IL_0009: Expected O, but got I4
		//IL_0015: Expected O, but got I
		//IL_002b: Expected O, but got I
		//IL_0205: Expected O, but got I
		//IL_0227: Expected O, but got I4
		//IL_009d: Expected O, but got I
		//IL_00b3: Expected O, but got I
		//IL_00bc: Unknown result type (might be due to invalid IL or missing references)
		//IL_00c1: Expected O, but got Unknown
		//IL_00e0: Expected O, but got I
		//IL_0060: Expected O, but got I
		//IL_02f7: Expected O, but got I4
		//IL_0257: Expected O, but got I
		//IL_0267: Expected O, but got I
		//IL_027d: Expected O, but got I
		//IL_0286: Unknown result type (might be due to invalid IL or missing references)
		//IL_028b: Expected O, but got Unknown
		//IL_02a5: Expected O, but got I4
		//IL_02bd: Expected O, but got I
		//IL_0132: Unknown result type (might be due to invalid IL or missing references)
		//IL_0137: Expected O, but got Unknown
		//IL_0147: Expected O, but got I
		//IL_0157: Expected O, but got I
		//IL_016d: Expected O, but got I
		//IL_0176: Unknown result type (might be due to invalid IL or missing references)
		//IL_017b: Expected O, but got Unknown
		//IL_0195: Expected O, but got I4
		//IL_01c2: Expected O, but got I
		object obj = 152981504;
		object obj2 = (nint)0 + (nint)3232;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [91E5E94]");
		object obj3 = (nint)0 & (nint)1;
		object obj6;
		object obj4;
		if (obj3 != null)
		{
			obj4 = obj2;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v92 @ X20_v6+38]");
			object obj5 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v92 @ X20_v6+38]");
			bool flag = (nint)0 == 0;
			obj6 = obj4;
			if (!flag)
			{
				goto IL_008d;
			}
		}
		else
		{
			_ = 1;
			obj4 = obj2;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v92 @ X20_v6+38]");
			object obj5 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v92 @ X20_v6+38]");
			bool flag2 = (nint)0 == 0;
			object obj7 = !flag2;
			obj6 = obj4;
			if (obj7 != null)
			{
				goto IL_008d;
			}
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @B0CD24");
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v93 @ X20_v2+38]");
		object obj8 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v78 @ X8_v6+10]");
		object obj9 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v78 @ X8_v6+10]");
		object obj10 = (nint)0 + (nint)309;
		object obj11 = obj10 & 1;
		bool flag3 = obj11 == null;
		object obj12 = !flag3;
		obj4 = obj6;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v78 @ X8_v6+10]");
		object obj13 = 0;
		if (obj12 != null)
		{
			goto IL_00f6;
		}
		goto IL_02cb;
		IL_0123:
		object obj14 = typeof(Newtonsoft.Json.Linq.JsonPath.JPath) + 2640;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v92 @ X20_v6+38]");
		object obj15 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v96 @ X8_v12+10]");
		object obj16 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v96 @ X8_v12+10]");
		object obj17 = (nint)0 + (nint)309;
		object obj18 = obj17 & 1;
		bool flag4 = obj18 == null;
		object obj19 = !flag4;
		if (obj19 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @B0CCA4");
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v106 @ X0_v17+B8]");
		object arguments = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
		LocalizableText localizableText = default(LocalizableText);
		localizableText..ctor(text, (object[])arguments);
		return localizableText;
		IL_030d:
		Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		obj4 = obj6;
		goto IL_0123;
		IL_00f6:
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v103 @ X0_v1+E4]");
		bool flag5 = (nint)0 == 0;
		obj6 = obj4;
		if (!flag5)
		{
			goto IL_0123;
		}
		goto IL_030d;
		IL_008d:
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v47 @ X8_v18+10]");
		obj9 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v47 @ X8_v18+10]");
		object obj20 = (nint)0 + (nint)309;
		object obj21 = obj20 & 1;
		bool flag6 = obj21 == null;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v47 @ X8_v18+10]");
		obj13 = 0;
		obj6 = obj4;
		if (!flag6)
		{
			goto IL_00f6;
		}
		goto IL_02cb;
		IL_02cb:
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @B0CCA4");
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v103 @ X0_v1+E4]");
		bool flag7 = (nint)0 == 0;
		object obj22 = !flag7;
		obj4 = obj6;
		if (obj22 != null)
		{
			goto IL_0123;
		}
		goto IL_030d;
	}

	public static LocalizableText LocalizeWith(string text, object[] arguments)
	{
		//IL_000f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0014: Expected O, but got Unknown
		object obj = typeof(Newtonsoft.Json.Linq.JsonPath.JPath) + 2640;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
		LocalizableText localizableText = default(LocalizableText);
		localizableText..ctor(text, arguments);
		return localizableText;
	}

	public static LocalizableText LocalizeArguments(string text, object[] arguments)
	{
		//IL_000f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0014: Expected O, but got Unknown
		object obj = typeof(Newtonsoft.Json.Linq.JsonPath.JPath) + 2640;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
		LocalizableText localizableText = default(LocalizableText);
		localizableText..ctor(text, LocalizableText.Mode.LocalizeArguments, arguments);
		return localizableText;
	}

	public static int GetTextAsInt(TMP_Text target)
	{
		//IL_01e7: Expected I4, but got O
		//IL_0039: Unknown result type (might be due to invalid IL or missing references)
		//IL_003e: Expected O, but got Unknown
		//IL_004a: Expected O, but got I
		//IL_0086: Unknown result type (might be due to invalid IL or missing references)
		//IL_008b: Expected O, but got Unknown
		//IL_009a: Unknown result type (might be due to invalid IL or missing references)
		//IL_009f: Expected O, but got Unknown
		//IL_022e: Expected O, but got I4
		//IL_00f0: Unknown result type (might be due to invalid IL or missing references)
		//IL_00f5: Expected O, but got Unknown
		//IL_011f: Expected O, but got I4
		//IL_01a7: Expected O, but got I4
		if ((object)target != null)
		{
			string text = target.text;
			if (text != null)
			{
				object oldValue = " SDK from working.  If you would like to change it's implementation please override StartVivoxUnity method in " + 3912;
				object newValue = (nint)0 + (nint)2000;
				string text2 = text.Replace((string)oldValue, (string)newValue);
				if (text2 != null)
				{
					object oldValue2 = "&action=sign-up" + 3400;
					object obj = typeof(System.Runtime.Remoting.Messaging.CallContextSecurityData) + 3632;
					string text3 = text2.Replace((string)oldValue2, (string)newValue);
					bool flag = !target.m_isRightToLeft;
					string s = text3;
					if (!flag)
					{
						object obj2 = typeof(System.Formats.Asn1.SetOfValueComparer) + 2536;
						object obj3 = obj2;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v162 @ X0_v19+E4]");
						bool flag2 = (nint)0 == 0;
						object obj4 = !flag2;
						if (obj4 == null)
						{
							Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
						}
						string text4 = StringsExtensions.Reverse(text3);
						s = text4;
					}
					object obj5 = obj;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v172 @ X0_v9+E4]");
					bool flag3 = (nint)0 == 0;
					object obj6 = !flag3;
					if (obj6 == null)
					{
						Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
					}
					CultureInfo invariantCulture = CultureInfo.InvariantCulture;
					int result;
					bool flag4 = int.TryParse(s, NumberStyles.Any, invariantCulture, out result);
					bool flag5 = !flag4;
					object obj7 = !flag5;
					object obj8 = ~obj7;
					if (obj8 == null)
					{
						return result;
					}
					return 0;
				}
			}
		}
		NullReferenceException ex = new NullReferenceException();
		return (int)ex;
	}
}

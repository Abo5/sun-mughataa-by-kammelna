using System;
using System.Buffers.Text;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.Data.SqlTypes;
using System.Diagnostics;
using System.Formats.Asn1;
using System.Globalization;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Security.Cryptography;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading;
using Cpp2ILInjected;
using HuaweiMobileServices.Location.Location;
using Kammelna.Server;
using Newtonsoft.Json.Linq.JsonPath;
using Sfs2X.Entities;
using Spine;
using TMPro;
using UnityEngine;
using UnityEngine.InputSystem.XR;
using UnityEngine.Purchasing.Telemetry;

public static class StringUtil
{
	[Serializable]
	private sealed class <>c
	{
		public static readonly <>c <>9;

		public static Func<char, bool> <>9__9_0;

		public static Func<string, float> <>9__21_0;

		static <>c()
		{
			//IL_000f: Unknown result type (might be due to invalid IL or missing references)
			//IL_0014: Expected O, but got Unknown
			object obj = typeof(SkeletonBinary.SkeletonInput) + 1752;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
			object obj2 = default(object);
			obj2..ctor();
			object obj3 = obj;
			object obj4 = obj2;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
		}

		internal bool <IsTashkeel>b__9_0(char c)
		{
			//IL_000f: Expected O, but got I4
			//IL_001f: Expected O, but got I
			//IL_0041: Expected O, but got I4
			//IL_0079: Expected O, but got I4
			object obj = 153100288 + 1024;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v13 @ X8_v2+88]");
			object obj2 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v14 @ X0_v1+E4]");
			bool flag = (nint)0 == 0;
			object obj3 = !flag;
			if (obj3 == null)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			}
			UnicodeCategory unicodeCategory = char.GetUnicodeCategory(c);
			object obj4 = unicodeCategory - 5;
			return obj4 == null;
		}

		internal float <AppendUserParamsWithObfuscation>b__21_0(string a)
		{
			return UnityEngine.Random.value;
		}
	}

	private sealed class <>c__DisplayClass21_0
	{
		public HttpQSCollection queryParams;

		public Dictionary<string, string> dict;

		internal void <AppendUserParamsWithObfuscation>b__1(string k)
		{
			object value = ((Dictionary<object, object>)(object)dict).get_Item((object)k);
			((NameValueCollection)queryParams).set_Item(k, (string)value);
		}
	}

	private static readonly Regex AllowedCharactersRegex;

	private static readonly Regex ValidEmail;

	private static readonly Regex AllowedChars;

	private static readonly Regex StrongChars;

	private static readonly Regex PhoneChars;

	private static readonly Regex TagRegex;

	private static Dictionary<char, char> HI_AR_Map;

	public static bool IsValidEmail(string email)
	{
		//IL_000f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0014: Expected O, but got Unknown
		//IL_002a: Expected O, but got I
		//IL_0107: Expected O, but got I4
		//IL_008c: Expected O, but got I
		//IL_009c: Expected O, but got I
		//IL_018d: Expected I4, but got O
		//IL_013f: Expected O, but got I
		//IL_014f: Expected O, but got I
		//IL_0171: Expected O, but got I4
		object obj = typeof(System.Formats.Asn1.SetOfValueComparer) + 2504;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [91E5F3D]");
		object obj2 = (nint)0 & (nint)1;
		if (obj2 != null)
		{
			object obj3 = obj;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v43 @ X0_v13+E4]");
			bool flag = (nint)0 == 0;
			object obj4 = obj3;
			if (!flag)
			{
				goto IL_007c;
			}
		}
		else
		{
			_ = 1;
			object obj3 = obj;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v43 @ X0_v13+E4]");
			bool flag2 = (nint)0 == 0;
			object obj5 = !flag2;
			object obj4 = obj3;
			if (obj5 != null)
			{
				goto IL_007c;
			}
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		object obj6 = obj;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v77 @ X0_v5+B8]");
		object obj7 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v63 @ X8_v4+8]");
		Regex regex = (Regex)0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v63 @ X8_v4+8]");
		bool flag3 = (nint)0 == 0;
		object obj8 = !flag3;
		if (obj8 != null)
		{
			goto IL_00c1;
		}
		goto IL_017f;
		IL_00c1:
		return regex.IsMatch(email);
		IL_017f:
		NullReferenceException ex = new NullReferenceException();
		return (byte)(int)ex != 0;
		IL_007c:
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v43 @ X0_v13+B8]");
		object obj9 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v49 @ X8_v9+8]");
		regex = (Regex)0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v49 @ X8_v9+8]");
		if ((nint)0 != 0)
		{
			goto IL_00c1;
		}
		goto IL_017f;
	}

	public static bool IsEnglishText(string text)
	{
		//IL_000f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0014: Expected O, but got Unknown
		//IL_0048: Unknown result type (might be due to invalid IL or missing references)
		//IL_004d: Expected O, but got Unknown
		//IL_0077: Expected O, but got I4
		object obj = typeof(System.Buffers.Text.ParserHelpers) + 3920;
		object pattern = "[{0}]:{1}" + 824;
		object obj2 = obj;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v47 @ X0_v2+E4]");
		bool flag = (nint)0 == 0;
		object obj3 = !flag;
		if (obj3 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		}
		return Regex.IsMatch(text, (string)pattern);
	}

	public static bool IsNumber(string text)
	{
		//IL_000f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0014: Expected O, but got Unknown
		//IL_0048: Unknown result type (might be due to invalid IL or missing references)
		//IL_004d: Expected O, but got Unknown
		//IL_0077: Expected O, but got I4
		object obj = typeof(System.Buffers.Text.ParserHelpers) + 3920;
		object pattern = "[{0}]:{1}" + 744;
		object obj2 = obj;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v47 @ X0_v2+E4]");
		bool flag = (nint)0 == 0;
		object obj3 = !flag;
		if (obj3 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		}
		return Regex.IsMatch(text, (string)pattern);
	}

	public static bool IsTashkeel(string text)
	{
		//IL_0009: Expected O, but got I4
		//IL_0018: Unknown result type (might be due to invalid IL or missing references)
		//IL_001d: Expected O, but got Unknown
		//IL_0033: Expected O, but got I
		//IL_011e: Expected O, but got I4
		//IL_0091: Expected O, but got I
		//IL_00a1: Expected O, but got I
		//IL_00b1: Expected O, but got I
		//IL_00d3: Expected O, but got I4
		//IL_0152: Expected O, but got I
		//IL_0162: Expected O, but got I
		//IL_0172: Expected O, but got I
		//IL_0194: Expected O, but got I4
		//IL_01cc: Expected O, but got I4
		//IL_0226: Unknown result type (might be due to invalid IL or missing references)
		//IL_022b: Expected O, but got Unknown
		//IL_0241: Expected O, but got I
		//IL_0252: Expected I, but got O
		//IL_0270: Expected O, but got I
		//IL_01fc: Expected O, but got I
		object obj = 152981504;
		object obj2 = typeof(SkeletonBinary.SkeletonInput) + 1752;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [91E5F3E]");
		object obj3 = (nint)0 & (nint)1;
		object obj4;
		if (obj3 != null)
		{
			obj4 = obj2;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v109 @ X0_v4+E4]");
			bool flag = (nint)0 == 0;
			object obj5 = obj4;
			if (!flag)
			{
				goto IL_0085;
			}
		}
		else
		{
			_ = 1;
			obj4 = obj2;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v109 @ X0_v4+E4]");
			bool flag2 = (nint)0 == 0;
			object obj6 = !flag2;
			object obj5 = obj4;
			if (obj6 != null)
			{
				goto IL_0085;
			}
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		obj4 = obj2;
		object obj7 = (nint)0 + (nint)1824;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v109 @ X0_v4+B8]");
		object obj8 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v119 @ X8_v4+8]");
		Func<char, bool> predicate = (Func<char, bool>)0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v119 @ X8_v4+8]");
		bool flag3 = (nint)0 == 0;
		object obj9 = !flag3;
		object obj10 = obj7;
		if (obj9 == null)
		{
			goto IL_01aa;
		}
		goto IL_0201;
		IL_01aa:
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v109 @ X0_v4+E4]");
		bool flag4 = (nint)0 == 0;
		object obj11 = !flag4;
		if (obj11 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			object obj12 = obj2;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v127 @ X8_v10+B8]");
			obj8 = 0;
		}
		object obj13 = typeof(Func<AndroidJavaObject, IList<HWLocation>>) + 544;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
		object obj14 = (nint)0 + (nint)2016;
		Func<char, bool> func = default(Func<char, bool>);
		func..ctor(obj8, (IntPtr)obj14);
		object obj15 = obj2;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v87 @ X8_v9+B8]");
		object obj16 = (nint)0 + (nint)8;
		obj16 = func;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
		obj10 = obj7;
		predicate = func;
		goto IL_0201;
		IL_0201:
		return Enumerable.All(text, predicate);
		IL_0085:
		obj10 = (nint)0 + (nint)1824;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v109 @ X0_v4+B8]");
		obj8 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v119 @ X8_v4+8]");
		predicate = (Func<char, bool>)0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v119 @ X8_v4+8]");
		bool flag5 = (nint)0 == 0;
		object obj17 = !flag5;
		if (obj17 == null)
		{
			obj7 = obj10;
			goto IL_01aa;
		}
		goto IL_0201;
	}

	public static string HinduToArabicNumber(string text)
	{
		//IL_0009: Expected O, but got I4
		//IL_0018: Unknown result type (might be due to invalid IL or missing references)
		//IL_001d: Expected O, but got Unknown
		//IL_0033: Expected O, but got I
		//IL_01c8: Expected O, but got I4
		//IL_01d1: Expected O, but got I4
		//IL_01da: Expected O, but got I4
		//IL_01eb: Expected O, but got I4
		//IL_01f4: Expected O, but got I4
		//IL_00b9: Expected O, but got I
		//IL_00c9: Expected O, but got I
		//IL_0078: Expected O, but got I4
		//IL_0081: Expected O, but got I4
		//IL_0092: Expected O, but got I4
		//IL_009b: Expected O, but got I4
		//IL_0286: Expected O, but got I4
		//IL_0224: Expected O, but got I
		//IL_0234: Expected O, but got I
		//IL_0256: Expected O, but got I4
		//IL_00fb: Expected O, but got I
		//IL_0107: Expected O, but got I
		//IL_0311: Expected I, but got O
		//IL_0131: Expected O, but got I4
		//IL_02bb: Expected I, but got O
		//IL_0155: Expected I4, but got O
		//IL_015e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0163: Expected I4, but got Unknown
		object obj = 152981504;
		object obj2 = typeof(System.Formats.Asn1.SetOfValueComparer) + 2504;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [91E5F3F]");
		object obj3 = (nint)0 & (nint)1;
		object obj5;
		object obj7;
		Dictionary<char, char>.Enumerator enumerator;
		if (obj3 != null)
		{
			object obj4 = obj2;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v46 @ X0_v54+E4]");
			bool flag = (nint)0 == 0;
			obj5 = 0;
			enumerator = (Dictionary<char, char>.Enumerator)0;
			object obj6 = obj4;
			obj7 = 0;
			enumerator = (Dictionary<char, char>.Enumerator)0;
			if (!flag)
			{
				goto IL_00a9;
			}
		}
		else
		{
			_ = 1;
			object obj4 = obj2;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v46 @ X0_v54+E4]");
			bool flag2 = (nint)0 == 0;
			object obj8 = !flag2;
			obj5 = 0;
			enumerator = (Dictionary<char, char>.Enumerator)0;
			object obj6 = obj4;
			obj7 = 0;
			enumerator = (Dictionary<char, char>.Enumerator)0;
			if (obj8 != null)
			{
				goto IL_00a9;
			}
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		object obj9 = obj2;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v97 @ X0_v19+B8]");
		object obj10 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v79 @ X8_v5+30]");
		Dictionary<char, char> dictionary = (Dictionary<char, char>)0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v79 @ X8_v5+30]");
		bool flag3 = (nint)0 == 0;
		object obj11 = !flag3;
		obj5 = obj7;
		if (obj11 != null)
		{
			goto IL_00ee;
		}
		goto IL_026c;
		IL_028b:
		NullReferenceException ex = new NullReferenceException();
		nint num = default(nint);
		bool flag4 = num != 1;
		NullReferenceException ex2 = ex;
		object obj12;
		Dictionary<char, char>.Enumerator enumerator2;
		string result;
		if (!flag4)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @6CB0B80");
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @6CB0BB0");
			num = (nint)obj12;
			enumerator2.Dispose();
			object obj13 = default(object);
			bool flag5 = obj13 == null;
			result = null;
			if (flag5)
			{
				goto IL_0193;
			}
			OutOfMemoryException ex3 = new OutOfMemoryException();
			object obj14 = obj13;
			ex2 = (NullReferenceException)(object)ex3;
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @22370B8");
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @6CB03A0");
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2B060");
		string result2 = default(string);
		return result2;
		IL_0193:
		return result;
		IL_00ee:
		object obj15 = (nint)0 + (nint)1040;
		obj12 = (nint)0 + (nint)1032;
		Dictionary<char, char>.Enumerator enumerator3 = dictionary.GetEnumerator();
		string text2 = default(string);
		while (true)
		{
			num = (nint)obj15;
			if (!enumerator.MoveNext())
			{
				break;
			}
			bool flag6 = text2 == null;
			object obj14 = 0;
			enumerator2 = enumerator;
			if (!flag6)
			{
				char newChar = (char)(obj5 >> 16);
				char oldChar = (char)(obj5 & 0xFFFF);
				text2 = text2.Replace(oldChar, newChar);
				continue;
			}
			goto IL_028b;
		}
		enumerator.Dispose();
		result = text2;
		goto IL_0193;
		IL_00a9:
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v46 @ X0_v54+B8]");
		object obj16 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v58 @ X8_v16+30]");
		dictionary = (Dictionary<char, char>)0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v58 @ X8_v16+30]");
		if ((nint)0 != 0)
		{
			goto IL_00ee;
		}
		goto IL_026c;
		IL_026c:
		NullReferenceException ex4 = new NullReferenceException();
		enumerator2 = enumerator;
		obj12 = 152981504;
		goto IL_028b;
	}

	public static bool IsValidPassword(string text)
	{
		//IL_000f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0014: Expected O, but got Unknown
		//IL_002a: Expected O, but got I
		//IL_0101: Expected O, but got I4
		//IL_008c: Expected O, but got I
		//IL_009c: Expected O, but got I
		//IL_00be: Expected O, but got I4
		//IL_0197: Expected O, but got I
		//IL_0139: Expected O, but got I
		//IL_0149: Expected O, but got I
		//IL_025a: Expected I4, but got O
		//IL_01d1: Expected O, but got I
		object obj = typeof(System.Formats.Asn1.SetOfValueComparer) + 2504;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [91E5F40]");
		object obj2 = (nint)0 & (nint)1;
		if (obj2 != null)
		{
			object obj3 = obj;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v43 @ X0_v18+E4]");
			bool flag = (nint)0 == 0;
			object obj4 = obj3;
			if (!flag)
			{
				goto IL_007c;
			}
		}
		else
		{
			_ = 1;
			object obj3 = obj;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v43 @ X0_v18+E4]");
			bool flag2 = (nint)0 == 0;
			object obj5 = !flag2;
			object obj4 = obj3;
			if (obj5 != null)
			{
				goto IL_007c;
			}
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		object obj6 = obj;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v68 @ X0_v12+B8]");
		object obj7 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v64 @ X8_v7+10]");
		Regex regex = (Regex)0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v64 @ X8_v7+10]");
		if ((nint)0 != 0)
		{
			goto IL_016e;
		}
		goto IL_024c;
		IL_024c:
		NullReferenceException ex = new NullReferenceException();
		return (byte)(int)ex != 0;
		IL_016e:
		Match match = regex.Match(text);
		object obj8 = obj;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v87 @ X8_v4+B8]");
		object obj9 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v83 @ X8_v5+18]");
		if ((nint)0 != 0)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v83 @ X8_v5+18]");
			Match match2 = ((Regex)0).Match(text);
			if (match2 != null)
			{
				bool success = match2.Success;
				if (!success)
				{
					return success;
				}
				if (match != null)
				{
					return match.Success;
				}
			}
		}
		goto IL_024c;
		IL_007c:
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v43 @ X0_v18+B8]");
		object obj10 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v49 @ X8_v11+10]");
		regex = (Regex)0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v49 @ X8_v11+10]");
		bool flag3 = (nint)0 == 0;
		object obj11 = !flag3;
		if (obj11 != null)
		{
			goto IL_016e;
		}
		goto IL_024c;
	}

	public static bool IsValidPhone(string text)
	{
		//IL_000f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0014: Expected O, but got Unknown
		//IL_002a: Expected O, but got I
		//IL_0101: Expected O, but got I4
		//IL_008c: Expected O, but got I
		//IL_009c: Expected O, but got I
		//IL_00be: Expected O, but got I4
		//IL_0139: Expected O, but got I
		//IL_0149: Expected O, but got I
		//IL_01bc: Expected I4, but got O
		object obj = typeof(System.Formats.Asn1.SetOfValueComparer) + 2504;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [91E5F41]");
		object obj2 = (nint)0 & (nint)1;
		if (obj2 != null)
		{
			object obj3 = obj;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v43 @ X0_v14+E4]");
			bool flag = (nint)0 == 0;
			object obj4 = obj3;
			if (!flag)
			{
				goto IL_007c;
			}
		}
		else
		{
			_ = 1;
			object obj3 = obj;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v43 @ X0_v14+E4]");
			bool flag2 = (nint)0 == 0;
			object obj5 = !flag2;
			object obj4 = obj3;
			if (obj5 != null)
			{
				goto IL_007c;
			}
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		object obj6 = obj;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v68 @ X0_v8+B8]");
		object obj7 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v64 @ X8_v5+20]");
		Regex regex = (Regex)0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v64 @ X8_v5+20]");
		if ((nint)0 != 0)
		{
			goto IL_016e;
		}
		goto IL_01ae;
		IL_01ae:
		NullReferenceException ex = new NullReferenceException();
		return (byte)(int)ex != 0;
		IL_016e:
		Match match = regex.Match(text);
		if (match != null)
		{
			return match.Success;
		}
		goto IL_01ae;
		IL_007c:
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v43 @ X0_v14+B8]");
		object obj8 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v49 @ X8_v9+20]");
		regex = (Regex)0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v49 @ X8_v9+20]");
		bool flag3 = (nint)0 == 0;
		object obj9 = !flag3;
		if (obj9 != null)
		{
			goto IL_016e;
		}
		goto IL_01ae;
	}

	public static char NoControlCharsValidationCallback(string text, int index, char addedChar)
	{
		//IL_000f: Expected O, but got I4
		//IL_001f: Expected O, but got I
		//IL_0041: Expected O, but got I4
		//IL_0085: Expected O, but got I4
		object obj = 153100288 + 1024;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v13 @ X8_v2+88]");
		object obj2 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v14 @ X0_v1+E4]");
		bool flag = (nint)0 == 0;
		object obj3 = !flag;
		if (obj3 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		}
		bool flag2 = char.IsControl(addedChar);
		bool flag3 = !flag2;
		object obj4 = !flag3;
		object obj5 = ~obj4;
		if (obj5 == null)
		{
			return '\0';
		}
		return addedChar;
	}

	public static bool IsAllowedChatCharacter(char c)
	{
		//IL_0433: Unknown result type (might be due to invalid IL or missing references)
		//IL_0438: Expected O, but got Unknown
		//IL_0447: Expected O, but got I4
		//IL_0457: Expected O, but got I
		//IL_0479: Expected O, but got I4
		//IL_013f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0144: Expected O, but got Unknown
		//IL_015a: Expected O, but got I
		//IL_0174: Expected O, but got I4
		//IL_00a7: Unknown result type (might be due to invalid IL or missing references)
		//IL_00ac: Expected O, but got Unknown
		//IL_005d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0062: Expected O, but got Unknown
		//IL_0078: Expected O, but got I
		//IL_019a: Unknown result type (might be due to invalid IL or missing references)
		//IL_019f: Expected O, but got Unknown
		//IL_01c9: Expected O, but got I4
		//IL_0221: Expected O, but got I4
		//IL_022a: Expected O, but got I4
		//IL_0112: Expected O, but got I4
		//IL_0247: Unknown result type (might be due to invalid IL or missing references)
		//IL_024c: Expected O, but got Unknown
		//IL_02f1: Expected O, but got I4
		//IL_02fa: Expected O, but got I4
		//IL_029c: Expected O, but got I4
		//IL_02a5: Expected O, but got I4
		//IL_038d: Expected O, but got I4
		//IL_0497: Expected O, but got I
		//IL_02bc: Expected O, but got I4
		//IL_0424: Expected I4, but got O
		//IL_03fa: Expected O, but got I4
		object obj = typeof(System.Formats.Asn1.SetOfValueComparer) + 2504;
		object obj2 = 153100288 + 1024;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v46 @ X8_v4+88]");
		object obj3 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v47 @ X0_v2+E4]");
		bool flag = (nint)0 == 0;
		object obj4 = !flag;
		if (obj4 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		}
		char c2 = default(char);
		string text = c2.ToString();
		object obj5 = obj;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v59 @ X0_v6+E4]");
		object obj6;
		object obj8;
		if ((nint)0 != 0)
		{
			obj6 = typeof(System.Buffers.Text.ParserHelpers) + 3920;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [91E5FDD]");
			object obj7 = (nint)0 & (nint)1;
			bool flag2 = obj7 == null;
			obj8 = obj6;
			if (!flag2)
			{
				goto IL_009d;
			}
		}
		else
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			obj6 = typeof(System.Buffers.Text.ParserHelpers) + 3920;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [91E5FDD]");
			object obj9 = (nint)0 & (nint)1;
			bool flag3 = obj9 == null;
			object obj10 = !flag3;
			obj8 = obj6;
			if (obj10 != null)
			{
				goto IL_009d;
			}
		}
		_ = 1;
		object obj11 = "[{0}]:{1}" + 824;
		object obj12 = obj8;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v109 @ X0_v31+E4]");
		bool flag4 = (nint)0 == 0;
		object obj13 = !flag4;
		object obj14 = obj11;
		if (obj13 != null)
		{
			goto IL_00e1;
		}
		goto IL_01df;
		IL_0238:
		object obj15 = typeof(Newtonsoft.Json.Linq.JsonPath.JPath) + 2656;
		object obj16 = obj15;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v149 @ X0_v8+E4]");
		object obj18;
		if ((nint)0 != 0)
		{
			bool flag5 = LocalizationUtil.HasArabicCharacters(text);
			bool flag6 = !flag5;
			object obj17 = !flag6;
			obj18 = 0;
			if (obj17 != null)
			{
				goto IL_0308;
			}
			object obj19 = 0;
		}
		else
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			bool flag7 = LocalizationUtil.HasArabicCharacters(text);
			bool flag8 = !flag7;
			obj18 = 0;
			object obj19 = 0;
			if (!flag8)
			{
				goto IL_0308;
			}
		}
		goto IL_0363;
		IL_00e1:
		string text2 = (string)obj11;
		bool flag9 = Regex.IsMatch(text, (string)obj11);
		bool flag10 = !flag9;
		object obj20 = 0;
		if (!flag10)
		{
			goto IL_0120;
		}
		goto IL_0238;
		IL_0308:
		object obj21 = obj;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v200 @ X0_v18+E4]");
		if ((nint)0 != 0)
		{
			bool flag11 = IsTashkeel(text);
			bool flag12 = !flag11;
			object obj19 = obj18;
			if (!flag12)
			{
				goto IL_0363;
			}
		}
		else
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			bool flag13 = IsTashkeel(text);
			bool flag14 = !flag13;
			object obj22 = !flag14;
			object obj19 = obj18;
			if (obj22 != null)
			{
				goto IL_0363;
			}
		}
		return true;
		IL_0120:
		return true;
		IL_0363:
		object obj23 = obj;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v216 @ X0_v11+E4]");
		bool flag15 = (nint)0 == 0;
		object obj24 = !flag15;
		if (obj24 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			obj23 = obj;
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v216 @ X0_v11+B8]");
		object obj25 = 0;
		if (obj25 != null)
		{
			return ((Regex)obj25).IsMatch(text);
		}
		NullReferenceException ex = new NullReferenceException();
		return (byte)(int)ex != 0;
		IL_009d:
		obj11 = "[{0}]:{1}" + 824;
		obj12 = obj6;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v109 @ X0_v31+E4]");
		bool flag16 = (nint)0 == 0;
		obj14 = obj11;
		if (!flag16)
		{
			goto IL_00e1;
		}
		goto IL_01df;
		IL_01df:
		Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		text2 = (string)obj14;
		bool flag17 = Regex.IsMatch(text, (string)obj14);
		bool flag18 = !flag17;
		object obj26 = !flag18;
		obj20 = 0;
		if (obj26 != null)
		{
			goto IL_0120;
		}
		goto IL_0238;
	}

	public static string RemoveSurrogate(string text)
	{
		//IL_000f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0014: Expected O, but got Unknown
		//IL_0302: Expected I, but got O
		//IL_0312: Expected O, but got I
		//IL_0322: Expected O, but got I
		//IL_004a: Expected O, but got I4
		//IL_0064: Expected O, but got I4
		//IL_01ff: Expected O, but got I
		//IL_00ba: Expected O, but got I
		//IL_00dc: Expected O, but got I4
		//IL_02a0: Expected O, but got I4
		//IL_01ae: Expected O, but got I4
		//IL_01d8: Expected O, but got I4
		//IL_025f: Expected O, but got I4
		object obj = typeof(System.Formats.Asn1.SetOfValueComparer) + 2344;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
		StringBuilder stringBuilder = default(StringBuilder);
		stringBuilder..ctor();
		if (text != null && text._stringLength >= 1)
		{
			object obj2 = 153100288 + 1024;
			bool flag = stringBuilder == null;
			object obj3 = !flag;
			int num = 0;
			int num2 = 0;
			object obj5 = default(object);
			object obj4 = obj5;
			int num4 = default(int);
			int num3 = num4;
			int num6 = default(int);
			int num5 = num6;
			string text2 = null;
			int num7 = 0;
			if (obj3 == null)
			{
				while (true)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v79 @ X22_v5+88]");
					object obj6 = 0;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v198 @ X0_v20+E4]");
					bool flag2 = (nint)0 == 0;
					object obj7 = !flag2;
					if (obj7 == null)
					{
						Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
					}
					if (!char.IsSurrogate(text, num2))
					{
						break;
					}
					int num8 = num2 + 2;
					bool flag3 = num8 < text._stringLength;
					num = num2;
					num2 = num8;
					if (flag3)
					{
						continue;
					}
					goto IL_02dd;
				}
				goto IL_032c;
			}
			bool flag6;
			do
			{
				IL_01ef:
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v79 @ X22_v5+88]");
				object obj8 = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v217 @ X0_v9+E4]");
				if ((nint)0 != 0)
				{
					if (!char.IsSurrogate(text, num7))
					{
						goto IL_0167;
					}
					num5 = 0;
					text2 = (string)num7;
				}
				else
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
					bool flag4 = char.IsSurrogate(text, num7);
					bool flag5 = !flag4;
					num5 = 0;
					text2 = (string)num7;
					if (flag5)
					{
						goto IL_0167;
					}
				}
				num7 += 2;
				if (num7 >= text._stringLength)
				{
					break;
				}
				goto IL_01ef;
				IL_0167:
				StringBuilder stringBuilder2 = stringBuilder.Append(text, num7, 1);
				int num9 = num7 + 1;
				flag6 = num9 >= text._stringLength;
				obj4 = 0;
				num3 = 1;
				num5 = num7;
				text2 = text;
				num7 = num9;
				obj5 = 0;
				num4 = 1;
			}
			while (!flag6);
		}
		goto IL_02dd;
		IL_032c:
		return (string)(object)new NullReferenceException();
		IL_02dd:
		if (stringBuilder != null)
		{
			nint num10 = (nint)stringBuilder;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v150 @ X8_v5 (Il2CppClass<System.Text.StringBuilder>)+168]");
			object obj9 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v150 @ X8_v5 (Il2CppClass<System.Text.StringBuilder>)+170]");
			object obj10 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Indirect jump: v151 @ X2_v3 (should have been resolved before IL gen)");
		}
		goto IL_032c;
	}

	public static string SanitizeChatMessage(string input)
	{
		//IL_02ff: Expected O, but got I4
		//IL_030f: Expected O, but got I
		//IL_031f: Expected O, but got I
		//IL_0011: Expected O, but got I
		//IL_0020: Unknown result type (might be due to invalid IL or missing references)
		//IL_0025: Expected O, but got Unknown
		//IL_0057: Expected O, but got I4
		//IL_027f: Expected O, but got I4
		//IL_03a1: Expected O, but got I
		//IL_00cf: Expected O, but got I4
		//IL_02bd: Expected O, but got I
		//IL_01f0: Expected O, but got I4
		//IL_018d: Expected O, but got I4
		//IL_0216: Expected O, but got I
		//IL_0238: Expected O, but got I4
		//IL_0119: Expected O, but got I4
		//IL_0121: Expected I, but got O
		if (input != null)
		{
			object obj = (nint)0 + (nint)2000;
			object obj2 = typeof(System.Formats.Asn1.SetOfValueComparer) + 2504;
			string text = (string)obj;
			object obj3 = obj2;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v60 @ X0_v4+E4]");
			bool flag = (nint)0 == 0;
			object obj4 = !flag;
			if (obj4 == null)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			}
			string text2 = RemoveSurrogate(input);
			if (text2 != null)
			{
				if (text2._stringLength >= 1)
				{
					object obj5 = 153100288 + 1024;
					int num = 0;
					string text3 = text;
					char c3 = default(char);
					char c4 = default(char);
					bool flag7;
					do
					{
						char c = text2.get_Chars(num);
						object obj6 = obj2;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v263 @ X8_v15+E4]");
						char c2;
						object obj7;
						nint num2;
						if ((nint)0 != 0)
						{
							bool flag2 = IsAllowedChatCharacter(c);
							bool flag3 = !flag2;
							obj7 = 0;
							num2 = num;
							if (!flag3)
							{
								c2 = c3;
								goto IL_0206;
							}
						}
						else
						{
							Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
							bool flag4 = IsAllowedChatCharacter(c);
							bool flag5 = !flag4;
							c2 = c;
							c3 = c;
							obj7 = 0;
							num2 = num;
							if (!flag5)
							{
								goto IL_0206;
							}
						}
						goto IL_0357;
						IL_0206:
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v210 @ X24_v6+88]");
						object obj8 = 0;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v284 @ X0_v23+E4]");
						bool flag6 = (nint)0 == 0;
						object obj9 = !flag6;
						if (obj9 == null)
						{
							Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
						}
						string text4 = c4.ToString();
						string text5 = text3 + text4;
						c3 = c2;
						obj7 = 0;
						num2 = (nint)text4;
						text3 = text5;
						goto IL_0357;
						IL_0357:
						num++;
						flag7 = num >= text2._stringLength;
						text = text3;
					}
					while (!flag7);
				}
				object obj10 = obj2;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v261 @ X0_v12+E4]");
				bool flag8 = (nint)0 == 0;
				object obj11 = !flag8;
				if (obj11 == null)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
					obj10 = obj2;
				}
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v261 @ X0_v12+B8]");
				object obj12 = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v124 @ X8_v13+28]");
				if ((nint)0 != 0)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v124 @ X8_v13+28]");
					string text6 = ((Regex)0).Replace(text, (string)obj);
					if (text6 != null)
					{
						return text6.Trim();
					}
				}
			}
			return (string)(object)new NullReferenceException();
		}
		object obj13 = 153100288 + 1024;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v65 @ X8_v5+90]");
		object obj14 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v66 @ X8_v6+B8]");
		return (string)0;
	}

	public static string SanitizeChatMessage(string input, TextMeshProUGUI field)
	{
		//IL_022e: Expected O, but got I4
		//IL_023e: Expected O, but got I
		//IL_024e: Expected O, but got I
		//IL_0011: Expected O, but got I
		//IL_0020: Unknown result type (might be due to invalid IL or missing references)
		//IL_0025: Expected O, but got Unknown
		//IL_0057: Expected O, but got I4
		//IL_02ba: Expected O, but got I4
		//IL_03cf: Expected O, but got I
		//IL_00fc: Expected O, but got I4
		//IL_02f8: Expected O, but got I
		//IL_01ba: Expected I, but got O
		//IL_01c2: Expected O, but got I4
		//IL_01e0: Expected O, but got I
		//IL_0202: Expected O, but got I4
		//IL_013a: Expected I, but got O
		object obj;
		object obj2;
		string text;
		string text2;
		string text3;
		if (input != null)
		{
			obj = (nint)0 + (nint)2000;
			obj2 = typeof(System.Formats.Asn1.SetOfValueComparer) + 2504;
			text = (string)obj;
			object obj3 = obj2;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v61 @ X0_v4+E4]");
			bool flag = (nint)0 == 0;
			object obj4 = !flag;
			if (obj4 == null)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			}
			text2 = RemoveSurrogate(input);
			bool flag2 = text2 == null;
			text3 = input;
			if (!flag2)
			{
				if ((object)field != null)
				{
					bool flag3 = text2._stringLength < 1;
					TextMeshProUGUI textMeshProUGUI = field;
					if (!flag3)
					{
						object obj5 = 153100288 + 1024;
						int num = 0;
						string text4 = text;
						char c2 = default(char);
						while (true)
						{
							char c = text2.get_Chars(num);
							bool flag4 = (object)((TMP_Text)field).m_fontAsset == null;
							text3 = text2;
							if (flag4)
							{
								break;
							}
							bool flag5 = ((TMP_Text)field).m_fontAsset.HasCharacter(c);
							bool flag6 = !flag5;
							nint num2 = unchecked((nint)null);
							textMeshProUGUI = (TextMeshProUGUI)c;
							if (!flag6)
							{
								Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v212 @ X25_v7+88]");
								object obj6 = 0;
								Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v295 @ X0_v28+E4]");
								bool flag7 = (nint)0 == 0;
								object obj7 = !flag7;
								if (obj7 == null)
								{
									Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
								}
								string text5 = c2.ToString();
								string text6 = text4 + text5;
								num2 = unchecked((nint)null);
								textMeshProUGUI = (TextMeshProUGUI)(object)text5;
								text4 = text6;
							}
							num++;
							bool flag8 = num >= text2._stringLength;
							text = text4;
							if (!flag8)
							{
								continue;
							}
							goto IL_0290;
						}
						goto IL_0338;
					}
				}
				else
				{
					bool flag9 = text2._stringLength >= 1;
					TextMeshProUGUI textMeshProUGUI = field;
					text3 = text2;
					if (flag9)
					{
						char c3 = text3.get_Chars(0);
						return (string)(object)new NullReferenceException();
					}
				}
				goto IL_0290;
			}
			goto IL_0338;
		}
		object obj8 = 153100288 + 1024;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v66 @ X8_v5+90]");
		object obj9 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v67 @ X8_v6+B8]");
		return (string)0;
		IL_0338:
		throw new NullReferenceException();
		IL_0290:
		object obj10 = obj2;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v290 @ X0_v16+E4]");
		bool flag10 = (nint)0 == 0;
		object obj11 = !flag10;
		if (obj11 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			obj10 = obj2;
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v290 @ X0_v16+B8]");
		object obj12 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v122 @ X8_v14+28]");
		bool flag11 = (nint)0 == 0;
		text3 = text2;
		if (!flag11)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v122 @ X8_v14+28]");
			string text7 = ((Regex)0).Replace(text, (string)obj);
			bool flag12 = text7 == null;
			text3 = text2;
			if (!flag12)
			{
				return text7.Trim();
			}
		}
		goto IL_0338;
	}

	public static string GenerateNonce()
	{
		//IL_000f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0014: Expected O, but got Unknown
		//IL_0020: Expected O, but got I
		Guid guid = Guid.NewGuid();
		Guid guid2 = default(Guid);
		string text = guid2.ToString();
		if (text != null)
		{
			object oldValue = ", stale={0}" + 120;
			object newValue = (nint)0 + (nint)2000;
			return text.Replace((string)oldValue, (string)newValue);
		}
		return (string)(object)new NullReferenceException();
	}

	public unsafe static string GenerateSHA256(string rawNonce)
	{
		//IL_000f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0014: Expected O, but got Unknown
		//IL_00a1: Expected O, but got I4
		//IL_00b1: Expected O, but got I
		//IL_00c1: Expected O, but got I
		//IL_00f2: Unknown result type (might be due to invalid IL or missing references)
		//IL_00f7: Expected O, but got Unknown
		//IL_0100: Unknown result type (might be due to invalid IL or missing references)
		//IL_0105: Expected I4, but got Unknown
		//IL_010e: Expected O, but got I4
		//IL_0172: Unknown result type (might be due to invalid IL or missing references)
		//IL_0177: Expected O, but got Unknown
		object obj = typeof(RegisteredWaitHandle) + 2144;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
		SHA256Managed sHA256Managed = default(SHA256Managed);
		sHA256Managed..ctor();
		Encoding uTF = Encoding.UTF8;
		if (uTF != null)
		{
			byte[] bytes = uTF.GetBytes(rawNonce);
			if (sHA256Managed != null)
			{
				byte[] array = sHA256Managed.ComputeHash(bytes);
				if (array != null)
				{
					object obj2 = 153100288 + 1024;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v132 @ X8_v6+90]");
					object obj3 = 0;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v133 @ X8_v7+B8]");
					object obj4 = 0;
					string result = (string)obj4;
					if (array.Length >= 1)
					{
						object obj5 = "utf-32" + 2272;
						byte b = (byte)(array + 32);
						object obj6 = 0;
						bool flag;
						do
						{
							string text = ((byte*)b)->ToString((string)obj5);
							string text2 = (string)obj4 + text;
							obj6++;
							b++;
							flag = (nint)obj6 < array.Length;
							result = text2;
						}
						while (flag);
					}
					return result;
				}
			}
		}
		return (string)(object)new NullReferenceException();
	}

	public static string AppendUserParamsWithObfuscation(string url)
	{
		//IL_000f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0014: Expected O, but got Unknown
		//IL_0023: Unknown result type (might be due to invalid IL or missing references)
		//IL_0028: Expected O, but got Unknown
		//IL_0095: Unknown result type (might be due to invalid IL or missing references)
		//IL_009a: Expected O, but got Unknown
		//IL_00aa: Unknown result type (might be due to invalid IL or missing references)
		//IL_00af: Expected O, but got Unknown
		//IL_00bb: Expected O, but got I
		//IL_00c7: Expected O, but got I
		//IL_00d3: Expected O, but got I
		//IL_00dc: Unknown result type (might be due to invalid IL or missing references)
		//IL_00e1: Expected O, but got Unknown
		//IL_0114: Unknown result type (might be due to invalid IL or missing references)
		//IL_0119: Expected O, but got Unknown
		//IL_0139: Expected O, but got I4
		//IL_0833: Expected O, but got I4
		//IL_01a8: Unknown result type (might be due to invalid IL or missing references)
		//IL_01ad: Expected O, but got Unknown
		//IL_01ec: Unknown result type (might be due to invalid IL or missing references)
		//IL_01f1: Expected O, but got Unknown
		//IL_021b: Expected O, but got I4
		//IL_0244: Expected O, but got I
		//IL_028c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0291: Expected O, but got Unknown
		//IL_0299: Expected I, but got O
		//IL_02a9: Expected O, but got I
		//IL_0353: Expected O, but got I4
		//IL_03c0: Unknown result type (might be due to invalid IL or missing references)
		//IL_03c5: Expected O, but got Unknown
		//IL_03e2: Expected O, but got I
		//IL_02e4: Expected O, but got I
		//IL_036f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0374: Expected O, but got Unknown
		//IL_037c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0381: Expected O, but got Unknown
		//IL_038a: Unknown result type (might be due to invalid IL or missing references)
		//IL_038f: Expected O, but got Unknown
		//IL_0425: Unknown result type (might be due to invalid IL or missing references)
		//IL_042a: Expected O, but got Unknown
		//IL_0436: Expected O, but got I
		//IL_02f2: Unknown result type (might be due to invalid IL or missing references)
		//IL_02f7: Expected O, but got Unknown
		//IL_0300: Unknown result type (might be due to invalid IL or missing references)
		//IL_0305: Expected O, but got Unknown
		//IL_0448: Unknown result type (might be due to invalid IL or missing references)
		//IL_044d: Expected O, but got Unknown
		//IL_0457: Unknown result type (might be due to invalid IL or missing references)
		//IL_045c: Expected O, but got Unknown
		//IL_0466: Unknown result type (might be due to invalid IL or missing references)
		//IL_046b: Expected O, but got Unknown
		//IL_0475: Unknown result type (might be due to invalid IL or missing references)
		//IL_047a: Expected O, but got Unknown
		//IL_08c9: Unknown result type (might be due to invalid IL or missing references)
		//IL_08ce: Expected O, but got Unknown
		//IL_08f8: Expected O, but got I4
		//IL_04c7: Expected O, but got I
		//IL_055f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0564: Expected O, but got Unknown
		//IL_059e: Expected O, but got I
		//IL_05ba: Unknown result type (might be due to invalid IL or missing references)
		//IL_05bf: Expected O, but got Unknown
		//IL_0683: Expected O, but got I
		//IL_0693: Expected O, but got I
		//IL_06b5: Expected O, but got I4
		//IL_06d5: Expected O, but got I
		//IL_0912: Expected O, but got I
		//IL_0932: Unknown result type (might be due to invalid IL or missing references)
		//IL_0937: Expected O, but got Unknown
		//IL_0952: Expected I, but got O
		//IL_05fc: Expected O, but got I
		//IL_060c: Expected O, but got I
		//IL_062e: Expected O, but got I4
		//IL_076c: Expected O, but got I
		//IL_0705: Expected O, but got I4
		//IL_0966: Unknown result type (might be due to invalid IL or missing references)
		//IL_096b: Expected O, but got Unknown
		//IL_0981: Expected O, but got I
		//IL_0992: Expected I, but got O
		//IL_09b0: Expected O, but got I
		//IL_065c: Expected O, but got I
		//IL_07c2: Expected I4, but got I8
		//IL_0735: Expected O, but got I
		object obj = typeof(SkeletonBinary.SkeletonInput) + 1760;
		object obj2 = typeof(UnityEngine.Purchasing.Telemetry.TelemetryMetricsInstanceWrapper) + 4032;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
		object obj3 = default(object);
		obj3..ctor();
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
		UriBuilder uriBuilder = default(UriBuilder);
		uriBuilder..ctor(url);
		if (uriBuilder != null)
		{
			HttpQSCollection httpQSCollection = HttpUtility.ParseQueryString(uriBuilder._query);
			if (obj3 != null)
			{
				object obj4 = typeof(ConditionalWeakTable<System.Net.HttpWebRequest, Mono.Http.NtlmSession>.CreateValueCallback) + 2808;
				object obj5 = typeof(System.Formats.Asn1.SetOfValueComparer) + 2504;
				object obj6 = (nint)0 + (nint)800;
				object obj7 = (nint)0 + (nint)2024;
				object obj8 = (nint)0 + (nint)2360;
				object obj9 = obj3 + 16;
				obj9 = httpQSCollection;
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
				Dictionary<object, object> dictionary = default(Dictionary<object, object>);
				dictionary..ctor();
				object obj10 = obj3 + 24;
				obj10 = dictionary;
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
				object obj11 = 17;
				object obj12 = null;
				Dictionary<object, object> dictionary2 = dictionary;
				SessionModel sessionModel = default(SessionModel);
				object value = default(object);
				SessionModel sessionModel2 = default(SessionModel);
				object obj29 = default(object);
				SessionModel sessionModel3 = default(SessionModel);
				int num2 = default(int);
				Func<object, float> func2 = default(Func<object, float>);
				Action<object> action = default(Action<object>);
				string query = default(string);
				while (true)
				{
					object obj13 = obj5;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v386 @ X0_v19+E4]");
					bool flag = (nint)0 == 0;
					object obj14 = !flag;
					if (obj14 == null)
					{
						Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
					}
					string text = <AppendUserParamsWithObfuscation>g__GetRandomKey|21_2();
					string text2 = <AppendUserParamsWithObfuscation>g__GetRandomValue|21_3();
					if (obj10 == null)
					{
						break;
					}
					((Dictionary<object, object>)obj10).set_Item((object)text, (object)text2);
					obj11--;
					bool flag2 = (nint)obj11 != 1;
					obj12 = text2;
					dictionary2 = (Dictionary<object, object>)(object)text;
					if (flag2)
					{
						continue;
					}
					object obj15 = typeof(Queue<string>) + 848;
					object obj16 = obj15;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v406 @ X0_v23+E4]");
					bool flag3 = (nint)0 == 0;
					object obj17 = !flag3;
					if (obj17 == null)
					{
						Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
					}
					object obj18 = (nint)0 + (nint)2200;
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @3CEC320");
					if ((object)sessionModel == null)
					{
						break;
					}
					User localUser = sessionModel.LocalUser;
					if (localUser == null)
					{
						break;
					}
					object obj19 = typeof(UsageHint) + 8;
					nint num = (nint)localUser;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v431 @ X8_v15 (Il2CppClass<Sfs2X.Entities.User>)+12E]");
					object obj20 = 0;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v431 @ X8_v15 (Il2CppClass<Sfs2X.Entities.User>)+12E]");
					if ((nint)0 == 0)
					{
						goto IL_0325;
					}
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v431 @ X8_v15 (Il2CppClass<Sfs2X.Entities.User>)+B0]");
					object obj21 = (nint)0 + (nint)8;
					while (true)
					{
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v101 @ X10_v6-8]");
						if (0 == (nint)obj19)
						{
							break;
						}
						obj21 += 16;
						obj20--;
						if ((nint)obj20 != 1)
						{
							continue;
						}
						goto IL_0325;
					}
					object obj22 = obj21 + 1;
					object obj23 = num + obj22;
					object obj24 = obj23 + 312;
					Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v465 @ X0_v82] (should have been resolved before IL gen)");
					if (obj10 == null)
					{
						break;
					}
					goto IL_03b6;
					IL_03b6:
					object key = "tournament_participate_warning_body_with_tickets_warning_daily" + 1280;
					((Dictionary<object, object>)obj10).set_Item(key, value);
					object obj25 = (nint)0 + (nint)2200;
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @3CEC320");
					if ((object)sessionModel2 == null)
					{
						break;
					}
					User localUser2 = sessionModel2.LocalUser;
					object obj26 = "setMimeType" + 3808;
					object obj27 = (nint)0 + (nint)360;
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @301F6F0");
					if (obj10 == null)
					{
						break;
					}
					object obj28 = obj29 & 0xFFFFFFFEL;
					object key2 = "rightCtrl" + 768;
					object value2 = "ThisIsFakeReceiptData" + 1984;
					object obj30 = "Error reading data from socket: " + 3616;
					if ((nint)obj28 != 2)
					{
						value2 = obj30;
					}
					((Dictionary<object, object>)obj10).set_Item(key2, value2);
					object obj31 = typeof(Queue<string>) + 848;
					object obj32 = obj31;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v513 @ X0_v37+E4]");
					bool flag4 = (nint)0 == 0;
					object obj33 = !flag4;
					if (obj33 == null)
					{
						Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
					}
					object obj34 = (nint)0 + (nint)2200;
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @3CEC320");
					if ((object)sessionModel3 == null)
					{
						break;
					}
					User localUser3 = sessionModel3.LocalUser;
					PlayerRank rank = SFSKammelnaUserExtensions.GetRank(localUser3);
					if (rank == null)
					{
						break;
					}
					string value3 = num2.ToString();
					if (obj10 == null)
					{
						break;
					}
					object key3 = "placementId" + 2064;
					((Dictionary<object, object>)obj10).set_Item(key3, (object)value3);
					if (obj10 == null)
					{
						break;
					}
					object obj35 = (nint)0 + (nint)792;
					Dictionary<object, object>.KeyCollection keys = ((Dictionary<object, object>)obj10).Keys;
					object obj36 = typeof(SkeletonBinary.SkeletonInput) + 1752;
					object obj37 = obj36;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v571 @ X0_v61+E4]");
					object obj38;
					Func<object, float> keySelector;
					Dictionary<object, object>.KeyCollection source;
					Dictionary<object, object>.KeyCollection keyCollection;
					if ((nint)0 != 0)
					{
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v571 @ X0_v61+B8]");
						obj38 = 0;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v581 @ X8_v46+10]");
						keySelector = (Func<object, float>)0;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v581 @ X8_v46+10]");
						bool flag5 = (nint)0 == 0;
						object obj39 = !flag5;
						source = keys;
						if (obj39 == null)
						{
							keyCollection = keys;
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v581 @ X8_v46+10]");
							Func<object, float> func = (Func<object, float>)0;
							goto IL_06e3;
						}
					}
					else
					{
						Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
						obj37 = obj36;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v571 @ X0_v61+B8]");
						obj38 = 0;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v581 @ X8_v46+10]");
						Func<object, float> func = (Func<object, float>)0;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v581 @ X8_v46+10]");
						bool flag6 = (nint)0 == 0;
						object obj40 = !flag6;
						keyCollection = keys;
						source = keys;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v581 @ X8_v46+10]");
						keySelector = (Func<object, float>)0;
						if (obj40 == null)
						{
							goto IL_06e3;
						}
					}
					goto IL_0906;
					IL_06e3:
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v571 @ X0_v61+E4]");
					bool flag7 = (nint)0 == 0;
					object obj41 = !flag7;
					if (obj41 == null)
					{
						Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
						object obj42 = obj36;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v589 @ X8_v52+B8]");
						obj38 = 0;
					}
					object obj43 = typeof(Func<AndroidJavaObject, IList<HWLocation>>) + 3632;
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
					object obj44 = (nint)0 + (nint)2008;
					func2..ctor(obj38, (IntPtr)obj44);
					object obj45 = obj36;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v557 @ X8_v51+B8]");
					object obj46 = (nint)0 + (nint)16;
					obj46 = func2;
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
					source = keyCollection;
					keySelector = func2;
					goto IL_0906;
					IL_0906:
					object obj47 = (nint)0 + (nint)2248;
					IOrderedEnumerable<object> enumeration = Enumerable.OrderBy(source, keySelector);
					object obj48 = typeof(System.Diagnostics.DiagnosticSourceEventSource.TransformSpec.PropertySpec.PropertyFetch.EnumeratePropertyFetch<>) + 3576;
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
					action..ctor(obj3, (IntPtr)obj7);
					ArraysExtensions.ForEach(enumeration, action);
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v61 @ X0_v3 (System.Object)+10]");
					object obj49 = 0;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v61 @ X0_v3 (System.Object)+10]");
					if ((nint)0 == 0)
					{
						break;
					}
					object obj50 = obj49;
					Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v598 @ X8_v43+168] (should have been resolved before IL gen)");
					uriBuilder.Query = query;
					uriBuilder.Port = -1;
					return uriBuilder.ToString();
					IL_0325:
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @B0D070");
					Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v448 @ X0_v79] (should have been resolved before IL gen)");
					bool flag8 = obj10 == null;
					object obj51 = !flag8;
					if (obj51 == null)
					{
						break;
					}
					goto IL_03b6;
				}
			}
		}
		return (string)(object)new NullReferenceException();
	}

	private static string Quotes(string text)
	{
		//IL_000a: Unknown result type (might be due to invalid IL or missing references)
		//IL_000f: Expected O, but got Unknown
		object obj = " SDK from working.  If you would like to change it's implementation please override StartVivoxUnity method in " + 2544;
		return (string)obj + text + (string)obj;
	}

	private static string Tag(string content, string tag)
	{
		//IL_000f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0014: Expected O, but got Unknown
		//IL_0042: Unknown result type (might be due to invalid IL or missing references)
		//IL_0047: Expected O, but got Unknown
		//IL_0050: Unknown result type (might be due to invalid IL or missing references)
		//IL_0055: Expected O, but got Unknown
		//IL_0081: Expected O, but got I8
		//IL_00a7: Unknown result type (might be due to invalid IL or missing references)
		//IL_00ac: Expected O, but got Unknown
		//IL_00e0: Expected O, but got I4
		//IL_00f6: Expected O, but got I
		//IL_0116: Unknown result type (might be due to invalid IL or missing references)
		//IL_011b: Expected O, but got Unknown
		//IL_0133: Unknown result type (might be due to invalid IL or missing references)
		//IL_0138: Expected O, but got Unknown
		//IL_0141: Unknown result type (might be due to invalid IL or missing references)
		//IL_0146: Expected O, but got Unknown
		//IL_0172: Expected O, but got I8
		//IL_0198: Unknown result type (might be due to invalid IL or missing references)
		//IL_019d: Expected O, but got Unknown
		//IL_01d1: Expected O, but got I4
		//IL_01e7: Expected O, but got I
		//IL_0207: Unknown result type (might be due to invalid IL or missing references)
		//IL_020c: Expected O, but got Unknown
		//IL_0224: Unknown result type (might be due to invalid IL or missing references)
		//IL_0229: Expected O, but got Unknown
		//IL_0232: Unknown result type (might be due to invalid IL or missing references)
		//IL_0237: Expected O, but got Unknown
		//IL_026b: Expected O, but got I4
		//IL_0281: Expected O, but got I
		//IL_02a1: Unknown result type (might be due to invalid IL or missing references)
		//IL_02a6: Expected O, but got Unknown
		//IL_02bd: Unknown result type (might be due to invalid IL or missing references)
		//IL_02c2: Expected O, but got Unknown
		//IL_02f6: Expected O, but got I4
		//IL_030c: Expected O, but got I
		//IL_032c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0331: Expected O, but got Unknown
		//IL_0348: Unknown result type (might be due to invalid IL or missing references)
		//IL_034d: Expected O, but got Unknown
		object obj = typeof(SqlSingle[]) + 32;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC18B4");
		string[] array = default(string[]);
		if (array != null)
		{
			if (array.Length != 0)
			{
				object obj2 = "1.2.840.113549.1.12.1.5" + 2144;
				object obj3 = array + 32;
				obj3 = obj2;
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v112 @ X22_v6-8]");
				object obj4 = 0 & 0xFFFFFFFEL;
				if (obj4 != null)
				{
					object obj5 = array + 40;
					obj5 = tag;
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v173 @ X22_v8-10]");
					bool flag = (nint)0 < (nint)2;
					object obj6 = !flag;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v173 @ X22_v8-10]");
					object obj7 = -2;
					bool flag2 = obj7 == null;
					object obj8 = ~obj6;
					object obj9 = obj8 | flag2;
					if (obj9 == null)
					{
						object obj10 = "<ds.DataTable.OnColumnChanging|INFO> {0}" + 880;
						object obj11 = array + 48;
						obj11 = obj10;
						Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v174 @ X22_v10-18]");
						object obj12 = 0 & 0xFFFFFFFCL;
						if (obj12 != null)
						{
							object obj13 = array + 56;
							obj13 = content;
							Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v175 @ X22_v12-20]");
							bool flag3 = (nint)0 < (nint)4;
							object obj14 = !flag3;
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v175 @ X22_v12-20]");
							object obj15 = -4;
							bool flag4 = obj15 == null;
							object obj16 = ~obj14;
							object obj17 = obj16 | flag4;
							if (obj17 == null)
							{
								object obj18 = "1.2.840.113549.1.12.1.5" + 2232;
								object obj19 = array + 64;
								obj19 = obj18;
								Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
								Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v182 @ X21_v5-28]");
								bool flag5 = (nint)0 < (nint)5;
								object obj20 = !flag5;
								Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v182 @ X21_v5-28]");
								object obj21 = -5;
								bool flag6 = obj21 == null;
								object obj22 = ~obj20;
								object obj23 = obj22 | flag6;
								if (obj23 == null)
								{
									object obj24 = array + 72;
									obj24 = tag;
									Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
									Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v183 @ X21_v7-30]");
									bool flag7 = (nint)0 < (nint)6;
									object obj25 = !flag7;
									Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v183 @ X21_v7-30]");
									object obj26 = -6;
									bool flag8 = obj26 == null;
									object obj27 = ~obj25;
									object obj28 = obj27 | flag8;
									if (obj28 == null)
									{
										object obj29 = array + 80;
										obj29 = obj10;
										Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
										return string.Concat(array);
									}
								}
							}
						}
					}
				}
			}
			IndexOutOfRangeException ex = new IndexOutOfRangeException();
		}
		return (string)(object)new NullReferenceException();
	}

	private static string Tag(string content, string tag, string value)
	{
		//IL_000f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0014: Expected O, but got Unknown
		//IL_0042: Unknown result type (might be due to invalid IL or missing references)
		//IL_0047: Expected O, but got Unknown
		//IL_0050: Unknown result type (might be due to invalid IL or missing references)
		//IL_0055: Expected O, but got Unknown
		//IL_0081: Expected O, but got I8
		//IL_00a7: Unknown result type (might be due to invalid IL or missing references)
		//IL_00ac: Expected O, but got Unknown
		//IL_00e0: Expected O, but got I4
		//IL_00f6: Expected O, but got I
		//IL_0116: Unknown result type (might be due to invalid IL or missing references)
		//IL_011b: Expected O, but got Unknown
		//IL_0133: Unknown result type (might be due to invalid IL or missing references)
		//IL_0138: Expected O, but got Unknown
		//IL_0141: Unknown result type (might be due to invalid IL or missing references)
		//IL_0146: Expected O, but got Unknown
		//IL_0172: Expected O, but got I8
		//IL_0198: Unknown result type (might be due to invalid IL or missing references)
		//IL_019d: Expected O, but got Unknown
		//IL_01d1: Expected O, but got I4
		//IL_01e7: Expected O, but got I
		//IL_0207: Unknown result type (might be due to invalid IL or missing references)
		//IL_020c: Expected O, but got Unknown
		//IL_0224: Unknown result type (might be due to invalid IL or missing references)
		//IL_0229: Expected O, but got Unknown
		//IL_0232: Unknown result type (might be due to invalid IL or missing references)
		//IL_0237: Expected O, but got Unknown
		//IL_026b: Expected O, but got I4
		//IL_0281: Expected O, but got I
		//IL_02a1: Unknown result type (might be due to invalid IL or missing references)
		//IL_02a6: Expected O, but got Unknown
		//IL_02bd: Unknown result type (might be due to invalid IL or missing references)
		//IL_02c2: Expected O, but got Unknown
		//IL_02f6: Expected O, but got I4
		//IL_030c: Expected O, but got I
		//IL_032c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0331: Expected O, but got Unknown
		//IL_0349: Unknown result type (might be due to invalid IL or missing references)
		//IL_034e: Expected O, but got Unknown
		//IL_0357: Unknown result type (might be due to invalid IL or missing references)
		//IL_035c: Expected O, but got Unknown
		//IL_0388: Expected O, but got I8
		//IL_03ae: Unknown result type (might be due to invalid IL or missing references)
		//IL_03b3: Expected O, but got Unknown
		//IL_03e7: Expected O, but got I4
		//IL_03fd: Expected O, but got I
		//IL_041d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0422: Expected O, but got Unknown
		//IL_0439: Unknown result type (might be due to invalid IL or missing references)
		//IL_043e: Expected O, but got Unknown
		object obj = typeof(SqlSingle[]) + 32;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC18B4");
		string[] array = default(string[]);
		if (array != null)
		{
			if (array.Length != 0)
			{
				object obj2 = "1.2.840.113549.1.12.1.5" + 2144;
				object obj3 = array + 32;
				obj3 = obj2;
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v114 @ X23_v6-8]");
				object obj4 = 0 & 0xFFFFFFFEL;
				if (obj4 != null)
				{
					object obj5 = array + 40;
					obj5 = tag;
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v192 @ X23_v8-10]");
					bool flag = (nint)0 < (nint)2;
					object obj6 = !flag;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v192 @ X23_v8-10]");
					object obj7 = -2;
					bool flag2 = obj7 == null;
					object obj8 = ~obj6;
					object obj9 = obj8 | flag2;
					if (obj9 == null)
					{
						object obj10 = "<ds.DataTable.OnColumnChanging|INFO> {0}" + 800;
						object obj11 = array + 48;
						obj11 = obj10;
						Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v193 @ X23_v10-18]");
						object obj12 = 0 & 0xFFFFFFFCL;
						if (obj12 != null)
						{
							object obj13 = array + 56;
							obj13 = value;
							Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v194 @ X23_v12-20]");
							bool flag3 = (nint)0 < (nint)4;
							object obj14 = !flag3;
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v194 @ X23_v12-20]");
							object obj15 = -4;
							bool flag4 = obj15 == null;
							object obj16 = ~obj14;
							object obj17 = obj16 | flag4;
							if (obj17 == null)
							{
								object obj18 = "<ds.DataTable.OnColumnChanging|INFO> {0}" + 880;
								object obj19 = array + 64;
								obj19 = obj18;
								Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
								Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v206 @ X22_v5-28]");
								bool flag5 = (nint)0 < (nint)5;
								object obj20 = !flag5;
								Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v206 @ X22_v5-28]");
								object obj21 = -5;
								bool flag6 = obj21 == null;
								object obj22 = ~obj20;
								object obj23 = obj22 | flag6;
								if (obj23 == null)
								{
									object obj24 = array + 72;
									obj24 = content;
									Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
									Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v207 @ X22_v7-30]");
									bool flag7 = (nint)0 < (nint)6;
									object obj25 = !flag7;
									Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v207 @ X22_v7-30]");
									object obj26 = -6;
									bool flag8 = obj26 == null;
									object obj27 = ~obj25;
									object obj28 = obj27 | flag8;
									if (obj28 == null)
									{
										object obj29 = "1.2.840.113549.1.12.1.5" + 2232;
										object obj30 = array + 80;
										obj30 = obj29;
										Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
										Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v204 @ X21_v5-38]");
										object obj31 = 0 & 0xFFFFFFF8L;
										if (obj31 != null)
										{
											object obj32 = array + 88;
											obj32 = tag;
											Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
											Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v205 @ X21_v7-40]");
											bool flag9 = (nint)0 < (nint)8;
											object obj33 = !flag9;
											Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v205 @ X21_v7-40]");
											object obj34 = -8;
											bool flag10 = obj34 == null;
											object obj35 = ~obj33;
											object obj36 = obj35 | flag10;
											if (obj36 == null)
											{
												object obj37 = array + 96;
												obj37 = obj18;
												Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
												return string.Concat(array);
											}
										}
									}
								}
							}
						}
					}
				}
			}
			IndexOutOfRangeException ex = new IndexOutOfRangeException();
		}
		return (string)(object)new NullReferenceException();
	}

	public static string Bold(string content)
	{
		//IL_0009: Expected O, but got I4
		//IL_0018: Unknown result type (might be due to invalid IL or missing references)
		//IL_001d: Expected O, but got Unknown
		//IL_0033: Expected O, but got I
		//IL_00ba: Unknown result type (might be due to invalid IL or missing references)
		//IL_00bf: Expected O, but got Unknown
		//IL_00e9: Expected O, but got I4
		//IL_005a: Unknown result type (might be due to invalid IL or missing references)
		//IL_005f: Expected O, but got Unknown
		object obj = 152981504;
		object obj2 = typeof(System.Formats.Asn1.SetOfValueComparer) + 2504;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [91E5F49]");
		object obj3 = (nint)0 & (nint)1;
		object obj4;
		object tag;
		if (obj3 != null)
		{
			obj4 = "alignContent" + 3552;
			object obj5 = obj2;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v62 @ X0_v1+E4]");
			bool flag = (nint)0 == 0;
			tag = obj4;
			if (!flag)
			{
				goto IL_0094;
			}
		}
		else
		{
			_ = 1;
			obj4 = "alignContent" + 3552;
			object obj5 = obj2;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v62 @ X0_v1+E4]");
			bool flag2 = (nint)0 == 0;
			object obj6 = !flag2;
			tag = obj4;
			if (obj6 != null)
			{
				goto IL_0094;
			}
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		return Tag(content, (string)tag);
		IL_0094:
		return Tag(content, (string)obj4);
	}

	public static string NoBreak(string content)
	{
		//IL_0009: Expected O, but got I4
		//IL_0018: Unknown result type (might be due to invalid IL or missing references)
		//IL_001d: Expected O, but got Unknown
		//IL_0033: Expected O, but got I
		//IL_00ba: Unknown result type (might be due to invalid IL or missing references)
		//IL_00bf: Expected O, but got Unknown
		//IL_00e9: Expected O, but got I4
		//IL_005a: Unknown result type (might be due to invalid IL or missing references)
		//IL_005f: Expected O, but got Unknown
		object obj = 152981504;
		object obj2 = typeof(System.Formats.Asn1.SetOfValueComparer) + 2504;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [91E5F4A]");
		object obj3 = (nint)0 & (nint)1;
		object obj4;
		object tag;
		if (obj3 != null)
		{
			obj4 = "m_StencilDeferredPS" + 3856;
			object obj5 = obj2;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v62 @ X0_v1+E4]");
			bool flag = (nint)0 == 0;
			tag = obj4;
			if (!flag)
			{
				goto IL_0094;
			}
		}
		else
		{
			_ = 1;
			obj4 = "m_StencilDeferredPS" + 3856;
			object obj5 = obj2;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v62 @ X0_v1+E4]");
			bool flag2 = (nint)0 == 0;
			object obj6 = !flag2;
			tag = obj4;
			if (obj6 != null)
			{
				goto IL_0094;
			}
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		return Tag(content, (string)tag);
		IL_0094:
		return Tag(content, (string)obj4);
	}

	public static string Underline(string content)
	{
		//IL_0009: Expected O, but got I4
		//IL_0018: Unknown result type (might be due to invalid IL or missing references)
		//IL_001d: Expected O, but got Unknown
		//IL_0033: Expected O, but got I
		//IL_00ba: Unknown result type (might be due to invalid IL or missing references)
		//IL_00bf: Expected O, but got Unknown
		//IL_00e9: Expected O, but got I4
		//IL_005a: Unknown result type (might be due to invalid IL or missing references)
		//IL_005f: Expected O, but got Unknown
		object obj = 152981504;
		object obj2 = typeof(System.Formats.Asn1.SetOfValueComparer) + 2504;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [91E5F4B]");
		object obj3 = (nint)0 & (nint)1;
		object obj4;
		object tag;
		if (obj3 != null)
		{
			obj4 = "tournament_participate_warning_body_with_tickets_warning_daily" + 1096;
			object obj5 = obj2;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v62 @ X0_v1+E4]");
			bool flag = (nint)0 == 0;
			tag = obj4;
			if (!flag)
			{
				goto IL_0094;
			}
		}
		else
		{
			_ = 1;
			obj4 = "tournament_participate_warning_body_with_tickets_warning_daily" + 1096;
			object obj5 = obj2;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v62 @ X0_v1+E4]");
			bool flag2 = (nint)0 == 0;
			object obj6 = !flag2;
			tag = obj4;
			if (obj6 != null)
			{
				goto IL_0094;
			}
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		return Tag(content, (string)tag);
		IL_0094:
		return Tag(content, (string)obj4);
	}

	public static string Font(string content, string font)
	{
		//IL_000f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0014: Expected O, but got Unknown
		//IL_0075: Expected O, but got I4
		//IL_0032: Unknown result type (might be due to invalid IL or missing references)
		//IL_0037: Expected O, but got Unknown
		//IL_0041: Unknown result type (might be due to invalid IL or missing references)
		//IL_0046: Expected O, but got Unknown
		object obj = typeof(System.Formats.Asn1.SetOfValueComparer) + 2504;
		object obj2 = obj;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v50 @ X0_v2+E4]");
		bool flag = (nint)0 == 0;
		object obj3 = !flag;
		if (obj3 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		}
		object tag = "fetch_products" + 920;
		object obj4 = " SDK from working.  If you would like to change it's implementation please override StartVivoxUnity method in " + 2544;
		string value = (string)obj4 + font + (string)obj4;
		return Tag(content, (string)tag, value);
	}

	public static string Size(string content, int size)
	{
		//IL_000f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0014: Expected O, but got Unknown
		//IL_004c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0051: Expected O, but got Unknown
		//IL_0088: Expected O, but got I4
		object obj = typeof(System.Formats.Asn1.SetOfValueComparer) + 2504;
		object tag = "setMimeType" + 2664;
		int num = default(int);
		string value = num.ToString();
		object obj2 = obj;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v54 @ X0_v4+E4]");
		bool flag = (nint)0 == 0;
		object obj3 = !flag;
		if (obj3 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		}
		return Tag(content, (string)tag, value);
	}

	public static string Color(string content, Color color)
	{
		//IL_000f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0014: Expected O, but got Unknown
		//IL_00be: Unknown result type (might be due to invalid IL or missing references)
		//IL_00c3: Expected O, but got Unknown
		//IL_00d9: Expected O, but got I
		//IL_0023: Unknown result type (might be due to invalid IL or missing references)
		//IL_0028: Expected O, but got Unknown
		//IL_003e: Expected O, but got I
		//IL_0058: Expected O, but got I4
		//IL_0147: Unknown result type (might be due to invalid IL or missing references)
		//IL_014c: Expected O, but got Unknown
		//IL_0187: Expected O, but got I4
		object obj = typeof(System.Formats.Asn1.SetOfValueComparer) + 2504;
		Color color2 = default(Color);
		string text = ColorUtility.ToHtmlStringRGBA(ref color2);
		object obj2 = obj;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v68 @ X0_v4+E4]");
		object obj3;
		object obj6;
		if ((nint)0 != 0)
		{
			obj3 = " SDK from working.  If you would like to change it's implementation please override StartVivoxUnity method in " + 2912;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [91E5FE4]");
			object obj4 = (nint)0 & (nint)1;
			bool flag = obj4 == null;
			object obj5 = !flag;
			obj6 = obj3;
			if (obj5 == null)
			{
				goto IL_006e;
			}
		}
		else
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			obj3 = " SDK from working.  If you would like to change it's implementation please override StartVivoxUnity method in " + 2912;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [91E5FE4]");
			object obj7 = (nint)0 & (nint)1;
			if (obj7 == null)
			{
				goto IL_006e;
			}
			obj6 = obj3;
		}
		goto IL_013d;
		IL_006e:
		_ = 1;
		obj6 = obj3;
		goto IL_013d;
		IL_013d:
		object tag = "clear_mass_tournaments" + 480;
		string value = (string)obj6 + text;
		object obj8 = obj;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v110 @ X0_v8+E4]");
		bool flag2 = (nint)0 == 0;
		object obj9 = !flag2;
		if (obj9 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		}
		return Tag(content, (string)tag, value);
	}

	public static string Color(string content, string colorHexCode)
	{
		//IL_000a: Unknown result type (might be due to invalid IL or missing references)
		//IL_000f: Expected O, but got Unknown
		//IL_001e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0023: Expected O, but got Unknown
		//IL_005b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0060: Expected O, but got Unknown
		//IL_009b: Expected O, but got I4
		object obj = " SDK from working.  If you would like to change it's implementation please override StartVivoxUnity method in " + 2912;
		object obj2 = typeof(System.Formats.Asn1.SetOfValueComparer) + 2504;
		object tag = "clear_mass_tournaments" + 480;
		string text = default(string);
		string value = (string)obj + text;
		object obj3 = obj2;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v64 @ X0_v4+E4]");
		bool flag = (nint)0 == 0;
		object obj4 = !flag;
		if (obj4 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		}
		return Tag(content, (string)tag, value);
	}

	public unsafe static string Sprite(string iconName, Color? color = null)
	{
		//IL_000f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0014: Expected O, but got Unknown
		//IL_0042: Unknown result type (might be due to invalid IL or missing references)
		//IL_0047: Expected O, but got Unknown
		//IL_0050: Unknown result type (might be due to invalid IL or missing references)
		//IL_0055: Expected O, but got Unknown
		//IL_0081: Expected O, but got I8
		//IL_00a7: Unknown result type (might be due to invalid IL or missing references)
		//IL_00ac: Expected O, but got Unknown
		//IL_00e0: Expected O, but got I4
		//IL_00f6: Expected O, but got I
		//IL_0116: Unknown result type (might be due to invalid IL or missing references)
		//IL_011b: Expected O, but got Unknown
		//IL_0133: Unknown result type (might be due to invalid IL or missing references)
		//IL_0138: Expected O, but got Unknown
		//IL_0141: Unknown result type (might be due to invalid IL or missing references)
		//IL_0146: Expected O, but got Unknown
		//IL_0161: Unknown result type (might be due to invalid IL or missing references)
		//IL_0166: Expected O, but got Unknown
		//IL_01dc: Expected O, but got I
		//IL_0311: Expected O, but got I8
		//IL_01ad: Unknown result type (might be due to invalid IL or missing references)
		//IL_01b2: Expected O, but got Unknown
		//IL_01f2: Unknown result type (might be due to invalid IL or missing references)
		//IL_01f7: Expected O, but got Unknown
		//IL_022b: Expected O, but got I4
		//IL_0241: Expected O, but got I
		//IL_0261: Unknown result type (might be due to invalid IL or missing references)
		//IL_0266: Expected O, but got Unknown
		//IL_027e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0283: Expected O, but got Unknown
		//IL_028c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0291: Expected O, but got Unknown
		object obj = typeof(SqlSingle[]) + 32;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC18B4");
		string[] array = default(string[]);
		if (array != null)
		{
			if (array.Length != 0)
			{
				object obj2 = "<ds.DataTable.OnColumnChanging|INFO> {0}" + 656;
				object obj3 = array + 32;
				obj3 = obj2;
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v121 @ X22_v6-8]");
				object obj4 = 0 & 0xFFFFFFFEL;
				if (obj4 != null)
				{
					object obj5 = array + 40;
					obj5 = iconName;
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v163 @ X22_v8-10]");
					bool flag = (nint)0 < (nint)2;
					object obj6 = !flag;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v163 @ X22_v8-10]");
					object obj7 = -2;
					bool flag2 = obj7 == null;
					object obj8 = ~obj6;
					object obj9 = obj8 | flag2;
					if (obj9 == null)
					{
						object obj10 = " SDK from working.  If you would like to change it's implementation please override StartVivoxUnity method in " + 2544;
						object obj11 = array + 48;
						obj11 = obj10;
						Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
						object obj12 = (??)color & 1;
						string text3;
						if (obj12 != null)
						{
							Color value = ((Color?*)color)->Value;
							Color color2 = default(Color);
							string text = ColorUtility.ToHtmlStringRGBA(ref color2);
							object obj13 = " SDK from working.  If you would like to change it's implementation please override StartVivoxUnity method in " + 568;
							string text2 = (string)obj13 + text;
							text3 = text2;
						}
						else
						{
							object obj14 = (nint)0 + (nint)2000;
							text3 = (string)obj14;
						}
						object obj15 = array.Length & 0xFFFFFFFCL;
						if (obj15 != null)
						{
							object obj16 = array + 56;
							obj16 = text3;
							Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v168 @ X20_v5-20]");
							bool flag3 = (nint)0 < (nint)4;
							object obj17 = !flag3;
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v168 @ X20_v5-20]");
							object obj18 = -4;
							bool flag4 = obj18 == null;
							object obj19 = ~obj17;
							object obj20 = obj19 | flag4;
							if (obj20 == null)
							{
								object obj21 = "<ds.DataTable.OnColumnChanging|INFO> {0}" + 880;
								object obj22 = array + 64;
								obj22 = obj21;
								Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
								return string.Concat(array);
							}
						}
					}
				}
			}
			IndexOutOfRangeException ex = new IndexOutOfRangeException();
		}
		return (string)(object)new NullReferenceException();
	}

	public static string AbbreviateNumber(int number)
	{
		//IL_00b9: Unknown result type (might be due to invalid IL or missing references)
		//IL_00be: Expected O, but got Unknown
		//IL_0041: Unknown result type (might be due to invalid IL or missing references)
		//IL_0046: Expected O, but got Unknown
		//IL_008f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0094: Expected O, but got Unknown
		object obj = ", stale={0}" + 3464;
		float num2 = default(float);
		if (number < 1000000)
		{
			int num = default(int);
			if (number < 1000)
			{
				return num.ToString();
			}
			string text = num2.ToString((string)obj);
			object obj2 = "Invalid serialized DateTime data. Unable to find 'ticks' or 'dateData'." + 3352;
			return text + (string)obj2;
		}
		object obj3 = "LAK" + 2584;
		string text2 = num2.ToString((string)obj);
		return text2 + (string)obj3;
	}

	static StringUtil()
	{
		//IL_000f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0014: Expected O, but got Unknown
		//IL_001e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0023: Expected O, but got Unknown
		//IL_0032: Unknown result type (might be due to invalid IL or missing references)
		//IL_0037: Expected O, but got Unknown
		//IL_0041: Unknown result type (might be due to invalid IL or missing references)
		//IL_0046: Expected O, but got Unknown
		//IL_0050: Unknown result type (might be due to invalid IL or missing references)
		//IL_0055: Expected O, but got Unknown
		//IL_005f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0064: Expected O, but got Unknown
		//IL_006e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0073: Expected O, but got Unknown
		//IL_007d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0082: Expected O, but got Unknown
		//IL_0091: Unknown result type (might be due to invalid IL or missing references)
		//IL_0096: Expected O, but got Unknown
		//IL_00d5: Expected O, but got I
		//IL_0121: Expected O, but got I
		//IL_0172: Expected O, but got I
		//IL_01be: Expected O, but got I
		//IL_020f: Expected O, but got I
		//IL_024b: Expected O, but got I
		//IL_0340: Expected O, but got I
		object obj = typeof(System.Buffers.Text.ParserHelpers) + 3920;
		object pattern = "{0} color encoding is currently unsupported for outputting to HDR." + 3728;
		object obj2 = typeof(System.Formats.Asn1.SetOfValueComparer) + 2504;
		object pattern2 = "[{0}]:{1}" + 768;
		object pattern3 = "WhiteSmoke" + 2528;
		object pattern4 = "[{0}]:{1}" + 704;
		object pattern5 = "[{0}]:{1}" + 752;
		object pattern6 = "1.2.840.113549.1.12.1.5" + 3264;
		object obj3 = typeof(ConditionalWeakTable<System.Net.HttpWebRequest, Mono.Http.NtlmSession>.CreateValueCallback) + 464;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
		Regex regex = default(Regex);
		regex..ctor((string)pattern);
		object obj4 = obj2;
		object obj5 = regex;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
		Regex regex2 = default(Regex);
		regex2..ctor((string)pattern2);
		object obj6 = obj2;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v101 @ X8_v4+B8]");
		object obj7 = (nint)0 + (nint)8;
		obj7 = regex2;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
		Regex regex3 = default(Regex);
		regex3..ctor((string)pattern3);
		object obj8 = obj2;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v120 @ X8_v5+B8]");
		object obj9 = (nint)0 + (nint)16;
		obj9 = regex3;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
		Regex regex4 = default(Regex);
		regex4..ctor((string)pattern4);
		object obj10 = obj2;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v135 @ X8_v6+B8]");
		object obj11 = (nint)0 + (nint)24;
		obj11 = regex4;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
		Regex regex5 = default(Regex);
		regex5..ctor((string)pattern5);
		object obj12 = obj2;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v145 @ X8_v7+B8]");
		object obj13 = (nint)0 + (nint)32;
		obj13 = regex5;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
		Regex regex6 = default(Regex);
		regex6..ctor((string)pattern6);
		object obj14 = obj2;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v155 @ X8_v8+B8]");
		object obj15 = (nint)0 + (nint)40;
		obj15 = regex6;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
		Dictionary<char, char> dictionary = default(Dictionary<char, char>);
		dictionary..ctor();
		object obj16 = (nint)0 + (nint)2032;
		dictionary.Add('٠', '0');
		dictionary.Add('١', '1');
		dictionary.Add('٢', '2');
		dictionary.Add('٣', '3');
		dictionary.Add('٤', '4');
		dictionary.Add('٥', '5');
		dictionary.Add('٦', '6');
		dictionary.Add('٧', '7');
		dictionary.Add('٨', '8');
		dictionary.Add('٩', '9');
		object obj17 = obj2;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v211 @ X8_v11+B8]");
		object obj18 = (nint)0 + (nint)48;
		obj18 = dictionary;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
	}

	internal static string <AppendUserParamsWithObfuscation>g__GetRandomKey|21_2()
	{
		//IL_000a: Unknown result type (might be due to invalid IL or missing references)
		//IL_000f: Expected O, but got Unknown
		//IL_001e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0023: Expected O, but got Unknown
		//IL_006a: Unknown result type (might be due to invalid IL or missing references)
		//IL_006f: Expected O, but got Unknown
		//IL_0079: Unknown result type (might be due to invalid IL or missing references)
		//IL_007e: Expected O, but got Unknown
		//IL_00c2: Expected O, but got I4
		object obj = "Material with texture name \"" + 3208;
		object obj2 = typeof(System.Buffers.Text.ParserHelpers) + 3920;
		object pattern = "[{0}]:{1}" + 848;
		object replacement = "utf-32" + 3136;
		Guid guid = Guid.NewGuid();
		Guid guid2 = default(Guid);
		string input = guid2.ToString((string)obj);
		object obj3 = obj2;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v64 @ X8_v3+E4]");
		bool flag = (nint)0 == 0;
		object obj4 = !flag;
		if (obj4 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		}
		string text = Regex.Replace(input, (string)pattern, (string)replacement);
		int length = UnityEngine.Random.Range(1, 6);
		if (text != null)
		{
			return text.Substring(0, length);
		}
		return (string)(object)new NullReferenceException();
	}

	internal static string <AppendUserParamsWithObfuscation>g__GetRandomValue|21_3()
	{
		//IL_001f: Expected O, but got I4
		//IL_00a6: Unknown result type (might be due to invalid IL or missing references)
		//IL_00ab: Expected O, but got Unknown
		//IL_0064: Unknown result type (might be due to invalid IL or missing references)
		//IL_0069: Expected O, but got Unknown
		int num = UnityEngine.Random.Range(0, 3);
		int maxExclusive;
		int minInclusive;
		if (num != 1)
		{
			bool flag = num == 0;
			object obj = !flag;
			if (obj == null)
			{
				float value = UnityEngine.Random.value;
				if ((double)value > 0.5)
				{
					return "ThisIsFakeReceiptData" + 1984;
				}
				return "Error reading data from socket: " + 3616;
			}
			maxExclusive = 1000000;
			minInclusive = 0;
		}
		else
		{
			maxExclusive = 7;
			minInclusive = 0;
		}
		int num2 = UnityEngine.Random.Range(minInclusive, maxExclusive);
		int num3 = default(int);
		return num3.ToString();
	}
}

using System;
using System.Buffers.Text;
using System.Collections;
using System.Collections.Generic;
using System.Formats.Asn1;
using System.Globalization;
using System.Linq;
using System.Runtime.Remoting.Messaging;
using System.Security.Cryptography;
using System.Text;
using System.Text.RegularExpressions;
using Cpp2ILInjected;
using HuaweiMobileServices.Location.Location;
using Newtonsoft.Json.Linq.JsonPath;
using Spine;
using UnityEngine;
using UnityEngine.AdaptivePerformance;
using UnityEngine.Purchasing.Telemetry;
using UnityEngine.TextCore;

public static class StringsExtensions
{
	[Serializable]
	private sealed class <>c
	{
		public static readonly <>c <>9;

		public static MatchEvaluator <>9__1_0;

		static <>c()
		{
			//IL_000f: Unknown result type (might be due to invalid IL or missing references)
			//IL_0014: Expected O, but got Unknown
			object obj = typeof(SkeletonBinary.SkeletonInput) + 1776;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
			object obj2 = default(object);
			obj2..ctor();
			object obj3 = obj;
			object obj4 = obj2;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
		}

		internal string <ToSentenceCase>b__1_0(Match m)
		{
			//IL_0050: Expected O, but got I4
			//IL_0093: Unknown result type (might be due to invalid IL or missing references)
			//IL_0098: Expected O, but got Unknown
			//IL_00ba: Expected O, but got I
			//IL_00dc: Expected O, but got I4
			if (m != null)
			{
				string value = m.Value;
				if (value != null)
				{
					char c = value.get_Chars(0);
					object obj = 153100288 + 1024;
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC195C");
					string value2 = m.Value;
					if (value2 != null)
					{
						object format = "{0} color encoding is currently unsupported for outputting to HDR." + 416;
						char c2 = value2.get_Chars(1);
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v47 @ X21_v3+88]");
						object obj2 = 0;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v89 @ X8_v3+E4]");
						bool flag = (nint)0 == 0;
						object obj3 = !flag;
						if (obj3 == null)
						{
							Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
						}
						char c3 = char.ToLower(c2);
						Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC195C");
						object arg = default(object);
						object arg2 = default(object);
						return string.Format((string)format, arg, arg2);
					}
				}
			}
			return (string)(object)new NullReferenceException();
		}
	}

	private static readonly Regex WebLinkPattern;

	public static bool IsNullOrEmpty(string value)
	{
		return string.IsNullOrEmpty(value);
	}

	public static string ToSentenceCase(string str)
	{
		//IL_0009: Expected O, but got I4
		//IL_0018: Unknown result type (might be due to invalid IL or missing references)
		//IL_001d: Expected O, but got Unknown
		//IL_0033: Expected O, but got I
		//IL_0174: Unknown result type (might be due to invalid IL or missing references)
		//IL_0179: Expected O, but got Unknown
		//IL_01a3: Expected O, but got I4
		//IL_00ab: Unknown result type (might be due to invalid IL or missing references)
		//IL_00b0: Expected O, but got Unknown
		//IL_00c0: Expected O, but got I
		//IL_00d0: Expected O, but got I
		//IL_005a: Unknown result type (might be due to invalid IL or missing references)
		//IL_005f: Expected O, but got Unknown
		//IL_0271: Expected O, but got I4
		//IL_01e2: Unknown result type (might be due to invalid IL or missing references)
		//IL_01e7: Expected O, but got Unknown
		//IL_01f7: Expected O, but got I
		//IL_0207: Expected O, but got I
		//IL_0231: Expected O, but got I4
		//IL_0324: Unknown result type (might be due to invalid IL or missing references)
		//IL_0329: Expected O, but got Unknown
		//IL_033f: Expected O, but got I
		//IL_0350: Expected I, but got O
		//IL_036e: Expected O, but got I
		//IL_02d0: Expected O, but got I4
		//IL_02a1: Expected O, but got I
		object obj = 152981504;
		object obj2 = typeof(SkeletonBinary.SkeletonInput) + 1776;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [91E5E82]");
		object obj3 = (nint)0 & (nint)1;
		object obj4;
		object obj7;
		object obj5;
		if (obj3 != null)
		{
			obj4 = "WhiteSmoke" + 3928;
			obj5 = obj2;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v88 @ X0_v3+E4]");
			bool flag = (nint)0 == 0;
			object obj6 = obj5;
			obj7 = obj4;
			if (!flag)
			{
				goto IL_009c;
			}
		}
		else
		{
			_ = 1;
			obj4 = "WhiteSmoke" + 3928;
			obj5 = obj2;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v88 @ X0_v3+E4]");
			bool flag2 = (nint)0 == 0;
			object obj8 = !flag2;
			object obj6 = obj5;
			obj7 = obj4;
			if (obj8 != null)
			{
				goto IL_009c;
			}
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		obj5 = obj2;
		object obj9 = typeof(System.Buffers.Text.ParserHelpers) + 3920;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v88 @ X0_v3+B8]");
		object obj10 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v147 @ X8_v4+8]");
		MatchEvaluator matchEvaluator = (MatchEvaluator)0;
		string text = (string)obj7;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v147 @ X8_v4+8]");
		bool flag3 = (nint)0 == 0;
		object obj11 = !flag3;
		object obj12 = obj9;
		string text2 = (string)obj7;
		if (obj11 != null)
		{
			goto IL_010d;
		}
		goto IL_024f;
		IL_010d:
		object obj13 = obj9;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v144 @ X0_v1+E4]");
		bool flag4 = (nint)0 == 0;
		MatchEvaluator matchEvaluator2 = matchEvaluator;
		text2 = text;
		if (!flag4)
		{
			goto IL_014a;
		}
		goto IL_02f6;
		IL_02f6:
		Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		matchEvaluator = matchEvaluator2;
		text = text2;
		goto IL_014a;
		IL_014a:
		return Regex.Replace(str, text, matchEvaluator);
		IL_009c:
		obj9 = typeof(System.Buffers.Text.ParserHelpers) + 3920;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v88 @ X0_v3+B8]");
		obj10 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v147 @ X8_v4+8]");
		matchEvaluator = (MatchEvaluator)0;
		text = (string)obj4;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v147 @ X8_v4+8]");
		bool flag5 = (nint)0 == 0;
		obj12 = obj9;
		text2 = (string)obj4;
		if (!flag5)
		{
			goto IL_010d;
		}
		goto IL_024f;
		IL_024f:
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v88 @ X0_v3+E4]");
		bool flag6 = (nint)0 == 0;
		object obj14 = !flag6;
		if (obj14 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			object obj15 = obj2;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v156 @ X8_v11+B8]");
			obj10 = 0;
		}
		object obj16 = typeof(Newtonsoft.Json.Linq.JsonPath.JPath) + 3864;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
		object obj17 = (nint)0 + (nint)2040;
		MatchEvaluator matchEvaluator3 = default(MatchEvaluator);
		matchEvaluator3..ctor(obj10, (IntPtr)obj17);
		object obj18 = obj2;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v163 @ X8_v9+B8]");
		object obj19 = (nint)0 + (nint)8;
		obj19 = matchEvaluator3;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
		obj13 = obj12;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v144 @ X0_v1+E4]");
		bool flag7 = (nint)0 == 0;
		object obj20 = !flag7;
		matchEvaluator = matchEvaluator3;
		text = text2;
		matchEvaluator2 = matchEvaluator3;
		if (obj20 != null)
		{
			goto IL_014a;
		}
		goto IL_02f6;
	}

	public static string Reverse(string value)
	{
		//IL_0014: Unknown result type (might be due to invalid IL or missing references)
		//IL_0019: Expected O, but got Unknown
		//IL_0051: Expected O, but got I4
		string text = default(string);
		if (text != null)
		{
			object obj = typeof(System.Formats.Asn1.SetOfValueComparer) + 2536;
			TextElementEnumerator textElementEnumerator = StringInfo.GetTextElementEnumerator(text);
			object obj2 = obj;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v55 @ X8_v3+E4]");
			bool flag = (nint)0 == 0;
			object obj3 = !flag;
			if (obj3 == null)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			}
			IEnumerable<string> source = AsEnumerable(textElementEnumerator);
			IEnumerable<object> enumerable = Enumerable.Reverse((IEnumerable<object>)source);
			return string.Concat((IEnumerable<string>)enumerable);
		}
		return text;
	}

	private static IEnumerable<string> AsEnumerable(TextElementEnumerator enumerator)
	{
		//IL_000f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0014: Expected O, but got Unknown
		//IL_0239: Expected O, but got I4
		//IL_0069: Expected O, but got I
		//IL_0078: Expected O, but got I4
		//IL_0184: Expected O, but got I4
		//IL_008d: Expected O, but got I
		//IL_009d: Expected O, but got I
		//IL_01bf: Unknown result type (might be due to invalid IL or missing references)
		//IL_01c4: Expected O, but got Unknown
		//IL_01cd: Unknown result type (might be due to invalid IL or missing references)
		//IL_01d2: Expected O, but got Unknown
		//IL_0210: Expected O, but got I4
		object obj = typeof(List<AdaptivePerformanceScaler>) + 3624;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
		List<object> list = default(List<object>);
		list..ctor();
		bool flag = enumerator.MoveNext();
		if (list != null)
		{
			if (flag)
			{
				object obj2 = (nint)0 + (nint)3072;
				object obj3 = 153100288 + 1024;
				while (true)
				{
					object current = enumerator.Current;
					if (current != null)
					{
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v110 @ X22_v9+90]");
						if (current != null)
						{
							throw new InvalidCastException();
						}
					}
					object obj4 = obj2;
					int version = list._version + 1;
					list._version = version;
					object[] items = list._items;
					bool flag2 = list._size < items.Length;
					object obj5 = !flag2;
					if (obj5 != null)
					{
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v100 @ X9_v7+20]");
						object obj6 = 0;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v274 @ X9_v9+C0]");
						object obj7 = 0;
						list.AddWithResize(current);
						if (!enumerator.MoveNext())
						{
							break;
						}
						continue;
					}
					int size = list._size + 1;
					list._size = size;
					object obj8 = items + list._size;
					object obj9 = obj8 + 32;
					obj9 = current;
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
					bool flag3 = enumerator.MoveNext();
					bool flag4 = !flag3;
					object obj10 = !flag4;
					if (obj10 == null)
					{
						break;
					}
				}
			}
		}
		else
		{
			bool flag5 = !flag;
			object obj11 = !flag5;
			if (obj11 != null)
			{
				object current2 = enumerator.Current;
				return (IEnumerable<string>)new NullReferenceException();
			}
		}
		return (IEnumerable<string>)list;
	}

	public static bool ContainsIgnoreCase(string source, string toCheck)
	{
		//IL_0017: Expected I4, but got O
		bool flag = source == null;
		bool result = (byte)(int)source != 0;
		if (!flag)
		{
			int num = source.IndexOf(toCheck, StringComparison.OrdinalIgnoreCase);
			int num2 = ~num;
			int num3 = num2 >> 31;
			result = (byte)num3 != 0;
		}
		return result;
	}

	public unsafe static string ReplaceUrls(string text, int max = -1, string[] allowedDomains = null, Func<string, string> replacement = null)
	{
		//IL_000f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0014: Expected I4, but got Unknown
		//IL_0fd5: Expected O, but got I4
		//IL_100d: Expected O, but got I4
		//IL_1015: Unknown result type (might be due to invalid IL or missing references)
		//IL_101a: Expected O, but got Unknown
		//IL_1060: Expected O, but got I4
		//IL_0062: Expected O, but got I4
		//IL_0082: Expected I4, but got O
		//IL_00d9: Unknown result type (might be due to invalid IL or missing references)
		//IL_00de: Expected O, but got Unknown
		//IL_00ed: Unknown result type (might be due to invalid IL or missing references)
		//IL_00f2: Expected O, but got Unknown
		//IL_0101: Unknown result type (might be due to invalid IL or missing references)
		//IL_0106: Expected O, but got Unknown
		//IL_0174: Expected O, but got I
		//IL_10af: Expected I4, but got O
		//IL_10d2: Unknown result type (might be due to invalid IL or missing references)
		//IL_10d7: Expected O, but got Unknown
		//IL_01af: Expected O, but got I
		//IL_081c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0821: Expected O, but got Unknown
		//IL_0829: Expected I4, but got O
		//IL_0852: Expected O, but got Ref
		//IL_085b: Expected O, but got I4
		//IL_086c: Expected O, but got I4
		//IL_0874: Expected I4, but got O
		//IL_087d: Expected O, but got I4
		//IL_08c5: Expected O, but got Ref
		//IL_08ce: Expected O, but got I4
		//IL_08ff: Expected O, but got I4
		//IL_0907: Expected I4, but got O
		//IL_0910: Expected O, but got I4
		//IL_1083: Expected O, but got I
		//IL_1229: Expected O, but got I4
		//IL_0232: Unknown result type (might be due to invalid IL or missing references)
		//IL_0237: Expected O, but got Unknown
		//IL_0936: Expected O, but got I
		//IL_01bd: Unknown result type (might be due to invalid IL or missing references)
		//IL_01c2: Expected O, but got Unknown
		//IL_01d8: Expected O, but got I
		//IL_0e78: Unknown result type (might be due to invalid IL or missing references)
		//IL_0e7d: Expected O, but got Unknown
		//IL_0279: Expected O, but got I
		//IL_0971: Expected O, but got I
		//IL_0318: Expected O, but got I4
		//IL_0a3d: Expected O, but got I4
		//IL_12bf: Expected O, but got I
		//IL_1130: Expected I4, but got O
		//IL_02b4: Expected O, but got I
		//IL_0ec6: Expected I4, but got O
		//IL_0eea: Expected O, but got I4
		//IL_0efb: Expected O, but got I4
		//IL_09ec: Unknown result type (might be due to invalid IL or missing references)
		//IL_09f1: Expected I4, but got Unknown
		//IL_1104: Expected O, but got I
		//IL_0c2a: Expected O, but got I4
		//IL_097f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0984: Expected O, but got Unknown
		//IL_098d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0992: Expected O, but got Unknown
		//IL_035b: Expected I4, but got O
		//IL_0363: Expected I4, but got O
		//IL_0373: Expected O, but got I
		//IL_0383: Expected O, but got I
		//IL_03ac: Expected O, but got I4
		//IL_0326: Unknown result type (might be due to invalid IL or missing references)
		//IL_032b: Expected O, but got Unknown
		//IL_0341: Unknown result type (might be due to invalid IL or missing references)
		//IL_0346: Expected O, but got Unknown
		//IL_0f9a: Expected O, but got I4
		//IL_0b6a: Expected O, but got I4
		//IL_02c2: Unknown result type (might be due to invalid IL or missing references)
		//IL_02c7: Expected O, but got Unknown
		//IL_02dd: Expected O, but got I
		//IL_03e0: Expected O, but got I
		//IL_0bd5: Expected O, but got I4
		//IL_0bde: Expected I, but got O
		//IL_0be6: Expected O, but got I4
		//IL_051c: Expected O, but got I
		//IL_0524: Expected O, but got I4
		//IL_04ae: Expected I, but got O
		//IL_04b6: Expected O, but got I4
		//IL_053e: Expected O, but got I
		//IL_0587: Expected O, but got I
		//IL_073a: Expected I4, but got O
		//IL_11e0: Expected O, but got Ref
		//IL_11e9: Expected O, but got I4
		//IL_1201: Expected I4, but got O
		//IL_05a4: Unknown result type (might be due to invalid IL or missing references)
		//IL_05a9: Expected I4, but got Unknown
		//IL_0770: Expected O, but got I
		//IL_078a: Expected I4, but got O
		//IL_07a9: Unknown result type (might be due to invalid IL or missing references)
		//IL_07ae: Expected O, but got Unknown
		//IL_0808: Expected I4, but got O
		//IL_05fe: Unknown result type (might be due to invalid IL or missing references)
		//IL_0603: Expected O, but got Unknown
		//IL_0619: Expected O, but got I
		//IL_062f: Expected I, but got O
		//IL_064d: Expected O, but got I4
		//IL_06b1: Expected O, but got I4
		//IL_06b9: Expected I4, but got O
		int num = typeof(System.Formats.Asn1.SetOfValueComparer) + 2536;
		object obj = max + 1;
		bool flag = (nint)obj < 0;
		bool flag2 = obj == null;
		bool flag3 = !flag;
		object obj2 = !flag2;
		object obj3 = flag3 & obj2;
		object obj4 = ~obj3;
		int num2 = ((obj4 != null) ? 2147483647 : max);
		int value = ((int*)num)->m_value;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v89 @ X0_v3 (System.Int32)+E4]");
		bool flag4 = (nint)0 == 0;
		object obj5 = !flag4;
		if (obj5 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			value = ((int*)num)->m_value;
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v89 @ X0_v3 (System.Int32)+B8]");
		int num3 = 0;
		bool flag5 = ((int*)num3)->m_value == 0;
		string[] array = allowedDomains;
		int num4 = max;
		int num5 = max;
		string result;
		Func<string, string> func2 = default(Func<string, string>);
		object obj34;
		object obj35 = default(object);
		object obj36;
		object obj37;
		object obj38;
		object obj39;
		UriBuilder uriBuilder4;
		string text5;
		Func<string, string> func10;
		object obj40;
		int num11;
		object obj41;
		Func<string, string> func11;
		object obj42;
		Func<string, string> func12;
		int num12;
		object obj43;
		int num13;
		object obj44;
		nint num10;
		string[] array3;
		object obj13 = default(object);
		object obj28 = default(object);
		UriBuilder uriBuilder2 = default(UriBuilder);
		string text3 = default(string);
		nint num8 = default(nint);
		object obj14 = default(object);
		int num9;
		object obj32;
		Func<string, string> func3;
		object obj7;
		Func<string, string> func8;
		Func<string, string> func;
		if (!flag5)
		{
			MatchCollection matchCollection = ((Regex)((int*)num3)->m_value).Matches(text);
			bool flag6 = matchCollection == null;
			array = null;
			num4 = (int)text;
			num5 = max;
			if (!flag6)
			{
				int count = matchCollection.Count;
				bool flag7 = count == 0;
				result = text;
				if (flag7)
				{
					goto IL_106e;
				}
				object obj6 = typeof(System.Formats.Asn1.SetOfValueComparer) + 2344;
				obj7 = typeof(UnityEngine.TextCore.HorizontalAlignment) + 2528;
				object obj8 = typeof(Newtonsoft.Json.Linq.JsonPath.JPath) + 3840;
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
				StringBuilder stringBuilder = default(StringBuilder);
				stringBuilder..ctor();
				IEnumerator enumerator = matchCollection.GetEnumerator();
				func = func2;
				func3 = null;
				array = null;
				num4 = 0;
				num = 0;
				object obj9 = default(object);
				num3 = (int)(&obj9);
				object obj10 = default(object);
				object obj16 = default(object);
				object obj18 = default(object);
				object obj22 = default(object);
				object obj23 = default(object);
				UriBuilder uriBuilder3 = default(UriBuilder);
				Func<object, bool> func7 = default(Func<object, bool>);
				string text4 = default(string);
				object obj33;
				while (true)
				{
					if (obj10 != null)
					{
						object obj11 = obj10;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v617 @ X8_v26+12E]");
						Func<string, string> func4 = (Func<string, string>)0;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v617 @ X8_v26+12E]");
						if ((nint)0 == 0)
						{
							goto IL_0200;
						}
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v617 @ X8_v26+B0]");
						object obj12 = (nint)0 + (nint)8;
						while (true)
						{
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v728 @ X10_v27-8]");
							obj13 = 0;
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v728 @ X10_v27-8]");
							if (0 == (nint)obj7)
							{
								break;
							}
							obj14 = obj12 + 16;
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v617 @ X8_v26+12E]");
							func4 = (Func<string, string>)(-1);
							bool flag8 = (nint)func4 != 1;
							obj12 = obj14;
							if (flag8)
							{
								continue;
							}
							goto IL_0200;
						}
						func4 = (Func<string, string>)obj12;
						object obj15 = obj11 + obj12;
						obj16 = obj15 + 312;
						obj14 = obj12;
						goto IL_10a7;
					}
					throw new NullReferenceException();
					IL_0200:
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @B0D070");
					array = null;
					goto IL_10a7;
					IL_0305:
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @B0D070");
					array = (string[])1;
					goto IL_1128;
					IL_10a7:
					num3 = (int)obj16;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v791 @ X0_v43+8]");
					num4 = 0;
					Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v791 @ X0_v43] (should have been resolved before IL gen)");
					object obj17 = obj18 & 1;
					if (obj17 == null)
					{
						break;
					}
					if (obj10 != null)
					{
						object obj19 = obj10;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v842 @ X8_v30+12E]");
						Func<string, string> func4 = (Func<string, string>)0;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v842 @ X8_v30+12E]");
						if ((nint)0 == 0)
						{
							goto IL_0305;
						}
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v842 @ X8_v30+B0]");
						object obj20 = (nint)0 + (nint)8;
						while (true)
						{
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v887 @ X10_v22-8]");
							obj13 = 0;
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v887 @ X10_v22-8]");
							if (0 == (nint)obj7)
							{
								break;
							}
							obj14 = obj20 + 16;
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v842 @ X8_v30+12E]");
							func4 = (Func<string, string>)(-1);
							bool flag9 = (nint)func4 != 1;
							obj20 = obj14;
							if (flag9)
							{
								continue;
							}
							goto IL_0305;
						}
						func4 = (Func<string, string>)(obj20 + 1);
						object obj21 = obj19 + (object)func4;
						obj22 = obj21 + 312;
						obj14 = obj20;
						goto IL_1128;
					}
					throw new NullReferenceException();
					IL_1128:
					num3 = (int)obj22;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v911 @ X0_v50+8]");
					num4 = 0;
					Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v911 @ X0_v50] (should have been resolved before IL gen)");
					if (obj23 != null)
					{
						num4 = (int)obj8;
						num3 = (int)obj23;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v187 @ X8_v8 (System.Int32)+130]");
						obj14 = 0;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v445 @ X1_v1 (System.Int32)+130]");
						Func<string, string> func4 = (Func<string, string>)0;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v187 @ X8_v8 (System.Int32)+130]");
						nint num6 = 0;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v445 @ X1_v1 (System.Int32)+130]");
						bool flag10 = num6 < 0;
						object obj24 = !flag10;
						object obj25 = ~obj24;
						if (obj25 == null)
						{
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v187 @ X8_v8 (System.Int32)+C8]");
							nint num7 = 0;
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v445 @ X1_v1 (System.Int32)+130]");
							object obj26 = num7 + 0;
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v927 @ X8_v36-8]");
							num3 = 0;
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v927 @ X8_v36-8]");
							if ((nint)0 == num4)
							{
								Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v914 @ X0_v52+10]");
								num4 = 0;
								Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v914 @ X0_v52+10]");
								int count2 = (int)(-num);
								Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v914 @ X0_v52+10]");
								if ((nint)0 > (nint)num)
								{
									if (stringBuilder == null)
									{
										throw new NullReferenceException();
									}
									StringBuilder stringBuilder2 = stringBuilder.Append(text, num, count2);
									Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v914 @ X0_v52+10]");
									num4 = 0;
									num8 = unchecked((nint)null);
									array = (string[])num;
									Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v914 @ X0_v52+10]");
									num = 0;
								}
								if (text != null)
								{
									int startIndex = num4;
									Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v914 @ X0_v52+14]");
									string text2 = text.Substring(startIndex, 0);
									bool flag11 = allowedDomains == null;
									object obj27 = obj28;
									UriBuilder uriBuilder = uriBuilder2;
									Func<string, string> func5 = null;
									Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v914 @ X0_v52+14]");
									string[] array2 = (string[])0;
									Func<object, bool> func6 = (Func<object, bool>)num4;
									if (!flag11)
									{
										object obj29 = (nint)0 + (nint)2376;
										func6 = (Func<object, bool>)obj29;
										bool flag12 = Enumerable.Any((IEnumerable<object>)allowedDomains);
										bool flag13 = !flag12;
										obj27 = obj28;
										uriBuilder = uriBuilder2;
										func5 = null;
										Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v914 @ X0_v52+14]");
										array2 = (string[])0;
										if (!flag13)
										{
											num3 = typeof(UnityEngine.Purchasing.Telemetry.TelemetryMetricsInstanceWrapper) + 4032;
											Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
											uriBuilder3..ctor(text2);
											if (uriBuilder3 == null)
											{
												throw new NullReferenceException();
											}
											obj27 = uriBuilder3._host;
											object obj30 = typeof(Func<AndroidJavaObject, IList<HWLocation>>) + 3552;
											Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
											object obj31 = (nint)0 + (nint)784;
											func7..ctor((object)uriBuilder3._host, (IntPtr)obj31);
											num3 = (int)((nint)0 + (nint)2824);
											array2 = (string[])((int*)num3)->m_value;
											bool flag14 = Enumerable.Any(allowedDomains, func7);
											bool flag15 = !flag14;
											uriBuilder = (UriBuilder)(object)func7;
											func5 = null;
											func6 = func7;
											obj28 = uriBuilder3._host;
											uriBuilder2 = (UriBuilder)(object)func7;
											text3 = text2;
											func = null;
											array = (string[])((int*)num3)->m_value;
											num4 = (int)func7;
											if (flag15)
											{
												continue;
											}
										}
									}
									bool flag16 = (nint)func3 == num2;
									obj28 = obj27;
									uriBuilder2 = uriBuilder;
									text3 = text2;
									func = func5;
									func4 = func3;
									array = array2;
									num3 = num2;
									if (flag16)
									{
										break;
									}
									bool flag17 = func2 == null;
									text3 = text2;
									num4 = (int)func6;
									num3 = num2;
									if (!flag17)
									{
										Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v113 @ X3_v7 (System.Func`2<System.String, System.String>)+18]");
										num3 = 0;
										Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v113 @ X3_v7 (System.Func`2<System.String, System.String>)+28]");
										array2 = (string[])0;
										Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v113 @ X3_v7 (System.Func`2<System.String, System.String>)+18] (should have been resolved before IL gen)");
										text3 = text4;
										num4 = (int)text2;
									}
									bool flag18 = stringBuilder == null;
									obj28 = obj27;
									uriBuilder2 = uriBuilder;
									func = func5;
									func4 = func2;
									num9 = (int)(&obj9);
									obj32 = (object)(&obj10);
									obj33 = 0;
									func8 = func2;
									array = array2;
									num5 = (int)stringBuilder;
									if (!flag18)
									{
										StringBuilder stringBuilder3 = stringBuilder.Append(text3);
										Func<string, string> func9 = (Func<string, string>)(func3 + 1);
										Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v914 @ X0_v52+14]");
										num3 = 0;
										Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v914 @ X0_v52+14]");
										num = (int)((nint)0 + (nint)num);
										obj28 = obj27;
										uriBuilder2 = uriBuilder;
										func = func5;
										func4 = func2;
										func3 = func9;
										array = null;
										num4 = (int)text3;
										continue;
									}
									goto IL_0e58;
								}
								throw new NullReferenceException();
							}
						}
						throw new InvalidCastException();
					}
					throw new NullReferenceException();
				}
				obj34 = typeof(UnityEngine.TextCore.HorizontalAlignment) + 2344;
				num4 = (int)obj34;
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1958");
				bool flag19 = obj35 == null;
				num9 = (int)(&obj9);
				obj32 = (object)(&obj10);
				obj33 = 0;
				func8 = func2;
				obj36 = 0;
				num5 = (int)stringBuilder;
				obj37 = 9;
				obj38 = obj13;
				obj39 = obj28;
				uriBuilder4 = uriBuilder2;
				text5 = text3;
				num10 = num8;
				func10 = func;
				obj40 = obj14;
				num11 = (int)(&obj9);
				obj41 = (object)(&obj10);
				obj33 = 0;
				func11 = func3;
				obj42 = obj7;
				func12 = func2;
				array3 = array;
				num12 = num;
				obj43 = 0;
				num13 = (int)stringBuilder;
				obj44 = 9;
				if (!flag19)
				{
					goto IL_091e;
				}
				goto IL_120f;
			}
		}
		goto IL_0e42;
		IL_0e58:
		throw new NullReferenceException();
		IL_09ba:
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @B0D070");
		array3 = null;
		int num14 = default(int);
		num3 = num14;
		goto IL_12e3;
		IL_12e3:
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v187 @ X8_v8 (System.Int32)+8]");
		num4 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: v187.m_value (System.Int32) (should have been resolved before IL gen)");
		obj38 = obj13;
		obj39 = obj28;
		uriBuilder4 = uriBuilder2;
		text5 = text3;
		num10 = num8;
		func10 = func;
		obj40 = obj14;
		num11 = num9;
		obj41 = obj32;
		func11 = func3;
		obj42 = obj7;
		func12 = func8;
		num12 = num;
		obj43 = obj36;
		num13 = num5;
		obj44 = obj37;
		goto IL_120f;
		IL_120f:
		object obj46 = default(object);
		string result2 = default(string);
		while (true)
		{
			bool flag20 = obj43 == null;
			object obj45 = !flag20;
			obj13 = obj38;
			obj28 = obj39;
			uriBuilder2 = uriBuilder4;
			text3 = text5;
			num8 = num10;
			func = func10;
			obj14 = obj40;
			num9 = num11;
			obj32 = obj41;
			func3 = func11;
			obj7 = obj42;
			func8 = func12;
			array = array3;
			num = num12;
			num5 = num13;
			if (obj45 == null)
			{
				break;
			}
			OutOfMemoryException ex = new OutOfMemoryException();
			obj34 = typeof(UnityEngine.TextCore.HorizontalAlignment) + 2344;
			if (num4 == 1)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @6CB0B80");
				obj36 = obj46;
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @6CB0BB0");
				num4 = (int)obj34;
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1958");
				bool flag21 = obj35 == null;
				object obj47 = !flag21;
				object obj33 = obj46;
				obj37 = 0;
				if (obj47 == null)
				{
					obj38 = obj13;
					obj39 = obj28;
					uriBuilder4 = uriBuilder2;
					text5 = text3;
					num10 = num8;
					func10 = func;
					obj40 = obj14;
					num11 = num9;
					obj41 = obj32;
					obj33 = obj46;
					func11 = func3;
					obj42 = obj7;
					func12 = func8;
					array3 = array;
					num12 = num;
					obj43 = obj46;
					num13 = num5;
					obj44 = 0;
					continue;
				}
				goto IL_091e;
			}
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @1C99B68");
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @6CB03A0");
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2B060");
			return result2;
		}
		if ((nint)obj44 != 9)
		{
			bool flag22 = obj44 == null;
			object obj48 = !flag22;
			result = text;
			if (obj48 != null)
			{
				goto IL_106e;
			}
		}
		bool flag23 = text == null;
		obj13 = obj38;
		obj28 = obj39;
		uriBuilder2 = uriBuilder4;
		text3 = text5;
		num8 = num10;
		func2 = func10;
		obj14 = obj40;
		num9 = num11;
		obj32 = obj41;
		func3 = func11;
		obj7 = obj42;
		func8 = func12;
		array = array3;
		num = num12;
		num5 = num13;
		if (!flag23)
		{
			num3 = text._stringLength;
			int num15 = text._stringLength - num12;
			if (text._stringLength > num12)
			{
				bool flag24 = num13 == 0;
				obj13 = obj38;
				obj28 = obj39;
				uriBuilder2 = uriBuilder4;
				text3 = text5;
				num8 = num10;
				func2 = (Func<string, string>)num15;
				obj14 = obj40;
				num9 = num11;
				obj32 = obj41;
				func3 = func11;
				obj7 = obj42;
				func8 = func12;
				array = array3;
				num = num12;
				num5 = num13;
				if (!flag24)
				{
					StringBuilder stringBuilder4 = ((StringBuilder)num13).Append(text, num12, num15);
					num10 = unchecked((nint)null);
					array3 = (string[])num12;
					goto IL_0c80;
				}
			}
			else
			{
				bool flag25 = num13 == 0;
				obj13 = obj38;
				obj28 = obj39;
				uriBuilder2 = uriBuilder4;
				text3 = text5;
				num8 = num10;
				func2 = (Func<string, string>)num15;
				obj14 = obj40;
				num9 = num11;
				obj32 = obj41;
				func3 = func11;
				obj7 = obj42;
				func8 = func12;
				array = array3;
				num = num12;
				num5 = num13;
				if (!flag25)
				{
					goto IL_0c80;
				}
			}
		}
		goto IL_0e42;
		IL_0e42:
		NullReferenceException ex2 = new NullReferenceException();
		func = func2;
		goto IL_0e58;
		IL_106e:
		return result;
		IL_0c80:
		int value2 = ((int*)num13)->m_value;
		Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v504 @ X8_v10 (System.Int32)+168] (should have been resolved before IL gen)");
		string text6 = default(string);
		result = text6;
		goto IL_106e;
		IL_091e:
		object obj49 = obj35;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v715 @ X8_v16+12E]");
		object obj50 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v715 @ X8_v16+12E]");
		if ((nint)0 == 0)
		{
			goto IL_09ba;
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v715 @ X8_v16+B0]");
		object obj51 = (nint)0 + (nint)8;
		while (true)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v808 @ X10_v12-8]");
			obj13 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v808 @ X10_v12-8]");
			if (0 == (nint)obj34)
			{
				break;
			}
			obj14 = obj51 + 16;
			obj50--;
			bool flag26 = (nint)obj50 != 1;
			obj51 = obj14;
			if (flag26)
			{
				continue;
			}
			goto IL_09ba;
		}
		object obj52 = obj49 + obj51;
		num3 = obj52 + 312;
		obj14 = obj51;
		array3 = array;
		goto IL_12e3;
	}

	public unsafe static string ToSHA256Base64(string value)
	{
		//IL_0034: Expected O, but got I4
		//IL_02ed: Expected O, but got I
		//IL_0052: Expected I, but got O
		//IL_0062: Expected O, but got I
		//IL_0072: Expected O, but got I
		//IL_030c: Expected O, but got I4
		//IL_00c0: Unknown result type (might be due to invalid IL or missing references)
		//IL_00c5: Expected O, but got Unknown
		//IL_00ff: Expected O, but got I4
		//IL_0141: Expected O, but got I4
		//IL_014a: Expected O, but got I4
		//IL_015b: Expected O, but got I4
		//IL_0170: Expected I, but got O
		//IL_0179: Expected O, but got I4
		//IL_0182: Expected O, but got I4
		//IL_0193: Expected O, but got I4
		//IL_0372: Expected O, but got I4
		//IL_0410: Expected O, but got I4
		//IL_01b0: Unknown result type (might be due to invalid IL or missing references)
		//IL_01b5: Expected O, but got Unknown
		//IL_01bd: Expected I, but got O
		//IL_01cd: Expected O, but got I
		//IL_0274: Expected O, but got I4
		//IL_03b5: Expected I, but got O
		//IL_0208: Expected O, but got I
		//IL_042e: Expected O, but got I
		//IL_0289: Unknown result type (might be due to invalid IL or missing references)
		//IL_028e: Expected O, but got Unknown
		//IL_0297: Unknown result type (might be due to invalid IL or missing references)
		//IL_029c: Expected O, but got Unknown
		//IL_0216: Unknown result type (might be due to invalid IL or missing references)
		//IL_021b: Expected O, but got Unknown
		//IL_0231: Expected O, but got I
		bool flag = value == null;
		string result = null;
		if (flag)
		{
			goto IL_02b9;
		}
		SHA256 sHA = SHA256.Create();
		Encoding aSCII = Encoding.ASCII;
		bool flag2 = aSCII == null;
		object obj = 0;
		object obj2 = default(object);
		nint num = (nint)(&obj2);
		if (flag2)
		{
			goto IL_02dc;
		}
		num = (nint)aSCII;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v160 @ X8_v6 (Il2CppClass<System.Text.Encoding>)+258]");
		object obj3 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v160 @ X8_v6 (Il2CppClass<System.Text.Encoding>)+260]");
		object obj4 = 0;
		byte[] bytes = aSCII.GetBytes(value);
		string text;
		object obj8;
		SHA256 sHA2;
		object obj9;
		object obj10;
		object obj11 = default(object);
		object obj12;
		object obj13 = default(object);
		nint num2 = default(nint);
		object obj14;
		if (sHA != null)
		{
			byte[] inArray = sHA.ComputeHash(bytes);
			object obj5 = typeof(System.Runtime.Remoting.Messaging.CallContextSecurityData) + 3016;
			object obj6 = obj5;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v204 @ X0_v34+E4]");
			num = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v204 @ X0_v34+E4]");
			bool flag3 = (nint)0 == 0;
			object obj7 = !flag3;
			if (obj7 == null)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			}
			text = Convert.ToBase64String(inArray);
			bool flag4 = sHA == null;
			obj8 = 0;
			obj = 0;
			sHA2 = sHA;
			obj9 = 0;
			obj10 = obj11;
			obj12 = obj13;
			num2 = unchecked((nint)null);
			obj4 = 0;
			obj = 0;
			result = text;
			obj14 = 0;
			if (!flag4)
			{
				goto IL_01a1;
			}
			goto IL_03f6;
		}
		NullReferenceException ex = new NullReferenceException();
		byte[] array = bytes;
		obj = 0;
		goto IL_0317;
		IL_0317:
		if ((nint)array == 1)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @6CB0B80");
			object obj15 = default(object);
			obj9 = obj15;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @6CB0BB0");
			bool flag5 = sHA == null;
			object obj16 = !flag5;
			obj8 = obj4;
			obj = obj15;
			text = null;
			sHA2 = sHA;
			if (obj16 != null)
			{
				goto IL_01a1;
			}
			obj10 = obj11;
			obj12 = obj13;
			num2 = (nint)array;
			obj = obj15;
			result = null;
			obj14 = obj15;
			goto IL_03f6;
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @1C99C14");
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @6CB03A0");
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2B060");
		string result2 = default(string);
		return result2;
		IL_02dc:
		ex = new NullReferenceException();
		array = (byte[])num2;
		goto IL_0317;
		IL_02b9:
		return result;
		IL_03f6:
		bool flag6 = obj14 == null;
		object obj17 = !flag6;
		if (obj17 != null)
		{
			OutOfMemoryException ex2 = new OutOfMemoryException();
			obj11 = obj10;
			obj13 = obj12;
			goto IL_02dc;
		}
		goto IL_02b9;
		IL_0452:
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v344 @ X0_v23+8]");
		num2 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v344 @ X0_v23] (should have been resolved before IL gen)");
		obj10 = obj11;
		obj12 = obj13;
		string text2;
		result = text2;
		obj14 = obj9;
		goto IL_03f6;
		IL_0259:
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @B0D070");
		text2 = text;
		obj4 = 0;
		goto IL_0452;
		IL_01a1:
		object obj18 = typeof(UnityEngine.TextCore.HorizontalAlignment) + 2344;
		nint num3 = (nint)sHA2;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v261 @ X8_v11 (Il2CppClass<System.Security.Cryptography.SHA256>)+12E]");
		obj3 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v261 @ X8_v11 (Il2CppClass<System.Security.Cryptography.SHA256>)+12E]");
		if ((nint)0 == 0)
		{
			goto IL_0259;
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v261 @ X8_v11 (Il2CppClass<System.Security.Cryptography.SHA256>)+B0]");
		object obj19 = (nint)0 + (nint)8;
		while (true)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v328 @ X10_v10-8]");
			obj11 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v328 @ X10_v10-8]");
			if (0 == (nint)obj18)
			{
				break;
			}
			obj13 = obj19 + 16;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v261 @ X8_v11 (Il2CppClass<System.Security.Cryptography.SHA256>)+12E]");
			obj3 = -1;
			bool flag7 = (nint)obj3 != 1;
			obj19 = obj13;
			if (flag7)
			{
				continue;
			}
			goto IL_0259;
		}
		obj3 = obj19;
		object obj20 = num3 + obj19;
		object obj21 = obj20 + 312;
		text2 = text;
		obj13 = obj19;
		obj4 = obj8;
		goto IL_0452;
	}

	static StringsExtensions()
	{
		//IL_000f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0014: Expected O, but got Unknown
		//IL_001e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0023: Expected O, but got Unknown
		//IL_0032: Unknown result type (might be due to invalid IL or missing references)
		//IL_0037: Expected O, but got Unknown
		object obj = typeof(System.Buffers.Text.ParserHelpers) + 3920;
		object pattern = "&action=sign-up" + 2504;
		object obj2 = typeof(System.Formats.Asn1.SetOfValueComparer) + 2536;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
		Regex regex = default(Regex);
		regex..ctor((string)pattern);
		object obj3 = obj2;
		object obj4 = regex;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
	}
}

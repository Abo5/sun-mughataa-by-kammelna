using System;
using System.Buffers.Text;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlTypes;
using System.Formats.Asn1;
using System.Globalization;
using System.Linq;
using System.Runtime.Remoting.Messaging;
using System.Text.RegularExpressions;
using ArabicSupport;
using Cpp2ILInjected;
using HuaweiMobileServices.Location.Location;
using Microsoft.Extensions.DependencyInjection.ServiceLookup;
using Newtonsoft.Json.Linq.JsonPath;
using Unity.Properties;
using UnityEngine;
using UnityEngine.Purchasing.Telemetry;
using Util;

public static class LocalizationUtil
{
	[Serializable]
	private sealed class <>c
	{
		public static readonly <>c <>9;

		public static Func<char, bool> <>9__9_1;

		public static Func<char, bool> <>9__9_2;

		public static Func<string, int, string> <>9__9_3;

		public static Func<string, string> <>9__9_0;

		public static Func<char, bool> <>9__13_0;

		static <>c()
		{
			//IL_000f: Unknown result type (might be due to invalid IL or missing references)
			//IL_0014: Expected O, but got Unknown
			object obj = typeof(InvitationsNotifier.<>c__DisplayClass16_0) + 2224;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
			object obj2 = default(object);
			obj2..ctor();
			object obj3 = obj;
			object obj4 = obj2;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
		}

		internal string <FixArabicMultipleLines>b__9_0(string line)
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
			//IL_0465: Expected O, but got I
			//IL_0475: Expected O, but got I
			//IL_0497: Expected O, but got I4
			//IL_024f: Expected O, but got I
			//IL_025f: Expected O, but got I
			//IL_01cc: Expected O, but got I4
			//IL_0562: Unknown result type (might be due to invalid IL or missing references)
			//IL_0567: Expected O, but got Unknown
			//IL_04c7: Expected O, but got I4
			//IL_085e: Unknown result type (might be due to invalid IL or missing references)
			//IL_0863: Expected O, but got Unknown
			//IL_0879: Expected O, but got I
			//IL_088a: Expected I, but got O
			//IL_08a8: Expected O, but got I
			//IL_08c3: Expected O, but got I4
			//IL_0679: Expected O, but got I
			//IL_0693: Expected O, but got I4
			//IL_02e3: Unknown result type (might be due to invalid IL or missing references)
			//IL_02e8: Expected O, but got Unknown
			//IL_091b: Unknown result type (might be due to invalid IL or missing references)
			//IL_0920: Expected O, but got Unknown
			//IL_0936: Expected O, but got I
			//IL_0947: Expected I, but got O
			//IL_0965: Expected O, but got I
			//IL_01fc: Expected O, but got I
			//IL_05aa: Expected O, but got I
			//IL_052c: Expected O, but got I4
			//IL_0535: Expected O, but got I4
			//IL_04f7: Expected O, but got I
			//IL_06d1: Expected O, but got I4
			//IL_0711: Expected O, but got I4
			//IL_0746: Expected O, but got I
			//IL_0756: Expected O, but got I
			//IL_0778: Expected O, but got I4
			//IL_0798: Expected O, but got I
			//IL_08f6: Expected O, but got I
			//IL_03de: Expected O, but got I
			//IL_03ee: Expected O, but got I
			//IL_0410: Expected O, but got I4
			//IL_07c8: Expected O, but got I4
			//IL_098b: Unknown result type (might be due to invalid IL or missing references)
			//IL_0990: Expected O, but got Unknown
			//IL_09a6: Expected O, but got I
			//IL_09b7: Expected I, but got O
			//IL_09d5: Expected O, but got I
			//IL_043e: Expected O, but got I
			//IL_07f8: Expected O, but got I
			object obj = 152981504;
			object obj2 = typeof(InvitationsNotifier.<>c__DisplayClass16_0) + 2224;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [91E5DEB]");
			object obj3 = (nint)0 & (nint)1;
			object obj4;
			if (obj3 != null)
			{
				obj4 = obj2;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v100 @ X0_v71+E4]");
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
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v100 @ X0_v71+E4]");
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
			object obj7 = (nint)0 + (nint)3504;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v100 @ X0_v71+B8]");
			object obj8 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v114 @ X8_v55+8]");
			Func<char, bool> predicate = (Func<char, bool>)0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v114 @ X8_v55+8]");
			bool flag3 = (nint)0 == 0;
			object obj9 = !flag3;
			object obj10 = obj7;
			if (obj9 == null)
			{
				goto IL_01aa;
			}
			goto IL_0201;
			IL_0841:
			return (string)(object)new NullReferenceException();
			IL_0553:
			object obj11 = typeof(Newtonsoft.Json.Linq.JsonPath.JPath) + 2656;
			object obj12 = obj11;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v236 @ X0_v6+E4]");
			if ((nint)0 != 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [91E5DE6]");
				object obj13 = (nint)0 & (nint)1;
				if (obj13 != null)
				{
					goto IL_05c7;
				}
			}
			else
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [91E5DE6]");
				object obj14 = (nint)0 & (nint)1;
				bool flag4 = obj14 == null;
				object obj15 = !flag4;
				if (obj15 != null)
				{
					goto IL_05c7;
				}
			}
			_ = 1;
			object obj16 = obj11;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v332 @ X0_v9+E4]");
			bool flag5 = (nint)0 == 0;
			object obj17 = !flag5;
			if (obj17 != null)
			{
				goto IL_05f4;
			}
			goto IL_06df;
			IL_0284:
			object obj18 = obj10;
			Func<char, bool> func;
			int num = Enumerable.Count(line, func);
			int num2;
			bool flag6 = num2 != num;
			object obj20 = default(object);
			object obj19 = obj20;
			Func<char, bool> func2 = func;
			object obj21 = obj10;
			if (!flag6)
			{
				goto IL_02d4;
			}
			goto IL_0553;
			IL_0085:
			obj10 = (nint)0 + (nint)3504;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v100 @ X0_v71+B8]");
			obj8 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v114 @ X8_v55+8]");
			predicate = (Func<char, bool>)0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v114 @ X8_v55+8]");
			bool flag7 = (nint)0 == 0;
			object obj22 = !flag7;
			if (obj22 == null)
			{
				obj7 = obj10;
				goto IL_01aa;
			}
			goto IL_0201;
			IL_07a6:
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v472 @ X0_v57+E4]");
			bool flag8 = (nint)0 == 0;
			object obj23 = !flag8;
			object obj25;
			if (obj23 == null)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
				object obj24 = obj2;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v487 @ X8_v47+B8]");
				obj25 = 0;
			}
			object obj26 = typeof(Func<Type, Microsoft.Extensions.DependencyInjection.ServiceLookup.ServiceCallSite>) + 1000;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
			object obj27 = (nint)0 + (nint)4048;
			Func<object, int, object> func3 = default(Func<object, int, object>);
			func3..ctor(obj25, (IntPtr)obj27);
			object obj28 = obj2;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v458 @ X8_v46+B8]");
			object obj29 = (nint)0 + (nint)24;
			obj29 = func3;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
			string[] array;
			string[] source = array;
			Func<object, int, object> selector = func3;
			goto IL_08d8;
			IL_01aa:
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v100 @ X0_v71+E4]");
			bool flag9 = (nint)0 == 0;
			object obj30 = !flag9;
			if (obj30 == null)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
				object obj31 = obj2;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v127 @ X8_v61+B8]");
				obj8 = 0;
			}
			object obj32 = typeof(Func<AndroidJavaObject, IList<HWLocation>>) + 544;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
			object obj33 = (nint)0 + (nint)4032;
			Func<char, bool> func4 = default(Func<char, bool>);
			func4..ctor(obj8, (IntPtr)obj33);
			object obj34 = obj2;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v86 @ X8_v60+B8]");
			object obj35 = (nint)0 + (nint)8;
			obj35 = func4;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
			obj20 = 0;
			obj10 = obj7;
			predicate = func4;
			goto IL_0201;
			IL_05c7:
			obj16 = obj11;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v332 @ X0_v9+E4]");
			if ((nint)0 != 0)
			{
				goto IL_05f4;
			}
			goto IL_06df;
			IL_02d4:
			object obj36 = typeof(TypeConverter<ushort, char>) + 1952;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC18B4");
			char[] array2 = default(char[]);
			if (array2 != null)
			{
				if (array2.Length != 0)
				{
					array2[0] = '<';
					if (array2.Length != 1)
					{
						array2[1] = '>';
						if (line == null)
						{
							goto IL_0841;
						}
						string[] array3 = line.Split(array2);
						object obj37 = obj2;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v472 @ X0_v57+E4]");
						if ((nint)0 != 0)
						{
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v472 @ X0_v57+B8]");
							obj25 = 0;
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v481 @ X8_v41+18]");
							selector = (Func<object, int, object>)0;
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v481 @ X8_v41+18]");
							bool flag10 = (nint)0 == 0;
							object obj38 = !flag10;
							source = array3;
							if (obj38 == null)
							{
								array = array3;
								Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v481 @ X8_v41+18]");
								Func<object, int, object> func5 = (Func<object, int, object>)0;
								goto IL_07a6;
							}
						}
						else
						{
							Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
							obj37 = obj2;
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v472 @ X0_v57+B8]");
							obj25 = 0;
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v481 @ X8_v41+18]");
							Func<object, int, object> func5 = (Func<object, int, object>)0;
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v481 @ X8_v41+18]");
							bool flag11 = (nint)0 == 0;
							object obj39 = !flag11;
							array = array3;
							source = array3;
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v481 @ X8_v41+18]");
							selector = (Func<object, int, object>)0;
							if (obj39 == null)
							{
								goto IL_07a6;
							}
						}
						goto IL_08d8;
					}
				}
				IndexOutOfRangeException ex = new IndexOutOfRangeException();
			}
			goto IL_0841;
			IL_0201:
			num2 = Enumerable.Count(line, predicate);
			object obj40 = obj2;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v144 @ X0_v31+E4]");
			object obj41;
			if ((nint)0 != 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v144 @ X0_v31+B8]");
				obj41 = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v168 @ X8_v19+10]");
				func = (Func<char, bool>)0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v168 @ X8_v19+10]");
				if ((nint)0 != 0)
				{
					goto IL_0284;
				}
			}
			else
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
				obj40 = obj2;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v144 @ X0_v31+B8]");
				obj41 = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v168 @ X8_v19+10]");
				func = (Func<char, bool>)0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v168 @ X8_v19+10]");
				bool flag12 = (nint)0 == 0;
				object obj42 = !flag12;
				if (obj42 != null)
				{
					goto IL_0284;
				}
			}
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v144 @ X0_v31+E4]");
			bool flag13 = (nint)0 == 0;
			object obj43 = !flag13;
			if (obj43 == null)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
				object obj44 = obj2;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v239 @ X8_v25+B8]");
				obj41 = 0;
			}
			object obj45 = typeof(Func<AndroidJavaObject, IList<HWLocation>>) + 544;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
			object obj46 = (nint)0 + (nint)4040;
			Func<char, bool> func6 = default(Func<char, bool>);
			func6..ctor(obj41, (IntPtr)obj46);
			object obj47 = obj2;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v210 @ X8_v24+B8]");
			object obj48 = (nint)0 + (nint)16;
			obj48 = func6;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
			obj18 = obj10;
			int num3 = Enumerable.Count(line, func6);
			bool flag14 = num2 == num3;
			obj20 = 0;
			obj19 = 0;
			func2 = func6;
			obj21 = obj10;
			if (flag14)
			{
				goto IL_02d4;
			}
			goto IL_0553;
			IL_071f:
			return line;
			IL_05f4:
			if (ShouldFixArabic(line))
			{
				goto IL_061a;
			}
			goto IL_071f;
			IL_06df:
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			bool flag15 = ShouldFixArabic(line);
			bool flag16 = !flag15;
			object obj49 = !flag16;
			if (obj49 != null)
			{
				goto IL_061a;
			}
			goto IL_071f;
			IL_08d8:
			IEnumerable<object> values = Enumerable.Select(source, selector);
			object separator = (nint)0 + (nint)2000;
			return string.Join((string)separator, (IEnumerable<string>)values);
			IL_061a:
			object obj50 = obj11;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v425 @ X0_v20+E4]");
			if ((nint)0 != 0)
			{
				return FixArabicHelper(line);
			}
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			return FixArabicHelper(line);
		}

		internal bool <FixArabicMultipleLines>b__9_1(char c)
		{
			//IL_000e: Expected O, but got I4
			object obj = c - 60;
			return obj == null;
		}

		internal bool <FixArabicMultipleLines>b__9_2(char c)
		{
			//IL_000e: Expected O, but got I4
			object obj = c - 62;
			return obj == null;
		}

		internal string <FixArabicMultipleLines>b__9_3(string word, int i)
		{
			//IL_000f: Unknown result type (might be due to invalid IL or missing references)
			//IL_0014: Expected O, but got Unknown
			//IL_0277: Expected O, but got I4
			//IL_015a: Expected O, but got I
			//IL_0174: Expected O, but got I4
			//IL_0054: Expected O, but got I
			//IL_01b2: Expected O, but got I4
			//IL_01f2: Expected O, but got I4
			object obj = typeof(Newtonsoft.Json.Linq.JsonPath.JPath) + 2656;
			object obj2 = obj;
			int num = i & 1;
			bool flag = num == 0;
			object obj3 = !flag;
			object obj7;
			if (obj3 == null)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v45 @ X0_v2+E4]");
				if ((nint)0 != 0)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [91E5DE6]");
					object obj4 = (nint)0 & (nint)1;
					if (obj4 != null)
					{
						goto IL_0071;
					}
				}
				else
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [91E5DE6]");
					object obj5 = (nint)0 & (nint)1;
					bool flag2 = obj5 == null;
					object obj6 = !flag2;
					if (obj6 != null)
					{
						goto IL_0071;
					}
				}
				_ = 1;
				obj7 = obj;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v102 @ X0_v10+E4]");
				bool flag3 = (nint)0 == 0;
				object obj8 = !flag3;
				if (obj8 != null)
				{
					goto IL_009e;
				}
				goto IL_01c0;
			}
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v45 @ X0_v2+E4]");
			if ((nint)0 != 0)
			{
				return FixTag(word);
			}
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			return FixTag(word);
			IL_0071:
			obj7 = obj;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v102 @ X0_v10+E4]");
			if ((nint)0 != 0)
			{
				goto IL_009e;
			}
			goto IL_01c0;
			IL_0200:
			return word;
			IL_00c4:
			object obj9 = obj;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v151 @ X0_v21+E4]");
			if ((nint)0 != 0)
			{
				return FixArabicHelper(word);
			}
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			return FixArabicHelper(word);
			IL_01c0:
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			bool flag4 = ShouldFixArabic(word);
			bool flag5 = !flag4;
			object obj10 = !flag5;
			if (obj10 != null)
			{
				goto IL_00c4;
			}
			goto IL_0200;
			IL_009e:
			if (ShouldFixArabic(word))
			{
				goto IL_00c4;
			}
			goto IL_0200;
		}

		internal bool <IsArabicFixed>b__13_0(char c)
		{
			//IL_000e: Expected O, but got I4
			//IL_0017: Unknown result type (might be due to invalid IL or missing references)
			//IL_001c: Expected O, but got Unknown
			//IL_0036: Expected O, but got I4
			//IL_003f: Expected I4, but got O
			object obj = c + 400;
			object obj2 = obj & 0xFFFF;
			bool flag = (nint)obj2 < 141;
			object obj3 = !flag;
			return (byte)(int)(~obj3) != 0;
		}
	}

	private static readonly Regex ArabicCharactersRegex;

	public static string Localize(string input)
	{
		//IL_0009: Expected O, but got I4
		//IL_0018: Unknown result type (might be due to invalid IL or missing references)
		//IL_001d: Expected O, but got Unknown
		//IL_0033: Expected O, but got I
		//IL_00c0: Expected O, but got I4
		object obj = 152981504;
		object obj2 = typeof(Newtonsoft.Json.Linq.JsonPath.JPath) + 2648;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [91E5DE1]");
		object obj3 = (nint)0 & (nint)1;
		if (obj3 != null)
		{
			object obj4 = obj2;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v58 @ X0_v1+E4]");
			if ((nint)0 != 0)
			{
				goto IL_007d;
			}
		}
		else
		{
			_ = 1;
			object obj4 = obj2;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v58 @ X0_v1+E4]");
			bool flag = (nint)0 == 0;
			object obj5 = !flag;
			if (obj5 != null)
			{
				goto IL_007d;
			}
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		return LocalizationText.GetText(input);
		IL_007d:
		return LocalizationText.GetText(input);
	}

	public static string Localize(string input, long quantity)
	{
		//IL_000f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0014: Expected O, but got Unknown
		//IL_002a: Expected O, but got I
		//IL_00ba: Expected O, but got I4
		object obj = typeof(Newtonsoft.Json.Linq.JsonPath.JPath) + 2648;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [91E5CB7]");
		object obj2 = (nint)0 & (nint)1;
		if (obj2 != null)
		{
			object obj3 = obj;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v59 @ X0_v1+E4]");
			if ((nint)0 != 0)
			{
				goto IL_0074;
			}
		}
		else
		{
			_ = 1;
			object obj3 = obj;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v59 @ X0_v1+E4]");
			bool flag = (nint)0 == 0;
			object obj4 = !flag;
			if (obj4 != null)
			{
				goto IL_0074;
			}
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		return LocalizationText.GetText(input, quantity);
		IL_0074:
		return LocalizationText.GetText(input, quantity);
	}

	public static string Localize(string input, object[] formattedArguments)
	{
		//IL_000f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0014: Expected O, but got Unknown
		//IL_007b: Expected O, but got I4
		object obj = typeof(Newtonsoft.Json.Linq.JsonPath.JPath) + 2648;
		object obj2 = obj;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v45 @ X0_v2+E4]");
		bool flag = (nint)0 == 0;
		object obj3 = !flag;
		if (obj3 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		}
		string text = LocalizationText.GetText(input);
		return string.Format(text, formattedArguments);
	}

	public static string LocalizeOrdinal(string input, int order)
	{
		//IL_000f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0014: Expected O, but got Unknown
		//IL_002a: Expected O, but got I
		//IL_00ba: Expected O, but got I4
		object obj = typeof(Newtonsoft.Json.Linq.JsonPath.JPath) + 2648;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [91E5CB9]");
		object obj2 = (nint)0 & (nint)1;
		if (obj2 != null)
		{
			object obj3 = obj;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v59 @ X0_v1+E4]");
			if ((nint)0 != 0)
			{
				goto IL_0074;
			}
		}
		else
		{
			_ = 1;
			object obj3 = obj;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v59 @ X0_v1+E4]");
			bool flag = (nint)0 == 0;
			object obj4 = !flag;
			if (obj4 != null)
			{
				goto IL_0074;
			}
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		return LocalizationText.GetOrdinalText(input, order);
		IL_0074:
		return LocalizationText.GetOrdinalText(input, order);
	}

	public static string LocalizeAndFix(string input)
	{
		//IL_000f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0014: Expected O, but got Unknown
		//IL_0223: Unknown result type (might be due to invalid IL or missing references)
		//IL_0228: Expected O, but got Unknown
		//IL_0252: Expected O, but got I4
		//IL_0148: Expected O, but got I
		//IL_0162: Expected O, but got I4
		//IL_0079: Expected O, but got I
		//IL_01a0: Expected O, but got I4
		//IL_01e0: Expected O, but got I4
		object obj = typeof(Newtonsoft.Json.Linq.JsonPath.JPath) + 2648;
		object obj2 = typeof(Newtonsoft.Json.Linq.JsonPath.JPath) + 2656;
		object obj3 = obj;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v47 @ X0_v2+E4]");
		bool flag = (nint)0 == 0;
		object obj4 = !flag;
		if (obj4 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		}
		string text = LocalizationText.GetText(input);
		object obj5 = obj2;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v59 @ X0_v6+E4]");
		if ((nint)0 != 0)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [91E5DE3]");
			object obj6 = (nint)0 & (nint)1;
			if (obj6 != null)
			{
				goto IL_0096;
			}
		}
		else
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [91E5DE3]");
			object obj7 = (nint)0 & (nint)1;
			bool flag2 = obj7 == null;
			object obj8 = !flag2;
			if (obj8 != null)
			{
				goto IL_0096;
			}
		}
		_ = 1;
		object obj9 = obj2;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v95 @ X0_v9+E4]");
		bool flag3 = (nint)0 == 0;
		object obj10 = !flag3;
		if (obj10 != null)
		{
			goto IL_00c3;
		}
		goto IL_01ae;
		IL_01ae:
		Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		bool flag4 = ShouldFixArabic(text);
		bool flag5 = !flag4;
		object obj11 = !flag5;
		if (obj11 != null)
		{
			goto IL_00e9;
		}
		goto IL_01ee;
		IL_0096:
		obj9 = obj2;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v95 @ X0_v9+E4]");
		if ((nint)0 != 0)
		{
			goto IL_00c3;
		}
		goto IL_01ae;
		IL_00e9:
		object obj12 = obj2;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v110 @ X0_v20+E4]");
		if ((nint)0 != 0)
		{
			return FixArabicMultipleLines(text);
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		return FixArabicMultipleLines(text);
		IL_01ee:
		return text;
		IL_00c3:
		if (ShouldFixArabic(text))
		{
			goto IL_00e9;
		}
		goto IL_01ee;
	}

	public static string FixArabic(string input)
	{
		//IL_000f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0014: Expected O, but got Unknown
		//IL_002a: Expected O, but got I
		//IL_0109: Expected O, but got I4
		//IL_0149: Expected O, but got I4
		object obj = typeof(Newtonsoft.Json.Linq.JsonPath.JPath) + 2656;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [91E5DE3]");
		object obj2 = (nint)0 & (nint)1;
		if (obj2 != null)
		{
			object obj3 = obj;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v51 @ X0_v3+E4]");
			if ((nint)0 != 0)
			{
				goto IL_0074;
			}
		}
		else
		{
			_ = 1;
			object obj3 = obj;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v51 @ X0_v3+E4]");
			bool flag = (nint)0 == 0;
			object obj4 = !flag;
			if (obj4 != null)
			{
				goto IL_0074;
			}
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		bool flag2 = ShouldFixArabic(input);
		bool flag3 = !flag2;
		object obj5 = !flag3;
		if (obj5 != null)
		{
			goto IL_009a;
		}
		goto IL_0157;
		IL_009a:
		object obj6 = obj;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v64 @ X0_v12+E4]");
		if ((nint)0 != 0)
		{
			return FixArabicMultipleLines(input);
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		return FixArabicMultipleLines(input);
		IL_0157:
		return input;
		IL_0074:
		if (ShouldFixArabic(input))
		{
			goto IL_009a;
		}
		goto IL_0157;
	}

	public static bool ShouldFixArabic(string input)
	{
		//IL_0009: Expected O, but got I4
		//IL_0018: Unknown result type (might be due to invalid IL or missing references)
		//IL_001d: Expected O, but got Unknown
		//IL_0033: Expected O, but got I
		//IL_01ef: Expected O, but got I4
		//IL_0093: Expected O, but got I
		//IL_0275: Expected O, but got I4
		//IL_021d: Expected O, but got I
		//IL_0237: Expected O, but got I4
		//IL_00f3: Expected O, but got I
		//IL_02db: Unknown result type (might be due to invalid IL or missing references)
		//IL_02e0: Expected O, but got Unknown
		//IL_030a: Expected O, but got I4
		//IL_02a3: Expected O, but got I
		//IL_02bd: Expected O, but got I4
		//IL_016c: Expected O, but got I
		//IL_0189: Expected O, but got I
		//IL_01a3: Expected O, but got I4
		//IL_01ac: Expected O, but got I4
		//IL_011a: Unknown result type (might be due to invalid IL or missing references)
		//IL_011f: Expected O, but got Unknown
		//IL_03a1: Unknown result type (might be due to invalid IL or missing references)
		//IL_03a6: Expected O, but got Unknown
		//IL_034a: Expected O, but got I
		//IL_0367: Expected O, but got I
		//IL_04a8: Expected O, but got I
		//IL_04c2: Expected O, but got I4
		//IL_0384: Expected O, but got I4
		//IL_03e9: Expected O, but got I
		//IL_04f0: Expected O, but got I4
		//IL_044d: Expected O, but got I4
		//IL_0522: Expected O, but got I
		//IL_0512: Expected I4, but got O
		object obj = 152981504;
		object obj2 = typeof(Newtonsoft.Json.Linq.JsonPath.JPath) + 2648;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [91E5DE4]");
		object obj3 = (nint)0 & (nint)1;
		if (obj3 != null)
		{
			object obj4 = obj2;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v53 @ X0_v36+E4]");
			if ((nint)0 != 0)
			{
				goto IL_007d;
			}
		}
		else
		{
			_ = 1;
			object obj4 = obj2;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v53 @ X0_v36+E4]");
			bool flag = (nint)0 == 0;
			object obj5 = !flag;
			if (obj5 != null)
			{
				goto IL_007d;
			}
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [91E5DE0]");
		object obj6 = (nint)0 & (nint)1;
		bool flag2 = obj6 == null;
		object obj7 = !flag2;
		if (obj7 != null)
		{
			goto IL_00b0;
		}
		goto IL_0245;
		IL_0406:
		if (input != null)
		{
			goto IL_0423;
		}
		goto IL_04fe;
		IL_0423:
		object obj9;
		object obj8 = obj9;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v235 @ X0_v12+E4]");
		bool flag3 = (nint)0 == 0;
		object obj10 = !flag3;
		if (obj10 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			obj8 = obj9;
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v235 @ X0_v12+B8]");
		object obj11 = 0;
		if (obj11 != null)
		{
			return ((Regex)obj11).IsMatch(input);
		}
		NullReferenceException ex = new NullReferenceException();
		return (byte)(int)ex != 0;
		IL_04fe:
		return false;
		IL_007d:
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [91E5DE0]");
		object obj12 = (nint)0 & (nint)1;
		if (obj12 != null)
		{
			goto IL_00b0;
		}
		goto IL_0245;
		IL_0245:
		_ = 1;
		object obj13 = obj2;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v93 @ X0_v29+E4]");
		bool flag4 = (nint)0 == 0;
		object obj14 = !flag4;
		if (obj14 != null)
		{
			goto IL_00dd;
		}
		goto IL_0283;
		IL_00b0:
		obj13 = obj2;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v93 @ X0_v29+E4]");
		if ((nint)0 != 0)
		{
			goto IL_00dd;
		}
		goto IL_0283;
		IL_0283:
		Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [8BE4587]");
		object obj15 = (nint)0 & (nint)1;
		bool flag5 = obj15 == null;
		object obj16 = !flag5;
		if (obj16 != null)
		{
			goto IL_0110;
		}
		goto IL_02cb;
		IL_00dd:
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [8BE4587]");
		object obj17 = (nint)0 & (nint)1;
		if (obj17 != null)
		{
			goto IL_0110;
		}
		goto IL_02cb;
		IL_02cb:
		_ = 1;
		object obj18 = "<ds.DataTable.OnColumnChanging|INFO> {0}" + 2752;
		object obj19 = obj2;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v123 @ X0_v48+E4]");
		bool flag6 = (nint)0 == 0;
		object obj20 = !flag6;
		object obj21 = obj19;
		object obj22 = obj18;
		if (obj20 != null)
		{
			goto IL_015c;
		}
		goto IL_0328;
		IL_0110:
		obj18 = "<ds.DataTable.OnColumnChanging|INFO> {0}" + 2752;
		obj19 = obj2;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v123 @ X0_v48+E4]");
		bool flag7 = (nint)0 == 0;
		obj21 = obj19;
		obj22 = obj18;
		if (!flag7)
		{
			goto IL_015c;
		}
		goto IL_0328;
		IL_0328:
		Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		object obj23 = obj2;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v146 @ X0_v21+B8]");
		object obj24 = 0;
		string text = (string)obj22;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v147 @ X8_v14+8]");
		bool flag8 = (string)0 == (string)obj22;
		bool flag9 = !flag8;
		object obj25 = 0;
		if (!flag9)
		{
			goto IL_0392;
		}
		goto IL_04fe;
		IL_015c:
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v123 @ X0_v48+B8]");
		object obj26 = 0;
		text = (string)obj18;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v131 @ X8_v28+8]");
		bool flag10 = (string)0 == (string)obj18;
		bool flag11 = !flag10;
		object obj27 = !flag11;
		obj25 = 0;
		if (obj27 != null)
		{
			goto IL_0392;
		}
		goto IL_04fe;
		IL_0392:
		obj9 = typeof(Newtonsoft.Json.Linq.JsonPath.JPath) + 2656;
		object obj28 = obj9;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v161 @ X0_v4+E4]");
		if ((nint)0 != 0)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [91E5DE5]");
			object obj29 = (nint)0 & (nint)1;
			if (obj29 != null)
			{
				goto IL_0406;
			}
		}
		else
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [91E5DE5]");
			object obj30 = (nint)0 & (nint)1;
			bool flag12 = obj30 == null;
			object obj31 = !flag12;
			if (obj31 != null)
			{
				goto IL_0406;
			}
		}
		_ = 1;
		bool flag13 = input == null;
		object obj32 = !flag13;
		if (obj32 != null)
		{
			goto IL_0423;
		}
		goto IL_04fe;
	}

	public static bool HasArabicCharacters(string text)
	{
		//IL_0014: Unknown result type (might be due to invalid IL or missing references)
		//IL_0019: Expected O, but got Unknown
		//IL_0043: Expected O, but got I4
		//IL_00bf: Expected O, but got I
		//IL_0092: Expected I4, but got O
		if (text != null)
		{
			object obj = typeof(Newtonsoft.Json.Linq.JsonPath.JPath) + 2656;
			object obj2 = obj;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v51 @ X0_v4+E4]");
			bool flag = (nint)0 == 0;
			object obj3 = !flag;
			if (obj3 == null)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
				obj2 = obj;
			}
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v51 @ X0_v4+B8]");
			object obj4 = 0;
			if (obj4 != null)
			{
				return ((Regex)obj4).IsMatch(text);
			}
			NullReferenceException ex = new NullReferenceException();
			return (byte)(int)ex != 0;
		}
		return false;
	}

	private static string FixArabicMultipleLines(string input)
	{
		//IL_0111: Expected O, but got I4
		//IL_0121: Expected O, but got I
		//IL_0131: Expected O, but got I
		//IL_0014: Unknown result type (might be due to invalid IL or missing references)
		//IL_0019: Expected O, but got Unknown
		//IL_005a: Expected O, but got I4
		//IL_0160: Expected O, but got I
		//IL_0170: Expected O, but got I
		//IL_0180: Expected O, but got I
		//IL_01a2: Expected O, but got I4
		//IL_00a1: Expected O, but got I4
		//IL_01bf: Unknown result type (might be due to invalid IL or missing references)
		//IL_01c4: Expected O, but got Unknown
		//IL_01da: Expected O, but got I
		//IL_01eb: Expected I, but got O
		//IL_0209: Expected O, but got I
		//IL_00d1: Expected O, but got I
		string text = default(string);
		if (text != null)
		{
			object obj = typeof(InvitationsNotifier.<>c__DisplayClass16_0) + 2224;
			string[] source = text.Split('\n');
			object obj2 = obj;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v115 @ X0_v5+E4]");
			bool flag = (nint)0 == 0;
			object obj3 = !flag;
			if (obj3 == null)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
				obj2 = obj;
			}
			object separator = (nint)0 + (nint)2336;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v115 @ X0_v5+B8]");
			object obj4 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v149 @ X8_v10+20]");
			Func<object, object> selector = (Func<object, object>)0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v149 @ X8_v10+20]");
			bool flag2 = (nint)0 == 0;
			object obj5 = !flag2;
			if (obj5 == null)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v115 @ X0_v5+E4]");
				bool flag3 = (nint)0 == 0;
				object obj6 = !flag3;
				if (obj6 == null)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
					object obj7 = obj;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v156 @ X8_v16+B8]");
					obj4 = 0;
				}
				object obj8 = typeof(Func<AndroidJavaObject, IList<HWLocation>>) + 3640;
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
				object obj9 = (nint)0 + (nint)4024;
				Func<object, object> func = default(Func<object, object>);
				func..ctor(obj4, (IntPtr)obj9);
				object obj10 = obj;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v142 @ X8_v15+B8]");
				object obj11 = (nint)0 + (nint)32;
				obj11 = func;
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
				selector = func;
			}
			IEnumerable<object> values = Enumerable.Select(source, selector);
			return string.Join((string)separator, (IEnumerable<string>)values);
		}
		object obj12 = 153100288 + 1024;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v60 @ X8_v4+90]");
		object obj13 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v61 @ X8_v5+B8]");
		return (string)0;
	}

	private static string FixWord(string input)
	{
		//IL_000f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0014: Expected O, but got Unknown
		//IL_002a: Expected O, but got I
		//IL_0109: Expected O, but got I4
		//IL_0149: Expected O, but got I4
		object obj = typeof(Newtonsoft.Json.Linq.JsonPath.JPath) + 2656;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [91E5DE6]");
		object obj2 = (nint)0 & (nint)1;
		if (obj2 != null)
		{
			object obj3 = obj;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v51 @ X0_v3+E4]");
			if ((nint)0 != 0)
			{
				goto IL_0074;
			}
		}
		else
		{
			_ = 1;
			object obj3 = obj;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v51 @ X0_v3+E4]");
			bool flag = (nint)0 == 0;
			object obj4 = !flag;
			if (obj4 != null)
			{
				goto IL_0074;
			}
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		bool flag2 = ShouldFixArabic(input);
		bool flag3 = !flag2;
		object obj5 = !flag3;
		if (obj5 != null)
		{
			goto IL_009a;
		}
		goto IL_0157;
		IL_009a:
		object obj6 = obj;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v64 @ X0_v12+E4]");
		if ((nint)0 != 0)
		{
			return FixArabicHelper(input);
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		return FixArabicHelper(input);
		IL_0157:
		return input;
		IL_0074:
		if (ShouldFixArabic(input))
		{
			goto IL_009a;
		}
		goto IL_0157;
	}

	private static string FixTag(string input)
	{
		//IL_0009: Expected O, but got I4
		//IL_0018: Unknown result type (might be due to invalid IL or missing references)
		//IL_001d: Expected O, but got Unknown
		//IL_0033: Expected O, but got I
		//IL_0215: Expected O, but got I4
		//IL_00a2: Expected O, but got I
		//IL_00c1: Expected O, but got I
		//IL_04ea: Expected O, but got I
		//IL_0504: Expected O, but got I4
		//IL_0257: Expected O, but got I
		//IL_0271: Expected O, but got I4
		//IL_0281: Expected O, but got I
		//IL_02ca: Expected O, but got I
		//IL_03f9: Expected O, but got I
		//IL_0413: Expected O, but got I4
		//IL_0542: Expected O, but got I4
		//IL_010a: Expected O, but got I
		//IL_0582: Expected O, but got I4
		//IL_0451: Expected O, but got I4
		//IL_034c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0351: Expected O, but got Unknown
		//IL_035b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0360: Expected O, but got Unknown
		//IL_0382: Expected O, but got I4
		//IL_059a: Unknown result type (might be due to invalid IL or missing references)
		//IL_059f: Expected O, but got Unknown
		//IL_05a9: Unknown result type (might be due to invalid IL or missing references)
		//IL_05ae: Expected O, but got Unknown
		//IL_0491: Expected O, but got I4
		//IL_018c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0191: Expected O, but got Unknown
		//IL_019b: Unknown result type (might be due to invalid IL or missing references)
		//IL_01a0: Expected O, but got Unknown
		//IL_01c2: Expected O, but got I4
		//IL_04a9: Unknown result type (might be due to invalid IL or missing references)
		//IL_04ae: Expected O, but got Unknown
		//IL_04b8: Unknown result type (might be due to invalid IL or missing references)
		//IL_04bd: Expected O, but got Unknown
		object obj = 152981504;
		object obj2 = typeof(Newtonsoft.Json.Linq.JsonPath.JPath) + 2656;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [91E5DE7]");
		object obj3 = (nint)0 & (nint)1;
		if (obj3 != null)
		{
			object obj4 = obj2;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v51 @ X0_v28+E4]");
			if ((nint)0 != 0)
			{
				goto IL_007d;
			}
		}
		else
		{
			_ = 1;
			object obj4 = obj2;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v51 @ X0_v28+E4]");
			bool flag = (nint)0 == 0;
			object obj5 = !flag;
			if (obj5 != null)
			{
				goto IL_007d;
			}
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		bool flag2 = ShouldFixArabic(input);
		object obj6 = obj2;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v70 @ X0_v43+E4]");
		object obj7 = 0;
		bool flag3 = !flag2;
		object obj8 = !flag3;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v70 @ X0_v43+E4]");
		object obj9 = 0;
		object obj10 = obj6;
		if (obj8 != null)
		{
			goto IL_00d7;
		}
		goto IL_0297;
		IL_045f:
		Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		bool flag4 = ShouldFixArabic(input);
		bool flag5 = !flag4;
		object obj11 = !flag5;
		if (obj11 != null)
		{
			goto IL_017a;
		}
		goto IL_049f;
		IL_0127:
		object obj12 = obj2;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v143 @ X0_v45+E4]");
		if ((nint)0 != 0)
		{
			goto IL_0154;
		}
		goto IL_045f;
		IL_0154:
		if (ShouldFixArabic(input))
		{
			goto IL_017a;
		}
		goto IL_049f;
		IL_007d:
		bool flag6 = ShouldFixArabic(input);
		obj6 = obj2;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v70 @ X0_v43+E4]");
		obj7 = 0;
		bool flag7 = !flag6;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v70 @ X0_v43+E4]");
		obj9 = 0;
		obj10 = obj6;
		if (!flag7)
		{
			goto IL_00d7;
		}
		goto IL_0297;
		IL_0297:
		if (obj9 != null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [91E5DE6]");
			object obj13 = (nint)0 & (nint)1;
			if (obj13 != null)
			{
				goto IL_02e7;
			}
		}
		else
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [91E5DE6]");
			object obj14 = (nint)0 & (nint)1;
			bool flag8 = obj14 == null;
			object obj15 = !flag8;
			if (obj15 != null)
			{
				goto IL_02e7;
			}
		}
		_ = 1;
		object obj16 = obj2;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v159 @ X0_v11+E4]");
		bool flag9 = (nint)0 == 0;
		object obj17 = !flag9;
		if (obj17 != null)
		{
			goto IL_0314;
		}
		goto IL_0550;
		IL_05bb:
		object obj18;
		string text;
		object obj19;
		return (string)obj18 + text + (string)obj19;
		IL_03bf:
		string text2 = FixArabicHelper(input);
		text = text2;
		goto IL_05bb;
		IL_03a0:
		Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		object obj20;
		obj19 = obj20;
		object obj21;
		obj18 = obj21;
		goto IL_03bf;
		IL_02e7:
		obj16 = obj2;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v159 @ X0_v11+E4]");
		if ((nint)0 != 0)
		{
			goto IL_0314;
		}
		goto IL_0550;
		IL_0550:
		Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		bool flag10 = ShouldFixArabic(input);
		bool flag11 = !flag10;
		object obj22 = !flag11;
		if (obj22 != null)
		{
			goto IL_033a;
		}
		goto IL_0590;
		IL_0314:
		if (ShouldFixArabic(input))
		{
			goto IL_033a;
		}
		goto IL_0590;
		IL_0590:
		obj19 = "<ds.DataTable.OnColumnChanging|INFO> {0}" + 880;
		obj18 = "1.2.840.113549.1.12.1.5" + 2144;
		text = input;
		goto IL_05bb;
		IL_033a:
		object obj23 = obj2;
		obj20 = "<ds.DataTable.OnColumnChanging|INFO> {0}" + 880;
		obj21 = "1.2.840.113549.1.12.1.5" + 2144;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v249 @ X0_v7+E4]");
		bool flag12 = (nint)0 == 0;
		object obj24 = !flag12;
		obj19 = obj20;
		obj18 = obj21;
		if (obj24 == null)
		{
			goto IL_03a0;
		}
		goto IL_03bf;
		IL_00d7:
		if (obj7 != null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [91E5DE6]");
			object obj25 = (nint)0 & (nint)1;
			if (obj25 != null)
			{
				goto IL_0127;
			}
		}
		else
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [91E5DE6]");
			object obj26 = (nint)0 & (nint)1;
			bool flag13 = obj26 == null;
			object obj27 = !flag13;
			if (obj27 != null)
			{
				goto IL_0127;
			}
		}
		_ = 1;
		obj12 = obj2;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v143 @ X0_v45+E4]");
		bool flag14 = (nint)0 == 0;
		object obj28 = !flag14;
		if (obj28 != null)
		{
			goto IL_0154;
		}
		goto IL_045f;
		IL_017a:
		obj23 = obj2;
		obj19 = "1.2.840.113549.1.12.1.5" + 2144;
		obj18 = "<ds.DataTable.OnColumnChanging|INFO> {0}" + 880;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v249 @ X0_v7+E4]");
		bool flag15 = (nint)0 == 0;
		object obj29 = !flag15;
		if (obj29 == null)
		{
			obj20 = obj19;
			obj21 = obj18;
			goto IL_03a0;
		}
		goto IL_03bf;
		IL_049f:
		obj19 = "1.2.840.113549.1.12.1.5" + 2144;
		obj18 = "<ds.DataTable.OnColumnChanging|INFO> {0}" + 880;
		text = input;
		goto IL_05bb;
	}

	private static string FixArabicHelper(string input)
	{
		//IL_000f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0014: Expected O, but got Unknown
		//IL_0135: Expected O, but got I4
		//IL_004f: Expected O, but got I4
		//IL_014f: Expected O, but got I
		//IL_008b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0090: Expected O, but got Unknown
		//IL_00ba: Expected O, but got I4
		object obj = typeof(Newtonsoft.Json.Linq.JsonPath.JPath) + 2656;
		object obj2 = obj;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v45 @ X0_v2+E4]");
		bool flag = (nint)0 == 0;
		object obj3 = !flag;
		if (obj3 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		}
		bool flag2 = IsArabicFixed(input);
		bool flag3 = !flag2;
		object obj4 = !flag3;
		string text = input;
		if (obj4 == null)
		{
			string value = ArabicFixer.Fix(input, showTashkeel: false, useHinduNumbers: false);
			object obj5 = typeof(System.Formats.Asn1.SetOfValueComparer) + 2536;
			object obj6 = obj5;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v95 @ X0_v12+E4]");
			bool flag4 = (nint)0 == 0;
			object obj7 = !flag4;
			if (obj7 == null)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			}
			string text2 = StringsExtensions.Reverse(value);
			text = text2;
		}
		object result = (nint)0 + (nint)2000;
		if (text == null)
		{
			return (string)result;
		}
		return text;
	}

	public static bool IsArabicFixed(string value)
	{
		//IL_0009: Expected O, but got I4
		//IL_0018: Unknown result type (might be due to invalid IL or missing references)
		//IL_001d: Expected O, but got Unknown
		//IL_0033: Expected O, but got I
		//IL_00e6: Expected O, but got I4
		//IL_00a2: Expected O, but got I4
		//IL_0150: Unknown result type (might be due to invalid IL or missing references)
		//IL_0155: Expected O, but got Unknown
		//IL_0209: Expected O, but got I
		//IL_0219: Expected O, but got I
		//IL_0229: Expected O, but got I
		//IL_024b: Expected O, but got I4
		//IL_012a: Expected O, but got I4
		//IL_0133: Expected O, but got I4
		//IL_018e: Expected O, but got I
		//IL_019e: Expected O, but got I
		//IL_01ae: Expected O, but got I
		//IL_01d0: Expected O, but got I4
		//IL_0283: Expected O, but got I4
		//IL_02dd: Unknown result type (might be due to invalid IL or missing references)
		//IL_02e2: Expected O, but got Unknown
		//IL_02f8: Expected O, but got I
		//IL_0309: Expected I, but got O
		//IL_0327: Expected O, but got I
		//IL_02b3: Expected O, but got I
		object obj = 152981504;
		object obj2 = typeof(System.Formats.Asn1.SetOfValueComparer) + 2536;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [91E5CBC]");
		object obj3 = (nint)0 & (nint)1;
		if (obj3 != null)
		{
			object obj4 = obj2;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v56 @ X0_v16+E4]");
			if ((nint)0 != 0)
			{
				goto IL_007d;
			}
		}
		else
		{
			_ = 1;
			object obj4 = obj2;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v56 @ X0_v16+E4]");
			bool flag = (nint)0 == 0;
			object obj5 = !flag;
			if (obj5 != null)
			{
				goto IL_007d;
			}
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		bool flag2 = StringsExtensions.IsNullOrEmpty(value);
		bool flag3 = !flag2;
		object obj6 = !flag3;
		object obj7 = 0;
		if (obj6 != null)
		{
			goto IL_00b0;
		}
		goto IL_0141;
		IL_02b8:
		Func<char, bool> predicate;
		return Enumerable.Any(value, predicate);
		IL_0261:
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v166 @ X0_v6+E4]");
		bool flag4 = (nint)0 == 0;
		object obj8 = !flag4;
		object obj10;
		object obj11;
		if (obj8 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			object obj9 = obj10;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v179 @ X8_v12+B8]");
			obj11 = 0;
		}
		object obj12 = typeof(Func<AndroidJavaObject, IList<HWLocation>>) + 544;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
		object obj13 = (nint)0 + (nint)4056;
		Func<char, bool> func = default(Func<char, bool>);
		func..ctor(obj11, (IntPtr)obj13);
		object obj14 = obj10;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v156 @ X8_v11+B8]");
		object obj15 = (nint)0 + (nint)40;
		obj15 = func;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
		object obj17;
		object obj16 = obj17;
		predicate = func;
		goto IL_02b8;
		IL_00b0:
		return true;
		IL_007d:
		bool flag5 = StringsExtensions.IsNullOrEmpty(value);
		bool flag6 = !flag5;
		obj7 = 0;
		if (!flag6)
		{
			goto IL_00b0;
		}
		goto IL_0141;
		IL_0141:
		obj10 = typeof(InvitationsNotifier.<>c__DisplayClass16_0) + 2224;
		object obj18 = obj10;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v166 @ X0_v6+E4]");
		if ((nint)0 != 0)
		{
			obj16 = (nint)0 + (nint)2512;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v166 @ X0_v6+B8]");
			obj11 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v173 @ X8_v6+28]");
			predicate = (Func<char, bool>)0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v173 @ X8_v6+28]");
			bool flag7 = (nint)0 == 0;
			object obj19 = !flag7;
			if (obj19 == null)
			{
				obj17 = obj16;
				goto IL_0261;
			}
		}
		else
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			obj18 = obj10;
			obj17 = (nint)0 + (nint)2512;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v166 @ X0_v6+B8]");
			obj11 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v173 @ X8_v6+28]");
			predicate = (Func<char, bool>)0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v173 @ X8_v6+28]");
			bool flag8 = (nint)0 == 0;
			object obj20 = !flag8;
			obj16 = obj17;
			if (obj20 == null)
			{
				goto IL_0261;
			}
		}
		goto IL_02b8;
	}

	public static string DateRangeMessage(DateTime startTime, DateTime endTime)
	{
		//IL_0009: Expected O, but got I4
		//IL_0018: Unknown result type (might be due to invalid IL or missing references)
		//IL_001d: Expected O, but got Unknown
		//IL_0033: Expected O, but got I
		//IL_0179: Unknown result type (might be due to invalid IL or missing references)
		//IL_017e: Expected O, but got Unknown
		//IL_01a8: Expected O, but got I4
		//IL_005f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0064: Expected O, but got Unknown
		//IL_0258: Expected O, but got I4
		//IL_0269: Expected O, but got I4
		//IL_0108: Expected O, but got I4
		//IL_0204: Expected O, but got I4
		//IL_012a: Expected O, but got I
		//IL_0281: Unknown result type (might be due to invalid IL or missing references)
		//IL_0286: Expected O, but got Unknown
		//IL_02b0: Expected O, but got I4
		//IL_02e9: Unknown result type (might be due to invalid IL or missing references)
		//IL_02ee: Expected O, but got Unknown
		//IL_06d1: Unknown result type (might be due to invalid IL or missing references)
		//IL_06d6: Expected O, but got Unknown
		//IL_0700: Expected O, but got I4
		//IL_071d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0722: Expected O, but got Unknown
		//IL_074c: Expected O, but got I4
		//IL_0386: Unknown result type (might be due to invalid IL or missing references)
		//IL_038b: Expected O, but got Unknown
		//IL_03b7: Expected O, but got I8
		//IL_03e0: Expected O, but got I
		//IL_03e9: Unknown result type (might be due to invalid IL or missing references)
		//IL_03ee: Expected O, but got Unknown
		//IL_0422: Expected O, but got I4
		//IL_0438: Expected O, but got I
		//IL_0458: Unknown result type (might be due to invalid IL or missing references)
		//IL_045d: Expected O, but got Unknown
		//IL_0474: Unknown result type (might be due to invalid IL or missing references)
		//IL_0479: Expected O, but got Unknown
		//IL_04a5: Expected O, but got I8
		//IL_04ce: Expected O, but got I
		//IL_04d7: Unknown result type (might be due to invalid IL or missing references)
		//IL_04dc: Expected O, but got Unknown
		//IL_0510: Expected O, but got I4
		//IL_0526: Expected O, but got I
		//IL_0546: Unknown result type (might be due to invalid IL or missing references)
		//IL_054b: Expected O, but got Unknown
		//IL_0562: Unknown result type (might be due to invalid IL or missing references)
		//IL_0567: Expected O, but got Unknown
		//IL_059b: Expected O, but got I4
		//IL_05b1: Expected O, but got I
		//IL_05d1: Unknown result type (might be due to invalid IL or missing references)
		//IL_05d6: Expected O, but got Unknown
		//IL_05ed: Unknown result type (might be due to invalid IL or missing references)
		//IL_05f2: Expected O, but got Unknown
		//IL_0626: Expected O, but got I4
		//IL_063c: Expected O, but got I
		//IL_065c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0661: Expected O, but got Unknown
		//IL_0678: Unknown result type (might be due to invalid IL or missing references)
		//IL_067d: Expected O, but got Unknown
		object obj = 152981504;
		object obj2 = typeof(Newtonsoft.Json.Linq.JsonPath.JPath) + 2656;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [91E5DE8]");
		object obj3 = (nint)0 & (nint)1;
		object obj4;
		object obj6;
		if (obj3 != null)
		{
			obj4 = typeof(DataRelation) + 712;
			object obj5 = obj2;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v64 @ X0_v52+E4]");
			bool flag = (nint)0 == 0;
			obj6 = obj4;
			if (!flag)
			{
				goto IL_0099;
			}
		}
		else
		{
			_ = 1;
			obj4 = typeof(DataRelation) + 712;
			object obj5 = obj2;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v64 @ X0_v52+E4]");
			bool flag2 = (nint)0 == 0;
			object obj7 = !flag2;
			obj6 = obj4;
			if (obj7 != null)
			{
				goto IL_0099;
			}
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		string text = FormatDateTime(startTime);
		object obj8 = obj6;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v94 @ X0_v48+E4]");
		bool flag3 = (nint)0 == 0;
		object obj9 = !flag3;
		string text2 = text;
		string text3 = text;
		if (obj9 != null)
		{
			goto IL_00e3;
		}
		goto IL_0222;
		IL_011e:
		object result = (nint)0 + (nint)2000;
		if (text2 == null)
		{
			return (string)result;
		}
		return text2;
		IL_0277:
		object key = "fetch_products" + 1400;
		object obj10 = obj2;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v142 @ X0_v2+E4]");
		bool flag4 = (nint)0 == 0;
		object obj11 = !flag4;
		if (obj11 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		}
		DateTime dateTime = default(DateTime);
		string text4 = FormatDateTime(dateTime);
		object obj12 = typeof(Newtonsoft.Json.Linq.JsonPath.JPath) + 2648;
		object key2 = "startPosition" + 3176;
		object obj13 = obj12;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v258 @ X0_v7+E4]");
		bool flag5 = (nint)0 == 0;
		object obj14 = !flag5;
		if (obj14 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		}
		string text5 = LocalizationText.GetText((string)key);
		object obj15 = typeof(SqlSingle[]) + 32;
		object obj16 = obj12;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v284 @ X0_v12+E4]");
		bool flag6 = (nint)0 == 0;
		object obj17 = !flag6;
		if (obj17 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		}
		string text6 = LocalizationText.GetText((string)key2);
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC18B4");
		string[] array = default(string[]);
		if (array != null)
		{
			if (array.Length != 0)
			{
				object obj18 = array + 32;
				obj18 = text5;
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v326 @ X24_v7-8]");
				object obj19 = 0 & 0xFFFFFFFEL;
				if (obj19 != null)
				{
					object obj20 = (nint)0 + (nint)3072;
					object obj21 = array + 40;
					obj21 = obj20;
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v377 @ X23_v6-10]");
					bool flag7 = (nint)0 < (nint)2;
					object obj22 = !flag7;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v377 @ X23_v6-10]");
					object obj23 = -2;
					bool flag8 = obj23 == null;
					object obj24 = ~obj22;
					object obj25 = obj24 | flag8;
					if (obj25 == null)
					{
						object obj26 = array + 48;
						obj26 = text3;
						Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v378 @ X23_v8-18]");
						object obj27 = 0 & 0xFFFFFFFCL;
						if (obj27 != null)
						{
							object obj28 = (nint)0 + (nint)2336;
							object obj29 = array + 56;
							obj29 = obj28;
							Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v385 @ X20_v6-20]");
							bool flag9 = (nint)0 < (nint)4;
							object obj30 = !flag9;
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v385 @ X20_v6-20]");
							object obj31 = -4;
							bool flag10 = obj31 == null;
							object obj32 = ~obj30;
							object obj33 = obj32 | flag10;
							if (obj33 == null)
							{
								object obj34 = array + 64;
								obj34 = text6;
								Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
								Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v386 @ X20_v8-28]");
								bool flag11 = (nint)0 < (nint)5;
								object obj35 = !flag11;
								Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v386 @ X20_v8-28]");
								object obj36 = -5;
								bool flag12 = obj36 == null;
								object obj37 = ~obj35;
								object obj38 = obj37 | flag12;
								if (obj38 == null)
								{
									object obj39 = array + 72;
									obj39 = obj20;
									Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
									Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v387 @ X20_v10-30]");
									bool flag13 = (nint)0 < (nint)6;
									object obj40 = !flag13;
									Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v387 @ X20_v10-30]");
									object obj41 = -6;
									bool flag14 = obj41 == null;
									object obj42 = ~obj40;
									object obj43 = obj42 | flag14;
									if (obj43 == null)
									{
										object obj44 = array + 80;
										obj44 = text4;
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
		IL_00e3:
		bool flag15 = startTime >= dateTime;
		bool flag16 = !flag15;
		object obj45 = 0;
		text3 = text2;
		if (!flag16)
		{
			goto IL_011e;
		}
		goto IL_0277;
		IL_0099:
		string text7 = FormatDateTime(startTime);
		obj8 = obj4;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v94 @ X0_v48+E4]");
		bool flag17 = (nint)0 == 0;
		text2 = text7;
		text3 = text7;
		if (!flag17)
		{
			goto IL_00e3;
		}
		goto IL_0222;
		IL_0222:
		Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		bool flag18 = startTime >= dateTime;
		bool flag19 = !flag18;
		object obj46 = !flag19;
		text2 = text3;
		obj45 = 0;
		if (obj46 != null)
		{
			goto IL_011e;
		}
		goto IL_0277;
	}

	public unsafe static string FormatDateTime(DateTime time)
	{
		//IL_000f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0014: Expected O, but got Unknown
		//IL_07fd: Unknown result type (might be due to invalid IL or missing references)
		//IL_0802: Expected O, but got Unknown
		//IL_082c: Expected O, but got I4
		//IL_007e: Expected O, but got I4
		//IL_00aa: Unknown result type (might be due to invalid IL or missing references)
		//IL_00af: Expected O, but got Unknown
		//IL_00be: Unknown result type (might be due to invalid IL or missing references)
		//IL_00c3: Expected O, but got Unknown
		//IL_00cd: Unknown result type (might be due to invalid IL or missing references)
		//IL_00d2: Expected O, but got Unknown
		//IL_00de: Expected O, but got I
		//IL_0587: Expected O, but got I
		//IL_05b1: Expected O, but got I4
		//IL_012e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0133: Expected O, but got Unknown
		//IL_0143: Unknown result type (might be due to invalid IL or missing references)
		//IL_0148: Expected O, but got Unknown
		//IL_017c: Expected O, but got I4
		//IL_01b0: Expected O, but got Ref
		//IL_079d: Expected O, but got I4
		//IL_06a4: Unknown result type (might be due to invalid IL or missing references)
		//IL_06a9: Expected O, but got Unknown
		//IL_06bf: Expected O, but got I
		//IL_06d9: Expected O, but got I4
		//IL_023f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0244: Expected O, but got Unknown
		//IL_01f5: Unknown result type (might be due to invalid IL or missing references)
		//IL_01fa: Expected O, but got Unknown
		//IL_0210: Expected O, but got I
		//IL_06ff: Unknown result type (might be due to invalid IL or missing references)
		//IL_0704: Expected O, but got Unknown
		//IL_072e: Expected O, but got I4
		//IL_02a8: Expected O, but got I4
		//IL_0331: Unknown result type (might be due to invalid IL or missing references)
		//IL_0336: Expected O, but got Unknown
		//IL_0362: Expected O, but got I8
		//IL_038b: Expected O, but got I
		//IL_0394: Unknown result type (might be due to invalid IL or missing references)
		//IL_0399: Expected O, but got Unknown
		//IL_03e7: Expected O, but got I4
		//IL_0868: Expected O, but got I4
		//IL_0878: Expected O, but got I4
		//IL_0898: Unknown result type (might be due to invalid IL or missing references)
		//IL_089d: Expected O, but got Unknown
		//IL_040d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0412: Expected O, but got Unknown
		//IL_043e: Expected O, but got I8
		//IL_0464: Unknown result type (might be due to invalid IL or missing references)
		//IL_0469: Expected O, but got Unknown
		//IL_04a5: Expected O, but got I4
		//IL_0501: Expected O, but got I4
		//IL_0511: Expected O, but got I4
		//IL_0531: Unknown result type (might be due to invalid IL or missing references)
		//IL_0536: Expected O, but got Unknown
		//IL_054d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0552: Expected O, but got Unknown
		object obj = typeof(DataRelation) + 712;
		object obj2 = typeof(UnityEngine.Purchasing.Telemetry.TelemetryMetricsInstanceWrapper) + 1032;
		object obj3 = obj;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v59 @ X0_v2+E4]");
		bool flag = (nint)0 == 0;
		object obj4 = !flag;
		if (obj4 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		}
		DateTime today = DateTime.Today;
		DateTime dateTime = default(DateTime);
		DateTime date = dateTime.Date;
		TimeSpan timeSpan = today - date;
		object obj5 = obj2;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v89 @ X0_v10+E4]");
		bool flag2 = (nint)0 == 0;
		object obj6 = !flag2;
		if (obj6 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		}
		object obj7 = typeof(DataRelation) + 824;
		object obj8 = typeof(System.Runtime.Remoting.Messaging.CallContextSecurityData) + 3632;
		object obj9 = "utf-32" + 3016;
		object obj10 = (nint)0 + (nint)3488;
		TimeSpan timeSpan2 = TimeSpan.FromDays(4.000000000465661);
		string key;
		object obj17;
		object obj22;
		object obj25;
		object obj23;
		if (timeSpan > timeSpan2)
		{
			object obj11 = typeof(SqlSingle[]) + 32;
			object obj12 = typeof(Newtonsoft.Json.Linq.JsonPath.JPath) + 2656;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC18B4");
			object obj13 = obj;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v143 @ X0_v39+E4]");
			bool flag3 = (nint)0 == 0;
			object obj14 = !flag3;
			if (obj14 == null)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			}
			DayOfWeek dayOfWeek = dateTime.DayOfWeek;
			object obj15 = default(object);
			key = ((Enum)(&obj15)).ToString();
			object obj16 = obj12;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v180 @ X0_v45+E4]");
			object obj19;
			if ((nint)0 != 0)
			{
				obj17 = typeof(Newtonsoft.Json.Linq.JsonPath.JPath) + 2648;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [91E5DE1]");
				object obj18 = (nint)0 & (nint)1;
				bool flag4 = obj18 == null;
				obj19 = obj17;
				if (!flag4)
				{
					goto IL_0235;
				}
			}
			else
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
				obj17 = typeof(Newtonsoft.Json.Linq.JsonPath.JPath) + 2648;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [91E5DE1]");
				object obj20 = (nint)0 & (nint)1;
				bool flag5 = obj20 == null;
				object obj21 = !flag5;
				obj19 = obj17;
				if (obj21 != null)
				{
					goto IL_0235;
				}
			}
			_ = 1;
			obj22 = "{0} color encoding is currently unsupported for outputting to HDR." + 456;
			obj23 = obj19;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v262 @ X0_v46+E4]");
			bool flag6 = (nint)0 == 0;
			object obj24 = !flag6;
			obj25 = obj22;
			if (obj24 != null)
			{
				goto IL_0279;
			}
			goto IL_0744;
		}
		object separator = (nint)0 + (nint)3104;
		object obj26 = obj7;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v135 @ X0_v17+E4]");
		bool flag7 = (nint)0 == 0;
		object obj27 = !flag7;
		if (obj27 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		}
		string dayOfWeekTimeFormat = DateTimeUtil.GetDayOfWeekTimeFormat(dateTime, (string)separator);
		object obj28 = obj8;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v163 @ X0_v21+E4]");
		CultureInfo cultureInfo;
		CultureInfo cultureInfo2;
		if ((nint)0 != 0)
		{
			CultureInfo invariantCulture = CultureInfo.InvariantCulture;
			object obj29 = obj;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v213 @ X0_v22+E4]");
			bool flag8 = (nint)0 == 0;
			cultureInfo = invariantCulture;
			cultureInfo2 = invariantCulture;
			if (!flag8)
			{
				goto IL_0657;
			}
		}
		else
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			CultureInfo invariantCulture2 = CultureInfo.InvariantCulture;
			object obj29 = obj;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v213 @ X0_v22+E4]");
			bool flag9 = (nint)0 == 0;
			object obj30 = !flag9;
			cultureInfo = invariantCulture2;
			cultureInfo2 = invariantCulture2;
			if (obj30 != null)
			{
				goto IL_0657;
			}
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		cultureInfo = cultureInfo2;
		goto IL_0657;
		IL_0657:
		string text = dateTime.ToString((string)obj9, cultureInfo);
		return dayOfWeekTimeFormat + (string)obj10 + text;
		IL_0235:
		obj22 = "{0} color encoding is currently unsupported for outputting to HDR." + 456;
		obj23 = obj17;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v262 @ X0_v46+E4]");
		bool flag10 = (nint)0 == 0;
		obj25 = obj22;
		if (!flag10)
		{
			goto IL_0279;
		}
		goto IL_0744;
		IL_0744:
		Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		obj22 = obj25;
		goto IL_0279;
		IL_0279:
		string text2 = LocalizationText.GetText(key);
		int day = dateTime.Day;
		object obj31 = 153100288 + 1024;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC195C");
		int month = dateTime.Month;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC195C");
		object arg = default(object);
		object arg2 = default(object);
		string text3 = string.Format((string)obj22, text2, arg, arg2);
		string[] array = default(string[]);
		if (array != null)
		{
			if (array.Length != 0)
			{
				object obj32 = array + 32;
				obj32 = text3;
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v435 @ X20_v18-8]");
				object obj33 = 0 & 0xFFFFFFFEL;
				if (obj33 != null)
				{
					object obj34 = (nint)0 + (nint)3072;
					object obj35 = array + 40;
					obj35 = obj34;
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
					TimeSpan timeOfDay = dateTime.TimeOfDay;
					object obj36 = obj7;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v479 @ X8_v29+E4]");
					bool flag11 = (nint)0 == 0;
					object obj37 = !flag11;
					if (obj37 == null)
					{
						Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
					}
					string text4 = DateTimeUtil.AmPmTime(timeOfDay, shortWords: false);
					bool flag12 = array.Length < 2;
					object obj38 = !flag12;
					object obj39 = array.Length - 2;
					bool flag13 = obj39 == null;
					object obj40 = ~obj38;
					object obj41 = obj40 | flag13;
					if (obj41 == null)
					{
						object obj42 = array + 48;
						obj42 = text4;
						Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v316 @ X20_v21-18]");
						object obj43 = 0 & 0xFFFFFFFCL;
						if (obj43 != null)
						{
							object obj44 = array + 56;
							obj44 = obj10;
							Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
							object obj45 = obj8;
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v494 @ X0_v85+E4]");
							bool flag14 = (nint)0 == 0;
							object obj46 = !flag14;
							if (obj46 == null)
							{
								Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
							}
							CultureInfo invariantCulture3 = CultureInfo.InvariantCulture;
							string text5 = dateTime.ToString((string)obj9, invariantCulture3);
							bool flag15 = array.Length < 4;
							object obj47 = !flag15;
							object obj48 = array.Length - 4;
							bool flag16 = obj48 == null;
							object obj49 = ~obj47;
							object obj50 = obj49 | flag16;
							if (obj50 == null)
							{
								object obj51 = array + 64;
								obj51 = text5;
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

	public static string FixArabicOnly(string @this)
	{
		//IL_000f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0014: Expected O, but got Unknown
		//IL_002a: Expected O, but got I
		//IL_0169: Expected O, but got I4
		//IL_008a: Expected O, but got I
		//IL_01ef: Expected O, but got I4
		//IL_0197: Expected O, but got I
		//IL_01b1: Expected O, but got I4
		//IL_022f: Expected O, but got I4
		object obj = typeof(Newtonsoft.Json.Linq.JsonPath.JPath) + 2656;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [91E5DEA]");
		object obj2 = (nint)0 & (nint)1;
		if (obj2 != null)
		{
			object obj3 = obj;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v53 @ X0_v12+E4]");
			if ((nint)0 != 0)
			{
				goto IL_0074;
			}
		}
		else
		{
			_ = 1;
			object obj3 = obj;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v53 @ X0_v12+E4]");
			bool flag = (nint)0 == 0;
			object obj4 = !flag;
			if (obj4 != null)
			{
				goto IL_0074;
			}
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [91E5DE3]");
		object obj5 = (nint)0 & (nint)1;
		bool flag2 = obj5 == null;
		object obj6 = !flag2;
		if (obj6 != null)
		{
			goto IL_00a7;
		}
		goto IL_01bf;
		IL_00fa:
		object obj7 = obj;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v102 @ X0_v19+E4]");
		if ((nint)0 != 0)
		{
			return FixArabicMultipleLines(@this);
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		return FixArabicMultipleLines(@this);
		IL_023d:
		return @this;
		IL_00d4:
		if (ShouldFixArabic(@this))
		{
			goto IL_00fa;
		}
		goto IL_023d;
		IL_0074:
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [91E5DE3]");
		object obj8 = (nint)0 & (nint)1;
		if (obj8 != null)
		{
			goto IL_00a7;
		}
		goto IL_01bf;
		IL_01bf:
		_ = 1;
		object obj9 = obj;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v87 @ X0_v3+E4]");
		bool flag3 = (nint)0 == 0;
		object obj10 = !flag3;
		if (obj10 != null)
		{
			goto IL_00d4;
		}
		goto IL_01fd;
		IL_00a7:
		obj9 = obj;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v87 @ X0_v3+E4]");
		if ((nint)0 != 0)
		{
			goto IL_00d4;
		}
		goto IL_01fd;
		IL_01fd:
		Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		bool flag4 = ShouldFixArabic(@this);
		bool flag5 = !flag4;
		object obj11 = !flag5;
		if (obj11 != null)
		{
			goto IL_00fa;
		}
		goto IL_023d;
	}

	static LocalizationUtil()
	{
		//IL_000f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0014: Expected O, but got Unknown
		//IL_001e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0023: Expected O, but got Unknown
		//IL_0032: Unknown result type (might be due to invalid IL or missing references)
		//IL_0037: Expected O, but got Unknown
		object obj = typeof(System.Buffers.Text.ParserHelpers) + 3920;
		object pattern = "[{0}]:{1}" + 40;
		object obj2 = typeof(Newtonsoft.Json.Linq.JsonPath.JPath) + 2656;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
		Regex regex = default(Regex);
		regex..ctor((string)pattern);
		object obj3 = obj2;
		object obj4 = regex;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
	}
}

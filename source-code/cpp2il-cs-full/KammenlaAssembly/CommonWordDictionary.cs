using System;
using System.Buffers.Text;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Runtime.Remoting.Messaging;
using Cpp2ILInjected;
using HuaweiMobileServices.Location.Location;
using Unity.Properties;
using UnityEngine;

public class CommonWordDictionary : MonoBehaviour
{
	[Serializable]
	private sealed class <>c
	{
		public static readonly <>c <>9;

		public static Func<CommonWord, ReplyCategory> <>9__1_0;

		public static Func<CommonWord, bool> <>9__1_1;

		static <>c()
		{
			//IL_000f: Unknown result type (might be due to invalid IL or missing references)
			//IL_0014: Expected O, but got Unknown
			object obj = typeof(CardUtils.<>c) + 2032;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
			object obj2 = default(object);
			obj2..ctor();
			object obj3 = obj;
			object obj4 = obj2;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
		}

		internal ReplyCategory <get_Words>b__1_0(CommonWord w)
		{
			//IL_0035: Expected I4, but got O
			if (w != null)
			{
				return w.<Category>k__BackingField;
			}
			NullReferenceException ex = new NullReferenceException();
			return (ReplyCategory)ex;
		}

		internal bool <get_Words>b__1_1(CommonWord w)
		{
			//IL_00e7: Expected I4, but got O
			//IL_0013: Unknown result type (might be due to invalid IL or missing references)
			//IL_0018: Expected O, but got Unknown
			//IL_0041: Expected O, but got I
			//IL_005d: Unknown result type (might be due to invalid IL or missing references)
			//IL_0062: Expected O, but got Unknown
			//IL_008c: Expected O, but got I4
			//IL_00bf: Expected O, but got I4
			if (w != null)
			{
				object obj = (??)w.<Game>k__BackingField & 1;
				if (obj != null)
				{
					object obj2 = (nint)0 + (nint)2768;
					System.Int32Enum? int32Enum = default(System.Int32Enum?);
					System.Int32Enum value = int32Enum.Value;
					object obj3 = typeof(System.Buffers.Text.ParserHelpers) + 1624;
					object obj4 = obj3;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v63 @ X0_v6+E4]");
					bool flag = (nint)0 == 0;
					object obj5 = !flag;
					if (obj5 == null)
					{
						Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
					}
					Games currentGame = Preferences.CurrentGame;
					object obj6 = (int)value - (int)currentGame;
					return obj6 == null;
				}
				return true;
			}
			NullReferenceException ex = new NullReferenceException();
			return (byte)(int)ex != 0;
		}
	}

	private static readonly CommonWord[] defaultWords;

	public static IEnumerable<CommonWord> Words
	{
		get
		{
			//IL_0009: Expected O, but got I4
			//IL_0018: Unknown result type (might be due to invalid IL or missing references)
			//IL_001d: Expected O, but got Unknown
			//IL_0033: Expected O, but got I
			//IL_018c: Unknown result type (might be due to invalid IL or missing references)
			//IL_0191: Expected O, but got Unknown
			//IL_01bb: Expected O, but got I4
			//IL_00b1: Expected O, but got I
			//IL_005f: Unknown result type (might be due to invalid IL or missing references)
			//IL_0064: Expected O, but got Unknown
			//IL_0271: Expected O, but got I
			//IL_0281: Expected O, but got I
			//IL_0291: Expected O, but got I
			//IL_02b3: Expected O, but got I4
			//IL_01fb: Expected O, but got I
			//IL_022d: Expected O, but got I4
			//IL_010a: Expected O, but got I
			//IL_011a: Expected O, but got I
			//IL_012a: Expected O, but got I
			//IL_014c: Expected O, but got I4
			//IL_03f5: Expected O, but got I
			//IL_0405: Expected O, but got I
			//IL_0415: Expected O, but got I
			//IL_0437: Expected O, but got I4
			//IL_02fb: Expected O, but got I4
			//IL_037a: Expected O, but got I
			//IL_038a: Expected O, but got I
			//IL_039a: Expected O, but got I
			//IL_03bc: Expected O, but got I4
			//IL_04c9: Unknown result type (might be due to invalid IL or missing references)
			//IL_04ce: Expected O, but got Unknown
			//IL_04e4: Expected O, but got I
			//IL_04f5: Expected I, but got O
			//IL_0513: Expected O, but got I
			//IL_046f: Expected O, but got I4
			//IL_032b: Expected O, but got I
			//IL_0559: Unknown result type (might be due to invalid IL or missing references)
			//IL_055e: Expected O, but got Unknown
			//IL_0574: Expected O, but got I
			//IL_0585: Expected I, but got O
			//IL_05a3: Expected O, but got I
			//IL_049f: Expected O, but got I
			object obj = 152989696;
			object obj2 = typeof(System.Runtime.Remoting.Messaging.CallContextSecurityData) + 2080;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [91E761D]");
			object obj3 = (nint)0 & (nint)1;
			object obj4;
			object obj7;
			if (obj3 != null)
			{
				obj4 = typeof(CardUtils.<>c) + 2032;
				object obj5 = obj2;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v47 @ X0_v59+E4]");
				bool flag = (nint)0 == 0;
				object obj6 = obj5;
				obj7 = obj4;
				if (!flag)
				{
					goto IL_00a1;
				}
			}
			else
			{
				_ = 1;
				obj4 = typeof(CardUtils.<>c) + 2032;
				object obj5 = obj2;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v47 @ X0_v59+E4]");
				bool flag2 = (nint)0 == 0;
				object obj8 = !flag2;
				object obj6 = obj5;
				obj7 = obj4;
				if (obj8 != null)
				{
					goto IL_00a1;
				}
			}
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			object obj9 = obj2;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v89 @ X0_v31+B8]");
			object obj10 = 0;
			IEnumerable<object> enumerable = (IEnumerable<object>)obj10;
			object obj11 = obj7;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v134 @ X0_v18+E4]");
			bool flag3 = (nint)0 == 0;
			object obj12 = !flag3;
			obj4 = obj7;
			object obj13 = obj11;
			IEnumerable<object> enumerable2 = (IEnumerable<object>)obj10;
			if (obj12 != null)
			{
				goto IL_00fe;
			}
			goto IL_0253;
			IL_044d:
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v212 @ X0_v8+E4]");
			bool flag4 = (nint)0 == 0;
			object obj14 = !flag4;
			object obj16;
			if (obj14 == null)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
				object obj15 = obj4;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v231 @ X8_v12+B8]");
				obj16 = 0;
			}
			object obj17 = typeof(Func<AndroidJavaObject, IList<HWLocation>>) + 824;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
			object obj18 = (nint)0 + (nint)1264;
			Func<object, bool> func = default(Func<object, bool>);
			func..ctor(obj16, (IntPtr)obj18);
			object obj19 = obj4;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v188 @ X8_v11+B8]");
			object obj20 = (nint)0 + (nint)16;
			obj20 = func;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
			object obj22;
			object obj21 = obj22;
			Func<object, bool> predicate = func;
			goto IL_04a4;
			IL_04a4:
			IOrderedEnumerable<object> source;
			return (IEnumerable<CommonWord>)Enumerable.Where(source, predicate);
			IL_02d9:
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v134 @ X0_v18+E4]");
			bool flag5 = (nint)0 == 0;
			object obj23 = !flag5;
			object obj25;
			if (obj23 == null)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
				object obj24 = obj7;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v164 @ X8_v23+B8]");
				obj25 = 0;
			}
			object obj26 = typeof(Func<AndroidJavaObject, IList<HWLocation>>) + 832;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
			object obj27 = (nint)0 + (nint)1256;
			Func<object, System.Int32Enum> func2 = default(Func<object, System.Int32Enum>);
			func2..ctor(obj25, (IntPtr)obj27);
			object obj28 = obj7;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v120 @ X8_v22+B8]");
			object obj29 = (nint)0 + (nint)8;
			obj29 = func2;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
			object obj31;
			object obj30 = obj31;
			obj4 = obj7;
			enumerable = enumerable2;
			Func<object, System.Int32Enum> keySelector = func2;
			goto IL_0330;
			IL_00a1:
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v47 @ X0_v59+B8]");
			object obj32 = 0;
			enumerable = (IEnumerable<object>)obj32;
			obj11 = obj4;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v134 @ X0_v18+E4]");
			bool flag6 = (nint)0 == 0;
			obj13 = obj11;
			obj7 = obj4;
			enumerable2 = (IEnumerable<object>)obj32;
			if (!flag6)
			{
				goto IL_00fe;
			}
			goto IL_0253;
			IL_0253:
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			obj11 = obj7;
			obj31 = (nint)0 + (nint)2072;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v134 @ X0_v18+B8]");
			obj25 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v148 @ X8_v17+8]");
			keySelector = (Func<object, System.Int32Enum>)0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v148 @ X8_v17+8]");
			bool flag7 = (nint)0 == 0;
			object obj33 = !flag7;
			obj30 = obj31;
			obj4 = obj7;
			enumerable = enumerable2;
			if (obj33 == null)
			{
				goto IL_02d9;
			}
			goto IL_0330;
			IL_00fe:
			obj30 = (nint)0 + (nint)2072;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v134 @ X0_v18+B8]");
			obj25 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v148 @ X8_v17+8]");
			keySelector = (Func<object, System.Int32Enum>)0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v148 @ X8_v17+8]");
			bool flag8 = (nint)0 == 0;
			object obj34 = !flag8;
			if (obj34 == null)
			{
				obj31 = obj30;
				obj7 = obj4;
				enumerable2 = enumerable;
				goto IL_02d9;
			}
			goto IL_0330;
			IL_0330:
			source = Enumerable.OrderBy(enumerable, keySelector);
			object obj35 = obj4;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v212 @ X0_v8+E4]");
			if ((nint)0 != 0)
			{
				obj21 = (nint)0 + (nint)3384;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v212 @ X0_v8+B8]");
				obj16 = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v222 @ X8_v6+10]");
				predicate = (Func<object, bool>)0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v222 @ X8_v6+10]");
				bool flag9 = (nint)0 == 0;
				object obj36 = !flag9;
				if (obj36 == null)
				{
					obj22 = obj21;
					goto IL_044d;
				}
			}
			else
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
				obj35 = obj4;
				obj22 = (nint)0 + (nint)3384;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v212 @ X0_v8+B8]");
				obj16 = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v222 @ X8_v6+10]");
				predicate = (Func<object, bool>)0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v222 @ X8_v6+10]");
				bool flag10 = (nint)0 == 0;
				object obj37 = !flag10;
				obj21 = obj22;
				if (obj37 == null)
				{
					goto IL_044d;
				}
			}
			goto IL_04a4;
		}
	}

	unsafe static CommonWordDictionary()
	{
		//IL_0008: Expected O, but got Ref
		//IL_0017: Unknown result type (might be due to invalid IL or missing references)
		//IL_001c: Expected O, but got Unknown
		//IL_002b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0030: Expected O, but got Unknown
		//IL_003a: Unknown result type (might be due to invalid IL or missing references)
		//IL_003f: Expected O, but got Unknown
		//IL_1fec: Expected O, but got I4
		//IL_00f4: Expected O, but got I4
		//IL_00fd: Expected O, but got I4
		//IL_0079: Expected O, but got I
		//IL_009b: Expected O, but got I4
		//IL_00a4: Expected O, but got I4
		//IL_00c6: Expected O, but got I
		//IL_0127: Unknown result type (might be due to invalid IL or missing references)
		//IL_012c: Expected O, but got Unknown
		//IL_0135: Unknown result type (might be due to invalid IL or missing references)
		//IL_013a: Expected O, but got Unknown
		//IL_017f: Expected O, but got I4
		//IL_0229: Expected O, but got I8
		//IL_0241: Expected O, but got I4
		//IL_024a: Expected O, but got I4
		//IL_01b4: Expected O, but got I
		//IL_01d6: Expected O, but got I4
		//IL_01df: Expected O, but got I4
		//IL_0201: Expected O, but got I
		//IL_0274: Unknown result type (might be due to invalid IL or missing references)
		//IL_0279: Expected O, but got Unknown
		//IL_0282: Unknown result type (might be due to invalid IL or missing references)
		//IL_0287: Expected O, but got Unknown
		//IL_02cc: Expected O, but got I4
		//IL_037e: Expected O, but got I4
		//IL_0394: Expected O, but got I
		//IL_03b4: Unknown result type (might be due to invalid IL or missing references)
		//IL_03b9: Expected O, but got Unknown
		//IL_03c2: Expected O, but got I4
		//IL_03cb: Expected O, but got I4
		//IL_0301: Expected O, but got I
		//IL_0323: Expected O, but got I4
		//IL_032c: Expected O, but got I4
		//IL_034e: Expected O, but got I
		//IL_03f5: Unknown result type (might be due to invalid IL or missing references)
		//IL_03fa: Expected O, but got Unknown
		//IL_0403: Unknown result type (might be due to invalid IL or missing references)
		//IL_0408: Expected O, but got Unknown
		//IL_044d: Expected O, but got I4
		//IL_04f7: Expected O, but got I8
		//IL_050f: Expected O, but got I4
		//IL_0518: Expected O, but got I4
		//IL_0482: Expected O, but got I
		//IL_04a4: Expected O, but got I4
		//IL_04ad: Expected O, but got I4
		//IL_04cf: Expected O, but got I
		//IL_0542: Unknown result type (might be due to invalid IL or missing references)
		//IL_0547: Expected O, but got Unknown
		//IL_0550: Unknown result type (might be due to invalid IL or missing references)
		//IL_0555: Expected O, but got Unknown
		//IL_059a: Expected O, but got I4
		//IL_064c: Expected O, but got I4
		//IL_0662: Expected O, but got I
		//IL_0682: Unknown result type (might be due to invalid IL or missing references)
		//IL_0687: Expected O, but got Unknown
		//IL_0690: Expected O, but got I4
		//IL_0699: Expected O, but got I4
		//IL_05cf: Expected O, but got I
		//IL_05f1: Expected O, but got I4
		//IL_05fa: Expected O, but got I4
		//IL_061c: Expected O, but got I
		//IL_06c3: Unknown result type (might be due to invalid IL or missing references)
		//IL_06c8: Expected O, but got Unknown
		//IL_06d1: Unknown result type (might be due to invalid IL or missing references)
		//IL_06d6: Expected O, but got Unknown
		//IL_071b: Expected O, but got I4
		//IL_07cd: Expected O, but got I4
		//IL_07e3: Expected O, but got I
		//IL_0803: Unknown result type (might be due to invalid IL or missing references)
		//IL_0808: Expected O, but got Unknown
		//IL_0811: Expected O, but got I4
		//IL_081a: Expected O, but got I4
		//IL_0750: Expected O, but got I
		//IL_0772: Expected O, but got I4
		//IL_077b: Expected O, but got I4
		//IL_079d: Expected O, but got I
		//IL_0844: Unknown result type (might be due to invalid IL or missing references)
		//IL_0849: Expected O, but got Unknown
		//IL_0852: Unknown result type (might be due to invalid IL or missing references)
		//IL_0857: Expected O, but got Unknown
		//IL_089c: Expected O, but got I4
		//IL_094e: Expected O, but got I4
		//IL_0964: Expected O, but got I
		//IL_0984: Unknown result type (might be due to invalid IL or missing references)
		//IL_0989: Expected O, but got Unknown
		//IL_0992: Expected O, but got I4
		//IL_099b: Expected O, but got I4
		//IL_08d1: Expected O, but got I
		//IL_08f3: Expected O, but got I4
		//IL_08fc: Expected O, but got I4
		//IL_091e: Expected O, but got I
		//IL_09c5: Unknown result type (might be due to invalid IL or missing references)
		//IL_09ca: Expected O, but got Unknown
		//IL_09d3: Unknown result type (might be due to invalid IL or missing references)
		//IL_09d8: Expected O, but got Unknown
		//IL_0a1d: Expected O, but got I4
		//IL_0ac7: Expected O, but got I8
		//IL_0adf: Expected O, but got I4
		//IL_0ae8: Expected O, but got I4
		//IL_0a52: Expected O, but got I
		//IL_0a74: Expected O, but got I4
		//IL_0a7d: Expected O, but got I4
		//IL_0a9f: Expected O, but got I
		//IL_0b12: Unknown result type (might be due to invalid IL or missing references)
		//IL_0b17: Expected O, but got Unknown
		//IL_0b20: Unknown result type (might be due to invalid IL or missing references)
		//IL_0b25: Expected O, but got Unknown
		//IL_0b6a: Expected O, but got I4
		//IL_0c1c: Expected O, but got I4
		//IL_0c32: Expected O, but got I
		//IL_0c52: Unknown result type (might be due to invalid IL or missing references)
		//IL_0c57: Expected O, but got Unknown
		//IL_0c60: Expected O, but got I4
		//IL_0c69: Expected O, but got I4
		//IL_0b9f: Expected O, but got I
		//IL_0bc1: Expected O, but got I4
		//IL_0bca: Expected O, but got I4
		//IL_0bec: Expected O, but got I
		//IL_0c93: Unknown result type (might be due to invalid IL or missing references)
		//IL_0c98: Expected O, but got Unknown
		//IL_0ca1: Unknown result type (might be due to invalid IL or missing references)
		//IL_0ca6: Expected O, but got Unknown
		//IL_0ceb: Expected O, but got I4
		//IL_0d9d: Expected O, but got I4
		//IL_0db3: Expected O, but got I
		//IL_0dd3: Unknown result type (might be due to invalid IL or missing references)
		//IL_0dd8: Expected O, but got Unknown
		//IL_0de1: Expected O, but got I4
		//IL_0dea: Expected O, but got I4
		//IL_0d20: Expected O, but got I
		//IL_0d42: Expected O, but got I4
		//IL_0d4b: Expected O, but got I4
		//IL_0d6d: Expected O, but got I
		//IL_0e16: Expected O, but got I
		//IL_0e20: Unknown result type (might be due to invalid IL or missing references)
		//IL_0e25: Expected O, but got Unknown
		//IL_0e2e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0e33: Expected O, but got Unknown
		//IL_0e59: Expected O, but got Ref
		//IL_0e62: Expected native int or pointer, but got O
		//IL_0e8e: Expected O, but got I
		//IL_0eb1: Expected O, but got I
		//IL_0f5f: Expected O, but got I4
		//IL_0f75: Expected O, but got I
		//IL_0f95: Unknown result type (might be due to invalid IL or missing references)
		//IL_0f9a: Expected O, but got Unknown
		//IL_0fa3: Expected O, but got I4
		//IL_0eeb: Expected O, but got I
		//IL_0f0d: Expected O, but got I4
		//IL_0f2f: Expected O, but got I
		//IL_0fcd: Unknown result type (might be due to invalid IL or missing references)
		//IL_0fd2: Expected O, but got Unknown
		//IL_0fdb: Unknown result type (might be due to invalid IL or missing references)
		//IL_0fe0: Expected O, but got Unknown
		//IL_10e8: Expected O, but got I4
		//IL_10fe: Expected O, but got I
		//IL_111e: Unknown result type (might be due to invalid IL or missing references)
		//IL_1123: Expected O, but got Unknown
		//IL_112c: Expected O, but got I4
		//IL_106c: Expected O, but got I
		//IL_108e: Expected O, but got I4
		//IL_10b8: Expected O, but got I
		//IL_115e: Unknown result type (might be due to invalid IL or missing references)
		//IL_1163: Expected O, but got Unknown
		//IL_116c: Unknown result type (might be due to invalid IL or missing references)
		//IL_1171: Expected O, but got Unknown
		//IL_1279: Expected O, but got I4
		//IL_128f: Expected O, but got I
		//IL_12af: Unknown result type (might be due to invalid IL or missing references)
		//IL_12b4: Expected O, but got Unknown
		//IL_12bd: Expected O, but got I4
		//IL_11fd: Expected O, but got I
		//IL_121f: Expected O, but got I4
		//IL_1249: Expected O, but got I
		//IL_12ef: Unknown result type (might be due to invalid IL or missing references)
		//IL_12f4: Expected O, but got Unknown
		//IL_12fd: Unknown result type (might be due to invalid IL or missing references)
		//IL_1302: Expected O, but got Unknown
		//IL_140a: Expected O, but got I4
		//IL_1420: Expected O, but got I
		//IL_1440: Unknown result type (might be due to invalid IL or missing references)
		//IL_1445: Expected O, but got Unknown
		//IL_144e: Expected O, but got I4
		//IL_138e: Expected O, but got I
		//IL_13b0: Expected O, but got I4
		//IL_13da: Expected O, but got I
		//IL_1480: Unknown result type (might be due to invalid IL or missing references)
		//IL_1485: Expected O, but got Unknown
		//IL_148e: Unknown result type (might be due to invalid IL or missing references)
		//IL_1493: Expected O, but got Unknown
		//IL_159b: Expected O, but got I4
		//IL_15b1: Expected O, but got I
		//IL_15d1: Unknown result type (might be due to invalid IL or missing references)
		//IL_15d6: Expected O, but got Unknown
		//IL_15df: Expected O, but got I4
		//IL_151f: Expected O, but got I
		//IL_1541: Expected O, but got I4
		//IL_156b: Expected O, but got I
		//IL_1611: Unknown result type (might be due to invalid IL or missing references)
		//IL_1616: Expected O, but got Unknown
		//IL_161f: Unknown result type (might be due to invalid IL or missing references)
		//IL_1624: Expected O, but got Unknown
		//IL_1724: Expected O, but got I8
		//IL_173c: Expected O, but got I4
		//IL_16b0: Expected O, but got I
		//IL_16d2: Expected O, but got I4
		//IL_16fc: Expected O, but got I
		//IL_176e: Unknown result type (might be due to invalid IL or missing references)
		//IL_1773: Expected O, but got Unknown
		//IL_177c: Unknown result type (might be due to invalid IL or missing references)
		//IL_1781: Expected O, but got Unknown
		//IL_1889: Expected O, but got I4
		//IL_189f: Expected O, but got I
		//IL_18bf: Unknown result type (might be due to invalid IL or missing references)
		//IL_18c4: Expected O, but got Unknown
		//IL_18cd: Expected O, but got I4
		//IL_180d: Expected O, but got I
		//IL_182f: Expected O, but got I4
		//IL_1859: Expected O, but got I
		//IL_18ff: Unknown result type (might be due to invalid IL or missing references)
		//IL_1904: Expected O, but got Unknown
		//IL_190d: Unknown result type (might be due to invalid IL or missing references)
		//IL_1912: Expected O, but got Unknown
		//IL_1a1a: Expected O, but got I4
		//IL_1a30: Expected O, but got I
		//IL_1a50: Unknown result type (might be due to invalid IL or missing references)
		//IL_1a55: Expected O, but got Unknown
		//IL_1a5e: Expected O, but got I4
		//IL_199e: Expected O, but got I
		//IL_19c0: Expected O, but got I4
		//IL_19ea: Expected O, but got I
		//IL_1a8f: Unknown result type (might be due to invalid IL or missing references)
		//IL_1a94: Expected O, but got Unknown
		//IL_1b9c: Expected O, but got I4
		//IL_1bb2: Expected O, but got I
		//IL_1bd2: Unknown result type (might be due to invalid IL or missing references)
		//IL_1bd7: Expected O, but got Unknown
		//IL_1be0: Expected O, but got I4
		//IL_1b20: Expected O, but got I
		//IL_1b42: Expected O, but got I4
		//IL_1b6c: Expected O, but got I
		//IL_1c12: Unknown result type (might be due to invalid IL or missing references)
		//IL_1c17: Expected O, but got Unknown
		//IL_1c20: Unknown result type (might be due to invalid IL or missing references)
		//IL_1c25: Expected O, but got Unknown
		//IL_1d2d: Expected O, but got I4
		//IL_1d43: Expected O, but got I
		//IL_1d63: Unknown result type (might be due to invalid IL or missing references)
		//IL_1d68: Expected O, but got Unknown
		//IL_1d71: Expected O, but got I4
		//IL_1cb1: Expected O, but got I
		//IL_1cd3: Expected O, but got I4
		//IL_1cfd: Expected O, but got I
		//IL_1da2: Unknown result type (might be due to invalid IL or missing references)
		//IL_1da7: Expected O, but got Unknown
		//IL_1eaf: Expected O, but got I4
		//IL_1ec5: Expected O, but got I
		//IL_1ee5: Unknown result type (might be due to invalid IL or missing references)
		//IL_1eea: Expected O, but got Unknown
		//IL_1ef3: Expected O, but got I4
		//IL_1e33: Expected O, but got I
		//IL_1e55: Expected O, but got I4
		//IL_1e7f: Expected O, but got I
		//IL_1f2a: Unknown result type (might be due to invalid IL or missing references)
		//IL_1f2f: Expected O, but got Unknown
		//IL_1f38: Unknown result type (might be due to invalid IL or missing references)
		//IL_1f3d: Expected O, but got Unknown
		//IL_1f67: Expected O, but got I
		object obj2 = default(object);
		object obj = (object)(&obj2);
		object obj3 = typeof(TypeConverter<ushort, char>) + 2000;
		object obj4 = typeof(System.Runtime.Remoting.Messaging.CallContextSecurityData) + 2072;
		object obj5 = "{0} color encoding is currently unsupported for outputting to HDR." + 2208;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC18B4");
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
		string text = (string)obj5;
		CommonWord commonWord = default(CommonWord);
		commonWord..ctor((string)obj5, ReplyCategory.Peaceful, isForSubscribers: false, (Games?)(object)0);
		object obj7 = default(object);
		object obj8;
		Games? games;
		bool flag2;
		ReplyCategory replyCategory;
		IndexOutOfRangeException ex = default(IndexOutOfRangeException);
		string text2;
		if (commonWord != null)
		{
			object obj6 = obj7;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v169 @ X8_v69+40]");
			text = (string)0;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1958");
			bool flag = ex == null;
			obj8 = 0;
			games = (Games?)(object)0;
			flag2 = false;
			replyCategory = ReplyCategory.Peaceful;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v169 @ X8_v69+40]");
			text2 = (string)0;
			if (flag)
			{
				goto IL_1f95;
			}
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v58 @ X0_v3+18]");
		bool flag3 = (nint)0 == 0;
		obj8 = 0;
		games = (Games?)(object)0;
		flag2 = false;
		replyCategory = ReplyCategory.Peaceful;
		if (!flag3)
		{
			object obj9 = "{0} color encoding is currently unsupported for outputting to HDR." + 2456;
			object obj10 = obj7 + 32;
			obj10 = commonWord;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
			text = (string)obj9;
			CommonWord commonWord2 = default(CommonWord);
			commonWord2..ctor((string)obj9, ReplyCategory.Peaceful, isForSubscribers: false, (Games?)(object)0);
			if (commonWord2 != null)
			{
				object obj11 = obj7;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v705 @ X8_v68+40]");
				text = (string)0;
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1958");
				bool flag4 = ex == null;
				obj8 = 0;
				games = (Games?)(object)0;
				flag2 = false;
				replyCategory = ReplyCategory.Peaceful;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v705 @ X8_v68+40]");
				text2 = (string)0;
				if (flag4)
				{
					goto IL_1f95;
				}
			}
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v58 @ X0_v3+18]");
			object obj12 = 0 & 0xFFFFFFFEL;
			bool flag5 = obj12 == null;
			obj8 = 0;
			games = (Games?)(object)0;
			flag2 = false;
			replyCategory = ReplyCategory.Peaceful;
			if (!flag5)
			{
				object obj13 = "{0} color encoding is currently unsupported for outputting to HDR." + 2328;
				object obj14 = obj7 + 40;
				obj14 = commonWord2;
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
				text = (string)obj13;
				CommonWord commonWord3 = default(CommonWord);
				commonWord3..ctor((string)obj13, ReplyCategory.Excitement, isForSubscribers: true, (Games?)(object)0);
				if (commonWord3 != null)
				{
					object obj15 = obj7;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v706 @ X8_v67+40]");
					text = (string)0;
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1958");
					bool flag6 = ex == null;
					obj8 = 0;
					games = (Games?)(object)0;
					flag2 = true;
					replyCategory = ReplyCategory.Excitement;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v706 @ X8_v67+40]");
					text2 = (string)0;
					if (flag6)
					{
						goto IL_1f95;
					}
				}
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v58 @ X0_v3+18]");
				bool flag7 = (nint)0 < (nint)2;
				object obj16 = !flag7;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v58 @ X0_v3+18]");
				object obj17 = -2;
				bool flag8 = obj17 == null;
				object obj18 = ~obj16;
				object obj19 = obj18 | flag8;
				obj8 = 0;
				games = (Games?)(object)0;
				flag2 = true;
				replyCategory = ReplyCategory.Excitement;
				if (obj19 == null)
				{
					object obj20 = "{0} color encoding is currently unsupported for outputting to HDR." + 2320;
					object obj21 = obj7 + 48;
					obj21 = commonWord3;
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
					text = (string)obj20;
					CommonWord commonWord4 = default(CommonWord);
					commonWord4..ctor((string)obj20, ReplyCategory.Game, isForSubscribers: true, (Games?)(object)0);
					if (commonWord4 != null)
					{
						object obj22 = obj7;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v707 @ X8_v66+40]");
						text = (string)0;
						Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1958");
						bool flag9 = ex == null;
						obj8 = 0;
						games = (Games?)(object)0;
						flag2 = true;
						replyCategory = ReplyCategory.Game;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v707 @ X8_v66+40]");
						text2 = (string)0;
						if (flag9)
						{
							goto IL_1f95;
						}
					}
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v58 @ X0_v3+18]");
					object obj23 = 0 & 0xFFFFFFFCL;
					bool flag10 = obj23 == null;
					obj8 = 0;
					games = (Games?)(object)0;
					flag2 = true;
					replyCategory = ReplyCategory.Game;
					if (!flag10)
					{
						object obj24 = "{0} color encoding is currently unsupported for outputting to HDR." + 2248;
						object obj25 = obj7 + 56;
						obj25 = commonWord4;
						Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
						Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
						text = (string)obj24;
						CommonWord commonWord5 = default(CommonWord);
						commonWord5..ctor((string)obj24, ReplyCategory.Game, isForSubscribers: true, (Games?)(object)0);
						if (commonWord5 != null)
						{
							object obj26 = obj7;
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v708 @ X8_v65+40]");
							text = (string)0;
							Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1958");
							bool flag11 = ex == null;
							obj8 = 0;
							games = (Games?)(object)0;
							flag2 = true;
							replyCategory = ReplyCategory.Game;
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v708 @ X8_v65+40]");
							text2 = (string)0;
							if (flag11)
							{
								goto IL_1f95;
							}
						}
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v58 @ X0_v3+18]");
						bool flag12 = (nint)0 < (nint)4;
						object obj27 = !flag12;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v58 @ X0_v3+18]");
						object obj28 = -4;
						bool flag13 = obj28 == null;
						object obj29 = ~obj27;
						object obj30 = obj29 | flag13;
						obj8 = 0;
						games = (Games?)(object)0;
						flag2 = true;
						replyCategory = ReplyCategory.Game;
						if (obj30 == null)
						{
							object obj31 = "{0} color encoding is currently unsupported for outputting to HDR." + 2216;
							object obj32 = obj7 + 64;
							obj32 = commonWord5;
							Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
							Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
							text = (string)obj31;
							CommonWord commonWord6 = default(CommonWord);
							commonWord6..ctor((string)obj31, ReplyCategory.Negative, isForSubscribers: true, (Games?)(object)0);
							if (commonWord6 != null)
							{
								object obj33 = obj7;
								Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v709 @ X8_v64+40]");
								text = (string)0;
								Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1958");
								bool flag14 = ex == null;
								obj8 = 0;
								games = (Games?)(object)0;
								flag2 = true;
								replyCategory = ReplyCategory.Negative;
								Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v709 @ X8_v64+40]");
								text2 = (string)0;
								if (flag14)
								{
									goto IL_1f95;
								}
							}
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v58 @ X0_v3+18]");
							bool flag15 = (nint)0 < (nint)5;
							object obj34 = !flag15;
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v58 @ X0_v3+18]");
							object obj35 = -5;
							bool flag16 = obj35 == null;
							object obj36 = ~obj34;
							object obj37 = obj36 | flag16;
							obj8 = 0;
							games = (Games?)(object)0;
							flag2 = true;
							replyCategory = ReplyCategory.Negative;
							if (obj37 == null)
							{
								object obj38 = "{0} color encoding is currently unsupported for outputting to HDR." + 2264;
								object obj39 = obj7 + 72;
								obj39 = commonWord6;
								Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
								Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
								text = (string)obj38;
								CommonWord commonWord7 = default(CommonWord);
								commonWord7..ctor((string)obj38, ReplyCategory.Negative, isForSubscribers: true, (Games?)(object)0);
								if (commonWord7 != null)
								{
									object obj40 = obj7;
									Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v710 @ X8_v63+40]");
									text = (string)0;
									Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1958");
									bool flag17 = ex == null;
									obj8 = 0;
									games = (Games?)(object)0;
									flag2 = true;
									replyCategory = ReplyCategory.Negative;
									Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v710 @ X8_v63+40]");
									text2 = (string)0;
									if (flag17)
									{
										goto IL_1f95;
									}
								}
								Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v58 @ X0_v3+18]");
								bool flag18 = (nint)0 < (nint)6;
								object obj41 = !flag18;
								Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v58 @ X0_v3+18]");
								object obj42 = -6;
								bool flag19 = obj42 == null;
								object obj43 = ~obj41;
								object obj44 = obj43 | flag19;
								obj8 = 0;
								games = (Games?)(object)0;
								flag2 = true;
								replyCategory = ReplyCategory.Negative;
								if (obj44 == null)
								{
									object obj45 = "{0} color encoding is currently unsupported for outputting to HDR." + 2288;
									object obj46 = obj7 + 80;
									obj46 = commonWord7;
									Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
									Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
									text = (string)obj45;
									CommonWord commonWord8 = default(CommonWord);
									commonWord8..ctor((string)obj45, ReplyCategory.Sorry, isForSubscribers: true, (Games?)(object)0);
									if (commonWord8 != null)
									{
										object obj47 = obj7;
										Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v711 @ X8_v62+40]");
										text = (string)0;
										Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1958");
										bool flag20 = ex == null;
										obj8 = 0;
										games = (Games?)(object)0;
										flag2 = true;
										replyCategory = ReplyCategory.Sorry;
										Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v711 @ X8_v62+40]");
										text2 = (string)0;
										if (flag20)
										{
											goto IL_1f95;
										}
									}
									Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v58 @ X0_v3+18]");
									object obj48 = 0 & 0xFFFFFFF8L;
									bool flag21 = obj48 == null;
									obj8 = 0;
									games = (Games?)(object)0;
									flag2 = true;
									replyCategory = ReplyCategory.Sorry;
									if (!flag21)
									{
										object obj49 = "{0} color encoding is currently unsupported for outputting to HDR." + 2184;
										object obj50 = obj7 + 88;
										obj50 = commonWord8;
										Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
										Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
										text = (string)obj49;
										CommonWord commonWord9 = default(CommonWord);
										commonWord9..ctor((string)obj49, ReplyCategory.Sorry, isForSubscribers: true, (Games?)(object)0);
										if (commonWord9 != null)
										{
											object obj51 = obj7;
											Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v712 @ X8_v61+40]");
											text = (string)0;
											Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1958");
											bool flag22 = ex == null;
											obj8 = 0;
											games = (Games?)(object)0;
											flag2 = true;
											replyCategory = ReplyCategory.Sorry;
											Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v712 @ X8_v61+40]");
											text2 = (string)0;
											if (flag22)
											{
												goto IL_1f95;
											}
										}
										Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v58 @ X0_v3+18]");
										bool flag23 = (nint)0 < (nint)8;
										object obj52 = !flag23;
										Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v58 @ X0_v3+18]");
										object obj53 = -8;
										bool flag24 = obj53 == null;
										object obj54 = ~obj52;
										object obj55 = obj54 | flag24;
										obj8 = 0;
										games = (Games?)(object)0;
										flag2 = true;
										replyCategory = ReplyCategory.Sorry;
										if (obj55 == null)
										{
											object obj56 = "{0} color encoding is currently unsupported for outputting to HDR." + 2448;
											object obj57 = obj7 + 96;
											obj57 = commonWord9;
											Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
											Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
											text = (string)obj56;
											CommonWord commonWord10 = default(CommonWord);
											commonWord10..ctor((string)obj56, ReplyCategory.Game, isForSubscribers: true, (Games?)(object)0);
											if (commonWord10 != null)
											{
												object obj58 = obj7;
												Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v713 @ X8_v60+40]");
												text = (string)0;
												Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1958");
												bool flag25 = ex == null;
												obj8 = 0;
												games = (Games?)(object)0;
												flag2 = true;
												replyCategory = ReplyCategory.Game;
												Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v713 @ X8_v60+40]");
												text2 = (string)0;
												if (flag25)
												{
													goto IL_1f95;
												}
											}
											Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v58 @ X0_v3+18]");
											bool flag26 = (nint)0 < (nint)9;
											object obj59 = !flag26;
											Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v58 @ X0_v3+18]");
											object obj60 = -9;
											bool flag27 = obj60 == null;
											object obj61 = ~obj59;
											object obj62 = obj61 | flag27;
											obj8 = 0;
											games = (Games?)(object)0;
											flag2 = true;
											replyCategory = ReplyCategory.Game;
											if (obj62 == null)
											{
												object obj63 = (nint)0 + (nint)2744;
												object obj64 = "{0} color encoding is currently unsupported for outputting to HDR." + 2368;
												object obj65 = obj7 + 104;
												obj65 = commonWord10;
												Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
												_ = 0;
												System.Int32Enum? int32Enum = (System.Int32Enum?)(object)System.Runtime.CompilerServices.Unsafe.AsPointer(ref System.Runtime.CompilerServices.Unsafe.SubtractByteOffset(ref obj2, 72));
												*(System.Int32Enum?*)(nint)int32Enum = (System.Int32Enum)0;
												Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
												text = (string)obj64;
												Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v20 @ X29_v1-48]");
												games = (Games?)(object)0;
												Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v20 @ X29_v1-48]");
												CommonWord commonWord11 = default(CommonWord);
												commonWord11..ctor((string)obj64, ReplyCategory.Excitement, isForSubscribers: true, (Games?)(object)0);
												if (commonWord11 != null)
												{
													object obj66 = obj7;
													Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v714 @ X8_v59+40]");
													text = (string)0;
													Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1958");
													bool flag28 = ex == null;
													obj8 = 0;
													flag2 = true;
													replyCategory = ReplyCategory.Excitement;
													Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v714 @ X8_v59+40]");
													text2 = (string)0;
													if (flag28)
													{
														goto IL_1f95;
													}
												}
												Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v58 @ X0_v3+18]");
												bool flag29 = (nint)0 < (nint)10;
												object obj67 = !flag29;
												Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v58 @ X0_v3+18]");
												object obj68 = -10;
												bool flag30 = obj68 == null;
												object obj69 = ~obj67;
												object obj70 = obj69 | flag30;
												obj8 = 0;
												flag2 = true;
												replyCategory = ReplyCategory.Excitement;
												if (obj70 == null)
												{
													object obj71 = "{0} color encoding is currently unsupported for outputting to HDR." + 2384;
													object obj72 = obj7 + 112;
													obj72 = commonWord11;
													Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
													System.Int32Enum? int32Enum2 = (System.Int32Enum)0;
													Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
													text = (string)obj71;
													CommonWord commonWord12 = default(CommonWord);
													commonWord12..ctor((string)obj71, ReplyCategory.Excitement, isForSubscribers: true, (Games?)int32Enum2);
													if (commonWord12 != null)
													{
														object obj73 = obj7;
														Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v715 @ X8_v58+40]");
														text = (string)0;
														Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1958");
														bool flag31 = ex == null;
														obj8 = 0;
														games = (Games?)int32Enum2;
														flag2 = true;
														replyCategory = ReplyCategory.Excitement;
														Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v715 @ X8_v58+40]");
														text2 = (string)0;
														if (flag31)
														{
															goto IL_1f95;
														}
													}
													Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v58 @ X0_v3+18]");
													bool flag32 = (nint)0 < (nint)11;
													object obj74 = !flag32;
													Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v58 @ X0_v3+18]");
													object obj75 = -11;
													bool flag33 = obj75 == null;
													object obj76 = ~obj74;
													object obj77 = obj76 | flag33;
													obj8 = 0;
													games = (Games?)int32Enum2;
													flag2 = true;
													replyCategory = ReplyCategory.Excitement;
													if (obj77 == null)
													{
														object obj78 = "{0} color encoding is currently unsupported for outputting to HDR." + 2304;
														object obj79 = obj7 + 120;
														obj79 = commonWord12;
														Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
														System.Int32Enum? int32Enum3 = (System.Int32Enum)0;
														Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
														text = (string)obj78;
														CommonWord commonWord13 = default(CommonWord);
														commonWord13..ctor((string)obj78, ReplyCategory.Game, isForSubscribers: true, (Games?)int32Enum3);
														if (commonWord13 != null)
														{
															object obj80 = obj7;
															Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v716 @ X8_v57+40]");
															text = (string)0;
															Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1958");
															bool flag34 = ex == null;
															obj8 = 0;
															games = (Games?)int32Enum3;
															flag2 = true;
															replyCategory = ReplyCategory.Game;
															Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v716 @ X8_v57+40]");
															text2 = (string)0;
															if (flag34)
															{
																goto IL_1f95;
															}
														}
														Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v58 @ X0_v3+18]");
														bool flag35 = (nint)0 < (nint)12;
														object obj81 = !flag35;
														Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v58 @ X0_v3+18]");
														object obj82 = -12;
														bool flag36 = obj82 == null;
														object obj83 = ~obj81;
														object obj84 = obj83 | flag36;
														obj8 = 0;
														games = (Games?)int32Enum3;
														flag2 = true;
														replyCategory = ReplyCategory.Game;
														if (obj84 == null)
														{
															object obj85 = "{0} color encoding is currently unsupported for outputting to HDR." + 2360;
															object obj86 = obj7 + 128;
															obj86 = commonWord13;
															Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
															System.Int32Enum? int32Enum4 = (System.Int32Enum)0;
															Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
															text = (string)obj85;
															CommonWord commonWord14 = default(CommonWord);
															commonWord14..ctor((string)obj85, ReplyCategory.Game, isForSubscribers: true, (Games?)int32Enum4);
															if (commonWord14 != null)
															{
																object obj87 = obj7;
																Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v717 @ X8_v56+40]");
																text = (string)0;
																Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1958");
																bool flag37 = ex == null;
																obj8 = 0;
																games = (Games?)int32Enum4;
																flag2 = true;
																replyCategory = ReplyCategory.Game;
																Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v717 @ X8_v56+40]");
																text2 = (string)0;
																if (flag37)
																{
																	goto IL_1f95;
																}
															}
															Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v58 @ X0_v3+18]");
															bool flag38 = (nint)0 < (nint)13;
															object obj88 = !flag38;
															Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v58 @ X0_v3+18]");
															object obj89 = -13;
															bool flag39 = obj89 == null;
															object obj90 = ~obj88;
															object obj91 = obj90 | flag39;
															obj8 = 0;
															games = (Games?)int32Enum4;
															flag2 = true;
															replyCategory = ReplyCategory.Game;
															if (obj91 == null)
															{
																object obj92 = "{0} color encoding is currently unsupported for outputting to HDR." + 2296;
																object obj93 = obj7 + 136;
																obj93 = commonWord14;
																Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
																System.Int32Enum? int32Enum5 = (System.Int32Enum)0;
																Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
																text = (string)obj92;
																CommonWord commonWord15 = default(CommonWord);
																commonWord15..ctor((string)obj92, ReplyCategory.Negative, isForSubscribers: true, (Games?)int32Enum5);
																if (commonWord15 != null)
																{
																	object obj94 = obj7;
																	Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v718 @ X8_v55+40]");
																	text = (string)0;
																	Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1958");
																	bool flag40 = ex == null;
																	obj8 = 0;
																	games = (Games?)int32Enum5;
																	flag2 = true;
																	replyCategory = ReplyCategory.Negative;
																	Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v718 @ X8_v55+40]");
																	text2 = (string)0;
																	if (flag40)
																	{
																		goto IL_1f95;
																	}
																}
																Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v58 @ X0_v3+18]");
																bool flag41 = (nint)0 < (nint)14;
																object obj95 = !flag41;
																Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v58 @ X0_v3+18]");
																object obj96 = -14;
																bool flag42 = obj96 == null;
																object obj97 = ~obj95;
																object obj98 = obj97 | flag42;
																obj8 = 0;
																games = (Games?)int32Enum5;
																flag2 = true;
																replyCategory = ReplyCategory.Negative;
																if (obj98 == null)
																{
																	object obj99 = "{0} color encoding is currently unsupported for outputting to HDR." + 2424;
																	object obj100 = obj7 + 144;
																	obj100 = commonWord15;
																	Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
																	System.Int32Enum? int32Enum6 = (System.Int32Enum)1;
																	Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
																	text = (string)obj99;
																	CommonWord commonWord16 = default(CommonWord);
																	commonWord16..ctor((string)obj99, ReplyCategory.Excitement, isForSubscribers: true, (Games?)int32Enum6);
																	if (commonWord16 != null)
																	{
																		object obj101 = obj7;
																		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v719 @ X8_v54+40]");
																		text = (string)0;
																		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1958");
																		bool flag43 = ex == null;
																		obj8 = 0;
																		games = (Games?)int32Enum6;
																		flag2 = true;
																		replyCategory = ReplyCategory.Excitement;
																		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v719 @ X8_v54+40]");
																		text2 = (string)0;
																		if (flag43)
																		{
																			goto IL_1f95;
																		}
																	}
																	Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v58 @ X0_v3+18]");
																	object obj102 = 0 & 0xFFFFFFF0L;
																	bool flag44 = obj102 == null;
																	obj8 = 0;
																	games = (Games?)int32Enum6;
																	flag2 = true;
																	replyCategory = ReplyCategory.Excitement;
																	if (!flag44)
																	{
																		object obj103 = "{0} color encoding is currently unsupported for outputting to HDR." + 2376;
																		object obj104 = obj7 + 152;
																		obj104 = commonWord16;
																		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
																		System.Int32Enum? int32Enum7 = (System.Int32Enum)1;
																		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
																		text = (string)obj103;
																		CommonWord commonWord17 = default(CommonWord);
																		commonWord17..ctor((string)obj103, ReplyCategory.Excitement, isForSubscribers: true, (Games?)int32Enum7);
																		if (commonWord17 != null)
																		{
																			object obj105 = obj7;
																			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v720 @ X8_v53+40]");
																			text = (string)0;
																			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1958");
																			bool flag45 = ex == null;
																			obj8 = 0;
																			games = (Games?)int32Enum7;
																			flag2 = true;
																			replyCategory = ReplyCategory.Excitement;
																			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v720 @ X8_v53+40]");
																			text2 = (string)0;
																			if (flag45)
																			{
																				goto IL_1f95;
																			}
																		}
																		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v58 @ X0_v3+18]");
																		bool flag46 = (nint)0 < (nint)16;
																		object obj106 = !flag46;
																		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v58 @ X0_v3+18]");
																		object obj107 = -16;
																		bool flag47 = obj107 == null;
																		object obj108 = ~obj106;
																		object obj109 = obj108 | flag47;
																		obj8 = 0;
																		games = (Games?)int32Enum7;
																		flag2 = true;
																		replyCategory = ReplyCategory.Excitement;
																		if (obj109 == null)
																		{
																			object obj110 = "{0} color encoding is currently unsupported for outputting to HDR." + 2272;
																			object obj111 = obj7 + 160;
																			obj111 = commonWord17;
																			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
																			System.Int32Enum? int32Enum8 = (System.Int32Enum)2;
																			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
																			text = (string)obj110;
																			CommonWord commonWord18 = default(CommonWord);
																			commonWord18..ctor((string)obj110, ReplyCategory.Excitement, isForSubscribers: true, (Games?)int32Enum8);
																			if (commonWord18 != null)
																			{
																				object obj112 = obj7;
																				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v721 @ X8_v52+40]");
																				text = (string)0;
																				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1958");
																				bool flag48 = ex == null;
																				obj8 = 0;
																				games = (Games?)int32Enum8;
																				flag2 = true;
																				replyCategory = ReplyCategory.Excitement;
																				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v721 @ X8_v52+40]");
																				text2 = (string)0;
																				if (flag48)
																				{
																					goto IL_1f95;
																				}
																			}
																			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v58 @ X0_v3+18]");
																			bool flag49 = (nint)0 < (nint)17;
																			object obj113 = !flag49;
																			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v58 @ X0_v3+18]");
																			object obj114 = -17;
																			bool flag50 = obj114 == null;
																			object obj115 = ~obj113;
																			object obj116 = obj115 | flag50;
																			obj8 = 0;
																			games = (Games?)int32Enum8;
																			flag2 = true;
																			replyCategory = ReplyCategory.Excitement;
																			if (obj116 == null)
																			{
																				object obj117 = obj7 + 168;
																				obj117 = commonWord18;
																				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
																				System.Int32Enum? int32Enum9 = (System.Int32Enum)2;
																				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
																				text = (string)obj64;
																				CommonWord commonWord19 = default(CommonWord);
																				commonWord19..ctor((string)obj64, ReplyCategory.Excitement, isForSubscribers: true, (Games?)int32Enum9);
																				if (commonWord19 != null)
																				{
																					object obj118 = obj7;
																					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v722 @ X8_v51+40]");
																					text = (string)0;
																					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1958");
																					bool flag51 = ex == null;
																					obj8 = 0;
																					games = (Games?)int32Enum9;
																					flag2 = true;
																					replyCategory = ReplyCategory.Excitement;
																					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v722 @ X8_v51+40]");
																					text2 = (string)0;
																					if (flag51)
																					{
																						goto IL_1f95;
																					}
																				}
																				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v58 @ X0_v3+18]");
																				bool flag52 = (nint)0 < (nint)18;
																				object obj119 = !flag52;
																				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v58 @ X0_v3+18]");
																				object obj120 = -18;
																				bool flag53 = obj120 == null;
																				object obj121 = ~obj119;
																				object obj122 = obj121 | flag53;
																				obj8 = 0;
																				games = (Games?)int32Enum9;
																				flag2 = true;
																				replyCategory = ReplyCategory.Excitement;
																				if (obj122 == null)
																				{
																					object obj123 = "{0} color encoding is currently unsupported for outputting to HDR." + 2240;
																					object obj124 = obj7 + 176;
																					obj124 = commonWord19;
																					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
																					System.Int32Enum? int32Enum10 = (System.Int32Enum)2;
																					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
																					text = (string)obj123;
																					CommonWord commonWord20 = default(CommonWord);
																					commonWord20..ctor((string)obj123, ReplyCategory.Game, isForSubscribers: true, (Games?)int32Enum10);
																					if (commonWord20 != null)
																					{
																						object obj125 = obj7;
																						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v723 @ X8_v50+40]");
																						text = (string)0;
																						Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1958");
																						bool flag54 = ex == null;
																						obj8 = 0;
																						games = (Games?)int32Enum10;
																						flag2 = true;
																						replyCategory = ReplyCategory.Game;
																						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v723 @ X8_v50+40]");
																						text2 = (string)0;
																						if (flag54)
																						{
																							goto IL_1f95;
																						}
																					}
																					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v58 @ X0_v3+18]");
																					bool flag55 = (nint)0 < (nint)19;
																					object obj126 = !flag55;
																					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v58 @ X0_v3+18]");
																					object obj127 = -19;
																					bool flag56 = obj127 == null;
																					object obj128 = ~obj126;
																					object obj129 = obj128 | flag56;
																					obj8 = 0;
																					games = (Games?)int32Enum10;
																					flag2 = true;
																					replyCategory = ReplyCategory.Game;
																					if (obj129 == null)
																					{
																						object obj130 = obj7 + 184;
																						obj130 = commonWord20;
																						Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
																						System.Int32Enum? int32Enum11 = (System.Int32Enum)2;
																						Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
																						text = (string)obj92;
																						CommonWord commonWord21 = default(CommonWord);
																						commonWord21..ctor((string)obj92, ReplyCategory.Negative, isForSubscribers: true, (Games?)int32Enum11);
																						if (commonWord21 != null)
																						{
																							object obj131 = obj7;
																							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v724 @ X8_v49+40]");
																							text = (string)0;
																							Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1958");
																							bool flag57 = ex == null;
																							obj8 = 0;
																							games = (Games?)int32Enum11;
																							flag2 = true;
																							replyCategory = ReplyCategory.Negative;
																							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v724 @ X8_v49+40]");
																							text2 = (string)0;
																							if (flag57)
																							{
																								goto IL_1f95;
																							}
																						}
																						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v58 @ X0_v3+18]");
																						bool flag58 = (nint)0 < (nint)20;
																						object obj132 = !flag58;
																						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v58 @ X0_v3+18]");
																						object obj133 = -20;
																						bool flag59 = obj133 == null;
																						object obj134 = ~obj132;
																						object obj135 = obj134 | flag59;
																						obj8 = 0;
																						games = (Games?)int32Enum11;
																						flag2 = true;
																						replyCategory = ReplyCategory.Negative;
																						if (obj135 == null)
																						{
																							object obj136 = typeof(System.Runtime.Remoting.Messaging.CallContextSecurityData) + 2080;
																							object obj137 = obj7 + 192;
																							obj137 = commonWord21;
																							Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
																							object obj138 = obj136;
																							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v635 @ X8_v48+B8]");
																							object obj139 = 0;
																							obj139 = obj7;
																							Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
																							return;
																						}
																					}
																				}
																			}
																		}
																	}
																}
															}
														}
													}
												}
											}
										}
									}
								}
							}
						}
					}
				}
			}
		}
		ex = new IndexOutOfRangeException();
		text2 = text;
		goto IL_1f95;
		IL_1f95:
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1ABC");
		OutOfMemoryException ex2 = new OutOfMemoryException();
		throw new NullReferenceException();
	}
}

using System;
using System.Buffers.Text;
using System.Collections;
using System.Collections.Generic;
using System.Data.SqlTypes;
using System.Linq;
using System.Runtime.CompilerServices;
using Cpp2ILInjected;
using Kammelna.Server.Models.Clans;
using Microsoft.Extensions.DependencyInjection.ServiceLookup;
using Newtonsoft.Json.Linq.JsonPath;
using TMPro;
using Unity.Properties;
using Unity.Services.Authentication.Shared;
using UnityEngine;
using UnityEngine.Purchasing.Telemetry;
using UnityEngine.TextCore;
using UnityEngine.UI;

public class ReferralSuccessPopup : MonoBehaviour
{
	[Serializable]
	private sealed class <>c
	{
		public static readonly <>c <>9;

		public static Func<UserReferralModel, bool> <>9__7_0;

		static <>c()
		{
			//IL_000f: Unknown result type (might be due to invalid IL or missing references)
			//IL_0014: Expected O, but got Unknown
			object obj = typeof(RankedPlayManager.<>c__DisplayClass36_0) + 296;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
			object obj2 = default(object);
			obj2..ctor();
			object obj3 = obj;
			object obj4 = obj2;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
		}

		internal bool <ShowReferralRewards>b__7_0(UserReferralModel referral)
		{
			//IL_0035: Expected I4, but got O
			if (referral != null)
			{
				return referral.<isNew>k__BackingField;
			}
			NullReferenceException ex = new NullReferenceException();
			return (byte)(int)ex != 0;
		}
	}

	private TextMeshProUGUI referralDescription;

	private PopupUI popup;

	private GameObject template;

	private Sprite subscriptionIcon;

	private Sprite coinsIcon;

	private Sprite itemIcon;

	private void Start()
	{
		//IL_000f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0014: Expected O, but got Unknown
		//IL_0020: Expected O, but got I
		//IL_002f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0034: Expected O, but got Unknown
		//IL_0074: Expected I, but got O
		object obj = typeof(SqlSingle[]) + 2376;
		object obj2 = (nint)0 + (nint)2112;
		object obj3 = typeof(System.Buffers.Text.ParserHelpers) + 3696;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
		Action action = default(Action);
		action..ctor(this, (IntPtr)obj2);
		object obj4 = obj3;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v64 @ X0_v4+E4]");
		if ((nint)0 != 0)
		{
			ReferralHandler.CallWhenReady(action);
			return;
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		ReferralHandler.CallWhenReady(action);
	}

	public unsafe void ShowReferralRewards()
	{
		//IL_0008: Expected O, but got Ref
		//IL_0017: Unknown result type (might be due to invalid IL or missing references)
		//IL_001c: Expected O, but got Unknown
		//IL_00e3: Expected O, but got I
		//IL_00fd: Expected O, but got I4
		//IL_0037: Expected O, but got I
		//IL_0173: Expected O, but got I
		//IL_013b: Expected O, but got I4
		//IL_0099: Expected O, but got I
		//IL_02ee: Expected O, but got I
		//IL_0308: Expected O, but got I4
		//IL_01d6: Expected O, but got I
		//IL_0346: Expected O, but got I4
		//IL_0238: Expected O, but got I
		//IL_0247: Unknown result type (might be due to invalid IL or missing references)
		//IL_024c: Expected O, but got Unknown
		//IL_0395: Expected O, but got I
		//IL_03a5: Expected O, but got I
		//IL_03c7: Expected O, but got I4
		//IL_0448: Expected O, but got I
		//IL_0465: Expected O, but got I
		//IL_0289: Expected O, but got I
		//IL_0299: Expected O, but got I
		//IL_02bb: Expected O, but got I4
		//IL_0495: Unknown result type (might be due to invalid IL or missing references)
		//IL_049a: Expected O, but got Unknown
		//IL_04bc: Expected O, but got I4
		//IL_04cb: Expected O, but got I4
		//IL_04d4: Expected O, but got I4
		//IL_03e5: Expected O, but got I
		//IL_0407: Expected O, but got I4
		//IL_18ba: Unknown result type (might be due to invalid IL or missing references)
		//IL_18bf: Expected O, but got Unknown
		//IL_18d5: Expected O, but got I
		//IL_18e6: Expected I, but got O
		//IL_1904: Expected O, but got I
		//IL_04fa: Expected O, but got I4
		//IL_051c: Expected O, but got I4
		//IL_052b: Expected O, but got I4
		//IL_0534: Expected O, but got I4
		//IL_0437: Expected O, but got I
		//IL_0601: Expected O, but got I4
		//IL_0618: Expected O, but got I4
		//IL_0621: Expected O, but got I4
		//IL_181b: Expected O, but got I
		//IL_1823: Expected I4, but got O
		//IL_0577: Expected I, but got O
		//IL_05a9: Expected O, but got I4
		//IL_05b8: Expected O, but got I4
		//IL_05c1: Expected O, but got I4
		//IL_0640: Unknown result type (might be due to invalid IL or missing references)
		//IL_0645: Expected O, but got Unknown
		//IL_0661: Unknown result type (might be due to invalid IL or missing references)
		//IL_0666: Expected O, but got Unknown
		//IL_068b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0690: Expected O, but got Unknown
		//IL_06a6: Expected O, but got I
		//IL_06ae: Expected I4, but got O
		//IL_06cc: Expected O, but got I4
		//IL_0947: Expected O, but got I4
		//IL_0956: Expected O, but got I4
		//IL_095f: Expected O, but got I4
		//IL_0709: Unknown result type (might be due to invalid IL or missing references)
		//IL_070e: Expected O, but got Unknown
		//IL_0726: Expected O, but got I4
		//IL_0735: Expected O, but got I4
		//IL_073e: Expected O, but got I4
		//IL_099f: Expected O, but got I4
		//IL_09ae: Expected O, but got I4
		//IL_09b7: Expected O, but got I4
		//IL_076d: Expected O, but got I
		//IL_077a: Expected O, but got I
		//IL_0797: Expected I4, but got O
		//IL_079f: Expected I4, but got O
		//IL_07a8: Expected O, but got I4
		//IL_0a02: Expected O, but got I4
		//IL_0a11: Expected O, but got I4
		//IL_0a1a: Expected O, but got I4
		//IL_07db: Expected O, but got I4
		//IL_07e4: Expected O, but got I4
		//IL_07fb: Expected O, but got I4
		//IL_0804: Expected O, but got I4
		//IL_081c: Expected O, but got I4
		//IL_0a5a: Unknown result type (might be due to invalid IL or missing references)
		//IL_0a5f: Expected O, but got Unknown
		//IL_084a: Expected O, but got I
		//IL_086a: Expected O, but got I4
		//IL_0879: Expected O, but got I4
		//IL_0882: Expected O, but got I4
		//IL_089a: Expected O, but got I4
		//IL_0a86: Expected O, but got I4
		//IL_0a95: Expected O, but got I4
		//IL_0a9e: Expected O, but got I4
		//IL_08e1: Expected O, but got I
		//IL_0adc: Expected O, but got I4
		//IL_0af3: Expected O, but got I4
		//IL_0afc: Expected O, but got I4
		//IL_196d: Expected I4, but got O
		//IL_1983: Expected O, but got I
		//IL_1992: Expected O, but got I4
		//IL_19b5: Expected I4, but got O
		//IL_19c5: Expected I4, but got O
		//IL_19cd: Expected O, but got I4
		//IL_0b29: Unknown result type (might be due to invalid IL or missing references)
		//IL_0b2e: Expected O, but got Unknown
		//IL_0b6c: Expected O, but got I4
		//IL_0b7b: Expected O, but got I4
		//IL_0b84: Expected O, but got I4
		//IL_0b8c: Expected I4, but got O
		//IL_0bc4: Unknown result type (might be due to invalid IL or missing references)
		//IL_0bc9: Expected O, but got Unknown
		//IL_0bd8: Unknown result type (might be due to invalid IL or missing references)
		//IL_0bdd: Expected O, but got Unknown
		//IL_0be9: Expected O, but got I
		//IL_0bf8: Unknown result type (might be due to invalid IL or missing references)
		//IL_0bfd: Expected O, but got Unknown
		//IL_0c0c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0c11: Expected O, but got Unknown
		//IL_0c1a: Expected O, but got I4
		//IL_0c59: Expected O, but got I
		//IL_16d5: Expected O, but got I
		//IL_16dd: Expected I4, but got O
		//IL_16ee: Expected O, but got Ref
		//IL_16f7: Expected O, but got I4
		//IL_0da1: Expected I8, but got I4
		//IL_0db5: Unknown result type (might be due to invalid IL or missing references)
		//IL_0dba: Expected O, but got Unknown
		//IL_0de4: Expected O, but got I4
		//IL_0cb2: Unknown result type (might be due to invalid IL or missing references)
		//IL_0cb7: Expected O, but got Unknown
		//IL_0ce1: Expected O, but got I4
		//IL_0e0d: Expected O, but got I
		//IL_0d08: Unknown result type (might be due to invalid IL or missing references)
		//IL_0d0d: Expected O, but got Unknown
		//IL_0d1a: Unknown result type (might be due to invalid IL or missing references)
		//IL_0d1f: Expected O, but got Unknown
		//IL_0d55: Expected I8, but got O
		//IL_1755: Expected I4, but got O
		//IL_17af: Expected O, but got Ref
		//IL_17b8: Expected O, but got I4
		//IL_0ea0: Expected O, but got I4
		//IL_0f7d: Expected I, but got O
		//IL_0f8d: Expected O, but got I
		//IL_0efa: Expected O, but got Ref
		//IL_0f04: Expected O, but got I4
		//IL_1a3a: Unknown result type (might be due to invalid IL or missing references)
		//IL_1a3f: Expected O, but got Unknown
		//IL_1bbb: Unknown result type (might be due to invalid IL or missing references)
		//IL_1bc0: Expected O, but got Unknown
		//IL_1bc8: Expected I4, but got O
		//IL_19f3: Expected O, but got I
		//IL_1b2b: Expected O, but got Ref
		//IL_1b35: Expected O, but got I4
		//IL_1035: Expected O, but got I
		//IL_1042: Expected O, but got I
		//IL_104b: Unknown result type (might be due to invalid IL or missing references)
		//IL_1050: Expected O, but got Unknown
		//IL_178f: Expected O, but got Ref
		//IL_1799: Expected O, but got I4
		//IL_14a6: Unknown result type (might be due to invalid IL or missing references)
		//IL_14ab: Expected O, but got Unknown
		//IL_14c3: Expected O, but got I
		//IL_15c5: Expected O, but got Ref
		//IL_15cf: Expected O, but got I4
		//IL_0ff1: Expected O, but got I
		//IL_1082: Expected I, but got O
		//IL_1092: Expected O, but got I
		//IL_1131: Expected O, but got I4
		//IL_1b52: Expected O, but got I
		//IL_154c: Unknown result type (might be due to invalid IL or missing references)
		//IL_1551: Expected O, but got Unknown
		//IL_155a: Unknown result type (might be due to invalid IL or missing references)
		//IL_155f: Expected O, but got Unknown
		//IL_159d: Expected O, but got Ref
		//IL_15a7: Expected O, but got I4
		//IL_1a6c: Expected O, but got I
		//IL_151a: Unknown result type (might be due to invalid IL or missing references)
		//IL_151f: Expected O, but got Unknown
		//IL_1174: Expected I4, but got O
		//IL_119c: Expected O, but got I
		//IL_11c5: Expected O, but got I4
		//IL_1144: Expected O, but got I
		//IL_114c: Unknown result type (might be due to invalid IL or missing references)
		//IL_1151: Expected O, but got Unknown
		//IL_115a: Unknown result type (might be due to invalid IL or missing references)
		//IL_115f: Expected O, but got Unknown
		//IL_1575: Expected O, but got Ref
		//IL_157f: Expected O, but got I4
		//IL_10f6: Expected O, but got I
		//IL_11f9: Expected O, but got I
		//IL_1228: Expected I4, but got O
		//IL_1257: Expected I, but got O
		//IL_125f: Expected I, but got O
		//IL_126f: Expected O, but got I
		//IL_1298: Expected O, but got I4
		//IL_1318: Expected I, but got O
		//IL_1328: Expected O, but got I
		//IL_1349: Expected O, but got I4
		//IL_12bf: Expected O, but got I
		//IL_12dc: Expected O, but got I
		//IL_12ec: Expected O, but got I
		//IL_137d: Expected O, but got I
		//IL_0f1e: Expected I4, but got O
		//IL_13ad: Unknown result type (might be due to invalid IL or missing references)
		//IL_13b2: Expected O, but got Unknown
		//IL_13cc: Expected O, but got I4
		//IL_1492: Expected O, but got I4
		//IL_1ad7: Expected O, but got I
		//IL_1af1: Expected I4, but got O
		//IL_15f0: Unknown result type (might be due to invalid IL or missing references)
		//IL_15f5: Expected O, but got Unknown
		//IL_160d: Expected O, but got Ref
		//IL_162b: Unknown result type (might be due to invalid IL or missing references)
		//IL_1630: Expected O, but got Unknown
		//IL_147a: Expected O, but got I4
		//IL_1653: Unknown result type (might be due to invalid IL or missing references)
		//IL_1658: Expected O, but got Unknown
		//IL_142f: Expected O, but got I4
		//IL_1685: Expected O, but got I
		//IL_16a5: Expected O, but got Ref
		//IL_16af: Expected O, but got I4
		object obj2 = default(object);
		object obj = (object)(&obj2);
		object obj3 = typeof(System.Buffers.Text.ParserHelpers) + 3696;
		_ = 0;
		object obj4 = obj3;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v62 @ X0_v2+E4]");
		if ((nint)0 != 0)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [8BE45A2]");
			object obj5 = (nint)0 & (nint)1;
			if (obj5 != null)
			{
				goto IL_0054;
			}
		}
		else
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [8BE45A2]");
			object obj6 = (nint)0 & (nint)1;
			bool flag = obj6 == null;
			object obj7 = !flag;
			if (obj7 != null)
			{
				goto IL_0054;
			}
		}
		_ = 1;
		object obj8 = obj3;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v145 @ X0_v4+E4]");
		bool flag2 = (nint)0 == 0;
		object obj9 = !flag2;
		object obj10 = obj8;
		if (obj9 != null)
		{
			goto IL_0089;
		}
		goto IL_0151;
		IL_17d5:
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1ABC");
		OutOfMemoryException ex = new OutOfMemoryException();
		bool flag3 = false;
		goto IL_1928;
		IL_1928:
		NullReferenceException ex2 = new NullReferenceException();
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @1C99B68");
		bool flag4 = !flag3;
		NullReferenceException ex3 = ex2;
		Dictionary<System.Int32Enum, int>.Enumerator enumerator = default(Dictionary<System.Int32Enum, int>.Enumerator);
		object[] array2 = default(object[]);
		object[] array;
		object obj13;
		if (!flag4)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @6CB0B80");
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @6CB0BB0");
			object obj11 = (nint)0 + (nint)2272;
			flag3 = (byte)(int)obj11 != 0;
			((Dictionary<System.Int32Enum, int>.Enumerator*)enumerator)->Dispose();
			object obj12 = default(object);
			bool flag5 = obj12 == null;
			array = array2;
			obj13 = obj12;
			if (flag5)
			{
				goto IL_170c;
			}
			OutOfMemoryException ex4 = new OutOfMemoryException();
			obj13 = obj12;
			ex3 = (NullReferenceException)(object)ex4;
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @223824C");
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @6CB03A0");
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2B060");
		return;
		IL_15b4:
		NullReferenceException ex5 = new NullReferenceException();
		object obj14;
		array = (object[])(&obj14);
		Dictionary<System.Int32Enum, int>.Enumerator enumerator2 = (Dictionary<System.Int32Enum, int>.Enumerator)0;
		object obj16;
		object obj15 = obj16;
		goto IL_17a6;
		IL_0054:
		obj8 = obj3;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v145 @ X0_v4+E4]");
		bool flag6 = (nint)0 == 0;
		obj10 = obj8;
		if (!flag6)
		{
			goto IL_0089;
		}
		goto IL_0151;
		IL_0151:
		Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		obj8 = obj3;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v145 @ X0_v4+B8]");
		object obj17 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v153 @ X8_v132+10]");
		if ((nint)0 == 1)
		{
			goto IL_019b;
		}
		return;
		IL_0089:
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v145 @ X0_v4+B8]");
		object obj18 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v105 @ X8_v139+10]");
		if ((nint)0 != 1)
		{
			return;
		}
		goto IL_019b;
		IL_019b:
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v145 @ X0_v4+E4]");
		if ((nint)0 != 0)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [8BE459E]");
			object obj19 = (nint)0 & (nint)1;
			if (obj19 != null)
			{
				goto IL_01f3;
			}
		}
		else
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [8BE459E]");
			object obj20 = (nint)0 & (nint)1;
			bool flag7 = obj20 == null;
			object obj21 = !flag7;
			if (obj21 != null)
			{
				goto IL_01f3;
			}
		}
		_ = 1;
		object obj22 = obj3;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v377 @ X0_v14+E4]");
		bool flag8 = (nint)0 == 0;
		object obj23 = !flag8;
		object obj24 = obj22;
		if (obj23 != null)
		{
			goto IL_0228;
		}
		goto IL_035c;
		IL_158c:
		NullReferenceException ex6 = new NullReferenceException();
		array = (object[])(&obj14);
		enumerator2 = (Dictionary<System.Int32Enum, int>.Enumerator)0;
		obj15 = obj16;
		goto IL_17a6;
		IL_17a6:
		Dictionary<System.Int32Enum, int>.Enumerator enumerator3;
		enumerator = (Dictionary<System.Int32Enum, int>.Enumerator)(&enumerator3);
		obj13 = 0;
		object[] array3 = array2;
		Dictionary<System.Int32Enum, int>.Enumerator enumerator4 = enumerator2;
		object[] array4 = (object[])obj15;
		goto IL_1936;
		IL_1afb:
		object obj25 = default(object);
		obj14 = obj25;
		object obj27;
		object obj26 = obj27;
		object obj29;
		object obj28 = obj29;
		object obj31;
		object obj30 = obj31;
		nint num2;
		nint num = num2;
		array = (object[])(&obj14);
		enumerator2 = (Dictionary<System.Int32Enum, int>.Enumerator)0;
		array4 = (object[])obj16;
		OutOfMemoryException ex7 = new OutOfMemoryException();
		obj14 = obj25;
		array = (object[])(&obj14);
		enumerator2 = (Dictionary<System.Int32Enum, int>.Enumerator)0;
		obj15 = obj16;
		goto IL_17a6;
		IL_01f3:
		obj22 = obj3;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v377 @ X0_v14+E4]");
		bool flag9 = (nint)0 == 0;
		obj24 = obj22;
		if (!flag9)
		{
			goto IL_0228;
		}
		goto IL_035c;
		IL_035c:
		Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		obj22 = obj3;
		goto IL_0228;
		IL_0228:
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v377 @ X0_v14+B8]");
		object obj32 = 0;
		object obj33 = typeof(RankedPlayManager.<>c__DisplayClass36_0) + 296;
		object obj34 = obj33;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v442 @ X0_v146+E4]");
		object obj35;
		Func<object, bool> predicate;
		if ((nint)0 != 0)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v442 @ X0_v146+B8]");
			obj35 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v456 @ X8_v118+8]");
			predicate = (Func<object, bool>)0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v456 @ X8_v118+8]");
			bool flag10 = (nint)0 == 0;
			object obj36 = !flag10;
			if (obj36 == null)
			{
				goto IL_03d5;
			}
		}
		else
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			obj34 = obj33;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v442 @ X0_v146+B8]");
			obj35 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v456 @ X8_v118+8]");
			predicate = (Func<object, bool>)0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v456 @ X8_v118+8]");
			bool flag11 = (nint)0 == 0;
			object obj37 = !flag11;
			if (obj37 == null)
			{
				goto IL_03d5;
			}
		}
		goto IL_043c;
		IL_15dc:
		object obj38 = typeof(System.Buffers.Text.ParserHelpers) + 3712;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC17CC");
		object obj39 = (object)System.Runtime.CompilerServices.Unsafe.AsPointer(ref System.Runtime.CompilerServices.Unsafe.SubtractByteOffset(ref obj2, 84));
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC195C");
		object obj40 = typeof(Unity.Services.Authentication.Shared.ApiConfiguration) + 656;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC17CC");
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
		object obj41 = "placementId" + 1008;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC17CC");
		ArgumentOutOfRangeException ex8 = default(ArgumentOutOfRangeException);
		string paramName = default(string);
		object obj42 = default(object);
		ex8..ctor(paramName, obj42, null);
		object obj43 = (nint)0 + (nint)2104;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC17CC");
		OutOfMemoryException ex9 = new OutOfMemoryException();
		array = (object[])(&obj14);
		enumerator2 = (Dictionary<System.Int32Enum, int>.Enumerator)0;
		string text = null;
		bool flag13 = default(bool);
		bool flag12 = flag13;
		obj15 = obj42;
		goto IL_17a6;
		IL_1564:
		InvalidCastException ex10 = new InvalidCastException();
		array = (object[])(&obj14);
		enumerator2 = (Dictionary<System.Int32Enum, int>.Enumerator)0;
		obj15 = obj16;
		goto IL_17a6;
		IL_03d5:
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v442 @ X0_v146+E4]");
		object obj44 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v442 @ X0_v146+E4]");
		bool flag14 = (nint)0 == 0;
		object obj45 = !flag14;
		if (obj45 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			object obj46 = obj33;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v472 @ X8_v124+B8]");
			obj35 = 0;
		}
		object obj47 = typeof(Func<Type, Microsoft.Extensions.DependencyInjection.ServiceLookup.ServiceCallSite>) + 136;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
		object obj48 = (nint)0 + (nint)3544;
		Func<object, bool> func = default(Func<object, bool>);
		func..ctor(obj35, (IntPtr)obj48);
		object obj49 = obj33;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v427 @ X8_v123+B8]");
		object obj50 = (nint)0 + (nint)8;
		obj50 = func;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
		text = null;
		predicate = func;
		goto IL_043c;
		IL_092d:
		bool flag15 = (object)template == null;
		obj14 = 0;
		IEnumerator enumerator5 = null;
		enumerator3 = (Dictionary<System.Int32Enum, int>.Enumerator)0;
		enumerator4 = (Dictionary<System.Int32Enum, int>.Enumerator)0;
		Dictionary<System.Int32Enum, int> dictionary = default(Dictionary<System.Int32Enum, int>);
		TextMeshProUGUI textMeshProUGUI = (TextMeshProUGUI)(object)dictionary;
		object obj94;
		if (!flag15)
		{
			template.SetActive(value: false);
			bool flag16 = (object)template == null;
			obj14 = 0;
			enumerator5 = null;
			enumerator3 = (Dictionary<System.Int32Enum, int>.Enumerator)0;
			enumerator4 = (Dictionary<System.Int32Enum, int>.Enumerator)0;
			flag3 = false;
			array4 = null;
			textMeshProUGUI = (TextMeshProUGUI)(object)dictionary;
			if (!flag16)
			{
				Transform transform = template.transform;
				bool flag17 = (object)transform == null;
				obj14 = 0;
				enumerator5 = null;
				enumerator3 = (Dictionary<System.Int32Enum, int>.Enumerator)0;
				enumerator4 = (Dictionary<System.Int32Enum, int>.Enumerator)0;
				flag3 = false;
				array4 = null;
				textMeshProUGUI = (TextMeshProUGUI)(object)dictionary;
				if (!flag17)
				{
					Transform parent = transform.parent;
					object obj51 = typeof(TypeConverter<ushort, char>) + 2568;
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC18B4");
					object[] array5 = default(object[]);
					bool flag18 = array5 == null;
					obj14 = 0;
					enumerator5 = null;
					enumerator3 = (Dictionary<System.Int32Enum, int>.Enumerator)0;
					enumerator4 = (Dictionary<System.Int32Enum, int>.Enumerator)0;
					flag3 = true;
					array4 = null;
					textMeshProUGUI = (TextMeshProUGUI)(object)dictionary;
					if (!flag18)
					{
						bool flag19 = array5.Length == 0;
						obj14 = 0;
						array = array2;
						enumerator5 = null;
						enumerator3 = (Dictionary<System.Int32Enum, int>.Enumerator)0;
						enumerator4 = (Dictionary<System.Int32Enum, int>.Enumerator)0;
						flag12 = true;
						array4 = null;
						textMeshProUGUI = (TextMeshProUGUI)(object)dictionary;
						if (flag19)
						{
							goto IL_1936;
						}
						object obj52 = array5 + 32;
						obj52 = template;
						Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
						UIExtensions.DestroyAllChildren(parent, (GameObject[])array5);
						bool flag20 = dictionary == null;
						obj14 = 0;
						enumerator5 = null;
						enumerator3 = (Dictionary<System.Int32Enum, int>.Enumerator)0;
						enumerator4 = (Dictionary<System.Int32Enum, int>.Enumerator)0;
						flag3 = (byte)(int)array5 != 0;
						array4 = null;
						textMeshProUGUI = (TextMeshProUGUI)(object)dictionary;
						if (!flag20)
						{
							Dictionary<System.Int32Enum, int>.Enumerator enumerator6 = dictionary.GetEnumerator();
							obj33 = typeof(UnityEngine.TextCore.HorizontalAlignment) + 2528;
							object obj53 = typeof(UnityEngine.Purchasing.Telemetry.TelemetryMetricsInstanceWrapper) + 1952;
							object obj54 = (nint)0 + (nint)3816;
							textMeshProUGUI = (TextMeshProUGUI)(typeof(UnityEngine.Purchasing.Telemetry.TelemetryMetricsInstanceWrapper) + 480);
							object obj55 = typeof(System.IOAsyncCallback) + 2456;
							obj14 = 0;
							array = array2;
							enumerator5 = null;
							array4 = null;
							object obj56 = (nint)0 + (nint)2280;
							if (enumerator3.MoveNext())
							{
								string text2;
								if ((nint)array2 == 1)
								{
									object obj57 = typeof(Newtonsoft.Json.Linq.JsonPath.JPath) + 2656;
									object obj58 = obj57;
									Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1006 @ X0_v132+E4]");
									bool flag21 = (nint)0 == 0;
									object obj59 = !flag21;
									if (obj59 == null)
									{
										Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
									}
									object input = "DNQUALIFIER" + 1456;
									object obj61 = default(object);
									object obj60 = obj61 * 3257812231L;
									object obj62 = obj60 >> 32;
									object obj63 = obj62 + obj61;
									obj44 = obj63 >> 16;
									long num3 = (long)(obj44 + obj63);
									text2 = LocalizationUtil.Localize((string)input, num3);
									long num4 = num3;
									array4 = null;
								}
								else
								{
									int num5 = (int)System.Runtime.CompilerServices.Unsafe.AsPointer(ref System.Runtime.CompilerServices.Unsafe.SubtractByteOffset(ref obj2, 88));
									text2 = ((int*)num5)->ToString();
									long num4 = 0L;
								}
								object obj64 = typeof(MemberAchievementClanFeedData) + 2976;
								object obj65 = obj64;
								Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1038 @ X0_v73+E4]");
								bool flag22 = (nint)0 == 0;
								object obj66 = !flag22;
								if (obj66 == null)
								{
									Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
								}
								object obj67 = (nint)0 + (nint)544;
								obj15 = obj67;
								Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2EE9D50");
								GameObject gameObject = default(GameObject);
								if ((object)gameObject != null)
								{
									gameObject.SetActive(value: true);
									Transform transform2 = gameObject.transform;
									if ((object)transform2 != null)
									{
										IEnumerator enumerator7 = transform2.GetEnumerator();
										bool flag23 = enumerator7 == null;
										object obj68 = !flag23;
										flag12 = false;
										obj15 = null;
										obj27 = obj26;
										obj29 = obj28;
										obj31 = obj30;
										num2 = num;
										IEnumerator enumerator8 = enumerator7;
										obj16 = null;
										if (obj68 == null)
										{
											goto IL_0ee9;
										}
										object obj71 = default(object);
										TextMeshProUGUI textMeshProUGUI2 = default(TextMeshProUGUI);
										object obj86 = default(object);
										while (true)
										{
											nint num6 = (nint)enumerator8;
											Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1202 @ X8_v66 (Il2CppClass<System.Collections.IEnumerator>)+12E]");
											obj44 = 0;
											Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1202 @ X8_v66 (Il2CppClass<System.Collections.IEnumerator>)+12E]");
											if ((nint)0 == 0)
											{
												goto IL_1019;
											}
											Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1202 @ X8_v66 (Il2CppClass<System.Collections.IEnumerator>)+B0]");
											nint num7 = (nint)0 + (nint)8;
											while (true)
											{
												Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1235 @ X10_v31 (Il2CppClass<TMPro.TextMeshProUGUI>)-8]");
												obj31 = 0;
												Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1235 @ X10_v31 (Il2CppClass<TMPro.TextMeshProUGUI>)-8]");
												if (0 == (nint)obj33)
												{
													break;
												}
												num2 = num7 + 16;
												Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1202 @ X8_v66 (Il2CppClass<System.Collections.IEnumerator>)+12E]");
												obj44 = -1;
												bool flag24 = (nint)obj44 != 1;
												num7 = num2;
												if (flag24)
												{
													continue;
												}
												goto IL_1019;
											}
											obj44 = num7;
											object obj69 = num6 + num7;
											object obj70 = obj69 + 312;
											num2 = num7;
											goto IL_1a17;
											IL_111e:
											Cpp2ILHelpers.NoteDecompilerIssue("Method not found @B0D070");
											obj16 = 1;
											goto IL_1a90;
											IL_1a90:
											Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1355 @ X0_v98+8]");
											flag12 = false;
											Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v1355 @ X0_v98] (should have been resolved before IL gen)");
											Sprite sprite;
											if (obj71 != null)
											{
												flag12 = (byte)(int)obj53 != 0;
												object obj72 = obj71;
												Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1389 @ X8_v82+130]");
												num = 0;
												Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v694 @ X1_v16 (System.Boolean)+130]");
												obj44 = 0;
												Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1389 @ X8_v82+130]");
												nint num8 = 0;
												Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v694 @ X1_v16 (System.Boolean)+130]");
												bool flag25 = num8 < 0;
												object obj73 = !flag25;
												object obj74 = ~obj73;
												if (obj74 == null)
												{
													Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1389 @ X8_v82+C8]");
													nint num9 = 0;
													Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v694 @ X1_v16 (System.Boolean)+130]");
													object obj75 = num9 + 0;
													Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1424 @ X8_v85-8]");
													if ((nint)0 == (flag12 ? 1 : 0))
													{
														flag12 = (byte)(int)obj54 != 0;
														Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2D3103C");
														if ((object)textMeshProUGUI2 != null)
														{
															num = (nint)textMeshProUGUI;
															nint num10 = (nint)textMeshProUGUI2;
															Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1445 @ X8_v87 (Il2CppClass<TMPro.TextMeshProUGUI>)+130]");
															obj44 = 0;
															Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1445 @ X8_v87 (Il2CppClass<TMPro.TextMeshProUGUI>)+130]");
															nint num11 = 0;
															Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1165 @ X10_v22 (Il2CppClass<TMPro.TextMeshProUGUI>)+130]");
															bool flag26 = num11 < 0;
															object obj76 = !flag26;
															object obj77 = ~obj76;
															if (obj77 == null)
															{
																Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1445 @ X8_v87 (Il2CppClass<TMPro.TextMeshProUGUI>)+C8]");
																obj29 = 0;
																Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1445 @ X8_v87 (Il2CppClass<TMPro.TextMeshProUGUI>)+C8]");
																nint num12 = 0;
																Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1165 @ X10_v22 (Il2CppClass<TMPro.TextMeshProUGUI>)+130]");
																object obj78 = num12 + 0;
																Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1501 @ X11_v20-8]");
																obj31 = 0;
																Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1501 @ X11_v20-8]");
																if (0 == num)
																{
																	TextMeshProExtensions.FixArabic(textMeshProUGUI2, text2);
																	flag12 = (byte)(int)text2 != 0;
																	obj16 = null;
																	goto IL_0f28;
																}
															}
															num = (nint)obj55;
															Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1165 @ X10_v22 (Il2CppClass<TMPro.TextMeshProUGUI>)+130]");
															obj31 = 0;
															object obj79 = obj44;
															Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1165 @ X10_v22 (Il2CppClass<TMPro.TextMeshProUGUI>)+130]");
															bool flag27 = (nint)obj79 < 0;
															object obj80 = !flag27;
															object obj81 = ~obj80;
															if (obj81 == null)
															{
																Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1445 @ X8_v87 (Il2CppClass<TMPro.TextMeshProUGUI>)+C8]");
																nint num13 = 0;
																Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1165 @ X10_v22 (Il2CppClass<TMPro.TextMeshProUGUI>)+130]");
																object obj82 = num13 + 0;
																Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1514 @ X8_v89-8]");
																if (0 == num)
																{
																	object obj83 = array2 - 1;
																	bool flag28 = obj83 == null;
																	obj27 = !flag28;
																	if ((nint)array2 <= 1)
																	{
																		if (array2 == null)
																		{
																			sprite = null;
																			goto IL_1adc;
																		}
																		if ((nint)array2 != 1)
																		{
																			goto IL_15dc;
																		}
																		object obj84 = 56;
																	}
																	else if ((nint)array2 != 3)
																	{
																		if ((nint)array2 != 2)
																		{
																			goto IL_15dc;
																		}
																		object obj84 = 64;
																	}
																	else
																	{
																		object obj84 = 72;
																	}
																	Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [this @ X0 (ReferralSuccessPopup)+v1574 @ X8_v92]");
																	sprite = (Sprite)0;
																	goto IL_1adc;
																}
															}
														}
														goto IL_0f28;
													}
												}
												goto IL_1564;
											}
											goto IL_158c;
											IL_0f28:
											bool flag29 = enumerator5 == null;
											obj26 = obj27;
											obj28 = obj29;
											obj30 = obj31;
											obj15 = obj16;
											num2 = num;
											enumerator8 = enumerator5;
											if (!flag29)
											{
												continue;
											}
											goto IL_0ee9;
											IL_1019:
											Cpp2ILHelpers.NoteDecompilerIssue("Method not found @B0D070");
											obj16 = null;
											goto IL_1a17;
											IL_1a17:
											Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1259 @ X0_v85+8]");
											flag12 = false;
											Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v1259 @ X0_v85] (should have been resolved before IL gen)");
											object obj85 = obj86 & 1;
											if (obj85 == null)
											{
												break;
											}
											if (enumerator5 == null)
											{
												goto IL_15b4;
											}
											nint num14 = (nint)enumerator5;
											Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1266 @ X8_v79 (Il2CppClass<System.Collections.IEnumerator>)+12E]");
											obj44 = 0;
											Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1266 @ X8_v79 (Il2CppClass<System.Collections.IEnumerator>)+12E]");
											if ((nint)0 == 0)
											{
												goto IL_111e;
											}
											Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1266 @ X8_v79 (Il2CppClass<System.Collections.IEnumerator>)+B0]");
											nint num15 = (nint)0 + (nint)8;
											while (true)
											{
												Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1305 @ X10_v26 (Il2CppClass<TMPro.TextMeshProUGUI>)-8]");
												obj31 = 0;
												Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1305 @ X10_v26 (Il2CppClass<TMPro.TextMeshProUGUI>)-8]");
												if (0 == (nint)obj33)
												{
													break;
												}
												num2 = num15 + 16;
												Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1266 @ X8_v79 (Il2CppClass<System.Collections.IEnumerator>)+12E]");
												obj44 = -1;
												bool flag30 = (nint)obj44 != 1;
												num15 = num2;
												if (flag30)
												{
													continue;
												}
												goto IL_111e;
											}
											obj44 = num15 + 1;
											object obj87 = num14 + obj44;
											object obj88 = obj87 + 312;
											num2 = num15;
											goto IL_1a90;
											IL_1adc:
											((Image)(object)textMeshProUGUI2).sprite = sprite;
											flag12 = (byte)(int)sprite != 0;
											obj16 = null;
											goto IL_0f28;
										}
										object obj89 = typeof(UnityEngine.TextCore.HorizontalAlignment) + 2344;
										flag12 = (byte)(int)obj89 != 0;
										Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1958");
										if (obj25 == null)
										{
											goto IL_1afb;
										}
										object obj90 = typeof(UnityEngine.TextCore.HorizontalAlignment) + 2344;
										object obj91 = obj25;
										Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1328 @ X8_v74+12E]");
										object obj92 = 0;
										Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1328 @ X8_v74+12E]");
										if ((nint)0 == 0)
										{
											goto IL_0c31;
										}
										Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1328 @ X8_v74+B0]");
										num2 = (nint)0 + (nint)8;
										while (true)
										{
											Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1332 @ X10_v12 (Il2CppClass<TMPro.TextMeshProUGUI>)-8]");
											obj31 = 0;
											Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1332 @ X10_v12 (Il2CppClass<TMPro.TextMeshProUGUI>)-8]");
											if (0 == (nint)obj90)
											{
												break;
											}
											num2 += 16;
											obj92--;
											if ((nint)obj92 != 1)
											{
												continue;
											}
											goto IL_0c31;
										}
										object obj93 = obj91 + num2;
										obj94 = obj93 + 312;
										goto IL_1b76;
									}
									NullReferenceException ex11 = new NullReferenceException();
									flag12 = false;
									obj15 = null;
								}
								else
								{
									NullReferenceException ex12 = new NullReferenceException();
									flag12 = (byte)(int)parent != 0;
								}
								goto IL_17a6;
							}
							object obj95 = (nint)0 + (nint)2272;
							flag3 = (byte)(int)obj95 != 0;
							enumerator3.Dispose();
							enumerator = (Dictionary<System.Int32Enum, int>.Enumerator)(&enumerator3);
							obj13 = 0;
							array3 = array2;
							enumerator4 = enumerator2;
							goto IL_170c;
						}
					}
				}
			}
		}
		goto IL_1928;
		IL_0ee9:
		NullReferenceException ex13 = new NullReferenceException();
		array = (object[])(&obj14);
		enumerator2 = (Dictionary<System.Int32Enum, int>.Enumerator)0;
		goto IL_17a6;
		IL_043c:
		object obj96 = (nint)0 + (nint)3864;
		array4 = (object[])obj96;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v388 @ X8_v13+8]");
		IEnumerable<object> source = Enumerable.Where((IEnumerable<object>)0, predicate);
		object[] array6 = Enumerable.ToArray(source);
		textMeshProUGUI = referralDescription;
		object obj97 = typeof(TypeConverter<ushort, char>) + 3400;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC18B4");
		bool flag31 = array6 == null;
		obj14 = 0;
		enumerator5 = null;
		enumerator3 = (Dictionary<System.Int32Enum, int>.Enumerator)0;
		enumerator4 = (Dictionary<System.Int32Enum, int>.Enumerator)0;
		flag3 = true;
		IndexOutOfRangeException ex14 = default(IndexOutOfRangeException);
		bool flag35;
		if (!flag31)
		{
			object obj98 = 153100288 + 1024;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC195C");
			object[] array7 = default(object[]);
			bool flag32 = array7 == null;
			obj14 = 0;
			enumerator5 = null;
			enumerator3 = (Dictionary<System.Int32Enum, int>.Enumerator)0;
			enumerator4 = (Dictionary<System.Int32Enum, int>.Enumerator)0;
			flag3 = (byte)(&enumerator2) != 0;
			if (!flag32)
			{
				object obj99 = default(object);
				bool flag33 = obj99 == null;
				flag12 = (byte)(&enumerator2) != 0;
				if (!flag33)
				{
					nint num16 = (nint)array7;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v629 @ X8_v116 (Il2CppClass<System.Object[]>)+40]");
					flag12 = false;
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1958");
					bool flag34 = ex14 == null;
					obj14 = 0;
					enumerator5 = null;
					enumerator3 = (Dictionary<System.Int32Enum, int>.Enumerator)0;
					enumerator4 = (Dictionary<System.Int32Enum, int>.Enumerator)0;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v629 @ X8_v116 (Il2CppClass<System.Object[]>)+40]");
					flag35 = false;
					obj33 = obj99;
					if (flag34)
					{
						goto IL_17d5;
					}
				}
				bool flag36 = array7.Length == 0;
				obj14 = 0;
				array = array2;
				enumerator5 = null;
				enumerator3 = (Dictionary<System.Int32Enum, int>.Enumerator)0;
				enumerator4 = (Dictionary<System.Int32Enum, int>.Enumerator)0;
				obj33 = obj99;
				if (!flag36)
				{
					object obj100 = array7 + 32;
					obj100 = obj99;
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
					object text3 = "WhiteSmoke" + 1984;
					TextMeshProExtensions.Localize(textMeshProUGUI, (string)text3, array7);
					object obj101 = typeof(ConditionalWeakTable<System.Net.HttpWebRequest, Mono.Http.NtlmSession>.CreateValueCallback) + 1888;
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
					object obj102 = (nint)0 + (nint)536;
					flag3 = (byte)(int)obj102 != 0;
					dictionary..ctor();
					_ = 0;
					object obj103 = array6.Length;
					bool flag37 = array6.Length < 1;
					text = null;
					array4 = array7;
					obj33 = obj99;
					if (flag37)
					{
						goto IL_092d;
					}
					obj33 = array6 + 32;
					bool flag38 = dictionary == null;
					obj14 = 0;
					enumerator5 = null;
					enumerator3 = (Dictionary<System.Int32Enum, int>.Enumerator)0;
					enumerator4 = (Dictionary<System.Int32Enum, int>.Enumerator)0;
					text = null;
					array4 = array7;
					textMeshProUGUI = (TextMeshProUGUI)(object)dictionary;
					if (flag38)
					{
						goto IL_1928;
					}
					object obj53 = (nint)0 + (nint)544;
					object obj104 = (nint)0 + (nint)568;
					object obj55 = default(object);
					object obj105 = obj55;
					object[] array8 = array7;
					string text4 = null;
					flag12 = (byte)(int)obj102 != 0;
					int num17 = (int)array7;
					object obj106 = 0;
					while (true)
					{
						bool flag39 = obj106 < obj103;
						object obj107 = !flag39;
						obj14 = 0;
						array = array2;
						enumerator5 = null;
						enumerator3 = (Dictionary<System.Int32Enum, int>.Enumerator)0;
						enumerator4 = (Dictionary<System.Int32Enum, int>.Enumerator)0;
						obj55 = obj105;
						text = text4;
						array4 = (object[])num17;
						obj44 = obj106;
						textMeshProUGUI = (TextMeshProUGUI)(object)dictionary;
						if (obj107 != null)
						{
							break;
						}
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v221 @ X23_v6+v545 @ X9_v40*8]");
						obj55 = 0;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v221 @ X23_v6+v545 @ X9_v40*8]");
						bool flag40 = (nint)0 == 0;
						obj14 = 0;
						enumerator5 = null;
						enumerator3 = (Dictionary<System.Int32Enum, int>.Enumerator)0;
						enumerator4 = (Dictionary<System.Int32Enum, int>.Enumerator)0;
						text = text4;
						flag3 = flag12;
						array4 = (object[])num17;
						obj44 = obj106;
						textMeshProUGUI = (TextMeshProUGUI)(object)dictionary;
						if (!flag40)
						{
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v510 @ X27_v8+18]");
							bool flag41 = dictionary.ContainsKey((System.Int32Enum)0);
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v510 @ X27_v8+18]");
							array8 = (object[])0;
							if (!flag41)
							{
								Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v510 @ X27_v8+1C]");
								num17 = 0;
							}
							else
							{
								Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v510 @ X27_v8+18]");
								int num18 = dictionary.get_Item((System.Int32Enum)0);
								Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v510 @ X27_v8+1C]");
								num17 = (int)((nint)0 + (nint)num18);
							}
							text4 = (string)obj104;
							dictionary.set_Item((System.Int32Enum)array8, num17);
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v24 @ X29_v1-58]");
							obj106 = (nint)0 + (nint)1;
							obj103 = array6.Length;
							bool flag42 = (nint)obj106 >= array6.Length;
							obj105 = obj55;
							flag12 = (byte)(int)array8 != 0;
							text = (string)obj104;
							flag3 = (byte)(int)array8 != 0;
							array4 = (object[])num17;
							obj44 = obj106;
							if (!flag42)
							{
								continue;
							}
							goto IL_092d;
						}
						goto IL_1928;
					}
				}
				goto IL_1936;
			}
		}
		goto IL_1928;
		IL_1936:
		ex14 = new IndexOutOfRangeException();
		array2 = array;
		flag35 = flag12;
		goto IL_17d5;
		IL_0c31:
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @B0D070");
		obj16 = null;
		object obj108 = default(object);
		obj94 = obj108;
		goto IL_1b76;
		IL_1b76:
		obj44 = obj94;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1348 @ X8_v75+8]");
		flag12 = false;
		Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v1348 @ X8_v75] (should have been resolved before IL gen)");
		goto IL_1afb;
		IL_170c:
		bool flag43 = (object)popup == null;
		array2 = array;
		if (!flag43)
		{
			popup.SlideFromTop();
			return;
		}
		goto IL_1928;
	}

	private Sprite GetSprite(ReferralRewardType prizeType)
	{
		//IL_00ce: Expected O, but got I4
		//IL_00db: Expected O, but got I
		//IL_00ea: Unknown result type (might be due to invalid IL or missing references)
		//IL_00ef: Expected O, but got Unknown
		//IL_0117: Unknown result type (might be due to invalid IL or missing references)
		//IL_011c: Expected O, but got Unknown
		//IL_00b6: Expected O, but got I4
		//IL_00c3: Expected O, but got I
		//IL_013f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0144: Expected O, but got Unknown
		//IL_0063: Expected O, but got I4
		//IL_0070: Expected O, but got I
		//IL_0171: Expected O, but got I
		switch (prizeType)
		{
		case ReferralRewardType.SubscriptionDays:
		{
			object obj7 = 56;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [this @ X0 (ReferralSuccessPopup)+v47 @ X8_v3]");
			return (Sprite)0;
		}
		case ReferralRewardType.Coins:
		{
			object obj6 = 64;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [this @ X0 (ReferralSuccessPopup)+v114 @ X8_v2]");
			return (Sprite)0;
		}
		case ReferralRewardType.None:
			return null;
		case ReferralRewardType.Item:
		{
			object obj5 = 72;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [this @ X0 (ReferralSuccessPopup)+v44 @ X8_v1]");
			return (Sprite)0;
		}
		default:
		{
			object obj = typeof(System.Buffers.Text.ParserHelpers) + 3712;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC17CC");
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC195C");
			object obj2 = typeof(Unity.Services.Authentication.Shared.ApiConfiguration) + 656;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC17CC");
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
			object obj3 = "placementId" + 1008;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC17CC");
			ArgumentOutOfRangeException ex = default(ArgumentOutOfRangeException);
			string paramName = default(string);
			object actualValue = default(object);
			ex..ctor(paramName, actualValue, null);
			object obj4 = (nint)0 + (nint)2104;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC17CC");
			return (Sprite)(object)new OutOfMemoryException();
		}
		}
	}

	public void RedeemReferral()
	{
		//IL_000f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0014: Expected O, but got Unknown
		//IL_002a: Expected O, but got I
		//IL_013b: Expected O, but got I4
		//IL_008a: Expected O, but got I
		//IL_01c1: Expected O, but got I4
		//IL_0169: Expected O, but got I
		//IL_0183: Expected O, but got I4
		//IL_00ec: Expected O, but got I
		//IL_01f9: Expected O, but got I
		//IL_0225: Expected O, but got I4
		object obj = typeof(System.Buffers.Text.ParserHelpers) + 3696;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [91E6575]");
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
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [8BE45A1]");
		object obj5 = (nint)0 & (nint)1;
		bool flag2 = obj5 == null;
		object obj6 = !flag2;
		if (obj6 != null)
		{
			goto IL_00a7;
		}
		goto IL_0191;
		IL_00dc:
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v78 @ X0_v19+B8]");
		object obj7 = 0;
		_ = 0;
		PopupUI popupUI = popup;
		goto IL_0101;
		IL_0101:
		popupUI.SlideToTop();
		return;
		IL_01d7:
		Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		object obj8 = obj;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v114 @ X0_v5+B8]");
		object obj9 = 0;
		_ = 0;
		popupUI = popup;
		bool flag3 = (object)popup == null;
		object obj10 = !flag3;
		if (obj10 == null)
		{
			throw new NullReferenceException();
		}
		goto IL_0101;
		IL_0074:
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [8BE45A1]");
		object obj11 = (nint)0 & (nint)1;
		if (obj11 != null)
		{
			goto IL_00a7;
		}
		goto IL_0191;
		IL_0191:
		_ = 1;
		object obj12 = obj;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v78 @ X0_v19+E4]");
		bool flag4 = (nint)0 == 0;
		object obj13 = !flag4;
		object obj14 = obj12;
		if (obj13 != null)
		{
			goto IL_00dc;
		}
		goto IL_01d7;
		IL_00a7:
		obj12 = obj;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v78 @ X0_v19+E4]");
		bool flag5 = (nint)0 == 0;
		obj14 = obj12;
		if (!flag5)
		{
			goto IL_00dc;
		}
		goto IL_01d7;
	}
}
